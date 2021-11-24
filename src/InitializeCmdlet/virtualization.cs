using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationCloudVmStorageConfiguration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationCloudVmStorageConfiguration")]
    public class InitializeIntersightVirtualizationCloudVmStorageConfiguration:PSCmdlet
	{
		public InitializeIntersightVirtualizationCloudVmStorageConfiguration()
		{
            ClassId = VirtualizationCloudVmStorageConfiguration.ClassIdEnum.VirtualizationAwsVmStorageConfiguration;
            ObjectType = VirtualizationCloudVmStorageConfiguration.ObjectTypeEnum.VirtualizationAwsVmStorageConfiguration;
            
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
        
        public VirtualizationCloudVmStorageConfiguration.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationCloudVmStorageConfiguration.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.VirtualizationVolumeInfo> Volumes {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VirtualizationCloudVmStorageConfiguration initObject = new Intersight.Model.VirtualizationCloudVmStorageConfiguration();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Volumes"))
            {
                initObject.Volumes = this.Volumes;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVmEsxiDisk.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVmEsxiDisk")]
    public class InitializeIntersightVirtualizationVmEsxiDisk:PSCmdlet
	{
		public InitializeIntersightVirtualizationVmEsxiDisk()
		{
            ClassId = VirtualizationVmEsxiDisk.ClassIdEnum.VirtualizationVmEsxiDisk;
            ObjectType = VirtualizationVmEsxiDisk.ObjectTypeEnum.VirtualizationVmEsxiDisk;
            
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
        /// <para type="description">"Disk capacity to be provided with units example - 10Gi."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Capacity {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmEsxiDisk.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Datastore of the disk from the space is allocated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Datastore {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Mode of the disk, like persistent, independent persistent."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Diskmode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the virtual disk."</para>
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
        
        public VirtualizationVmEsxiDisk.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specify the allocation type as thin or thick."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string StorageAllocation {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Controller name of the disk, if not specified uses the default one."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string StorageController {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VirtualizationVmEsxiDisk initObject = new Intersight.Model.VirtualizationVmEsxiDisk();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Capacity"))
            {
                initObject.Capacity = this.Capacity;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Datastore"))
            {
                initObject.Datastore = this.Datastore;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Diskmode"))
            {
                initObject.Diskmode = this.Diskmode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("StorageAllocation"))
            {
                initObject.StorageAllocation = this.StorageAllocation;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StorageController"))
            {
                initObject.StorageController = this.StorageController;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationBaseVmConfiguration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationBaseVmConfiguration")]
    public class InitializeIntersightVirtualizationBaseVmConfiguration:PSCmdlet
	{
		public InitializeIntersightVirtualizationBaseVmConfiguration()
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
        
        public VirtualizationBaseVmConfiguration.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationBaseVmConfiguration.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VirtualizationBaseVmConfiguration initObject = new Intersight.Model.VirtualizationBaseVmConfiguration();
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
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationEsxiVmNetworkConfiguration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationEsxiVmNetworkConfiguration")]
    public class InitializeIntersightVirtualizationEsxiVmNetworkConfiguration:PSCmdlet
	{
		public InitializeIntersightVirtualizationEsxiVmNetworkConfiguration()
		{
            ClassId = VirtualizationEsxiVmNetworkConfiguration.ClassIdEnum.VirtualizationEsxiVmNetworkConfiguration;
            ObjectType = VirtualizationEsxiVmNetworkConfiguration.ObjectTypeEnum.VirtualizationEsxiVmNetworkConfiguration;
            
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
        
        public VirtualizationEsxiVmNetworkConfiguration.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.VirtualizationNetworkInterface> Interfaces {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationEsxiVmNetworkConfiguration.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VirtualizationEsxiVmNetworkConfiguration initObject = new Intersight.Model.VirtualizationEsxiVmNetworkConfiguration();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Interfaces"))
            {
                initObject.Interfaces = this.Interfaces;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationAwsVmConfiguration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationAwsVmConfiguration")]
    public class InitializeIntersightVirtualizationAwsVmConfiguration:PSCmdlet
	{
		public InitializeIntersightVirtualizationAwsVmConfiguration()
		{
            ClassId = VirtualizationAwsVmConfiguration.ClassIdEnum.VirtualizationAwsVmConfiguration;
            ObjectType = VirtualizationAwsVmConfiguration.ObjectTypeEnum.VirtualizationAwsVmConfiguration;
            
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
        /// <para type="description">"Availability zone for the VM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string AvailabilityZoneId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationAwsVmConfiguration.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Cloud virtual machine compute specifications."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.VirtualizationCloudVmComputeConfiguration Compute {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Virtual machine image used by this VM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ImageId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Keypair for accessing the VM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string KeyPairName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Cloud virtual machine network specifications."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.VirtualizationCloudVmNetworkConfiguration Network {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationAwsVmConfiguration.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Region where the VM instance is created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RegionId {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> SecurityGroups {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Cloud Virtual machine disk information."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.VirtualizationCloudVmStorageConfiguration Storage {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Unique Identifier of the cloud VM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string VmId {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VirtualizationAwsVmConfiguration initObject = new Intersight.Model.VirtualizationAwsVmConfiguration();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AvailabilityZoneId"))
            {
                initObject.AvailabilityZoneId = this.AvailabilityZoneId;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Compute"))
            {
                initObject.Compute = this.Compute;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ImageId"))
            {
                initObject.ImageId = this.ImageId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("KeyPairName"))
            {
                initObject.KeyPairName = this.KeyPairName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Network"))
            {
                initObject.Network = this.Network;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RegionId"))
            {
                initObject.RegionId = this.RegionId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SecurityGroups"))
            {
                initObject.SecurityGroups = this.SecurityGroups;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Storage"))
            {
                initObject.Storage = this.Storage;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VmId"))
            {
                initObject.VmId = this.VmId;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVmwareVmDiskCommitInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVmwareVmDiskCommitInfo")]
    public class InitializeIntersightVirtualizationVmwareVmDiskCommitInfo:PSCmdlet
	{
		public InitializeIntersightVirtualizationVmwareVmDiskCommitInfo()
		{
            ClassId = VirtualizationVmwareVmDiskCommitInfo.ClassIdEnum.VirtualizationVmwareVmDiskCommitInfo;
            ObjectType = VirtualizationVmwareVmDiskCommitInfo.ObjectTypeEnum.VirtualizationVmwareVmDiskCommitInfo;
            
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
        
        public VirtualizationVmwareVmDiskCommitInfo.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Disk committed in bytes on this virtual machine (disk space used up)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long CommittedDisk {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareVmDiskCommitInfo.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Total uncommitted disk space that is available for use (in bytes)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long UnCommittedDisk {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Total unshared disk space (in bytes)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long UnsharedDisk {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VirtualizationVmwareVmDiskCommitInfo initObject = new Intersight.Model.VirtualizationVmwareVmDiskCommitInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CommittedDisk"))
            {
                initObject.CommittedDisk = this.CommittedDisk;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("UnCommittedDisk"))
            {
                initObject.UnCommittedDisk = this.UnCommittedDisk;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UnsharedDisk"))
            {
                initObject.UnsharedDisk = this.UnsharedDisk;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVmwareTeamingAndFailover.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVmwareTeamingAndFailover")]
    public class InitializeIntersightVirtualizationVmwareTeamingAndFailover:PSCmdlet
	{
		public InitializeIntersightVirtualizationVmwareTeamingAndFailover()
		{
            ClassId = VirtualizationVmwareTeamingAndFailover.ClassIdEnum.VirtualizationVmwareTeamingAndFailover;
            LoadBalancing = VirtualizationVmwareTeamingAndFailover.LoadBalancingEnum.LoadbalanceIP;
            NetworkFailureDetection = VirtualizationVmwareTeamingAndFailover.NetworkFailureDetectionEnum.LinkStatus;
            ObjectType = VirtualizationVmwareTeamingAndFailover.ObjectTypeEnum.VirtualizationVmwareTeamingAndFailover;
            
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> ActiveAdapters {
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
        
        public VirtualizationVmwareTeamingAndFailover.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"By default, a failback policy is enabled on a NIC team. If a failed physical NIC returns online, the network component sets the NIC back to active by replacing the standby NIC that took over its slot."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Failback {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Determines how network traffic is distributed between the network adapters in a NIC team.\n* `loadbalanceIP` - Load balance based on IP hash.\n* `loadbalanceSrcmac` - Route based on source MAC hash.\n* `loadbalanceSrcid` - Route based on originating virtual port.\n* `failoverExplicit` - Use explicit failover order.\n* `loadbalanceSrcnic` - Route based on physical NIC load."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareTeamingAndFailover.LoadBalancingEnum LoadBalancing {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the network component, example dvswitch, dvnetwork, vswitch or standard network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Methods used by network component for failover detection.\n* `linkStatus` - This option detects failures such as removed cables and physical switch power failures.\n* `beaconProbing` - Sends out and listens for beacon probes on all NICs in the team, and uses this information, in addition to link status, to determine link failure. ESXi sends beacon packets every second."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareTeamingAndFailover.NetworkFailureDetectionEnum NetworkFailureDetection {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Determines how network traffic is distributed between the network adapters in a NIC team."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool NotifySwitches {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareTeamingAndFailover.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> StandbyAdapters {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VirtualizationVmwareTeamingAndFailover initObject = new Intersight.Model.VirtualizationVmwareTeamingAndFailover();
            if (this.MyInvocation.BoundParameters.ContainsKey("ActiveAdapters"))
            {
                initObject.ActiveAdapters = this.ActiveAdapters;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Failback"))
            {
                initObject.Failback = this.Failback;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LoadBalancing"))
            {
                initObject.LoadBalancing = this.LoadBalancing;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NetworkFailureDetection"))
            {
                initObject.NetworkFailureDetection = this.NetworkFailureDetection;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NotifySwitches"))
            {
                initObject.NotifySwitches = this.NotifySwitches;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("StandbyAdapters"))
            {
                initObject.StandbyAdapters = this.StandbyAdapters;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationBaseCustomSpec.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationBaseCustomSpec")]
    public class InitializeIntersightVirtualizationBaseCustomSpec:PSCmdlet
	{
		public InitializeIntersightVirtualizationBaseCustomSpec()
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
        
        public VirtualizationBaseCustomSpec.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationBaseCustomSpec.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VirtualizationBaseCustomSpec initObject = new Intersight.Model.VirtualizationBaseCustomSpec();
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
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationAwsVmNetworkConfiguration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationAwsVmNetworkConfiguration")]
    public class InitializeIntersightVirtualizationAwsVmNetworkConfiguration:PSCmdlet
	{
		public InitializeIntersightVirtualizationAwsVmNetworkConfiguration()
		{
            ClassId = VirtualizationAwsVmNetworkConfiguration.ClassIdEnum.VirtualizationAwsVmNetworkConfiguration;
            ObjectType = VirtualizationAwsVmNetworkConfiguration.ObjectTypeEnum.VirtualizationAwsVmNetworkConfiguration;
            
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
        
        public VirtualizationAwsVmNetworkConfiguration.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.VirtualizationNetworkInterface> Interfaces {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationAwsVmNetworkConfiguration.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VirtualizationAwsVmNetworkConfiguration initObject = new Intersight.Model.VirtualizationAwsVmNetworkConfiguration();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Interfaces"))
            {
                initObject.Interfaces = this.Interfaces;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationEsxiOvaCustomSpec.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationEsxiOvaCustomSpec")]
    public class InitializeIntersightVirtualizationEsxiOvaCustomSpec:PSCmdlet
	{
		public InitializeIntersightVirtualizationEsxiOvaCustomSpec()
		{
            ClassId = VirtualizationEsxiOvaCustomSpec.ClassIdEnum.VirtualizationEsxiOvaCustomSpec;
            ObjectType = VirtualizationEsxiOvaCustomSpec.ObjectTypeEnum.VirtualizationEsxiOvaCustomSpec;
            
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
        
        public VirtualizationEsxiOvaCustomSpec.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specify the Extra Config specification which can be configured on virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object ExtraConfig {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationEsxiOvaCustomSpec.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specify the OVA Environment specification which can be configured on the virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object OvaEnvSpec {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VirtualizationEsxiOvaCustomSpec initObject = new Intersight.Model.VirtualizationEsxiOvaCustomSpec();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ExtraConfig"))
            {
                initObject.ExtraConfig = this.ExtraConfig;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OvaEnvSpec"))
            {
                initObject.OvaEnvSpec = this.OvaEnvSpec;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationEsxiVmConfiguration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationEsxiVmConfiguration")]
    public class InitializeIntersightVirtualizationEsxiVmConfiguration:PSCmdlet
	{
		public InitializeIntersightVirtualizationEsxiVmConfiguration()
		{
            ClassId = VirtualizationEsxiVmConfiguration.ClassIdEnum.VirtualizationEsxiVmConfiguration;
            ObjectType = VirtualizationEsxiVmConfiguration.ObjectTypeEnum.VirtualizationEsxiVmConfiguration;
            
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
        /// <para type="description">"Specify annotation (optional) for the virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Annotation {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationEsxiVmConfiguration.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"ESXi virtual machine compute specification."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.VirtualizationEsxiVmComputeConfiguration Compute {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"ESXi virtual machine custom specification."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.VirtualizationBaseCustomSpec Customspec {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Datacenter where virtual machine is deployed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Datacenter {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Folder where virtual machine is deployed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Folder {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Image path of OVA (The image can be from any location)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Image {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"ESXi virtual machine network specification."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.VirtualizationEsxiVmNetworkConfiguration Network {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationEsxiVmConfiguration.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"ESXi virtual machine storage specification."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.VirtualizationEsxiVmStorageConfiguration Storage {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Template to be used for clone."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Template {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VirtualizationEsxiVmConfiguration initObject = new Intersight.Model.VirtualizationEsxiVmConfiguration();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Annotation"))
            {
                initObject.Annotation = this.Annotation;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Compute"))
            {
                initObject.Compute = this.Compute;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Customspec"))
            {
                initObject.Customspec = this.Customspec;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Datacenter"))
            {
                initObject.Datacenter = this.Datacenter;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Folder"))
            {
                initObject.Folder = this.Folder;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Image"))
            {
                initObject.Image = this.Image;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Network"))
            {
                initObject.Network = this.Network;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Storage"))
            {
                initObject.Storage = this.Storage;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Template"))
            {
                initObject.Template = this.Template;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationCloudInitConfig.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationCloudInitConfig")]
    public class InitializeIntersightVirtualizationCloudInitConfig:PSCmdlet
	{
		public InitializeIntersightVirtualizationCloudInitConfig()
		{
            ClassId = VirtualizationCloudInitConfig.ClassIdEnum.VirtualizationCloudInitConfig;
            ObjectType = VirtualizationCloudInitConfig.ObjectTypeEnum.VirtualizationCloudInitConfig;
            
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
        
        public VirtualizationCloudInitConfig.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Virtual machine cloud init configuration type.\n* `` - No cloud init specified. Cloud-init configurations are not sent to hypervisor, if none is selected.\n* `NoCloudSource` - Allows the user to provide user-data to the instance without running a network service.\n* `CloudConfigDrive` - Allows the user to provide user-data and network-data from cloud."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationCloudInitConfig.ConfigTypeEnum ConfigType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Network configuration data for a virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string NetworkData {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Set to true, if the cloud init network data is in base64 format."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool NetworkDataBase64Encoded {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationCloudInitConfig.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User configuration data for a virtual machine such as adding user, group etc."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string UserData {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Set to true, if the cloud init user data is in base64 format."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool UserDataBase64Encoded {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VirtualizationCloudInitConfig initObject = new Intersight.Model.VirtualizationCloudInitConfig();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ConfigType"))
            {
                initObject.ConfigType = this.ConfigType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NetworkData"))
            {
                initObject.NetworkData = this.NetworkData;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NetworkDataBase64Encoded"))
            {
                initObject.NetworkDataBase64Encoded = this.NetworkDataBase64Encoded;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("UserData"))
            {
                initObject.UserData = this.UserData;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UserDataBase64Encoded"))
            {
                initObject.UserDataBase64Encoded = this.UserDataBase64Encoded;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationCpuAllocation.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationCpuAllocation")]
    public class InitializeIntersightVirtualizationCpuAllocation:PSCmdlet
	{
		public InitializeIntersightVirtualizationCpuAllocation()
		{
            ClassId = VirtualizationCpuAllocation.ClassIdEnum.VirtualizationCpuAllocation;
            ObjectType = VirtualizationCpuAllocation.ObjectTypeEnum.VirtualizationCpuAllocation;
            
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
        
        public VirtualizationCpuAllocation.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Free CPU count on the entity."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Free {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationCpuAllocation.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Reserved CPU count on the entity. These reserved CPUs can be used for system purposes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Reserved {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Total number of CPU available on the entity."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Total {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Used or allocated CPU count on the entity."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Used {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VirtualizationCpuAllocation initObject = new Intersight.Model.VirtualizationCpuAllocation();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Free"))
            {
                initObject.Free = this.Free;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Reserved"))
            {
                initObject.Reserved = this.Reserved;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Total"))
            {
                initObject.Total = this.Total;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Used"))
            {
                initObject.Used = this.Used;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVmwareVlanRange.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVmwareVlanRange")]
    public class InitializeIntersightVirtualizationVmwareVlanRange:PSCmdlet
	{
		public InitializeIntersightVirtualizationVmwareVlanRange()
		{
            ClassId = VirtualizationVmwareVlanRange.ClassIdEnum.VirtualizationVmwareVlanRange;
            ObjectType = VirtualizationVmwareVlanRange.ObjectTypeEnum.VirtualizationVmwareVlanRange;
            
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
        
        public VirtualizationVmwareVlanRange.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareVlanRange.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"End value of VLAN range for the trunk port. The valid range is from 0 to 4094."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long VlanRangeEnd {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Start value of VLAN range for the trunk port. The valid range is from 0 to 4094."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long VlanRangeStart {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VirtualizationVmwareVlanRange initObject = new Intersight.Model.VirtualizationVmwareVlanRange();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("VlanRangeEnd"))
            {
                initObject.VlanRangeEnd = this.VlanRangeEnd;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VlanRangeStart"))
            {
                initObject.VlanRangeStart = this.VlanRangeStart;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVmwareRemoteDisplayInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVmwareRemoteDisplayInfo")]
    public class InitializeIntersightVirtualizationVmwareRemoteDisplayInfo:PSCmdlet
	{
		public InitializeIntersightVirtualizationVmwareRemoteDisplayInfo()
		{
            ClassId = VirtualizationVmwareRemoteDisplayInfo.ClassIdEnum.VirtualizationVmwareRemoteDisplayInfo;
            ObjectType = VirtualizationVmwareRemoteDisplayInfo.ObjectTypeEnum.VirtualizationVmwareRemoteDisplayInfo;
            
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
        
        public VirtualizationVmwareRemoteDisplayInfo.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareRemoteDisplayInfo.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The password used for remote access. It is stored base64 encoded."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RemoteDisplayPassword {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The access key for the remote display, potentially a long string."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RemoteDisplayVncKey {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Applies only when remoteDisplayvnc is enabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long RemoteDisplayVncPort {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VirtualizationVmwareRemoteDisplayInfo initObject = new Intersight.Model.VirtualizationVmwareRemoteDisplayInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RemoteDisplayPassword"))
            {
                initObject.RemoteDisplayPassword = this.RemoteDisplayPassword;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RemoteDisplayVncKey"))
            {
                initObject.RemoteDisplayVncKey = this.RemoteDisplayVncKey;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RemoteDisplayVncPort"))
            {
                initObject.RemoteDisplayVncPort = this.RemoteDisplayVncPort;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVmwareVmCpuShareInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVmwareVmCpuShareInfo")]
    public class InitializeIntersightVirtualizationVmwareVmCpuShareInfo:PSCmdlet
	{
		public InitializeIntersightVirtualizationVmwareVmCpuShareInfo()
		{
            ClassId = VirtualizationVmwareVmCpuShareInfo.ClassIdEnum.VirtualizationVmwareVmCpuShareInfo;
            ObjectType = VirtualizationVmwareVmCpuShareInfo.ObjectTypeEnum.VirtualizationVmwareVmCpuShareInfo;
            
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
        
        public VirtualizationVmwareVmCpuShareInfo.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Upper limit on CPU allocation (MHz)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long CpuLimit {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Amount of CPU for virtualization overhead."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long CpuOverheadLimit {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Guaranteed minimum allocation of CPU resource (MHz)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long CpuReservation {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Shows the relative importance of a VM. There is no unit for this value. It is a relative measure based on the settings for other resource pools. For more information, see VMware documentation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long CpuShares {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareVmCpuShareInfo.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VirtualizationVmwareVmCpuShareInfo initObject = new Intersight.Model.VirtualizationVmwareVmCpuShareInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CpuLimit"))
            {
                initObject.CpuLimit = this.CpuLimit;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CpuOverheadLimit"))
            {
                initObject.CpuOverheadLimit = this.CpuOverheadLimit;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CpuReservation"))
            {
                initObject.CpuReservation = this.CpuReservation;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CpuShares"))
            {
                initObject.CpuShares = this.CpuShares;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationAwsVmStorageConfiguration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationAwsVmStorageConfiguration")]
    public class InitializeIntersightVirtualizationAwsVmStorageConfiguration:PSCmdlet
	{
		public InitializeIntersightVirtualizationAwsVmStorageConfiguration()
		{
            ClassId = VirtualizationAwsVmStorageConfiguration.ClassIdEnum.VirtualizationAwsVmStorageConfiguration;
            ObjectType = VirtualizationAwsVmStorageConfiguration.ObjectTypeEnum.VirtualizationAwsVmStorageConfiguration;
            
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
        
        public VirtualizationAwsVmStorageConfiguration.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationAwsVmStorageConfiguration.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.VirtualizationVolumeInfo> Volumes {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VirtualizationAwsVmStorageConfiguration initObject = new Intersight.Model.VirtualizationAwsVmStorageConfiguration();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Volumes"))
            {
                initObject.Volumes = this.Volumes;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationHxapVmConfiguration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationHxapVmConfiguration")]
    public class InitializeIntersightVirtualizationHxapVmConfiguration:PSCmdlet
	{
		public InitializeIntersightVirtualizationHxapVmConfiguration()
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
        
        public VirtualizationHxapVmConfiguration.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationHxapVmConfiguration.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VirtualizationHxapVmConfiguration initObject = new Intersight.Model.VirtualizationHxapVmConfiguration();
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
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationCloudVmComputeConfiguration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationCloudVmComputeConfiguration")]
    public class InitializeIntersightVirtualizationCloudVmComputeConfiguration:PSCmdlet
	{
		public InitializeIntersightVirtualizationCloudVmComputeConfiguration()
		{
            ClassId = VirtualizationCloudVmComputeConfiguration.ClassIdEnum.VirtualizationAwsVmComputeConfiguration;
            ObjectType = VirtualizationCloudVmComputeConfiguration.ObjectTypeEnum.VirtualizationAwsVmComputeConfiguration;
            
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
        
        public VirtualizationCloudVmComputeConfiguration.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Instance Type used by this VM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string InstanceTypeId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationCloudVmComputeConfiguration.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VirtualizationCloudVmComputeConfiguration initObject = new Intersight.Model.VirtualizationCloudVmComputeConfiguration();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("InstanceTypeId"))
            {
                initObject.InstanceTypeId = this.InstanceTypeId;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationIpAddressInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationIpAddressInfo")]
    public class InitializeIntersightVirtualizationIpAddressInfo:PSCmdlet
	{
		public InitializeIntersightVirtualizationIpAddressInfo()
		{
            ClassId = VirtualizationIpAddressInfo.ClassIdEnum.VirtualizationIpAddressInfo;
            ObjectType = VirtualizationIpAddressInfo.ObjectTypeEnum.VirtualizationIpAddressInfo;
            
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
        
        public VirtualizationIpAddressInfo.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IP address of the device on network which forwards local traffic to other networks."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string GatewayIp {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An IP address is a 32-bit number. It uniquely identifies a host in given network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string IpAddress {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationIpAddressInfo.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A 32 bit number which helps to identify the host and rest of the network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SubnetMask {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VirtualizationIpAddressInfo initObject = new Intersight.Model.VirtualizationIpAddressInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("GatewayIp"))
            {
                initObject.GatewayIp = this.GatewayIp;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpAddress"))
            {
                initObject.IpAddress = this.IpAddress;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SubnetMask"))
            {
                initObject.SubnetMask = this.SubnetMask;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVmwareVmMemoryShareInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVmwareVmMemoryShareInfo")]
    public class InitializeIntersightVirtualizationVmwareVmMemoryShareInfo:PSCmdlet
	{
		public InitializeIntersightVirtualizationVmwareVmMemoryShareInfo()
		{
            ClassId = VirtualizationVmwareVmMemoryShareInfo.ClassIdEnum.VirtualizationVmwareVmMemoryShareInfo;
            ObjectType = VirtualizationVmwareVmMemoryShareInfo.ObjectTypeEnum.VirtualizationVmwareVmMemoryShareInfo;
            
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
        
        public VirtualizationVmwareVmMemoryShareInfo.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Limit on the memory sharing imposed (in Mbytes)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MemLimit {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Limit on memory overhead imposed (in Mbytes)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MemOverheadLimit {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Similar to CPU reservations (Mbytes)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MemReservation {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Similar to CPU Shares but applicable to memory. There is no unit for this value. It is a relative measure based on the settings for other resource pools."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MemShares {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareVmMemoryShareInfo.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VirtualizationVmwareVmMemoryShareInfo initObject = new Intersight.Model.VirtualizationVmwareVmMemoryShareInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("MemLimit"))
            {
                initObject.MemLimit = this.MemLimit;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MemOverheadLimit"))
            {
                initObject.MemOverheadLimit = this.MemOverheadLimit;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MemReservation"))
            {
                initObject.MemReservation = this.MemReservation;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MemShares"))
            {
                initObject.MemShares = this.MemShares;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationActionInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationActionInfo")]
    public class InitializeIntersightVirtualizationActionInfo:PSCmdlet
	{
		public InitializeIntersightVirtualizationActionInfo()
		{
            ClassId = VirtualizationActionInfo.ClassIdEnum.VirtualizationActionInfo;
            ObjectType = VirtualizationActionInfo.ObjectTypeEnum.VirtualizationActionInfo;
            
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
        
        public VirtualizationActionInfo.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationActionInfo.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VirtualizationActionInfo initObject = new Intersight.Model.VirtualizationActionInfo();
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
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationMemoryCapacity.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationMemoryCapacity")]
    public class InitializeIntersightVirtualizationMemoryCapacity:PSCmdlet
	{
		public InitializeIntersightVirtualizationMemoryCapacity()
		{
            ClassId = VirtualizationMemoryCapacity.ClassIdEnum.VirtualizationMemoryCapacity;
            ObjectType = VirtualizationMemoryCapacity.ObjectTypeEnum.VirtualizationMemoryCapacity;
            
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
        /// <para type="description">"The total memory capacity of the entity in bytes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Capacity {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationMemoryCapacity.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Free memory (bytes) that is unused and available for allocation, as a point-in-time snapshot. The available memory capacity is reported for an entity (such as Host or Cluster) when inventory data is collected for that entity. As part of the inventory data, a snapshot of the free and used memory capacity is also reported."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Free {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationMemoryCapacity.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Memory (bytes) that has been already used up, as a point-in-time snapshot."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Used {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VirtualizationMemoryCapacity initObject = new Intersight.Model.VirtualizationMemoryCapacity();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Capacity"))
            {
                initObject.Capacity = this.Capacity;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Free"))
            {
                initObject.Free = this.Free;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Used"))
            {
                initObject.Used = this.Used;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVmwareVmCpuSocketInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVmwareVmCpuSocketInfo")]
    public class InitializeIntersightVirtualizationVmwareVmCpuSocketInfo:PSCmdlet
	{
		public InitializeIntersightVirtualizationVmwareVmCpuSocketInfo()
		{
            ClassId = VirtualizationVmwareVmCpuSocketInfo.ClassIdEnum.VirtualizationVmwareVmCpuSocketInfo;
            ObjectType = VirtualizationVmwareVmCpuSocketInfo.ObjectTypeEnum.VirtualizationVmwareVmCpuSocketInfo;
            
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
        
        public VirtualizationVmwareVmCpuSocketInfo.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of core per CPU socket (value may be empty)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long CoresPerSocket {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of CPUs allocated to this VM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NumCpus {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of CPU sockets allocated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NumSockets {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareVmCpuSocketInfo.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VirtualizationVmwareVmCpuSocketInfo initObject = new Intersight.Model.VirtualizationVmwareVmCpuSocketInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CoresPerSocket"))
            {
                initObject.CoresPerSocket = this.CoresPerSocket;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumCpus"))
            {
                initObject.NumCpus = this.NumCpus;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumSockets"))
            {
                initObject.NumSockets = this.NumSockets;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationNetworkInterface.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationNetworkInterface")]
    public class InitializeIntersightVirtualizationNetworkInterface:PSCmdlet
	{
		public InitializeIntersightVirtualizationNetworkInterface()
		{
            AdaptorType = VirtualizationNetworkInterface.AdaptorTypeEnum.Unknown;
            ClassId = VirtualizationNetworkInterface.ClassIdEnum.VirtualizationNetworkInterface;
            ObjectType = VirtualizationNetworkInterface.ObjectTypeEnum.VirtualizationNetworkInterface;
            PrivateIpAllocationMode = VirtualizationNetworkInterface.PrivateIpAllocationModeEnum.DHCP;
            
		}
        // <summary>
        /// <para type="description">"Virtual machine network adaptor type.\n* `Unknown` - The type of the network adaptor type is unknown.\n* `E1000` - Emulated version of the Intel 82545EM Gigabit Ethernet NIC.\n* `SRIOV` - Representation of a virtual function (VF) on a physical NIC with SR-IOV support.\n* `VMXNET2` - VMXNET 2 (Enhanced) is available only for some guest operating systems on ESX/ESXi 3.5 and later.\n* `VMXNET3` - VMXNET 3 offers all the features available in VMXNET 2 and adds several new features.\n* `E1000E` - E1000E – emulates a newer real network adapter, the 1 Gbit Intel 82574, and is available for Windows 2012 and later. The E1000E needs virtual machine hardware version 8 or later.\n* `NE2K_PCI` - The Ne2000 network card uses two ring buffers for packet handling. These are circular buffers made of 256-byte pages that the chip's DMA logic will use to store received packets or to get received packets.\n* `PCnet` - The PCnet-PCI II is a PCI network adapter. It has built-in support for CRC checks and can automatically pad short packets to the minimum Ethernet length.\n* `RTL8139` - The RTL8139 is a fast Ethernet card that operates at 10/100 Mbps. It is compliant with PCI version 2.0/2.1 and it is known for reliability and superior performance.\n* `VirtIO` - VirtIO is a standardized interface which allows virtual machines access to simplified \"virtual\" devices, such as block devices, network adapters and consoles. Accessing devices through VirtIO on a guest VM improves performance over more traditional \"emulated\" devices, as VirtIO devices require only the bare minimum setup and configuration needed to send and receive data, while the host machine handles the majority of the setup and maintenance of the actual physical hardware.\n* `` - Default network adaptor type supported by the hypervisor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationNetworkInterface.AdaptorTypeEnum AdaptorType {
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
        /// <para type="description">"Virtual machine network bridge name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Bridge {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationNetworkInterface.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Connect the adaptor at virtual machine power on."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool ConnectAtPowerOn {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enable the direct path I/O."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool DirectPathIo {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Set to true, if IP forwarding is enabled on the NIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool IpForwardingEnabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Set to true, if IPv6 address should be allocated for the NIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Ipv6Address {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Virtual machine network mac address."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^([0-9A-Fa-f]{2}[:-]){5}([0-9A-Fa-f]{2})$")]
        public string MacAddress {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the network interface. This may be different from guest operating system assigned."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Identity of the network to which this network interface belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string NetworkId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Identity of the network interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string NicId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationNetworkInterface.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Order of the NIC attachment to the VM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Order {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Allocation mode for NIC addresses e.g. DHCP or static.\n* `DHCP` - Dynamic IP address allocation using DHCP protocol.\n* `STATIC_IP` - Assign fixed / static IPs to resources for use.\n* `IPAM_CALLOUT` - Use callout scripts to query cloud IP allocation tools to assign network parameters.\n* `PREALLOCATE_IP` - Allows the cloud infrastructure IP allocation to be dynamically provided before the server boots up."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationNetworkInterface.PrivateIpAllocationModeEnum PrivateIpAllocationMode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Set to true, if public IP should be allocated for the NIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool PublicIpAllocate {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> SecurityGroups {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.VirtualizationIpAddressInfo> StaticIpAddress {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Subnet identifier for the NIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SubnetId {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VirtualizationNetworkInterface initObject = new Intersight.Model.VirtualizationNetworkInterface();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdaptorType"))
            {
                initObject.AdaptorType = this.AdaptorType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Bridge"))
            {
                initObject.Bridge = this.Bridge;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ConnectAtPowerOn"))
            {
                initObject.ConnectAtPowerOn = this.ConnectAtPowerOn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DirectPathIo"))
            {
                initObject.DirectPathIo = this.DirectPathIo;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpForwardingEnabled"))
            {
                initObject.IpForwardingEnabled = this.IpForwardingEnabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Ipv6Address"))
            {
                initObject.Ipv6Address = this.Ipv6Address;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MacAddress"))
            {
                initObject.MacAddress = this.MacAddress;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NetworkId"))
            {
                initObject.NetworkId = this.NetworkId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NicId"))
            {
                initObject.NicId = this.NicId;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Order"))
            {
                initObject.Order = this.Order;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PrivateIpAllocationMode"))
            {
                initObject.PrivateIpAllocationMode = this.PrivateIpAllocationMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PublicIpAllocate"))
            {
                initObject.PublicIpAllocate = this.PublicIpAllocate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SecurityGroups"))
            {
                initObject.SecurityGroups = this.SecurityGroups;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StaticIpAddress"))
            {
                initObject.StaticIpAddress = this.StaticIpAddress;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SubnetId"))
            {
                initObject.SubnetId = this.SubnetId;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationEsxiVmComputeConfiguration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationEsxiVmComputeConfiguration")]
    public class InitializeIntersightVirtualizationEsxiVmComputeConfiguration:PSCmdlet
	{
		public InitializeIntersightVirtualizationEsxiVmComputeConfiguration()
		{
            ClassId = VirtualizationEsxiVmComputeConfiguration.ClassIdEnum.VirtualizationEsxiVmComputeConfiguration;
            ObjectType = VirtualizationEsxiVmComputeConfiguration.ObjectTypeEnum.VirtualizationEsxiVmComputeConfiguration;
            
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
        
        public VirtualizationEsxiVmComputeConfiguration.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationEsxiVmComputeConfiguration.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"ResourcePool where virtual machine is deployed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ResourcePool {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VirtualizationEsxiVmComputeConfiguration initObject = new Intersight.Model.VirtualizationEsxiVmComputeConfiguration();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ResourcePool"))
            {
                initObject.ResourcePool = this.ResourcePool;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVirtualDiskConfig.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVirtualDiskConfig")]
    public class InitializeIntersightVirtualizationVirtualDiskConfig:PSCmdlet
	{
		public InitializeIntersightVirtualizationVirtualDiskConfig()
		{
            ClassId = VirtualizationVirtualDiskConfig.ClassIdEnum.VirtualizationVirtualDiskConfig;
            Mode = VirtualizationVirtualDiskConfig.ModeEnum.Block;
            ObjectType = VirtualizationVirtualDiskConfig.ObjectTypeEnum.VirtualizationVirtualDiskConfig;
            
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
        /// <para type="description">"Disk capacity to be provided with units example - 10Gi."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Capacity {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVirtualDiskConfig.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"File mode of the disk, example - Filesystem, Block.\n* `Block` - It is a Block virtual disk.\n* `Filesystem` - It is a File system virtual disk.\n* `` - Disk mode is either unknown or not supported."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVirtualDiskConfig.ModeEnum Mode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVirtualDiskConfig.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Base64 encoded CA certificates of the https source to check against."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SourceCerts {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Source disk name from where the clone is done."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SourceDiskToClone {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Disk image source for the virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SourceFilePath {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VirtualizationVirtualDiskConfig initObject = new Intersight.Model.VirtualizationVirtualDiskConfig();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Capacity"))
            {
                initObject.Capacity = this.Capacity;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Mode"))
            {
                initObject.Mode = this.Mode;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SourceCerts"))
            {
                initObject.SourceCerts = this.SourceCerts;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SourceDiskToClone"))
            {
                initObject.SourceDiskToClone = this.SourceDiskToClone;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SourceFilePath"))
            {
                initObject.SourceFilePath = this.SourceFilePath;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationProductInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationProductInfo")]
    public class InitializeIntersightVirtualizationProductInfo:PSCmdlet
	{
		public InitializeIntersightVirtualizationProductInfo()
		{
            ClassId = VirtualizationProductInfo.ClassIdEnum.VirtualizationProductInfo;
            ObjectType = VirtualizationProductInfo.ObjectTypeEnum.VirtualizationProductInfo;
            
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
        /// <para type="description">"The build number of the hypervisor running on this host (e.g., 4541947, 6.3.9600.18692). The build number may indicate some feature support that applications might rely on. The build number may not always be an integer."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Build {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationProductInfo.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationProductInfo.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Commercial product name. For example, VMware ESXi."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ProductName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Product name provided by the vendor. For example, embeddedEsx."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ProductType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Commercial vendor name. For example, VMware Inc."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ProductVendor {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Hypervisor version running on the system."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VirtualizationProductInfo initObject = new Intersight.Model.VirtualizationProductInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Build"))
            {
                initObject.Build = this.Build;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ProductName"))
            {
                initObject.ProductName = this.ProductName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ProductType"))
            {
                initObject.ProductType = this.ProductType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ProductVendor"))
            {
                initObject.ProductVendor = this.ProductVendor;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationAwsVmComputeConfiguration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationAwsVmComputeConfiguration")]
    public class InitializeIntersightVirtualizationAwsVmComputeConfiguration:PSCmdlet
	{
		public InitializeIntersightVirtualizationAwsVmComputeConfiguration()
		{
            ClassId = VirtualizationAwsVmComputeConfiguration.ClassIdEnum.VirtualizationAwsVmComputeConfiguration;
            ObjectType = VirtualizationAwsVmComputeConfiguration.ObjectTypeEnum.VirtualizationAwsVmComputeConfiguration;
            
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
        
        public VirtualizationAwsVmComputeConfiguration.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Instance Type used by this VM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string InstanceTypeId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationAwsVmComputeConfiguration.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VirtualizationAwsVmComputeConfiguration initObject = new Intersight.Model.VirtualizationAwsVmComputeConfiguration();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("InstanceTypeId"))
            {
                initObject.InstanceTypeId = this.InstanceTypeId;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationStorageCapacity.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationStorageCapacity")]
    public class InitializeIntersightVirtualizationStorageCapacity:PSCmdlet
	{
		public InitializeIntersightVirtualizationStorageCapacity()
		{
            ClassId = VirtualizationStorageCapacity.ClassIdEnum.VirtualizationStorageCapacity;
            ObjectType = VirtualizationStorageCapacity.ObjectTypeEnum.VirtualizationStorageCapacity;
            
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
        /// <para type="description">"The total capacity of the entity (bytes)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Capacity {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationStorageCapacity.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Free storage space remaining in the entity (bytes) as a point-in-time snapshot. The available space is reported for an entity (such as Host or Cluster) when inventory data is collected for that entity. As part of the inventory data, a snapshot of the free and used storage capacity is also reported."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Free {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationStorageCapacity.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Spaced already used by this entity (bytes), as a point-in-time snapshot."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Used {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VirtualizationStorageCapacity initObject = new Intersight.Model.VirtualizationStorageCapacity();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Capacity"))
            {
                initObject.Capacity = this.Capacity;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Free"))
            {
                initObject.Free = this.Free;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Used"))
            {
                initObject.Used = this.Used;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationGuestInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationGuestInfo")]
    public class InitializeIntersightVirtualizationGuestInfo:PSCmdlet
	{
		public InitializeIntersightVirtualizationGuestInfo()
		{
            ClassId = VirtualizationGuestInfo.ClassIdEnum.VirtualizationGuestInfo;
            ObjectType = VirtualizationGuestInfo.ObjectTypeEnum.VirtualizationGuestInfo;
            
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
        
        public VirtualizationGuestInfo.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name provided to the host OS (example, ubuntu6410, test-gateway, etc.)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Hostname {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Primary IP address of the guest os."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string IpAddress {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the guest running on this VM. This may not be the same as the hostname."</para>
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
        
        public VirtualizationGuestInfo.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the guest OS running on this VM (Cent OS 4/5/6/7)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string OperatingSystem {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VirtualizationGuestInfo initObject = new Intersight.Model.VirtualizationGuestInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Hostname"))
            {
                initObject.Hostname = this.Hostname;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpAddress"))
            {
                initObject.IpAddress = this.IpAddress;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OperatingSystem"))
            {
                initObject.OperatingSystem = this.OperatingSystem;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVmwareResourceConsumption.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVmwareResourceConsumption")]
    public class InitializeIntersightVirtualizationVmwareResourceConsumption:PSCmdlet
	{
		public InitializeIntersightVirtualizationVmwareResourceConsumption()
		{
            ClassId = VirtualizationVmwareResourceConsumption.ClassIdEnum.VirtualizationVmwareResourceConsumption;
            ObjectType = VirtualizationVmwareResourceConsumption.ObjectTypeEnum.VirtualizationVmwareResourceConsumption;
            
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
        
        public VirtualizationVmwareResourceConsumption.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The amount of CPU consumed in Hz."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long CpuConsumed {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Memory consumed by this host in bytes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MemoryConsumed {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareResourceConsumption.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VirtualizationVmwareResourceConsumption initObject = new Intersight.Model.VirtualizationVmwareResourceConsumption();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CpuConsumed"))
            {
                initObject.CpuConsumed = this.CpuConsumed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MemoryConsumed"))
            {
                initObject.MemoryConsumed = this.MemoryConsumed;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationCloudVmNetworkConfiguration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationCloudVmNetworkConfiguration")]
    public class InitializeIntersightVirtualizationCloudVmNetworkConfiguration:PSCmdlet
	{
		public InitializeIntersightVirtualizationCloudVmNetworkConfiguration()
		{
            ClassId = VirtualizationCloudVmNetworkConfiguration.ClassIdEnum.VirtualizationAwsVmNetworkConfiguration;
            ObjectType = VirtualizationCloudVmNetworkConfiguration.ObjectTypeEnum.VirtualizationAwsVmNetworkConfiguration;
            
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
        
        public VirtualizationCloudVmNetworkConfiguration.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.VirtualizationNetworkInterface> Interfaces {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationCloudVmNetworkConfiguration.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VirtualizationCloudVmNetworkConfiguration initObject = new Intersight.Model.VirtualizationCloudVmNetworkConfiguration();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Interfaces"))
            {
                initObject.Interfaces = this.Interfaces;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVolumeInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVolumeInfo")]
    public class InitializeIntersightVirtualizationVolumeInfo:PSCmdlet
	{
		public InitializeIntersightVirtualizationVolumeInfo()
		{
            ClassId = VirtualizationVolumeInfo.ClassIdEnum.VirtualizationVolumeInfo;
            ObjectType = VirtualizationVolumeInfo.ObjectTypeEnum.VirtualizationVolumeInfo;
            
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
        /// <para type="description">"Set to true, if the volume should be a root disk."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Bootable {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVolumeInfo.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Set to true, to delete the volume on termination of the VM the volume is attached to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool DeleteOnTermination {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Set to true, if the volume should be encrypted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Encryption {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IOPS for the volume for applicable volume types."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Iops {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVolumeInfo.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Order of the disk attachment to the VM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Order {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name assigned to the volume created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string VolumeName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Size of the volume created in GB."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long VolumeSize {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Id of the volume or storage type of this volume."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string VolumeType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VirtualizationVolumeInfo initObject = new Intersight.Model.VirtualizationVolumeInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Bootable"))
            {
                initObject.Bootable = this.Bootable;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DeleteOnTermination"))
            {
                initObject.DeleteOnTermination = this.DeleteOnTermination;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Encryption"))
            {
                initObject.Encryption = this.Encryption;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Iops"))
            {
                initObject.Iops = this.Iops;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Order"))
            {
                initObject.Order = this.Order;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VolumeName"))
            {
                initObject.VolumeName = this.VolumeName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VolumeSize"))
            {
                initObject.VolumeSize = this.VolumeSize;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VolumeType"))
            {
                initObject.VolumeType = this.VolumeType;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationEsxiVmStorageConfiguration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationEsxiVmStorageConfiguration")]
    public class InitializeIntersightVirtualizationEsxiVmStorageConfiguration:PSCmdlet
	{
		public InitializeIntersightVirtualizationEsxiVmStorageConfiguration()
		{
            ClassId = VirtualizationEsxiVmStorageConfiguration.ClassIdEnum.VirtualizationEsxiVmStorageConfiguration;
            ObjectType = VirtualizationEsxiVmStorageConfiguration.ObjectTypeEnum.VirtualizationEsxiVmStorageConfiguration;
            
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
        
        public VirtualizationEsxiVmStorageConfiguration.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Datastore where virtual machine is deployed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Datastore {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.VirtualizationVmEsxiDisk> Disks {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationEsxiVmStorageConfiguration.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VirtualizationEsxiVmStorageConfiguration initObject = new Intersight.Model.VirtualizationEsxiVmStorageConfiguration();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Datastore"))
            {
                initObject.Datastore = this.Datastore;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Disks"))
            {
                initObject.Disks = this.Disks;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVmwareSharesInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVmwareSharesInfo")]
    public class InitializeIntersightVirtualizationVmwareSharesInfo:PSCmdlet
	{
		public InitializeIntersightVirtualizationVmwareSharesInfo()
		{
            ClassId = VirtualizationVmwareSharesInfo.ClassIdEnum.VirtualizationVmwareSharesInfo;
            ObjectType = VirtualizationVmwareSharesInfo.ObjectTypeEnum.VirtualizationVmwareSharesInfo;
            
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
        
        public VirtualizationVmwareSharesInfo.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The allocation level. The level is a simplified view of shares. Levels map to a pre-determined set of numeric values for shares. If the shares value does not map to a predefined size, then the level is set as custom."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Level {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareSharesInfo.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of shares allocated. It is used to determine resource allocation in case of resource contention. Set if level is custom. If level is not set to custom, this value is ignored. Therefore, only shares with custom values can be compared."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Shares {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VirtualizationVmwareSharesInfo initObject = new Intersight.Model.VirtualizationVmwareSharesInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Level"))
            {
                initObject.Level = this.Level;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Shares"))
            {
                initObject.Shares = this.Shares;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationEsxiCloneCustomSpec.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationEsxiCloneCustomSpec")]
    public class InitializeIntersightVirtualizationEsxiCloneCustomSpec:PSCmdlet
	{
		public InitializeIntersightVirtualizationEsxiCloneCustomSpec()
		{
            ClassId = VirtualizationEsxiCloneCustomSpec.ClassIdEnum.VirtualizationEsxiCloneCustomSpec;
            ObjectType = VirtualizationEsxiCloneCustomSpec.ObjectTypeEnum.VirtualizationEsxiCloneCustomSpec;
            
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
        
        public VirtualizationEsxiCloneCustomSpec.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specify the Extra Config specification which can be configured on virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object ExtraConfig {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationEsxiCloneCustomSpec.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specify the OVA Environment specification which can be configured on virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object OvaEnvSpec {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VirtualizationEsxiCloneCustomSpec initObject = new Intersight.Model.VirtualizationEsxiCloneCustomSpec();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ExtraConfig"))
            {
                initObject.ExtraConfig = this.ExtraConfig;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OvaEnvSpec"))
            {
                initObject.OvaEnvSpec = this.OvaEnvSpec;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationCpuInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationCpuInfo")]
    public class InitializeIntersightVirtualizationCpuInfo:PSCmdlet
	{
		public InitializeIntersightVirtualizationCpuInfo()
		{
            ClassId = VirtualizationCpuInfo.ClassIdEnum.VirtualizationCpuInfo;
            ObjectType = VirtualizationCpuInfo.ObjectTypeEnum.VirtualizationCpuInfo;
            
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
        
        public VirtualizationCpuInfo.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of cores per CPU, as reported by the manufacturer."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Cores {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The vendor provided description of the CPU. For example, Intel Xeon E5-2640 v3 @ 2.60GHz."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationCpuInfo.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of CPU sockets available."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Sockets {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Speed of the CPUs in Hertz. For example, 2593749663."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Speed {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Manufacturer of the CPU . For example, Intel."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vendor {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VirtualizationCpuInfo initObject = new Intersight.Model.VirtualizationCpuInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Cores"))
            {
                initObject.Cores = this.Cores;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Sockets"))
            {
                initObject.Sockets = this.Sockets;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Speed"))
            {
                initObject.Speed = this.Speed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vendor"))
            {
                initObject.Vendor = this.Vendor;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationMemoryAllocation.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationMemoryAllocation")]
    public class InitializeIntersightVirtualizationMemoryAllocation:PSCmdlet
	{
		public InitializeIntersightVirtualizationMemoryAllocation()
		{
            ClassId = VirtualizationMemoryAllocation.ClassIdEnum.VirtualizationMemoryAllocation;
            ObjectType = VirtualizationMemoryAllocation.ObjectTypeEnum.VirtualizationMemoryAllocation;
            
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
        
        public VirtualizationMemoryAllocation.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Free memory on the entity in bytes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Free {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationMemoryAllocation.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Reserved memory on the entity in bytes. These reserved memory can be used for system purposes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Reserved {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The total memory capacity of the entity in bytes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Total {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Used or allocated memory on the entity represented in bytes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Used {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VirtualizationMemoryAllocation initObject = new Intersight.Model.VirtualizationMemoryAllocation();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Free"))
            {
                initObject.Free = this.Free;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Reserved"))
            {
                initObject.Reserved = this.Reserved;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Total"))
            {
                initObject.Total = this.Total;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Used"))
            {
                initObject.Used = this.Used;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationComputeCapacity.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationComputeCapacity")]
    public class InitializeIntersightVirtualizationComputeCapacity:PSCmdlet
	{
		public InitializeIntersightVirtualizationComputeCapacity()
		{
            ClassId = VirtualizationComputeCapacity.ClassIdEnum.VirtualizationComputeCapacity;
            ObjectType = VirtualizationComputeCapacity.ObjectTypeEnum.VirtualizationComputeCapacity;
            
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
        /// <para type="description">"Total capacity of the entity in MHz."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Capacity {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationComputeCapacity.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Free CPU capacity in MHz, as a point-in-time snapshot. The available CPU capacity is reported for an entity (such as Host or Cluster) when inventory data is collected for that entity. As part of the inventory data, a snapshot of the free and used CPU capacity is also reported."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Free {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationComputeCapacity.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Used CPU capacity of the entity in MHz, as a point-in-time snapshot."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Used {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VirtualizationComputeCapacity initObject = new Intersight.Model.VirtualizationComputeCapacity();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Capacity"))
            {
                initObject.Capacity = this.Capacity;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Free"))
            {
                initObject.Free = this.Free;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Used"))
            {
                initObject.Used = this.Used;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VirtualizationVirtualMachineDisk.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVirtualizationVirtualMachineDisk")]
    public class InitializeIntersightVirtualizationVirtualMachineDisk:PSCmdlet
	{
		public InitializeIntersightVirtualizationVirtualMachineDisk()
		{
            Bus = VirtualizationVirtualMachineDisk.BusEnum.Virtio;
            ClassId = VirtualizationVirtualMachineDisk.ClassIdEnum.VirtualizationVirtualMachineDisk;
            ObjectType = VirtualizationVirtualMachineDisk.ObjectTypeEnum.VirtualizationVirtualMachineDisk;
            Type = VirtualizationVirtualMachineDisk.TypeEnum.Hdd;
            
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
        /// <para type="description">"Disk bus name given for a virtual machine.\n* `virtio` - Disk uses the same paths as a bare-metal system. This simplifies physical-to-virtual and virtual-to-virtual migration.\n* `sata` - Serial ATA (SATA, abbreviated from Serial AT Attachment) is a computer bus interface that connects host bus adapters to mass storage devices such as hard disk drives, optical drives, and solid-state drives.\n* `scsi` - SCSI (Small Computer System Interface) bus used.."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVirtualMachineDisk.BusEnum Bus {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVirtualMachineDisk.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Virtual machine network bridge name."</para>
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
        
        public VirtualizationVirtualMachineDisk.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Priority order of the disk."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Order {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Disk type hdd or cdrom for a virtual machine.\n* `hdd` - Allows the virtual machine to mount disk from hard disk drive (hdd) image.\n* `cdrom` - Allows the virtual machine to mount disk from compact disk (cd) image."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVirtualMachineDisk.TypeEnum Type {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Virtual disk configuration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.VirtualizationVirtualDiskConfig VirtualDisk {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the existing virtual disk to be attached to the Virtual Machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string VirtualDiskReference {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VirtualizationVirtualMachineDisk initObject = new Intersight.Model.VirtualizationVirtualMachineDisk();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Bus"))
            {
                initObject.Bus = this.Bus;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Order"))
            {
                initObject.Order = this.Order;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Type"))
            {
                initObject.Type = this.Type;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VirtualDisk"))
            {
                initObject.VirtualDisk = this.VirtualDisk;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VirtualDiskReference"))
            {
                initObject.VirtualDiskReference = this.VirtualDiskReference;
            }
            WriteObject(initObject);
        }

    }
}