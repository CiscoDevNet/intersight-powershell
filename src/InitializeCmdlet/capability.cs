using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CapabilitySwitchStorageLimits.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCapabilitySwitchStorageLimits")]
    public class InitializeIntersightCapabilitySwitchStorageLimits:PSCmdlet
	{
		public InitializeIntersightCapabilitySwitchStorageLimits()
		{
            ClassId = CapabilitySwitchStorageLimits.ClassIdEnum.CapabilitySwitchStorageLimits;
            ObjectType = CapabilitySwitchStorageLimits.ObjectTypeEnum.CapabilitySwitchStorageLimits;
            
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
        
        public CapabilitySwitchStorageLimits.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum user zones per Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MaximumUserZoneCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum configurable Virtual Fibre Channel interfaces on Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MaximumVirtualFcInterfaces {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum configurable Virtual Fibre Channel interfaces per blade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MaximumVirtualFcInterfacesPerBladeServer {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum configurable VSANs on Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MaximumVsans {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Zone limit per Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MaximumZoneCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public CapabilitySwitchStorageLimits.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.CapabilitySwitchStorageLimits initObject = new Intersight.Model.CapabilitySwitchStorageLimits();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("MaximumUserZoneCount"))
            {
                initObject.MaximumUserZoneCount = this.MaximumUserZoneCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaximumVirtualFcInterfaces"))
            {
                initObject.MaximumVirtualFcInterfaces = this.MaximumVirtualFcInterfaces;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaximumVirtualFcInterfacesPerBladeServer"))
            {
                initObject.MaximumVirtualFcInterfacesPerBladeServer = this.MaximumVirtualFcInterfacesPerBladeServer;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaximumVsans"))
            {
                initObject.MaximumVsans = this.MaximumVsans;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaximumZoneCount"))
            {
                initObject.MaximumZoneCount = this.MaximumZoneCount;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CapabilityPortRange.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCapabilityPortRange")]
    public class InitializeIntersightCapabilityPortRange:PSCmdlet
	{
		public InitializeIntersightCapabilityPortRange()
		{
            ClassId = CapabilityPortRange.ClassIdEnum.CapabilityPortRange;
            ObjectType = CapabilityPortRange.ObjectTypeEnum.CapabilityPortRange;
            
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
        
        public CapabilityPortRange.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Ending Port ID in this range of ports."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long EndPortId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Ending Slot ID in this range of ports."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long EndSlotId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public CapabilityPortRange.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Starting Port ID in this range of ports."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long StartPortId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Starting Slot ID in this range of ports."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long StartSlotId {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.CapabilityPortRange initObject = new Intersight.Model.CapabilityPortRange();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("EndPortId"))
            {
                initObject.EndPortId = this.EndPortId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndSlotId"))
            {
                initObject.EndSlotId = this.EndSlotId;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("StartPortId"))
            {
                initObject.StartPortId = this.StartPortId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StartSlotId"))
            {
                initObject.StartSlotId = this.StartSlotId;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CapabilitySwitchSystemLimits.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCapabilitySwitchSystemLimits")]
    public class InitializeIntersightCapabilitySwitchSystemLimits:PSCmdlet
	{
		public InitializeIntersightCapabilitySwitchSystemLimits()
		{
            ClassId = CapabilitySwitchSystemLimits.ClassIdEnum.CapabilitySwitchSystemLimits;
            ObjectType = CapabilitySwitchSystemLimits.ObjectTypeEnum.CapabilitySwitchSystemLimits;
            
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
        
        public CapabilitySwitchSystemLimits.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum UCS chassis that can be connected to this Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MaximumChassisCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum UCS Fabric-extenders (FEX) per Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MaximumFexPerDomain {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum UCS servers per Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MaximumServersPerDomain {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public CapabilitySwitchSystemLimits.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.CapabilitySwitchSystemLimits initObject = new Intersight.Model.CapabilitySwitchSystemLimits();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("MaximumChassisCount"))
            {
                initObject.MaximumChassisCount = this.MaximumChassisCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaximumFexPerDomain"))
            {
                initObject.MaximumFexPerDomain = this.MaximumFexPerDomain;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaximumServersPerDomain"))
            {
                initObject.MaximumServersPerDomain = this.MaximumServersPerDomain;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CapabilitySwitchNetworkLimits.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCapabilitySwitchNetworkLimits")]
    public class InitializeIntersightCapabilitySwitchNetworkLimits:PSCmdlet
	{
		public InitializeIntersightCapabilitySwitchNetworkLimits()
		{
            ClassId = CapabilitySwitchNetworkLimits.ClassIdEnum.CapabilitySwitchNetworkLimits;
            ObjectType = CapabilitySwitchNetworkLimits.ObjectTypeEnum.CapabilitySwitchNetworkLimits;
            
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
        
        public CapabilitySwitchNetworkLimits.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum Compressed configurable VLANs on Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MaxCompressedPortVlanCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum configurable VLANs on Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MaxUncompressedPortVlanCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum configured and enabled Traffic Monitoring sessions on this Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MaximumActiveTrafficMonitoringSessions {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum configurable Ethernet port-channels on Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MaximumEthernetPortChannels {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum configurable Ethernet Uplink ports on Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MaximumEthernetUplinkPorts {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum configurable Fibre Channel port-channel member ports on Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MaximumFcPortChannelMembers {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum configurable Fibre Channel port-channels on Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MaximumFcPortChannels {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum configurable IGMP Groups on Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MaximumIgmpGroups {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum configurable ports per each port-channel on Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MaximumPortChannelMembers {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum configurable Primary Private VLANs on Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MaximumPrimaryVlan {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum configurable Secondary Private VLANs on Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MaximumSecondaryVlan {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum configurable Secondary VLANs per each Primary VLAN on Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MaximumSecondaryVlanPerPrimary {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum allowes VIFs on Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MaximumVifs {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum configurable VLANs on Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MaximumVlans {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Minimum required fans in 'active' state for this Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MinimumActiveFans {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public CapabilitySwitchNetworkLimits.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.CapabilitySwitchNetworkLimits initObject = new Intersight.Model.CapabilitySwitchNetworkLimits();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("MaxCompressedPortVlanCount"))
            {
                initObject.MaxCompressedPortVlanCount = this.MaxCompressedPortVlanCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaxUncompressedPortVlanCount"))
            {
                initObject.MaxUncompressedPortVlanCount = this.MaxUncompressedPortVlanCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaximumActiveTrafficMonitoringSessions"))
            {
                initObject.MaximumActiveTrafficMonitoringSessions = this.MaximumActiveTrafficMonitoringSessions;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaximumEthernetPortChannels"))
            {
                initObject.MaximumEthernetPortChannels = this.MaximumEthernetPortChannels;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaximumEthernetUplinkPorts"))
            {
                initObject.MaximumEthernetUplinkPorts = this.MaximumEthernetUplinkPorts;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaximumFcPortChannelMembers"))
            {
                initObject.MaximumFcPortChannelMembers = this.MaximumFcPortChannelMembers;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaximumFcPortChannels"))
            {
                initObject.MaximumFcPortChannels = this.MaximumFcPortChannels;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaximumIgmpGroups"))
            {
                initObject.MaximumIgmpGroups = this.MaximumIgmpGroups;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaximumPortChannelMembers"))
            {
                initObject.MaximumPortChannelMembers = this.MaximumPortChannelMembers;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaximumPrimaryVlan"))
            {
                initObject.MaximumPrimaryVlan = this.MaximumPrimaryVlan;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaximumSecondaryVlan"))
            {
                initObject.MaximumSecondaryVlan = this.MaximumSecondaryVlan;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaximumSecondaryVlanPerPrimary"))
            {
                initObject.MaximumSecondaryVlanPerPrimary = this.MaximumSecondaryVlanPerPrimary;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaximumVifs"))
            {
                initObject.MaximumVifs = this.MaximumVifs;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaximumVlans"))
            {
                initObject.MaximumVlans = this.MaximumVlans;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MinimumActiveFans"))
            {
                initObject.MinimumActiveFans = this.MinimumActiveFans;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CapabilitySwitchingModeCapability.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCapabilitySwitchingModeCapability")]
    public class InitializeIntersightCapabilitySwitchingModeCapability:PSCmdlet
	{
		public InitializeIntersightCapabilitySwitchingModeCapability()
		{
            ClassId = CapabilitySwitchingModeCapability.ClassIdEnum.CapabilitySwitchingModeCapability;
            ObjectType = CapabilitySwitchingModeCapability.ObjectTypeEnum.CapabilitySwitchingModeCapability;
            SwitchingMode = CapabilitySwitchingModeCapability.SwitchingModeEnum.EndHost;
            
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
        
        public CapabilitySwitchingModeCapability.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public CapabilitySwitchingModeCapability.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Switching mode type (endhost, switch) of the switch.\n* `end-host` - In end-host mode, the fabric interconnects appear to the upstream devices as end hosts with multiple links.In this mode, the switch does not run Spanning Tree Protocol and avoids loops by following a set of rules for traffic forwarding.In case of ethernet switching mode - Ethernet end-host mode is also known as Ethernet host virtualizer.\n* `switch` - In switch mode, the switch runs Spanning Tree Protocol to avoid loops, and broadcast and multicast packets are handled in the traditional way.This is the traditional switch mode."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public CapabilitySwitchingModeCapability.SwitchingModeEnum SwitchingMode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VP Compression support on this switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool VpCompressionSupported {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.CapabilitySwitchingModeCapability initObject = new Intersight.Model.CapabilitySwitchingModeCapability();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SwitchingMode"))
            {
                initObject.SwitchingMode = this.SwitchingMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VpCompressionSupported"))
            {
                initObject.VpCompressionSupported = this.VpCompressionSupported;
            }
            WriteObject(initObject);
        }

    }
}