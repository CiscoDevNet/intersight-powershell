using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Client;
using Intersight.Client.Auth;
using System.Security;
using System.Security.Cryptography;
using System.Net;
using Intersight.Api;
using System.IO;

namespace Intersight.PowerShell
{
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

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ParameterSetName = "KeyPath")]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ParameterSetName = "KeyString")]
        public List<string> HttpSigningHeader { get; set; }

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
                new OrganizationApi(config).GetOrganizationOrganizationListWithHttpInfo();
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                if (ex.GetType().FullName == "System.IO.InvalidDataException")
                    throw new Exception("Check BasePath and credentials are configured correctly.", ex);
                if (msg.Contains("No such host is known"))
                    throw new Exception("Invalid BasePath (No such host is known).", ex);
                if (msg.Contains("The SSL connection could not be established"))
                    throw new Exception("Invalid SSL Certificates. Use SkipCertificateCheck for invalid SSL certificates.", ex);
                throw ex.InnerException ?? ex;
            }
        }

        private HttpSigningConfiguration BuildHttpSigningConfig()
        {
            if (!File.Exists(ApiKeyFilePath) && string.IsNullOrEmpty(ApiKeyString))
                throw new Exception("No API Key provided.");

            var httpConfig = new HttpSigningConfiguration
            {
                KeyId = ApiKeyId,
                HttpSigningHeader = HttpSigningHeader,
                HashAlgorithm = HashAlgorithm == "sha512" ? HashAlgorithmName.SHA512 : HashAlgorithmName.SHA256
            };

            if (ParameterSetName == "KeyPath") httpConfig.KeyFilePath = ApiKeyFilePath;
            else httpConfig.KeyString = ApiKeyString;

            if (HttpSigningHeader.Contains("(expires)") && SignatureValidityPeriod <= 0)
                throw new Exception("SignatureValidityPeriod must be greater than 0 seconds.");
            httpConfig.SignatureValidityPeriod = SignatureValidityPeriod;

            if (!string.IsNullOrEmpty(ApiKeyPassPhrase))
            {
                var secStr = new SecureString();
                foreach (char ch in ApiKeyPassPhrase) secStr.AppendChar(ch);
                httpConfig.KeyPassPhrase = secStr;
            }
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
