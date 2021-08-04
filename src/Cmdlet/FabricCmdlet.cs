using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricEthNetworkPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricEthNetworkPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricEthNetworkPolicy:GetCmdletBase
	{
		public GetIntersightFabricEthNetworkPolicy()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricEthNetworkPolicyListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricEthNetworkPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricEthNetworkPolicy")]
    public class NewIntersightFabricEthNetworkPolicy:NewCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to fabricSwitchProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<FabricSwitchProfileRelationship> Profiles {
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
    /// <para type="synopsis">This is the cmdlet to Set FabricFcUplinkRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricFcUplinkRole")]
    public class SetIntersightFabricFcUplinkRole:SetCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Admin configured speed for the port.\n* `Auto` - Admin configurable speed AUTO ( default ).\n* `8Gbps` - Admin configurable speed 8Gbps.\n* `16Gbps` - Admin configurable speed 16Gbps.\n* `32Gbps` - Admin configurable speed 32Gbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricFcUplinkRole.AdminSpeedEnum AdminSpeed {
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
        /// <para type="description">"Fill pattern to differentiate the configs in NPIV.\n* `Idle` - Fc Fill Pattern type Idle.\n* `Arbff` - Fc Fill Pattern type Arbff."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricFcUplinkRole.FillPatternEnum FillPattern {
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
        /// <para type="description">"Port Identifier of the Switch/FEX/Chassis Interface.\nWhen a port is not configured as a breakout port, the portId is the port number as labeled on the equipment,\ne.g. the id of the port on the switch, FEX or chassis.\nWhen a port is configured as a breakout port, the 'portId' represents the port id on the fanout side of the breakout cable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 108)]
        public long PortId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricPortPolicyRelationship PortPolicy {
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
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Virtual San Identifier associated to the FC port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 4093)]
        public long VsanId {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricFcUplinkRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricFcUplinkRole")]
    public class RemoveIntersightFabricFcUplinkRole:RemoveCmdletBase
	{
		public RemoveIntersightFabricFcUplinkRole()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricFcUplinkRoleWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricEthNetworkPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricEthNetworkPolicy")]
    public class SetIntersightFabricEthNetworkPolicy:SetCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to fabricSwitchProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<FabricSwitchProfileRelationship> Profiles {
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
    /// <para type="synopsis">This is the cmdlet to Remove FabricEthNetworkPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricEthNetworkPolicy")]
    public class RemoveIntersightFabricEthNetworkPolicy:RemoveCmdletBase
	{
		public RemoveIntersightFabricEthNetworkPolicy()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricEthNetworkPolicyWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricPortPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricPortPolicy")]
    public class SetIntersightFabricPortPolicy:SetCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This field specifies the device model that this Port Policy is being configured for.\n* `UCS-FI-6454` - The standard 4th generation UCS Fabric Interconnect with 54 ports.\n* `UCS-FI-64108` - The expanded 4th generation UCS Fabric Interconnect with 108 ports.\n* `unknown` - Unknown device type, usage is TBD."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricPortPolicy.DeviceModelEnum DeviceModel {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to fabricSwitchProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<FabricSwitchProfileRelationship> Profiles {
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
    /// <para type="synopsis">This is the cmdlet to Remove FabricPortPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricPortPolicy")]
    public class RemoveIntersightFabricPortPolicy:RemoveCmdletBase
	{
		public RemoveIntersightFabricPortPolicy()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricPortPolicyWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricEthNetworkGroupPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricEthNetworkGroupPolicy")]
    public class SetIntersightFabricEthNetworkGroupPolicy:SetCmdletBase
	{
		public SetIntersightFabricEthNetworkGroupPolicy()
		{
			ApiInstance = new FabricApi(Config);
            ModelObject = new FabricEthNetworkGroupPolicy();
            MethodName = "PatchFabricEthNetworkGroupPolicyWithHttpInfo";
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
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
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
        /// <para type="description">"VLAN configuration for the virtual interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricVlanSettings VlanSettings {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricEthNetworkGroupPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricEthNetworkGroupPolicy")]
    public class RemoveIntersightFabricEthNetworkGroupPolicy:RemoveCmdletBase
	{
		public RemoveIntersightFabricEthNetworkGroupPolicy()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricEthNetworkGroupPolicyWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricLinkAggregationPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricLinkAggregationPolicy")]
    public class NewIntersightFabricLinkAggregationPolicy:NewCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Flag used to indicate whether LACP PDUs are to be sent 'fast', i.e., every 1 second.\n* `normal` - The expanded 4th generation UCS Fabric Interconnect with 108 ports.\n* `fast` - The standard 4th generation UCS Fabric Interconnect with 54 ports."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricLinkAggregationPolicy.LacpRateEnum LacpRate {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Flag tells the switch whether to suspend the port if it didn’t receive LACP PDU."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool SuspendIndividual {
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
    /// <para type="synopsis">This is the cmdlet to Get FabricLinkAggregationPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricLinkAggregationPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricLinkAggregationPolicy:GetCmdletBase
	{
		public GetIntersightFabricLinkAggregationPolicy()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricLinkAggregationPolicyListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricSystemQosPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricSystemQosPolicy")]
    public class SetIntersightFabricSystemQosPolicy:SetCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<FabricQosClass> Classes {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to fabricSwitchProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<FabricSwitchProfileRelationship> Profiles {
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
    /// <para type="synopsis">This is the cmdlet to Remove FabricSystemQosPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricSystemQosPolicy")]
    public class RemoveIntersightFabricSystemQosPolicy:RemoveCmdletBase
	{
		public RemoveIntersightFabricSystemQosPolicy()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricSystemQosPolicyWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricFcNetworkPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricFcNetworkPolicy")]
    public class NewIntersightFabricFcNetworkPolicy:NewCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enable or Disable Trunking on all of configured FC uplink ports."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool EnableTrunking {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to fabricSwitchProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<FabricSwitchProfileRelationship> Profiles {
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
    /// <para type="synopsis">This is the cmdlet to Get FabricFcNetworkPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricFcNetworkPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricFcNetworkPolicy:GetCmdletBase
	{
		public GetIntersightFabricFcNetworkPolicy()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricFcNetworkPolicyListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricSwitchControlPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricSwitchControlPolicy")]
    public class SetIntersightFabricSwitchControlPolicy:SetCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This specifies the MAC aging option and time settings."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricMacAgingSettings MacAgingSettings {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to fabricSwitchProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<FabricSwitchProfileRelationship> Profiles {
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
        /// <para type="description">"This specifies the UDLD Global configurations for this switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricUdldGlobalSettings UdldSettings {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"To enable or disable the VLAN port count optimization."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool VlanPortOptimizationEnabled {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricSwitchControlPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricSwitchControlPolicy")]
    public class RemoveIntersightFabricSwitchControlPolicy:RemoveCmdletBase
	{
		public RemoveIntersightFabricSwitchControlPolicy()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricSwitchControlPolicyWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricPortMode.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricPortMode", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricPortMode:GetCmdletBase
	{
		public GetIntersightFabricPortMode()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricPortModeListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricPortMode.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricPortMode")]
    public class NewIntersightFabricPortMode:NewCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Custom Port Mode specified for the port range.\n* `FibreChannel` - Fibre Channel Port Types.\n* `BreakoutEthernet10G` - Breakout Ethernet 10G Port Type.\n* `BreakoutEthernet25G` - Breakout Ethernet 25G Port Type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricPortMode.CustomModeEnum CustomMode {
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
        /// <para type="description">"Ending range of the Port Identifier."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long PortIdEnd {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Starting range of the Port Identifier."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long PortIdStart {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricPortPolicyRelationship PortPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Slot Identifier of the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long SlotId {
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
    /// <para type="synopsis">This is the cmdlet to Get FabricEthNetworkControlPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricEthNetworkControlPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricEthNetworkControlPolicy:GetCmdletBase
	{
		public GetIntersightFabricEthNetworkControlPolicy()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricEthNetworkControlPolicyListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricEthNetworkControlPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricEthNetworkControlPolicy")]
    public class NewIntersightFabricEthNetworkControlPolicy:NewCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enables the CDP on an interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool CdpEnabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Determines if the MAC forging is allowed or denied on an interface.\n* `allow` - Allows mac forging on an interface.\n* `deny` - Denies mac forging on an interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricEthNetworkControlPolicy.ForgeMacEnum ForgeMac {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Determines the LLDP setting on an interface on the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricLldpSettings LldpSettings {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Determines the MAC addresses that have to be registered with the switch.\n* `nativeVlanOnly` - Register only the MAC addresses learnt on the native VLAN.\n* `allVlans` - Register all the MAC addresses learnt on all the allowed VLANs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricEthNetworkControlPolicy.MacRegistrationModeEnum MacRegistrationMode {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to vnicEthNetworkPolicy resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<VnicEthNetworkPolicyRelationship> NetworkPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
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
        /// <para type="description">"Determines the state of the virtual interface (vethernet / vfc) on the switch when a suitable uplink is not pinned.\n* `linkDown` - The vethernet will go down in case a suitable uplink is not pinned.\n* `warning` - The vethernet will remain up even if a suitable uplink is not pinned."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricEthNetworkControlPolicy.UplinkFailActionEnum UplinkFailAction {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricVlan.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricVlan")]
    public class SetIntersightFabricVlan:SetCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Used to determine whether this VLAN will be allowed on all uplink ports and PCs in this FI."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool AutoAllowOnUplinks {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricEthNetworkPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricEthNetworkPolicyRelationship EthNetworkPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Used to define whether this VLAN is to be classified as 'native' for traffic in this FI."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool IsNative {
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
        /// <para type="description">"A reference to a fabricMulticastPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricMulticastPolicyRelationship MulticastPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The 'name' used to identify this VLAN."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
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
        /// <para type="description">"The identifier for this Virtual LAN."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 4093)]
        public long VlanId {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricVlan.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricVlan")]
    public class RemoveIntersightFabricVlan:RemoveCmdletBase
	{
		public RemoveIntersightFabricVlan()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricVlanWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricServerRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricServerRole", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricServerRole:GetCmdletBase
	{
		public GetIntersightFabricServerRole()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricServerRoleListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricServerRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricServerRole")]
    public class NewIntersightFabricServerRole:NewCmdletBase
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
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
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
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricPortPolicyRelationship PortPolicy {
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
    /// <para type="synopsis">This is the cmdlet to Get FabricConfigResult.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricConfigResult", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricConfigResult:GetCmdletBase
	{
		public GetIntersightFabricConfigResult()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricConfigResultListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricElementIdentity.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricElementIdentity", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricElementIdentity:GetCmdletBase
	{
		public GetIntersightFabricElementIdentity()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricElementIdentityListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricUplinkPcRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricUplinkPcRole", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricUplinkPcRole:GetCmdletBase
	{
		public GetIntersightFabricUplinkPcRole()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricUplinkPcRoleListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricUplinkPcRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricUplinkPcRole")]
    public class NewIntersightFabricUplinkPcRole:NewCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Admin configured speed for the port.\n* `Auto` - Admin configurable speed AUTO ( default ).\n* `1Gbps` - Admin configurable speed 1Gbps.\n* `10Gbps` - Admin configurable speed 10Gbps.\n* `25Gbps` - Admin configurable speed 25Gbps.\n* `40Gbps` - Admin configurable speed 40Gbps.\n* `100Gbps` - Admin configurable speed 100Gbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricUplinkPcRole.AdminSpeedEnum AdminSpeed {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricFlowControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricFlowControlPolicyRelationship FlowControlPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricLinkAggregationPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricLinkAggregationPolicyRelationship LinkAggregationPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricLinkControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricLinkControlPolicyRelationship LinkControlPolicy {
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
        /// <para type="description">"Unique Identifier of the port-channel, local to this switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 256)]
        public long PcId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricPortPolicyRelationship PortPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<FabricPortIdentifier> Ports {
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
    /// <para type="synopsis">This is the cmdlet to Set FabricEthNetworkControlPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricEthNetworkControlPolicy")]
    public class SetIntersightFabricEthNetworkControlPolicy:SetCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enables the CDP on an interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool CdpEnabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Determines if the MAC forging is allowed or denied on an interface.\n* `allow` - Allows mac forging on an interface.\n* `deny` - Denies mac forging on an interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricEthNetworkControlPolicy.ForgeMacEnum ForgeMac {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Determines the LLDP setting on an interface on the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricLldpSettings LldpSettings {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Determines the MAC addresses that have to be registered with the switch.\n* `nativeVlanOnly` - Register only the MAC addresses learnt on the native VLAN.\n* `allVlans` - Register all the MAC addresses learnt on all the allowed VLANs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricEthNetworkControlPolicy.MacRegistrationModeEnum MacRegistrationMode {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to vnicEthNetworkPolicy resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<VnicEthNetworkPolicyRelationship> NetworkPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
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
        /// <para type="description">"Determines the state of the virtual interface (vethernet / vfc) on the switch when a suitable uplink is not pinned.\n* `linkDown` - The vethernet will go down in case a suitable uplink is not pinned.\n* `warning` - The vethernet will remain up even if a suitable uplink is not pinned."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricEthNetworkControlPolicy.UplinkFailActionEnum UplinkFailAction {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricEthNetworkControlPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricEthNetworkControlPolicy")]
    public class RemoveIntersightFabricEthNetworkControlPolicy:RemoveCmdletBase
	{
		public RemoveIntersightFabricEthNetworkControlPolicy()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricEthNetworkControlPolicyWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricFcUplinkPcRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricFcUplinkPcRole", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricFcUplinkPcRole:GetCmdletBase
	{
		public GetIntersightFabricFcUplinkPcRole()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricFcUplinkPcRoleListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricFcUplinkPcRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricFcUplinkPcRole")]
    public class NewIntersightFabricFcUplinkPcRole:NewCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Admin configured speed for the port.\n* `Auto` - Admin configurable speed AUTO ( default ).\n* `8Gbps` - Admin configurable speed 8Gbps.\n* `16Gbps` - Admin configurable speed 16Gbps.\n* `32Gbps` - Admin configurable speed 32Gbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricFcUplinkPcRole.AdminSpeedEnum AdminSpeed {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Fill pattern to differentiate the configs in NPIV.\n* `Idle` - Fc Fill Pattern type Idle.\n* `Arbff` - Fc Fill Pattern type Arbff."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricFcUplinkPcRole.FillPatternEnum FillPattern {
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
        /// <para type="description">"Unique Identifier of the port-channel, local to this switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 256)]
        public long PcId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricPortPolicyRelationship PortPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<FabricPortIdentifier> Ports {
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
        /// <para type="description">"Virtual San Identifier associated to the FC port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 4093)]
        public long VsanId {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricEthNetworkGroupPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricEthNetworkGroupPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricEthNetworkGroupPolicy:GetCmdletBase
	{
		public GetIntersightFabricEthNetworkGroupPolicy()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricEthNetworkGroupPolicyListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricEthNetworkGroupPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricEthNetworkGroupPolicy")]
    public class NewIntersightFabricEthNetworkGroupPolicy:NewCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
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
        /// <para type="description">"VLAN configuration for the virtual interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricVlanSettings VlanSettings {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricLinkControlPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricLinkControlPolicy")]
    public class NewIntersightFabricLinkControlPolicy:NewCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
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
        /// <para type="description">"UDLD related configurations for the port and port-channel."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricUdldSettings UdldSettings {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricLinkControlPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricLinkControlPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricLinkControlPolicy:GetCmdletBase
	{
		public GetIntersightFabricLinkControlPolicy()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricLinkControlPolicyListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricFcoeUplinkPcRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricFcoeUplinkPcRole", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricFcoeUplinkPcRole:GetCmdletBase
	{
		public GetIntersightFabricFcoeUplinkPcRole()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricFcoeUplinkPcRoleListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricFcoeUplinkPcRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricFcoeUplinkPcRole")]
    public class NewIntersightFabricFcoeUplinkPcRole:NewCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Admin configured speed for the port.\n* `Auto` - Admin configurable speed AUTO ( default ).\n* `1Gbps` - Admin configurable speed 1Gbps.\n* `10Gbps` - Admin configurable speed 10Gbps.\n* `25Gbps` - Admin configurable speed 25Gbps.\n* `40Gbps` - Admin configurable speed 40Gbps.\n* `100Gbps` - Admin configurable speed 100Gbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricFcoeUplinkPcRole.AdminSpeedEnum AdminSpeed {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricLinkAggregationPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricLinkAggregationPolicyRelationship LinkAggregationPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricLinkControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricLinkControlPolicyRelationship LinkControlPolicy {
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
        /// <para type="description">"Unique Identifier of the port-channel, local to this switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 256)]
        public long PcId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricPortPolicyRelationship PortPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<FabricPortIdentifier> Ports {
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
    /// <para type="synopsis">This is the cmdlet to Set FabricPortOperation.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricPortOperation")]
    public class SetIntersightFabricPortOperation:SetCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Admin configured state to disable the port.\n* `Enabled` - Admin configured Enabled State.\n* `Disabled` - Admin configured Disabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricPortOperation.AdminStateEnum AdminState {
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
        /// <para type="description">"The configured state of these settings in the target chassis. The value is any one of Applied, Applying, Failed. Applied - This state denotes that the admin state changes are applied successfully in the target FI domain. Applying - This state denotes that the admin state changes are being applied in the target FI domain. Failed - This state denotes that the admin state changes could not be applied in the target FI domain.\n* `None` - Nil value when no action has been triggered by the user.\n* `Applied` - User configured settings are in applied state.\n* `Applying` - User settings are being applied on the target server.\n* `Failed` - User configured settings could not be applied."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricPortOperation.ConfigStateEnum ConfigState {
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
        /// <para type="description">"Port Identifier of the Switch/FEX/Chassis Interface.\nWhen a port is not configured as a breakout port, the portId is the port number as labeled on the equipment,\ne.g. the id of the port on the switch, FEX or chassis.\nWhen a port is configured as a breakout port, the 'portId' represents the port id on the fanout side of the breakout cable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long PortId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Slot Identifier of the Switch/FEX/Chassis Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long SlotId {
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
    /// <para type="synopsis">This is the cmdlet to Remove FabricPortOperation.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricPortOperation")]
    public class RemoveIntersightFabricPortOperation:RemoveCmdletBase
	{
		public RemoveIntersightFabricPortOperation()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricPortOperationWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricServerRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricServerRole")]
    public class SetIntersightFabricServerRole:SetCmdletBase
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
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
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
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricPortPolicyRelationship PortPolicy {
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
    /// <para type="synopsis">This is the cmdlet to Remove FabricServerRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricServerRole")]
    public class RemoveIntersightFabricServerRole:RemoveCmdletBase
	{
		public RemoveIntersightFabricServerRole()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricServerRoleWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricLinkAggregationPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricLinkAggregationPolicy")]
    public class SetIntersightFabricLinkAggregationPolicy:SetCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Flag used to indicate whether LACP PDUs are to be sent 'fast', i.e., every 1 second.\n* `normal` - The expanded 4th generation UCS Fabric Interconnect with 108 ports.\n* `fast` - The standard 4th generation UCS Fabric Interconnect with 54 ports."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricLinkAggregationPolicy.LacpRateEnum LacpRate {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Flag tells the switch whether to suspend the port if it didn’t receive LACP PDU."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool SuspendIndividual {
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
    /// <para type="synopsis">This is the cmdlet to Remove FabricLinkAggregationPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricLinkAggregationPolicy")]
    public class RemoveIntersightFabricLinkAggregationPolicy:RemoveCmdletBase
	{
		public RemoveIntersightFabricLinkAggregationPolicy()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricLinkAggregationPolicyWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricFcoeUplinkRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricFcoeUplinkRole", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricFcoeUplinkRole:GetCmdletBase
	{
		public GetIntersightFabricFcoeUplinkRole()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricFcoeUplinkRoleListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricFcoeUplinkRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricFcoeUplinkRole")]
    public class NewIntersightFabricFcoeUplinkRole:NewCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Admin configured speed for the port.\n* `Auto` - Admin configurable speed AUTO ( default ).\n* `1Gbps` - Admin configurable speed 1Gbps.\n* `10Gbps` - Admin configurable speed 10Gbps.\n* `25Gbps` - Admin configurable speed 25Gbps.\n* `40Gbps` - Admin configurable speed 40Gbps.\n* `100Gbps` - Admin configurable speed 100Gbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricFcoeUplinkRole.AdminSpeedEnum AdminSpeed {
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
        /// <para type="description">"Forward error correction configuration for the port.\n* `Auto` - Forward error correction option 'Auto'.\n* `Cl91` - Forward error correction option 'cl91'.\n* `Cl74` - Forward error correction option 'cl74'."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricFcoeUplinkRole.FecEnum Fec {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricLinkControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricLinkControlPolicyRelationship LinkControlPolicy {
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
        /// <para type="description">"Port Identifier of the Switch/FEX/Chassis Interface.\nWhen a port is not configured as a breakout port, the portId is the port number as labeled on the equipment,\ne.g. the id of the port on the switch, FEX or chassis.\nWhen a port is configured as a breakout port, the 'portId' represents the port id on the fanout side of the breakout cable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 108)]
        public long PortId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricPortPolicyRelationship PortPolicy {
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
    /// <para type="synopsis">This is the cmdlet to New FabricPortPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricPortPolicy")]
    public class NewIntersightFabricPortPolicy:NewCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This field specifies the device model that this Port Policy is being configured for.\n* `UCS-FI-6454` - The standard 4th generation UCS Fabric Interconnect with 54 ports.\n* `UCS-FI-64108` - The expanded 4th generation UCS Fabric Interconnect with 108 ports.\n* `unknown` - Unknown device type, usage is TBD."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricPortPolicy.DeviceModelEnum DeviceModel {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to fabricSwitchProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<FabricSwitchProfileRelationship> Profiles {
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
    /// <para type="synopsis">This is the cmdlet to Get FabricPortPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricPortPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricPortPolicy:GetCmdletBase
	{
		public GetIntersightFabricPortPolicy()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricPortPolicyListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricLinkControlPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricLinkControlPolicy")]
    public class SetIntersightFabricLinkControlPolicy:SetCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
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
        /// <para type="description">"UDLD related configurations for the port and port-channel."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricUdldSettings UdldSettings {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricLinkControlPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricLinkControlPolicy")]
    public class RemoveIntersightFabricLinkControlPolicy:RemoveCmdletBase
	{
		public RemoveIntersightFabricLinkControlPolicy()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricLinkControlPolicyWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricSwitchProfile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricSwitchProfile")]
    public class SetIntersightFabricSwitchProfile:SetCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Action {
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
        /// <para type="description">"A reference to a networkElement resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NetworkElementRelationship AssignedSwitch {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This lists the pending configuration changes at the summary level. Detailed changes are saved in configChangeDetails as a separate object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PolicyConfigChange ConfigChanges {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The configuration state and results of the last configuration operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PolicyConfigContext ConfigContext {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
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
        /// <para type="description">"Name of the profile instance or profile template."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to policyAbstractPolicy resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<PolicyAbstractPolicyRelationship> PolicyBucket {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a policyAbstractProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PolicyAbstractProfileRelationship SrcTemplate {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricSwitchClusterProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricSwitchClusterProfileRelationship SwitchClusterProfile {
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
        /// <para type="description">"Defines the type of the profile. Accepted values are instance or template.\n* `instance` - The profile defines the configuration for a specific instance of a target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricSwitchProfile.TypeEnum Type {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricSwitchProfile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricSwitchProfile")]
    public class RemoveIntersightFabricSwitchProfile:RemoveCmdletBase
	{
		public RemoveIntersightFabricSwitchProfile()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricSwitchProfileWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricElementIdentity.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricElementIdentity")]
    public class SetIntersightFabricElementIdentity:SetCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Updated by UI/API to trigger specific chassis action type.\n* `None` - No operation value for maintenance actions on an equipment.\n* `Decommission` - Decommission the equipment and temporarily remove it from being managed by Intersight.\n* `Recommission` - Recommission the equipment.\n* `Reack` - Reacknowledge the equipment and discover it again.\n* `Remove` - Remove the equipment permanently from Intersight management.\n* `Replace` - Replace the equipment with the other one."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricElementIdentity.AdminActionEnum AdminAction {
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
        
        public NetworkElementRelationship ReplacementTarget {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Replacement type specifies whether it is single FI or domain replacement.\n* `None` - The default action is none.\n* `Individual` - Replacement of single network element.\n* `Domain` - Domain indicates the replacement of Fabric Interconnect domain."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricElementIdentity.ReplacementTypeEnum ReplacementType {
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
    /// <para type="synopsis">This is the cmdlet to Set FabricMulticastPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricMulticastPolicy")]
    public class SetIntersightFabricMulticastPolicy:SetCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Used to define the IGMP Querier IP address."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string QuerierIpAddress {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Used to define the IGMP Querier IP address of the peer switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string QuerierIpAddressPeer {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Administrative state of the IGMP Querier for this VLAN.\n* `Disabled` - Admin configured Disabled State.\n* `Enabled` - Admin configured Enabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricMulticastPolicy.QuerierStateEnum QuerierState {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Administrative state of the IGMP Snooping for this VLAN.\n* `Enabled` - Admin configured Enabled State.\n* `Disabled` - Admin configured Disabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricMulticastPolicy.SnoopingStateEnum SnoopingState {
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
    /// <para type="synopsis">This is the cmdlet to Remove FabricMulticastPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricMulticastPolicy")]
    public class RemoveIntersightFabricMulticastPolicy:RemoveCmdletBase
	{
		public RemoveIntersightFabricMulticastPolicy()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricMulticastPolicyWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricPortMode.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricPortMode")]
    public class SetIntersightFabricPortMode:SetCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Custom Port Mode specified for the port range.\n* `FibreChannel` - Fibre Channel Port Types.\n* `BreakoutEthernet10G` - Breakout Ethernet 10G Port Type.\n* `BreakoutEthernet25G` - Breakout Ethernet 25G Port Type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricPortMode.CustomModeEnum CustomMode {
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
        /// <para type="description">"Ending range of the Port Identifier."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long PortIdEnd {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Starting range of the Port Identifier."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long PortIdStart {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricPortPolicyRelationship PortPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Slot Identifier of the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long SlotId {
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
    /// <para type="synopsis">This is the cmdlet to Remove FabricPortMode.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricPortMode")]
    public class RemoveIntersightFabricPortMode:RemoveCmdletBase
	{
		public RemoveIntersightFabricPortMode()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricPortModeWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricAppliancePcRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricAppliancePcRole", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricAppliancePcRole:GetCmdletBase
	{
		public GetIntersightFabricAppliancePcRole()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricAppliancePcRoleListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricAppliancePcRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricAppliancePcRole")]
    public class NewIntersightFabricAppliancePcRole:NewCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Admin configured speed for the port channel.\n* `Auto` - Admin configurable speed AUTO ( default ).\n* `1Gbps` - Admin configurable speed 1Gbps.\n* `10Gbps` - Admin configurable speed 10Gbps.\n* `25Gbps` - Admin configurable speed 25Gbps.\n* `40Gbps` - Admin configurable speed 40Gbps.\n* `100Gbps` - Admin configurable speed 100Gbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricAppliancePcRole.AdminSpeedEnum AdminSpeed {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricEthNetworkControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricEthNetworkControlPolicyRelationship EthNetworkControlPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricEthNetworkGroupPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricEthNetworkGroupPolicyRelationship EthNetworkGroupPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Port mode to be set on the appliance port-channel.\n* `trunk` - Trunk Mode Switch Port Type.\n* `access` - Access Mode Switch Port Type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricAppliancePcRole.ModeEnum Mode {
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
        /// <para type="description">"Unique Identifier of the port-channel, local to this switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 256)]
        public long PcId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricPortPolicyRelationship PortPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<FabricPortIdentifier> Ports {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The 'name' of the System QoS Class.\n* `Best Effort` - QoS Priority for Best-effort traffic.\n* `FC` - QoS Priority for FC traffic.\n* `Platinum` - QoS Priority for Platinum traffic.\n* `Gold` - QoS Priority for Gold traffic.\n* `Silver` - QoS Priority for Silver traffic.\n* `Bronze` - QoS Priority for Bronze traffic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricAppliancePcRole.PriorityEnum Priority {
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
    /// <para type="synopsis">This is the cmdlet to Get FabricSystemQosPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricSystemQosPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricSystemQosPolicy:GetCmdletBase
	{
		public GetIntersightFabricSystemQosPolicy()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricSystemQosPolicyListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricSystemQosPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricSystemQosPolicy")]
    public class NewIntersightFabricSystemQosPolicy:NewCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<FabricQosClass> Classes {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to fabricSwitchProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<FabricSwitchProfileRelationship> Profiles {
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
    /// <para type="synopsis">This is the cmdlet to Get FabricApplianceRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricApplianceRole", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricApplianceRole:GetCmdletBase
	{
		public GetIntersightFabricApplianceRole()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricApplianceRoleListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricApplianceRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricApplianceRole")]
    public class NewIntersightFabricApplianceRole:NewCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Admin configured speed for the port.\n* `Auto` - Admin configurable speed AUTO ( default ).\n* `1Gbps` - Admin configurable speed 1Gbps.\n* `10Gbps` - Admin configurable speed 10Gbps.\n* `25Gbps` - Admin configurable speed 25Gbps.\n* `40Gbps` - Admin configurable speed 40Gbps.\n* `100Gbps` - Admin configurable speed 100Gbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricApplianceRole.AdminSpeedEnum AdminSpeed {
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
        /// <para type="description">"A reference to a fabricEthNetworkControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricEthNetworkControlPolicyRelationship EthNetworkControlPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricEthNetworkGroupPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricEthNetworkGroupPolicyRelationship EthNetworkGroupPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Forward error correction configuration for the port.\n* `Auto` - Forward error correction option 'Auto'.\n* `Cl91` - Forward error correction option 'cl91'.\n* `Cl74` - Forward error correction option 'cl74'."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricApplianceRole.FecEnum Fec {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricFlowControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricFlowControlPolicyRelationship FlowControlPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricLinkControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricLinkControlPolicyRelationship LinkControlPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Port mode to be set on the appliance port.\n* `trunk` - Trunk Mode Switch Port Type.\n* `access` - Access Mode Switch Port Type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricApplianceRole.ModeEnum Mode {
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
        /// <para type="description">"Port Identifier of the Switch/FEX/Chassis Interface.\nWhen a port is not configured as a breakout port, the portId is the port number as labeled on the equipment,\ne.g. the id of the port on the switch, FEX or chassis.\nWhen a port is configured as a breakout port, the 'portId' represents the port id on the fanout side of the breakout cable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 108)]
        public long PortId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricPortPolicyRelationship PortPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The 'name' of the System QoS Class.\n* `Best Effort` - QoS Priority for Best-effort traffic.\n* `FC` - QoS Priority for FC traffic.\n* `Platinum` - QoS Priority for Platinum traffic.\n* `Gold` - QoS Priority for Gold traffic.\n* `Silver` - QoS Priority for Silver traffic.\n* `Bronze` - QoS Priority for Bronze traffic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricApplianceRole.PriorityEnum Priority {
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
    /// <para type="synopsis">This is the cmdlet to Remove FabricAppliancePcRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricAppliancePcRole")]
    public class RemoveIntersightFabricAppliancePcRole:RemoveCmdletBase
	{
		public RemoveIntersightFabricAppliancePcRole()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricAppliancePcRoleWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricAppliancePcRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricAppliancePcRole")]
    public class SetIntersightFabricAppliancePcRole:SetCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Admin configured speed for the port channel.\n* `Auto` - Admin configurable speed AUTO ( default ).\n* `1Gbps` - Admin configurable speed 1Gbps.\n* `10Gbps` - Admin configurable speed 10Gbps.\n* `25Gbps` - Admin configurable speed 25Gbps.\n* `40Gbps` - Admin configurable speed 40Gbps.\n* `100Gbps` - Admin configurable speed 100Gbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricAppliancePcRole.AdminSpeedEnum AdminSpeed {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricEthNetworkControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricEthNetworkControlPolicyRelationship EthNetworkControlPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricEthNetworkGroupPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricEthNetworkGroupPolicyRelationship EthNetworkGroupPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Port mode to be set on the appliance port-channel.\n* `trunk` - Trunk Mode Switch Port Type.\n* `access` - Access Mode Switch Port Type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricAppliancePcRole.ModeEnum Mode {
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
        /// <para type="description">"Unique Identifier of the port-channel, local to this switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 256)]
        public long PcId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricPortPolicyRelationship PortPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<FabricPortIdentifier> Ports {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The 'name' of the System QoS Class.\n* `Best Effort` - QoS Priority for Best-effort traffic.\n* `FC` - QoS Priority for FC traffic.\n* `Platinum` - QoS Priority for Platinum traffic.\n* `Gold` - QoS Priority for Gold traffic.\n* `Silver` - QoS Priority for Silver traffic.\n* `Bronze` - QoS Priority for Bronze traffic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricAppliancePcRole.PriorityEnum Priority {
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
    /// <para type="synopsis">This is the cmdlet to Set FabricUplinkPcRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricUplinkPcRole")]
    public class SetIntersightFabricUplinkPcRole:SetCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Admin configured speed for the port.\n* `Auto` - Admin configurable speed AUTO ( default ).\n* `1Gbps` - Admin configurable speed 1Gbps.\n* `10Gbps` - Admin configurable speed 10Gbps.\n* `25Gbps` - Admin configurable speed 25Gbps.\n* `40Gbps` - Admin configurable speed 40Gbps.\n* `100Gbps` - Admin configurable speed 100Gbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricUplinkPcRole.AdminSpeedEnum AdminSpeed {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricFlowControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricFlowControlPolicyRelationship FlowControlPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricLinkAggregationPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricLinkAggregationPolicyRelationship LinkAggregationPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricLinkControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricLinkControlPolicyRelationship LinkControlPolicy {
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
        /// <para type="description">"Unique Identifier of the port-channel, local to this switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 256)]
        public long PcId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricPortPolicyRelationship PortPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<FabricPortIdentifier> Ports {
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
    /// <para type="synopsis">This is the cmdlet to Remove FabricUplinkPcRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricUplinkPcRole")]
    public class RemoveIntersightFabricUplinkPcRole:RemoveCmdletBase
	{
		public RemoveIntersightFabricUplinkPcRole()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricUplinkPcRoleWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricFcUplinkRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricFcUplinkRole", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricFcUplinkRole:GetCmdletBase
	{
		public GetIntersightFabricFcUplinkRole()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricFcUplinkRoleListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricFcUplinkRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricFcUplinkRole")]
    public class NewIntersightFabricFcUplinkRole:NewCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Admin configured speed for the port.\n* `Auto` - Admin configurable speed AUTO ( default ).\n* `8Gbps` - Admin configurable speed 8Gbps.\n* `16Gbps` - Admin configurable speed 16Gbps.\n* `32Gbps` - Admin configurable speed 32Gbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricFcUplinkRole.AdminSpeedEnum AdminSpeed {
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
        /// <para type="description">"Fill pattern to differentiate the configs in NPIV.\n* `Idle` - Fc Fill Pattern type Idle.\n* `Arbff` - Fc Fill Pattern type Arbff."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricFcUplinkRole.FillPatternEnum FillPattern {
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
        /// <para type="description">"Port Identifier of the Switch/FEX/Chassis Interface.\nWhen a port is not configured as a breakout port, the portId is the port number as labeled on the equipment,\ne.g. the id of the port on the switch, FEX or chassis.\nWhen a port is configured as a breakout port, the 'portId' represents the port id on the fanout side of the breakout cable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 108)]
        public long PortId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricPortPolicyRelationship PortPolicy {
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
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Virtual San Identifier associated to the FC port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 4093)]
        public long VsanId {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricMulticastPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricMulticastPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricMulticastPolicy:GetCmdletBase
	{
		public GetIntersightFabricMulticastPolicy()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricMulticastPolicyListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricMulticastPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricMulticastPolicy")]
    public class NewIntersightFabricMulticastPolicy:NewCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Used to define the IGMP Querier IP address."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string QuerierIpAddress {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Used to define the IGMP Querier IP address of the peer switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string QuerierIpAddressPeer {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Administrative state of the IGMP Querier for this VLAN.\n* `Disabled` - Admin configured Disabled State.\n* `Enabled` - Admin configured Enabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricMulticastPolicy.QuerierStateEnum QuerierState {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Administrative state of the IGMP Snooping for this VLAN.\n* `Enabled` - Admin configured Enabled State.\n* `Disabled` - Admin configured Disabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricMulticastPolicy.SnoopingStateEnum SnoopingState {
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
    /// <para type="synopsis">This is the cmdlet to Get FabricVsan.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricVsan", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricVsan:GetCmdletBase
	{
		public GetIntersightFabricVsan()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricVsanListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricVsan.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricVsan")]
    public class NewIntersightFabricVsan:NewCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enables or Disables the default zoning state.\n* `Enabled` - Admin configured Enabled State.\n* `Disabled` - Admin configured Disabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricVsan.DefaultZoningEnum DefaultZoning {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricFcNetworkPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricFcNetworkPolicyRelationship FcNetworkPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Logical grouping mode for fc ports."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FcZoneSharingMode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"FCOE Vlan associated to the VSAN configuration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long FcoeVlan {
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
        /// <para type="description">"User given name for the VSAN configuration."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        
        public string Name {
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
        /// <para type="description">"Virtual San Identifier in the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 4093)]
        public long VsanId {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricConfigChangeDetail.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricConfigChangeDetail", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricConfigChangeDetail:GetCmdletBase
	{
		public GetIntersightFabricConfigChangeDetail()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricConfigChangeDetailListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricFcUplinkPcRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricFcUplinkPcRole")]
    public class SetIntersightFabricFcUplinkPcRole:SetCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Admin configured speed for the port.\n* `Auto` - Admin configurable speed AUTO ( default ).\n* `8Gbps` - Admin configurable speed 8Gbps.\n* `16Gbps` - Admin configurable speed 16Gbps.\n* `32Gbps` - Admin configurable speed 32Gbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricFcUplinkPcRole.AdminSpeedEnum AdminSpeed {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Fill pattern to differentiate the configs in NPIV.\n* `Idle` - Fc Fill Pattern type Idle.\n* `Arbff` - Fc Fill Pattern type Arbff."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricFcUplinkPcRole.FillPatternEnum FillPattern {
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
        /// <para type="description">"Unique Identifier of the port-channel, local to this switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 256)]
        public long PcId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricPortPolicyRelationship PortPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<FabricPortIdentifier> Ports {
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
        /// <para type="description">"Virtual San Identifier associated to the FC port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 4093)]
        public long VsanId {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricFcUplinkPcRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricFcUplinkPcRole")]
    public class RemoveIntersightFabricFcUplinkPcRole:RemoveCmdletBase
	{
		public RemoveIntersightFabricFcUplinkPcRole()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricFcUplinkPcRoleWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricSwitchProfile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricSwitchProfile", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricSwitchProfile:GetCmdletBase
	{
		public GetIntersightFabricSwitchProfile()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricSwitchProfileListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricSwitchProfile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricSwitchProfile")]
    public class NewIntersightFabricSwitchProfile:NewCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Action {
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
        /// <para type="description">"A reference to a networkElement resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NetworkElementRelationship AssignedSwitch {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This lists the pending configuration changes at the summary level. Detailed changes are saved in configChangeDetails as a separate object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PolicyConfigChange ConfigChanges {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The configuration state and results of the last configuration operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PolicyConfigContext ConfigContext {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
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
        /// <para type="description">"Name of the profile instance or profile template."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to policyAbstractPolicy resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<PolicyAbstractPolicyRelationship> PolicyBucket {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a policyAbstractProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PolicyAbstractProfileRelationship SrcTemplate {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricSwitchClusterProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricSwitchClusterProfileRelationship SwitchClusterProfile {
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
        /// <para type="description">"Defines the type of the profile. Accepted values are instance or template.\n* `instance` - The profile defines the configuration for a specific instance of a target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricSwitchProfile.TypeEnum Type {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricUplinkRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricUplinkRole")]
    public class SetIntersightFabricUplinkRole:SetCmdletBase
	{
		public SetIntersightFabricUplinkRole()
		{
			ApiInstance = new FabricApi(Config);
            ModelObject = new FabricUplinkRole();
            MethodName = "PatchFabricUplinkRoleWithHttpInfo";
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
        /// <para type="description">"Admin configured speed for the port.\n* `Auto` - Admin configurable speed AUTO ( default ).\n* `1Gbps` - Admin configurable speed 1Gbps.\n* `10Gbps` - Admin configurable speed 10Gbps.\n* `25Gbps` - Admin configurable speed 25Gbps.\n* `40Gbps` - Admin configurable speed 40Gbps.\n* `100Gbps` - Admin configurable speed 100Gbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricUplinkRole.AdminSpeedEnum AdminSpeed {
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
        /// <para type="description">"Forward error correction configuration for the port.\n* `Auto` - Forward error correction option 'Auto'.\n* `Cl91` - Forward error correction option 'cl91'.\n* `Cl74` - Forward error correction option 'cl74'."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricUplinkRole.FecEnum Fec {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricFlowControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricFlowControlPolicyRelationship FlowControlPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricLinkControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricLinkControlPolicyRelationship LinkControlPolicy {
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
        /// <para type="description">"Port Identifier of the Switch/FEX/Chassis Interface.\nWhen a port is not configured as a breakout port, the portId is the port number as labeled on the equipment,\ne.g. the id of the port on the switch, FEX or chassis.\nWhen a port is configured as a breakout port, the 'portId' represents the port id on the fanout side of the breakout cable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 108)]
        public long PortId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricPortPolicyRelationship PortPolicy {
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
    /// <para type="synopsis">This is the cmdlet to Remove FabricUplinkRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricUplinkRole")]
    public class RemoveIntersightFabricUplinkRole:RemoveCmdletBase
	{
		public RemoveIntersightFabricUplinkRole()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricUplinkRoleWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricFcoeUplinkRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricFcoeUplinkRole")]
    public class SetIntersightFabricFcoeUplinkRole:SetCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Admin configured speed for the port.\n* `Auto` - Admin configurable speed AUTO ( default ).\n* `1Gbps` - Admin configurable speed 1Gbps.\n* `10Gbps` - Admin configurable speed 10Gbps.\n* `25Gbps` - Admin configurable speed 25Gbps.\n* `40Gbps` - Admin configurable speed 40Gbps.\n* `100Gbps` - Admin configurable speed 100Gbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricFcoeUplinkRole.AdminSpeedEnum AdminSpeed {
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
        /// <para type="description">"Forward error correction configuration for the port.\n* `Auto` - Forward error correction option 'Auto'.\n* `Cl91` - Forward error correction option 'cl91'.\n* `Cl74` - Forward error correction option 'cl74'."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricFcoeUplinkRole.FecEnum Fec {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricLinkControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricLinkControlPolicyRelationship LinkControlPolicy {
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
        /// <para type="description">"Port Identifier of the Switch/FEX/Chassis Interface.\nWhen a port is not configured as a breakout port, the portId is the port number as labeled on the equipment,\ne.g. the id of the port on the switch, FEX or chassis.\nWhen a port is configured as a breakout port, the 'portId' represents the port id on the fanout side of the breakout cable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 108)]
        public long PortId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricPortPolicyRelationship PortPolicy {
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
    /// <para type="synopsis">This is the cmdlet to Remove FabricFcoeUplinkRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricFcoeUplinkRole")]
    public class RemoveIntersightFabricFcoeUplinkRole:RemoveCmdletBase
	{
		public RemoveIntersightFabricFcoeUplinkRole()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricFcoeUplinkRoleWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricPortOperation.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricPortOperation", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricPortOperation:GetCmdletBase
	{
		public GetIntersightFabricPortOperation()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricPortOperationListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricPortOperation.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricPortOperation")]
    public class NewIntersightFabricPortOperation:NewCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Admin configured state to disable the port.\n* `Enabled` - Admin configured Enabled State.\n* `Disabled` - Admin configured Disabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricPortOperation.AdminStateEnum AdminState {
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
        /// <para type="description">"The configured state of these settings in the target chassis. The value is any one of Applied, Applying, Failed. Applied - This state denotes that the admin state changes are applied successfully in the target FI domain. Applying - This state denotes that the admin state changes are being applied in the target FI domain. Failed - This state denotes that the admin state changes could not be applied in the target FI domain.\n* `None` - Nil value when no action has been triggered by the user.\n* `Applied` - User configured settings are in applied state.\n* `Applying` - User settings are being applied on the target server.\n* `Failed` - User configured settings could not be applied."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricPortOperation.ConfigStateEnum ConfigState {
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
        /// <para type="description">"A reference to a networkElement resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NetworkElementRelationship NetworkElement {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Port Identifier of the Switch/FEX/Chassis Interface.\nWhen a port is not configured as a breakout port, the portId is the port number as labeled on the equipment,\ne.g. the id of the port on the switch, FEX or chassis.\nWhen a port is configured as a breakout port, the 'portId' represents the port id on the fanout side of the breakout cable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long PortId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Slot Identifier of the Switch/FEX/Chassis Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long SlotId {
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
    /// <para type="synopsis">This is the cmdlet to Get FabricFlowControlPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricFlowControlPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricFlowControlPolicy:GetCmdletBase
	{
		public GetIntersightFabricFlowControlPolicy()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricFlowControlPolicyListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricFlowControlPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricFlowControlPolicy")]
    public class NewIntersightFabricFlowControlPolicy:NewCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Configure PFC on a per-port basis to enable the no-drop behavior for the CoS as defined by the active network qos policy.\n* `auto` - Enables the no-drop CoS values to be advertised by the DCBXP and negotiated with the peer.A successful negotiation enables PFC on the no-drop CoS.Any failures because of a mismatch in the capability of peers causes the PFC not to be enabled.\n* `on` - Enables PFC on the local port regardless of the capability of the peers."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricFlowControlPolicy.PriorityFlowControlModeEnum PriorityFlowControlMode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Link-level Flow Control configured in the receive direction.\n* `Disabled` - Admin configured Disabled State.\n* `Enabled` - Admin configured Enabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricFlowControlPolicy.ReceiveDirectionEnum ReceiveDirection {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Link-level Flow Control configured in the send direction.\n* `Disabled` - Admin configured Disabled State.\n* `Enabled` - Admin configured Enabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricFlowControlPolicy.SendDirectionEnum SendDirection {
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
    /// <para type="synopsis">This is the cmdlet to Get FabricPcMember.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricPcMember", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricPcMember:GetCmdletBase
	{
		public GetIntersightFabricPcMember()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricPcMemberListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricEstimateImpact.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricEstimateImpact")]
    public class NewIntersightFabricEstimateImpact:NewCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
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
        /// <para type="description">"A reference to a fabricSwitchProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricSwitchProfileRelationship Profile {
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
    /// <para type="synopsis">This is the cmdlet to Get FabricVlan.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricVlan", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricVlan:GetCmdletBase
	{
		public GetIntersightFabricVlan()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricVlanListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricVlan.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricVlan")]
    public class NewIntersightFabricVlan:NewCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Used to determine whether this VLAN will be allowed on all uplink ports and PCs in this FI."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool AutoAllowOnUplinks {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricEthNetworkPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricEthNetworkPolicyRelationship EthNetworkPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Used to define whether this VLAN is to be classified as 'native' for traffic in this FI."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool IsNative {
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
        /// <para type="description">"A reference to a fabricMulticastPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricMulticastPolicyRelationship MulticastPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The 'name' used to identify this VLAN."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        
        public string Name {
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
        /// <para type="description">"The identifier for this Virtual LAN."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 4093)]
        public long VlanId {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricVsan.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricVsan")]
    public class SetIntersightFabricVsan:SetCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enables or Disables the default zoning state.\n* `Enabled` - Admin configured Enabled State.\n* `Disabled` - Admin configured Disabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricVsan.DefaultZoningEnum DefaultZoning {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricFcNetworkPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricFcNetworkPolicyRelationship FcNetworkPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Logical grouping mode for fc ports."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FcZoneSharingMode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"FCOE Vlan associated to the VSAN configuration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long FcoeVlan {
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
        /// <para type="description">"User given name for the VSAN configuration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
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
        /// <para type="description">"Virtual San Identifier in the switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 4093)]
        public long VsanId {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricVsan.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricVsan")]
    public class RemoveIntersightFabricVsan:RemoveCmdletBase
	{
		public RemoveIntersightFabricVsan()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricVsanWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricSwitchClusterProfile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricSwitchClusterProfile", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricSwitchClusterProfile:GetCmdletBase
	{
		public GetIntersightFabricSwitchClusterProfile()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricSwitchClusterProfileListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricSwitchClusterProfile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricSwitchClusterProfile")]
    public class NewIntersightFabricSwitchClusterProfile:NewCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
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
        /// <para type="description">"Name of the profile instance or profile template."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a policyAbstractProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PolicyAbstractProfileRelationship SrcTemplate {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to fabricSwitchProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<FabricSwitchProfileRelationship> SwitchProfiles {
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
        /// <para type="description">"Defines the type of the profile. Accepted values are instance or template.\n* `instance` - The profile defines the configuration for a specific instance of a target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricSwitchClusterProfile.TypeEnum Type {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FabricSwitchClusterProfile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricSwitchClusterProfile")]
    public class RemoveIntersightFabricSwitchClusterProfile:RemoveCmdletBase
	{
		public RemoveIntersightFabricSwitchClusterProfile()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricSwitchClusterProfileWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricSwitchClusterProfile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricSwitchClusterProfile")]
    public class SetIntersightFabricSwitchClusterProfile:SetCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
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
        /// <para type="description">"Name of the profile instance or profile template."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a policyAbstractProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PolicyAbstractProfileRelationship SrcTemplate {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to fabricSwitchProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<FabricSwitchProfileRelationship> SwitchProfiles {
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
        /// <para type="description">"Defines the type of the profile. Accepted values are instance or template.\n* `instance` - The profile defines the configuration for a specific instance of a target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricSwitchClusterProfile.TypeEnum Type {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricUplinkRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricUplinkRole", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricUplinkRole:GetCmdletBase
	{
		public GetIntersightFabricUplinkRole()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricUplinkRoleListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricUplinkRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricUplinkRole")]
    public class NewIntersightFabricUplinkRole:NewCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Admin configured speed for the port.\n* `Auto` - Admin configurable speed AUTO ( default ).\n* `1Gbps` - Admin configurable speed 1Gbps.\n* `10Gbps` - Admin configurable speed 10Gbps.\n* `25Gbps` - Admin configurable speed 25Gbps.\n* `40Gbps` - Admin configurable speed 40Gbps.\n* `100Gbps` - Admin configurable speed 100Gbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricUplinkRole.AdminSpeedEnum AdminSpeed {
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
        /// <para type="description">"Forward error correction configuration for the port.\n* `Auto` - Forward error correction option 'Auto'.\n* `Cl91` - Forward error correction option 'cl91'.\n* `Cl74` - Forward error correction option 'cl74'."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricUplinkRole.FecEnum Fec {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricFlowControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricFlowControlPolicyRelationship FlowControlPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricLinkControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricLinkControlPolicyRelationship LinkControlPolicy {
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
        /// <para type="description">"Port Identifier of the Switch/FEX/Chassis Interface.\nWhen a port is not configured as a breakout port, the portId is the port number as labeled on the equipment,\ne.g. the id of the port on the switch, FEX or chassis.\nWhen a port is configured as a breakout port, the 'portId' represents the port id on the fanout side of the breakout cable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 108)]
        public long PortId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricPortPolicyRelationship PortPolicy {
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
    /// <para type="synopsis">This is the cmdlet to Set FabricPcOperation.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricPcOperation")]
    public class SetIntersightFabricPcOperation:SetCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Admin configured state to disable the port channel.\n* `Enabled` - Admin configured Enabled State.\n* `Disabled` - Admin configured Disabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricPcOperation.AdminStateEnum AdminState {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The configured state of these settings in the target chassis. The value is any one of Applied, Applying, Failed. Applied - This state denotes that the admin state changes are applied successfully in the target FI domain. Applying - This state denotes that the admin state changes are being applied in the target FI domain. Failed - This state denotes that the admin state changes could not be applied in the target FI domain.\n* `None` - Nil value when no action has been triggered by the user.\n* `Applied` - User configured settings are in applied state.\n* `Applying` - User settings are being applied on the target server.\n* `Failed` - User configured settings could not be applied."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricPcOperation.ConfigStateEnum ConfigState {
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
        /// <para type="description">"Port Channel Identifier for the collection of ports."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long PcId {
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
    /// <para type="synopsis">This is the cmdlet to Remove FabricPcOperation.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricPcOperation")]
    public class RemoveIntersightFabricPcOperation:RemoveCmdletBase
	{
		public RemoveIntersightFabricPcOperation()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricPcOperationWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricSwitchControlPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricSwitchControlPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricSwitchControlPolicy:GetCmdletBase
	{
		public GetIntersightFabricSwitchControlPolicy()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricSwitchControlPolicyListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricSwitchControlPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricSwitchControlPolicy")]
    public class NewIntersightFabricSwitchControlPolicy:NewCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This specifies the MAC aging option and time settings."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricMacAgingSettings MacAgingSettings {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to fabricSwitchProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<FabricSwitchProfileRelationship> Profiles {
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
        /// <para type="description">"This specifies the UDLD Global configurations for this switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricUdldGlobalSettings UdldSettings {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"To enable or disable the VLAN port count optimization."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool VlanPortOptimizationEnabled {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricApplianceRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricApplianceRole")]
    public class SetIntersightFabricApplianceRole:SetCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Admin configured speed for the port.\n* `Auto` - Admin configurable speed AUTO ( default ).\n* `1Gbps` - Admin configurable speed 1Gbps.\n* `10Gbps` - Admin configurable speed 10Gbps.\n* `25Gbps` - Admin configurable speed 25Gbps.\n* `40Gbps` - Admin configurable speed 40Gbps.\n* `100Gbps` - Admin configurable speed 100Gbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricApplianceRole.AdminSpeedEnum AdminSpeed {
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
        /// <para type="description">"A reference to a fabricEthNetworkControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricEthNetworkControlPolicyRelationship EthNetworkControlPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricEthNetworkGroupPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricEthNetworkGroupPolicyRelationship EthNetworkGroupPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Forward error correction configuration for the port.\n* `Auto` - Forward error correction option 'Auto'.\n* `Cl91` - Forward error correction option 'cl91'.\n* `Cl74` - Forward error correction option 'cl74'."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricApplianceRole.FecEnum Fec {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricFlowControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricFlowControlPolicyRelationship FlowControlPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricLinkControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricLinkControlPolicyRelationship LinkControlPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Port mode to be set on the appliance port.\n* `trunk` - Trunk Mode Switch Port Type.\n* `access` - Access Mode Switch Port Type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricApplianceRole.ModeEnum Mode {
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
        /// <para type="description">"Port Identifier of the Switch/FEX/Chassis Interface.\nWhen a port is not configured as a breakout port, the portId is the port number as labeled on the equipment,\ne.g. the id of the port on the switch, FEX or chassis.\nWhen a port is configured as a breakout port, the 'portId' represents the port id on the fanout side of the breakout cable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 108)]
        public long PortId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricPortPolicyRelationship PortPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The 'name' of the System QoS Class.\n* `Best Effort` - QoS Priority for Best-effort traffic.\n* `FC` - QoS Priority for FC traffic.\n* `Platinum` - QoS Priority for Platinum traffic.\n* `Gold` - QoS Priority for Gold traffic.\n* `Silver` - QoS Priority for Silver traffic.\n* `Bronze` - QoS Priority for Bronze traffic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricApplianceRole.PriorityEnum Priority {
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
    /// <para type="synopsis">This is the cmdlet to Remove FabricApplianceRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricApplianceRole")]
    public class RemoveIntersightFabricApplianceRole:RemoveCmdletBase
	{
		public RemoveIntersightFabricApplianceRole()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricApplianceRoleWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricFcNetworkPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricFcNetworkPolicy")]
    public class SetIntersightFabricFcNetworkPolicy:SetCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enable or Disable Trunking on all of configured FC uplink ports."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool EnableTrunking {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to fabricSwitchProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<FabricSwitchProfileRelationship> Profiles {
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
    /// <para type="synopsis">This is the cmdlet to Remove FabricFcNetworkPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricFcNetworkPolicy")]
    public class RemoveIntersightFabricFcNetworkPolicy:RemoveCmdletBase
	{
		public RemoveIntersightFabricFcNetworkPolicy()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricFcNetworkPolicyWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FabricPcOperation.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricPcOperation", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricPcOperation:GetCmdletBase
	{
		public GetIntersightFabricPcOperation()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricPcOperationListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FabricPcOperation.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFabricPcOperation")]
    public class NewIntersightFabricPcOperation:NewCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Admin configured state to disable the port channel.\n* `Enabled` - Admin configured Enabled State.\n* `Disabled` - Admin configured Disabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricPcOperation.AdminStateEnum AdminState {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The configured state of these settings in the target chassis. The value is any one of Applied, Applying, Failed. Applied - This state denotes that the admin state changes are applied successfully in the target FI domain. Applying - This state denotes that the admin state changes are being applied in the target FI domain. Failed - This state denotes that the admin state changes could not be applied in the target FI domain.\n* `None` - Nil value when no action has been triggered by the user.\n* `Applied` - User configured settings are in applied state.\n* `Applying` - User settings are being applied on the target server.\n* `Failed` - User configured settings could not be applied."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricPcOperation.ConfigStateEnum ConfigState {
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
        /// <para type="description">"A reference to a networkElement resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public NetworkElementRelationship NetworkElement {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Port Channel Identifier for the collection of ports."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long PcId {
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
    /// <para type="synopsis">This is the cmdlet to Get FabricConfigResultEntry.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFabricConfigResultEntry", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFabricConfigResultEntry:GetCmdletBase
	{
		public GetIntersightFabricConfigResultEntry()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "GetFabricConfigResultEntryListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricFlowControlPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricFlowControlPolicy")]
    public class SetIntersightFabricFlowControlPolicy:SetCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Configure PFC on a per-port basis to enable the no-drop behavior for the CoS as defined by the active network qos policy.\n* `auto` - Enables the no-drop CoS values to be advertised by the DCBXP and negotiated with the peer.A successful negotiation enables PFC on the no-drop CoS.Any failures because of a mismatch in the capability of peers causes the PFC not to be enabled.\n* `on` - Enables PFC on the local port regardless of the capability of the peers."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricFlowControlPolicy.PriorityFlowControlModeEnum PriorityFlowControlMode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Link-level Flow Control configured in the receive direction.\n* `Disabled` - Admin configured Disabled State.\n* `Enabled` - Admin configured Enabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricFlowControlPolicy.ReceiveDirectionEnum ReceiveDirection {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Link-level Flow Control configured in the send direction.\n* `Disabled` - Admin configured Disabled State.\n* `Enabled` - Admin configured Enabled State."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricFlowControlPolicy.SendDirectionEnum SendDirection {
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
    /// <para type="synopsis">This is the cmdlet to Remove FabricFlowControlPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricFlowControlPolicy")]
    public class RemoveIntersightFabricFlowControlPolicy:RemoveCmdletBase
	{
		public RemoveIntersightFabricFlowControlPolicy()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricFlowControlPolicyWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FabricFcoeUplinkPcRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFabricFcoeUplinkPcRole")]
    public class SetIntersightFabricFcoeUplinkPcRole:SetCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Admin configured speed for the port.\n* `Auto` - Admin configurable speed AUTO ( default ).\n* `1Gbps` - Admin configurable speed 1Gbps.\n* `10Gbps` - Admin configurable speed 10Gbps.\n* `25Gbps` - Admin configurable speed 25Gbps.\n* `40Gbps` - Admin configurable speed 40Gbps.\n* `100Gbps` - Admin configurable speed 100Gbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricFcoeUplinkPcRole.AdminSpeedEnum AdminSpeed {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricLinkAggregationPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricLinkAggregationPolicyRelationship LinkAggregationPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricLinkControlPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricLinkControlPolicyRelationship LinkControlPolicy {
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
        /// <para type="description">"Unique Identifier of the port-channel, local to this switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 256)]
        public long PcId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a fabricPortPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FabricPortPolicyRelationship PortPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<FabricPortIdentifier> Ports {
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
    /// <para type="synopsis">This is the cmdlet to Remove FabricFcoeUplinkPcRole.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFabricFcoeUplinkPcRole")]
    public class RemoveIntersightFabricFcoeUplinkPcRole:RemoveCmdletBase
	{
		public RemoveIntersightFabricFcoeUplinkPcRole()
		{
			ApiInstance = new FabricApi(Config);
            MethodName = "DeleteFabricFcoeUplinkPcRoleWithHttpInfo";
		}
    }
}