using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Management.Automation;
using Intersight.Client;
using Intersight.Client.Auth;
using System.Security;
using System.Security.Cryptography;
using System.Net;
using Intersight.Api;
using System.IO;
using System.Runtime.InteropServices;

namespace Intersight.PowerShell
{
    /// <summary>
    /// Identifies the format of a PEM-encoded private key.
    /// </summary>
    public enum PemKeyFormat
    {
        Unknown,
        Pkcs1Rsa,               // -----BEGIN RSA PRIVATE KEY----- (no encryption headers)
        Sec1Ec,                 // -----BEGIN EC PRIVATE KEY-----
        Pkcs8Unencrypted,       // -----BEGIN PRIVATE KEY-----
        Pkcs8Encrypted,         // -----BEGIN ENCRYPTED PRIVATE KEY-----
        LegacyOpenSslEncrypted  // -----BEGIN RSA PRIVATE KEY----- + Proc-Type: 4,ENCRYPTED
    }

    /// <summary>
    /// Detects the PEM key format and normalises it to the PKCS#1 / SEC1 format
    /// that the generated SDK (HttpSigningConfiguration) expects.
    /// </summary>
    public static class PemKeyHelper
    {
        // ── Format detection ────────────────────────────────────────────────
        public static PemKeyFormat DetectKeyFormat(string pemContent)
        {
            if (string.IsNullOrWhiteSpace(pemContent))
                return PemKeyFormat.Unknown;

            if (pemContent.Contains("-----BEGIN ENCRYPTED PRIVATE KEY-----"))
                return PemKeyFormat.Pkcs8Encrypted;

            if (pemContent.Contains("-----BEGIN PRIVATE KEY-----"))
                return PemKeyFormat.Pkcs8Unencrypted;

            if (pemContent.Contains("-----BEGIN EC PRIVATE KEY-----"))
                return PemKeyFormat.Sec1Ec;

            if (pemContent.Contains("-----BEGIN RSA PRIVATE KEY-----"))
            {
                // Legacy OpenSSL encrypted keys have Proc-Type header
                if (Regex.IsMatch(pemContent, @"Proc-Type:\s*4,ENCRYPTED", RegexOptions.IgnoreCase))
                    return PemKeyFormat.LegacyOpenSslEncrypted;
                return PemKeyFormat.Pkcs1Rsa;
            }

            return PemKeyFormat.Unknown;
        }

        // ── Key normalisation ───────────────────────────────────────────────
        /// <summary>
        /// Converts the supplied PEM key to the legacy PKCS#1 (RSA) or SEC1 (EC)
        /// format the generated SDK expects.  Returns the PEM string unchanged
        /// when it is already in the correct format.
        /// </summary>
        public static string NormalizeKey(string pemContent, SecureString passPhrase)
        {
            var format = DetectKeyFormat(pemContent);
            switch (format)
            {
                case PemKeyFormat.Pkcs1Rsa:
                case PemKeyFormat.Sec1Ec:
                case PemKeyFormat.LegacyOpenSslEncrypted:
                    // Already in native format — pass through
                    return pemContent;

                case PemKeyFormat.Pkcs8Unencrypted:
                    return ConvertPkcs8UnencryptedToPkcs1(pemContent);

                case PemKeyFormat.Pkcs8Encrypted:
                    if (passPhrase == null || passPhrase.Length == 0)
                        throw new ArgumentException(
                            "The private key is encrypted (PKCS#8). Please provide the passphrase via -ApiKeyPassPhrase.");
                    return DecryptPkcs8ToPkcs1(pemContent, passPhrase);

                default:
                    throw new NotSupportedException(
                        $"Unrecognised PEM key format. Supported formats: PKCS#1 RSA, SEC1 EC, PKCS#8 unencrypted, PKCS#8 encrypted, Legacy OpenSSL encrypted RSA.");
            }
        }

