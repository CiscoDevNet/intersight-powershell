using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize PowerControlState.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightPowerControlState")]
    public class InitializeIntersightPowerControlState:PSCmdlet
	{
		public InitializeIntersightPowerControlState()
		{
            ClassId = PowerControlState.ClassIdEnum.PowerControlState;
            ObjectType = PowerControlState.ObjectTypeEnum.PowerControlState;
            
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
        
        public PowerControlState.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a equipmentChassis resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.EquipmentChassisRelationship EquipmentChassis {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PowerControlState.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.MoTag> Tags {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.PowerControlState initObject = new Intersight.Model.PowerControlState();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("EquipmentChassis"))
            {
                initObject.EquipmentChassis = this.EquipmentChassis;
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
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize PowerPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightPowerPolicy")]
    public class InitializeIntersightPowerPolicy:PSCmdlet
	{
		public InitializeIntersightPowerPolicy()
		{
            ClassId = PowerPolicy.ClassIdEnum.PowerPolicy;
            DynamicRebalancing = PowerPolicy.DynamicRebalancingEnum.Enabled;
            ObjectType = PowerPolicy.ObjectTypeEnum.PowerPolicy;
            PowerPriority = PowerPolicy.PowerPriorityEnum.Low;
            PowerProfiling = PowerPolicy.PowerProfilingEnum.Enabled;
            PowerRestoreState = PowerPolicy.PowerRestoreStateEnum.AlwaysOff;
            PowerSaveMode = PowerPolicy.PowerSaveModeEnum.Enabled;
            RedundancyMode = PowerPolicy.RedundancyModeEnum.Grid;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PowerPolicy.ClassIdEnum ClassId {
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
        /// <para type="description">"Sets the Dynamic Power Rebalancing of the System. This option is only supported for Cisco UCS X series Chassis.\n* `Enabled` - Set the value to Enabled.\n* `Disabled` - Set the value to Disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PowerPolicy.DynamicRebalancingEnum DynamicRebalancing {
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PowerPolicy.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Sets the Power Priority of the System. This field is only supported for Cisco UCS X series servers.\n* `Low` - Set the Power Priority to Low.\n* `Medium` - Set the Power Priority to Medium.\n* `High` - Set the Power Priority to High."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PowerPolicy.PowerPriorityEnum PowerPriority {
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
        /// <para type="description">"Sets the Power Save mode of the System. This option is only supported for Cisco UCS X series Chassis.\n* `Enabled` - Set the value to Enabled.\n* `Disabled` - Set the value to Disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PowerPolicy.PowerSaveModeEnum PowerSaveMode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to policyAbstractConfigProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.PolicyAbstractConfigProfileRelationship> Profiles {
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
        
        public List<Model.MoTag> Tags {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.PowerPolicy initObject = new Intersight.Model.PowerPolicy();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AllocatedBudget"))
            {
                initObject.AllocatedBudget = this.AllocatedBudget;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DynamicRebalancing"))
            {
                initObject.DynamicRebalancing = this.DynamicRebalancing;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Organization"))
            {
                initObject.Organization = this.Organization;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PowerPriority"))
            {
                initObject.PowerPriority = this.PowerPriority;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PowerProfiling"))
            {
                initObject.PowerProfiling = this.PowerProfiling;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PowerRestoreState"))
            {
                initObject.PowerRestoreState = this.PowerRestoreState;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PowerSaveMode"))
            {
                initObject.PowerSaveMode = this.PowerSaveMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Profiles"))
            {
                initObject.Profiles = this.Profiles;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RedundancyMode"))
            {
                initObject.RedundancyMode = this.RedundancyMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
}