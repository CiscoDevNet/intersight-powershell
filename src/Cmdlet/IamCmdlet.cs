using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IamCertificate.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIamCertificate", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIamCertificate:GetCmdletBase
	{
		public GetIntersightIamCertificate()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "GetIamCertificateListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New IamCertificate.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightIamCertificate")]
    public class NewIntersightIamCertificate:NewCmdletBase
	{
		public NewIntersightIamCertificate()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamCertificate();
            MethodName = "CreateIamCertificateWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User-input pem-encoded certificate, signed by a CAcert."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public X509Certificate Certificate {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamCertificateRequest resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamCertificateRequestRelationship CertificateRequest {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set IamLdapGroup.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightIamLdapGroup")]
    public class SetIntersightIamLdapGroup:SetCmdletBase
	{
		public SetIntersightIamLdapGroup()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamLdapGroup();
            MethodName = "UpdateIamLdapGroupWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"LDAP server domain the Group resides in."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9-]+(.[a-zA-Z0-9-]+)*$")]
        public string Domain {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamEndPointRole resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<IamEndPointRoleRelationship> EndPointRole {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamLdapPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamLdapPolicyRelationship LdapPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"LDAP Group name in the LDAP server database."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^([^+\\-][a-zA-Z0-9=!#$%()*+,-.:;@ _{|}~?&]*)$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove IamLdapGroup.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightIamLdapGroup")]
    public class RemoveIntersightIamLdapGroup:RemoveCmdletBase
	{
		public RemoveIntersightIamLdapGroup()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "DeleteIamLdapGroupWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove IamOAuthToken.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightIamOAuthToken")]
    public class RemoveIntersightIamOAuthToken:RemoveCmdletBase
	{
		public RemoveIntersightIamOAuthToken()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "DeleteIamOAuthTokenWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set IamResourceRoles.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightIamResourceRoles")]
    public class SetIntersightIamResourceRoles:SetCmdletBase
	{
		public SetIntersightIamResourceRoles()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamResourceRoles();
            MethodName = "UpdateIamResourceRolesWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamPermission resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamPermissionRelationship Permission {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamRole resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<IamRoleRelationship> Roles {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove IamResourceRoles.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightIamResourceRoles")]
    public class RemoveIntersightIamResourceRoles:RemoveCmdletBase
	{
		public RemoveIntersightIamResourceRoles()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "DeleteIamResourceRolesWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IamUser.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIamUser", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIamUser:GetCmdletBase
	{
		public GetIntersightIamUser()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "GetIamUserListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New IamUser.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightIamUser")]
    public class NewIntersightIamUser:NewCmdletBase
	{
		public NewIntersightIamUser()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamUser();
            MethodName = "CreateIamUserWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Email of the user. Users are added to Intersight using the email configured in the IdP."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$")]
        public string Email {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamIdp resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamIdpRelationship Idp {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamIdpReference resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamIdpReferenceRelationship Idpreference {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamPermission resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<IamPermissionRelationship> Permissions {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"UserID or email as configured in the IdP."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string UserIdOrEmail {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IamSessionLimits.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIamSessionLimits", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIamSessionLimits:GetCmdletBase
	{
		public GetIntersightIamSessionLimits()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "GetIamSessionLimitsListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New IamSessionLimits.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightIamSessionLimits")]
    public class NewIntersightIamSessionLimits:NewCmdletBase
	{
		public NewIntersightIamSessionLimits()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamSessionLimits();
            MethodName = "CreateIamSessionLimitsWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The idle timeout interval for the web session in seconds. When a session is not refreshed for this duration, the session is marked as idle and removed. The minimum value is 300 seconds and the maximum value is 18000 seconds (5 hours). The system default value is 1800 seconds."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(300, 18000)]
        public long IdleTimeOut {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The maximum number of sessions allowed in an account or permission. The default value is 128."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 128)]
        public long MaximumLimit {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The maximum number of sessions allowed per user. Default value is 32."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(2, 32)]
        public long PerUserLimit {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamPermission resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamPermissionRelationship Permission {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The session expiry duration in seconds. The minimum value is 350 seconds and the maximum value is 31536000 seconds (1 year). The system default value is 57600 seconds."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(300, 3.1536e+07)]
        public long SessionTimeOut {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New IamLdapGroup.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightIamLdapGroup")]
    public class NewIntersightIamLdapGroup:NewCmdletBase
	{
		public NewIntersightIamLdapGroup()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamLdapGroup();
            MethodName = "CreateIamLdapGroupWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"LDAP server domain the Group resides in."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9-]+(.[a-zA-Z0-9-]+)*$")]
        public string Domain {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamEndPointRole resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<IamEndPointRoleRelationship> EndPointRole {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamLdapPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamLdapPolicyRelationship LdapPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"LDAP Group name in the LDAP server database."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^([^+\\-][a-zA-Z0-9=!#$%()*+,-.:;@ _{|}~?&]*)$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IamLdapGroup.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIamLdapGroup", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIamLdapGroup:GetCmdletBase
	{
		public GetIntersightIamLdapGroup()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "GetIamLdapGroupListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IamOAuthToken.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIamOAuthToken", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIamOAuthToken:GetCmdletBase
	{
		public GetIntersightIamOAuthToken()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "GetIamOAuthTokenListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove IamTrustPoint.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightIamTrustPoint")]
    public class RemoveIntersightIamTrustPoint:RemoveCmdletBase
	{
		public RemoveIntersightIamTrustPoint()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "DeleteIamTrustPointWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove IamAppRegistration.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightIamAppRegistration")]
    public class RemoveIntersightIamAppRegistration:RemoveCmdletBase
	{
		public RemoveIntersightIamAppRegistration()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "DeleteIamAppRegistrationWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set IamAppRegistration.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightIamAppRegistration")]
    public class SetIntersightIamAppRegistration:SetCmdletBase
	{
		public SetIntersightIamAppRegistration()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamAppRegistration();
            MethodName = "UpdateIamAppRegistrationWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"App Registration name specified by user."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ClientName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The OAuth2 client secret.\nThe value of this property is generated when grantType includes 'client-credentials'.\nOtherwise, no client-secret is generated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ClientSecret {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of the OAuth2 client (public or confidential), as specified in https://tools.ietf.org/html/rfc6749#section-2.1.\n* `public` - Clients incapable of maintaining the confidentiality of their credentials.This includes clients executing on the device used by the resource owner,such as mobile applications, installed native application or a webbrowser-based application.\n* `confidential` - Clients capable of maintaining the confidentiality of their credentials.For example, this could be a client implemented on a secure server withrestricted access to the client credentials.To maintain the confidentiality of the OAuth2 credentials, two use cases areconsidered.1) The application is running as a service within Intersight. The application automatically   obtains the OAuth2 credentials when the application starts and the credentials are not   exposed to the end-user.   Because end-users (even account administrators) do not have access the OAuth2 credentials,   they cannot take the credentials with them when they leave their organization.2) The application is under the control of a \"trusted\" end-user. For example,   the end-user may create a native application running outside Intersight. The application   uses OAuth2 credentials to interact with the Intersight API. In that case, the Intersight   account administrator may generate OAuth2 credentials with a registered application   using \"client_credentials\" grant type.   In that case, the end-user is responsible for maintaining the confidentiality of the   OAuth2 credentials. If the end-user leaves the organization, you should revoke the   credentials and issue new Oauth2 credentials.Here is a possible workflow for handling OAuth2 tokens.1) User Alice (Intersight Account Administrator) logins to Intersight and deploys an Intersight   application that requires an OAuth2 token.2) Intersight automatically deploys the application. The application is assigned a OAuth2 token,   possibly linked to Alice. The application must NOT expose the OAuth2 secret to Alice, otherwise   Alice would be able to use the token after she leaves the company.3) The application can make API calls to Intersight using its assigned OAuth2 token. For example,   the application could make weekly scheduled API calls to Intersight.4) Separately, Alice may also get OAuth2 tokens that she can use to make API calls from the   Intersight SDK through the northbound API. In that case, Alice will get the associated OAuth2   secrets, but not the one assigned in step #2.5) Alice leaves the organization. The OAuth2 tokens assigned in step #2 must retain their validity   even after Alice has left the organization. Because the OAuth2 secrets were never shared with   Alice, there is no risk Alice can reuse the OAuth2 secrets.   On the other hand, the OAuth2 tokens assigned in step #4 must be invalidated because Alice had   the OAuth2 tokens in her possession."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamAppRegistration.ClientTypeEnum ClientType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the application."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> GrantTypes {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> RedirectUris {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Set value to true to renew the client-secret. Applicable to client_credentials grant type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool RenewClientSecret {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> ResponseTypes {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Used to trigger update the revocationTimestamp value.\nIf UI sent updating request with the Revoke value is true, then update RevocationTimestamp."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Revoke {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamRole resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<IamRoleRelationship> Roles {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IamDomainGroup.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIamDomainGroup", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIamDomainGroup:GetCmdletBase
	{
		public GetIntersightIamDomainGroup()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "GetIamDomainGroupListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove IamApiKey.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightIamApiKey")]
    public class RemoveIntersightIamApiKey:RemoveCmdletBase
	{
		public RemoveIntersightIamApiKey()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "DeleteIamApiKeyWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set IamApiKey.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightIamApiKey")]
    public class SetIntersightIamApiKey:SetCmdletBase
	{
		public SetIntersightIamApiKey()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamApiKey();
            MethodName = "UpdateIamApiKeyWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The cryptographic hash algorithm to calculate the message digest.\n* `SHA256` - The SHA-256 cryptographic hash, as defined by NIST in FIPS 180-4.\n* `SHA384` - The SHA-384 cryptographic hash, as defined by NIST in FIPS 180-4.\n* `SHA512` - The SHA-512 cryptographic hash, as defined by NIST in FIPS 180-4.\n* `SHA512_224` - The SHA-512/224 cryptographic hash, as defined by NIST in FIPS 180-4.\n* `SHA512_256` - The SHA-512/256 cryptographic hash, as defined by NIST in FIPS 180-4."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamApiKey.HashAlgorithmEnum HashAlgorithm {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The key generation specification provides the algorithm and the parameters required for this algorithm to generate a private key, public key pair. Supported key generation schemes include RSA, ECDSA and Edwards-Curve Digital Signature Algorithm (EdDSA)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PkixKeyGenerationSpec KeySpec {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Holds the private key for the API key."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PrivateKey {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The purpose of the API Key."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Purpose {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The signing algorithm used by the client to authenticate API requests to Intersight.\nThe signing algorithm must be compatible with the key generation specification.\n* `RSASSA-PKCS1-v1_5` - RSASSA-PKCS1-v1_5 is a RSA signature scheme specified in [RFC 8017](https://tools.ietf.org/html/rfc8017).RSASSA-PKCS1-v1_5 is included only for compatibility with existing applications.\n* `RSASSA-PSS` - RSASSA-PSS is a RSA signature scheme specified in [RFC 8017](https://tools.ietf.org/html/rfc8017).It combines the RSASP1 and RSAVP1 primitives with the EMSA-PSS encoding method.In the interest of increased robustness, RSASSA-PSS is required in new applications.\n* `Ed25519` - The Ed25519 signature algorithm, as specified in [RFC 8032](https://tools.ietf.org/html/rfc8032).Ed25519 is a public-key signature system with several attractive features, includingfast single-signature verification, very fast signing, fast key generation and high security level.\n* `Ecdsa` - The Elliptic Curve Digital Signature Standard (ECDSA), as defined by NIST in FIPS 186-4 and ANSI X9.62.The signature is encoded as a ASN.1 DER SEQUENCE with two INTEGERs (r and s), as defined in RFC3279.When using ECDSA signatures, configure the client to use the same signature encoding as specified on the server side.\n* `EcdsaP1363Format` - The Elliptic Curve Digital Signature Standard (ECDSA), as defined by NIST in FIPS 186-4 and ANSI X9.62.The signature is the raw concatenation of r and s, as defined in the ISO/IEC 7816-8 IEEE P.1363 standard.In that format, r and s are represented as unsigned, big endian numbers.Extra padding bytes (of value 0x00) is applied so that both r and s encodings have the same size.When using ECDSA signatures, configure the client to use the same signature encoding as specified on the server side."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamApiKey.SigningAlgorithmEnum SigningAlgorithm {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IamEndPointRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIamEndPointRole", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIamEndPointRole:GetCmdletBase
	{
		public GetIntersightIamEndPointRole()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "GetIamEndPointRoleListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IamBannerMessage.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIamBannerMessage", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIamBannerMessage:GetCmdletBase
	{
		public GetIntersightIamBannerMessage()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "GetIamBannerMessageListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set IamSessionLimits.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightIamSessionLimits")]
    public class SetIntersightIamSessionLimits:SetCmdletBase
	{
		public SetIntersightIamSessionLimits()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamSessionLimits();
            MethodName = "UpdateIamSessionLimitsWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The idle timeout interval for the web session in seconds. When a session is not refreshed for this duration, the session is marked as idle and removed. The minimum value is 300 seconds and the maximum value is 18000 seconds (5 hours). The system default value is 1800 seconds."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(300, 18000)]
        public long IdleTimeOut {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The maximum number of sessions allowed in an account or permission. The default value is 128."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 128)]
        public long MaximumLimit {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The maximum number of sessions allowed per user. Default value is 32."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(2, 32)]
        public long PerUserLimit {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamPermission resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamPermissionRelationship Permission {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The session expiry duration in seconds. The minimum value is 350 seconds and the maximum value is 31536000 seconds (1 year). The system default value is 57600 seconds."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(300, 3.1536e+07)]
        public long SessionTimeOut {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove IamSessionLimits.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightIamSessionLimits")]
    public class RemoveIntersightIamSessionLimits:RemoveCmdletBase
	{
		public RemoveIntersightIamSessionLimits()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "DeleteIamSessionLimitsWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IamTrustPoint.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIamTrustPoint", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIamTrustPoint:GetCmdletBase
	{
		public GetIntersightIamTrustPoint()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "GetIamTrustPointListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New IamTrustPoint.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightIamTrustPoint")]
    public class NewIntersightIamTrustPoint:NewCmdletBase
	{
		public NewIntersightIamTrustPoint()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamTrustPoint();
            MethodName = "CreateIamTrustPointWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<X509Certificate> Certificates {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The certificate information for this trusted point. The certificate must be in Base64 encoded X.509 (CER) format."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Chain {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set IamCertificateRequest.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightIamCertificateRequest")]
    public class SetIntersightIamCertificateRequest:SetCmdletBase
	{
		public SetIntersightIamCertificateRequest()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamCertificateRequest();
            MethodName = "UpdateIamCertificateRequestWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamCertificate resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamCertificateRelationship Certificate {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User input email address, an optional part of the subject of the certificate request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string EmailAddress {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the certificate request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamPrivateKeySpec resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamPrivateKeySpecRelationship PrivateKeySpec {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Whether the user wants the generated CSR to be self-signed by the appliance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool SelfSigned {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The x.509 distinguished name of the subject of the certificate request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PkixDistinguishedName Subject {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The x.509 subject alternate name values of the certificate request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PkixSubjectAlternateName SubjectAlternateName {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove IamCertificateRequest.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightIamCertificateRequest")]
    public class RemoveIntersightIamCertificateRequest:RemoveCmdletBase
	{
		public RemoveIntersightIamCertificateRequest()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "DeleteIamCertificateRequestWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New IamAccount.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightIamAccount")]
    public class NewIntersightIamAccount:NewCmdletBase
	{
		public NewIntersightIamAccount()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamAccount();
            MethodName = "CreateIamAccountWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the Intersight account. By default, name is same as the MoID of the account."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9][a-zA-Z0-9\\-]{0,61}[a-zA-Z0-9]$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IamAccount.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIamAccount", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIamAccount:GetCmdletBase
	{
		public GetIntersightIamAccount()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "GetIamAccountListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set IamUserPreference.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightIamUserPreference")]
    public class SetIntersightIamUserPreference:SetCmdletBase
	{
		public SetIntersightIamUserPreference()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamUserPreference();
            MethodName = "UpdateIamUserPreferenceWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"UI preferences of the user."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object Preference {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set IamLocalUserPasswordPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightIamLocalUserPasswordPolicy")]
    public class SetIntersightIamLocalUserPasswordPolicy:SetCmdletBase
	{
		public SetIntersightIamLocalUserPasswordPolicy()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamLocalUserPasswordPolicy();
            MethodName = "UpdateIamLocalUserPasswordPolicyWithHttpInfo";
		}
        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamAccountRelationship Account {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Minimum number of characters different from previous password."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MinCharDifference {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Minimum Days allowed between password change."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MinDaysBetweenPasswordChange {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Minimum length of password."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(8, 127)]
        public long MinLengthPassword {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Minimum number of required lower case characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 64)]
        public long MinLowerCase {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Minimum number of required numeric characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 64)]
        public long MinNumeric {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Minimum number of required special characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MinSpecialChar {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Minimum number of required upper case characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 64)]
        public long MinUpperCase {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of previous passwords disallowed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NumPreviousPasswordsDisallowed {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IamPrivilege.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIamPrivilege", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIamPrivilege:GetCmdletBase
	{
		public GetIntersightIamPrivilege()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "GetIamPrivilegeListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set IamIpAddress.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightIamIpAddress")]
    public class SetIntersightIamIpAddress:SetCmdletBase
	{
		public SetIntersightIamIpAddress()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamIpAddress();
            MethodName = "PatchIamIpAddressWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Trusted IP range's address. IP address, CIDR range, and IP address range formats are supported. For example '12.13.14.15', '12.13.14.0/24', and '12.13.14.15-12.13.14.200'. Reserved IP ranges '127.0.0.1', '10.0.0.0/8', '172.16.0.0/12', and '192.168.0.0/16' are not allowed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Address {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of Trusted IP address range."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove IamIpAddress.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightIamIpAddress")]
    public class RemoveIntersightIamIpAddress:RemoveCmdletBase
	{
		public RemoveIntersightIamIpAddress()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "DeleteIamIpAddressWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New IamLdapPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightIamLdapPolicy")]
    public class NewIntersightIamLdapPolicy:NewCmdletBase
	{
		public NewIntersightIamLdapPolicy()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamLdapPolicy();
            MethodName = "CreateIamLdapPolicyWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamAccountRelationship ApplianceAccount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Base settings of LDAP required while configuring LDAP policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamLdapBaseProperties BaseProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Configuration settings to resolve LDAP servers, when DNS is enabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamLdapDnsParameters DnsParameters {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enables DNS to access LDAP servers."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool EnableDns {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"LDAP server performs authentication."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamLdapGroup resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<IamLdapGroupRelationship> Groups {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to policyAbstractConfigProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<PolicyAbstractConfigProfileRelationship> Profiles {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamLdapProvider resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<IamLdapProviderRelationship> Providers {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Search precedence between local user database and LDAP user database.\n* `LocalUserDb` - Precedence is given to local user database while searching.\n* `LDAPUserDb` - Precedence is given to LADP user database while searching."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamLdapPolicy.UserSearchPrecedenceEnum UserSearchPrecedence {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IamLdapPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIamLdapPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIamLdapPolicy:GetCmdletBase
	{
		public GetIntersightIamLdapPolicy()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "GetIamLdapPolicyListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IamPrivilegeSet.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIamPrivilegeSet", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIamPrivilegeSet:GetCmdletBase
	{
		public GetIntersightIamPrivilegeSet()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "GetIamPrivilegeSetListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IamResourceRoles.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIamResourceRoles", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIamResourceRoles:GetCmdletBase
	{
		public GetIntersightIamResourceRoles()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "GetIamResourceRolesListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New IamResourceRoles.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightIamResourceRoles")]
    public class NewIntersightIamResourceRoles:NewCmdletBase
	{
		public NewIntersightIamResourceRoles()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamResourceRoles();
            MethodName = "CreateIamResourceRolesWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamPermission resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamPermissionRelationship Permission {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamRole resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<IamRoleRelationship> Roles {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IamLocalUserPasswordPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIamLocalUserPasswordPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIamLocalUserPasswordPolicy:GetCmdletBase
	{
		public GetIntersightIamLocalUserPasswordPolicy()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "GetIamLocalUserPasswordPolicyListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New IamIpAddress.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightIamIpAddress")]
    public class NewIntersightIamIpAddress:NewCmdletBase
	{
		public NewIntersightIamIpAddress()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamIpAddress();
            MethodName = "CreateIamIpAddressWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Trusted IP range's address. IP address, CIDR range, and IP address range formats are supported. For example '12.13.14.15', '12.13.14.0/24', and '12.13.14.15-12.13.14.200'. Reserved IP ranges '127.0.0.1', '10.0.0.0/8', '172.16.0.0/12', and '192.168.0.0/16' are not allowed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Address {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of Trusted IP address range."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IamIpAddress.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIamIpAddress", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIamIpAddress:GetCmdletBase
	{
		public GetIntersightIamIpAddress()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "GetIamIpAddressListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove IamPermission.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightIamPermission")]
    public class RemoveIntersightIamPermission:RemoveCmdletBase
	{
		public RemoveIntersightIamPermission()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "DeleteIamPermissionWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set IamPermission.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightIamPermission")]
    public class SetIntersightIamPermission:SetCmdletBase
	{
		public SetIntersightIamPermission()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamPermission();
            MethodName = "UpdateIamPermissionWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The informative description about each permission."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the permission which has to be granted to user."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_ .:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamResourceRoles resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<IamResourceRolesRelationship> ResourceRoles {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamRole resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<IamRoleRelationship> Roles {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamSessionLimits resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamSessionLimitsRelationship SessionLimits {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamUserGroup resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<IamUserGroupRelationship> UserGroups {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamUser resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<IamUserRelationship> Users {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IamServiceProvider.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIamServiceProvider", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIamServiceProvider:GetCmdletBase
	{
		public GetIntersightIamServiceProvider()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "GetIamServiceProviderListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IamResourceLimits.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIamResourceLimits", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIamResourceLimits:GetCmdletBase
	{
		public GetIntersightIamResourceLimits()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "GetIamResourceLimitsListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IamEndPointUserPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIamEndPointUserPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIamEndPointUserPolicy:GetCmdletBase
	{
		public GetIntersightIamEndPointUserPolicy()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "GetIamEndPointUserPolicyListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New IamEndPointUserPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightIamEndPointUserPolicy")]
    public class NewIntersightIamEndPointUserPolicy:NewCmdletBase
	{
		public NewIntersightIamEndPointUserPolicy()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamEndPointUserPolicy();
            MethodName = "CreateIamEndPointUserPolicyWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamEndPointUserRole resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<IamEndPointUserRoleRelationship> EndPointUserRoles {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Set password properties for endpoint users."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamEndPointPasswordProperties PasswordProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to policyAbstractConfigProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<PolicyAbstractConfigProfileRelationship> Profiles {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set IamEndPointUserRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightIamEndPointUserRole")]
    public class SetIntersightIamEndPointUserRole:SetCmdletBase
	{
		public SetIntersightIamEndPointUserRole()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamEndPointUserRole();
            MethodName = "UpdateIamEndPointUserRoleWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enables the user account on the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamEndPointRole resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<IamEndPointRoleRelationship> EndPointRole {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamEndPointUser resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamEndPointUserRelationship EndPointUser {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamEndPointUserPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamEndPointUserPolicyRelationship EndPointUserPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Valid login password of the user."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9!@#$%^&\\*+-_=]+$")]
        public string Password {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove IamEndPointUserRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightIamEndPointUserRole")]
    public class RemoveIntersightIamEndPointUserRole:RemoveCmdletBase
	{
		public RemoveIntersightIamEndPointUserRole()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "DeleteIamEndPointUserRoleWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set IamIdp.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightIamIdp")]
    public class SetIntersightIamIdp:SetCmdletBase
	{
		public SetIntersightIamIdp()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamIdp();
            MethodName = "UpdateIamIdpWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Email domain name of the user for this IdP. When a user enters an email during login in the Intersight home page, the IdP is picked by matching this domain name with the email domain name for authentication."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$")]
        public string DomainName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Setting that indicates whether 'Single Logout (SLO)' has been enabled for this IdP."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool EnableSingleLogout {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SAML metadata of the IdP."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Metadata {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the Identity Provider, for example Cisco, Okta, or OneID."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Authentication protocol used by the IdP.\n* `saml` - Use SAML as the authentication protocol for sign-on.\n* `oidc` - Open ID connect to be used as an authentication protocol for sign-on.\n* `local` - The local authentication method to be used for sign-on. Local type is set to default for the Intersight Appliance IdP."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamIdp.TypeEnum Type {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamUserGroup resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<IamUserGroupRelationship> Usergroups {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamUser resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<IamUserRelationship> Users {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove IamIdp.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightIamIdp")]
    public class RemoveIntersightIamIdp:RemoveCmdletBase
	{
		public RemoveIntersightIamIdp()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "DeleteIamIdpWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set IamAccountExperience.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightIamAccountExperience")]
    public class SetIntersightIamAccountExperience:SetCmdletBase
	{
		public SetIntersightIamAccountExperience()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamAccountExperience();
            MethodName = "UpdateIamAccountExperienceWithHttpInfo";
		}
        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamAccountRelationship Account {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<IamFeatureDefinition> Features {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IamUserGroup.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIamUserGroup", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIamUserGroup:GetCmdletBase
	{
		public GetIntersightIamUserGroup()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "GetIamUserGroupListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New IamUserGroup.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightIamUserGroup")]
    public class NewIntersightIamUserGroup:NewCmdletBase
	{
		public NewIntersightIamUserGroup()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamUserGroup();
            MethodName = "CreateIamUserGroupWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamIdp resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamIdpRelationship Idp {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamIdpReference resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamIdpReferenceRelationship Idpreference {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the user group which the dynamic user belongs to."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamPermission resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<IamPermissionRelationship> Permissions {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamQualifier resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamQualifierRelationship Qualifier {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IamEndPointUserRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIamEndPointUserRole", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIamEndPointUserRole:GetCmdletBase
	{
		public GetIntersightIamEndPointUserRole()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "GetIamEndPointUserRoleListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New IamEndPointUserRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightIamEndPointUserRole")]
    public class NewIntersightIamEndPointUserRole:NewCmdletBase
	{
		public NewIntersightIamEndPointUserRole()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamEndPointUserRole();
            MethodName = "CreateIamEndPointUserRoleWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enables the user account on the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamEndPointRole resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<IamEndPointRoleRelationship> EndPointRole {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamEndPointUser resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamEndPointUserRelationship EndPointUser {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamEndPointUserPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamEndPointUserPolicyRelationship EndPointUserPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Valid login password of the user."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9!@#$%^&\\*+-_=]+$")]
        public string Password {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IamEndPointPrivilege.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIamEndPointPrivilege", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIamEndPointPrivilege:GetCmdletBase
	{
		public GetIntersightIamEndPointPrivilege()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "GetIamEndPointPrivilegeListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IamPrivateKeySpec.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIamPrivateKeySpec", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIamPrivateKeySpec:GetCmdletBase
	{
		public GetIntersightIamPrivateKeySpec()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "GetIamPrivateKeySpecListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New IamPrivateKeySpec.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightIamPrivateKeySpec")]
    public class NewIntersightIamPrivateKeySpec:NewCmdletBase
	{
		public NewIntersightIamPrivateKeySpec()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamPrivateKeySpec();
            MethodName = "CreateIamPrivateKeySpecWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Algorithm used to generate the key pair and algorithm-speicifc parameters, such as RSA modulus size."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PkixKeyGenerationSpec Algorithm {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamCertificateRequest resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamCertificateRequestRelationship CertificateRequest {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IamAppRegistration.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIamAppRegistration", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIamAppRegistration:GetCmdletBase
	{
		public GetIntersightIamAppRegistration()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "GetIamAppRegistrationListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New IamAppRegistration.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightIamAppRegistration")]
    public class NewIntersightIamAppRegistration:NewCmdletBase
	{
		public NewIntersightIamAppRegistration()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamAppRegistration();
            MethodName = "CreateIamAppRegistrationWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"App Registration name specified by user."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ClientName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The OAuth2 client secret.\nThe value of this property is generated when grantType includes 'client-credentials'.\nOtherwise, no client-secret is generated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ClientSecret {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of the OAuth2 client (public or confidential), as specified in https://tools.ietf.org/html/rfc6749#section-2.1.\n* `public` - Clients incapable of maintaining the confidentiality of their credentials.This includes clients executing on the device used by the resource owner,such as mobile applications, installed native application or a webbrowser-based application.\n* `confidential` - Clients capable of maintaining the confidentiality of their credentials.For example, this could be a client implemented on a secure server withrestricted access to the client credentials.To maintain the confidentiality of the OAuth2 credentials, two use cases areconsidered.1) The application is running as a service within Intersight. The application automatically   obtains the OAuth2 credentials when the application starts and the credentials are not   exposed to the end-user.   Because end-users (even account administrators) do not have access the OAuth2 credentials,   they cannot take the credentials with them when they leave their organization.2) The application is under the control of a \"trusted\" end-user. For example,   the end-user may create a native application running outside Intersight. The application   uses OAuth2 credentials to interact with the Intersight API. In that case, the Intersight   account administrator may generate OAuth2 credentials with a registered application   using \"client_credentials\" grant type.   In that case, the end-user is responsible for maintaining the confidentiality of the   OAuth2 credentials. If the end-user leaves the organization, you should revoke the   credentials and issue new Oauth2 credentials.Here is a possible workflow for handling OAuth2 tokens.1) User Alice (Intersight Account Administrator) logins to Intersight and deploys an Intersight   application that requires an OAuth2 token.2) Intersight automatically deploys the application. The application is assigned a OAuth2 token,   possibly linked to Alice. The application must NOT expose the OAuth2 secret to Alice, otherwise   Alice would be able to use the token after she leaves the company.3) The application can make API calls to Intersight using its assigned OAuth2 token. For example,   the application could make weekly scheduled API calls to Intersight.4) Separately, Alice may also get OAuth2 tokens that she can use to make API calls from the   Intersight SDK through the northbound API. In that case, Alice will get the associated OAuth2   secrets, but not the one assigned in step #2.5) Alice leaves the organization. The OAuth2 tokens assigned in step #2 must retain their validity   even after Alice has left the organization. Because the OAuth2 secrets were never shared with   Alice, there is no risk Alice can reuse the OAuth2 secrets.   On the other hand, the OAuth2 tokens assigned in step #4 must be invalidated because Alice had   the OAuth2 tokens in her possession."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamAppRegistration.ClientTypeEnum ClientType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the application."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> GrantTypes {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> RedirectUris {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Set value to true to renew the client-secret. Applicable to client_credentials grant type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool RenewClientSecret {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> ResponseTypes {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Used to trigger update the revocationTimestamp value.\nIf UI sent updating request with the Revoke value is true, then update RevocationTimestamp."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Revoke {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamRole resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<IamRoleRelationship> Roles {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set IamEndPointUserPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightIamEndPointUserPolicy")]
    public class SetIntersightIamEndPointUserPolicy:SetCmdletBase
	{
		public SetIntersightIamEndPointUserPolicy()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamEndPointUserPolicy();
            MethodName = "UpdateIamEndPointUserPolicyWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamEndPointUserRole resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<IamEndPointUserRoleRelationship> EndPointUserRoles {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Set password properties for endpoint users."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamEndPointPasswordProperties PasswordProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to policyAbstractConfigProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<PolicyAbstractConfigProfileRelationship> Profiles {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove IamEndPointUserPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightIamEndPointUserPolicy")]
    public class RemoveIntersightIamEndPointUserPolicy:RemoveCmdletBase
	{
		public RemoveIntersightIamEndPointUserPolicy()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "DeleteIamEndPointUserPolicyWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IamIpAccessManagement.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIamIpAccessManagement", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIamIpAccessManagement:GetCmdletBase
	{
		public GetIntersightIamIpAccessManagement()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "GetIamIpAccessManagementListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New IamIpAccessManagement.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightIamIpAccessManagement")]
    public class NewIntersightIamIpAccessManagement:NewCmdletBase
	{
		public NewIntersightIamIpAccessManagement()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamIpAccessManagement();
            MethodName = "CreateIamIpAccessManagementWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Flag stores the state of IP address based access management. Access management is enabled when it's true."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enable {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IamEndPointUser.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIamEndPointUser", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIamEndPointUser:GetCmdletBase
	{
		public GetIntersightIamEndPointUser()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "GetIamEndPointUserListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New IamEndPointUser.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightIamEndPointUser")]
    public class NewIntersightIamEndPointUser:NewCmdletBase
	{
		public NewIntersightIamEndPointUser()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamEndPointUser();
            MethodName = "CreateIamEndPointUserWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamEndPointUserRole resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<IamEndPointUserRoleRelationship> EndPointUserRole {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the user to be created on the endpoint. It can be any string that adheres to the following constraints. It can have alphanumeric characters, dots, underscores and hyphen. It cannot be more than 16 characters."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9\\._\\-]+$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IamUserPreference.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIamUserPreference", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIamUserPreference:GetCmdletBase
	{
		public GetIntersightIamUserPreference()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "GetIamUserPreferenceListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set IamIpAccessManagement.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightIamIpAccessManagement")]
    public class SetIntersightIamIpAccessManagement:SetCmdletBase
	{
		public SetIntersightIamIpAccessManagement()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamIpAccessManagement();
            MethodName = "PatchIamIpAccessManagementWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Flag stores the state of IP address based access management. Access management is enabled when it's true."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enable {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IamResourcePermission.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIamResourcePermission", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIamResourcePermission:GetCmdletBase
	{
		public GetIntersightIamResourcePermission()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "GetIamResourcePermissionListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IamIdpReference.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIamIdpReference", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIamIdpReference:GetCmdletBase
	{
		public GetIntersightIamIdpReference()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "GetIamIdpReferenceListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove IamUserGroup.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightIamUserGroup")]
    public class RemoveIntersightIamUserGroup:RemoveCmdletBase
	{
		public RemoveIntersightIamUserGroup()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "DeleteIamUserGroupWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set IamUserGroup.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightIamUserGroup")]
    public class SetIntersightIamUserGroup:SetCmdletBase
	{
		public SetIntersightIamUserGroup()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamUserGroup();
            MethodName = "UpdateIamUserGroupWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamIdp resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamIdpRelationship Idp {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamIdpReference resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamIdpReferenceRelationship Idpreference {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the user group which the dynamic user belongs to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamPermission resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<IamPermissionRelationship> Permissions {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamQualifier resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamQualifierRelationship Qualifier {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New IamLdapProvider.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightIamLdapProvider")]
    public class NewIntersightIamLdapProvider:NewCmdletBase
	{
		public NewIntersightIamLdapProvider()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamLdapProvider();
            MethodName = "CreateIamLdapProviderWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamLdapPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamLdapPolicyRelationship LdapPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"LDAP Server Port for connection establishment."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 65535)]
        public long Port {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"LDAP Server Address, can be IP address or hostname."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Server {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IamLdapProvider.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIamLdapProvider", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIamLdapProvider:GetCmdletBase
	{
		public GetIntersightIamLdapProvider()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "GetIamLdapProviderListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set IamIdpReference.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightIamIdpReference")]
    public class SetIntersightIamIdpReference:SetCmdletBase
	{
		public SetIntersightIamIdpReference()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamIdpReference();
            MethodName = "UpdateIamIdpReferenceWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The flag represents if the second factor of authentication is required for Cisco IdP users."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool MultiFactorAuthentication {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamUserGroup resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<IamUserGroupRelationship> Usergroups {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamUser resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<IamUserRelationship> Users {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IamApiKey.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIamApiKey", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIamApiKey:GetCmdletBase
	{
		public GetIntersightIamApiKey()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "GetIamApiKeyListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New IamApiKey.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightIamApiKey")]
    public class NewIntersightIamApiKey:NewCmdletBase
	{
		public NewIntersightIamApiKey()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamApiKey();
            MethodName = "CreateIamApiKeyWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The cryptographic hash algorithm to calculate the message digest.\n* `SHA256` - The SHA-256 cryptographic hash, as defined by NIST in FIPS 180-4.\n* `SHA384` - The SHA-384 cryptographic hash, as defined by NIST in FIPS 180-4.\n* `SHA512` - The SHA-512 cryptographic hash, as defined by NIST in FIPS 180-4.\n* `SHA512_224` - The SHA-512/224 cryptographic hash, as defined by NIST in FIPS 180-4.\n* `SHA512_256` - The SHA-512/256 cryptographic hash, as defined by NIST in FIPS 180-4."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamApiKey.HashAlgorithmEnum HashAlgorithm {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The key generation specification provides the algorithm and the parameters required for this algorithm to generate a private key, public key pair. Supported key generation schemes include RSA, ECDSA and Edwards-Curve Digital Signature Algorithm (EdDSA)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PkixKeyGenerationSpec KeySpec {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Holds the private key for the API key."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PrivateKey {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The purpose of the API Key."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Purpose {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The signing algorithm used by the client to authenticate API requests to Intersight.\nThe signing algorithm must be compatible with the key generation specification.\n* `RSASSA-PKCS1-v1_5` - RSASSA-PKCS1-v1_5 is a RSA signature scheme specified in [RFC 8017](https://tools.ietf.org/html/rfc8017).RSASSA-PKCS1-v1_5 is included only for compatibility with existing applications.\n* `RSASSA-PSS` - RSASSA-PSS is a RSA signature scheme specified in [RFC 8017](https://tools.ietf.org/html/rfc8017).It combines the RSASP1 and RSAVP1 primitives with the EMSA-PSS encoding method.In the interest of increased robustness, RSASSA-PSS is required in new applications.\n* `Ed25519` - The Ed25519 signature algorithm, as specified in [RFC 8032](https://tools.ietf.org/html/rfc8032).Ed25519 is a public-key signature system with several attractive features, includingfast single-signature verification, very fast signing, fast key generation and high security level.\n* `Ecdsa` - The Elliptic Curve Digital Signature Standard (ECDSA), as defined by NIST in FIPS 186-4 and ANSI X9.62.The signature is encoded as a ASN.1 DER SEQUENCE with two INTEGERs (r and s), as defined in RFC3279.When using ECDSA signatures, configure the client to use the same signature encoding as specified on the server side.\n* `EcdsaP1363Format` - The Elliptic Curve Digital Signature Standard (ECDSA), as defined by NIST in FIPS 186-4 and ANSI X9.62.The signature is the raw concatenation of r and s, as defined in the ISO/IEC 7816-8 IEEE P.1363 standard.In that format, r and s are represented as unsigned, big endian numbers.Extra padding bytes (of value 0x00) is applied so that both r and s encodings have the same size.When using ECDSA signatures, configure the client to use the same signature encoding as specified on the server side."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamApiKey.SigningAlgorithmEnum SigningAlgorithm {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IamSession.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIamSession", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIamSession:GetCmdletBase
	{
		public GetIntersightIamSession()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "GetIamSessionListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IamSystem.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIamSystem", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIamSystem:GetCmdletBase
	{
		public GetIntersightIamSystem()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "GetIamSystemListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set IamLdapPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightIamLdapPolicy")]
    public class SetIntersightIamLdapPolicy:SetCmdletBase
	{
		public SetIntersightIamLdapPolicy()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamLdapPolicy();
            MethodName = "UpdateIamLdapPolicyWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamAccountRelationship ApplianceAccount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Base settings of LDAP required while configuring LDAP policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamLdapBaseProperties BaseProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Configuration settings to resolve LDAP servers, when DNS is enabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamLdapDnsParameters DnsParameters {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enables DNS to access LDAP servers."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool EnableDns {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"LDAP server performs authentication."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamLdapGroup resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<IamLdapGroupRelationship> Groups {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to policyAbstractConfigProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<PolicyAbstractConfigProfileRelationship> Profiles {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamLdapProvider resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<IamLdapProviderRelationship> Providers {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Search precedence between local user database and LDAP user database.\n* `LocalUserDb` - Precedence is given to local user database while searching.\n* `LDAPUserDb` - Precedence is given to LADP user database while searching."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamLdapPolicy.UserSearchPrecedenceEnum UserSearchPrecedence {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove IamLdapPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightIamLdapPolicy")]
    public class RemoveIntersightIamLdapPolicy:RemoveCmdletBase
	{
		public RemoveIntersightIamLdapPolicy()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "DeleteIamLdapPolicyWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove IamPrivateKeySpec.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightIamPrivateKeySpec")]
    public class RemoveIntersightIamPrivateKeySpec:RemoveCmdletBase
	{
		public RemoveIntersightIamPrivateKeySpec()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "DeleteIamPrivateKeySpecWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set IamPrivateKeySpec.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightIamPrivateKeySpec")]
    public class SetIntersightIamPrivateKeySpec:SetCmdletBase
	{
		public SetIntersightIamPrivateKeySpec()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamPrivateKeySpec();
            MethodName = "UpdateIamPrivateKeySpecWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Algorithm used to generate the key pair and algorithm-speicifc parameters, such as RSA modulus size."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PkixKeyGenerationSpec Algorithm {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamCertificateRequest resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamCertificateRequestRelationship CertificateRequest {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set IamLocalUserPassword.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightIamLocalUserPassword")]
    public class SetIntersightIamLocalUserPassword:SetCmdletBase
	{
		public SetIntersightIamLocalUserPassword()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamLocalUserPassword();
            MethodName = "UpdateIamLocalUserPasswordWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User-entered passsord to be compared to password for change password function."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string CurrentPassword {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"New password that the user's password should be changed to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string NewPassword {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User's current valid passsord."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public byte Password {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IamRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIamRole", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIamRole:GetCmdletBase
	{
		public GetIntersightIamRole()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "GetIamRoleListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IamSecurityHolder.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIamSecurityHolder", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIamSecurityHolder:GetCmdletBase
	{
		public GetIntersightIamSecurityHolder()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "GetIamSecurityHolderListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IamCertificateRequest.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIamCertificateRequest", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIamCertificateRequest:GetCmdletBase
	{
		public GetIntersightIamCertificateRequest()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "GetIamCertificateRequestListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New IamCertificateRequest.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightIamCertificateRequest")]
    public class NewIntersightIamCertificateRequest:NewCmdletBase
	{
		public NewIntersightIamCertificateRequest()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamCertificateRequest();
            MethodName = "CreateIamCertificateRequestWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamCertificate resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamCertificateRelationship Certificate {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User input email address, an optional part of the subject of the certificate request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string EmailAddress {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the certificate request."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamPrivateKeySpec resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamPrivateKeySpecRelationship PrivateKeySpec {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Whether the user wants the generated CSR to be self-signed by the appliance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool SelfSigned {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The x.509 distinguished name of the subject of the certificate request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PkixDistinguishedName Subject {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The x.509 subject alternate name values of the certificate request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PkixSubjectAlternateName SubjectAlternateName {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set IamQualifier.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightIamQualifier")]
    public class SetIntersightIamQualifier:SetCmdletBase
	{
		public SetIntersightIamQualifier()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamQualifier();
            MethodName = "UpdateIamQualifierWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamUserGroup resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamUserGroupRelationship Usergroup {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> Value {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove IamQualifier.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightIamQualifier")]
    public class RemoveIntersightIamQualifier:RemoveCmdletBase
	{
		public RemoveIntersightIamQualifier()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "DeleteIamQualifierWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IamAccountExperience.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIamAccountExperience", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIamAccountExperience:GetCmdletBase
	{
		public GetIntersightIamAccountExperience()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "GetIamAccountExperienceListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New IamAccountExperience.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightIamAccountExperience")]
    public class NewIntersightIamAccountExperience:NewCmdletBase
	{
		public NewIntersightIamAccountExperience()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamAccountExperience();
            MethodName = "CreateIamAccountExperienceWithHttpInfo";
		}
        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamAccountRelationship Account {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<IamFeatureDefinition> Features {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set IamUser.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightIamUser")]
    public class SetIntersightIamUser:SetCmdletBase
	{
		public SetIntersightIamUser()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamUser();
            MethodName = "UpdateIamUserWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Email of the user. Users are added to Intersight using the email configured in the IdP."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$")]
        public string Email {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamIdp resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamIdpRelationship Idp {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamIdpReference resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamIdpReferenceRelationship Idpreference {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamPermission resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<IamPermissionRelationship> Permissions {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"UserID or email as configured in the IdP."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string UserIdOrEmail {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove IamUser.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightIamUser")]
    public class RemoveIntersightIamUser:RemoveCmdletBase
	{
		public RemoveIntersightIamUser()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "DeleteIamUserWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set IamCertificate.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightIamCertificate")]
    public class SetIntersightIamCertificate:SetCmdletBase
	{
		public SetIntersightIamCertificate()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamCertificate();
            MethodName = "UpdateIamCertificateWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User-input pem-encoded certificate, signed by a CAcert."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public X509Certificate Certificate {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamCertificateRequest resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamCertificateRequestRelationship CertificateRequest {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove IamCertificate.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightIamCertificate")]
    public class RemoveIntersightIamCertificate:RemoveCmdletBase
	{
		public RemoveIntersightIamCertificate()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "DeleteIamCertificateWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set IamLdapProvider.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightIamLdapProvider")]
    public class SetIntersightIamLdapProvider:SetCmdletBase
	{
		public SetIntersightIamLdapProvider()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamLdapProvider();
            MethodName = "UpdateIamLdapProviderWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamLdapPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamLdapPolicyRelationship LdapPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"LDAP Server Port for connection establishment."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 65535)]
        public long Port {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"LDAP Server Address, can be IP address or hostname."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Server {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove IamLdapProvider.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightIamLdapProvider")]
    public class RemoveIntersightIamLdapProvider:RemoveCmdletBase
	{
		public RemoveIntersightIamLdapProvider()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "DeleteIamLdapProviderWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New IamPermission.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightIamPermission")]
    public class NewIntersightIamPermission:NewCmdletBase
	{
		public NewIntersightIamPermission()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamPermission();
            MethodName = "CreateIamPermissionWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The informative description about each permission."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the permission which has to be granted to user."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_ .:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamResourceRoles resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<IamResourceRolesRelationship> ResourceRoles {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamRole resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<IamRoleRelationship> Roles {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamSessionLimits resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamSessionLimitsRelationship SessionLimits {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamUserGroup resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<IamUserGroupRelationship> UserGroups {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamUser resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<IamUserRelationship> Users {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IamPermission.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIamPermission", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIamPermission:GetCmdletBase
	{
		public GetIntersightIamPermission()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "GetIamPermissionListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set IamBannerMessage.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightIamBannerMessage")]
    public class SetIntersightIamBannerMessage:SetCmdletBase
	{
		public SetIntersightIamBannerMessage()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamBannerMessage();
            MethodName = "UpdateIamBannerMessageWithHttpInfo";
		}
        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamAccountRelationship Account {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Contents of the banner message."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string BannerContents {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Whether or not to display the banner message."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool BannerDisplay {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Title of the banner message."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string BannerTitle {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IamQualifier.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIamQualifier", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIamQualifier:GetCmdletBase
	{
		public GetIntersightIamQualifier()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "GetIamQualifierListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New IamQualifier.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightIamQualifier")]
    public class NewIntersightIamQualifier:NewCmdletBase
	{
		public NewIntersightIamQualifier()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamQualifier();
            MethodName = "CreateIamQualifierWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamUserGroup resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamUserGroupRelationship Usergroup {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> Value {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set IamAccount.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightIamAccount")]
    public class SetIntersightIamAccount:SetCmdletBase
	{
		public SetIntersightIamAccount()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamAccount();
            MethodName = "UpdateIamAccountWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the Intersight account. By default, name is same as the MoID of the account."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9][a-zA-Z0-9\\-]{0,61}[a-zA-Z0-9]$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove IamAccount.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightIamAccount")]
    public class RemoveIntersightIamAccount:RemoveCmdletBase
	{
		public RemoveIntersightIamAccount()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "DeleteIamAccountWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get IamIdp.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightIamIdp", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightIamIdp:GetCmdletBase
	{
		public GetIntersightIamIdp()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "GetIamIdpListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New IamIdp.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightIamIdp")]
    public class NewIntersightIamIdp:NewCmdletBase
	{
		public NewIntersightIamIdp()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamIdp();
            MethodName = "CreateIamIdpWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Email domain name of the user for this IdP. When a user enters an email during login in the Intersight home page, the IdP is picked by matching this domain name with the email domain name for authentication."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$")]
        public string DomainName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Setting that indicates whether 'Single Logout (SLO)' has been enabled for this IdP."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool EnableSingleLogout {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SAML metadata of the IdP."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Metadata {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the Identity Provider, for example Cisco, Okta, or OneID."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Authentication protocol used by the IdP.\n* `saml` - Use SAML as the authentication protocol for sign-on.\n* `oidc` - Open ID connect to be used as an authentication protocol for sign-on.\n* `local` - The local authentication method to be used for sign-on. Local type is set to default for the Intersight Appliance IdP."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamIdp.TypeEnum Type {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamUserGroup resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<IamUserGroupRelationship> Usergroups {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamUser resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<IamUserRelationship> Users {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove IamSession.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightIamSession")]
    public class RemoveIntersightIamSession:RemoveCmdletBase
	{
		public RemoveIntersightIamSession()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "DeleteIamSessionWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set IamEndPointUser.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightIamEndPointUser")]
    public class SetIntersightIamEndPointUser:SetCmdletBase
	{
		public SetIntersightIamEndPointUser()
		{
			ApiInstance = new IamApi(Config);
            ModelObject = new IamEndPointUser();
            MethodName = "UpdateIamEndPointUserWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamEndPointUserRole resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<IamEndPointUserRoleRelationship> EndPointUserRole {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the user to be created on the endpoint. It can be any string that adheres to the following constraints. It can have alphanumeric characters, dots, underscores and hyphen. It cannot be more than 16 characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9\\._\\-]+$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove IamEndPointUser.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightIamEndPointUser")]
    public class RemoveIntersightIamEndPointUser:RemoveCmdletBase
	{
		public RemoveIntersightIamEndPointUser()
		{
			ApiInstance = new IamApi(Config);
            MethodName = "DeleteIamEndPointUserWithHttpInfo";
		}
    }
}