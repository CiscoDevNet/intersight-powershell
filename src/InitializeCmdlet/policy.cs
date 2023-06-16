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

        protected override void ProcessRecord()
        {
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
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PolicyName"))
            {
                initObject.PolicyName = this.PolicyName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PolicyPendingAction"))
            {
                initObject.PolicyPendingAction = this.PolicyPendingAction;
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
        /// <para type="description">"The data of the object present in config result context."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object EntityData
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
            Intersight.Model.PolicyConfigResultContext initObject = new Intersight.Model.PolicyConfigResultContext();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("EntityData"))
            {
                initObject.EntityData = this.EntityData;
            }
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
            if (this.MyInvocation.BoundParameters.ContainsKey("ParentType"))
            {
                initObject.ParentType = this.ParentType;
            }
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
            Intersight.Model.PolicyScheduledAction initObject = new Intersight.Model.PolicyScheduledAction();
            if (this.MyInvocation.BoundParameters.ContainsKey("Action"))
            {
                initObject.Action = this.Action;
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