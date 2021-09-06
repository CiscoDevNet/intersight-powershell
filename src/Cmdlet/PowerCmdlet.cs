using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set PowerPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightPowerPolicy")]
    public class SetIntersightPowerPolicy:SetCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Sets the Allocated Power Budget of the System (in Watts). This field is only supported for Cisco UCS X series Chassis."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long AllocatedBudget {
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
        /// <para type="description">"Sets the Power Profiling of the Server. This field is only supported for Cisco UCS X series servers.\n* `Enabled` - Set the value to Enabled.\n* `Disabled` - Set the value to Disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PowerPolicy.PowerProfilingEnum PowerProfiling {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Sets the Power Restore State of the Server. This field is only supported for Cisco UCS X series servers.\n* `AlwaysOff` - Set the Power Restore Mode to Off.\n* `AlwaysOn` - Set the Power Restore Mode to On.\n* `LastState` - Set the Power Restore Mode to LastState."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PowerPolicy.PowerRestoreStateEnum PowerRestoreState {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to policyAbstractConfigProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<PolicyAbstractConfigProfileRelationship> Profiles {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Sets the Power Redundancy of the System. N+2 mode is only supported for Cisco UCS X series Chassis.\n* `Grid` - Grid Mode requires two power sources. If one source fails, the surviving PSUs connected to the other source provides power to the chassis.\n* `NotRedundant` - Power Manager turns on the minimum number of PSUs required to support chassis power requirements. No Redundant PSUs are maintained.\n* `N+1` - Power Manager turns on the minimum number of PSUs required to support chassis power requirements plus one additional PSU for redundancy.\n* `N+2` - Power Manager turns on the minimum number of PSUs required to support chassis power requirements plus two additional PSU for redundancy. This Mode is only supported for UCS X series Chassis."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PowerPolicy.RedundancyModeEnum RedundancyMode {
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
    /// <para type="synopsis">This is the cmdlet to Remove PowerPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightPowerPolicy")]
    public class RemoveIntersightPowerPolicy:RemoveCmdletBase
	{
		public RemoveIntersightPowerPolicy()
		{
			ApiInstance = new PowerApi(Config);
            MethodName = "DeletePowerPolicyWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get PowerControlState.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightPowerControlState", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightPowerControlState:GetCmdletBase
	{
		public GetIntersightPowerControlState()
		{
			ApiInstance = new PowerApi(Config);
            MethodName = "GetPowerControlStateListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get PowerPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightPowerPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightPowerPolicy:GetCmdletBase
	{
		public GetIntersightPowerPolicy()
		{
			ApiInstance = new PowerApi(Config);
            MethodName = "GetPowerPolicyListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New PowerPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightPowerPolicy")]
    public class NewIntersightPowerPolicy:NewCmdletBase
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Sets the Allocated Power Budget of the System (in Watts). This field is only supported for Cisco UCS X series Chassis."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long AllocatedBudget {
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
        /// <para type="description">"Sets the Power Profiling of the Server. This field is only supported for Cisco UCS X series servers.\n* `Enabled` - Set the value to Enabled.\n* `Disabled` - Set the value to Disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PowerPolicy.PowerProfilingEnum PowerProfiling {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Sets the Power Restore State of the Server. This field is only supported for Cisco UCS X series servers.\n* `AlwaysOff` - Set the Power Restore Mode to Off.\n* `AlwaysOn` - Set the Power Restore Mode to On.\n* `LastState` - Set the Power Restore Mode to LastState."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PowerPolicy.PowerRestoreStateEnum PowerRestoreState {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to policyAbstractConfigProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<PolicyAbstractConfigProfileRelationship> Profiles {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Sets the Power Redundancy of the System. N+2 mode is only supported for Cisco UCS X series Chassis.\n* `Grid` - Grid Mode requires two power sources. If one source fails, the surviving PSUs connected to the other source provides power to the chassis.\n* `NotRedundant` - Power Manager turns on the minimum number of PSUs required to support chassis power requirements. No Redundant PSUs are maintained.\n* `N+1` - Power Manager turns on the minimum number of PSUs required to support chassis power requirements plus one additional PSU for redundancy.\n* `N+2` - Power Manager turns on the minimum number of PSUs required to support chassis power requirements plus two additional PSU for redundancy. This Mode is only supported for UCS X series Chassis."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PowerPolicy.RedundancyModeEnum RedundancyMode {
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
}