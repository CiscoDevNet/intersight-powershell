using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize MonitoringCategoryStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightMonitoringCategoryStatus")]
    public class InitializeIntersightMonitoringCategoryStatus : PSCmdlet
    {
        public InitializeIntersightMonitoringCategoryStatus()
        {
            ClassId = MonitoringCategoryStatus.ClassIdEnum.MonitoringCategoryStatus;
            ObjectType = MonitoringCategoryStatus.ObjectTypeEnum.MonitoringCategoryStatus;
            Status = MonitoringCategoryStatus.StatusEnum.Unknown;

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
        /// <para type="description">"Name of the category for which status is being reported (for e.g. 'Licensing', 'Advisories')."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string CategoryLabel
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public MonitoringCategoryStatus.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Link to the corresponding category specific page in Intersight to get additional information and troubleshoot. for e.g. 'Alarms' category would have the deeplink as 'https://intersight.com/an/cond/alarms/active'."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^(?:http(s)?:\\/\\/)?[\\w.-]+(?:\\.[\\w\\.-]+)+[\\w\\-\\._~:/?#[\\]@!\\$&'\\(\\)\\*\\+,;=.]+$")]
        public string Deeplink
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Additional information regarding category status that may be displayed in UI related to the category status. Optional and currently unused."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Details
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public MonitoringCategoryStatus.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Additional parameter to be used for traceability and troubleshooting, currently unused."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SourceId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Aggregated status of the category being reported. For e.g., a given Intersight account might have a combination of high and low severity Advisories applicable to managed devices. However, even if one of the devices is impacted by a high severity Advisories, the category status is reported as 'critical'.\n* `Unknown` - The current status for the respective category cannot be determined. This may be due to some intermittent issue or due to the fact that the user making the request does not have appropriate privileges/entitlements for the concerned category.\n* `Critical` - The Intersight account is impacted by a high severity issue  for the applicable category that will need to be addressed immediately. for e.g. critical status for 'Advisories' category would mean that the Intersight account is impacted by an urgent field notice or a vulnerability with high severity level.\n* `Warning` - The Intersight account is impacted by a high severity issue  for the applicable category that will need to be addressed soon. for e.g. warning status for 'Advisories' category might mean that the Intersight account is impacted by an a vulnerability with moderate severity level.\n* `Healthy` - The Intersight account is not impacted by any high severity issue for the applicable category."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public MonitoringCategoryStatus.StatusEnum Status
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.MonitoringCategoryStatus initObject = new Intersight.Model.MonitoringCategoryStatus();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CategoryLabel"))
            {
                initObject.CategoryLabel = this.CategoryLabel;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Deeplink"))
            {
                initObject.Deeplink = this.Deeplink;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Details"))
            {
                initObject.Details = this.Details;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SourceId"))
            {
                initObject.SourceId = this.SourceId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Status"))
            {
                initObject.Status = this.Status;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize MonitoringHealthStatus.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightMonitoringHealthStatus")]
    public class InitializeIntersightMonitoringHealthStatus : PSCmdlet
    {
        public InitializeIntersightMonitoringHealthStatus()
        {
            ClassId = MonitoringHealthStatus.ClassIdEnum.MonitoringHealthStatus;
            ObjectType = MonitoringHealthStatus.ObjectTypeEnum.MonitoringHealthStatus;

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

        public List<Model.MonitoringCategoryStatus> CategoryStatus
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public MonitoringHealthStatus.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of compliant health data API schema."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string HealthDataSchemaVersion
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

        public MonitoringHealthStatus.ObjectTypeEnum ObjectType
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
        /// <para type="description">"Set as 'Intersight'. Especially useful in cases such as when this API is consumed by an external dashboard. This field allows such dashboards to aggregate health status across multiple  sources (Intersight, Meraki etc.)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Source
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Time stamp when the status was generated. The status reported by this API may lag the real time status by up to 5 minutes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime StatusTimeStamp
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
            Intersight.Model.MonitoringHealthStatus initObject = new Intersight.Model.MonitoringHealthStatus();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CategoryStatus"))
            {
                initObject.CategoryStatus = this.CategoryStatus;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("HealthDataSchemaVersion"))
            {
                initObject.HealthDataSchemaVersion = this.HealthDataSchemaVersion;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Source"))
            {
                initObject.Source = this.Source;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StatusTimeStamp"))
            {
                initObject.StatusTimeStamp = this.StatusTimeStamp;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
}