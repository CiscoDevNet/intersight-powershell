using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicVsanSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicVsanSettings")]
    public class InitializeIntersightVnicVsanSettings:PSCmdlet
	{
		public InitializeIntersightVnicVsanSettings()
		{
            ClassId = VnicVsanSettings.ClassIdEnum.VnicVsanSettings;
            ObjectType = VnicVsanSettings.ObjectTypeEnum.VnicVsanSettings;
            
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
        
        public VnicVsanSettings.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Default VLAN of the virtual interface in Standalone Rack server. Setting the value to 0 is equivalent to None and will not associate any Default VLAN to the traffic on the virtual interface (0-4094)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long DefaultVlanId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VSAN ID of the virtual interface in FI attached server (1-4094)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 4094)]
        public long Id {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VnicVsanSettings.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VnicVsanSettings initObject = new Intersight.Model.VnicVsanSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DefaultVlanId"))
            {
                initObject.DefaultVlanId = this.DefaultVlanId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Id"))
            {
                initObject.Id = this.Id;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicVmqSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicVmqSettings")]
    public class InitializeIntersightVnicVmqSettings:PSCmdlet
	{
		public InitializeIntersightVnicVmqSettings()
		{
            ClassId = VnicVmqSettings.ClassIdEnum.VnicVmqSettings;
            ObjectType = VnicVmqSettings.ObjectTypeEnum.VnicVmqSettings;
            
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
        
        public VnicVmqSettings.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enables VMQ feature on the virtual interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enables Virtual Machine Multi-Queue feature on the virtual interface. VMMQ allows configuration of multiple I/O queues for a single VM and thus distributes traffic across multiple CPU cores in a VM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool MultiQueueSupport {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of interrupt resources to be allocated. Recommended value is the number of CPU threads or logical processors available in the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 514)]
        public long NumInterrupts {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of sub vNICs to be created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NumSubVnics {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of hardware Virtual Machine Queues to be allocated. The number of VMQs per adapter must be one more than the maximum number of VM NICs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 128)]
        public long NumVmqs {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VnicVmqSettings.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Ethernet Adapter policy to be associated with the Sub vNICs. The Transmit Queue and Receive Queue resource value of VMMQ adapter policy should be greater than or equal to the configured number of sub vNICs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string VmmqAdapterPolicy {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VnicVmqSettings initObject = new Intersight.Model.VnicVmqSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Enabled"))
            {
                initObject.Enabled = this.Enabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MultiQueueSupport"))
            {
                initObject.MultiQueueSupport = this.MultiQueueSupport;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumInterrupts"))
            {
                initObject.NumInterrupts = this.NumInterrupts;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumSubVnics"))
            {
                initObject.NumSubVnics = this.NumSubVnics;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumVmqs"))
            {
                initObject.NumVmqs = this.NumVmqs;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("VmmqAdapterPolicy"))
            {
                initObject.VmmqAdapterPolicy = this.VmmqAdapterPolicy;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicScsiQueueSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicScsiQueueSettings")]
    public class InitializeIntersightVnicScsiQueueSettings:PSCmdlet
	{
		public InitializeIntersightVnicScsiQueueSettings()
		{
            ClassId = VnicScsiQueueSettings.ClassIdEnum.VnicScsiQueueSettings;
            ObjectType = VnicScsiQueueSettings.ObjectTypeEnum.VnicScsiQueueSettings;
            
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
        
        public VnicScsiQueueSettings.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of SCSI I/O queue resources the system should allocate."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 245)]
        public long Count {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VnicScsiQueueSettings.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of descriptors in each SCSI I/O queue."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(64, 512)]
        public long RingSize {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VnicScsiQueueSettings initObject = new Intersight.Model.VnicScsiQueueSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Count"))
            {
                initObject.Count = this.Count;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RingSize"))
            {
                initObject.RingSize = this.RingSize;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicArfsSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicArfsSettings")]
    public class InitializeIntersightVnicArfsSettings:PSCmdlet
	{
		public InitializeIntersightVnicArfsSettings()
		{
            ClassId = VnicArfsSettings.ClassIdEnum.VnicArfsSettings;
            ObjectType = VnicArfsSettings.ObjectTypeEnum.VnicArfsSettings;
            
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
        
        public VnicArfsSettings.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Status of Accelerated Receive Flow Steering on the virtual ethernet interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VnicArfsSettings.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VnicArfsSettings initObject = new Intersight.Model.VnicArfsSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Enabled"))
            {
                initObject.Enabled = this.Enabled;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicCdn.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicCdn")]
    public class InitializeIntersightVnicCdn:PSCmdlet
	{
		public InitializeIntersightVnicCdn()
		{
            ClassId = VnicCdn.ClassIdEnum.VnicCdn;
            ObjectType = VnicCdn.ObjectTypeEnum.VnicCdn;
            Source = VnicCdn.SourceEnum.Vnic;
            
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
        
        public VnicCdn.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VnicCdn.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Source of the CDN. It can either be user specified or be the same as the vNIC name.\n* `vnic` - Source of the CDN is the same as the vNIC name.\n* `user` - Source of the CDN is specified by the user."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VnicCdn.SourceEnum Source {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The CDN value entered in case of user defined mode."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9\\-\\._:]*$")]
        public string Value {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VnicCdn initObject = new Intersight.Model.VnicCdn();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Source"))
            {
                initObject.Source = this.Source;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Value"))
            {
                initObject.Value = this.Value;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicNvgreSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicNvgreSettings")]
    public class InitializeIntersightVnicNvgreSettings:PSCmdlet
	{
		public InitializeIntersightVnicNvgreSettings()
		{
            ClassId = VnicNvgreSettings.ClassIdEnum.VnicNvgreSettings;
            ObjectType = VnicNvgreSettings.ObjectTypeEnum.VnicNvgreSettings;
            
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
        
        public VnicNvgreSettings.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Status of the Network Virtualization using Generic Routing Encapsulation on the virtual ethernet interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VnicNvgreSettings.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VnicNvgreSettings initObject = new Intersight.Model.VnicNvgreSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Enabled"))
            {
                initObject.Enabled = this.Enabled;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicRoceSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicRoceSettings")]
    public class InitializeIntersightVnicRoceSettings:PSCmdlet
	{
		public InitializeIntersightVnicRoceSettings()
		{
            ClassId = VnicRoceSettings.ClassIdEnum.VnicRoceSettings;
            ClassOfService = VnicRoceSettings.ClassOfServiceEnum.NUMBER_5;
            ObjectType = VnicRoceSettings.ObjectTypeEnum.VnicRoceSettings;
            Version = VnicRoceSettings.VersionEnum.NUMBER_1;
            
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
        
        public VnicRoceSettings.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Class of Service for RoCE on this virtual interface.\n* `5` - RDMA CoS Service Level 5.\n* `1` - RDMA CoS Service Level 1.\n* `2` - RDMA CoS Service Level 2.\n* `4` - RDMA CoS Service Level 4.\n* `6` - RDMA CoS Service Level 6."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VnicRoceSettings.ClassOfServiceEnum ClassOfService {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If enabled sets RDMA over Converged Ethernet (RoCE) on this virtual interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of memory regions per adapter. Recommended value = integer power of 2."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MemoryRegions {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VnicRoceSettings.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of queue pairs per adapter. Recommended value = integer power of 2."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long QueuePairs {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of resource groups per adapter. Recommended value = be an integer power of 2 greater than or equal to the number of CPU cores on the system for optimum performance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long ResourceGroups {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Configure RDMA over Converged Ethernet (RoCE) version on the virtual interface. Only RoCEv1 is supported on Cisco VIC 13xx series adapters and only RoCEv2 is supported on Cisco VIC 14xx series adapters.\n* `1` - RDMA over Converged Ethernet Protocol Version 1.\n* `2` - RDMA over Converged Ethernet Protocol Version 2."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VnicRoceSettings.VersionEnum Version {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VnicRoceSettings initObject = new Intersight.Model.VnicRoceSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ClassOfService"))
            {
                initObject.ClassOfService = this.ClassOfService;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Enabled"))
            {
                initObject.Enabled = this.Enabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MemoryRegions"))
            {
                initObject.MemoryRegions = this.MemoryRegions;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("QueuePairs"))
            {
                initObject.QueuePairs = this.QueuePairs;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ResourceGroups"))
            {
                initObject.ResourceGroups = this.ResourceGroups;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicPlacementSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicPlacementSettings")]
    public class InitializeIntersightVnicPlacementSettings:PSCmdlet
	{
		public InitializeIntersightVnicPlacementSettings()
		{
            ClassId = VnicPlacementSettings.ClassIdEnum.VnicPlacementSettings;
            ObjectType = VnicPlacementSettings.ObjectTypeEnum.VnicPlacementSettings;
            SwitchId = VnicPlacementSettings.SwitchIdEnum.None;
            
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
        
        public VnicPlacementSettings.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"PCIe Slot where the VIC adapter is installed. Supported values are (1-15) and MLOM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|1[0-5]|MLOM)$")]
        public string Id {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VnicPlacementSettings.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The PCI Link used as transport for the virtual interface. All VIC adapters have a single PCI link except VIC 1385 which has two."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long PciLink {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fabric port to which the vNICs will be associated.\n* `None` - Fabric Id is not set to either A or B for the standalone case where the server is not connected to Fabric Interconnects. The value 'None' should be used.\n* `A` - Fabric A of the FI cluster.\n* `B` - Fabric B of the FI cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VnicPlacementSettings.SwitchIdEnum SwitchId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Adapter port on which the virtual interface will be created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Uplink {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VnicPlacementSettings initObject = new Intersight.Model.VnicPlacementSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Id"))
            {
                initObject.Id = this.Id;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PciLink"))
            {
                initObject.PciLink = this.PciLink;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SwitchId"))
            {
                initObject.SwitchId = this.SwitchId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Uplink"))
            {
                initObject.Uplink = this.Uplink;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicEthInterruptSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicEthInterruptSettings")]
    public class InitializeIntersightVnicEthInterruptSettings:PSCmdlet
	{
		public InitializeIntersightVnicEthInterruptSettings()
		{
            ClassId = VnicEthInterruptSettings.ClassIdEnum.VnicEthInterruptSettings;
            CoalescingType = VnicEthInterruptSettings.CoalescingTypeEnum.MIN;
            Mode = VnicEthInterruptSettings.ModeEnum.MSIx;
            ObjectType = VnicEthInterruptSettings.ObjectTypeEnum.VnicEthInterruptSettings;
            
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
        
        public VnicEthInterruptSettings.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The time to wait between interrupts or the idle period that must be encountered before an interrupt is sent. To turn off interrupt coalescing, enter 0 (zero) in this field."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long CoalescingTime {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Interrupt Coalescing Type. This can be one of the following:- MIN  - The system waits for the time specified in the Coalescing Time field before sending another interrupt event IDLE - The system does not send an interrupt until there is a period of no activity lasting as least as long as the time specified in the Coalescing Time field.\n* `MIN` - The system waits for the time specified in the Coalescing Time field before sending another interrupt event.\n* `IDLE` - The system does not send an interrupt until there is a period of no activity lasting as least as long as the time specified in the Coalescing Time field."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VnicEthInterruptSettings.CoalescingTypeEnum CoalescingType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of interrupt resources to allocate. Typical value is be equal to the number of completion queue resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 1024)]
        public long Count {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Preferred driver interrupt mode. This can be one of the following:- MSIx - Message Signaled Interrupts (MSI) with the optional extension. MSI  - MSI only. INTx - PCI INTx interrupts. MSIx is the recommended option.\n* `MSIx` - Message Signaled Interrupt (MSI) mechanism with the optional extension (MSIx). MSIx is the recommended and default option.\n* `MSI` - Message Signaled Interrupt (MSI) mechanism that treats messages as interrupts.\n* `INTx` - Line-based interrupt (INTx) mechanism similar to the one used in Legacy systems."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VnicEthInterruptSettings.ModeEnum Mode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VnicEthInterruptSettings.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VnicEthInterruptSettings initObject = new Intersight.Model.VnicEthInterruptSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CoalescingTime"))
            {
                initObject.CoalescingTime = this.CoalescingTime;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CoalescingType"))
            {
                initObject.CoalescingType = this.CoalescingType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Count"))
            {
                initObject.Count = this.Count;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Mode"))
            {
                initObject.Mode = this.Mode;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicFcQueueSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicFcQueueSettings")]
    public class InitializeIntersightVnicFcQueueSettings:PSCmdlet
	{
		public InitializeIntersightVnicFcQueueSettings()
		{
            ClassId = VnicFcQueueSettings.ClassIdEnum.VnicFcQueueSettings;
            ObjectType = VnicFcQueueSettings.ObjectTypeEnum.VnicFcQueueSettings;
            
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
        
        public VnicFcQueueSettings.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VnicFcQueueSettings.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of descriptors in each queue."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(64, 2048)]
        public long RingSize {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VnicFcQueueSettings initObject = new Intersight.Model.VnicFcQueueSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RingSize"))
            {
                initObject.RingSize = this.RingSize;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicPlogiSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicPlogiSettings")]
    public class InitializeIntersightVnicPlogiSettings:PSCmdlet
	{
		public InitializeIntersightVnicPlogiSettings()
		{
            ClassId = VnicPlogiSettings.ClassIdEnum.VnicPlogiSettings;
            ObjectType = VnicPlogiSettings.ObjectTypeEnum.VnicPlogiSettings;
            
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
        
        public VnicPlogiSettings.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VnicPlogiSettings.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of times that the system tries to log in to a port after the first failure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Retries {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of milliseconds that the system waits before it tries to log in again."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1000, 255000)]
        public long Timeout {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VnicPlogiSettings initObject = new Intersight.Model.VnicPlogiSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Retries"))
            {
                initObject.Retries = this.Retries;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Timeout"))
            {
                initObject.Timeout = this.Timeout;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicEthTxQueueSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicEthTxQueueSettings")]
    public class InitializeIntersightVnicEthTxQueueSettings:PSCmdlet
	{
		public InitializeIntersightVnicEthTxQueueSettings()
		{
            ClassId = VnicEthTxQueueSettings.ClassIdEnum.VnicEthTxQueueSettings;
            ObjectType = VnicEthTxQueueSettings.ObjectTypeEnum.VnicEthTxQueueSettings;
            
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
        
        public VnicEthTxQueueSettings.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of queue resources to allocate."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 1000)]
        public long Count {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VnicEthTxQueueSettings.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of descriptors in each queue."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(64, 4096)]
        public long RingSize {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VnicEthTxQueueSettings initObject = new Intersight.Model.VnicEthTxQueueSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Count"))
            {
                initObject.Count = this.Count;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RingSize"))
            {
                initObject.RingSize = this.RingSize;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicRssHashSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicRssHashSettings")]
    public class InitializeIntersightVnicRssHashSettings:PSCmdlet
	{
		public InitializeIntersightVnicRssHashSettings()
		{
            ClassId = VnicRssHashSettings.ClassIdEnum.VnicRssHashSettings;
            ObjectType = VnicRssHashSettings.ObjectTypeEnum.VnicRssHashSettings;
            
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
        
        public VnicRssHashSettings.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When enabled, the IPv4 address is used for traffic distribution."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Ipv4Hash {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When enabled, the IPv6 extensions are used for traffic distribution."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Ipv6ExtHash {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When enabled, the IPv6 address is used for traffic distribution."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Ipv6Hash {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VnicRssHashSettings.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When enabled, both the IPv4 address and TCP port number are used for traffic distribution."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool TcpIpv4Hash {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When enabled, both the IPv6 extensions and TCP port number are used for traffic distribution."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool TcpIpv6ExtHash {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When enabled, both the IPv6 address and TCP port number are used for traffic distribution."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool TcpIpv6Hash {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When enabled, both the IPv4 address and UDP port number are used for traffic distribution."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool UdpIpv4Hash {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When enabled, both the IPv6 address and UDP port number are used for traffic distribution."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool UdpIpv6Hash {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VnicRssHashSettings initObject = new Intersight.Model.VnicRssHashSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Ipv4Hash"))
            {
                initObject.Ipv4Hash = this.Ipv4Hash;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Ipv6ExtHash"))
            {
                initObject.Ipv6ExtHash = this.Ipv6ExtHash;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Ipv6Hash"))
            {
                initObject.Ipv6Hash = this.Ipv6Hash;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("TcpIpv4Hash"))
            {
                initObject.TcpIpv4Hash = this.TcpIpv4Hash;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TcpIpv6ExtHash"))
            {
                initObject.TcpIpv6ExtHash = this.TcpIpv6ExtHash;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TcpIpv6Hash"))
            {
                initObject.TcpIpv6Hash = this.TcpIpv6Hash;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UdpIpv4Hash"))
            {
                initObject.UdpIpv4Hash = this.UdpIpv4Hash;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UdpIpv6Hash"))
            {
                initObject.UdpIpv6Hash = this.UdpIpv6Hash;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicIscsiAuthProfile.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicIscsiAuthProfile")]
    public class InitializeIntersightVnicIscsiAuthProfile:PSCmdlet
	{
		public InitializeIntersightVnicIscsiAuthProfile()
		{
            ClassId = VnicIscsiAuthProfile.ClassIdEnum.VnicIscsiAuthProfile;
            ObjectType = VnicIscsiAuthProfile.ObjectTypeEnum.VnicIscsiAuthProfile;
            
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
        
        public VnicIscsiAuthProfile.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VnicIscsiAuthProfile.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Password of Initiator/Target Interface. Enter between 12 and 16 characters, including special characters except spaces, tabs, line breaks."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[\\S+]{12,16}$")]
        public string Password {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User Id of Initiator/Target Interface. Enter between 1 and 128 characters, spaces, or special characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^.{1,128}$")]
        public string UserId {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VnicIscsiAuthProfile initObject = new Intersight.Model.VnicIscsiAuthProfile();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("UserId"))
            {
                initObject.UserId = this.UserId;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicFcInterruptSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicFcInterruptSettings")]
    public class InitializeIntersightVnicFcInterruptSettings:PSCmdlet
	{
		public InitializeIntersightVnicFcInterruptSettings()
		{
            ClassId = VnicFcInterruptSettings.ClassIdEnum.VnicFcInterruptSettings;
            Mode = VnicFcInterruptSettings.ModeEnum.MSIx;
            ObjectType = VnicFcInterruptSettings.ObjectTypeEnum.VnicFcInterruptSettings;
            
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
        
        public VnicFcInterruptSettings.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The preferred driver interrupt mode. This can be one of the following:- MSIx - Message Signaled Interrupts (MSI) with the optional extension. MSI  - MSI only. INTx - PCI INTx interrupts. MSIx is the recommended option.\n* `MSIx` - Message Signaled Interrupt (MSI) mechanism with the optional extension (MSIx). MSIx is the recommended and default option.\n* `MSI` - Message Signaled Interrupt (MSI) mechanism that treats messages as interrupts.\n* `INTx` - Line-based interrupt (INTx) mechanism similar to the one used in Legacy systems."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VnicFcInterruptSettings.ModeEnum Mode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VnicFcInterruptSettings.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VnicFcInterruptSettings initObject = new Intersight.Model.VnicFcInterruptSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Mode"))
            {
                initObject.Mode = this.Mode;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicLun.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicLun")]
    public class InitializeIntersightVnicLun:PSCmdlet
	{
		public InitializeIntersightVnicLun()
		{
            ClassId = VnicLun.ClassIdEnum.VnicLun;
            ObjectType = VnicLun.ObjectTypeEnum.VnicLun;
            
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
        /// <para type="description">"Specifies LUN is bootable."</para>
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
        
        public VnicLun.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Identifier of the LUN."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long LunId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VnicLun.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VnicLun initObject = new Intersight.Model.VnicLun();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Bootable"))
            {
                initObject.Bootable = this.Bootable;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("LunId"))
            {
                initObject.LunId = this.LunId;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicTcpOffloadSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicTcpOffloadSettings")]
    public class InitializeIntersightVnicTcpOffloadSettings:PSCmdlet
	{
		public InitializeIntersightVnicTcpOffloadSettings()
		{
            ClassId = VnicTcpOffloadSettings.ClassIdEnum.VnicTcpOffloadSettings;
            ObjectType = VnicTcpOffloadSettings.ObjectTypeEnum.VnicTcpOffloadSettings;
            
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
        
        public VnicTcpOffloadSettings.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enables the reassembly of segmented packets in hardware before sending them to the CPU."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool LargeReceive {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enables the CPU to send large packets to the hardware for segmentation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool LargeSend {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VnicTcpOffloadSettings.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When enabled, the CPU sends all packet checksums to the hardware for validation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool RxChecksum {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When enabled, the CPU sends all packets to the hardware so that the checksum can be calculated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool TxChecksum {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VnicTcpOffloadSettings initObject = new Intersight.Model.VnicTcpOffloadSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("LargeReceive"))
            {
                initObject.LargeReceive = this.LargeReceive;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LargeSend"))
            {
                initObject.LargeSend = this.LargeSend;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RxChecksum"))
            {
                initObject.RxChecksum = this.RxChecksum;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TxChecksum"))
            {
                initObject.TxChecksum = this.TxChecksum;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicVifStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicVifStatus")]
    public class InitializeIntersightVnicVifStatus:PSCmdlet
	{
		public InitializeIntersightVnicVifStatus()
		{
            ClassId = VnicVifStatus.ClassIdEnum.VnicVifStatus;
            ObjectType = VnicVifStatus.ObjectTypeEnum.VnicVifStatus;
            Status = VnicVifStatus.StatusEnum.Ok;
            
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
        
        public VnicVifStatus.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the vNIC for which the status is reported."</para>
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
        
        public VnicVifStatus.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The reason for the status - it will be empty if status is ok or validating. If error, it will have the appropriate message indicating the reason for failure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Reason {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates if the vNIC / vHBA is ready for deploy or not.\n* `ok` - No issues with the LCP/SCP/VIF.\n* `error` - The LCP/SCP/VIF cannot be deployed due to error.\n* `validating` - Validation in progress for the LCP."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VnicVifStatus.StatusEnum Status {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VnicVifStatus initObject = new Intersight.Model.VnicVifStatus();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Reason"))
            {
                initObject.Reason = this.Reason;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Status"))
            {
                initObject.Status = this.Status;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicVxlanSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicVxlanSettings")]
    public class InitializeIntersightVnicVxlanSettings:PSCmdlet
	{
		public InitializeIntersightVnicVxlanSettings()
		{
            ClassId = VnicVxlanSettings.ClassIdEnum.VnicVxlanSettings;
            ObjectType = VnicVxlanSettings.ObjectTypeEnum.VnicVxlanSettings;
            
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
        
        public VnicVxlanSettings.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Status of the Virtual Extensible LAN Protocol on the virtual ethernet interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VnicVxlanSettings.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VnicVxlanSettings initObject = new Intersight.Model.VnicVxlanSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Enabled"))
            {
                initObject.Enabled = this.Enabled;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicUsnicSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicUsnicSettings")]
    public class InitializeIntersightVnicUsnicSettings:PSCmdlet
	{
		public InitializeIntersightVnicUsnicSettings()
		{
            ClassId = VnicUsnicSettings.ClassIdEnum.VnicUsnicSettings;
            ObjectType = VnicUsnicSettings.ObjectTypeEnum.VnicUsnicSettings;
            
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
        
        public VnicUsnicSettings.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Class of Service to be used for traffic on the usNIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Cos {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of usNIC interfaces to be created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Count {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VnicUsnicSettings.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Ethernet Adapter policy to be associated with the usNICs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string UsnicAdapterPolicy {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VnicUsnicSettings initObject = new Intersight.Model.VnicUsnicSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Cos"))
            {
                initObject.Cos = this.Cos;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Count"))
            {
                initObject.Count = this.Count;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("UsnicAdapterPolicy"))
            {
                initObject.UsnicAdapterPolicy = this.UsnicAdapterPolicy;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicFcErrorRecoverySettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicFcErrorRecoverySettings")]
    public class InitializeIntersightVnicFcErrorRecoverySettings:PSCmdlet
	{
		public InitializeIntersightVnicFcErrorRecoverySettings()
		{
            ClassId = VnicFcErrorRecoverySettings.ClassIdEnum.VnicFcErrorRecoverySettings;
            ObjectType = VnicFcErrorRecoverySettings.ObjectTypeEnum.VnicFcErrorRecoverySettings;
            
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
        
        public VnicFcErrorRecoverySettings.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enables Fibre Channel Error recovery."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Enabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of times an I/O request to a port is retried because the port is busy before the system decides the port is unavailable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long IoRetryCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of seconds the adapter waits before aborting the pending command and resending the same IO request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 59)]
        public long IoRetryTimeout {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of milliseconds the port should actually be down before it is marked down and fabric connectivity is lost."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long LinkDownTimeout {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VnicFcErrorRecoverySettings.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of milliseconds a remote Fibre Channel port should be offline before informing the SCSI upper layer that the port is unavailable. For a server with a VIC adapter running ESXi, the recommended value is 10000. For a server with a port used to boot a Windows OS from the SAN, the recommended value is 5000 milliseconds."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long PortDownTimeout {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VnicFcErrorRecoverySettings initObject = new Intersight.Model.VnicFcErrorRecoverySettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Enabled"))
            {
                initObject.Enabled = this.Enabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IoRetryCount"))
            {
                initObject.IoRetryCount = this.IoRetryCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IoRetryTimeout"))
            {
                initObject.IoRetryTimeout = this.IoRetryTimeout;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LinkDownTimeout"))
            {
                initObject.LinkDownTimeout = this.LinkDownTimeout;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PortDownTimeout"))
            {
                initObject.PortDownTimeout = this.PortDownTimeout;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicVlanSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicVlanSettings")]
    public class InitializeIntersightVnicVlanSettings:PSCmdlet
	{
		public InitializeIntersightVnicVlanSettings()
		{
            ClassId = VnicVlanSettings.ClassIdEnum.VnicVlanSettings;
            Mode = VnicVlanSettings.ModeEnum.ACCESS;
            ObjectType = VnicVlanSettings.ObjectTypeEnum.VnicVlanSettings;
            
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
        /// <para type="description">"Allowed VLAN IDs of the virtual interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^((\\d+\\-\\d+)|(\\d+))(,((\\d+\\-\\d+)|(\\d+)))*$")]
        public string AllowedVlans {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VnicVlanSettings.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Native VLAN ID of the virtual interface or the corresponding vethernet on the peer Fabric Interconnect to which the virtual interface is connected. Setting the ID to 0 will not associate any native VLAN to the traffic on the virtual interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long DefaultVlan {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Option to determine if the port can carry single VLAN (Access) or multiple VLANs (Trunk) traffic.\n* `ACCESS` - An access port carries traffic only for a single VLAN on the interface.\n* `TRUNK` - A trunk port can have two or more VLANs configured on the interface. It can carry traffic for several VLANs simultaneously."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VnicVlanSettings.ModeEnum Mode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VnicVlanSettings.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VnicVlanSettings initObject = new Intersight.Model.VnicVlanSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AllowedVlans"))
            {
                initObject.AllowedVlans = this.AllowedVlans;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DefaultVlan"))
            {
                initObject.DefaultVlan = this.DefaultVlan;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Mode"))
            {
                initObject.Mode = this.Mode;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicEthRxQueueSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicEthRxQueueSettings")]
    public class InitializeIntersightVnicEthRxQueueSettings:PSCmdlet
	{
		public InitializeIntersightVnicEthRxQueueSettings()
		{
            ClassId = VnicEthRxQueueSettings.ClassIdEnum.VnicEthRxQueueSettings;
            ObjectType = VnicEthRxQueueSettings.ObjectTypeEnum.VnicEthRxQueueSettings;
            
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
        
        public VnicEthRxQueueSettings.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of queue resources to allocate."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 1000)]
        public long Count {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VnicEthRxQueueSettings.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of descriptors in each queue."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(64, 4096)]
        public long RingSize {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VnicEthRxQueueSettings initObject = new Intersight.Model.VnicEthRxQueueSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Count"))
            {
                initObject.Count = this.Count;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RingSize"))
            {
                initObject.RingSize = this.RingSize;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicFlogiSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicFlogiSettings")]
    public class InitializeIntersightVnicFlogiSettings:PSCmdlet
	{
		public InitializeIntersightVnicFlogiSettings()
		{
            ClassId = VnicFlogiSettings.ClassIdEnum.VnicFlogiSettings;
            ObjectType = VnicFlogiSettings.ObjectTypeEnum.VnicFlogiSettings;
            
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
        
        public VnicFlogiSettings.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VnicFlogiSettings.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of times that the system tries to log in to the fabric after the first failure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Retries {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of milliseconds that the system waits before it tries to log in again."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1000, 255000)]
        public long Timeout {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VnicFlogiSettings initObject = new Intersight.Model.VnicFlogiSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Retries"))
            {
                initObject.Retries = this.Retries;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Timeout"))
            {
                initObject.Timeout = this.Timeout;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize VnicCompletionQueueSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightVnicCompletionQueueSettings")]
    public class InitializeIntersightVnicCompletionQueueSettings:PSCmdlet
	{
		public InitializeIntersightVnicCompletionQueueSettings()
		{
            ClassId = VnicCompletionQueueSettings.ClassIdEnum.VnicCompletionQueueSettings;
            ObjectType = VnicCompletionQueueSettings.ObjectTypeEnum.VnicCompletionQueueSettings;
            
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
        
        public VnicCompletionQueueSettings.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of completion queue resources to allocate. In general, the number of completion queue resources to allocate is equal to the number of transmit queue resources plus the number of receive queue resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 2000)]
        public long Count {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VnicCompletionQueueSettings.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.VnicCompletionQueueSettings initObject = new Intersight.Model.VnicCompletionQueueSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Count"))
            {
                initObject.Count = this.Count;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
}