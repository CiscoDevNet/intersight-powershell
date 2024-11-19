using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetAddressInformation.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetAddressInformation")]
    public class InitializeIntersightAssetAddressInformation : PSCmdlet
    {
        public InitializeIntersightAssetAddressInformation()
        {
            ClassId = AssetAddressInformation.ClassIdEnum.AssetAddressInformation;
            ObjectType = AssetAddressInformation.ObjectTypeEnum.AssetAddressInformation;

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

        public AssetAddressInformation.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetAddressInformation.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetAlarmSummary.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetAlarmSummary")]
    public class InitializeIntersightAssetAlarmSummary : PSCmdlet
    {
        public InitializeIntersightAssetAlarmSummary()
        {
            ClassId = AssetAlarmSummary.ClassIdEnum.AssetAlarmSummary;
            ObjectType = AssetAlarmSummary.ObjectTypeEnum.AssetAlarmSummary;

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

        public AssetAlarmSummary.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetAlarmSummary.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.AssetAlarmSummary initObject = new Intersight.Model.AssetAlarmSummary();
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetApiKeyCredential.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetApiKeyCredential")]
    public class InitializeIntersightAssetApiKeyCredential : PSCmdlet
    {
        public InitializeIntersightAssetApiKeyCredential()
        {
            ClassId = AssetApiKeyCredential.ClassIdEnum.AssetApiKeyCredential;
            ObjectType = AssetApiKeyCredential.ObjectTypeEnum.AssetApiKeyCredential;

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
        /// <para type="description">"This a secret API key which can be used for authentication purposes for different targets like Azure Enterprise Agreement."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ApiKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetApiKeyCredential.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetApiKeyCredential.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetClaimSignature.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetClaimSignature")]
    public class InitializeIntersightAssetClaimSignature : PSCmdlet
    {
        public InitializeIntersightAssetClaimSignature()
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

        public AssetClaimSignature.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetClaimSignature.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The result of signing the deviceId appended with the timeStamp fields with the devices private key."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public byte[] Signature
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The time at which the signature was generated. Date is accurate to Intersights clock. Used to expire the signature."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime TimeStamp
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
            if (this.MyInvocation.BoundParameters.ContainsKey("TimeStamp"))
            {
                initObject.TimeStamp = this.TimeStamp;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetClientCertificateCredential.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetClientCertificateCredential")]
    public class InitializeIntersightAssetClientCertificateCredential : PSCmdlet
    {
        public InitializeIntersightAssetClientCertificateCredential()
        {
            ClassId = AssetClientCertificateCredential.ClassIdEnum.AssetClientCertificateCredential;
            ObjectType = AssetClientCertificateCredential.ObjectTypeEnum.AssetClientCertificateCredential;

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

        public AssetClientCertificateCredential.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"PEM encoded x509 client certificate used to authenticate with the target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ClientCertificate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"PEM encoded private key used to authenticate with the target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ClientKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetClientCertificateCredential.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetCloudConnection.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetCloudConnection")]
    public class InitializeIntersightAssetCloudConnection : PSCmdlet
    {
        public InitializeIntersightAssetCloudConnection()
        {
            ClassId = AssetCloudConnection.ClassIdEnum.AssetCloudConnection;
            ObjectType = AssetCloudConnection.ObjectTypeEnum.AssetCloudConnection;

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

        public AssetCloudConnection.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The credential to be used to authenticate with the managed target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetCredential Credential
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetCloudConnection.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetClusterMember.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetClusterMember")]
    public class InitializeIntersightAssetClusterMember : PSCmdlet
    {
        public InitializeIntersightAssetClusterMember()
        {
            ClassId = AssetClusterMember.ClassIdEnum.AssetClusterMember;
            ObjectType = AssetClusterMember.ObjectTypeEnum.AssetClusterMember;

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

        public AssetClusterMember.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Devices lock their leadership on failure to heartbeat with peers. Value acts as a third party tie breaker in election between nodes. Intersight enforces that only one cluster member exists with this value set to true."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool LockedLeader
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

        public AssetClusterMember.ObjectTypeEnum ObjectType
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.AssetClusterMember initObject = new Intersight.Model.AssetClusterMember();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("LockedLeader"))
            {
                initObject.LockedLeader = this.LockedLeader;
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetConnection.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetConnection")]
    public class InitializeIntersightAssetConnection : PSCmdlet
    {
        public InitializeIntersightAssetConnection()
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

        public AssetConnection.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The credential to be used to authenticate with the managed target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetCredential Credential
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetConnection.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetContractInformation.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetContractInformation")]
    public class InitializeIntersightAssetContractInformation : PSCmdlet
    {
        public InitializeIntersightAssetContractInformation()
        {
            ClassId = AssetContractInformation.ClassIdEnum.AssetContractInformation;
            ObjectType = AssetContractInformation.ObjectTypeEnum.AssetContractInformation;

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

        public AssetContractInformation.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetContractInformation.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetCredential.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetCredential")]
    public class InitializeIntersightAssetCredential : PSCmdlet
    {
        public InitializeIntersightAssetCredential()
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

        public AssetCredential.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetCredential.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetCustomerInformation.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetCustomerInformation")]
    public class InitializeIntersightAssetCustomerInformation : PSCmdlet
    {
        public InitializeIntersightAssetCustomerInformation()
        {
            ClassId = AssetCustomerInformation.ClassIdEnum.AssetCustomerInformation;
            ObjectType = AssetCustomerInformation.ObjectTypeEnum.AssetCustomerInformation;

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

        public AssetCustomerInformation.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetCustomerInformation.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetDeployment.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetDeployment")]
    public class InitializeIntersightAssetDeployment : PSCmdlet
    {
        public InitializeIntersightAssetDeployment()
        {
            ClassId = AssetDeployment.ClassIdEnum.AssetDeployment;
            ObjectType = AssetDeployment.ObjectTypeEnum.AssetDeployment;

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

        public AssetDeployment.ClassIdEnum ClassId
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

        public AssetDeployment.ObjectTypeEnum ObjectType
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.AssetDeployment initObject = new Intersight.Model.AssetDeployment();
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetDeploymentAlarmInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetDeploymentAlarmInfo")]
    public class InitializeIntersightAssetDeploymentAlarmInfo : PSCmdlet
    {
        public InitializeIntersightAssetDeploymentAlarmInfo()
        {
            ClassId = AssetDeploymentAlarmInfo.ClassIdEnum.AssetDeploymentAlarmInfo;
            ObjectType = AssetDeploymentAlarmInfo.ObjectTypeEnum.AssetDeploymentAlarmInfo;

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

        public AssetDeploymentAlarmInfo.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetDeploymentAlarmInfo.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.AssetDeploymentAlarmInfo initObject = new Intersight.Model.AssetDeploymentAlarmInfo();
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetDeploymentDevice.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetDeploymentDevice")]
    public class InitializeIntersightAssetDeploymentDevice : PSCmdlet
    {
        public InitializeIntersightAssetDeploymentDevice()
        {
            ClassId = AssetDeploymentDevice.ClassIdEnum.AssetDeploymentDevice;
            ObjectType = AssetDeploymentDevice.ObjectTypeEnum.AssetDeploymentDevice;

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

        public AssetDeploymentDevice.ClassIdEnum ClassId
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

        public AssetDeploymentDevice.ObjectTypeEnum ObjectType
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.AssetDeploymentDevice initObject = new Intersight.Model.AssetDeploymentDevice();
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetDeploymentDeviceAlarmInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetDeploymentDeviceAlarmInfo")]
    public class InitializeIntersightAssetDeploymentDeviceAlarmInfo : PSCmdlet
    {
        public InitializeIntersightAssetDeploymentDeviceAlarmInfo()
        {
            ClassId = AssetDeploymentDeviceAlarmInfo.ClassIdEnum.AssetDeploymentDeviceAlarmInfo;
            ObjectType = AssetDeploymentDeviceAlarmInfo.ObjectTypeEnum.AssetDeploymentDeviceAlarmInfo;

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

        public AssetDeploymentDeviceAlarmInfo.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetDeploymentDeviceAlarmInfo.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.AssetDeploymentDeviceAlarmInfo initObject = new Intersight.Model.AssetDeploymentDeviceAlarmInfo();
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetDeploymentDeviceInformation.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetDeploymentDeviceInformation")]
    public class InitializeIntersightAssetDeploymentDeviceInformation : PSCmdlet
    {
        public InitializeIntersightAssetDeploymentDeviceInformation()
        {
            ClassId = AssetDeploymentDeviceInformation.ClassIdEnum.AssetDeploymentDeviceInformation;
            ObjectType = AssetDeploymentDeviceInformation.ObjectTypeEnum.AssetDeploymentDeviceInformation;

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

        public AssetDeploymentDeviceInformation.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetDeploymentDeviceInformation.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.AssetDeploymentDeviceInformation initObject = new Intersight.Model.AssetDeploymentDeviceInformation();
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetDeviceClaim.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetDeviceClaim")]
    public class InitializeIntersightAssetDeviceClaim : PSCmdlet
    {
        public InitializeIntersightAssetDeviceClaim()
        {
            ClassId = AssetDeviceClaim.ClassIdEnum.AssetDeviceClaim;
            ObjectType = AssetDeviceClaim.ObjectTypeEnum.AssetDeviceClaim;

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

        public AssetDeviceClaim.ClassIdEnum ClassId
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

        public AssetDeviceClaim.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a resourceReservation resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.ResourceReservationRelationship Reservation
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Obtained from the device connector management UI or API (REST endpoint '/connector/SecurityTokens')."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SecurityToken
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Obtained from the device connector management UI or API (REST endpoint '/connector/DeviceIdentifiers')."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SerialNumber
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.AssetDeviceClaim initObject = new Intersight.Model.AssetDeviceClaim();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Reservation"))
            {
                initObject.Reservation = this.Reservation;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SecurityToken"))
            {
                initObject.SecurityToken = this.SecurityToken;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SerialNumber"))
            {
                initObject.SerialNumber = this.SerialNumber;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetDeviceConfiguration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetDeviceConfiguration")]
    public class InitializeIntersightAssetDeviceConfiguration : PSCmdlet
    {
        public InitializeIntersightAssetDeviceConfiguration()
        {
            ClassId = AssetDeviceConfiguration.ClassIdEnum.AssetDeviceConfiguration;
            ObjectType = AssetDeviceConfiguration.ObjectTypeEnum.AssetDeviceConfiguration;

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

        public AssetDeviceConfiguration.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specifies whether configuration through the platforms local management interface has been disabled, with only configuration through the Intersight service enabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool LocalConfigurationLocked
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The log level of the device connector service."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string LogLevel
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

        public AssetDeviceConfiguration.ObjectTypeEnum ObjectType
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.AssetDeviceConfiguration initObject = new Intersight.Model.AssetDeviceConfiguration();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("LocalConfigurationLocked"))
            {
                initObject.LocalConfigurationLocked = this.LocalConfigurationLocked;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LogLevel"))
            {
                initObject.LogLevel = this.LogLevel;
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetDeviceConnectorManager.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetDeviceConnectorManager")]
    public class InitializeIntersightAssetDeviceConnectorManager : PSCmdlet
    {
        public InitializeIntersightAssetDeviceConnectorManager()
        {
            ClassId = AssetDeviceConnectorManager.ClassIdEnum.AssetDeviceConnectorManager;
            ObjectType = AssetDeviceConnectorManager.ObjectTypeEnum.AssetDeviceConnectorManager;

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

        public AssetDeviceConnectorManager.ClassIdEnum ClassId
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

        public AssetDeviceConnectorManager.ObjectTypeEnum ObjectType
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.AssetDeviceConnectorManager initObject = new Intersight.Model.AssetDeviceConnectorManager();
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetDeviceContractInformation.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetDeviceContractInformation")]
    public class InitializeIntersightAssetDeviceContractInformation : PSCmdlet
    {
        public InitializeIntersightAssetDeviceContractInformation()
        {
            ClassId = AssetDeviceContractInformation.ClassIdEnum.AssetDeviceContractInformation;
            ObjectType = AssetDeviceContractInformation.ObjectTypeEnum.AssetDeviceContractInformation;
            StateContract = AssetDeviceContractInformation.StateContractEnum.Update;

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

        public AssetDeviceContractInformation.ClassIdEnum ClassId
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

        public AssetDeviceContractInformation.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Internal property used for triggering and tracking actions for contract information.\n* `Update` - Sn2Info/Contract information needs to be updated.\n* `OK` - Sn2Info/Contract information was fetched succcessfuly and updated.\n* `Failed` - Sn2Info/Contract information was not available  or failed while fetching.\n* `Retry` - Sn2Info/Contract information update failed and will be retried later."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetDeviceContractInformation.StateContractEnum StateContract
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.AssetDeviceContractInformation initObject = new Intersight.Model.AssetDeviceContractInformation();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("StateContract"))
            {
                initObject.StateContract = this.StateContract;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetDeviceContractNotification.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetDeviceContractNotification")]
    public class InitializeIntersightAssetDeviceContractNotification : PSCmdlet
    {
        public InitializeIntersightAssetDeviceContractNotification()
        {
            ClassId = AssetDeviceContractNotification.ClassIdEnum.AssetDeviceContractNotification;
            ContractStatus = AssetDeviceContractNotification.ContractStatusEnum.Unknown;
            ObjectType = AssetDeviceContractNotification.ObjectTypeEnum.AssetDeviceContractNotification;
            StateContract = AssetDeviceContractNotification.StateContractEnum.Update;
            StateSn2Info = AssetDeviceContractNotification.StateSn2InfoEnum.Update;

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

        public AssetDeviceContractNotification.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Contract information for the Cisco support contract purchased for the Cisco device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetContractInformation Contract
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Calculated contract status that is derived based on the service line status and contract end date. It is different from serviceLineStatus property. serviceLineStatus gives us ACTIVE, OVERDUE, EXPIRED. These are transformed into Active, Expiring Soon and Not Covered.\n* `Unknown` - The device's contract status cannot be determined.\n* `Not Covered` - The Cisco device does not have a valid support contract.\n* `Active` - The Cisco device is covered under a active support contract.\n* `Expiring Soon` - The contract for this Cisco device is going to expire in the next 30 days."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetDeviceContractNotification.ContractStatusEnum ContractStatus
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Reason for contract status. In case of Not Covered, reason is either Terminated or Expired.\n* `` - There is no reason for the specified contract status.\n* `Line Item Expired` - The Cisco device does not have a valid support contract, it has expired.\n* `Line Item Terminated` - The Cisco device does not have a valid support contract, it has been terminated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetDeviceContractNotification.ContractStatusReasonEnum ContractStatusReason
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Date and time indicating when the contract data is last refreshed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime ContractUpdatedTime
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"End date of the covered product line. The coverage end date is fetched from Cisco SN2INFO API."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string CoveredProductLineEndDate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Unique identifier of the Cisco device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string DeviceId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"End customer information for the Cisco support contract purchased for the Cisco device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetCustomerInformation EndCustomer
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"EndUserGlobalUltimate information listed in the contract."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetGlobalUltimate EndUserGlobalUltimate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Validates if the device is a genuine Cisco device. Validated is done using the Cisco SN2INFO APIs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsValid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Item type of this specific Cisco device. example \"Chassis\"."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ItemType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The last date of hardware support for this device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime LastDateOfSupport
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maintenance purchase order number for the Cisco device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string MaintenancePurchaseOrderNumber
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maintenance sales order number for the Cisco device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string MaintenanceSalesOrderNumber
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

        public AssetDeviceContractNotification.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Product information of the offering under a contract."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetProductInformation Product
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Purchase order number for the Cisco device. It is a unique number assigned for every purchase."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PurchaseOrderNumber
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"ResellerGlobalUltimate information listed in the contract."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetGlobalUltimate ResellerGlobalUltimate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Sales order number for the Cisco device. It is a unique number assigned for every sale."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SalesOrderNumber
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of service contract that covers the Cisco device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ServiceDescription
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"End date for the Cisco service contract that covers this Cisco device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime ServiceEndDate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of service contract that covers the Cisco device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ServiceLevel
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The SKU of the service contract that covers the Cisco device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ServiceSku
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Start date for the Cisco service contract that covers this Cisco device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime ServiceStartDate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Internal property used for triggering and tracking actions for contract information.\n* `Update` - Sn2Info/Contract information needs to be updated.\n* `OK` - Sn2Info/Contract information was fetched succcessfuly and updated.\n* `Failed` - Sn2Info/Contract information was not available  or failed while fetching.\n* `Retry` - Sn2Info/Contract information update failed and will be retried later."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetDeviceContractNotification.StateContractEnum StateContract
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Internal property used for triggering and tracking actions for sn2info information.\n* `Update` - Sn2Info/Contract information needs to be updated.\n* `OK` - Sn2Info/Contract information was fetched succcessfuly and updated.\n* `Failed` - Sn2Info/Contract information was not available  or failed while fetching.\n* `Retry` - Sn2Info/Contract information update failed and will be retried later."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetDeviceContractNotification.StateSn2InfoEnum StateSn2Info
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
        /// <para type="description">"End date for the warranty that covers the Cisco device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string WarrantyEndDate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of warranty that covers the Cisco device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string WarrantyType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.AssetDeviceContractNotification initObject = new Intersight.Model.AssetDeviceContractNotification();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Contract"))
            {
                initObject.Contract = this.Contract;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ContractStatus"))
            {
                initObject.ContractStatus = this.ContractStatus;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ContractStatusReason"))
            {
                initObject.ContractStatusReason = this.ContractStatusReason;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ContractUpdatedTime"))
            {
                initObject.ContractUpdatedTime = this.ContractUpdatedTime;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CoveredProductLineEndDate"))
            {
                initObject.CoveredProductLineEndDate = this.CoveredProductLineEndDate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DeviceId"))
            {
                initObject.DeviceId = this.DeviceId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndCustomer"))
            {
                initObject.EndCustomer = this.EndCustomer;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndUserGlobalUltimate"))
            {
                initObject.EndUserGlobalUltimate = this.EndUserGlobalUltimate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsValid"))
            {
                initObject.IsValid = this.IsValid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ItemType"))
            {
                initObject.ItemType = this.ItemType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LastDateOfSupport"))
            {
                initObject.LastDateOfSupport = this.LastDateOfSupport;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaintenancePurchaseOrderNumber"))
            {
                initObject.MaintenancePurchaseOrderNumber = this.MaintenancePurchaseOrderNumber;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaintenanceSalesOrderNumber"))
            {
                initObject.MaintenanceSalesOrderNumber = this.MaintenanceSalesOrderNumber;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Product"))
            {
                initObject.Product = this.Product;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PurchaseOrderNumber"))
            {
                initObject.PurchaseOrderNumber = this.PurchaseOrderNumber;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ResellerGlobalUltimate"))
            {
                initObject.ResellerGlobalUltimate = this.ResellerGlobalUltimate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SalesOrderNumber"))
            {
                initObject.SalesOrderNumber = this.SalesOrderNumber;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ServiceDescription"))
            {
                initObject.ServiceDescription = this.ServiceDescription;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ServiceEndDate"))
            {
                initObject.ServiceEndDate = this.ServiceEndDate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ServiceLevel"))
            {
                initObject.ServiceLevel = this.ServiceLevel;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ServiceSku"))
            {
                initObject.ServiceSku = this.ServiceSku;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ServiceStartDate"))
            {
                initObject.ServiceStartDate = this.ServiceStartDate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StateContract"))
            {
                initObject.StateContract = this.StateContract;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StateSn2Info"))
            {
                initObject.StateSn2Info = this.StateSn2Info;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("WarrantyEndDate"))
            {
                initObject.WarrantyEndDate = this.WarrantyEndDate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("WarrantyType"))
            {
                initObject.WarrantyType = this.WarrantyType;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetDeviceEndpointLocalCredential.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetDeviceEndpointLocalCredential")]
    public class InitializeIntersightAssetDeviceEndpointLocalCredential : PSCmdlet
    {
        public InitializeIntersightAssetDeviceEndpointLocalCredential()
        {
            ClassId = AssetDeviceEndpointLocalCredential.ClassIdEnum.AssetDeviceEndpointLocalCredential;
            ObjectType = AssetDeviceEndpointLocalCredential.ObjectTypeEnum.AssetDeviceEndpointLocalCredential;

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

        public AssetDeviceEndpointLocalCredential.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetDeviceEndpointLocalCredential.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.AssetDeviceEndpointLocalCredential initObject = new Intersight.Model.AssetDeviceEndpointLocalCredential();
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetDeviceInformation.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetDeviceInformation")]
    public class InitializeIntersightAssetDeviceInformation : PSCmdlet
    {
        public InitializeIntersightAssetDeviceInformation()
        {
            ClassId = AssetDeviceInformation.ClassIdEnum.AssetDeviceInformation;
            ObjectType = AssetDeviceInformation.ObjectTypeEnum.AssetDeviceInformation;

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

        public AssetDeviceInformation.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetDeviceInformation.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.AssetDeviceInformation initObject = new Intersight.Model.AssetDeviceInformation();
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetDeviceRegistration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetDeviceRegistration")]
    public class InitializeIntersightAssetDeviceRegistration : PSCmdlet
    {
        public InitializeIntersightAssetDeviceRegistration()
        {
            ClassId = AssetDeviceRegistration.ClassIdEnum.AssetDeviceRegistration;
            ObjectType = AssetDeviceRegistration.ObjectTypeEnum.AssetDeviceRegistration;

        }
        // <summary>
        /// <para type="description">"An identifier for the credential used by the device connector to authenticate with the Intersight web socket gateway."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string AccessKeyId
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

        public AssetDeviceRegistration.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates if the platform is an actual device or an emulated device for testing, demos, etc. Permitted values are [Normal, Emulator, ContainerEmulator].\n* `` - The device reported an empty or unrecognized executionMode.\n* `Normal` - The device connector is running in normal mode, i.e. it is not a simulation.\n* `Emulator` - The device connector is running in simulation mode inside an emulated device.\n* `ContainerEmulator` - The device connector is running in simulation mode inside a containerized emulated device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetDeviceRegistration.ExecutionModeEnum ExecutionMode
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

        public AssetDeviceRegistration.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A signature generated by a parent device or target used to auto-claim a device into a user account at time of registration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetClaimSignature ParentSignature
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The platform type on which device connector is executing.\n* `` - An unrecognized platform type.\n* `APIC` - A Cisco Application Policy Infrastructure Controller (APIC) cluster.\n* `CAPIC` - A Cisco Cloud Application Policy Infrastructure Controller (Cloud APIC) instance.\n* `DCNM` - A Cisco Data Center Network Manager (DCNM) instance.\n* `UCSFI` - A Cisco UCS Fabric Interconnect that is managed by Cisco UCS Manager (UCSM).\n* `UCSFIISM` - A Cisco UCS Fabric Interconnect that is managed by Cisco Intersight.\n* `IMC` - A standalone Cisco UCS rack server (Deprecated).\n* `IMCM4` - A standalone Cisco UCS C-Series or S-Series M4 server.\n* `IMCM5` - A standalone Cisco UCS C-Series or S-Series M5 server.\n* `IMCRack` - A standalone Cisco UCS C-Series or S-Series M6 or newer server.\n* `UCSIOM` - A Cisco UCS Blade Chassis I/O Module (IOM).\n* `HX` - A Cisco HyperFlex (HX) cluster.\n* `UCSD` - A Cisco UCS Director (UCSD) instance.\n* `IntersightAppliance` - A Cisco Intersight Connected Virtual Appliance instance.\n* `IntersightAssist` - A Cisco Intersight Assist instance.\n* `PureStorageFlashArray` - A Pure Storage FlashArray that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer and storage management features are supported on this device.\n* `NexusDevice` - A Cisco Nexus Network Switch that is managed using Cisco Intersight Assist.\n* `ACISwitch` - A Cisco Nexus Network Switch with the embedded Device Connector and is a part of the Cisco ACI fabric.\n* `NexusSwitch` - A standalone Cisco Nexus Network Switch with the embedded Device Connector.\n* `MDSSwitch` - A Cisco MDS Switch that is managed using the embedded Device Connector.\n* `MDSDevice` - A Cisco MDS Switch that is managed using Cisco Intersight Assist.\n* `UCSC890` - A standalone Cisco UCS C890 server managed using Cisco Intersight Assist.\n* `RedfishServer` - A generic target type for servers that support Redfish APIs and is managed using Cisco Intersight Assist. Support is limited to HPE and Dell Servers.\n* `NetAppOntap` - A Netapp ONTAP Storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `NetAppActiveIqUnifiedManager` - A NetApp Active IQ Unified Manager (AIQUM) that is managed using Cisco Intersight Assist.\n* `EmcScaleIo` - An EMC ScaleIO Software Defined Storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `EmcVmax` - An EMC VMAX 2 or 3 series enterprise storage array that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `EmcVplex` - An EMC VPLEX virtual storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `EmcXtremIo` - An EMC XtremIO SSD storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `VmwareVcenter` - A VMware vCenter instance that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer and Virtualization features are supported on this hypervisor.\n* `MicrosoftHyperV` - A Microsoft Hyper-V host that is managed using Cisco Intersight Assist. Optionally, other hosts in the cluster can be discovered through this host. Cisco Intersight Workload Optimizer features are supported on this hypervisor.\n* `AppDynamics` - An AppDynamics controller running in a SaaS or on-prem datacenter. On-prem AppDynamics instance is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this controller.\n* `Dynatrace` - A Dynatrace Server instance running in a SaaS or on-prem datacenter. On-prem Dynatrace instance is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this server.\n* `NewRelic` - A NewRelic user account. The NewRelic instance monitors the application infrastructure. Cisco Intersight Workload Optimizer features are supported on this server.\n* `ServiceNow` - A cloud-based workflow automation platform that enables enterprise organizations to improve operational efficiencies by streamlining and automating routine work tasks.\n* `Umbrella` - Umbrella cloud target that discovers and monitors an organization. It discovers entities like Datacenters, Devices, Tunnels, Networks, etc.\n* `CloudFoundry` - An open source cloud platform on which developers can build, deploy, run and scale applications.\n* `MicrosoftAzureApplicationInsights` - A feature of Azure Monitor, is an extensible Application Performance Management service for developers and DevOps professionals to monitor their live applications.\n* `OpenStack` - An OpenStack target manages Virtual Machines, Physical Machines, Datacenters and Virtual Datacenters using different OpenStack services as administrative endpoints.\n* `MicrosoftSqlServer` - A Microsoft SQL database server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this database.\n* `MySqlServer` - A MySQL database server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this database.\n* `OracleDatabaseServer` - An Oracle database server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this database.\n* `IBMWebSphereApplicationServer` - An IBM WebSphere Application server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this application server.\n* `OracleWebLogicServer` - Oracle WebLogic Server is a unified and extensible platform for developing, deploying and running enterprise applications, such as Java, for on-premises and in the cloud. WebLogic Server offers a robust, mature, and scalable implementation of Java Enterprise Edition (EE) and Jakarta EE.\n* `ApacheTomcatServer` - An Apache Tomcat server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this server.\n* `JavaVirtualMachine` - A JVM Application with JMX configured that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this application.\n* `RedHatJBossApplicationServer` - JBoss Application Server is an open-source, cross-platform Java application server developed by JBoss, a division of Red Hat Inc. It is an open-source implementation of Java 2 Enterprise Edition (J2EE) that is used for implementing Java applications and other Web-based applications and software.\n* `Kubernetes` - A Kubernetes cluster that runs containerized applications, with Kubernetes Collector installed. Cisco Intersight Workload Optimizer features are supported on Kubernetes cluster.\n* `AmazonWebService` - An Amazon Web Service cloud account. Cisco Intersight Workload Optimizer and Virtualization features are supported on this cloud.\n* `AmazonWebServiceBilling` - An Amazon Web Service cloud billing account used to retrieve billing information stored in S3 bucket. Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `GoogleCloudPlatform` - A Google Cloud Platform service account with access to one or more projects. Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `GoogleCloudPlatformBilling` - A Google Cloud Platform service account used to retrieve billing information from BigQuery. Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `MicrosoftAzureServicePrincipal` - A Microsoft Azure Service Principal account with access to Azure subscriptions. Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `MicrosoftAzureEnterpriseAgreement` - A Microsoft Azure Enterprise Agreement enrolment used to retrieve pricing and billing information. Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `MicrosoftAzureBilling` - A Microsoft Azure Service Principal account with access to billing information. Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `DellCompellent` - A Dell EMC SC Series (Compellent) storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `HPE3Par` - A HPE 3PAR StoreServ system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `RedHatEnterpriseVirtualization` - A Red Hat Enterprise Virtualization Hypervisor system that manages Virtual Machines.\n* `NutanixAcropolis` - A Nutanix Acropolis cluster that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this cluster.\n* `NutanixPrismCentral` - A Nutanix Prism Central cluster. Prism central is a virtual appliance for managing Nutanix clusters and services.\n* `HPEOneView` - A HPE OneView system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this system.\n* `ServiceEngine` - Cisco Application Services Engine. Cisco Application Services Engine is a platform to deploy and manage applications.\n* `HitachiVirtualStoragePlatform` - A Hitachi Virtual Storage Platform (Hitachi VSP) that is managed using Cisco Intersight Assist.\n* `GenericTarget` - A generic third-party target supported only in Partner Integration Appliance. This target type is used for development purposes and will not be supported in production environment.\n* `IMCBlade` - A Cisco UCS blade server managed by Cisco Intersight.\n* `TerraformCloud` - A Terraform Cloud Business Tier account.\n* `TerraformAgent` - A Terraform Cloud Agent that will be deployed on Cisco Intersight Assist. The agent can be used to plan and apply Terraform runs from a Terraform Cloud workspace.\n* `CustomTarget` - CustomTarget is deprecated. Use HTTPEndpoint type to claim HTTP endpoints.\n* `AnsibleEndpoint` - An external endpoint that is added as a target which can be accessed through Ansible in Intersight Cloud Orchestrator automation workflows.\n* `HTTPEndpoint` - An HTTP endpoint that can be accessed in Intersight Orchestrator workflows directly or using Cisco Intersight Assist. Authentication Schemes supported are Basic and Bearer Token.\n* `SSHEndpoint` - An SSH endpoint that can be accessed in Intersight Orchestrator workflows using Cisco Intersight Assist.\n* `CiscoCatalyst` - A Cisco Catalyst networking switch device.\n* `PowerShellEndpoint` - A Windows operating system server on which PowerShell scripts can be executed using Cisco Intersight Assist.\n* `CiscoDNAC` - A Cisco Digital Network Architecture (DNA) Center appliance.\n* `CiscoFMC` - A Cisco Secure Firewall Management Center.\n* `ViptelaCloud` - A Cisco Viptela SD-WAN Cloud.\n* `MerakiCloud` - A Cisco Meraki Organization.\n* `CiscoISE` - A Cisco Identity Services Engine (ISE) target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetDeviceRegistration.PlatformTypeEnum PlatformType
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.AssetDeviceRegistration initObject = new Intersight.Model.AssetDeviceRegistration();
            if (this.MyInvocation.BoundParameters.ContainsKey("AccessKeyId"))
            {
                initObject.AccessKeyId = this.AccessKeyId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ExecutionMode"))
            {
                initObject.ExecutionMode = this.ExecutionMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ParentSignature"))
            {
                initObject.ParentSignature = this.ParentSignature;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PlatformType"))
            {
                initObject.PlatformType = this.PlatformType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetDeviceStatistics.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetDeviceStatistics")]
    public class InitializeIntersightAssetDeviceStatistics : PSCmdlet
    {
        public InitializeIntersightAssetDeviceStatistics()
        {
            ClassId = AssetDeviceStatistics.ClassIdEnum.AssetDeviceStatistics;
            ObjectType = AssetDeviceStatistics.ObjectTypeEnum.AssetDeviceStatistics;

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

        public AssetDeviceStatistics.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetDeviceStatistics.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetDeviceTransaction.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetDeviceTransaction")]
    public class InitializeIntersightAssetDeviceTransaction : PSCmdlet
    {
        public InitializeIntersightAssetDeviceTransaction()
        {
            ClassId = AssetDeviceTransaction.ClassIdEnum.AssetDeviceTransaction;
            ObjectType = AssetDeviceTransaction.ObjectTypeEnum.AssetDeviceTransaction;

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

        public AssetDeviceTransaction.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetDeviceTransaction.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetGenericTargetClaimOptions.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetGenericTargetClaimOptions")]
    public class InitializeIntersightAssetGenericTargetClaimOptions : PSCmdlet
    {
        public InitializeIntersightAssetGenericTargetClaimOptions()
        {
            ClassId = AssetGenericTargetClaimOptions.ClassIdEnum.AssetGenericTargetClaimOptions;
            ObjectType = AssetGenericTargetClaimOptions.ObjectTypeEnum.AssetGenericTargetClaimOptions;

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

        public AssetGenericTargetClaimOptions.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetGenericTargetClaimOptions.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The generic device connector will consume these options."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object TargetOptions
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.AssetGenericTargetClaimOptions initObject = new Intersight.Model.AssetGenericTargetClaimOptions();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("TargetOptions"))
            {
                initObject.TargetOptions = this.TargetOptions;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetGlobalUltimate.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetGlobalUltimate")]
    public class InitializeIntersightAssetGlobalUltimate : PSCmdlet
    {
        public InitializeIntersightAssetGlobalUltimate()
        {
            ClassId = AssetGlobalUltimate.ClassIdEnum.AssetGlobalUltimate;
            ObjectType = AssetGlobalUltimate.ObjectTypeEnum.AssetGlobalUltimate;

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

        public AssetGlobalUltimate.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetGlobalUltimate.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetGoogleCloudPlatformServiceAccountKeyCredential.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetGoogleCloudPlatformServiceAccountKeyCredential")]
    public class InitializeIntersightAssetGoogleCloudPlatformServiceAccountKeyCredential : PSCmdlet
    {
        public InitializeIntersightAssetGoogleCloudPlatformServiceAccountKeyCredential()
        {
            ClassId = AssetGoogleCloudPlatformServiceAccountKeyCredential.ClassIdEnum.AssetGoogleCloudPlatformServiceAccountKeyCredential;
            KeyType = AssetGoogleCloudPlatformServiceAccountKeyCredential.KeyTypeEnum.JSON;
            ObjectType = AssetGoogleCloudPlatformServiceAccountKeyCredential.ObjectTypeEnum.AssetGoogleCloudPlatformServiceAccountKeyCredential;

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

        public AssetGoogleCloudPlatformServiceAccountKeyCredential.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Google Cloud Platform (GCP) service account's key type.\n* `JSON` - JavaScript Object Notation (JSON) is a standard text-based format for representing structured data based on JavaScript object syntax. It is commonly used for transmitting data in web applications.\n* `P12` - PKCS #12 is an archive file format for storing many cryptography objects as a single file. It is commonly used to bundle a private key with its X.509 certificate or to bundle all the members of a chain of trust."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetGoogleCloudPlatformServiceAccountKeyCredential.KeyTypeEnum KeyType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetGoogleCloudPlatformServiceAccountKeyCredential.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Google Cloud Platform (GCP) service account's key file content in the format of the keyType specified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ServiceAccountKey
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.AssetGoogleCloudPlatformServiceAccountKeyCredential initObject = new Intersight.Model.AssetGoogleCloudPlatformServiceAccountKeyCredential();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("KeyType"))
            {
                initObject.KeyType = this.KeyType;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ServiceAccountKey"))
            {
                initObject.ServiceAccountKey = this.ServiceAccountKey;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetHttpConnection.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetHttpConnection")]
    public class InitializeIntersightAssetHttpConnection : PSCmdlet
    {
        public InitializeIntersightAssetHttpConnection()
        {
            ClassId = AssetHttpConnection.ClassIdEnum.AssetHttpConnection;
            ObjectType = AssetHttpConnection.ObjectTypeEnum.AssetHttpConnection;

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
        /// <para type="description">"The certificate authority of the target. If set and connection is secure the connection will be validate using the servers identity with this certificate. If not set no validation will be done of the identity."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string CertificateAuthority
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetHttpConnection.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The credential to be used to authenticate with the managed target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetCredential Credential
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates whether a connection to the target should be established using HTTPS."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsSecure
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The DNS hostname or IP Address, either IPv4 or IPv6, to be used to connect to the managed target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ManagementAddress
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetHttpConnection.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The port number to be used to connect to the managed target. Values 1-65535 indicate a port number to be used. A value of 0 is not a valid port number and instead indicates that the default management port, as defined by the documentation of the managed target, should be used to establish a connection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Port
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetIntersightDeviceConnectorConnection.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetIntersightDeviceConnectorConnection")]
    public class InitializeIntersightAssetIntersightDeviceConnectorConnection : PSCmdlet
    {
        public InitializeIntersightAssetIntersightDeviceConnectorConnection()
        {
            ClassId = AssetIntersightDeviceConnectorConnection.ClassIdEnum.AssetIntersightDeviceConnectorConnection;
            ObjectType = AssetIntersightDeviceConnectorConnection.ObjectTypeEnum.AssetIntersightDeviceConnectorConnection;

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

        public AssetIntersightDeviceConnectorConnection.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The credential to be used to authenticate with the managed target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetCredential Credential
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetIntersightDeviceConnectorConnection.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetMerakiCloudOptions.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetMerakiCloudOptions")]
    public class InitializeIntersightAssetMerakiCloudOptions : PSCmdlet
    {
        public InitializeIntersightAssetMerakiCloudOptions()
        {
            ClassId = AssetMerakiCloudOptions.ClassIdEnum.AssetMerakiCloudOptions;
            ObjectType = AssetMerakiCloudOptions.ObjectTypeEnum.AssetMerakiCloudOptions;

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

        public AssetMerakiCloudOptions.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetMerakiCloudOptions.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Meraki organization id that is mapped to the target being claimed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string OrganizationId
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.AssetMerakiCloudOptions initObject = new Intersight.Model.AssetMerakiCloudOptions();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OrganizationId"))
            {
                initObject.OrganizationId = this.OrganizationId;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetMeteringType.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetMeteringType")]
    public class InitializeIntersightAssetMeteringType : PSCmdlet
    {
        public InitializeIntersightAssetMeteringType()
        {
            ClassId = AssetMeteringType.ClassIdEnum.AssetMeteringType;
            ObjectType = AssetMeteringType.ObjectTypeEnum.AssetMeteringType;

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

        public AssetMeteringType.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetMeteringType.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetNewRelicCredential.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetNewRelicCredential")]
    public class InitializeIntersightAssetNewRelicCredential : PSCmdlet
    {
        public InitializeIntersightAssetNewRelicCredential()
        {
            ClassId = AssetNewRelicCredential.ClassIdEnum.AssetNewRelicCredential;
            ObjectType = AssetNewRelicCredential.ObjectTypeEnum.AssetNewRelicCredential;

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

        public AssetNewRelicCredential.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A credential for authenticating with the NewRelic GraphQL interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetApiKeyCredential GraphQlCredential
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetNewRelicCredential.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A credential for authenticating with the NewRelic Rest API interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetApiKeyCredential RestApiCredential
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.AssetNewRelicCredential initObject = new Intersight.Model.AssetNewRelicCredential();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("GraphQlCredential"))
            {
                initObject.GraphQlCredential = this.GraphQlCredential;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RestApiCredential"))
            {
                initObject.RestApiCredential = this.RestApiCredential;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetNoAuthenticationCredential.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetNoAuthenticationCredential")]
    public class InitializeIntersightAssetNoAuthenticationCredential : PSCmdlet
    {
        public InitializeIntersightAssetNoAuthenticationCredential()
        {
            ClassId = AssetNoAuthenticationCredential.ClassIdEnum.AssetNoAuthenticationCredential;
            ObjectType = AssetNoAuthenticationCredential.ObjectTypeEnum.AssetNoAuthenticationCredential;

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

        public AssetNoAuthenticationCredential.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetNoAuthenticationCredential.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetOauthBearerTokenCredential.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetOauthBearerTokenCredential")]
    public class InitializeIntersightAssetOauthBearerTokenCredential : PSCmdlet
    {
        public InitializeIntersightAssetOauthBearerTokenCredential()
        {
            ClassId = AssetOauthBearerTokenCredential.ClassIdEnum.AssetOauthBearerTokenCredential;
            ObjectType = AssetOauthBearerTokenCredential.ObjectTypeEnum.AssetOauthBearerTokenCredential;

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

        public AssetOauthBearerTokenCredential.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetOauthBearerTokenCredential.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Scope type for the crendetial i.e. User, Organization, Team."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ScopeType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Scope value for the credential i.e. username, organization name or team name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ScopeValue
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The token used to authenticate with a managed target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Token
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetOauthClientIdSecretCredential.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetOauthClientIdSecretCredential")]
    public class InitializeIntersightAssetOauthClientIdSecretCredential : PSCmdlet
    {
        public InitializeIntersightAssetOauthClientIdSecretCredential()
        {
            ClassId = AssetOauthClientIdSecretCredential.ClassIdEnum.AssetOauthClientIdSecretCredential;
            ObjectType = AssetOauthClientIdSecretCredential.ObjectTypeEnum.AssetOauthClientIdSecretCredential;

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

        public AssetOauthClientIdSecretCredential.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The client ID used to authenticate with a managed target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ClientId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The client secret used to authenticate with a managed target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ClientSecret
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetOauthClientIdSecretCredential.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetOrchestrationCivpVmwareVcenterOptions.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetOrchestrationCivpVmwareVcenterOptions")]
    public class InitializeIntersightAssetOrchestrationCivpVmwareVcenterOptions : PSCmdlet
    {
        public InitializeIntersightAssetOrchestrationCivpVmwareVcenterOptions()
        {
            ClassId = AssetOrchestrationCivpVmwareVcenterOptions.ClassIdEnum.AssetOrchestrationCivpVmwareVcenterOptions;
            ObjectType = AssetOrchestrationCivpVmwareVcenterOptions.ObjectTypeEnum.AssetOrchestrationCivpVmwareVcenterOptions;

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
        /// <para type="description">"CivpEnabled controls whether VSphere Remote Plugin is enabled or not. vCenter Server version 8.0 or later."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool CivpEnabled
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetOrchestrationCivpVmwareVcenterOptions.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetOrchestrationCivpVmwareVcenterOptions.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.AssetOrchestrationCivpVmwareVcenterOptions initObject = new Intersight.Model.AssetOrchestrationCivpVmwareVcenterOptions();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CivpEnabled"))
            {
                initObject.CivpEnabled = this.CivpEnabled;
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
    public class InitializeIntersightAssetOrchestrationHitachiVirtualStoragePlatformOptions : PSCmdlet
    {
        public InitializeIntersightAssetOrchestrationHitachiVirtualStoragePlatformOptions()
        {
            ClassId = AssetOrchestrationHitachiVirtualStoragePlatformOptions.ClassIdEnum.AssetOrchestrationHitachiVirtualStoragePlatformOptions;
            ObjectType = AssetOrchestrationHitachiVirtualStoragePlatformOptions.ObjectTypeEnum.AssetOrchestrationHitachiVirtualStoragePlatformOptions;

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

        public AssetOrchestrationHitachiVirtualStoragePlatformOptions.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetOrchestrationHitachiVirtualStoragePlatformOptions.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The DNS hostname or IP address of the Hitachi Ops Center API Configuration Manager used to manage the Hitachi Virtual Storage Platform."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string OpsCenterManagementAddress
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetOrchestrationHsmVmwareVcenterOptions.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetOrchestrationHsmVmwareVcenterOptions")]
    public class InitializeIntersightAssetOrchestrationHsmVmwareVcenterOptions : PSCmdlet
    {
        public InitializeIntersightAssetOrchestrationHsmVmwareVcenterOptions()
        {
            ClassId = AssetOrchestrationHsmVmwareVcenterOptions.ClassIdEnum.AssetOrchestrationHsmVmwareVcenterOptions;
            ObjectType = AssetOrchestrationHsmVmwareVcenterOptions.ObjectTypeEnum.AssetOrchestrationHsmVmwareVcenterOptions;

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

        public AssetOrchestrationHsmVmwareVcenterOptions.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"HsmEnabled controls whether Hardware Support Manager is enabled or not. vCenter Server version 7.0 or later."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool HsmEnabled
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetOrchestrationHsmVmwareVcenterOptions.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.AssetOrchestrationHsmVmwareVcenterOptions initObject = new Intersight.Model.AssetOrchestrationHsmVmwareVcenterOptions();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("HsmEnabled"))
            {
                initObject.HsmEnabled = this.HsmEnabled;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetOrchestrationService.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetOrchestrationService")]
    public class InitializeIntersightAssetOrchestrationService : PSCmdlet
    {
        public InitializeIntersightAssetOrchestrationService()
        {
            ClassId = AssetOrchestrationService.ClassIdEnum.AssetOrchestrationService;
            ObjectType = AssetOrchestrationService.ObjectTypeEnum.AssetOrchestrationService;

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

        public AssetOrchestrationService.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetOrchestrationService.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Captures configuration that is specific to a target type for a specific service."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetServiceOptions Options
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetParentConnectionSignature.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetParentConnectionSignature")]
    public class InitializeIntersightAssetParentConnectionSignature : PSCmdlet
    {
        public InitializeIntersightAssetParentConnectionSignature()
        {
            ClassId = AssetParentConnectionSignature.ClassIdEnum.AssetParentConnectionSignature;
            ObjectType = AssetParentConnectionSignature.ObjectTypeEnum.AssetParentConnectionSignature;

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

        public AssetParentConnectionSignature.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The moid of the parent device registration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string DeviceId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The node identity of the parent device, corresponds to the parents ClusterMember.memberIdentity. Used on connect to establish through which device in a cluster the child is connected through."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string NodeId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetParentConnectionSignature.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The result of signing the deviceId appended with the timeStamp fields with the devices private key."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public byte[] Signature
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The time at which the signature was generated. Date is accurate to Intersights clock. Used to expire the signature."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime TimeStamp
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
            if (this.MyInvocation.BoundParameters.ContainsKey("TimeStamp"))
            {
                initObject.TimeStamp = this.TimeStamp;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetPrivateKeyCredential.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetPrivateKeyCredential")]
    public class InitializeIntersightAssetPrivateKeyCredential : PSCmdlet
    {
        public InitializeIntersightAssetPrivateKeyCredential()
        {
            ClassId = AssetPrivateKeyCredential.ClassIdEnum.AssetPrivateKeyCredential;
            ObjectType = AssetPrivateKeyCredential.ObjectTypeEnum.AssetPrivateKeyCredential;

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

        public AssetPrivateKeyCredential.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetPrivateKeyCredential.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The passphrase associated with the private key - Optional."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Passphrase
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The private key used to authenticate with a managed target. The corresponding public key needs to be added in the auth list of the remote endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PrivateKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The username used to authenticate with a managed target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Username
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.AssetPrivateKeyCredential initObject = new Intersight.Model.AssetPrivateKeyCredential();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Passphrase"))
            {
                initObject.Passphrase = this.Passphrase;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PrivateKey"))
            {
                initObject.PrivateKey = this.PrivateKey;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Username"))
            {
                initObject.Username = this.Username;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetProductInformation.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetProductInformation")]
    public class InitializeIntersightAssetProductInformation : PSCmdlet
    {
        public InitializeIntersightAssetProductInformation()
        {
            ClassId = AssetProductInformation.ClassIdEnum.AssetProductInformation;
            ObjectType = AssetProductInformation.ObjectTypeEnum.AssetProductInformation;

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

        public AssetProductInformation.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetProductInformation.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetScopedTargetConnection.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetScopedTargetConnection")]
    public class InitializeIntersightAssetScopedTargetConnection : PSCmdlet
    {
        public InitializeIntersightAssetScopedTargetConnection()
        {
            ClassId = AssetScopedTargetConnection.ClassIdEnum.AssetScopedTargetConnection;
            ObjectType = AssetScopedTargetConnection.ObjectTypeEnum.AssetScopedTargetConnection;

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

        public AssetScopedTargetConnection.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The credential to be used to authenticate with the managed target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetCredential Credential
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When this flag is set to true, every IWO entity in the scope targets will be checked and discovery of the scope target will be regarded as a failure when anyone of these entities cannot be connected and validated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool FullValidation
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates whether a connection to the target should be established using TLS."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsSecure
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetScopedTargetConnection.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The port number to be used to connect to the managed target. Values 1-65535 indicate a port number to be used. A value of 0 is not a valid port number and instead indicates that the default management port, as defined by the documentation of the managed target, should be used to establish a connection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Port
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The group id of IWO entities upon which the discover of a scoped target is performed. For example, a database target may be scoped to the group of virtual machines upon which the database application is running. Scope value is group id created for all those virtual machines in this scope."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Scope
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.AssetScopedTargetConnection initObject = new Intersight.Model.AssetScopedTargetConnection();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Credential"))
            {
                initObject.Credential = this.Credential;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FullValidation"))
            {
                initObject.FullValidation = this.FullValidation;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsSecure"))
            {
                initObject.IsSecure = this.IsSecure;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Port"))
            {
                initObject.Port = this.Port;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Scope"))
            {
                initObject.Scope = this.Scope;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetService.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetService")]
    public class InitializeIntersightAssetService : PSCmdlet
    {
        public InitializeIntersightAssetService()
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

        public AssetService.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetService.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Captures configuration that is specific to a target type for a specific service."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetServiceOptions Options
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetServiceNowCredential.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetServiceNowCredential")]
    public class InitializeIntersightAssetServiceNowCredential : PSCmdlet
    {
        public InitializeIntersightAssetServiceNowCredential()
        {
            ClassId = AssetServiceNowCredential.ClassIdEnum.AssetServiceNowCredential;
            ObjectType = AssetServiceNowCredential.ObjectTypeEnum.AssetServiceNowCredential;

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

        public AssetServiceNowCredential.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Optional client id/secret credential used for OAuth authentication with ServiceNow target. ServiceNow requires this to be used for OAuth authentication combining with user/password credential."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetOauthClientIdSecretCredential OauthAuthenticationCredential
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetServiceNowCredential.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Minimum required user/password credential to validate and discover ServiceNow target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetUsernamePasswordCredential UserPasswordCredential
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.AssetServiceNowCredential initObject = new Intersight.Model.AssetServiceNowCredential();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("OauthAuthenticationCredential"))
            {
                initObject.OauthAuthenticationCredential = this.OauthAuthenticationCredential;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("UserPasswordCredential"))
            {
                initObject.UserPasswordCredential = this.UserPasswordCredential;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetServiceOptions.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetServiceOptions")]
    public class InitializeIntersightAssetServiceOptions : PSCmdlet
    {
        public InitializeIntersightAssetServiceOptions()
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

        public AssetServiceOptions.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetServiceOptions.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetSshConnection.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetSshConnection")]
    public class InitializeIntersightAssetSshConnection : PSCmdlet
    {
        public InitializeIntersightAssetSshConnection()
        {
            ClassId = AssetSshConnection.ClassIdEnum.AssetSshConnection;
            ObjectType = AssetSshConnection.ObjectTypeEnum.AssetSshConnection;

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

        public AssetSshConnection.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The credential to be used to authenticate with the managed target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetCredential Credential
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The DNS hostname or IPv4 Address to be used to connect to the managed target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ManagementAddress
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetSshConnection.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The port number to be used to connect to the managed target. Valid values are 1 - 65535. If not provided, a default port of 22 is used to establish the SSH connection to the given target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Port
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.AssetSshConnection initObject = new Intersight.Model.AssetSshConnection();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Credential"))
            {
                initObject.Credential = this.Credential;
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetSubscription.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetSubscription")]
    public class InitializeIntersightAssetSubscription : PSCmdlet
    {
        public InitializeIntersightAssetSubscription()
        {
            ClassId = AssetSubscription.ClassIdEnum.AssetSubscription;
            ObjectType = AssetSubscription.ObjectTypeEnum.AssetSubscription;

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

        public AssetSubscription.ClassIdEnum ClassId
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

        public AssetSubscription.ObjectTypeEnum ObjectType
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.AssetSubscription initObject = new Intersight.Model.AssetSubscription();
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetSubscriptionAccount.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetSubscriptionAccount")]
    public class InitializeIntersightAssetSubscriptionAccount : PSCmdlet
    {
        public InitializeIntersightAssetSubscriptionAccount()
        {
            ClassId = AssetSubscriptionAccount.ClassIdEnum.AssetSubscriptionAccount;
            ObjectType = AssetSubscriptionAccount.ObjectTypeEnum.AssetSubscriptionAccount;

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

        public AssetSubscriptionAccount.ClassIdEnum ClassId
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

        public AssetSubscriptionAccount.ObjectTypeEnum ObjectType
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.AssetSubscriptionAccount initObject = new Intersight.Model.AssetSubscriptionAccount();
            if (this.MyInvocation.BoundParameters.ContainsKey("Account"))
            {
                initObject.Account = this.Account;
            }
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetSubscriptionDeviceContractInformation.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetSubscriptionDeviceContractInformation")]
    public class InitializeIntersightAssetSubscriptionDeviceContractInformation : PSCmdlet
    {
        public InitializeIntersightAssetSubscriptionDeviceContractInformation()
        {
            ClassId = AssetSubscriptionDeviceContractInformation.ClassIdEnum.AssetSubscriptionDeviceContractInformation;
            ObjectType = AssetSubscriptionDeviceContractInformation.ObjectTypeEnum.AssetSubscriptionDeviceContractInformation;

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

        public AssetSubscriptionDeviceContractInformation.ClassIdEnum ClassId
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

        public AssetSubscriptionDeviceContractInformation.ObjectTypeEnum ObjectType
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.AssetSubscriptionDeviceContractInformation initObject = new Intersight.Model.AssetSubscriptionDeviceContractInformation();
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetSudiInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetSudiInfo")]
    public class InitializeIntersightAssetSudiInfo : PSCmdlet
    {
        public InitializeIntersightAssetSudiInfo()
        {
            ClassId = AssetSudiInfo.ClassIdEnum.AssetSudiInfo;
            ObjectType = AssetSudiInfo.ObjectTypeEnum.AssetSudiInfo;

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

        public AssetSudiInfo.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetSudiInfo.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.AssetSudiInfo initObject = new Intersight.Model.AssetSudiInfo();
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetTarget.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetTarget")]
    public class InitializeIntersightAssetTarget : PSCmdlet
    {
        public InitializeIntersightAssetTarget()
        {
            ClassId = AssetTarget.ClassIdEnum.AssetTarget;
            ManagementLocation = AssetTarget.ManagementLocationEnum.Unknown;
            ObjectType = AssetTarget.ObjectTypeEnum.AssetTarget;

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
        /// <para type="description">"A reference to a assetTarget resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetTargetRelationship Assist
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetTarget.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.AssetConnection> Connections
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The location from which Intersight manages the target.\n* `Unknown` - The management mechanism is not detected. Unknown is used as a default by the implementation and is not an allowed user input.\n* `Intersight` - Management of a target is performed directly from Intersight. Network connections are established from Intersight to a management interface of the Target and authenticated using user provided credentials.\n* `IntersightAssist` - Management of a target is performed via a selected Intersight Assist. Network connections are established from the Intersight Assist to a management interface of the Target.\n* `DeviceConnector` - An Intersight Device Connector running within the Target establishes a connection to Intersight and management of the target is performed via this connection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetTarget.ManagementLocationEnum ManagementLocation
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
        /// <para type="description">"A user provided name for the managed target."</para>
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

        public AssetTarget.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.AssetService> Services
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
        /// <para type="description">"The type of the managed target. For example a UCS Server or VMware Vcenter target.\n* `` - An unrecognized platform type.\n* `APIC` - A Cisco Application Policy Infrastructure Controller (APIC) cluster.\n* `CAPIC` - A Cisco Cloud Application Policy Infrastructure Controller (Cloud APIC) instance.\n* `DCNM` - A Cisco Data Center Network Manager (DCNM) instance.\n* `UCSFI` - A Cisco UCS Fabric Interconnect that is managed by Cisco UCS Manager (UCSM).\n* `UCSFIISM` - A Cisco UCS Fabric Interconnect that is managed by Cisco Intersight.\n* `IMC` - A standalone Cisco UCS rack server (Deprecated).\n* `IMCM4` - A standalone Cisco UCS C-Series or S-Series M4 server.\n* `IMCM5` - A standalone Cisco UCS C-Series or S-Series M5 server.\n* `IMCRack` - A standalone Cisco UCS C-Series or S-Series M6 or newer server.\n* `UCSIOM` - A Cisco UCS Blade Chassis I/O Module (IOM).\n* `HX` - A Cisco HyperFlex (HX) cluster.\n* `UCSD` - A Cisco UCS Director (UCSD) instance.\n* `IntersightAppliance` - A Cisco Intersight Connected Virtual Appliance instance.\n* `IntersightAssist` - A Cisco Intersight Assist instance.\n* `PureStorageFlashArray` - A Pure Storage FlashArray that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer and storage management features are supported on this device.\n* `NexusDevice` - A Cisco Nexus Network Switch that is managed using Cisco Intersight Assist.\n* `ACISwitch` - A Cisco Nexus Network Switch with the embedded Device Connector and is a part of the Cisco ACI fabric.\n* `NexusSwitch` - A standalone Cisco Nexus Network Switch with the embedded Device Connector.\n* `MDSSwitch` - A Cisco MDS Switch that is managed using the embedded Device Connector.\n* `MDSDevice` - A Cisco MDS Switch that is managed using Cisco Intersight Assist.\n* `UCSC890` - A standalone Cisco UCS C890 server managed using Cisco Intersight Assist.\n* `RedfishServer` - A generic target type for servers that support Redfish APIs and is managed using Cisco Intersight Assist. Support is limited to HPE and Dell Servers.\n* `NetAppOntap` - A Netapp ONTAP Storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `NetAppActiveIqUnifiedManager` - A NetApp Active IQ Unified Manager (AIQUM) that is managed using Cisco Intersight Assist.\n* `EmcScaleIo` - An EMC ScaleIO Software Defined Storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `EmcVmax` - An EMC VMAX 2 or 3 series enterprise storage array that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `EmcVplex` - An EMC VPLEX virtual storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `EmcXtremIo` - An EMC XtremIO SSD storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `VmwareVcenter` - A VMware vCenter instance that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer and Virtualization features are supported on this hypervisor.\n* `MicrosoftHyperV` - A Microsoft Hyper-V host that is managed using Cisco Intersight Assist. Optionally, other hosts in the cluster can be discovered through this host. Cisco Intersight Workload Optimizer features are supported on this hypervisor.\n* `AppDynamics` - An AppDynamics controller running in a SaaS or on-prem datacenter. On-prem AppDynamics instance is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this controller.\n* `Dynatrace` - A Dynatrace Server instance running in a SaaS or on-prem datacenter. On-prem Dynatrace instance is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this server.\n* `NewRelic` - A NewRelic user account. The NewRelic instance monitors the application infrastructure. Cisco Intersight Workload Optimizer features are supported on this server.\n* `ServiceNow` - A cloud-based workflow automation platform that enables enterprise organizations to improve operational efficiencies by streamlining and automating routine work tasks.\n* `Umbrella` - Umbrella cloud target that discovers and monitors an organization. It discovers entities like Datacenters, Devices, Tunnels, Networks, etc.\n* `CloudFoundry` - An open source cloud platform on which developers can build, deploy, run and scale applications.\n* `MicrosoftAzureApplicationInsights` - A feature of Azure Monitor, is an extensible Application Performance Management service for developers and DevOps professionals to monitor their live applications.\n* `OpenStack` - An OpenStack target manages Virtual Machines, Physical Machines, Datacenters and Virtual Datacenters using different OpenStack services as administrative endpoints.\n* `MicrosoftSqlServer` - A Microsoft SQL database server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this database.\n* `MySqlServer` - A MySQL database server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this database.\n* `OracleDatabaseServer` - An Oracle database server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this database.\n* `IBMWebSphereApplicationServer` - An IBM WebSphere Application server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this application server.\n* `OracleWebLogicServer` - Oracle WebLogic Server is a unified and extensible platform for developing, deploying and running enterprise applications, such as Java, for on-premises and in the cloud. WebLogic Server offers a robust, mature, and scalable implementation of Java Enterprise Edition (EE) and Jakarta EE.\n* `ApacheTomcatServer` - An Apache Tomcat server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this server.\n* `JavaVirtualMachine` - A JVM Application with JMX configured that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this application.\n* `RedHatJBossApplicationServer` - JBoss Application Server is an open-source, cross-platform Java application server developed by JBoss, a division of Red Hat Inc. It is an open-source implementation of Java 2 Enterprise Edition (J2EE) that is used for implementing Java applications and other Web-based applications and software.\n* `Kubernetes` - A Kubernetes cluster that runs containerized applications, with Kubernetes Collector installed. Cisco Intersight Workload Optimizer features are supported on Kubernetes cluster.\n* `AmazonWebService` - An Amazon Web Service cloud account. Cisco Intersight Workload Optimizer and Virtualization features are supported on this cloud.\n* `AmazonWebServiceBilling` - An Amazon Web Service cloud billing account used to retrieve billing information stored in S3 bucket. Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `GoogleCloudPlatform` - A Google Cloud Platform service account with access to one or more projects. Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `GoogleCloudPlatformBilling` - A Google Cloud Platform service account used to retrieve billing information from BigQuery. Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `MicrosoftAzureServicePrincipal` - A Microsoft Azure Service Principal account with access to Azure subscriptions. Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `MicrosoftAzureEnterpriseAgreement` - A Microsoft Azure Enterprise Agreement enrolment used to retrieve pricing and billing information. Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `MicrosoftAzureBilling` - A Microsoft Azure Service Principal account with access to billing information. Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `DellCompellent` - A Dell EMC SC Series (Compellent) storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `HPE3Par` - A HPE 3PAR StoreServ system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `RedHatEnterpriseVirtualization` - A Red Hat Enterprise Virtualization Hypervisor system that manages Virtual Machines.\n* `NutanixAcropolis` - A Nutanix Acropolis cluster that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this cluster.\n* `NutanixPrismCentral` - A Nutanix Prism Central cluster. Prism central is a virtual appliance for managing Nutanix clusters and services.\n* `HPEOneView` - A HPE OneView system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this system.\n* `ServiceEngine` - Cisco Application Services Engine. Cisco Application Services Engine is a platform to deploy and manage applications.\n* `HitachiVirtualStoragePlatform` - A Hitachi Virtual Storage Platform (Hitachi VSP) that is managed using Cisco Intersight Assist.\n* `GenericTarget` - A generic third-party target supported only in Partner Integration Appliance. This target type is used for development purposes and will not be supported in production environment.\n* `IMCBlade` - A Cisco UCS blade server managed by Cisco Intersight.\n* `TerraformCloud` - A Terraform Cloud Business Tier account.\n* `TerraformAgent` - A Terraform Cloud Agent that will be deployed on Cisco Intersight Assist. The agent can be used to plan and apply Terraform runs from a Terraform Cloud workspace.\n* `CustomTarget` - CustomTarget is deprecated. Use HTTPEndpoint type to claim HTTP endpoints.\n* `AnsibleEndpoint` - An external endpoint that is added as a target which can be accessed through Ansible in Intersight Cloud Orchestrator automation workflows.\n* `HTTPEndpoint` - An HTTP endpoint that can be accessed in Intersight Orchestrator workflows directly or using Cisco Intersight Assist. Authentication Schemes supported are Basic and Bearer Token.\n* `SSHEndpoint` - An SSH endpoint that can be accessed in Intersight Orchestrator workflows using Cisco Intersight Assist.\n* `CiscoCatalyst` - A Cisco Catalyst networking switch device.\n* `PowerShellEndpoint` - A Windows operating system server on which PowerShell scripts can be executed using Cisco Intersight Assist.\n* `CiscoDNAC` - A Cisco Digital Network Architecture (DNA) Center appliance.\n* `CiscoFMC` - A Cisco Secure Firewall Management Center.\n* `ViptelaCloud` - A Cisco Viptela SD-WAN Cloud.\n* `MerakiCloud` - A Cisco Meraki Organization.\n* `CiscoISE` - A Cisco Identity Services Engine (ISE) target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetTarget.TargetTypeEnum TargetType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamTrustPoint resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamTrustPointRelationship TrustPoint
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.AssetTarget initObject = new Intersight.Model.AssetTarget();
            if (this.MyInvocation.BoundParameters.ContainsKey("Account"))
            {
                initObject.Account = this.Account;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Assist"))
            {
                initObject.Assist = this.Assist;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Connections"))
            {
                initObject.Connections = this.Connections;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ManagementLocation"))
            {
                initObject.ManagementLocation = this.ManagementLocation;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Services"))
            {
                initObject.Services = this.Services;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TargetType"))
            {
                initObject.TargetType = this.TargetType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TrustPoint"))
            {
                initObject.TrustPoint = this.TrustPoint;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetTargetKey.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetTargetKey")]
    public class InitializeIntersightAssetTargetKey : PSCmdlet
    {
        public InitializeIntersightAssetTargetKey()
        {
            ClassId = AssetTargetKey.ClassIdEnum.AssetTargetKey;
            ObjectType = AssetTargetKey.ObjectTypeEnum.AssetTargetKey;

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

        public AssetTargetKey.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetTargetKey.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
    public class InitializeIntersightAssetTargetSignature : PSCmdlet
    {
        public InitializeIntersightAssetTargetSignature()
        {
            ClassId = AssetTargetSignature.ClassIdEnum.AssetTargetSignature;
            ObjectType = AssetTargetSignature.ObjectTypeEnum.AssetTargetSignature;

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

        public AssetTargetSignature.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetTargetSignature.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The result of signing the deviceId appended with the timeStamp fields with the devices private key."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public byte[] Signature
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The moid of the associated target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string TargetId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The time at which the signature was generated. Date is accurate to Intersights clock. Used to expire the signature."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime TimeStamp
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
            if (this.MyInvocation.BoundParameters.ContainsKey("TimeStamp"))
            {
                initObject.TimeStamp = this.TimeStamp;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetTargetStatusDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetTargetStatusDetails")]
    public class InitializeIntersightAssetTargetStatusDetails : PSCmdlet
    {
        public InitializeIntersightAssetTargetStatusDetails()
        {
            ClassId = AssetTargetStatusDetails.ClassIdEnum.AssetTargetStatusDetails;
            ObjectType = AssetTargetStatusDetails.ObjectTypeEnum.AssetTargetStatusDetails;

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

        public AssetTargetStatusDetails.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetTargetStatusDetails.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetTerraformIntegrationService.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetTerraformIntegrationService")]
    public class InitializeIntersightAssetTerraformIntegrationService : PSCmdlet
    {
        public InitializeIntersightAssetTerraformIntegrationService()
        {
            ClassId = AssetTerraformIntegrationService.ClassIdEnum.AssetTerraformIntegrationService;
            ObjectType = AssetTerraformIntegrationService.ObjectTypeEnum.AssetTerraformIntegrationService;

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

        public AssetTerraformIntegrationService.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetTerraformIntegrationService.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Captures configuration that is specific to a target type for a specific service."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetServiceOptions Options
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetTerraformIntegrationTerraformAgentOptions.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetTerraformIntegrationTerraformAgentOptions")]
    public class InitializeIntersightAssetTerraformIntegrationTerraformAgentOptions : PSCmdlet
    {
        public InitializeIntersightAssetTerraformIntegrationTerraformAgentOptions()
        {
            ClassId = AssetTerraformIntegrationTerraformAgentOptions.ClassIdEnum.AssetTerraformIntegrationTerraformAgentOptions;
            ObjectType = AssetTerraformIntegrationTerraformAgentOptions.ObjectTypeEnum.AssetTerraformIntegrationTerraformAgentOptions;

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

        public AssetTerraformIntegrationTerraformAgentOptions.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> ManagedHosts
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetTerraformIntegrationTerraformAgentOptions.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Agent pool name for Terraform Agent platform type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string TerraformAgentPoolName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Organization for Terraform Agent platform type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string TerraformOrganization
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetTerraformIntegrationTerraformCloudOptions.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetTerraformIntegrationTerraformCloudOptions")]
    public class InitializeIntersightAssetTerraformIntegrationTerraformCloudOptions : PSCmdlet
    {
        public InitializeIntersightAssetTerraformIntegrationTerraformCloudOptions()
        {
            ClassId = AssetTerraformIntegrationTerraformCloudOptions.ClassIdEnum.AssetTerraformIntegrationTerraformCloudOptions;
            ObjectType = AssetTerraformIntegrationTerraformCloudOptions.ObjectTypeEnum.AssetTerraformIntegrationTerraformCloudOptions;

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

        public AssetTerraformIntegrationTerraformCloudOptions.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> DefaultManagedHosts
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Default organization for Terraform Cloud platform type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string DefaultTerraformOrganization
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetTerraformIntegrationTerraformCloudOptions.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetUsernamePasswordCredential.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetUsernamePasswordCredential")]
    public class InitializeIntersightAssetUsernamePasswordCredential : PSCmdlet
    {
        public InitializeIntersightAssetUsernamePasswordCredential()
        {
            ClassId = AssetUsernamePasswordCredential.ClassIdEnum.AssetUsernamePasswordCredential;
            ObjectType = AssetUsernamePasswordCredential.ObjectTypeEnum.AssetUsernamePasswordCredential;

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

        public AssetUsernamePasswordCredential.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetUsernamePasswordCredential.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The password used to authenticate with a managed target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Password
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The username used to authenticate with a managed target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Username
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetVirtualizationAmazonWebServiceOptions.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetVirtualizationAmazonWebServiceOptions")]
    public class InitializeIntersightAssetVirtualizationAmazonWebServiceOptions : PSCmdlet
    {
        public InitializeIntersightAssetVirtualizationAmazonWebServiceOptions()
        {
            ClassId = AssetVirtualizationAmazonWebServiceOptions.ClassIdEnum.AssetVirtualizationAmazonWebServiceOptions;
            ObjectType = AssetVirtualizationAmazonWebServiceOptions.ObjectTypeEnum.AssetVirtualizationAmazonWebServiceOptions;

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

        public AssetVirtualizationAmazonWebServiceOptions.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoMoRef> ManagedRegions
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetVirtualizationAmazonWebServiceOptions.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetVirtualizationService.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetVirtualizationService")]
    public class InitializeIntersightAssetVirtualizationService : PSCmdlet
    {
        public InitializeIntersightAssetVirtualizationService()
        {
            ClassId = AssetVirtualizationService.ClassIdEnum.AssetVirtualizationService;
            ObjectType = AssetVirtualizationService.ObjectTypeEnum.AssetVirtualizationService;

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

        public AssetVirtualizationService.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetVirtualizationService.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Captures configuration that is specific to a target type for a specific service."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetServiceOptions Options
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetVmHost.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetVmHost")]
    public class InitializeIntersightAssetVmHost : PSCmdlet
    {
        public InitializeIntersightAssetVmHost()
        {
            ClassId = AssetVmHost.ClassIdEnum.AssetVmHost;
            ObjectType = AssetVmHost.ObjectTypeEnum.AssetVmHost;

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

        public AssetVmHost.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetVmHost.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetWorkloadOptimizerAmazonWebServicesBillingOptions.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetWorkloadOptimizerAmazonWebServicesBillingOptions")]
    public class InitializeIntersightAssetWorkloadOptimizerAmazonWebServicesBillingOptions : PSCmdlet
    {
        public InitializeIntersightAssetWorkloadOptimizerAmazonWebServicesBillingOptions()
        {
            ClassId = AssetWorkloadOptimizerAmazonWebServicesBillingOptions.ClassIdEnum.AssetWorkloadOptimizerAmazonWebServicesBillingOptions;
            ObjectType = AssetWorkloadOptimizerAmazonWebServicesBillingOptions.ObjectTypeEnum.AssetWorkloadOptimizerAmazonWebServicesBillingOptions;

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

        public AssetWorkloadOptimizerAmazonWebServicesBillingOptions.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of S3 bucket that contains the Amazon web service Cost and Usage report to get cloud service spend."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string CostAndUsageReportBucket
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Report path prefix for the Amazon web service cost and usage report to get cloud service spend."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string CostAndUsageReportPath
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Region for S3 bucket that contains the Amazon web service Cost and Usage report to get cloud service spend."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string CostAndUsageReportRegion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetWorkloadOptimizerAmazonWebServicesBillingOptions.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetWorkloadOptimizerDynatraceOptions.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetWorkloadOptimizerDynatraceOptions")]
    public class InitializeIntersightAssetWorkloadOptimizerDynatraceOptions : PSCmdlet
    {
        public InitializeIntersightAssetWorkloadOptimizerDynatraceOptions()
        {
            ClassId = AssetWorkloadOptimizerDynatraceOptions.ClassIdEnum.AssetWorkloadOptimizerDynatraceOptions;
            ObjectType = AssetWorkloadOptimizerDynatraceOptions.ObjectTypeEnum.AssetWorkloadOptimizerDynatraceOptions;

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

        public AssetWorkloadOptimizerDynatraceOptions.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Collect tag information from Dynatrace."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool CollectTagInfo
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Overwrite Hypervisor or Cloud Provider Virtual Machine metrics with data from the target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool CollectVmMetrics
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Each environment monitored with Dynatrace is identified with a unique character string—the environment ID. The Dynatrace API relies heavily on environment IDs to ensure that it pulls monitoring data from and pushes relevant external events to the correct Dynatrace environments."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EnvironmentId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetWorkloadOptimizerDynatraceOptions.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.AssetWorkloadOptimizerDynatraceOptions initObject = new Intersight.Model.AssetWorkloadOptimizerDynatraceOptions();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CollectTagInfo"))
            {
                initObject.CollectTagInfo = this.CollectTagInfo;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CollectVmMetrics"))
            {
                initObject.CollectVmMetrics = this.CollectVmMetrics;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EnvironmentId"))
            {
                initObject.EnvironmentId = this.EnvironmentId;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetWorkloadOptimizerGoogleCloudPlatformBillingOptions.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetWorkloadOptimizerGoogleCloudPlatformBillingOptions")]
    public class InitializeIntersightAssetWorkloadOptimizerGoogleCloudPlatformBillingOptions : PSCmdlet
    {
        public InitializeIntersightAssetWorkloadOptimizerGoogleCloudPlatformBillingOptions()
        {
            ClassId = AssetWorkloadOptimizerGoogleCloudPlatformBillingOptions.ClassIdEnum.AssetWorkloadOptimizerGoogleCloudPlatformBillingOptions;
            ObjectType = AssetWorkloadOptimizerGoogleCloudPlatformBillingOptions.ObjectTypeEnum.AssetWorkloadOptimizerGoogleCloudPlatformBillingOptions;

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
        /// <para type="description">"The Google Cloud Platform (GCP) Billing Account ID."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string BillingAccountId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetWorkloadOptimizerGoogleCloudPlatformBillingOptions.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of Google BigQuery Cost Export Data Set which is the dataset for the billed cost export."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string CostExportDataSetName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Google BigQuery Cost Export Table Name. This table will store the exported data from the Cost Export."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string CostExportTableName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetWorkloadOptimizerGoogleCloudPlatformBillingOptions.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the BigQuery Pricing Export Data Set which is the dataset for negotiated pricing."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PricingExportDataSetName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Google BigQuery Pricing Export Table Name field is auto-populated with the table used in BigQuery, cloud_pricing_export. There is no need to modify this name, unless you use a different table for negotiated pricing. The Default name is \"cloud_pricing_export\"."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PricingExportTableName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique ID assigned to the project containing the cost and pricing exports. If the exports are in separate projects, multiple billing targets will be necessary."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ProjectId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This flag will enable querying of detailed usage cost with resource level information included. If not enabled, cost export data will be queried, if dataset and table name are provided."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool ResourceLevelCostEnabled
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.AssetWorkloadOptimizerGoogleCloudPlatformBillingOptions initObject = new Intersight.Model.AssetWorkloadOptimizerGoogleCloudPlatformBillingOptions();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BillingAccountId"))
            {
                initObject.BillingAccountId = this.BillingAccountId;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CostExportDataSetName"))
            {
                initObject.CostExportDataSetName = this.CostExportDataSetName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CostExportTableName"))
            {
                initObject.CostExportTableName = this.CostExportTableName;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PricingExportDataSetName"))
            {
                initObject.PricingExportDataSetName = this.PricingExportDataSetName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PricingExportTableName"))
            {
                initObject.PricingExportTableName = this.PricingExportTableName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ProjectId"))
            {
                initObject.ProjectId = this.ProjectId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ResourceLevelCostEnabled"))
            {
                initObject.ResourceLevelCostEnabled = this.ResourceLevelCostEnabled;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetWorkloadOptimizerHypervOptions.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetWorkloadOptimizerHypervOptions")]
    public class InitializeIntersightAssetWorkloadOptimizerHypervOptions : PSCmdlet
    {
        public InitializeIntersightAssetWorkloadOptimizerHypervOptions()
        {
            ClassId = AssetWorkloadOptimizerHypervOptions.ClassIdEnum.AssetWorkloadOptimizerHypervOptions;
            ObjectType = AssetWorkloadOptimizerHypervOptions.ObjectTypeEnum.AssetWorkloadOptimizerHypervOptions;

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

        public AssetWorkloadOptimizerHypervOptions.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When enabled, all Hyper-V hosts in the same cluster of specified Hyper-V host target will be discovered Each server must still be configured to allow remote management (for example, configuring WinRM using a GPO)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool DiscoverHostCluster
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Fully qualified domain name of the Hyper-V target. It is used to get the name of the Hyper-V cluster node and do Active Directory authentication process through Kerberos scheme."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string FullDomainName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetWorkloadOptimizerHypervOptions.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetWorkloadOptimizerMicrosoftAzureApplicationInsightsOptions.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetWorkloadOptimizerMicrosoftAzureApplicationInsightsOptions")]
    public class InitializeIntersightAssetWorkloadOptimizerMicrosoftAzureApplicationInsightsOptions : PSCmdlet
    {
        public InitializeIntersightAssetWorkloadOptimizerMicrosoftAzureApplicationInsightsOptions()
        {
            ClassId = AssetWorkloadOptimizerMicrosoftAzureApplicationInsightsOptions.ClassIdEnum.AssetWorkloadOptimizerMicrosoftAzureApplicationInsightsOptions;
            ObjectType = AssetWorkloadOptimizerMicrosoftAzureApplicationInsightsOptions.ObjectTypeEnum.AssetWorkloadOptimizerMicrosoftAzureApplicationInsightsOptions;

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

        public AssetWorkloadOptimizerMicrosoftAzureApplicationInsightsOptions.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enrollment number of this Azure account."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EnrollmentNumber
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetWorkloadOptimizerMicrosoftAzureApplicationInsightsOptions.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The offer ID of this account. Default value is \"MS-AZR-0003P\", a pay-as-you-go subscription lets you pay for the services and resources that you use on a monthly basis."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string OfferId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Azure Subscription ID."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SubscriptionId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Tenant ID associated with Azure Account."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string TenantId
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetWorkloadOptimizerMicrosoftAzureBillingOptions.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetWorkloadOptimizerMicrosoftAzureBillingOptions")]
    public class InitializeIntersightAssetWorkloadOptimizerMicrosoftAzureBillingOptions : PSCmdlet
    {
        public InitializeIntersightAssetWorkloadOptimizerMicrosoftAzureBillingOptions()
        {
            ClassId = AssetWorkloadOptimizerMicrosoftAzureBillingOptions.ClassIdEnum.AssetWorkloadOptimizerMicrosoftAzureBillingOptions;
            ObjectType = AssetWorkloadOptimizerMicrosoftAzureBillingOptions.ObjectTypeEnum.AssetWorkloadOptimizerMicrosoftAzureBillingOptions;

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
        /// <para type="description">"The Microsoft Azure Billing Account ID."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string BillingAccountId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetWorkloadOptimizerMicrosoftAzureBillingOptions.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the Cost Export Data that exports cost management data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string CostExportName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetWorkloadOptimizerMicrosoftAzureBillingOptions.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Id of the tenant used while authenticating the managed target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string TenantId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"For larger topologies, use cost export to fetch billed cost data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool UseCostExport
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.AssetWorkloadOptimizerMicrosoftAzureBillingOptions initObject = new Intersight.Model.AssetWorkloadOptimizerMicrosoftAzureBillingOptions();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BillingAccountId"))
            {
                initObject.BillingAccountId = this.BillingAccountId;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CostExportName"))
            {
                initObject.CostExportName = this.CostExportName;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("TenantId"))
            {
                initObject.TenantId = this.TenantId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UseCostExport"))
            {
                initObject.UseCostExport = this.UseCostExport;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetWorkloadOptimizerMicrosoftAzureEnterpriseAgreementOptions.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetWorkloadOptimizerMicrosoftAzureEnterpriseAgreementOptions")]
    public class InitializeIntersightAssetWorkloadOptimizerMicrosoftAzureEnterpriseAgreementOptions : PSCmdlet
    {
        public InitializeIntersightAssetWorkloadOptimizerMicrosoftAzureEnterpriseAgreementOptions()
        {
            ClassId = AssetWorkloadOptimizerMicrosoftAzureEnterpriseAgreementOptions.ClassIdEnum.AssetWorkloadOptimizerMicrosoftAzureEnterpriseAgreementOptions;
            ObjectType = AssetWorkloadOptimizerMicrosoftAzureEnterpriseAgreementOptions.ObjectTypeEnum.AssetWorkloadOptimizerMicrosoftAzureEnterpriseAgreementOptions;

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

        public AssetWorkloadOptimizerMicrosoftAzureEnterpriseAgreementOptions.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enrollment number for Azure EA."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EnrollmentNumber
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetWorkloadOptimizerMicrosoftAzureEnterpriseAgreementOptions.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetWorkloadOptimizerMicrosoftAzureServicePrincipalOptions.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetWorkloadOptimizerMicrosoftAzureServicePrincipalOptions")]
    public class InitializeIntersightAssetWorkloadOptimizerMicrosoftAzureServicePrincipalOptions : PSCmdlet
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Azure has different endpoints for managing Germany subscriptions. Azure cloud type helps in differentiating between regular subscriptions and Germany subscriptions to manage the Azure services for workload optimization. Documentation for germany cloud [link](https://docs.microsoft.com/en-us/azure/germany/germany-manage-subscriptions).\n* `Global` - Global cloud type for Azure subscription.\n* `Germany` - Germany cloud type for Azure subscription."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetWorkloadOptimizerMicrosoftAzureServicePrincipalOptions.AzureCloudTypeEnum AzureCloudType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetWorkloadOptimizerMicrosoftAzureServicePrincipalOptions.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetWorkloadOptimizerMicrosoftAzureServicePrincipalOptions.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"ID of the tenant used while authenticating the managed target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string TenantId
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetWorkloadOptimizerMicrosoftSqlServerOptions.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetWorkloadOptimizerMicrosoftSqlServerOptions")]
    public class InitializeIntersightAssetWorkloadOptimizerMicrosoftSqlServerOptions : PSCmdlet
    {
        public InitializeIntersightAssetWorkloadOptimizerMicrosoftSqlServerOptions()
        {
            ClassId = AssetWorkloadOptimizerMicrosoftSqlServerOptions.ClassIdEnum.AssetWorkloadOptimizerMicrosoftSqlServerOptions;
            ObjectType = AssetWorkloadOptimizerMicrosoftSqlServerOptions.ObjectTypeEnum.AssetWorkloadOptimizerMicrosoftSqlServerOptions;

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
        /// <para type="description">"Port that Microsoft SQL Server Browser listens for incoming requests for SQL Server resources and provides information about SQL Server instances that are installed on the computer. When this port is specified, Database will be communicated through the Browser Service with this port instead of default SQLServer port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long BrowserServicePort
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetWorkloadOptimizerMicrosoftSqlServerOptions.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Discovery path to define if its scope target entities or hostname or IP address."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string DiscoveryPath
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Active Directory domain, if required for this account."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string FullDomainName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetWorkloadOptimizerMicrosoftSqlServerOptions.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.AssetWorkloadOptimizerMicrosoftSqlServerOptions initObject = new Intersight.Model.AssetWorkloadOptimizerMicrosoftSqlServerOptions();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BrowserServicePort"))
            {
                initObject.BrowserServicePort = this.BrowserServicePort;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DiscoveryPath"))
            {
                initObject.DiscoveryPath = this.DiscoveryPath;
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetWorkloadOptimizerNewRelicOptions.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetWorkloadOptimizerNewRelicOptions")]
    public class InitializeIntersightAssetWorkloadOptimizerNewRelicOptions : PSCmdlet
    {
        public InitializeIntersightAssetWorkloadOptimizerNewRelicOptions()
        {
            ClassId = AssetWorkloadOptimizerNewRelicOptions.ClassIdEnum.AssetWorkloadOptimizerNewRelicOptions;
            ObjectType = AssetWorkloadOptimizerNewRelicOptions.ObjectTypeEnum.AssetWorkloadOptimizerNewRelicOptions;
            Region = AssetWorkloadOptimizerNewRelicOptions.RegionEnum.US;

        }
        // <summary>
        /// <para type="description">"Your NewRelic account id."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string AccountId
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

        public AssetWorkloadOptimizerNewRelicOptions.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Collect tag information from NewRelic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool CollectTagInfo
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Overwrite Hypervisor or Cloud Provider Virtual Machine metrics with data from the target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool CollectVmMetrics
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetWorkloadOptimizerNewRelicOptions.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The region associated with the NewRelic account.\n* `US` - The United States (US) region.\n* `EU` - The European Union (EU) region."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetWorkloadOptimizerNewRelicOptions.RegionEnum Region
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.AssetWorkloadOptimizerNewRelicOptions initObject = new Intersight.Model.AssetWorkloadOptimizerNewRelicOptions();
            if (this.MyInvocation.BoundParameters.ContainsKey("AccountId"))
            {
                initObject.AccountId = this.AccountId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CollectTagInfo"))
            {
                initObject.CollectTagInfo = this.CollectTagInfo;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CollectVmMetrics"))
            {
                initObject.CollectVmMetrics = this.CollectVmMetrics;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Region"))
            {
                initObject.Region = this.Region;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetWorkloadOptimizerOpenStackOptions.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetWorkloadOptimizerOpenStackOptions")]
    public class InitializeIntersightAssetWorkloadOptimizerOpenStackOptions : PSCmdlet
    {
        public InitializeIntersightAssetWorkloadOptimizerOpenStackOptions()
        {
            ClassId = AssetWorkloadOptimizerOpenStackOptions.ClassIdEnum.AssetWorkloadOptimizerOpenStackOptions;
            ObjectType = AssetWorkloadOptimizerOpenStackOptions.ObjectTypeEnum.AssetWorkloadOptimizerOpenStackOptions;

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

        public AssetWorkloadOptimizerOpenStackOptions.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"OpenStack Identity Service (keystone) domain name. Domain is an additional namespaces you can create in keystone to partition users, groups, and projects. Default domain name value is \"Default\"."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Domain
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetWorkloadOptimizerOpenStackOptions.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of tenant which has assigned administrator role this OpenStack target user is in. A tenant or project is referred to as a group of users of OpenStack. Each tenant can be assigned a role which gives all its member users their rights and privileges to perform a specific set of operations."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Tenant
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetWorkloadOptimizerOracleDatabaseServerOptions.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetWorkloadOptimizerOracleDatabaseServerOptions")]
    public class InitializeIntersightAssetWorkloadOptimizerOracleDatabaseServerOptions : PSCmdlet
    {
        public InitializeIntersightAssetWorkloadOptimizerOracleDatabaseServerOptions()
        {
            ClassId = AssetWorkloadOptimizerOracleDatabaseServerOptions.ClassIdEnum.AssetWorkloadOptimizerOracleDatabaseServerOptions;
            ObjectType = AssetWorkloadOptimizerOracleDatabaseServerOptions.ObjectTypeEnum.AssetWorkloadOptimizerOracleDatabaseServerOptions;

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

        public AssetWorkloadOptimizerOracleDatabaseServerOptions.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A unique name for an Oracle database instance on a specific host."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string DatabaseId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetWorkloadOptimizerOracleDatabaseServerOptions.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.AssetWorkloadOptimizerOracleDatabaseServerOptions initObject = new Intersight.Model.AssetWorkloadOptimizerOracleDatabaseServerOptions();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DatabaseId"))
            {
                initObject.DatabaseId = this.DatabaseId;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize AssetWorkloadOptimizerRedHatOpenStackOptions.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetWorkloadOptimizerRedHatOpenStackOptions")]
    public class InitializeIntersightAssetWorkloadOptimizerRedHatOpenStackOptions : PSCmdlet
    {
        public InitializeIntersightAssetWorkloadOptimizerRedHatOpenStackOptions()
        {
            ClassId = AssetWorkloadOptimizerRedHatOpenStackOptions.ClassIdEnum.AssetWorkloadOptimizerRedHatOpenStackOptions;
            ObjectType = AssetWorkloadOptimizerRedHatOpenStackOptions.ObjectTypeEnum.AssetWorkloadOptimizerRedHatOpenStackOptions;

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

        public AssetWorkloadOptimizerRedHatOpenStackOptions.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"RedHat OpenStack Identity Service (keystone) domain name. Domain is an additional namespaces you can create in keystone to partition users, groups, and projects. Default domain name value is \"Default\"."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Domain
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetWorkloadOptimizerRedHatOpenStackOptions.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of tenant which has assigned administrator role this RedHat OpenStack target user is in. A tenant or project is referred to as a group of users of RedHat OpenStack. Each tenant can be assigned a role which gives all its member users their rights and privileges to perform a specific set of operations."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Tenant
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetWorkloadOptimizerService.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetWorkloadOptimizerService")]
    public class InitializeIntersightAssetWorkloadOptimizerService : PSCmdlet
    {
        public InitializeIntersightAssetWorkloadOptimizerService()
        {
            ClassId = AssetWorkloadOptimizerService.ClassIdEnum.AssetWorkloadOptimizerService;
            ObjectType = AssetWorkloadOptimizerService.ObjectTypeEnum.AssetWorkloadOptimizerService;

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

        public AssetWorkloadOptimizerService.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetWorkloadOptimizerService.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Captures configuration that is specific to a target type for a specific service."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetServiceOptions Options
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
    /// <para type="synopsis">This is the cmdlet to Initialize AssetWorkloadOptimizerVmwareVcenterOptions.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightAssetWorkloadOptimizerVmwareVcenterOptions")]
    public class InitializeIntersightAssetWorkloadOptimizerVmwareVcenterOptions : PSCmdlet
    {
        public InitializeIntersightAssetWorkloadOptimizerVmwareVcenterOptions()
        {
            ClassId = AssetWorkloadOptimizerVmwareVcenterOptions.ClassIdEnum.AssetWorkloadOptimizerVmwareVcenterOptions;
            ObjectType = AssetWorkloadOptimizerVmwareVcenterOptions.ObjectTypeEnum.AssetWorkloadOptimizerVmwareVcenterOptions;

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

        public AssetWorkloadOptimizerVmwareVcenterOptions.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"DatastoreBrowsingEnabled controls whether Workload Optimizer scans vCenter datastores to identify files which are not used and can be deleted to reclaim space and improve actual disk utilization. For example orphaned VMDK files."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool DatastoreBrowsingEnabled
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enable retrieval of advanced memory metrics. Only supported on vCenter Server version 6.5U3 or later. Guest VMs must run VMWare Tools 10.3.2 Build 10338 or later."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool GuestMetricsEnabled
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public AssetWorkloadOptimizerVmwareVcenterOptions.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
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
            if (this.MyInvocation.BoundParameters.ContainsKey("GuestMetricsEnabled"))
            {
                initObject.GuestMetricsEnabled = this.GuestMetricsEnabled;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
}