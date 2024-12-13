using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ResourceAdaptorsRangeFilter.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightResourceAdaptorsRangeFilter")]
    public class InitializeIntersightResourceAdaptorsRangeFilter : PSCmdlet
    {
        public InitializeIntersightResourceAdaptorsRangeFilter()
        {
            ClassId = ResourceAdaptorsRangeFilter.ClassIdEnum.ResourceAdaptorsRangeFilter;
            ConditionType = ResourceAdaptorsRangeFilter.ConditionTypeEnum.RANGE;
            ObjectType = ResourceAdaptorsRangeFilter.ObjectTypeEnum.ResourceAdaptorsRangeFilter;

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

        public ResourceAdaptorsRangeFilter.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Filter condition to extract the resource.\n* `RANGE` - Condition matches with range over value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourceAdaptorsRangeFilter.ConditionTypeEnum ConditionType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum value for the range limit. It should be greater than the minimum value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MaxValue
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Minimum value for the range limit."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MinValue
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourceAdaptorsRangeFilter.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.ResourceAdaptorsRangeFilter initObject = new Intersight.Model.ResourceAdaptorsRangeFilter();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ConditionType"))
            {
                initObject.ConditionType = this.ConditionType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaxValue"))
            {
                initObject.MaxValue = this.MaxValue;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MinValue"))
            {
                initObject.MinValue = this.MinValue;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ResourceBladeQualifier.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightResourceBladeQualifier")]
    public class InitializeIntersightResourceBladeQualifier : PSCmdlet
    {
        public InitializeIntersightResourceBladeQualifier()
        {
            ClassId = ResourceBladeQualifier.ClassIdEnum.ResourceBladeQualifier;
            ObjectType = ResourceBladeQualifier.ObjectTypeEnum.ResourceBladeQualifier;

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

        public List<string> AssetTags
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.ResourceChassisAndSlotQualification> ChassisAndSlotIdRange
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> ChassisPids
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourceBladeQualifier.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourceBladeQualifier.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> Pids
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> UserLabels
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.ResourceBladeQualifier initObject = new Intersight.Model.ResourceBladeQualifier();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AssetTags"))
            {
                initObject.AssetTags = this.AssetTags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ChassisAndSlotIdRange"))
            {
                initObject.ChassisAndSlotIdRange = this.ChassisAndSlotIdRange;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ChassisPids"))
            {
                initObject.ChassisPids = this.ChassisPids;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Pids"))
            {
                initObject.Pids = this.Pids;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UserLabels"))
            {
                initObject.UserLabels = this.UserLabels;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ResourceChassisAndSlotQualification.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightResourceChassisAndSlotQualification")]
    public class InitializeIntersightResourceChassisAndSlotQualification : PSCmdlet
    {
        public InitializeIntersightResourceChassisAndSlotQualification()
        {
            ClassId = ResourceChassisAndSlotQualification.ClassIdEnum.ResourceChassisAndSlotQualification;
            ObjectType = ResourceChassisAndSlotQualification.ObjectTypeEnum.ResourceChassisAndSlotQualification;

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
        /// <para type="description">"The server qualification condition based on the ChassisId range."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.ResourceChassisIdRangeFilter ChassisIdRange
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourceChassisAndSlotQualification.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourceChassisAndSlotQualification.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.ResourceSlotIdRangeFilter> SlotIdRanges
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.ResourceChassisAndSlotQualification initObject = new Intersight.Model.ResourceChassisAndSlotQualification();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ChassisIdRange"))
            {
                initObject.ChassisIdRange = this.ChassisIdRange;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotIdRanges"))
            {
                initObject.SlotIdRanges = this.SlotIdRanges;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ResourceChassisIdRangeFilter.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightResourceChassisIdRangeFilter")]
    public class InitializeIntersightResourceChassisIdRangeFilter : PSCmdlet
    {
        public InitializeIntersightResourceChassisIdRangeFilter()
        {
            ClassId = ResourceChassisIdRangeFilter.ClassIdEnum.ResourceChassisIdRangeFilter;
            ConditionType = ResourceChassisIdRangeFilter.ConditionTypeEnum.RANGE;
            ObjectType = ResourceChassisIdRangeFilter.ObjectTypeEnum.ResourceChassisIdRangeFilter;

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

        public ResourceChassisIdRangeFilter.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Filter condition to extract the resource.\n* `RANGE` - Condition matches with range over value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourceChassisIdRangeFilter.ConditionTypeEnum ConditionType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum value for the range limit. It should be greater than the minimum value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MaxValue
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Minimum value for the range limit."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MinValue
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourceChassisIdRangeFilter.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.ResourceChassisIdRangeFilter initObject = new Intersight.Model.ResourceChassisIdRangeFilter();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ConditionType"))
            {
                initObject.ConditionType = this.ConditionType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaxValue"))
            {
                initObject.MaxValue = this.MaxValue;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MinValue"))
            {
                initObject.MinValue = this.MinValue;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ResourceCpuCoreRangeFilter.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightResourceCpuCoreRangeFilter")]
    public class InitializeIntersightResourceCpuCoreRangeFilter : PSCmdlet
    {
        public InitializeIntersightResourceCpuCoreRangeFilter()
        {
            ClassId = ResourceCpuCoreRangeFilter.ClassIdEnum.ResourceCpuCoreRangeFilter;
            ConditionType = ResourceCpuCoreRangeFilter.ConditionTypeEnum.RANGE;
            ObjectType = ResourceCpuCoreRangeFilter.ObjectTypeEnum.ResourceCpuCoreRangeFilter;

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

        public ResourceCpuCoreRangeFilter.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Filter condition to extract the resource.\n* `RANGE` - Condition matches with range over value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourceCpuCoreRangeFilter.ConditionTypeEnum ConditionType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum value for the range limit. It should be greater than minimum value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MaxValue
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Minimum value for the range limit."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MinValue
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourceCpuCoreRangeFilter.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.ResourceCpuCoreRangeFilter initObject = new Intersight.Model.ResourceCpuCoreRangeFilter();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ConditionType"))
            {
                initObject.ConditionType = this.ConditionType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaxValue"))
            {
                initObject.MaxValue = this.MaxValue;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MinValue"))
            {
                initObject.MinValue = this.MinValue;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ResourceCpuSpeedRangeFilter.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightResourceCpuSpeedRangeFilter")]
    public class InitializeIntersightResourceCpuSpeedRangeFilter : PSCmdlet
    {
        public InitializeIntersightResourceCpuSpeedRangeFilter()
        {
            ClassId = ResourceCpuSpeedRangeFilter.ClassIdEnum.ResourceCpuSpeedRangeFilter;
            ConditionType = ResourceCpuSpeedRangeFilter.ConditionTypeEnum.RANGE;
            ObjectType = ResourceCpuSpeedRangeFilter.ObjectTypeEnum.ResourceCpuSpeedRangeFilter;

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

        public ResourceCpuSpeedRangeFilter.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Filter condition to extract the resource.\n* `RANGE` - Condition matches with range over value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourceCpuSpeedRangeFilter.ConditionTypeEnum ConditionType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum value for the range limit. It should be greater than the minimum value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MaxValue
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Minimum value for the range limit."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MinValue
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourceCpuSpeedRangeFilter.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.ResourceCpuSpeedRangeFilter initObject = new Intersight.Model.ResourceCpuSpeedRangeFilter();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ConditionType"))
            {
                initObject.ConditionType = this.ConditionType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaxValue"))
            {
                initObject.MaxValue = this.MaxValue;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MinValue"))
            {
                initObject.MinValue = this.MinValue;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ResourceDomainQualifier.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightResourceDomainQualifier")]
    public class InitializeIntersightResourceDomainQualifier : PSCmdlet
    {
        public InitializeIntersightResourceDomainQualifier()
        {
            ClassId = ResourceDomainQualifier.ClassIdEnum.ResourceDomainQualifier;
            ObjectType = ResourceDomainQualifier.ObjectTypeEnum.ResourceDomainQualifier;

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

        public ResourceDomainQualifier.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> DomainNames
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> FabricInterConnectPids
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourceDomainQualifier.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.ResourceDomainQualifier initObject = new Intersight.Model.ResourceDomainQualifier();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DomainNames"))
            {
                initObject.DomainNames = this.DomainNames;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FabricInterConnectPids"))
            {
                initObject.FabricInterConnectPids = this.FabricInterConnectPids;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ResourceGpuControllersRangeFilter.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightResourceGpuControllersRangeFilter")]
    public class InitializeIntersightResourceGpuControllersRangeFilter : PSCmdlet
    {
        public InitializeIntersightResourceGpuControllersRangeFilter()
        {
            ClassId = ResourceGpuControllersRangeFilter.ClassIdEnum.ResourceGpuControllersRangeFilter;
            ConditionType = ResourceGpuControllersRangeFilter.ConditionTypeEnum.RANGE;
            ObjectType = ResourceGpuControllersRangeFilter.ObjectTypeEnum.ResourceGpuControllersRangeFilter;

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

        public ResourceGpuControllersRangeFilter.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Filter condition to extract the resource.\n* `RANGE` - Condition matches with range over value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourceGpuControllersRangeFilter.ConditionTypeEnum ConditionType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum value for the range limit. It should be greater than minimum value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MaxValue
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Minimum value for the range limit."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MinValue
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourceGpuControllersRangeFilter.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.ResourceGpuControllersRangeFilter initObject = new Intersight.Model.ResourceGpuControllersRangeFilter();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ConditionType"))
            {
                initObject.ConditionType = this.ConditionType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaxValue"))
            {
                initObject.MaxValue = this.MaxValue;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MinValue"))
            {
                initObject.MinValue = this.MinValue;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ResourceGpuQualifier.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightResourceGpuQualifier")]
    public class InitializeIntersightResourceGpuQualifier : PSCmdlet
    {
        public InitializeIntersightResourceGpuQualifier()
        {
            ClassId = ResourceGpuQualifier.ClassIdEnum.ResourceGpuQualifier;
            GpuEvaluationType = ResourceGpuQualifier.GpuEvaluationTypeEnum.ServerWithoutGpu;
            ObjectType = ResourceGpuQualifier.ObjectTypeEnum.ResourceGpuQualifier;

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

        public ResourceGpuQualifier.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The qualification of resources is based on number of GPU controllers between the minimum and maximum value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.ResourceGpuControllersRangeFilter GpuControllersRange
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The GPU qualifier used for resource qualification is based on gpuEvaluationType.\n* `ServerWithoutGpu` - It is used to specify the evaluation of a resource without a GPU.\n* `ServerWithGpu` - It is used to specify the evaluation of a resource with a GPU.\n* `Unspecified` - It is used to specify that the GPU qualifier should be ignored for the evaluation of a resource."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourceGpuQualifier.GpuEvaluationTypeEnum GpuEvaluationType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourceGpuQualifier.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> Pids
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The qualification of resources is based on vendor of GPU."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vendor
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.ResourceGpuQualifier initObject = new Intersight.Model.ResourceGpuQualifier();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("GpuControllersRange"))
            {
                initObject.GpuControllersRange = this.GpuControllersRange;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("GpuEvaluationType"))
            {
                initObject.GpuEvaluationType = this.GpuEvaluationType;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Pids"))
            {
                initObject.Pids = this.Pids;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vendor"))
            {
                initObject.Vendor = this.Vendor;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ResourceGroup.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightResourceGroup")]
    public class InitializeIntersightResourceGroup : PSCmdlet
    {
        public InitializeIntersightResourceGroup()
        {
            ClassId = ResourceGroup.ClassIdEnum.ResourceGroup;
            ObjectType = ResourceGroup.ObjectTypeEnum.ResourceGroup;
            Qualifier = ResourceGroup.QualifierEnum.AllowSelectors;

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

        public ResourceGroup.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The informative description about the usage of this Resource Group."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

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
        /// <para type="description">"The name of this resource group."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,128}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourceGroup.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to organizationOrganization resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.OrganizationOrganizationRelationship> Organizations
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Qualifier shall be used to specify if we want to organize resources using multiple resource group or single For an account, resource groups can be of only one of the above types. (Both the types are mutually exclusive for an account.).\n* `Allow-Selectors` - Resources will be added to resource groups based on ODATA filter. Multiple resource group can be created to organize resources.\n* `Allow-All` - All resources will become part of the Resource Group. Only one resource group can be created to organize resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourceGroup.QualifierEnum Qualifier
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Set Reevaluate to true to reevaluate the group members and memberships of this resource group."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Reevaluate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.ResourceSelector> Selectors
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
            Intersight.Model.ResourceGroup initObject = new Intersight.Model.ResourceGroup();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Organizations"))
            {
                initObject.Organizations = this.Organizations;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Qualifier"))
            {
                initObject.Qualifier = this.Qualifier;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Reevaluate"))
            {
                initObject.Reevaluate = this.Reevaluate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Selectors"))
            {
                initObject.Selectors = this.Selectors;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ResourceGroupMember.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightResourceGroupMember")]
    public class InitializeIntersightResourceGroupMember : PSCmdlet
    {
        public InitializeIntersightResourceGroupMember()
        {
            ClassId = ResourceGroupMember.ClassIdEnum.ResourceGroupMember;
            ObjectType = ResourceGroupMember.ObjectTypeEnum.ResourceGroupMember;

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

        public ResourceGroupMember.ClassIdEnum ClassId
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

        public ResourceGroupMember.ObjectTypeEnum ObjectType
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
            Intersight.Model.ResourceGroupMember initObject = new Intersight.Model.ResourceGroupMember();
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
    /// <para type="synopsis">This is the cmdlet to Initialize ResourceLicenseResourceCount.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightResourceLicenseResourceCount")]
    public class InitializeIntersightResourceLicenseResourceCount : PSCmdlet
    {
        public InitializeIntersightResourceLicenseResourceCount()
        {
            ClassId = ResourceLicenseResourceCount.ClassIdEnum.ResourceLicenseResourceCount;
            ObjectType = ResourceLicenseResourceCount.ObjectTypeEnum.ResourceLicenseResourceCount;

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

        public ResourceLicenseResourceCount.ClassIdEnum ClassId
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

        public ResourceLicenseResourceCount.ObjectTypeEnum ObjectType
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
            Intersight.Model.ResourceLicenseResourceCount initObject = new Intersight.Model.ResourceLicenseResourceCount();
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
    /// <para type="synopsis">This is the cmdlet to Initialize ResourceMembership.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightResourceMembership")]
    public class InitializeIntersightResourceMembership : PSCmdlet
    {
        public InitializeIntersightResourceMembership()
        {
            ClassId = ResourceMembership.ClassIdEnum.ResourceMembership;
            ObjectType = ResourceMembership.ObjectTypeEnum.ResourceMembership;

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

        public ResourceMembership.ClassIdEnum ClassId
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

        public ResourceMembership.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Set Reevaluate to true to reevaluate the membership of a resource."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Reevaluate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.MoBaseMoRelationship Resource
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to moBaseMo resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoBaseMoRelationship> ResourceAncestors
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
            Intersight.Model.ResourceMembership initObject = new Intersight.Model.ResourceMembership();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Reevaluate"))
            {
                initObject.Reevaluate = this.Reevaluate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Resource"))
            {
                initObject.Resource = this.Resource;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ResourceAncestors"))
            {
                initObject.ResourceAncestors = this.ResourceAncestors;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ResourceMembershipHolder.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightResourceMembershipHolder")]
    public class InitializeIntersightResourceMembershipHolder : PSCmdlet
    {
        public InitializeIntersightResourceMembershipHolder()
        {
            ClassId = ResourceMembershipHolder.ClassIdEnum.ResourceMembershipHolder;
            ObjectType = ResourceMembershipHolder.ObjectTypeEnum.ResourceMembershipHolder;

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

        public ResourceMembershipHolder.ClassIdEnum ClassId
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

        public ResourceMembershipHolder.ObjectTypeEnum ObjectType
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
            Intersight.Model.ResourceMembershipHolder initObject = new Intersight.Model.ResourceMembershipHolder();
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
    /// <para type="synopsis">This is the cmdlet to Initialize ResourceMemoryCapacityRangeFilter.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightResourceMemoryCapacityRangeFilter")]
    public class InitializeIntersightResourceMemoryCapacityRangeFilter : PSCmdlet
    {
        public InitializeIntersightResourceMemoryCapacityRangeFilter()
        {
            ClassId = ResourceMemoryCapacityRangeFilter.ClassIdEnum.ResourceMemoryCapacityRangeFilter;
            ConditionType = ResourceMemoryCapacityRangeFilter.ConditionTypeEnum.RANGE;
            ObjectType = ResourceMemoryCapacityRangeFilter.ObjectTypeEnum.ResourceMemoryCapacityRangeFilter;

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

        public ResourceMemoryCapacityRangeFilter.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Filter condition to extract the resource.\n* `RANGE` - Condition matches with range over value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourceMemoryCapacityRangeFilter.ConditionTypeEnum ConditionType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum value for the range limit. It should be greater than the minimum value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MaxValue
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Minimum value for the range limit."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MinValue
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourceMemoryCapacityRangeFilter.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.ResourceMemoryCapacityRangeFilter initObject = new Intersight.Model.ResourceMemoryCapacityRangeFilter();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ConditionType"))
            {
                initObject.ConditionType = this.ConditionType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaxValue"))
            {
                initObject.MaxValue = this.MaxValue;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MinValue"))
            {
                initObject.MinValue = this.MinValue;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ResourceMemoryQualifier.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightResourceMemoryQualifier")]
    public class InitializeIntersightResourceMemoryQualifier : PSCmdlet
    {
        public InitializeIntersightResourceMemoryQualifier()
        {
            ClassId = ResourceMemoryQualifier.ClassIdEnum.ResourceMemoryQualifier;
            ObjectType = ResourceMemoryQualifier.ObjectTypeEnum.ResourceMemoryQualifier;

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

        public ResourceMemoryQualifier.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The qualification of resources is based on memory range between minimum and maximum value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.ResourceMemoryCapacityRangeFilter MemoryCapacityRange
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The qualification of resources is based on the number of memory units between minimum and maximum value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.ResourceMemoryUnitsRangeFilter MemoryUnitsRange
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourceMemoryQualifier.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.ResourceMemoryQualifier initObject = new Intersight.Model.ResourceMemoryQualifier();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("MemoryCapacityRange"))
            {
                initObject.MemoryCapacityRange = this.MemoryCapacityRange;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MemoryUnitsRange"))
            {
                initObject.MemoryUnitsRange = this.MemoryUnitsRange;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ResourceMemoryUnitsRangeFilter.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightResourceMemoryUnitsRangeFilter")]
    public class InitializeIntersightResourceMemoryUnitsRangeFilter : PSCmdlet
    {
        public InitializeIntersightResourceMemoryUnitsRangeFilter()
        {
            ClassId = ResourceMemoryUnitsRangeFilter.ClassIdEnum.ResourceMemoryUnitsRangeFilter;
            ConditionType = ResourceMemoryUnitsRangeFilter.ConditionTypeEnum.RANGE;
            ObjectType = ResourceMemoryUnitsRangeFilter.ObjectTypeEnum.ResourceMemoryUnitsRangeFilter;

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

        public ResourceMemoryUnitsRangeFilter.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Filter condition to extract the resource.\n* `RANGE` - Condition matches with range over value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourceMemoryUnitsRangeFilter.ConditionTypeEnum ConditionType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum value for the range limit. It should be greater than the minimum value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MaxValue
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Minimum value for the range limit."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MinValue
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourceMemoryUnitsRangeFilter.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.ResourceMemoryUnitsRangeFilter initObject = new Intersight.Model.ResourceMemoryUnitsRangeFilter();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ConditionType"))
            {
                initObject.ConditionType = this.ConditionType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaxValue"))
            {
                initObject.MaxValue = this.MaxValue;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MinValue"))
            {
                initObject.MinValue = this.MinValue;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ResourceNetworkAdaptorQualifier.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightResourceNetworkAdaptorQualifier")]
    public class InitializeIntersightResourceNetworkAdaptorQualifier : PSCmdlet
    {
        public InitializeIntersightResourceNetworkAdaptorQualifier()
        {
            ClassId = ResourceNetworkAdaptorQualifier.ClassIdEnum.ResourceNetworkAdaptorQualifier;
            ObjectType = ResourceNetworkAdaptorQualifier.ObjectTypeEnum.ResourceNetworkAdaptorQualifier;

        }
        // <summary>
        /// <para type="description">"The qualification of resources is based on number of adaptors between the minimum and maximum value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.ResourceAdaptorsRangeFilter AdaptorsRange
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

        public ResourceNetworkAdaptorQualifier.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourceNetworkAdaptorQualifier.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.ResourceNetworkAdaptorQualifier initObject = new Intersight.Model.ResourceNetworkAdaptorQualifier();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdaptorsRange"))
            {
                initObject.AdaptorsRange = this.AdaptorsRange;
            }
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
    /// <para type="synopsis">This is the cmdlet to Initialize ResourcePerTypeCombinedSelector.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightResourcePerTypeCombinedSelector")]
    public class InitializeIntersightResourcePerTypeCombinedSelector : PSCmdlet
    {
        public InitializeIntersightResourcePerTypeCombinedSelector()
        {
            ClassId = ResourcePerTypeCombinedSelector.ClassIdEnum.ResourcePerTypeCombinedSelector;
            ObjectType = ResourcePerTypeCombinedSelector.ObjectTypeEnum.ResourcePerTypeCombinedSelector;

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

        public ResourcePerTypeCombinedSelector.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourcePerTypeCombinedSelector.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.ResourcePerTypeCombinedSelector initObject = new Intersight.Model.ResourcePerTypeCombinedSelector();
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
    /// <para type="synopsis">This is the cmdlet to Initialize ResourceProcessorQualifier.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightResourceProcessorQualifier")]
    public class InitializeIntersightResourceProcessorQualifier : PSCmdlet
    {
        public InitializeIntersightResourceProcessorQualifier()
        {
            ClassId = ResourceProcessorQualifier.ClassIdEnum.ResourceProcessorQualifier;
            ObjectType = ResourceProcessorQualifier.ObjectTypeEnum.ResourceProcessorQualifier;

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

        public ResourceProcessorQualifier.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The qualification of resources is based on number of CPU cores between minimum and maximum value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.ResourceCpuCoreRangeFilter CpuCoresRange
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourceProcessorQualifier.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> Pids
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The qualification of resources is based on speed of the processor between minimum and maximum value in GHz."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.ResourceCpuSpeedRangeFilter SpeedRange
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The qualification of resources is based on the vendor of the processor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vendor
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.ResourceProcessorQualifier initObject = new Intersight.Model.ResourceProcessorQualifier();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CpuCoresRange"))
            {
                initObject.CpuCoresRange = this.CpuCoresRange;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Pids"))
            {
                initObject.Pids = this.Pids;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SpeedRange"))
            {
                initObject.SpeedRange = this.SpeedRange;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vendor"))
            {
                initObject.Vendor = this.Vendor;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ResourceRackIdRangeFilter.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightResourceRackIdRangeFilter")]
    public class InitializeIntersightResourceRackIdRangeFilter : PSCmdlet
    {
        public InitializeIntersightResourceRackIdRangeFilter()
        {
            ClassId = ResourceRackIdRangeFilter.ClassIdEnum.ResourceRackIdRangeFilter;
            ConditionType = ResourceRackIdRangeFilter.ConditionTypeEnum.RANGE;
            ObjectType = ResourceRackIdRangeFilter.ObjectTypeEnum.ResourceRackIdRangeFilter;

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

        public ResourceRackIdRangeFilter.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Filter condition to extract the resource.\n* `RANGE` - Condition matches with range over value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourceRackIdRangeFilter.ConditionTypeEnum ConditionType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum value for the range limit. It should be greater than the minimum value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MaxValue
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Minimum value for the range limit."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MinValue
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourceRackIdRangeFilter.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.ResourceRackIdRangeFilter initObject = new Intersight.Model.ResourceRackIdRangeFilter();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ConditionType"))
            {
                initObject.ConditionType = this.ConditionType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaxValue"))
            {
                initObject.MaxValue = this.MaxValue;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MinValue"))
            {
                initObject.MinValue = this.MinValue;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ResourceRackServerQualifier.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightResourceRackServerQualifier")]
    public class InitializeIntersightResourceRackServerQualifier : PSCmdlet
    {
        public InitializeIntersightResourceRackServerQualifier()
        {
            ClassId = ResourceRackServerQualifier.ClassIdEnum.ResourceRackServerQualifier;
            ObjectType = ResourceRackServerQualifier.ObjectTypeEnum.ResourceRackServerQualifier;

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

        public List<string> AssetTags
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourceRackServerQualifier.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourceRackServerQualifier.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> Pids
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.ResourceRackIdRangeFilter> RackIdRange
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> UserLabels
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.ResourceRackServerQualifier initObject = new Intersight.Model.ResourceRackServerQualifier();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AssetTags"))
            {
                initObject.AssetTags = this.AssetTags;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Pids"))
            {
                initObject.Pids = this.Pids;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RackIdRange"))
            {
                initObject.RackIdRange = this.RackIdRange;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UserLabels"))
            {
                initObject.UserLabels = this.UserLabels;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ResourceReservation.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightResourceReservation")]
    public class InitializeIntersightResourceReservation : PSCmdlet
    {
        public InitializeIntersightResourceReservation()
        {
            ClassId = ResourceReservation.ClassIdEnum.ResourceReservation;
            ObjectType = ResourceReservation.ObjectTypeEnum.ResourceReservation;

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

        public ResourceReservation.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Details of the use case for which the reservation was created, such as decommissioning."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The resource reservation includes an expiration date and a timestamp indicating when this management object will be cleared. The expiration date is set during the decommissioning process and is maintained for a period of 3 months."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime Expiration
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to resourceGroup resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.ResourceGroupRelationship> Groups
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.MoBaseMoRelationship Identity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"MarkFail is used to set the reservation status to Failed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool MarkFail
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

        public ResourceReservation.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identification of the resource is based on the resource OData string, which is mentioned as part of the ReservationSelector. For example, 'Serial eq 'EM6259AE6B'."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ReservationSelector
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of resource that is placed into resource groups or pools. Resource Type can be either 'compute.Blade' or 'compute.RackUnit' for pools."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ResourceType
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
            Intersight.Model.ResourceReservation initObject = new Intersight.Model.ResourceReservation();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Expiration"))
            {
                initObject.Expiration = this.Expiration;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Groups"))
            {
                initObject.Groups = this.Groups;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Identity"))
            {
                initObject.Identity = this.Identity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MarkFail"))
            {
                initObject.MarkFail = this.MarkFail;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ReservationSelector"))
            {
                initObject.ReservationSelector = this.ReservationSelector;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ResourceType"))
            {
                initObject.ResourceType = this.ResourceType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ResourceResourceQualifier.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightResourceResourceQualifier")]
    public class InitializeIntersightResourceResourceQualifier : PSCmdlet
    {
        public InitializeIntersightResourceResourceQualifier()
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

        public ResourceResourceQualifier.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourceResourceQualifier.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.ResourceResourceQualifier initObject = new Intersight.Model.ResourceResourceQualifier();
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
    /// <para type="synopsis">This is the cmdlet to Initialize ResourceSelectionCriteria.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightResourceSelectionCriteria")]
    public class InitializeIntersightResourceSelectionCriteria : PSCmdlet
    {
        public InitializeIntersightResourceSelectionCriteria()
        {
            ClassId = ResourceSelectionCriteria.ClassIdEnum.ResourceSelectionCriteria;
            ObjectType = ResourceSelectionCriteria.ObjectTypeEnum.ResourceSelectionCriteria;

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

        public ResourceSelectionCriteria.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The description of the Resource Selection Criteria."</para>
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
        /// <para type="description">"Name of the Resource Selection Criteria."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,128}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourceSelectionCriteria.ObjectTypeEnum ObjectType
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

        public List<Model.ResourceSelector> Selectors
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
            Intersight.Model.ResourceSelectionCriteria initObject = new Intersight.Model.ResourceSelectionCriteria();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Selectors"))
            {
                initObject.Selectors = this.Selectors;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ResourceSelector.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightResourceSelector")]
    public class InitializeIntersightResourceSelector : PSCmdlet
    {
        public InitializeIntersightResourceSelector()
        {
            ClassId = ResourceSelector.ClassIdEnum.ResourceSelector;
            ObjectType = ResourceSelector.ObjectTypeEnum.ResourceSelector;

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

        public ResourceSelector.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourceSelector.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"ODATA filter to select resources. The group selector may include URLs of individual resource, or OData query with filters that match multiple queries. The URLs must be relative (i.e. do not include the host)."</para>
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
            Intersight.Model.ResourceSelector initObject = new Intersight.Model.ResourceSelector();
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
    /// <para type="synopsis">This is the cmdlet to Initialize ResourceSharedResourcesInfoHolder.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightResourceSharedResourcesInfoHolder")]
    public class InitializeIntersightResourceSharedResourcesInfoHolder : PSCmdlet
    {
        public InitializeIntersightResourceSharedResourcesInfoHolder()
        {
            ClassId = ResourceSharedResourcesInfoHolder.ClassIdEnum.ResourceSharedResourcesInfoHolder;
            ObjectType = ResourceSharedResourcesInfoHolder.ObjectTypeEnum.ResourceSharedResourcesInfoHolder;

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

        public ResourceSharedResourcesInfoHolder.ClassIdEnum ClassId
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

        public ResourceSharedResourcesInfoHolder.ObjectTypeEnum ObjectType
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
            Intersight.Model.ResourceSharedResourcesInfoHolder initObject = new Intersight.Model.ResourceSharedResourcesInfoHolder();
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
    /// <para type="synopsis">This is the cmdlet to Initialize ResourceSlotIdRangeFilter.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightResourceSlotIdRangeFilter")]
    public class InitializeIntersightResourceSlotIdRangeFilter : PSCmdlet
    {
        public InitializeIntersightResourceSlotIdRangeFilter()
        {
            ClassId = ResourceSlotIdRangeFilter.ClassIdEnum.ResourceSlotIdRangeFilter;
            ConditionType = ResourceSlotIdRangeFilter.ConditionTypeEnum.RANGE;
            ObjectType = ResourceSlotIdRangeFilter.ObjectTypeEnum.ResourceSlotIdRangeFilter;

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

        public ResourceSlotIdRangeFilter.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Filter condition to extract the resource.\n* `RANGE` - Condition matches with range over value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourceSlotIdRangeFilter.ConditionTypeEnum ConditionType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum value for the range limit. It should be greater than minimum value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MaxValue
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Minimum value for the range limit."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MinValue
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourceSlotIdRangeFilter.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.ResourceSlotIdRangeFilter initObject = new Intersight.Model.ResourceSlotIdRangeFilter();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ConditionType"))
            {
                initObject.ConditionType = this.ConditionType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaxValue"))
            {
                initObject.MaxValue = this.MaxValue;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MinValue"))
            {
                initObject.MinValue = this.MinValue;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ResourceSourceToPermissionResources.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightResourceSourceToPermissionResources")]
    public class InitializeIntersightResourceSourceToPermissionResources : PSCmdlet
    {
        public InitializeIntersightResourceSourceToPermissionResources()
        {
            ClassId = ResourceSourceToPermissionResources.ClassIdEnum.ResourceSourceToPermissionResources;
            ObjectType = ResourceSourceToPermissionResources.ObjectTypeEnum.ResourceSourceToPermissionResources;

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

        public ResourceSourceToPermissionResources.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourceSourceToPermissionResources.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.ResourceSourceToPermissionResources initObject = new Intersight.Model.ResourceSourceToPermissionResources();
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
    /// <para type="synopsis">This is the cmdlet to Initialize ResourceSourceToPermissionResourcesHolder.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightResourceSourceToPermissionResourcesHolder")]
    public class InitializeIntersightResourceSourceToPermissionResourcesHolder : PSCmdlet
    {
        public InitializeIntersightResourceSourceToPermissionResourcesHolder()
        {
            ClassId = ResourceSourceToPermissionResourcesHolder.ClassIdEnum.ResourceSourceToPermissionResourcesHolder;
            ObjectType = ResourceSourceToPermissionResourcesHolder.ObjectTypeEnum.ResourceSourceToPermissionResourcesHolder;

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

        public ResourceSourceToPermissionResourcesHolder.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourceSourceToPermissionResourcesHolder.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.ResourceSourceToPermissionResourcesHolder initObject = new Intersight.Model.ResourceSourceToPermissionResourcesHolder();
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
    /// <para type="synopsis">This is the cmdlet to Initialize ResourceTag.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightResourceTag")]
    public class InitializeIntersightResourceTag : PSCmdlet
    {
        public InitializeIntersightResourceTag()
        {
            ClassId = ResourceTag.ClassIdEnum.ResourceTag;
            ObjectType = ResourceTag.ObjectTypeEnum.ResourceTag;

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

        public ResourceTag.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Key to match the resource's tag key."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Key
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourceTag.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Value to match the resource's tag value."</para>
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
            Intersight.Model.ResourceTag initObject = new Intersight.Model.ResourceTag();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Key"))
            {
                initObject.Key = this.Key;
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
    /// <para type="synopsis">This is the cmdlet to Initialize ResourceTagQualifier.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightResourceTagQualifier")]
    public class InitializeIntersightResourceTagQualifier : PSCmdlet
    {
        public InitializeIntersightResourceTagQualifier()
        {
            ClassId = ResourceTagQualifier.ClassIdEnum.ResourceTagQualifier;
            ObjectType = ResourceTagQualifier.ObjectTypeEnum.ResourceTagQualifier;

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

        public List<Model.ResourceTag> ChassisTags
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourceTagQualifier.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.ResourceTag> DomainProfileTags
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public ResourceTagQualifier.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.ResourceTag> ServerTags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.ResourceTagQualifier initObject = new Intersight.Model.ResourceTagQualifier();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ChassisTags"))
            {
                initObject.ChassisTags = this.ChassisTags;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DomainProfileTags"))
            {
                initObject.DomainProfileTags = this.DomainProfileTags;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ServerTags"))
            {
                initObject.ServerTags = this.ServerTags;
            }
            WriteObject(initObject);
        }

    }
}