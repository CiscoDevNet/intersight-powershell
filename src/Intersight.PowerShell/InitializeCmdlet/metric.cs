using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize MetricSeverityCriteria.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightMetricSeverityCriteria")]
    public class InitializeIntersightMetricSeverityCriteria : PSCmdlet
    {
        public InitializeIntersightMetricSeverityCriteria()
        {
            ClassId = MetricSeverityCriteria.ClassIdEnum.MetricSeverityCriteria;
            ObjectType = MetricSeverityCriteria.ObjectTypeEnum.MetricSeverityCriteria;
            Operator = MetricSeverityCriteria.OperatorEnum.GreaterThan;
            Severity = MetricSeverityCriteria.SeverityEnum.None;

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

        public MetricSeverityCriteria.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public MetricSeverityCriteria.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The comparison operator that evaluates the metric value against the threshold.\n* `greaterThan` - This checks if the metric value is greater than the threshold value.\n* `lessThan` - This checks if the metric value is less than the threshold value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public MetricSeverityCriteria.OperatorEnum Operator
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The severity of the alarm.\n* `None` - The Enum value None represents that there is no severity.\n* `Info` - The Enum value Info represents the Informational level of severity.\n* `Critical` - The Enum value Critical represents the Critical level of severity.\n* `Warning` - The Enum value Warning represents the Warning level of severity.\n* `Cleared` - The Enum value Cleared represents that the alarm severity has been cleared."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public MetricSeverityCriteria.SeverityEnum Severity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The threshold value of the metric for the corresponding severity."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ThresholdValue
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.MetricSeverityCriteria initObject = new Intersight.Model.MetricSeverityCriteria();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Operator"))
            {
                initObject.Operator = this.Operator;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Severity"))
            {
                initObject.Severity = this.Severity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ThresholdValue"))
            {
                initObject.ThresholdValue = this.ThresholdValue;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize MetricThresholdCondition.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightMetricThresholdCondition")]
    public class InitializeIntersightMetricThresholdCondition : PSCmdlet
    {
        public InitializeIntersightMetricThresholdCondition()
        {
            ClassId = MetricThresholdCondition.ClassIdEnum.MetricThresholdCondition;
            Granularity = MetricThresholdCondition.GranularityEnum.PT10M;
            GroupBy = MetricThresholdCondition.GroupByEnum.HostId;
            ObjectType = MetricThresholdCondition.ObjectTypeEnum.MetricThresholdCondition;
            RollUpAggregate = MetricThresholdCondition.RollUpAggregateEnum.Last;

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

        public MetricThresholdCondition.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CondFilterRule> Filters
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Defines the interval at which alarm condition is evaluated.\n* `PT10M` - Duration of 10 minutes in the ISO 8601 duration format.\n* `PT1M` - Duration of 1 minute in the ISO 8601 duration format.\n* `PT30M` - Duration of 30 minutes in the ISO 8601 duration format.\n* `PT1H` - Duration of 1 hour in the ISO 8601 duration format."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public MetricThresholdCondition.GranularityEnum Granularity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A set of metric attributes used for grouping the metric data. Currently, this can be the 'id' or 'host.id' attributes, as alarms must be generated for Intersight-managed object.\n* `host.id` - The API path of the host associated with the resource component for which the metric is reported.\n* `id` - The API path of the resource component for which the metric is reported."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public MetricThresholdCondition.GroupByEnum GroupBy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The instrument to which the metric belongs to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string InstrumentName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The metric on which condition is specified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string MetricName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public MetricThresholdCondition.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Aggregation function to be applied to the grouped metric values. Example - \"Avg\" network utilization across all uplink ports in FI.\n* `Last` - Last value observed within a time duration - for example, last temperature reading.\n* `Average` - Arithmetic mean of the metric measurements collected over time, calculated as the sum of all metric measurements divided by the count. For example - Average temperature over time.\n* `AverageRate` - Rate of the metric measurements collected over time, calculated as the sum of all metric measurements divided by the duration of collection. For example - Average rate of network CRC errors over time.\n* `Minimum` - Smallest of all the metric values collected over time.\n* `MinimumRate` - Smallest of all the metric rate values collected over time.\n* `Maximum` - Maximum of all metric values collected over time.\n* `MaximumRate` - Maximum of all the metric rate values collected over time.\n* `Sum` - Sum of the metric values, like energy consumed over time.\n* `SumRate` - Sum of the metric rate values over time."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public MetricThresholdCondition.RollUpAggregateEnum RollUpAggregate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MetricSeverityCriteria> SeverityCriteria
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Total number of data points for which the alarm should be evaluated for this condition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long TotalDataPoints
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The minimum number of instances that must satisfy the alarm criteria."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long TriggerCount
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.MetricThresholdCondition initObject = new Intersight.Model.MetricThresholdCondition();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Filters"))
            {
                initObject.Filters = this.Filters;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Granularity"))
            {
                initObject.Granularity = this.Granularity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("GroupBy"))
            {
                initObject.GroupBy = this.GroupBy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InstrumentName"))
            {
                initObject.InstrumentName = this.InstrumentName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MetricName"))
            {
                initObject.MetricName = this.MetricName;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RollUpAggregate"))
            {
                initObject.RollUpAggregate = this.RollUpAggregate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SeverityCriteria"))
            {
                initObject.SeverityCriteria = this.SeverityCriteria;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TotalDataPoints"))
            {
                initObject.TotalDataPoints = this.TotalDataPoints;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TriggerCount"))
            {
                initObject.TriggerCount = this.TriggerCount;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize MetricThresholdDefinitionState.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightMetricThresholdDefinitionState")]
    public class InitializeIntersightMetricThresholdDefinitionState : PSCmdlet
    {
        public InitializeIntersightMetricThresholdDefinitionState()
        {
            ClassId = MetricThresholdDefinitionState.ClassIdEnum.MetricThresholdDefinitionState;
            ObjectType = MetricThresholdDefinitionState.ObjectTypeEnum.MetricThresholdDefinitionState;

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

        public MetricThresholdDefinitionState.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Controls the behavior of alarm processing based on the criteria set for this metric. If set to true which is also the default behavior, the alarm is evaluated against the criteria set for the metric. If set to false, the alarm is not evaluated, and any existing alarms triggered by the criteria set for the metric are cleared."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Enabled
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The instrument to which the metric belongs to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string InstrumentName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The metric for which rule is specified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string MetricName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public MetricThresholdDefinitionState.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.MetricThresholdDefinitionState initObject = new Intersight.Model.MetricThresholdDefinitionState();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Enabled"))
            {
                initObject.Enabled = this.Enabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InstrumentName"))
            {
                initObject.InstrumentName = this.InstrumentName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MetricName"))
            {
                initObject.MetricName = this.MetricName;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
}