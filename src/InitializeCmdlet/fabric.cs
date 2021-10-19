using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FabricUdldGlobalSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFabricUdldGlobalSettings")]
    public class InitializeIntersightFabricUdldGlobalSettings:PSCmdlet
	{
		public InitializeIntersightFabricUdldGlobalSettings()
		{
            ClassId = FabricUdldGlobalSettings.ClassIdEnum.FabricUdldGlobalSettings;
            ObjectType = FabricUdldGlobalSettings.ObjectTypeEnum.FabricUdldGlobalSettings;
            RecoveryAction = FabricUdldGlobalSettings.RecoveryActionEnum.None;
            
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
        
        public FabricUdldGlobalSettings.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Configures the time between UDLD probe messages on ports that are in advertisement mode and are\ncurrently determined to be bidirectional.\nValid values are from 7 to 90 seconds."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(7, 90)]
        public long MessageInterval {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricUdldGlobalSettings.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"UDLD recovery when enabled, attempts to bring an UDLD error-disabled port out of reset.\n* `none` - The standard 4th generation UCS Fabric Interconnect with 54 ports.\n* `reset` - The expanded 4th generation UCS Fabric Interconnect with 108 ports."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricUdldGlobalSettings.RecoveryActionEnum RecoveryAction {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.FabricUdldGlobalSettings initObject = new Intersight.Model.FabricUdldGlobalSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("MessageInterval"))
            {
                initObject.MessageInterval = this.MessageInterval;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RecoveryAction"))
            {
                initObject.RecoveryAction = this.RecoveryAction;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FabricVlanSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFabricVlanSettings")]
    public class InitializeIntersightFabricVlanSettings:PSCmdlet
	{
		public InitializeIntersightFabricVlanSettings()
		{
            ClassId = FabricVlanSettings.ClassIdEnum.FabricVlanSettings;
            ObjectType = FabricVlanSettings.ObjectTypeEnum.FabricVlanSettings;
            
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
        /// <para type="description">"Allowed VLAN IDs of the virtual interface. A list of comma seperated VLAN ids and/or VLAN id ranges."</para>
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
        
        public FabricVlanSettings.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Native VLAN ID of the virtual interface or the corresponding vethernet on the peer Fabric Interconnect to which the virtual interface is connected. If the native VLAN is not a part of the allowed VLANs, it will automatically be added to the list of allowed VLANs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 4093)]
        public long NativeVlan {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricVlanSettings.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.FabricVlanSettings initObject = new Intersight.Model.FabricVlanSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AllowedVlans"))
            {
                initObject.AllowedVlans = this.AllowedVlans;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("NativeVlan"))
            {
                initObject.NativeVlan = this.NativeVlan;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FabricQosClass.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFabricQosClass")]
    public class InitializeIntersightFabricQosClass:PSCmdlet
	{
		public InitializeIntersightFabricQosClass()
		{
            AdminState = FabricQosClass.AdminStateEnum.Disabled;
            ClassId = FabricQosClass.ClassIdEnum.FabricQosClass;
            Name = FabricQosClass.NameEnum.BestEffort;
            ObjectType = FabricQosClass.ObjectTypeEnum.FabricQosClass;
            
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
        /// <para type="description">"Administrative state for this QoS class.\n* `Disabled` - Admin configured Disabled State.\n* `Enabled` - Admin configured Enabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricQosClass.AdminStateEnum AdminState {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Percentage of bandwidth received by the traffic tagged with this QoS."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long BandwidthPercent {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricQosClass.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Class of service received by the traffic tagged with this QoS."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Cos {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum transmission unit (MTU) is the largest size packet or frame,\nthat can be sent in a packet- or frame-based network such as the Internet.\nUser can select from the following:\n1. Any value between 1500 and 9216\n2. 'Normal' (default) mapping to a value of 1500.\n3. 'FC' mapping to a value of 2240."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1500, 9216)]
        public long Mtu {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If enabled, this QoS class will be optimized to send multiple packets."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool MulticastOptimize {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The 'name' of this QoS Class.\n* `Best Effort` - QoS Priority for Best-effort traffic.\n* `FC` - QoS Priority for FC traffic.\n* `Platinum` - QoS Priority for Platinum traffic.\n* `Gold` - QoS Priority for Gold traffic.\n* `Silver` - QoS Priority for Silver traffic.\n* `Bronze` - QoS Priority for Bronze traffic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricQosClass.NameEnum Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricQosClass.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If enabled, this QoS class will allow packet drops within an acceptable limit."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool PacketDrop {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The weight of the QoS Class controls the distribution of bandwidth between QoS Classes,\nwith the same priority after the Guarantees for the QoS Classes are reached."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Weight {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.FabricQosClass initObject = new Intersight.Model.FabricQosClass();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdminState"))
            {
                initObject.AdminState = this.AdminState;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BandwidthPercent"))
            {
                initObject.BandwidthPercent = this.BandwidthPercent;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Cos"))
            {
                initObject.Cos = this.Cos;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Mtu"))
            {
                initObject.Mtu = this.Mtu;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MulticastOptimize"))
            {
                initObject.MulticastOptimize = this.MulticastOptimize;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PacketDrop"))
            {
                initObject.PacketDrop = this.PacketDrop;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Weight"))
            {
                initObject.Weight = this.Weight;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FabricLldpSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFabricLldpSettings")]
    public class InitializeIntersightFabricLldpSettings:PSCmdlet
	{
		public InitializeIntersightFabricLldpSettings()
		{
            ClassId = FabricLldpSettings.ClassIdEnum.FabricLldpSettings;
            ObjectType = FabricLldpSettings.ObjectTypeEnum.FabricLldpSettings;
            
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
        
        public FabricLldpSettings.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricLldpSettings.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Determines if the LLDP frames can be received by an interface on the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool ReceiveEnabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Determines if the LLDP frames can be transmitted by an interface on the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool TransmitEnabled {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.FabricLldpSettings initObject = new Intersight.Model.FabricLldpSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ReceiveEnabled"))
            {
                initObject.ReceiveEnabled = this.ReceiveEnabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TransmitEnabled"))
            {
                initObject.TransmitEnabled = this.TransmitEnabled;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FabricUdldSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFabricUdldSettings")]
    public class InitializeIntersightFabricUdldSettings:PSCmdlet
	{
		public InitializeIntersightFabricUdldSettings()
		{
            AdminState = FabricUdldSettings.AdminStateEnum.Disabled;
            ClassId = FabricUdldSettings.ClassIdEnum.FabricUdldSettings;
            Mode = FabricUdldSettings.ModeEnum.Normal;
            ObjectType = FabricUdldSettings.ObjectTypeEnum.FabricUdldSettings;
            
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
        /// <para type="description">"Admin configured UDLD State for this port.\n* `Disabled` - Admin configured Disabled State.\n* `Enabled` - Admin configured Enabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricUdldSettings.AdminStateEnum AdminState {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricUdldSettings.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Admin configured UDLD Mode for this port.\n* `normal` - Admin configured 'normal' UDLD mode.\n* `aggressive` - Admin configured 'aggressive' UDLD mode."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricUdldSettings.ModeEnum Mode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricUdldSettings.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.FabricUdldSettings initObject = new Intersight.Model.FabricUdldSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdminState"))
            {
                initObject.AdminState = this.AdminState;
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
    /// <para type="synopsis">This is the cmdlet to Initialize FabricPortIdentifier.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFabricPortIdentifier")]
    public class InitializeIntersightFabricPortIdentifier:PSCmdlet
	{
		public InitializeIntersightFabricPortIdentifier()
		{
            ClassId = FabricPortIdentifier.ClassIdEnum.FabricPortIdentifier;
            ObjectType = FabricPortIdentifier.ObjectTypeEnum.FabricPortIdentifier;
            
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
        /// <para type="description">"Breakout port Identifier of the Switch Interface.\nWhen a port is not configured as a breakout port, the aggregatePortId is set to 0, and unused.\nWhen a port is configured as a breakout port, the 'aggregatePortId' port number as labeled on the equipment,\ne.g. the id of the port on the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long AggregatePortId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricPortIdentifier.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricPortIdentifier.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Port Identifier of the Switch/FEX/Chassis Interface.\nWhen a port is not configured as a breakout port, the portId is the port number as labeled on the equipment,\ne.g. the id of the port on the switch, FEX or chassis.\nWhen a port is configured as a breakout port, the 'portId' represents the port id on the fanout side of the breakout cable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 108)]
        public long PortId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Slot Identifier of the Switch/FEX/Chassis Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 5)]
        public long SlotId {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.FabricPortIdentifier initObject = new Intersight.Model.FabricPortIdentifier();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AggregatePortId"))
            {
                initObject.AggregatePortId = this.AggregatePortId;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PortId"))
            {
                initObject.PortId = this.PortId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotId"))
            {
                initObject.SlotId = this.SlotId;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize FabricMacAgingSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightFabricMacAgingSettings")]
    public class InitializeIntersightFabricMacAgingSettings:PSCmdlet
	{
		public InitializeIntersightFabricMacAgingSettings()
		{
            ClassId = FabricMacAgingSettings.ClassIdEnum.FabricMacAgingSettings;
            MacAgingOption = FabricMacAgingSettings.MacAgingOptionEnum.Default;
            ObjectType = FabricMacAgingSettings.ObjectTypeEnum.FabricMacAgingSettings;
            
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
        
        public FabricMacAgingSettings.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This specifies one of the option to configure the MAC address aging time.\n* `Default` - This option sets the default MAC address aging time to 14500 seconds for End Host mode.\n* `Custom` - This option allows the the user to configure the MAC address aging time on the switch. For Switch Model UCS-FI-6454 or higher, the valid range is 120 to 918000 seconds and the switch will set the lower multiple of 5 of the given time.\n* `Never` - This option disables the MAC address aging process and never allows the MAC address entries to get removed from the table."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricMacAgingSettings.MacAgingOptionEnum MacAgingOption {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Define the MAC address aging time in seconds. This field is valid when the \"Custom\" MAC address aging option is selected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 1e+06)]
        public int MacAgingTime {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricMacAgingSettings.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.FabricMacAgingSettings initObject = new Intersight.Model.FabricMacAgingSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("MacAgingOption"))
            {
                initObject.MacAgingOption = this.MacAgingOption;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MacAgingTime"))
            {
                initObject.MacAgingTime = this.MacAgingTime;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
}