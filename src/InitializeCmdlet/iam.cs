using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamAccount.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamAccount")]
    public class InitializeIntersightIamAccount : PSCmdlet
    {
        public InitializeIntersightIamAccount()
        {
            ClassId = IamAccount.ClassIdEnum.IamAccount;
            ObjectType = IamAccount.ObjectTypeEnum.IamAccount;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamAccount.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the Intersight account. By default, name is same as the MoID of the account."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9][a-zA-Z0-9\\-]{0,61}[a-zA-Z0-9]$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamAccount.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamAccount initObject = new Intersight.Model.IamAccount();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamAccountExperience.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamAccountExperience")]
    public class InitializeIntersightIamAccountExperience : PSCmdlet
    {
        public InitializeIntersightIamAccountExperience()
        {
            ClassId = IamAccountExperience.ClassIdEnum.IamAccountExperience;
            ObjectType = IamAccountExperience.ObjectTypeEnum.IamAccountExperience;

        }
        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamAccountRelationship Account
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamAccountExperience.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.IamFeatureDefinition> Features
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamAccountExperience.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamAccountExperience initObject = new Intersight.Model.IamAccountExperience();
            if (this.MyInvocation.BoundParameters.ContainsKey("Account"))
            {
                initObject.Account = this.Account;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Features"))
            {
                initObject.Features = this.Features;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamAccountPermissions.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamAccountPermissions")]
    public class InitializeIntersightIamAccountPermissions : PSCmdlet
    {
        public InitializeIntersightIamAccountPermissions()
        {
            ClassId = IamAccountPermissions.ClassIdEnum.IamAccountPermissions;
            ObjectType = IamAccountPermissions.ObjectTypeEnum.IamAccountPermissions;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamAccountPermissions.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamAccountPermissions.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamAccountPermissions initObject = new Intersight.Model.IamAccountPermissions();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamAccountTags.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamAccountTags")]
    public class InitializeIntersightIamAccountTags : PSCmdlet
    {
        public InitializeIntersightIamAccountTags()
        {
            ClassId = IamAccountTags.ClassIdEnum.IamAccountTags;
            ObjectType = IamAccountTags.ObjectTypeEnum.IamAccountTags;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamAccountTags.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The string representation of a tag key."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Key
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamAccountTags.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The string representation of a tag value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Value
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamAccountTags initObject = new Intersight.Model.IamAccountTags();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Key"))
            {
                initObject.Key = this.Key;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Value"))
            {
                initObject.Value = this.Value;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamApiKey.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamApiKey")]
    public class InitializeIntersightIamApiKey : PSCmdlet
    {
        public InitializeIntersightIamApiKey()
        {
            AdminStatus = IamApiKey.AdminStatusEnum.Enable;
            ClassId = IamApiKey.ClassIdEnum.IamApiKey;
            HashAlgorithm = IamApiKey.HashAlgorithmEnum.SHA256;
            ObjectType = IamApiKey.ObjectTypeEnum.IamApiKey;
            SigningAlgorithm = IamApiKey.SigningAlgorithmEnum.RSASSAPKCS1V15;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Used to trigger the enable or disable action on the API key. These actions change the status of an API key.\n* `enable` - Used to enable a disabled API key/App Registration. If the API key/App Registration is already expired, this action has no effect.\n* `disable` - Used to disable an active API key/App Registration. If the API key/App Registration is already expired, this action has no effect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamApiKey.AdminStatusEnum AdminStatus
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamApiKey.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The expiration date of the API key which is set at the time of creation of the key. Its value can only be assigned a date that falls within the range determined by the maximum expiration time configured at the account level. The expiry date can be edited to be earlier or later, provided it stays within the designated expiry period. This period is determined by adding the 'startTime' property of the API key to the maximum expiry time configured at the account level."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime ExpiryDateTime
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The cryptographic hash algorithm to calculate the message digest.\n* `SHA256` - The SHA-256 cryptographic hash, as defined by NIST in FIPS 180-4.\n* `SHA384` - The SHA-384 cryptographic hash, as defined by NIST in FIPS 180-4.\n* `SHA512` - The SHA-512 cryptographic hash, as defined by NIST in FIPS 180-4.\n* `SHA512_224` - The SHA-512/224 cryptographic hash, as defined by NIST in FIPS 180-4.\n* `SHA512_256` - The SHA-512/256 cryptographic hash, as defined by NIST in FIPS 180-4."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamApiKey.HashAlgorithmEnum HashAlgorithm
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Used to mark the API key as a never-expiring API key."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsNeverExpiring
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The key generation specification provides the algorithm and the parameters required for this algorithm to generate a private key, public key pair. Supported key generation schemes include RSA, ECDSA and Edwards-Curve Digital Signature Algorithm (EdDSA)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.PkixKeyGenerationSpec KeySpec
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamApiKey.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Holds the private key for the API key."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PrivateKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The purpose of the API Key."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Purpose
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The signing algorithm used by the client to authenticate API requests to Intersight.\nThe signing algorithm must be compatible with the key generation specification.\n* `RSASSA-PKCS1-v1_5` - RSASSA-PKCS1-v1_5 is a RSA signature scheme specified in [RFC 8017](https://tools.ietf.org/html/rfc8017).RSASSA-PKCS1-v1_5 is included only for compatibility with existing applications.\n* `RSASSA-PSS` - RSASSA-PSS is a RSA signature scheme specified in [RFC 8017](https://tools.ietf.org/html/rfc8017).It combines the RSASP1 and RSAVP1 primitives with the EMSA-PSS encoding method.In the interest of increased robustness, RSASSA-PSS is required in new applications.\n* `Ed25519` - The Ed25519 signature algorithm, as specified in [RFC 8032](https://tools.ietf.org/html/rfc8032).Ed25519 is a public-key signature system with several attractive features, includingfast single-signature verification, very fast signing, fast key generation and high security level.\n* `Ecdsa` - The Elliptic Curve Digital Signature Standard (ECDSA), as defined by NIST in FIPS 186-4 and ANSI X9.62.The signature is encoded as a ASN.1 DER SEQUENCE with two INTEGERs (r and s), as defined in RFC3279.When using ECDSA signatures, configure the client to use the same signature encoding as specified on the server side.\n* `EcdsaP1363Format` - The Elliptic Curve Digital Signature Standard (ECDSA), as defined by NIST in FIPS 186-4 and ANSI X9.62.The signature is the raw concatenation of r and s, as defined in the ISO/IEC 7816-8 IEEE P.1363 standard.In that format, r and s are represented as unsigned, big endian numbers.Extra padding bytes (of value 0x00) is applied so that both r and s encodings have the same size.When using ECDSA signatures, configure the client to use the same signature encoding as specified on the server side."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamApiKey.SigningAlgorithmEnum SigningAlgorithm
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamApiKey initObject = new Intersight.Model.IamApiKey();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdminStatus"))
            {
                initObject.AdminStatus = this.AdminStatus;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ExpiryDateTime"))
            {
                initObject.ExpiryDateTime = this.ExpiryDateTime;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HashAlgorithm"))
            {
                initObject.HashAlgorithm = this.HashAlgorithm;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsNeverExpiring"))
            {
                initObject.IsNeverExpiring = this.IsNeverExpiring;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("KeySpec"))
            {
                initObject.KeySpec = this.KeySpec;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PrivateKey"))
            {
                initObject.PrivateKey = this.PrivateKey;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Purpose"))
            {
                initObject.Purpose = this.Purpose;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SigningAlgorithm"))
            {
                initObject.SigningAlgorithm = this.SigningAlgorithm;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamAppRegistration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamAppRegistration")]
    public class InitializeIntersightIamAppRegistration : PSCmdlet
    {
        public InitializeIntersightIamAppRegistration()
        {
            AdminStatus = IamAppRegistration.AdminStatusEnum.Enable;
            ClassId = IamAppRegistration.ClassIdEnum.IamAppRegistration;
            ClientType = IamAppRegistration.ClientTypeEnum.Public;
            ObjectType = IamAppRegistration.ObjectTypeEnum.IamAppRegistration;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Used to trigger the enable or disable action on the App Registration. These actions change the status of an App Registration.\n* `enable` - Used to enable a disabled API key/App Registration. If the API key/App Registration is already expired, this action has no effect.\n* `disable` - Used to disable an active API key/App Registration. If the API key/App Registration is already expired, this action has no effect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamAppRegistration.AdminStatusEnum AdminStatus
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamAppRegistration.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"App Registration name specified by user."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ClientName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The OAuth2 client secret.\nThe value of this property is generated when grantType includes 'client-credentials'.\nOtherwise, no client-secret is generated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ClientSecret
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of the OAuth2 client (public or confidential), as specified in https://tools.ietf.org/html/rfc6749#section-2.1.\n* `public` - Clients incapable of maintaining the confidentiality of their credentials.This includes clients executing on the device used by the resource owner,such as mobile applications, installed native application or a webbrowser-based application.\n* `confidential` - Clients capable of maintaining the confidentiality of their credentials.For example, this could be a client implemented on a secure server withrestricted access to the client credentials.To maintain the confidentiality of the OAuth2 credentials, two use cases areconsidered.1) The application is running as a service within Intersight. The application automatically   obtains the OAuth2 credentials when the application starts and the credentials are not   exposed to the end-user.   Because end-users (even account administrators) do not have access the OAuth2 credentials,   they cannot take the credentials with them when they leave their organization.2) The application is under the control of a \"trusted\" end-user. For example,   the end-user may create a native application running outside Intersight. The application   uses OAuth2 credentials to interact with the Intersight API. In that case, the Intersight   account administrator may generate OAuth2 credentials with a registered application   using \"client_credentials\" grant type.   In that case, the end-user is responsible for maintaining the confidentiality of the   OAuth2 credentials. If the end-user leaves the organization, you should revoke the   credentials and issue new Oauth2 credentials.Here is a possible workflow for handling OAuth2 tokens.1) User Alice (Intersight Account Administrator) logins to Intersight and deploys an Intersight   application that requires an OAuth2 token.2) Intersight automatically deploys the application. The application is assigned a OAuth2 token,   possibly linked to Alice. The application must NOT expose the OAuth2 secret to Alice, otherwise   Alice would be able to use the token after she leaves the company.3) The application can make API calls to Intersight using its assigned OAuth2 token. For example,   the application could make weekly scheduled API calls to Intersight.4) Separately, Alice may also get OAuth2 tokens that she can use to make API calls from the   Intersight SDK through the northbound API. In that case, Alice will get the associated OAuth2   secrets, but not the one assigned in step #2.5) Alice leaves the organization. The OAuth2 tokens assigned in step #2 must retain their validity   even after Alice has left the organization. Because the OAuth2 secrets were never shared with   Alice, there is no risk Alice can reuse the OAuth2 secrets.   On the other hand, the OAuth2 tokens assigned in step #4 must be invalidated because Alice had   the OAuth2 tokens in her possession."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamAppRegistration.ClientTypeEnum ClientType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the application."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The expiration date of the App Registration which is set at the time of its creation. Its value can only be assigned a date that falls within the range determined by the maximum expiration time configured at the account level. The expiry date can be edited to be earlier or later, provided it stays within the designated expiry period. This period is determined by adding the 'startTime' property of the App Registration to the maximum expiry time configured at the account level."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime ExpiryDateTime
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Used to mark the App Registration as a never-expiring App Registration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsNeverExpiring
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamAppRegistration.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> RedirectUris
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Set value to true to renew the client-secret. Applicable to client_credentials grant type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool RenewClientSecret
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Used to trigger update the revocationTimestamp value.\nIf UI sent updating request with the Revoke value is true, then update RevocationTimestamp."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Revoke
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamRole resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.IamRoleRelationship> Roles
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Set to true if consent screen needs to be shown during the OAuth login process.\nApplicable only for public AppRegistrations, means only 'authorization_code' grantType.\nNote that consent screen will be shown on each login."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool ShowConsentScreen
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamAppRegistration initObject = new Intersight.Model.IamAppRegistration();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdminStatus"))
            {
                initObject.AdminStatus = this.AdminStatus;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ClientName"))
            {
                initObject.ClientName = this.ClientName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ClientSecret"))
            {
                initObject.ClientSecret = this.ClientSecret;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ClientType"))
            {
                initObject.ClientType = this.ClientType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ExpiryDateTime"))
            {
                initObject.ExpiryDateTime = this.ExpiryDateTime;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsNeverExpiring"))
            {
                initObject.IsNeverExpiring = this.IsNeverExpiring;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RedirectUris"))
            {
                initObject.RedirectUris = this.RedirectUris;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RenewClientSecret"))
            {
                initObject.RenewClientSecret = this.RenewClientSecret;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Revoke"))
            {
                initObject.Revoke = this.Revoke;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Roles"))
            {
                initObject.Roles = this.Roles;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ShowConsentScreen"))
            {
                initObject.ShowConsentScreen = this.ShowConsentScreen;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamBannerMessage.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamBannerMessage")]
    public class InitializeIntersightIamBannerMessage : PSCmdlet
    {
        public InitializeIntersightIamBannerMessage()
        {
            ClassId = IamBannerMessage.ClassIdEnum.IamBannerMessage;
            ObjectType = IamBannerMessage.ObjectTypeEnum.IamBannerMessage;

        }
        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamAccountRelationship Account
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Contents of the banner message."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string BannerContents
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Whether or not to display the banner message."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool BannerDisplay
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Title of the banner message."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string BannerTitle
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamBannerMessage.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamBannerMessage.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamBannerMessage initObject = new Intersight.Model.IamBannerMessage();
            if (this.MyInvocation.BoundParameters.ContainsKey("Account"))
            {
                initObject.Account = this.Account;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BannerContents"))
            {
                initObject.BannerContents = this.BannerContents;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BannerDisplay"))
            {
                initObject.BannerDisplay = this.BannerDisplay;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BannerTitle"))
            {
                initObject.BannerTitle = this.BannerTitle;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamCertificate.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamCertificate")]
    public class InitializeIntersightIamCertificate : PSCmdlet
    {
        public InitializeIntersightIamCertificate()
        {
            ClassId = IamCertificate.ClassIdEnum.IamCertificate;
            ObjectType = IamCertificate.ObjectTypeEnum.IamCertificate;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User-input pem-encoded certificate, signed by a CAcert."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.X509Certificate Certificate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamCertificateRequest resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamCertificateRequestRelationship CertificateRequest
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamCertificate.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamCertificate.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamCertificate initObject = new Intersight.Model.IamCertificate();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Certificate"))
            {
                initObject.Certificate = this.Certificate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CertificateRequest"))
            {
                initObject.CertificateRequest = this.CertificateRequest;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamCertificateRequest.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamCertificateRequest")]
    public class InitializeIntersightIamCertificateRequest : PSCmdlet
    {
        public InitializeIntersightIamCertificateRequest()
        {
            ClassId = IamCertificateRequest.ClassIdEnum.IamCertificateRequest;
            ObjectType = IamCertificateRequest.ObjectTypeEnum.IamCertificateRequest;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamCertificate resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamCertificateRelationship Certificate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamCertificateRequest.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User input email address, an optional part of the subject of the certificate request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EmailAddress
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the certificate request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamCertificateRequest.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamPrivateKeySpec resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamPrivateKeySpecRelationship PrivateKeySpec
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Whether the user wants the generated CSR to be self-signed by the appliance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool SelfSigned
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The x.509 distinguished name of the subject of the certificate request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.PkixDistinguishedName Subject
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The x.509 subject alternate name values of the certificate request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.PkixSubjectAlternateName SubjectAlternateName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamCertificateRequest initObject = new Intersight.Model.IamCertificateRequest();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Certificate"))
            {
                initObject.Certificate = this.Certificate;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("EmailAddress"))
            {
                initObject.EmailAddress = this.EmailAddress;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PrivateKeySpec"))
            {
                initObject.PrivateKeySpec = this.PrivateKeySpec;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SelfSigned"))
            {
                initObject.SelfSigned = this.SelfSigned;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Subject"))
            {
                initObject.Subject = this.Subject;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SubjectAlternateName"))
            {
                initObject.SubjectAlternateName = this.SubjectAlternateName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamClientMeta.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamClientMeta")]
    public class InitializeIntersightIamClientMeta : PSCmdlet
    {
        public InitializeIntersightIamClientMeta()
        {
            ClassId = IamClientMeta.ClassIdEnum.IamClientMeta;
            ObjectType = IamClientMeta.ObjectTypeEnum.IamClientMeta;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamClientMeta.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Parsed device model from raw User-Agent."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string DeviceModel
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamClientMeta.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The value of the \"User-Agent\" HTTP header, as sent by the HTTP client when it initiate a session to Intersight. This can be used to identify the client operating system, browser type and browser version.\nExample - Mozilla/5.0 (Macintosh; Intel Mac OS X 10_14_5) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/75.0.3770.100 Safari/537.36\nIt is set when User successfully passed OAuth login flow and receives Access Token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string UserAgent
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamClientMeta initObject = new Intersight.Model.IamClientMeta();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DeviceModel"))
            {
                initObject.DeviceModel = this.DeviceModel;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("UserAgent"))
            {
                initObject.UserAgent = this.UserAgent;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamDomainGroup.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamDomainGroup")]
    public class InitializeIntersightIamDomainGroup : PSCmdlet
    {
        public InitializeIntersightIamDomainGroup()
        {
            ClassId = IamDomainGroup.ClassIdEnum.IamDomainGroup;
            ObjectType = IamDomainGroup.ObjectTypeEnum.IamDomainGroup;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamDomainGroup.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamDomainGroup.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamDomainGroup initObject = new Intersight.Model.IamDomainGroup();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamDomainNameInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamDomainNameInfo")]
    public class InitializeIntersightIamDomainNameInfo : PSCmdlet
    {
        public InitializeIntersightIamDomainNameInfo()
        {
            Action = IamDomainNameInfo.ActionEnum.Generate;
            ClassId = IamDomainNameInfo.ClassIdEnum.IamDomainNameInfo;
            ObjectType = IamDomainNameInfo.ObjectTypeEnum.IamDomainNameInfo;

        }
        // <summary>
        /// <para type="description">"Regenerate TXT record and validate TXT record.\n* `generate` - Generate TXT record for domain name ownership validation.\n* `verify` - Verify TXT record for domain name ownership validation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamDomainNameInfo.ActionEnum Action
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamDomainNameInfo.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Email domain name. When a user enters an email during login in the Intersight home page, the IdP is picked by matching this domain name with the email domain name for authentication."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$")]
        public string DomainName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamDomainNameInfo.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamDomainNameInfo initObject = new Intersight.Model.IamDomainNameInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("Action"))
            {
                initObject.Action = this.Action;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DomainName"))
            {
                initObject.DomainName = this.DomainName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamEndPointPasswordProperties.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamEndPointPasswordProperties")]
    public class InitializeIntersightIamEndPointPasswordProperties : PSCmdlet
    {
        public InitializeIntersightIamEndPointPasswordProperties()
        {
            ClassId = IamEndPointPasswordProperties.ClassIdEnum.IamEndPointPasswordProperties;
            ObjectType = IamEndPointPasswordProperties.ObjectTypeEnum.IamEndPointPasswordProperties;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamEndPointPasswordProperties.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enables password expiry on the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool EnablePasswordExpiry
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enables a strong password policy. Strong password requirements: A. The password must have a minimum of 8 and a maximum of 20 characters. B. The password must not contain the User's Name. C. The password must contain characters from three of the following four categories. 1) English uppercase characters (A through Z). 2) English lowercase characters (a through z). 3) Base 10 digits (0 through 9). 4) Non-alphabetic characters (! , @, #, $, %, ^, &, *, -, _, +, =)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool EnforceStrongPassword
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User password will always be sent to endpoint device. If the option is not selected, then user password will be sent to endpoint device for new users and if user password is changed for existing users."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool ForceSendPassword
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Time period until when you can use the existing password, after it expires."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long GracePeriod
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The duration after which the password will expire."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long NotificationPeriod
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamEndPointPasswordProperties.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Set time period for password expiration. Value should be greater than notification period and grace period."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 3650)]
        public long PasswordExpiryDuration
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Tracks password change history. Specifies in number of instances, that the new password was already used."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long PasswordHistory
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamEndPointPasswordProperties initObject = new Intersight.Model.IamEndPointPasswordProperties();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("EnablePasswordExpiry"))
            {
                initObject.EnablePasswordExpiry = this.EnablePasswordExpiry;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EnforceStrongPassword"))
            {
                initObject.EnforceStrongPassword = this.EnforceStrongPassword;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ForceSendPassword"))
            {
                initObject.ForceSendPassword = this.ForceSendPassword;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("GracePeriod"))
            {
                initObject.GracePeriod = this.GracePeriod;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NotificationPeriod"))
            {
                initObject.NotificationPeriod = this.NotificationPeriod;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PasswordExpiryDuration"))
            {
                initObject.PasswordExpiryDuration = this.PasswordExpiryDuration;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PasswordHistory"))
            {
                initObject.PasswordHistory = this.PasswordHistory;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamEndPointPrivilege.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamEndPointPrivilege")]
    public class InitializeIntersightIamEndPointPrivilege : PSCmdlet
    {
        public InitializeIntersightIamEndPointPrivilege()
        {
            ClassId = IamEndPointPrivilege.ClassIdEnum.IamEndPointPrivilege;
            ObjectType = IamEndPointPrivilege.ObjectTypeEnum.IamEndPointPrivilege;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamEndPointPrivilege.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamEndPointPrivilege.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamEndPointPrivilege initObject = new Intersight.Model.IamEndPointPrivilege();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamEndPointRole.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamEndPointRole")]
    public class InitializeIntersightIamEndPointRole : PSCmdlet
    {
        public InitializeIntersightIamEndPointRole()
        {
            ClassId = IamEndPointRole.ClassIdEnum.IamEndPointRole;
            ObjectType = IamEndPointRole.ObjectTypeEnum.IamEndPointRole;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamEndPointRole.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamEndPointRole.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamEndPointRole initObject = new Intersight.Model.IamEndPointRole();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamEndPointUser.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamEndPointUser")]
    public class InitializeIntersightIamEndPointUser : PSCmdlet
    {
        public InitializeIntersightIamEndPointUser()
        {
            ClassId = IamEndPointUser.ClassIdEnum.IamEndPointUser;
            ObjectType = IamEndPointUser.ObjectTypeEnum.IamEndPointUser;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamEndPointUser.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamEndPointUserRole resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.IamEndPointUserRoleRelationship> EndPointUserRole
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the user to be created on the endpoint. It can be any string that adheres to the following constraints. It can have alphanumeric characters, dots, underscores and hyphen. It cannot be more than 16 characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9\\._\\-]+$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamEndPointUser.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.OrganizationOrganizationRelationship Organization
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamEndPointUser initObject = new Intersight.Model.IamEndPointUser();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("EndPointUserRole"))
            {
                initObject.EndPointUserRole = this.EndPointUserRole;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Organization"))
            {
                initObject.Organization = this.Organization;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamEndPointUserInventory.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamEndPointUserInventory")]
    public class InitializeIntersightIamEndPointUserInventory : PSCmdlet
    {
        public InitializeIntersightIamEndPointUserInventory()
        {
            ClassId = IamEndPointUserInventory.ClassIdEnum.IamEndPointUserInventory;
            ObjectType = IamEndPointUserInventory.ObjectTypeEnum.IamEndPointUserInventory;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamEndPointUserInventory.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamEndPointUserInventory.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamEndPointUserInventory initObject = new Intersight.Model.IamEndPointUserInventory();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamEndPointUserPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamEndPointUserPolicy")]
    public class InitializeIntersightIamEndPointUserPolicy : PSCmdlet
    {
        public InitializeIntersightIamEndPointUserPolicy()
        {
            ClassId = IamEndPointUserPolicy.ClassIdEnum.IamEndPointUserPolicy;
            ObjectType = IamEndPointUserPolicy.ObjectTypeEnum.IamEndPointUserPolicy;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamEndPointUserPolicy.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamEndPointUserRole resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.IamEndPointUserRoleRelationship> EndPointUserRoles
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamEndPointUserPolicy.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.OrganizationOrganizationRelationship Organization
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Set password properties for endpoint users."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamEndPointPasswordProperties PasswordProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to policyAbstractConfigProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.PolicyAbstractConfigProfileRelationship> Profiles
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamEndPointUserPolicy initObject = new Intersight.Model.IamEndPointUserPolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndPointUserRoles"))
            {
                initObject.EndPointUserRoles = this.EndPointUserRoles;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Organization"))
            {
                initObject.Organization = this.Organization;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PasswordProperties"))
            {
                initObject.PasswordProperties = this.PasswordProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Profiles"))
            {
                initObject.Profiles = this.Profiles;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamEndPointUserPolicyInventory.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamEndPointUserPolicyInventory")]
    public class InitializeIntersightIamEndPointUserPolicyInventory : PSCmdlet
    {
        public InitializeIntersightIamEndPointUserPolicyInventory()
        {
            ClassId = IamEndPointUserPolicyInventory.ClassIdEnum.IamEndPointUserPolicyInventory;
            ObjectType = IamEndPointUserPolicyInventory.ObjectTypeEnum.IamEndPointUserPolicyInventory;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamEndPointUserPolicyInventory.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamEndPointUserPolicyInventory.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamEndPointUserPolicyInventory initObject = new Intersight.Model.IamEndPointUserPolicyInventory();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamEndPointUserRole.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamEndPointUserRole")]
    public class InitializeIntersightIamEndPointUserRole : PSCmdlet
    {
        public InitializeIntersightIamEndPointUserRole()
        {
            ClassId = IamEndPointUserRole.ClassIdEnum.IamEndPointUserRole;
            ObjectType = IamEndPointUserRole.ObjectTypeEnum.IamEndPointUserRole;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamEndPointUserRole.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enables the user account on the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Enabled
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamEndPointRole resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.IamEndPointRoleRelationship> EndPointRole
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamEndPointUser resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamEndPointUserRelationship EndPointUser
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamEndPointUserPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamEndPointUserPolicyRelationship EndPointUserPolicy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamEndPointUserRole.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The password must have a minimum of 8 and a maximum of 127 characters. For servers with IPMI user role enabled, the maximum length is limited to 20 characters. When strong password is enabled, must satisfy below requirements: A. The password must not contain the User's Name. B. The password must contain characters from three of the following four categories. 1) English uppercase characters (A through Z). 2) English lowercase characters (a through z). 3) Base 10 digits (0 through 9). 4) Non-alphabetic characters (! , @, #, $, %, ^, &, *, -, _, +, =)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9!@#$%^&\\*+-_=]+$")]
        public string Password
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamEndPointUserRole initObject = new Intersight.Model.IamEndPointUserRole();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Enabled"))
            {
                initObject.Enabled = this.Enabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndPointRole"))
            {
                initObject.EndPointRole = this.EndPointRole;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndPointUser"))
            {
                initObject.EndPointUser = this.EndPointUser;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndPointUserPolicy"))
            {
                initObject.EndPointUserPolicy = this.EndPointUserPolicy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Password"))
            {
                initObject.Password = this.Password;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamEndPointUserRoleInventory.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamEndPointUserRoleInventory")]
    public class InitializeIntersightIamEndPointUserRoleInventory : PSCmdlet
    {
        public InitializeIntersightIamEndPointUserRoleInventory()
        {
            ClassId = IamEndPointUserRoleInventory.ClassIdEnum.IamEndPointUserRoleInventory;
            ObjectType = IamEndPointUserRoleInventory.ObjectTypeEnum.IamEndPointUserRoleInventory;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamEndPointUserRoleInventory.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamEndPointUserRoleInventory.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The password must have a minimum of 8 and a maximum of 127 characters. For servers with IPMI user role enabled, the maximum length is limited to 20 characters. When strong password is enabled, must satisfy below requirements: A. The password must not contain the User's Name. B. The password must contain characters from three of the following four categories. 1) English uppercase characters (A through Z). 2) English lowercase characters (a through z). 3) Base 10 digits (0 through 9). 4) Non-alphabetic characters (! , @, #, $, %, ^, &, *, -, _, +, =)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9!@#$%^&\\*+-_=]+$")]
        public string Password
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamEndPointUserRoleInventory initObject = new Intersight.Model.IamEndPointUserRoleInventory();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Password"))
            {
                initObject.Password = this.Password;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamFailureDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamFailureDetails")]
    public class InitializeIntersightIamFailureDetails : PSCmdlet
    {
        public InitializeIntersightIamFailureDetails()
        {
            ClassId = IamFailureDetails.ClassIdEnum.IamFailureDetails;
            ObjectType = IamFailureDetails.ObjectTypeEnum.IamFailureDetails;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamFailureDetails.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamFailureDetails.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamFailureDetails initObject = new Intersight.Model.IamFailureDetails();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamFeatureDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamFeatureDefinition")]
    public class InitializeIntersightIamFeatureDefinition : PSCmdlet
    {
        public InitializeIntersightIamFeatureDefinition()
        {
            ClassId = IamFeatureDefinition.ClassIdEnum.IamFeatureDefinition;
            Feature = IamFeatureDefinition.FeatureEnum.IWO;
            ObjectType = IamFeatureDefinition.ObjectTypeEnum.IamFeatureDefinition;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamFeatureDefinition.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The beta feature that will be enabled for specific account.\n* `IWO` - Intersight Workflow Optimizer.\n* `Hitachi` - Support to claim Hitachi Storage arrays using the Intersight Orchestrator framework.\n* `KubernetesExtension` - Extension to the IKS and Adopted Clusters.\n* `NetAppIO` - Support to claim NetApp Storage arrays as IO targets.\n* `IvsPublicCloud` - Enables virtualization service for public clouds.\n* `TerraformCloud` - Enables an ability to create Terraform Cloud.\n* `WashingtonEFT` - Support for EFT customers to use Washington firmware images for upgrades.\n* `Solutions` - Support for managing solutions.\n* `IksBm` - Enables Intersight Kubernetes Service on Baremetal server.\n* `NexusCloud` - Enables Nexus Cloud services functionality.\n* `NexusCloudTrial` - Enables Nexus Cloud trial period.\n* `NexusCloudUpgradeAssist` - Enables Nexus Cloud upgrade assist.\n* `NexusCloudSustainability` - Enables Nexus Cloud sustainability.\n* `PlatformUIRefresh` - Enables platform refreshed UI with new service launcher.\n* `IksGpu` - Enables GPU support for Intersight Kubernetes Service.\n* `IwoAppServiceVerticalScaling` - Enables vertical Scaling of App Service Plans.\n* `IwoDataExporter` - Enables IWO Data Exporter component.\n* `NexusCloudTechPreviewGold` - Enable Nexus Cloud Preview of stable features, available for public consumption.\n* `NexusCloudTechPreviewSilver` - Enable Nexus Cloud Preview of beta features. This feature set is intended for consumption by internal audiences.\n* `NexusCloudTechPreviewBronze` - Enable Nexus Cloud Preview of features still in development. This feature set is intended for consumption by internal audiences.\n* `DisconnectedTargetAlarm` - Raise an alarm when a Target is disconnected from Intersight. Intersight is unable to manage disconnected Targets.\n* `AsAService` - Enable AsAService Preview of beta features. This feature set is intended for consumption by selective audiences.\n* `EMEA` - Enable all avaialble features on Intersight EMEA region.\n* `CrossPlatformNavigation` - Enable Cross-Platform Navigation on UI."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamFeatureDefinition.FeatureEnum Feature
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamFeatureDefinition.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamFeatureDefinition initObject = new Intersight.Model.IamFeatureDefinition();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Feature"))
            {
                initObject.Feature = this.Feature;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamGroupPermissionToRoles.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamGroupPermissionToRoles")]
    public class InitializeIntersightIamGroupPermissionToRoles : PSCmdlet
    {
        public InitializeIntersightIamGroupPermissionToRoles()
        {
            ClassId = IamGroupPermissionToRoles.ClassIdEnum.IamGroupPermissionToRoles;
            ObjectType = IamGroupPermissionToRoles.ObjectTypeEnum.IamGroupPermissionToRoles;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamGroupPermissionToRoles.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamGroupPermissionToRoles.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamGroupPermissionToRoles initObject = new Intersight.Model.IamGroupPermissionToRoles();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamIdp.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamIdp")]
    public class InitializeIntersightIamIdp : PSCmdlet
    {
        public InitializeIntersightIamIdp()
        {
            ClassId = IamIdp.ClassIdEnum.IamIdp;
            ObjectType = IamIdp.ObjectTypeEnum.IamIdp;
            Type = IamIdp.TypeEnum.Saml;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamIdp.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Email domain name of the user for this IdP. When a user enters an email during login in the Intersight home page, the IdP is picked by matching this domain name with the email domain name for authentication."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$")]
        public string DomainName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> DomainNames
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Setting that indicates whether 'Single Logout (SLO)' has been enabled for this IdP."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool EnableSingleLogout
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SAML metadata of the IdP."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Metadata
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the Identity Provider, for example Cisco, Okta, or OneID."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamIdp.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When users attempt the Account URL login with an unverified Domain Name, they get a warning stating that they are logging in using an unverified Domain Name. Enable the slider if you do not wish to see the warning message."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool SkipWarning
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Authentication protocol used by the IdP.\n* `saml` - Use SAML as the authentication protocol for sign-on.\n* `oidc` - Open ID connect to be used as an authentication protocol for sign-on.\n* `local` - The local authentication method to be used for sign-on. Local type is set to default for the Intersight Appliance IdP."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamIdp.TypeEnum Type
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamUserGroup resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.IamUserGroupRelationship> Usergroups
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamUser resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.IamUserRelationship> Users
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamIdp initObject = new Intersight.Model.IamIdp();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DomainName"))
            {
                initObject.DomainName = this.DomainName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DomainNames"))
            {
                initObject.DomainNames = this.DomainNames;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EnableSingleLogout"))
            {
                initObject.EnableSingleLogout = this.EnableSingleLogout;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Metadata"))
            {
                initObject.Metadata = this.Metadata;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SkipWarning"))
            {
                initObject.SkipWarning = this.SkipWarning;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Type"))
            {
                initObject.Type = this.Type;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Usergroups"))
            {
                initObject.Usergroups = this.Usergroups;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Users"))
            {
                initObject.Users = this.Users;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamIdpReference.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamIdpReference")]
    public class InitializeIntersightIamIdpReference : PSCmdlet
    {
        public InitializeIntersightIamIdpReference()
        {
            ClassId = IamIdpReference.ClassIdEnum.IamIdpReference;
            ObjectType = IamIdpReference.ObjectTypeEnum.IamIdpReference;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamIdpReference.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The flag represents if the second factor of authentication is required for Cisco IdP users."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool MultiFactorAuthentication
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamIdpReference.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamUserGroup resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.IamUserGroupRelationship> Usergroups
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamUser resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.IamUserRelationship> Users
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamIdpReference initObject = new Intersight.Model.IamIdpReference();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MultiFactorAuthentication"))
            {
                initObject.MultiFactorAuthentication = this.MultiFactorAuthentication;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Usergroups"))
            {
                initObject.Usergroups = this.Usergroups;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Users"))
            {
                initObject.Users = this.Users;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamIpAccessManagement.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamIpAccessManagement")]
    public class InitializeIntersightIamIpAccessManagement : PSCmdlet
    {
        public InitializeIntersightIamIpAccessManagement()
        {
            ClassId = IamIpAccessManagement.ClassIdEnum.IamIpAccessManagement;
            ObjectType = IamIpAccessManagement.ObjectTypeEnum.IamIpAccessManagement;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamIpAccessManagement.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Flag stores the state of IP address based access management. Access management is enabled when it's true."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Enable
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamIpAccessManagement.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamIpAccessManagement initObject = new Intersight.Model.IamIpAccessManagement();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Enable"))
            {
                initObject.Enable = this.Enable;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamIpAddress.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamIpAddress")]
    public class InitializeIntersightIamIpAddress : PSCmdlet
    {
        public InitializeIntersightIamIpAddress()
        {
            ClassId = IamIpAddress.ClassIdEnum.IamIpAddress;
            ObjectType = IamIpAddress.ObjectTypeEnum.IamIpAddress;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Trusted IP range's address. IP address, CIDR range, and IP address range formats are supported. For example '12.13.14.15', '12.13.14.0/24', and '12.13.14.15-12.13.14.200'. Reserved IP ranges '127.0.0.1', '10.0.0.0/8', '172.16.0.0/12', and '192.168.0.0/16' are not allowed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Address
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamIpAddress.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of Trusted IP address range."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamIpAddress.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamIpAddress initObject = new Intersight.Model.IamIpAddress();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Address"))
            {
                initObject.Address = this.Address;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamLdapBaseProperties.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamLdapBaseProperties")]
    public class InitializeIntersightIamLdapBaseProperties : PSCmdlet
    {
        public InitializeIntersightIamLdapBaseProperties()
        {
            BindMethod = IamLdapBaseProperties.BindMethodEnum.LoginCredentials;
            ClassId = IamLdapBaseProperties.ClassIdEnum.IamLdapBaseProperties;
            ObjectType = IamLdapBaseProperties.ObjectTypeEnum.IamLdapBaseProperties;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Role and locale information of the user."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9][a-zA-Z0-9\\-\\.]*[a-zA-Z0-9\\-]$")]
        public string Attribute
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Base Distinguished Name (DN). Starting point from where server will search for users and groups."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string BaseDn
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Distinguished Name (DN) of the user, that is used to authenticate against LDAP servers."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string BindDn
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Authentication method to access LDAP servers.\n* `LoginCredentials` - Requires the user credentials. If the bind process fails, then user is denied access.\n* `Anonymous` - Requires no username and password. If this option is selected and the LDAP server is configured for Anonymous logins, then the user gains access.\n* `ConfiguredCredentials` - Requires a known set of credentials to be specified for the initial bind process. If the initial bind process succeeds, then the distinguished name (DN) of the user name is queried and re-used for the re-binding process. If the re-binding process fails, then the user is denied access."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamLdapBaseProperties.BindMethodEnum BindMethod
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamLdapBaseProperties.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The IPv4 domain that all users must be in."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^(([a-zA-Z0-9])|([a-zA-Z0-9][a-zA-Z0-9\\.\\-]*[a-zA-Z0-9]))$")]
        public string Domain
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If enabled, the endpoint encrypts all information it sends to the LDAP server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool EnableEncryption
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If enabled, user authorization is also done at the group level for LDAP users not in the local user database."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool EnableGroupAuthorization
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If enabled, an extended search walks the chain of ancestry all the way to the root and returns all the groups and subgroups, each of those groups belong to recursively."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool EnableNestedGroupSearch
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Criteria to identify entries in search requests."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9(][a-zA-Z0-9_#@$%&\\-\\^|()*=:!,.]*[a-zA-Z0-9\\-)]$")]
        public string Filter
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Groups to which an LDAP entry belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9][a-zA-Z0-9_#@$%&\\-\\^]*[a-zA-Z0-9\\-]$")]
        public string GroupAttribute
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Search depth to look for a nested LDAP group in an LDAP group map."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 128)]
        public long NestedGroupSearchDepth
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamLdapBaseProperties.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The password of the user for initial bind process. It can be any string that adheres to the following constraints. It can have character except spaces, tabs, line breaks. It cannot be more than 254 characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[\\S+]{0,254}$")]
        public string Password
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"LDAP authentication timeout duration, in seconds."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Timeout
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamLdapBaseProperties initObject = new Intersight.Model.IamLdapBaseProperties();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Attribute"))
            {
                initObject.Attribute = this.Attribute;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BaseDn"))
            {
                initObject.BaseDn = this.BaseDn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BindDn"))
            {
                initObject.BindDn = this.BindDn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BindMethod"))
            {
                initObject.BindMethod = this.BindMethod;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Domain"))
            {
                initObject.Domain = this.Domain;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EnableEncryption"))
            {
                initObject.EnableEncryption = this.EnableEncryption;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EnableGroupAuthorization"))
            {
                initObject.EnableGroupAuthorization = this.EnableGroupAuthorization;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EnableNestedGroupSearch"))
            {
                initObject.EnableNestedGroupSearch = this.EnableNestedGroupSearch;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Filter"))
            {
                initObject.Filter = this.Filter;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("GroupAttribute"))
            {
                initObject.GroupAttribute = this.GroupAttribute;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NestedGroupSearchDepth"))
            {
                initObject.NestedGroupSearchDepth = this.NestedGroupSearchDepth;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Password"))
            {
                initObject.Password = this.Password;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Timeout"))
            {
                initObject.Timeout = this.Timeout;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamLdapConfigParams.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamLdapConfigParams")]
    public class InitializeIntersightIamLdapConfigParams : PSCmdlet
    {
        public InitializeIntersightIamLdapConfigParams()
        {
            ClassId = IamLdapConfigParams.ClassIdEnum.IamLdapConfigParams;
            ObjectType = IamLdapConfigParams.ObjectTypeEnum.IamLdapConfigParams;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamLdapConfigParams.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Stores the hostname based on which the issuer URL should be generated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ConfigHost
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamLdapConfigParams.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamLdapConfigParams initObject = new Intersight.Model.IamLdapConfigParams();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ConfigHost"))
            {
                initObject.ConfigHost = this.ConfigHost;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamLdapDnsParameters.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamLdapDnsParameters")]
    public class InitializeIntersightIamLdapDnsParameters : PSCmdlet
    {
        public InitializeIntersightIamLdapDnsParameters()
        {
            ClassId = IamLdapDnsParameters.ClassIdEnum.IamLdapDnsParameters;
            ObjectType = IamLdapDnsParameters.ObjectTypeEnum.IamLdapDnsParameters;
            Source = IamLdapDnsParameters.SourceEnum.Extracted;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamLdapDnsParameters.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamLdapDnsParameters.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Domain name that acts as a source for a DNS query."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^(([a-zA-Z0-9])|([a-zA-Z0-9][a-zA-Z0-9\\.\\-]*[a-zA-Z0-9]))$")]
        public string SearchDomain
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Forest name that acts as a source for a DNS query."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^(([a-zA-Z0-9])|([a-zA-Z0-9][a-zA-Z0-9\\.\\-]*[a-zA-Z0-9]))$")]
        public string SearchForest
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Source of the domain name used for the DNS SRV request.\n* `Extracted` - The domain name extracted-domain from the login ID.\n* `Configured` - The configured-search domain.\n* `ConfiguredExtracted` - The domain name extracted from the login ID than the configured-search domain."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamLdapDnsParameters.SourceEnum Source
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamLdapDnsParameters initObject = new Intersight.Model.IamLdapDnsParameters();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SearchDomain"))
            {
                initObject.SearchDomain = this.SearchDomain;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SearchForest"))
            {
                initObject.SearchForest = this.SearchForest;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Source"))
            {
                initObject.Source = this.Source;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamLdapGroup.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamLdapGroup")]
    public class InitializeIntersightIamLdapGroup : PSCmdlet
    {
        public InitializeIntersightIamLdapGroup()
        {
            ClassId = IamLdapGroup.ClassIdEnum.IamLdapGroup;
            ObjectType = IamLdapGroup.ObjectTypeEnum.IamLdapGroup;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamLdapGroup.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"LDAP server domain the Group resides in."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9-]+(.[a-zA-Z0-9-]+)*$")]
        public string Domain
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamEndPointRole resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.IamEndPointRoleRelationship> EndPointRole
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamLdapPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamLdapPolicyRelationship LdapPolicy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"LDAP Group name in the LDAP server database."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^([^+\\-][a-zA-Z0-9=!#$%()*+,-.:;@ _{|}~?&]*)$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamLdapGroup.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamLdapGroup initObject = new Intersight.Model.IamLdapGroup();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Domain"))
            {
                initObject.Domain = this.Domain;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndPointRole"))
            {
                initObject.EndPointRole = this.EndPointRole;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LdapPolicy"))
            {
                initObject.LdapPolicy = this.LdapPolicy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamLdapPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamLdapPolicy")]
    public class InitializeIntersightIamLdapPolicy : PSCmdlet
    {
        public InitializeIntersightIamLdapPolicy()
        {
            ClassId = IamLdapPolicy.ClassIdEnum.IamLdapPolicy;
            ObjectType = IamLdapPolicy.ObjectTypeEnum.IamLdapPolicy;
            UserSearchPrecedence = IamLdapPolicy.UserSearchPrecedenceEnum.LocalUserDb;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamAccountRelationship ApplianceAccount
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Base settings of LDAP required while configuring LDAP policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamLdapBaseProperties BaseProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamLdapPolicy.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Configuration settings to resolve LDAP servers, when DNS is enabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamLdapDnsParameters DnsParameters
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enables DNS to access LDAP servers."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool EnableDns
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"LDAP server performs authentication."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Enabled
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamLdapGroup resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.IamLdapGroupRelationship> Groups
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamLdapPolicy.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.OrganizationOrganizationRelationship Organization
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to policyAbstractConfigProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.PolicyAbstractConfigProfileRelationship> Profiles
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamLdapProvider resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.IamLdapProviderRelationship> Providers
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Search precedence between local user database and LDAP user database.\n* `LocalUserDb` - Precedence is given to local user database while searching.\n* `LDAPUserDb` - Precedence is given to LADP user database while searching."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamLdapPolicy.UserSearchPrecedenceEnum UserSearchPrecedence
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamLdapPolicy initObject = new Intersight.Model.IamLdapPolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ApplianceAccount"))
            {
                initObject.ApplianceAccount = this.ApplianceAccount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BaseProperties"))
            {
                initObject.BaseProperties = this.BaseProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DnsParameters"))
            {
                initObject.DnsParameters = this.DnsParameters;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EnableDns"))
            {
                initObject.EnableDns = this.EnableDns;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Enabled"))
            {
                initObject.Enabled = this.Enabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Groups"))
            {
                initObject.Groups = this.Groups;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Organization"))
            {
                initObject.Organization = this.Organization;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Profiles"))
            {
                initObject.Profiles = this.Profiles;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Providers"))
            {
                initObject.Providers = this.Providers;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UserSearchPrecedence"))
            {
                initObject.UserSearchPrecedence = this.UserSearchPrecedence;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamLdapProvider.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamLdapProvider")]
    public class InitializeIntersightIamLdapProvider : PSCmdlet
    {
        public InitializeIntersightIamLdapProvider()
        {
            ClassId = IamLdapProvider.ClassIdEnum.IamLdapProvider;
            ObjectType = IamLdapProvider.ObjectTypeEnum.IamLdapProvider;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamLdapProvider.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamLdapPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamLdapPolicyRelationship LdapPolicy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamLdapProvider.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"LDAP Server Port for connection establishment."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 65535)]
        public long Port
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"LDAP Server Address, can be IP address or hostname."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Server
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamLdapProvider initObject = new Intersight.Model.IamLdapProvider();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("LdapPolicy"))
            {
                initObject.LdapPolicy = this.LdapPolicy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Port"))
            {
                initObject.Port = this.Port;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Server"))
            {
                initObject.Server = this.Server;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamLocalUserPassword.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamLocalUserPassword")]
    public class InitializeIntersightIamLocalUserPassword : PSCmdlet
    {
        public InitializeIntersightIamLocalUserPassword()
        {
            ClassId = IamLocalUserPassword.ClassIdEnum.IamLocalUserPassword;
            ObjectType = IamLocalUserPassword.ObjectTypeEnum.IamLocalUserPassword;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamLocalUserPassword.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User-entered password to be compared to password for change password function."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string CurrentPassword
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Initial password set for the local user for the first time when the local user gets created or when the password gets reset by the Account Administrator."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string InitialPassword
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"New password that the user's password should be changed to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string NewPassword
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamLocalUserPassword.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User's current valid password."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public byte[] Password
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamLocalUserPassword initObject = new Intersight.Model.IamLocalUserPassword();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CurrentPassword"))
            {
                initObject.CurrentPassword = this.CurrentPassword;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InitialPassword"))
            {
                initObject.InitialPassword = this.InitialPassword;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NewPassword"))
            {
                initObject.NewPassword = this.NewPassword;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Password"))
            {
                initObject.Password = this.Password;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamLocalUserPasswordPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamLocalUserPasswordPolicy")]
    public class InitializeIntersightIamLocalUserPasswordPolicy : PSCmdlet
    {
        public InitializeIntersightIamLocalUserPasswordPolicy()
        {
            ClassId = IamLocalUserPasswordPolicy.ClassIdEnum.IamLocalUserPasswordPolicy;
            ObjectType = IamLocalUserPasswordPolicy.ObjectTypeEnum.IamLocalUserPasswordPolicy;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamLocalUserPasswordPolicy.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Determines if the user lock out feature must be enabled for the local admin user."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool EnableLockOutForAdminUser
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Seconds are tracked for consecutive incorrect login attempts. Users will be locked out if they exceed the max number of incorrect login attempts during this duration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(300, 3600)]
        public long FailedLoginTrackerWindow
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The time period, in seconds, during which a user account will remain locked."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(60, 3600)]
        public long LockOutTimePeriod
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Users will be locked out after exceeding the max consecutive incorrect login attempts allowed within the configured time duration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(3, 10)]
        public long MaxFailedLoginsAllowed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Minimum number of characters different from previous password."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MinCharDifference
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Minimum Days allowed between password change."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MinDaysBetweenPasswordChange
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Minimum length of password."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(8, 127)]
        public long MinLengthPassword
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Minimum number of required lower case characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 64)]
        public long MinLowerCase
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Minimum number of required numeric characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 64)]
        public long MinNumeric
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Minimum number of required special characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MinSpecialChar
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Minimum number of required upper case characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 64)]
        public long MinUpperCase
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of previous passwords disallowed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long NumPreviousPasswordsDisallowed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamLocalUserPasswordPolicy.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamLocalUserPasswordPolicy initObject = new Intersight.Model.IamLocalUserPasswordPolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("EnableLockOutForAdminUser"))
            {
                initObject.EnableLockOutForAdminUser = this.EnableLockOutForAdminUser;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FailedLoginTrackerWindow"))
            {
                initObject.FailedLoginTrackerWindow = this.FailedLoginTrackerWindow;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LockOutTimePeriod"))
            {
                initObject.LockOutTimePeriod = this.LockOutTimePeriod;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaxFailedLoginsAllowed"))
            {
                initObject.MaxFailedLoginsAllowed = this.MaxFailedLoginsAllowed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MinCharDifference"))
            {
                initObject.MinCharDifference = this.MinCharDifference;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MinDaysBetweenPasswordChange"))
            {
                initObject.MinDaysBetweenPasswordChange = this.MinDaysBetweenPasswordChange;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MinLengthPassword"))
            {
                initObject.MinLengthPassword = this.MinLengthPassword;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MinLowerCase"))
            {
                initObject.MinLowerCase = this.MinLowerCase;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MinNumeric"))
            {
                initObject.MinNumeric = this.MinNumeric;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MinSpecialChar"))
            {
                initObject.MinSpecialChar = this.MinSpecialChar;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MinUpperCase"))
            {
                initObject.MinUpperCase = this.MinUpperCase;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumPreviousPasswordsDisallowed"))
            {
                initObject.NumPreviousPasswordsDisallowed = this.NumPreviousPasswordsDisallowed;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamOAuthToken.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamOAuthToken")]
    public class InitializeIntersightIamOAuthToken : PSCmdlet
    {
        public InitializeIntersightIamOAuthToken()
        {
            ClassId = IamOAuthToken.ClassIdEnum.IamOAuthToken;
            ObjectType = IamOAuthToken.ObjectTypeEnum.IamOAuthToken;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamOAuthToken.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The identifier of the registered application to which the token belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ClientId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the registered application to which the token belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ClientName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamOAuthToken.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User Device meta information."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamClientMeta UserMeta
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamOAuthToken initObject = new Intersight.Model.IamOAuthToken();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ClientId"))
            {
                initObject.ClientId = this.ClientId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ClientName"))
            {
                initObject.ClientName = this.ClientName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UserMeta"))
            {
                initObject.UserMeta = this.UserMeta;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamPermission.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamPermission")]
    public class InitializeIntersightIamPermission : PSCmdlet
    {
        public InitializeIntersightIamPermission()
        {
            ClassId = IamPermission.ClassIdEnum.IamPermission;
            ObjectType = IamPermission.ObjectTypeEnum.IamPermission;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamPermission.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The informative description about each permission."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the permission which has to be granted to user."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_ .:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamPermission.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamResourceRoles resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.IamResourceRolesRelationship> ResourceRoles
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamRole resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.IamRoleRelationship> Roles
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamSessionLimits resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamSessionLimitsRelationship SessionLimits
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamUserGroup resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.IamUserGroupRelationship> UserGroups
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamUser resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.IamUserRelationship> Users
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamPermission initObject = new Intersight.Model.IamPermission();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ResourceRoles"))
            {
                initObject.ResourceRoles = this.ResourceRoles;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Roles"))
            {
                initObject.Roles = this.Roles;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SessionLimits"))
            {
                initObject.SessionLimits = this.SessionLimits;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UserGroups"))
            {
                initObject.UserGroups = this.UserGroups;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Users"))
            {
                initObject.Users = this.Users;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamPermissionReference.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamPermissionReference")]
    public class InitializeIntersightIamPermissionReference : PSCmdlet
    {
        public InitializeIntersightIamPermissionReference()
        {
            ClassId = IamPermissionReference.ClassIdEnum.IamPermissionReference;
            ObjectType = IamPermissionReference.ObjectTypeEnum.IamPermissionReference;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamPermissionReference.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamPermissionReference.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamPermissionReference initObject = new Intersight.Model.IamPermissionReference();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamPermissionToRoles.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamPermissionToRoles")]
    public class InitializeIntersightIamPermissionToRoles : PSCmdlet
    {
        public InitializeIntersightIamPermissionToRoles()
        {
            ClassId = IamPermissionToRoles.ClassIdEnum.IamPermissionToRoles;
            ObjectType = IamPermissionToRoles.ObjectTypeEnum.IamPermissionToRoles;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamPermissionToRoles.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamPermissionToRoles.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamPermissionToRoles initObject = new Intersight.Model.IamPermissionToRoles();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamPrivateKeySpec.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamPrivateKeySpec")]
    public class InitializeIntersightIamPrivateKeySpec : PSCmdlet
    {
        public InitializeIntersightIamPrivateKeySpec()
        {
            ClassId = IamPrivateKeySpec.ClassIdEnum.IamPrivateKeySpec;
            ObjectType = IamPrivateKeySpec.ObjectTypeEnum.IamPrivateKeySpec;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Algorithm used to generate the key pair and algorithm-speicifc parameters, such as RSA modulus size."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.PkixKeyGenerationSpec Algorithm
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamCertificateRequest resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamCertificateRequestRelationship CertificateRequest
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamPrivateKeySpec.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamPrivateKeySpec.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamPrivateKeySpec initObject = new Intersight.Model.IamPrivateKeySpec();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Algorithm"))
            {
                initObject.Algorithm = this.Algorithm;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CertificateRequest"))
            {
                initObject.CertificateRequest = this.CertificateRequest;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamPrivilege.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamPrivilege")]
    public class InitializeIntersightIamPrivilege : PSCmdlet
    {
        public InitializeIntersightIamPrivilege()
        {
            ClassId = IamPrivilege.ClassIdEnum.IamPrivilege;
            ObjectType = IamPrivilege.ObjectTypeEnum.IamPrivilege;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamPrivilege.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamPrivilege.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamPrivilege initObject = new Intersight.Model.IamPrivilege();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamPrivilegeSet.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamPrivilegeSet")]
    public class InitializeIntersightIamPrivilegeSet : PSCmdlet
    {
        public InitializeIntersightIamPrivilegeSet()
        {
            ClassId = IamPrivilegeSet.ClassIdEnum.IamPrivilegeSet;
            ObjectType = IamPrivilegeSet.ObjectTypeEnum.IamPrivilegeSet;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamPrivilegeSet.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the privilege set."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_ .:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamPrivilegeSet.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamPrivilegeSet initObject = new Intersight.Model.IamPrivilegeSet();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamQualifier.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamQualifier")]
    public class InitializeIntersightIamQualifier : PSCmdlet
    {
        public InitializeIntersightIamQualifier()
        {
            ClassId = IamQualifier.ClassIdEnum.IamQualifier;
            ObjectType = IamQualifier.ObjectTypeEnum.IamQualifier;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamQualifier.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamQualifier.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamUserGroup resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamUserGroupRelationship Usergroup
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> Value
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamQualifier initObject = new Intersight.Model.IamQualifier();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Usergroup"))
            {
                initObject.Usergroup = this.Usergroup;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Value"))
            {
                initObject.Value = this.Value;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamResourceLimits.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamResourceLimits")]
    public class InitializeIntersightIamResourceLimits : PSCmdlet
    {
        public InitializeIntersightIamResourceLimits()
        {
            ClassId = IamResourceLimits.ClassIdEnum.IamResourceLimits;
            ObjectType = IamResourceLimits.ObjectTypeEnum.IamResourceLimits;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Boolean value used to decide whether API keys that never expire are allowed for the account. This allows creation of API keys which are perpetual which can used for specific applications where rotation of API keys are not feasible."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool AllowApiKeysWithoutExpiry
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Boolean value used to decide whether App Registration that never expire are allowed for the account."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool AllowAppRegistrationsWithoutExpiry
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamResourceLimits.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The maximum expiration period (in seconds) allowed for API keys. The default value is 180 days or 15552000 seconds. It is shown to user in days for readability."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MaxApiKeyExpiry
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The maximum expiration period (in seconds) allowed for App Registration. The default value is 180 days or 15552000 seconds. It is shown to user in days for readability."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MaxAppRegistrationExpiry
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamResourceLimits.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamResourceLimits initObject = new Intersight.Model.IamResourceLimits();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AllowApiKeysWithoutExpiry"))
            {
                initObject.AllowApiKeysWithoutExpiry = this.AllowApiKeysWithoutExpiry;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AllowAppRegistrationsWithoutExpiry"))
            {
                initObject.AllowAppRegistrationsWithoutExpiry = this.AllowAppRegistrationsWithoutExpiry;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("MaxApiKeyExpiry"))
            {
                initObject.MaxApiKeyExpiry = this.MaxApiKeyExpiry;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaxAppRegistrationExpiry"))
            {
                initObject.MaxAppRegistrationExpiry = this.MaxAppRegistrationExpiry;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamResourcePermission.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamResourcePermission")]
    public class InitializeIntersightIamResourcePermission : PSCmdlet
    {
        public InitializeIntersightIamResourcePermission()
        {
            ClassId = IamResourcePermission.ClassIdEnum.IamResourcePermission;
            ObjectType = IamResourcePermission.ObjectTypeEnum.IamResourcePermission;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamResourcePermission.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamResourcePermission.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamResourcePermission initObject = new Intersight.Model.IamResourcePermission();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamResourceRole.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamResourceRole")]
    public class InitializeIntersightIamResourceRole : PSCmdlet
    {
        public InitializeIntersightIamResourceRole()
        {

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamResourceRole.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamResourceRole.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamResourceRole initObject = new Intersight.Model.IamResourceRole();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamResourceRoles.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamResourceRoles")]
    public class InitializeIntersightIamResourceRoles : PSCmdlet
    {
        public InitializeIntersightIamResourceRoles()
        {
            ClassId = IamResourceRoles.ClassIdEnum.IamResourceRoles;
            ObjectType = IamResourceRoles.ObjectTypeEnum.IamResourceRoles;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamResourceRoles.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamResourceRoles.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamPermission resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamPermissionRelationship Permission
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.MoBaseMoRelationship Resource
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamRole resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.IamRoleRelationship> Roles
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamResourceRoles initObject = new Intersight.Model.IamResourceRoles();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Permission"))
            {
                initObject.Permission = this.Permission;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Resource"))
            {
                initObject.Resource = this.Resource;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Roles"))
            {
                initObject.Roles = this.Roles;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamRole.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamRole")]
    public class InitializeIntersightIamRole : PSCmdlet
    {
        public InitializeIntersightIamRole()
        {
            ClassId = IamRole.ClassIdEnum.IamRole;
            ObjectType = IamRole.ObjectTypeEnum.IamRole;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamRole.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the role which has to be granted to user."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_ .:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamRole.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamRole initObject = new Intersight.Model.IamRole();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamRule.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamRule")]
    public class InitializeIntersightIamRule : PSCmdlet
    {
        public InitializeIntersightIamRule()
        {
            ClassId = IamRule.ClassIdEnum.IamRule;
            ObjectType = IamRule.ObjectTypeEnum.IamRule;
            RuleType = IamRule.RuleTypeEnum.Ip;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamRule.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The flag represents if IP addresses in the rule is IPv4 or IPv6."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IpV6
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamRule.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of the IP address. Currently three types are supported, ie IP, CIDR range and IP range.\n* `Ip` - The IP address rule type is IP.\n* `Cidr` - The IP address rule type is CIDR range.\n* `IpRange` - The IP address rule type is IP range."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamRule.RuleTypeEnum RuleType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> RuleValue
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamRule initObject = new Intersight.Model.IamRule();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("IpV6"))
            {
                initObject.IpV6 = this.IpV6;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RuleType"))
            {
                initObject.RuleType = this.RuleType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RuleValue"))
            {
                initObject.RuleValue = this.RuleValue;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamSamlSpConnection.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamSamlSpConnection")]
    public class InitializeIntersightIamSamlSpConnection : PSCmdlet
    {
        public InitializeIntersightIamSamlSpConnection()
        {
            ClassId = IamSamlSpConnection.ClassIdEnum.IamSamlSpConnection;
            ObjectType = IamSamlSpConnection.ObjectTypeEnum.IamSamlSpConnection;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamSamlSpConnection.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SingleLogout Services binding in IdP Metadata."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string IdentityProviderSloBinding
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SingleLogOut Services location in IdP Metadata."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string IdentityProviderSloUrl
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SingleSignOn Services binding in IdP Metadata."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string IdentityProviderSsoBinding
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SingleSignOn Services location in IdP Metadata."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string IdentityProviderSsoUrl
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Decoded Certificate from IdP Metatdata."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object IdpCertificateStore
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamSamlSpConnection.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"WantAuthnRequestsSigned from IdP Metadata."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool SignAuthnRequests
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamSamlSpConnection initObject = new Intersight.Model.IamSamlSpConnection();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("IdentityProviderSloBinding"))
            {
                initObject.IdentityProviderSloBinding = this.IdentityProviderSloBinding;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IdentityProviderSloUrl"))
            {
                initObject.IdentityProviderSloUrl = this.IdentityProviderSloUrl;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IdentityProviderSsoBinding"))
            {
                initObject.IdentityProviderSsoBinding = this.IdentityProviderSsoBinding;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IdentityProviderSsoUrl"))
            {
                initObject.IdentityProviderSsoUrl = this.IdentityProviderSsoUrl;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IdpCertificateStore"))
            {
                initObject.IdpCertificateStore = this.IdpCertificateStore;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SignAuthnRequests"))
            {
                initObject.SignAuthnRequests = this.SignAuthnRequests;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamSecurityContext.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamSecurityContext")]
    public class InitializeIntersightIamSecurityContext : PSCmdlet
    {
        public InitializeIntersightIamSecurityContext()
        {

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamSecurityContext.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamSecurityContext.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamSecurityContext initObject = new Intersight.Model.IamSecurityContext();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamSecurityHolder.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamSecurityHolder")]
    public class InitializeIntersightIamSecurityHolder : PSCmdlet
    {
        public InitializeIntersightIamSecurityHolder()
        {
            ClassId = IamSecurityHolder.ClassIdEnum.IamSecurityHolder;
            ObjectType = IamSecurityHolder.ObjectTypeEnum.IamSecurityHolder;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamSecurityHolder.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamSecurityHolder.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamSecurityHolder initObject = new Intersight.Model.IamSecurityHolder();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamServiceProvider.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamServiceProvider")]
    public class InitializeIntersightIamServiceProvider : PSCmdlet
    {
        public InitializeIntersightIamServiceProvider()
        {
            ClassId = IamServiceProvider.ClassIdEnum.IamServiceProvider;
            ObjectType = IamServiceProvider.ObjectTypeEnum.IamServiceProvider;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamServiceProvider.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamServiceProvider.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamSystem resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamSystemRelationship System
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamServiceProvider initObject = new Intersight.Model.IamServiceProvider();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("System"))
            {
                initObject.VarSystem = this.System;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamSession.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamSession")]
    public class InitializeIntersightIamSession : PSCmdlet
    {
        public InitializeIntersightIamSession()
        {
            ClassId = IamSession.ClassIdEnum.IamSession;
            ObjectType = IamSession.ObjectTypeEnum.IamSession;
            Status = IamSession.StatusEnum.Active;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamSession.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamSession.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Session token shared with the user agent which is used to identify the user session when API requests are received to perform authorization."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SessionId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The status of the session.\n* `Active` - The session is currently active.\n* `Ended` - The session has ended normally.\n* `Terminated` - The session was terminated by an admin."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamSession.StatusEnum Status
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamSession initObject = new Intersight.Model.IamSession();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SessionId"))
            {
                initObject.SessionId = this.SessionId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Status"))
            {
                initObject.Status = this.Status;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamSessionLimits.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamSessionLimits")]
    public class InitializeIntersightIamSessionLimits : PSCmdlet
    {
        public InitializeIntersightIamSessionLimits()
        {
            ClassId = IamSessionLimits.ClassIdEnum.IamSessionLimits;
            ObjectType = IamSessionLimits.ObjectTypeEnum.IamSessionLimits;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamSessionLimits.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The idle timeout interval for the web session in seconds. When a session is not refreshed for this duration, the session is marked as idle and removed. The minimum value is 300 seconds and the maximum value is 18000 seconds (5 hours). The system default value is 1800 seconds."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(300, 18000)]
        public long IdleTimeOut
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The maximum number of sessions allowed in an account or permission. The default value is 128."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 128)]
        public long MaximumLimit
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamSessionLimits.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The maximum number of sessions allowed per user. Default value is 32."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(2, 32)]
        public long PerUserLimit
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamPermission resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamPermissionRelationship Permission
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The session expiry duration in seconds. The minimum value is 350 seconds and the maximum value is 31536000 seconds (1 year). The system default value is 57600 seconds."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(300, 3.1536e+07)]
        public long SessionTimeOut
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamSessionLimits initObject = new Intersight.Model.IamSessionLimits();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("IdleTimeOut"))
            {
                initObject.IdleTimeOut = this.IdleTimeOut;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaximumLimit"))
            {
                initObject.MaximumLimit = this.MaximumLimit;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PerUserLimit"))
            {
                initObject.PerUserLimit = this.PerUserLimit;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Permission"))
            {
                initObject.Permission = this.Permission;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SessionTimeOut"))
            {
                initObject.SessionTimeOut = this.SessionTimeOut;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamSharingRule.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamSharingRule")]
    public class InitializeIntersightIamSharingRule : PSCmdlet
    {
        public InitializeIntersightIamSharingRule()
        {
            ClassId = IamSharingRule.ClassIdEnum.IamSharingRule;
            ObjectType = IamSharingRule.ObjectTypeEnum.IamSharingRule;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamSharingRule.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamSharingRule.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.MoBaseMoRelationship SharedResource
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.MoBaseMoRelationship SharedWithResource
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamSharingRule initObject = new Intersight.Model.IamSharingRule();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SharedResource"))
            {
                initObject.SharedResource = this.SharedResource;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SharedWithResource"))
            {
                initObject.SharedWithResource = this.SharedWithResource;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamSsoSessionAttributes.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamSsoSessionAttributes")]
    public class InitializeIntersightIamSsoSessionAttributes : PSCmdlet
    {
        public InitializeIntersightIamSsoSessionAttributes()
        {
            ClassId = IamSsoSessionAttributes.ClassIdEnum.IamSsoSessionAttributes;
            ObjectType = IamSsoSessionAttributes.ObjectTypeEnum.IamSsoSessionAttributes;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamSsoSessionAttributes.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamSsoSessionAttributes.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamSsoSessionAttributes initObject = new Intersight.Model.IamSsoSessionAttributes();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamSystem.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamSystem")]
    public class InitializeIntersightIamSystem : PSCmdlet
    {
        public InitializeIntersightIamSystem()
        {
            ClassId = IamSystem.ClassIdEnum.IamSystem;
            ObjectType = IamSystem.ObjectTypeEnum.IamSystem;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamSystem.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamSystem.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamServiceProvider resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamServiceProviderRelationship ServiceProvider
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamSystem initObject = new Intersight.Model.IamSystem();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ServiceProvider"))
            {
                initObject.ServiceProvider = this.ServiceProvider;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamTrustPoint.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamTrustPoint")]
    public class InitializeIntersightIamTrustPoint : PSCmdlet
    {
        public InitializeIntersightIamTrustPoint()
        {
            ClassId = IamTrustPoint.ClassIdEnum.IamTrustPoint;
            ObjectType = IamTrustPoint.ObjectTypeEnum.IamTrustPoint;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The certificate information for this trusted point. The certificate must be in Base64 encoded X.509 (CER) format."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Chain
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamTrustPoint.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamTrustPoint.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamTrustPoint initObject = new Intersight.Model.IamTrustPoint();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Chain"))
            {
                initObject.Chain = this.Chain;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamUser.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamUser")]
    public class InitializeIntersightIamUser : PSCmdlet
    {
        public InitializeIntersightIamUser()
        {
            ClassId = IamUser.ClassIdEnum.IamUser;
            ObjectType = IamUser.ObjectTypeEnum.IamUser;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamUser.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Email of the user. Remote users are added to Intersight using the email configured in the IdP."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$")]
        public string Email
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"First name of the user. For remote users, this field is populated from the IdP attributes received after authentication."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string FirstName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamIdp resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamIdpRelationship Idp
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamIdpReference resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamIdpReferenceRelationship Idpreference
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Last name of the user. For remote users, this field is populated from the IdP attributes received after authentication."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string LastName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamUser.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamPermission resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.IamPermissionRelationship> Permissions
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"UserID or email of the user. For remote users, it is the value as configured in the IDP."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string UserIdOrEmail
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamUser initObject = new Intersight.Model.IamUser();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Email"))
            {
                initObject.Email = this.Email;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FirstName"))
            {
                initObject.FirstName = this.FirstName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Idp"))
            {
                initObject.Idp = this.Idp;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Idpreference"))
            {
                initObject.Idpreference = this.Idpreference;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LastName"))
            {
                initObject.LastName = this.LastName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Permissions"))
            {
                initObject.Permissions = this.Permissions;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UserIdOrEmail"))
            {
                initObject.UserIdOrEmail = this.UserIdOrEmail;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamUserGroup.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamUserGroup")]
    public class InitializeIntersightIamUserGroup : PSCmdlet
    {
        public InitializeIntersightIamUserGroup()
        {
            ClassId = IamUserGroup.ClassIdEnum.IamUserGroup;
            ObjectType = IamUserGroup.ObjectTypeEnum.IamUserGroup;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamUserGroup.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamIdp resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamIdpRelationship Idp
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamIdpReference resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamIdpReferenceRelationship Idpreference
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the user group which the dynamic user belongs to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamUserGroup.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamPermission resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.IamPermissionRelationship> Permissions
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamQualifier resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamQualifierRelationship Qualifier
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamUserGroup initObject = new Intersight.Model.IamUserGroup();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Idp"))
            {
                initObject.Idp = this.Idp;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Idpreference"))
            {
                initObject.Idpreference = this.Idpreference;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Permissions"))
            {
                initObject.Permissions = this.Permissions;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Qualifier"))
            {
                initObject.Qualifier = this.Qualifier;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamUserPreference.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamUserPreference")]
    public class InitializeIntersightIamUserPreference : PSCmdlet
    {
        public InitializeIntersightIamUserPreference()
        {
            ClassId = IamUserPreference.ClassIdEnum.IamUserPreference;
            ObjectType = IamUserPreference.ObjectTypeEnum.IamUserPreference;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamUserPreference.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamUserPreference.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"UI preferences of the user."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Preference
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamUserPreference initObject = new Intersight.Model.IamUserPreference();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Preference"))
            {
                initObject.Preference = this.Preference;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamUserSetting.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamUserSetting")]
    public class InitializeIntersightIamUserSetting : PSCmdlet
    {
        public InitializeIntersightIamUserSetting()
        {
            ClassId = IamUserSetting.ClassIdEnum.IamUserSetting;
            ObjectType = IamUserSetting.ObjectTypeEnum.IamUserSetting;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"UI preference of the user for Session Recording."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool AllowUiSessionRecording
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamUserSetting.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public IamUserSetting.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.IamUserSetting initObject = new Intersight.Model.IamUserSetting();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AllowUiSessionRecording"))
            {
                initObject.AllowUiSessionRecording = this.AllowUiSessionRecording;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
}