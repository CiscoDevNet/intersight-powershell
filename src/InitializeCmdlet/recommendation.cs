using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize RecommendationCapacityRunway.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightRecommendationCapacityRunway")]
    public class InitializeIntersightRecommendationCapacityRunway : PSCmdlet
    {
        public InitializeIntersightRecommendationCapacityRunway()
        {
            ClassId = RecommendationCapacityRunway.ClassIdEnum.RecommendationCapacityRunway;
            ObjectType = RecommendationCapacityRunway.ObjectTypeEnum.RecommendationCapacityRunway;

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

        public RecommendationCapacityRunway.ClassIdEnum ClassId
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

        public RecommendationCapacityRunway.ObjectTypeEnum ObjectType
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
            Intersight.Model.RecommendationCapacityRunway initObject = new Intersight.Model.RecommendationCapacityRunway();
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
    /// <para type="synopsis">This is the cmdlet to Initialize RecommendationClusterExpansion.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightRecommendationClusterExpansion")]
    public class InitializeIntersightRecommendationClusterExpansion : PSCmdlet
    {
        public InitializeIntersightRecommendationClusterExpansion()
        {
            ClassId = RecommendationClusterExpansion.ClassIdEnum.RecommendationClusterExpansion;
            ObjectType = RecommendationClusterExpansion.ObjectTypeEnum.RecommendationClusterExpansion;

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

        public RecommendationClusterExpansion.ClassIdEnum ClassId
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

        public RecommendationClusterExpansion.ObjectTypeEnum ObjectType
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
            Intersight.Model.RecommendationClusterExpansion initObject = new Intersight.Model.RecommendationClusterExpansion();
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
    /// <para type="synopsis">This is the cmdlet to Initialize RecommendationHardwareExpansionRequest.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightRecommendationHardwareExpansionRequest")]
    public class InitializeIntersightRecommendationHardwareExpansionRequest : PSCmdlet
    {
        public InitializeIntersightRecommendationHardwareExpansionRequest()
        {
            Action = RecommendationHardwareExpansionRequest.ActionEnum.None;
            ClassId = RecommendationHardwareExpansionRequest.ClassIdEnum.RecommendationHardwareExpansionRequest;
            ObjectType = RecommendationHardwareExpansionRequest.ObjectTypeEnum.RecommendationHardwareExpansionRequest;

        }
        // <summary>
        /// <para type="description">"Action to be triggered for computing recommendation. Default value is None.\n* `None` - The Enum value None represents that no action is triggered on the forecast Instance managed object.\n* `Evaluate` - The Enum value Evaluate represents that a re-evaluation of the forecast needs to be triggered."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public RecommendationHardwareExpansionRequest.ActionEnum Action
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

        public RecommendationHardwareExpansionRequest.ClassIdEnum ClassId
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

        public RecommendationHardwareExpansionRequest.ObjectTypeEnum ObjectType
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
            Intersight.Model.RecommendationHardwareExpansionRequest initObject = new Intersight.Model.RecommendationHardwareExpansionRequest();
            if (this.MyInvocation.BoundParameters.ContainsKey("Action"))
            {
                initObject.Action = this.Action;
            }
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
    /// <para type="synopsis">This is the cmdlet to Initialize RecommendationHardwareExpansionRequestItem.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightRecommendationHardwareExpansionRequestItem")]
    public class InitializeIntersightRecommendationHardwareExpansionRequestItem : PSCmdlet
    {
        public InitializeIntersightRecommendationHardwareExpansionRequestItem()
        {
            ClassId = RecommendationHardwareExpansionRequestItem.ClassIdEnum.RecommendationHardwareExpansionRequestItem;
            ItemType = RecommendationHardwareExpansionRequestItem.ItemTypeEnum.None;
            MaxValueUnit = RecommendationHardwareExpansionRequestItem.MaxValueUnitEnum.TB;
            ObjectType = RecommendationHardwareExpansionRequestItem.ObjectTypeEnum.RecommendationHardwareExpansionRequestItem;
            UnitType = RecommendationHardwareExpansionRequestItem.UnitTypeEnum.TB;

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

        public RecommendationHardwareExpansionRequestItem.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of hardware item for which the capacity increase is requested by the user. For example, CPU.\n* `None` - The Enum value None represents that no value was set for the hardware type.\n* `CPU` - The Enum value CPU represents that the hardware type requested for expansion is a physical CPU.\n* `Memory` - The Enum value Memory represents that the hardware type requested for expansion is a memory unit.\n* `Storage` - The Enum value Storage represents that the hardware type requested for expansion is a storage unit, ie, storage drives."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public RecommendationHardwareExpansionRequestItem.ItemTypeEnum ItemType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The maximum value allowed for expansion for the hardware type on the referred registered device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public float MaxValue
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Unit type for the maximum value of the resource. For example, TB, GB, MB.\n* `TB` - The Enum value TB represents that the measurement unit is in terabytes.\n* `MB` - The Enum value MB represents that the measurement unit is in megabytes.\n* `GB` - The Enum value GB represents that the measurement unit is in gigabytes.\n* `MHz` - The Enum value MHz represents that the measurement unit is in megahertz.\n* `GHz` - The Enum value GHz represents that the measurement unit is in gigahertz.\n* `Percentage` - The Enum value Percentage represents that the expansion request is in the percentage of resource increase. For example, a 20% increase in CPU capacity."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public RecommendationHardwareExpansionRequestItem.MaxValueUnitEnum MaxValueUnit
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

        public RecommendationHardwareExpansionRequestItem.ObjectTypeEnum ObjectType
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
        /// <para type="description">"Unit type for the expansion request, i.e., if the increase is requested as a raw value in TB, GB, etc., or in percentage increase.\n* `TB` - The Enum value TB represents that the measurement unit is in terabytes.\n* `MB` - The Enum value MB represents that the measurement unit is in megabytes.\n* `GB` - The Enum value GB represents that the measurement unit is in gigabytes.\n* `MHz` - The Enum value MHz represents that the measurement unit is in megahertz.\n* `GHz` - The Enum value GHz represents that the measurement unit is in gigahertz.\n* `Percentage` - The Enum value Percentage represents that the expansion request is in the percentage of resource increase. For example, a 20% increase in CPU capacity."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public RecommendationHardwareExpansionRequestItem.UnitTypeEnum UnitType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Value of the expansion request which can be absolute value or percentage increase."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public float Value
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.RecommendationHardwareExpansionRequestItem initObject = new Intersight.Model.RecommendationHardwareExpansionRequestItem();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ItemType"))
            {
                initObject.ItemType = this.ItemType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaxValue"))
            {
                initObject.MaxValue = this.MaxValue;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaxValueUnit"))
            {
                initObject.MaxValueUnit = this.MaxValueUnit;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("UnitType"))
            {
                initObject.UnitType = this.UnitType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Value"))
            {
                initObject.Value = this.Value;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize RecommendationPhysicalItem.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightRecommendationPhysicalItem")]
    public class InitializeIntersightRecommendationPhysicalItem : PSCmdlet
    {
        public InitializeIntersightRecommendationPhysicalItem()
        {
            ClassId = RecommendationPhysicalItem.ClassIdEnum.RecommendationPhysicalItem;
            ObjectType = RecommendationPhysicalItem.ObjectTypeEnum.RecommendationPhysicalItem;

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

        public RecommendationPhysicalItem.ClassIdEnum ClassId
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

        public RecommendationPhysicalItem.ObjectTypeEnum ObjectType
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
            Intersight.Model.RecommendationPhysicalItem initObject = new Intersight.Model.RecommendationPhysicalItem();
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
    /// <para type="synopsis">This is the cmdlet to Initialize RecommendationPurchaseOrderEstimate.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightRecommendationPurchaseOrderEstimate")]
    public class InitializeIntersightRecommendationPurchaseOrderEstimate : PSCmdlet
    {
        public InitializeIntersightRecommendationPurchaseOrderEstimate()
        {
            Action = RecommendationPurchaseOrderEstimate.ActionEnum.None;
            ClassId = RecommendationPurchaseOrderEstimate.ClassIdEnum.RecommendationPurchaseOrderEstimate;
            ObjectType = RecommendationPurchaseOrderEstimate.ObjectTypeEnum.RecommendationPurchaseOrderEstimate;

        }
        // <summary>
        /// <para type="description">"Action to be triggered for computing estimate. Default value is None.\n* `None` - The Enum value None represents that no action is triggered on the forecast Instance managed object.\n* `Evaluate` - The Enum value Evaluate represents that a re-evaluation of the forecast needs to be triggered."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public RecommendationPurchaseOrderEstimate.ActionEnum Action
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

        public RecommendationPurchaseOrderEstimate.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a recommendationClusterExpansion resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.RecommendationClusterExpansionRelationship ClusterExpansion
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

        public RecommendationPurchaseOrderEstimate.ObjectTypeEnum ObjectType
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
            Intersight.Model.RecommendationPurchaseOrderEstimate initObject = new Intersight.Model.RecommendationPurchaseOrderEstimate();
            if (this.MyInvocation.BoundParameters.ContainsKey("Action"))
            {
                initObject.Action = this.Action;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ClusterExpansion"))
            {
                initObject.ClusterExpansion = this.ClusterExpansion;
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
    /// <para type="synopsis">This is the cmdlet to Initialize RecommendationPurchaseOrderList.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightRecommendationPurchaseOrderList")]
    public class InitializeIntersightRecommendationPurchaseOrderList : PSCmdlet
    {
        public InitializeIntersightRecommendationPurchaseOrderList()
        {
            ClassId = RecommendationPurchaseOrderList.ClassIdEnum.RecommendationPurchaseOrderList;
            ObjectType = RecommendationPurchaseOrderList.ObjectTypeEnum.RecommendationPurchaseOrderList;

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

        public RecommendationPurchaseOrderList.ClassIdEnum ClassId
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

        public RecommendationPurchaseOrderList.ObjectTypeEnum ObjectType
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
            Intersight.Model.RecommendationPurchaseOrderList initObject = new Intersight.Model.RecommendationPurchaseOrderList();
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
    /// <para type="synopsis">This is the cmdlet to Initialize RecommendationSoftwareItem.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightRecommendationSoftwareItem")]
    public class InitializeIntersightRecommendationSoftwareItem : PSCmdlet
    {
        public InitializeIntersightRecommendationSoftwareItem()
        {
            ClassId = RecommendationSoftwareItem.ClassIdEnum.RecommendationSoftwareItem;
            ObjectType = RecommendationSoftwareItem.ObjectTypeEnum.RecommendationSoftwareItem;

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

        public RecommendationSoftwareItem.ClassIdEnum ClassId
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

        public RecommendationSoftwareItem.ObjectTypeEnum ObjectType
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
            Intersight.Model.RecommendationSoftwareItem initObject = new Intersight.Model.RecommendationSoftwareItem();
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
}