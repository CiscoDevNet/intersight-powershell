using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize PolicyActionParam.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightPolicyActionParam")]
    public class InitializeIntersightPolicyActionParam : PSCmdlet
    {
        public InitializeIntersightPolicyActionParam()
        {
            ClassId = PolicyActionParam.ClassIdEnum.PolicyActionParam;
            ObjectType = PolicyActionParam.ObjectTypeEnum.PolicyActionParam;

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

        public PolicyActionParam.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The action parameter identifier."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PolicyActionParam.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The action parameter value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Value
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.PolicyActionParam initObject = new Intersight.Model.PolicyActionParam();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Value"))
            {
                initObject.Value = this.Value;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize PolicyActionQualifier.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightPolicyActionQualifier")]
    public class InitializeIntersightPolicyActionQualifier : PSCmdlet
    {
        public InitializeIntersightPolicyActionQualifier()
        {
            ClassId = PolicyActionQualifier.ClassIdEnum.PolicyActionQualifier;
            ObjectType = PolicyActionQualifier.ObjectTypeEnum.PolicyActionQualifier;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PolicyActionQualifier.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PolicyActionQualifier.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.PolicyActionQualifier initObject = new Intersight.Model.PolicyActionQualifier();
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
    /// <para type="synopsis">This is the cmdlet to Initialize PolicyConfigChange.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightPolicyConfigChange")]
    public class InitializeIntersightPolicyConfigChange : PSCmdlet
    {
        public InitializeIntersightPolicyConfigChange()
        {
            ClassId = PolicyConfigChange.ClassIdEnum.PolicyConfigChange;
            ObjectType = PolicyConfigChange.ObjectTypeEnum.PolicyConfigChange;

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

        public List<string> Changes
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PolicyConfigChange.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> Disruptions
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PolicyConfigChange.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.PolicyConfigChangeDisruptionDetailType> PolicyDisruptions
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.PolicyConfigChange initObject = new Intersight.Model.PolicyConfigChange();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Changes"))
            {
                initObject.Changes = this.Changes;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Disruptions"))
            {
                initObject.Disruptions = this.Disruptions;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PolicyDisruptions"))
            {
                initObject.PolicyDisruptions = this.PolicyDisruptions;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize PolicyConfigChangeContext.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightPolicyConfigChangeContext")]
    public class InitializeIntersightPolicyConfigChangeContext : PSCmdlet
    {
        public InitializeIntersightPolicyConfigChangeContext()
        {
            ClassId = PolicyConfigChangeContext.ClassIdEnum.PolicyConfigChangeContext;
            ObjectType = PolicyConfigChangeContext.ObjectTypeEnum.PolicyConfigChangeContext;

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

        public PolicyConfigChangeContext.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PolicyConfigChangeContext.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.PolicyConfigChangeContext initObject = new Intersight.Model.PolicyConfigChangeContext();
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
    /// <para type="synopsis">This is the cmdlet to Initialize PolicyConfigChangeDetailType.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightPolicyConfigChangeDetailType")]
    public class InitializeIntersightPolicyConfigChangeDetailType : PSCmdlet
    {
        public InitializeIntersightPolicyConfigChangeDetailType()
        {
            ClassId = PolicyConfigChangeDetailType.ClassIdEnum.PolicyConfigChangeDetailType;
            ConfigChangeFlag = PolicyConfigChangeDetailType.ConfigChangeFlagEnum.PendingChanges;
            ModStatus = PolicyConfigChangeDetailType.ModStatusEnum.None;
            ObjectType = PolicyConfigChangeDetailType.ObjectTypeEnum.PolicyConfigChangeDetailType;

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

        public List<string> Changes
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PolicyConfigChangeDetailType.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Context information on the change."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.PolicyConfigResultContext ConfigChangeContext
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Config change flag to differentiate Pending-changes and Config-drift.\n* `Pending-changes` - Config change flag represents changes are due to not deployed changes from Intersight.\n* `Drift-changes` - Config change flag represents changes are due to endpoint configuration changes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PolicyConfigChangeDetailType.ConfigChangeFlagEnum ConfigChangeFlag
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> Disruptions
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed description of the config change."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Message
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Modification status of the mo in this config change.\n* `None` - The 'none' operation/state.Indicates a configuration profile has been deployed, and the desired configuration matches the actual device configuration.\n* `Created` - The 'create' operation/state.Indicates a configuration profile has been created and associated with a device, but the configuration specified in the profilehas not been applied yet. For example, this could happen when the user creates a server profile and has not deployed the profile yet.\n* `Modified` - The 'update' operation/state.Indicates some of the desired configuration changes specified in a profile have not been been applied to the associated device.This happens when the user has made changes to a profile and has not deployed the changes yet, or when the workflow to applythe configuration changes has not completed successfully.\n* `Deleted` - The 'delete' operation/state.Indicates a configuration profile has been been disassociated from a device and the user has not undeployed these changes yet."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PolicyConfigChangeDetailType.ModStatusEnum ModStatus
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PolicyConfigChangeDetailType.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.PolicyConfigChangeDetailType initObject = new Intersight.Model.PolicyConfigChangeDetailType();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Changes"))
            {
                initObject.Changes = this.Changes;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ConfigChangeContext"))
            {
                initObject.ConfigChangeContext = this.ConfigChangeContext;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ConfigChangeFlag"))
            {
                initObject.ConfigChangeFlag = this.ConfigChangeFlag;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Disruptions"))
            {
                initObject.Disruptions = this.Disruptions;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Message"))
            {
                initObject.Message = this.Message;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ModStatus"))
            {
                initObject.ModStatus = this.ModStatus;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize PolicyConfigChangeDisruptionDetailType.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightPolicyConfigChangeDisruptionDetailType")]
    public class InitializeIntersightPolicyConfigChangeDisruptionDetailType : PSCmdlet
    {
        public InitializeIntersightPolicyConfigChangeDisruptionDetailType()
        {
            ClassId = PolicyConfigChangeDisruptionDetailType.ClassIdEnum.PolicyConfigChangeDisruptionDetailType;
            ObjectType = PolicyConfigChangeDisruptionDetailType.ObjectTypeEnum.PolicyConfigChangeDisruptionDetailType;

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

        public PolicyConfigChangeDisruptionDetailType.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> Disruptions
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The current policy has to be redeployed only because there are other policy changes that require this."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsOnlyRequiredByOtherPolicies
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PolicyConfigChangeDisruptionDetailType.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the policy that, when modified, causes the disruption."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PolicyName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the action which is pending on this policy. Example, if policy is not yet activated we mark this field as not-activated. Currently we support two actions, not-deployed and not-activated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PolicyPendingAction
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> RequiredByPolicies
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.PolicyConfigChangeDisruptionDetailType initObject = new Intersight.Model.PolicyConfigChangeDisruptionDetailType();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Disruptions"))
            {
                initObject.Disruptions = this.Disruptions;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsOnlyRequiredByOtherPolicies"))
            {
                initObject.IsOnlyRequiredByOtherPolicies = this.IsOnlyRequiredByOtherPolicies;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PolicyName"))
            {
                initObject.PolicyName = this.PolicyName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PolicyPendingAction"))
            {
                initObject.PolicyPendingAction = this.PolicyPendingAction;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RequiredByPolicies"))
            {
                initObject.RequiredByPolicies = this.RequiredByPolicies;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize PolicyConfigContext.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightPolicyConfigContext")]
    public class InitializeIntersightPolicyConfigContext : PSCmdlet
    {
        public InitializeIntersightPolicyConfigContext()
        {
            ClassId = PolicyConfigContext.ClassIdEnum.PolicyConfigContext;
            ObjectType = PolicyConfigContext.ObjectTypeEnum.PolicyConfigContext;

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

        public PolicyConfigContext.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"System action to trigger the appropriate workflow. Values -- No_op, ConfigChange, Deploy, Unbind."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ControlAction
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates a profile's error state. Values -- Validation-error (Static validation error), Pre-config-error (Runtime validation error), Config-error (Runtime configuration error)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ErrorState
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PolicyConfigContext.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.PolicyConfigContext initObject = new Intersight.Model.PolicyConfigContext();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ControlAction"))
            {
                initObject.ControlAction = this.ControlAction;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ErrorState"))
            {
                initObject.ErrorState = this.ErrorState;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize PolicyConfigResultContext.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightPolicyConfigResultContext")]
    public class InitializeIntersightPolicyConfigResultContext : PSCmdlet
    {
        public InitializeIntersightPolicyConfigResultContext()
        {
            ClassId = PolicyConfigResultContext.ClassIdEnum.PolicyConfigResultContext;
            ObjectType = PolicyConfigResultContext.ObjectTypeEnum.PolicyConfigResultContext;

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

        public PolicyConfigResultContext.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Moid of the object present in config result context."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EntityMoid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the object present in config result context."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EntityName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of the object present in config result context."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EntityType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PolicyConfigResultContext.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Moid of the parent object present in config result context."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ParentMoid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of the policy object associated with the profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ParentPolicyObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of the parent object present in config result context."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ParentType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.PolicyConfigResultContext initObject = new Intersight.Model.PolicyConfigResultContext();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("EntityMoid"))
            {
                initObject.EntityMoid = this.EntityMoid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EntityName"))
            {
                initObject.EntityName = this.EntityName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EntityType"))
            {
                initObject.EntityType = this.EntityType;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ParentMoid"))
            {
                initObject.ParentMoid = this.ParentMoid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ParentPolicyObjectType"))
            {
                initObject.ParentPolicyObjectType = this.ParentPolicyObjectType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ParentType"))
            {
                initObject.ParentType = this.ParentType;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize PolicyPolicyContextHolder.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightPolicyPolicyContextHolder")]
    public class InitializeIntersightPolicyPolicyContextHolder : PSCmdlet
    {
        public InitializeIntersightPolicyPolicyContextHolder()
        {
            ClassId = PolicyPolicyContextHolder.ClassIdEnum.PolicyPolicyContextHolder;
            ObjectType = PolicyPolicyContextHolder.ObjectTypeEnum.PolicyPolicyContextHolder;

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

        public PolicyPolicyContextHolder.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PolicyPolicyContextHolder.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.PolicyPolicyContextHolder initObject = new Intersight.Model.PolicyPolicyContextHolder();
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
    /// <para type="synopsis">This is the cmdlet to Initialize PolicyPolicyError.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightPolicyPolicyError")]
    public class InitializeIntersightPolicyPolicyError : PSCmdlet
    {
        public InitializeIntersightPolicyPolicyError()
        {
            ClassId = PolicyPolicyError.ClassIdEnum.PolicyPolicyError;
            ObjectType = PolicyPolicyError.ObjectTypeEnum.PolicyPolicyError;

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

        public PolicyPolicyError.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PolicyPolicyError.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.PolicyPolicyError initObject = new Intersight.Model.PolicyPolicyError();
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
    /// <para type="synopsis">This is the cmdlet to Initialize PolicyPolicyStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightPolicyPolicyStatus")]
    public class InitializeIntersightPolicyPolicyStatus : PSCmdlet
    {
        public InitializeIntersightPolicyPolicyStatus()
        {
            ClassId = PolicyPolicyStatus.ClassIdEnum.PolicyPolicyStatus;
            ObjectType = PolicyPolicyStatus.ObjectTypeEnum.PolicyPolicyStatus;

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

        public PolicyPolicyStatus.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PolicyPolicyStatus.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.PolicyPolicyStatus initObject = new Intersight.Model.PolicyPolicyStatus();
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
    /// <para type="synopsis">This is the cmdlet to Initialize PolicyQualifier.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightPolicyQualifier")]
    public class InitializeIntersightPolicyQualifier : PSCmdlet
    {
        public InitializeIntersightPolicyQualifier()
        {
            ClassId = PolicyQualifier.ClassIdEnum.PolicyQualifier;
            ObjectType = PolicyQualifier.ObjectTypeEnum.PolicyQualifier;

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PolicyQualifier.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PolicyQualifier.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.PolicyQualifier initObject = new Intersight.Model.PolicyQualifier();
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
    /// <para type="synopsis">This is the cmdlet to Initialize PolicyReportedPolicyChange.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightPolicyReportedPolicyChange")]
    public class InitializeIntersightPolicyReportedPolicyChange : PSCmdlet
    {
        public InitializeIntersightPolicyReportedPolicyChange()
        {
            ClassId = PolicyReportedPolicyChange.ClassIdEnum.PolicyReportedPolicyChange;
            ObjectType = PolicyReportedPolicyChange.ObjectTypeEnum.PolicyReportedPolicyChange;

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

        public PolicyReportedPolicyChange.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PolicyReportedPolicyChange.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.PolicyReportedPolicyChange initObject = new Intersight.Model.PolicyReportedPolicyChange();
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
    /// <para type="synopsis">This is the cmdlet to Initialize PolicyScheduledAction.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightPolicyScheduledAction")]
    public class InitializeIntersightPolicyScheduledAction : PSCmdlet
    {
        public InitializeIntersightPolicyScheduledAction()
        {
            ClassId = PolicyScheduledAction.ClassIdEnum.PolicyScheduledAction;
            ObjectType = PolicyScheduledAction.ObjectTypeEnum.PolicyScheduledAction;

        }
        // <summary>
        /// <para type="description">"Name of the action to be performed on the profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Action
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Qualifiers to control the action being triggered. Action qualifiers are to be specified based on the type of disruptions that an action is to be restricted to. For example, trigger the 'Deploy' action to only perform network and management plane configurations."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.PolicyActionQualifier ActionQualifier
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PolicyScheduledAction.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public PolicyScheduledAction.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"ProceedOnReboot can be used to acknowledge server reboot while triggering deploy/activate."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool ProceedOnReboot
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.PolicyScheduledAction initObject = new Intersight.Model.PolicyScheduledAction();
            if (this.MyInvocation.BoundParameters.ContainsKey("Action"))
            {
                initObject.Action = this.Action;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ActionQualifier"))
            {
                initObject.ActionQualifier = this.ActionQualifier;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ProceedOnReboot"))
            {
                initObject.ProceedOnReboot = this.ProceedOnReboot;
            }
            WriteObject(initObject);
        }

    }
}