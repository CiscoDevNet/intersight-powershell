using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get WorkflowBatchApiExecutor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightWorkflowBatchApiExecutor", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightWorkflowBatchApiExecutor:GetCmdletBase
	{
		public GetIntersightWorkflowBatchApiExecutor()
		{
			ApiInstance = new Intersight.Api.WorkflowApi(Config);
            MethodName = "GetWorkflowBatchApiExecutorListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New WorkflowBatchApiExecutor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightWorkflowBatchApiExecutor")]
    public class NewIntersightWorkflowBatchApiExecutor:NewCmdletBase
	{
		public NewIntersightWorkflowBatchApiExecutor()
		{
			ApiInstance = new Intersight.Api.WorkflowApi(Config);
            ModelObject = new WorkflowBatchApiExecutor();
            MethodName = "CreateWorkflowBatchApiExecutorWithHttpInfo";
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Intersight.Model.WorkflowApi> Batch {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enter the constraints on when this task should match against the task definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowTaskConstraints Constraints {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A detailed description about the batch APIs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a workflowErrorResponseHandler resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowErrorResponseHandlerRelationship ErrorResponseHandler {
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
        /// <para type="description">"Name for the batch API task."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"All the possible outcomes of this task are captured here. Outcomes property\nis a collection property of type workflow.Outcome objects.\nThe outcomes can be mapped to the message to be shown. The outcomes are\nevaluated in the order they are given. At the end of the outcomes list,\nan catchall success/fail outcome can be added with condition as 'true'.\nThis is an optional\nproperty and if not specified the task will be marked as success."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object Outcomes {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Intersight Orchestrator allows the extraction of required values from API\nresponses using the API response grammar. These extracted values can be mapped\nto task output parameters defined in task definition.\nThe mapping of API output parameters to the task output parameters is provided\nas JSON in this property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object Output {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When an execution of a nth API in the Batch fails,\nRetry from falied API flag indicates if the execution should start from the nth API or the first API during task retry.\nBy default the value is set to false."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool RetryFromFailedApi {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The skip expression, if provided, allows the batch API executor to skip the\ntask execution when the given expression evaluates to true.\nThe expression is given as such a golang template that has to be\nevaluated to a final content true/false. The expression is an optional and in\ncase not provided, the API will always be executed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SkipOnCondition {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a workflowTaskDefinition resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowTaskDefinitionRelationship TaskDefinition {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get WorkflowCatalog.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightWorkflowCatalog", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightWorkflowCatalog:GetCmdletBase
	{
		public GetIntersightWorkflowCatalog()
		{
			ApiInstance = new Intersight.Api.WorkflowApi(Config);
            MethodName = "GetWorkflowCatalogListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get WorkflowBuildTaskMetaOwner.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightWorkflowBuildTaskMetaOwner", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightWorkflowBuildTaskMetaOwner:GetCmdletBase
	{
		public GetIntersightWorkflowBuildTaskMetaOwner()
		{
			ApiInstance = new Intersight.Api.WorkflowApi(Config);
            MethodName = "GetWorkflowBuildTaskMetaOwnerListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get WorkflowWorkflowInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightWorkflowWorkflowInfo", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightWorkflowWorkflowInfo:GetCmdletBase
	{
		public GetIntersightWorkflowWorkflowInfo()
		{
			ApiInstance = new Intersight.Api.WorkflowApi(Config);
            MethodName = "GetWorkflowWorkflowInfoListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New WorkflowWorkflowInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightWorkflowWorkflowInfo")]
    public class NewIntersightWorkflowWorkflowInfo:NewCmdletBase
	{
		public NewIntersightWorkflowWorkflowInfo()
		{
			ApiInstance = new Intersight.Api.WorkflowApi(Config);
            ModelObject = new WorkflowWorkflowInfo();
            MethodName = "CreateWorkflowWorkflowInfoWithHttpInfo";
		}
        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamAccountRelationship Account {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The action of the workflow such as start, cancel, retry, pause.\n* `None` - No action is set, this is the default value for action field.\n* `Create` - Create a new instance of the workflow but it does not start the execution of the workflow. Use the Start action to start execution of the workflow.\n* `Start` - Start a new execution of the workflow.\n* `Pause` - Pause the workflow, this can only be issued on workflows that are in running state.\n* `Resume` - Resume the workflow which was previously paused through pause action on the workflow.\n* `Retry` - Retry the workflow that has previously reached a final state and has the retryable property set to true. A running or waiting workflow cannot be retried. If the property retryFromTaskName is also passed along with this action, the workflow will be started from that specific task, otherwise the workflow will be restarted from the first task.  The task name in retryFromTaskName must be one of the tasks that completed or failed in the previous run. It is not possible to retry a workflow from a task which wasn't run in the previous iteration.\n* `RetryFailed` - Retry the workflow that has failed. A running or waiting workflow or a workflow that completed successfully cannot be retried. Only the tasks that failed in the previous run will be retried and the rest of workflow will be run. This action does not restart the workflow and also does not support retrying from a specific task.\n* `Cancel` - Cancel the workflow that is in running or waiting state."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowWorkflowInfo.ActionEnum Action {
            get;
            set;
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
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public MoBaseMoRelationship AssociatedObject {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The duration in hours after which the workflow info for failed, terminated or timed out workflow will be removed from database."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long FailedWorkflowCleanupDuration {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"All the given inputs for the workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object Input {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Denotes if this workflow is internal and should be hidden from user view of running workflows."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Internal {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<WorkflowMessage> Message {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of the workflow metadata for which this workflow execution was started."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MetaVersion {
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
        /// <para type="description">"A name of the workflow execution instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[^:]{1,92}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Denotes the reason workflow is in paused status.\n* `None` - Pause reason is none, which indicates there is no reason for the pause state.\n* `TaskWithWarning` - Pause reason indicates the workflow is in this state due to a task that has a status as completed with warnings.\n* `SystemMaintenance` - Pause reason indicates the workflow is in this state based on actions of system admin for maintenance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowWorkflowInfo.PauseReasonEnum PauseReason {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamPermission resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamPermissionRelationship Permission {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This field is applicable when Retry action is issued for a workflow which is in 'final' state. When this field is not specified, the workflow will be retried from the start i.e., the first task. When this field is specified then the workflow will be retried from the specified task. This field should specify the task name which is the unique name of the task within the workflow. The task name must be one of the tasks that completed or failed in the previous run. It is not possible to retry a workflow from a task which wasn't run in the previous iteration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RetryFromTaskName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The duration in hours after which the workflow info for successful workflow will be removed from database."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long SuccessWorkflowCleanupDuration {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Denotes the reason workflow is in waiting status.\n* `None` - Wait reason is none, which indicates there is no reason for the waiting state.\n* `GatherTasks` - Wait reason is gathering tasks, which indicates the workflow is in this state in order to gather tasks.\n* `Duplicate` - Wait reason is duplicate, which indicates the workflow is a duplicate of current running workflow.\n* `RateLimit` - Wait reason is rate limit, which indicates the workflow is rate limited by account/instance level throttling threshold.\n* `WaitTask` - Wait reason when there are one or more wait tasks in the workflow which are yet to receive a task status update.\n* `PendingRetryFailed` - Wait reason when the workflow is pending a RetryFailed action.\n* `WaitingToStart` - Workflow is waiting to start on workflow engine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowWorkflowInfo.WaitReasonEnum WaitReason {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The workflow context which contains initiator and target information."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowWorkflowCtx WorkflowCtx {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a workflowWorkflowDefinition resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowWorkflowDefinitionRelationship WorkflowDefinition {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of workflow meta. Derived from the workflow meta that is used to launch this workflow instance.\n* `SystemDefined` - System defined workflow definition.\n* `UserDefined` - User defined workflow definition.\n* `Dynamic` - Dynamically defined workflow definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowWorkflowInfo.WorkflowMetaTypeEnum WorkflowMetaType {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set WorkflowTaskInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightWorkflowTaskInfo")]
    public class SetIntersightWorkflowTaskInfo:SetCmdletBase
	{
		public SetIntersightWorkflowTaskInfo()
		{
			ApiInstance = new Intersight.Api.WorkflowApi(Config);
            ModelObject = new WorkflowTaskInfo();
            MethodName = "UpdateWorkflowTaskInfoWithHttpInfo";
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<WorkflowMessage> Message {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The status of the task and this will specify if the task is running or has reached a final state."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Status {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a workflowTaskDefinition resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowTaskDefinitionRelationship TaskDefinition {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<WorkflowTaskRetryInfo> TaskInstIdList {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get WorkflowCustomDataTypeDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightWorkflowCustomDataTypeDefinition", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightWorkflowCustomDataTypeDefinition:GetCmdletBase
	{
		public GetIntersightWorkflowCustomDataTypeDefinition()
		{
			ApiInstance = new Intersight.Api.WorkflowApi(Config);
            MethodName = "GetWorkflowCustomDataTypeDefinitionListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New WorkflowCustomDataTypeDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightWorkflowCustomDataTypeDefinition")]
    public class NewIntersightWorkflowCustomDataTypeDefinition:NewCmdletBase
	{
		public NewIntersightWorkflowCustomDataTypeDefinition()
		{
			ApiInstance = new Intersight.Api.WorkflowApi(Config);
            ModelObject = new WorkflowCustomDataTypeDefinition();
            MethodName = "CreateWorkflowCustomDataTypeDefinitionWithHttpInfo";
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
        /// <para type="description">"A reference to a workflowCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowCatalogRelationship Catalog {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When true this data type definition is a collection of type definitions to represent composite data like JSON."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool CompositeType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A human-friendly description of this custom data type indicating it's domain and usage."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user friendly short name to identify the custom data type definition. Label can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.), colon (:), space ( ), single quote ('), or an underscore (_)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+[\\sa-zA-Z0-9_'.:-]{1,92}$")]
        public string Label {
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
        /// <para type="description">"The name of custom data type definition. The valid name can contain lower case and upper case alphabetic characters, digits and special characters '-' and '_'."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<WorkflowParameterSet> ParameterSet {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type to capture all the properties for the custom data type definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowCustomDataTypeProperties Properties {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<WorkflowBaseDataType> TypeDefinition {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get WorkflowTaskDebugLog.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightWorkflowTaskDebugLog", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightWorkflowTaskDebugLog:GetCmdletBase
	{
		public GetIntersightWorkflowTaskDebugLog()
		{
			ApiInstance = new Intersight.Api.WorkflowApi(Config);
            MethodName = "GetWorkflowTaskDebugLogListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set WorkflowTaskDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightWorkflowTaskDefinition")]
    public class SetIntersightWorkflowTaskDefinition:SetCmdletBase
	{
		public SetIntersightWorkflowTaskDefinition()
		{
			ApiInstance = new Intersight.Api.WorkflowApi(Config);
            ModelObject = new WorkflowTaskDefinition();
            MethodName = "PatchWorkflowTaskDefinitionWithHttpInfo";
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
        /// <para type="description">"A reference to a workflowCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowCatalogRelationship Catalog {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When true this will be the task version that is used when a specific task definition version is not specified. The very first task definition created with a name will be set as the default version, after that user can explicitly set any version of the task definition as the default version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool DefaultVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user friendly description about task on what operations are done as part of the task execution and any other specific information about task input and output."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to workflowTaskDefinition resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<WorkflowTaskDefinitionRelationship> ImplementedTasks {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a workflowTaskDefinition resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowTaskDefinitionRelationship InterfaceTask {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user friendly short name to identify the task definition. Label can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.), colon (:), space ( ), single quote ('), forward slash (/), or an underscore (_)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+[\\sa-zA-Z0-9_'./:-]{1,92}$")]
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the task definition. The name should follow this convention <Verb or Action><Category><Vendor><Product><Noun or object> Verb or Action is a required portion of the name and this must be part of the pre-approved verb list. Category is an optional field and this will refer to the broad category of the task referring to the type of resource or endpoint. If there is no specific category then use \"Generic\" if required. Vendor is an optional field and this will refer to the specific vendor this task applies to. If the task is generic and not tied to a vendor, then do not specify anything. Product is an optional field, this will contain the vendor product and model when desired. Noun or object is a required field and  this will contain the noun or object on which the action is being performed. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.), colon (:), or an underscore (_). Examples SendEmail  - This is a task in Generic category for sending email. NewStorageVolume - This is a vendor agnostic task under Storage device category for creating a new volume."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type to capture all the properties for the task definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowProperties Properties {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<WorkflowRollbackTask> RollbackTasks {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If set to true, the task requires access to secure properties and uses an encryption token associated with a workflow moid to encrypt or decrypt the secure properties."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool SecurePropAccess {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a workflowTaskMetadata resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowTaskMetadataRelationship TaskMetadata {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The version of the task definition so we can support multiple versions of a task definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove WorkflowTaskDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightWorkflowTaskDefinition")]
    public class RemoveIntersightWorkflowTaskDefinition:RemoveCmdletBase
	{
		public RemoveIntersightWorkflowTaskDefinition()
		{
			ApiInstance = new Intersight.Api.WorkflowApi(Config);
            MethodName = "DeleteWorkflowTaskDefinitionWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set WorkflowErrorResponseHandler.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightWorkflowErrorResponseHandler")]
    public class SetIntersightWorkflowErrorResponseHandler:SetCmdletBase
	{
		public SetIntersightWorkflowErrorResponseHandler()
		{
			ApiInstance = new Intersight.Api.WorkflowApi(Config);
            ModelObject = new WorkflowErrorResponseHandler();
            MethodName = "UpdateWorkflowErrorResponseHandlerWithHttpInfo";
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
        /// <para type="description">"A reference to a workflowCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowCatalogRelationship Catalog {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A detailed description about the error response handler."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name for the error response handler."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<ContentParameter> Parameters {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The platform type for which the error response handler is defined.\n* `` - The device reported an empty or unrecognized platform type.\n* `APIC` - An Application Policy Infrastructure Controller cluster.\n* `DCNM` - A Data Center Network Manager instance. Data Center Network Manager (DCNM) is the network management platform for all NX-OS-enabled deployments, spanning new fabric architectures, IP Fabric for Media, and storage networking deployments for the Cisco Nexus-powered data center.\n* `UCSFI` - A UCS Fabric Interconnect in HA or standalone mode, which is being managed by UCS Manager (UCSM).\n* `UCSFIISM` - A UCS Fabric Interconnect in HA or standalone mode, managed directly by Intersight.\n* `IMC` - A standalone UCS Server Integrated Management Controller.\n* `IMCM4` - A standalone UCS M4 Server.\n* `IMCM5` - A standalone UCS M5 server.\n* `IMCRack` - A standalone UCS M6 and above server.\n* `UCSIOM` - An UCS Chassis IO module.\n* `HX` - A HyperFlex storage controller.\n* `HyperFlexAP` - A HyperFlex Application Platform.\n* `UCSD` - A UCS Director virtual appliance. Cisco UCS Director automates, orchestrates, and manages Cisco and third-party hardware.\n* `IntersightAppliance` - A Cisco Intersight Connected Virtual Appliance.\n* `IntersightAssist` - A Cisco Intersight Assist.\n* `PureStorageFlashArray` - A Pure Storage FlashArray device.\n* `UCSC890` - A standalone Cisco UCSC890 server.\n* `NetAppOntap` - A NetApp ONTAP storage system.\n* `NetAppActiveIqUnifiedManager` - A NetApp Active IQ Unified Manager.\n* `EmcScaleIo` - An EMC ScaleIO storage system.\n* `EmcVmax` - An EMC VMAX storage system.\n* `EmcVplex` - An EMC VPLEX storage system.\n* `EmcXtremIo` - An EMC XtremIO storage system.\n* `VmwareVcenter` - A VMware vCenter device that manages Virtual Machines.\n* `MicrosoftHyperV` - A Microsoft Hyper-V system that manages Virtual Machines.\n* `AppDynamics` - An AppDynamics controller that monitors applications.\n* `Dynatrace` - A software-intelligence monitoring platform that simplifies enterprise cloud complexity and accelerates digital transformation.\n* `ReadHatOpenStack` - An OpenStack target manages Virtual Machines, Physical Machines, Datacenters and Virtual Datacenters using different OpenStack services as administrative endpoints.\n* `CloudFoundry` - An open source cloud platform on which developers can build, deploy, run and scale applications.\n* `MicrosoftAzureApplicationInsights` - A feature of Azure Monitor, is an extensible Application Performance Management service for developers and DevOps professionals to monitor their live applications.\n* `OpenStack` - An OpenStack target manages Virtual Machines, Physical Machines, Datacenters and Virtual Datacenters using different OpenStack services as administrative endpoints.\n* `MicrosoftSqlServer` - A Microsoft SQL database server.\n* `Kubernetes` - A Kubernetes cluster that runs containerized applications.\n* `AmazonWebService` - A Amazon web service target that discovers and monitors different services like EC2. It discovers entities like VMs, Volumes, regions etc. and monitors attributes like Mem, CPU, cost.\n* `AmazonWebServiceBilling` - A Amazon web service billing target to retrieve billing information stored in S3 bucket.\n* `MicrosoftAzureServicePrincipal` - A Microsoft Azure Service Principal target that discovers all the associated Azure subscriptions.\n* `MicrosoftAzureEnterpriseAgreement` - A Microsoft Azure Enterprise Agreement target that discovers cost, billing and RIs.\n* `DellCompellent` - A Dell Compellent storage system.\n* `HPE3Par` - A HPE 3PAR storage system.\n* `RedHatEnterpriseVirtualization` - A Red Hat Enterprise Virtualization Hypervisor system that manages Virtual Machines.\n* `NutanixAcropolis` - A Nutanix Acropolis system that combines servers and storage into a distributed infrastructure platform.\n* `HPEOneView` - A HPE Oneview management system that manages compute, storage, and networking.\n* `ServiceEngine` - Cisco Application Services Engine. Cisco Application Services Engine is a platform to deploy and manage applications.\n* `HitachiVirtualStoragePlatform` - A Hitachi Virtual Storage Platform also referred to as Hitachi VSP. It includes various storage systems designed for data centers.\n* `IMCBlade` - An Intersight managed UCS Blade Server.\n* `TerraformCloud` - A Terraform Cloud account.\n* `TerraformAgent` - A Terraform Cloud Agent that Intersight will deploy in datacenter. The agent will execute Terraform plan for Terraform Cloud workspace configured to use the agent.\n* `CustomTarget` - An external endpoint added as Target that can be accessed through its HTTP API interface in Intersight Orchestrator automation workflow.Standard HTTP authentication scheme supported: Basic.\n* `HTTPEndpoint` - An external endpoint added as Target that can be accessed through its HTTP API interface in Intersight Orchestrator automation workflow.Standard HTTP authentication scheme supported: Basic.\n* `CiscoCatalyst` - A Cisco Catalyst networking switch device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowErrorResponseHandler.PlatformTypeEnum PlatformType {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<ContentComplexType> Types {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove WorkflowErrorResponseHandler.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightWorkflowErrorResponseHandler")]
    public class RemoveIntersightWorkflowErrorResponseHandler:RemoveCmdletBase
	{
		public RemoveIntersightWorkflowErrorResponseHandler()
		{
			ApiInstance = new Intersight.Api.WorkflowApi(Config);
            MethodName = "DeleteWorkflowErrorResponseHandlerWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get WorkflowErrorResponseHandler.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightWorkflowErrorResponseHandler", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightWorkflowErrorResponseHandler:GetCmdletBase
	{
		public GetIntersightWorkflowErrorResponseHandler()
		{
			ApiInstance = new Intersight.Api.WorkflowApi(Config);
            MethodName = "GetWorkflowErrorResponseHandlerListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New WorkflowErrorResponseHandler.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightWorkflowErrorResponseHandler")]
    public class NewIntersightWorkflowErrorResponseHandler:NewCmdletBase
	{
		public NewIntersightWorkflowErrorResponseHandler()
		{
			ApiInstance = new Intersight.Api.WorkflowApi(Config);
            ModelObject = new WorkflowErrorResponseHandler();
            MethodName = "CreateWorkflowErrorResponseHandlerWithHttpInfo";
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
        /// <para type="description">"A reference to a workflowCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowCatalogRelationship Catalog {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A detailed description about the error response handler."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
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
        /// <para type="description">"Name for the error response handler."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<ContentParameter> Parameters {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The platform type for which the error response handler is defined.\n* `` - The device reported an empty or unrecognized platform type.\n* `APIC` - An Application Policy Infrastructure Controller cluster.\n* `DCNM` - A Data Center Network Manager instance. Data Center Network Manager (DCNM) is the network management platform for all NX-OS-enabled deployments, spanning new fabric architectures, IP Fabric for Media, and storage networking deployments for the Cisco Nexus-powered data center.\n* `UCSFI` - A UCS Fabric Interconnect in HA or standalone mode, which is being managed by UCS Manager (UCSM).\n* `UCSFIISM` - A UCS Fabric Interconnect in HA or standalone mode, managed directly by Intersight.\n* `IMC` - A standalone UCS Server Integrated Management Controller.\n* `IMCM4` - A standalone UCS M4 Server.\n* `IMCM5` - A standalone UCS M5 server.\n* `IMCRack` - A standalone UCS M6 and above server.\n* `UCSIOM` - An UCS Chassis IO module.\n* `HX` - A HyperFlex storage controller.\n* `HyperFlexAP` - A HyperFlex Application Platform.\n* `UCSD` - A UCS Director virtual appliance. Cisco UCS Director automates, orchestrates, and manages Cisco and third-party hardware.\n* `IntersightAppliance` - A Cisco Intersight Connected Virtual Appliance.\n* `IntersightAssist` - A Cisco Intersight Assist.\n* `PureStorageFlashArray` - A Pure Storage FlashArray device.\n* `UCSC890` - A standalone Cisco UCSC890 server.\n* `NetAppOntap` - A NetApp ONTAP storage system.\n* `NetAppActiveIqUnifiedManager` - A NetApp Active IQ Unified Manager.\n* `EmcScaleIo` - An EMC ScaleIO storage system.\n* `EmcVmax` - An EMC VMAX storage system.\n* `EmcVplex` - An EMC VPLEX storage system.\n* `EmcXtremIo` - An EMC XtremIO storage system.\n* `VmwareVcenter` - A VMware vCenter device that manages Virtual Machines.\n* `MicrosoftHyperV` - A Microsoft Hyper-V system that manages Virtual Machines.\n* `AppDynamics` - An AppDynamics controller that monitors applications.\n* `Dynatrace` - A software-intelligence monitoring platform that simplifies enterprise cloud complexity and accelerates digital transformation.\n* `ReadHatOpenStack` - An OpenStack target manages Virtual Machines, Physical Machines, Datacenters and Virtual Datacenters using different OpenStack services as administrative endpoints.\n* `CloudFoundry` - An open source cloud platform on which developers can build, deploy, run and scale applications.\n* `MicrosoftAzureApplicationInsights` - A feature of Azure Monitor, is an extensible Application Performance Management service for developers and DevOps professionals to monitor their live applications.\n* `OpenStack` - An OpenStack target manages Virtual Machines, Physical Machines, Datacenters and Virtual Datacenters using different OpenStack services as administrative endpoints.\n* `MicrosoftSqlServer` - A Microsoft SQL database server.\n* `Kubernetes` - A Kubernetes cluster that runs containerized applications.\n* `AmazonWebService` - A Amazon web service target that discovers and monitors different services like EC2. It discovers entities like VMs, Volumes, regions etc. and monitors attributes like Mem, CPU, cost.\n* `AmazonWebServiceBilling` - A Amazon web service billing target to retrieve billing information stored in S3 bucket.\n* `MicrosoftAzureServicePrincipal` - A Microsoft Azure Service Principal target that discovers all the associated Azure subscriptions.\n* `MicrosoftAzureEnterpriseAgreement` - A Microsoft Azure Enterprise Agreement target that discovers cost, billing and RIs.\n* `DellCompellent` - A Dell Compellent storage system.\n* `HPE3Par` - A HPE 3PAR storage system.\n* `RedHatEnterpriseVirtualization` - A Red Hat Enterprise Virtualization Hypervisor system that manages Virtual Machines.\n* `NutanixAcropolis` - A Nutanix Acropolis system that combines servers and storage into a distributed infrastructure platform.\n* `HPEOneView` - A HPE Oneview management system that manages compute, storage, and networking.\n* `ServiceEngine` - Cisco Application Services Engine. Cisco Application Services Engine is a platform to deploy and manage applications.\n* `HitachiVirtualStoragePlatform` - A Hitachi Virtual Storage Platform also referred to as Hitachi VSP. It includes various storage systems designed for data centers.\n* `IMCBlade` - An Intersight managed UCS Blade Server.\n* `TerraformCloud` - A Terraform Cloud account.\n* `TerraformAgent` - A Terraform Cloud Agent that Intersight will deploy in datacenter. The agent will execute Terraform plan for Terraform Cloud workspace configured to use the agent.\n* `CustomTarget` - An external endpoint added as Target that can be accessed through its HTTP API interface in Intersight Orchestrator automation workflow.Standard HTTP authentication scheme supported: Basic.\n* `HTTPEndpoint` - An external endpoint added as Target that can be accessed through its HTTP API interface in Intersight Orchestrator automation workflow.Standard HTTP authentication scheme supported: Basic.\n* `CiscoCatalyst` - A Cisco Catalyst networking switch device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowErrorResponseHandler.PlatformTypeEnum PlatformType {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<ContentComplexType> Types {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove WorkflowBatchApiExecutor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightWorkflowBatchApiExecutor")]
    public class RemoveIntersightWorkflowBatchApiExecutor:RemoveCmdletBase
	{
		public RemoveIntersightWorkflowBatchApiExecutor()
		{
			ApiInstance = new Intersight.Api.WorkflowApi(Config);
            MethodName = "DeleteWorkflowBatchApiExecutorWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set WorkflowBatchApiExecutor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightWorkflowBatchApiExecutor")]
    public class SetIntersightWorkflowBatchApiExecutor:SetCmdletBase
	{
		public SetIntersightWorkflowBatchApiExecutor()
		{
			ApiInstance = new Intersight.Api.WorkflowApi(Config);
            ModelObject = new WorkflowBatchApiExecutor();
            MethodName = "UpdateWorkflowBatchApiExecutorWithHttpInfo";
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Intersight.Model.WorkflowApi> Batch {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enter the constraints on when this task should match against the task definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowTaskConstraints Constraints {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A detailed description about the batch APIs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a workflowErrorResponseHandler resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowErrorResponseHandlerRelationship ErrorResponseHandler {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name for the batch API task."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"All the possible outcomes of this task are captured here. Outcomes property\nis a collection property of type workflow.Outcome objects.\nThe outcomes can be mapped to the message to be shown. The outcomes are\nevaluated in the order they are given. At the end of the outcomes list,\nan catchall success/fail outcome can be added with condition as 'true'.\nThis is an optional\nproperty and if not specified the task will be marked as success."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object Outcomes {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Intersight Orchestrator allows the extraction of required values from API\nresponses using the API response grammar. These extracted values can be mapped\nto task output parameters defined in task definition.\nThe mapping of API output parameters to the task output parameters is provided\nas JSON in this property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object Output {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When an execution of a nth API in the Batch fails,\nRetry from falied API flag indicates if the execution should start from the nth API or the first API during task retry.\nBy default the value is set to false."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool RetryFromFailedApi {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The skip expression, if provided, allows the batch API executor to skip the\ntask execution when the given expression evaluates to true.\nThe expression is given as such a golang template that has to be\nevaluated to a final content true/false. The expression is an optional and in\ncase not provided, the API will always be executed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SkipOnCondition {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a workflowTaskDefinition resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowTaskDefinitionRelationship TaskDefinition {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set WorkflowCustomDataTypeDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightWorkflowCustomDataTypeDefinition")]
    public class SetIntersightWorkflowCustomDataTypeDefinition:SetCmdletBase
	{
		public SetIntersightWorkflowCustomDataTypeDefinition()
		{
			ApiInstance = new Intersight.Api.WorkflowApi(Config);
            ModelObject = new WorkflowCustomDataTypeDefinition();
            MethodName = "UpdateWorkflowCustomDataTypeDefinitionWithHttpInfo";
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
        /// <para type="description">"A reference to a workflowCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowCatalogRelationship Catalog {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When true this data type definition is a collection of type definitions to represent composite data like JSON."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool CompositeType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A human-friendly description of this custom data type indicating it's domain and usage."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user friendly short name to identify the custom data type definition. Label can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.), colon (:), space ( ), single quote ('), or an underscore (_)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+[\\sa-zA-Z0-9_'.:-]{1,92}$")]
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of custom data type definition. The valid name can contain lower case and upper case alphabetic characters, digits and special characters '-' and '_'."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<WorkflowParameterSet> ParameterSet {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type to capture all the properties for the custom data type definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowCustomDataTypeProperties Properties {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<WorkflowBaseDataType> TypeDefinition {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove WorkflowCustomDataTypeDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightWorkflowCustomDataTypeDefinition")]
    public class RemoveIntersightWorkflowCustomDataTypeDefinition:RemoveCmdletBase
	{
		public RemoveIntersightWorkflowCustomDataTypeDefinition()
		{
			ApiInstance = new Intersight.Api.WorkflowApi(Config);
            MethodName = "DeleteWorkflowCustomDataTypeDefinitionWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get WorkflowTaskMetadata.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightWorkflowTaskMetadata", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightWorkflowTaskMetadata:GetCmdletBase
	{
		public GetIntersightWorkflowTaskMetadata()
		{
			ApiInstance = new Intersight.Api.WorkflowApi(Config);
            MethodName = "GetWorkflowTaskMetadataListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New WorkflowTaskDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightWorkflowTaskDefinition")]
    public class NewIntersightWorkflowTaskDefinition:NewCmdletBase
	{
		public NewIntersightWorkflowTaskDefinition()
		{
			ApiInstance = new Intersight.Api.WorkflowApi(Config);
            ModelObject = new WorkflowTaskDefinition();
            MethodName = "CreateWorkflowTaskDefinitionWithHttpInfo";
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
        /// <para type="description">"A reference to a workflowCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowCatalogRelationship Catalog {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When true this will be the task version that is used when a specific task definition version is not specified. The very first task definition created with a name will be set as the default version, after that user can explicitly set any version of the task definition as the default version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool DefaultVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user friendly description about task on what operations are done as part of the task execution and any other specific information about task input and output."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to workflowTaskDefinition resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<WorkflowTaskDefinitionRelationship> ImplementedTasks {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a workflowTaskDefinition resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowTaskDefinitionRelationship InterfaceTask {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user friendly short name to identify the task definition. Label can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.), colon (:), space ( ), single quote ('), forward slash (/), or an underscore (_)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+[\\sa-zA-Z0-9_'./:-]{1,92}$")]
        public string Label {
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
        /// <para type="description">"The name of the task definition. The name should follow this convention <Verb or Action><Category><Vendor><Product><Noun or object> Verb or Action is a required portion of the name and this must be part of the pre-approved verb list. Category is an optional field and this will refer to the broad category of the task referring to the type of resource or endpoint. If there is no specific category then use \"Generic\" if required. Vendor is an optional field and this will refer to the specific vendor this task applies to. If the task is generic and not tied to a vendor, then do not specify anything. Product is an optional field, this will contain the vendor product and model when desired. Noun or object is a required field and  this will contain the noun or object on which the action is being performed. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.), colon (:), or an underscore (_). Examples SendEmail  - This is a task in Generic category for sending email. NewStorageVolume - This is a vendor agnostic task under Storage device category for creating a new volume."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type to capture all the properties for the task definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowProperties Properties {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<WorkflowRollbackTask> RollbackTasks {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If set to true, the task requires access to secure properties and uses an encryption token associated with a workflow moid to encrypt or decrypt the secure properties."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool SecurePropAccess {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a workflowTaskMetadata resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowTaskMetadataRelationship TaskMetadata {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The version of the task definition so we can support multiple versions of a task definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get WorkflowTaskDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightWorkflowTaskDefinition", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightWorkflowTaskDefinition:GetCmdletBase
	{
		public GetIntersightWorkflowTaskDefinition()
		{
			ApiInstance = new Intersight.Api.WorkflowApi(Config);
            MethodName = "GetWorkflowTaskDefinitionListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get WorkflowPendingDynamicWorkflowInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightWorkflowPendingDynamicWorkflowInfo", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightWorkflowPendingDynamicWorkflowInfo:GetCmdletBase
	{
		public GetIntersightWorkflowPendingDynamicWorkflowInfo()
		{
			ApiInstance = new Intersight.Api.WorkflowApi(Config);
            MethodName = "GetWorkflowPendingDynamicWorkflowInfoListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get WorkflowTemplateFunctionMeta.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightWorkflowTemplateFunctionMeta", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightWorkflowTemplateFunctionMeta:GetCmdletBase
	{
		public GetIntersightWorkflowTemplateFunctionMeta()
		{
			ApiInstance = new Intersight.Api.WorkflowApi(Config);
            MethodName = "GetWorkflowTemplateFunctionMetaListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set WorkflowWorkflowDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightWorkflowWorkflowDefinition")]
    public class SetIntersightWorkflowWorkflowDefinition:SetCmdletBase
	{
		public SetIntersightWorkflowWorkflowDefinition()
		{
			ApiInstance = new Intersight.Api.WorkflowApi(Config);
            ModelObject = new WorkflowWorkflowDefinition();
            MethodName = "UpdateWorkflowWorkflowDefinitionWithHttpInfo";
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
        /// <para type="description">"A reference to a workflowCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowCatalogRelationship Catalog {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When true this will be the workflow version that is used when a specific workflow definition version is not specified. The default version is used when user executes a workflow without specifying a version or when workflow is included in another workflow without a specific version. The very first workflow definition created with a name will be set as the default version, after that user can explicitly set any version of the workflow definition as the default version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool DefaultVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The description for this workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<WorkflowBaseDataType> InputDefinition {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<WorkflowParameterSet> InputParameterSet {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user friendly short name to identify the workflow. Label can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.), colon (:), space ( ), forward slash (/), or an underscore (_)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+[\\sa-zA-Z0-9_./:-]{1,92}$")]
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name for this workflow. You can have multiple versions of the workflow with the same name. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.) or an underscore (_)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<WorkflowBaseDataType> OutputDefinition {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The output mappings for the workflow. The outputs for workflows will generally be task output variables that we want to export out at the end of the workflow. The format to specify the mapping is '${Source.output.JsonPath}', where 'Source' is the name of the task within the workflow. Any task output can be mapped to a workflow output as long as the types are compatible. It's followed by a JSON path expression to extract JSON fragment from source's output."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object OutputParameters {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type to capture the properties of a workflow definition. Some of these properties are passed to workflow execution instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowWorkflowProperties Properties {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<WorkflowWorkflowTask> Tasks {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<WorkflowUiInputFilter> UiInputFilters {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This will hold the data needed for workflow to be rendered in the user interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object UiRenderingData {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The version of the workflow to support multiple versions."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Version {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a workflowWorkflowMetadata resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowWorkflowMetadataRelationship WorkflowMetadata {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove WorkflowWorkflowDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightWorkflowWorkflowDefinition")]
    public class RemoveIntersightWorkflowWorkflowDefinition:RemoveCmdletBase
	{
		public RemoveIntersightWorkflowWorkflowDefinition()
		{
			ApiInstance = new Intersight.Api.WorkflowApi(Config);
            MethodName = "DeleteWorkflowWorkflowDefinitionWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get WorkflowWorkflowMetadata.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightWorkflowWorkflowMetadata", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightWorkflowWorkflowMetadata:GetCmdletBase
	{
		public GetIntersightWorkflowWorkflowMetadata()
		{
			ApiInstance = new Intersight.Api.WorkflowApi(Config);
            MethodName = "GetWorkflowWorkflowMetadataListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set WorkflowRollbackWorkflow.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightWorkflowRollbackWorkflow")]
    public class SetIntersightWorkflowRollbackWorkflow:SetCmdletBase
	{
		public SetIntersightWorkflowRollbackWorkflow()
		{
			ApiInstance = new Intersight.Api.WorkflowApi(Config);
            ModelObject = new WorkflowRollbackWorkflow();
            MethodName = "UpdateWorkflowRollbackWorkflowWithHttpInfo";
		}
        // <summary>
        /// <para type="description">"The action of the rollback workflow such as Create and Start.\n* `None` - If no action is set, then the default value is set to none for the action field.\n* `Create` - Create rollback workflow data for the execution of the rollback workflow.\n* `Start` - Start a new execution of the rollback workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowRollbackWorkflow.ActionEnum Action {
            get;
            set;
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
        /// <para type="description">"When set to true, if a task in the workflow fails, the rollback workflow continues to the subsequent task. When set to false, the rollback workflow execution halts if a task fails."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool ContinueOnTaskFailure {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a workflowWorkflowInfo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowWorkflowInfoRelationship PrimaryWorkflow {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<WorkflowRollbackWorkflowTask> RollbackTasks {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<WorkflowRollbackWorkflowTask> SelectedTasks {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove WorkflowRollbackWorkflow.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightWorkflowRollbackWorkflow")]
    public class RemoveIntersightWorkflowRollbackWorkflow:RemoveCmdletBase
	{
		public RemoveIntersightWorkflowRollbackWorkflow()
		{
			ApiInstance = new Intersight.Api.WorkflowApi(Config);
            MethodName = "DeleteWorkflowRollbackWorkflowWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get WorkflowRollbackWorkflow.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightWorkflowRollbackWorkflow", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightWorkflowRollbackWorkflow:GetCmdletBase
	{
		public GetIntersightWorkflowRollbackWorkflow()
		{
			ApiInstance = new Intersight.Api.WorkflowApi(Config);
            MethodName = "GetWorkflowRollbackWorkflowListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New WorkflowRollbackWorkflow.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightWorkflowRollbackWorkflow")]
    public class NewIntersightWorkflowRollbackWorkflow:NewCmdletBase
	{
		public NewIntersightWorkflowRollbackWorkflow()
		{
			ApiInstance = new Intersight.Api.WorkflowApi(Config);
            ModelObject = new WorkflowRollbackWorkflow();
            MethodName = "CreateWorkflowRollbackWorkflowWithHttpInfo";
		}
        // <summary>
        /// <para type="description">"The action of the rollback workflow such as Create and Start.\n* `None` - If no action is set, then the default value is set to none for the action field.\n* `Create` - Create rollback workflow data for the execution of the rollback workflow.\n* `Start` - Start a new execution of the rollback workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowRollbackWorkflow.ActionEnum Action {
            get;
            set;
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
        /// <para type="description">"When set to true, if a task in the workflow fails, the rollback workflow continues to the subsequent task. When set to false, the rollback workflow execution halts if a task fails."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool ContinueOnTaskFailure {
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
        /// <para type="description">"A reference to a workflowWorkflowInfo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowWorkflowInfoRelationship PrimaryWorkflow {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<WorkflowRollbackWorkflowTask> RollbackTasks {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<WorkflowRollbackWorkflowTask> SelectedTasks {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get WorkflowWorkflowMeta.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightWorkflowWorkflowMeta", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightWorkflowWorkflowMeta:GetCmdletBase
	{
		public GetIntersightWorkflowWorkflowMeta()
		{
			ApiInstance = new Intersight.Api.WorkflowApi(Config);
            MethodName = "GetWorkflowWorkflowMetaListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get WorkflowTaskInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightWorkflowTaskInfo", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightWorkflowTaskInfo:GetCmdletBase
	{
		public GetIntersightWorkflowTaskInfo()
		{
			ApiInstance = new Intersight.Api.WorkflowApi(Config);
            MethodName = "GetWorkflowTaskInfoListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get WorkflowWorkflowDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightWorkflowWorkflowDefinition", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightWorkflowWorkflowDefinition:GetCmdletBase
	{
		public GetIntersightWorkflowWorkflowDefinition()
		{
			ApiInstance = new Intersight.Api.WorkflowApi(Config);
            MethodName = "GetWorkflowWorkflowDefinitionListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New WorkflowWorkflowDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightWorkflowWorkflowDefinition")]
    public class NewIntersightWorkflowWorkflowDefinition:NewCmdletBase
	{
		public NewIntersightWorkflowWorkflowDefinition()
		{
			ApiInstance = new Intersight.Api.WorkflowApi(Config);
            ModelObject = new WorkflowWorkflowDefinition();
            MethodName = "CreateWorkflowWorkflowDefinitionWithHttpInfo";
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
        /// <para type="description">"A reference to a workflowCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowCatalogRelationship Catalog {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When true this will be the workflow version that is used when a specific workflow definition version is not specified. The default version is used when user executes a workflow without specifying a version or when workflow is included in another workflow without a specific version. The very first workflow definition created with a name will be set as the default version, after that user can explicitly set any version of the workflow definition as the default version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool DefaultVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The description for this workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<WorkflowBaseDataType> InputDefinition {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<WorkflowParameterSet> InputParameterSet {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user friendly short name to identify the workflow. Label can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.), colon (:), space ( ), forward slash (/), or an underscore (_)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+[\\sa-zA-Z0-9_./:-]{1,92}$")]
        public string Label {
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
        /// <para type="description">"The name for this workflow. You can have multiple versions of the workflow with the same name. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.) or an underscore (_)."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<WorkflowBaseDataType> OutputDefinition {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The output mappings for the workflow. The outputs for workflows will generally be task output variables that we want to export out at the end of the workflow. The format to specify the mapping is '${Source.output.JsonPath}', where 'Source' is the name of the task within the workflow. Any task output can be mapped to a workflow output as long as the types are compatible. It's followed by a JSON path expression to extract JSON fragment from source's output."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object OutputParameters {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type to capture the properties of a workflow definition. Some of these properties are passed to workflow execution instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowWorkflowProperties Properties {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<WorkflowWorkflowTask> Tasks {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<WorkflowUiInputFilter> UiInputFilters {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This will hold the data needed for workflow to be rendered in the user interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object UiRenderingData {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The version of the workflow to support multiple versions."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Version {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a workflowWorkflowMetadata resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowWorkflowMetadataRelationship WorkflowMetadata {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New WorkflowTemplateEvaluation.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightWorkflowTemplateEvaluation")]
    public class NewIntersightWorkflowTemplateEvaluation:NewCmdletBase
	{
		public NewIntersightWorkflowTemplateEvaluation()
		{
			ApiInstance = new Intersight.Api.WorkflowApi(Config);
            ModelObject = new WorkflowTemplateEvaluation();
            MethodName = "CreateWorkflowTemplateEvaluationWithHttpInfo";
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
        /// <para type="description">"Expected output type of the template. Required to type cast the output."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowBaseDataType ExpectedOutputDataType {
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<TemplateTransformationStage> Stages {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Values to be fed to the template for execution."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object Values {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set WorkflowWorkflowInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightWorkflowWorkflowInfo")]
    public class SetIntersightWorkflowWorkflowInfo:SetCmdletBase
	{
		public SetIntersightWorkflowWorkflowInfo()
		{
			ApiInstance = new Intersight.Api.WorkflowApi(Config);
            ModelObject = new WorkflowWorkflowInfo();
            MethodName = "UpdateWorkflowWorkflowInfoWithHttpInfo";
		}
        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamAccountRelationship Account {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The action of the workflow such as start, cancel, retry, pause.\n* `None` - No action is set, this is the default value for action field.\n* `Create` - Create a new instance of the workflow but it does not start the execution of the workflow. Use the Start action to start execution of the workflow.\n* `Start` - Start a new execution of the workflow.\n* `Pause` - Pause the workflow, this can only be issued on workflows that are in running state.\n* `Resume` - Resume the workflow which was previously paused through pause action on the workflow.\n* `Retry` - Retry the workflow that has previously reached a final state and has the retryable property set to true. A running or waiting workflow cannot be retried. If the property retryFromTaskName is also passed along with this action, the workflow will be started from that specific task, otherwise the workflow will be restarted from the first task.  The task name in retryFromTaskName must be one of the tasks that completed or failed in the previous run. It is not possible to retry a workflow from a task which wasn't run in the previous iteration.\n* `RetryFailed` - Retry the workflow that has failed. A running or waiting workflow or a workflow that completed successfully cannot be retried. Only the tasks that failed in the previous run will be retried and the rest of workflow will be run. This action does not restart the workflow and also does not support retrying from a specific task.\n* `Cancel` - Cancel the workflow that is in running or waiting state."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowWorkflowInfo.ActionEnum Action {
            get;
            set;
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
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public MoBaseMoRelationship AssociatedObject {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The duration in hours after which the workflow info for failed, terminated or timed out workflow will be removed from database."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long FailedWorkflowCleanupDuration {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"All the given inputs for the workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object Input {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Denotes if this workflow is internal and should be hidden from user view of running workflows."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Internal {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<WorkflowMessage> Message {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of the workflow metadata for which this workflow execution was started."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long MetaVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A name of the workflow execution instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[^:]{1,92}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Denotes the reason workflow is in paused status.\n* `None` - Pause reason is none, which indicates there is no reason for the pause state.\n* `TaskWithWarning` - Pause reason indicates the workflow is in this state due to a task that has a status as completed with warnings.\n* `SystemMaintenance` - Pause reason indicates the workflow is in this state based on actions of system admin for maintenance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowWorkflowInfo.PauseReasonEnum PauseReason {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamPermission resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public IamPermissionRelationship Permission {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This field is applicable when Retry action is issued for a workflow which is in 'final' state. When this field is not specified, the workflow will be retried from the start i.e., the first task. When this field is specified then the workflow will be retried from the specified task. This field should specify the task name which is the unique name of the task within the workflow. The task name must be one of the tasks that completed or failed in the previous run. It is not possible to retry a workflow from a task which wasn't run in the previous iteration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RetryFromTaskName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The duration in hours after which the workflow info for successful workflow will be removed from database."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long SuccessWorkflowCleanupDuration {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Denotes the reason workflow is in waiting status.\n* `None` - Wait reason is none, which indicates there is no reason for the waiting state.\n* `GatherTasks` - Wait reason is gathering tasks, which indicates the workflow is in this state in order to gather tasks.\n* `Duplicate` - Wait reason is duplicate, which indicates the workflow is a duplicate of current running workflow.\n* `RateLimit` - Wait reason is rate limit, which indicates the workflow is rate limited by account/instance level throttling threshold.\n* `WaitTask` - Wait reason when there are one or more wait tasks in the workflow which are yet to receive a task status update.\n* `PendingRetryFailed` - Wait reason when the workflow is pending a RetryFailed action.\n* `WaitingToStart` - Workflow is waiting to start on workflow engine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowWorkflowInfo.WaitReasonEnum WaitReason {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The workflow context which contains initiator and target information."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowWorkflowCtx WorkflowCtx {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a workflowWorkflowDefinition resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowWorkflowDefinitionRelationship WorkflowDefinition {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of workflow meta. Derived from the workflow meta that is used to launch this workflow instance.\n* `SystemDefined` - System defined workflow definition.\n* `UserDefined` - User defined workflow definition.\n* `Dynamic` - Dynamically defined workflow definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowWorkflowInfo.WorkflowMetaTypeEnum WorkflowMetaType {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove WorkflowWorkflowInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightWorkflowWorkflowInfo")]
    public class RemoveIntersightWorkflowWorkflowInfo:RemoveCmdletBase
	{
		public RemoveIntersightWorkflowWorkflowInfo()
		{
			ApiInstance = new Intersight.Api.WorkflowApi(Config);
            MethodName = "DeleteWorkflowWorkflowInfoWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get WorkflowBuildTaskMeta.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightWorkflowBuildTaskMeta", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightWorkflowBuildTaskMeta:GetCmdletBase
	{
		public GetIntersightWorkflowBuildTaskMeta()
		{
			ApiInstance = new Intersight.Api.WorkflowApi(Config);
            MethodName = "GetWorkflowBuildTaskMetaListWithHttpInfo";
		}
    }
}