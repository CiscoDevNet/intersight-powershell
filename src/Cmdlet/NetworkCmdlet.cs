using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NetworkFcZoneInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNetworkFcZoneInfo", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNetworkFcZoneInfo:GetCmdletBase
	{
		public GetIntersightNetworkFcZoneInfo()
		{
			ApiInstance = new NetworkApi(Config);
            MethodName = "GetNetworkFcZoneInfoList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NetworkVlanPortInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNetworkVlanPortInfo", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNetworkVlanPortInfo:GetCmdletBase
	{
		public GetIntersightNetworkVlanPortInfo()
		{
			ApiInstance = new NetworkApi(Config);
            MethodName = "GetNetworkVlanPortInfoList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set NetworkFcZoneInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightNetworkFcZoneInfo")]
    public class SetIntersightNetworkFcZoneInfo:SetCmdletBase
	{
		public SetIntersightNetworkFcZoneInfo()
		{
			ApiInstance = new NetworkApi(Config);
            ModelObject = new NetworkFcZoneInfo();
            MethodName = "UpdateNetworkFcZoneInfo";
		}
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
    /// <para type="synopsis">This is the cmdlet to Get NetworkElement.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNetworkElement", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNetworkElement:GetCmdletBase
	{
		public GetIntersightNetworkElement()
		{
			ApiInstance = new NetworkApi(Config);
            MethodName = "GetNetworkElementList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set NetworkVlanPortInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightNetworkVlanPortInfo")]
    public class SetIntersightNetworkVlanPortInfo:SetCmdletBase
	{
		public SetIntersightNetworkVlanPortInfo()
		{
			ApiInstance = new NetworkApi(Config);
            ModelObject = new NetworkVlanPortInfo();
            MethodName = "UpdateNetworkVlanPortInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of compressed VLAN Group count on a Fabric Interconnect calculated by VLAN port group library."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long CompressedOptimizationSetsValue {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of compressed VLAN port count on a Fabric Interconnect calculated by VLAN port group library."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long CompressedVlanPortCountValue {
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
        /// <para type="description">"The number of uncompressed VLAN port count on a Fabric Interconnect calculated by VLAN port group library."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long UncompressedVlanPortCountValue {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get NetworkElementSummary.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightNetworkElementSummary", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightNetworkElementSummary:GetCmdletBase
	{
		public GetIntersightNetworkElementSummary()
		{
			ApiInstance = new NetworkApi(Config);
            MethodName = "GetNetworkElementSummaryList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set NetworkElement.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightNetworkElement")]
    public class SetIntersightNetworkElement:SetCmdletBase
	{
		public SetIntersightNetworkElement()
		{
			ApiInstance = new NetworkApi(Config);
            ModelObject = new NetworkElement();
            MethodName = "UpdateNetworkElement";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The summary of alarm counts based on the severity types (Critical or Warning)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputeAlarmSummary AlarmSummary {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fault summary of the network Element out-of-band management interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long FaultSummary {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The management mode of the fabric interconnect.\n* `IntersightStandalone` - Intersight Standalone mode of operation.\n* `UCSM` - Unified Computing System Manager mode of operation.\n* `Intersight` - Intersight managed mode of operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NetworkElement.ManagementModeEnum ManagementMode {
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
        /// <para type="description">"The IPv6 address of the network Element out-of-band management interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string OutOfBandIpv6Address {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The default IPv6 gateway of the network Element out-of-band management interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string OutOfBandIpv6Gateway {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The network mask of the network Element out-of-band management interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string OutOfBandIpv6Prefix {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to portMacBinding resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<PortMacBindingRelationship> PortMacBindings {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a equipmentFru resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public EquipmentFruRelationship PreviousFru {
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
        /// <para type="description">"The Thermal status of the fabric interconnect.\n* `unknown` - The default state of the sensor (in case no data is received).\n* `ok` - State of the sensor indicating the sensor's temperature range is okay.\n* `upper-non-recoverable` - State of the sensor indicating that the temperature is extremely high above normal range.\n* `upper-critical` - State of the sensor indicating that the temperature is above normal range.\n* `upper-non-critical` - State of the sensor indicating that the temperature is a little above the normal range.\n* `lower-non-critical` - State of the sensor indicating that the temperature is a little below the normal range.\n* `lower-critical` - State of the sensor indicating that the temperature is below normal range.\n* `lower-non-recoverable` - State of the sensor indicating that the temperature is extremely below normal range."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NetworkElement.ThermalEnum Thermal {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a topSystem resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public TopSystemRelationship TopSystem {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a firmwareRunningFirmware resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareRunningFirmwareRelationship UcsmRunningFirmware {
            get;
            set;
        }
    }
}