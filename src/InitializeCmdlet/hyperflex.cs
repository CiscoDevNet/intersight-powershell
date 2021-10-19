using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexMapUuidToTrackedDisk.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexMapUuidToTrackedDisk")]
    public class InitializeIntersightHyperflexMapUuidToTrackedDisk:PSCmdlet
	{
		public InitializeIntersightHyperflexMapUuidToTrackedDisk()
		{
            ClassId = HyperflexMapUuidToTrackedDisk.ClassIdEnum.HyperflexMapUuidToTrackedDisk;
            ObjectType = HyperflexMapUuidToTrackedDisk.ObjectTypeEnum.HyperflexMapUuidToTrackedDisk;
            
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
        
        public HyperflexMapUuidToTrackedDisk.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexMapUuidToTrackedDisk.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexMapUuidToTrackedDisk initObject = new Intersight.Model.HyperflexMapUuidToTrackedDisk();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexHxLinkDt.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexHxLinkDt")]
    public class InitializeIntersightHyperflexHxLinkDt:PSCmdlet
	{
		public InitializeIntersightHyperflexHxLinkDt()
		{
            ClassId = HyperflexHxLinkDt.ClassIdEnum.HyperflexHxLinkDt;
            ObjectType = HyperflexHxLinkDt.ObjectTypeEnum.HyperflexHxLinkDt;
            
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
        
        public HyperflexHxLinkDt.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexHxLinkDt.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexHxLinkDt initObject = new Intersight.Model.HyperflexHxLinkDt();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexHxNetworkAddressDt.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexHxNetworkAddressDt")]
    public class InitializeIntersightHyperflexHxNetworkAddressDt:PSCmdlet
	{
		public InitializeIntersightHyperflexHxNetworkAddressDt()
		{
            ClassId = HyperflexHxNetworkAddressDt.ClassIdEnum.HyperflexHxNetworkAddressDt;
            ObjectType = HyperflexHxNetworkAddressDt.ObjectTypeEnum.HyperflexHxNetworkAddressDt;
            
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
        
        public HyperflexHxNetworkAddressDt.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexHxNetworkAddressDt.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexHxNetworkAddressDt initObject = new Intersight.Model.HyperflexHxNetworkAddressDt();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexReplicationPlatDatastore.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexReplicationPlatDatastore")]
    public class InitializeIntersightHyperflexReplicationPlatDatastore:PSCmdlet
	{
		public InitializeIntersightHyperflexReplicationPlatDatastore()
		{
            ClassId = HyperflexReplicationPlatDatastore.ClassIdEnum.HyperflexReplicationPlatDatastore;
            ObjectType = HyperflexReplicationPlatDatastore.ObjectTypeEnum.HyperflexReplicationPlatDatastore;
            
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
        
        public HyperflexReplicationPlatDatastore.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexReplicationPlatDatastore.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexReplicationPlatDatastore initObject = new Intersight.Model.HyperflexReplicationPlatDatastore();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexHxPlatformDatastoreConfigDt.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexHxPlatformDatastoreConfigDt")]
    public class InitializeIntersightHyperflexHxPlatformDatastoreConfigDt:PSCmdlet
	{
		public InitializeIntersightHyperflexHxPlatformDatastoreConfigDt()
		{
            ClassId = HyperflexHxPlatformDatastoreConfigDt.ClassIdEnum.HyperflexHxPlatformDatastoreConfigDt;
            ObjectType = HyperflexHxPlatformDatastoreConfigDt.ObjectTypeEnum.HyperflexHxPlatformDatastoreConfigDt;
            
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
        
        public HyperflexHxPlatformDatastoreConfigDt.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexHxPlatformDatastoreConfigDt.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexHxPlatformDatastoreConfigDt initObject = new Intersight.Model.HyperflexHxPlatformDatastoreConfigDt();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexNetworkPort.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexNetworkPort")]
    public class InitializeIntersightHyperflexNetworkPort:PSCmdlet
	{
		public InitializeIntersightHyperflexNetworkPort()
		{
            ClassId = HyperflexNetworkPort.ClassIdEnum.HyperflexNetworkPort;
            ObjectType = HyperflexNetworkPort.ObjectTypeEnum.HyperflexNetworkPort;
            
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
        
        public HyperflexNetworkPort.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the network port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexNetworkPort.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexNetworkPort initObject = new Intersight.Model.HyperflexNetworkPort();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexMacAddrPrefixRange.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexMacAddrPrefixRange")]
    public class InitializeIntersightHyperflexMacAddrPrefixRange:PSCmdlet
	{
		public InitializeIntersightHyperflexMacAddrPrefixRange()
		{
            ClassId = HyperflexMacAddrPrefixRange.ClassIdEnum.HyperflexMacAddrPrefixRange;
            ObjectType = HyperflexMacAddrPrefixRange.ObjectTypeEnum.HyperflexMacAddrPrefixRange;
            
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
        
        public HyperflexMacAddrPrefixRange.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The end MAC address prefix of a MAC address prefix range in the form of 00:25:B5:XX."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^00:25:B5:[0-9a-fA-F]{2}$")]
        public string EndAddr {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexMacAddrPrefixRange.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The start MAC address prefix of a MAC address prefix range in the form of 00:25:B5:XX."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^00:25:B5:[0-9a-fA-F]{2}$")]
        public string StartAddr {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexMacAddrPrefixRange initObject = new Intersight.Model.HyperflexMacAddrPrefixRange();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("EndAddr"))
            {
                initObject.EndAddr = this.EndAddr;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("StartAddr"))
            {
                initObject.StartAddr = this.StartAddr;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexHxResiliencyInfoDt.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexHxResiliencyInfoDt")]
    public class InitializeIntersightHyperflexHxResiliencyInfoDt:PSCmdlet
	{
		public InitializeIntersightHyperflexHxResiliencyInfoDt()
		{
            ClassId = HyperflexHxResiliencyInfoDt.ClassIdEnum.HyperflexHxResiliencyInfoDt;
            ObjectType = HyperflexHxResiliencyInfoDt.ObjectTypeEnum.HyperflexHxResiliencyInfoDt;
            
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
        
        public HyperflexHxResiliencyInfoDt.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexHxResiliencyInfoDt.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexHxResiliencyInfoDt initObject = new Intersight.Model.HyperflexHxResiliencyInfoDt();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexStPlatformClusterHealingInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexStPlatformClusterHealingInfo")]
    public class InitializeIntersightHyperflexStPlatformClusterHealingInfo:PSCmdlet
	{
		public InitializeIntersightHyperflexStPlatformClusterHealingInfo()
		{
            ClassId = HyperflexStPlatformClusterHealingInfo.ClassIdEnum.HyperflexStPlatformClusterHealingInfo;
            ObjectType = HyperflexStPlatformClusterHealingInfo.ObjectTypeEnum.HyperflexStPlatformClusterHealingInfo;
            
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
        
        public HyperflexStPlatformClusterHealingInfo.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexStPlatformClusterHealingInfo.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexStPlatformClusterHealingInfo initObject = new Intersight.Model.HyperflexStPlatformClusterHealingInfo();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexReplicationStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexReplicationStatus")]
    public class InitializeIntersightHyperflexReplicationStatus:PSCmdlet
	{
		public InitializeIntersightHyperflexReplicationStatus()
		{
            ClassId = HyperflexReplicationStatus.ClassIdEnum.HyperflexReplicationStatus;
            ObjectType = HyperflexReplicationStatus.ObjectTypeEnum.HyperflexReplicationStatus;
            
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
        
        public HyperflexReplicationStatus.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexReplicationStatus.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexReplicationStatus initObject = new Intersight.Model.HyperflexReplicationStatus();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexAlarmSummary.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexAlarmSummary")]
    public class InitializeIntersightHyperflexAlarmSummary:PSCmdlet
	{
		public InitializeIntersightHyperflexAlarmSummary()
		{
            ClassId = HyperflexAlarmSummary.ClassIdEnum.HyperflexAlarmSummary;
            ObjectType = HyperflexAlarmSummary.ObjectTypeEnum.HyperflexAlarmSummary;
            
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
        
        public HyperflexAlarmSummary.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The count of alarms that have severity type Critical."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Critical {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexAlarmSummary.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The count of alarms that have severity type Warning."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Warning {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexAlarmSummary initObject = new Intersight.Model.HyperflexAlarmSummary();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Critical"))
            {
                initObject.Critical = this.Critical;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Warning"))
            {
                initObject.Warning = this.Warning;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexDiskStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexDiskStatus")]
    public class InitializeIntersightHyperflexDiskStatus:PSCmdlet
	{
		public InitializeIntersightHyperflexDiskStatus()
		{
            ClassId = HyperflexDiskStatus.ClassIdEnum.HyperflexDiskStatus;
            ObjectType = HyperflexDiskStatus.ObjectTypeEnum.HyperflexDiskStatus;
            
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
        
        public HyperflexDiskStatus.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexDiskStatus.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexDiskStatus initObject = new Intersight.Model.HyperflexDiskStatus();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexHxSiteDt.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexHxSiteDt")]
    public class InitializeIntersightHyperflexHxSiteDt:PSCmdlet
	{
		public InitializeIntersightHyperflexHxSiteDt()
		{
            ClassId = HyperflexHxSiteDt.ClassIdEnum.HyperflexHxSiteDt;
            ObjectType = HyperflexHxSiteDt.ObjectTypeEnum.HyperflexHxSiteDt;
            
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
        
        public HyperflexHxSiteDt.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexHxSiteDt.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexHxSiteDt initObject = new Intersight.Model.HyperflexHxSiteDt();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexSummary.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexSummary")]
    public class InitializeIntersightHyperflexSummary:PSCmdlet
	{
		public InitializeIntersightHyperflexSummary()
		{
            ClassId = HyperflexSummary.ClassIdEnum.HyperflexSummary;
            ObjectType = HyperflexSummary.ObjectTypeEnum.HyperflexSummary;
            
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
        
        public HyperflexSummary.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexSummary.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexSummary initObject = new Intersight.Model.HyperflexSummary();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexTrackedDisk.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexTrackedDisk")]
    public class InitializeIntersightHyperflexTrackedDisk:PSCmdlet
	{
		public InitializeIntersightHyperflexTrackedDisk()
		{
            ClassId = HyperflexTrackedDisk.ClassIdEnum.HyperflexTrackedDisk;
            ObjectType = HyperflexTrackedDisk.ObjectTypeEnum.HyperflexTrackedDisk;
            
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
        
        public HyperflexTrackedDisk.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexTrackedDisk.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexTrackedDisk initObject = new Intersight.Model.HyperflexTrackedDisk();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexReplicationClusterReferenceToSchedule.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexReplicationClusterReferenceToSchedule")]
    public class InitializeIntersightHyperflexReplicationClusterReferenceToSchedule:PSCmdlet
	{
		public InitializeIntersightHyperflexReplicationClusterReferenceToSchedule()
		{
            ClassId = HyperflexReplicationClusterReferenceToSchedule.ClassIdEnum.HyperflexReplicationClusterReferenceToSchedule;
            ObjectType = HyperflexReplicationClusterReferenceToSchedule.ObjectTypeEnum.HyperflexReplicationClusterReferenceToSchedule;
            
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
        
        public HyperflexReplicationClusterReferenceToSchedule.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexReplicationClusterReferenceToSchedule.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexReplicationClusterReferenceToSchedule initObject = new Intersight.Model.HyperflexReplicationClusterReferenceToSchedule();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexRpoStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexRpoStatus")]
    public class InitializeIntersightHyperflexRpoStatus:PSCmdlet
	{
		public InitializeIntersightHyperflexRpoStatus()
		{
            ClassId = HyperflexRpoStatus.ClassIdEnum.HyperflexRpoStatus;
            ObjectType = HyperflexRpoStatus.ObjectTypeEnum.HyperflexRpoStatus;
            
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
        
        public HyperflexRpoStatus.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexRpoStatus.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexRpoStatus initObject = new Intersight.Model.HyperflexRpoStatus();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexIpAddrRange.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexIpAddrRange")]
    public class InitializeIntersightHyperflexIpAddrRange:PSCmdlet
	{
		public InitializeIntersightHyperflexIpAddrRange()
		{
            ClassId = HyperflexIpAddrRange.ClassIdEnum.HyperflexIpAddrRange;
            ObjectType = HyperflexIpAddrRange.ObjectTypeEnum.HyperflexIpAddrRange;
            
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
        
        public HyperflexIpAddrRange.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The end IPv4 address of the range."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string EndAddr {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The default gateway for the start and end IPv4 addresses."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string Gateway {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.CommIpV4AddressBlock> IpAddrBlocks {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The netmask specified in dot decimal notation.\nThe start address, end address, and gateway must all be within the network specified by this netmask."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^(((255\\.){3}(255|254|252|248|240|224|192|128|0+))|((255\\.){2}(255|254|252|248|240|224|192|128|0+)\\.0)|((255\\.)(255|254|252|248|240|224|192|128|0+)(\\.0+){2})|((255|254|252|248|240|224|192|128|0+)(\\.0+){3}))$")]
        public string Netmask {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexIpAddrRange.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The start IPv4 address of the range."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string StartAddr {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexIpAddrRange initObject = new Intersight.Model.HyperflexIpAddrRange();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("EndAddr"))
            {
                initObject.EndAddr = this.EndAddr;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Gateway"))
            {
                initObject.Gateway = this.Gateway;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpAddrBlocks"))
            {
                initObject.IpAddrBlocks = this.IpAddrBlocks;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Netmask"))
            {
                initObject.Netmask = this.Netmask;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("StartAddr"))
            {
                initObject.StartAddr = this.StartAddr;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexProtectionInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexProtectionInfo")]
    public class InitializeIntersightHyperflexProtectionInfo:PSCmdlet
	{
		public InitializeIntersightHyperflexProtectionInfo()
		{
            ClassId = HyperflexProtectionInfo.ClassIdEnum.HyperflexProtectionInfo;
            ObjectType = HyperflexProtectionInfo.ObjectTypeEnum.HyperflexProtectionInfo;
            
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
        
        public HyperflexProtectionInfo.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexProtectionInfo.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexProtectionInfo initObject = new Intersight.Model.HyperflexProtectionInfo();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexHxZoneResiliencyInfoDt.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexHxZoneResiliencyInfoDt")]
    public class InitializeIntersightHyperflexHxZoneResiliencyInfoDt:PSCmdlet
	{
		public InitializeIntersightHyperflexHxZoneResiliencyInfoDt()
		{
            ClassId = HyperflexHxZoneResiliencyInfoDt.ClassIdEnum.HyperflexHxZoneResiliencyInfoDt;
            ObjectType = HyperflexHxZoneResiliencyInfoDt.ObjectTypeEnum.HyperflexHxZoneResiliencyInfoDt;
            
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
        
        public HyperflexHxZoneResiliencyInfoDt.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexHxZoneResiliencyInfoDt.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexHxZoneResiliencyInfoDt initObject = new Intersight.Model.HyperflexHxZoneResiliencyInfoDt();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexServerFirmwareVersionInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexServerFirmwareVersionInfo")]
    public class InitializeIntersightHyperflexServerFirmwareVersionInfo:PSCmdlet
	{
		public InitializeIntersightHyperflexServerFirmwareVersionInfo()
		{
            ClassId = HyperflexServerFirmwareVersionInfo.ClassIdEnum.HyperflexServerFirmwareVersionInfo;
            ObjectType = HyperflexServerFirmwareVersionInfo.ObjectTypeEnum.HyperflexServerFirmwareVersionInfo;
            ServerPlatform = HyperflexServerFirmwareVersionInfo.ServerPlatformEnum.M5;
            
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
        
        public HyperflexServerFirmwareVersionInfo.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexServerFirmwareVersionInfo.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The platform type for UCS server.\n* `M5` - M5 generation of UCS server.\n* `M3` - M3 generation of UCS server.\n* `M4` - M4 generation of UCS server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexServerFirmwareVersionInfo.ServerPlatformEnum ServerPlatform {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The server firmware bundle version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("(^3\\.[1-9]\\([1-9][a-z]\\)$|^[4-9]\\.[0-9]\\([1-9][a-z]\\)$)")]
        public string Version {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexServerFirmwareVersionInfo initObject = new Intersight.Model.HyperflexServerFirmwareVersionInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ServerPlatform"))
            {
                initObject.ServerPlatform = this.ServerPlatform;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexSnapshotInfoBrief.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexSnapshotInfoBrief")]
    public class InitializeIntersightHyperflexSnapshotInfoBrief:PSCmdlet
	{
		public InitializeIntersightHyperflexSnapshotInfoBrief()
		{
            ClassId = HyperflexSnapshotInfoBrief.ClassIdEnum.HyperflexSnapshotInfoBrief;
            ObjectType = HyperflexSnapshotInfoBrief.ObjectTypeEnum.HyperflexSnapshotInfoBrief;
            
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
        
        public HyperflexSnapshotInfoBrief.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexSnapshotInfoBrief.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexSnapshotInfoBrief initObject = new Intersight.Model.HyperflexSnapshotInfoBrief();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexWwxnPrefixRange.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexWwxnPrefixRange")]
    public class InitializeIntersightHyperflexWwxnPrefixRange:PSCmdlet
	{
		public InitializeIntersightHyperflexWwxnPrefixRange()
		{
            ClassId = HyperflexWwxnPrefixRange.ClassIdEnum.HyperflexWwxnPrefixRange;
            ObjectType = HyperflexWwxnPrefixRange.ObjectTypeEnum.HyperflexWwxnPrefixRange;
            
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
        
        public HyperflexWwxnPrefixRange.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The end WWxN prefix of a WWPN/WWNN range in the form of 20:00:00:25:B5:XX."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^20:00:00:25:B5:[0-9a-fA-F]{2}$")]
        public string EndAddr {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexWwxnPrefixRange.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The start WWxN prefix of a WWPN/WWNN range in the form of 20:00:00:25:B5:XX."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^20:00:00:25:B5:[0-9a-fA-F]{2}$")]
        public string StartAddr {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexWwxnPrefixRange initObject = new Intersight.Model.HyperflexWwxnPrefixRange();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("EndAddr"))
            {
                initObject.EndAddr = this.EndAddr;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("StartAddr"))
            {
                initObject.StartAddr = this.StartAddr;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexBondState.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexBondState")]
    public class InitializeIntersightHyperflexBondState:PSCmdlet
	{
		public InitializeIntersightHyperflexBondState()
		{
            ClassId = HyperflexBondState.ClassIdEnum.HyperflexBondState;
            ObjectType = HyperflexBondState.ObjectTypeEnum.HyperflexBondState;
            
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
        
        public HyperflexBondState.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexBondState.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexBondState initObject = new Intersight.Model.HyperflexBondState();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexErrorStack.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexErrorStack")]
    public class InitializeIntersightHyperflexErrorStack:PSCmdlet
	{
		public InitializeIntersightHyperflexErrorStack()
		{
            ClassId = HyperflexErrorStack.ClassIdEnum.HyperflexErrorStack;
            ObjectType = HyperflexErrorStack.ObjectTypeEnum.HyperflexErrorStack;
            
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
        
        public HyperflexErrorStack.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexErrorStack.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexErrorStack initObject = new Intersight.Model.HyperflexErrorStack();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexHxLicenseAuthorizationDetailsDt.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexHxLicenseAuthorizationDetailsDt")]
    public class InitializeIntersightHyperflexHxLicenseAuthorizationDetailsDt:PSCmdlet
	{
		public InitializeIntersightHyperflexHxLicenseAuthorizationDetailsDt()
		{
            ClassId = HyperflexHxLicenseAuthorizationDetailsDt.ClassIdEnum.HyperflexHxLicenseAuthorizationDetailsDt;
            ObjectType = HyperflexHxLicenseAuthorizationDetailsDt.ObjectTypeEnum.HyperflexHxLicenseAuthorizationDetailsDt;
            
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
        
        public HyperflexHxLicenseAuthorizationDetailsDt.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexHxLicenseAuthorizationDetailsDt.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexHxLicenseAuthorizationDetailsDt initObject = new Intersight.Model.HyperflexHxLicenseAuthorizationDetailsDt();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexHealthCheckScriptInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexHealthCheckScriptInfo")]
    public class InitializeIntersightHyperflexHealthCheckScriptInfo:PSCmdlet
	{
		public InitializeIntersightHyperflexHealthCheckScriptInfo()
		{
            ClassId = HyperflexHealthCheckScriptInfo.ClassIdEnum.HyperflexHealthCheckScriptInfo;
            ObjectType = HyperflexHealthCheckScriptInfo.ObjectTypeEnum.HyperflexHealthCheckScriptInfo;
            
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
        
        public HyperflexHealthCheckScriptInfo.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexHealthCheckScriptInfo.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexHealthCheckScriptInfo initObject = new Intersight.Model.HyperflexHealthCheckScriptInfo();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexMapClusterIdToProtectionInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexMapClusterIdToProtectionInfo")]
    public class InitializeIntersightHyperflexMapClusterIdToProtectionInfo:PSCmdlet
	{
		public InitializeIntersightHyperflexMapClusterIdToProtectionInfo()
		{
            ClassId = HyperflexMapClusterIdToProtectionInfo.ClassIdEnum.HyperflexMapClusterIdToProtectionInfo;
            ObjectType = HyperflexMapClusterIdToProtectionInfo.ObjectTypeEnum.HyperflexMapClusterIdToProtectionInfo;
            
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
        
        public HyperflexMapClusterIdToProtectionInfo.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexMapClusterIdToProtectionInfo.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexMapClusterIdToProtectionInfo initObject = new Intersight.Model.HyperflexMapClusterIdToProtectionInfo();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexSnapshotFiles.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexSnapshotFiles")]
    public class InitializeIntersightHyperflexSnapshotFiles:PSCmdlet
	{
		public InitializeIntersightHyperflexSnapshotFiles()
		{
            ClassId = HyperflexSnapshotFiles.ClassIdEnum.HyperflexSnapshotFiles;
            ObjectType = HyperflexSnapshotFiles.ObjectTypeEnum.HyperflexSnapshotFiles;
            
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
        
        public HyperflexSnapshotFiles.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexSnapshotFiles.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexSnapshotFiles initObject = new Intersight.Model.HyperflexSnapshotFiles();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexStPlatformClusterResiliencyInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexStPlatformClusterResiliencyInfo")]
    public class InitializeIntersightHyperflexStPlatformClusterResiliencyInfo:PSCmdlet
	{
		public InitializeIntersightHyperflexStPlatformClusterResiliencyInfo()
		{
            ClassId = HyperflexStPlatformClusterResiliencyInfo.ClassIdEnum.HyperflexStPlatformClusterResiliencyInfo;
            ObjectType = HyperflexStPlatformClusterResiliencyInfo.ObjectTypeEnum.HyperflexStPlatformClusterResiliencyInfo;
            
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
        
        public HyperflexStPlatformClusterResiliencyInfo.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexStPlatformClusterResiliencyInfo.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexStPlatformClusterResiliencyInfo initObject = new Intersight.Model.HyperflexStPlatformClusterResiliencyInfo();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexVmInterface.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexVmInterface")]
    public class InitializeIntersightHyperflexVmInterface:PSCmdlet
	{
		public InitializeIntersightHyperflexVmInterface()
		{
            ClassId = HyperflexVmInterface.ClassIdEnum.HyperflexVmInterface;
            ObjectType = HyperflexVmInterface.ObjectTypeEnum.HyperflexVmInterface;
            
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
        
        public HyperflexVmInterface.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> IpAddress {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the virtual machine interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexVmInterface.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexVmInterface initObject = new Intersight.Model.HyperflexVmInterface();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("IpAddress"))
            {
                initObject.IpAddress = this.IpAddress;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexFeatureLimitEntry.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexFeatureLimitEntry")]
    public class InitializeIntersightHyperflexFeatureLimitEntry:PSCmdlet
	{
		public InitializeIntersightHyperflexFeatureLimitEntry()
		{
            ClassId = HyperflexFeatureLimitEntry.ClassIdEnum.HyperflexFeatureLimitEntry;
            ObjectType = HyperflexFeatureLimitEntry.ObjectTypeEnum.HyperflexFeatureLimitEntry;
            
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
        
        public HyperflexFeatureLimitEntry.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The conditions that must be satisfied before applying the AppSetting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.HyperflexAppSettingConstraint Constraint {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The application setting identifier."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexFeatureLimitEntry.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The application setting value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Value {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexFeatureLimitEntry initObject = new Intersight.Model.HyperflexFeatureLimitEntry();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Constraint"))
            {
                initObject.Constraint = this.Constraint;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexPortTypeToPortNumberMap.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexPortTypeToPortNumberMap")]
    public class InitializeIntersightHyperflexPortTypeToPortNumberMap:PSCmdlet
	{
		public InitializeIntersightHyperflexPortTypeToPortNumberMap()
		{
            ClassId = HyperflexPortTypeToPortNumberMap.ClassIdEnum.HyperflexPortTypeToPortNumberMap;
            ObjectType = HyperflexPortTypeToPortNumberMap.ObjectTypeEnum.HyperflexPortTypeToPortNumberMap;
            
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
        
        public HyperflexPortTypeToPortNumberMap.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexPortTypeToPortNumberMap.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexPortTypeToPortNumberMap initObject = new Intersight.Model.HyperflexPortTypeToPortNumberMap();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexHxUuIdDt.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexHxUuIdDt")]
    public class InitializeIntersightHyperflexHxUuIdDt:PSCmdlet
	{
		public InitializeIntersightHyperflexHxUuIdDt()
		{
            ClassId = HyperflexHxUuIdDt.ClassIdEnum.HyperflexHxUuIdDt;
            ObjectType = HyperflexHxUuIdDt.ObjectTypeEnum.HyperflexHxUuIdDt;
            
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
        
        public HyperflexHxUuIdDt.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexHxUuIdDt.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexHxUuIdDt initObject = new Intersight.Model.HyperflexHxUuIdDt();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexReplicationPlatDatastorePair.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexReplicationPlatDatastorePair")]
    public class InitializeIntersightHyperflexReplicationPlatDatastorePair:PSCmdlet
	{
		public InitializeIntersightHyperflexReplicationPlatDatastorePair()
		{
            ClassId = HyperflexReplicationPlatDatastorePair.ClassIdEnum.HyperflexReplicationPlatDatastorePair;
            ObjectType = HyperflexReplicationPlatDatastorePair.ObjectTypeEnum.HyperflexReplicationPlatDatastorePair;
            
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
        
        public HyperflexReplicationPlatDatastorePair.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexReplicationPlatDatastorePair.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexReplicationPlatDatastorePair initObject = new Intersight.Model.HyperflexReplicationPlatDatastorePair();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexNamedVsan.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexNamedVsan")]
    public class InitializeIntersightHyperflexNamedVsan:PSCmdlet
	{
		public InitializeIntersightHyperflexNamedVsan()
		{
            ClassId = HyperflexNamedVsan.ClassIdEnum.HyperflexNamedVsan;
            ObjectType = HyperflexNamedVsan.ObjectTypeEnum.HyperflexNamedVsan;
            
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
        
        public HyperflexNamedVsan.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the VSAN.\nThe name can be from 1 to 32 characters long and can contain a combination of alphanumeric characters, underscores, and hyphens."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9-_.]{1,32}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexNamedVsan.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The ID of the named VSAN.\nThe ID can be any number between 1 and 4093, inclusive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 4093)]
        public long VsanId {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexNamedVsan initObject = new Intersight.Model.HyperflexNamedVsan();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("VsanId"))
            {
                initObject.VsanId = this.VsanId;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexEntityReference.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexEntityReference")]
    public class InitializeIntersightHyperflexEntityReference:PSCmdlet
	{
		public InitializeIntersightHyperflexEntityReference()
		{
            ClassId = HyperflexEntityReference.ClassIdEnum.HyperflexEntityReference;
            ObjectType = HyperflexEntityReference.ObjectTypeEnum.HyperflexEntityReference;
            
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
        
        public HyperflexEntityReference.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexEntityReference.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexEntityReference initObject = new Intersight.Model.HyperflexEntityReference();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexVmProtectionSpaceUsage.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexVmProtectionSpaceUsage")]
    public class InitializeIntersightHyperflexVmProtectionSpaceUsage:PSCmdlet
	{
		public InitializeIntersightHyperflexVmProtectionSpaceUsage()
		{
            ClassId = HyperflexVmProtectionSpaceUsage.ClassIdEnum.HyperflexVmProtectionSpaceUsage;
            ObjectType = HyperflexVmProtectionSpaceUsage.ObjectTypeEnum.HyperflexVmProtectionSpaceUsage;
            
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
        
        public HyperflexVmProtectionSpaceUsage.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexVmProtectionSpaceUsage.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexVmProtectionSpaceUsage initObject = new Intersight.Model.HyperflexVmProtectionSpaceUsage();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexMapClusterIdToStSnapshotPoint.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexMapClusterIdToStSnapshotPoint")]
    public class InitializeIntersightHyperflexMapClusterIdToStSnapshotPoint:PSCmdlet
	{
		public InitializeIntersightHyperflexMapClusterIdToStSnapshotPoint()
		{
            ClassId = HyperflexMapClusterIdToStSnapshotPoint.ClassIdEnum.HyperflexMapClusterIdToStSnapshotPoint;
            ObjectType = HyperflexMapClusterIdToStSnapshotPoint.ObjectTypeEnum.HyperflexMapClusterIdToStSnapshotPoint;
            
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
        
        public HyperflexMapClusterIdToStSnapshotPoint.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexMapClusterIdToStSnapshotPoint.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexMapClusterIdToStSnapshotPoint initObject = new Intersight.Model.HyperflexMapClusterIdToStSnapshotPoint();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexReplicationPeerInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexReplicationPeerInfo")]
    public class InitializeIntersightHyperflexReplicationPeerInfo:PSCmdlet
	{
		public InitializeIntersightHyperflexReplicationPeerInfo()
		{
            ClassId = HyperflexReplicationPeerInfo.ClassIdEnum.HyperflexReplicationPeerInfo;
            ObjectType = HyperflexReplicationPeerInfo.ObjectTypeEnum.HyperflexReplicationPeerInfo;
            
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
        
        public HyperflexReplicationPeerInfo.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexReplicationPeerInfo.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexReplicationPeerInfo initObject = new Intersight.Model.HyperflexReplicationPeerInfo();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexHxRegistrationDetailsDt.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexHxRegistrationDetailsDt")]
    public class InitializeIntersightHyperflexHxRegistrationDetailsDt:PSCmdlet
	{
		public InitializeIntersightHyperflexHxRegistrationDetailsDt()
		{
            ClassId = HyperflexHxRegistrationDetailsDt.ClassIdEnum.HyperflexHxRegistrationDetailsDt;
            ObjectType = HyperflexHxRegistrationDetailsDt.ObjectTypeEnum.HyperflexHxRegistrationDetailsDt;
            
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
        
        public HyperflexHxRegistrationDetailsDt.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexHxRegistrationDetailsDt.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexHxRegistrationDetailsDt initObject = new Intersight.Model.HyperflexHxRegistrationDetailsDt();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexLogicalAvailabilityZone.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexLogicalAvailabilityZone")]
    public class InitializeIntersightHyperflexLogicalAvailabilityZone:PSCmdlet
	{
		public InitializeIntersightHyperflexLogicalAvailabilityZone()
		{
            ClassId = HyperflexLogicalAvailabilityZone.ClassIdEnum.HyperflexLogicalAvailabilityZone;
            ObjectType = HyperflexLogicalAvailabilityZone.ObjectTypeEnum.HyperflexLogicalAvailabilityZone;
            
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
        /// <para type="description">"Enable or disable Logical Availability Zones (LAZ).\nIf enabled, HyperFlex Data Platform automatically selects and groups nodes into different availability zones. For HyperFlex Data Platform versions prior to 3.0 release, this setting does not apply. For HyperFlex Data Platform versions 3.0 or higher, this setting is only applicable to Fabric Interconnect attached HyperFlex systems with 8 or more converged nodes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool AutoConfig {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexLogicalAvailabilityZone.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexLogicalAvailabilityZone.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexLogicalAvailabilityZone initObject = new Intersight.Model.HyperflexLogicalAvailabilityZone();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AutoConfig"))
            {
                initObject.AutoConfig = this.AutoConfig;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexSnapshotStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexSnapshotStatus")]
    public class InitializeIntersightHyperflexSnapshotStatus:PSCmdlet
	{
		public InitializeIntersightHyperflexSnapshotStatus()
		{
            ClassId = HyperflexSnapshotStatus.ClassIdEnum.HyperflexSnapshotStatus;
            ObjectType = HyperflexSnapshotStatus.ObjectTypeEnum.HyperflexSnapshotStatus;
            
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
        
        public HyperflexSnapshotStatus.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexSnapshotStatus.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexSnapshotStatus initObject = new Intersight.Model.HyperflexSnapshotStatus();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexSnapshotPoint.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexSnapshotPoint")]
    public class InitializeIntersightHyperflexSnapshotPoint:PSCmdlet
	{
		public InitializeIntersightHyperflexSnapshotPoint()
		{
            ClassId = HyperflexSnapshotPoint.ClassIdEnum.HyperflexSnapshotPoint;
            ObjectType = HyperflexSnapshotPoint.ObjectTypeEnum.HyperflexSnapshotPoint;
            
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
        
        public HyperflexSnapshotPoint.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexSnapshotPoint.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexSnapshotPoint initObject = new Intersight.Model.HyperflexSnapshotPoint();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexVirtualMachineRuntimeInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexVirtualMachineRuntimeInfo")]
    public class InitializeIntersightHyperflexVirtualMachineRuntimeInfo:PSCmdlet
	{
		public InitializeIntersightHyperflexVirtualMachineRuntimeInfo()
		{
            ClassId = HyperflexVirtualMachineRuntimeInfo.ClassIdEnum.HyperflexVirtualMachineRuntimeInfo;
            ObjectType = HyperflexVirtualMachineRuntimeInfo.ObjectTypeEnum.HyperflexVirtualMachineRuntimeInfo;
            
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
        
        public HyperflexVirtualMachineRuntimeInfo.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexVirtualMachineRuntimeInfo.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexVirtualMachineRuntimeInfo initObject = new Intersight.Model.HyperflexVirtualMachineRuntimeInfo();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexHxHostMountStatusDt.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexHxHostMountStatusDt")]
    public class InitializeIntersightHyperflexHxHostMountStatusDt:PSCmdlet
	{
		public InitializeIntersightHyperflexHxHostMountStatusDt()
		{
            ClassId = HyperflexHxHostMountStatusDt.ClassIdEnum.HyperflexHxHostMountStatusDt;
            ObjectType = HyperflexHxHostMountStatusDt.ObjectTypeEnum.HyperflexHxHostMountStatusDt;
            
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
        
        public HyperflexHxHostMountStatusDt.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexHxHostMountStatusDt.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexHxHostMountStatusDt initObject = new Intersight.Model.HyperflexHxHostMountStatusDt();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexVmDisk.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexVmDisk")]
    public class InitializeIntersightHyperflexVmDisk:PSCmdlet
	{
		public InitializeIntersightHyperflexVmDisk()
		{
            ClassId = HyperflexVmDisk.ClassIdEnum.HyperflexVmDisk;
            ObjectType = HyperflexVmDisk.ObjectTypeEnum.HyperflexVmDisk;
            
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
        
        public HyperflexVmDisk.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexVmDisk.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexVmDisk initObject = new Intersight.Model.HyperflexVmDisk();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexNamedVlan.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexNamedVlan")]
    public class InitializeIntersightHyperflexNamedVlan:PSCmdlet
	{
		public InitializeIntersightHyperflexNamedVlan()
		{
            ClassId = HyperflexNamedVlan.ClassIdEnum.HyperflexNamedVlan;
            ObjectType = HyperflexNamedVlan.ObjectTypeEnum.HyperflexNamedVlan;
            
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
        
        public HyperflexNamedVlan.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the VLAN.\nThe name can be from 1 to 32 characters long and can contain a combination of alphanumeric characters, underscores, and hyphens."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9-_.]{1,32}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexNamedVlan.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The ID of the named VLAN. An ID of 0 means the traffic is untagged.\nThe ID can be any number between 0 and 4095, inclusive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long VlanId {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexNamedVlan initObject = new Intersight.Model.HyperflexNamedVlan();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("VlanId"))
            {
                initObject.VlanId = this.VlanId;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexReplicationSchedule.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexReplicationSchedule")]
    public class InitializeIntersightHyperflexReplicationSchedule:PSCmdlet
	{
		public InitializeIntersightHyperflexReplicationSchedule()
		{
            ClassId = HyperflexReplicationSchedule.ClassIdEnum.HyperflexReplicationSchedule;
            ObjectType = HyperflexReplicationSchedule.ObjectTypeEnum.HyperflexReplicationSchedule;
            
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
        /// <para type="description">"Time interval between two copies in minutes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(5, 10080)]
        public long BackupInterval {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexReplicationSchedule.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexReplicationSchedule.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexReplicationSchedule initObject = new Intersight.Model.HyperflexReplicationSchedule();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BackupInterval"))
            {
                initObject.BackupInterval = this.BackupInterval;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexHxZoneInfoDt.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexHxZoneInfoDt")]
    public class InitializeIntersightHyperflexHxZoneInfoDt:PSCmdlet
	{
		public InitializeIntersightHyperflexHxZoneInfoDt()
		{
            ClassId = HyperflexHxZoneInfoDt.ClassIdEnum.HyperflexHxZoneInfoDt;
            ObjectType = HyperflexHxZoneInfoDt.ObjectTypeEnum.HyperflexHxZoneInfoDt;
            
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
        
        public HyperflexHxZoneInfoDt.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexHxZoneInfoDt.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexHxZoneInfoDt initObject = new Intersight.Model.HyperflexHxZoneInfoDt();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexDatastoreInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexDatastoreInfo")]
    public class InitializeIntersightHyperflexDatastoreInfo:PSCmdlet
	{
		public InitializeIntersightHyperflexDatastoreInfo()
		{
            ClassId = HyperflexDatastoreInfo.ClassIdEnum.HyperflexDatastoreInfo;
            ObjectType = HyperflexDatastoreInfo.ObjectTypeEnum.HyperflexDatastoreInfo;
            
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
        
        public HyperflexDatastoreInfo.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexDatastoreInfo.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexDatastoreInfo initObject = new Intersight.Model.HyperflexDatastoreInfo();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexServerModelEntry.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexServerModelEntry")]
    public class InitializeIntersightHyperflexServerModelEntry:PSCmdlet
	{
		public InitializeIntersightHyperflexServerModelEntry()
		{
            ClassId = HyperflexServerModelEntry.ClassIdEnum.HyperflexServerModelEntry;
            ObjectType = HyperflexServerModelEntry.ObjectTypeEnum.HyperflexServerModelEntry;
            
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
        
        public HyperflexServerModelEntry.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The conditions that must be satisfied before applying the AppSetting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.HyperflexAppSettingConstraint Constraint {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The application setting identifier."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexServerModelEntry.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The application setting value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Value {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexServerModelEntry initObject = new Intersight.Model.HyperflexServerModelEntry();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Constraint"))
            {
                initObject.Constraint = this.Constraint;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexVdiskConfig.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexVdiskConfig")]
    public class InitializeIntersightHyperflexVdiskConfig:PSCmdlet
	{
		public InitializeIntersightHyperflexVdiskConfig()
		{
            ClassId = HyperflexVdiskConfig.ClassIdEnum.HyperflexVdiskConfig;
            ObjectType = HyperflexVdiskConfig.ObjectTypeEnum.HyperflexVdiskConfig;
            
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
        
        public HyperflexVdiskConfig.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexVdiskConfig.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexVdiskConfig initObject = new Intersight.Model.HyperflexVdiskConfig();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexAppSettingConstraint.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexAppSettingConstraint")]
    public class InitializeIntersightHyperflexAppSettingConstraint:PSCmdlet
	{
		public InitializeIntersightHyperflexAppSettingConstraint()
		{
            ClassId = HyperflexAppSettingConstraint.ClassIdEnum.HyperflexAppSettingConstraint;
            DeploymentType = HyperflexAppSettingConstraint.DeploymentTypeEnum.NA;
            HypervisorType = HyperflexAppSettingConstraint.HypervisorTypeEnum.ESXi;
            MgmtPlatform = HyperflexAppSettingConstraint.MgmtPlatformEnum.FI;
            ObjectType = HyperflexAppSettingConstraint.ObjectTypeEnum.HyperflexAppSettingConstraint;
            
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
        
        public HyperflexAppSettingConstraint.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The deployment type of the cluster.\n* `NA` - The deployment type of the HyperFlex cluster is not available.\n* `Datacenter` - The deployment type of a HyperFlex cluster consisting of UCS Fabric Interconnect-attached nodes on the same site.\n* `Stretched Cluster` - The deployment type of a HyperFlex cluster consisting of UCS Fabric Interconnect-attached nodes across different sites.\n* `Edge` - The deployment type of a HyperFlex cluster consisting of 2 or more standalone nodes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexAppSettingConstraint.DeploymentTypeEnum DeploymentType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The supported HyperFlex Data Platform version in regex format."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string HxdpVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The hypervisor type for the HyperFlex cluster.\n* `ESXi` - The hypervisor running on the HyperFlex cluster is a Vmware ESXi hypervisor of any version.\n* `HyperFlexAp` - The hypervisor of the virtualization platform is Cisco HyperFlex Application Platform.\n* `IWE` - The hypervisor of the virtualization platform is Cisco Intersight Workload Engine.\n* `Hyper-V` - The hypervisor running on the HyperFlex cluster is Microsoft Hyper-V.\n* `Unknown` - The hypervisor running on the HyperFlex cluster is not known."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexAppSettingConstraint.HypervisorTypeEnum HypervisorType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The supported management platform for the HyperFlex Cluster.\n* `FI` - The host servers used in the cluster deployment are managed by a UCS Fabric Interconnect.\n* `EDGE` - The host servers used in the cluster deployment are standalone severs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexAppSettingConstraint.MgmtPlatformEnum MgmtPlatform {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexAppSettingConstraint.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The supported server models in regex format."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ServerModel {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexAppSettingConstraint initObject = new Intersight.Model.HyperflexAppSettingConstraint();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DeploymentType"))
            {
                initObject.DeploymentType = this.DeploymentType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HxdpVersion"))
            {
                initObject.HxdpVersion = this.HxdpVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HypervisorType"))
            {
                initObject.HypervisorType = this.HypervisorType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MgmtPlatform"))
            {
                initObject.MgmtPlatform = this.MgmtPlatform;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ServerModel"))
            {
                initObject.ServerModel = this.ServerModel;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexVirtualMachine.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexVirtualMachine")]
    public class InitializeIntersightHyperflexVirtualMachine:PSCmdlet
	{
		public InitializeIntersightHyperflexVirtualMachine()
		{
            ClassId = HyperflexVirtualMachine.ClassIdEnum.HyperflexVirtualMachine;
            ObjectType = HyperflexVirtualMachine.ObjectTypeEnum.HyperflexVirtualMachine;
            
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
        
        public HyperflexVirtualMachine.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexVirtualMachine.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexVirtualMachine initObject = new Intersight.Model.HyperflexVirtualMachine();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexFilePath.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexFilePath")]
    public class InitializeIntersightHyperflexFilePath:PSCmdlet
	{
		public InitializeIntersightHyperflexFilePath()
		{
            ClassId = HyperflexFilePath.ClassIdEnum.HyperflexFilePath;
            ObjectType = HyperflexFilePath.ObjectTypeEnum.HyperflexFilePath;
            
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
        
        public HyperflexFilePath.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexFilePath.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexFilePath initObject = new Intersight.Model.HyperflexFilePath();
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
    /// <para type="synopsis">This is the cmdlet to Initialize HyperflexTrackedFile.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightHyperflexTrackedFile")]
    public class InitializeIntersightHyperflexTrackedFile:PSCmdlet
	{
		public InitializeIntersightHyperflexTrackedFile()
		{
            ClassId = HyperflexTrackedFile.ClassIdEnum.HyperflexTrackedFile;
            ObjectType = HyperflexTrackedFile.ObjectTypeEnum.HyperflexTrackedFile;
            
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
        
        public HyperflexTrackedFile.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexTrackedFile.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.HyperflexTrackedFile initObject = new Intersight.Model.HyperflexTrackedFile();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
}