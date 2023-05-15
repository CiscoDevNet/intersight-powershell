using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize TamAction.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightTamAction")]
    public class InitializeIntersightTamAction : PSCmdlet
    {
        public InitializeIntersightTamAction()
        {
            AlertType = TamAction.AlertTypeEnum.Psirt;
            ClassId = TamAction.ClassIdEnum.TamAction;
            ObjectType = TamAction.ObjectTypeEnum.TamAction;
            OperationType = TamAction.OperationTypeEnum.Create;
            Type = TamAction.TypeEnum.RestApi;

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
        /// <para type="description">"Type of the managed object that should be marked with an instance of the Alert (when operation type is create) or that should have an alert instance removed (when operation type is remove)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string AffectedObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Alert type is used to denote the category of an Intersight alert (FieldNotice, equipment Fault etc.).\n* `psirt` - Respresents the psirt alert type (https://tools.cisco.com/security/center/publicationListing.x).\n* `fieldNotice` - Respresents the field notice alert type (https://www.cisco.com/c/en/us/support/web/tsd-products-field-notice-summary.html).\n* `eolAdvisory` - Represents product End of Life (EOL) type (https://www.cisco.com/c/en/us/products/eos-eol-policy.html)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TamAction.AlertTypeEnum AlertType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TamAction.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.TamIdentifiers> Identifiers
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Uniquely identifies a given action among the set of actions corresponding to an advisory. Primarily used to store and compare results of subsequent iterations corresponding to the action queries."</para>
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

        public TamAction.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Operation type for the alert action. An action is used to carry out the process of \"reacting\" to an alert condition. For e.g.in case of a fieldNotice alert, the intention may be to create a new alert (if the condition matches and there is no existing alert) or to remove an existing alert when the alert condition has been remedied.\n* `create` - Create an instance of AdvisoryInstance.\n* `remove` - Remove an instance of AdvisoryInstance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TamAction.OperationTypeEnum OperationType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.TamQueryEntry> Queries
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of Intersight alert. An alert in Intersight could be one of several kinds (FieldNotice, PSIRT etc.). Primarily used for filtering alerts based on the type.\n* `restApi` - Repesents the use of REST API for carrying out alert actions."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TamAction.TypeEnum Type
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.TamAction initObject = new Intersight.Model.TamAction();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AffectedObjectType"))
            {
                initObject.AffectedObjectType = this.AffectedObjectType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AlertType"))
            {
                initObject.AlertType = this.AlertType;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Identifiers"))
            {
                initObject.Identifiers = this.Identifiers;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OperationType"))
            {
                initObject.OperationType = this.OperationType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Queries"))
            {
                initObject.Queries = this.Queries;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Type"))
            {
                initObject.Type = this.Type;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize TamAdvisoryCount.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightTamAdvisoryCount")]
    public class InitializeIntersightTamAdvisoryCount : PSCmdlet
    {
        public InitializeIntersightTamAdvisoryCount()
        {
            ClassId = TamAdvisoryCount.ClassIdEnum.TamAdvisoryCount;
            ObjectType = TamAdvisoryCount.ObjectTypeEnum.TamAdvisoryCount;

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
        /// <para type="description">"Total number of advisories affecting the account."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long AdvisoryCount
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TamAdvisoryCount.ClassIdEnum ClassId
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

        public TamAdvisoryCount.ObjectTypeEnum ObjectType
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
            Intersight.Model.TamAdvisoryCount initObject = new Intersight.Model.TamAdvisoryCount();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdvisoryCount"))
            {
                initObject.AdvisoryCount = this.AdvisoryCount;
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
    /// <para type="synopsis">This is the cmdlet to Initialize TamAdvisoryDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightTamAdvisoryDefinition")]
    public class InitializeIntersightTamAdvisoryDefinition : PSCmdlet
    {
        public InitializeIntersightTamAdvisoryDefinition()
        {
            ClassId = TamAdvisoryDefinition.ClassIdEnum.TamAdvisoryDefinition;
            ExecuteOnPod = TamAdvisoryDefinition.ExecuteOnPodEnum.Tier1;
            ObjectType = TamAdvisoryDefinition.ObjectTypeEnum.TamAdvisoryDefinition;
            State = TamAdvisoryDefinition.StateEnum.Ready;
            Type = TamAdvisoryDefinition.TypeEnum.SecurityAdvisory;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.TamAction> Actions
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
        /// <para type="description">"Additional details for the advisory definition. For e.g. if the definition corresponds to a security advisory, the details regarding CVE ids and CVSS score would be available here. If the definition is for an end-of-life milestone, the details about the specific milestone will be included."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.TamBaseAdvisoryDetails AdvisoryDetails
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Cisco generated identifier for the published security/field-notice/end-of-life advisory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string AdvisoryId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.TamApiDataSource> ApiDataSources
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TamAdvisoryDefinition.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Date when the security/field-notice/end-of-life advisory was first published by Cisco."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime DatePublished
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Date when the security/field-notice/end-of-life advisory was last updated by Cisco."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime DateUpdated
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Brief description of the advisory details."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Orion pod on which this advisory should process.\n* `tier1` - Advisory processing will be taken care in first advisory driver of multinode cluster.\n* `tier2` - Advisory processing will be taken care in second advisory driver of multinode cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TamAdvisoryDefinition.ExecuteOnPodEnum ExecuteOnPod
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A link to an external URL describing security Advisory in more details."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^(?:http(s)?:\\/\\/)?[\\w.-]+(?:\\.[\\w\\.-]+)+[\\w\\-\\._~:/?#[\\]@!\\$&'\\(\\)\\*\\+,;=.]+$")]
        public string ExternalUrl
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
        /// <para type="description">"A user defined name for the Intersight Advisory."</para>
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

        public TamAdvisoryDefinition.ObjectTypeEnum ObjectType
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

        public List<string> OtherRefUrls
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Recommended action to resolve the security advisory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Recommendation
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.TamS3DataSource> S3DataSources
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Severity level of the Intersight Advisory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.TamSeverity Severity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Current state of the advisory.\n* `ready` - Advisory has been evaluated. The affected devices would be analyzed and corresponding advisory instances would be created.\n* `evaluating` - Advisory is currently under evaluation. The affected devices would be analyzed but no advisory instances wouldbe created. The results of the analysis would be made available to Intersight engineering for evaluation and validation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TamAdvisoryDefinition.StateEnum State
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
        /// <para type="description">"The type (field notice, security advisory, end-of-life milestone advisory etc.) of Intersight advisory.\n* `securityAdvisory` - Respresents the psirt alert type (https://tools.cisco.com/security/center/publicationListing.x).\n* `fieldNotice` - Respresents the field notice alert type (https://www.cisco.com/c/en/us/support/web/tsd-products-field-notice-summary.html).\n* `eolAdvisory` - Represents product End of Life (EOL) type (https://www.cisco.com/c/en/us/products/eos-eol-policy.html)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TamAdvisoryDefinition.TypeEnum Type
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Cisco assigned advisory/field-notice/end-of-life version after latest revision."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Workarounds available for the advisory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Workaround
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.TamAdvisoryDefinition initObject = new Intersight.Model.TamAdvisoryDefinition();
            if (this.MyInvocation.BoundParameters.ContainsKey("Actions"))
            {
                initObject.Actions = this.Actions;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdvisoryDetails"))
            {
                initObject.AdvisoryDetails = this.AdvisoryDetails;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdvisoryId"))
            {
                initObject.AdvisoryId = this.AdvisoryId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ApiDataSources"))
            {
                initObject.ApiDataSources = this.ApiDataSources;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DatePublished"))
            {
                initObject.DatePublished = this.DatePublished;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DateUpdated"))
            {
                initObject.DateUpdated = this.DateUpdated;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ExecuteOnPod"))
            {
                initObject.ExecuteOnPod = this.ExecuteOnPod;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ExternalUrl"))
            {
                initObject.ExternalUrl = this.ExternalUrl;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("OtherRefUrls"))
            {
                initObject.OtherRefUrls = this.OtherRefUrls;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Recommendation"))
            {
                initObject.Recommendation = this.Recommendation;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("S3DataSources"))
            {
                initObject.S3DataSources = this.S3DataSources;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Severity"))
            {
                initObject.Severity = this.Severity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("State"))
            {
                initObject.State = this.State;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Type"))
            {
                initObject.Type = this.Type;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Workaround"))
            {
                initObject.Workaround = this.Workaround;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize TamAdvisoryInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightTamAdvisoryInfo")]
    public class InitializeIntersightTamAdvisoryInfo : PSCmdlet
    {
        public InitializeIntersightTamAdvisoryInfo()
        {
            ClassId = TamAdvisoryInfo.ClassIdEnum.TamAdvisoryInfo;
            ObjectType = TamAdvisoryInfo.ObjectTypeEnum.TamAdvisoryInfo;
            State = TamAdvisoryInfo.StateEnum.Active;

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
        /// <para type="description">"A reference to a tamBaseAdvisory resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.TamBaseAdvisoryRelationship Advisory
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TamAdvisoryInfo.ClassIdEnum ClassId
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

        public TamAdvisoryInfo.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Current state of the advisory for the owner. Indicates if the user is interested in getting updates for the advisory.\n* `active` - Advisory is currently active and the user wants to receive updates for this advisory.\n* `acknowledged` - Advisory is seen and acknowledged by the user and she no longer wants to recieve updates."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TamAdvisoryInfo.StateEnum State
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
            Intersight.Model.TamAdvisoryInfo initObject = new Intersight.Model.TamAdvisoryInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Advisory"))
            {
                initObject.Advisory = this.Advisory;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("State"))
            {
                initObject.State = this.State;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize TamAdvisoryInstance.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightTamAdvisoryInstance")]
    public class InitializeIntersightTamAdvisoryInstance : PSCmdlet
    {
        public InitializeIntersightTamAdvisoryInstance()
        {
            ClassId = TamAdvisoryInstance.ClassIdEnum.TamAdvisoryInstance;
            ObjectType = TamAdvisoryInstance.ObjectTypeEnum.TamAdvisoryInstance;
            State = TamAdvisoryInstance.StateEnum.Unknown;

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
        /// <para type="description">"A reference to a tamBaseAdvisory resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.TamBaseAdvisoryRelationship Advisory
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.MoBaseMoRelationship AffectedObject
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Moid of the Intersight MO affected by the alert. Deprecated now and will be removed in subsequent releases."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string AffectedObjectMoid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Object type of the Intersight MO affected by the alert. Deprecated now and will be removed in subsequent releases."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string AffectedObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TamAdvisoryInstance.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetDeviceRegistrationRelationship DeviceRegistration
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

        public TamAdvisoryInstance.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Current state of the advisory instance (Active/Cleared/Unknown etc.).\n* `unknown` - Intersight is unable to determine if the Advisory instance is applicable for the affected managed object.\n* `active` - Advisory instance is currently active and applicable for the affected managed object.\n* `cleared` - Advisory instance is no longer applicable for the affected managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TamAdvisoryInstance.StateEnum State
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
            Intersight.Model.TamAdvisoryInstance initObject = new Intersight.Model.TamAdvisoryInstance();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Advisory"))
            {
                initObject.Advisory = this.Advisory;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AffectedObject"))
            {
                initObject.AffectedObject = this.AffectedObject;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AffectedObjectMoid"))
            {
                initObject.AffectedObjectMoid = this.AffectedObjectMoid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AffectedObjectType"))
            {
                initObject.AffectedObjectType = this.AffectedObjectType;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DeviceRegistration"))
            {
                initObject.DeviceRegistration = this.DeviceRegistration;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("State"))
            {
                initObject.State = this.State;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize TamApiDataSource.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightTamApiDataSource")]
    public class InitializeIntersightTamApiDataSource : PSCmdlet
    {
        public InitializeIntersightTamApiDataSource()
        {
            ClassId = TamApiDataSource.ClassIdEnum.TamApiDataSource;
            ObjectType = TamApiDataSource.ObjectTypeEnum.TamApiDataSource;
            Type = TamApiDataSource.TypeEnum.IntersightApi;

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

        public TamApiDataSource.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of Intersight managed object used as data source."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string MoType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name is used to unique identify and refer a given data source in an alert definition."</para>
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

        public TamApiDataSource.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.TamQueryEntry> Queries
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of data source (for e.g. TextFsmTempalate based, Intersight API based etc.).\n* `intersightApi` - Collector type for this data collection is Intersight APIs.\n* `nxos` - Collector type for this data collection is NXOS.\n* `s3File` - Collector type for this data collection is a file in a cloud hosted object storage bucket."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TamApiDataSource.TypeEnum Type
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.TamApiDataSource initObject = new Intersight.Model.TamApiDataSource();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("MoType"))
            {
                initObject.MoType = this.MoType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Queries"))
            {
                initObject.Queries = this.Queries;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Type"))
            {
                initObject.Type = this.Type;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize TamBaseAdvisoryDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightTamBaseAdvisoryDetails")]
    public class InitializeIntersightTamBaseAdvisoryDetails : PSCmdlet
    {
        public InitializeIntersightTamBaseAdvisoryDetails()
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

        public TamBaseAdvisoryDetails.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Brief description of details specified for an advisory type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TamBaseAdvisoryDetails.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.TamBaseAdvisoryDetails initObject = new Intersight.Model.TamBaseAdvisoryDetails();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize TamEolAdvisoryDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightTamEolAdvisoryDetails")]
    public class InitializeIntersightTamEolAdvisoryDetails : PSCmdlet
    {
        public InitializeIntersightTamEolAdvisoryDetails()
        {
            ClassId = TamEolAdvisoryDetails.ClassIdEnum.TamEolAdvisoryDetails;
            ObjectType = TamEolAdvisoryDetails.ObjectTypeEnum.TamEolAdvisoryDetails;

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

        public List<Model.TamMilestone> AllMilestones
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TamEolAdvisoryDetails.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Brief description of details specified for an advisory type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A end-of-life advisory milestone as defined in Cisco end-of-life (EOL) policy (https://www.cisco.com/c/en/us/products/eos-eol-policy.html)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.TamMilestone Milestone
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TamEolAdvisoryDetails.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the impacted release this advisory milestone intends to address, e.g. \"3.5 (2x)\"."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Release
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.TamEolAdvisoryDetails initObject = new Intersight.Model.TamEolAdvisoryDetails();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AllMilestones"))
            {
                initObject.AllMilestones = this.AllMilestones;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Milestone"))
            {
                initObject.Milestone = this.Milestone;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Release"))
            {
                initObject.Release = this.Release;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize TamEolSeverity.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightTamEolSeverity")]
    public class InitializeIntersightTamEolSeverity : PSCmdlet
    {
        public InitializeIntersightTamEolSeverity()
        {
            ClassId = TamEolSeverity.ClassIdEnum.TamEolSeverity;
            Level = TamEolSeverity.LevelEnum.Info;
            ObjectType = TamEolSeverity.ObjectTypeEnum.TamEolSeverity;

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

        public TamEolSeverity.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Severity level associated with an end-of-life (EOL) milestone advisory.\n* `info` - The end-of-life (EOL) milestone is at info level.\n* `critical` - The end-of-life (EOL) milestone is at critical level. It usually hints 'red' in a color-map.\n* `high` - The end-of-life (EOL) milestone is at high level.\n* `medium` - The end-of-life (EOL) milestone is at medium level."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TamEolSeverity.LevelEnum Level
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TamEolSeverity.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.TamEolSeverity initObject = new Intersight.Model.TamEolSeverity();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Level"))
            {
                initObject.Level = this.Level;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize TamIdentifiers.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightTamIdentifiers")]
    public class InitializeIntersightTamIdentifiers : PSCmdlet
    {
        public InitializeIntersightTamIdentifiers()
        {
            ClassId = TamIdentifiers.ClassIdEnum.TamIdentifiers;
            ObjectType = TamIdentifiers.ObjectTypeEnum.TamIdentifiers;

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

        public TamIdentifiers.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the filter paramter."</para>
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

        public TamIdentifiers.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Value of the filter paramter."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Value
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.TamIdentifiers initObject = new Intersight.Model.TamIdentifiers();
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
    /// <para type="synopsis">This is the cmdlet to Initialize TamMilestone.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightTamMilestone")]
    public class InitializeIntersightTamMilestone : PSCmdlet
    {
        public InitializeIntersightTamMilestone()
        {
            ClassId = TamMilestone.ClassIdEnum.TamMilestone;
            LabelHint = TamMilestone.LabelHintEnum.Upcoming;
            MilestoneType = TamMilestone.MilestoneTypeEnum.Unknown;
            ObjectType = TamMilestone.ObjectTypeEnum.TamMilestone;

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

        public TamMilestone.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Date when the specified end-of-life milestone advisory is reached."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime Date
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A description of the milestone defined by an end-of-life advisory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of days (exclusive) relative to the milestone date when the milestone is considered to be not in effect. A nagative number indicates number of days ahead of the milestone date. The default is 2147483647 (0x7FFFFFFF) which means the milestone date range's upper bound is omitted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public int EndOffset
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Extra hint to the type of label to be used in display in addition to severity and effective date. How to use it is at UI's descretion.\n* `upcoming` - This end-of-life (EOL) milestone is upcoming. The label may be changed to more urgent type such as 'imminent' as time progress approaching effective date.\n* `imminent` - This end-of-life (EOL) milestone is imminent. There will be no label change before the effective date.\n* `past` - This end-of-life (EOL) milestone has past the effective date.\n* `info` - This end-of-life (EOL) milestone for informative purpose."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TamMilestone.LabelHintEnum LabelHint
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Milestone type as defined in Cisco end-of-life (EOL) policy (https://www.cisco.com/c/en/us/products/eos-eol-policy.html) when the specified end-of-life milestone advisory is reached.\n* `unknown` - The type of end-of-life milestone is not defined.\n* `endOfSoftwareMaintenanceDate` - The last date that Cisco Engineering may release any final software maintenance releases or bug fixes. After this date, Cisco Engineering may no longer develop, repair, maintain, or test the product software and only critical security updates will be provided on this release train. \n* `lastDateOfSupport` - The last date to receive service and support for the software. After this date, all support services for the software are unavailable, and the software becomes obsolete. \n* `endOfLifeAnnouncementDate` - The date the document that announces the end-of-sale and end-of-life of a product is distributed to the general public."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TamMilestone.MilestoneTypeEnum MilestoneType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A milestone defined by an end-of-life advisory."</para>
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

        public TamMilestone.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of days (inclusive) relative to the milestone date when the milestone is considered to be in effect. A nagative number indicates number of days ahead of the milestone date. The default is 0 which means the milestone take effect exactly on the same date as the specified milestone date. A negative value of -2147483648 (0x80000000) indicates the milestone date range's lower bound is omitted."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public int StartOffset
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.TamMilestone initObject = new Intersight.Model.TamMilestone();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Date"))
            {
                initObject.Date = this.Date;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndOffset"))
            {
                initObject.EndOffset = this.EndOffset;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LabelHint"))
            {
                initObject.LabelHint = this.LabelHint;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MilestoneType"))
            {
                initObject.MilestoneType = this.MilestoneType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("StartOffset"))
            {
                initObject.StartOffset = this.StartOffset;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize TamPsirtSeverity.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightTamPsirtSeverity")]
    public class InitializeIntersightTamPsirtSeverity : PSCmdlet
    {
        public InitializeIntersightTamPsirtSeverity()
        {
            ClassId = TamPsirtSeverity.ClassIdEnum.TamPsirtSeverity;
            Level = TamPsirtSeverity.LevelEnum.Critical;
            ObjectType = TamPsirtSeverity.ObjectTypeEnum.TamPsirtSeverity;

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

        public TamPsirtSeverity.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Severity level associated with the security advisory.\n* `critical` - < If applicable, it may expose users to critical failures and it needs to be addressed immediately. For e.g. a PSIRT advisory with a corresponding CVSS score of above 9.0.\n* `high` - < If applicable, it may expose the users to critical failure and it needs to be addressed immediately. For e.g. a PSIRT advisory with a corresponding CVSS score between 7.0-8.9. These may be the vulnerabilities that are more difficult to exploit than the ones deemed critical but once exploited, the will cause critical failures.\n* `medium` - < If applicable, it may expose the users to failure of certain functions. for e.g. a PSIRT advisory with a corresponding CVSS score between 4.0-6.9. These may be the vulnerabilities that are mitigated to a large extent but that may still be exploited in certain restricted cases.\n* `info` - < If applicable, it may have some minimal impact for certain functions in the user environment. For e.g. a PSIRT advisory with a corresponding CVSS score below 4.0."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TamPsirtSeverity.LevelEnum Level
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TamPsirtSeverity.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.TamPsirtSeverity initObject = new Intersight.Model.TamPsirtSeverity();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Level"))
            {
                initObject.Level = this.Level;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize TamQueryEntry.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightTamQueryEntry")]
    public class InitializeIntersightTamQueryEntry : PSCmdlet
    {
        public InitializeIntersightTamQueryEntry()
        {
            ClassId = TamQueryEntry.ClassIdEnum.TamQueryEntry;
            ObjectType = TamQueryEntry.ObjectTypeEnum.TamQueryEntry;

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

        public TamQueryEntry.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name is used to unique identify and result of the given query which can be used by subsequent queries as input data source."</para>
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

        public TamQueryEntry.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An integer value depicting the priority of the query among the queries that are part of the same QueryEntry collection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Priority
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A SparkSQL query to be used on a given data source."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Query
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.TamQueryEntry initObject = new Intersight.Model.TamQueryEntry();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Priority"))
            {
                initObject.Priority = this.Priority;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Query"))
            {
                initObject.Query = this.Query;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize TamS3DataSource.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightTamS3DataSource")]
    public class InitializeIntersightTamS3DataSource : PSCmdlet
    {
        public InitializeIntersightTamS3DataSource()
        {
            ClassId = TamS3DataSource.ClassIdEnum.TamS3DataSource;
            ObjectType = TamS3DataSource.ObjectTypeEnum.TamS3DataSource;
            Type = TamS3DataSource.TypeEnum.IntersightApi;

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

        public TamS3DataSource.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name is used to unique identify and refer a given data source in an alert definition."</para>
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

        public TamS3DataSource.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.TamQueryEntry> Queries
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Path used to access file in s3 containing data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string S3Path
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of data source (for e.g. TextFsmTempalate based, Intersight API based etc.).\n* `intersightApi` - Collector type for this data collection is Intersight APIs.\n* `nxos` - Collector type for this data collection is NXOS.\n* `s3File` - Collector type for this data collection is a file in a cloud hosted object storage bucket."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TamS3DataSource.TypeEnum Type
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.TamS3DataSource initObject = new Intersight.Model.TamS3DataSource();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Queries"))
            {
                initObject.Queries = this.Queries;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("S3Path"))
            {
                initObject.S3Path = this.S3Path;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Type"))
            {
                initObject.Type = this.Type;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize TamSecurityAdvisory.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightTamSecurityAdvisory")]
    public class InitializeIntersightTamSecurityAdvisory : PSCmdlet
    {
        public InitializeIntersightTamSecurityAdvisory()
        {
            ClassId = TamSecurityAdvisory.ClassIdEnum.TamSecurityAdvisory;
            ExecuteOnPod = TamSecurityAdvisory.ExecuteOnPodEnum.Tier1;
            ObjectType = TamSecurityAdvisory.ObjectTypeEnum.TamSecurityAdvisory;
            State = TamSecurityAdvisory.StateEnum.Ready;
            Status = TamSecurityAdvisory.StatusEnum.Interim;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.TamAction> Actions
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
        /// <para type="description">"Cisco generated identifier for the published security advisory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string AdvisoryId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.TamApiDataSource> ApiDataSources
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"CVSS version 3 base score for the security Advisory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public float BaseScore
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TamSecurityAdvisory.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> CveIds
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Date when the security advisory was first published by Cisco."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime DatePublished
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Date when the security advisory was last updated by Cisco."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime DateUpdated
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Brief description of the advisory details."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"CVSS version 3 environmental score for the security Advisory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public float EnvironmentalScore
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Orion pod on which this advisory should process.\n* `tier1` - Advisory processing will be taken care in first advisory driver of multinode cluster.\n* `tier2` - Advisory processing will be taken care in second advisory driver of multinode cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TamSecurityAdvisory.ExecuteOnPodEnum ExecuteOnPod
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A link to an external URL describing security Advisory in more details."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^(?:http(s)?:\\/\\/)?[\\w.-]+(?:\\.[\\w\\.-]+)+[\\w\\-\\._~:/?#[\\]@!\\$&'\\(\\)\\*\\+,;=.]+$")]
        public string ExternalUrl
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
        /// <para type="description">"A user defined name for the Intersight Advisory."</para>
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

        public TamSecurityAdvisory.ObjectTypeEnum ObjectType
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

        public List<string> OtherRefUrls
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Recommended action to resolve the security advisory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Recommendation
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Severity level of the Intersight Advisory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.TamSeverity Severity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Current state of the advisory.\n* `ready` - Advisory has been evaluated. The affected devices would be analyzed and corresponding advisory instances would be created.\n* `evaluating` - Advisory is currently under evaluation. The affected devices would be analyzed but no advisory instances wouldbe created. The results of the analysis would be made available to Intersight engineering for evaluation and validation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TamSecurityAdvisory.StateEnum State
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Cisco assigned status of the published advisory based on whether the investigation is complete or on-going.\n* `interim` - The Cisco investigation for the advisory is ongoing. Cisco will issue revisions to the advisory when additional information, including fixed software release data, becomes available.\n* `final` - Cisco has completed its evaluation of the vulnerability described in the advisory. There will be no further updates unless there is a material change in the nature of the vulnerability."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TamSecurityAdvisory.StatusEnum Status
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
        /// <para type="description">"CVSS version 3 temporal score for the security Advisory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public float TemporalScore
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Cisco assigned advisory version after latest revision."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Workarounds available for the advisory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Workaround
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.TamSecurityAdvisory initObject = new Intersight.Model.TamSecurityAdvisory();
            if (this.MyInvocation.BoundParameters.ContainsKey("Actions"))
            {
                initObject.Actions = this.Actions;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdvisoryId"))
            {
                initObject.AdvisoryId = this.AdvisoryId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ApiDataSources"))
            {
                initObject.ApiDataSources = this.ApiDataSources;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BaseScore"))
            {
                initObject.BaseScore = this.BaseScore;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CveIds"))
            {
                initObject.CveIds = this.CveIds;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DatePublished"))
            {
                initObject.DatePublished = this.DatePublished;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DateUpdated"))
            {
                initObject.DateUpdated = this.DateUpdated;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EnvironmentalScore"))
            {
                initObject.EnvironmentalScore = this.EnvironmentalScore;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ExecuteOnPod"))
            {
                initObject.ExecuteOnPod = this.ExecuteOnPod;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ExternalUrl"))
            {
                initObject.ExternalUrl = this.ExternalUrl;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("OtherRefUrls"))
            {
                initObject.OtherRefUrls = this.OtherRefUrls;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Recommendation"))
            {
                initObject.Recommendation = this.Recommendation;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Severity"))
            {
                initObject.Severity = this.Severity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("State"))
            {
                initObject.State = this.State;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Status"))
            {
                initObject.Status = this.Status;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TemporalScore"))
            {
                initObject.TemporalScore = this.TemporalScore;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Workaround"))
            {
                initObject.Workaround = this.Workaround;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize TamSecurityAdvisoryDetails.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightTamSecurityAdvisoryDetails")]
    public class InitializeIntersightTamSecurityAdvisoryDetails : PSCmdlet
    {
        public InitializeIntersightTamSecurityAdvisoryDetails()
        {
            ClassId = TamSecurityAdvisoryDetails.ClassIdEnum.TamSecurityAdvisoryDetails;
            ObjectType = TamSecurityAdvisoryDetails.ObjectTypeEnum.TamSecurityAdvisoryDetails;
            Status = TamSecurityAdvisoryDetails.StatusEnum.Interim;

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
        /// <para type="description">"CVSS version 3 base score for the security Advisory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public float BaseScore
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TamSecurityAdvisoryDetails.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> CveIds
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Brief description of details specified for an advisory type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"CVSS version 3 environmental score for the security Advisory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public float EnvironmentalScore
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TamSecurityAdvisoryDetails.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Cisco assigned status of the published advisory. Depends on whether the investigation is complete or on-going.\n* `interim` - The Cisco investigation for the advisory is ongoing. Cisco will issue revisions to the advisory when additional information, including fixed software release data, becomes available.\n* `final` - Cisco has completed its evaluation of the vulnerability described in the advisory. There will be no further updates unless there is a material change in the nature of the vulnerability."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TamSecurityAdvisoryDetails.StatusEnum Status
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"CVSS version 3 temporal score for the security Advisory."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public float TemporalScore
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.TamSecurityAdvisoryDetails initObject = new Intersight.Model.TamSecurityAdvisoryDetails();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("BaseScore"))
            {
                initObject.BaseScore = this.BaseScore;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CveIds"))
            {
                initObject.CveIds = this.CveIds;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EnvironmentalScore"))
            {
                initObject.EnvironmentalScore = this.EnvironmentalScore;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Status"))
            {
                initObject.Status = this.Status;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TemporalScore"))
            {
                initObject.TemporalScore = this.TemporalScore;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize TamSeverity.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightTamSeverity")]
    public class InitializeIntersightTamSeverity : PSCmdlet
    {
        public InitializeIntersightTamSeverity()
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

        public TamSeverity.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TamSeverity.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.TamSeverity initObject = new Intersight.Model.TamSeverity();
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
    /// <para type="synopsis">This is the cmdlet to Initialize TamTextFsmTemplateDataSource.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightTamTextFsmTemplateDataSource")]
    public class InitializeIntersightTamTextFsmTemplateDataSource : PSCmdlet
    {
        public InitializeIntersightTamTextFsmTemplateDataSource()
        {
            ClassId = TamTextFsmTemplateDataSource.ClassIdEnum.TamTextFsmTemplateDataSource;
            ObjectType = TamTextFsmTemplateDataSource.ObjectTypeEnum.TamTextFsmTemplateDataSource;
            Type = TamTextFsmTemplateDataSource.TypeEnum.IntersightApi;

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

        public TamTextFsmTemplateDataSource.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Command used to gather data needed to evaluate field notice applicability."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Cmd
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name is used to unique identify and refer a given data source in an alert definition."</para>
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

        public TamTextFsmTemplateDataSource.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of data source (for e.g. TextFsmTempalate based, Intersight API based etc.).\n* `intersightApi` - Collector type for this data collection is Intersight APIs.\n* `nxos` - Collector type for this data collection is NXOS.\n* `s3File` - Collector type for this data collection is a file in a cloud hosted object storage bucket."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public TamTextFsmTemplateDataSource.TypeEnum Type
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.TamTextFsmTemplateDataSource initObject = new Intersight.Model.TamTextFsmTemplateDataSource();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Cmd"))
            {
                initObject.Cmd = this.Cmd;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Type"))
            {
                initObject.Type = this.Type;
            }
            WriteObject(initObject);
        }

    }
}