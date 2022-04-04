using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NetworkElement.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNetworkElement")]
    public class InitializeIntersightNetworkElement : PSCmdlet
    {
        public InitializeIntersightNetworkElement()
        {
            ClassId = NetworkElement.ClassIdEnum.NetworkElement;
            ManagementMode = NetworkElement.ManagementModeEnum.IntersightStandalone;
            ObjectType = NetworkElement.ObjectTypeEnum.NetworkElement;
            SwitchType = NetworkElement.SwitchTypeEnum.FabricInterconnect;
            Thermal = NetworkElement.ThermalEnum.Unknown;

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
        /// <para type="description">"The summary of alarm counts based on the severity types (Critical or Warning)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.ComputeAlarmSummary AlarmSummary
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Chassis IP of the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Chassis
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NetworkElement.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Configuration modified timestamp of the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ConfModTs
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Configuration modified backup timestamp of the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ConfModTsBackup
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to consoleConsoleConfig resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.ConsoleConsoleConfigRelationship> Console
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fault summary of the network Element out-of-band management interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long FaultSummary
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to networkFeatureControl resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.NetworkFeatureControlRelationship> FeatureControl
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to networkInterfaceList resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.NetworkInterfaceListRelationship> InterfaceList
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to networkLicenseFile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.NetworkLicenseFileRelationship> LicenseFile
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The management mode of the fabric interconnect.\n* `IntersightStandalone` - Intersight Standalone mode of operation.\n* `UCSM` - Unified Computing System Manager mode of operation.\n* `Intersight` - Intersight managed mode of operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NetworkElement.ManagementModeEnum ManagementMode
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

        public NetworkElement.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The IPv6 address of the network Element out-of-band management interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string OutOfBandIpv6Address
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The default IPv6 gateway of the network Element out-of-band management interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string OutOfBandIpv6Gateway
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The network mask of the network Element out-of-band management interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string OutOfBandIpv6Prefix
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Part number of the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PartNumber
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to portMacBinding resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.PortMacBindingRelationship> PortMacBindings
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a equipmentFru resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.EquipmentFruRelationship PreviousFru
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to processorUnit resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.ProcessorUnitRelationship> ProcessorUnit
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The status of the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Status
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to networkSupervisorCard resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.NetworkSupervisorCardRelationship> SupervisorCard
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Switch type that the network element is a part of.\n* `FabricInterconnect` - The default Switch type of UCSM and IMM mode devices.\n* `NexusDevice` - Switch type of Nexus devices.\n* `MDSDevice` - Switch type of Nexus MDS devices."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NetworkElement.SwitchTypeEnum SwitchType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"System up time of the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SystemUpTime
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
        /// <para type="description">"The Thermal status of the fabric interconnect.\n* `unknown` - The default state of the sensor (in case no data is received).\n* `ok` - State of the sensor indicating the sensor's temperature range is okay.\n* `upper-non-recoverable` - State of the sensor indicating that the temperature is extremely high above normal range.\n* `upper-critical` - State of the sensor indicating that the temperature is above normal range.\n* `upper-non-critical` - State of the sensor indicating that the temperature is a little above the normal range.\n* `lower-non-critical` - State of the sensor indicating that the temperature is a little below the normal range.\n* `lower-critical` - State of the sensor indicating that the temperature is below normal range.\n* `lower-non-recoverable` - State of the sensor indicating that the temperature is extremely below normal range."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NetworkElement.ThermalEnum Thermal
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a topSystem resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.TopSystemRelationship TopSystem
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a firmwareRunningFirmware resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.FirmwareRunningFirmwareRelationship UcsmRunningFirmware
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Firmware version of the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to networkVrf resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.NetworkVrfRelationship> Vrf
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.NetworkElement initObject = new Intersight.Model.NetworkElement();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AlarmSummary"))
            {
                initObject.AlarmSummary = this.AlarmSummary;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Chassis"))
            {
                initObject.Chassis = this.Chassis;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ConfModTs"))
            {
                initObject.ConfModTs = this.ConfModTs;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ConfModTsBackup"))
            {
                initObject.ConfModTsBackup = this.ConfModTsBackup;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Console"))
            {
                initObject.Console = this.Console;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FaultSummary"))
            {
                initObject.FaultSummary = this.FaultSummary;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FeatureControl"))
            {
                initObject.FeatureControl = this.FeatureControl;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InterfaceList"))
            {
                initObject.InterfaceList = this.InterfaceList;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LicenseFile"))
            {
                initObject.LicenseFile = this.LicenseFile;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ManagementMode"))
            {
                initObject.ManagementMode = this.ManagementMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OutOfBandIpv6Address"))
            {
                initObject.OutOfBandIpv6Address = this.OutOfBandIpv6Address;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("OutOfBandIpv6Gateway"))
            {
                initObject.OutOfBandIpv6Gateway = this.OutOfBandIpv6Gateway;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("OutOfBandIpv6Prefix"))
            {
                initObject.OutOfBandIpv6Prefix = this.OutOfBandIpv6Prefix;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PartNumber"))
            {
                initObject.PartNumber = this.PartNumber;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PortMacBindings"))
            {
                initObject.PortMacBindings = this.PortMacBindings;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PreviousFru"))
            {
                initObject.PreviousFru = this.PreviousFru;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ProcessorUnit"))
            {
                initObject.ProcessorUnit = this.ProcessorUnit;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Status"))
            {
                initObject.Status = this.Status;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SupervisorCard"))
            {
                initObject.SupervisorCard = this.SupervisorCard;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SwitchType"))
            {
                initObject.SwitchType = this.SwitchType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SystemUpTime"))
            {
                initObject.SystemUpTime = this.SystemUpTime;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Thermal"))
            {
                initObject.Thermal = this.Thermal;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TopSystem"))
            {
                initObject.TopSystem = this.TopSystem;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UcsmRunningFirmware"))
            {
                initObject.UcsmRunningFirmware = this.UcsmRunningFirmware;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vrf"))
            {
                initObject.Vrf = this.Vrf;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NetworkElementSummary.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNetworkElementSummary")]
    public class InitializeIntersightNetworkElementSummary : PSCmdlet
    {
        public InitializeIntersightNetworkElementSummary()
        {
            ClassId = NetworkElementSummary.ClassIdEnum.NetworkElementSummary;
            ObjectType = NetworkElementSummary.ObjectTypeEnum.NetworkElementSummary;

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

        public NetworkElementSummary.ClassIdEnum ClassId
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

        public NetworkElementSummary.ObjectTypeEnum ObjectType
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
            Intersight.Model.NetworkElementSummary initObject = new Intersight.Model.NetworkElementSummary();
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
    /// <para type="synopsis">This is the cmdlet to Initialize NetworkFcZoneInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNetworkFcZoneInfo")]
    public class InitializeIntersightNetworkFcZoneInfo : PSCmdlet
    {
        public InitializeIntersightNetworkFcZoneInfo()
        {
            ClassId = NetworkFcZoneInfo.ClassIdEnum.NetworkFcZoneInfo;
            ObjectType = NetworkFcZoneInfo.ObjectTypeEnum.NetworkFcZoneInfo;

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

        public NetworkFcZoneInfo.ClassIdEnum ClassId
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

        public NetworkFcZoneInfo.ObjectTypeEnum ObjectType
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
            Intersight.Model.NetworkFcZoneInfo initObject = new Intersight.Model.NetworkFcZoneInfo();
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
    /// <para type="synopsis">This is the cmdlet to Initialize NetworkFeatureControl.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNetworkFeatureControl")]
    public class InitializeIntersightNetworkFeatureControl : PSCmdlet
    {
        public InitializeIntersightNetworkFeatureControl()
        {
            ClassId = NetworkFeatureControl.ClassIdEnum.NetworkFeatureControl;
            ObjectType = NetworkFeatureControl.ObjectTypeEnum.NetworkFeatureControl;

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
        /// <para type="description">"The admin state of the feature."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string AdminState
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NetworkFeatureControl.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of instances of the feature."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Instance
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
        /// <para type="description">"The name to identify the feature."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a networkElement resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.NetworkElementRelationship NetworkElement
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NetworkFeatureControl.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The operational state of the feature."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string OperationalState
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetDeviceRegistrationRelationship RegisteredDevice
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
            Intersight.Model.NetworkFeatureControl initObject = new Intersight.Model.NetworkFeatureControl();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdminState"))
            {
                initObject.AdminState = this.AdminState;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Instance"))
            {
                initObject.Instance = this.Instance;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NetworkElement"))
            {
                initObject.NetworkElement = this.NetworkElement;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OperationalState"))
            {
                initObject.OperationalState = this.OperationalState;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RegisteredDevice"))
            {
                initObject.RegisteredDevice = this.RegisteredDevice;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NetworkHyperFlexNetworkAddress.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNetworkHyperFlexNetworkAddress")]
    public class InitializeIntersightNetworkHyperFlexNetworkAddress : PSCmdlet
    {
        public InitializeIntersightNetworkHyperFlexNetworkAddress()
        {
            ClassId = NetworkHyperFlexNetworkAddress.ClassIdEnum.NetworkHyperFlexNetworkAddress;
            ObjectType = NetworkHyperFlexNetworkAddress.ObjectTypeEnum.NetworkHyperFlexNetworkAddress;

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

        public NetworkHyperFlexNetworkAddress.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NetworkHyperFlexNetworkAddress.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.NetworkHyperFlexNetworkAddress initObject = new Intersight.Model.NetworkHyperFlexNetworkAddress();
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
    /// <para type="synopsis">This is the cmdlet to Initialize NetworkInterfaceList.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNetworkInterfaceList")]
    public class InitializeIntersightNetworkInterfaceList : PSCmdlet
    {
        public InitializeIntersightNetworkInterfaceList()
        {
            ClassId = NetworkInterfaceList.ClassIdEnum.NetworkInterfaceList;
            ObjectType = NetworkInterfaceList.ObjectTypeEnum.NetworkInterfaceList;

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
        /// <para type="description">"Admin state of the interface list."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string AdminState
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NetworkInterfaceList.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IP address of the interface list."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string IpAddress
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"MAC address of the interface list."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Mac
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
        /// <para type="description">"Name of the interface list."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a networkElement resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.NetworkElementRelationship NetworkElement
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NetworkInterfaceList.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Operational state of the interface list."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string OperState
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Port type of interface list."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PortType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetDeviceRegistrationRelationship RegisteredDevice
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Slot id of the interface list."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SlotId
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
        /// <para type="description">"VLAN of the interface list."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vlan
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.NetworkInterfaceList initObject = new Intersight.Model.NetworkInterfaceList();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdminState"))
            {
                initObject.AdminState = this.AdminState;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("IpAddress"))
            {
                initObject.IpAddress = this.IpAddress;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Mac"))
            {
                initObject.Mac = this.Mac;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NetworkElement"))
            {
                initObject.NetworkElement = this.NetworkElement;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OperState"))
            {
                initObject.OperState = this.OperState;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PortType"))
            {
                initObject.PortType = this.PortType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RegisteredDevice"))
            {
                initObject.RegisteredDevice = this.RegisteredDevice;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotId"))
            {
                initObject.SlotId = this.SlotId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vlan"))
            {
                initObject.Vlan = this.Vlan;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NetworkLicenseFile.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNetworkLicenseFile")]
    public class InitializeIntersightNetworkLicenseFile : PSCmdlet
    {
        public InitializeIntersightNetworkLicenseFile()
        {
            ClassId = NetworkLicenseFile.ClassIdEnum.NetworkLicenseFile;
            ObjectType = NetworkLicenseFile.ObjectTypeEnum.NetworkLicenseFile;

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

        public NetworkLicenseFile.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The expiry date of the license feature."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ExpiryDate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the license feature."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string FeatureName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The file Id of the license file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string FileId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The identifier to identify license host Id."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string HostId
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
        /// <para type="description">"A reference to a networkElement resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.NetworkElementRelationship NetworkElement
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NetworkLicenseFile.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetDeviceRegistrationRelationship RegisteredDevice
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
        /// <para type="description">"The vendor of the license."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vendor
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.NetworkLicenseFile initObject = new Intersight.Model.NetworkLicenseFile();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ExpiryDate"))
            {
                initObject.ExpiryDate = this.ExpiryDate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FeatureName"))
            {
                initObject.FeatureName = this.FeatureName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FileId"))
            {
                initObject.FileId = this.FileId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HostId"))
            {
                initObject.HostId = this.HostId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NetworkElement"))
            {
                initObject.NetworkElement = this.NetworkElement;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RegisteredDevice"))
            {
                initObject.RegisteredDevice = this.RegisteredDevice;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vendor"))
            {
                initObject.Vendor = this.Vendor;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NetworkSupervisorCard.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNetworkSupervisorCard")]
    public class InitializeIntersightNetworkSupervisorCard : PSCmdlet
    {
        public InitializeIntersightNetworkSupervisorCard()
        {
            ClassId = NetworkSupervisorCard.ClassIdEnum.NetworkSupervisorCard;
            ObjectType = NetworkSupervisorCard.ObjectTypeEnum.NetworkSupervisorCard;

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

        public NetworkSupervisorCard.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The description of the supervisor card."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The hardware version of the supervisor card."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string HardwareVersion
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
        /// <para type="description">"The name of the supervisor card like Supervisor Card-1."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a networkElement resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.NetworkElementRelationship NetworkElement
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of ports on the supervisor card."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long NumberOfPorts
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NetworkSupervisorCard.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The operational status of the supervisor card."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string OperState
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The part number of the supervisor card."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PartNumber
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The power state of the supervisor card."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PowerState
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a equipmentFru resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.EquipmentFruRelationship PreviousFru
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetDeviceRegistrationRelationship RegisteredDevice
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The status of the supervisor card."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Status
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The identifier for the supervisor card."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SupervisorId
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
        /// <para type="description">"The type of the supervisor card."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Type
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.NetworkSupervisorCard initObject = new Intersight.Model.NetworkSupervisorCard();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HardwareVersion"))
            {
                initObject.HardwareVersion = this.HardwareVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NetworkElement"))
            {
                initObject.NetworkElement = this.NetworkElement;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumberOfPorts"))
            {
                initObject.NumberOfPorts = this.NumberOfPorts;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OperState"))
            {
                initObject.OperState = this.OperState;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PartNumber"))
            {
                initObject.PartNumber = this.PartNumber;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PowerState"))
            {
                initObject.PowerState = this.PowerState;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PreviousFru"))
            {
                initObject.PreviousFru = this.PreviousFru;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RegisteredDevice"))
            {
                initObject.RegisteredDevice = this.RegisteredDevice;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Status"))
            {
                initObject.Status = this.Status;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SupervisorId"))
            {
                initObject.SupervisorId = this.SupervisorId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Type"))
            {
                initObject.Type = this.Type;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NetworkVlanPortInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNetworkVlanPortInfo")]
    public class InitializeIntersightNetworkVlanPortInfo : PSCmdlet
    {
        public InitializeIntersightNetworkVlanPortInfo()
        {
            ClassId = NetworkVlanPortInfo.ClassIdEnum.NetworkVlanPortInfo;
            ObjectType = NetworkVlanPortInfo.ObjectTypeEnum.NetworkVlanPortInfo;

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

        public NetworkVlanPortInfo.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of compressed VLAN Group count on a Fabric Interconnect calculated by VLAN port group library."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long CompressedOptimizationSetsValue
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of compressed VLAN port count on a Fabric Interconnect calculated by VLAN port group library."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long CompressedVlanPortCountValue
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

        public NetworkVlanPortInfo.ObjectTypeEnum ObjectType
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
        /// <para type="description">"The number of uncompressed VLAN port count on a Fabric Interconnect calculated by VLAN port group library."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long UncompressedVlanPortCountValue
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.NetworkVlanPortInfo initObject = new Intersight.Model.NetworkVlanPortInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CompressedOptimizationSetsValue"))
            {
                initObject.CompressedOptimizationSetsValue = this.CompressedOptimizationSetsValue;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CompressedVlanPortCountValue"))
            {
                initObject.CompressedVlanPortCountValue = this.CompressedVlanPortCountValue;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("UncompressedVlanPortCountValue"))
            {
                initObject.UncompressedVlanPortCountValue = this.UncompressedVlanPortCountValue;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NetworkVrf.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNetworkVrf")]
    public class InitializeIntersightNetworkVrf : PSCmdlet
    {
        public InitializeIntersightNetworkVrf()
        {
            ClassId = NetworkVrf.ClassIdEnum.NetworkVrf;
            ObjectType = NetworkVrf.ObjectTypeEnum.NetworkVrf;

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
        /// <para type="description">"This field identifies the adminState of the given component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string AdminState
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NetworkVrf.ClassIdEnum ClassId
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
        /// <para type="description">"This field identifies the name of the given component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a networkElement resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.NetworkElementRelationship NetworkElement
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NetworkVrf.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetDeviceRegistrationRelationship RegisteredDevice
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
        /// <para type="description">"This field identifies the id of the given component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string VrfId
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.NetworkVrf initObject = new Intersight.Model.NetworkVrf();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdminState"))
            {
                initObject.AdminState = this.AdminState;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NetworkElement"))
            {
                initObject.NetworkElement = this.NetworkElement;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RegisteredDevice"))
            {
                initObject.RegisteredDevice = this.RegisteredDevice;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VrfId"))
            {
                initObject.VrfId = this.VrfId;
            }
            WriteObject(initObject);
        }

    }
}