        // ── PKCS#8 Unencrypted → PKCS#1 / SEC1 ────────────────────────────
        private static string ConvertPkcs8UnencryptedToPkcs1(string pem)
        {
            // Try RSA first, fall back to EC
            try
            {
                using var rsa = RSA.Create();
                rsa.ImportFromPem(pem);
                byte[] pkcs1 = rsa.ExportRSAPrivateKey();
                return PemEncode(pkcs1, "RSA PRIVATE KEY");
            }
            catch (CryptographicException)
            {
                // Not RSA — try EC
            }

            try
            {
                using var ec = ECDsa.Create();
                ec.ImportFromPem(pem);
                byte[] sec1 = ec.ExportECPrivateKey();
                return PemEncode(sec1, "EC PRIVATE KEY");
            }
            catch (CryptographicException ex)
            {
                throw new CryptographicException(
                    "Unable to import PKCS#8 unencrypted key as either RSA or EC.", ex);
            }
        }

        // ── PKCS#8 Encrypted → PKCS#1 / SEC1 ──────────────────────────────
        private static string DecryptPkcs8ToPkcs1(string pem, SecureString passPhrase)
        {
            string plainPassPhrase = SecureStringToString(passPhrase);
            ReadOnlySpan<char> passChars = plainPassPhrase.AsSpan();

            // Extract Base64 payload between the PEM markers
            string base64 = ExtractBase64(pem);
            byte[] der = Convert.FromBase64String(base64);

            // Try RSA first
            try
            {
                using var rsa = RSA.Create();
                rsa.ImportEncryptedPkcs8PrivateKey(passChars, der, out _);
                byte[] pkcs1 = rsa.ExportRSAPrivateKey();
                return PemEncode(pkcs1, "RSA PRIVATE KEY");
            }
            catch (CryptographicException)
            {
                // Not RSA — try EC
            }

            try
            {
                using var ec = ECDsa.Create();
                ec.ImportEncryptedPkcs8PrivateKey(passChars, der, out _);
                byte[] sec1 = ec.ExportECPrivateKey();
                return PemEncode(sec1, "EC PRIVATE KEY");
            }
            catch (CryptographicException ex)
            {
                throw new CryptographicException(
                    "Unable to decrypt PKCS#8 encrypted key. Verify the passphrase is correct.", ex);
            }
        }

