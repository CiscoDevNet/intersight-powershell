using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamPermissionToRoles.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamPermissionToRoles")]
    public class InitializeIntersightIamPermissionToRoles:PSCmdlet
	{
		public InitializeIntersightIamPermissionToRoles()
		{
            ClassId = IamPermissionToRoles.ClassIdEnum.IamPermissionToRoles;
            ObjectType = IamPermissionToRoles.ObjectTypeEnum.IamPermissionToRoles;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamPermissionToRoles.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamPermissionToRoles.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.MoMoRef> Roles {
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Roles"))
            {
                initObject.Roles = this.Roles;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamRule.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamRule")]
    public class InitializeIntersightIamRule:PSCmdlet
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamRule.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The flag represents if IP addresses in the rule is IPv4 or IPv6."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool IpV6 {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamRule.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of the IP address. Currently three types are supported, ie IP, CIDR range and IP range.\n* `Ip` - The IP address rule type is IP.\n* `Cidr` - The IP address rule type is CIDR range.\n* `IpRange` - The IP address rule type is IP range."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamRule.RuleTypeEnum RuleType {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> RuleValue {
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
    /// <para type="synopsis">This is the cmdlet to Initialize IamGroupPermissionToRoles.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamGroupPermissionToRoles")]
    public class InitializeIntersightIamGroupPermissionToRoles:PSCmdlet
	{
		public InitializeIntersightIamGroupPermissionToRoles()
		{
            ClassId = IamGroupPermissionToRoles.ClassIdEnum.IamGroupPermissionToRoles;
            ObjectType = IamGroupPermissionToRoles.ObjectTypeEnum.IamGroupPermissionToRoles;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamGroupPermissionToRoles.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamGroupPermissionToRoles.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.MoMoRef> Orgs {
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Orgs"))
            {
                initObject.Orgs = this.Orgs;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamPermissionReference.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamPermissionReference")]
    public class InitializeIntersightIamPermissionReference:PSCmdlet
	{
		public InitializeIntersightIamPermissionReference()
		{
            ClassId = IamPermissionReference.ClassIdEnum.IamPermissionReference;
            ObjectType = IamPermissionReference.ObjectTypeEnum.IamPermissionReference;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamPermissionReference.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamPermissionReference.ObjectTypeEnum ObjectType {
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
    /// <para type="synopsis">This is the cmdlet to Initialize IamEndPointPasswordProperties.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamEndPointPasswordProperties")]
    public class InitializeIntersightIamEndPointPasswordProperties:PSCmdlet
	{
		public InitializeIntersightIamEndPointPasswordProperties()
		{
            ClassId = IamEndPointPasswordProperties.ClassIdEnum.IamEndPointPasswordProperties;
            ObjectType = IamEndPointPasswordProperties.ObjectTypeEnum.IamEndPointPasswordProperties;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamEndPointPasswordProperties.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enables password expiry on the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool EnablePasswordExpiry {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enables a strong password policy. Strong password requirements: A. The password must have a minimum of 8 and a maximum of 20 characters. B. The password must not contain the User's Name. C. The password must contain characters from three of the following four categories. 1) English uppercase characters (A through Z). 2) English lowercase characters (a through z). 3) Base 10 digits (0 through 9). 4) Non-alphabetic characters (! , @, #, $, %, ^, &, *, -, _, +, =)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool EnforceStrongPassword {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User password will always be sent to endpoint device. If the option is not selected, then user password will be sent to endpoint device for new users and if user password is changed for existing users."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool ForceSendPassword {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Time period until when you can use the existing password, after it expires."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long GracePeriod {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The duration after which the password will expire."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NotificationPeriod {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamEndPointPasswordProperties.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Set time period for password expiration. Value should be greater than notification period and grace period."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 3650)]
        public long PasswordExpiryDuration {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Tracks password change history. Specifies in number of instances, that the new password was already used."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long PasswordHistory {
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
    /// <para type="synopsis">This is the cmdlet to Initialize IamAccountPermissions.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamAccountPermissions")]
    public class InitializeIntersightIamAccountPermissions:PSCmdlet
	{
		public InitializeIntersightIamAccountPermissions()
		{
            ClassId = IamAccountPermissions.ClassIdEnum.IamAccountPermissions;
            ObjectType = IamAccountPermissions.ObjectTypeEnum.IamAccountPermissions;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamAccountPermissions.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamAccountPermissions.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.IamPermissionReference> Permissions {
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Permissions"))
            {
                initObject.Permissions = this.Permissions;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize IamSamlSpConnection.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamSamlSpConnection")]
    public class InitializeIntersightIamSamlSpConnection:PSCmdlet
	{
		public InitializeIntersightIamSamlSpConnection()
		{
            ClassId = IamSamlSpConnection.ClassIdEnum.IamSamlSpConnection;
            ObjectType = IamSamlSpConnection.ObjectTypeEnum.IamSamlSpConnection;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamSamlSpConnection.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SingleLogout Services binding in IdP Metadata."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string IdentityProviderSloBinding {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SingleLogOut Services location in IdP Metadata."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string IdentityProviderSloUrl {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SingleSignOn Services binding in IdP Metadata."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string IdentityProviderSsoBinding {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SingleSignOn Services location in IdP Metadata."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string IdentityProviderSsoUrl {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Decoded Certificate from IdP Metatdata."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object IdpCertificateStore {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamSamlSpConnection.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"WantAuthnRequestsSigned from IdP Metadata."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool SignAuthnRequests {
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
    /// <para type="synopsis">This is the cmdlet to Initialize IamFeatureDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamFeatureDefinition")]
    public class InitializeIntersightIamFeatureDefinition:PSCmdlet
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamFeatureDefinition.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The beta feature that will be enabled for specific account.\n* `IWO` - Intersight Workflow Optimizer.\n* `Hitachi` - Support to claim Hitachi Storage arrays using the Intersight Orchestrator framework.\n* `Kubernetes` - Enables ability to create and manage Kubernetes clusters.\n* `NetAppIO` - Support to claim NetApp Storage arrays as IO targets.\n* `IvsPublicCloud` - Enables virtualization service for public clouds.\n* `TerraformCloud` - Enables an ability to create Terraform Cloud.\n* `IWE` - Enables an ability to use Intersight Workload Engine.\n* `WashingtonEFT` - Support for EFT customers to use Washington firmware images for upgrades."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamFeatureDefinition.FeatureEnum Feature {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamFeatureDefinition.ObjectTypeEnum ObjectType {
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
    /// <para type="synopsis">This is the cmdlet to Initialize IamSsoSessionAttributes.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamSsoSessionAttributes")]
    public class InitializeIntersightIamSsoSessionAttributes:PSCmdlet
	{
		public InitializeIntersightIamSsoSessionAttributes()
		{
            ClassId = IamSsoSessionAttributes.ClassIdEnum.IamSsoSessionAttributes;
            ObjectType = IamSsoSessionAttributes.ObjectTypeEnum.IamSsoSessionAttributes;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamSsoSessionAttributes.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamSsoSessionAttributes.ObjectTypeEnum ObjectType {
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
    /// <para type="synopsis">This is the cmdlet to Initialize IamLdapBaseProperties.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamLdapBaseProperties")]
    public class InitializeIntersightIamLdapBaseProperties:PSCmdlet
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Role and locale information of the user."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9][a-zA-Z0-9\\-\\.]*[a-zA-Z0-9\\-]$")]
        public string Attribute {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Base Distinguished Name (DN). Starting point from where server will search for users and groups."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string BaseDn {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Distinguished Name (DN) of the user, that is used to authenticate against LDAP servers."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string BindDn {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Authentication method to access LDAP servers.\n* `LoginCredentials` - Requires the user credentials. If the bind process fails, then user is denied access.\n* `Anonymous` - Requires no username and password. If this option is selected and the LDAP server is configured for Anonymous logins, then the user gains access.\n* `ConfiguredCredentials` - Requires a known set of credentials to be specified for the initial bind process. If the initial bind process succeeds, then the distinguished name (DN) of the user name is queried and re-used for the re-binding process. If the re-binding process fails, then the user is denied access."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamLdapBaseProperties.BindMethodEnum BindMethod {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamLdapBaseProperties.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The IPv4 domain that all users must be in."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^(([a-zA-Z0-9])|([a-zA-Z0-9][a-zA-Z0-9\\.\\-]*[a-zA-Z0-9]))$")]
        public string Domain {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If enabled, the endpoint encrypts all information it sends to the LDAP server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool EnableEncryption {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If enabled, user authorization is also done at the group level for LDAP users not in the local user database."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool EnableGroupAuthorization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Criteria to identify entries in search requests."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9(][a-zA-Z0-9_#@$%&\\-\\^|()*=:!,.]*[a-zA-Z0-9\\-)]$")]
        public string Filter {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Groups to which an LDAP entry belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9][a-zA-Z0-9_#@$%&\\-\\^]*[a-zA-Z0-9\\-]$")]
        public string GroupAttribute {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Search depth to look for a nested LDAP group in an LDAP group map."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 128)]
        public long NestedGroupSearchDepth {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamLdapBaseProperties.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The password of the user for initial bind process. It can be any string that adheres to the following constraints. It can have character except spaces, tabs, line breaks. It cannot be more than 254 characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[\\S+]{0,254}$")]
        public string Password {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"LDAP authentication timeout duration, in seconds."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Timeout {
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
    /// <para type="synopsis">This is the cmdlet to Initialize IamLdapDnsParameters.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamLdapDnsParameters")]
    public class InitializeIntersightIamLdapDnsParameters:PSCmdlet
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamLdapDnsParameters.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamLdapDnsParameters.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Domain name that acts as a source for a DNS query."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^(([a-zA-Z0-9])|([a-zA-Z0-9][a-zA-Z0-9\\.\\-]*[a-zA-Z0-9]))$")]
        public string SearchDomain {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Forest name that acts as a source for a DNS query."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^(([a-zA-Z0-9])|([a-zA-Z0-9][a-zA-Z0-9\\.\\-]*[a-zA-Z0-9]))$")]
        public string SearchForest {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Source of the domain name used for the DNS SRV request.\n* `Extracted` - The domain name extracted-domain from the login ID.\n* `Configured` - The configured-search domain.\n* `ConfiguredExtracted` - The domain name extracted from the login ID than the configured-search domain."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamLdapDnsParameters.SourceEnum Source {
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
    /// <para type="synopsis">This is the cmdlet to Initialize IamClientMeta.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightIamClientMeta")]
    public class InitializeIntersightIamClientMeta:PSCmdlet
	{
		public InitializeIntersightIamClientMeta()
		{
            ClassId = IamClientMeta.ClassIdEnum.IamClientMeta;
            ObjectType = IamClientMeta.ObjectTypeEnum.IamClientMeta;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamClientMeta.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Parsed device model from raw User-Agent."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DeviceModel {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamClientMeta.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The value of the \"User-Agent\" HTTP header, as sent by the HTTP client when it initiate a session to Intersight. This can be used to identify the client operating system, browser type and browser version.\nExample - Mozilla/5.0 (Macintosh; Intel Mac OS X 10_14_5) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/75.0.3770.100 Safari/537.36\nIt is set when User successfully passed OAuth login flow and receives Access Token."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string UserAgent {
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
}