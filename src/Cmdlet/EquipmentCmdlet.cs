using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set EquipmentTpm.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightEquipmentTpm")]
    public class SetIntersightEquipmentTpm:SetCmdletBase
	{
		public SetIntersightEquipmentTpm()
		{
			ApiInstance = new EquipmentApi(Config);
            ModelObject = new EquipmentTpm();
            MethodName = "UpdateEquipmentTpmWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Firmware Version of the Trusted Platform Module."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FirmwareVersion {
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
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get EquipmentChassisIdentity.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightEquipmentChassisIdentity", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightEquipmentChassisIdentity:GetCmdletBase
	{
		public GetIntersightEquipmentChassisIdentity()
		{
			ApiInstance = new EquipmentApi(Config);
            MethodName = "GetEquipmentChassisIdentityListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set EquipmentSystemIoController.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightEquipmentSystemIoController")]
    public class SetIntersightEquipmentSystemIoController:SetCmdletBase
	{
		public SetIntersightEquipmentSystemIoController()
		{
			ApiInstance = new EquipmentApi(Config);
            ModelObject = new EquipmentSystemIoController();
            MethodName = "UpdateEquipmentSystemIoControllerWithHttpInfo";
		}
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
        /// <para type="description">"A reference to a equipmentFru resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public EquipmentFruRelationship PreviousFru {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a equipmentSharedIoModule resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public EquipmentSharedIoModuleRelationship SharedIoModule {
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
    /// <para type="synopsis">This is the cmdlet to Set EquipmentChassisOperation.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightEquipmentChassisOperation")]
    public class SetIntersightEquipmentChassisOperation:SetCmdletBase
	{
		public SetIntersightEquipmentChassisOperation()
		{
			ApiInstance = new EquipmentApi(Config);
            ModelObject = new EquipmentChassisOperation();
            MethodName = "UpdateEquipmentChassisOperationWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User configured state of the locator LED for the Chassis.\n* `None` - No operation action for the Locator Led of an equipment.\n* `TurnOn` - Turn on the Locator Led of an equipment.\n* `TurnOff` - Turn off the Locator Led of an equipment."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public EquipmentChassisOperation.AdminLocatorLedActionEnum AdminLocatorLedAction {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceRegistrationRelationship DeviceRegistration {
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
    /// <para type="synopsis">This is the cmdlet to Get EquipmentSystemIoController.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightEquipmentSystemIoController", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightEquipmentSystemIoController:GetCmdletBase
	{
		public GetIntersightEquipmentSystemIoController()
		{
			ApiInstance = new EquipmentApi(Config);
            MethodName = "GetEquipmentSystemIoControllerListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get EquipmentDeviceSummary.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightEquipmentDeviceSummary", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightEquipmentDeviceSummary:GetCmdletBase
	{
		public GetIntersightEquipmentDeviceSummary()
		{
			ApiInstance = new EquipmentApi(Config);
            MethodName = "GetEquipmentDeviceSummaryListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set EquipmentIoCard.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightEquipmentIoCard")]
    public class SetIntersightEquipmentIoCard:SetCmdletBase
	{
		public SetIntersightEquipmentIoCard()
		{
			ApiInstance = new EquipmentApi(Config);
            ModelObject = new EquipmentIoCard();
            MethodName = "UpdateEquipmentIoCardWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Connectivity Status of FEX/IOM to Switch - A or B or AB."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ConnectionStatus {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to etherHostPort resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<EtherHostPortRelationship> HostPorts {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<ComputeIpAddress> InbandIpAddresses {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a managementController resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ManagementControllerRelationship MgmtController {
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
        /// <para type="description">"An array of relationships to etherNetworkPort resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<EtherNetworkPortRelationship> NetworkPorts {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> OperReason {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceRegistrationRelationship PhysicalDeviceRegistration {
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
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get EquipmentIdentitySummary.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightEquipmentIdentitySummary", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightEquipmentIdentitySummary:GetCmdletBase
	{
		public GetIntersightEquipmentIdentitySummary()
		{
			ApiInstance = new EquipmentApi(Config);
            MethodName = "GetEquipmentIdentitySummaryListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get EquipmentPsuControl.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightEquipmentPsuControl", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightEquipmentPsuControl:GetCmdletBase
	{
		public GetIntersightEquipmentPsuControl()
		{
			ApiInstance = new EquipmentApi(Config);
            MethodName = "GetEquipmentPsuControlListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get EquipmentRackEnclosureSlot.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightEquipmentRackEnclosureSlot", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightEquipmentRackEnclosureSlot:GetCmdletBase
	{
		public GetIntersightEquipmentRackEnclosureSlot()
		{
			ApiInstance = new EquipmentApi(Config);
            MethodName = "GetEquipmentRackEnclosureSlotListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set EquipmentFan.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightEquipmentFan")]
    public class SetIntersightEquipmentFan:SetCmdletBase
	{
		public SetIntersightEquipmentFan()
		{
			ApiInstance = new EquipmentApi(Config);
            ModelObject = new EquipmentFan();
            MethodName = "UpdateEquipmentFanWithHttpInfo";
		}
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
        
        public List<string> OperReason {
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
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set EquipmentSwitchCard.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightEquipmentSwitchCard")]
    public class SetIntersightEquipmentSwitchCard:SetCmdletBase
	{
		public SetIntersightEquipmentSwitchCard()
		{
			ApiInstance = new EquipmentApi(Config);
            ModelObject = new EquipmentSwitchCard();
            MethodName = "UpdateEquipmentSwitchCardWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to fcPortChannel resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<FcPortChannelRelationship> FcPortChannels {
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
        /// <para type="description">"Field specifies the Netmask for this Switch's Out-of-band IP address."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string OutOfBandIpMask {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to etherPortChannel resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<EtherPortChannelRelationship> PortChannels {
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
        
        public EquipmentSwitchCard.ThermalEnum Thermal {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set EquipmentPsuControl.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightEquipmentPsuControl")]
    public class SetIntersightEquipmentPsuControl:SetCmdletBase
	{
		public SetIntersightEquipmentPsuControl()
		{
			ApiInstance = new EquipmentApi(Config);
            ModelObject = new EquipmentPsuControl();
            MethodName = "UpdateEquipmentPsuControlWithHttpInfo";
		}
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
        
        public List<string> OperReason {
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
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set EquipmentPsu.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightEquipmentPsu")]
    public class SetIntersightEquipmentPsu:SetCmdletBase
	{
		public SetIntersightEquipmentPsu()
		{
			ApiInstance = new EquipmentApi(Config);
            ModelObject = new EquipmentPsu();
            MethodName = "UpdateEquipmentPsuWithHttpInfo";
		}
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
        
        public List<string> OperReason {
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
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get EquipmentFru.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightEquipmentFru", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightEquipmentFru:GetCmdletBase
	{
		public GetIntersightEquipmentFru()
		{
			ApiInstance = new EquipmentApi(Config);
            MethodName = "GetEquipmentFruListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get EquipmentFan.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightEquipmentFan", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightEquipmentFan:GetCmdletBase
	{
		public GetIntersightEquipmentFan()
		{
			ApiInstance = new EquipmentApi(Config);
            MethodName = "GetEquipmentFanListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set EquipmentLocatorLed.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightEquipmentLocatorLed")]
    public class SetIntersightEquipmentLocatorLed:SetCmdletBase
	{
		public SetIntersightEquipmentLocatorLed()
		{
			ApiInstance = new EquipmentApi(Config);
            ModelObject = new EquipmentLocatorLed();
            MethodName = "UpdateEquipmentLocatorLedWithHttpInfo";
		}
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
    /// <para type="synopsis">This is the cmdlet to Set EquipmentRackEnclosure.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightEquipmentRackEnclosure")]
    public class SetIntersightEquipmentRackEnclosure:SetCmdletBase
	{
		public SetIntersightEquipmentRackEnclosure()
		{
			ApiInstance = new EquipmentApi(Config);
            ModelObject = new EquipmentRackEnclosure();
            MethodName = "UpdateEquipmentRackEnclosureWithHttpInfo";
		}
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
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set EquipmentIoExpander.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightEquipmentIoExpander")]
    public class SetIntersightEquipmentIoExpander:SetCmdletBase
	{
		public SetIntersightEquipmentIoExpander()
		{
			ApiInstance = new EquipmentApi(Config);
            ModelObject = new EquipmentIoExpander();
            MethodName = "UpdateEquipmentIoExpanderWithHttpInfo";
		}
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
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set EquipmentFru.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightEquipmentFru")]
    public class SetIntersightEquipmentFru:SetCmdletBase
	{
		public SetIntersightEquipmentFru()
		{
			ApiInstance = new EquipmentApi(Config);
            ModelObject = new EquipmentFru();
            MethodName = "UpdateEquipmentFruWithHttpInfo";
		}
        // <summary>
        /// <para type="description">"This field identifies the action performed on a component.\n* `None` - No action performed on the FRU.\n* `Inserted` - A new FRU is inserted or added.\n* `Removed` - The previous FRU is removed.\n* `Replaced` - The previous FRU is replaced with a new FRU.\n* `ReplacedWithAlarm` - The previous FRU is replaced with a new FRU and a alarm is raised."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public EquipmentFru.ActionEnum Action {
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
        /// <para type="description">"A reference to a equipmentBase resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public EquipmentBaseRelationship CurrentFru {
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
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get EquipmentIoCardOperation.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightEquipmentIoCardOperation", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightEquipmentIoCardOperation:GetCmdletBase
	{
		public GetIntersightEquipmentIoCardOperation()
		{
			ApiInstance = new EquipmentApi(Config);
            MethodName = "GetEquipmentIoCardOperationListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set EquipmentFexOperation.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightEquipmentFexOperation")]
    public class SetIntersightEquipmentFexOperation:SetCmdletBase
	{
		public SetIntersightEquipmentFexOperation()
		{
			ApiInstance = new EquipmentApi(Config);
            ModelObject = new EquipmentFexOperation();
            MethodName = "UpdateEquipmentFexOperationWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Action performed on the locator LED for a FEX.\n* `None` - No operation action for the Locator Led of an equipment.\n* `TurnOn` - Turn on the Locator Led of an equipment.\n* `TurnOff` - Turn off the Locator Led of an equipment."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public EquipmentFexOperation.AdminLocatorLedActionEnum AdminLocatorLedAction {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Defines status of action performed on AdminLocatorLedState.\n* `None` - Nil value when no action has been triggered by the user.\n* `Applied` - User configured settings are in applied state.\n* `Applying` - User settings are being applied on the target server.\n* `Failed` - User configured settings could not be applied."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public EquipmentFexOperation.AdminLocatorLedActionStateEnum AdminLocatorLedActionState {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceRegistrationRelationship DeviceRegistration {
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
    /// <para type="synopsis">This is the cmdlet to Set EquipmentTransceiver.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightEquipmentTransceiver")]
    public class SetIntersightEquipmentTransceiver:SetCmdletBase
	{
		public SetIntersightEquipmentTransceiver()
		{
			ApiInstance = new EquipmentApi(Config);
            ModelObject = new EquipmentTransceiver();
            MethodName = "UpdateEquipmentTransceiverWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a etherPhysicalPort resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public EtherPhysicalPortRelationship EtherPhysicalPort {
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
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get EquipmentSwitchCard.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightEquipmentSwitchCard", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightEquipmentSwitchCard:GetCmdletBase
	{
		public GetIntersightEquipmentSwitchCard()
		{
			ApiInstance = new EquipmentApi(Config);
            MethodName = "GetEquipmentSwitchCardListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set EquipmentChassisIdentity.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightEquipmentChassisIdentity")]
    public class SetIntersightEquipmentChassisIdentity:SetCmdletBase
	{
		public SetIntersightEquipmentChassisIdentity()
		{
			ApiInstance = new EquipmentApi(Config);
            ModelObject = new EquipmentChassisIdentity();
            MethodName = "UpdateEquipmentChassisIdentityWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Updated by UI/API to trigger specific chassis action type.\n* `None` - No operation value for maintenance actions on an equipment.\n* `Decommission` - Decommission the equipment and temporarily remove it from being managed by Intersight.\n* `Recommission` - Recommission the equipment.\n* `Reack` - Reacknowledge the equipment and discover it again.\n* `Remove` - Remove the equipment permanently from Intersight management.\n* `Replace` - Replace the equipment with the other one."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public EquipmentChassisIdentity.AdminActionEnum AdminAction {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<EquipmentIoCardIdentity> IoCardIdentityList {
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
    /// <para type="synopsis">This is the cmdlet to Set EquipmentChassis.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightEquipmentChassis")]
    public class SetIntersightEquipmentChassis:SetCmdletBase
	{
		public SetIntersightEquipmentChassis()
		{
			ApiInstance = new EquipmentApi(Config);
            ModelObject = new EquipmentChassis();
            MethodName = "UpdateEquipmentChassisWithHttpInfo";
		}
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
        /// <para type="description">"A reference to a equipmentFanControl resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public EquipmentFanControlRelationship FanControl {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This field summarizes the faults on the chassis enclosure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long FaultSummary {
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
        
        public List<string> OperReason {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The platform type that the chassis is a part of."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PlatformType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a powerControlState resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PowerControlStateRelationship PowerControlState {
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
        /// <para type="description">"An array of relationships to storageVirtualDriveContainer resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<StorageVirtualDriveContainerRelationship> VirtualDriveContainer {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get EquipmentIoCard.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightEquipmentIoCard", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightEquipmentIoCard:GetCmdletBase
	{
		public GetIntersightEquipmentIoCard()
		{
			ApiInstance = new EquipmentApi(Config);
            MethodName = "GetEquipmentIoCardListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get EquipmentTransceiver.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightEquipmentTransceiver", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightEquipmentTransceiver:GetCmdletBase
	{
		public GetIntersightEquipmentTransceiver()
		{
			ApiInstance = new EquipmentApi(Config);
            MethodName = "GetEquipmentTransceiverListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set EquipmentRackEnclosureSlot.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightEquipmentRackEnclosureSlot")]
    public class SetIntersightEquipmentRackEnclosureSlot:SetCmdletBase
	{
		public SetIntersightEquipmentRackEnclosureSlot()
		{
			ApiInstance = new EquipmentApi(Config);
            ModelObject = new EquipmentRackEnclosureSlot();
            MethodName = "UpdateEquipmentRackEnclosureSlotWithHttpInfo";
		}
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
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get EquipmentSharedIoModule.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightEquipmentSharedIoModule", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightEquipmentSharedIoModule:GetCmdletBase
	{
		public GetIntersightEquipmentSharedIoModule()
		{
			ApiInstance = new EquipmentApi(Config);
            MethodName = "GetEquipmentSharedIoModuleListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get EquipmentFex.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightEquipmentFex", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightEquipmentFex:GetCmdletBase
	{
		public GetIntersightEquipmentFex()
		{
			ApiInstance = new EquipmentApi(Config);
            MethodName = "GetEquipmentFexListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get EquipmentFanModule.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightEquipmentFanModule", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightEquipmentFanModule:GetCmdletBase
	{
		public GetIntersightEquipmentFanModule()
		{
			ApiInstance = new EquipmentApi(Config);
            MethodName = "GetEquipmentFanModuleListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set EquipmentSharedIoModule.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightEquipmentSharedIoModule")]
    public class SetIntersightEquipmentSharedIoModule:SetCmdletBase
	{
		public SetIntersightEquipmentSharedIoModule()
		{
			ApiInstance = new EquipmentApi(Config);
            ModelObject = new EquipmentSharedIoModule();
            MethodName = "PatchEquipmentSharedIoModuleWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a equipmentSystemIoController resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public EquipmentSystemIoControllerRelationship EquipmentSystemIoController {
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
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set EquipmentIoCardOperation.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightEquipmentIoCardOperation")]
    public class SetIntersightEquipmentIoCardOperation:SetCmdletBase
	{
		public SetIntersightEquipmentIoCardOperation()
		{
			ApiInstance = new EquipmentApi(Config);
            ModelObject = new EquipmentIoCardOperation();
            MethodName = "UpdateEquipmentIoCardOperationWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User configured power state of the iomodule.\n* `None` - Placeholder default value for iom power state property.\n* `Reboot` - IO Module reboot state property value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public EquipmentIoCardOperation.AdminPowerStateEnum AdminPowerState {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceRegistrationRelationship DeviceRegistration {
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
    /// <para type="synopsis">This is the cmdlet to Get EquipmentChassisOperation.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightEquipmentChassisOperation", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightEquipmentChassisOperation:GetCmdletBase
	{
		public GetIntersightEquipmentChassisOperation()
		{
			ApiInstance = new EquipmentApi(Config);
            MethodName = "GetEquipmentChassisOperationListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get EquipmentPsu.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightEquipmentPsu", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightEquipmentPsu:GetCmdletBase
	{
		public GetIntersightEquipmentPsu()
		{
			ApiInstance = new EquipmentApi(Config);
            MethodName = "GetEquipmentPsuListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set EquipmentFanModule.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightEquipmentFanModule")]
    public class SetIntersightEquipmentFanModule:SetCmdletBase
	{
		public SetIntersightEquipmentFanModule()
		{
			ApiInstance = new EquipmentApi(Config);
            ModelObject = new EquipmentFanModule();
            MethodName = "PatchEquipmentFanModuleWithHttpInfo";
		}
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
        
        public List<string> OperReason {
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
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get EquipmentFexIdentity.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightEquipmentFexIdentity", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightEquipmentFexIdentity:GetCmdletBase
	{
		public GetIntersightEquipmentFexIdentity()
		{
			ApiInstance = new EquipmentApi(Config);
            MethodName = "GetEquipmentFexIdentityListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get EquipmentChassis.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightEquipmentChassis", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightEquipmentChassis:GetCmdletBase
	{
		public GetIntersightEquipmentChassis()
		{
			ApiInstance = new EquipmentApi(Config);
            MethodName = "GetEquipmentChassisListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get EquipmentLocatorLed.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightEquipmentLocatorLed", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightEquipmentLocatorLed:GetCmdletBase
	{
		public GetIntersightEquipmentLocatorLed()
		{
			ApiInstance = new EquipmentApi(Config);
            MethodName = "GetEquipmentLocatorLedListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set EquipmentFanControl.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightEquipmentFanControl")]
    public class SetIntersightEquipmentFanControl:SetCmdletBase
	{
		public SetIntersightEquipmentFanControl()
		{
			ApiInstance = new EquipmentApi(Config);
            ModelObject = new EquipmentFanControl();
            MethodName = "UpdateEquipmentFanControlWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a equipmentChassis resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public EquipmentChassisRelationship EquipmentChassis {
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
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set EquipmentFexIdentity.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightEquipmentFexIdentity")]
    public class SetIntersightEquipmentFexIdentity:SetCmdletBase
	{
		public SetIntersightEquipmentFexIdentity()
		{
			ApiInstance = new EquipmentApi(Config);
            ModelObject = new EquipmentFexIdentity();
            MethodName = "PatchEquipmentFexIdentityWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Updated by UI/API to trigger specific chassis action type.\n* `None` - No operation value for maintenance actions on an equipment.\n* `Decommission` - Decommission the equipment and temporarily remove it from being managed by Intersight.\n* `Recommission` - Recommission the equipment.\n* `Reack` - Reacknowledge the equipment and discover it again.\n* `Remove` - Remove the equipment permanently from Intersight management.\n* `Replace` - Replace the equipment with the other one."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public EquipmentFexIdentity.AdminActionEnum AdminAction {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a equipmentFex resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public EquipmentFexRelationship Fex {
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
        /// <para type="description">"A reference to a networkElement resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NetworkElementRelationship NetworkElement {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceRegistrationRelationship PhysicalDeviceRegistration {
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
    /// <para type="synopsis">This is the cmdlet to Set EquipmentFex.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightEquipmentFex")]
    public class SetIntersightEquipmentFex:SetCmdletBase
	{
		public SetIntersightEquipmentFex()
		{
			ApiInstance = new EquipmentApi(Config);
            ModelObject = new EquipmentFex();
            MethodName = "UpdateEquipmentFexWithHttpInfo";
		}
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Connectivity Status of FEX/IOM to Switch - A or B or AB."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ConnectionStatus {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Discovery state of IO card or fabric extender."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DiscoveryState {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to etherHostPort resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<EtherHostPortRelationship> HostPorts {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a managementController resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ManagementControllerRelationship MgmtController {
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
        /// <para type="description">"A reference to a networkElement resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NetworkElementRelationship NetworkElement {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to etherNetworkPort resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<EtherNetworkPortRelationship> NetworkPorts {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> OperReason {
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
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get EquipmentFexOperation.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightEquipmentFexOperation", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightEquipmentFexOperation:GetCmdletBase
	{
		public GetIntersightEquipmentFexOperation()
		{
			ApiInstance = new EquipmentApi(Config);
            MethodName = "GetEquipmentFexOperationListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get EquipmentFanControl.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightEquipmentFanControl", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightEquipmentFanControl:GetCmdletBase
	{
		public GetIntersightEquipmentFanControl()
		{
			ApiInstance = new EquipmentApi(Config);
            MethodName = "GetEquipmentFanControlListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get EquipmentTpm.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightEquipmentTpm", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightEquipmentTpm:GetCmdletBase
	{
		public GetIntersightEquipmentTpm()
		{
			ApiInstance = new EquipmentApi(Config);
            MethodName = "GetEquipmentTpmListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get EquipmentRackEnclosure.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightEquipmentRackEnclosure", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightEquipmentRackEnclosure:GetCmdletBase
	{
		public GetIntersightEquipmentRackEnclosure()
		{
			ApiInstance = new EquipmentApi(Config);
            MethodName = "GetEquipmentRackEnclosureListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get EquipmentIoExpander.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightEquipmentIoExpander", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightEquipmentIoExpander:GetCmdletBase
	{
		public GetIntersightEquipmentIoExpander()
		{
			ApiInstance = new EquipmentApi(Config);
            MethodName = "GetEquipmentIoExpanderListWithHttpInfo";
		}
    }
}