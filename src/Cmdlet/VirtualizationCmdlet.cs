using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set VirtualizationVmwareCluster.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightVirtualizationVmwareCluster")]
    public class SetIntersightVirtualizationVmwareCluster:SetCmdletBase
	{
		public SetIntersightVirtualizationVmwareCluster()
		{
			ApiInstance = new VirtualizationApi(Config);
            ModelObject = new VirtualizationVmwareCluster();
            MethodName = "UpdateVirtualizationVmwareCluster";
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
        /// <para type="description">"CPU over commitment associated with this cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long CpuOverCommitment {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Count of all datastores associated with this cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long DatastoreCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Identifies the broad type of the underlying hypervisor.\n* `ESXi` - The hypervisor running on the HyperFlex cluster is a Vmware ESXi hypervisor of any version.\n* `HyperFlexAp` - The hypervisor running on the HyperFlex cluster is Cisco HyperFlex Application Platform.\n* `Hyper-V` - The hypervisor running on the HyperFlex cluster is Microsoft Hyper-V.\n* `Unknown` - The hypervisor running on the HyperFlex cluster is not known."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareCluster.HypervisorTypeEnum HypervisorType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Inventory path of the cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string InventoryPath {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The capacity and usage information for memory on this cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationMemoryCapacity MemoryCapacity {
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
        /// <para type="description">"The capacity and usage information for CPU power on this cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationComputeCapacity ProcessorCapacity {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceRegistrationRelationship RegisteredDevice {
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
        /// <para type="description">"Total number of CPU cores in this cluster. It is a cumulative number across all hosts in the cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long TotalCores {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get VirtualizationVmwareNetwork.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightVirtualizationVmwareNetwork", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightVirtualizationVmwareNetwork:GetCmdletBase
	{
		public GetIntersightVirtualizationVmwareNetwork()
		{
			ApiInstance = new VirtualizationApi(Config);
            MethodName = "GetVirtualizationVmwareNetworkList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get VirtualizationVmwareDistributedSwitch.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightVirtualizationVmwareDistributedSwitch", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightVirtualizationVmwareDistributedSwitch:GetCmdletBase
	{
		public GetIntersightVirtualizationVmwareDistributedSwitch()
		{
			ApiInstance = new VirtualizationApi(Config);
            MethodName = "GetVirtualizationVmwareDistributedSwitchList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get VirtualizationVmwareUplinkPort.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightVirtualizationVmwareUplinkPort", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightVirtualizationVmwareUplinkPort:GetCmdletBase
	{
		public GetIntersightVirtualizationVmwareUplinkPort()
		{
			ApiInstance = new VirtualizationApi(Config);
            MethodName = "GetVirtualizationVmwareUplinkPortList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set VirtualizationVmwarePhysicalNetworkInterface.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightVirtualizationVmwarePhysicalNetworkInterface")]
    public class SetIntersightVirtualizationVmwarePhysicalNetworkInterface:SetCmdletBase
	{
		public SetIntersightVirtualizationVmwarePhysicalNetworkInterface()
		{
			ApiInstance = new VirtualizationApi(Config);
            ModelObject = new VirtualizationVmwarePhysicalNetworkInterface();
            MethodName = "PatchVirtualizationVmwarePhysicalNetworkInterface";
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
        /// <para type="description">"Driver type associated with physical network interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Driver {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The internally generated identity of physical network interface. This entity cannot manipulated by users. It aids in uniquely identifying the physical network interface object. For VMware, this is MOR (managed object reference)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Identity {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Link speed of the physical network interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public int LinkSpeed {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Standard MAC address assigned to physical network interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^([0-9A-Fa-f]{2}[:-]){5}([0-9A-Fa-f]{2})$")]
        public string MacAddress {
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
        /// <para type="description">"User-provided name to identify the physical network interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"PCI info for physical network interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Pci {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceRegistrationRelationship RegisteredDevice {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Switch associated with the physical network interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SwitchName {
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
    /// <para type="synopsis">This is the cmdlet to Get VirtualizationVirtualDisk.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightVirtualizationVirtualDisk", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightVirtualizationVirtualDisk:GetCmdletBase
	{
		public GetIntersightVirtualizationVirtualDisk()
		{
			ApiInstance = new VirtualizationApi(Config);
            MethodName = "GetVirtualizationVirtualDiskList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New VirtualizationVirtualDisk.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightVirtualizationVirtualDisk")]
    public class NewIntersightVirtualizationVirtualDisk:NewCmdletBase
	{
		public NewIntersightVirtualizationVirtualDisk()
		{
			ApiInstance = new VirtualizationApi(Config);
            ModelObject = new VirtualizationVirtualDisk();
            MethodName = "CreateVirtualizationVirtualDisk";
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
        /// <para type="description">"A reference to a virtualizationBaseCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationBaseClusterRelationship Cluster {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"File mode of the disk  example - Filesystem, Block.\n* `Block` - It is a Block virtual disk.\n* `Filesystem` - It is a File system virtual disk.\n* `` - Disk mode is either unknown or not supported."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVirtualDisk.ModeEnum Mode {
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
        /// <para type="description">"Name of the storage disk. Name must be unique within a Datastore."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9-]{3,48}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceRegistrationRelationship RegisteredDevice {
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
        /// <para type="description">"Source disk from which the content is copied."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SourceDiskToClone {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Image path used to import on the created disk."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SourceFilePath {
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
    /// <para type="synopsis">This is the cmdlet to Get VirtualizationVmwareVirtualSwitch.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightVirtualizationVmwareVirtualSwitch", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightVirtualizationVmwareVirtualSwitch:GetCmdletBase
	{
		public GetIntersightVirtualizationVmwareVirtualSwitch()
		{
			ApiInstance = new VirtualizationApi(Config);
            MethodName = "GetVirtualizationVmwareVirtualSwitchList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set VirtualizationVmwareDistributedNetwork.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightVirtualizationVmwareDistributedNetwork")]
    public class SetIntersightVirtualizationVmwareDistributedNetwork:SetCmdletBase
	{
		public SetIntersightVirtualizationVmwareDistributedNetwork()
		{
			ApiInstance = new VirtualizationApi(Config);
            ModelObject = new VirtualizationVmwareDistributedNetwork();
            MethodName = "UpdateVirtualizationVmwareDistributedNetwork";
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
        /// <para type="description">"If forgedTransmits property value is set to reject, outbound frames with a source MAC address different from the one set on the adapter are dropped. If property value is set to accept, no filtering is performed and all outbound frames are passed.\n* `Reject` - Indicates that the security policy is rejected.\n* `Accept` - Indicates that the security policy is accepted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareDistributedNetwork.ForgedTransmitsEnum ForgedTransmits {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The internally generated identity of network. This entity cannot manipulated by users. It aids in uniquely identifying the network object. For VMware, this is MOR (managed object reference)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Identity {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If macAddressChanges property value is set to reject and the MAC address of the adapter is changed to a value other than the one specified in .vmx configuration file, all inbound frames are dropped. If property value is set to accept and the MAC address is changed, inbound frames to the new MAC address are received.\n* `Reject` - Indicates that the security policy is rejected.\n* `Accept` - Indicates that the security policy is accepted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareDistributedNetwork.MacAddressChangesEnum MacAddressChanges {
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
        /// <para type="description">"User-provided name to identify the portgroup."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The teams can then either share the load of traffic between physical and virtual networks among some or all of its members, or provide passive failover in the event of a hardware failure or a network outage."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareTeamingAndFailover NicTeamingAndFailover {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The total number of hosts connected to this distributed virtual network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NumHosts {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The total number of ports in the distributed virtual network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NumPorts {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If promiscuousMode property value is set to reject, incoming traffic only targeted to that network will be visible. If property value is set to accept, objects defined within the network can see all incoming traffic on the virtual switch based on the VLAN policy.\n* `Reject` - Indicates that the security policy is rejected.\n* `Accept` - Indicates that the security policy is accepted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareDistributedNetwork.PromiscuousModeEnum PromiscuousMode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceRegistrationRelationship RegisteredDevice {
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
        /// <para type="description">"Indicates if the distributed virtual network is a uplink."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool UpLink {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<VirtualizationVmwareVlanRange> VlanRange {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VLAN type of the distributed virtual network. It can be None, VLAN, VLAN Trunking or Private VLAN.\n* `None` - Do not tag traffic with any VLAN Id.\n* `VLAN` - Tag traffic with the Id from the VLAN Id field.\n* `VLAN trunking` - Pass VLAN traffic with Id within the VLAN trunk range to guest operating system.\n* `Private VLAN` - Associate the traffic with a private VLAN created on the distributed switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareDistributedNetwork.VlanTypeEnum VlanType {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set VirtualizationVmwareKernelNetwork.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightVirtualizationVmwareKernelNetwork")]
    public class SetIntersightVirtualizationVmwareKernelNetwork:SetCmdletBase
	{
		public SetIntersightVirtualizationVmwareKernelNetwork()
		{
			ApiInstance = new VirtualizationApi(Config);
            ModelObject = new VirtualizationVmwareKernelNetwork();
            MethodName = "UpdateVirtualizationVmwareKernelNetwork";
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
        /// <para type="description">"Indicates that fault tolerance logging is enabled on this kernel network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool FaultToleranceLogging {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The internally generated identity of network. This entity cannot manipulated by users. It aids in uniquely identifying the network object. For VMware, this is MOR (managed object reference)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Identity {
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
        /// <para type="description">"Standard MAC address assigned to this kernel network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^([0-9A-Fa-f]{2}[:-]){5}([0-9A-Fa-f]{2})$")]
        public string MacAddress {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates that management traffic is enabled on this kernel network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Management {
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
        /// <para type="description">"Maximum transmission unit configured on a kernel network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Mtu {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User-provided name to identify the portgroup."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceRegistrationRelationship RegisteredDevice {
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
        /// <para type="description">"Indicates that vmotion is enabled on this kernel network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Vmotion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates that vsan traffic is enabled on this kernel network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Vsan {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates that vsphere provisioning traffic is enabled on this kernel network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool VsphereProvisioning {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates that vsphere replication is enabled on this kernel network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool VsphereReplication {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates that vsphere replication nfc is enabled on this kernel network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool VsphereReplicationNfc {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get VirtualizationVmwareVirtualMachine.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightVirtualizationVmwareVirtualMachine", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightVirtualizationVmwareVirtualMachine:GetCmdletBase
	{
		public GetIntersightVirtualizationVmwareVirtualMachine()
		{
			ApiInstance = new VirtualizationApi(Config);
            MethodName = "GetVirtualizationVmwareVirtualMachineList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get VirtualizationHost.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightVirtualizationHost", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightVirtualizationHost:GetCmdletBase
	{
		public GetIntersightVirtualizationHost()
		{
			ApiInstance = new VirtualizationApi(Config);
            MethodName = "GetVirtualizationHostList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set VirtualizationVmwareVirtualNetworkInterface.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightVirtualizationVmwareVirtualNetworkInterface")]
    public class SetIntersightVirtualizationVmwareVirtualNetworkInterface:SetCmdletBase
	{
		public SetIntersightVirtualizationVmwareVirtualNetworkInterface()
		{
			ApiInstance = new VirtualizationApi(Config);
            ModelObject = new VirtualizationVmwareVirtualNetworkInterface();
            MethodName = "UpdateVirtualizationVmwareVirtualNetworkInterface";
		}
        // <summary>
        /// <para type="description">"Type of virtual ethernet adapter for virtual network interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string AdapterType {
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
        /// <para type="description">"Connect or not to connect the device when the virtual machine starts."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool ConnectAtPowerOn {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Device is currently connected or not. Valid only while the virtual machine is running."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Connected {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The internally assigned key of this virtual network interface. This entity is not manipulated by users."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Key {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"MAC address assigned to virtual network interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^([0-9A-Fa-f]{2}[:-]){5}([0-9A-Fa-f]{2})$")]
        public string MacAddress {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"MAC address type for the mac address assigned to virtual network interface.\n* `manual` - Statically assigned MAC address.\n* `generated` - Automatically generated MAC address.\n* `assigned` - MAC address assigned by VCenter to the virtual network interface card."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareVirtualNetworkInterface.MacAddressTypeEnum MacAddressType {
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
        /// <para type="description">"Name of the virtual network interface created on a virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of network for virtual network interface. It can be either standard or distributed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string NetworkType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceRegistrationRelationship RegisteredDevice {
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
        /// <para type="description">"Identity of the virtual machine where the virtual network interface is created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string VmIdentity {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get VirtualizationVmwareVcenter.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightVirtualizationVmwareVcenter", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightVirtualizationVmwareVcenter:GetCmdletBase
	{
		public GetIntersightVirtualizationVmwareVcenter()
		{
			ApiInstance = new VirtualizationApi(Config);
            MethodName = "GetVirtualizationVmwareVcenterList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set VirtualizationVmwareFolder.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightVirtualizationVmwareFolder")]
    public class SetIntersightVirtualizationVmwareFolder:SetCmdletBase
	{
		public SetIntersightVirtualizationVmwareFolder()
		{
			ApiInstance = new VirtualizationApi(Config);
            ModelObject = new VirtualizationVmwareFolder();
            MethodName = "UpdateVirtualizationVmwareFolder";
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
        /// <para type="description">"A reference to a virtualizationVmwareVcenter resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareVcenterRelationship HypervisorManager {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The internally generated identity of this folder. This entity is not manipulated by users. It aids in uniquely identifying the folder object. For VMware, this is a MOR (managed object reference)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Identity {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If a folder is internal, it will be set to true."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Internal {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Inventory path to the folder. Example - /DC/myFolder."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string InventoryPath {
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
        /// <para type="description">"Name of the folder as stored in vCenter."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceRegistrationRelationship RegisteredDevice {
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
        /// <para type="description">"Determines the type of folder. e.g. vCenter folder, VM and Templete Folder, StorageFolder, NetworkFolder, Host and Cluster Folder.\n* `Unknown` - The type of the folder is unknown. It may not represent that the folder does not exist but indicates that something might be wrong.\n* `VMTemplateFolder` - The folder contains VMs and VM templates.\n* `StorageFolder` - The folder contains storage devices.\n* `HostClusterFolder` - The folder contains hosts and clusters.\n* `NetworkFolder` - The folder contains network items.\n* `VcenterFolder` - The folder created under a vCenter or vCenter folder."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareFolder.TypeofFolderEnum TypeofFolder {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a virtualizationVmwareFolder resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareFolderRelationship VmwareFolder {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set VirtualizationVmwareVirtualDisk.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightVirtualizationVmwareVirtualDisk")]
    public class SetIntersightVirtualizationVmwareVirtualDisk:SetCmdletBase
	{
		public SetIntersightVirtualizationVmwareVirtualDisk()
		{
			ApiInstance = new VirtualizationApi(Config);
            ModelObject = new VirtualizationVmwareVirtualDisk();
            MethodName = "UpdateVirtualizationVmwareVirtualDisk";
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
        /// <para type="description">"Compatibility mode of the raw disk mapping (RDM).\n* `notApplicable` - Value specified for any disk which is not of raw device mapping type.\n* `physicalMode` - A disk device backed by a physical compatibility mode raw disk mapping cannot use disk modes, and commands are passed straight through to the LUN indicated by the raw disk mapping.\n* `virtualMode` - A disk device backed by a virtual compatibility mode raw disk mapping can use disk modes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareVirtualDisk.CompatibilityModeEnum CompatibilityMode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Key of the controller on which the disk is created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long ControllerKey {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Host-specific device the LUN is being accessed through. If the target LUN is not available on the host then it is empty. For example, this could happen if it has accidentally been masked out."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DeviceName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Persistence mode of the virtual disk. For RDM disks, it is only supported when the raw disk mapping is using virtual compatibility mode.\n* `persistent` - Changes are immediately and permanently written to the virtual disk.\n* `independent_persistent` - Changes are immediately and permanently written to the virtual disk and not affected by snapshots.\n* `independent_nonpersistent` - Changes to virtual disk are made to a redo log and discarded at power off and not affected by snapshots.\n* `nonpersistent` - Changes to virtual disk are made to a redo log and discarded at power off.\n* `undoable` - Changes to virtual disk are made to a redo log and has the option to commit or undo.\n* `append` - Changes are appended to the redo log and can be revoked by removing the undo log."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareVirtualDisk.DiskModeEnum DiskMode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specifies whether the virtual disk is a RDM or a Hard disk.\n* `flatDisk` - Specifies that it is a flat disk.\n* `rdmDisk` - Specifies that it is a raw device mapping disk."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareVirtualDisk.DiskTypeEnum DiskType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The internally assigned key of this disk. This entity is not manipulated by users."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Key {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The utilization of a virtual machine will not exceed this limit, even if there are available resources. Used to ensure a consistent performance of virtual machines independent of available resources. If set to -1, then there is no fixed limit on resource usage (only bounded by available resources and shares). The unit is number of I/O per second."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Limit {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Unique identifier of the LUN accessed by the raw disk mapping (RDM)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string LunUuid {
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
        /// <para type="description">"Name of the storage disk. Name must be unique within a Datastore."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceRegistrationRelationship RegisteredDevice {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Serial ID of the storage device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Serial {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Disk shares used for resource scheduling."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareSharesInfo Shares {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Sharing mode of the virtual disk.\n* `sharingNone` - The virtual disk is not shared.\n* `sharingMultiWriter` - The virtual disk is shared between multiple virtual machines."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareVirtualDisk.SharingEnum Sharing {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Disk size represented in bytes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Size {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Allocation type for the virtual disk.\n* `notApplicable` - Value specified for a disk for which storage allocation type is not applicable.\n* `thin` - A thin provisioned disk consumes only the space that it needs for its initial operrations, and grows with time according to demand. It is the fastest method to create a virtual disk because it creates a disk with just the header information.\n* `lazyZeroedThick` - A lazy zeroed thick disk has all space allocated at the time of its creation. Data remaining on the physical device is not erased during creation, but is zeroed out on demand later on first write from the virtual machine.\n* `eagerZeroedThick` - An eager zeroed thick disk has all space allocated and wiped clean of any previous contents on the physical media at creation time. Such disks may take longer time during creation compared to other disk formats."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareVirtualDisk.StorageAllocationTypeEnum StorageAllocationType {
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
        /// <para type="description">"Unit number of the disk on its controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long UnitNumber {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"UUID assigned by vCenter to every disk."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$")]
        public string Uuid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Identity of the virtual disk object as the first class entity."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$")]
        public string VdiskId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Vendor of the storage device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vendor {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Path of the virtual disk."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string VirtualDiskPath {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Identity of the virtual machine where the virtual disk is created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string VmIdentity {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get VirtualizationVmwareKernelNetwork.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightVirtualizationVmwareKernelNetwork", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightVirtualizationVmwareKernelNetwork:GetCmdletBase
	{
		public GetIntersightVirtualizationVmwareKernelNetwork()
		{
			ApiInstance = new VirtualizationApi(Config);
            MethodName = "GetVirtualizationVmwareKernelNetworkList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get VirtualizationVmwareVirtualNetworkInterface.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightVirtualizationVmwareVirtualNetworkInterface", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightVirtualizationVmwareVirtualNetworkInterface:GetCmdletBase
	{
		public GetIntersightVirtualizationVmwareVirtualNetworkInterface()
		{
			ApiInstance = new VirtualizationApi(Config);
            MethodName = "GetVirtualizationVmwareVirtualNetworkInterfaceList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get VirtualizationVmwareDistributedNetwork.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightVirtualizationVmwareDistributedNetwork", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightVirtualizationVmwareDistributedNetwork:GetCmdletBase
	{
		public GetIntersightVirtualizationVmwareDistributedNetwork()
		{
			ApiInstance = new VirtualizationApi(Config);
            MethodName = "GetVirtualizationVmwareDistributedNetworkList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get VirtualizationVmwarePhysicalNetworkInterface.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightVirtualizationVmwarePhysicalNetworkInterface", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightVirtualizationVmwarePhysicalNetworkInterface:GetCmdletBase
	{
		public GetIntersightVirtualizationVmwarePhysicalNetworkInterface()
		{
			ApiInstance = new VirtualizationApi(Config);
            MethodName = "GetVirtualizationVmwarePhysicalNetworkInterfaceList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set VirtualizationVmwareUplinkPort.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightVirtualizationVmwareUplinkPort")]
    public class SetIntersightVirtualizationVmwareUplinkPort:SetCmdletBase
	{
		public SetIntersightVirtualizationVmwareUplinkPort()
		{
			ApiInstance = new VirtualizationApi(Config);
            ModelObject = new VirtualizationVmwareUplinkPort();
            MethodName = "UpdateVirtualizationVmwareUplinkPort";
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
        /// <para type="description">"The VMware managed object reference as a string."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Identity {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The internally assigned key of this uplink port object. This entity is not manipulated by users."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Key {
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
        /// <para type="description">"User-provided name to identify the uplink port object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceRegistrationRelationship RegisteredDevice {
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
    /// <para type="synopsis">This is the cmdlet to Get VirtualizationVmwareCluster.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightVirtualizationVmwareCluster", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightVirtualizationVmwareCluster:GetCmdletBase
	{
		public GetIntersightVirtualizationVmwareCluster()
		{
			ApiInstance = new VirtualizationApi(Config);
            MethodName = "GetVirtualizationVmwareClusterList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get VirtualizationVmwareVirtualDisk.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightVirtualizationVmwareVirtualDisk", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightVirtualizationVmwareVirtualDisk:GetCmdletBase
	{
		public GetIntersightVirtualizationVmwareVirtualDisk()
		{
			ApiInstance = new VirtualizationApi(Config);
            MethodName = "GetVirtualizationVmwareVirtualDiskList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get VirtualizationVmwareHost.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightVirtualizationVmwareHost", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightVirtualizationVmwareHost:GetCmdletBase
	{
		public GetIntersightVirtualizationVmwareHost()
		{
			ApiInstance = new VirtualizationApi(Config);
            MethodName = "GetVirtualizationVmwareHostList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set VirtualizationVmwareNetwork.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightVirtualizationVmwareNetwork")]
    public class SetIntersightVirtualizationVmwareNetwork:SetCmdletBase
	{
		public SetIntersightVirtualizationVmwareNetwork()
		{
			ApiInstance = new VirtualizationApi(Config);
            ModelObject = new VirtualizationVmwareNetwork();
            MethodName = "UpdateVirtualizationVmwareNetwork";
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
        /// <para type="description">"If forgedTransmits property value is set to reject, outbound frames with source MAC address different from the one set on the adapter are dropped. If property value is set to accept, no filtering is performed and all outbound frames are passed.\n* `Reject` - Indicates that the security policy is rejected.\n* `Accept` - Indicates that the security policy is accepted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareNetwork.ForgedTransmitsEnum ForgedTransmits {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The internally generated identity of network. This entity cannot manipulated by users. It aids in uniquely identifying the network object. For VMware, this is MOR (managed object reference)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Identity {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If macAddressChanges property value is set to reject and the MAC address of the adapter is changed to a value other than the one specified in .vmx configuration file, all inbound frames are dropped. If property value is set to accept and the MAC address is changed, inbound frames to the new MAC address are received.\n* `Reject` - Indicates that the security policy is rejected.\n* `Accept` - Indicates that the security policy is accepted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareNetwork.MacAddressChangesEnum MacAddressChanges {
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
        /// <para type="description">"User-provided name to identify the portgroup."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The teams can then either share the load of traffic between physical and virtual networks among some or all of its members, or provide passive failover in the event of a hardware failure or a network outage."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareTeamingAndFailover NicTeamingAndFailover {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If promiscuousMode property value is set to reject, incoming traffic only targeted to that network will be visible. If property value is set to accept, objects defined within the network can see all incoming traffic on the virtual switch based on the VLAN policy.\n* `Reject` - Indicates that the security policy is rejected.\n* `Accept` - Indicates that the security policy is accepted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareNetwork.PromiscuousModeEnum PromiscuousMode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceRegistrationRelationship RegisteredDevice {
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
        /// <para type="description">"VLAN id with which the network is associated. A value of 0 specifies that port is not associated with a VLAN."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long VlanId {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get VirtualizationVmwareDatacenter.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightVirtualizationVmwareDatacenter", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightVirtualizationVmwareDatacenter:GetCmdletBase
	{
		public GetIntersightVirtualizationVmwareDatacenter()
		{
			ApiInstance = new VirtualizationApi(Config);
            MethodName = "GetVirtualizationVmwareDatacenterList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set VirtualizationHost.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightVirtualizationHost")]
    public class SetIntersightVirtualizationHost:SetCmdletBase
	{
		public SetIntersightVirtualizationHost()
		{
			ApiInstance = new VirtualizationApi(Config);
            ModelObject = new VirtualizationHost();
            MethodName = "UpdateVirtualizationHost";
		}
        // <summary>
        /// <para type="description">"Action to be performed on a host (Create, PowerState, Migrate, Clone etc).\n* `None` - A place holder for the default value.\n* `PowerOffStorageController` - Power off HyperFlex storage controller node running on selected hypervisor host.\n* `PowerOnStorageController` - Power on HyperFlex storage controller node running on selected hypervisor host."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationHost.ActionEnum Action {
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
    /// <para type="synopsis">This is the cmdlet to Set VirtualizationVmwareHost.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightVirtualizationVmwareHost")]
    public class SetIntersightVirtualizationVmwareHost:SetCmdletBase
	{
		public SetIntersightVirtualizationVmwareHost()
		{
			ApiInstance = new VirtualizationApi(Config);
            ModelObject = new VirtualizationVmwareHost();
            MethodName = "UpdateVirtualizationVmwareHost";
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
        /// <para type="description">"The time when this host booted up."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public DateTime BootTime {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a virtualizationVmwareCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareClusterRelationship Cluster {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates if the host is connected to the vCenter. Values are connected, not connected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ConnectionState {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Details about the CPUs installed on this host are represented here."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationCpuInfo CpuInfo {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The hardware details of this host. It includes capacity, manufacturer, and model information."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public InfraHardwareInfo HardwareInfo {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Is the host Powered-up or Powered-down.\n* `Unknown` - The entity's power state is unknown.\n* `PoweringOn` - The entity is powering on.\n* `PoweredOn` - The entity is powered on.\n* `PoweringOff` - The entity is powering off.\n* `PoweredOff` - The entity is powered down.\n* `StandBy` - The entity is in standby mode.\n* `Paused` - The entity is in pause state.\n* `Rebooting` - The entity reboot is in progress.\n* `` - The entity's power state is not available."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareHost.HwPowerStateEnum HwPowerState {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Identifies the broad type of the underlying hypervisor.\n* `ESXi` - The hypervisor running on the HyperFlex cluster is a Vmware ESXi hypervisor of any version.\n* `HyperFlexAp` - The hypervisor running on the HyperFlex cluster is Cisco HyperFlex Application Platform.\n* `Hyper-V` - The hypervisor running on the HyperFlex cluster is Microsoft Hyper-V.\n* `Unknown` - The hypervisor running on the HyperFlex cluster is not known."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareHost.HypervisorTypeEnum HypervisorType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The internally generated identity of this host. This entity is not manipulated by users. It aids in uniquely identifying the datacenter object. For VMware, this is an MOR (managed object reference)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Identity {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Is this host in maintenance mode. Set to true or false."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool MaintenanceMode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The memory capacity and usage information on this host."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationMemoryCapacity MemoryCapacity {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Commercial model information about this hardware."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Model {
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
        /// <para type="description">"Name of this host supplied by user. It is not the identity of the host. The name is subject to user manipulations."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The count of all network adapters attached to this host."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NetworkAdapterCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The capacity and usage information for CPU power on this host."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationComputeCapacity ProcessorCapacity {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Details of this product, such as vendor, model, etc. are represented here."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationProductInfo ProductInfo {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceRegistrationRelationship RegisteredDevice {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Snapshot of resources (CPU, memory, etc.) consumed by this host."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareResourceConsumption ResourceConsumed {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Serial number of this host (internally generated)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Serial {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Host health status, as reported by the hypervisor platform.\n* `Unknown` - Entity status is unknown.\n* `Degraded` - State is degraded, and might impact normal operation of the entity.\n* `Critical` - Entity is in a critical state, impacting operations.\n* `Ok` - Entity status is in a stable state, operating normally."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareHost.StatusEnum Status {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The count of all storage adapters attached to this host."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long StorageAdapterCount {
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
        /// <para type="description">"The uptime of the host, stored as Duration (from w3c)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string UpTime {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Universally unique identity of this host (example b3d4483b-5560-9342-8309-b486c9236610). Internally generated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$")]
        public string Uuid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The identity of this host within vCenter (optional)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string VcenterHostId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Commercial vendor details of this hardware."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vendor {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set VirtualizationVmwareVirtualSwitch.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightVirtualizationVmwareVirtualSwitch")]
    public class SetIntersightVirtualizationVmwareVirtualSwitch:SetCmdletBase
	{
		public SetIntersightVirtualizationVmwareVirtualSwitch()
		{
			ApiInstance = new VirtualizationApi(Config);
            ModelObject = new VirtualizationVmwareVirtualSwitch();
            MethodName = "UpdateVirtualizationVmwareVirtualSwitch";
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
        /// <para type="description">"If forgedTransmits property value is set to reject, outbound frames with a source MAC address different from the one set on the adapter are dropped. If property value is set to accept, the switch does not perform filtering and permits all outbound frames.\n* `Reject` - Indicates that the security policy is rejected.\n* `Accept` - Indicates that the security policy is accepted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareVirtualSwitch.ForgedTransmitsEnum ForgedTransmits {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The internally generated identity of this switch. This entity is not manipulated by users. It aids in uniquely identifying the switch object. For VMware, this is MOR (managed object reference)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Identity {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If macAddressChanges property value is set to reject and the MAC address of the adapter is changed to a value other than the one specified in .vmx configuration file, the switch drops all inbound frames to the adapter. If property value is set to accept and the MAC address is changed, the switch allows frames to the new MAC address to pass.\n* `Reject` - Indicates that the security policy is rejected.\n* `Accept` - Indicates that the security policy is accepted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareVirtualSwitch.MacAddressChangesEnum MacAddressChanges {
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
        /// <para type="description">"Maximum transmission unit configured on a virtual switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Mtu {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User-provided name to identify the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The teams can then either share the load of traffic between physical and virtual networks among some or all of its members, or provide passive failover in the event of a hardware failure or a network outage."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareTeamingAndFailover NicTeamingAndFailover {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of networks available on this virtual switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NumNetworks {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of physical network interfaces connected with this virtual switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NumPhysicalNetworkInterfaces {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If promiscuousMode property value is set to reject, the virtual switch forwards only frames that are addressed to the adapter. If property value is set to accept, the virtual switch forwards all frames to the adapter in compliance with the active VLAN policy for the port to which it is connected.\n* `Reject` - Indicates that the security policy is rejected.\n* `Accept` - Indicates that the security policy is accepted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareVirtualSwitch.PromiscuousModeEnum PromiscuousMode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceRegistrationRelationship RegisteredDevice {
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
    /// <para type="synopsis">This is the cmdlet to Set VirtualizationVmwareDistributedSwitch.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightVirtualizationVmwareDistributedSwitch")]
    public class SetIntersightVirtualizationVmwareDistributedSwitch:SetCmdletBase
	{
		public SetIntersightVirtualizationVmwareDistributedSwitch()
		{
			ApiInstance = new VirtualizationApi(Config);
            ModelObject = new VirtualizationVmwareDistributedSwitch();
            MethodName = "UpdateVirtualizationVmwareDistributedSwitch";
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
        /// <para type="description">"Switch description (user provided), if any."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The internally generated identity of this switch. This entity is not manipulated by users. It aids in uniquely identifying the switch object. For VMware, this is MOR (managed object reference)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Identity {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum number of ports allowed on this distributed virtual switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MaxPort {
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
        /// <para type="description">"Maximum transmission unit configured on a distributed virtual switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Mtu {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User-provided name to identify the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The teams can then either share the load of traffic between physical and virtual networks among some or all of its members, or provide passive failover in the event of a hardware failure or a network outage."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareTeamingAndFailover NicTeamingAndFailover {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The total number of hosts attached to the distributed virtual switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NumHosts {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The total number of distributed networks in the distributed virtual switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NumNetworks {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of stand-alone ports in use."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NumStandAlonePorts {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of uplinks configured in this distributed virtual switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NumUplinks {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceRegistrationRelationship RegisteredDevice {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Capacity and consumption information about this distributed virtual switch, if available."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationStorageCapacity SwitchCapacity {
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
        /// <para type="description">"Universally Unique Id of this distributed virtual switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$")]
        public string Uuid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The running config's version details are represented."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set VirtualizationVmwareDatacenter.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightVirtualizationVmwareDatacenter")]
    public class SetIntersightVirtualizationVmwareDatacenter:SetCmdletBase
	{
		public SetIntersightVirtualizationVmwareDatacenter()
		{
			ApiInstance = new VirtualizationApi(Config);
            ModelObject = new VirtualizationVmwareDatacenter();
            MethodName = "UpdateVirtualizationVmwareDatacenter";
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
        /// <para type="description">"Count of all clusters associated with this DC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long ClusterCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Count of all datastores associated with this DC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long DatastoreCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Count of all hosts associated with this DC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long HostCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The internally generated identity of this placement. This entity is not manipulated by users. It aids in uniquely identifying the placement object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Identity {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Inventory path of the DC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string InventoryPath {
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
        /// <para type="description">"Name of the virtual machine placement. It is the name of the VPC (Virtual Private Cloud) in case of AWS\nvirtual machine, and datacenter name in case of VMware virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Count of all networks associated with this datacenter (DC)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NetworkCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceRegistrationRelationship RegisteredDevice {
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
        /// <para type="description">"The uuid of this placement. The uuid is internally generated and not user specified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$")]
        public string Uuid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Count of all virtual machines (VMs) associated with this DC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long VmCount {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set VirtualizationVirtualMachine.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightVirtualizationVirtualMachine")]
    public class SetIntersightVirtualizationVirtualMachine:SetCmdletBase
	{
		public SetIntersightVirtualizationVirtualMachine()
		{
			ApiInstance = new VirtualizationApi(Config);
            ModelObject = new VirtualizationVirtualMachine();
            MethodName = "UpdateVirtualizationVirtualMachine";
		}
        // <summary>
        /// <para type="description">"Action to be performed on a virtual machine (Create, PowerState, Migrate, Clone etc).\n* `None` - A place holder for the default value.\n* `PowerState` - Power action is performed on the virtual machine.\n* `Migrate` - The virtual machine will be migrated from existing node to a different node in cluster. The behavior depends on the underlying hypervisor.\n* `Create` - The virtual machine will be created on the specified hypervisor. This action is also useful if the virtual machine creation failed during first POST operation on VirtualMachine managed object. User can set this action to retry the virtual machine creation.\n* `Delete` - The virtual machine will be deleted from the specified hypervisor. User can either set this action or can do a DELETE operation on the VirtualMachine managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVirtualMachine.ActionEnum Action {
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
        
        public List<InfraMetaData> AffinitySelectors {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<InfraMetaData> AntiAffinitySelectors {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Cloud init configuration data for virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationCloudInitConfig CloudInitConfig {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a virtualizationBaseCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationBaseClusterRelationship Cluster {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Cluster where virtual machine is deployed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ClusterEsxi {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of vCPUs allocated to virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 40)]
        public long Cpu {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<VirtualizationVirtualMachineDisk> Disk {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Normally any virtual machine that is still powered on cannot be deleted. The expected sequence from a user is to first power off the virtual machine and then invoke the delete operation. However, in special circumstances, the owner of the virtual machine may know very well that the virtual machine is no longer needed and just wants to dispose it off. In such situations a delete operation of a virtual machine object is accepted only when this forceDelete attribute is set to true. Under normal circumstances (forceDelete is false), delete operation first confirms that the virtual machine is powered off and then proceeds to delete the virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool ForceDelete {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Guest operating system running on virtual machine.\n* `linux` - A Linux operating system.\n* `windows` - A Windows operating system."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVirtualMachine.GuestOsEnum GuestOs {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a virtualizationBaseHost resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationBaseHostRelationship Host {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Host where virtual machine is deployed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string HostEsxi {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<VirtualizationNetworkInterface> Interfaces {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<InfraMetaData> Labels {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Virtual machine memory in mebi bytes (one mebibyte, 1MiB, is 1048576 bytes, and 1KiB is 1024 bytes). Input must be a whole number and scientific notation is not acceptable. For example, enter 1730 and not 1.73e03."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 4.17792e+06)]
        public long Memory {
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
        /// <para type="description">"Virtual machine name that is unique. Hypervisors enforce platform specific limits and character sets. The name length limit, both min and max, vary among hypervisors. Therefore, the basic limits are set here and proper enforcement is done elsewhere."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Expected power state of virtual machine (PowerOn, PowerOff, Restart).\n* `PowerOff` - The virtual machine will be powered off if it is already not in powered off state. If it is already powered off, no side-effects are expected.\n* `PowerOn` - The virtual machine will be powered on if it is already not in powered on state. If it is already powered on, no side-effects are expected.\n* `Suspend` - The virtual machine will be put into  a suspended state.\n* `ShutDownGuestOS` - The guest operating system is shut down gracefully.\n* `RestartGuestOS` - It can either act as a reset switch and abruptly reset the guest operating system, or it can send a restart signal to the guest operating system so that it shuts down gracefully and restarts.\n* `Reset` - Resets the virtual machine abruptly, with no consideration for work in progress.\n* `Restart` - The virtual machine will be restarted only if it is in powered on state. If it is powered off, it will not be started up.\n* `Unknown` - Power state of the entity is unknown."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVirtualMachine.PowerStateEnum PowerState {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Identifies the provision type to create a new virtual machine.\n* `OVA` - Deploy virtual machine using OVA/F file.\n* `Template` - Provision virtual machine using a template file.\n* `Discovered` - A virtual machine was 'discovered' and not created from Intersight. No provisioning information is available."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVirtualMachine.ProvisionTypeEnum ProvisionType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceRegistrationRelationship RegisteredDevice {
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
        /// <para type="description">"Virtual machine configuration to provision."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationBaseVmConfiguration VmConfig {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove VirtualizationVirtualMachine.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightVirtualizationVirtualMachine")]
    public class RemoveIntersightVirtualizationVirtualMachine:RemoveCmdletBase
	{
		public RemoveIntersightVirtualizationVirtualMachine()
		{
			ApiInstance = new VirtualizationApi(Config);
            MethodName = "DeleteVirtualizationVirtualMachine";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set VirtualizationVmwareVirtualMachine.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightVirtualizationVmwareVirtualMachine")]
    public class SetIntersightVirtualizationVmwareVirtualMachine:SetCmdletBase
	{
		public SetIntersightVirtualizationVmwareVirtualMachine()
		{
			ApiInstance = new VirtualizationApi(Config);
            ModelObject = new VirtualizationVmwareVirtualMachine();
            MethodName = "UpdateVirtualizationVmwareVirtualMachine";
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
        /// <para type="description">"List of annotations provided to this VM by user. Can be long."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Annotation {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Time when this VM booted up."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public DateTime BootTime {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Provisioned CPU and memory information for this virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public InfraHardwareInfo Capacity {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The configuration name for this VM. This maybe the same as the guest hostname."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ConfigName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Shows if virtual machine is connected to vCenter. Values are Connected, Disconnected, Orphaned, Inaccessible, and Invalid."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ConnectionState {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates if the capability to add CPUs to a running VM is enabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool CpuHotAddEnabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Shows the relative importance of a VM and its CPU limits."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareVmCpuShareInfo CpuShares {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Details of CPUs/sockets of this VM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareVmCpuSocketInfo CpuSocketInfo {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> CustomAttributes {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates how the VM will be powered off (soft, hard etc.)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DefaultPowerOffType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Shows if DHCP is used for IP/DNS on this VM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool DhcpEnabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Information about the virtual machine's disk commits, sharing and limits."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareVmDiskCommitInfo DiskCommitInfo {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> DnsServerList {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> DnsSuffixList {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Additional custom configuration settings applied to this VM. It is a set of name-value pairs stored as json."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object ExtraConfig {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The folder name associated with this VM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Folder {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Guest operating system details running on this machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationGuestInfo GuestInfo {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The state of the guest OS running on this VM. Could be running, not running etc.\n* `Unknown` - Indicates that the guest OS state cannot be determined.\n* `NotRunning` - Indicates that the guest OS is not running.\n* `Resetting` - Indicates that the guest OS is resetting.\n* `Running` - Indicates that the guest OS is running normally.\n* `ShuttingDown` - Indicates that the guest OS is shutting down.\n* `Standby` - Indicates that the guest OS is in standby mode."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareVirtualMachine.GuestStateEnum GuestState {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of hypervisor where the virtual machine is hosted for example ESXi.\n* `ESXi` - The hypervisor running on the HyperFlex cluster is a Vmware ESXi hypervisor of any version.\n* `HyperFlexAp` - The hypervisor running on the HyperFlex cluster is Cisco HyperFlex Application Platform.\n* `Hyper-V` - The hypervisor running on the HyperFlex cluster is Microsoft Hyper-V.\n* `Unknown` - The hypervisor running on the HyperFlex cluster is not known."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareVirtualMachine.HypervisorTypeEnum HypervisorType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The internally generated identity of this VM. This entity is not manipulated by users. It aids in uniquely identifying the virtual machine object. For VMware, this is MOR (managed object reference)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Identity {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"UUID assigned by vCenter to every VM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$")]
        public string InstanceUuid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Inventory path to the VM. Example - /DC/vm/folder/VMName."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string InventoryPath {
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
        /// <para type="description">"If true, indicates that the entity refers to a template of a virtual machine and not a real virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool IsTemplate {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> MacAddress {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Similar to CPU Shares but applicable to memory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareVmMemoryShareInfo MemShares {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The capacity and usage information for memory on this virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationMemoryCapacity MemoryCapacity {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Adding memory to a running VM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool MemoryHotAddEnabled {
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
        /// <para type="description">"User-provided name to identify the virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates how many networks are used by this VM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NetworkCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a virtualizationVmwareFolder resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareFolderRelationship ParentFolder {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> PortGroups {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Power state of the virtual machine.\n* `Unknown` - The entity's power state is unknown.\n* `PoweringOn` - The entity is powering on.\n* `PoweredOn` - The entity is powered on.\n* `PoweringOff` - The entity is powering off.\n* `PoweredOff` - The entity is powered down.\n* `StandBy` - The entity is in standby mode.\n* `Paused` - The entity is in pause state.\n* `Rebooting` - The entity reboot is in progress.\n* `` - The entity's power state is not available."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareVirtualMachine.PowerStateEnum PowerState {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The capacity and usage information for CPU power on this virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationComputeCapacity ProcessorCapacity {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Shows if this is a protected VM. VMs can be in protection groups."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool ProtectedVm {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Cloud platform, where the virtual machine is launched.\n* `Unknown` - Cloud provider is not known.\n* `VMwarevSphere` - Cloud provider named VMware vSphere.\n* `AmazonWebServices` - Cloud provider named Amazon Web Services.\n* `MicrosoftAzure` - Cloud provider named Microsoft Azure.\n* `GoogleCloudPlatform` - Cloud provider named Google Cloud Platform."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareVirtualMachine.ProviderEnum Provider {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceRegistrationRelationship RegisteredDevice {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Applies only when remoteDisplayvnc is enabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareRemoteDisplayInfo RemoteDisplayInfo {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Shows if support for a remote VNC access is enabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool RemoteDisplayVncEnabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the resource pool to which this VM belongs (optional)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ResourcePool {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Who owns the resource pool."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ResourcePoolOwner {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The parent of the current resource pool to which this VM belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ResourcePoolParent {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The current state of the virtual machine. For example, starting, stopped, etc.\n* `None` - A place holder for the default value.\n* `Creating` - Virtual machine creation is in progress.\n* `Pending` - The virtual machine is preparing to enter the started state.\n* `Starting` - The virtual machine is starting.\n* `Started` - The virtual machine is running and ready for use.\n* `Stopping` - The virtual machine is preparing to be stopped.\n* `Stopped` - The virtual machine is shut down and cannot be used. The virtual machine can be started again at any time.\n* `Pausing` - The virtual machine is preparing to be paused.\n* `Paused` - The virtual machine enters into paused state due to low free disk space.\n* `Suspending` - The virtual machine is preparing to be suspended.\n* `Suspended` - Virtual machine is in sleep mode.When a virtual machine is suspended, the current state of theoperating system, and applications is saved, and the virtual machine put into a suspended mode.\n* `Deleting` - The virtual machine is preparing to be terminated.\n* `Terminated` - The virtual machine has been permanently deleted and cannot be started.\n* `Rebooting` - The virtual machine reboot is in progress.\n* `Error` - The deployment of virtual machine is failed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareVirtualMachine.StateEnum State {
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
        /// <para type="description">"Indicates if guest tools are running on this VM. Could be set to guestToolNotRunning or guestToolsRunning."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ToolRunningStatus {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The version of the guest tools, usually not specified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ToolsVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The uuid of this virtual machine. The uuid is internally generated and not user specified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$")]
        public string Uuid {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<long> VirtualDisks {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<long> VirtualNetworkInterfaces {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Time when this virtualmachine is created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public DateTime VmCreationTime {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Shows the number of disks assigned to this VM."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long VmDiskCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The operational state of the VM. Could be Available, Provisioned, Maintenance mode, Deleting, etc."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string VmOverallStatus {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Path to the vmx file of the VM. Example - [datastore3] VCSA-134/VCSA-134.vmx."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string VmPath {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Information about the version of this VM (vmx-09, vmx-11 etc.)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string VmVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"How many vnics are present."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long VmVnicCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Information related to the guest info's VNIC virtual device. It is a comma-separated list."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string VnicDeviceConfigId {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get VirtualizationVmwareFolder.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightVirtualizationVmwareFolder", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightVirtualizationVmwareFolder:GetCmdletBase
	{
		public GetIntersightVirtualizationVmwareFolder()
		{
			ApiInstance = new VirtualizationApi(Config);
            MethodName = "GetVirtualizationVmwareFolderList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set VirtualizationVmwareDatastore.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightVirtualizationVmwareDatastore")]
    public class SetIntersightVirtualizationVmwareDatastore:SetCmdletBase
	{
		public SetIntersightVirtualizationVmwareDatastore()
		{
			ApiInstance = new VirtualizationApi(Config);
            ModelObject = new VirtualizationVmwareDatastore();
            MethodName = "UpdateVirtualizationVmwareDatastore";
		}
        // <summary>
        /// <para type="description">"Shows if this datastore is accessible."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Accessible {
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
        /// <para type="description">"Storage utilization for this datastore."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationStorageCapacity Capacity {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a virtualizationVmwareCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareClusterRelationship Cluster {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of hosts attached to or supported-by this datastore."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long HostCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The internally generated identity of this datastore. This entity is not manipulated by users. It aids in uniquely identifying the datastore object. For VMware, this is a MOR (managed object reference)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Identity {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Inventory path of the Datastore."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string InventoryPath {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates if the datastore is in maintenance mode. Will be set to True, when in maintenance mode."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool MaintenanceMode {
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
        /// <para type="description">"Indicates if this datastore is connected to multiple hosts."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool MultipleHostAccess {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of this datastore supplied by user. It is not the identity of the datastore. The name is subject to user manipulations."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceRegistrationRelationship RegisteredDevice {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Datastore health status, as reported by the hypervisor platform.\n* `Unknown` - Entity status is unknown.\n* `Degraded` - State is degraded, and might impact normal operation of the entity.\n* `Critical` - Entity is in a critical state, impacting operations.\n* `Ok` - Entity status is in a stable state, operating normally."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareDatastore.StatusEnum Status {
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
        /// <para type="description">"Indicates if this datastore supports thin provisioning for files."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool ThinProvisioningSupported {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A string indicating the type of the datastore (VMFS, NFS, etc).\n* `Unknown` - The nature of the file system is unknown.\n* `VMFS` - It is a Virtual Machine Filesystem.\n* `NFS` - It is a Network File System.\n* `vSAN` - It is a virtual Storage Area Network file system.\n* `VirtualVolume` - A Virtual Volume datastore represents a storage container in a hypervisor server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVmwareDatastore.TypeEnum Type {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Space uncommitted in this datastore in bytes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long UnCommitted {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The URL to access this datastore (example - 'ds:///vmfs/volumes/562a4e8a-0eeb5372-dd61-78baf9cb9afa/')."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Url {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of virtual machines relying on (using) this datastore."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long VmCount {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set VirtualizationVirtualDisk.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightVirtualizationVirtualDisk")]
    public class SetIntersightVirtualizationVirtualDisk:SetCmdletBase
	{
		public SetIntersightVirtualizationVirtualDisk()
		{
			ApiInstance = new VirtualizationApi(Config);
            ModelObject = new VirtualizationVirtualDisk();
            MethodName = "UpdateVirtualizationVirtualDisk";
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
        /// <para type="description">"A reference to a virtualizationBaseCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationBaseClusterRelationship Cluster {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"File mode of the disk  example - Filesystem, Block.\n* `Block` - It is a Block virtual disk.\n* `Filesystem` - It is a File system virtual disk.\n* `` - Disk mode is either unknown or not supported."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVirtualDisk.ModeEnum Mode {
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
        /// <para type="description">"Name of the storage disk. Name must be unique within a Datastore."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9-]{3,48}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceRegistrationRelationship RegisteredDevice {
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
        /// <para type="description">"Source disk from which the content is copied."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SourceDiskToClone {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Image path used to import on the created disk."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SourceFilePath {
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
    /// <para type="synopsis">This is the cmdlet to Remove VirtualizationVirtualDisk.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightVirtualizationVirtualDisk")]
    public class RemoveIntersightVirtualizationVirtualDisk:RemoveCmdletBase
	{
		public RemoveIntersightVirtualizationVirtualDisk()
		{
			ApiInstance = new VirtualizationApi(Config);
            MethodName = "DeleteVirtualizationVirtualDisk";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get VirtualizationVmwareDatastore.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightVirtualizationVmwareDatastore", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightVirtualizationVmwareDatastore:GetCmdletBase
	{
		public GetIntersightVirtualizationVmwareDatastore()
		{
			ApiInstance = new VirtualizationApi(Config);
            MethodName = "GetVirtualizationVmwareDatastoreList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get VirtualizationVirtualMachine.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightVirtualizationVirtualMachine", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightVirtualizationVirtualMachine:GetCmdletBase
	{
		public GetIntersightVirtualizationVirtualMachine()
		{
			ApiInstance = new VirtualizationApi(Config);
            MethodName = "GetVirtualizationVirtualMachineList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New VirtualizationVirtualMachine.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightVirtualizationVirtualMachine")]
    public class NewIntersightVirtualizationVirtualMachine:NewCmdletBase
	{
		public NewIntersightVirtualizationVirtualMachine()
		{
			ApiInstance = new VirtualizationApi(Config);
            ModelObject = new VirtualizationVirtualMachine();
            MethodName = "CreateVirtualizationVirtualMachine";
		}
        // <summary>
        /// <para type="description">"Action to be performed on a virtual machine (Create, PowerState, Migrate, Clone etc).\n* `None` - A place holder for the default value.\n* `PowerState` - Power action is performed on the virtual machine.\n* `Migrate` - The virtual machine will be migrated from existing node to a different node in cluster. The behavior depends on the underlying hypervisor.\n* `Create` - The virtual machine will be created on the specified hypervisor. This action is also useful if the virtual machine creation failed during first POST operation on VirtualMachine managed object. User can set this action to retry the virtual machine creation.\n* `Delete` - The virtual machine will be deleted from the specified hypervisor. User can either set this action or can do a DELETE operation on the VirtualMachine managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVirtualMachine.ActionEnum Action {
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
        
        public List<InfraMetaData> AffinitySelectors {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<InfraMetaData> AntiAffinitySelectors {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Cloud init configuration data for virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationCloudInitConfig CloudInitConfig {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a virtualizationBaseCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationBaseClusterRelationship Cluster {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Cluster where virtual machine is deployed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ClusterEsxi {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of vCPUs allocated to virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 40)]
        public long Cpu {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<VirtualizationVirtualMachineDisk> Disk {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Normally any virtual machine that is still powered on cannot be deleted. The expected sequence from a user is to first power off the virtual machine and then invoke the delete operation. However, in special circumstances, the owner of the virtual machine may know very well that the virtual machine is no longer needed and just wants to dispose it off. In such situations a delete operation of a virtual machine object is accepted only when this forceDelete attribute is set to true. Under normal circumstances (forceDelete is false), delete operation first confirms that the virtual machine is powered off and then proceeds to delete the virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool ForceDelete {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Guest operating system running on virtual machine.\n* `linux` - A Linux operating system.\n* `windows` - A Windows operating system."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVirtualMachine.GuestOsEnum GuestOs {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a virtualizationBaseHost resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationBaseHostRelationship Host {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Host where virtual machine is deployed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string HostEsxi {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<VirtualizationNetworkInterface> Interfaces {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<InfraMetaData> Labels {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Virtual machine memory in mebi bytes (one mebibyte, 1MiB, is 1048576 bytes, and 1KiB is 1024 bytes). Input must be a whole number and scientific notation is not acceptable. For example, enter 1730 and not 1.73e03."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 4.17792e+06)]
        public long Memory {
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
        /// <para type="description">"Virtual machine name that is unique. Hypervisors enforce platform specific limits and character sets. The name length limit, both min and max, vary among hypervisors. Therefore, the basic limits are set here and proper enforcement is done elsewhere."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Expected power state of virtual machine (PowerOn, PowerOff, Restart).\n* `PowerOff` - The virtual machine will be powered off if it is already not in powered off state. If it is already powered off, no side-effects are expected.\n* `PowerOn` - The virtual machine will be powered on if it is already not in powered on state. If it is already powered on, no side-effects are expected.\n* `Suspend` - The virtual machine will be put into  a suspended state.\n* `ShutDownGuestOS` - The guest operating system is shut down gracefully.\n* `RestartGuestOS` - It can either act as a reset switch and abruptly reset the guest operating system, or it can send a restart signal to the guest operating system so that it shuts down gracefully and restarts.\n* `Reset` - Resets the virtual machine abruptly, with no consideration for work in progress.\n* `Restart` - The virtual machine will be restarted only if it is in powered on state. If it is powered off, it will not be started up.\n* `Unknown` - Power state of the entity is unknown."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVirtualMachine.PowerStateEnum PowerState {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Identifies the provision type to create a new virtual machine.\n* `OVA` - Deploy virtual machine using OVA/F file.\n* `Template` - Provision virtual machine using a template file.\n* `Discovered` - A virtual machine was 'discovered' and not created from Intersight. No provisioning information is available."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationVirtualMachine.ProvisionTypeEnum ProvisionType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceRegistrationRelationship RegisteredDevice {
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
        /// <para type="description">"Virtual machine configuration to provision."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationBaseVmConfiguration VmConfig {
            get;
            set;
        }
    }
}