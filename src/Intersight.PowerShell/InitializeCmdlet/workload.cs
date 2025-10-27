using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkloadAssignedResource.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkloadAssignedResource")]
    public class InitializeIntersightWorkloadAssignedResource : PSCmdlet
    {
        public InitializeIntersightWorkloadAssignedResource()
        {
            ClassId = WorkloadAssignedResource.ClassIdEnum.WorkloadAssignedResource;
            ObjectType = WorkloadAssignedResource.ObjectTypeEnum.WorkloadAssignedResource;

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

        public WorkloadAssignedResource.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkloadAssignedResource.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkloadAssignedResource initObject = new Intersight.Model.WorkloadAssignedResource();
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkloadBatchDeployment.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkloadBatchDeployment")]
    public class InitializeIntersightWorkloadBatchDeployment : PSCmdlet
    {
        public InitializeIntersightWorkloadBatchDeployment()
        {
            ClassId = WorkloadBatchDeployment.ClassIdEnum.WorkloadBatchDeployment;
            ObjectType = WorkloadBatchDeployment.ObjectTypeEnum.WorkloadBatchDeployment;

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

        public WorkloadBatchDeployment.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkloadBatchDeployment.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkloadBatchDeployment initObject = new Intersight.Model.WorkloadBatchDeployment();
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkloadBlueprint.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkloadBlueprint")]
    public class InitializeIntersightWorkloadBlueprint : PSCmdlet
    {
        public InitializeIntersightWorkloadBlueprint()
        {
            ClassId = WorkloadBlueprint.ClassIdEnum.WorkloadBlueprint;
            ObjectType = WorkloadBlueprint.ObjectTypeEnum.WorkloadBlueprint;
            PlatformType = WorkloadBlueprint.PlatformTypeEnum.None;

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

        public List<Model.BlueprintBlueprintDefinitionDependency> BlueprintDependencies
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a workflowCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowCatalogRelationship Catalog
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkloadBlueprint.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The flag to indicate that this is the default version of the blueprint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool DefaultVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The description for this blueprint which provides information on what are the pre-requisites to deploy the blueprint and what features are supported on the blueprint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When set to false the blueprint is created for use within internal services."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool ExternalMeta
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.BlueprintGeneratedObjectMetadata> GeneratedObjectDefinition
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.WorkflowBaseDataType> InputDefinition
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.BlueprintInputOperationType> InputOperationMetadata
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user friendly short name to identify the blueprint. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.), colon (:), space ( ) or an underscore (_)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+[\\sa-zA-Z0-9_.:-]{1,31}$")]
        public string Label
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
        /// <para type="description">"The name for this blueprint. You can have multiple versions of the blueprint with the same name. Name can only contain letters (a-z, A-Z), numbers (0-9), or an underscore (_)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9][a-zA-Z0-9_]{0,31}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkloadBlueprint.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Intersight platforms supported by this blueprint.\n* `None` - Default value is none, platform is not mentioned.\n* `UnifiedEdge` - The blueprint is created for Unified Edge platform."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkloadBlueprint.PlatformTypeEnum PlatformType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The resource constraint definition for the blueprint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.BlueprintResourceConstraints ResourceDefinition
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.BlueprintServiceItemDefinition> ServiceItems
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
        /// <para type="description">"The version of the blueprint to support multiple versions."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkloadBlueprint initObject = new Intersight.Model.WorkloadBlueprint();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BlueprintDependencies"))
            {
                initObject.BlueprintDependencies = this.BlueprintDependencies;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Catalog"))
            {
                initObject.Catalog = this.Catalog;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DefaultVersion"))
            {
                initObject.DefaultVersion = this.DefaultVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ExternalMeta"))
            {
                initObject.ExternalMeta = this.ExternalMeta;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("GeneratedObjectDefinition"))
            {
                initObject.GeneratedObjectDefinition = this.GeneratedObjectDefinition;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InputDefinition"))
            {
                initObject.InputDefinition = this.InputDefinition;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InputOperationMetadata"))
            {
                initObject.InputOperationMetadata = this.InputOperationMetadata;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("PlatformType"))
            {
                initObject.PlatformType = this.PlatformType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ResourceDefinition"))
            {
                initObject.ResourceDefinition = this.ResourceDefinition;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ServiceItems"))
            {
                initObject.ServiceItems = this.ServiceItems;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject.VarVersion = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkloadBlueprintInputReference.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkloadBlueprintInputReference")]
    public class InitializeIntersightWorkloadBlueprintInputReference : PSCmdlet
    {
        public InitializeIntersightWorkloadBlueprintInputReference()
        {
            ClassId = WorkloadBlueprintInputReference.ClassIdEnum.WorkloadBlueprintInputReference;
            ObjectType = WorkloadBlueprintInputReference.ObjectTypeEnum.WorkloadBlueprintInputReference;

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
        /// <para type="description">"The referred blueprint details."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.MoMoRef Blueprint
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkloadBlueprintInputReference.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The input data for the referred blueprint. All required inputs of the blueprint must have a value provided."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Input
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name for the referred blueprint. This name must be unique within the workload definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9][a-zA-Z0-9- _]{0,31}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkloadBlueprintInputReference.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The constraints that need to be applied to the resources in order to match this blueprint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkloadResourceConstraint ResourceConstraint
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkloadBlueprintInputReference initObject = new Intersight.Model.WorkloadBlueprintInputReference();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Blueprint"))
            {
                initObject.Blueprint = this.Blueprint;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Input"))
            {
                initObject.Input = this.Input;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ResourceConstraint"))
            {
                initObject.ResourceConstraint = this.ResourceConstraint;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkloadBlueprintReference.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkloadBlueprintReference")]
    public class InitializeIntersightWorkloadBlueprintReference : PSCmdlet
    {
        public InitializeIntersightWorkloadBlueprintReference()
        {
            ClassId = WorkloadBlueprintReference.ClassIdEnum.WorkloadBlueprintReference;
            ObjectType = WorkloadBlueprintReference.ObjectTypeEnum.WorkloadBlueprintReference;

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
        /// <para type="description">"The referred blueprint details."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.MoMoRef Blueprint
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkloadBlueprintReference.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The input data for the referred blueprint. All required inputs of the blueprint must have a value provided."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Input
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> InputOverride
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name for the referred blueprint. This name must be unique within the workload definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9][a-zA-Z0-9- _]{0,31}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkloadBlueprintReference.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The constraints that need to be applied to the resources in order to match this blueprint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkloadResourceConstraint ResourceConstraint
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkloadBlueprintReference initObject = new Intersight.Model.WorkloadBlueprintReference();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Blueprint"))
            {
                initObject.Blueprint = this.Blueprint;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Input"))
            {
                initObject.Input = this.Input;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InputOverride"))
            {
                initObject.InputOverride = this.InputOverride;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ResourceConstraint"))
            {
                initObject.ResourceConstraint = this.ResourceConstraint;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkloadCanaryDeployment.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkloadCanaryDeployment")]
    public class InitializeIntersightWorkloadCanaryDeployment : PSCmdlet
    {
        public InitializeIntersightWorkloadCanaryDeployment()
        {
            ClassId = WorkloadCanaryDeployment.ClassIdEnum.WorkloadCanaryDeployment;
            ObjectType = WorkloadCanaryDeployment.ObjectTypeEnum.WorkloadCanaryDeployment;

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

        public WorkloadCanaryDeployment.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkloadCanaryDeployment.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkloadCanaryDeployment initObject = new Intersight.Model.WorkloadCanaryDeployment();
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkloadCloneStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkloadCloneStatus")]
    public class InitializeIntersightWorkloadCloneStatus : PSCmdlet
    {
        public InitializeIntersightWorkloadCloneStatus()
        {
            ClassId = WorkloadCloneStatus.ClassIdEnum.WorkloadCloneStatus;
            ObjectType = WorkloadCloneStatus.ObjectTypeEnum.WorkloadCloneStatus;

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

        public WorkloadCloneStatus.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkloadCloneStatus.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkloadCloneStatus initObject = new Intersight.Model.WorkloadCloneStatus();
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkloadCloneStatusEntry.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkloadCloneStatusEntry")]
    public class InitializeIntersightWorkloadCloneStatusEntry : PSCmdlet
    {
        public InitializeIntersightWorkloadCloneStatusEntry()
        {
            ClassId = WorkloadCloneStatusEntry.ClassIdEnum.WorkloadCloneStatusEntry;
            ObjectType = WorkloadCloneStatusEntry.ObjectTypeEnum.WorkloadCloneStatusEntry;

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

        public WorkloadCloneStatusEntry.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkloadCloneStatusEntry.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkloadCloneStatusEntry initObject = new Intersight.Model.WorkloadCloneStatusEntry();
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkloadDefinitionMapper.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkloadDefinitionMapper")]
    public class InitializeIntersightWorkloadDefinitionMapper : PSCmdlet
    {
        public InitializeIntersightWorkloadDefinitionMapper()
        {
            ClassId = WorkloadDefinitionMapper.ClassIdEnum.WorkloadDefinitionMapper;
            ObjectType = WorkloadDefinitionMapper.ObjectTypeEnum.WorkloadDefinitionMapper;

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

        public WorkloadDefinitionMapper.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the definition being referenced."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string DefinitionName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkloadDefinitionMapper.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The organization to which the definition belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.MoMoRef Organization
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates whether this version is the default version of the referenced definition. If set to true, the version should be the default."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool UsePreferredVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The version number of the referenced definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkloadDefinitionMapper initObject = new Intersight.Model.WorkloadDefinitionMapper();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DefinitionName"))
            {
                initObject.DefinitionName = this.DefinitionName;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Organization"))
            {
                initObject.Organization = this.Organization;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UsePreferredVersion"))
            {
                initObject.UsePreferredVersion = this.UsePreferredVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject.VarVersion = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkloadDeploymentBlueprintInputType.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkloadDeploymentBlueprintInputType")]
    public class InitializeIntersightWorkloadDeploymentBlueprintInputType : PSCmdlet
    {
        public InitializeIntersightWorkloadDeploymentBlueprintInputType()
        {
            ClassId = WorkloadDeploymentBlueprintInputType.ClassIdEnum.WorkloadDeploymentBlueprintInputType;
            ObjectType = WorkloadDeploymentBlueprintInputType.ObjectTypeEnum.WorkloadDeploymentBlueprintInputType;

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
        /// <para type="description">"The referred blueprint details."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.MoMoRef Blueprint
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkloadDeploymentBlueprintInputType.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The input data for the referred blueprint. All required inputs of the blueprint must have a value provided."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Input
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name for the referred blueprint. This name must be unique within the workload definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9][a-zA-Z0-9- _]{0,31}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkloadDeploymentBlueprintInputType.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The constraints that need to be applied to the resources in order to match this blueprint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkloadResourceConstraint ResourceConstraint
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkloadDeploymentBlueprintInputType initObject = new Intersight.Model.WorkloadDeploymentBlueprintInputType();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Blueprint"))
            {
                initObject.Blueprint = this.Blueprint;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Input"))
            {
                initObject.Input = this.Input;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ResourceConstraint"))
            {
                initObject.ResourceConstraint = this.ResourceConstraint;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkloadDeploymentChangeDetail.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkloadDeploymentChangeDetail")]
    public class InitializeIntersightWorkloadDeploymentChangeDetail : PSCmdlet
    {
        public InitializeIntersightWorkloadDeploymentChangeDetail()
        {
            ClassId = WorkloadDeploymentChangeDetail.ClassIdEnum.WorkloadDeploymentChangeDetail;
            ObjectType = WorkloadDeploymentChangeDetail.ObjectTypeEnum.WorkloadDeploymentChangeDetail;

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

        public WorkloadDeploymentChangeDetail.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkloadDeploymentChangeDetail.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkloadDeploymentChangeDetail initObject = new Intersight.Model.WorkloadDeploymentChangeDetail();
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkloadDeploymentInput.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkloadDeploymentInput")]
    public class InitializeIntersightWorkloadDeploymentInput : PSCmdlet
    {
        public InitializeIntersightWorkloadDeploymentInput()
        {
            ClassId = WorkloadDeploymentInput.ClassIdEnum.WorkloadDeploymentInput;
            ObjectType = WorkloadDeploymentInput.ObjectTypeEnum.WorkloadDeploymentInput;

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

        public WorkloadDeploymentInput.ClassIdEnum ClassId
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

        public WorkloadDeploymentInput.ObjectTypeEnum ObjectType
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkloadDeploymentInput initObject = new Intersight.Model.WorkloadDeploymentInput();
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkloadGeneratedObject.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkloadGeneratedObject")]
    public class InitializeIntersightWorkloadGeneratedObject : PSCmdlet
    {
        public InitializeIntersightWorkloadGeneratedObject()
        {
            ClassId = WorkloadGeneratedObject.ClassIdEnum.WorkloadGeneratedObject;
            ObjectType = WorkloadGeneratedObject.ObjectTypeEnum.WorkloadGeneratedObject;

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

        public WorkloadGeneratedObject.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkloadGeneratedObject.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkloadGeneratedObject initObject = new Intersight.Model.WorkloadGeneratedObject();
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkloadResourceConstraint.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkloadResourceConstraint")]
    public class InitializeIntersightWorkloadResourceConstraint : PSCmdlet
    {
        public InitializeIntersightWorkloadResourceConstraint()
        {
            ClassId = WorkloadResourceConstraint.ClassIdEnum.WorkloadResourceConstraint;
            ObjectType = WorkloadResourceConstraint.ObjectTypeEnum.WorkloadResourceConstraint;

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

        public WorkloadResourceConstraint.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The input values from the user for the resource definition of the blueprint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Input
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkloadResourceConstraint.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkloadResourceConstraint initObject = new Intersight.Model.WorkloadResourceConstraint();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Input"))
            {
                initObject.Input = this.Input;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkloadRolloutStrategy.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkloadRolloutStrategy")]
    public class InitializeIntersightWorkloadRolloutStrategy : PSCmdlet
    {
        public InitializeIntersightWorkloadRolloutStrategy()
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

        public WorkloadRolloutStrategy.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkloadRolloutStrategy.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkloadRolloutStrategy initObject = new Intersight.Model.WorkloadRolloutStrategy();
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkloadStateAggregation.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkloadStateAggregation")]
    public class InitializeIntersightWorkloadStateAggregation : PSCmdlet
    {
        public InitializeIntersightWorkloadStateAggregation()
        {
            ClassId = WorkloadStateAggregation.ClassIdEnum.WorkloadStateAggregation;
            ObjectType = WorkloadStateAggregation.ObjectTypeEnum.WorkloadStateAggregation;

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

        public WorkloadStateAggregation.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkloadStateAggregation.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkloadStateAggregation initObject = new Intersight.Model.WorkloadStateAggregation();
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkloadWorkloadDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkloadWorkloadDefinition")]
    public class InitializeIntersightWorkloadWorkloadDefinition : PSCmdlet
    {
        public InitializeIntersightWorkloadWorkloadDefinition()
        {
            ClassId = WorkloadWorkloadDefinition.ClassIdEnum.WorkloadWorkloadDefinition;
            ObjectType = WorkloadWorkloadDefinition.ObjectTypeEnum.WorkloadWorkloadDefinition;
            Status = WorkloadWorkloadDefinition.StatusEnum.Inactive;

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

        public List<Model.WorkloadBlueprintReference> Blueprints
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkloadWorkloadDefinition.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The description for this workload definition."</para>
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
        /// <para type="description">"The name for this Workload. You can have multiple versions of the Workload with the same name. Name can only contain letters (a-z, A-Z), numbers (0-9), space, hyphen (-), or an underscore (_). A refName is generated from the given name, and that along with the version must be unique within an Organization."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9][a-zA-Z0-9- _]{0,31}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkloadWorkloadDefinition.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.OrganizationOrganizationRelationship Organization
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<WorkloadWorkloadDefinition.PlatformTypeEnum> PlatformType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The flag to indicate that this is the preferred (default) version of the workload."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool PreferredVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The strategy used for rolling out deployment changes when this workload version is marked as the preferred version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkloadRolloutStrategy PreferredVersionRolloutStrategy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The status of the definition.\n* `Inactive` - The definition is in an inactive state and there are no workload instances associated with this workload. Changes to input parameters within the workload are allowed in this state.\n* `Active` - The definition is active and associated with one or more workload instances."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkloadWorkloadDefinition.StatusEnum Status
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
        /// <para type="description">"The version of the workload to support multiple versions."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkloadWorkloadDefinition initObject = new Intersight.Model.WorkloadWorkloadDefinition();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Blueprints"))
            {
                initObject.Blueprints = this.Blueprints;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("PlatformType"))
            {
                initObject.PlatformType = this.PlatformType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PreferredVersion"))
            {
                initObject.PreferredVersion = this.PreferredVersion;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PreferredVersionRolloutStrategy"))
            {
                initObject.PreferredVersionRolloutStrategy = this.PreferredVersionRolloutStrategy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Status"))
            {
                initObject.Status = this.Status;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject.VarVersion = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkloadWorkloadDeployment.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkloadWorkloadDeployment")]
    public class InitializeIntersightWorkloadWorkloadDeployment : PSCmdlet
    {
        public InitializeIntersightWorkloadWorkloadDeployment()
        {
            Action = WorkloadWorkloadDeployment.ActionEnum.None;
            ClassId = WorkloadWorkloadDeployment.ClassIdEnum.WorkloadWorkloadDeployment;
            ObjectType = WorkloadWorkloadDeployment.ObjectTypeEnum.WorkloadWorkloadDeployment;

        }
        // <summary>
        /// <para type="description">"The action is performed on the deployment.\n* `None` - No changes have been made.\n* `PrepareToDeploy` - Marks the deployment as ready once the user has completed all changes and the deployment is in a valid state. Once the deployment is marked as PrepareToDeploy, workload instances will be created, but the actual deployment will occur as part of the deploy action.\n* `Deploy` - Initiates the process of pushing workload configuration to the instances based on the configured schedule. Once deployed, the deployment cannot be reverted to draft status.\n* `Suspend` - Suspends the deployment, preventing any further actions until it is resumed. Making changes to deployment configuration will not be pushed out. The deployment will not take any changes from the attached Workload when it is suspended.\n* `Retry` - Retries the deployment for all instances that previously failed.\n* `Resume` - Resumes a suspended deployment. Any changes made to the deployment when it was suspended or any changes made to the attached Workload will now be pushed out based on configured schedules."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkloadWorkloadDeployment.ActionEnum Action
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.WorkloadBlueprintInputReference> Blueprints
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkloadWorkloadDeployment.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A brief description of the deployment."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The minimum digit count to format the instance index with leading zeros,  for example if the digit count is 4 and the start index is 1, then the  first instance will have a suffix 0001. If the number of instances created for the deployment exceeds the 9999, then the suffix will become a 5 digit number."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 4)]
        public long DigitCount
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
        /// <para type="description">"The name for this Deployment. Name can only contain letters (a-z, A-Z), numbers (0-9), space, hyphen (-), or an underscore (_). The name must be unique within the organization."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9][a-zA-Z0-9- _]{0,31}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkloadWorkloadDeployment.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.OrganizationOrganizationRelationship Organization
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.ResourceResourceQualifier> Qualifiers
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The strategy used for rolling out deployment changes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkloadRolloutStrategy RolloutStrategy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a schedulerSchedulePolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.SchedulerSchedulePolicyRelationship SchedulePolicy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The starting index used to generate the suffix for the workload instance name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long StartIndexForSuffix
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
        /// <para type="description">"The workload definition associated with this deployment."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkloadDefinitionMapper WorkloadDefinitionReference
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The prefix to be used for naming workload instances created by this deployment. Prefix can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), or an underscore (_). This prefix must be unique within the organization."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9][a-zA-Z0-9-_]{0,31}$")]
        public string WorkloadInstancePrefix
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkloadWorkloadDeployment initObject = new Intersight.Model.WorkloadWorkloadDeployment();
            if (this.MyInvocation.BoundParameters.ContainsKey("Action"))
            {
                initObject.Action = this.Action;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Blueprints"))
            {
                initObject.Blueprints = this.Blueprints;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DigitCount"))
            {
                initObject.DigitCount = this.DigitCount;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Qualifiers"))
            {
                initObject.Qualifiers = this.Qualifiers;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RolloutStrategy"))
            {
                initObject.RolloutStrategy = this.RolloutStrategy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SchedulePolicy"))
            {
                initObject.SchedulePolicy = this.SchedulePolicy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StartIndexForSuffix"))
            {
                initObject.StartIndexForSuffix = this.StartIndexForSuffix;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("WorkloadDefinitionReference"))
            {
                initObject.WorkloadDefinitionReference = this.WorkloadDefinitionReference;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("WorkloadInstancePrefix"))
            {
                initObject.WorkloadInstancePrefix = this.WorkloadInstancePrefix;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkloadWorkloadInstance.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkloadWorkloadInstance")]
    public class InitializeIntersightWorkloadWorkloadInstance : PSCmdlet
    {
        public InitializeIntersightWorkloadWorkloadInstance()
        {
            Action = WorkloadWorkloadInstance.ActionEnum.None;
            ClassId = WorkloadWorkloadInstance.ClassIdEnum.WorkloadWorkloadInstance;
            ObjectType = WorkloadWorkloadInstance.ObjectTypeEnum.WorkloadWorkloadInstance;

        }
        // <summary>
        /// <para type="description">"The action to be performed on the workload instance.\n* `None` - Absence of any action on the workload instance.\n* `Suspend` - Pauses the execution of the workload instance, temporarily stopping its operations without permanently removing it.\n* `Resume` - Restarts a suspended workload instance, allowing it to continue operations from where it left off.\n* `Deploy` - Initiates the deployment of the workload instance, provisioning the necessary resources and starting its execution.\n* `Retry` - Attempts to re-deploy the workload instance, either due to a previous failure or to apply changes made to the instance.\n* `RetryAll` - Attempts to re-deploy all workload instances associated with the same deployment, either due to a previous failure or to apply changes made to the instances.\n* `Attach` - Associates the workload instance with its assigned resources, allowing it to utilize the resources for its operations.\n* `Detach` - Disassociates the workload instance from its assigned resources, preventing it from using the resources for its operations.\n* `UnAssign` - Detaches assigned resources from the workload instance while keeping the instance active."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkloadWorkloadInstance.ActionEnum Action
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

        public WorkloadWorkloadInstance.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a workloadDeploymentInput resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkloadDeploymentInputRelationship DeploymentInput
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a workloadDeploymentInput resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkloadDeploymentInputRelationship LastDeploymentInput
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

        public WorkloadWorkloadInstance.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.OrganizationOrganizationRelationship Organization
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
        /// <para type="description">"A reference to a workloadWorkloadDeployment resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkloadWorkloadDeploymentRelationship WorkloadDeployment
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkloadWorkloadInstance initObject = new Intersight.Model.WorkloadWorkloadInstance();
            if (this.MyInvocation.BoundParameters.ContainsKey("Action"))
            {
                initObject.Action = this.Action;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DeploymentInput"))
            {
                initObject.DeploymentInput = this.DeploymentInput;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LastDeploymentInput"))
            {
                initObject.LastDeploymentInput = this.LastDeploymentInput;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Organization"))
            {
                initObject.Organization = this.Organization;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("WorkloadDeployment"))
            {
                initObject.WorkloadDeployment = this.WorkloadDeployment;
            }
            WriteObject(initObject);
        }

    }
}