using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize BlueprintBaseGeneratedObjectSourceMetadata.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightBlueprintBaseGeneratedObjectSourceMetadata")]
    public class InitializeIntersightBlueprintBaseGeneratedObjectSourceMetadata : PSCmdlet
    {
        public InitializeIntersightBlueprintBaseGeneratedObjectSourceMetadata()
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

        public BlueprintBaseGeneratedObjectSourceMetadata.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BlueprintBaseGeneratedObjectSourceMetadata.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.BlueprintBaseGeneratedObjectSourceMetadata initObject = new Intersight.Model.BlueprintBaseGeneratedObjectSourceMetadata();
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
    /// <para type="synopsis">This is the cmdlet to Initialize BlueprintBlueprintDefinitionDependency.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightBlueprintBlueprintDefinitionDependency")]
    public class InitializeIntersightBlueprintBlueprintDefinitionDependency : PSCmdlet
    {
        public InitializeIntersightBlueprintBlueprintDefinitionDependency()
        {
            ClassId = BlueprintBlueprintDefinitionDependency.ClassIdEnum.BlueprintBlueprintDefinitionDependency;
            ObjectType = BlueprintBlueprintDefinitionDependency.ObjectTypeEnum.BlueprintBlueprintDefinitionDependency;

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
        /// <para type="description">"The qualified name of blueprint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string BlueprintName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specify the catalog moid that this blueprint belongs too. When catalog moid is not specified then the catalog of the parent blueprint is used first and if no blueprint can be found in that catalog, then the system catalog is used."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string CatalogMoid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BlueprintBlueprintDefinitionDependency.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The description of that describes the purpose of including this dependent blueprint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If any input of the nested blueprint needs to be modified in some form to include data from the parent blueprint, then the input parameters can be specified here."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object InputParameters
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user defined label identifier for this blueprint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BlueprintBlueprintDefinitionDependency.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The blueprint version. If not specified, the default version is used."</para>
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
            Intersight.Model.BlueprintBlueprintDefinitionDependency initObject = new Intersight.Model.BlueprintBlueprintDefinitionDependency();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BlueprintName"))
            {
                initObject.BlueprintName = this.BlueprintName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CatalogMoid"))
            {
                initObject.CatalogMoid = this.CatalogMoid;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InputParameters"))
            {
                initObject.InputParameters = this.InputParameters;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject.VarVersion = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize BlueprintGeneratedObjectMetadata.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightBlueprintGeneratedObjectMetadata")]
    public class InitializeIntersightBlueprintGeneratedObjectMetadata : PSCmdlet
    {
        public InitializeIntersightBlueprintGeneratedObjectMetadata()
        {
            ClassId = BlueprintGeneratedObjectMetadata.ClassIdEnum.BlueprintGeneratedObjectMetadata;
            ObjectType = BlueprintGeneratedObjectMetadata.ObjectTypeEnum.BlueprintGeneratedObjectMetadata;

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

        public BlueprintGeneratedObjectMetadata.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> Conditions
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name for the generated object. The name given for reference in later parts of the blueprint definition. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-) or an underscore (_). The first and last character in name must be an alphanumeric character."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+([a-zA-Z0-9-_]*[a-zA-Z0-9])*$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A template for controlling loop behavior when generating multiple instances of the generated object. The resolved value of the template is expected to be an integer which is used to determine the number of iterations in the loop. Each iteration creates a new instance of the generated object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ObjectIteration
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The source object from which the object is generated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.BlueprintBaseGeneratedObjectSourceMetadata ObjectSource
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BlueprintGeneratedObjectMetadata.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.BlueprintPreGenerateOperation> PreGenerateOperations
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.BlueprintPropertyIteration> PropertyIteration
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A list of key value pairs where key is the property path and value is the template to derive the value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object PropertyParameters
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The flag to indicate if this object must be generated for this blueprint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Required
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.BlueprintGeneratedObjectMetadata initObject = new Intersight.Model.BlueprintGeneratedObjectMetadata();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Conditions"))
            {
                initObject.Conditions = this.Conditions;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ObjectIteration"))
            {
                initObject.ObjectIteration = this.ObjectIteration;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ObjectSource"))
            {
                initObject.ObjectSource = this.ObjectSource;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PreGenerateOperations"))
            {
                initObject.PreGenerateOperations = this.PreGenerateOperations;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PropertyIteration"))
            {
                initObject.PropertyIteration = this.PropertyIteration;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PropertyParameters"))
            {
                initObject.PropertyParameters = this.PropertyParameters;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Required"))
            {
                initObject.Required = this.Required;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize BlueprintGeneratedObjectNew.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightBlueprintGeneratedObjectNew")]
    public class InitializeIntersightBlueprintGeneratedObjectNew : PSCmdlet
    {
        public InitializeIntersightBlueprintGeneratedObjectNew()
        {
            ClassId = BlueprintGeneratedObjectNew.ClassIdEnum.BlueprintGeneratedObjectNew;
            ObjectType = BlueprintGeneratedObjectNew.ObjectTypeEnum.BlueprintGeneratedObjectNew;

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

        public BlueprintGeneratedObjectNew.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The flag to indicate that a collection of objects will be created based on an array input."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Collection
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of the object being created new."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string CreateObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BlueprintGeneratedObjectNew.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.BlueprintGeneratedObjectNew initObject = new Intersight.Model.BlueprintGeneratedObjectNew();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Collection"))
            {
                initObject.Collection = this.Collection;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CreateObjectType"))
            {
                initObject.CreateObjectType = this.CreateObjectType;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize BlueprintGeneratedObjectOperationTarget.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightBlueprintGeneratedObjectOperationTarget")]
    public class InitializeIntersightBlueprintGeneratedObjectOperationTarget : PSCmdlet
    {
        public InitializeIntersightBlueprintGeneratedObjectOperationTarget()
        {
            ClassId = BlueprintGeneratedObjectOperationTarget.ClassIdEnum.BlueprintGeneratedObjectOperationTarget;
            ObjectType = BlueprintGeneratedObjectOperationTarget.ObjectTypeEnum.BlueprintGeneratedObjectOperationTarget;

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

        public BlueprintGeneratedObjectOperationTarget.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the generated object metadata. The objects produced from this metadata are the target of the operation."</para>
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

        public BlueprintGeneratedObjectOperationTarget.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A list of key value pairs where key is the property path and value is the template to derive the value. The target of the pre-generation operation is updated with the resolved values of these parameters. This operation is only applicable if the operation is of type \"Update\"."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object PropertyParameters
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.BlueprintGeneratedObjectOperationTarget initObject = new Intersight.Model.BlueprintGeneratedObjectOperationTarget();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("PropertyParameters"))
            {
                initObject.PropertyParameters = this.PropertyParameters;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize BlueprintGeneratedObjectSourceClone.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightBlueprintGeneratedObjectSourceClone")]
    public class InitializeIntersightBlueprintGeneratedObjectSourceClone : PSCmdlet
    {
        public InitializeIntersightBlueprintGeneratedObjectSourceClone()
        {
            ClassId = BlueprintGeneratedObjectSourceClone.ClassIdEnum.BlueprintGeneratedObjectSourceClone;
            CloneType = BlueprintGeneratedObjectSourceClone.CloneTypeEnum.Clone;
            ObjectType = BlueprintGeneratedObjectSourceClone.ObjectTypeEnum.BlueprintGeneratedObjectSourceClone;

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

        public BlueprintGeneratedObjectSourceClone.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of the source object.\n* `Clone` - The generated object will cloned from the given source object.\n* `DeepClone` - The generated object will deep cloned from the given source object. This means the object referenced in the source object will also be cloned."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BlueprintGeneratedObjectSourceClone.CloneTypeEnum CloneType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BlueprintGeneratedObjectSourceClone.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.BlueprintGeneratedObjectSourceSelector> SourceSelectors
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.BlueprintGeneratedObjectSourceClone initObject = new Intersight.Model.BlueprintGeneratedObjectSourceClone();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CloneType"))
            {
                initObject.CloneType = this.CloneType;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SourceSelectors"))
            {
                initObject.SourceSelectors = this.SourceSelectors;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize BlueprintGeneratedObjectSourceLookup.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightBlueprintGeneratedObjectSourceLookup")]
    public class InitializeIntersightBlueprintGeneratedObjectSourceLookup : PSCmdlet
    {
        public InitializeIntersightBlueprintGeneratedObjectSourceLookup()
        {
            ClassId = BlueprintGeneratedObjectSourceLookup.ClassIdEnum.BlueprintGeneratedObjectSourceLookup;
            LookupType = BlueprintGeneratedObjectSourceLookup.LookupTypeEnum.Cloned;
            ObjectType = BlueprintGeneratedObjectSourceLookup.ObjectTypeEnum.BlueprintGeneratedObjectSourceLookup;

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

        public BlueprintGeneratedObjectSourceLookup.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of the object being looked up.\n* `Cloned` - The generated object that is being looked up is a result of a deep clone from a previous step.\n* `PreCreated` - The generated object that is being looked up is an existing or pre-created object from the system catalog or from the user account."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BlueprintGeneratedObjectSourceLookup.LookupTypeEnum LookupType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BlueprintGeneratedObjectSourceLookup.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.BlueprintGeneratedObjectSourceSelector> SourceSelectors
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.BlueprintGeneratedObjectSourceLookup initObject = new Intersight.Model.BlueprintGeneratedObjectSourceLookup();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("LookupType"))
            {
                initObject.LookupType = this.LookupType;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SourceSelectors"))
            {
                initObject.SourceSelectors = this.SourceSelectors;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize BlueprintGeneratedObjectSourceMerge.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightBlueprintGeneratedObjectSourceMerge")]
    public class InitializeIntersightBlueprintGeneratedObjectSourceMerge : PSCmdlet
    {
        public InitializeIntersightBlueprintGeneratedObjectSourceMerge()
        {
            ClassId = BlueprintGeneratedObjectSourceMerge.ClassIdEnum.BlueprintGeneratedObjectSourceMerge;
            MergeAction = BlueprintGeneratedObjectSourceMerge.MergeActionEnum.Merge;
            ObjectType = BlueprintGeneratedObjectSourceMerge.ObjectTypeEnum.BlueprintGeneratedObjectSourceMerge;

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

        public BlueprintGeneratedObjectSourceMerge.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The action to be performed when merging the source object with the target object. When the action is set to \"Merge\", all empty source properties are ignored. \"Replace\" action replaces all properties in the target object with the source object properties.\n* `Merge` - The null properties/relationships of the source MO will be ignored for the target MO. The non-null properties/relationships of the source will override the target MO properties/relationships.\n* `Replace` - Merge action as described in RFC 7386. The null properties/relationships of the source MO will be deleted on the target MO.The non-null properties/relationships of the source will override the target MO properties/relationships.When source object type is different from target, only the properties common to both source and target  will be affected.Other properties on the target will be ignored."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BlueprintGeneratedObjectSourceMerge.MergeActionEnum MergeAction
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BlueprintGeneratedObjectSourceMerge.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.BlueprintGeneratedObjectSourceSelector> SourceSelectors
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.BlueprintGeneratedObjectSourceMerge initObject = new Intersight.Model.BlueprintGeneratedObjectSourceMerge();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("MergeAction"))
            {
                initObject.MergeAction = this.MergeAction;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SourceSelectors"))
            {
                initObject.SourceSelectors = this.SourceSelectors;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize BlueprintGeneratedObjectSourceReference.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightBlueprintGeneratedObjectSourceReference")]
    public class InitializeIntersightBlueprintGeneratedObjectSourceReference : PSCmdlet
    {
        public InitializeIntersightBlueprintGeneratedObjectSourceReference()
        {
            ClassId = BlueprintGeneratedObjectSourceReference.ClassIdEnum.BlueprintGeneratedObjectSourceReference;
            ObjectType = BlueprintGeneratedObjectSourceReference.ObjectTypeEnum.BlueprintGeneratedObjectSourceReference;

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

        public BlueprintGeneratedObjectSourceReference.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BlueprintGeneratedObjectSourceReference.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When the source object is of type reference, then the source parameter will be the parameter that refers to the source object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SourceParameter
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.BlueprintGeneratedObjectSourceReference initObject = new Intersight.Model.BlueprintGeneratedObjectSourceReference();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SourceParameter"))
            {
                initObject.SourceParameter = this.SourceParameter;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize BlueprintGeneratedObjectSourceSelector.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightBlueprintGeneratedObjectSourceSelector")]
    public class InitializeIntersightBlueprintGeneratedObjectSourceSelector : PSCmdlet
    {
        public InitializeIntersightBlueprintGeneratedObjectSourceSelector()
        {
            ClassId = BlueprintGeneratedObjectSourceSelector.ClassIdEnum.BlueprintGeneratedObjectSourceSelector;
            ObjectType = BlueprintGeneratedObjectSourceSelector.ObjectTypeEnum.BlueprintGeneratedObjectSourceSelector;

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

        public BlueprintGeneratedObjectSourceSelector.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BlueprintGeneratedObjectSourceSelector.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The selector to identify the source object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|/api/v1/.*")]
        public string Selector
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.BlueprintGeneratedObjectSourceSelector initObject = new Intersight.Model.BlueprintGeneratedObjectSourceSelector();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Selector"))
            {
                initObject.Selector = this.Selector;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize BlueprintInputOperationType.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightBlueprintInputOperationType")]
    public class InitializeIntersightBlueprintInputOperationType : PSCmdlet
    {
        public InitializeIntersightBlueprintInputOperationType()
        {
            ClassId = BlueprintInputOperationType.ClassIdEnum.BlueprintInputOperationType;
            ObjectType = BlueprintInputOperationType.ObjectTypeEnum.BlueprintInputOperationType;

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

        public BlueprintInputOperationType.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<BlueprintInputOperationType.ImpactTypeEnum> ImpactType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the input as defined within the definition."</para>
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

        public BlueprintInputOperationType.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<BlueprintInputOperationType.OperationModesEnum> OperationModes
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.BlueprintInputOperationType initObject = new Intersight.Model.BlueprintInputOperationType();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ImpactType"))
            {
                initObject.ImpactType = this.ImpactType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OperationModes"))
            {
                initObject.OperationModes = this.OperationModes;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize BlueprintPreGenerateOperation.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightBlueprintPreGenerateOperation")]
    public class InitializeIntersightBlueprintPreGenerateOperation : PSCmdlet
    {
        public InitializeIntersightBlueprintPreGenerateOperation()
        {
            ClassId = BlueprintPreGenerateOperation.ClassIdEnum.BlueprintPreGenerateOperation;
            ObjectType = BlueprintPreGenerateOperation.ObjectTypeEnum.BlueprintPreGenerateOperation;
            Operation = BlueprintPreGenerateOperation.OperationEnum.Update;

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

        public BlueprintPreGenerateOperation.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.BlueprintGeneratedObjectOperationTarget> GeneratedObjects
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BlueprintPreGenerateOperation.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The operation to be performed before generating the object.\n* `Update` - The operation is to update the object via an HTTP PATCH operation.\n* `Delete` - The operation is to immediately delete the object via an HTTP DELETE operation.\n* `MarkDeleted` - The object is marked as deleted. This adds a tag to the object indicating that it should be deleted as part of the object cleanup task during workload deployment."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BlueprintPreGenerateOperation.OperationEnum Operation
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.BlueprintPreGenerateOperation initObject = new Intersight.Model.BlueprintPreGenerateOperation();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("GeneratedObjects"))
            {
                initObject.GeneratedObjects = this.GeneratedObjects;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Operation"))
            {
                initObject.Operation = this.Operation;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize BlueprintPropertyIteration.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightBlueprintPropertyIteration")]
    public class InitializeIntersightBlueprintPropertyIteration : PSCmdlet
    {
        public InitializeIntersightBlueprintPropertyIteration()
        {
            ClassId = BlueprintPropertyIteration.ClassIdEnum.BlueprintPropertyIteration;
            ObjectType = BlueprintPropertyIteration.ObjectTypeEnum.BlueprintPropertyIteration;

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

        public BlueprintPropertyIteration.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The expression to evaluate for each iteration. This expression can refer to the array input that is being iterated over. The value of this expression will be used to populate the array property in the generated object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Iteration
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the array property in the generated object to populate."</para>
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

        public BlueprintPropertyIteration.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.BlueprintPropertyIteration initObject = new Intersight.Model.BlueprintPropertyIteration();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Iteration"))
            {
                initObject.Iteration = this.Iteration;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize BlueprintResourceConstraints.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightBlueprintResourceConstraints")]
    public class InitializeIntersightBlueprintResourceConstraints : PSCmdlet
    {
        public InitializeIntersightBlueprintResourceConstraints()
        {
            ClassId = BlueprintResourceConstraints.ClassIdEnum.BlueprintResourceConstraints;
            ObjectType = BlueprintResourceConstraints.ObjectTypeEnum.BlueprintResourceConstraints;

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

        public BlueprintResourceConstraints.ClassIdEnum ClassId
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BlueprintResourceConstraints.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.BlueprintResourceConstraints initObject = new Intersight.Model.BlueprintResourceConstraints();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("InputDefinition"))
            {
                initObject.InputDefinition = this.InputDefinition;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize BlueprintServiceItemDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightBlueprintServiceItemDefinition")]
    public class InitializeIntersightBlueprintServiceItemDefinition : PSCmdlet
    {
        public InitializeIntersightBlueprintServiceItemDefinition()
        {
            ClassId = BlueprintServiceItemDefinition.ClassIdEnum.BlueprintServiceItemDefinition;
            ObjectType = BlueprintServiceItemDefinition.ObjectTypeEnum.BlueprintServiceItemDefinition;

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
        /// <para type="description">"Specify the catalog moid that this service item belongs. When catalog moid is not specified then the catalog of the service item is used first and if no service item can be found in that catalog, then the system catalog is used."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string CatalogMoid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BlueprintServiceItemDefinition.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The description of that describes the purpose of including this service item within the blueprint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Capture the mapping of blueprint inputs to service item inputs. The mapping for inputs can refer to blueprint inputs or to the generated objects which are part of this blueprint and all nested blueprints. The mapping will be referred using the convention of ${<BlueprintName>.input.<InputName>} or ${<BlueprintName>.generatedObject.<GeneratedObjectName>}."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object InputParameters
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user defined label identifier for this Service item."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public BlueprintServiceItemDefinition.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The qualified name of service item that should be executed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ServiceItemDefinitionName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The service item definition version. If not specified, the default version of the service item is used."</para>
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
            Intersight.Model.BlueprintServiceItemDefinition initObject = new Intersight.Model.BlueprintServiceItemDefinition();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CatalogMoid"))
            {
                initObject.CatalogMoid = this.CatalogMoid;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InputParameters"))
            {
                initObject.InputParameters = this.InputParameters;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ServiceItemDefinitionName"))
            {
                initObject.ServiceItemDefinitionName = this.ServiceItemDefinitionName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject.VarVersion = this.Version;
            }
            WriteObject(initObject);
        }

    }
}