using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get PowerControlState.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightPowerControlState", DefaultParameterSetName = "CmdletParam", SupportsShouldProcess = true)]
    public class GetIntersightPowerControlState : GetCmdletBase
    {
        public GetIntersightPowerControlState()
        {
            ApiInstance = new PowerApi(Config);
            MethodName = "GetPowerControlStateListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AccountMoid
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"This field identifies the allocated power on the chassis in Watts."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long AllocatedPower
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DomainGroupMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a equipmentChassis resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public EquipmentChassisRelationship EquipmentChassis
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The status of extended power capacity mode of the chassis. If Enabled, this mode allows chassis available power to be increased by borrowing power from redundant power supplies.\n* `Enabled` - Set the value to Enabled.\n* `Disabled` - Set the value to Disabled.\n* `Not Applicable` - Set the value to Not Applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public PowerControlState.ExtendedPowerCapacityEnum ExtendedPowerCapacity
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"This field identifies the available power when PSUs are in grid mode in Watts."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long GridMaxPower
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"This field identifies the maximum power required by the endpoint in Watts."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long MaxRequiredPower
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"This field identifies the minimum power required by the endpoint in Watts."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long MinRequiredPower
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ModTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Moid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"This field identifies the available power when PSUs are in N+1 mode in Watts."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long N1MaxPower
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"This field identifies the available power when PSUs are in N+2 mode in Watts."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long N2MaxPower
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"This field identifies the available power when PSUs are in non-redundant mode in Watts."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long NonRedundantMaxPower
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The status of power rebalancing mode of the chassis. If enabled, this mode allows the system to dynamically reallocate the power between servers depending on their power usage.\n* `Enabled` - The power group is administratively enabled.\n* `Disabled` - The power group is administratively disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public PowerControlState.PowerRebalancingEnum PowerRebalancing
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The status of power save mode of the chassis. If Enabled and the requested power budget is less than available power\u00a0capacity, the additional PSUs not required to comply with redundancy policy are placed in Power Save mode.\n* `Enabled` - The power group is administratively enabled.\n* `Disabled` - The power group is administratively disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public PowerControlState.PowerSaveModeEnum PowerSaveMode
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public AssetDeviceRegistrationRelationship RegisteredDevice
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">The $inlinecount query option allows clients to request an inline count of the matching resources included with the resources in the response.</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "QueryParam")]
        [ValidateSet("allpages", "none")]
        public String Inlinecount
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">The 'tags' parameter is used to request a summary of the Tag utilization for this resource. When the 'tags' parameter is specified, the response provides a list of tag keys, the number of times the key has been used across all documents, and the tag values that have been assigned to the tag key.</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "QueryParam")]

        public String Tags
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get PowerPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightPowerPolicy", DefaultParameterSetName = "CmdletParam", SupportsShouldProcess = true)]
    public class GetIntersightPowerPolicy : GetCmdletBase
    {
        public GetIntersightPowerPolicy()
        {
            ApiInstance = new PowerApi(Config);
            MethodName = "GetPowerPolicyListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AccountMoid
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Sets the limit for the maximum input power consumption by the chassis (in Watts). Set to 0 for no limit."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long AllocatedBudget
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DomainGroupMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Sets the dynamic power rebalancing mode of the chassis. If enabled, this mode allows the chassis to dynamically reallocate the power between servers depending on their power usage.\n* `Enabled` - The power group is administratively enabled.\n* `Disabled` - The power group is administratively disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public PowerPolicy.DynamicRebalancingEnum DynamicRebalancing
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Sets the Extended Power Capacity of the Chassis. If Enabled, this mode allows chassis available power to be increased by borrowing power from redundant power supplies.  This option is only supported for Cisco UCS X series Chassis.\n* `Enabled` - The power group is administratively enabled.\n* `Disabled` - The power group is administratively disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public PowerPolicy.ExtendedPowerCapacityEnum ExtendedPowerCapacity
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ModTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Moid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public OrganizationOrganizationRelationship Organization
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Sets the Power Priority of the Server. This priority is used to determine the initial power allocation for servers. This field is only supported for Cisco UCS B series and X series servers.\n* `Low` - Set the Power Priority to Low.\n* `Medium` - Set the Power Priority to Medium.\n* `High` - Set the Power Priority to High."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public PowerPolicy.PowerPriorityEnum PowerPriority
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Sets the Power Profiling of the Server. If Enabled, this field allows the power manager to run power profiling  utility to determine the power needs of the server.  This field is only supported for Cisco UCS X series servers.\n* `Enabled` - The power group is administratively enabled.\n* `Disabled` - The power group is administratively disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public PowerPolicy.PowerProfilingEnum PowerProfiling
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Sets the Power Restore State of the Server. In the absence of Intersight connectivity, the chassis/server will use this policy  to recover the host power after a power loss event.\n* `AlwaysOff` - Set the Power Restore Mode to Off.\n* `AlwaysOn` - Set the Power Restore Mode to On.\n* `LastState` - Set the Power Restore Mode to LastState."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public PowerPolicy.PowerRestoreStateEnum PowerRestoreState
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Sets the power save mode of the chassis. If the requested power budget is less than available power capacity,  the additional PSUs not required to comply with redundancy policy are placed in power save mode.\n* `Enabled` - The power group is administratively enabled.\n* `Disabled` - The power group is administratively disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public PowerPolicy.PowerSaveModeEnum PowerSaveMode
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Sets the Processor Package Power Limit (PPL) of a server. PPL refers to the amount of power that a CPU can draw from the power supply. The Processor Package Power Limit (PPL) feature is currently available exclusively on Cisco UCS C225/C245/C845 M8 servers.\n* `Default` - Set the Package Power Limit to the platform defined default value.\n* `Maximum` - Set the Package Power Limit to the platform defined maximum value.\n* `Minimum` - Set the Package Power Limit to the platform defined minimum value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public PowerPolicy.ProcessorPackagePowerLimitEnum ProcessorPackagePowerLimit
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Sets the Power Redundancy Mode of the Chassis.  Redundancy Mode determines the number of PSUs the chassis keeps as redundant.  N+2 mode is only supported for Cisco UCS X series Chassis. Only Grid and NotRedundant modes are supported for Cisco Unified Edge Chassis.\n* `Grid` - Grid Mode requires two power sources. If one source fails, the surviving PSUs connected to the other source provides power to the chassis.\n* `NotRedundant` - Power Manager turns on the minimum number of PSUs required to support chassis power requirements. No Redundant PSUs are maintained.\n* `N+1` - Power Manager turns on the minimum number of PSUs required to support chassis power requirements plus one additional PSU for redundancy.\n* `N+2` - Power Manager turns on the minimum number of PSUs required to support chassis power requirements plus two additional PSU for redundancy. This Mode is only supported for UCS X series Chassis."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public PowerPolicy.RedundancyModeEnum RedundancyMode
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">The $inlinecount query option allows clients to request an inline count of the matching resources included with the resources in the response.</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "QueryParam")]
        [ValidateSet("allpages", "none")]
        public String Inlinecount
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">The 'tags' parameter is used to request a summary of the Tag utilization for this resource. When the 'tags' parameter is specified, the response provides a list of tag keys, the number of times the key has been used across all documents, and the tag values that have been assigned to the tag key.</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "QueryParam")]

        public String Tags
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get PowerPolicyInventory.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightPowerPolicyInventory", DefaultParameterSetName = "CmdletParam", SupportsShouldProcess = true)]
    public class GetIntersightPowerPolicyInventory : GetCmdletBase
    {
        public GetIntersightPowerPolicyInventory()
        {
            ApiInstance = new PowerApi(Config);
            MethodName = "GetPowerPolicyInventoryListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AccountMoid
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Sets the limit for the maximum input power consumption by the chassis (in Watts). Set to 0 for no limit."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long AllocatedBudget
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\sa-zA-Z0-9_'.:-]*$")]
        public string Description
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Device ID of the entity from where inventory is reported."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DeviceMoId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DomainGroupMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Sets the dynamic power rebalancing mode of the chassis. If enabled, this mode allows the chassis to dynamically reallocate the power between servers depending on their power usage.\n* `Enabled` - The power group is administratively enabled.\n* `Disabled` - The power group is administratively disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public PowerPolicyInventory.DynamicRebalancingEnum DynamicRebalancing
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Sets the Extended Power Capacity of the Chassis. If Enabled, this mode allows chassis available power to be increased by borrowing power from redundant power supplies.  This option is only supported for Cisco UCS X series Chassis.\n* `Enabled` - The power group is administratively enabled.\n* `Disabled` - The power group is administratively disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public PowerPolicyInventory.ExtendedPowerCapacityEnum ExtendedPowerCapacity
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ModTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Moid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Name of the inventoried policy object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,512}$")]
        public string Name
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Sets the Power Priority of the Server. This priority is used to determine the initial power allocation for servers. This field is only supported for Cisco UCS B series and X series servers.\n* `Low` - Set the Power Priority to Low.\n* `Medium` - Set the Power Priority to Medium.\n* `High` - Set the Power Priority to High."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public PowerPolicyInventory.PowerPriorityEnum PowerPriority
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Sets the Power Profiling of the Server. If Enabled, this field allows the power manager to run power profiling  utility to determine the power needs of the server.  This field is only supported for Cisco UCS X series servers.\n* `Enabled` - The power group is administratively enabled.\n* `Disabled` - The power group is administratively disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public PowerPolicyInventory.PowerProfilingEnum PowerProfiling
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Sets the Power Restore State of the Server. In the absence of Intersight connectivity, the chassis/server will use this policy  to recover the host power after a power loss event.\n* `AlwaysOff` - Set the Power Restore Mode to Off.\n* `AlwaysOn` - Set the Power Restore Mode to On.\n* `LastState` - Set the Power Restore Mode to LastState."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public PowerPolicyInventory.PowerRestoreStateEnum PowerRestoreState
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Sets the power save mode of the chassis. If the requested power budget is less than available power capacity,  the additional PSUs not required to comply with redundancy policy are placed in power save mode.\n* `Enabled` - The power group is administratively enabled.\n* `Disabled` - The power group is administratively disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public PowerPolicyInventory.PowerSaveModeEnum PowerSaveMode
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Sets the Processor Package Power Limit (PPL) of a server. PPL refers to the amount of power that a CPU can draw from the power supply. The Processor Package Power Limit (PPL) feature is currently available exclusively on Cisco UCS C225/C245/C845 M8 servers.\n* `Default` - Set the Package Power Limit to the platform defined default value.\n* `Maximum` - Set the Package Power Limit to the platform defined maximum value.\n* `Minimum` - Set the Package Power Limit to the platform defined minimum value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public PowerPolicyInventory.ProcessorPackagePowerLimitEnum ProcessorPackagePowerLimit
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Sets the Power Redundancy Mode of the Chassis.  Redundancy Mode determines the number of PSUs the chassis keeps as redundant.  N+2 mode is only supported for Cisco UCS X series Chassis. Only Grid and NotRedundant modes are supported for Cisco Unified Edge Chassis.\n* `Grid` - Grid Mode requires two power sources. If one source fails, the surviving PSUs connected to the other source provides power to the chassis.\n* `NotRedundant` - Power Manager turns on the minimum number of PSUs required to support chassis power requirements. No Redundant PSUs are maintained.\n* `N+1` - Power Manager turns on the minimum number of PSUs required to support chassis power requirements plus one additional PSU for redundancy.\n* `N+2` - Power Manager turns on the minimum number of PSUs required to support chassis power requirements plus two additional PSU for redundancy. This Mode is only supported for UCS X series Chassis."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public PowerPolicyInventory.RedundancyModeEnum RedundancyMode
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship TargetMo
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">The $inlinecount query option allows clients to request an inline count of the matching resources included with the resources in the response.</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "QueryParam")]
        [ValidateSet("allpages", "none")]
        public String Inlinecount
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">The 'tags' parameter is used to request a summary of the Tag utilization for this resource. When the 'tags' parameter is specified, the response provides a list of tag keys, the number of times the key has been used across all documents, and the tag values that have been assigned to the tag key.</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "QueryParam")]

        public String Tags
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get PowerPowerGroup.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightPowerPowerGroup", DefaultParameterSetName = "CmdletParam", SupportsShouldProcess = true)]
    public class GetIntersightPowerPowerGroup : GetCmdletBase
    {
        public GetIntersightPowerPowerGroup()
        {
            ApiInstance = new PowerApi(Config);
            MethodName = "GetPowerPowerGroupListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public IamAccountRelationship Account
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AccountMoid
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Administrative state of the power group. Determines whether the power group is enabled or disabled.\n* `Enabled` - The power group is administratively enabled.\n* `Disabled` - The power group is administratively disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public PowerPowerGroup.AdminStateEnum AdminState
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Reserved power buffer calculated as 10% of total chassis minimum power requirements. FI and FEX do not contribute to buffer power."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long BufferPowerRequired
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Power Group Configuration State.\n* `Ok` - The configuration state of the power group is ok. All members are configured successfully.\n* `Unknown` - The configuration state of the power group is not known.\n* `Configuring` - The power group is actively being configured. Transitional state during CREATE or UPDATE operations.\n* `PartiallyConfigured` - The power group configuration failed mid-way. Some members may be configured while others are not. Totals may not match actual membership. Reconciliation or manual intervention is required.\n* `PartiallyDeleted` - The configuration state of the power group is Partially Deleted. This occurs when a DELETE operation was initiated but the workflow to remove power limits did not succeed for all members.\n* `Disabling` - The power group is being disabled. A workflow is in progress to push 0 power limits to all member devices.\n* `PartiallyDisabled` - The power group disable operation failed mid-way. Some members may have their power limits removed while others retain their previous values. The power group remains in a disabled state but may require manual intervention."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public PowerPowerGroup.ConfigStateEnum ConfigState
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Description of the power group."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DomainGroupMoid
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ModTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Moid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"User defined name for the power group."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Power Group Operational State.\n* `Ok` - The operational state of the power group is ok. All members are configured successfully.\n* `Unknown` - The operational state of the power group is not known.\n* `InsufficientPower` - The power group does not have sufficient power budget to meet the minimum power requirements of all its chassis members. This typically occurs when new hardware is added to a member chassis, increasing its minimum power requirement beyond the available budget."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public PowerPowerGroup.OperStateEnum OperState
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Maximum power budget allocated to this power group in watts."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long PowerBudget
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Sum of maximum power required for each member in this group in watts."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long TotalMaximumPowerRequired
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Sum of minimum power required for each member in this group in watts."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long TotalMinimumPowerRequired
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">The $inlinecount query option allows clients to request an inline count of the matching resources included with the resources in the response.</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "QueryParam")]
        [ValidateSet("allpages", "none")]
        public String Inlinecount
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">The 'tags' parameter is used to request a summary of the Tag utilization for this resource. When the 'tags' parameter is specified, the response provides a list of tag keys, the number of times the key has been used across all documents, and the tag values that have been assigned to the tag key.</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "QueryParam")]

        public String Tags
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get PowerPowerGroupMember.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightPowerPowerGroupMember", DefaultParameterSetName = "CmdletParam", SupportsShouldProcess = true)]
    public class GetIntersightPowerPowerGroupMember : GetCmdletBase
    {
        public GetIntersightPowerPowerGroupMember()
        {
            ApiInstance = new PowerApi(Config);
            MethodName = "GetPowerPowerGroupMemberListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AccountMoid
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Power allocated to the power group member by the power group in watts."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long AllocatedPower
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Configuration State of the power group member.\n* `Ok` - The configuration state of the power group member is ok.\n* `Unknown` - The configuration state of the power group member is not known.\n* `PendingRemoval` - The power group member is pending removal. The member has been removed from the power group's InventoryDeviceMember list but the workflow to remove power limit from the device has not yet completed. Once the workflow succeeds, this member MO will be deleted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public PowerPowerGroupMember.ConfigStateEnum ConfigState
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Moid of the asset.DeviceRegistration corresponding to this member's inventory device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DeviceRegistrationMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DomainGroupMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship InventoryDevice
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Maximum power required by the power group member in watts."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long MaxRequiredPower
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The type of the power group member - Chassis, Fex or Fabric Interconnect.\n* `Unknown` - The power group member type is unknown.\n* `Chassis` - The power group member is a chassis.\n* `Fex` - The power group member is a Fex.\n* `FabricInterconnect` - The power group member is a Fabric Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public PowerPowerGroupMember.MemberTypeEnum MemberType
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Minimum power required by the power group member in watts."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long MinRequiredPower
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ModTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Moid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Operational State of the power group member.\n* `Ok` - The operational state of the power group member is ok.\n* `PowerConsumptionNearingLimit` - Operational state for power group member is PowerConsumptionNearingLimit. This may happen when the current power consumption of a chassis approaches the chassis power limit."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public PowerPowerGroupMember.OperStateEnum OperState
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a powerPowerGroup resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public PowerPowerGroupRelationship PowerGroupParent
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">The $inlinecount query option allows clients to request an inline count of the matching resources included with the resources in the response.</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "QueryParam")]
        [ValidateSet("allpages", "none")]
        public String Inlinecount
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">The 'tags' parameter is used to request a summary of the Tag utilization for this resource. When the 'tags' parameter is specified, the response provides a list of tag keys, the number of times the key has been used across all documents, and the tag values that have been assigned to the tag key.</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "QueryParam")]

        public String Tags
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New PowerPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightPowerPolicy", SupportsShouldProcess = true)]
    public class NewIntersightPowerPolicy : NewCmdletBase
    {
        public NewIntersightPowerPolicy()
        {
            ApiInstance = new PowerApi(Config);
            ModelObject = new PowerPolicy();
            MethodName = "CreatePowerPolicyWithHttpInfo";
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
        /// <para type="description">"Sets the limit for the maximum input power consumption by the chassis (in Watts). Set to 0 for no limit."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long AllocatedBudget
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Sets the dynamic power rebalancing mode of the chassis. If enabled, this mode allows the chassis to dynamically reallocate the power between servers depending on their power usage.\n* `Enabled` - The power group is administratively enabled.\n* `Disabled` - The power group is administratively disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PowerPolicy.DynamicRebalancingEnum DynamicRebalancing
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Sets the Extended Power Capacity of the Chassis. If Enabled, this mode allows chassis available power to be increased by borrowing power from redundant power supplies.  This option is only supported for Cisco UCS X series Chassis.\n* `Enabled` - The power group is administratively enabled.\n* `Disabled` - The power group is administratively disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PowerPolicy.ExtendedPowerCapacityEnum ExtendedPowerCapacity
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public OrganizationOrganizationRelationship Organization
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"Sets the Power Priority of the Server. This priority is used to determine the initial power allocation for servers. This field is only supported for Cisco UCS B series and X series servers.\n* `Low` - Set the Power Priority to Low.\n* `Medium` - Set the Power Priority to Medium.\n* `High` - Set the Power Priority to High."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PowerPolicy.PowerPriorityEnum PowerPriority
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Sets the Power Profiling of the Server. If Enabled, this field allows the power manager to run power profiling  utility to determine the power needs of the server.  This field is only supported for Cisco UCS X series servers.\n* `Enabled` - The power group is administratively enabled.\n* `Disabled` - The power group is administratively disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PowerPolicy.PowerProfilingEnum PowerProfiling
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Sets the Power Restore State of the Server. In the absence of Intersight connectivity, the chassis/server will use this policy  to recover the host power after a power loss event.\n* `AlwaysOff` - Set the Power Restore Mode to Off.\n* `AlwaysOn` - Set the Power Restore Mode to On.\n* `LastState` - Set the Power Restore Mode to LastState."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PowerPolicy.PowerRestoreStateEnum PowerRestoreState
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Sets the power save mode of the chassis. If the requested power budget is less than available power capacity,  the additional PSUs not required to comply with redundancy policy are placed in power save mode.\n* `Enabled` - The power group is administratively enabled.\n* `Disabled` - The power group is administratively disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PowerPolicy.PowerSaveModeEnum PowerSaveMode
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Sets the Processor Package Power Limit (PPL) of a server. PPL refers to the amount of power that a CPU can draw from the power supply. The Processor Package Power Limit (PPL) feature is currently available exclusively on Cisco UCS C225/C245/C845 M8 servers.\n* `Default` - Set the Package Power Limit to the platform defined default value.\n* `Maximum` - Set the Package Power Limit to the platform defined maximum value.\n* `Minimum` - Set the Package Power Limit to the platform defined minimum value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PowerPolicy.ProcessorPackagePowerLimitEnum ProcessorPackagePowerLimit
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An array of relationships to policyAbstractConfigProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<PolicyAbstractConfigProfileRelationship> Profiles
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Sets the Power Redundancy Mode of the Chassis.  Redundancy Mode determines the number of PSUs the chassis keeps as redundant.  N+2 mode is only supported for Cisco UCS X series Chassis. Only Grid and NotRedundant modes are supported for Cisco Unified Edge Chassis.\n* `Grid` - Grid Mode requires two power sources. If one source fails, the surviving PSUs connected to the other source provides power to the chassis.\n* `NotRedundant` - Power Manager turns on the minimum number of PSUs required to support chassis power requirements. No Redundant PSUs are maintained.\n* `N+1` - Power Manager turns on the minimum number of PSUs required to support chassis power requirements plus one additional PSU for redundancy.\n* `N+2` - Power Manager turns on the minimum number of PSUs required to support chassis power requirements plus two additional PSU for redundancy. This Mode is only supported for UCS X series Chassis."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PowerPolicy.RedundancyModeEnum RedundancyMode
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">For methods that apply server-side changes, and in particular for PUT, If-Match can be used to prevent the lost update problem. It can check if the modification of a resource that the user wants to upload will not override another change that has been done since the original resource was fetched. If the request cannot be fulfilled, the 412 (Precondition Failed) response is returned. When modifying a resource using POST or PUT, the If-Match header must be set to the value of the resource ModTime property after which no lost update problem should occur. For example, a client send a GET request to obtain a resource, which includes the ModTime property. The ModTime indicates the last time the resource was created or modified. The client then sends a POST or PUT request with the If-Match header set to the ModTime property of the resource as obtained in the GET request.</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]

        public String IfMatch
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">For methods that apply server-side changes, If-None-Match used with the * value can be used to create a resource not known to exist, guaranteeing that another resource creation didn't happen before, losing the data of the previous put. The request will be processed only if the eventually existing resource's ETag doesn't match any of the values listed. Otherwise, the status code 412 (Precondition Failed) is used. The asterisk is a special value representing any resource. It is only useful when creating a resource, usually with PUT, to check if another resource with the identity has already been created before. The comparison with the stored ETag uses the weak comparison algorithm, meaning two resources are considered identical if the content is equivalent - they don't have to be identical byte for byte.</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]

        public String IfNoneMatch
        {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New PowerPowerGroup.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightPowerPowerGroup", SupportsShouldProcess = true)]
    public class NewIntersightPowerPowerGroup : NewCmdletBase
    {
        public NewIntersightPowerPowerGroup()
        {
            ApiInstance = new PowerApi(Config);
            ModelObject = new PowerPowerGroup();
            MethodName = "CreatePowerPowerGroupWithHttpInfo";
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
        /// <para type="description">"Administrative state of the power group. Determines whether the power group is enabled or disabled.\n* `Enabled` - The power group is administratively enabled.\n* `Disabled` - The power group is administratively disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PowerPowerGroup.AdminStateEnum AdminState
        {
            get;
            set;
        }





        // <summary>
        /// <para type="description">"Description of the power group."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"An array of relationships to moBaseMo resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoBaseMoRelationship> InventoryDeviceMember
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
        /// <para type="description">"User defined name for the power group."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }





        // <summary>
        /// <para type="description">"Maximum power budget allocated to this power group in watts."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long PowerBudget
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">For methods that apply server-side changes, and in particular for PUT, If-Match can be used to prevent the lost update problem. It can check if the modification of a resource that the user wants to upload will not override another change that has been done since the original resource was fetched. If the request cannot be fulfilled, the 412 (Precondition Failed) response is returned. When modifying a resource using POST or PUT, the If-Match header must be set to the value of the resource ModTime property after which no lost update problem should occur. For example, a client send a GET request to obtain a resource, which includes the ModTime property. The ModTime indicates the last time the resource was created or modified. The client then sends a POST or PUT request with the If-Match header set to the ModTime property of the resource as obtained in the GET request.</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]

        public String IfMatch
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">For methods that apply server-side changes, If-None-Match used with the * value can be used to create a resource not known to exist, guaranteeing that another resource creation didn't happen before, losing the data of the previous put. The request will be processed only if the eventually existing resource's ETag doesn't match any of the values listed. Otherwise, the status code 412 (Precondition Failed) is used. The asterisk is a special value representing any resource. It is only useful when creating a resource, usually with PUT, to check if another resource with the identity has already been created before. The comparison with the stored ETag uses the weak comparison algorithm, meaning two resources are considered identical if the content is equivalent - they don't have to be identical byte for byte.</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]

        public String IfNoneMatch
        {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove PowerPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightPowerPolicy", SupportsShouldProcess = true)]
    public class RemoveIntersightPowerPolicy : RemoveCmdletBase
    {
        public RemoveIntersightPowerPolicy()
        {
            ApiInstance = new PowerApi(Config);
            MethodName = "DeletePowerPolicyWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove PowerPowerGroup.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightPowerPowerGroup", SupportsShouldProcess = true)]
    public class RemoveIntersightPowerPowerGroup : RemoveCmdletBase
    {
        public RemoveIntersightPowerPowerGroup()
        {
            ApiInstance = new PowerApi(Config);
            MethodName = "DeletePowerPowerGroupWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set PowerPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightPowerPolicy", SupportsShouldProcess = true)]
    public class SetIntersightPowerPolicy : SetCmdletBase
    {
        public SetIntersightPowerPolicy()
        {
            ApiInstance = new PowerApi(Config);
            ModelObject = new PowerPolicy();
            MethodName = "UpdatePowerPolicyWithHttpInfo";
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
        /// <para type="description">"Sets the limit for the maximum input power consumption by the chassis (in Watts). Set to 0 for no limit."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long AllocatedBudget
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Sets the dynamic power rebalancing mode of the chassis. If enabled, this mode allows the chassis to dynamically reallocate the power between servers depending on their power usage.\n* `Enabled` - The power group is administratively enabled.\n* `Disabled` - The power group is administratively disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PowerPolicy.DynamicRebalancingEnum DynamicRebalancing
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Sets the Extended Power Capacity of the Chassis. If Enabled, this mode allows chassis available power to be increased by borrowing power from redundant power supplies.  This option is only supported for Cisco UCS X series Chassis.\n* `Enabled` - The power group is administratively enabled.\n* `Disabled` - The power group is administratively disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PowerPolicy.ExtendedPowerCapacityEnum ExtendedPowerCapacity
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public OrganizationOrganizationRelationship Organization
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"Sets the Power Priority of the Server. This priority is used to determine the initial power allocation for servers. This field is only supported for Cisco UCS B series and X series servers.\n* `Low` - Set the Power Priority to Low.\n* `Medium` - Set the Power Priority to Medium.\n* `High` - Set the Power Priority to High."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PowerPolicy.PowerPriorityEnum PowerPriority
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Sets the Power Profiling of the Server. If Enabled, this field allows the power manager to run power profiling  utility to determine the power needs of the server.  This field is only supported for Cisco UCS X series servers.\n* `Enabled` - The power group is administratively enabled.\n* `Disabled` - The power group is administratively disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PowerPolicy.PowerProfilingEnum PowerProfiling
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Sets the Power Restore State of the Server. In the absence of Intersight connectivity, the chassis/server will use this policy  to recover the host power after a power loss event.\n* `AlwaysOff` - Set the Power Restore Mode to Off.\n* `AlwaysOn` - Set the Power Restore Mode to On.\n* `LastState` - Set the Power Restore Mode to LastState."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PowerPolicy.PowerRestoreStateEnum PowerRestoreState
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Sets the power save mode of the chassis. If the requested power budget is less than available power capacity,  the additional PSUs not required to comply with redundancy policy are placed in power save mode.\n* `Enabled` - The power group is administratively enabled.\n* `Disabled` - The power group is administratively disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PowerPolicy.PowerSaveModeEnum PowerSaveMode
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Sets the Processor Package Power Limit (PPL) of a server. PPL refers to the amount of power that a CPU can draw from the power supply. The Processor Package Power Limit (PPL) feature is currently available exclusively on Cisco UCS C225/C245/C845 M8 servers.\n* `Default` - Set the Package Power Limit to the platform defined default value.\n* `Maximum` - Set the Package Power Limit to the platform defined maximum value.\n* `Minimum` - Set the Package Power Limit to the platform defined minimum value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PowerPolicy.ProcessorPackagePowerLimitEnum ProcessorPackagePowerLimit
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An array of relationships to policyAbstractConfigProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<PolicyAbstractConfigProfileRelationship> Profiles
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Sets the Power Redundancy Mode of the Chassis.  Redundancy Mode determines the number of PSUs the chassis keeps as redundant.  N+2 mode is only supported for Cisco UCS X series Chassis. Only Grid and NotRedundant modes are supported for Cisco Unified Edge Chassis.\n* `Grid` - Grid Mode requires two power sources. If one source fails, the surviving PSUs connected to the other source provides power to the chassis.\n* `NotRedundant` - Power Manager turns on the minimum number of PSUs required to support chassis power requirements. No Redundant PSUs are maintained.\n* `N+1` - Power Manager turns on the minimum number of PSUs required to support chassis power requirements plus one additional PSU for redundancy.\n* `N+2` - Power Manager turns on the minimum number of PSUs required to support chassis power requirements plus two additional PSU for redundancy. This Mode is only supported for UCS X series Chassis."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PowerPolicy.RedundancyModeEnum RedundancyMode
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">For methods that apply server-side changes, and in particular for PUT, If-Match can be used to prevent the lost update problem. It can check if the modification of a resource that the user wants to upload will not override another change that has been done since the original resource was fetched. If the request cannot be fulfilled, the 412 (Precondition Failed) response is returned. When modifying a resource using POST or PUT, the If-Match header must be set to the value of the resource ModTime property after which no lost update problem should occur. For example, a client send a GET request to obtain a resource, which includes the ModTime property. The ModTime indicates the last time the resource was created or modified. The client then sends a POST or PUT request with the If-Match header set to the ModTime property of the resource as obtained in the GET request.</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]

        public String IfMatch
        {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set PowerPowerGroup.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightPowerPowerGroup", SupportsShouldProcess = true)]
    public class SetIntersightPowerPowerGroup : SetCmdletBase
    {
        public SetIntersightPowerPowerGroup()
        {
            ApiInstance = new PowerApi(Config);
            ModelObject = new PowerPowerGroup();
            MethodName = "UpdatePowerPowerGroupWithHttpInfo";
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
        /// <para type="description">"Administrative state of the power group. Determines whether the power group is enabled or disabled.\n* `Enabled` - The power group is administratively enabled.\n* `Disabled` - The power group is administratively disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PowerPowerGroup.AdminStateEnum AdminState
        {
            get;
            set;
        }





        // <summary>
        /// <para type="description">"Description of the power group."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"An array of relationships to moBaseMo resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoBaseMoRelationship> InventoryDeviceMember
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"User defined name for the power group."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }





        // <summary>
        /// <para type="description">"Maximum power budget allocated to this power group in watts."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long PowerBudget
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">For methods that apply server-side changes, and in particular for PUT, If-Match can be used to prevent the lost update problem. It can check if the modification of a resource that the user wants to upload will not override another change that has been done since the original resource was fetched. If the request cannot be fulfilled, the 412 (Precondition Failed) response is returned. When modifying a resource using POST or PUT, the If-Match header must be set to the value of the resource ModTime property after which no lost update problem should occur. For example, a client send a GET request to obtain a resource, which includes the ModTime property. The ModTime indicates the last time the resource was created or modified. The client then sends a POST or PUT request with the If-Match header set to the ModTime property of the resource as obtained in the GET request.</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]

        public String IfMatch
        {
            get;
            set;
        }
    }
}