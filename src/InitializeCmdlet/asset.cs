using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetTargetStatusDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetTargetStatusDetails")]
    public class InitializeIntersightAssetTargetStatusDetails:PSCmdlet
	{
		public InitializeIntersightAssetTargetStatusDetails()
		{
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetTargetStatusDetails.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetTargetStatusDetails.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetTargetStatusDetails initObject = new Intersight.Model.AssetTargetStatusDetails();
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetClientCertificateCredential.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetClientCertificateCredential")]
    public class InitializeIntersightAssetClientCertificateCredential:PSCmdlet
	{
		public InitializeIntersightAssetClientCertificateCredential()
		{
            ClassId = AssetClientCertificateCredential.ClassIdEnum.AssetClientCertificateCredential;
            ObjectType = AssetClientCertificateCredential.ObjectTypeEnum.AssetClientCertificateCredential;
            
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
        
        public AssetClientCertificateCredential.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"PEM encoded x509 client certificate used to authenticate with the target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ClientCertificate {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"PEM encoded private key used to authenticate with the target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ClientKey {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetClientCertificateCredential.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetClientCertificateCredential initObject = new Intersight.Model.AssetClientCertificateCredential();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ClientCertificate"))
            {
                initObject.ClientCertificate = this.ClientCertificate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ClientKey"))
            {
                initObject.ClientKey = this.ClientKey;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetWorkloadOptimizerMicrosoftAzureEnterpriseAgreementOptions.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetWorkloadOptimizerMicrosoftAzureEnterpriseAgreementOptions")]
    public class InitializeIntersightAssetWorkloadOptimizerMicrosoftAzureEnterpriseAgreementOptions:PSCmdlet
	{
		public InitializeIntersightAssetWorkloadOptimizerMicrosoftAzureEnterpriseAgreementOptions()
		{
            ClassId = AssetWorkloadOptimizerMicrosoftAzureEnterpriseAgreementOptions.ClassIdEnum.AssetWorkloadOptimizerMicrosoftAzureEnterpriseAgreementOptions;
            ObjectType = AssetWorkloadOptimizerMicrosoftAzureEnterpriseAgreementOptions.ObjectTypeEnum.AssetWorkloadOptimizerMicrosoftAzureEnterpriseAgreementOptions;
            
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
        
        public AssetWorkloadOptimizerMicrosoftAzureEnterpriseAgreementOptions.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enrollment number for Azure EA."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string EnrollmentNumber {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetWorkloadOptimizerMicrosoftAzureEnterpriseAgreementOptions.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetWorkloadOptimizerMicrosoftAzureEnterpriseAgreementOptions initObject = new Intersight.Model.AssetWorkloadOptimizerMicrosoftAzureEnterpriseAgreementOptions();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("EnrollmentNumber"))
            {
                initObject.EnrollmentNumber = this.EnrollmentNumber;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetDeviceInformation.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetDeviceInformation")]
    public class InitializeIntersightAssetDeviceInformation:PSCmdlet
	{
		public InitializeIntersightAssetDeviceInformation()
		{
            ClassId = AssetDeviceInformation.ClassIdEnum.AssetDeviceInformation;
            ObjectType = AssetDeviceInformation.ObjectTypeEnum.AssetDeviceInformation;
            
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
        
        public AssetDeviceInformation.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.AssetDeviceTransaction> DeviceTransactions {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceInformation.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetDeviceInformation initObject = new Intersight.Model.AssetDeviceInformation();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DeviceTransactions"))
            {
                initObject.DeviceTransactions = this.DeviceTransactions;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetConnectionControlMessage.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetConnectionControlMessage")]
    public class InitializeIntersightAssetConnectionControlMessage:PSCmdlet
	{
		public InitializeIntersightAssetConnectionControlMessage()
		{
            ClassId = AssetConnectionControlMessage.ClassIdEnum.AssetConnectionControlMessage;
            Leadership = AssetConnectionControlMessage.LeadershipEnum.Unknown;
            ObjectType = AssetConnectionControlMessage.ObjectTypeEnum.AssetConnectionControlMessage;
            
		}
        // <summary>
        /// <para type="description">"The account id to which the device belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Account {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetConnectionControlMessage.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The version of the device connector currently running on the platform. Deprecated by newer connectors that will report this directly to the device connector gateway in a websocket header, but included to continue to support older versions which report any version change after connect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ConnectorVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Moid of the device under change. Used to route the message to a devices connection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DeviceId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The domain group id to which the device belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DomainGroup {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Flag to force any open connections to be evicted. Used in case device has been deleted or blacklisted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Evict {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The current leadership of a device cluster member.\n* `Unknown` - The node is unable to complete election or determine the current state. If the device has been registered before and the node has access to the current credentials it will establish a connection to Intersight with limited capabilities that can be used to debug the HA failure from Intersight.\n* `Primary` - The node has been elected as the primary and will establish a connection to the Intersight service and accept all message types enabled for a primary node. There can only be one primary in a given cluster, while the underlying platform may be active-active only one connector will assume the primary role.\n* `Secondary` - The node has been elected as a secondary node in the cluster. The device connector will establish a connection to the Intersight service with limited capabilities. e.g. file upload will be enabled, but requests to the underlying platform management will be disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetConnectionControlMessage.LeadershipEnum Leadership {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The new identity assigned to a device on ownership change (claim/unclaim)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string NewIdentity {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetConnectionControlMessage.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The partition the device was last connected to, used to address the control message to the device connector gateway instance holding the devices connection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Partition {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetConnectionControlMessage initObject = new Intersight.Model.AssetConnectionControlMessage();
            if (this.MyInvocation.BoundParameters.ContainsKey("Account"))
            {
                initObject.Account = this.Account;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ConnectorVersion"))
            {
                initObject.ConnectorVersion = this.ConnectorVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DeviceId"))
            {
                initObject.DeviceId = this.DeviceId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DomainGroup"))
            {
                initObject.DomainGroup = this.DomainGroup;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Evict"))
            {
                initObject.Evict = this.Evict;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Leadership"))
            {
                initObject.Leadership = this.Leadership;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NewIdentity"))
            {
                initObject.NewIdentity = this.NewIdentity;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Partition"))
            {
                initObject.Partition = this.Partition;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetConnection.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetConnection")]
    public class InitializeIntersightAssetConnection:PSCmdlet
	{
		public InitializeIntersightAssetConnection()
		{
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetConnection.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The credential to be used to authenticate with the managed target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.AssetCredential Credential {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetConnection.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetConnection initObject = new Intersight.Model.AssetConnection();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Credential"))
            {
                initObject.Credential = this.Credential;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetOrchestrationService.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetOrchestrationService")]
    public class InitializeIntersightAssetOrchestrationService:PSCmdlet
	{
		public InitializeIntersightAssetOrchestrationService()
		{
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetOrchestrationService.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetOrchestrationService.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Captures configuration that is specific to a target type for a specific service."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.AssetServiceOptions Options {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetOrchestrationService initObject = new Intersight.Model.AssetOrchestrationService();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Options"))
            {
                initObject.Options = this.Options;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetUsernamePasswordCredential.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetUsernamePasswordCredential")]
    public class InitializeIntersightAssetUsernamePasswordCredential:PSCmdlet
	{
		public InitializeIntersightAssetUsernamePasswordCredential()
		{
            ClassId = AssetUsernamePasswordCredential.ClassIdEnum.AssetUsernamePasswordCredential;
            ObjectType = AssetUsernamePasswordCredential.ObjectTypeEnum.AssetUsernamePasswordCredential;
            
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
        
        public AssetUsernamePasswordCredential.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetUsernamePasswordCredential.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The password used to authenticate with a managed target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Password {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The username used to authenticate with a managed target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Username {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetUsernamePasswordCredential initObject = new Intersight.Model.AssetUsernamePasswordCredential();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Password"))
            {
                initObject.Password = this.Password;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Username"))
            {
                initObject.Username = this.Username;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetCloudConnection.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetCloudConnection")]
    public class InitializeIntersightAssetCloudConnection:PSCmdlet
	{
		public InitializeIntersightAssetCloudConnection()
		{
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetCloudConnection.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The credential to be used to authenticate with the managed target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.AssetCredential Credential {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetCloudConnection.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetCloudConnection initObject = new Intersight.Model.AssetCloudConnection();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Credential"))
            {
                initObject.Credential = this.Credential;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetProductInformation.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetProductInformation")]
    public class InitializeIntersightAssetProductInformation:PSCmdlet
	{
		public InitializeIntersightAssetProductInformation()
		{
            ClassId = AssetProductInformation.ClassIdEnum.AssetProductInformation;
            ObjectType = AssetProductInformation.ObjectTypeEnum.AssetProductInformation;
            
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
        
        public AssetProductInformation.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetProductInformation.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetProductInformation initObject = new Intersight.Model.AssetProductInformation();
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetNoAuthenticationCredential.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetNoAuthenticationCredential")]
    public class InitializeIntersightAssetNoAuthenticationCredential:PSCmdlet
	{
		public InitializeIntersightAssetNoAuthenticationCredential()
		{
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetNoAuthenticationCredential.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetNoAuthenticationCredential.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetNoAuthenticationCredential initObject = new Intersight.Model.AssetNoAuthenticationCredential();
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetClaimSignature.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetClaimSignature")]
    public class InitializeIntersightAssetClaimSignature:PSCmdlet
	{
		public InitializeIntersightAssetClaimSignature()
		{
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetClaimSignature.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetClaimSignature.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The result of signing the deviceId appended with the timeStamp fields with the devices private key."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public byte[] Signature {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetClaimSignature initObject = new Intersight.Model.AssetClaimSignature();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Signature"))
            {
                initObject.Signature = this.Signature;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetWorkloadOptimizerOpenStackOptions.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetWorkloadOptimizerOpenStackOptions")]
    public class InitializeIntersightAssetWorkloadOptimizerOpenStackOptions:PSCmdlet
	{
		public InitializeIntersightAssetWorkloadOptimizerOpenStackOptions()
		{
            ClassId = AssetWorkloadOptimizerOpenStackOptions.ClassIdEnum.AssetWorkloadOptimizerOpenStackOptions;
            ObjectType = AssetWorkloadOptimizerOpenStackOptions.ObjectTypeEnum.AssetWorkloadOptimizerOpenStackOptions;
            
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
        
        public AssetWorkloadOptimizerOpenStackOptions.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"OpenStack Identity Service (keystone) domain name. Domain is an additional namespaces you can create in keystone to partition users, groups, and projects. Default domain name value is \"Default\"."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Domain {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetWorkloadOptimizerOpenStackOptions.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of tenant which has assigned administrator role this OpenStack target user is in. A tenant or project is referred to as a group of users of OpenStack. Each tenant can be assigned a role which gives all its member users their rights and privileges to perform a specific set of operations."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Tenant {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetWorkloadOptimizerOpenStackOptions initObject = new Intersight.Model.AssetWorkloadOptimizerOpenStackOptions();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Domain"))
            {
                initObject.Domain = this.Domain;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tenant"))
            {
                initObject.Tenant = this.Tenant;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetServiceOptions.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetServiceOptions")]
    public class InitializeIntersightAssetServiceOptions:PSCmdlet
	{
		public InitializeIntersightAssetServiceOptions()
		{
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetServiceOptions.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetServiceOptions.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetServiceOptions initObject = new Intersight.Model.AssetServiceOptions();
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetVirtualizationService.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetVirtualizationService")]
    public class InitializeIntersightAssetVirtualizationService:PSCmdlet
	{
		public InitializeIntersightAssetVirtualizationService()
		{
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetVirtualizationService.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetVirtualizationService.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Captures configuration that is specific to a target type for a specific service."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.AssetServiceOptions Options {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetVirtualizationService initObject = new Intersight.Model.AssetVirtualizationService();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Options"))
            {
                initObject.Options = this.Options;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetWorkloadOptimizerService.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetWorkloadOptimizerService")]
    public class InitializeIntersightAssetWorkloadOptimizerService:PSCmdlet
	{
		public InitializeIntersightAssetWorkloadOptimizerService()
		{
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetWorkloadOptimizerService.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetWorkloadOptimizerService.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Captures configuration that is specific to a target type for a specific service."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.AssetServiceOptions Options {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetWorkloadOptimizerService initObject = new Intersight.Model.AssetWorkloadOptimizerService();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Options"))
            {
                initObject.Options = this.Options;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetIntersightDeviceConnectorConnection.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetIntersightDeviceConnectorConnection")]
    public class InitializeIntersightAssetIntersightDeviceConnectorConnection:PSCmdlet
	{
		public InitializeIntersightAssetIntersightDeviceConnectorConnection()
		{
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetIntersightDeviceConnectorConnection.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The credential to be used to authenticate with the managed target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.AssetCredential Credential {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetIntersightDeviceConnectorConnection.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetIntersightDeviceConnectorConnection initObject = new Intersight.Model.AssetIntersightDeviceConnectorConnection();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Credential"))
            {
                initObject.Credential = this.Credential;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetWorkloadOptimizerRedHatOpenStackOptions.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetWorkloadOptimizerRedHatOpenStackOptions")]
    public class InitializeIntersightAssetWorkloadOptimizerRedHatOpenStackOptions:PSCmdlet
	{
		public InitializeIntersightAssetWorkloadOptimizerRedHatOpenStackOptions()
		{
            ClassId = AssetWorkloadOptimizerRedHatOpenStackOptions.ClassIdEnum.AssetWorkloadOptimizerRedHatOpenStackOptions;
            ObjectType = AssetWorkloadOptimizerRedHatOpenStackOptions.ObjectTypeEnum.AssetWorkloadOptimizerRedHatOpenStackOptions;
            
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
        
        public AssetWorkloadOptimizerRedHatOpenStackOptions.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"RedHat OpenStack Identity Service (keystone) domain name. Domain is an additional namespaces you can create in keystone to partition users, groups, and projects. Default domain name value is \"Default\"."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Domain {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetWorkloadOptimizerRedHatOpenStackOptions.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of tenant which has assigned administrator role this RedHat OpenStack target user is in. A tenant or project is referred to as a group of users of RedHat OpenStack. Each tenant can be assigned a role which gives all its member users their rights and privileges to perform a specific set of operations."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Tenant {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetWorkloadOptimizerRedHatOpenStackOptions initObject = new Intersight.Model.AssetWorkloadOptimizerRedHatOpenStackOptions();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Domain"))
            {
                initObject.Domain = this.Domain;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tenant"))
            {
                initObject.Tenant = this.Tenant;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetOauthClientIdSecretCredential.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetOauthClientIdSecretCredential")]
    public class InitializeIntersightAssetOauthClientIdSecretCredential:PSCmdlet
	{
		public InitializeIntersightAssetOauthClientIdSecretCredential()
		{
            ClassId = AssetOauthClientIdSecretCredential.ClassIdEnum.AssetOauthClientIdSecretCredential;
            ObjectType = AssetOauthClientIdSecretCredential.ObjectTypeEnum.AssetOauthClientIdSecretCredential;
            
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
        
        public AssetOauthClientIdSecretCredential.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The client ID used to authenticate with a managed target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ClientId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The client secret used to authenticate with a managed target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ClientSecret {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetOauthClientIdSecretCredential.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetOauthClientIdSecretCredential initObject = new Intersight.Model.AssetOauthClientIdSecretCredential();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ClientId"))
            {
                initObject.ClientId = this.ClientId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ClientSecret"))
            {
                initObject.ClientSecret = this.ClientSecret;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetWorkloadOptimizerAmazonWebServicesBillingOptions.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetWorkloadOptimizerAmazonWebServicesBillingOptions")]
    public class InitializeIntersightAssetWorkloadOptimizerAmazonWebServicesBillingOptions:PSCmdlet
	{
		public InitializeIntersightAssetWorkloadOptimizerAmazonWebServicesBillingOptions()
		{
            ClassId = AssetWorkloadOptimizerAmazonWebServicesBillingOptions.ClassIdEnum.AssetWorkloadOptimizerAmazonWebServicesBillingOptions;
            ObjectType = AssetWorkloadOptimizerAmazonWebServicesBillingOptions.ObjectTypeEnum.AssetWorkloadOptimizerAmazonWebServicesBillingOptions;
            
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
        
        public AssetWorkloadOptimizerAmazonWebServicesBillingOptions.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of S3 bucket that contains the Amazon web service Cost and Usage report to get cloud service spend."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string CostAndUsageReportBucket {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Report path prefix for the Amazon web service cost and usage report to get cloud service spend."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string CostAndUsageReportPath {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Region for S3 bucket that contains the Amazon web service Cost and Usage report to get cloud service spend."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string CostAndUsageReportRegion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetWorkloadOptimizerAmazonWebServicesBillingOptions.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetWorkloadOptimizerAmazonWebServicesBillingOptions initObject = new Intersight.Model.AssetWorkloadOptimizerAmazonWebServicesBillingOptions();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CostAndUsageReportBucket"))
            {
                initObject.CostAndUsageReportBucket = this.CostAndUsageReportBucket;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CostAndUsageReportPath"))
            {
                initObject.CostAndUsageReportPath = this.CostAndUsageReportPath;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CostAndUsageReportRegion"))
            {
                initObject.CostAndUsageReportRegion = this.CostAndUsageReportRegion;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetDeviceTransaction.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetDeviceTransaction")]
    public class InitializeIntersightAssetDeviceTransaction:PSCmdlet
	{
		public InitializeIntersightAssetDeviceTransaction()
		{
            ClassId = AssetDeviceTransaction.ClassIdEnum.AssetDeviceTransaction;
            ObjectType = AssetDeviceTransaction.ObjectTypeEnum.AssetDeviceTransaction;
            
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
        
        public AssetDeviceTransaction.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceTransaction.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetDeviceTransaction initObject = new Intersight.Model.AssetDeviceTransaction();
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetDeviceStatistics.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetDeviceStatistics")]
    public class InitializeIntersightAssetDeviceStatistics:PSCmdlet
	{
		public InitializeIntersightAssetDeviceStatistics()
		{
            ClassId = AssetDeviceStatistics.ClassIdEnum.AssetDeviceStatistics;
            ObjectType = AssetDeviceStatistics.ObjectTypeEnum.AssetDeviceStatistics;
            
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
        
        public AssetDeviceStatistics.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceStatistics.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetDeviceStatistics initObject = new Intersight.Model.AssetDeviceStatistics();
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetTerraformIntegrationTerraformCloudOptions.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetTerraformIntegrationTerraformCloudOptions")]
    public class InitializeIntersightAssetTerraformIntegrationTerraformCloudOptions:PSCmdlet
	{
		public InitializeIntersightAssetTerraformIntegrationTerraformCloudOptions()
		{
            ClassId = AssetTerraformIntegrationTerraformCloudOptions.ClassIdEnum.AssetTerraformIntegrationTerraformCloudOptions;
            ObjectType = AssetTerraformIntegrationTerraformCloudOptions.ObjectTypeEnum.AssetTerraformIntegrationTerraformCloudOptions;
            
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
        
        public AssetTerraformIntegrationTerraformCloudOptions.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> DefaultManagedHosts {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Default organization for Terraform Cloud platform type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DefaultTerraformOrganization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetTerraformIntegrationTerraformCloudOptions.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetTerraformIntegrationTerraformCloudOptions initObject = new Intersight.Model.AssetTerraformIntegrationTerraformCloudOptions();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DefaultManagedHosts"))
            {
                initObject.DefaultManagedHosts = this.DefaultManagedHosts;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DefaultTerraformOrganization"))
            {
                initObject.DefaultTerraformOrganization = this.DefaultTerraformOrganization;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetWorkloadOptimizerMicrosoftAzureServicePrincipalOptions.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetWorkloadOptimizerMicrosoftAzureServicePrincipalOptions")]
    public class InitializeIntersightAssetWorkloadOptimizerMicrosoftAzureServicePrincipalOptions:PSCmdlet
	{
		public InitializeIntersightAssetWorkloadOptimizerMicrosoftAzureServicePrincipalOptions()
		{
            AzureCloudType = AssetWorkloadOptimizerMicrosoftAzureServicePrincipalOptions.AzureCloudTypeEnum.Global;
            ClassId = AssetWorkloadOptimizerMicrosoftAzureServicePrincipalOptions.ClassIdEnum.AssetWorkloadOptimizerMicrosoftAzureServicePrincipalOptions;
            ObjectType = AssetWorkloadOptimizerMicrosoftAzureServicePrincipalOptions.ObjectTypeEnum.AssetWorkloadOptimizerMicrosoftAzureServicePrincipalOptions;
            
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
        /// <para type="description">"Azure has different endpoints for managing Germany subscriptions. Azure cloud type helps in differentiating between regular subscriptions and Germany subscriptions to manage the Azure services for workload optimization. Documentation for germany cloud [link](https://docs.microsoft.com/en-us/azure/germany/germany-manage-subscriptions).\n* `Global` - Global cloud type for Azure subscription.\n* `Germany` - Germany cloud type for Azure subscription."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetWorkloadOptimizerMicrosoftAzureServicePrincipalOptions.AzureCloudTypeEnum AzureCloudType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetWorkloadOptimizerMicrosoftAzureServicePrincipalOptions.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetWorkloadOptimizerMicrosoftAzureServicePrincipalOptions.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"ID of the tenant used while authenticating the managed target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string TenantId {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetWorkloadOptimizerMicrosoftAzureServicePrincipalOptions initObject = new Intersight.Model.AssetWorkloadOptimizerMicrosoftAzureServicePrincipalOptions();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AzureCloudType"))
            {
                initObject.AzureCloudType = this.AzureCloudType;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("TenantId"))
            {
                initObject.TenantId = this.TenantId;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetSudiInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetSudiInfo")]
    public class InitializeIntersightAssetSudiInfo:PSCmdlet
	{
		public InitializeIntersightAssetSudiInfo()
		{
            ClassId = AssetSudiInfo.ClassIdEnum.AssetSudiInfo;
            ObjectType = AssetSudiInfo.ObjectTypeEnum.AssetSudiInfo;
            Status = AssetSudiInfo.StatusEnum.DeviceStatusUnknown;
            
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
        
        public AssetSudiInfo.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetSudiInfo.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The device model (PID) extracted from the X.509 SUDI Leaf Certificate."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Pid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The device SerialNumber extracted from the X.509 SUDI Leaf Certiicate."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SerialNumber {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The signature is obtained by taking the base64 encoding of the Serial Number + PID + Status, taking the SHA256 hash and then signing with the SUDI X.509 Leaf Certifiate."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Signature {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The validation status of the device.\n* `DeviceStatusUnknown` - SUDI validation is done on the establishment of a connection. Before a device connects or after it disconnects, the SUDI validation status is set to this value.\n* `Verified` - The device returned a valid PID, Serial Number, Status and X.509 Leaf Certificate. The certificate signing chain was validated.\n* `CertificateValidationFailed` - Validation of the certificate signing chain failed.\n* `UnsupportedFirmware` - The firmware version of the Cisco IMC that is installed does not contain the SUDI APIs needed to perform validation.\n* `UnsupportedHardware` - The device is a model that does not contain a Trust Anchor Module (TAM) and thus cannot be validated.\n* `DeviceNotResponding` - An request was sent to the device, but no response was received."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetSudiInfo.StatusEnum Status {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The X.509 SUDI Leaf Certificate from the Trust Anchor Module. The certificate is serialized in PEM format (Base64 encoded DER certificate)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.X509Certificate SudiCertificate {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetSudiInfo initObject = new Intersight.Model.AssetSudiInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Pid"))
            {
                initObject.Pid = this.Pid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SerialNumber"))
            {
                initObject.SerialNumber = this.SerialNumber;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Signature"))
            {
                initObject.Signature = this.Signature;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Status"))
            {
                initObject.Status = this.Status;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SudiCertificate"))
            {
                initObject.SudiCertificate = this.SudiCertificate;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetParentConnectionSignature.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetParentConnectionSignature")]
    public class InitializeIntersightAssetParentConnectionSignature:PSCmdlet
	{
		public InitializeIntersightAssetParentConnectionSignature()
		{
            ClassId = AssetParentConnectionSignature.ClassIdEnum.AssetParentConnectionSignature;
            ObjectType = AssetParentConnectionSignature.ObjectTypeEnum.AssetParentConnectionSignature;
            
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
        
        public AssetParentConnectionSignature.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The moid of the parent device registration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DeviceId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The node identity of the parent device, corresponds to the parents ClusterMember.memberIdentity. Used on connect to establish through which device in a cluster the child is connected through."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string NodeId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetParentConnectionSignature.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The result of signing the deviceId appended with the timeStamp fields with the devices private key."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public byte[] Signature {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetParentConnectionSignature initObject = new Intersight.Model.AssetParentConnectionSignature();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DeviceId"))
            {
                initObject.DeviceId = this.DeviceId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NodeId"))
            {
                initObject.NodeId = this.NodeId;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Signature"))
            {
                initObject.Signature = this.Signature;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetWorkloadOptimizerVmwareVcenterOptions.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetWorkloadOptimizerVmwareVcenterOptions")]
    public class InitializeIntersightAssetWorkloadOptimizerVmwareVcenterOptions:PSCmdlet
	{
		public InitializeIntersightAssetWorkloadOptimizerVmwareVcenterOptions()
		{
            ClassId = AssetWorkloadOptimizerVmwareVcenterOptions.ClassIdEnum.AssetWorkloadOptimizerVmwareVcenterOptions;
            ObjectType = AssetWorkloadOptimizerVmwareVcenterOptions.ObjectTypeEnum.AssetWorkloadOptimizerVmwareVcenterOptions;
            
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
        
        public AssetWorkloadOptimizerVmwareVcenterOptions.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"DatastoreBrowsingEnabled controls whether Workload Optimizer scans vCenter datastores to identify files which are not used and can be deleted to reclaim space and improve actual disk utilization. For example orphaned VMDK files."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool DatastoreBrowsingEnabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetWorkloadOptimizerVmwareVcenterOptions.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetWorkloadOptimizerVmwareVcenterOptions initObject = new Intersight.Model.AssetWorkloadOptimizerVmwareVcenterOptions();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DatastoreBrowsingEnabled"))
            {
                initObject.DatastoreBrowsingEnabled = this.DatastoreBrowsingEnabled;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetHttpConnection.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetHttpConnection")]
    public class InitializeIntersightAssetHttpConnection:PSCmdlet
	{
		public InitializeIntersightAssetHttpConnection()
		{
            ClassId = AssetHttpConnection.ClassIdEnum.AssetHttpConnection;
            ObjectType = AssetHttpConnection.ObjectTypeEnum.AssetHttpConnection;
            
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
        /// <para type="description">"The certificate authority of the target. If set and connection is secure the connection will be validate using the servers identity with this certificate. If not set no validation will be done of the identity."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string CertificateAuthority {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetHttpConnection.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The credential to be used to authenticate with the managed target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.AssetCredential Credential {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates whether a connection to the target should be established using HTTPS."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool IsSecure {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The DNS hostname or IP Address, either IPv4 or IPv6, to be used to connect to the managed target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ManagementAddress {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetHttpConnection.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The port number to be used to connect to the managed target. Values 1-65535 indicate a port number to be used. A value of 0 is not a valid port number and instead indicates that the default management port, as defined by the documentation of the managed target, should be used to establish a connection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Port {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetHttpConnection initObject = new Intersight.Model.AssetHttpConnection();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CertificateAuthority"))
            {
                initObject.CertificateAuthority = this.CertificateAuthority;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Credential"))
            {
                initObject.Credential = this.Credential;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsSecure"))
            {
                initObject.IsSecure = this.IsSecure;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ManagementAddress"))
            {
                initObject.ManagementAddress = this.ManagementAddress;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Port"))
            {
                initObject.Port = this.Port;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetWorkloadOptimizerHypervOptions.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetWorkloadOptimizerHypervOptions")]
    public class InitializeIntersightAssetWorkloadOptimizerHypervOptions:PSCmdlet
	{
		public InitializeIntersightAssetWorkloadOptimizerHypervOptions()
		{
            ClassId = AssetWorkloadOptimizerHypervOptions.ClassIdEnum.AssetWorkloadOptimizerHypervOptions;
            ObjectType = AssetWorkloadOptimizerHypervOptions.ObjectTypeEnum.AssetWorkloadOptimizerHypervOptions;
            
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
        
        public AssetWorkloadOptimizerHypervOptions.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When enabled, all Hyper-V hosts in the same cluster of specified Hyper-V host target will be discovered Each server must still be configured to allow remote management (for example, configuring WinRM using a GPO)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool DiscoverHostCluster {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Fully qualified domain name of the Hyper-V target. It is used to get the name of the Hyper-V cluster node and do Active Directory authentication process through Kerberos scheme."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FullDomainName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetWorkloadOptimizerHypervOptions.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetWorkloadOptimizerHypervOptions initObject = new Intersight.Model.AssetWorkloadOptimizerHypervOptions();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DiscoverHostCluster"))
            {
                initObject.DiscoverHostCluster = this.DiscoverHostCluster;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FullDomainName"))
            {
                initObject.FullDomainName = this.FullDomainName;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetVmHost.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetVmHost")]
    public class InitializeIntersightAssetVmHost:PSCmdlet
	{
		public InitializeIntersightAssetVmHost()
		{
            ClassId = AssetVmHost.ClassIdEnum.AssetVmHost;
            ObjectType = AssetVmHost.ObjectTypeEnum.AssetVmHost;
            
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
        
        public AssetVmHost.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetVmHost.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetVmHost initObject = new Intersight.Model.AssetVmHost();
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetTerraformIntegrationService.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetTerraformIntegrationService")]
    public class InitializeIntersightAssetTerraformIntegrationService:PSCmdlet
	{
		public InitializeIntersightAssetTerraformIntegrationService()
		{
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetTerraformIntegrationService.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetTerraformIntegrationService.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Captures configuration that is specific to a target type for a specific service."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.AssetServiceOptions Options {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetTerraformIntegrationService initObject = new Intersight.Model.AssetTerraformIntegrationService();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Options"))
            {
                initObject.Options = this.Options;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetApiKeyCredential.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetApiKeyCredential")]
    public class InitializeIntersightAssetApiKeyCredential:PSCmdlet
	{
		public InitializeIntersightAssetApiKeyCredential()
		{
            ClassId = AssetApiKeyCredential.ClassIdEnum.AssetApiKeyCredential;
            ObjectType = AssetApiKeyCredential.ObjectTypeEnum.AssetApiKeyCredential;
            
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
        /// <para type="description">"This a secret API key which can be used for authentication purposes for different targets like Azure Enterprise Agreement."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ApiKey {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetApiKeyCredential.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetApiKeyCredential.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetApiKeyCredential initObject = new Intersight.Model.AssetApiKeyCredential();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ApiKey"))
            {
                initObject.ApiKey = this.ApiKey;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetTargetKey.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetTargetKey")]
    public class InitializeIntersightAssetTargetKey:PSCmdlet
	{
		public InitializeIntersightAssetTargetKey()
		{
            ClassId = AssetTargetKey.ClassIdEnum.AssetTargetKey;
            ObjectType = AssetTargetKey.ObjectTypeEnum.AssetTargetKey;
            
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
        
        public AssetTargetKey.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetTargetKey.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetTargetKey initObject = new Intersight.Model.AssetTargetKey();
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetTargetSignature.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetTargetSignature")]
    public class InitializeIntersightAssetTargetSignature:PSCmdlet
	{
		public InitializeIntersightAssetTargetSignature()
		{
            ClassId = AssetTargetSignature.ClassIdEnum.AssetTargetSignature;
            ObjectType = AssetTargetSignature.ObjectTypeEnum.AssetTargetSignature;
            
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
        
        public AssetTargetSignature.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetTargetSignature.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The result of signing the deviceId appended with the timeStamp fields with the devices private key."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public byte[] Signature {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The moid of the associated target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string TargetId {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetTargetSignature initObject = new Intersight.Model.AssetTargetSignature();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Signature"))
            {
                initObject.Signature = this.Signature;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TargetId"))
            {
                initObject.TargetId = this.TargetId;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetVirtualizationAmazonWebServiceOptions.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetVirtualizationAmazonWebServiceOptions")]
    public class InitializeIntersightAssetVirtualizationAmazonWebServiceOptions:PSCmdlet
	{
		public InitializeIntersightAssetVirtualizationAmazonWebServiceOptions()
		{
            ClassId = AssetVirtualizationAmazonWebServiceOptions.ClassIdEnum.AssetVirtualizationAmazonWebServiceOptions;
            ObjectType = AssetVirtualizationAmazonWebServiceOptions.ObjectTypeEnum.AssetVirtualizationAmazonWebServiceOptions;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetVirtualizationAmazonWebServiceOptions.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.MoMoRef> ManagedRegions {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetVirtualizationAmazonWebServiceOptions.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetVirtualizationAmazonWebServiceOptions initObject = new Intersight.Model.AssetVirtualizationAmazonWebServiceOptions();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ManagedRegions"))
            {
                initObject.ManagedRegions = this.ManagedRegions;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetDeploymentDeviceInformation.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetDeploymentDeviceInformation")]
    public class InitializeIntersightAssetDeploymentDeviceInformation:PSCmdlet
	{
		public InitializeIntersightAssetDeploymentDeviceInformation()
		{
            ClassId = AssetDeploymentDeviceInformation.ClassIdEnum.AssetDeploymentDeviceInformation;
            ObjectType = AssetDeploymentDeviceInformation.ObjectTypeEnum.AssetDeploymentDeviceInformation;
            
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
        
        public AssetDeploymentDeviceInformation.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.AssetDeviceTransaction> DeviceTransactions {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeploymentDeviceInformation.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetDeploymentDeviceInformation initObject = new Intersight.Model.AssetDeploymentDeviceInformation();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DeviceTransactions"))
            {
                initObject.DeviceTransactions = this.DeviceTransactions;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetCustomerInformation.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetCustomerInformation")]
    public class InitializeIntersightAssetCustomerInformation:PSCmdlet
	{
		public InitializeIntersightAssetCustomerInformation()
		{
            ClassId = AssetCustomerInformation.ClassIdEnum.AssetCustomerInformation;
            ObjectType = AssetCustomerInformation.ObjectTypeEnum.AssetCustomerInformation;
            
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
        
        public AssetCustomerInformation.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetCustomerInformation.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetCustomerInformation initObject = new Intersight.Model.AssetCustomerInformation();
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetMeteringType.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetMeteringType")]
    public class InitializeIntersightAssetMeteringType:PSCmdlet
	{
		public InitializeIntersightAssetMeteringType()
		{
            ClassId = AssetMeteringType.ClassIdEnum.AssetMeteringType;
            ObjectType = AssetMeteringType.ObjectTypeEnum.AssetMeteringType;
            
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
        
        public AssetMeteringType.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetMeteringType.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetMeteringType initObject = new Intersight.Model.AssetMeteringType();
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetOrchestrationHitachiVirtualStoragePlatformOptions.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetOrchestrationHitachiVirtualStoragePlatformOptions")]
    public class InitializeIntersightAssetOrchestrationHitachiVirtualStoragePlatformOptions:PSCmdlet
	{
		public InitializeIntersightAssetOrchestrationHitachiVirtualStoragePlatformOptions()
		{
            ClassId = AssetOrchestrationHitachiVirtualStoragePlatformOptions.ClassIdEnum.AssetOrchestrationHitachiVirtualStoragePlatformOptions;
            ObjectType = AssetOrchestrationHitachiVirtualStoragePlatformOptions.ObjectTypeEnum.AssetOrchestrationHitachiVirtualStoragePlatformOptions;
            
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
        
        public AssetOrchestrationHitachiVirtualStoragePlatformOptions.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetOrchestrationHitachiVirtualStoragePlatformOptions.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The DNS hostname or IP address of the Hitachi Ops Center API Configuration Manager used to manage the Hitachi Virtual Storage Platform."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string OpsCenterManagementAddress {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetOrchestrationHitachiVirtualStoragePlatformOptions initObject = new Intersight.Model.AssetOrchestrationHitachiVirtualStoragePlatformOptions();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OpsCenterManagementAddress"))
            {
                initObject.OpsCenterManagementAddress = this.OpsCenterManagementAddress;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetService.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetService")]
    public class InitializeIntersightAssetService:PSCmdlet
	{
		public InitializeIntersightAssetService()
		{
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetService.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetService.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Captures configuration that is specific to a target type for a specific service."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.AssetServiceOptions Options {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetService initObject = new Intersight.Model.AssetService();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Options"))
            {
                initObject.Options = this.Options;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetCredential.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetCredential")]
    public class InitializeIntersightAssetCredential:PSCmdlet
	{
		public InitializeIntersightAssetCredential()
		{
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetCredential.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetCredential.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetCredential initObject = new Intersight.Model.AssetCredential();
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetContractInformation.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetContractInformation")]
    public class InitializeIntersightAssetContractInformation:PSCmdlet
	{
		public InitializeIntersightAssetContractInformation()
		{
            ClassId = AssetContractInformation.ClassIdEnum.AssetContractInformation;
            ObjectType = AssetContractInformation.ObjectTypeEnum.AssetContractInformation;
            
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
        
        public AssetContractInformation.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetContractInformation.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetContractInformation initObject = new Intersight.Model.AssetContractInformation();
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetGlobalUltimate.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetGlobalUltimate")]
    public class InitializeIntersightAssetGlobalUltimate:PSCmdlet
	{
		public InitializeIntersightAssetGlobalUltimate()
		{
            ClassId = AssetGlobalUltimate.ClassIdEnum.AssetGlobalUltimate;
            ObjectType = AssetGlobalUltimate.ObjectTypeEnum.AssetGlobalUltimate;
            
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
        
        public AssetGlobalUltimate.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetGlobalUltimate.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetGlobalUltimate initObject = new Intersight.Model.AssetGlobalUltimate();
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetTerraformIntegrationTerraformAgentOptions.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetTerraformIntegrationTerraformAgentOptions")]
    public class InitializeIntersightAssetTerraformIntegrationTerraformAgentOptions:PSCmdlet
	{
		public InitializeIntersightAssetTerraformIntegrationTerraformAgentOptions()
		{
            ClassId = AssetTerraformIntegrationTerraformAgentOptions.ClassIdEnum.AssetTerraformIntegrationTerraformAgentOptions;
            ObjectType = AssetTerraformIntegrationTerraformAgentOptions.ObjectTypeEnum.AssetTerraformIntegrationTerraformAgentOptions;
            
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
        
        public AssetTerraformIntegrationTerraformAgentOptions.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> ManagedHosts {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetTerraformIntegrationTerraformAgentOptions.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Agent pool name for Terraform Agent platform type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string TerraformAgentPoolName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Organization for Terraform Agent platform type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string TerraformOrganization {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetTerraformIntegrationTerraformAgentOptions initObject = new Intersight.Model.AssetTerraformIntegrationTerraformAgentOptions();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ManagedHosts"))
            {
                initObject.ManagedHosts = this.ManagedHosts;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("TerraformAgentPoolName"))
            {
                initObject.TerraformAgentPoolName = this.TerraformAgentPoolName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TerraformOrganization"))
            {
                initObject.TerraformOrganization = this.TerraformOrganization;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetWorkloadOptimizerMicrosoftAzureApplicationInsightsOptions.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetWorkloadOptimizerMicrosoftAzureApplicationInsightsOptions")]
    public class InitializeIntersightAssetWorkloadOptimizerMicrosoftAzureApplicationInsightsOptions:PSCmdlet
	{
		public InitializeIntersightAssetWorkloadOptimizerMicrosoftAzureApplicationInsightsOptions()
		{
            ClassId = AssetWorkloadOptimizerMicrosoftAzureApplicationInsightsOptions.ClassIdEnum.AssetWorkloadOptimizerMicrosoftAzureApplicationInsightsOptions;
            ObjectType = AssetWorkloadOptimizerMicrosoftAzureApplicationInsightsOptions.ObjectTypeEnum.AssetWorkloadOptimizerMicrosoftAzureApplicationInsightsOptions;
            
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
        
        public AssetWorkloadOptimizerMicrosoftAzureApplicationInsightsOptions.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enrollment number of this Azure account."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string EnrollmentNumber {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetWorkloadOptimizerMicrosoftAzureApplicationInsightsOptions.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The offer ID of this account. Default value is \"MS-AZR-0003P\", a pay-as-you-go subscription lets you pay for the services and resources that you use on a monthly basis."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string OfferId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Azure Subscription ID."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SubscriptionId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Tenant ID associated with Azure Account."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string TenantId {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetWorkloadOptimizerMicrosoftAzureApplicationInsightsOptions initObject = new Intersight.Model.AssetWorkloadOptimizerMicrosoftAzureApplicationInsightsOptions();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("EnrollmentNumber"))
            {
                initObject.EnrollmentNumber = this.EnrollmentNumber;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OfferId"))
            {
                initObject.OfferId = this.OfferId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SubscriptionId"))
            {
                initObject.SubscriptionId = this.SubscriptionId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TenantId"))
            {
                initObject.TenantId = this.TenantId;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetAddressInformation.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetAddressInformation")]
    public class InitializeIntersightAssetAddressInformation:PSCmdlet
	{
		public InitializeIntersightAssetAddressInformation()
		{
            ClassId = AssetAddressInformation.ClassIdEnum.AssetAddressInformation;
            ObjectType = AssetAddressInformation.ObjectTypeEnum.AssetAddressInformation;
            
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
        
        public AssetAddressInformation.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetAddressInformation.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetAddressInformation initObject = new Intersight.Model.AssetAddressInformation();
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetOauthBearerTokenCredential.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetOauthBearerTokenCredential")]
    public class InitializeIntersightAssetOauthBearerTokenCredential:PSCmdlet
	{
		public InitializeIntersightAssetOauthBearerTokenCredential()
		{
            ClassId = AssetOauthBearerTokenCredential.ClassIdEnum.AssetOauthBearerTokenCredential;
            ObjectType = AssetOauthBearerTokenCredential.ObjectTypeEnum.AssetOauthBearerTokenCredential;
            
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
        
        public AssetOauthBearerTokenCredential.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetOauthBearerTokenCredential.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Scope type for the crendetial i.e. User, Organization, Team."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ScopeType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Scope value for the credential i.e. username, organization name or team name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ScopeValue {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The token used to authenticate with a managed target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Token {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.AssetOauthBearerTokenCredential initObject = new Intersight.Model.AssetOauthBearerTokenCredential();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ScopeType"))
            {
                initObject.ScopeType = this.ScopeType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ScopeValue"))
            {
                initObject.ScopeValue = this.ScopeValue;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Token"))
            {
                initObject.Token = this.Token;
            }
            WriteObject(initObject);
        }

    }
}