        // ── Helpers ──────────────────────────────────────────────────────────
        private static string PemEncode(byte[] der, string label)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"-----BEGIN {label}-----");
            sb.AppendLine(Convert.ToBase64String(der, Base64FormattingOptions.InsertLineBreaks));
            sb.AppendLine($"-----END {label}-----");
            return sb.ToString();
        }

        private static string ExtractBase64(string pem)
        {
            var lines = pem.Split('\n');
            var sb = new StringBuilder();
            foreach (var line in lines)
            {
                var trimmed = line.Trim();
                if (trimmed.StartsWith("-----") || string.IsNullOrWhiteSpace(trimmed))
                    continue;
                sb.Append(trimmed);
            }
            return sb.ToString();
        }

        private static string SecureStringToString(SecureString secureString)
        {
            IntPtr ptr = IntPtr.Zero;
            try
            {
                ptr = Marshal.SecureStringToGlobalAllocUnicode(secureString);
                return Marshal.PtrToStringUni(ptr);
            }
            finally
            {
                if (ptr != IntPtr.Zero)
                    Marshal.ZeroFreeGlobalAllocUnicode(ptr);
            }
        }
    }

    public class ConfigInfo
    {
        public string BasePath { get; set; }
        public string GrantType { get; set; }
        public string ApiKeyId { get; set; }
        public string ApiKeyFilePath { get; set; }
        public string ApiKeyString { get; set; }
        public SecureString ApiKeyPassPhrase { get; set; }
        public WebProxy Proxy { get; set; }
        public string HashAlgorithm { get; set; }
        public List<string> HttpSigningHeader { get; set; }
        public int SignatureValidityPeriod { get; set; }
    }
    [Cmdlet(VerbsCommon.Set, "IntersightConfiguration", DefaultParameterSetName = "KeyPath")]
    public class SetConfigurationCmdlet : PSCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true)]
        public string BasePath { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ParameterSetName = "KeyPath")]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ParameterSetName = "KeyString")]
        public string ApiKeyId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ParameterSetName = "KeyPath")]
        public string ApiKeyFilePath { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ParameterSetName = "KeyString")]
        public string ApiKeyString { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ParameterSetName = "KeyPath")]
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ParameterSetName = "KeyString")]
        public String ApiKeyPassPhrase { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true)]
        public WebProxy Proxy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ParameterSetName = "KeyPath")]
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ParameterSetName = "KeyString")]
        [ValidateSet("sha256", "sha512")]
        public string HashAlgorithm { get; set; } = "sha256";

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ParameterSetName = "KeyPath")]
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ParameterSetName = "KeyString")]
        public List<string> HttpSigningHeader { get; set; } = new List<string> { "(request-target)", "Host", "Date", "Digest" };

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ParameterSetName = "KeyPath")]
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ParameterSetName = "KeyString")]
        public int SignatureValidityPeriod { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false)]
        public SwitchParameter SkipCertificateCheck { get; set; }

        // OAuth parameters. GrantType selects the flow and required values.
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ParameterSetName = "OAuth")]
        [ValidateSet("Application", "AccessCode", "Implicit", "Password")]
        public string GrantType { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ParameterSetName = "OAuth")]
        public string ClientId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ParameterSetName = "OAuth")]
        public string ClientSecret { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ParameterSetName = "OAuth")]
        public string OAuthTokenUrl { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ParameterSetName = "OAuth")]
        public string AuthorizationCode { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ParameterSetName = "OAuth")]
        public string RedirectUri { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ParameterSetName = "OAuth")]
        public string OAuthUserName { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ParameterSetName = "OAuth")]
        public string OAuthPassword { get; set; }

        // Bearer Token parameter
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ParameterSetName = "BearerToken")]
        public string BearerToken { get; set; }

        protected override void ProcessRecord()
        {
            var basePath = BasePath.TrimEnd('/');
            var config = new Configuration() { BasePath = basePath };
            var shouldValidateConfig = true;

            if (Proxy != null) config.Proxy = Proxy;
            CmdletBase.SkipCertificateCheck = SkipCertificateCheck.IsPresent;
            if (SkipCertificateCheck.IsPresent) config.RemoteCertificateValidationCallback = delegate { return true; };

            switch (ParameterSetName)
            {
                case "OAuth":
                    config.OAuthTokenUrl = string.IsNullOrEmpty(OAuthTokenUrl) ? basePath + "/iam/token" : OAuthTokenUrl;
                    config.OAuthClientId = ClientId;
                    config.OAuthClientSecret = ClientSecret;

                    switch (GrantType.ToLowerInvariant())
                    {
                        case "application":
                            if (string.IsNullOrEmpty(ClientSecret))
                                throw new Exception("ClientSecret is required for GrantType 'Application'.");
                            config.OAuthFlow = OAuthFlow.APPLICATION;
                            break;

                        case "accesscode":
                            config.OAuthFlow = OAuthFlow.ACCESS_CODE;
                            shouldValidateConfig = false;
                            if (string.IsNullOrEmpty(AuthorizationCode))
                                WriteWarning("AuthorizationCode is not provided. Provide it for ACCESS_CODE token exchange once the SDK supports it.");
                            if (string.IsNullOrEmpty(RedirectUri))
                                WriteWarning("RedirectUri is not provided. Provide it when using ACCESS_CODE flow with authorization code exchange.");
                            break;

                        case "implicit":
                            config.OAuthFlow = OAuthFlow.IMPLICIT;
                            shouldValidateConfig = false;
                            break;

                        case "password":
                            config.OAuthFlow = OAuthFlow.PASSWORD;
                            shouldValidateConfig = false;
                            if (string.IsNullOrEmpty(OAuthUserName) || string.IsNullOrEmpty(OAuthPassword))
                                WriteWarning("OAuthUserName and OAuthPassword should be provided for GrantType 'Password'.");
                            config.Username = OAuthUserName;
                            config.Password = OAuthPassword;
                            break;
                    }
                    break;

                case "BearerToken":
                    config.AccessToken = BearerToken;
                    break;

                default: // KeyPath or KeyString
                    config.HttpSigningConfiguration = BuildHttpSigningConfig();
                    break;
            }

            CmdletBase.Config = config;
            if (!shouldValidateConfig)
            {
                WriteWarning("Configuration is stored, but this OAuth grant type is not fully implemented in the current C# SDK authenticator. Validation is skipped.");
                return;
            }

            // Validate configuration
            try
            {
                new IamApi(config).GetIamAccountListWithHttpInfo();
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                if (msg.Contains("401") || msg.Contains("Unauthorized"))
                    throw new Exception("Invalid API Key or API Path. Check BasePath and credentials are configured correctly.", ex);
                if (msg.Contains("No such host is known"))
                    throw new Exception("Invalid BasePath (No such host is known).", ex);
                if (msg.Contains("The SSL connection could not be established"))
                    throw new Exception("Invalid SSL Certificates. Use SkipCertificateCheck for invalid SSL certificates.", ex);
                throw;
            }
        }

        private HttpSigningConfiguration BuildHttpSigningConfig()
        {
            if (ParameterSetName == "KeyPath" && !File.Exists(ApiKeyFilePath))
                throw new Exception($"API Key file not found: {ApiKeyFilePath}");
            if (ParameterSetName == "KeyString" && string.IsNullOrEmpty(ApiKeyString))
                throw new Exception("No API Key provided.");

            var httpConfig = new HttpSigningConfiguration
            {
                KeyId = ApiKeyId,
                HttpSigningHeader = HttpSigningHeader,
                HashAlgorithm = HashAlgorithm == "sha512" ? HashAlgorithmName.SHA512 : HashAlgorithmName.SHA256
            };

            // Read raw key content
            string rawKeyContent = ParameterSetName == "KeyPath"
                ? File.ReadAllText(ApiKeyFilePath)
                : ApiKeyString;

            // Build SecureString passphrase if provided
            SecureString securePassPhrase = null;
            if (!string.IsNullOrEmpty(ApiKeyPassPhrase))
            {
                securePassPhrase = new SecureString();
                foreach (char ch in ApiKeyPassPhrase) securePassPhrase.AppendChar(ch);
            }

            // Detect the original key format and normalise to PKCS#1/SEC1
            var originalFormat = PemKeyHelper.DetectKeyFormat(rawKeyContent);
            string normalizedKey = PemKeyHelper.NormalizeKey(rawKeyContent, securePassPhrase);

            // Always use KeyString with the normalised key so the SDK never re-reads
            // the file itself (which would fail for PKCS#8).
            httpConfig.KeyString = normalizedKey;

            // Only forward the passphrase for legacy OpenSSL encrypted format,
            // which is the only encrypted format the SDK natively handles.
            if (originalFormat == PemKeyFormat.LegacyOpenSslEncrypted && securePassPhrase != null)
                httpConfig.KeyPassPhrase = securePassPhrase;

            if (HttpSigningHeader.Contains("(expires)") && SignatureValidityPeriod <= 0)
                throw new Exception("SignatureValidityPeriod must be greater than 0 seconds.");
            httpConfig.SignatureValidityPeriod = SignatureValidityPeriod;

            return httpConfig;
        }
    }


    [Cmdlet(VerbsCommon.Get, "IntersightConfiguration")]
    public class GetConfigurationCmldet : PSCmdlet
    {
        protected override void ProcessRecord()
        {
            if (CmdletBase.Config != null)
            {
                ConfigInfo configInfo = new ConfigInfo();
                configInfo.BasePath = CmdletBase.Config.BasePath;
                if (CmdletBase.Config.OAuthFlow.HasValue)
                {
                    configInfo.GrantType = CmdletBase.Config.OAuthFlow.Value.ToString();
                }
                if (CmdletBase.Config.HttpSigningConfiguration != null)
                {
                    configInfo.ApiKeyId = CmdletBase.Config.HttpSigningConfiguration.KeyId;
                    configInfo.ApiKeyFilePath = CmdletBase.Config.HttpSigningConfiguration.KeyFilePath;
                    configInfo.ApiKeyPassPhrase = CmdletBase.Config.HttpSigningConfiguration.KeyPassPhrase;
                    configInfo.HttpSigningHeader = CmdletBase.Config.HttpSigningConfiguration.HttpSigningHeader;
                    configInfo.HashAlgorithm = CmdletBase.Config.HttpSigningConfiguration.HashAlgorithm.Name;
                    configInfo.SignatureValidityPeriod = CmdletBase.Config.HttpSigningConfiguration.SignatureValidityPeriod;
                    if (string.IsNullOrEmpty(CmdletBase.Config.HttpSigningConfiguration.KeyFilePath))
                    {
                        configInfo.ApiKeyString = CmdletBase.Config.HttpSigningConfiguration.KeyString;
                    }
                }

                configInfo.Proxy = CmdletBase.Config.Proxy;
                WriteObject(configInfo);
            }
        }
    }
}
