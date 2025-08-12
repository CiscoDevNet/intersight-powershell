using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricAppliancePcRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricAppliancePcRole", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricAppliancePcRole : GetCmdletBase
    {
        public GetIntersightFabricAppliancePcRole()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricAppliancePcRoleListWithHttpInfo";
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
        /// <para type="description">"Admin configured speed for the port channel.\n* `Auto` - Admin configurable speed AUTO ( default ).\n* `1Gbps` - Admin configurable speed 1Gbps.\n* `10Gbps` - Admin configurable speed 10Gbps.\n* `25Gbps` - Admin configurable speed 25Gbps.\n* `40Gbps` - Admin configurable speed 40Gbps.\n* `100Gbps` - Admin configurable speed 100Gbps.\n* `NegAuto25Gbps` - Admin configurable 25Gbps auto negotiation for ports and port-channels.Speed is applicable on Ethernet Uplink, Ethernet Appliance and FCoE Uplink port and port-channel roles.This speed config is only applicable to non-breakout ports on UCS-FI-6454 and UCS-FI-64108."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricAppliancePcRole.AdminSpeedEnum AdminSpeed
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
        /// <para type="description">"A reference to a fabricEthNetworkControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricEthNetworkControlPolicyRelationship EthNetworkControlPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricEthNetworkGroupPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricEthNetworkGroupPolicyRelationship EthNetworkGroupPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Forward error correction configuration for Appliance Port Channel member ports.\n* `Auto` - Forward error correction option 'Auto'. Supported speeds are Auto, 1Gbps, 10Gbps, 25Gbps, 40Gbps and 100 Gbps.\n* `Cl91` - Forward error correction option 'cl91'. Supported speeds are 25Gbps and 100 Gbps.\n* `Cl74` - Forward error correction option 'cl74'. Supported speeds are 25Gbps.\n* `rs-cons16` - Forward error correction option \"rs-cons16\". Supported speeds are 25Gbps.\n* `rs-ieee` - Forward error correction option \"rs-ieee\". Supported speeds are 25Gbps.\n* `Off` - Turn off forward error correction. Supported speeds are 25Gbps and 100 Gbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricAppliancePcRole.FecEnum Fec
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricLinkAggregationPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricLinkAggregationPolicyRelationship LinkAggregationPolicy
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
        /// <para type="description">"Port mode to be set on the appliance port-channel.\n* `trunk` - Trunk Mode Switch Port Type.\n* `access` - Access Mode Switch Port Type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricAppliancePcRole.ModeEnum Mode
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
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Unique Identifier of the port-channel, local to this switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidateRange(1, 256)]
        public long PcId
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricPortPolicyRelationship PortPolicy
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The 'name' of the System QoS Class.\n* `Best Effort` - QoS Priority for Best-effort traffic.\n* `FC` - QoS Priority for FC traffic.\n* `Platinum` - QoS Priority for Platinum traffic.\n* `Gold` - QoS Priority for Gold traffic.\n* `Silver` - QoS Priority for Silver traffic.\n* `Bronze` - QoS Priority for Bronze traffic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricAppliancePcRole.PriorityEnum Priority
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
        /// <para type="description">"The user defined label assigned to the a Port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^[ !#$%\\s+&\\(\\)\\*\\+,\\-\\./:;\\?@\\[\\]_\\{\\|\\}~a-zA-Z0-9]*$")]
        public string UserLabel
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricApplianceRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricApplianceRole", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricApplianceRole : GetCmdletBase
    {
        public GetIntersightFabricApplianceRole()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricApplianceRoleListWithHttpInfo";
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
        /// <para type="description">"Admin configured speed for the port.\n* `Auto` - Admin configurable speed AUTO ( default ).\n* `1Gbps` - Admin configurable speed 1Gbps.\n* `10Gbps` - Admin configurable speed 10Gbps.\n* `25Gbps` - Admin configurable speed 25Gbps.\n* `40Gbps` - Admin configurable speed 40Gbps.\n* `100Gbps` - Admin configurable speed 100Gbps.\n* `NegAuto25Gbps` - Admin configurable 25Gbps auto negotiation for ports and port-channels.Speed is applicable on Ethernet Uplink, Ethernet Appliance and FCoE Uplink port and port-channel roles.This speed config is only applicable to non-breakout ports on UCS-FI-6454 and UCS-FI-64108."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricApplianceRole.AdminSpeedEnum AdminSpeed
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Breakout port Identifier of the Switch Interface.\nWhen a port is not configured as a breakout port, the aggregatePortId is set to 0, and unused.\nWhen a port is configured as a breakout port, the 'aggregatePortId' port number as labeled on the equipment,\ne.g. the id of the port on the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long AggregatePortId
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
        /// <para type="description">"A reference to a fabricEthNetworkControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricEthNetworkControlPolicyRelationship EthNetworkControlPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricEthNetworkGroupPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricEthNetworkGroupPolicyRelationship EthNetworkGroupPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Forward error correction configuration for the port.\n* `Auto` - Forward error correction option 'Auto'. Supported speeds are Auto, 1Gbps, 10Gbps, 25Gbps, 40Gbps and 100 Gbps.\n* `Cl91` - Forward error correction option 'cl91'. Supported speeds are 25Gbps and 100 Gbps.\n* `Cl74` - Forward error correction option 'cl74'. Supported speeds are 25Gbps.\n* `rs-cons16` - Forward error correction option \"rs-cons16\". Supported speeds are 25Gbps.\n* `rs-ieee` - Forward error correction option \"rs-ieee\". Supported speeds are 25Gbps.\n* `Off` - Turn off forward error correction. Supported speeds are 25Gbps and 100 Gbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricApplianceRole.FecEnum Fec
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricFlowControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricFlowControlPolicyRelationship FlowControlPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricLinkControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricLinkControlPolicyRelationship LinkControlPolicy
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
        /// <para type="description">"Port mode to be set on the appliance port.\n* `trunk` - Trunk Mode Switch Port Type.\n* `access` - Access Mode Switch Port Type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricApplianceRole.ModeEnum Mode
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
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Port Identifier of the Switch/FEX/Chassis Interface.\nWhen a port is not configured as a breakout port, the portId is the port number as labeled on the equipment,\ne.g. the id of the port on the switch, FEX or chassis.\nWhen a port is configured as a breakout port, the 'portId' represents the port id on the fanout side of the breakout cable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidateRange(1, 108)]
        public long PortId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricPortPolicyRelationship PortPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The 'name' of the System QoS Class.\n* `Best Effort` - QoS Priority for Best-effort traffic.\n* `FC` - QoS Priority for FC traffic.\n* `Platinum` - QoS Priority for Platinum traffic.\n* `Gold` - QoS Priority for Gold traffic.\n* `Silver` - QoS Priority for Silver traffic.\n* `Bronze` - QoS Priority for Bronze traffic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricApplianceRole.PriorityEnum Priority
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
        /// <para type="description">"Slot Identifier of the Switch/FEX/Chassis Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidateRange(1, 5)]
        public long SlotId
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The user defined label assigned to a Port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^[ !#$%\\s+&\\(\\)\\*\\+,\\-\\./:;\\?@\\[\\]_\\{\\|\\}~a-zA-Z0-9]*$")]
        public string UserLabel
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricConfigChangeDetail.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricConfigChangeDetail", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricConfigChangeDetail : GetCmdletBase
    {
        public GetIntersightFabricConfigChangeDetail()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricConfigChangeDetailListWithHttpInfo";
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
        /// <para type="description">"Config change flag to differentiate Pending-changes and Config-drift.\n* `Pending-changes` - Config change flag represents changes are due to not deployed changes from Intersight.\n* `Drift-changes` - Config change flag represents changes are due to endpoint configuration changes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricConfigChangeDetail.ConfigChangeFlagEnum ConfigChangeFlag
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
        /// <para type="description">"Detailed description of the config change."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Message
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Modification status of the mo in this config change.\n* `None` - The 'none' operation/state.Indicates a configuration profile has been deployed, and the desired configuration matches the actual device configuration.\n* `Created` - The 'create' operation/state.Indicates a configuration profile has been created and associated with a device, but the configuration specified in the profilehas not been applied yet. For example, this could happen when the user creates a server profile and has not deployed the profile yet.\n* `Modified` - The 'update' operation/state.Indicates some of the desired configuration changes specified in a profile have not been been applied to the associated device.This happens when the user has made changes to a profile and has not deployed the changes yet, or when the workflow to applythe configuration changes has not completed successfully.\n* `Deleted` - The 'delete' operation/state.Indicates a configuration profile has been been disassociated from a device and the user has not undeployed these changes yet."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricConfigChangeDetail.ModStatusEnum ModStatus
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
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a fabricSwitchProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricSwitchProfileRelationship Profile
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




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricConfigResult.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricConfigResult", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricConfigResult : GetCmdletBase
    {
        public GetIntersightFabricConfigResult()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricConfigResultListWithHttpInfo";
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
        /// <para type="description">"The current running stage of the configuration or workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ConfigStage
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Indicates overall configuration state for applying the configuration to the end point. Values  -- Ok, Ok-with-warning, Errored."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ConfigState
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
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a fabricBaseSwitchProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricBaseSwitchProfileRelationship Profile
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
        /// <para type="description">"Indicates overall state for logical model validation. Values  -- Ok, Ok-with-warning, Errored."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ValidationState
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricConfigResultEntry.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricConfigResultEntry", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricConfigResultEntry : GetCmdletBase
    {
        public GetIntersightFabricConfigResultEntry()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricConfigResultEntryListWithHttpInfo";
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
        /// <para type="description">"The completed time of the task in installer."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string CompletedTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricConfigResult resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricConfigResultRelationship ConfigResult
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
        /// <para type="description">"Localized message based on the locale setting of the user's context."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Message
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
        /// <para type="description">"The identifier of the object that owns the result message.\nThe owner ID is used to correlate a given result entry to a task or entity. For example, a config result\nentry that describes the result of a workflow task may have the task's instance ID as the owner."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string OwnerId
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
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Values  -- Ok, Ok-with-warning, Errored."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string State
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Indicates if the result is reported during the logical model validation/resource allocation phase. or the configuration applying phase. Values -- validation, config."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Type
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricElementIdentity.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricElementIdentity", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricElementIdentity : GetCmdletBase
    {
        public GetIntersightFabricElementIdentity()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricElementIdentityListWithHttpInfo";
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
        /// <para type="description">"Updated by UI/API to trigger specific action type.\n* `None` - No operation value for maintenance actions on an equipment.\n* `Decommission` - Decommission the equipment and temporarily remove it from being managed by Intersight.\n* `Recommission` - Recommission the equipment.\n* `Reack` - Reacknowledge the equipment and discover it again.\n* `Remove` - Remove the equipment permanently from Intersight management.\n* `Replace` - Replace the equipment with the other one."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricElementIdentity.AdminActionEnum AdminAction
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The state of Maintenance Action performed. This will have three states. Applying - Action is in progress. Applied - Action is completed and applied. Failed - Action has failed.\n* `None` - Nil value when no action has been triggered by the user.\n* `Applied` - User configured settings are in applied state.\n* `Applying` - User settings are being applied on the target server.\n* `Failed` - User configured settings could not be applied."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricElementIdentity.AdminActionStateEnum AdminActionState
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
        /// <para type="description">"Name of the Fabric Interconnect domain."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Domain
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
        /// <para type="description">"Numeric Identifier assigned by the management system to the equipment. Identifier can only be changed if it has been PATCHED with the AdminAction property set to 'Recommission'."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long Identifier
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The equipment's lifecycle status.\n* `None` - Default state of an equipment. This should be an initial state when no state is defined for an equipment.\n* `Active` - Default Lifecycle State for a physical entity.\n* `Decommissioned` - Decommission Lifecycle state.\n* `DecommissionInProgress` - Decommission Inprogress Lifecycle state.\n* `RecommissionInProgress` - Recommission Inprogress Lifecycle state.\n* `OperationFailed` - Failed Operation Lifecycle state.\n* `ReackInProgress` - ReackInProgress Lifecycle state.\n* `RemoveInProgress` - RemoveInProgress Lifecycle state.\n* `Discovered` - Discovered Lifecycle state.\n* `DiscoveryInProgress` - DiscoveryInProgress Lifecycle state.\n* `DiscoveryFailed` - DiscoveryFailed Lifecycle state.\n* `FirmwareUpgradeInProgress` - Firmware upgrade is in progress on given physical entity.\n* `SecureEraseInProgress` - Secure Erase is in progress on given physical entity.\n* `ScrubInProgress` - Scrub is in progress on given physical entity.\n* `BladeMigrationInProgress` - Server slot migration is in progress on given physical entity.\n* `Inactive` - Inactive Lifecycle state.\n* `ReplaceInProgress` - ReplaceInProgress Lifecycle state.\n* `SlotMismatch` - The blade server is detected in a different chassis/slot than it was previously.\n* `ReplacementPendingUserAction` - A new blade server is detected, and discovery is pending cleanup of old blade originally discovered in the new blade's location.\n* `Removed` - The blade server has been removed from its discovered slot, and not detected anywhere else within the domain.\n* `Moved` - The blade server has been moved from its discovered location to a new location within the domain.\n* `Replaced` - The blade server has been removed from its discovered location and another blade has been inserted. in that location.\n* `MovedAndReplaced` - The blade server has been moved from its discovered location to a new location within the domain and another blade has been inserted into the previously discovered location.\n* `DomainRmaPendingUserAction` - Domain RMA detected due to the presence of an old pair of FIs with mismatched serial numbers within the same account. User to either initiate the 'Replace Domain workflow' or unclaim the old domain.\n* `IdentityUnknown` - The endpoint cannot be identified because of incomplete vendor, model, or serial information."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricElementIdentity.LifecycleEnum Lifecycle
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when the last life cycle state change happened."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime LifecycleModTime
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
        /// <para type="description">"The vendor provided model name for the equipment."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Model
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
        /// <para type="description">"The name of the equipment for unique identification."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Name
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a networkElement resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public NetworkElementRelationship NetworkElement
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
        /// <para type="description">"Determines if there is partial configuration that has to be deployed on any of the server profiles associated with the server connected to the Fabric Interconnect in cases where one or more server profiles  was deployed when the Fabric Interconnect was down.\n* `None` - No configuration which is yet to be deployed.The default state of a fabric interconnect which does not have any pending deployment.\n* `Pending` - There is pending configuration which is yet to be deployed on the fabric interconnect.\n* `Deploying` - Pending configuration is being deployed on the fabric interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricElementIdentity.PartialDeploymentStatusEnum PartialDeploymentStatus
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
        /// <para type="description">"A reference to a networkElement resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public NetworkElementRelationship ReplacementTarget
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Replacement type specifies whether it is single FI or domain replacement.\n* `None` - The default action is none.\n* `Individual` - Replacement of single network element.\n* `Domain` - Domain indicates the replacement of Fabric Interconnect domain."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricElementIdentity.ReplacementTypeEnum ReplacementType
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The serial number of the equipment."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Serial
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
        /// <para type="description">"Switch Identifier that uniquely represents the fabric object.\n* `A` - Switch Identifier of Fabric Interconnect A.\n* `B` - Switch Identifier of Fabric Interconnect B."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricElementIdentity.SwitchIdEnum SwitchId
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The manufacturer of the equipment."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Vendor
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricEthNetworkControlPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricEthNetworkControlPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricEthNetworkControlPolicy : GetCmdletBase
    {
        public GetIntersightFabricEthNetworkControlPolicy()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricEthNetworkControlPolicyListWithHttpInfo";
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
        /// <para type="description">"Enables the CDP on an interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool CdpEnabled
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
        /// <para type="description">"Determines if the MAC forging is allowed or denied on an interface.\n* `allow` - Allows mac forging on an interface.\n* `deny` - Denies mac forging on an interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricEthNetworkControlPolicy.ForgeMacEnum ForgeMac
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Determines the MAC addresses that have to be registered with the switch.\n* `nativeVlanOnly` - Register only the MAC addresses learnt on the native VLAN.\n* `allVlans` - Register all the MAC addresses learnt on all the allowed VLANs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricEthNetworkControlPolicy.MacRegistrationModeEnum MacRegistrationMode
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
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Determines the state of the virtual interface (vethernet / vfc) on the switch when a suitable uplink is not pinned.\n* `linkDown` - The vethernet will go down in case a suitable uplink is not pinned.\n* `warning` - The vethernet will remain up even if a suitable uplink is not pinned."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricEthNetworkControlPolicy.UplinkFailActionEnum UplinkFailAction
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricEthNetworkControlPolicyInventory.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricEthNetworkControlPolicyInventory", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricEthNetworkControlPolicyInventory : GetCmdletBase
    {
        public GetIntersightFabricEthNetworkControlPolicyInventory()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricEthNetworkControlPolicyInventoryListWithHttpInfo";
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
        /// <para type="description">"Enables the CDP on an interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool CdpEnabled
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
        /// <para type="description">"Determines if the MAC forging is allowed or denied on an interface.\n* `allow` - Allows mac forging on an interface.\n* `deny` - Denies mac forging on an interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricEthNetworkControlPolicyInventory.ForgeMacEnum ForgeMac
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Determines the MAC addresses that have to be registered with the switch.\n* `nativeVlanOnly` - Register only the MAC addresses learnt on the native VLAN.\n* `allVlans` - Register all the MAC addresses learnt on all the allowed VLANs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricEthNetworkControlPolicyInventory.MacRegistrationModeEnum MacRegistrationMode
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
        /// <para type="description">"Determines the state of the virtual interface (vethernet / vfc) on the switch when a suitable uplink is not pinned.\n* `linkDown` - The vethernet will go down in case a suitable uplink is not pinned.\n* `warning` - The vethernet will remain up even if a suitable uplink is not pinned."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricEthNetworkControlPolicyInventory.UplinkFailActionEnum UplinkFailAction
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricEthNetworkGroupPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricEthNetworkGroupPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricEthNetworkGroupPolicy : GetCmdletBase
    {
        public GetIntersightFabricEthNetworkGroupPolicy()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricEthNetworkGroupPolicyListWithHttpInfo";
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
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }





    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricEthNetworkGroupPolicyInventory.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricEthNetworkGroupPolicyInventory", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricEthNetworkGroupPolicyInventory : GetCmdletBase
    {
        public GetIntersightFabricEthNetworkGroupPolicyInventory()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricEthNetworkGroupPolicyInventoryListWithHttpInfo";
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




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricEthNetworkPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricEthNetworkPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricEthNetworkPolicy : GetCmdletBase
    {
        public GetIntersightFabricEthNetworkPolicy()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricEthNetworkPolicyListWithHttpInfo";
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
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricFcNetworkPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricFcNetworkPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricFcNetworkPolicy : GetCmdletBase
    {
        public GetIntersightFabricFcNetworkPolicy()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricFcNetworkPolicyListWithHttpInfo";
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
        /// <para type="description">"Enable or Disable Trunking on all of configured FC uplink ports."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool EnableTrunking
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
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricFcStorageRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricFcStorageRole", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricFcStorageRole : GetCmdletBase
    {
        public GetIntersightFabricFcStorageRole()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricFcStorageRoleListWithHttpInfo";
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
        /// <para type="description">"Admin configured speed for the port.\n* `16Gbps` - Admin configurable speed 16Gbps.\n* `8Gbps` - Admin configurable speed 8Gbps.\n* `32Gbps` - Admin configurable speed 32Gbps.\n* `64Gbps` - Admin configurable speed 64Gbps.\n* `Auto` - Admin configurable speed AUTO ( default )."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricFcStorageRole.AdminSpeedEnum AdminSpeed
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Breakout port Identifier of the Switch Interface.\nWhen a port is not configured as a breakout port, the aggregatePortId is set to 0, and unused.\nWhen a port is configured as a breakout port, the 'aggregatePortId' port number as labeled on the equipment,\ne.g. the id of the port on the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long AggregatePortId
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
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Port Identifier of the Switch/FEX/Chassis Interface.\nWhen a port is not configured as a breakout port, the portId is the port number as labeled on the equipment,\ne.g. the id of the port on the switch, FEX or chassis.\nWhen a port is configured as a breakout port, the 'portId' represents the port id on the fanout side of the breakout cable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidateRange(1, 108)]
        public long PortId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricPortPolicyRelationship PortPolicy
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
        /// <para type="description">"Slot Identifier of the Switch/FEX/Chassis Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidateRange(1, 5)]
        public long SlotId
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The user defined label assigned to a Port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^[ !#$%\\s+&\\(\\)\\*\\+,\\-\\./:;\\?@\\[\\]_\\{\\|\\}~a-zA-Z0-9]*$")]
        public string UserLabel
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Virtual San Identifier associated to the FC port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidateRange(1, 4093)]
        public long VsanId
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricFcUplinkPcRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricFcUplinkPcRole", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricFcUplinkPcRole : GetCmdletBase
    {
        public GetIntersightFabricFcUplinkPcRole()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricFcUplinkPcRoleListWithHttpInfo";
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
        /// <para type="description">"Admin configured speed for the port.\n* `16Gbps` - Admin configurable speed 16Gbps.\n* `8Gbps` - Admin configurable speed 8Gbps.\n* `32Gbps` - Admin configurable speed 32Gbps.\n* `64Gbps` - Admin configurable speed 64Gbps.\n* `Auto` - Admin configurable speed AUTO ( default )."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricFcUplinkPcRole.AdminSpeedEnum AdminSpeed
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
        /// <para type="description">"Fill pattern to differentiate the configs in NPIV.\n* `Idle` - Fc Fill Pattern type Idle.\n* `Arbff` - Fc Fill Pattern type Arbff."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricFcUplinkPcRole.FillPatternEnum FillPattern
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
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Unique Identifier of the port-channel, local to this switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidateRange(1, 256)]
        public long PcId
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricPortPolicyRelationship PortPolicy
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
        /// <para type="description">"The user defined label assigned to the a Port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^[ !#$%\\s+&\\(\\)\\*\\+,\\-\\./:;\\?@\\[\\]_\\{\\|\\}~a-zA-Z0-9]*$")]
        public string UserLabel
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Virtual San Identifier associated to the FC port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidateRange(1, 4093)]
        public long VsanId
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricFcUplinkRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricFcUplinkRole", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricFcUplinkRole : GetCmdletBase
    {
        public GetIntersightFabricFcUplinkRole()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricFcUplinkRoleListWithHttpInfo";
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
        /// <para type="description">"Admin configured speed for the port.\n* `16Gbps` - Admin configurable speed 16Gbps.\n* `8Gbps` - Admin configurable speed 8Gbps.\n* `32Gbps` - Admin configurable speed 32Gbps.\n* `64Gbps` - Admin configurable speed 64Gbps.\n* `Auto` - Admin configurable speed AUTO ( default )."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricFcUplinkRole.AdminSpeedEnum AdminSpeed
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Breakout port Identifier of the Switch Interface.\nWhen a port is not configured as a breakout port, the aggregatePortId is set to 0, and unused.\nWhen a port is configured as a breakout port, the 'aggregatePortId' port number as labeled on the equipment,\ne.g. the id of the port on the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long AggregatePortId
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
        /// <para type="description">"Fill pattern to differentiate the configs in NPIV.\n* `Idle` - Fc Fill Pattern type Idle.\n* `Arbff` - Fc Fill Pattern type Arbff."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricFcUplinkRole.FillPatternEnum FillPattern
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
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Port Identifier of the Switch/FEX/Chassis Interface.\nWhen a port is not configured as a breakout port, the portId is the port number as labeled on the equipment,\ne.g. the id of the port on the switch, FEX or chassis.\nWhen a port is configured as a breakout port, the 'portId' represents the port id on the fanout side of the breakout cable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidateRange(1, 108)]
        public long PortId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricPortPolicyRelationship PortPolicy
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
        /// <para type="description">"Slot Identifier of the Switch/FEX/Chassis Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidateRange(1, 5)]
        public long SlotId
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The user defined label assigned to a Port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^[ !#$%\\s+&\\(\\)\\*\\+,\\-\\./:;\\?@\\[\\]_\\{\\|\\}~a-zA-Z0-9]*$")]
        public string UserLabel
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Virtual San Identifier associated to the FC port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidateRange(1, 4093)]
        public long VsanId
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricFcZonePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricFcZonePolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricFcZonePolicy : GetCmdletBase
    {
        public GetIntersightFabricFcZonePolicy()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricFcZonePolicyListWithHttpInfo";
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
        /// <para type="description">"Type of FC zoning. Allowed values are SIST, SIMT and None.\n* `SIST` - The system automatically creates one zone for each vHBA and storage port pair. Each zone has two members.\n* `SIMT` - The system automatically creates one zone for each vHBA. Configure this type of zoning if the number of zones created is likely to exceed the maximum supported number of zones.\n* `None` - FC zoning is not configured."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricFcZonePolicy.FcTargetZoningTypeEnum FcTargetZoningType
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
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricFcoeUplinkPcRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricFcoeUplinkPcRole", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricFcoeUplinkPcRole : GetCmdletBase
    {
        public GetIntersightFabricFcoeUplinkPcRole()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricFcoeUplinkPcRoleListWithHttpInfo";
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
        /// <para type="description">"Admin configured speed for the port.\n* `Auto` - Admin configurable speed AUTO ( default ).\n* `1Gbps` - Admin configurable speed 1Gbps.\n* `10Gbps` - Admin configurable speed 10Gbps.\n* `25Gbps` - Admin configurable speed 25Gbps.\n* `40Gbps` - Admin configurable speed 40Gbps.\n* `100Gbps` - Admin configurable speed 100Gbps.\n* `NegAuto25Gbps` - Admin configurable 25Gbps auto negotiation for ports and port-channels.Speed is applicable on Ethernet Uplink, Ethernet Appliance and FCoE Uplink port and port-channel roles.This speed config is only applicable to non-breakout ports on UCS-FI-6454 and UCS-FI-64108."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricFcoeUplinkPcRole.AdminSpeedEnum AdminSpeed
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
        /// <para type="description">"Forward error correction configuration for Fcoe Uplink Port Channel member ports.\n* `Auto` - Forward error correction option 'Auto'. Supported speeds are Auto, 1Gbps, 10Gbps, 25Gbps, 40Gbps and 100 Gbps.\n* `Cl91` - Forward error correction option 'cl91'. Supported speeds are 25Gbps and 100 Gbps.\n* `Cl74` - Forward error correction option 'cl74'. Supported speeds are 25Gbps.\n* `rs-cons16` - Forward error correction option \"rs-cons16\". Supported speeds are 25Gbps.\n* `rs-ieee` - Forward error correction option \"rs-ieee\". Supported speeds are 25Gbps.\n* `Off` - Turn off forward error correction. Supported speeds are 25Gbps and 100 Gbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricFcoeUplinkPcRole.FecEnum Fec
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricLinkAggregationPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricLinkAggregationPolicyRelationship LinkAggregationPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricLinkControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricLinkControlPolicyRelationship LinkControlPolicy
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
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Unique Identifier of the port-channel, local to this switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidateRange(1, 256)]
        public long PcId
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricPortPolicyRelationship PortPolicy
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
        /// <para type="description">"The user defined label assigned to the a Port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^[ !#$%\\s+&\\(\\)\\*\\+,\\-\\./:;\\?@\\[\\]_\\{\\|\\}~a-zA-Z0-9]*$")]
        public string UserLabel
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricFcoeUplinkRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricFcoeUplinkRole", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricFcoeUplinkRole : GetCmdletBase
    {
        public GetIntersightFabricFcoeUplinkRole()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricFcoeUplinkRoleListWithHttpInfo";
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
        /// <para type="description">"Admin configured speed for the port.\n* `Auto` - Admin configurable speed AUTO ( default ).\n* `1Gbps` - Admin configurable speed 1Gbps.\n* `10Gbps` - Admin configurable speed 10Gbps.\n* `25Gbps` - Admin configurable speed 25Gbps.\n* `40Gbps` - Admin configurable speed 40Gbps.\n* `100Gbps` - Admin configurable speed 100Gbps.\n* `NegAuto25Gbps` - Admin configurable 25Gbps auto negotiation for ports and port-channels.Speed is applicable on Ethernet Uplink, Ethernet Appliance and FCoE Uplink port and port-channel roles.This speed config is only applicable to non-breakout ports on UCS-FI-6454 and UCS-FI-64108."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricFcoeUplinkRole.AdminSpeedEnum AdminSpeed
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Breakout port Identifier of the Switch Interface.\nWhen a port is not configured as a breakout port, the aggregatePortId is set to 0, and unused.\nWhen a port is configured as a breakout port, the 'aggregatePortId' port number as labeled on the equipment,\ne.g. the id of the port on the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long AggregatePortId
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
        /// <para type="description">"Forward error correction configuration for the port.\n* `Auto` - Forward error correction option 'Auto'. Supported speeds are Auto, 1Gbps, 10Gbps, 25Gbps, 40Gbps and 100 Gbps.\n* `Cl91` - Forward error correction option 'cl91'. Supported speeds are 25Gbps and 100 Gbps.\n* `Cl74` - Forward error correction option 'cl74'. Supported speeds are 25Gbps.\n* `rs-cons16` - Forward error correction option \"rs-cons16\". Supported speeds are 25Gbps.\n* `rs-ieee` - Forward error correction option \"rs-ieee\". Supported speeds are 25Gbps.\n* `Off` - Turn off forward error correction. Supported speeds are 25Gbps and 100 Gbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricFcoeUplinkRole.FecEnum Fec
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricLinkControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricLinkControlPolicyRelationship LinkControlPolicy
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
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Port Identifier of the Switch/FEX/Chassis Interface.\nWhen a port is not configured as a breakout port, the portId is the port number as labeled on the equipment,\ne.g. the id of the port on the switch, FEX or chassis.\nWhen a port is configured as a breakout port, the 'portId' represents the port id on the fanout side of the breakout cable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidateRange(1, 108)]
        public long PortId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricPortPolicyRelationship PortPolicy
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
        /// <para type="description">"Slot Identifier of the Switch/FEX/Chassis Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidateRange(1, 5)]
        public long SlotId
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The user defined label assigned to a Port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^[ !#$%\\s+&\\(\\)\\*\\+,\\-\\./:;\\?@\\[\\]_\\{\\|\\}~a-zA-Z0-9]*$")]
        public string UserLabel
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricFlowControlPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricFlowControlPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricFlowControlPolicy : GetCmdletBase
    {
        public GetIntersightFabricFlowControlPolicy()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricFlowControlPolicyListWithHttpInfo";
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
        /// <para type="description">"Configure the Priority Flow Control (PFC) for each port to enable the no-drop behavior for the CoS defined by the System QoS Policy and an Ethernet QoS policy. If Auto and On is selected for PFC, the Receive and Send link level flow control will be Off.\n* `auto` - Enables the no-drop CoS values to be advertised by the DCBXP and negotiated with the peer.A successful negotiation enables PFC on the no-drop CoS.Any failures because of a mismatch in the capability of peers causes the PFC not to be enabled.\n* `on` - Enables PFC on the local port regardless of the capability of the peers.\n* `off` - Disable PFC on the local port regardless of the capability of the peers."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricFlowControlPolicy.PriorityFlowControlModeEnum PriorityFlowControlMode
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Link-level Flow Control configured in the receive direction.\n* `Disabled` - Admin configured Disabled State.\n* `Enabled` - Admin configured Enabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricFlowControlPolicy.ReceiveDirectionEnum ReceiveDirection
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Link-level Flow Control configured in the send direction.\n* `Disabled` - Admin configured Disabled State.\n* `Enabled` - Admin configured Enabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricFlowControlPolicy.SendDirectionEnum SendDirection
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




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricLanPinGroup.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricLanPinGroup", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricLanPinGroup : GetCmdletBase
    {
        public GetIntersightFabricLanPinGroup()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricLanPinGroupListWithHttpInfo";
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
        /// <para type="description">"Name of the Pingroup for static pinning."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
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
        /// <para type="description">"A reference to a fabricAbstractInterfaceRole resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricAbstractInterfaceRoleRelationship PinTargetInterfaceRole
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricPortPolicyRelationship PortPolicy
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




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricLinkAggregationPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricLinkAggregationPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricLinkAggregationPolicy : GetCmdletBase
    {
        public GetIntersightFabricLinkAggregationPolicy()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricLinkAggregationPolicyListWithHttpInfo";
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
        /// <para type="description">"Flag used to indicate whether LACP PDUs are to be sent 'fast', i.e., every 1 second.\n* `normal` - The expanded 4th generation UCS Fabric Interconnect with 108 ports.\n* `fast` - The standard 4th generation UCS Fabric Interconnect with 54 ports."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricLinkAggregationPolicy.LacpRateEnum LacpRate
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
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Flag tells the switch whether to suspend the port if it didn’t receive LACP PDU."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool SuspendIndividual
        {
            get;
            set;
        }




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricLinkControlPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricLinkControlPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricLinkControlPolicy : GetCmdletBase
    {
        public GetIntersightFabricLinkControlPolicy()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricLinkControlPolicyListWithHttpInfo";
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
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }





    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricMacSecPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricMacSecPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricMacSecPolicy : GetCmdletBase
    {
        public GetIntersightFabricMacSecPolicy()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricMacSecPolicyListWithHttpInfo";
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
        /// <para type="description">"Cipher suite to be used for MACsec encryption.\n* `GCM-AES-XPN-256` - An extended Cipher Suite of GCM-AES-256 used in MACsec (Media Access Control Security) that incorporates Extended Packet Numbering (XPN) for enhanced security and scalability.\n* `GCM-AES-128` - This Cipher Suite employs the Advanced Encryption Standard (AES) with a 128-bit key in Galois/Counter Mode, offering both encryption and authentication.\n* `GCM-AES-256` - This Cipher Suite utilizes Advanced Encryption Standard (AES) with a 256-bit key in Galois/Counter Mode, offering a higher level of security compared to GCM-AES-128 due to the larger key size.\n* `GCM-AES-XPN-128` - An extended Cipher Suite of GCM-AES-128  used in MACsec (Media Access Control Security) that incorporates Extended Packet Numbering (XPN) to enhance security and scalability."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricMacSecPolicy.CipherSuiteEnum CipherSuite
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The MACsec confidentiality offset specifies the number of bytes starting from the frame header. MACsec encrypts only the bytes after the offset in a frame.\n* `CONF-OFFSET-0` - A value of 0 means the entire ethernet frame is encrypted.\n* `CONF-OFFSET-30` - The first 30 bytes of the ethernet frame are not encrypted, and the rest of the frame is encrypted.\n* `CONF-OFFSET-50` - The first 50 bytes of the ethernet frame are not encrypted, and the rest of the frame is encrypted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricMacSecPolicy.ConfidentialityOffsetEnum ConfidentialityOffset
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
        /// <para type="description">"Configures inclusion of the optional integrity check value (ICV) indicator as part of the transmitted MACsec key agreement protocol data unit (PDU)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool IncludeIcvIndicator
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The key server is selected by comparing key-server priority values during MACsec key agreement (MKA) message exchange between peer devices. Valid values range from 0 to 255. The lower the value, the higher the chance it will be selected as the key server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long KeyServerPriority
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
        /// <para type="description">"Defines the size of the replay protection window. It determines the number of packets that can be received out of order without being considered replay attacks."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long ReplayWindowSize
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Time in seconds to force secure association key (SAK) rekey. Valid range is from 60 to 2592000 seconds when configured. When not configured, the SAK rekey interval is determined based on the interface speed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long SakExpiryTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The security policy specifies the level of MACsec enforcement on network traffic passing through a given interface.\nShould secure allows unencrypted traffic to flow until the MACsec key agreement (MKA) session is secured. After the MKA session is secured, the policy switches to only allow encrypted traffic to flow. Must secure imposes only MACsec encrypted traffic to flow. Traffic will be dropped, until the MKA session is not secured.\n* `Should-secure` - Should secure allows unencrypted traffic to flow until the MACsec key agreement (MKA) session is secured. After the MKA session is secured, the policy switches to only allow encrypted traffic to flow.\n* `Must-secure` - Must secure imposes only MACsec encrypted traffic to flow. Traffic will be dropped, until the MKA session is not secured."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricMacSecPolicy.SecurityPolicyEnum SecurityPolicy
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




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricMulticastPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricMulticastPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricMulticastPolicy : GetCmdletBase
    {
        public GetIntersightFabricMulticastPolicy()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricMulticastPolicyListWithHttpInfo";
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
        /// <para type="description">"Used to define the IGMP Querier IP address."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string QuerierIpAddress
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Used to define the IGMP Querier IP address of the peer switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string QuerierIpAddressPeer
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Administrative state of the IGMP Querier for this VLAN.\n* `Disabled` - Admin configured Disabled State.\n* `Enabled` - Admin configured Enabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricMulticastPolicy.QuerierStateEnum QuerierState
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
        /// <para type="description">"Administrative state of the IGMP Snooping for this VLAN.\n* `Enabled` - Admin configured Enabled State.\n* `Disabled` - Admin configured Disabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricMulticastPolicy.SnoopingStateEnum SnoopingState
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Administrative state of the IGMP source IP proxy for this VLAN.\n* `Enabled` - Admin configured Enabled State.\n* `Disabled` - Admin configured Disabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricMulticastPolicy.SrcIpProxyEnum SrcIpProxy
        {
            get;
            set;
        }




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricPcMember.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricPcMember", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricPcMember : GetCmdletBase
    {
        public GetIntersightFabricPcMember()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricPcMemberListWithHttpInfo";
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
        /// <para type="description">"Breakout port Identifier of the Switch Interface.\nWhen a port is not configured as a breakout port, the aggregatePortId is set to 0, and unused.\nWhen a port is configured as a breakout port, the 'aggregatePortId' port number as labeled on the equipment,\ne.g. the id of the port on the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long AggregatePortId
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
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Port Channel Identifier for the collection of ports."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long PcId
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Port Identifier of the Switch/FEX/Chassis Interface.\nWhen a port is not configured as a breakout port, the portId is the port number as labeled on the equipment,\ne.g. the id of the port on the switch, FEX or chassis.\nWhen a port is configured as a breakout port, the 'portId' represents the port id on the fanout side of the breakout cable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long PortId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricPortPolicyRelationship PortPolicy
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
        /// <para type="description">"Slot Identifier of the Switch/FEX/Chassis Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long SlotId
        {
            get;
            set;
        }




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricPcOperation.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricPcOperation", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricPcOperation : GetCmdletBase
    {
        public GetIntersightFabricPcOperation()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricPcOperationListWithHttpInfo";
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
        /// <para type="description">"An operation that has to be perfomed on the port channel. Default value is None which means there will be no implicit port operation triggered.\n* `None` - No admin triggered action.\n* `SetUserLabel` - Admin triggered operation to set the user label on the port channel."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricPcOperation.AdminActionEnum AdminAction
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Admin configured state to disable the port channel.\n* `Enabled` - Admin configured Enabled State.\n* `Disabled` - Admin configured Disabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricPcOperation.AdminStateEnum AdminState
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The configured state of these settings in the target chassis. The value is any one of Applied, Applying, Failed. Applied - This state denotes that the admin state changes are applied successfully in the target FI domain. Applying - This state denotes that the admin state changes are being applied in the target FI domain. Failed - This state denotes that the admin state changes could not be applied in the target FI domain.\n* `None` - Nil value when no action has been triggered by the user.\n* `Applied` - User configured settings are in applied state.\n* `Applying` - User settings are being applied on the target server.\n* `Failed` - User configured settings could not be applied."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricPcOperation.ConfigStateEnum ConfigState
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
        /// <para type="description">"A reference to a networkElement resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public NetworkElementRelationship NetworkElement
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
        /// <para type="description">"Port Channel Identifier for the collection of ports."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long PcId
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
        /// <para type="description">"The user defined label assigned to the a Port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^[ !#$%\\s+&\\(\\)\\*\\+,\\-\\./:;\\?@\\[\\]_\\{\\|\\}~a-zA-Z0-9]*$")]
        public string UserLabel
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricPortMode.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricPortMode", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricPortMode : GetCmdletBase
    {
        public GetIntersightFabricPortMode()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricPortModeListWithHttpInfo";
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
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Custom Port Mode specified for the port range.\n* `FibreChannel` - Fibre Channel Port Types.\n* `BreakoutEthernet10G` - Breakout Ethernet 10G Port Type.\n* `BreakoutEthernet25G` - Breakout Ethernet 25G Port Type.\n* `BreakoutFibreChannel8G` - Breakout FibreChannel 8G Port Type.\n* `BreakoutFibreChannel16G` - Breakout FibreChannel 16G Port Type.\n* `BreakoutFibreChannel32G` - Breakout FibreChannel 32G Port Type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricPortMode.CustomModeEnum CustomMode
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
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Ending range of the Port Identifier."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long PortIdEnd
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Starting range of the Port Identifier."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long PortIdStart
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricPortPolicyRelationship PortPolicy
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
        /// <para type="description">"Slot Identifier of the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long SlotId
        {
            get;
            set;
        }




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricPortOperation.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricPortOperation", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricPortOperation : GetCmdletBase
    {
        public GetIntersightFabricPortOperation()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricPortOperationListWithHttpInfo";
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
        /// <para type="description">"An operation that has to be perfomed on the switch or IOM port. Default value is None which means there will be no implicit port operation triggered.\n* `None` - No admin triggered action.\n* `ResetServerPortConfiguration` - Admin triggered operation to reset the server port to its original configuration.\n* `SetUserLabel` - Admin triggered operation to set the user label on the port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricPortOperation.AdminActionEnum AdminAction
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Admin configured state to disable the port.\n* `Enabled` - Admin configured Enabled State.\n* `Disabled` - Admin configured Disabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricPortOperation.AdminStateEnum AdminState
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Breakout port Identifier of the Switch Interface.\nWhen a port is not configured as a breakout port, the aggregatePortId is set to 0, and unused.\nWhen a port is configured as a breakout port, the 'aggregatePortId' port number as labeled on the equipment,\ne.g. the id of the port on the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long AggregatePortId
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The configured state of these settings in the target chassis. The value is any one of Applied, Applying, Failed. Applied - This state denotes that the admin state changes are applied successfully in the target FI domain. Applying - This state denotes that the admin state changes are being applied in the target FI domain. Failed - This state denotes that the admin state changes could not be applied in the target FI domain.\n* `None` - Nil value when no action has been triggered by the user.\n* `Applied` - User configured settings are in applied state.\n* `Applying` - User settings are being applied on the target server.\n* `Failed` - User configured settings could not be applied."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricPortOperation.ConfigStateEnum ConfigState
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
        /// <para type="description">"FEX/IOM identifier to denote its Host ports in the format - FexId/SlotId/PortId."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long FexId
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
        /// <para type="description">"A reference to a networkElement resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public NetworkElementRelationship NetworkElement
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
        /// <para type="description">"Port Identifier of the Switch/FEX/Chassis Interface.\nWhen a port is not configured as a breakout port, the portId is the port number as labeled on the equipment,\ne.g. the id of the port on the switch, FEX or chassis.\nWhen a port is configured as a breakout port, the 'portId' represents the port id on the fanout side of the breakout cable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long PortId
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
        /// <para type="description">"Slot Identifier of the Switch/FEX/Chassis Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long SlotId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Name of the switch on which the port operation is performed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SwitchName
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The user defined label assigned to the a Port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^[ !#$%\\s+&\\(\\)\\*\\+,\\-\\./:;\\?@\\[\\]_\\{\\|\\}~a-zA-Z0-9]*$")]
        public string UserLabel
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricPortPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricPortPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricPortPolicy : GetCmdletBase
    {
        public GetIntersightFabricPortPolicy()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricPortPolicyListWithHttpInfo";
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
        /// <para type="description">"This field specifies the device model that this Port Policy is being configured for.\n* `UCS-FI-6454` - The standard 4th generation UCS Fabric Interconnect with 54 ports.\n* `UCS-FI-64108` - The expanded 4th generation UCS Fabric Interconnect with 108 ports.\n* `UCS-FI-6536` - The standard 5th generation UCS Fabric Interconnect with 36 ports.\n* `UCSX-S9108-100G` - Cisco UCS Fabric Interconnect 9108 100G with 8 ports.\n* `UCS-FI-6664` - The standard 6th generation UCS Fabric Interconnect with 64 ports.\n* `unknown` - Unknown device type, usage is TBD."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricPortPolicy.DeviceModelEnum DeviceModel
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
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricSanPinGroup.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricSanPinGroup", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricSanPinGroup : GetCmdletBase
    {
        public GetIntersightFabricSanPinGroup()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricSanPinGroupListWithHttpInfo";
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
        /// <para type="description">"Name of the Pingroup for static pinning."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
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
        /// <para type="description">"A reference to a fabricAbstractInterfaceRole resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricAbstractInterfaceRoleRelationship PinTargetInterfaceRole
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricPortPolicyRelationship PortPolicy
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




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricServerRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricServerRole", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricServerRole : GetCmdletBase
    {
        public GetIntersightFabricServerRole()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricServerRoleListWithHttpInfo";
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
        /// <para type="description">"Breakout port Identifier of the Switch Interface.\nWhen a port is not configured as a breakout port, the aggregatePortId is set to 0, and unused.\nWhen a port is configured as a breakout port, the 'aggregatePortId' port number as labeled on the equipment,\ne.g. the id of the port on the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long AggregatePortId
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Auto negotiation configuration for server port. This configuration is required only for FEX Model N9K-C93180YC-FX3 connected with 100G speed port on UCS-FI-6536 and should be set as True."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool AutoNegotiationDisabled
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
        /// <para type="description">"Forward error correction configuration for server port. This configuration is required only for FEX Model N9K-C93180YC-FX3 connected with 25G speed ports on UCS-FI-6454/UCS-FI-64108 and should be set as Cl74.\n* `Auto` - Forward error correction option 'Auto'. Supported speeds are Auto, 1Gbps, 10Gbps, 25Gbps, 40Gbps and 100 Gbps.\n* `Cl91` - Forward error correction option 'cl91'. Supported speeds are 25Gbps and 100 Gbps.\n* `Cl74` - Forward error correction option 'cl74'. Supported speeds are 25Gbps.\n* `rs-cons16` - Forward error correction option \"rs-cons16\". Supported speeds are 25Gbps.\n* `rs-ieee` - Forward error correction option \"rs-ieee\". Supported speeds are 25Gbps.\n* `Off` - Turn off forward error correction. Supported speeds are 25Gbps and 100 Gbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricServerRole.FecEnum Fec
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
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Port Identifier of the Switch/FEX/Chassis Interface.\nWhen a port is not configured as a breakout port, the portId is the port number as labeled on the equipment,\ne.g. the id of the port on the switch, FEX or chassis.\nWhen a port is configured as a breakout port, the 'portId' represents the port id on the fanout side of the breakout cable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidateRange(1, 108)]
        public long PortId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricPortPolicyRelationship PortPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Preferred device ID to be configured by user for the connected device. This ID must be specified together with the 'PreferredDeviceType' property. This ID will only takes effect if the actual connected device matches the 'PreferredDeviceType'. If the preferred ID is not available, the ID is automatically allocated and assigned by the system. If different preferred IDs are specified for the ports connected to the same device, only the preferred ID (if specified) of the port that is discovered first will be considered."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long PreferredDeviceId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Device type for which preferred ID to be configured. If the actual connected device does not match the specified device type, the system ignores the 'PreferredDeviceId' property.\n* `Auto` - Preferred Id will be ignored if specified with this type.\n* `RackServer` - Connected device type is Rack Unit Server.\n* `Chassis` - Connected device type is Chassis."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricServerRole.PreferredDeviceTypeEnum PreferredDeviceType
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
        /// <para type="description">"Slot Identifier of the Switch/FEX/Chassis Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidateRange(1, 5)]
        public long SlotId
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The user defined label assigned to a Port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^[ !#$%\\s+&\\(\\)\\*\\+,\\-\\./:;\\?@\\[\\]_\\{\\|\\}~a-zA-Z0-9]*$")]
        public string UserLabel
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricSpanDestEthPort.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricSpanDestEthPort", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricSpanDestEthPort : GetCmdletBase
    {
        public GetIntersightFabricSpanDestEthPort()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricSpanDestEthPortListWithHttpInfo";
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
        /// <para type="description">"Admin speed of the SPAN Destination Port.\n* `Auto` - Admin configurable speed AUTO ( default ).\n* `1Gbps` - Admin configurable speed 1Gbps.\n* `10Gbps` - Admin configurable speed 10Gbps.\n* `25Gbps` - Admin configurable speed 25Gbps.\n* `40Gbps` - Admin configurable speed 40Gbps.\n* `100Gbps` - Admin configurable speed 100Gbps.\n* `NegAuto25Gbps` - Admin configurable 25Gbps auto negotiation for ports and port-channels.Speed is applicable on Ethernet Uplink, Ethernet Appliance and FCoE Uplink port and port-channel roles.This speed config is only applicable to non-breakout ports on UCS-FI-6454 and UCS-FI-64108."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricSpanDestEthPort.AdminSpeedEnum AdminSpeed
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Breakout port Identifier of the Switch Interface.\nWhen a port is not configured as a breakout port, the aggregatePortId is set to 0, and unused.\nWhen a port is configured as a breakout port, the 'aggregatePortId' port number as labeled on the equipment,\ne.g. the id of the port on the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long AggregatePortId
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
        /// <para type="description">"Forward error correction setting of the SPAN Destination Port.\n* `Auto` - Forward error correction option 'Auto'. Supported speeds are Auto, 1Gbps, 10Gbps, 25Gbps, 40Gbps and 100 Gbps.\n* `Cl91` - Forward error correction option 'cl91'. Supported speeds are 25Gbps and 100 Gbps.\n* `Cl74` - Forward error correction option 'cl74'. Supported speeds are 25Gbps.\n* `rs-cons16` - Forward error correction option \"rs-cons16\". Supported speeds are 25Gbps.\n* `rs-ieee` - Forward error correction option \"rs-ieee\". Supported speeds are 25Gbps.\n* `Off` - Turn off forward error correction. Supported speeds are 25Gbps and 100 Gbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricSpanDestEthPort.FecEnum Fec
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
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a inventoryInterface resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public InventoryInterfaceRelationship PhysicalPort
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Port Identifier of the Switch Interface.\nWhen a port is not configured as a breakout port, the portId is the port number as labeled on the equipment,\ne.g. the id of the port on the switch, FEX or chassis.\nWhen a port is configured as a breakout port, the 'portId' represents the port id on the fanout side of the breakout cable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long PortId
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
        /// <para type="description">"Slot Identifier of the Switch Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long SlotId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricSpanSession resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricSpanSessionRelationship SpanSession
        {
            get;
            set;
        }




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricSpanSession.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricSpanSession", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricSpanSession : GetCmdletBase
    {
        public GetIntersightFabricSpanSession()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricSpanSessionListWithHttpInfo";
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
        /// <para type="description">"Admin state to enable or disable the SPAN session.\n* `Disabled` - Admin configured Disabled State.\n* `Enabled` - Admin configured Enabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricSpanSession.AdminStateEnum AdminState
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The configured state of SPAN configuration. If the configuration fails to deploy to the Fabric Interconnect, it can be redeployed by toggling the admin state.\n* `None` - Nil value when no action has been triggered by the user.\n* `Applied` - User configured settings are in applied state.\n* `Applying` - User settings are being applied on the target server.\n* `Failed` - User configured settings could not be applied."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricSpanSession.ConfigStateEnum ConfigState
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
        /// <para type="description">"Name of the SPAN session. The name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.) or an underscore (_)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a networkElement resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public NetworkElementRelationship NetworkElement
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Operational state of the SPAN session.\n* `Unknown` - SPAN session operational state is Unknown.\n* `Up` - SPAN session operational state is Up.\n* `Down` - SPAN session operational state is Down.\n* `Error` - SPAN session operational state is Error."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricSpanSession.OperStateEnum OperState
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Operational state reason of the SPAN session.\n* `Unknown` - Unknown operational state.\n* `Active` - Active and operational SPAN session.\n* `NoHardwareResource` - No hardware resources available.\n* `NoOperationalSrcDst` - No operational SPAN source or destination.\n* `GenericError` - Generic operational error.\n* `NoSourcesConfigured` - No source interfaces configured.\n* `NoDestinationConfigured` - No destination port configured.\n* `NoSourceDestinationConfigured` - No source or destination interface configured.\n* `SessionAdminShut` - Session is administratively disabled.\n* `WrongDestinationMode` - Wrong Destination mode configured.\n* `WrongSourceMode` - Wrong Source mode configured.\n* `TunnelMisconfDown` - Tunnel Misconfigured or Down.\n* `NoFlowIdSpecified` - No Flow ID specified for ERSPAN."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricSpanSession.OperStateReasonEnum OperStateReason
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
        /// <para type="description">"Session ID identifies the SPAN session on the Fabric Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long SessionId
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
        /// <para type="description">"Count of total number of sources in the SPAN session."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long SourceCount
        {
            get;
            set;
        }





        // <summary>
        /// <para type="description">"Admin state to enable or disable spanning control packets.\n* `Disabled` - Admin configured Disabled State.\n* `Enabled` - Admin configured Enabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricSpanSession.SpanControlPacketsEnum SpanControlPackets
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Switch ID (A or B) corresponding to network element.\n* `A` - Switch Identifier of Fabric Interconnect A.\n* `B` - Switch Identifier of Fabric Interconnect B."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricSpanSession.SwitchIdEnum SwitchId
        {
            get;
            set;
        }




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricSpanSourceEthPort.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricSpanSourceEthPort", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricSpanSourceEthPort : GetCmdletBase
    {
        public GetIntersightFabricSpanSourceEthPort()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricSpanSourceEthPortListWithHttpInfo";
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
        /// <para type="description">"Breakout port Identifier of the Switch Interface.\nWhen a port is not configured as a breakout port, the aggregatePortId is set to 0, and unused.\nWhen a port is configured as a breakout port, the 'aggregatePortId' port number as labeled on the equipment,\ne.g. the id of the port on the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long AggregatePortId
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
        /// <para type="description">"Direction of the source SPAN.\n* `Receive` - SPAN incoming traffic on the SPAN source interface.\n* `Transmit` - SPAN outgoing traffic on the SPAN source interface.\n* `Both` - SPAN incoming and outgoing traffic on the SPAN source interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricSpanSourceEthPort.DirectionEnum Direction
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
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a inventoryInterface resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public InventoryInterfaceRelationship PhysicalPort
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Port Identifier of the Switch Interface.\nWhen a port is not configured as a breakout port, the portId is the port number as labeled on the equipment,\ne.g. the id of the port on the switch, FEX or chassis.\nWhen a port is configured as a breakout port, the 'portId' represents the port id on the fanout side of the breakout cable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long PortId
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
        /// <para type="description">"Slot Identifier of the Switch Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long SlotId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Role of the port configured as SPAN source.\n* `Uplink` - Uplink Role corresponding to PortRole in PortPolicy.\n* `FcoeUplink` - FcoeUplink Role corresponding to PortRole in PortPolicy.\n* `FcUplink` - FcoeUplink Role corresponding to PortRole in PortPolicy.\n* `Appliance` - FcoeUplink Role corresponding to PortRole in PortPolicy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricSpanSourceEthPort.SourceRoleEnum SourceRole
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricSpanSession resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricSpanSessionRelationship SpanSession
        {
            get;
            set;
        }




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricSpanSourceEthPortChannel.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricSpanSourceEthPortChannel", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricSpanSourceEthPortChannel : GetCmdletBase
    {
        public GetIntersightFabricSpanSourceEthPortChannel()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricSpanSourceEthPortChannelListWithHttpInfo";
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
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Direction of the source SPAN.\n* `Receive` - SPAN incoming traffic on the SPAN source interface.\n* `Transmit` - SPAN outgoing traffic on the SPAN source interface.\n* `Both` - SPAN incoming and outgoing traffic on the SPAN source interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricSpanSourceEthPortChannel.DirectionEnum Direction
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
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Port-channel ID of SPAN source."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long PcId
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a inventoryInterface resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public InventoryInterfaceRelationship PhysicalPortChannel
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
        /// <para type="description">"Role of the port-channel configured as SPAN source.\n* `Uplink` - Uplink Role corresponding to PortRole in PortPolicy.\n* `FcoeUplink` - FcoeUplink Role corresponding to PortRole in PortPolicy.\n* `FcUplink` - FcoeUplink Role corresponding to PortRole in PortPolicy.\n* `Appliance` - FcoeUplink Role corresponding to PortRole in PortPolicy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricSpanSourceEthPortChannel.SourceRoleEnum SourceRole
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricSpanSession resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricSpanSessionRelationship SpanSession
        {
            get;
            set;
        }




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricSpanSourceVlan.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricSpanSourceVlan", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricSpanSourceVlan : GetCmdletBase
    {
        public GetIntersightFabricSpanSourceVlan()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricSpanSourceVlanListWithHttpInfo";
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
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Direction of the source SPAN.\n* `Receive` - SPAN incoming traffic on the SPAN source interface.\n* `Transmit` - SPAN outgoing traffic on the SPAN source interface.\n* `Both` - SPAN incoming and outgoing traffic on the SPAN source interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricSpanSourceVlan.DirectionEnum Direction
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
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
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
        /// <para type="description">"A reference to a fabricSpanSession resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricSpanSessionRelationship SpanSession
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"SPAN source VLAN Identifier."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long VlanId
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricSpanSourceVnicEthIf.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricSpanSourceVnicEthIf", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricSpanSourceVnicEthIf : GetCmdletBase
    {
        public GetIntersightFabricSpanSourceVnicEthIf()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricSpanSourceVnicEthIfListWithHttpInfo";
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
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Direction of the source SPAN.\n* `Receive` - SPAN incoming traffic on the SPAN source interface.\n* `Transmit` - SPAN outgoing traffic on the SPAN source interface.\n* `Both` - SPAN incoming and outgoing traffic on the SPAN source interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricSpanSourceVnicEthIf.DirectionEnum Direction
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
        /// <para type="description">"Name of the VNIC referenced by vnic relationship. Vnic name is not updated if it gets updated by the user."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

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
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricSpanSession resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricSpanSessionRelationship SpanSession
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"VIF ID of the VNIC placed on Fabric Interconnect associated to the SPAN session."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long VifId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a vnicEthIf resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public VnicEthIfRelationship Vnic
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricSwitchClusterProfile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricSwitchClusterProfile", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricSwitchClusterProfile : GetCmdletBase
    {
        public GetIntersightFabricSwitchClusterProfile()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricSwitchClusterProfileListWithHttpInfo";
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
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Deploy status of the switch cluster profile indicating if deployment has been initiated on all the members of the cluster profile.\n* `None` - Switch profiles not deployed on either of the switches.\n* `Complete` - Both switch profiles of the cluster profile are deployed.\n* `Partial` - Only one of the switch profiles of the cluster profile is deployed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricSwitchClusterProfile.DeployStatusEnum DeployStatus
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Values indicating the switches on which the cluster profile has been deployed. 0 indicates that the profile has not been deployed on any switch, 1 indicates that the profile has been deployed on A, 2 indicates that it is deployed on B and 3 indicates that it is deployed on both.\n* `None` - Switch profiles not deployed on either of the fabric interconnects.\n* `A` - Switch profiles deployed only on fabric interconnect A.\n* `B` - Switch profiles deployed only on fabric interconnect B.\n* `AB` - Switch profiles deployed on both fabric interconnect A and B."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricSwitchClusterProfile.DeployedSwitchesEnum DeployedSwitches
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Description of the profile."</para>
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
        /// <para type="description">"Name of the profile instance or profile template."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^[a-zA-Z0-9_.-]{1,64}$")]
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
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a policyAbstractProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public PolicyAbstractProfileRelationship SrcTemplate
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Number of switch profiles that are part of this cluster profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long SwitchProfilesCount
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Defines the type of the profile. Accepted values are instance or template.\n* `instance` - The profile defines the configuration for a specific instance of a target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricSwitchClusterProfile.TypeEnum Type
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The user defined label assigned to the switch profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^[ !#$%&\\(\\)\\*\\+,\\-\\./:;\\?@\\[\\]_\\{\\|\\}~a-zA-Z0-9]*$")]
        public string UserLabel
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricSwitchClusterProfileTemplate.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricSwitchClusterProfileTemplate", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricSwitchClusterProfileTemplate : GetCmdletBase
    {
        public GetIntersightFabricSwitchClusterProfileTemplate()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricSwitchClusterProfileTemplateListWithHttpInfo";
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
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Description of the profile."</para>
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
        /// <para type="description">"Name of the profile instance or profile template."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^[a-zA-Z0-9_.-]{1,64}$")]
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
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a policyAbstractProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public PolicyAbstractProfileRelationship SrcTemplate
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Number of switch profiles that are part of this cluster profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long SwitchProfilesCount
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Defines the type of the profile. Accepted values are instance or template.\n* `instance` - The profile defines the configuration for a specific instance of a target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricSwitchClusterProfileTemplate.TypeEnum Type
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The count of switch cluster profiles derived from the template."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long Usage
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricSwitchControlPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricSwitchControlPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricSwitchControlPolicy : GetCmdletBase
    {
        public GetIntersightFabricSwitchControlPolicy()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricSwitchControlPolicyListWithHttpInfo";
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
        /// <para type="description">"Encrypts MACsec keys in type-6 format. If a MACsec key is already provided in a type-6 format, the primary key decrypts it."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^$|^[^\"\\s]{16,64}$")]
        public string AesPrimaryKey
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
        /// <para type="description">"Enable or Disable Ethernet End Host Switching Mode.\n* `end-host` - In end-host mode, the fabric interconnects appear to the upstream devices as end hosts with multiple links.In this mode, the switch does not run Spanning Tree Protocol and avoids loops by following a set of rules for traffic forwarding.In case of ethernet switching mode - Ethernet end-host mode is also known as Ethernet host virtualizer.\n* `switch` - In switch mode, the switch runs Spanning Tree Protocol to avoid loops, and broadcast and multicast packets are handled in the traditional way.This is the traditional switch mode."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricSwitchControlPolicy.EthernetSwitchingModeEnum EthernetSwitchingMode
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"When enabled, a Registered State Change Notification (RSCN) is sent to the VIC adapter when any member port within the fabric port-channel goes down and vHBA would reset to restore the connection immediately. When disabled (default), vHBA reset is done only when all the members of a fabric port-channel are down.\n* `Disabled` - Admin configured Disabled State.\n* `Enabled` - Admin configured Enabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricSwitchControlPolicy.FabricPcVhbaResetEnum FabricPcVhbaReset
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Enable or Disable FC End Host Switching Mode.\n* `end-host` - In end-host mode, the fabric interconnects appear to the upstream devices as end hosts with multiple links.In this mode, the switch does not run Spanning Tree Protocol and avoids loops by following a set of rules for traffic forwarding.In case of ethernet switching mode - Ethernet end-host mode is also known as Ethernet host virtualizer.\n* `switch` - In switch mode, the switch runs Spanning Tree Protocol to avoid loops, and broadcast and multicast packets are handled in the traditional way.This is the traditional switch mode."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricSwitchControlPolicy.FcSwitchingModeEnum FcSwitchingMode
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Indicates whether the value of the 'aesPrimaryKey' property has been set."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool IsAesPrimaryKeySet
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
        /// <para type="description">"The starting ID for VLANs reserved for internal use within the Fabric Interconnect. This VLAN ID is the starting ID of\na contiguous block of 128 VLANs that cannot be configured for user data.  This range of VLANs cannot be configured in\nVLAN policy.\nIf this property is not configured, VLAN range 3915 - 4042 is reserved for internal use by default."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidateRange(2, 3915)]
        public long ReservedVlanStartId
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
        /// <para type="description">"To enable or disable the VLAN port count optimization. This feature will always be enabled for\nCisco UCS Fabric Interconnect 9108 100G and also enabled on the IMM 6.x Bundle version and onwards."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool VlanPortOptimizationEnabled
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricSwitchProfile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricSwitchProfile", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricSwitchProfile : GetCmdletBase
    {
        public GetIntersightFabricSwitchProfile()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricSwitchProfileListWithHttpInfo";
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
        /// <para type="description">"User initiated action. Each profile type has its own supported actions. For HyperFlex cluster profile, the supported actions are -- Validate, Deploy, Continue, Retry, Abort, Unassign For server profile, the support actions are -- Deploy, Unassign."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Action
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"A reference to a networkElement resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public NetworkElementRelationship AssignedSwitch
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a networkElement resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public NetworkElementRelationship AssociatedSwitch
        {
            get;
            set;
        }





        // <summary>
        /// <para type="description">"A reference to a fabricConfigResult resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricConfigResultRelationship ConfigResult
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
        /// <para type="description">"Description of the profile."</para>
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
        /// <para type="description">"Name of the profile instance or profile template."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^[a-zA-Z0-9_.-]{1,64}$")]
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
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a policyAbstractProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public PolicyAbstractProfileRelationship SrcTemplate
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricSwitchClusterProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricSwitchClusterProfileRelationship SwitchClusterProfile
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Value indicating the switch side on which the switch profile or template has to be deployed.\n* `None` - Switch side not defined for the policy configurations in the switch profile or template.\n* `A` - Policy configurations in the switch profile or template to be deployed on fabric interconnect A.\n* `B` - Policy configurations in the switch profile or template to be deployed on fabric interconnect B."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricSwitchProfile.SwitchIdEnum SwitchId
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Defines the type of the profile. Accepted values are instance or template.\n* `instance` - The profile defines the configuration for a specific instance of a target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricSwitchProfile.TypeEnum Type
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricSwitchProfileTemplate.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricSwitchProfileTemplate", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricSwitchProfileTemplate : GetCmdletBase
    {
        public GetIntersightFabricSwitchProfileTemplate()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricSwitchProfileTemplateListWithHttpInfo";
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
        /// <para type="description">"User initiated action. Each profile type has its own supported actions. For HyperFlex cluster profile, the supported actions are -- Validate, Deploy, Continue, Retry, Abort, Unassign For server profile, the support actions are -- Deploy, Unassign."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Action
        {
            get;
            set;
        }





        // <summary>
        /// <para type="description">"A reference to a fabricConfigResult resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricConfigResultRelationship ConfigResult
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
        /// <para type="description">"Description of the profile."</para>
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
        /// <para type="description">"Name of the profile instance or profile template."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^[a-zA-Z0-9_.-]{1,64}$")]
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
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a policyAbstractProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public PolicyAbstractProfileRelationship SrcTemplate
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricSwitchClusterProfileTemplate resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricSwitchClusterProfileTemplateRelationship SwitchClusterProfileTemplate
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Value indicating the switch side on which the switch profile or template has to be deployed.\n* `None` - Switch side not defined for the policy configurations in the switch profile or template.\n* `A` - Policy configurations in the switch profile or template to be deployed on fabric interconnect A.\n* `B` - Policy configurations in the switch profile or template to be deployed on fabric interconnect B."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricSwitchProfileTemplate.SwitchIdEnum SwitchId
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Defines the type of the profile. Accepted values are instance or template.\n* `instance` - The profile defines the configuration for a specific instance of a target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricSwitchProfileTemplate.TypeEnum Type
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricSystemQosPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricSystemQosPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricSystemQosPolicy : GetCmdletBase
    {
        public GetIntersightFabricSystemQosPolicy()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricSystemQosPolicyListWithHttpInfo";
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
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricUplinkPcRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricUplinkPcRole", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricUplinkPcRole : GetCmdletBase
    {
        public GetIntersightFabricUplinkPcRole()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricUplinkPcRoleListWithHttpInfo";
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
        /// <para type="description">"Admin configured speed for the port.\n* `Auto` - Admin configurable speed AUTO ( default ).\n* `1Gbps` - Admin configurable speed 1Gbps.\n* `10Gbps` - Admin configurable speed 10Gbps.\n* `25Gbps` - Admin configurable speed 25Gbps.\n* `40Gbps` - Admin configurable speed 40Gbps.\n* `100Gbps` - Admin configurable speed 100Gbps.\n* `NegAuto25Gbps` - Admin configurable 25Gbps auto negotiation for ports and port-channels.Speed is applicable on Ethernet Uplink, Ethernet Appliance and FCoE Uplink port and port-channel roles.This speed config is only applicable to non-breakout ports on UCS-FI-6454 and UCS-FI-64108."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricUplinkPcRole.AdminSpeedEnum AdminSpeed
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
        /// <para type="description">"Forward error correction configuration for Uplink Port Channel member ports.\n* `Auto` - Forward error correction option 'Auto'. Supported speeds are Auto, 1Gbps, 10Gbps, 25Gbps, 40Gbps and 100 Gbps.\n* `Cl91` - Forward error correction option 'cl91'. Supported speeds are 25Gbps and 100 Gbps.\n* `Cl74` - Forward error correction option 'cl74'. Supported speeds are 25Gbps.\n* `rs-cons16` - Forward error correction option \"rs-cons16\". Supported speeds are 25Gbps.\n* `rs-ieee` - Forward error correction option \"rs-ieee\". Supported speeds are 25Gbps.\n* `Off` - Turn off forward error correction. Supported speeds are 25Gbps and 100 Gbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricUplinkPcRole.FecEnum Fec
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricFlowControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricFlowControlPolicyRelationship FlowControlPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricLinkAggregationPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricLinkAggregationPolicyRelationship LinkAggregationPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricLinkControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricLinkControlPolicyRelationship LinkControlPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricMacSecPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricMacSecPolicyRelationship MacSecPolicy
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
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Unique Identifier of the port-channel, local to this switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidateRange(1, 256)]
        public long PcId
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricPortPolicyRelationship PortPolicy
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
        /// <para type="description">"The user defined label assigned to the a Port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^[ !#$%\\s+&\\(\\)\\*\\+,\\-\\./:;\\?@\\[\\]_\\{\\|\\}~a-zA-Z0-9]*$")]
        public string UserLabel
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricUplinkRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricUplinkRole", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricUplinkRole : GetCmdletBase
    {
        public GetIntersightFabricUplinkRole()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricUplinkRoleListWithHttpInfo";
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
        /// <para type="description">"Admin configured speed for the port.\n* `Auto` - Admin configurable speed AUTO ( default ).\n* `1Gbps` - Admin configurable speed 1Gbps.\n* `10Gbps` - Admin configurable speed 10Gbps.\n* `25Gbps` - Admin configurable speed 25Gbps.\n* `40Gbps` - Admin configurable speed 40Gbps.\n* `100Gbps` - Admin configurable speed 100Gbps.\n* `NegAuto25Gbps` - Admin configurable 25Gbps auto negotiation for ports and port-channels.Speed is applicable on Ethernet Uplink, Ethernet Appliance and FCoE Uplink port and port-channel roles.This speed config is only applicable to non-breakout ports on UCS-FI-6454 and UCS-FI-64108."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricUplinkRole.AdminSpeedEnum AdminSpeed
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Breakout port Identifier of the Switch Interface.\nWhen a port is not configured as a breakout port, the aggregatePortId is set to 0, and unused.\nWhen a port is configured as a breakout port, the 'aggregatePortId' port number as labeled on the equipment,\ne.g. the id of the port on the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long AggregatePortId
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
        /// <para type="description">"Forward error correction configuration for the port.\n* `Auto` - Forward error correction option 'Auto'. Supported speeds are Auto, 1Gbps, 10Gbps, 25Gbps, 40Gbps and 100 Gbps.\n* `Cl91` - Forward error correction option 'cl91'. Supported speeds are 25Gbps and 100 Gbps.\n* `Cl74` - Forward error correction option 'cl74'. Supported speeds are 25Gbps.\n* `rs-cons16` - Forward error correction option \"rs-cons16\". Supported speeds are 25Gbps.\n* `rs-ieee` - Forward error correction option \"rs-ieee\". Supported speeds are 25Gbps.\n* `Off` - Turn off forward error correction. Supported speeds are 25Gbps and 100 Gbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricUplinkRole.FecEnum Fec
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricFlowControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricFlowControlPolicyRelationship FlowControlPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricLinkControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricLinkControlPolicyRelationship LinkControlPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricMacSecPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricMacSecPolicyRelationship MacSecPolicy
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
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Port Identifier of the Switch/FEX/Chassis Interface.\nWhen a port is not configured as a breakout port, the portId is the port number as labeled on the equipment,\ne.g. the id of the port on the switch, FEX or chassis.\nWhen a port is configured as a breakout port, the 'portId' represents the port id on the fanout side of the breakout cable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidateRange(1, 108)]
        public long PortId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricPortPolicyRelationship PortPolicy
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
        /// <para type="description">"Slot Identifier of the Switch/FEX/Chassis Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidateRange(1, 5)]
        public long SlotId
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The user defined label assigned to a Port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^[ !#$%\\s+&\\(\\)\\*\\+,\\-\\./:;\\?@\\[\\]_\\{\\|\\}~a-zA-Z0-9]*$")]
        public string UserLabel
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricVlan.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricVlan", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricVlan : GetCmdletBase
    {
        public GetIntersightFabricVlan()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricVlanListWithHttpInfo";
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
        /// <para type="description">"Enable to automatically allow this VLAN on all uplinks. Disable must be specified for Disjoint Layer 2 VLAN configuration. Default VLAN-1 cannot be configured as Disjoint Layer 2 VLAN."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool AutoAllowOnUplinks
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
        /// <para type="description">"A reference to a fabricEthNetworkPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricEthNetworkPolicyRelationship EthNetworkPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Used to define whether this VLAN is to be classified as 'native' for traffic in this FI."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool IsNative
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
        /// <para type="description">"A reference to a fabricMulticastPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricMulticastPolicyRelationship MulticastPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The 'name' used to identify this VLAN."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

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
        /// <para type="description">"The Primary VLAN ID of the VLAN, if the sharing type of the VLAN is Isolated or Community."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long PrimaryVlanId
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
        /// <para type="description">"The sharing type of this VLAN.\n* `None` - This represents a regular VLAN.\n* `Primary` - This represents a primary VLAN.\n* `Isolated` - This represents an isolated VLAN.\n* `Community` - This represents a community VLAN."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricVlan.SharingTypeEnum SharingType
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The identifier for this Virtual LAN."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidateRange(1, 4093)]
        public long VlanId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricVlanSet resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricVlanSetRelationship VlanSet
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricVlanInventory.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricVlanInventory", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricVlanInventory : GetCmdletBase
    {
        public GetIntersightFabricVlanInventory()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricVlanInventoryListWithHttpInfo";
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
        /// <para type="description">"Admin State of the VLAN attribute in the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AdminState
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
        /// <para type="description">"Name of the VLAN Inventory for the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Name
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a networkElement resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public NetworkElementRelationship NetworkElement
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
        /// <para type="description">"Ports associated to the VLAN."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Port
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
        /// <para type="description">"Status of the VLAN attribute in the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Status
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The Identifier for VLAN in the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string VlanId
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricVlanSet.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricVlanSet", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricVlanSet : GetCmdletBase
    {
        public GetIntersightFabricVlanSet()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricVlanSetListWithHttpInfo";
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
        /// <para type="description">"Used to determine whether this VLAN will be allowed on all uplink ports and PCs in this FI."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool AutoAllowOnUplinks
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
        /// <para type="description">"A reference to a fabricEthNetworkPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricEthNetworkPolicyRelationship EthNetworkPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Used to define whether this VLAN is to be classified as 'native' for traffic in this FI."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool IsNative
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
        /// <para type="description">"A reference to a fabricMulticastPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricMulticastPolicyRelationship MulticastPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The 'name' used to identify this VLAN."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

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
        /// <para type="description">"The Primary VLAN ID of the VLAN, if the sharing type of the VLAN is Isolated or Community."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long PrimaryVlanId
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
        /// <para type="description">"The sharing type of this VLAN.\n* `None` - This represents a regular VLAN.\n* `Primary` - This represents a primary VLAN.\n* `Isolated` - This represents an isolated VLAN.\n* `Community` - This represents a community VLAN."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricVlanSet.SharingTypeEnum SharingType
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"Set of VLANs defined by VLAN object with identical configuration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^$|^((\\d+\\-\\d+)|(\\d+))(,((\\d+\\-\\d+)|(\\d+)))*$")]
        public string Vlans
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricVsan.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricVsan", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricVsan : GetCmdletBase
    {
        public GetIntersightFabricVsan()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricVsanListWithHttpInfo";
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
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Enables or Disables the default zoning state.\n* `Enabled` - Admin configured Enabled State.\n* `Disabled` - Admin configured Disabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricVsan.DefaultZoningEnum DefaultZoning
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
        /// <para type="description">"A reference to a fabricFcNetworkPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public FabricFcNetworkPolicyRelationship FcNetworkPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Logical grouping mode for fc ports."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string FcZoneSharingMode
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"FCOE Vlan associated to the VSAN configuration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidateRange(1, 4093)]
        public long FcoeVlan
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
        /// <para type="description">"User given name for the VSAN configuration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

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
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"Virtual San Identifier in the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidateRange(1, 4093)]
        public long VsanId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Used to indicate whether the VSAN Id is defined for storage or uplink or both traffics in FI.\n* `Uplink` - Vsan associated with uplink network.\n* `Storage` - Vsan associated with storage network.\n* `Common` - Vsan that is common for uplink and storage network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricVsan.VsanScopeEnum VsanScope
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricVsanInventory.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricVsanInventory", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricVsanInventory : GetCmdletBase
    {
        public GetIntersightFabricVsanInventory()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricVsanInventoryListWithHttpInfo";
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
        /// <para type="description">"Admin state of the VSAN. It can be active or inactive.\n* `` - Default value to represent the administrative state of isolated vsan.\n* `Up` - VSAN administrative state is up.\n* `Down` - VSAN administrative state is down."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricVsanInventory.AdminStateEnum AdminState
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
        /// <para type="description">"Interoperability mode of the VSAN. It enables products of multiple vendors to communicate with each other.\n* `` - Default value to represent the interoperability mode of isolated vsan when it is not configured.\n* `Default` - Default mode for a VSAN that is communicating between a SAN composed entirely of MDS 9000 switches.\n* `1` - Allows integration with Brocade and McData switches that have been configured for their own interoperability modes. Brocade and McData switches must be running in interop mode to work with this VSAN mode.\n* `2` - Allows seamless integration with specific Brocade switches running in their own native mode of operation.\n* `3` - Allows seamless integration with Brocade switches that contains more than 16 ports.\n* `4` - Allows seamless integration between MDS VSANs and McData switches running in McData Fabric 1.0 interop mode."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricVsanInventory.InteropModeEnum InteropMode
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"These attributes indicate the use of the source-destination ID or the originator exchange OX ID for load balancing path selection.\n* `` - Default value to represent the load balancing scheme of isolated vsan.\n* `src-id/dst-id` - Directs the switch to use the source and destination ID for its path selection process.\n* `src-id/dst-id/oxid` - Directs the switch to use the source ID, the destination ID, and the OX ID for its path selection process."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricVsanInventory.LoadBalancingEnum LoadBalancing
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
        /// <para type="description">"User-specified name of the VSAN."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Name
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a networkElement resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public NetworkElementRelationship NetworkElement
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Operational state of the VSAN.\n* `` - Default value to represent the operational state of isolated vsan.\n* `Up` - VSAN operational state is up.\n* `Down` - VSAN operational state is down."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricVsanInventory.OperStateEnum OperState
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
        /// <para type="description">"Smart zoning status on the VSAN. It can be enabled or disabled.\n* `` - Default value to represent the smart zoning status of isolated vsan.\n* `Enabled` - VSAN smart zoning state is enabled.\n* `Disabled` - VSAN smart zoning state is disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public FabricVsanInventory.SmartZoningEnum SmartZoning
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"Identifier for the VSAN. It is an integer from 1 to 4094."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long VsanId
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricAppliancePcRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricAppliancePcRole")]
    public class NewIntersightFabricAppliancePcRole : NewCmdletBase
    {
        public NewIntersightFabricAppliancePcRole()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricAppliancePcRole();
            MethodName = "CreateFabricAppliancePcRoleWithHttpInfo";
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
        /// <para type="description">"Admin configured speed for the port channel.\n* `Auto` - Admin configurable speed AUTO ( default ).\n* `1Gbps` - Admin configurable speed 1Gbps.\n* `10Gbps` - Admin configurable speed 10Gbps.\n* `25Gbps` - Admin configurable speed 25Gbps.\n* `40Gbps` - Admin configurable speed 40Gbps.\n* `100Gbps` - Admin configurable speed 100Gbps.\n* `NegAuto25Gbps` - Admin configurable 25Gbps auto negotiation for ports and port-channels.Speed is applicable on Ethernet Uplink, Ethernet Appliance and FCoE Uplink port and port-channel roles.This speed config is only applicable to non-breakout ports on UCS-FI-6454 and UCS-FI-64108."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricAppliancePcRole.AdminSpeedEnum AdminSpeed
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"A reference to a fabricEthNetworkControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricEthNetworkControlPolicyRelationship EthNetworkControlPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricEthNetworkGroupPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricEthNetworkGroupPolicyRelationship EthNetworkGroupPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Forward error correction configuration for Appliance Port Channel member ports.\n* `Auto` - Forward error correction option 'Auto'. Supported speeds are Auto, 1Gbps, 10Gbps, 25Gbps, 40Gbps and 100 Gbps.\n* `Cl91` - Forward error correction option 'cl91'. Supported speeds are 25Gbps and 100 Gbps.\n* `Cl74` - Forward error correction option 'cl74'. Supported speeds are 25Gbps.\n* `rs-cons16` - Forward error correction option \"rs-cons16\". Supported speeds are 25Gbps.\n* `rs-ieee` - Forward error correction option \"rs-ieee\". Supported speeds are 25Gbps.\n* `Off` - Turn off forward error correction. Supported speeds are 25Gbps and 100 Gbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricAppliancePcRole.FecEnum Fec
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricLinkAggregationPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricLinkAggregationPolicyRelationship LinkAggregationPolicy
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Port mode to be set on the appliance port-channel.\n* `trunk` - Trunk Mode Switch Port Type.\n* `access` - Access Mode Switch Port Type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricAppliancePcRole.ModeEnum Mode
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
        /// <para type="description">"Unique Identifier of the port-channel, local to this switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 256)]
        public long PcId
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricPortPolicyRelationship PortPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FabricPortIdentifier> Ports
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The 'name' of the System QoS Class.\n* `Best Effort` - QoS Priority for Best-effort traffic.\n* `FC` - QoS Priority for FC traffic.\n* `Platinum` - QoS Priority for Platinum traffic.\n* `Gold` - QoS Priority for Gold traffic.\n* `Silver` - QoS Priority for Silver traffic.\n* `Bronze` - QoS Priority for Bronze traffic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricAppliancePcRole.PriorityEnum Priority
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
        /// <para type="description">"The user defined label assigned to the a Port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[ !#$%\\s+&\\(\\)\\*\\+,\\-\\./:;\\?@\\[\\]_\\{\\|\\}~a-zA-Z0-9]*$")]
        public string UserLabel
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricApplianceRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricApplianceRole")]
    public class NewIntersightFabricApplianceRole : NewCmdletBase
    {
        public NewIntersightFabricApplianceRole()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricApplianceRole();
            MethodName = "CreateFabricApplianceRoleWithHttpInfo";
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
        /// <para type="description">"Admin configured speed for the port.\n* `Auto` - Admin configurable speed AUTO ( default ).\n* `1Gbps` - Admin configurable speed 1Gbps.\n* `10Gbps` - Admin configurable speed 10Gbps.\n* `25Gbps` - Admin configurable speed 25Gbps.\n* `40Gbps` - Admin configurable speed 40Gbps.\n* `100Gbps` - Admin configurable speed 100Gbps.\n* `NegAuto25Gbps` - Admin configurable 25Gbps auto negotiation for ports and port-channels.Speed is applicable on Ethernet Uplink, Ethernet Appliance and FCoE Uplink port and port-channel roles.This speed config is only applicable to non-breakout ports on UCS-FI-6454 and UCS-FI-64108."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricApplianceRole.AdminSpeedEnum AdminSpeed
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Breakout port Identifier of the Switch Interface.\nWhen a port is not configured as a breakout port, the aggregatePortId is set to 0, and unused.\nWhen a port is configured as a breakout port, the 'aggregatePortId' port number as labeled on the equipment,\ne.g. the id of the port on the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long AggregatePortId
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"A reference to a fabricEthNetworkControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricEthNetworkControlPolicyRelationship EthNetworkControlPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricEthNetworkGroupPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricEthNetworkGroupPolicyRelationship EthNetworkGroupPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Forward error correction configuration for the port.\n* `Auto` - Forward error correction option 'Auto'. Supported speeds are Auto, 1Gbps, 10Gbps, 25Gbps, 40Gbps and 100 Gbps.\n* `Cl91` - Forward error correction option 'cl91'. Supported speeds are 25Gbps and 100 Gbps.\n* `Cl74` - Forward error correction option 'cl74'. Supported speeds are 25Gbps.\n* `rs-cons16` - Forward error correction option \"rs-cons16\". Supported speeds are 25Gbps.\n* `rs-ieee` - Forward error correction option \"rs-ieee\". Supported speeds are 25Gbps.\n* `Off` - Turn off forward error correction. Supported speeds are 25Gbps and 100 Gbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricApplianceRole.FecEnum Fec
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricFlowControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricFlowControlPolicyRelationship FlowControlPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricLinkControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricLinkControlPolicyRelationship LinkControlPolicy
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Port mode to be set on the appliance port.\n* `trunk` - Trunk Mode Switch Port Type.\n* `access` - Access Mode Switch Port Type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricApplianceRole.ModeEnum Mode
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
        /// <para type="description">"Port Identifier of the Switch/FEX/Chassis Interface.\nWhen a port is not configured as a breakout port, the portId is the port number as labeled on the equipment,\ne.g. the id of the port on the switch, FEX or chassis.\nWhen a port is configured as a breakout port, the 'portId' represents the port id on the fanout side of the breakout cable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 108)]
        public long PortId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricPortPolicyRelationship PortPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The 'name' of the System QoS Class.\n* `Best Effort` - QoS Priority for Best-effort traffic.\n* `FC` - QoS Priority for FC traffic.\n* `Platinum` - QoS Priority for Platinum traffic.\n* `Gold` - QoS Priority for Gold traffic.\n* `Silver` - QoS Priority for Silver traffic.\n* `Bronze` - QoS Priority for Bronze traffic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricApplianceRole.PriorityEnum Priority
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Slot Identifier of the Switch/FEX/Chassis Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 5)]
        public long SlotId
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
        /// <para type="description">"The user defined label assigned to a Port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[ !#$%\\s+&\\(\\)\\*\\+,\\-\\./:;\\?@\\[\\]_\\{\\|\\}~a-zA-Z0-9]*$")]
        public string UserLabel
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricEstimateImpact.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricEstimateImpact")]
    public class NewIntersightFabricEstimateImpact : NewCmdletBase
    {
        public NewIntersightFabricEstimateImpact()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricEstimateImpact();
            MethodName = "CreateFabricEstimateImpactWithHttpInfo";
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
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"A reference to a fabricSwitchProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricSwitchProfileRelationship Profile
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricEthNetworkControlPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricEthNetworkControlPolicy")]
    public class NewIntersightFabricEthNetworkControlPolicy : NewCmdletBase
    {
        public NewIntersightFabricEthNetworkControlPolicy()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricEthNetworkControlPolicy();
            MethodName = "CreateFabricEthNetworkControlPolicyWithHttpInfo";
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
        /// <para type="description">"Enables the CDP on an interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool CdpEnabled
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
        /// <para type="description">"Determines if the MAC forging is allowed or denied on an interface.\n* `allow` - Allows mac forging on an interface.\n* `deny` - Denies mac forging on an interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricEthNetworkControlPolicy.ForgeMacEnum ForgeMac
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Determines the LLDP setting on an interface on the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricLldpSettings LldpSettings
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Determines the MAC addresses that have to be registered with the switch.\n* `nativeVlanOnly` - Register only the MAC addresses learnt on the native VLAN.\n* `allVlans` - Register all the MAC addresses learnt on all the allowed VLANs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricEthNetworkControlPolicy.MacRegistrationModeEnum MacRegistrationMode
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
        /// <para type="description">"An array of relationships to vnicEthNetworkPolicy resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<VnicEthNetworkPolicyRelationship> NetworkPolicy
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Determines the state of the virtual interface (vethernet / vfc) on the switch when a suitable uplink is not pinned.\n* `linkDown` - The vethernet will go down in case a suitable uplink is not pinned.\n* `warning` - The vethernet will remain up even if a suitable uplink is not pinned."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricEthNetworkControlPolicy.UplinkFailActionEnum UplinkFailAction
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricEthNetworkGroupPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricEthNetworkGroupPolicy")]
    public class NewIntersightFabricEthNetworkGroupPolicy : NewCmdletBase
    {
        public NewIntersightFabricEthNetworkGroupPolicy()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricEthNetworkGroupPolicy();
            MethodName = "CreateFabricEthNetworkGroupPolicyWithHttpInfo";
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"VLAN configuration for the virtual interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricVlanSettings VlanSettings
        {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricEthNetworkPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricEthNetworkPolicy")]
    public class NewIntersightFabricEthNetworkPolicy : NewCmdletBase
    {
        public NewIntersightFabricEthNetworkPolicy()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricEthNetworkPolicy();
            MethodName = "CreateFabricEthNetworkPolicyWithHttpInfo";
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
        /// <para type="description">"An array of relationships to fabricBaseSwitchProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FabricBaseSwitchProfileRelationship> Profiles
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricFcNetworkPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricFcNetworkPolicy")]
    public class NewIntersightFabricFcNetworkPolicy : NewCmdletBase
    {
        public NewIntersightFabricFcNetworkPolicy()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricFcNetworkPolicy();
            MethodName = "CreateFabricFcNetworkPolicyWithHttpInfo";
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
        /// <para type="description">"Enable or Disable Trunking on all of configured FC uplink ports."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool EnableTrunking
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
        /// <para type="description">"An array of relationships to fabricBaseSwitchProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FabricBaseSwitchProfileRelationship> Profiles
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricFcStorageRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricFcStorageRole")]
    public class NewIntersightFabricFcStorageRole : NewCmdletBase
    {
        public NewIntersightFabricFcStorageRole()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricFcStorageRole();
            MethodName = "CreateFabricFcStorageRoleWithHttpInfo";
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
        /// <para type="description">"Admin configured speed for the port.\n* `16Gbps` - Admin configurable speed 16Gbps.\n* `8Gbps` - Admin configurable speed 8Gbps.\n* `32Gbps` - Admin configurable speed 32Gbps.\n* `64Gbps` - Admin configurable speed 64Gbps.\n* `Auto` - Admin configurable speed AUTO ( default )."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricFcStorageRole.AdminSpeedEnum AdminSpeed
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Breakout port Identifier of the Switch Interface.\nWhen a port is not configured as a breakout port, the aggregatePortId is set to 0, and unused.\nWhen a port is configured as a breakout port, the 'aggregatePortId' port number as labeled on the equipment,\ne.g. the id of the port on the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long AggregatePortId
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
        /// <para type="description">"Port Identifier of the Switch/FEX/Chassis Interface.\nWhen a port is not configured as a breakout port, the portId is the port number as labeled on the equipment,\ne.g. the id of the port on the switch, FEX or chassis.\nWhen a port is configured as a breakout port, the 'portId' represents the port id on the fanout side of the breakout cable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 108)]
        public long PortId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricPortPolicyRelationship PortPolicy
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Slot Identifier of the Switch/FEX/Chassis Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 5)]
        public long SlotId
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
        /// <para type="description">"The user defined label assigned to a Port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[ !#$%\\s+&\\(\\)\\*\\+,\\-\\./:;\\?@\\[\\]_\\{\\|\\}~a-zA-Z0-9]*$")]
        public string UserLabel
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Virtual San Identifier associated to the FC port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 4093)]
        public long VsanId
        {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricFcUplinkPcRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricFcUplinkPcRole")]
    public class NewIntersightFabricFcUplinkPcRole : NewCmdletBase
    {
        public NewIntersightFabricFcUplinkPcRole()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricFcUplinkPcRole();
            MethodName = "CreateFabricFcUplinkPcRoleWithHttpInfo";
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
        /// <para type="description">"Admin configured speed for the port.\n* `16Gbps` - Admin configurable speed 16Gbps.\n* `8Gbps` - Admin configurable speed 8Gbps.\n* `32Gbps` - Admin configurable speed 32Gbps.\n* `64Gbps` - Admin configurable speed 64Gbps.\n* `Auto` - Admin configurable speed AUTO ( default )."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricFcUplinkPcRole.AdminSpeedEnum AdminSpeed
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"Fill pattern to differentiate the configs in NPIV.\n* `Idle` - Fc Fill Pattern type Idle.\n* `Arbff` - Fc Fill Pattern type Arbff."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricFcUplinkPcRole.FillPatternEnum FillPattern
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
        /// <para type="description">"Unique Identifier of the port-channel, local to this switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 256)]
        public long PcId
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricPortPolicyRelationship PortPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FabricPortIdentifier> Ports
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
        /// <para type="description">"The user defined label assigned to the a Port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[ !#$%\\s+&\\(\\)\\*\\+,\\-\\./:;\\?@\\[\\]_\\{\\|\\}~a-zA-Z0-9]*$")]
        public string UserLabel
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Virtual San Identifier associated to the FC port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 4093)]
        public long VsanId
        {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricFcUplinkRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricFcUplinkRole")]
    public class NewIntersightFabricFcUplinkRole : NewCmdletBase
    {
        public NewIntersightFabricFcUplinkRole()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricFcUplinkRole();
            MethodName = "CreateFabricFcUplinkRoleWithHttpInfo";
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
        /// <para type="description">"Admin configured speed for the port.\n* `16Gbps` - Admin configurable speed 16Gbps.\n* `8Gbps` - Admin configurable speed 8Gbps.\n* `32Gbps` - Admin configurable speed 32Gbps.\n* `64Gbps` - Admin configurable speed 64Gbps.\n* `Auto` - Admin configurable speed AUTO ( default )."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricFcUplinkRole.AdminSpeedEnum AdminSpeed
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Breakout port Identifier of the Switch Interface.\nWhen a port is not configured as a breakout port, the aggregatePortId is set to 0, and unused.\nWhen a port is configured as a breakout port, the 'aggregatePortId' port number as labeled on the equipment,\ne.g. the id of the port on the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long AggregatePortId
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"Fill pattern to differentiate the configs in NPIV.\n* `Idle` - Fc Fill Pattern type Idle.\n* `Arbff` - Fc Fill Pattern type Arbff."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricFcUplinkRole.FillPatternEnum FillPattern
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
        /// <para type="description">"Port Identifier of the Switch/FEX/Chassis Interface.\nWhen a port is not configured as a breakout port, the portId is the port number as labeled on the equipment,\ne.g. the id of the port on the switch, FEX or chassis.\nWhen a port is configured as a breakout port, the 'portId' represents the port id on the fanout side of the breakout cable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 108)]
        public long PortId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricPortPolicyRelationship PortPolicy
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Slot Identifier of the Switch/FEX/Chassis Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 5)]
        public long SlotId
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
        /// <para type="description">"The user defined label assigned to a Port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[ !#$%\\s+&\\(\\)\\*\\+,\\-\\./:;\\?@\\[\\]_\\{\\|\\}~a-zA-Z0-9]*$")]
        public string UserLabel
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Virtual San Identifier associated to the FC port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 4093)]
        public long VsanId
        {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricFcZonePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricFcZonePolicy")]
    public class NewIntersightFabricFcZonePolicy : NewCmdletBase
    {
        public NewIntersightFabricFcZonePolicy()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricFcZonePolicy();
            MethodName = "CreateFabricFcZonePolicyWithHttpInfo";
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FabricFcZoneMember> FcTargetMembers
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Type of FC zoning. Allowed values are SIST, SIMT and None.\n* `SIST` - The system automatically creates one zone for each vHBA and storage port pair. Each zone has two members.\n* `SIMT` - The system automatically creates one zone for each vHBA. Configure this type of zoning if the number of zones created is likely to exceed the maximum supported number of zones.\n* `None` - FC zoning is not configured."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricFcZonePolicy.FcTargetZoningTypeEnum FcTargetZoningType
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricFcoeUplinkPcRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricFcoeUplinkPcRole")]
    public class NewIntersightFabricFcoeUplinkPcRole : NewCmdletBase
    {
        public NewIntersightFabricFcoeUplinkPcRole()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricFcoeUplinkPcRole();
            MethodName = "CreateFabricFcoeUplinkPcRoleWithHttpInfo";
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
        /// <para type="description">"Admin configured speed for the port.\n* `Auto` - Admin configurable speed AUTO ( default ).\n* `1Gbps` - Admin configurable speed 1Gbps.\n* `10Gbps` - Admin configurable speed 10Gbps.\n* `25Gbps` - Admin configurable speed 25Gbps.\n* `40Gbps` - Admin configurable speed 40Gbps.\n* `100Gbps` - Admin configurable speed 100Gbps.\n* `NegAuto25Gbps` - Admin configurable 25Gbps auto negotiation for ports and port-channels.Speed is applicable on Ethernet Uplink, Ethernet Appliance and FCoE Uplink port and port-channel roles.This speed config is only applicable to non-breakout ports on UCS-FI-6454 and UCS-FI-64108."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricFcoeUplinkPcRole.AdminSpeedEnum AdminSpeed
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"Forward error correction configuration for Fcoe Uplink Port Channel member ports.\n* `Auto` - Forward error correction option 'Auto'. Supported speeds are Auto, 1Gbps, 10Gbps, 25Gbps, 40Gbps and 100 Gbps.\n* `Cl91` - Forward error correction option 'cl91'. Supported speeds are 25Gbps and 100 Gbps.\n* `Cl74` - Forward error correction option 'cl74'. Supported speeds are 25Gbps.\n* `rs-cons16` - Forward error correction option \"rs-cons16\". Supported speeds are 25Gbps.\n* `rs-ieee` - Forward error correction option \"rs-ieee\". Supported speeds are 25Gbps.\n* `Off` - Turn off forward error correction. Supported speeds are 25Gbps and 100 Gbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricFcoeUplinkPcRole.FecEnum Fec
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricLinkAggregationPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricLinkAggregationPolicyRelationship LinkAggregationPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricLinkControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricLinkControlPolicyRelationship LinkControlPolicy
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
        /// <para type="description">"Unique Identifier of the port-channel, local to this switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 256)]
        public long PcId
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricPortPolicyRelationship PortPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FabricPortIdentifier> Ports
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
        /// <para type="description">"The user defined label assigned to the a Port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[ !#$%\\s+&\\(\\)\\*\\+,\\-\\./:;\\?@\\[\\]_\\{\\|\\}~a-zA-Z0-9]*$")]
        public string UserLabel
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricFcoeUplinkRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricFcoeUplinkRole")]
    public class NewIntersightFabricFcoeUplinkRole : NewCmdletBase
    {
        public NewIntersightFabricFcoeUplinkRole()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricFcoeUplinkRole();
            MethodName = "CreateFabricFcoeUplinkRoleWithHttpInfo";
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
        /// <para type="description">"Admin configured speed for the port.\n* `Auto` - Admin configurable speed AUTO ( default ).\n* `1Gbps` - Admin configurable speed 1Gbps.\n* `10Gbps` - Admin configurable speed 10Gbps.\n* `25Gbps` - Admin configurable speed 25Gbps.\n* `40Gbps` - Admin configurable speed 40Gbps.\n* `100Gbps` - Admin configurable speed 100Gbps.\n* `NegAuto25Gbps` - Admin configurable 25Gbps auto negotiation for ports and port-channels.Speed is applicable on Ethernet Uplink, Ethernet Appliance and FCoE Uplink port and port-channel roles.This speed config is only applicable to non-breakout ports on UCS-FI-6454 and UCS-FI-64108."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricFcoeUplinkRole.AdminSpeedEnum AdminSpeed
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Breakout port Identifier of the Switch Interface.\nWhen a port is not configured as a breakout port, the aggregatePortId is set to 0, and unused.\nWhen a port is configured as a breakout port, the 'aggregatePortId' port number as labeled on the equipment,\ne.g. the id of the port on the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long AggregatePortId
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"Forward error correction configuration for the port.\n* `Auto` - Forward error correction option 'Auto'. Supported speeds are Auto, 1Gbps, 10Gbps, 25Gbps, 40Gbps and 100 Gbps.\n* `Cl91` - Forward error correction option 'cl91'. Supported speeds are 25Gbps and 100 Gbps.\n* `Cl74` - Forward error correction option 'cl74'. Supported speeds are 25Gbps.\n* `rs-cons16` - Forward error correction option \"rs-cons16\". Supported speeds are 25Gbps.\n* `rs-ieee` - Forward error correction option \"rs-ieee\". Supported speeds are 25Gbps.\n* `Off` - Turn off forward error correction. Supported speeds are 25Gbps and 100 Gbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricFcoeUplinkRole.FecEnum Fec
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricLinkControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricLinkControlPolicyRelationship LinkControlPolicy
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
        /// <para type="description">"Port Identifier of the Switch/FEX/Chassis Interface.\nWhen a port is not configured as a breakout port, the portId is the port number as labeled on the equipment,\ne.g. the id of the port on the switch, FEX or chassis.\nWhen a port is configured as a breakout port, the 'portId' represents the port id on the fanout side of the breakout cable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 108)]
        public long PortId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricPortPolicyRelationship PortPolicy
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Slot Identifier of the Switch/FEX/Chassis Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 5)]
        public long SlotId
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
        /// <para type="description">"The user defined label assigned to a Port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[ !#$%\\s+&\\(\\)\\*\\+,\\-\\./:;\\?@\\[\\]_\\{\\|\\}~a-zA-Z0-9]*$")]
        public string UserLabel
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricFlowControlPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricFlowControlPolicy")]
    public class NewIntersightFabricFlowControlPolicy : NewCmdletBase
    {
        public NewIntersightFabricFlowControlPolicy()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricFlowControlPolicy();
            MethodName = "CreateFabricFlowControlPolicyWithHttpInfo";
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
        /// <para type="description">"Configure the Priority Flow Control (PFC) for each port to enable the no-drop behavior for the CoS defined by the System QoS Policy and an Ethernet QoS policy. If Auto and On is selected for PFC, the Receive and Send link level flow control will be Off.\n* `auto` - Enables the no-drop CoS values to be advertised by the DCBXP and negotiated with the peer.A successful negotiation enables PFC on the no-drop CoS.Any failures because of a mismatch in the capability of peers causes the PFC not to be enabled.\n* `on` - Enables PFC on the local port regardless of the capability of the peers.\n* `off` - Disable PFC on the local port regardless of the capability of the peers."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricFlowControlPolicy.PriorityFlowControlModeEnum PriorityFlowControlMode
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Link-level Flow Control configured in the receive direction.\n* `Disabled` - Admin configured Disabled State.\n* `Enabled` - Admin configured Enabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricFlowControlPolicy.ReceiveDirectionEnum ReceiveDirection
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Link-level Flow Control configured in the send direction.\n* `Disabled` - Admin configured Disabled State.\n* `Enabled` - Admin configured Enabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricFlowControlPolicy.SendDirectionEnum SendDirection
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricLanPinGroup.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricLanPinGroup")]
    public class NewIntersightFabricLanPinGroup : NewCmdletBase
    {
        public NewIntersightFabricLanPinGroup()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricLanPinGroup();
            MethodName = "CreateFabricLanPinGroupWithHttpInfo";
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
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Name of the Pingroup for static pinning."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"A reference to a fabricAbstractInterfaceRole resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricAbstractInterfaceRoleRelationship PinTargetInterfaceRole
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricPortPolicyRelationship PortPolicy
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricLinkAggregationPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricLinkAggregationPolicy")]
    public class NewIntersightFabricLinkAggregationPolicy : NewCmdletBase
    {
        public NewIntersightFabricLinkAggregationPolicy()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricLinkAggregationPolicy();
            MethodName = "CreateFabricLinkAggregationPolicyWithHttpInfo";
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
        /// <para type="description">"Flag used to indicate whether LACP PDUs are to be sent 'fast', i.e., every 1 second.\n* `normal` - The expanded 4th generation UCS Fabric Interconnect with 108 ports.\n* `fast` - The standard 4th generation UCS Fabric Interconnect with 54 ports."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricLinkAggregationPolicy.LacpRateEnum LacpRate
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
        /// <para type="description">"Flag tells the switch whether to suspend the port if it didn’t receive LACP PDU."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool SuspendIndividual
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricLinkControlPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricLinkControlPolicy")]
    public class NewIntersightFabricLinkControlPolicy : NewCmdletBase
    {
        public NewIntersightFabricLinkControlPolicy()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricLinkControlPolicy();
            MethodName = "CreateFabricLinkControlPolicyWithHttpInfo";
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"UDLD related configurations for the port and port-channel."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricUdldSettings UdldSettings
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricMacSecPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricMacSecPolicy")]
    public class NewIntersightFabricMacSecPolicy : NewCmdletBase
    {
        public NewIntersightFabricMacSecPolicy()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricMacSecPolicy();
            MethodName = "CreateFabricMacSecPolicyWithHttpInfo";
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
        /// <para type="description">"Cipher suite to be used for MACsec encryption.\n* `GCM-AES-XPN-256` - An extended Cipher Suite of GCM-AES-256 used in MACsec (Media Access Control Security) that incorporates Extended Packet Numbering (XPN) for enhanced security and scalability.\n* `GCM-AES-128` - This Cipher Suite employs the Advanced Encryption Standard (AES) with a 128-bit key in Galois/Counter Mode, offering both encryption and authentication.\n* `GCM-AES-256` - This Cipher Suite utilizes Advanced Encryption Standard (AES) with a 256-bit key in Galois/Counter Mode, offering a higher level of security compared to GCM-AES-128 due to the larger key size.\n* `GCM-AES-XPN-128` - An extended Cipher Suite of GCM-AES-128  used in MACsec (Media Access Control Security) that incorporates Extended Packet Numbering (XPN) to enhance security and scalability."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricMacSecPolicy.CipherSuiteEnum CipherSuite
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The MACsec confidentiality offset specifies the number of bytes starting from the frame header. MACsec encrypts only the bytes after the offset in a frame.\n* `CONF-OFFSET-0` - A value of 0 means the entire ethernet frame is encrypted.\n* `CONF-OFFSET-30` - The first 30 bytes of the ethernet frame are not encrypted, and the rest of the frame is encrypted.\n* `CONF-OFFSET-50` - The first 50 bytes of the ethernet frame are not encrypted, and the rest of the frame is encrypted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricMacSecPolicy.ConfidentialityOffsetEnum ConfidentialityOffset
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
        /// <para type="description">"Fallback keychain for managing an alternative set of security keys to be used when a secure session cannot be established using the primary keychain."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricSecKeyChain FallbackKeyChain
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Configures inclusion of the optional integrity check value (ICV) indicator as part of the transmitted MACsec key agreement protocol data unit (PDU)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IncludeIcvIndicator
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The key server is selected by comparing key-server priority values during MACsec key agreement (MKA) message exchange between peer devices. Valid values range from 0 to 255. The lower the value, the higher the chance it will be selected as the key server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long KeyServerPriority
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Extensible authentication protocol over LAN (EAPoL). MACsec transmits MACsec key agreement (MKA) protocol data units (PDUs) using EAPoL packets to establish a secure session."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricMacSecEaPol MacSecEaPol
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
        /// <para type="description">"Primary keychain for managing the default set of security keys for encryption and decryption."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricSecKeyChain PrimaryKeyChain
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Defines the size of the replay protection window. It determines the number of packets that can be received out of order without being considered replay attacks."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long ReplayWindowSize
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Time in seconds to force secure association key (SAK) rekey. Valid range is from 60 to 2592000 seconds when configured. When not configured, the SAK rekey interval is determined based on the interface speed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long SakExpiryTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The security policy specifies the level of MACsec enforcement on network traffic passing through a given interface.\nShould secure allows unencrypted traffic to flow until the MACsec key agreement (MKA) session is secured. After the MKA session is secured, the policy switches to only allow encrypted traffic to flow. Must secure imposes only MACsec encrypted traffic to flow. Traffic will be dropped, until the MKA session is not secured.\n* `Should-secure` - Should secure allows unencrypted traffic to flow until the MACsec key agreement (MKA) session is secured. After the MKA session is secured, the policy switches to only allow encrypted traffic to flow.\n* `Must-secure` - Must secure imposes only MACsec encrypted traffic to flow. Traffic will be dropped, until the MKA session is not secured."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricMacSecPolicy.SecurityPolicyEnum SecurityPolicy
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricMulticastPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricMulticastPolicy")]
    public class NewIntersightFabricMulticastPolicy : NewCmdletBase
    {
        public NewIntersightFabricMulticastPolicy()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricMulticastPolicy();
            MethodName = "CreateFabricMulticastPolicyWithHttpInfo";
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
        /// <para type="description">"Used to define the IGMP Querier IP address."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string QuerierIpAddress
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Used to define the IGMP Querier IP address of the peer switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string QuerierIpAddressPeer
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Administrative state of the IGMP Querier for this VLAN.\n* `Disabled` - Admin configured Disabled State.\n* `Enabled` - Admin configured Enabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricMulticastPolicy.QuerierStateEnum QuerierState
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Administrative state of the IGMP Snooping for this VLAN.\n* `Enabled` - Admin configured Enabled State.\n* `Disabled` - Admin configured Disabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricMulticastPolicy.SnoopingStateEnum SnoopingState
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Administrative state of the IGMP source IP proxy for this VLAN.\n* `Enabled` - Admin configured Enabled State.\n* `Disabled` - Admin configured Disabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricMulticastPolicy.SrcIpProxyEnum SrcIpProxy
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricPcOperation.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricPcOperation")]
    public class NewIntersightFabricPcOperation : NewCmdletBase
    {
        public NewIntersightFabricPcOperation()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricPcOperation();
            MethodName = "CreateFabricPcOperationWithHttpInfo";
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
        /// <para type="description">"An operation that has to be perfomed on the port channel. Default value is None which means there will be no implicit port operation triggered.\n* `None` - No admin triggered action.\n* `SetUserLabel` - Admin triggered operation to set the user label on the port channel."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricPcOperation.AdminActionEnum AdminAction
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Admin configured state to disable the port channel.\n* `Enabled` - Admin configured Enabled State.\n* `Disabled` - Admin configured Disabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricPcOperation.AdminStateEnum AdminState
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The configured state of these settings in the target chassis. The value is any one of Applied, Applying, Failed. Applied - This state denotes that the admin state changes are applied successfully in the target FI domain. Applying - This state denotes that the admin state changes are being applied in the target FI domain. Failed - This state denotes that the admin state changes could not be applied in the target FI domain.\n* `None` - Nil value when no action has been triggered by the user.\n* `Applied` - User configured settings are in applied state.\n* `Applying` - User settings are being applied on the target server.\n* `Failed` - User configured settings could not be applied."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricPcOperation.ConfigStateEnum ConfigState
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

        public NetworkElementRelationship NetworkElement
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"Port Channel Identifier for the collection of ports."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long PcId
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
        /// <para type="description">"The user defined label assigned to the a Port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[ !#$%\\s+&\\(\\)\\*\\+,\\-\\./:;\\?@\\[\\]_\\{\\|\\}~a-zA-Z0-9]*$")]
        public string UserLabel
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricPortMode.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricPortMode")]
    public class NewIntersightFabricPortMode : NewCmdletBase
    {
        public NewIntersightFabricPortMode()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricPortMode();
            MethodName = "CreateFabricPortModeWithHttpInfo";
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
        /// <para type="description">"Custom Port Mode specified for the port range.\n* `FibreChannel` - Fibre Channel Port Types.\n* `BreakoutEthernet10G` - Breakout Ethernet 10G Port Type.\n* `BreakoutEthernet25G` - Breakout Ethernet 25G Port Type.\n* `BreakoutFibreChannel8G` - Breakout FibreChannel 8G Port Type.\n* `BreakoutFibreChannel16G` - Breakout FibreChannel 16G Port Type.\n* `BreakoutFibreChannel32G` - Breakout FibreChannel 32G Port Type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricPortMode.CustomModeEnum CustomMode
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
        /// <para type="description">"Ending range of the Port Identifier."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long PortIdEnd
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Starting range of the Port Identifier."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long PortIdStart
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricPortPolicyRelationship PortPolicy
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Slot Identifier of the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long SlotId
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricPortOperation.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricPortOperation")]
    public class NewIntersightFabricPortOperation : NewCmdletBase
    {
        public NewIntersightFabricPortOperation()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricPortOperation();
            MethodName = "CreateFabricPortOperationWithHttpInfo";
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
        /// <para type="description">"An operation that has to be perfomed on the switch or IOM port. Default value is None which means there will be no implicit port operation triggered.\n* `None` - No admin triggered action.\n* `ResetServerPortConfiguration` - Admin triggered operation to reset the server port to its original configuration.\n* `SetUserLabel` - Admin triggered operation to set the user label on the port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricPortOperation.AdminActionEnum AdminAction
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Admin configured state to disable the port.\n* `Enabled` - Admin configured Enabled State.\n* `Disabled` - Admin configured Disabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricPortOperation.AdminStateEnum AdminState
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Breakout port Identifier of the Switch Interface.\nWhen a port is not configured as a breakout port, the aggregatePortId is set to 0, and unused.\nWhen a port is configured as a breakout port, the 'aggregatePortId' port number as labeled on the equipment,\ne.g. the id of the port on the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long AggregatePortId
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The configured state of these settings in the target chassis. The value is any one of Applied, Applying, Failed. Applied - This state denotes that the admin state changes are applied successfully in the target FI domain. Applying - This state denotes that the admin state changes are being applied in the target FI domain. Failed - This state denotes that the admin state changes could not be applied in the target FI domain.\n* `None` - Nil value when no action has been triggered by the user.\n* `Applied` - User configured settings are in applied state.\n* `Applying` - User settings are being applied on the target server.\n* `Failed` - User configured settings could not be applied."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricPortOperation.ConfigStateEnum ConfigState
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"FEX/IOM identifier to denote its Host ports in the format - FexId/SlotId/PortId."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long FexId
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

        public NetworkElementRelationship NetworkElement
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"Port Identifier of the Switch/FEX/Chassis Interface.\nWhen a port is not configured as a breakout port, the portId is the port number as labeled on the equipment,\ne.g. the id of the port on the switch, FEX or chassis.\nWhen a port is configured as a breakout port, the 'portId' represents the port id on the fanout side of the breakout cable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long PortId
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Slot Identifier of the Switch/FEX/Chassis Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long SlotId
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
        /// <para type="description">"The user defined label assigned to the a Port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[ !#$%\\s+&\\(\\)\\*\\+,\\-\\./:;\\?@\\[\\]_\\{\\|\\}~a-zA-Z0-9]*$")]
        public string UserLabel
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricPortPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricPortPolicy")]
    public class NewIntersightFabricPortPolicy : NewCmdletBase
    {
        public NewIntersightFabricPortPolicy()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricPortPolicy();
            MethodName = "CreateFabricPortPolicyWithHttpInfo";
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
        /// <para type="description">"This field specifies the device model that this Port Policy is being configured for.\n* `UCS-FI-6454` - The standard 4th generation UCS Fabric Interconnect with 54 ports.\n* `UCS-FI-64108` - The expanded 4th generation UCS Fabric Interconnect with 108 ports.\n* `UCS-FI-6536` - The standard 5th generation UCS Fabric Interconnect with 36 ports.\n* `UCSX-S9108-100G` - Cisco UCS Fabric Interconnect 9108 100G with 8 ports.\n* `UCS-FI-6664` - The standard 6th generation UCS Fabric Interconnect with 64 ports.\n* `unknown` - Unknown device type, usage is TBD."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricPortPolicy.DeviceModelEnum DeviceModel
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
        /// <para type="description">"An array of relationships to fabricBaseSwitchProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FabricBaseSwitchProfileRelationship> Profiles
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricSanPinGroup.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricSanPinGroup")]
    public class NewIntersightFabricSanPinGroup : NewCmdletBase
    {
        public NewIntersightFabricSanPinGroup()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricSanPinGroup();
            MethodName = "CreateFabricSanPinGroupWithHttpInfo";
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
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Name of the Pingroup for static pinning."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"A reference to a fabricAbstractInterfaceRole resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricAbstractInterfaceRoleRelationship PinTargetInterfaceRole
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricPortPolicyRelationship PortPolicy
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricServerRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricServerRole")]
    public class NewIntersightFabricServerRole : NewCmdletBase
    {
        public NewIntersightFabricServerRole()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricServerRole();
            MethodName = "CreateFabricServerRoleWithHttpInfo";
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
        /// <para type="description">"Breakout port Identifier of the Switch Interface.\nWhen a port is not configured as a breakout port, the aggregatePortId is set to 0, and unused.\nWhen a port is configured as a breakout port, the 'aggregatePortId' port number as labeled on the equipment,\ne.g. the id of the port on the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long AggregatePortId
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Auto negotiation configuration for server port. This configuration is required only for FEX Model N9K-C93180YC-FX3 connected with 100G speed port on UCS-FI-6536 and should be set as True."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool AutoNegotiationDisabled
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"Forward error correction configuration for server port. This configuration is required only for FEX Model N9K-C93180YC-FX3 connected with 25G speed ports on UCS-FI-6454/UCS-FI-64108 and should be set as Cl74.\n* `Auto` - Forward error correction option 'Auto'. Supported speeds are Auto, 1Gbps, 10Gbps, 25Gbps, 40Gbps and 100 Gbps.\n* `Cl91` - Forward error correction option 'cl91'. Supported speeds are 25Gbps and 100 Gbps.\n* `Cl74` - Forward error correction option 'cl74'. Supported speeds are 25Gbps.\n* `rs-cons16` - Forward error correction option \"rs-cons16\". Supported speeds are 25Gbps.\n* `rs-ieee` - Forward error correction option \"rs-ieee\". Supported speeds are 25Gbps.\n* `Off` - Turn off forward error correction. Supported speeds are 25Gbps and 100 Gbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricServerRole.FecEnum Fec
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
        /// <para type="description">"Port Identifier of the Switch/FEX/Chassis Interface.\nWhen a port is not configured as a breakout port, the portId is the port number as labeled on the equipment,\ne.g. the id of the port on the switch, FEX or chassis.\nWhen a port is configured as a breakout port, the 'portId' represents the port id on the fanout side of the breakout cable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 108)]
        public long PortId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricPortPolicyRelationship PortPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Preferred device ID to be configured by user for the connected device. This ID must be specified together with the 'PreferredDeviceType' property. This ID will only takes effect if the actual connected device matches the 'PreferredDeviceType'. If the preferred ID is not available, the ID is automatically allocated and assigned by the system. If different preferred IDs are specified for the ports connected to the same device, only the preferred ID (if specified) of the port that is discovered first will be considered."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long PreferredDeviceId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Device type for which preferred ID to be configured. If the actual connected device does not match the specified device type, the system ignores the 'PreferredDeviceId' property.\n* `Auto` - Preferred Id will be ignored if specified with this type.\n* `RackServer` - Connected device type is Rack Unit Server.\n* `Chassis` - Connected device type is Chassis."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricServerRole.PreferredDeviceTypeEnum PreferredDeviceType
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Slot Identifier of the Switch/FEX/Chassis Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 5)]
        public long SlotId
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
        /// <para type="description">"The user defined label assigned to a Port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[ !#$%\\s+&\\(\\)\\*\\+,\\-\\./:;\\?@\\[\\]_\\{\\|\\}~a-zA-Z0-9]*$")]
        public string UserLabel
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricSpanDestEthPort.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricSpanDestEthPort")]
    public class NewIntersightFabricSpanDestEthPort : NewCmdletBase
    {
        public NewIntersightFabricSpanDestEthPort()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricSpanDestEthPort();
            MethodName = "CreateFabricSpanDestEthPortWithHttpInfo";
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
        /// <para type="description">"Admin speed of the SPAN Destination Port.\n* `Auto` - Admin configurable speed AUTO ( default ).\n* `1Gbps` - Admin configurable speed 1Gbps.\n* `10Gbps` - Admin configurable speed 10Gbps.\n* `25Gbps` - Admin configurable speed 25Gbps.\n* `40Gbps` - Admin configurable speed 40Gbps.\n* `100Gbps` - Admin configurable speed 100Gbps.\n* `NegAuto25Gbps` - Admin configurable 25Gbps auto negotiation for ports and port-channels.Speed is applicable on Ethernet Uplink, Ethernet Appliance and FCoE Uplink port and port-channel roles.This speed config is only applicable to non-breakout ports on UCS-FI-6454 and UCS-FI-64108."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricSpanDestEthPort.AdminSpeedEnum AdminSpeed
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Breakout port Identifier of the Switch Interface.\nWhen a port is not configured as a breakout port, the aggregatePortId is set to 0, and unused.\nWhen a port is configured as a breakout port, the 'aggregatePortId' port number as labeled on the equipment,\ne.g. the id of the port on the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long AggregatePortId
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"Forward error correction setting of the SPAN Destination Port.\n* `Auto` - Forward error correction option 'Auto'. Supported speeds are Auto, 1Gbps, 10Gbps, 25Gbps, 40Gbps and 100 Gbps.\n* `Cl91` - Forward error correction option 'cl91'. Supported speeds are 25Gbps and 100 Gbps.\n* `Cl74` - Forward error correction option 'cl74'. Supported speeds are 25Gbps.\n* `rs-cons16` - Forward error correction option \"rs-cons16\". Supported speeds are 25Gbps.\n* `rs-ieee` - Forward error correction option \"rs-ieee\". Supported speeds are 25Gbps.\n* `Off` - Turn off forward error correction. Supported speeds are 25Gbps and 100 Gbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricSpanDestEthPort.FecEnum Fec
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
        /// <para type="description">"Port Identifier of the Switch Interface.\nWhen a port is not configured as a breakout port, the portId is the port number as labeled on the equipment,\ne.g. the id of the port on the switch, FEX or chassis.\nWhen a port is configured as a breakout port, the 'portId' represents the port id on the fanout side of the breakout cable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long PortId
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Slot Identifier of the Switch Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long SlotId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricSpanSession resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricSpanSessionRelationship SpanSession
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricSpanSession.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricSpanSession")]
    public class NewIntersightFabricSpanSession : NewCmdletBase
    {
        public NewIntersightFabricSpanSession()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricSpanSession();
            MethodName = "CreateFabricSpanSessionWithHttpInfo";
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
        /// <para type="description">"Admin state to enable or disable the SPAN session.\n* `Disabled` - Admin configured Disabled State.\n* `Enabled` - Admin configured Enabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricSpanSession.AdminStateEnum AdminState
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"An array of relationships to fabricAbstractSpanDestPort resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FabricAbstractSpanDestPortRelationship> DestPorts
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
        /// <para type="description">"Name of the SPAN session. The name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.) or an underscore (_)."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a networkElement resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NetworkElementRelationship NetworkElement
        {
            get;
            set;
        }









        // <summary>
        /// <para type="description">"An array of relationships to fabricAbstractSpanSourcePortChannel resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FabricAbstractSpanSourcePortChannelRelationship> SourcePortChannels
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An array of relationships to fabricAbstractSpanSourcePort resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FabricAbstractSpanSourcePortRelationship> SourcePorts
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An array of relationships to fabricAbstractSpanSourceVirtualIf resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FabricAbstractSpanSourceVirtualIfRelationship> SourceVirtualIfs
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An array of relationships to fabricSpanSourceVlan resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FabricSpanSourceVlanRelationship> SourceVlans
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Admin state to enable or disable spanning control packets.\n* `Disabled` - Admin configured Disabled State.\n* `Enabled` - Admin configured Enabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricSpanSession.SpanControlPacketsEnum SpanControlPackets
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricSpanSourceEthPort.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricSpanSourceEthPort")]
    public class NewIntersightFabricSpanSourceEthPort : NewCmdletBase
    {
        public NewIntersightFabricSpanSourceEthPort()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricSpanSourceEthPort();
            MethodName = "CreateFabricSpanSourceEthPortWithHttpInfo";
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
        /// <para type="description">"Breakout port Identifier of the Switch Interface.\nWhen a port is not configured as a breakout port, the aggregatePortId is set to 0, and unused.\nWhen a port is configured as a breakout port, the 'aggregatePortId' port number as labeled on the equipment,\ne.g. the id of the port on the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long AggregatePortId
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"Direction of the source SPAN.\n* `Receive` - SPAN incoming traffic on the SPAN source interface.\n* `Transmit` - SPAN outgoing traffic on the SPAN source interface.\n* `Both` - SPAN incoming and outgoing traffic on the SPAN source interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricSpanSourceEthPort.DirectionEnum Direction
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
        /// <para type="description">"Port Identifier of the Switch Interface.\nWhen a port is not configured as a breakout port, the portId is the port number as labeled on the equipment,\ne.g. the id of the port on the switch, FEX or chassis.\nWhen a port is configured as a breakout port, the 'portId' represents the port id on the fanout side of the breakout cable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long PortId
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Slot Identifier of the Switch Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long SlotId
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a fabricSpanSession resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricSpanSessionRelationship SpanSession
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricSpanSourceEthPortChannel.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricSpanSourceEthPortChannel")]
    public class NewIntersightFabricSpanSourceEthPortChannel : NewCmdletBase
    {
        public NewIntersightFabricSpanSourceEthPortChannel()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricSpanSourceEthPortChannel();
            MethodName = "CreateFabricSpanSourceEthPortChannelWithHttpInfo";
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
        /// <para type="description">"Direction of the source SPAN.\n* `Receive` - SPAN incoming traffic on the SPAN source interface.\n* `Transmit` - SPAN outgoing traffic on the SPAN source interface.\n* `Both` - SPAN incoming and outgoing traffic on the SPAN source interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricSpanSourceEthPortChannel.DirectionEnum Direction
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
        /// <para type="description">"Port-channel ID of SPAN source."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long PcId
        {
            get;
            set;
        }





        // <summary>
        /// <para type="description">"A reference to a fabricSpanSession resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricSpanSessionRelationship SpanSession
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricSpanSourceVlan.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricSpanSourceVlan")]
    public class NewIntersightFabricSpanSourceVlan : NewCmdletBase
    {
        public NewIntersightFabricSpanSourceVlan()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricSpanSourceVlan();
            MethodName = "CreateFabricSpanSourceVlanWithHttpInfo";
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
        /// <para type="description">"Direction of the source SPAN.\n* `Receive` - SPAN incoming traffic on the SPAN source interface.\n* `Transmit` - SPAN outgoing traffic on the SPAN source interface.\n* `Both` - SPAN incoming and outgoing traffic on the SPAN source interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricSpanSourceVlan.DirectionEnum Direction
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
        /// <para type="description">"A reference to a fabricSpanSession resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricSpanSessionRelationship SpanSession
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
        /// <para type="description">"SPAN source VLAN Identifier."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long VlanId
        {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricSpanSourceVnicEthIf.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricSpanSourceVnicEthIf")]
    public class NewIntersightFabricSpanSourceVnicEthIf : NewCmdletBase
    {
        public NewIntersightFabricSpanSourceVnicEthIf()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricSpanSourceVnicEthIf();
            MethodName = "CreateFabricSpanSourceVnicEthIfWithHttpInfo";
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
        /// <para type="description">"Direction of the source SPAN.\n* `Receive` - SPAN incoming traffic on the SPAN source interface.\n* `Transmit` - SPAN outgoing traffic on the SPAN source interface.\n* `Both` - SPAN incoming and outgoing traffic on the SPAN source interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricSpanSourceVnicEthIf.DirectionEnum Direction
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
        /// <para type="description">"A reference to a fabricSpanSession resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricSpanSessionRelationship SpanSession
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
        /// <para type="description">"A reference to a vnicEthIf resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public VnicEthIfRelationship Vnic
        {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricSwitchClusterProfile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricSwitchClusterProfile")]
    public class NewIntersightFabricSwitchClusterProfile : NewCmdletBase
    {
        public NewIntersightFabricSwitchClusterProfile()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricSwitchClusterProfile();
            MethodName = "CreateFabricSwitchClusterProfileWithHttpInfo";
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FabricClusterAssignment> ClusterAssignments
        {
            get;
            set;
        }





        // <summary>
        /// <para type="description">"Description of the profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
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
        /// <para type="description">"Name of the profile instance or profile template."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.-]{1,64}$")]
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
        /// <para type="description">"A reference to a policyAbstractProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PolicyAbstractProfileRelationship SrcTemplate
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An array of relationships to fabricSwitchProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FabricSwitchProfileRelationship> SwitchProfiles
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
        /// <para type="description">"Defines the type of the profile. Accepted values are instance or template.\n* `instance` - The profile defines the configuration for a specific instance of a target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricSwitchClusterProfile.TypeEnum Type
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The user defined label assigned to the switch profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[ !#$%&\\(\\)\\*\\+,\\-\\./:;\\?@\\[\\]_\\{\\|\\}~a-zA-Z0-9]*$")]
        public string UserLabel
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricSwitchClusterProfileTemplate.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricSwitchClusterProfileTemplate")]
    public class NewIntersightFabricSwitchClusterProfileTemplate : NewCmdletBase
    {
        public NewIntersightFabricSwitchClusterProfileTemplate()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricSwitchClusterProfileTemplate();
            MethodName = "CreateFabricSwitchClusterProfileTemplateWithHttpInfo";
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
        /// <para type="description">"Description of the profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
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
        /// <para type="description">"Name of the profile instance or profile template."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.-]{1,64}$")]
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
        /// <para type="description">"A reference to a policyAbstractProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PolicyAbstractProfileRelationship SrcTemplate
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An array of relationships to fabricSwitchProfileTemplate resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FabricSwitchProfileTemplateRelationship> SwitchProfileTemplates
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
        /// <para type="description">"Defines the type of the profile. Accepted values are instance or template.\n* `instance` - The profile defines the configuration for a specific instance of a target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricSwitchClusterProfileTemplate.TypeEnum Type
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricSwitchControlPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricSwitchControlPolicy")]
    public class NewIntersightFabricSwitchControlPolicy : NewCmdletBase
    {
        public NewIntersightFabricSwitchControlPolicy()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricSwitchControlPolicy();
            MethodName = "CreateFabricSwitchControlPolicyWithHttpInfo";
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
        /// <para type="description">"Encrypts MACsec keys in type-6 format. If a MACsec key is already provided in a type-6 format, the primary key decrypts it."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[^\"\\s]{16,64}$")]
        public string AesPrimaryKey
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
        /// <para type="description">"Enable or Disable Ethernet End Host Switching Mode.\n* `end-host` - In end-host mode, the fabric interconnects appear to the upstream devices as end hosts with multiple links.In this mode, the switch does not run Spanning Tree Protocol and avoids loops by following a set of rules for traffic forwarding.In case of ethernet switching mode - Ethernet end-host mode is also known as Ethernet host virtualizer.\n* `switch` - In switch mode, the switch runs Spanning Tree Protocol to avoid loops, and broadcast and multicast packets are handled in the traditional way.This is the traditional switch mode."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricSwitchControlPolicy.EthernetSwitchingModeEnum EthernetSwitchingMode
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"When enabled, a Registered State Change Notification (RSCN) is sent to the VIC adapter when any member port within the fabric port-channel goes down and vHBA would reset to restore the connection immediately. When disabled (default), vHBA reset is done only when all the members of a fabric port-channel are down.\n* `Disabled` - Admin configured Disabled State.\n* `Enabled` - Admin configured Enabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricSwitchControlPolicy.FabricPcVhbaResetEnum FabricPcVhbaReset
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Enable or Disable FC End Host Switching Mode.\n* `end-host` - In end-host mode, the fabric interconnects appear to the upstream devices as end hosts with multiple links.In this mode, the switch does not run Spanning Tree Protocol and avoids loops by following a set of rules for traffic forwarding.In case of ethernet switching mode - Ethernet end-host mode is also known as Ethernet host virtualizer.\n* `switch` - In switch mode, the switch runs Spanning Tree Protocol to avoid loops, and broadcast and multicast packets are handled in the traditional way.This is the traditional switch mode."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricSwitchControlPolicy.FcSwitchingModeEnum FcSwitchingMode
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"This specifies the MAC aging option and time settings."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricMacAgingSettings MacAgingSettings
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
        /// <para type="description">"An array of relationships to fabricBaseSwitchProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FabricBaseSwitchProfileRelationship> Profiles
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The starting ID for VLANs reserved for internal use within the Fabric Interconnect. This VLAN ID is the starting ID of\na contiguous block of 128 VLANs that cannot be configured for user data.  This range of VLANs cannot be configured in\nVLAN policy.\nIf this property is not configured, VLAN range 3915 - 4042 is reserved for internal use by default."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(2, 3915)]
        public long ReservedVlanStartId
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
        /// <para type="description">"This specifies the UDLD Global configurations for this switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricUdldGlobalSettings UdldSettings
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"To enable or disable the VLAN port count optimization. This feature will always be enabled for\nCisco UCS Fabric Interconnect 9108 100G and also enabled on the IMM 6.x Bundle version and onwards."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool VlanPortOptimizationEnabled
        {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricSwitchProfile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricSwitchProfile")]
    public class NewIntersightFabricSwitchProfile : NewCmdletBase
    {
        public NewIntersightFabricSwitchProfile()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricSwitchProfile();
            MethodName = "CreateFabricSwitchProfileWithHttpInfo";
        }


        // <summary>
        /// <para type="description">"User initiated action. Each profile type has its own supported actions. For HyperFlex cluster profile, the supported actions are -- Validate, Deploy, Continue, Retry, Abort, Unassign For server profile, the support actions are -- Deploy, Unassign."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Action
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<PolicyActionParam> ActionParams
        {
            get;
            set;
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
        /// <para type="description">"A reference to a networkElement resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NetworkElementRelationship AssignedSwitch
        {
            get;
            set;
        }





        // <summary>
        /// <para type="description">"The configuration state and results of the last configuration operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PolicyConfigContext ConfigContext
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"Description of the profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
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
        /// <para type="description">"Name of the profile instance or profile template."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"An array of relationships to policyAbstractPolicy resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<PolicyAbstractPolicyRelationship> PolicyBucket
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<PolicyScheduledAction> ScheduledActions
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a policyAbstractProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PolicyAbstractProfileRelationship SrcTemplate
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricSwitchClusterProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricSwitchClusterProfileRelationship SwitchClusterProfile
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Value indicating the switch side on which the switch profile or template has to be deployed.\n* `None` - Switch side not defined for the policy configurations in the switch profile or template.\n* `A` - Policy configurations in the switch profile or template to be deployed on fabric interconnect A.\n* `B` - Policy configurations in the switch profile or template to be deployed on fabric interconnect B."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricSwitchProfile.SwitchIdEnum SwitchId
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
        /// <para type="description">"Defines the type of the profile. Accepted values are instance or template.\n* `instance` - The profile defines the configuration for a specific instance of a target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricSwitchProfile.TypeEnum Type
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricSwitchProfileTemplate.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricSwitchProfileTemplate")]
    public class NewIntersightFabricSwitchProfileTemplate : NewCmdletBase
    {
        public NewIntersightFabricSwitchProfileTemplate()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricSwitchProfileTemplate();
            MethodName = "CreateFabricSwitchProfileTemplateWithHttpInfo";
        }


        // <summary>
        /// <para type="description">"User initiated action. Each profile type has its own supported actions. For HyperFlex cluster profile, the supported actions are -- Validate, Deploy, Continue, Retry, Abort, Unassign For server profile, the support actions are -- Deploy, Unassign."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Action
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<PolicyActionParam> ActionParams
        {
            get;
            set;
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
        /// <para type="description">"The configuration state and results of the last configuration operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PolicyConfigContext ConfigContext
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"Description of the profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
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
        /// <para type="description">"Name of the profile instance or profile template."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"An array of relationships to policyAbstractPolicy resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<PolicyAbstractPolicyRelationship> PolicyBucket
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<PolicyScheduledAction> ScheduledActions
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a policyAbstractProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PolicyAbstractProfileRelationship SrcTemplate
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricSwitchClusterProfileTemplate resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricSwitchClusterProfileTemplateRelationship SwitchClusterProfileTemplate
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Value indicating the switch side on which the switch profile or template has to be deployed.\n* `None` - Switch side not defined for the policy configurations in the switch profile or template.\n* `A` - Policy configurations in the switch profile or template to be deployed on fabric interconnect A.\n* `B` - Policy configurations in the switch profile or template to be deployed on fabric interconnect B."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricSwitchProfileTemplate.SwitchIdEnum SwitchId
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
        /// <para type="description">"Defines the type of the profile. Accepted values are instance or template.\n* `instance` - The profile defines the configuration for a specific instance of a target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricSwitchProfileTemplate.TypeEnum Type
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricSystemQosPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricSystemQosPolicy")]
    public class NewIntersightFabricSystemQosPolicy : NewCmdletBase
    {
        public NewIntersightFabricSystemQosPolicy()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricSystemQosPolicy();
            MethodName = "CreateFabricSystemQosPolicyWithHttpInfo";
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FabricQosClass> Classes
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
        /// <para type="description">"An array of relationships to fabricBaseSwitchProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FabricBaseSwitchProfileRelationship> Profiles
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricUplinkPcRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricUplinkPcRole")]
    public class NewIntersightFabricUplinkPcRole : NewCmdletBase
    {
        public NewIntersightFabricUplinkPcRole()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricUplinkPcRole();
            MethodName = "CreateFabricUplinkPcRoleWithHttpInfo";
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
        /// <para type="description">"Admin configured speed for the port.\n* `Auto` - Admin configurable speed AUTO ( default ).\n* `1Gbps` - Admin configurable speed 1Gbps.\n* `10Gbps` - Admin configurable speed 10Gbps.\n* `25Gbps` - Admin configurable speed 25Gbps.\n* `40Gbps` - Admin configurable speed 40Gbps.\n* `100Gbps` - Admin configurable speed 100Gbps.\n* `NegAuto25Gbps` - Admin configurable 25Gbps auto negotiation for ports and port-channels.Speed is applicable on Ethernet Uplink, Ethernet Appliance and FCoE Uplink port and port-channel roles.This speed config is only applicable to non-breakout ports on UCS-FI-6454 and UCS-FI-64108."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricUplinkPcRole.AdminSpeedEnum AdminSpeed
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"An array of relationships to fabricEthNetworkGroupPolicy resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FabricEthNetworkGroupPolicyRelationship> EthNetworkGroupPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Forward error correction configuration for Uplink Port Channel member ports.\n* `Auto` - Forward error correction option 'Auto'. Supported speeds are Auto, 1Gbps, 10Gbps, 25Gbps, 40Gbps and 100 Gbps.\n* `Cl91` - Forward error correction option 'cl91'. Supported speeds are 25Gbps and 100 Gbps.\n* `Cl74` - Forward error correction option 'cl74'. Supported speeds are 25Gbps.\n* `rs-cons16` - Forward error correction option \"rs-cons16\". Supported speeds are 25Gbps.\n* `rs-ieee` - Forward error correction option \"rs-ieee\". Supported speeds are 25Gbps.\n* `Off` - Turn off forward error correction. Supported speeds are 25Gbps and 100 Gbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricUplinkPcRole.FecEnum Fec
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricFlowControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricFlowControlPolicyRelationship FlowControlPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricLinkAggregationPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricLinkAggregationPolicyRelationship LinkAggregationPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricLinkControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricLinkControlPolicyRelationship LinkControlPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricMacSecPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricMacSecPolicyRelationship MacSecPolicy
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
        /// <para type="description">"Unique Identifier of the port-channel, local to this switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 256)]
        public long PcId
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricPortPolicyRelationship PortPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FabricPortIdentifier> Ports
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
        /// <para type="description">"The user defined label assigned to the a Port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[ !#$%\\s+&\\(\\)\\*\\+,\\-\\./:;\\?@\\[\\]_\\{\\|\\}~a-zA-Z0-9]*$")]
        public string UserLabel
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricUplinkRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricUplinkRole")]
    public class NewIntersightFabricUplinkRole : NewCmdletBase
    {
        public NewIntersightFabricUplinkRole()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricUplinkRole();
            MethodName = "CreateFabricUplinkRoleWithHttpInfo";
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
        /// <para type="description">"Admin configured speed for the port.\n* `Auto` - Admin configurable speed AUTO ( default ).\n* `1Gbps` - Admin configurable speed 1Gbps.\n* `10Gbps` - Admin configurable speed 10Gbps.\n* `25Gbps` - Admin configurable speed 25Gbps.\n* `40Gbps` - Admin configurable speed 40Gbps.\n* `100Gbps` - Admin configurable speed 100Gbps.\n* `NegAuto25Gbps` - Admin configurable 25Gbps auto negotiation for ports and port-channels.Speed is applicable on Ethernet Uplink, Ethernet Appliance and FCoE Uplink port and port-channel roles.This speed config is only applicable to non-breakout ports on UCS-FI-6454 and UCS-FI-64108."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricUplinkRole.AdminSpeedEnum AdminSpeed
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Breakout port Identifier of the Switch Interface.\nWhen a port is not configured as a breakout port, the aggregatePortId is set to 0, and unused.\nWhen a port is configured as a breakout port, the 'aggregatePortId' port number as labeled on the equipment,\ne.g. the id of the port on the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long AggregatePortId
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"An array of relationships to fabricEthNetworkGroupPolicy resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FabricEthNetworkGroupPolicyRelationship> EthNetworkGroupPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Forward error correction configuration for the port.\n* `Auto` - Forward error correction option 'Auto'. Supported speeds are Auto, 1Gbps, 10Gbps, 25Gbps, 40Gbps and 100 Gbps.\n* `Cl91` - Forward error correction option 'cl91'. Supported speeds are 25Gbps and 100 Gbps.\n* `Cl74` - Forward error correction option 'cl74'. Supported speeds are 25Gbps.\n* `rs-cons16` - Forward error correction option \"rs-cons16\". Supported speeds are 25Gbps.\n* `rs-ieee` - Forward error correction option \"rs-ieee\". Supported speeds are 25Gbps.\n* `Off` - Turn off forward error correction. Supported speeds are 25Gbps and 100 Gbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricUplinkRole.FecEnum Fec
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricFlowControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricFlowControlPolicyRelationship FlowControlPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricLinkControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricLinkControlPolicyRelationship LinkControlPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricMacSecPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricMacSecPolicyRelationship MacSecPolicy
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
        /// <para type="description">"Port Identifier of the Switch/FEX/Chassis Interface.\nWhen a port is not configured as a breakout port, the portId is the port number as labeled on the equipment,\ne.g. the id of the port on the switch, FEX or chassis.\nWhen a port is configured as a breakout port, the 'portId' represents the port id on the fanout side of the breakout cable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 108)]
        public long PortId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricPortPolicyRelationship PortPolicy
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Slot Identifier of the Switch/FEX/Chassis Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 5)]
        public long SlotId
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
        /// <para type="description">"The user defined label assigned to a Port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[ !#$%\\s+&\\(\\)\\*\\+,\\-\\./:;\\?@\\[\\]_\\{\\|\\}~a-zA-Z0-9]*$")]
        public string UserLabel
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricVlan.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricVlan")]
    public class NewIntersightFabricVlan : NewCmdletBase
    {
        public NewIntersightFabricVlan()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricVlan();
            MethodName = "CreateFabricVlanWithHttpInfo";
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
        /// <para type="description">"Enable to automatically allow this VLAN on all uplinks. Disable must be specified for Disjoint Layer 2 VLAN configuration. Default VLAN-1 cannot be configured as Disjoint Layer 2 VLAN."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool AutoAllowOnUplinks
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"A reference to a fabricEthNetworkPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricEthNetworkPolicyRelationship EthNetworkPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Used to define whether this VLAN is to be classified as 'native' for traffic in this FI."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsNative
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
        /// <para type="description">"A reference to a fabricMulticastPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricMulticastPolicyRelationship MulticastPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The 'name' used to identify this VLAN."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"The Primary VLAN ID of the VLAN, if the sharing type of the VLAN is Isolated or Community."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long PrimaryVlanId
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The sharing type of this VLAN.\n* `None` - This represents a regular VLAN.\n* `Primary` - This represents a primary VLAN.\n* `Isolated` - This represents an isolated VLAN.\n* `Community` - This represents a community VLAN."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricVlan.SharingTypeEnum SharingType
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
        /// <para type="description">"The identifier for this Virtual LAN."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 4093)]
        public long VlanId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricVlanSet resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricVlanSetRelationship VlanSet
        {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricVsan.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricVsan")]
    public class NewIntersightFabricVsan : NewCmdletBase
    {
        public NewIntersightFabricVsan()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricVsan();
            MethodName = "CreateFabricVsanWithHttpInfo";
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
        /// <para type="description">"Enables or Disables the default zoning state.\n* `Enabled` - Admin configured Enabled State.\n* `Disabled` - Admin configured Disabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricVsan.DefaultZoningEnum DefaultZoning
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a fabricFcNetworkPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricFcNetworkPolicyRelationship FcNetworkPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Logical grouping mode for fc ports."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string FcZoneSharingMode
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"FCOE Vlan associated to the VSAN configuration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 4093)]
        public long FcoeVlan
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
        /// <para type="description">"User given name for the VSAN configuration."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]

        public string Name
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
        /// <para type="description">"Virtual San Identifier in the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 4093)]
        public long VsanId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Used to indicate whether the VSAN Id is defined for storage or uplink or both traffics in FI.\n* `Uplink` - Vsan associated with uplink network.\n* `Storage` - Vsan associated with storage network.\n* `Common` - Vsan that is common for uplink and storage network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricVsan.VsanScopeEnum VsanScope
        {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricAppliancePcRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricAppliancePcRole")]
    public class RemoveIntersightFabricAppliancePcRole : RemoveCmdletBase
    {
        public RemoveIntersightFabricAppliancePcRole()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricAppliancePcRoleWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricApplianceRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricApplianceRole")]
    public class RemoveIntersightFabricApplianceRole : RemoveCmdletBase
    {
        public RemoveIntersightFabricApplianceRole()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricApplianceRoleWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricEthNetworkControlPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricEthNetworkControlPolicy")]
    public class RemoveIntersightFabricEthNetworkControlPolicy : RemoveCmdletBase
    {
        public RemoveIntersightFabricEthNetworkControlPolicy()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricEthNetworkControlPolicyWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricEthNetworkGroupPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricEthNetworkGroupPolicy")]
    public class RemoveIntersightFabricEthNetworkGroupPolicy : RemoveCmdletBase
    {
        public RemoveIntersightFabricEthNetworkGroupPolicy()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricEthNetworkGroupPolicyWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricEthNetworkPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricEthNetworkPolicy")]
    public class RemoveIntersightFabricEthNetworkPolicy : RemoveCmdletBase
    {
        public RemoveIntersightFabricEthNetworkPolicy()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricEthNetworkPolicyWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricFcNetworkPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricFcNetworkPolicy")]
    public class RemoveIntersightFabricFcNetworkPolicy : RemoveCmdletBase
    {
        public RemoveIntersightFabricFcNetworkPolicy()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricFcNetworkPolicyWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricFcStorageRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricFcStorageRole")]
    public class RemoveIntersightFabricFcStorageRole : RemoveCmdletBase
    {
        public RemoveIntersightFabricFcStorageRole()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricFcStorageRoleWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricFcUplinkPcRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricFcUplinkPcRole")]
    public class RemoveIntersightFabricFcUplinkPcRole : RemoveCmdletBase
    {
        public RemoveIntersightFabricFcUplinkPcRole()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricFcUplinkPcRoleWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricFcUplinkRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricFcUplinkRole")]
    public class RemoveIntersightFabricFcUplinkRole : RemoveCmdletBase
    {
        public RemoveIntersightFabricFcUplinkRole()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricFcUplinkRoleWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricFcZonePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricFcZonePolicy")]
    public class RemoveIntersightFabricFcZonePolicy : RemoveCmdletBase
    {
        public RemoveIntersightFabricFcZonePolicy()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricFcZonePolicyWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricFcoeUplinkPcRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricFcoeUplinkPcRole")]
    public class RemoveIntersightFabricFcoeUplinkPcRole : RemoveCmdletBase
    {
        public RemoveIntersightFabricFcoeUplinkPcRole()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricFcoeUplinkPcRoleWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricFcoeUplinkRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricFcoeUplinkRole")]
    public class RemoveIntersightFabricFcoeUplinkRole : RemoveCmdletBase
    {
        public RemoveIntersightFabricFcoeUplinkRole()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricFcoeUplinkRoleWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricFlowControlPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricFlowControlPolicy")]
    public class RemoveIntersightFabricFlowControlPolicy : RemoveCmdletBase
    {
        public RemoveIntersightFabricFlowControlPolicy()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricFlowControlPolicyWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricLanPinGroup.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricLanPinGroup")]
    public class RemoveIntersightFabricLanPinGroup : RemoveCmdletBase
    {
        public RemoveIntersightFabricLanPinGroup()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricLanPinGroupWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricLinkAggregationPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricLinkAggregationPolicy")]
    public class RemoveIntersightFabricLinkAggregationPolicy : RemoveCmdletBase
    {
        public RemoveIntersightFabricLinkAggregationPolicy()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricLinkAggregationPolicyWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricLinkControlPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricLinkControlPolicy")]
    public class RemoveIntersightFabricLinkControlPolicy : RemoveCmdletBase
    {
        public RemoveIntersightFabricLinkControlPolicy()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricLinkControlPolicyWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricMacSecPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricMacSecPolicy")]
    public class RemoveIntersightFabricMacSecPolicy : RemoveCmdletBase
    {
        public RemoveIntersightFabricMacSecPolicy()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricMacSecPolicyWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricMulticastPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricMulticastPolicy")]
    public class RemoveIntersightFabricMulticastPolicy : RemoveCmdletBase
    {
        public RemoveIntersightFabricMulticastPolicy()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricMulticastPolicyWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricPcOperation.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricPcOperation")]
    public class RemoveIntersightFabricPcOperation : RemoveCmdletBase
    {
        public RemoveIntersightFabricPcOperation()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricPcOperationWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricPortMode.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricPortMode")]
    public class RemoveIntersightFabricPortMode : RemoveCmdletBase
    {
        public RemoveIntersightFabricPortMode()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricPortModeWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricPortOperation.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricPortOperation")]
    public class RemoveIntersightFabricPortOperation : RemoveCmdletBase
    {
        public RemoveIntersightFabricPortOperation()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricPortOperationWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricPortPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricPortPolicy")]
    public class RemoveIntersightFabricPortPolicy : RemoveCmdletBase
    {
        public RemoveIntersightFabricPortPolicy()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricPortPolicyWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricSanPinGroup.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricSanPinGroup")]
    public class RemoveIntersightFabricSanPinGroup : RemoveCmdletBase
    {
        public RemoveIntersightFabricSanPinGroup()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricSanPinGroupWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricServerRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricServerRole")]
    public class RemoveIntersightFabricServerRole : RemoveCmdletBase
    {
        public RemoveIntersightFabricServerRole()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricServerRoleWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricSpanDestEthPort.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricSpanDestEthPort")]
    public class RemoveIntersightFabricSpanDestEthPort : RemoveCmdletBase
    {
        public RemoveIntersightFabricSpanDestEthPort()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricSpanDestEthPortWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricSpanSession.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricSpanSession")]
    public class RemoveIntersightFabricSpanSession : RemoveCmdletBase
    {
        public RemoveIntersightFabricSpanSession()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricSpanSessionWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricSpanSourceEthPort.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricSpanSourceEthPort")]
    public class RemoveIntersightFabricSpanSourceEthPort : RemoveCmdletBase
    {
        public RemoveIntersightFabricSpanSourceEthPort()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricSpanSourceEthPortWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricSpanSourceEthPortChannel.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricSpanSourceEthPortChannel")]
    public class RemoveIntersightFabricSpanSourceEthPortChannel : RemoveCmdletBase
    {
        public RemoveIntersightFabricSpanSourceEthPortChannel()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricSpanSourceEthPortChannelWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricSpanSourceVlan.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricSpanSourceVlan")]
    public class RemoveIntersightFabricSpanSourceVlan : RemoveCmdletBase
    {
        public RemoveIntersightFabricSpanSourceVlan()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricSpanSourceVlanWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricSpanSourceVnicEthIf.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricSpanSourceVnicEthIf")]
    public class RemoveIntersightFabricSpanSourceVnicEthIf : RemoveCmdletBase
    {
        public RemoveIntersightFabricSpanSourceVnicEthIf()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricSpanSourceVnicEthIfWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricSwitchClusterProfile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricSwitchClusterProfile")]
    public class RemoveIntersightFabricSwitchClusterProfile : RemoveCmdletBase
    {
        public RemoveIntersightFabricSwitchClusterProfile()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricSwitchClusterProfileWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricSwitchClusterProfileTemplate.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricSwitchClusterProfileTemplate")]
    public class RemoveIntersightFabricSwitchClusterProfileTemplate : RemoveCmdletBase
    {
        public RemoveIntersightFabricSwitchClusterProfileTemplate()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricSwitchClusterProfileTemplateWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricSwitchControlPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricSwitchControlPolicy")]
    public class RemoveIntersightFabricSwitchControlPolicy : RemoveCmdletBase
    {
        public RemoveIntersightFabricSwitchControlPolicy()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricSwitchControlPolicyWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricSwitchProfile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricSwitchProfile")]
    public class RemoveIntersightFabricSwitchProfile : RemoveCmdletBase
    {
        public RemoveIntersightFabricSwitchProfile()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricSwitchProfileWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricSwitchProfileTemplate.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricSwitchProfileTemplate")]
    public class RemoveIntersightFabricSwitchProfileTemplate : RemoveCmdletBase
    {
        public RemoveIntersightFabricSwitchProfileTemplate()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricSwitchProfileTemplateWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricSystemQosPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricSystemQosPolicy")]
    public class RemoveIntersightFabricSystemQosPolicy : RemoveCmdletBase
    {
        public RemoveIntersightFabricSystemQosPolicy()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricSystemQosPolicyWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricUplinkPcRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricUplinkPcRole")]
    public class RemoveIntersightFabricUplinkPcRole : RemoveCmdletBase
    {
        public RemoveIntersightFabricUplinkPcRole()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricUplinkPcRoleWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricUplinkRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricUplinkRole")]
    public class RemoveIntersightFabricUplinkRole : RemoveCmdletBase
    {
        public RemoveIntersightFabricUplinkRole()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricUplinkRoleWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricVlan.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricVlan")]
    public class RemoveIntersightFabricVlan : RemoveCmdletBase
    {
        public RemoveIntersightFabricVlan()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricVlanWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricVsan.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricVsan")]
    public class RemoveIntersightFabricVsan : RemoveCmdletBase
    {
        public RemoveIntersightFabricVsan()
        {
            ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricVsanWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricAppliancePcRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricAppliancePcRole")]
    public class SetIntersightFabricAppliancePcRole : SetCmdletBase
    {
        public SetIntersightFabricAppliancePcRole()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricAppliancePcRole();
            MethodName = "UpdateFabricAppliancePcRoleWithHttpInfo";
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
        /// <para type="description">"Admin configured speed for the port channel.\n* `Auto` - Admin configurable speed AUTO ( default ).\n* `1Gbps` - Admin configurable speed 1Gbps.\n* `10Gbps` - Admin configurable speed 10Gbps.\n* `25Gbps` - Admin configurable speed 25Gbps.\n* `40Gbps` - Admin configurable speed 40Gbps.\n* `100Gbps` - Admin configurable speed 100Gbps.\n* `NegAuto25Gbps` - Admin configurable 25Gbps auto negotiation for ports and port-channels.Speed is applicable on Ethernet Uplink, Ethernet Appliance and FCoE Uplink port and port-channel roles.This speed config is only applicable to non-breakout ports on UCS-FI-6454 and UCS-FI-64108."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricAppliancePcRole.AdminSpeedEnum AdminSpeed
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"A reference to a fabricEthNetworkControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricEthNetworkControlPolicyRelationship EthNetworkControlPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricEthNetworkGroupPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricEthNetworkGroupPolicyRelationship EthNetworkGroupPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Forward error correction configuration for Appliance Port Channel member ports.\n* `Auto` - Forward error correction option 'Auto'. Supported speeds are Auto, 1Gbps, 10Gbps, 25Gbps, 40Gbps and 100 Gbps.\n* `Cl91` - Forward error correction option 'cl91'. Supported speeds are 25Gbps and 100 Gbps.\n* `Cl74` - Forward error correction option 'cl74'. Supported speeds are 25Gbps.\n* `rs-cons16` - Forward error correction option \"rs-cons16\". Supported speeds are 25Gbps.\n* `rs-ieee` - Forward error correction option \"rs-ieee\". Supported speeds are 25Gbps.\n* `Off` - Turn off forward error correction. Supported speeds are 25Gbps and 100 Gbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricAppliancePcRole.FecEnum Fec
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricLinkAggregationPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricLinkAggregationPolicyRelationship LinkAggregationPolicy
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Port mode to be set on the appliance port-channel.\n* `trunk` - Trunk Mode Switch Port Type.\n* `access` - Access Mode Switch Port Type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricAppliancePcRole.ModeEnum Mode
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
        /// <para type="description">"Unique Identifier of the port-channel, local to this switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 256)]
        public long PcId
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricPortPolicyRelationship PortPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FabricPortIdentifier> Ports
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The 'name' of the System QoS Class.\n* `Best Effort` - QoS Priority for Best-effort traffic.\n* `FC` - QoS Priority for FC traffic.\n* `Platinum` - QoS Priority for Platinum traffic.\n* `Gold` - QoS Priority for Gold traffic.\n* `Silver` - QoS Priority for Silver traffic.\n* `Bronze` - QoS Priority for Bronze traffic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricAppliancePcRole.PriorityEnum Priority
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
        /// <para type="description">"The user defined label assigned to the a Port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[ !#$%\\s+&\\(\\)\\*\\+,\\-\\./:;\\?@\\[\\]_\\{\\|\\}~a-zA-Z0-9]*$")]
        public string UserLabel
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricApplianceRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricApplianceRole")]
    public class SetIntersightFabricApplianceRole : SetCmdletBase
    {
        public SetIntersightFabricApplianceRole()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricApplianceRole();
            MethodName = "UpdateFabricApplianceRoleWithHttpInfo";
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
        /// <para type="description">"Admin configured speed for the port.\n* `Auto` - Admin configurable speed AUTO ( default ).\n* `1Gbps` - Admin configurable speed 1Gbps.\n* `10Gbps` - Admin configurable speed 10Gbps.\n* `25Gbps` - Admin configurable speed 25Gbps.\n* `40Gbps` - Admin configurable speed 40Gbps.\n* `100Gbps` - Admin configurable speed 100Gbps.\n* `NegAuto25Gbps` - Admin configurable 25Gbps auto negotiation for ports and port-channels.Speed is applicable on Ethernet Uplink, Ethernet Appliance and FCoE Uplink port and port-channel roles.This speed config is only applicable to non-breakout ports on UCS-FI-6454 and UCS-FI-64108."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricApplianceRole.AdminSpeedEnum AdminSpeed
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Breakout port Identifier of the Switch Interface.\nWhen a port is not configured as a breakout port, the aggregatePortId is set to 0, and unused.\nWhen a port is configured as a breakout port, the 'aggregatePortId' port number as labeled on the equipment,\ne.g. the id of the port on the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long AggregatePortId
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"A reference to a fabricEthNetworkControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricEthNetworkControlPolicyRelationship EthNetworkControlPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricEthNetworkGroupPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricEthNetworkGroupPolicyRelationship EthNetworkGroupPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Forward error correction configuration for the port.\n* `Auto` - Forward error correction option 'Auto'. Supported speeds are Auto, 1Gbps, 10Gbps, 25Gbps, 40Gbps and 100 Gbps.\n* `Cl91` - Forward error correction option 'cl91'. Supported speeds are 25Gbps and 100 Gbps.\n* `Cl74` - Forward error correction option 'cl74'. Supported speeds are 25Gbps.\n* `rs-cons16` - Forward error correction option \"rs-cons16\". Supported speeds are 25Gbps.\n* `rs-ieee` - Forward error correction option \"rs-ieee\". Supported speeds are 25Gbps.\n* `Off` - Turn off forward error correction. Supported speeds are 25Gbps and 100 Gbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricApplianceRole.FecEnum Fec
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricFlowControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricFlowControlPolicyRelationship FlowControlPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricLinkControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricLinkControlPolicyRelationship LinkControlPolicy
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Port mode to be set on the appliance port.\n* `trunk` - Trunk Mode Switch Port Type.\n* `access` - Access Mode Switch Port Type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricApplianceRole.ModeEnum Mode
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
        /// <para type="description">"Port Identifier of the Switch/FEX/Chassis Interface.\nWhen a port is not configured as a breakout port, the portId is the port number as labeled on the equipment,\ne.g. the id of the port on the switch, FEX or chassis.\nWhen a port is configured as a breakout port, the 'portId' represents the port id on the fanout side of the breakout cable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 108)]
        public long PortId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricPortPolicyRelationship PortPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The 'name' of the System QoS Class.\n* `Best Effort` - QoS Priority for Best-effort traffic.\n* `FC` - QoS Priority for FC traffic.\n* `Platinum` - QoS Priority for Platinum traffic.\n* `Gold` - QoS Priority for Gold traffic.\n* `Silver` - QoS Priority for Silver traffic.\n* `Bronze` - QoS Priority for Bronze traffic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricApplianceRole.PriorityEnum Priority
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Slot Identifier of the Switch/FEX/Chassis Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 5)]
        public long SlotId
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
        /// <para type="description">"The user defined label assigned to a Port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[ !#$%\\s+&\\(\\)\\*\\+,\\-\\./:;\\?@\\[\\]_\\{\\|\\}~a-zA-Z0-9]*$")]
        public string UserLabel
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricElementIdentity.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricElementIdentity")]
    public class SetIntersightFabricElementIdentity : SetCmdletBase
    {
        public SetIntersightFabricElementIdentity()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricElementIdentity();
            MethodName = "UpdateFabricElementIdentityWithHttpInfo";
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
        /// <para type="description">"Updated by UI/API to trigger specific action type.\n* `None` - No operation value for maintenance actions on an equipment.\n* `Decommission` - Decommission the equipment and temporarily remove it from being managed by Intersight.\n* `Recommission` - Recommission the equipment.\n* `Reack` - Reacknowledge the equipment and discover it again.\n* `Remove` - Remove the equipment permanently from Intersight management.\n* `Replace` - Replace the equipment with the other one."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricElementIdentity.AdminActionEnum AdminAction
        {
            get;
            set;
        }







        // <summary>
        /// <para type="description">"Numeric Identifier assigned by the management system to the equipment. Identifier can only be changed if it has been PATCHED with the AdminAction property set to 'Recommission'."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Identifier
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
        /// <para type="description">"A reference to a networkElement resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NetworkElementRelationship ReplacementTarget
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Replacement type specifies whether it is single FI or domain replacement.\n* `None` - The default action is none.\n* `Individual` - Replacement of single network element.\n* `Domain` - Domain indicates the replacement of Fabric Interconnect domain."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricElementIdentity.ReplacementTypeEnum ReplacementType
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


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricEthNetworkControlPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricEthNetworkControlPolicy")]
    public class SetIntersightFabricEthNetworkControlPolicy : SetCmdletBase
    {
        public SetIntersightFabricEthNetworkControlPolicy()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricEthNetworkControlPolicy();
            MethodName = "UpdateFabricEthNetworkControlPolicyWithHttpInfo";
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
        /// <para type="description">"Enables the CDP on an interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool CdpEnabled
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
        /// <para type="description">"Determines if the MAC forging is allowed or denied on an interface.\n* `allow` - Allows mac forging on an interface.\n* `deny` - Denies mac forging on an interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricEthNetworkControlPolicy.ForgeMacEnum ForgeMac
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Determines the LLDP setting on an interface on the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricLldpSettings LldpSettings
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Determines the MAC addresses that have to be registered with the switch.\n* `nativeVlanOnly` - Register only the MAC addresses learnt on the native VLAN.\n* `allVlans` - Register all the MAC addresses learnt on all the allowed VLANs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricEthNetworkControlPolicy.MacRegistrationModeEnum MacRegistrationMode
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
        /// <para type="description">"An array of relationships to vnicEthNetworkPolicy resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<VnicEthNetworkPolicyRelationship> NetworkPolicy
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Determines the state of the virtual interface (vethernet / vfc) on the switch when a suitable uplink is not pinned.\n* `linkDown` - The vethernet will go down in case a suitable uplink is not pinned.\n* `warning` - The vethernet will remain up even if a suitable uplink is not pinned."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricEthNetworkControlPolicy.UplinkFailActionEnum UplinkFailAction
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricEthNetworkGroupPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricEthNetworkGroupPolicy")]
    public class SetIntersightFabricEthNetworkGroupPolicy : SetCmdletBase
    {
        public SetIntersightFabricEthNetworkGroupPolicy()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricEthNetworkGroupPolicy();
            MethodName = "UpdateFabricEthNetworkGroupPolicyWithHttpInfo";
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"VLAN configuration for the virtual interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricVlanSettings VlanSettings
        {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricEthNetworkPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricEthNetworkPolicy")]
    public class SetIntersightFabricEthNetworkPolicy : SetCmdletBase
    {
        public SetIntersightFabricEthNetworkPolicy()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricEthNetworkPolicy();
            MethodName = "UpdateFabricEthNetworkPolicyWithHttpInfo";
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
        /// <para type="description">"An array of relationships to fabricBaseSwitchProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FabricBaseSwitchProfileRelationship> Profiles
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricFcNetworkPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricFcNetworkPolicy")]
    public class SetIntersightFabricFcNetworkPolicy : SetCmdletBase
    {
        public SetIntersightFabricFcNetworkPolicy()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricFcNetworkPolicy();
            MethodName = "UpdateFabricFcNetworkPolicyWithHttpInfo";
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
        /// <para type="description">"Enable or Disable Trunking on all of configured FC uplink ports."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool EnableTrunking
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
        /// <para type="description">"An array of relationships to fabricBaseSwitchProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FabricBaseSwitchProfileRelationship> Profiles
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricFcStorageRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricFcStorageRole")]
    public class SetIntersightFabricFcStorageRole : SetCmdletBase
    {
        public SetIntersightFabricFcStorageRole()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricFcStorageRole();
            MethodName = "UpdateFabricFcStorageRoleWithHttpInfo";
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
        /// <para type="description">"Admin configured speed for the port.\n* `16Gbps` - Admin configurable speed 16Gbps.\n* `8Gbps` - Admin configurable speed 8Gbps.\n* `32Gbps` - Admin configurable speed 32Gbps.\n* `64Gbps` - Admin configurable speed 64Gbps.\n* `Auto` - Admin configurable speed AUTO ( default )."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricFcStorageRole.AdminSpeedEnum AdminSpeed
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Breakout port Identifier of the Switch Interface.\nWhen a port is not configured as a breakout port, the aggregatePortId is set to 0, and unused.\nWhen a port is configured as a breakout port, the 'aggregatePortId' port number as labeled on the equipment,\ne.g. the id of the port on the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long AggregatePortId
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
        /// <para type="description">"Port Identifier of the Switch/FEX/Chassis Interface.\nWhen a port is not configured as a breakout port, the portId is the port number as labeled on the equipment,\ne.g. the id of the port on the switch, FEX or chassis.\nWhen a port is configured as a breakout port, the 'portId' represents the port id on the fanout side of the breakout cable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 108)]
        public long PortId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricPortPolicyRelationship PortPolicy
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Slot Identifier of the Switch/FEX/Chassis Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 5)]
        public long SlotId
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
        /// <para type="description">"The user defined label assigned to a Port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[ !#$%\\s+&\\(\\)\\*\\+,\\-\\./:;\\?@\\[\\]_\\{\\|\\}~a-zA-Z0-9]*$")]
        public string UserLabel
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Virtual San Identifier associated to the FC port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 4093)]
        public long VsanId
        {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricFcUplinkPcRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricFcUplinkPcRole")]
    public class SetIntersightFabricFcUplinkPcRole : SetCmdletBase
    {
        public SetIntersightFabricFcUplinkPcRole()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricFcUplinkPcRole();
            MethodName = "UpdateFabricFcUplinkPcRoleWithHttpInfo";
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
        /// <para type="description">"Admin configured speed for the port.\n* `16Gbps` - Admin configurable speed 16Gbps.\n* `8Gbps` - Admin configurable speed 8Gbps.\n* `32Gbps` - Admin configurable speed 32Gbps.\n* `64Gbps` - Admin configurable speed 64Gbps.\n* `Auto` - Admin configurable speed AUTO ( default )."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricFcUplinkPcRole.AdminSpeedEnum AdminSpeed
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"Fill pattern to differentiate the configs in NPIV.\n* `Idle` - Fc Fill Pattern type Idle.\n* `Arbff` - Fc Fill Pattern type Arbff."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricFcUplinkPcRole.FillPatternEnum FillPattern
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
        /// <para type="description">"Unique Identifier of the port-channel, local to this switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 256)]
        public long PcId
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricPortPolicyRelationship PortPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FabricPortIdentifier> Ports
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
        /// <para type="description">"The user defined label assigned to the a Port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[ !#$%\\s+&\\(\\)\\*\\+,\\-\\./:;\\?@\\[\\]_\\{\\|\\}~a-zA-Z0-9]*$")]
        public string UserLabel
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Virtual San Identifier associated to the FC port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 4093)]
        public long VsanId
        {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricFcUplinkRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricFcUplinkRole")]
    public class SetIntersightFabricFcUplinkRole : SetCmdletBase
    {
        public SetIntersightFabricFcUplinkRole()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricFcUplinkRole();
            MethodName = "UpdateFabricFcUplinkRoleWithHttpInfo";
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
        /// <para type="description">"Admin configured speed for the port.\n* `16Gbps` - Admin configurable speed 16Gbps.\n* `8Gbps` - Admin configurable speed 8Gbps.\n* `32Gbps` - Admin configurable speed 32Gbps.\n* `64Gbps` - Admin configurable speed 64Gbps.\n* `Auto` - Admin configurable speed AUTO ( default )."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricFcUplinkRole.AdminSpeedEnum AdminSpeed
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Breakout port Identifier of the Switch Interface.\nWhen a port is not configured as a breakout port, the aggregatePortId is set to 0, and unused.\nWhen a port is configured as a breakout port, the 'aggregatePortId' port number as labeled on the equipment,\ne.g. the id of the port on the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long AggregatePortId
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"Fill pattern to differentiate the configs in NPIV.\n* `Idle` - Fc Fill Pattern type Idle.\n* `Arbff` - Fc Fill Pattern type Arbff."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricFcUplinkRole.FillPatternEnum FillPattern
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
        /// <para type="description">"Port Identifier of the Switch/FEX/Chassis Interface.\nWhen a port is not configured as a breakout port, the portId is the port number as labeled on the equipment,\ne.g. the id of the port on the switch, FEX or chassis.\nWhen a port is configured as a breakout port, the 'portId' represents the port id on the fanout side of the breakout cable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 108)]
        public long PortId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricPortPolicyRelationship PortPolicy
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Slot Identifier of the Switch/FEX/Chassis Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 5)]
        public long SlotId
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
        /// <para type="description">"The user defined label assigned to a Port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[ !#$%\\s+&\\(\\)\\*\\+,\\-\\./:;\\?@\\[\\]_\\{\\|\\}~a-zA-Z0-9]*$")]
        public string UserLabel
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Virtual San Identifier associated to the FC port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 4093)]
        public long VsanId
        {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricFcZonePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricFcZonePolicy")]
    public class SetIntersightFabricFcZonePolicy : SetCmdletBase
    {
        public SetIntersightFabricFcZonePolicy()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricFcZonePolicy();
            MethodName = "UpdateFabricFcZonePolicyWithHttpInfo";
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FabricFcZoneMember> FcTargetMembers
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Type of FC zoning. Allowed values are SIST, SIMT and None.\n* `SIST` - The system automatically creates one zone for each vHBA and storage port pair. Each zone has two members.\n* `SIMT` - The system automatically creates one zone for each vHBA. Configure this type of zoning if the number of zones created is likely to exceed the maximum supported number of zones.\n* `None` - FC zoning is not configured."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricFcZonePolicy.FcTargetZoningTypeEnum FcTargetZoningType
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricFcoeUplinkPcRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricFcoeUplinkPcRole")]
    public class SetIntersightFabricFcoeUplinkPcRole : SetCmdletBase
    {
        public SetIntersightFabricFcoeUplinkPcRole()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricFcoeUplinkPcRole();
            MethodName = "UpdateFabricFcoeUplinkPcRoleWithHttpInfo";
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
        /// <para type="description">"Admin configured speed for the port.\n* `Auto` - Admin configurable speed AUTO ( default ).\n* `1Gbps` - Admin configurable speed 1Gbps.\n* `10Gbps` - Admin configurable speed 10Gbps.\n* `25Gbps` - Admin configurable speed 25Gbps.\n* `40Gbps` - Admin configurable speed 40Gbps.\n* `100Gbps` - Admin configurable speed 100Gbps.\n* `NegAuto25Gbps` - Admin configurable 25Gbps auto negotiation for ports and port-channels.Speed is applicable on Ethernet Uplink, Ethernet Appliance and FCoE Uplink port and port-channel roles.This speed config is only applicable to non-breakout ports on UCS-FI-6454 and UCS-FI-64108."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricFcoeUplinkPcRole.AdminSpeedEnum AdminSpeed
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"Forward error correction configuration for Fcoe Uplink Port Channel member ports.\n* `Auto` - Forward error correction option 'Auto'. Supported speeds are Auto, 1Gbps, 10Gbps, 25Gbps, 40Gbps and 100 Gbps.\n* `Cl91` - Forward error correction option 'cl91'. Supported speeds are 25Gbps and 100 Gbps.\n* `Cl74` - Forward error correction option 'cl74'. Supported speeds are 25Gbps.\n* `rs-cons16` - Forward error correction option \"rs-cons16\". Supported speeds are 25Gbps.\n* `rs-ieee` - Forward error correction option \"rs-ieee\". Supported speeds are 25Gbps.\n* `Off` - Turn off forward error correction. Supported speeds are 25Gbps and 100 Gbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricFcoeUplinkPcRole.FecEnum Fec
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricLinkAggregationPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricLinkAggregationPolicyRelationship LinkAggregationPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricLinkControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricLinkControlPolicyRelationship LinkControlPolicy
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
        /// <para type="description">"Unique Identifier of the port-channel, local to this switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 256)]
        public long PcId
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricPortPolicyRelationship PortPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FabricPortIdentifier> Ports
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
        /// <para type="description">"The user defined label assigned to the a Port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[ !#$%\\s+&\\(\\)\\*\\+,\\-\\./:;\\?@\\[\\]_\\{\\|\\}~a-zA-Z0-9]*$")]
        public string UserLabel
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricFcoeUplinkRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricFcoeUplinkRole")]
    public class SetIntersightFabricFcoeUplinkRole : SetCmdletBase
    {
        public SetIntersightFabricFcoeUplinkRole()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricFcoeUplinkRole();
            MethodName = "UpdateFabricFcoeUplinkRoleWithHttpInfo";
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
        /// <para type="description">"Admin configured speed for the port.\n* `Auto` - Admin configurable speed AUTO ( default ).\n* `1Gbps` - Admin configurable speed 1Gbps.\n* `10Gbps` - Admin configurable speed 10Gbps.\n* `25Gbps` - Admin configurable speed 25Gbps.\n* `40Gbps` - Admin configurable speed 40Gbps.\n* `100Gbps` - Admin configurable speed 100Gbps.\n* `NegAuto25Gbps` - Admin configurable 25Gbps auto negotiation for ports and port-channels.Speed is applicable on Ethernet Uplink, Ethernet Appliance and FCoE Uplink port and port-channel roles.This speed config is only applicable to non-breakout ports on UCS-FI-6454 and UCS-FI-64108."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricFcoeUplinkRole.AdminSpeedEnum AdminSpeed
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Breakout port Identifier of the Switch Interface.\nWhen a port is not configured as a breakout port, the aggregatePortId is set to 0, and unused.\nWhen a port is configured as a breakout port, the 'aggregatePortId' port number as labeled on the equipment,\ne.g. the id of the port on the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long AggregatePortId
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"Forward error correction configuration for the port.\n* `Auto` - Forward error correction option 'Auto'. Supported speeds are Auto, 1Gbps, 10Gbps, 25Gbps, 40Gbps and 100 Gbps.\n* `Cl91` - Forward error correction option 'cl91'. Supported speeds are 25Gbps and 100 Gbps.\n* `Cl74` - Forward error correction option 'cl74'. Supported speeds are 25Gbps.\n* `rs-cons16` - Forward error correction option \"rs-cons16\". Supported speeds are 25Gbps.\n* `rs-ieee` - Forward error correction option \"rs-ieee\". Supported speeds are 25Gbps.\n* `Off` - Turn off forward error correction. Supported speeds are 25Gbps and 100 Gbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricFcoeUplinkRole.FecEnum Fec
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricLinkControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricLinkControlPolicyRelationship LinkControlPolicy
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
        /// <para type="description">"Port Identifier of the Switch/FEX/Chassis Interface.\nWhen a port is not configured as a breakout port, the portId is the port number as labeled on the equipment,\ne.g. the id of the port on the switch, FEX or chassis.\nWhen a port is configured as a breakout port, the 'portId' represents the port id on the fanout side of the breakout cable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 108)]
        public long PortId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricPortPolicyRelationship PortPolicy
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Slot Identifier of the Switch/FEX/Chassis Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 5)]
        public long SlotId
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
        /// <para type="description">"The user defined label assigned to a Port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[ !#$%\\s+&\\(\\)\\*\\+,\\-\\./:;\\?@\\[\\]_\\{\\|\\}~a-zA-Z0-9]*$")]
        public string UserLabel
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricFlowControlPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricFlowControlPolicy")]
    public class SetIntersightFabricFlowControlPolicy : SetCmdletBase
    {
        public SetIntersightFabricFlowControlPolicy()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricFlowControlPolicy();
            MethodName = "UpdateFabricFlowControlPolicyWithHttpInfo";
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
        /// <para type="description">"Configure the Priority Flow Control (PFC) for each port to enable the no-drop behavior for the CoS defined by the System QoS Policy and an Ethernet QoS policy. If Auto and On is selected for PFC, the Receive and Send link level flow control will be Off.\n* `auto` - Enables the no-drop CoS values to be advertised by the DCBXP and negotiated with the peer.A successful negotiation enables PFC on the no-drop CoS.Any failures because of a mismatch in the capability of peers causes the PFC not to be enabled.\n* `on` - Enables PFC on the local port regardless of the capability of the peers.\n* `off` - Disable PFC on the local port regardless of the capability of the peers."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricFlowControlPolicy.PriorityFlowControlModeEnum PriorityFlowControlMode
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Link-level Flow Control configured in the receive direction.\n* `Disabled` - Admin configured Disabled State.\n* `Enabled` - Admin configured Enabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricFlowControlPolicy.ReceiveDirectionEnum ReceiveDirection
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Link-level Flow Control configured in the send direction.\n* `Disabled` - Admin configured Disabled State.\n* `Enabled` - Admin configured Enabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricFlowControlPolicy.SendDirectionEnum SendDirection
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricLanPinGroup.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricLanPinGroup")]
    public class SetIntersightFabricLanPinGroup : SetCmdletBase
    {
        public SetIntersightFabricLanPinGroup()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricLanPinGroup();
            MethodName = "UpdateFabricLanPinGroupWithHttpInfo";
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
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Name of the Pingroup for static pinning."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"A reference to a fabricAbstractInterfaceRole resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricAbstractInterfaceRoleRelationship PinTargetInterfaceRole
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricPortPolicyRelationship PortPolicy
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricLinkAggregationPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricLinkAggregationPolicy")]
    public class SetIntersightFabricLinkAggregationPolicy : SetCmdletBase
    {
        public SetIntersightFabricLinkAggregationPolicy()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricLinkAggregationPolicy();
            MethodName = "UpdateFabricLinkAggregationPolicyWithHttpInfo";
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
        /// <para type="description">"Flag used to indicate whether LACP PDUs are to be sent 'fast', i.e., every 1 second.\n* `normal` - The expanded 4th generation UCS Fabric Interconnect with 108 ports.\n* `fast` - The standard 4th generation UCS Fabric Interconnect with 54 ports."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricLinkAggregationPolicy.LacpRateEnum LacpRate
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
        /// <para type="description">"Flag tells the switch whether to suspend the port if it didn’t receive LACP PDU."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool SuspendIndividual
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricLinkControlPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricLinkControlPolicy")]
    public class SetIntersightFabricLinkControlPolicy : SetCmdletBase
    {
        public SetIntersightFabricLinkControlPolicy()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricLinkControlPolicy();
            MethodName = "UpdateFabricLinkControlPolicyWithHttpInfo";
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<MoTag> Tags
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"UDLD related configurations for the port and port-channel."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricUdldSettings UdldSettings
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricMacSecPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricMacSecPolicy")]
    public class SetIntersightFabricMacSecPolicy : SetCmdletBase
    {
        public SetIntersightFabricMacSecPolicy()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricMacSecPolicy();
            MethodName = "UpdateFabricMacSecPolicyWithHttpInfo";
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
        /// <para type="description">"Cipher suite to be used for MACsec encryption.\n* `GCM-AES-XPN-256` - An extended Cipher Suite of GCM-AES-256 used in MACsec (Media Access Control Security) that incorporates Extended Packet Numbering (XPN) for enhanced security and scalability.\n* `GCM-AES-128` - This Cipher Suite employs the Advanced Encryption Standard (AES) with a 128-bit key in Galois/Counter Mode, offering both encryption and authentication.\n* `GCM-AES-256` - This Cipher Suite utilizes Advanced Encryption Standard (AES) with a 256-bit key in Galois/Counter Mode, offering a higher level of security compared to GCM-AES-128 due to the larger key size.\n* `GCM-AES-XPN-128` - An extended Cipher Suite of GCM-AES-128  used in MACsec (Media Access Control Security) that incorporates Extended Packet Numbering (XPN) to enhance security and scalability."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricMacSecPolicy.CipherSuiteEnum CipherSuite
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The MACsec confidentiality offset specifies the number of bytes starting from the frame header. MACsec encrypts only the bytes after the offset in a frame.\n* `CONF-OFFSET-0` - A value of 0 means the entire ethernet frame is encrypted.\n* `CONF-OFFSET-30` - The first 30 bytes of the ethernet frame are not encrypted, and the rest of the frame is encrypted.\n* `CONF-OFFSET-50` - The first 50 bytes of the ethernet frame are not encrypted, and the rest of the frame is encrypted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricMacSecPolicy.ConfidentialityOffsetEnum ConfidentialityOffset
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
        /// <para type="description">"Fallback keychain for managing an alternative set of security keys to be used when a secure session cannot be established using the primary keychain."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricSecKeyChain FallbackKeyChain
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Configures inclusion of the optional integrity check value (ICV) indicator as part of the transmitted MACsec key agreement protocol data unit (PDU)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IncludeIcvIndicator
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The key server is selected by comparing key-server priority values during MACsec key agreement (MKA) message exchange between peer devices. Valid values range from 0 to 255. The lower the value, the higher the chance it will be selected as the key server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long KeyServerPriority
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Extensible authentication protocol over LAN (EAPoL). MACsec transmits MACsec key agreement (MKA) protocol data units (PDUs) using EAPoL packets to establish a secure session."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricMacSecEaPol MacSecEaPol
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
        /// <para type="description">"Primary keychain for managing the default set of security keys for encryption and decryption."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricSecKeyChain PrimaryKeyChain
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Defines the size of the replay protection window. It determines the number of packets that can be received out of order without being considered replay attacks."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long ReplayWindowSize
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Time in seconds to force secure association key (SAK) rekey. Valid range is from 60 to 2592000 seconds when configured. When not configured, the SAK rekey interval is determined based on the interface speed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long SakExpiryTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The security policy specifies the level of MACsec enforcement on network traffic passing through a given interface.\nShould secure allows unencrypted traffic to flow until the MACsec key agreement (MKA) session is secured. After the MKA session is secured, the policy switches to only allow encrypted traffic to flow. Must secure imposes only MACsec encrypted traffic to flow. Traffic will be dropped, until the MKA session is not secured.\n* `Should-secure` - Should secure allows unencrypted traffic to flow until the MACsec key agreement (MKA) session is secured. After the MKA session is secured, the policy switches to only allow encrypted traffic to flow.\n* `Must-secure` - Must secure imposes only MACsec encrypted traffic to flow. Traffic will be dropped, until the MKA session is not secured."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricMacSecPolicy.SecurityPolicyEnum SecurityPolicy
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricMulticastPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricMulticastPolicy")]
    public class SetIntersightFabricMulticastPolicy : SetCmdletBase
    {
        public SetIntersightFabricMulticastPolicy()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricMulticastPolicy();
            MethodName = "UpdateFabricMulticastPolicyWithHttpInfo";
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
        /// <para type="description">"Used to define the IGMP Querier IP address."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string QuerierIpAddress
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Used to define the IGMP Querier IP address of the peer switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string QuerierIpAddressPeer
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Administrative state of the IGMP Querier for this VLAN.\n* `Disabled` - Admin configured Disabled State.\n* `Enabled` - Admin configured Enabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricMulticastPolicy.QuerierStateEnum QuerierState
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Administrative state of the IGMP Snooping for this VLAN.\n* `Enabled` - Admin configured Enabled State.\n* `Disabled` - Admin configured Disabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricMulticastPolicy.SnoopingStateEnum SnoopingState
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Administrative state of the IGMP source IP proxy for this VLAN.\n* `Enabled` - Admin configured Enabled State.\n* `Disabled` - Admin configured Disabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricMulticastPolicy.SrcIpProxyEnum SrcIpProxy
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricPcOperation.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricPcOperation")]
    public class SetIntersightFabricPcOperation : SetCmdletBase
    {
        public SetIntersightFabricPcOperation()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricPcOperation();
            MethodName = "UpdateFabricPcOperationWithHttpInfo";
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
        /// <para type="description">"An operation that has to be perfomed on the port channel. Default value is None which means there will be no implicit port operation triggered.\n* `None` - No admin triggered action.\n* `SetUserLabel` - Admin triggered operation to set the user label on the port channel."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricPcOperation.AdminActionEnum AdminAction
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Admin configured state to disable the port channel.\n* `Enabled` - Admin configured Enabled State.\n* `Disabled` - Admin configured Disabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricPcOperation.AdminStateEnum AdminState
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The configured state of these settings in the target chassis. The value is any one of Applied, Applying, Failed. Applied - This state denotes that the admin state changes are applied successfully in the target FI domain. Applying - This state denotes that the admin state changes are being applied in the target FI domain. Failed - This state denotes that the admin state changes could not be applied in the target FI domain.\n* `None` - Nil value when no action has been triggered by the user.\n* `Applied` - User configured settings are in applied state.\n* `Applying` - User settings are being applied on the target server.\n* `Failed` - User configured settings could not be applied."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricPcOperation.ConfigStateEnum ConfigState
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
        /// <para type="description">"A reference to a networkElement resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NetworkElementRelationship NetworkElement
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"Port Channel Identifier for the collection of ports."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long PcId
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
        /// <para type="description">"The user defined label assigned to the a Port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[ !#$%\\s+&\\(\\)\\*\\+,\\-\\./:;\\?@\\[\\]_\\{\\|\\}~a-zA-Z0-9]*$")]
        public string UserLabel
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricPortMode.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricPortMode")]
    public class SetIntersightFabricPortMode : SetCmdletBase
    {
        public SetIntersightFabricPortMode()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricPortMode();
            MethodName = "UpdateFabricPortModeWithHttpInfo";
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
        /// <para type="description">"Custom Port Mode specified for the port range.\n* `FibreChannel` - Fibre Channel Port Types.\n* `BreakoutEthernet10G` - Breakout Ethernet 10G Port Type.\n* `BreakoutEthernet25G` - Breakout Ethernet 25G Port Type.\n* `BreakoutFibreChannel8G` - Breakout FibreChannel 8G Port Type.\n* `BreakoutFibreChannel16G` - Breakout FibreChannel 16G Port Type.\n* `BreakoutFibreChannel32G` - Breakout FibreChannel 32G Port Type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricPortMode.CustomModeEnum CustomMode
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
        /// <para type="description">"Ending range of the Port Identifier."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long PortIdEnd
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Starting range of the Port Identifier."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long PortIdStart
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricPortPolicyRelationship PortPolicy
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Slot Identifier of the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long SlotId
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricPortOperation.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricPortOperation")]
    public class SetIntersightFabricPortOperation : SetCmdletBase
    {
        public SetIntersightFabricPortOperation()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricPortOperation();
            MethodName = "UpdateFabricPortOperationWithHttpInfo";
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
        /// <para type="description">"An operation that has to be perfomed on the switch or IOM port. Default value is None which means there will be no implicit port operation triggered.\n* `None` - No admin triggered action.\n* `ResetServerPortConfiguration` - Admin triggered operation to reset the server port to its original configuration.\n* `SetUserLabel` - Admin triggered operation to set the user label on the port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricPortOperation.AdminActionEnum AdminAction
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Admin configured state to disable the port.\n* `Enabled` - Admin configured Enabled State.\n* `Disabled` - Admin configured Disabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricPortOperation.AdminStateEnum AdminState
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Breakout port Identifier of the Switch Interface.\nWhen a port is not configured as a breakout port, the aggregatePortId is set to 0, and unused.\nWhen a port is configured as a breakout port, the 'aggregatePortId' port number as labeled on the equipment,\ne.g. the id of the port on the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long AggregatePortId
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The configured state of these settings in the target chassis. The value is any one of Applied, Applying, Failed. Applied - This state denotes that the admin state changes are applied successfully in the target FI domain. Applying - This state denotes that the admin state changes are being applied in the target FI domain. Failed - This state denotes that the admin state changes could not be applied in the target FI domain.\n* `None` - Nil value when no action has been triggered by the user.\n* `Applied` - User configured settings are in applied state.\n* `Applying` - User settings are being applied on the target server.\n* `Failed` - User configured settings could not be applied."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricPortOperation.ConfigStateEnum ConfigState
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"FEX/IOM identifier to denote its Host ports in the format - FexId/SlotId/PortId."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long FexId
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
        /// <para type="description">"A reference to a networkElement resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NetworkElementRelationship NetworkElement
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"Port Identifier of the Switch/FEX/Chassis Interface.\nWhen a port is not configured as a breakout port, the portId is the port number as labeled on the equipment,\ne.g. the id of the port on the switch, FEX or chassis.\nWhen a port is configured as a breakout port, the 'portId' represents the port id on the fanout side of the breakout cable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long PortId
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Slot Identifier of the Switch/FEX/Chassis Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long SlotId
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
        /// <para type="description">"The user defined label assigned to the a Port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[ !#$%\\s+&\\(\\)\\*\\+,\\-\\./:;\\?@\\[\\]_\\{\\|\\}~a-zA-Z0-9]*$")]
        public string UserLabel
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricPortPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricPortPolicy")]
    public class SetIntersightFabricPortPolicy : SetCmdletBase
    {
        public SetIntersightFabricPortPolicy()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricPortPolicy();
            MethodName = "UpdateFabricPortPolicyWithHttpInfo";
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
        /// <para type="description">"This field specifies the device model that this Port Policy is being configured for.\n* `UCS-FI-6454` - The standard 4th generation UCS Fabric Interconnect with 54 ports.\n* `UCS-FI-64108` - The expanded 4th generation UCS Fabric Interconnect with 108 ports.\n* `UCS-FI-6536` - The standard 5th generation UCS Fabric Interconnect with 36 ports.\n* `UCSX-S9108-100G` - Cisco UCS Fabric Interconnect 9108 100G with 8 ports.\n* `UCS-FI-6664` - The standard 6th generation UCS Fabric Interconnect with 64 ports.\n* `unknown` - Unknown device type, usage is TBD."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricPortPolicy.DeviceModelEnum DeviceModel
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
        /// <para type="description">"An array of relationships to fabricBaseSwitchProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FabricBaseSwitchProfileRelationship> Profiles
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricSanPinGroup.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricSanPinGroup")]
    public class SetIntersightFabricSanPinGroup : SetCmdletBase
    {
        public SetIntersightFabricSanPinGroup()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricSanPinGroup();
            MethodName = "UpdateFabricSanPinGroupWithHttpInfo";
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
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Name of the Pingroup for static pinning."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"A reference to a fabricAbstractInterfaceRole resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricAbstractInterfaceRoleRelationship PinTargetInterfaceRole
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricPortPolicyRelationship PortPolicy
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricServerRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricServerRole")]
    public class SetIntersightFabricServerRole : SetCmdletBase
    {
        public SetIntersightFabricServerRole()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricServerRole();
            MethodName = "UpdateFabricServerRoleWithHttpInfo";
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
        /// <para type="description">"Breakout port Identifier of the Switch Interface.\nWhen a port is not configured as a breakout port, the aggregatePortId is set to 0, and unused.\nWhen a port is configured as a breakout port, the 'aggregatePortId' port number as labeled on the equipment,\ne.g. the id of the port on the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long AggregatePortId
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Auto negotiation configuration for server port. This configuration is required only for FEX Model N9K-C93180YC-FX3 connected with 100G speed port on UCS-FI-6536 and should be set as True."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool AutoNegotiationDisabled
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"Forward error correction configuration for server port. This configuration is required only for FEX Model N9K-C93180YC-FX3 connected with 25G speed ports on UCS-FI-6454/UCS-FI-64108 and should be set as Cl74.\n* `Auto` - Forward error correction option 'Auto'. Supported speeds are Auto, 1Gbps, 10Gbps, 25Gbps, 40Gbps and 100 Gbps.\n* `Cl91` - Forward error correction option 'cl91'. Supported speeds are 25Gbps and 100 Gbps.\n* `Cl74` - Forward error correction option 'cl74'. Supported speeds are 25Gbps.\n* `rs-cons16` - Forward error correction option \"rs-cons16\". Supported speeds are 25Gbps.\n* `rs-ieee` - Forward error correction option \"rs-ieee\". Supported speeds are 25Gbps.\n* `Off` - Turn off forward error correction. Supported speeds are 25Gbps and 100 Gbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricServerRole.FecEnum Fec
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
        /// <para type="description">"Port Identifier of the Switch/FEX/Chassis Interface.\nWhen a port is not configured as a breakout port, the portId is the port number as labeled on the equipment,\ne.g. the id of the port on the switch, FEX or chassis.\nWhen a port is configured as a breakout port, the 'portId' represents the port id on the fanout side of the breakout cable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 108)]
        public long PortId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricPortPolicyRelationship PortPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Preferred device ID to be configured by user for the connected device. This ID must be specified together with the 'PreferredDeviceType' property. This ID will only takes effect if the actual connected device matches the 'PreferredDeviceType'. If the preferred ID is not available, the ID is automatically allocated and assigned by the system. If different preferred IDs are specified for the ports connected to the same device, only the preferred ID (if specified) of the port that is discovered first will be considered."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long PreferredDeviceId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Device type for which preferred ID to be configured. If the actual connected device does not match the specified device type, the system ignores the 'PreferredDeviceId' property.\n* `Auto` - Preferred Id will be ignored if specified with this type.\n* `RackServer` - Connected device type is Rack Unit Server.\n* `Chassis` - Connected device type is Chassis."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricServerRole.PreferredDeviceTypeEnum PreferredDeviceType
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Slot Identifier of the Switch/FEX/Chassis Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 5)]
        public long SlotId
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
        /// <para type="description">"The user defined label assigned to a Port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[ !#$%\\s+&\\(\\)\\*\\+,\\-\\./:;\\?@\\[\\]_\\{\\|\\}~a-zA-Z0-9]*$")]
        public string UserLabel
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricSpanDestEthPort.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricSpanDestEthPort")]
    public class SetIntersightFabricSpanDestEthPort : SetCmdletBase
    {
        public SetIntersightFabricSpanDestEthPort()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricSpanDestEthPort();
            MethodName = "UpdateFabricSpanDestEthPortWithHttpInfo";
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
        /// <para type="description">"Admin speed of the SPAN Destination Port.\n* `Auto` - Admin configurable speed AUTO ( default ).\n* `1Gbps` - Admin configurable speed 1Gbps.\n* `10Gbps` - Admin configurable speed 10Gbps.\n* `25Gbps` - Admin configurable speed 25Gbps.\n* `40Gbps` - Admin configurable speed 40Gbps.\n* `100Gbps` - Admin configurable speed 100Gbps.\n* `NegAuto25Gbps` - Admin configurable 25Gbps auto negotiation for ports and port-channels.Speed is applicable on Ethernet Uplink, Ethernet Appliance and FCoE Uplink port and port-channel roles.This speed config is only applicable to non-breakout ports on UCS-FI-6454 and UCS-FI-64108."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricSpanDestEthPort.AdminSpeedEnum AdminSpeed
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Breakout port Identifier of the Switch Interface.\nWhen a port is not configured as a breakout port, the aggregatePortId is set to 0, and unused.\nWhen a port is configured as a breakout port, the 'aggregatePortId' port number as labeled on the equipment,\ne.g. the id of the port on the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long AggregatePortId
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"Forward error correction setting of the SPAN Destination Port.\n* `Auto` - Forward error correction option 'Auto'. Supported speeds are Auto, 1Gbps, 10Gbps, 25Gbps, 40Gbps and 100 Gbps.\n* `Cl91` - Forward error correction option 'cl91'. Supported speeds are 25Gbps and 100 Gbps.\n* `Cl74` - Forward error correction option 'cl74'. Supported speeds are 25Gbps.\n* `rs-cons16` - Forward error correction option \"rs-cons16\". Supported speeds are 25Gbps.\n* `rs-ieee` - Forward error correction option \"rs-ieee\". Supported speeds are 25Gbps.\n* `Off` - Turn off forward error correction. Supported speeds are 25Gbps and 100 Gbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricSpanDestEthPort.FecEnum Fec
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
        /// <para type="description">"Port Identifier of the Switch Interface.\nWhen a port is not configured as a breakout port, the portId is the port number as labeled on the equipment,\ne.g. the id of the port on the switch, FEX or chassis.\nWhen a port is configured as a breakout port, the 'portId' represents the port id on the fanout side of the breakout cable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long PortId
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Slot Identifier of the Switch Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long SlotId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricSpanSession resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricSpanSessionRelationship SpanSession
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricSpanSession.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricSpanSession")]
    public class SetIntersightFabricSpanSession : SetCmdletBase
    {
        public SetIntersightFabricSpanSession()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricSpanSession();
            MethodName = "UpdateFabricSpanSessionWithHttpInfo";
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
        /// <para type="description">"Admin state to enable or disable the SPAN session.\n* `Disabled` - Admin configured Disabled State.\n* `Enabled` - Admin configured Enabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricSpanSession.AdminStateEnum AdminState
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"An array of relationships to fabricAbstractSpanDestPort resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FabricAbstractSpanDestPortRelationship> DestPorts
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
        /// <para type="description">"Name of the SPAN session. The name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.) or an underscore (_)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a networkElement resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NetworkElementRelationship NetworkElement
        {
            get;
            set;
        }









        // <summary>
        /// <para type="description">"An array of relationships to fabricAbstractSpanSourcePortChannel resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FabricAbstractSpanSourcePortChannelRelationship> SourcePortChannels
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An array of relationships to fabricAbstractSpanSourcePort resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FabricAbstractSpanSourcePortRelationship> SourcePorts
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An array of relationships to fabricAbstractSpanSourceVirtualIf resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FabricAbstractSpanSourceVirtualIfRelationship> SourceVirtualIfs
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An array of relationships to fabricSpanSourceVlan resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FabricSpanSourceVlanRelationship> SourceVlans
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Admin state to enable or disable spanning control packets.\n* `Disabled` - Admin configured Disabled State.\n* `Enabled` - Admin configured Enabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricSpanSession.SpanControlPacketsEnum SpanControlPackets
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricSwitchClusterProfile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricSwitchClusterProfile")]
    public class SetIntersightFabricSwitchClusterProfile : SetCmdletBase
    {
        public SetIntersightFabricSwitchClusterProfile()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricSwitchClusterProfile();
            MethodName = "UpdateFabricSwitchClusterProfileWithHttpInfo";
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FabricClusterAssignment> ClusterAssignments
        {
            get;
            set;
        }





        // <summary>
        /// <para type="description">"Description of the profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
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
        /// <para type="description">"Name of the profile instance or profile template."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.-]{1,64}$")]
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
        /// <para type="description">"A reference to a policyAbstractProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PolicyAbstractProfileRelationship SrcTemplate
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An array of relationships to fabricSwitchProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FabricSwitchProfileRelationship> SwitchProfiles
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
        /// <para type="description">"Defines the type of the profile. Accepted values are instance or template.\n* `instance` - The profile defines the configuration for a specific instance of a target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricSwitchClusterProfile.TypeEnum Type
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The user defined label assigned to the switch profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[ !#$%&\\(\\)\\*\\+,\\-\\./:;\\?@\\[\\]_\\{\\|\\}~a-zA-Z0-9]*$")]
        public string UserLabel
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricSwitchClusterProfileTemplate.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricSwitchClusterProfileTemplate")]
    public class SetIntersightFabricSwitchClusterProfileTemplate : SetCmdletBase
    {
        public SetIntersightFabricSwitchClusterProfileTemplate()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricSwitchClusterProfileTemplate();
            MethodName = "UpdateFabricSwitchClusterProfileTemplateWithHttpInfo";
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
        /// <para type="description">"Description of the profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
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
        /// <para type="description">"Name of the profile instance or profile template."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.-]{1,64}$")]
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
        /// <para type="description">"A reference to a policyAbstractProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PolicyAbstractProfileRelationship SrcTemplate
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"An array of relationships to fabricSwitchProfileTemplate resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FabricSwitchProfileTemplateRelationship> SwitchProfileTemplates
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
        /// <para type="description">"Defines the type of the profile. Accepted values are instance or template.\n* `instance` - The profile defines the configuration for a specific instance of a target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricSwitchClusterProfileTemplate.TypeEnum Type
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricSwitchControlPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricSwitchControlPolicy")]
    public class SetIntersightFabricSwitchControlPolicy : SetCmdletBase
    {
        public SetIntersightFabricSwitchControlPolicy()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricSwitchControlPolicy();
            MethodName = "UpdateFabricSwitchControlPolicyWithHttpInfo";
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
        /// <para type="description">"Encrypts MACsec keys in type-6 format. If a MACsec key is already provided in a type-6 format, the primary key decrypts it."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[^\"\\s]{16,64}$")]
        public string AesPrimaryKey
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
        /// <para type="description">"Enable or Disable Ethernet End Host Switching Mode.\n* `end-host` - In end-host mode, the fabric interconnects appear to the upstream devices as end hosts with multiple links.In this mode, the switch does not run Spanning Tree Protocol and avoids loops by following a set of rules for traffic forwarding.In case of ethernet switching mode - Ethernet end-host mode is also known as Ethernet host virtualizer.\n* `switch` - In switch mode, the switch runs Spanning Tree Protocol to avoid loops, and broadcast and multicast packets are handled in the traditional way.This is the traditional switch mode."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricSwitchControlPolicy.EthernetSwitchingModeEnum EthernetSwitchingMode
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"When enabled, a Registered State Change Notification (RSCN) is sent to the VIC adapter when any member port within the fabric port-channel goes down and vHBA would reset to restore the connection immediately. When disabled (default), vHBA reset is done only when all the members of a fabric port-channel are down.\n* `Disabled` - Admin configured Disabled State.\n* `Enabled` - Admin configured Enabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricSwitchControlPolicy.FabricPcVhbaResetEnum FabricPcVhbaReset
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Enable or Disable FC End Host Switching Mode.\n* `end-host` - In end-host mode, the fabric interconnects appear to the upstream devices as end hosts with multiple links.In this mode, the switch does not run Spanning Tree Protocol and avoids loops by following a set of rules for traffic forwarding.In case of ethernet switching mode - Ethernet end-host mode is also known as Ethernet host virtualizer.\n* `switch` - In switch mode, the switch runs Spanning Tree Protocol to avoid loops, and broadcast and multicast packets are handled in the traditional way.This is the traditional switch mode."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricSwitchControlPolicy.FcSwitchingModeEnum FcSwitchingMode
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"This specifies the MAC aging option and time settings."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricMacAgingSettings MacAgingSettings
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
        /// <para type="description">"An array of relationships to fabricBaseSwitchProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FabricBaseSwitchProfileRelationship> Profiles
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The starting ID for VLANs reserved for internal use within the Fabric Interconnect. This VLAN ID is the starting ID of\na contiguous block of 128 VLANs that cannot be configured for user data.  This range of VLANs cannot be configured in\nVLAN policy.\nIf this property is not configured, VLAN range 3915 - 4042 is reserved for internal use by default."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(2, 3915)]
        public long ReservedVlanStartId
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
        /// <para type="description">"This specifies the UDLD Global configurations for this switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricUdldGlobalSettings UdldSettings
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"To enable or disable the VLAN port count optimization. This feature will always be enabled for\nCisco UCS Fabric Interconnect 9108 100G and also enabled on the IMM 6.x Bundle version and onwards."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool VlanPortOptimizationEnabled
        {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricSwitchProfile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricSwitchProfile")]
    public class SetIntersightFabricSwitchProfile : SetCmdletBase
    {
        public SetIntersightFabricSwitchProfile()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricSwitchProfile();
            MethodName = "UpdateFabricSwitchProfileWithHttpInfo";
        }


        // <summary>
        /// <para type="description">"User initiated action. Each profile type has its own supported actions. For HyperFlex cluster profile, the supported actions are -- Validate, Deploy, Continue, Retry, Abort, Unassign For server profile, the support actions are -- Deploy, Unassign."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Action
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<PolicyActionParam> ActionParams
        {
            get;
            set;
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
        /// <para type="description">"A reference to a networkElement resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NetworkElementRelationship AssignedSwitch
        {
            get;
            set;
        }





        // <summary>
        /// <para type="description">"The configuration state and results of the last configuration operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PolicyConfigContext ConfigContext
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"Description of the profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
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
        /// <para type="description">"Name of the profile instance or profile template."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"An array of relationships to policyAbstractPolicy resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<PolicyAbstractPolicyRelationship> PolicyBucket
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<PolicyScheduledAction> ScheduledActions
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a policyAbstractProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PolicyAbstractProfileRelationship SrcTemplate
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricSwitchClusterProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricSwitchClusterProfileRelationship SwitchClusterProfile
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Value indicating the switch side on which the switch profile or template has to be deployed.\n* `None` - Switch side not defined for the policy configurations in the switch profile or template.\n* `A` - Policy configurations in the switch profile or template to be deployed on fabric interconnect A.\n* `B` - Policy configurations in the switch profile or template to be deployed on fabric interconnect B."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricSwitchProfile.SwitchIdEnum SwitchId
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
        /// <para type="description">"Defines the type of the profile. Accepted values are instance or template.\n* `instance` - The profile defines the configuration for a specific instance of a target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricSwitchProfile.TypeEnum Type
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricSwitchProfileTemplate.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricSwitchProfileTemplate")]
    public class SetIntersightFabricSwitchProfileTemplate : SetCmdletBase
    {
        public SetIntersightFabricSwitchProfileTemplate()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricSwitchProfileTemplate();
            MethodName = "UpdateFabricSwitchProfileTemplateWithHttpInfo";
        }


        // <summary>
        /// <para type="description">"User initiated action. Each profile type has its own supported actions. For HyperFlex cluster profile, the supported actions are -- Validate, Deploy, Continue, Retry, Abort, Unassign For server profile, the support actions are -- Deploy, Unassign."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Action
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<PolicyActionParam> ActionParams
        {
            get;
            set;
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
        /// <para type="description">"The configuration state and results of the last configuration operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PolicyConfigContext ConfigContext
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"Description of the profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
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
        /// <para type="description">"Name of the profile instance or profile template."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"An array of relationships to policyAbstractPolicy resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<PolicyAbstractPolicyRelationship> PolicyBucket
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<PolicyScheduledAction> ScheduledActions
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a policyAbstractProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PolicyAbstractProfileRelationship SrcTemplate
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricSwitchClusterProfileTemplate resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricSwitchClusterProfileTemplateRelationship SwitchClusterProfileTemplate
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Value indicating the switch side on which the switch profile or template has to be deployed.\n* `None` - Switch side not defined for the policy configurations in the switch profile or template.\n* `A` - Policy configurations in the switch profile or template to be deployed on fabric interconnect A.\n* `B` - Policy configurations in the switch profile or template to be deployed on fabric interconnect B."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricSwitchProfileTemplate.SwitchIdEnum SwitchId
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
        /// <para type="description">"Defines the type of the profile. Accepted values are instance or template.\n* `instance` - The profile defines the configuration for a specific instance of a target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricSwitchProfileTemplate.TypeEnum Type
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricSystemQosPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricSystemQosPolicy")]
    public class SetIntersightFabricSystemQosPolicy : SetCmdletBase
    {
        public SetIntersightFabricSystemQosPolicy()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricSystemQosPolicy();
            MethodName = "UpdateFabricSystemQosPolicyWithHttpInfo";
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FabricQosClass> Classes
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
        /// <para type="description">"An array of relationships to fabricBaseSwitchProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FabricBaseSwitchProfileRelationship> Profiles
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

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricUplinkPcRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricUplinkPcRole")]
    public class SetIntersightFabricUplinkPcRole : SetCmdletBase
    {
        public SetIntersightFabricUplinkPcRole()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricUplinkPcRole();
            MethodName = "UpdateFabricUplinkPcRoleWithHttpInfo";
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
        /// <para type="description">"Admin configured speed for the port.\n* `Auto` - Admin configurable speed AUTO ( default ).\n* `1Gbps` - Admin configurable speed 1Gbps.\n* `10Gbps` - Admin configurable speed 10Gbps.\n* `25Gbps` - Admin configurable speed 25Gbps.\n* `40Gbps` - Admin configurable speed 40Gbps.\n* `100Gbps` - Admin configurable speed 100Gbps.\n* `NegAuto25Gbps` - Admin configurable 25Gbps auto negotiation for ports and port-channels.Speed is applicable on Ethernet Uplink, Ethernet Appliance and FCoE Uplink port and port-channel roles.This speed config is only applicable to non-breakout ports on UCS-FI-6454 and UCS-FI-64108."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricUplinkPcRole.AdminSpeedEnum AdminSpeed
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"An array of relationships to fabricEthNetworkGroupPolicy resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FabricEthNetworkGroupPolicyRelationship> EthNetworkGroupPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Forward error correction configuration for Uplink Port Channel member ports.\n* `Auto` - Forward error correction option 'Auto'. Supported speeds are Auto, 1Gbps, 10Gbps, 25Gbps, 40Gbps and 100 Gbps.\n* `Cl91` - Forward error correction option 'cl91'. Supported speeds are 25Gbps and 100 Gbps.\n* `Cl74` - Forward error correction option 'cl74'. Supported speeds are 25Gbps.\n* `rs-cons16` - Forward error correction option \"rs-cons16\". Supported speeds are 25Gbps.\n* `rs-ieee` - Forward error correction option \"rs-ieee\". Supported speeds are 25Gbps.\n* `Off` - Turn off forward error correction. Supported speeds are 25Gbps and 100 Gbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricUplinkPcRole.FecEnum Fec
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricFlowControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricFlowControlPolicyRelationship FlowControlPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricLinkAggregationPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricLinkAggregationPolicyRelationship LinkAggregationPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricLinkControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricLinkControlPolicyRelationship LinkControlPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricMacSecPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricMacSecPolicyRelationship MacSecPolicy
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
        /// <para type="description">"Unique Identifier of the port-channel, local to this switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 256)]
        public long PcId
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricPortPolicyRelationship PortPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FabricPortIdentifier> Ports
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
        /// <para type="description">"The user defined label assigned to the a Port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[ !#$%\\s+&\\(\\)\\*\\+,\\-\\./:;\\?@\\[\\]_\\{\\|\\}~a-zA-Z0-9]*$")]
        public string UserLabel
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricUplinkRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricUplinkRole")]
    public class SetIntersightFabricUplinkRole : SetCmdletBase
    {
        public SetIntersightFabricUplinkRole()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricUplinkRole();
            MethodName = "UpdateFabricUplinkRoleWithHttpInfo";
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
        /// <para type="description">"Admin configured speed for the port.\n* `Auto` - Admin configurable speed AUTO ( default ).\n* `1Gbps` - Admin configurable speed 1Gbps.\n* `10Gbps` - Admin configurable speed 10Gbps.\n* `25Gbps` - Admin configurable speed 25Gbps.\n* `40Gbps` - Admin configurable speed 40Gbps.\n* `100Gbps` - Admin configurable speed 100Gbps.\n* `NegAuto25Gbps` - Admin configurable 25Gbps auto negotiation for ports and port-channels.Speed is applicable on Ethernet Uplink, Ethernet Appliance and FCoE Uplink port and port-channel roles.This speed config is only applicable to non-breakout ports on UCS-FI-6454 and UCS-FI-64108."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricUplinkRole.AdminSpeedEnum AdminSpeed
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Breakout port Identifier of the Switch Interface.\nWhen a port is not configured as a breakout port, the aggregatePortId is set to 0, and unused.\nWhen a port is configured as a breakout port, the 'aggregatePortId' port number as labeled on the equipment,\ne.g. the id of the port on the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long AggregatePortId
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"An array of relationships to fabricEthNetworkGroupPolicy resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<FabricEthNetworkGroupPolicyRelationship> EthNetworkGroupPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Forward error correction configuration for the port.\n* `Auto` - Forward error correction option 'Auto'. Supported speeds are Auto, 1Gbps, 10Gbps, 25Gbps, 40Gbps and 100 Gbps.\n* `Cl91` - Forward error correction option 'cl91'. Supported speeds are 25Gbps and 100 Gbps.\n* `Cl74` - Forward error correction option 'cl74'. Supported speeds are 25Gbps.\n* `rs-cons16` - Forward error correction option \"rs-cons16\". Supported speeds are 25Gbps.\n* `rs-ieee` - Forward error correction option \"rs-ieee\". Supported speeds are 25Gbps.\n* `Off` - Turn off forward error correction. Supported speeds are 25Gbps and 100 Gbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricUplinkRole.FecEnum Fec
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricFlowControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricFlowControlPolicyRelationship FlowControlPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricLinkControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricLinkControlPolicyRelationship LinkControlPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricMacSecPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricMacSecPolicyRelationship MacSecPolicy
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
        /// <para type="description">"Port Identifier of the Switch/FEX/Chassis Interface.\nWhen a port is not configured as a breakout port, the portId is the port number as labeled on the equipment,\ne.g. the id of the port on the switch, FEX or chassis.\nWhen a port is configured as a breakout port, the 'portId' represents the port id on the fanout side of the breakout cable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 108)]
        public long PortId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricPortPolicyRelationship PortPolicy
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Slot Identifier of the Switch/FEX/Chassis Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 5)]
        public long SlotId
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
        /// <para type="description">"The user defined label assigned to a Port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[ !#$%\\s+&\\(\\)\\*\\+,\\-\\./:;\\?@\\[\\]_\\{\\|\\}~a-zA-Z0-9]*$")]
        public string UserLabel
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricVlan.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricVlan")]
    public class SetIntersightFabricVlan : SetCmdletBase
    {
        public SetIntersightFabricVlan()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricVlan();
            MethodName = "UpdateFabricVlanWithHttpInfo";
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
        /// <para type="description">"Enable to automatically allow this VLAN on all uplinks. Disable must be specified for Disjoint Layer 2 VLAN configuration. Default VLAN-1 cannot be configured as Disjoint Layer 2 VLAN."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool AutoAllowOnUplinks
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"A reference to a fabricEthNetworkPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricEthNetworkPolicyRelationship EthNetworkPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Used to define whether this VLAN is to be classified as 'native' for traffic in this FI."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsNative
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
        /// <para type="description">"A reference to a fabricMulticastPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricMulticastPolicyRelationship MulticastPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The 'name' used to identify this VLAN."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"The Primary VLAN ID of the VLAN, if the sharing type of the VLAN is Isolated or Community."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long PrimaryVlanId
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The sharing type of this VLAN.\n* `None` - This represents a regular VLAN.\n* `Primary` - This represents a primary VLAN.\n* `Isolated` - This represents an isolated VLAN.\n* `Community` - This represents a community VLAN."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricVlan.SharingTypeEnum SharingType
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
        /// <para type="description">"The identifier for this Virtual LAN."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 4093)]
        public long VlanId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a fabricVlanSet resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricVlanSetRelationship VlanSet
        {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricVsan.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricVsan")]
    public class SetIntersightFabricVsan : SetCmdletBase
    {
        public SetIntersightFabricVsan()
        {
            ApiInstance = new FabricApi(Config);
            ModelObject = new FabricVsan();
            MethodName = "UpdateFabricVsanWithHttpInfo";
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
        /// <para type="description">"Enables or Disables the default zoning state.\n* `Enabled` - Admin configured Enabled State.\n* `Disabled` - Admin configured Disabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricVsan.DefaultZoningEnum DefaultZoning
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a fabricFcNetworkPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricFcNetworkPolicyRelationship FcNetworkPolicy
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Logical grouping mode for fc ports."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string FcZoneSharingMode
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"FCOE Vlan associated to the VSAN configuration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 4093)]
        public long FcoeVlan
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
        /// <para type="description">"User given name for the VSAN configuration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
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
        /// <para type="description">"Virtual San Identifier in the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 4093)]
        public long VsanId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Used to indicate whether the VSAN Id is defined for storage or uplink or both traffics in FI.\n* `Uplink` - Vsan associated with uplink network.\n* `Storage` - Vsan associated with storage network.\n* `Common` - Vsan that is common for uplink and storage network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public FabricVsan.VsanScopeEnum VsanScope
        {
            get;
            set;
        }
    }
}