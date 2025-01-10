using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowAbstractResourceSelector.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowAbstractResourceSelector")]
    public class InitializeIntersightWorkflowAbstractResourceSelector : PSCmdlet
    {
        public InitializeIntersightWorkflowAbstractResourceSelector()
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

        public WorkflowAbstractResourceSelector.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowAbstractResourceSelector.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowAbstractResourceSelector initObject = new Intersight.Model.WorkflowAbstractResourceSelector();
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowAnsibleBatchExecutor.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowAnsibleBatchExecutor")]
    public class InitializeIntersightWorkflowAnsibleBatchExecutor : PSCmdlet
    {
        public InitializeIntersightWorkflowAnsibleBatchExecutor()
        {
            ClassId = WorkflowAnsibleBatchExecutor.ClassIdEnum.WorkflowAnsibleBatchExecutor;
            ObjectType = WorkflowAnsibleBatchExecutor.ObjectTypeEnum.WorkflowAnsibleBatchExecutor;

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

        public List<Model.WorkflowApi> Batch
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.WorkflowApi> CancelAction
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowAnsibleBatchExecutor.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enter the constraints on when this task should match against the task definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowTaskConstraints Constraints
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A detailed description about the batch APIs."</para>
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
        /// <para type="description">"Name for the batch API task."</para>
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

        public WorkflowAnsibleBatchExecutor.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"All the possible outcomes of this task are captured here. Outcomes property\nis a collection property of type workflow.Outcome objects.\nThe outcomes can be mapped to the message to be shown. The outcomes are\nevaluated in the order they are given. At the end of the outcomes list,\nan catchall success/fail outcome can be added with condition as 'true'.\nThis is an optional\nproperty and if not specified the task will be marked as success."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Outcomes
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Intersight Orchestrator allows the extraction of required values from API\nresponses using the API response grammar. These extracted values can be mapped\nto task output parameters defined in task definition.\nThe mapping of API output parameters to the task output parameters is provided\nas JSON in this property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Output
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When an execution of a nth API in the Batch fails,\nRetry from failed API flag indicates if the execution should start from the nth API or the first API during task retry.\nBy default the value is set to false."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool RetryFromFailedApi
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The skip expression, if provided, allows the batch API executor to skip the\ntask execution when the given expression evaluates to true.\nThe expression is given as such a golang template that has to be\nevaluated to a final content true/false. The expression is an optional and in\ncase not provided, the API will always be executed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SkipOnCondition
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
        /// <para type="description">"A reference to a workflowTaskDefinition resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowTaskDefinitionRelationship TaskDefinition
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This will hold the data needed for task to be rendered in the user interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object UiRenderingData
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowAnsibleBatchExecutor initObject = new Intersight.Model.WorkflowAnsibleBatchExecutor();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Batch"))
            {
                initObject.Batch = this.Batch;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CancelAction"))
            {
                initObject.CancelAction = this.CancelAction;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Constraints"))
            {
                initObject.Constraints = this.Constraints;
            }
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Outcomes"))
            {
                initObject.Outcomes = this.Outcomes;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Output"))
            {
                initObject.Output = this.Output;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RetryFromFailedApi"))
            {
                initObject.RetryFromFailedApi = this.RetryFromFailedApi;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SkipOnCondition"))
            {
                initObject.SkipOnCondition = this.SkipOnCondition;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TaskDefinition"))
            {
                initObject.TaskDefinition = this.TaskDefinition;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UiRenderingData"))
            {
                initObject.UiRenderingData = this.UiRenderingData;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowAnsiblePlaySession.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowAnsiblePlaySession")]
    public class InitializeIntersightWorkflowAnsiblePlaySession : PSCmdlet
    {
        public InitializeIntersightWorkflowAnsiblePlaySession()
        {
            ClassId = WorkflowAnsiblePlaySession.ClassIdEnum.WorkflowAnsiblePlaySession;
            ObjectType = WorkflowAnsiblePlaySession.ObjectTypeEnum.WorkflowAnsiblePlaySession;

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
        /// <para type="description">"The optional request body that is sent as part of this API request.\nThe request body can contain a golang template that can be populated with task input\nparameters and previous API output parameters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Body
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowAnsiblePlaySession.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The command line arguments for running the Ansible playbook against the given endpoint. Escape character backslash needs to be used when the command line arguments contain double quotes in them."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string CommandLineArguments
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Intersight Orchestrator, with the support of response parser specification,\ncan extract the values from API responses and map them to task output parameters.\nThe value extraction is supported for response content types XML, JSON and Text.\nThe type of the content that gets passed as payload and response in this\nAPI. The supported values are json, xml, text."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ContentType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A description that task designer can add to individual API requests that explain \nwhat the API call is about."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Intersight Orchestrator, with the support of response parser specification,\ncan extract the values from API responses and map them to task output parameters.\nThe value extraction is supported for response content types XML, JSON and Text.\nOptional input to specify the content type in case of error API response. This\nshould be used if the content type of error response is different from that of\nthe success response. If not specified, contentType input value is used to parse\nthe error response."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ErrorContentType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The path of the host inventory file that resides on the Ansible Endpoint target or the comma separated list of hosts on which the Ansible playbook is to be run. Make sure to suffix a comma when the list of hosts is provided as input, even if the list has only one value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string HostInventory
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user friendly label that task designers have given to the batch API request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference name for this API request within the batch API request.\nThis name shall be used to map the API output parameters to subsequent\nAPI input parameters within a batch API task."</para>
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

        public WorkflowAnsiblePlaySession.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"All the possible outcomes of this API are captured here. Outcomes property\nis a collection property of type workflow.Outcome objects.\nThe outcomes can be mapped to the message to be shown. The outcomes are\nevaluated in the order they are given. At the end of the outcomes list,\nan catchall success/fail outcome can be added with condition as 'true'.\nThis is an optional\nproperty and if not specified the task will be marked as success."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Outcomes
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The path of the Ansible playbook that resides on the Ansible Endpoint target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PlaybookPath
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The optional grammar specification for parsing the response to extract the\nrequired values.\nThe specification should have extraction specification specified for\nall the API output parameters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object ResponseSpec
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The skip expression, if provided, allows the batch API executor to skip the\napi execution when the given expression evaluates to true.\nThe expression is given as such a golang template that has to be\nevaluated to a final content true/false. The expression is an optional and in\ncase not provided, the API will always be executed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SkipOnCondition
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SSH operation timeout value in seconds. Value provided should be string representation of an interger."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SshOpTimeout
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The delay in seconds after which the API needs to be executed.\nBy default, the given API is executed immediately. Specifying a start delay adds to the delay to execution.\nStart Delay is not supported for the first API in the Batch and cumulative delay of all the APIs in the Batch should not exceed the task time out."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long StartDelay
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The duration in seconds by which the API response is expected from the API target.\nIf the end point does not respond for the API request within this timeout\nduration, the task will be marked as failed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Timeout
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowAnsiblePlaySession initObject = new Intersight.Model.WorkflowAnsiblePlaySession();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Body"))
            {
                initObject.Body = this.Body;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CommandLineArguments"))
            {
                initObject.CommandLineArguments = this.CommandLineArguments;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ContentType"))
            {
                initObject.ContentType = this.ContentType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ErrorContentType"))
            {
                initObject.ErrorContentType = this.ErrorContentType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HostInventory"))
            {
                initObject.HostInventory = this.HostInventory;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Outcomes"))
            {
                initObject.Outcomes = this.Outcomes;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PlaybookPath"))
            {
                initObject.PlaybookPath = this.PlaybookPath;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ResponseSpec"))
            {
                initObject.ResponseSpec = this.ResponseSpec;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SkipOnCondition"))
            {
                initObject.SkipOnCondition = this.SkipOnCondition;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SshOpTimeout"))
            {
                initObject.SshOpTimeout = this.SshOpTimeout;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StartDelay"))
            {
                initObject.StartDelay = this.StartDelay;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Timeout"))
            {
                initObject.Timeout = this.Timeout;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowApi.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowApi")]
    public class InitializeIntersightWorkflowApi : PSCmdlet
    {
        public InitializeIntersightWorkflowApi()
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
        /// <para type="description">"The optional request body that is sent as part of this API request.\nThe request body can contain a golang template that can be populated with task input\nparameters and previous API output parameters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Body
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowApi.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Intersight Orchestrator, with the support of response parser specification,\ncan extract the values from API responses and map them to task output parameters.\nThe value extraction is supported for response content types XML, JSON and Text.\nThe type of the content that gets passed as payload and response in this\nAPI. The supported values are json, xml, text."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ContentType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A description that task designer can add to individual API requests that explain \nwhat the API call is about."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Intersight Orchestrator, with the support of response parser specification,\ncan extract the values from API responses and map them to task output parameters.\nThe value extraction is supported for response content types XML, JSON and Text.\nOptional input to specify the content type in case of error API response. This\nshould be used if the content type of error response is different from that of\nthe success response. If not specified, contentType input value is used to parse\nthe error response."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ErrorContentType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user friendly label that task designers have given to the batch API request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference name for this API request within the batch API request.\nThis name shall be used to map the API output parameters to subsequent\nAPI input parameters within a batch API task."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowApi.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"All the possible outcomes of this API are captured here. Outcomes property\nis a collection property of type workflow.Outcome objects.\nThe outcomes can be mapped to the message to be shown. The outcomes are\nevaluated in the order they are given. At the end of the outcomes list,\nan catchall success/fail outcome can be added with condition as 'true'.\nThis is an optional\nproperty and if not specified the task will be marked as success."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Outcomes
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The optional grammar specification for parsing the response to extract the\nrequired values.\nThe specification should have extraction specification specified for\nall the API output parameters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object ResponseSpec
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The skip expression, if provided, allows the batch API executor to skip the\napi execution when the given expression evaluates to true.\nThe expression is given as such a golang template that has to be\nevaluated to a final content true/false. The expression is an optional and in\ncase not provided, the API will always be executed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SkipOnCondition
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The delay in seconds after which the API needs to be executed.\nBy default, the given API is executed immediately. Specifying a start delay adds to the delay to execution.\nStart Delay is not supported for the first API in the Batch and cumulative delay of all the APIs in the Batch should not exceed the task time out."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long StartDelay
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The duration in seconds by which the API response is expected from the API target.\nIf the end point does not respond for the API request within this timeout\nduration, the task will be marked as failed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Timeout
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowApi initObject = new Intersight.Model.WorkflowApi();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Body"))
            {
                initObject.Body = this.Body;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ContentType"))
            {
                initObject.ContentType = this.ContentType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ErrorContentType"))
            {
                initObject.ErrorContentType = this.ErrorContentType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Outcomes"))
            {
                initObject.Outcomes = this.Outcomes;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ResponseSpec"))
            {
                initObject.ResponseSpec = this.ResponseSpec;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SkipOnCondition"))
            {
                initObject.SkipOnCondition = this.SkipOnCondition;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StartDelay"))
            {
                initObject.StartDelay = this.StartDelay;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Timeout"))
            {
                initObject.Timeout = this.Timeout;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowArrayDataType.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowArrayDataType")]
    public class InitializeIntersightWorkflowArrayDataType : PSCmdlet
    {
        public InitializeIntersightWorkflowArrayDataType()
        {
            ClassId = WorkflowArrayDataType.ClassIdEnum.WorkflowArrayDataType;
            ObjectType = WorkflowArrayDataType.ObjectTypeEnum.WorkflowArrayDataType;

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
        /// <para type="description">"Data item within the array data type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowArrayItem ArrayItemType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowArrayDataType.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Default value for the data type. If default value was provided and the input was required the default value will be used as the input."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowDefaultValue Default
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Provide a detailed description of the data type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Captures the meta data needed for displaying workflow data types in Intersight User Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowDisplayMeta DisplayMeta
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"JSON formatted mapping from other property of the definition to the current property. Input parameter mapping is supported only for custom data type property in workflow definition and custom data type definition. The format to specify mapping ina workflow definition when source property is of scalar types is '${workflow.input.property}'. The format to specify mapping when the source property is of object reference and mapping needs to be made to the property of the object is '${workflow.input.property.subproperty}'. The format to specify mapping in a custom data type definition is '${datatype.type.property}'. When the current property is of non-scalar type like composite custom data type, then mapping can be provided to the individual property of the custom data type like 'cdt_property:${workflow.input.property}'."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object InputParameters
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Descriptive label for the data type. Label can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), space ( ), forward slash (/) or an underscore (_). The first and last character in label must be an alphanumeric character."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+[\\sa-zA-Z0-9_'.:/-]{1,92}$")]
        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specify the maximum value of the array."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Max
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specify the minimum value of the array."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Min
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Descriptive name for the data type. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-) or an underscore (_). The first and last character in name must be an alphanumeric character."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+([a-zA-Z0-9-_]*[a-zA-Z0-9])*$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowArrayDataType.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specifies whether this parameter is required. The field is applicable for task and workflow."</para>
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
            Intersight.Model.WorkflowArrayDataType initObject = new Intersight.Model.WorkflowArrayDataType();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ArrayItemType"))
            {
                initObject.ArrayItemType = this.ArrayItemType;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Default"))
            {
                initObject.Default = this.Default;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DisplayMeta"))
            {
                initObject.DisplayMeta = this.DisplayMeta;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InputParameters"))
            {
                initObject.InputParameters = this.InputParameters;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Max"))
            {
                initObject.Max = this.Max;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Min"))
            {
                initObject.Min = this.Min;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Required"))
            {
                initObject.Required = this.Required;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowArrayItem.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowArrayItem")]
    public class InitializeIntersightWorkflowArrayItem : PSCmdlet
    {
        public InitializeIntersightWorkflowArrayItem()
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

        public WorkflowArrayItem.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowArrayItem.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowArrayItem initObject = new Intersight.Model.WorkflowArrayItem();
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowAssociatedRoles.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowAssociatedRoles")]
    public class InitializeIntersightWorkflowAssociatedRoles : PSCmdlet
    {
        public InitializeIntersightWorkflowAssociatedRoles()
        {
            ClassId = WorkflowAssociatedRoles.ClassIdEnum.WorkflowAssociatedRoles;
            ObjectType = WorkflowAssociatedRoles.ObjectTypeEnum.WorkflowAssociatedRoles;

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

        public WorkflowAssociatedRoles.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowAssociatedRoles.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowAssociatedRoles initObject = new Intersight.Model.WorkflowAssociatedRoles();
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowBaseDataType.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowBaseDataType")]
    public class InitializeIntersightWorkflowBaseDataType : PSCmdlet
    {
        public InitializeIntersightWorkflowBaseDataType()
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

        public WorkflowBaseDataType.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Default value for the data type. If default value was provided and the input was required the default value will be used as the input."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowDefaultValue Default
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Provide a detailed description of the data type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Captures the meta data needed for displaying workflow data types in Intersight User Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowDisplayMeta DisplayMeta
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"JSON formatted mapping from other property of the definition to the current property. Input parameter mapping is supported only for custom data type property in workflow definition and custom data type definition. The format to specify mapping ina workflow definition when source property is of scalar types is '${workflow.input.property}'. The format to specify mapping when the source property is of object reference and mapping needs to be made to the property of the object is '${workflow.input.property.subproperty}'. The format to specify mapping in a custom data type definition is '${datatype.type.property}'. When the current property is of non-scalar type like composite custom data type, then mapping can be provided to the individual property of the custom data type like 'cdt_property:${workflow.input.property}'."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object InputParameters
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Descriptive label for the data type. Label can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), space ( ), forward slash (/) or an underscore (_). The first and last character in label must be an alphanumeric character."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+[\\sa-zA-Z0-9_'.:/-]{1,92}$")]
        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Descriptive name for the data type. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-) or an underscore (_). The first and last character in name must be an alphanumeric character."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+([a-zA-Z0-9-_]*[a-zA-Z0-9])*$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowBaseDataType.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specifies whether this parameter is required. The field is applicable for task and workflow."</para>
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
            Intersight.Model.WorkflowBaseDataType initObject = new Intersight.Model.WorkflowBaseDataType();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Default"))
            {
                initObject.Default = this.Default;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DisplayMeta"))
            {
                initObject.DisplayMeta = this.DisplayMeta;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InputParameters"))
            {
                initObject.InputParameters = this.InputParameters;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Required"))
            {
                initObject.Required = this.Required;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowBaseOperation.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowBaseOperation")]
    public class InitializeIntersightWorkflowBaseOperation : PSCmdlet
    {
        public InitializeIntersightWorkflowBaseOperation()
        {
            OperationType = WorkflowBaseOperation.OperationTypeEnum.PostDeployment;

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

        public WorkflowBaseOperation.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowBaseOperation.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of action operation to be performed on the service item.\n* `PostDeployment` - This represents the post-deployment actions for the resources created or defined through the deployment action. There can be more than one post-deployment operations associated with a service item.\n* `Deployment` - This represents the deploy action, for the service item action definition. This operation type is used to create or define resources that is managed by the service item. There can only be one Service Item Action Definition that can be marked with the operation type as Deployment and this is a mandatory operation type. All valid Service Items must have one and only one operation type marked as type Deployment.\n* `Decommission` - This represents the decommission action, used to decommission the created resources. All valid Service Items must have one and only one operation type marked as type Decommission. Once a decommission action is run on a Service Item, no further operations are allowed on that Service Item."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowBaseOperation.OperationTypeEnum OperationType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowBaseOperation initObject = new Intersight.Model.WorkflowBaseOperation();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OperationType"))
            {
                initObject.OperationType = this.OperationType;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowBatchApiExecutor.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowBatchApiExecutor")]
    public class InitializeIntersightWorkflowBatchApiExecutor : PSCmdlet
    {
        public InitializeIntersightWorkflowBatchApiExecutor()
        {
            ClassId = WorkflowBatchApiExecutor.ClassIdEnum.WorkflowBatchApiExecutor;
            ObjectType = WorkflowBatchApiExecutor.ObjectTypeEnum.WorkflowBatchApiExecutor;

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

        public List<Model.WorkflowApi> Batch
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.WorkflowApi> CancelAction
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowBatchApiExecutor.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enter the constraints on when this task should match against the task definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowTaskConstraints Constraints
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A detailed description about the batch APIs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a workflowErrorResponseHandler resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowErrorResponseHandlerRelationship ErrorResponseHandler
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
        /// <para type="description">"Name for the batch API task."</para>
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

        public WorkflowBatchApiExecutor.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"All the possible outcomes of this task are captured here. Outcomes property\nis a collection property of type workflow.Outcome objects.\nThe outcomes can be mapped to the message to be shown. The outcomes are\nevaluated in the order they are given. At the end of the outcomes list,\nan catchall success/fail outcome can be added with condition as 'true'.\nThis is an optional\nproperty and if not specified the task will be marked as success."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Outcomes
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Intersight Orchestrator allows the extraction of required values from API\nresponses using the API response grammar. These extracted values can be mapped\nto task output parameters defined in task definition.\nThe mapping of API output parameters to the task output parameters is provided\nas JSON in this property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Output
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When an execution of a nth API in the Batch fails,\nRetry from failed API flag indicates if the execution should start from the nth API or the first API during task retry.\nBy default the value is set to false."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool RetryFromFailedApi
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The skip expression, if provided, allows the batch API executor to skip the\ntask execution when the given expression evaluates to true.\nThe expression is given as such a golang template that has to be\nevaluated to a final content true/false. The expression is an optional and in\ncase not provided, the API will always be executed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SkipOnCondition
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
        /// <para type="description">"A reference to a workflowTaskDefinition resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowTaskDefinitionRelationship TaskDefinition
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This will hold the data needed for task to be rendered in the user interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object UiRenderingData
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowBatchApiExecutor initObject = new Intersight.Model.WorkflowBatchApiExecutor();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Batch"))
            {
                initObject.Batch = this.Batch;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CancelAction"))
            {
                initObject.CancelAction = this.CancelAction;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Constraints"))
            {
                initObject.Constraints = this.Constraints;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ErrorResponseHandler"))
            {
                initObject.ErrorResponseHandler = this.ErrorResponseHandler;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Outcomes"))
            {
                initObject.Outcomes = this.Outcomes;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Output"))
            {
                initObject.Output = this.Output;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RetryFromFailedApi"))
            {
                initObject.RetryFromFailedApi = this.RetryFromFailedApi;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SkipOnCondition"))
            {
                initObject.SkipOnCondition = this.SkipOnCondition;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TaskDefinition"))
            {
                initObject.TaskDefinition = this.TaskDefinition;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UiRenderingData"))
            {
                initObject.UiRenderingData = this.UiRenderingData;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowCancelableType.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowCancelableType")]
    public class InitializeIntersightWorkflowCancelableType : PSCmdlet
    {
        public InitializeIntersightWorkflowCancelableType()
        {
            ClassId = WorkflowCancelableType.ClassIdEnum.WorkflowCancelableType;
            Mode = WorkflowCancelableType.ModeEnum.ApiOnly;
            ObjectType = WorkflowCancelableType.ObjectTypeEnum.WorkflowCancelableType;

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

        public List<string> CancelableStates
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowCancelableType.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When true the workflow can be cancelled. The action can be further restricted by the mode and cancelableStates properties."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Enabled
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Mode controls how the workflow can be canceled.\n* `ApiOnly` - The workflow can only be canceled via API call.\n* `All` - The workflow can be canceled from API or from the user interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowCancelableType.ModeEnum Mode
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowCancelableType.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowCancelableType initObject = new Intersight.Model.WorkflowCancelableType();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CancelableStates"))
            {
                initObject.CancelableStates = this.CancelableStates;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Enabled"))
            {
                initObject.Enabled = this.Enabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Mode"))
            {
                initObject.Mode = this.Mode;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowCatalog.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowCatalog")]
    public class InitializeIntersightWorkflowCatalog : PSCmdlet
    {
        public InitializeIntersightWorkflowCatalog()
        {
            ClassId = WorkflowCatalog.ClassIdEnum.WorkflowCatalog;
            ObjectType = WorkflowCatalog.ObjectTypeEnum.WorkflowCatalog;

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

        public WorkflowCatalog.ClassIdEnum ClassId
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
        /// <para type="description">"A unique name for the catalog."</para>
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

        public WorkflowCatalog.ObjectTypeEnum ObjectType
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

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowCatalog initObject = new Intersight.Model.WorkflowCatalog();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowCatalogItemDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowCatalogItemDefinition")]
    public class InitializeIntersightWorkflowCatalogItemDefinition : PSCmdlet
    {
        public InitializeIntersightWorkflowCatalogItemDefinition()
        {
            ClassId = WorkflowCatalogItemDefinition.ClassIdEnum.WorkflowCatalogItemDefinition;
            ObjectType = WorkflowCatalogItemDefinition.ObjectTypeEnum.WorkflowCatalogItemDefinition;
            PublishStatus = WorkflowCatalogItemDefinition.PublishStatusEnum.Draft;
            SupportStatus = WorkflowCatalogItemDefinition.SupportStatusEnum.Supported;

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

        public WorkflowCatalogItemDefinition.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The description for the catalog item which provides information on what are the pre-requisites to deploy the resource."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user friendly short name to identify the catalog item. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.), colon (:), space ( ) or an underscore (_)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+[\\sa-zA-Z0-9_.:-]{1,92}$")]
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
        /// <para type="description">"The name for this catalog item definition. You can have multiple versions of the catalog item with the same name. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.), colon (:) or an underscore (_)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowCatalogItemDefinition.ObjectTypeEnum ObjectType
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
        /// <para type="description">"Publish status of the catalog item.\n* `Draft` - The enum specifies the option as Draft which means the meta definition is being designed and tested.\n* `Published` - The enum specifies the option as Published which means the meta definition is ready for consumption.\n* `Archived` - The enum specifies the option as Archived which means the meta definition is archived and can no longer be consumed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowCatalogItemDefinition.PublishStatusEnum PublishStatus
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.WorkflowServiceItemType> ServiceItems
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The CatalogItem Support depicts the support status of catalog, the values will be any of Supported or Deprecated state. The user can create a Catalog Service Request if the support status is supported, if its Deprecated then it cannot be instantiated.\n* `Supported` - The definition is a supported version and there will be no changes to the mandatory inputs or outputs.\n* `Beta` - The definition is a Beta version and this version can under go changes until the version is marked supported.\n* `Deprecated` - The version of definition is deprecated and typically there will be a higher version of the same definition that has been added."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowCatalogItemDefinition.SupportStatusEnum SupportStatus
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
        /// <para type="description">"The version of the catalog item to support multiple versions."</para>
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
            Intersight.Model.WorkflowCatalogItemDefinition initObject = new Intersight.Model.WorkflowCatalogItemDefinition();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Organization"))
            {
                initObject.Organization = this.Organization;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PublishStatus"))
            {
                initObject.PublishStatus = this.PublishStatus;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ServiceItems"))
            {
                initObject.ServiceItems = this.ServiceItems;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SupportStatus"))
            {
                initObject.SupportStatus = this.SupportStatus;
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowCatalogServiceRequest.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowCatalogServiceRequest")]
    public class InitializeIntersightWorkflowCatalogServiceRequest : PSCmdlet
    {
        public InitializeIntersightWorkflowCatalogServiceRequest()
        {
            ClassId = WorkflowCatalogServiceRequest.ClassIdEnum.WorkflowCatalogServiceRequest;
            ObjectType = WorkflowCatalogServiceRequest.ObjectTypeEnum.WorkflowCatalogServiceRequest;

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
        /// <para type="description">"A reference to a workflowCatalogItemDefinition resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowCatalogItemDefinitionRelationship CatalogItemDefinition
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowCatalogServiceRequest.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The description for this catalog service request which provides information on request from the user."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamIdp resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamIdpRelationship Idp
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamIdpReference resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamIdpReferenceRelationship IdpReference
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Inputs for a catalog service request instance creation, format is specified by input definition of the catalog item definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Input
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user friendly short name to identify the catalog service request instance. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.), colon (:), space ( ) or an underscore (_)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\sa-zA-Z0-9_.:-]{1,92}$")]
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
        /// <para type="description">"A name of the catalog service request instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+[\\sa-zA-Z0-9_.:-]{1,92}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowCatalogServiceRequest.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Captures the operation to be performed as part of catalog service request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowBaseOperation Operation
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
        /// <para type="description">"A reference to a iamUser resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamUserRelationship User
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowCatalogServiceRequest initObject = new Intersight.Model.WorkflowCatalogServiceRequest();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CatalogItemDefinition"))
            {
                initObject.CatalogItemDefinition = this.CatalogItemDefinition;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Idp"))
            {
                initObject.Idp = this.Idp;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IdpReference"))
            {
                initObject.IdpReference = this.IdpReference;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Input"))
            {
                initObject.Input = this.Input;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Operation"))
            {
                initObject.Operation = this.Operation;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("User"))
            {
                initObject.User = this.User;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowCliCommand.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowCliCommand")]
    public class InitializeIntersightWorkflowCliCommand : PSCmdlet
    {
        public InitializeIntersightWorkflowCliCommand()
        {
            ClassId = WorkflowCliCommand.ClassIdEnum.WorkflowCliCommand;
            ObjectType = WorkflowCliCommand.ObjectTypeEnum.WorkflowCliCommand;
            Type = WorkflowCliCommand.TypeEnum.NonInteractive;

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
        /// <para type="description">"The optional request body that is sent as part of this API request.\nThe request body can contain a golang template that can be populated with task input\nparameters and previous API output parameters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Body
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowCliCommand.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The command to run on the device connector."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Command
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Intersight Orchestrator, with the support of response parser specification,\ncan extract the values from API responses and map them to task output parameters.\nThe value extraction is supported for response content types XML, JSON and Text.\nThe type of the content that gets passed as payload and response in this\nAPI. The supported values are json, xml, text."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ContentType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A description that task designer can add to individual API requests that explain \nwhat the API call is about."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The regex string that identifies the end of the command response."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EndPrompt
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Intersight Orchestrator, with the support of response parser specification,\ncan extract the values from API responses and map them to task output parameters.\nThe value extraction is supported for response content types XML, JSON and Text.\nOptional input to specify the content type in case of error API response. This\nshould be used if the content type of error response is different from that of\nthe success response. If not specified, contentType input value is used to parse\nthe error response."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ErrorContentType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.WorkflowExpectPrompt> ExpectPrompts
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<long> ExpectedExitCodes
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user friendly label that task designers have given to the batch API request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference name for this API request within the batch API request.\nThis name shall be used to map the API output parameters to subsequent\nAPI input parameters within a batch API task."</para>
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

        public WorkflowCliCommand.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"All the possible outcomes of this API are captured here. Outcomes property\nis a collection property of type workflow.Outcome objects.\nThe outcomes can be mapped to the message to be shown. The outcomes are\nevaluated in the order they are given. At the end of the outcomes list,\nan catchall success/fail outcome can be added with condition as 'true'.\nThis is an optional\nproperty and if not specified the task will be marked as success."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Outcomes
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The optional grammar specification for parsing the response to extract the\nrequired values.\nThe specification should have extraction specification specified for\nall the API output parameters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object ResponseSpec
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The skip expression, if provided, allows the batch API executor to skip the\napi execution when the given expression evaluates to true.\nThe expression is given as such a golang template that has to be\nevaluated to a final content true/false. The expression is an optional and in\ncase not provided, the API will always be executed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SkipOnCondition
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Skips the execution status check of the terminal command. One use case for this is while exiting the\nterminal session from esxi host."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool SkipStatusCheck
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The delay in seconds after which the API needs to be executed.\nBy default, the given API is executed immediately. Specifying a start delay adds to the delay to execution.\nStart Delay is not supported for the first API in the Batch and cumulative delay of all the APIs in the Batch should not exceed the task time out."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long StartDelay
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If this flag is set, it marks the end of the terminal session where the previous commands were executed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool TerminalEnd
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If this flag is set, the execution of this command initiates a terminal session in which the subsequent\nCLI commands are executed until a command with terminalEnd flag is encountered or the end of the batch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool TerminalStart
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The duration in seconds by which the API response is expected from the API target.\nIf the end point does not respond for the API request within this timeout\nduration, the task will be marked as failed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Timeout
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of the command - can be interactive or non-interactive.\n* `NonInteractive` - The CLI command is not an interactive command.\n* `Interactive` - The CLI command is executed in interactive mode and the command must provide the expects andanswers."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowCliCommand.TypeEnum Type
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowCliCommand initObject = new Intersight.Model.WorkflowCliCommand();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Body"))
            {
                initObject.Body = this.Body;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Command"))
            {
                initObject.Command = this.Command;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ContentType"))
            {
                initObject.ContentType = this.ContentType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndPrompt"))
            {
                initObject.EndPrompt = this.EndPrompt;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ErrorContentType"))
            {
                initObject.ErrorContentType = this.ErrorContentType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ExpectPrompts"))
            {
                initObject.ExpectPrompts = this.ExpectPrompts;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ExpectedExitCodes"))
            {
                initObject.ExpectedExitCodes = this.ExpectedExitCodes;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Outcomes"))
            {
                initObject.Outcomes = this.Outcomes;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ResponseSpec"))
            {
                initObject.ResponseSpec = this.ResponseSpec;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SkipOnCondition"))
            {
                initObject.SkipOnCondition = this.SkipOnCondition;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SkipStatusCheck"))
            {
                initObject.SkipStatusCheck = this.SkipStatusCheck;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StartDelay"))
            {
                initObject.StartDelay = this.StartDelay;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TerminalEnd"))
            {
                initObject.TerminalEnd = this.TerminalEnd;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TerminalStart"))
            {
                initObject.TerminalStart = this.TerminalStart;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Timeout"))
            {
                initObject.Timeout = this.Timeout;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Type"))
            {
                initObject.Type = this.Type;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowComments.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowComments")]
    public class InitializeIntersightWorkflowComments : PSCmdlet
    {
        public InitializeIntersightWorkflowComments()
        {
            ClassId = WorkflowComments.ClassIdEnum.WorkflowComments;
            ObjectType = WorkflowComments.ObjectTypeEnum.WorkflowComments;

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

        public WorkflowComments.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description field provides comment about the template function."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> Examples
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowComments.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowComments initObject = new Intersight.Model.WorkflowComments();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Examples"))
            {
                initObject.Examples = this.Examples;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowConstraints.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowConstraints")]
    public class InitializeIntersightWorkflowConstraints : PSCmdlet
    {
        public InitializeIntersightWorkflowConstraints()
        {
            ClassId = WorkflowConstraints.ClassIdEnum.WorkflowConstraints;
            ObjectType = WorkflowConstraints.ObjectTypeEnum.WorkflowConstraints;

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

        public WorkflowConstraints.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.WorkflowEnumEntry> EnumList
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Allowed maximum value of the parameter if parameter is integer/float or maximum length of the parameter if the parameter is string. When max and min are set to 0, then the limits are not checked. If parameter is integer/float, then maximum number supported is 1.797693134862315708145274237317043567981e+308 or (2**1023 * (2**53 - 1) / 2**52). When a number bigger than this is given as Maximum value, the constraints will not be enforced."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public double Max
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Allowed minimum value of the parameter if parameter is integer/float or minimum length of the parameter if the parameter is string. When max and min are set to 0, then the limits are not checked. If parameter is integer/float, then minimum number supported is 4.940656458412465441765687928682213723651e-324 or (1 / 2 ** (1023 - 1 + 52)). When a number smaller than this is given as minimum value, the constraints will not be enforced."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public double Min
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowConstraints.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When the parameter is a string this regular expression is used to ensure the value is valid."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Regex
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowConstraints initObject = new Intersight.Model.WorkflowConstraints();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("EnumList"))
            {
                initObject.EnumList = this.EnumList;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Max"))
            {
                initObject.Max = this.Max;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Min"))
            {
                initObject.Min = this.Min;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Regex"))
            {
                initObject.Regex = this.Regex;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowCustomArrayItem.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowCustomArrayItem")]
    public class InitializeIntersightWorkflowCustomArrayItem : PSCmdlet
    {
        public InitializeIntersightWorkflowCustomArrayItem()
        {
            ClassId = WorkflowCustomArrayItem.ClassIdEnum.WorkflowCustomArrayItem;
            ObjectType = WorkflowCustomArrayItem.ObjectTypeEnum.WorkflowCustomArrayItem;

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

        public WorkflowCustomArrayItem.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowCustomArrayItem.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Captures an array item which is of custom data type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowCustomDataProperty Properties
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowCustomArrayItem initObject = new Intersight.Model.WorkflowCustomArrayItem();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Properties"))
            {
                initObject.Properties = this.Properties;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowCustomDataProperty.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowCustomDataProperty")]
    public class InitializeIntersightWorkflowCustomDataProperty : PSCmdlet
    {
        public InitializeIntersightWorkflowCustomDataProperty()
        {
            ClassId = WorkflowCustomDataProperty.ClassIdEnum.WorkflowCustomDataProperty;
            ObjectType = WorkflowCustomDataProperty.ObjectTypeEnum.WorkflowCustomDataProperty;

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
        /// <para type="description">"Specify the catalog moid that this custom data type belongs."</para>
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

        public WorkflowCustomDataProperty.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the custom data type for this input."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string CustomDataTypeName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowCustomDataProperty.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowCustomDataProperty initObject = new Intersight.Model.WorkflowCustomDataProperty();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CatalogMoid"))
            {
                initObject.CatalogMoid = this.CatalogMoid;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CustomDataTypeName"))
            {
                initObject.CustomDataTypeName = this.CustomDataTypeName;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowCustomDataType.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowCustomDataType")]
    public class InitializeIntersightWorkflowCustomDataType : PSCmdlet
    {
        public InitializeIntersightWorkflowCustomDataType()
        {
            ClassId = WorkflowCustomDataType.ClassIdEnum.WorkflowCustomDataType;
            ObjectType = WorkflowCustomDataType.ObjectTypeEnum.WorkflowCustomDataType;

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

        public WorkflowCustomDataType.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Default value for the data type. If default value was provided and the input was required the default value will be used as the input."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowDefaultValue Default
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Provide a detailed description of the data type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Captures the meta data needed for displaying workflow data types in Intersight User Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowDisplayMeta DisplayMeta
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"JSON formatted mapping from other property of the definition to the current property. Input parameter mapping is supported only for custom data type property in workflow definition and custom data type definition. The format to specify mapping ina workflow definition when source property is of scalar types is '${workflow.input.property}'. The format to specify mapping when the source property is of object reference and mapping needs to be made to the property of the object is '${workflow.input.property.subproperty}'. The format to specify mapping in a custom data type definition is '${datatype.type.property}'. When the current property is of non-scalar type like composite custom data type, then mapping can be provided to the individual property of the custom data type like 'cdt_property:${workflow.input.property}'."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object InputParameters
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Descriptive label for the data type. Label can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), space ( ), forward slash (/) or an underscore (_). The first and last character in label must be an alphanumeric character."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+[\\sa-zA-Z0-9_'.:/-]{1,92}$")]
        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Descriptive name for the data type. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-) or an underscore (_). The first and last character in name must be an alphanumeric character."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+([a-zA-Z0-9-_]*[a-zA-Z0-9])*$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowCustomDataType.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Captures the custom data type properties."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowCustomDataProperty Properties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specifies whether this parameter is required. The field is applicable for task and workflow."</para>
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
            Intersight.Model.WorkflowCustomDataType initObject = new Intersight.Model.WorkflowCustomDataType();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Default"))
            {
                initObject.Default = this.Default;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DisplayMeta"))
            {
                initObject.DisplayMeta = this.DisplayMeta;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InputParameters"))
            {
                initObject.InputParameters = this.InputParameters;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Properties"))
            {
                initObject.Properties = this.Properties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Required"))
            {
                initObject.Required = this.Required;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowCustomDataTypeDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowCustomDataTypeDefinition")]
    public class InitializeIntersightWorkflowCustomDataTypeDefinition : PSCmdlet
    {
        public InitializeIntersightWorkflowCustomDataTypeDefinition()
        {
            ClassId = WorkflowCustomDataTypeDefinition.ClassIdEnum.WorkflowCustomDataTypeDefinition;
            ObjectType = WorkflowCustomDataTypeDefinition.ObjectTypeEnum.WorkflowCustomDataTypeDefinition;

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

        public WorkflowCustomDataTypeDefinition.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When true this data type definition is a collection of type definitions to represent composite data like JSON."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool CompositeType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A human-friendly description of this custom data type indicating it's domain and usage."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user friendly short name to identify the custom data type definition. Label can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.), colon (:), space ( ), single quote ('), or an underscore (_) and must be at least 2 characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+[\\sa-zA-Z0-9_'.:-]{1,92}$")]
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
        /// <para type="description">"The name of custom data type definition. The valid name can contain lower case and upper case alphabetic characters, digits and special characters '-' and '_'."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowCustomDataTypeDefinition.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.WorkflowParameterSet> ParameterSet
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type to capture all the properties for the custom data type definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowCustomDataTypeProperties Properties
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.WorkflowBaseDataType> TypeDefinition
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowCustomDataTypeDefinition initObject = new Intersight.Model.WorkflowCustomDataTypeDefinition();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Catalog"))
            {
                initObject.Catalog = this.Catalog;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CompositeType"))
            {
                initObject.CompositeType = this.CompositeType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("ParameterSet"))
            {
                initObject.ParameterSet = this.ParameterSet;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Properties"))
            {
                initObject.Properties = this.Properties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TypeDefinition"))
            {
                initObject.TypeDefinition = this.TypeDefinition;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowCustomDataTypeProperties.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowCustomDataTypeProperties")]
    public class InitializeIntersightWorkflowCustomDataTypeProperties : PSCmdlet
    {
        public InitializeIntersightWorkflowCustomDataTypeProperties()
        {
            ClassId = WorkflowCustomDataTypeProperties.ClassIdEnum.WorkflowCustomDataTypeProperties;
            ObjectType = WorkflowCustomDataTypeProperties.ObjectTypeEnum.WorkflowCustomDataTypeProperties;

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

        public WorkflowCustomDataTypeProperties.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowCustomDataTypeProperties.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowCustomDataTypeProperties initObject = new Intersight.Model.WorkflowCustomDataTypeProperties();
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowDecisionCase.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowDecisionCase")]
    public class InitializeIntersightWorkflowDecisionCase : PSCmdlet
    {
        public InitializeIntersightWorkflowDecisionCase()
        {
            ClassId = WorkflowDecisionCase.ClassIdEnum.WorkflowDecisionCase;
            ObjectType = WorkflowDecisionCase.ObjectTypeEnum.WorkflowDecisionCase;

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

        public WorkflowDecisionCase.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of this decision case."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the next task (Task names unique within workflow) to run.  In a graph model, denotes an edge to another Task Node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string NextTask
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowDecisionCase.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Value for the decision case."</para>
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
            Intersight.Model.WorkflowDecisionCase initObject = new Intersight.Model.WorkflowDecisionCase();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NextTask"))
            {
                initObject.NextTask = this.NextTask;
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowDecisionTask.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowDecisionTask")]
    public class InitializeIntersightWorkflowDecisionTask : PSCmdlet
    {
        public InitializeIntersightWorkflowDecisionTask()
        {
            ClassId = WorkflowDecisionTask.ClassIdEnum.WorkflowDecisionTask;
            ObjectType = WorkflowDecisionTask.ObjectTypeEnum.WorkflowDecisionTask;

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

        public WorkflowDecisionTask.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The condition to evaluate for this decision task. The condition can be a workflow or task variable or an JavaScript expression. Example value for condition could be a variable like \"${task1.output.var1} or ${workflow.input.var2}\" which evaluates to a value matching any of the decision case values. Example value for condition if it's an expression - \"if ( ${task1.output.var1} ! = null && ${task1.output.var1} > 0 ) 'true'; else 'false'; \" which evaluates to 'true' or 'false' and will match one of the decision case values. You can also use JavaScript functions like indexOf, toUpperCase in the expression which will be evaluated by the expression evaluator."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Condition
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.WorkflowDecisionCase> DecisionCases
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The default next Task to execute if the decision cannot be evaluated to any of the DecisionCases."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string DefaultTask
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The description of this task instance in the workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This field is deprecated. Decision case conditions can be added using the workflow input or task output variables in the Condition field. Refer to Condition field for more details."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object InputParameters
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user defined label identifier of the workflow task used for UI display."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the task within the workflow and it must be unique among all WorkflowTasks within a workflow definition. This name serves as the internal unique identifier for the task and is used to pick input and output parameters to feed into other tasks."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowDecisionTask.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowDecisionTask initObject = new Intersight.Model.WorkflowDecisionTask();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Condition"))
            {
                initObject.Condition = this.Condition;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DecisionCases"))
            {
                initObject.DecisionCases = this.DecisionCases;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DefaultTask"))
            {
                initObject.DefaultTask = this.DefaultTask;
            }
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowDefaultValue.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowDefaultValue")]
    public class InitializeIntersightWorkflowDefaultValue : PSCmdlet
    {
        public InitializeIntersightWorkflowDefaultValue()
        {
            ClassId = WorkflowDefaultValue.ClassIdEnum.WorkflowDefaultValue;
            ObjectType = WorkflowDefaultValue.ObjectTypeEnum.WorkflowDefaultValue;

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

        public WorkflowDefaultValue.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowDefaultValue.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Override the default value provided for the data type. When true, allow the user to enter value for the data type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Override
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Default value for the data type. If default value was provided and the input was required the default value will be used as the input."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Value
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowDefaultValue initObject = new Intersight.Model.WorkflowDefaultValue();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Override"))
            {
                initObject.Override = this.Override;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Value"))
            {
                initObject.Value = this.Value;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowDisplayMeta.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowDisplayMeta")]
    public class InitializeIntersightWorkflowDisplayMeta : PSCmdlet
    {
        public InitializeIntersightWorkflowDisplayMeta()
        {
            ClassId = WorkflowDisplayMeta.ClassIdEnum.WorkflowDisplayMeta;
            ObjectType = WorkflowDisplayMeta.ObjectTypeEnum.WorkflowDisplayMeta;
            WidgetType = WorkflowDisplayMeta.WidgetTypeEnum.None;

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

        public WorkflowDisplayMeta.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Inventory selector specified for primitive data property should be used in Intersight User Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool InventorySelector
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowDisplayMeta.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specify the widget type for data display.\n* `None` - Display none of the widget types.\n* `Radio` - Display the widget as a radio button.\n* `Dropdown` - Display the widget as a dropdown.\n* `GridSelector` - Display the widget as a selector.\n* `DrawerSelector` - Display the widget as a selector."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowDisplayMeta.WidgetTypeEnum WidgetType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowDisplayMeta initObject = new Intersight.Model.WorkflowDisplayMeta();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("InventorySelector"))
            {
                initObject.InventorySelector = this.InventorySelector;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("WidgetType"))
            {
                initObject.WidgetType = this.WidgetType;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowDynamicTemplateParserDataType.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowDynamicTemplateParserDataType")]
    public class InitializeIntersightWorkflowDynamicTemplateParserDataType : PSCmdlet
    {
        public InitializeIntersightWorkflowDynamicTemplateParserDataType()
        {
            ClassId = WorkflowDynamicTemplateParserDataType.ClassIdEnum.WorkflowDynamicTemplateParserDataType;
            ObjectType = WorkflowDynamicTemplateParserDataType.ObjectTypeEnum.WorkflowDynamicTemplateParserDataType;
            TemplateType = WorkflowDynamicTemplateParserDataType.TemplateTypeEnum.OsInstall;

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

        public WorkflowDynamicTemplateParserDataType.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Default value for the data type. If default value was provided and the input was required the default value will be used as the input."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowDefaultValue Default
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Provide a detailed description of the data type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Captures the meta data needed for displaying workflow data types in Intersight User Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowDisplayMeta DisplayMeta
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"JSON formatted mapping from other property of the definition to the current property. Input parameter mapping is supported only for custom data type property in workflow definition and custom data type definition. The format to specify mapping ina workflow definition when source property is of scalar types is '${workflow.input.property}'. The format to specify mapping when the source property is of object reference and mapping needs to be made to the property of the object is '${workflow.input.property.subproperty}'. The format to specify mapping in a custom data type definition is '${datatype.type.property}'. When the current property is of non-scalar type like composite custom data type, then mapping can be provided to the individual property of the custom data type like 'cdt_property:${workflow.input.property}'."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object InputParameters
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When set to true, the template is marked as secure and the content is encrypted and stored."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsTemplateSecure
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Descriptive label for the data type. Label can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), space ( ), forward slash (/) or an underscore (_). The first and last character in label must be an alphanumeric character."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+[\\sa-zA-Z0-9_'.:/-]{1,92}$")]
        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Descriptive name for the data type. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-) or an underscore (_). The first and last character in name must be an alphanumeric character."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+([a-zA-Z0-9-_]*[a-zA-Z0-9])*$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowDynamicTemplateParserDataType.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specifies whether this parameter is required. The field is applicable for task and workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Required
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Template type decides on the API to be used to fetch the placeholders present inside the template.\n* `OsInstall` - This refers to the OS configuration template MO."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowDynamicTemplateParserDataType.TemplateTypeEnum TemplateType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowDynamicTemplateParserDataType initObject = new Intersight.Model.WorkflowDynamicTemplateParserDataType();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Default"))
            {
                initObject.Default = this.Default;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DisplayMeta"))
            {
                initObject.DisplayMeta = this.DisplayMeta;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InputParameters"))
            {
                initObject.InputParameters = this.InputParameters;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsTemplateSecure"))
            {
                initObject.IsTemplateSecure = this.IsTemplateSecure;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Required"))
            {
                initObject.Required = this.Required;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TemplateType"))
            {
                initObject.TemplateType = this.TemplateType;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowEnumEntry.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowEnumEntry")]
    public class InitializeIntersightWorkflowEnumEntry : PSCmdlet
    {
        public InitializeIntersightWorkflowEnumEntry()
        {
            ClassId = WorkflowEnumEntry.ClassIdEnum.WorkflowEnumEntry;
            ObjectType = WorkflowEnumEntry.ObjectTypeEnum.WorkflowEnumEntry;

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

        public WorkflowEnumEntry.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Label for the enum value. A user friendly short string to identify the enum value. Label can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.), colon (:), space ( ), single quote ('), forward slash (/), round parenthesis ( () ), or an underscore (_) and must have an alphanumeric character."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+[+\\s\\/a-zA-Z0-9)(_'.:-]{0,92}$")]
        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowEnumEntry.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enum value for this enum entry. Value will be passed to the workflow as string type for execution. Value can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.), colon (:), space ( ), round parenthesis ( () ), forward slash (/), or an underscore (_)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]*[+\\s\\/a-zA-Z0-9)(_.:-]{1,64}$")]
        public string Value
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowEnumEntry initObject = new Intersight.Model.WorkflowEnumEntry();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowEnvironmentVariableReference.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowEnvironmentVariableReference")]
    public class InitializeIntersightWorkflowEnvironmentVariableReference : PSCmdlet
    {
        public InitializeIntersightWorkflowEnvironmentVariableReference()
        {
            ClassId = WorkflowEnvironmentVariableReference.ClassIdEnum.WorkflowEnvironmentVariableReference;
            ObjectType = WorkflowEnvironmentVariableReference.ObjectTypeEnum.WorkflowEnvironmentVariableReference;

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

        public WorkflowEnvironmentVariableReference.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowEnvironmentVariableReference.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowEnvironmentVariableReference initObject = new Intersight.Model.WorkflowEnvironmentVariableReference();
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowErrorResponseHandler.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowErrorResponseHandler")]
    public class InitializeIntersightWorkflowErrorResponseHandler : PSCmdlet
    {
        public InitializeIntersightWorkflowErrorResponseHandler()
        {
            ClassId = WorkflowErrorResponseHandler.ClassIdEnum.WorkflowErrorResponseHandler;
            ObjectType = WorkflowErrorResponseHandler.ObjectTypeEnum.WorkflowErrorResponseHandler;

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

        public WorkflowErrorResponseHandler.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A detailed description about the error response handler."</para>
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
        /// <para type="description">"Name for the error response handler."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowErrorResponseHandler.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.ContentParameter> Parameters
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The platform type for which the error response handler is defined.\n* `` - An unrecognized platform type.\n* `APIC` - A Cisco Application Policy Infrastructure Controller (APIC) cluster.\n* `CAPIC` - A Cisco Cloud Application Policy Infrastructure Controller (Cloud APIC) instance.\n* `DCNM` - A Cisco Data Center Network Manager (DCNM) instance.\n* `UCSFI` - A Cisco UCS Fabric Interconnect that is managed by Cisco UCS Manager (UCSM).\n* `UCSFIISM` - A Cisco UCS Fabric Interconnect that is managed by Cisco Intersight.\n* `IMC` - A standalone Cisco UCS rack server (Deprecated).\n* `IMCM4` - A standalone Cisco UCS C-Series or S-Series M4 server.\n* `IMCM5` - A standalone Cisco UCS C-Series or S-Series M5 server.\n* `IMCRack` - A standalone Cisco UCS C-Series or S-Series M6 or newer server.\n* `UCSIOM` - A Cisco UCS Blade Chassis I/O Module (IOM).\n* `HX` - A Cisco HyperFlex (HX) cluster.\n* `UCSD` - A Cisco UCS Director (UCSD) instance.\n* `IntersightAppliance` - A Cisco Intersight Connected Virtual Appliance instance.\n* `IntersightAssist` - A Cisco Intersight Assist instance.\n* `PureStorageFlashArray` - A Pure Storage FlashArray that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer and storage management features are supported on this device.\n* `NexusDevice` - A Cisco Nexus Network Switch that is managed using Cisco Intersight Assist.\n* `ACISwitch` - A Cisco Nexus Network Switch with the embedded Device Connector and is a part of the Cisco ACI fabric.\n* `NexusSwitch` - A standalone Cisco Nexus Network Switch with the embedded Device Connector.\n* `MDSSwitch` - A Cisco MDS Switch that is managed using the embedded Device Connector.\n* `MDSDevice` - A Cisco MDS Switch that is managed using Cisco Intersight Assist.\n* `UCSC890` - A standalone Cisco UCS C890 server managed using Cisco Intersight Assist.\n* `RedfishServer` - A generic target type for servers that support Redfish APIs and is managed using Cisco Intersight Assist. Support is limited to HPE and Dell Servers.\n* `NetAppOntap` - A Netapp ONTAP Storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `NetAppActiveIqUnifiedManager` - A NetApp Active IQ Unified Manager (AIQUM) that is managed using Cisco Intersight Assist.\n* `EmcScaleIo` - An EMC ScaleIO Software Defined Storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `EmcVmax` - An EMC VMAX 2 or 3 series enterprise storage array that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `EmcVplex` - An EMC VPLEX virtual storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `EmcXtremIo` - An EMC XtremIO SSD storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `VmwareVcenter` - A VMware vCenter instance that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer and Virtualization features are supported on this hypervisor.\n* `MicrosoftHyperV` - A Microsoft Hyper-V host that is managed using Cisco Intersight Assist. Optionally, other hosts in the cluster can be discovered through this host. Cisco Intersight Workload Optimizer features are supported on this hypervisor.\n* `AppDynamics` - An AppDynamics controller running in a SaaS or on-prem datacenter. On-prem AppDynamics instance is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this controller.\n* `Dynatrace` - A Dynatrace Server instance running in a SaaS or on-prem datacenter. On-prem Dynatrace instance is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this server.\n* `NewRelic` - A NewRelic user account. The NewRelic instance monitors the application infrastructure. Cisco Intersight Workload Optimizer features are supported on this server.\n* `ServiceNow` - A cloud-based workflow automation platform that enables enterprise organizations to improve operational efficiencies by streamlining and automating routine work tasks.\n* `Umbrella` - Umbrella cloud target that discovers and monitors an organization. It discovers entities like Datacenters, Devices, Tunnels, Networks, etc.\n* `CloudFoundry` - An open source cloud platform on which developers can build, deploy, run and scale applications.\n* `MicrosoftAzureApplicationInsights` - A feature of Azure Monitor, is an extensible Application Performance Management service for developers and DevOps professionals to monitor their live applications.\n* `OpenStack` - An OpenStack target manages Virtual Machines, Physical Machines, Datacenters and Virtual Datacenters using different OpenStack services as administrative endpoints.\n* `MicrosoftSqlServer` - A Microsoft SQL database server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this database.\n* `MySqlServer` - A MySQL database server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this database.\n* `OracleDatabaseServer` - An Oracle database server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this database.\n* `IBMWebSphereApplicationServer` - An IBM WebSphere Application server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this application server.\n* `OracleWebLogicServer` - Oracle WebLogic Server is a unified and extensible platform for developing, deploying and running enterprise applications, such as Java, for on-premises and in the cloud. WebLogic Server offers a robust, mature, and scalable implementation of Java Enterprise Edition (EE) and Jakarta EE.\n* `ApacheTomcatServer` - An Apache Tomcat server that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this server.\n* `JavaVirtualMachine` - A JVM Application with JMX configured that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this application.\n* `RedHatJBossApplicationServer` - JBoss Application Server is an open-source, cross-platform Java application server developed by JBoss, a division of Red Hat Inc. It is an open-source implementation of Java 2 Enterprise Edition (J2EE) that is used for implementing Java applications and other Web-based applications and software.\n* `Kubernetes` - A Kubernetes cluster that runs containerized applications, with Kubernetes Collector installed. Cisco Intersight Workload Optimizer features are supported on Kubernetes cluster.\n* `AmazonWebService` - An Amazon Web Service cloud account. Cisco Intersight Workload Optimizer and Virtualization features are supported on this cloud.\n* `AmazonWebServiceBilling` - An Amazon Web Service cloud billing account used to retrieve billing information stored in S3 bucket. Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `GoogleCloudPlatform` - A Google Cloud Platform service account with access to one or more projects. Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `GoogleCloudPlatformBilling` - A Google Cloud Platform service account used to retrieve billing information from BigQuery. Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `MicrosoftAzureServicePrincipal` - A Microsoft Azure Service Principal account with access to Azure subscriptions. Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `MicrosoftAzureEnterpriseAgreement` - A Microsoft Azure Enterprise Agreement enrolment used to retrieve pricing and billing information. Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `MicrosoftAzureBilling` - A Microsoft Azure Service Principal account with access to billing information. Cisco Intersight Workload Optimizer features are supported on this cloud.\n* `DellCompellent` - A Dell EMC SC Series (Compellent) storage system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `HPE3Par` - A HPE 3PAR StoreServ system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this device.\n* `RedHatEnterpriseVirtualization` - A Red Hat Enterprise Virtualization Hypervisor system that manages Virtual Machines.\n* `NutanixAcropolis` - A Nutanix Acropolis cluster that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this cluster.\n* `NutanixPrismCentral` - A Nutanix Prism Central cluster. Prism central is a virtual appliance for managing Nutanix clusters and services.\n* `HPEOneView` - A HPE OneView system that is managed using Cisco Intersight Assist. Cisco Intersight Workload Optimizer features are supported on this system.\n* `ServiceEngine` - Cisco Application Services Engine. Cisco Application Services Engine is a platform to deploy and manage applications.\n* `HitachiVirtualStoragePlatform` - A Hitachi Virtual Storage Platform (Hitachi VSP) that is managed using Cisco Intersight Assist.\n* `GenericTarget` - A generic third-party target supported only in Partner Integration Appliance. This target type is used for development purposes and will not be supported in production environment.\n* `IMCBlade` - A Cisco UCS blade server managed by Cisco Intersight.\n* `TerraformCloud` - A Terraform Cloud Business Tier account.\n* `TerraformAgent` - A Terraform Cloud Agent that will be deployed on Cisco Intersight Assist. The agent can be used to plan and apply Terraform runs from a Terraform Cloud workspace.\n* `CustomTarget` - CustomTarget is deprecated. Use HTTPEndpoint type to claim HTTP endpoints.\n* `AnsibleEndpoint` - An external endpoint that is added as a target which can be accessed through Ansible in Intersight Cloud Orchestrator automation workflows.\n* `HTTPEndpoint` - An HTTP endpoint that can be accessed in Intersight Orchestrator workflows directly or using Cisco Intersight Assist. Authentication Schemes supported are Basic and Bearer Token.\n* `SSHEndpoint` - An SSH endpoint that can be accessed in Intersight Orchestrator workflows using Cisco Intersight Assist.\n* `CiscoCatalyst` - A Cisco Catalyst networking switch device.\n* `PowerShellEndpoint` - A Windows operating system server on which PowerShell scripts can be executed using Cisco Intersight Assist.\n* `CiscoDNAC` - A Cisco Digital Network Architecture (DNA) Center appliance.\n* `CiscoFMC` - A Cisco Secure Firewall Management Center.\n* `ViptelaCloud` - A Cisco Viptela SD-WAN Cloud.\n* `MerakiCloud` - A Cisco Meraki Organization.\n* `CiscoISE` - A Cisco Identity Services Engine (ISE) target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowErrorResponseHandler.PlatformTypeEnum PlatformType
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.ContentComplexType> Types
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowErrorResponseHandler initObject = new Intersight.Model.WorkflowErrorResponseHandler();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Catalog"))
            {
                initObject.Catalog = this.Catalog;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Parameters"))
            {
                initObject.Parameters = this.Parameters;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PlatformType"))
            {
                initObject.PlatformType = this.PlatformType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Types"))
            {
                initObject.Types = this.Types;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowExpectPrompt.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowExpectPrompt")]
    public class InitializeIntersightWorkflowExpectPrompt : PSCmdlet
    {
        public InitializeIntersightWorkflowExpectPrompt()
        {
            ClassId = WorkflowExpectPrompt.ClassIdEnum.WorkflowExpectPrompt;
            ObjectType = WorkflowExpectPrompt.ObjectTypeEnum.WorkflowExpectPrompt;

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

        public WorkflowExpectPrompt.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The regex of the expect prompt of the interactive command."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Expect
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowExpectPrompt.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The answer string to the expect prompt."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Send
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowExpectPrompt initObject = new Intersight.Model.WorkflowExpectPrompt();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Expect"))
            {
                initObject.Expect = this.Expect;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Send"))
            {
                initObject.Send = this.Send;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowFailureEndTask.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowFailureEndTask")]
    public class InitializeIntersightWorkflowFailureEndTask : PSCmdlet
    {
        public InitializeIntersightWorkflowFailureEndTask()
        {
            ClassId = WorkflowFailureEndTask.ClassIdEnum.WorkflowFailureEndTask;
            ObjectType = WorkflowFailureEndTask.ObjectTypeEnum.WorkflowFailureEndTask;

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

        public WorkflowFailureEndTask.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The description of this task instance in the workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user defined label identifier of the workflow task used for UI display."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the task within the workflow and it must be unique among all WorkflowTasks within a workflow definition. This name serves as the internal unique identifier for the task and is used to pick input and output parameters to feed into other tasks."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowFailureEndTask.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowFailureEndTask initObject = new Intersight.Model.WorkflowFailureEndTask();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowFileDownloadOp.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowFileDownloadOp")]
    public class InitializeIntersightWorkflowFileDownloadOp : PSCmdlet
    {
        public InitializeIntersightWorkflowFileDownloadOp()
        {
            ClassId = WorkflowFileDownloadOp.ClassIdEnum.WorkflowFileDownloadOp;
            ObjectType = WorkflowFileDownloadOp.ObjectTypeEnum.WorkflowFileDownloadOp;

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

        public WorkflowFileDownloadOp.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Path on the Intersight connected device to which file needs to be downloaded."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string DestinationPath
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowFileDownloadOp.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Source bucket name hosting the file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SourceBucket
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the file to be downloaded from bucket to endpoint devices."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SourceFile
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowFileDownloadOp initObject = new Intersight.Model.WorkflowFileDownloadOp();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DestinationPath"))
            {
                initObject.DestinationPath = this.DestinationPath;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SourceBucket"))
            {
                initObject.SourceBucket = this.SourceBucket;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SourceFile"))
            {
                initObject.SourceFile = this.SourceFile;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowFileOperations.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowFileOperations")]
    public class InitializeIntersightWorkflowFileOperations : PSCmdlet
    {
        public InitializeIntersightWorkflowFileOperations()
        {
            ClassId = WorkflowFileOperations.ClassIdEnum.WorkflowFileOperations;
            ObjectType = WorkflowFileOperations.ObjectTypeEnum.WorkflowFileOperations;
            OperationType = WorkflowFileOperations.OperationTypeEnum.FileDownload;

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
        /// <para type="description">"The optional request body that is sent as part of this API request.\nThe request body can contain a golang template that can be populated with task input\nparameters and previous API output parameters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Body
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowFileOperations.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Intersight Orchestrator, with the support of response parser specification,\ncan extract the values from API responses and map them to task output parameters.\nThe value extraction is supported for response content types XML, JSON and Text.\nThe type of the content that gets passed as payload and response in this\nAPI. The supported values are json, xml, text."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ContentType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A description that task designer can add to individual API requests that explain \nwhat the API call is about."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Intersight Orchestrator, with the support of response parser specification,\ncan extract the values from API responses and map them to task output parameters.\nThe value extraction is supported for response content types XML, JSON and Text.\nOptional input to specify the content type in case of error API response. This\nshould be used if the content type of error response is different from that of\nthe success response. If not specified, contentType input value is used to parse\nthe error response."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ErrorContentType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"File operation to download a given file from Intersight storage services such as\nAWS or Minio bucket to a specified path on one or more Intersight connected devices."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowFileDownloadOp FileDownload
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Populates data driven template file with input values to generate textual output."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowFileTemplateOp FileTemplate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user friendly label that task designers have given to the batch API request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference name for this API request within the batch API request.\nThis name shall be used to map the API output parameters to subsequent\nAPI input parameters within a batch API task."</para>
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

        public WorkflowFileOperations.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"File operation type to be executed on the connected endpoint.\n* `FileDownload` - The API is executed in a remote device connected to the Intersightthrough its device connector. This operation is to download the filefrom specified storage bucket to the specific path on the device.\n* `FileTemplatize` - Populates data driven template file with input values to generate textual output.Inputs - the path of the template file on the device and json values to populate.An error will be returned if the file does not exists or if there is an error whileexecuting the template."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowFileOperations.OperationTypeEnum OperationType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"All the possible outcomes of this API are captured here. Outcomes property\nis a collection property of type workflow.Outcome objects.\nThe outcomes can be mapped to the message to be shown. The outcomes are\nevaluated in the order they are given. At the end of the outcomes list,\nan catchall success/fail outcome can be added with condition as 'true'.\nThis is an optional\nproperty and if not specified the task will be marked as success."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Outcomes
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The optional grammar specification for parsing the response to extract the\nrequired values.\nThe specification should have extraction specification specified for\nall the API output parameters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object ResponseSpec
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The skip expression, if provided, allows the batch API executor to skip the\napi execution when the given expression evaluates to true.\nThe expression is given as such a golang template that has to be\nevaluated to a final content true/false. The expression is an optional and in\ncase not provided, the API will always be executed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SkipOnCondition
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The delay in seconds after which the API needs to be executed.\nBy default, the given API is executed immediately. Specifying a start delay adds to the delay to execution.\nStart Delay is not supported for the first API in the Batch and cumulative delay of all the APIs in the Batch should not exceed the task time out."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long StartDelay
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The duration in seconds by which the API response is expected from the API target.\nIf the end point does not respond for the API request within this timeout\nduration, the task will be marked as failed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Timeout
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowFileOperations initObject = new Intersight.Model.WorkflowFileOperations();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Body"))
            {
                initObject.Body = this.Body;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ContentType"))
            {
                initObject.ContentType = this.ContentType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ErrorContentType"))
            {
                initObject.ErrorContentType = this.ErrorContentType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FileDownload"))
            {
                initObject.FileDownload = this.FileDownload;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FileTemplate"))
            {
                initObject.FileTemplate = this.FileTemplate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Outcomes"))
            {
                initObject.Outcomes = this.Outcomes;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ResponseSpec"))
            {
                initObject.ResponseSpec = this.ResponseSpec;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SkipOnCondition"))
            {
                initObject.SkipOnCondition = this.SkipOnCondition;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StartDelay"))
            {
                initObject.StartDelay = this.StartDelay;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Timeout"))
            {
                initObject.Timeout = this.Timeout;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowFileTemplateOp.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowFileTemplateOp")]
    public class InitializeIntersightWorkflowFileTemplateOp : PSCmdlet
    {
        public InitializeIntersightWorkflowFileTemplateOp()
        {
            ClassId = WorkflowFileTemplateOp.ClassIdEnum.WorkflowFileTemplateOp;
            ObjectType = WorkflowFileTemplateOp.ObjectTypeEnum.WorkflowFileTemplateOp;

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

        public WorkflowFileTemplateOp.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowFileTemplateOp.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Path of the template file on the connected device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string TemplateFilePath
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Input values to render text output file from template file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object TemplateValues
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowFileTemplateOp initObject = new Intersight.Model.WorkflowFileTemplateOp();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("TemplateFilePath"))
            {
                initObject.TemplateFilePath = this.TemplateFilePath;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TemplateValues"))
            {
                initObject.TemplateValues = this.TemplateValues;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowFileTransfer.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowFileTransfer")]
    public class InitializeIntersightWorkflowFileTransfer : PSCmdlet
    {
        public InitializeIntersightWorkflowFileTransfer()
        {
            ClassId = WorkflowFileTransfer.ClassIdEnum.WorkflowFileTransfer;
            ObjectType = WorkflowFileTransfer.ObjectTypeEnum.WorkflowFileTransfer;

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

        public WorkflowFileTransfer.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Destination file path on the target server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string DestinationFilePath
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The secure properties that have large text content as value can be encrypted using AES key. In these cases, the AES key needs to be encrypted using the device connector's public key and passed as the value for this property.\nThe secure properties that are encrypted using the AES key are mapped against the property name with prefix 'AES' in SecureProperties dictionary."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EncryptedAesKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The public key that was used to encrypt the values present in SecureProperties dictionary.\nIf the given public key is not the same as device connector's public key, an error response with appropriate error message is thrown back."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EncryptionKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"File permission to set on the transferred file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long FileMode
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowFileTransfer.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A dictionary of encrypted secure values mapped against the secure property name. The values that are encrypted using the AES key must be mapped against the secure property name with an 'AES' prefix\nDevice connector expects the message body to be a golang template and the template can use the secure property names as placeholders."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object SecureProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Source file path on the Intersight connected device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SourceFilePath
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowFileTransfer initObject = new Intersight.Model.WorkflowFileTransfer();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DestinationFilePath"))
            {
                initObject.DestinationFilePath = this.DestinationFilePath;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EncryptedAesKey"))
            {
                initObject.EncryptedAesKey = this.EncryptedAesKey;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EncryptionKey"))
            {
                initObject.EncryptionKey = this.EncryptionKey;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FileMode"))
            {
                initObject.FileMode = this.FileMode;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SecureProperties"))
            {
                initObject.SecureProperties = this.SecureProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SourceFilePath"))
            {
                initObject.SourceFilePath = this.SourceFilePath;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowForkTask.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowForkTask")]
    public class InitializeIntersightWorkflowForkTask : PSCmdlet
    {
        public InitializeIntersightWorkflowForkTask()
        {
            ClassId = WorkflowForkTask.ClassIdEnum.WorkflowForkTask;
            ObjectType = WorkflowForkTask.ObjectTypeEnum.WorkflowForkTask;

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

        public WorkflowForkTask.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The description of this task instance in the workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> ForkedTasks
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Task name for the join control task that must follow a fork control task."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string JoinTask
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user defined label identifier of the workflow task used for UI display."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the task within the workflow and it must be unique among all WorkflowTasks within a workflow definition. This name serves as the internal unique identifier for the task and is used to pick input and output parameters to feed into other tasks."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowForkTask.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowForkTask initObject = new Intersight.Model.WorkflowForkTask();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ForkedTasks"))
            {
                initObject.ForkedTasks = this.ForkedTasks;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("JoinTask"))
            {
                initObject.JoinTask = this.JoinTask;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowInitiatorContext.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowInitiatorContext")]
    public class InitializeIntersightWorkflowInitiatorContext : PSCmdlet
    {
        public InitializeIntersightWorkflowInitiatorContext()
        {
            ClassId = WorkflowInitiatorContext.ClassIdEnum.WorkflowInitiatorContext;
            ObjectType = WorkflowInitiatorContext.ObjectTypeEnum.WorkflowInitiatorContext;

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

        public WorkflowInitiatorContext.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The moid of the Intersight managed object that initiated the workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string InitiatorMoid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the initiator who started the workflow. The initiator can be Intersight managed object that triggered the workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string InitiatorName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of Intersight managed object that initiated the workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string InitiatorType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowInitiatorContext.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowInitiatorContext initObject = new Intersight.Model.WorkflowInitiatorContext();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("InitiatorMoid"))
            {
                initObject.InitiatorMoid = this.InitiatorMoid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InitiatorName"))
            {
                initObject.InitiatorName = this.InitiatorName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InitiatorType"))
            {
                initObject.InitiatorType = this.InitiatorType;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowInternalProperties.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowInternalProperties")]
    public class InitializeIntersightWorkflowInternalProperties : PSCmdlet
    {
        public InitializeIntersightWorkflowInternalProperties()
        {
            ClassId = WorkflowInternalProperties.ClassIdEnum.WorkflowInternalProperties;
            ObjectType = WorkflowInternalProperties.ObjectTypeEnum.WorkflowInternalProperties;

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

        public WorkflowInternalProperties.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowInternalProperties.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowInternalProperties initObject = new Intersight.Model.WorkflowInternalProperties();
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowJoinTask.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowJoinTask")]
    public class InitializeIntersightWorkflowJoinTask : PSCmdlet
    {
        public InitializeIntersightWorkflowJoinTask()
        {
            ClassId = WorkflowJoinTask.ClassIdEnum.WorkflowJoinTask;
            ObjectType = WorkflowJoinTask.ObjectTypeEnum.WorkflowJoinTask;

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

        public WorkflowJoinTask.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The description of this task instance in the workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user defined label identifier of the workflow task used for UI display."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the task within the workflow and it must be unique among all WorkflowTasks within a workflow definition. This name serves as the internal unique identifier for the task and is used to pick input and output parameters to feed into other tasks."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowJoinTask.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the next task to run if all fork path specified in the JoinOnTasks list succeeds which is the unique name given to the task instance within the workflow. In a graph model, denotes an edge to another Task Node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string OnSuccess
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowJoinTask initObject = new Intersight.Model.WorkflowJoinTask();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OnSuccess"))
            {
                initObject.OnSuccess = this.OnSuccess;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowLoopTask.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowLoopTask")]
    public class InitializeIntersightWorkflowLoopTask : PSCmdlet
    {
        public InitializeIntersightWorkflowLoopTask()
        {
            ClassId = WorkflowLoopTask.ClassIdEnum.WorkflowLoopTask;
            FailurePolicy = WorkflowLoopTask.FailurePolicyEnum.FailOnFirstFailure;
            ObjectType = WorkflowLoopTask.ObjectTypeEnum.WorkflowLoopTask;

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

        public WorkflowLoopTask.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Count value for the loop, this can be a static value defined as a constant at design time or can be a dynamic value defined as an expression that will evaluate to an integer value at execution time. Dynamic values for count must be specified as a template. For example, if a loop must run for a count which matches the length of a workflow input called StringArray, then the count must be specified using a template '{{ len .global.workflow.input.StringArray }}'. The count must be less than or equal to 100. If count is given as a dynamic value, and during execution time if count evaluates to be a value greater than 100, then the loop task will fail."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Count
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The description of this task instance in the workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The policy to handle the failure of an iteration within a parallel loop.\n* `FailOnFirstFailure` - The enum specifies the option as FailOnFirstFailure where the loop task will fail if one of the iteration in the loop fails. The running iterations will be cancelled on first failure and the loop will be marked as failed.\n* `ContinueOnFailure` - The enum specifies the option as ContinueOnFailure where the loop task will continue with all iterations, even if one fails. Running iterations will not be canceled, but the loop will be marked as failed after all iterations are complete."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowLoopTask.FailurePolicyEnum FailurePolicy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user defined label identifier of the workflow task used for UI display."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Start task where the list of tasks will be executed multiple times based on the count or condition value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string LoopStartTask
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the task within the workflow and it must be unique among all WorkflowTasks within a workflow definition. This name serves as the internal unique identifier for the task and is used to pick input and output parameters to feed into other tasks."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"All iterations of the loop run in parallel within a single batch, with a maximum of 100 iterations. To run more than 100 iterations, you can increase the number of batches. The configuration is acceptable as long as the total number of iterations divided by the number of batches is less than 100. Adjusting the number of batches also allows you to control how many iterations run in parallel. For example, if the total count is 100 and you set the number of batches to 5, then 20 tasks will run in parallel across the 5 batches. It's important to note that the number of batches must be less than the total count. If the count is dynamic and falls below the number of batches, this may result in empty batches with no tasks."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long NumberOfBatches
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowLoopTask.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This specifies the name of the next task to run if all iterations of the loop task do not succeed. The unique name given to the task instance within the workflow must be provided here. In a graph model, denotes an edge to another Task Node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string OnFailure
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This specifies the name of the next task to run if all iterations of the loop task succeeds. The unique name given to the task instance within the workflow must be provided here. In a graph model, denotes an edge to another Task Node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string OnSuccess
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This field is deprecated. Always set to true for parallel loop."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Parallel
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowLoopTask initObject = new Intersight.Model.WorkflowLoopTask();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Count"))
            {
                initObject.Count = this.Count;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FailurePolicy"))
            {
                initObject.FailurePolicy = this.FailurePolicy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LoopStartTask"))
            {
                initObject.LoopStartTask = this.LoopStartTask;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumberOfBatches"))
            {
                initObject.NumberOfBatches = this.NumberOfBatches;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OnFailure"))
            {
                initObject.OnFailure = this.OnFailure;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("OnSuccess"))
            {
                initObject.OnSuccess = this.OnSuccess;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Parallel"))
            {
                initObject.Parallel = this.Parallel;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowMessage.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowMessage")]
    public class InitializeIntersightWorkflowMessage : PSCmdlet
    {
        public InitializeIntersightWorkflowMessage()
        {
            ClassId = WorkflowMessage.ClassIdEnum.WorkflowMessage;
            ObjectType = WorkflowMessage.ObjectTypeEnum.WorkflowMessage;

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

        public WorkflowMessage.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowMessage.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowMessage initObject = new Intersight.Model.WorkflowMessage();
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowMoInventoryDataType.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowMoInventoryDataType")]
    public class InitializeIntersightWorkflowMoInventoryDataType : PSCmdlet
    {
        public InitializeIntersightWorkflowMoInventoryDataType()
        {
            ClassId = WorkflowMoInventoryDataType.ClassIdEnum.WorkflowMoInventoryDataType;
            ObjectType = WorkflowMoInventoryDataType.ObjectTypeEnum.WorkflowMoInventoryDataType;

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

        public WorkflowMoInventoryDataType.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Default value for the data type. If default value was provided and the input was required the default value will be used as the input."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowDefaultValue Default
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Provide a detailed description of the data type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Captures the meta data needed for displaying workflow data types in Intersight User Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowDisplayMeta DisplayMeta
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"JSON formatted mapping from other property of the definition to the current property. Input parameter mapping is supported only for custom data type property in workflow definition and custom data type definition. The format to specify mapping ina workflow definition when source property is of scalar types is '${workflow.input.property}'. The format to specify mapping when the source property is of object reference and mapping needs to be made to the property of the object is '${workflow.input.property.subproperty}'. The format to specify mapping in a custom data type definition is '${datatype.type.property}'. When the current property is of non-scalar type like composite custom data type, then mapping can be provided to the individual property of the custom data type like 'cdt_property:${workflow.input.property}'."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object InputParameters
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Descriptive label for the data type. Label can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), space ( ), forward slash (/) or an underscore (_). The first and last character in label must be an alphanumeric character."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+[\\sa-zA-Z0-9_'.:/-]{1,92}$")]
        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Descriptive name for the data type. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-) or an underscore (_). The first and last character in name must be an alphanumeric character."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+([a-zA-Z0-9-_]*[a-zA-Z0-9])*$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowMoInventoryDataType.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.WorkflowMoInventoryProperty> Properties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specifies whether this parameter is required. The field is applicable for task and workflow."</para>
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
            Intersight.Model.WorkflowMoInventoryDataType initObject = new Intersight.Model.WorkflowMoInventoryDataType();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Default"))
            {
                initObject.Default = this.Default;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DisplayMeta"))
            {
                initObject.DisplayMeta = this.DisplayMeta;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InputParameters"))
            {
                initObject.InputParameters = this.InputParameters;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Properties"))
            {
                initObject.Properties = this.Properties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Required"))
            {
                initObject.Required = this.Required;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowMoInventoryProperty.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowMoInventoryProperty")]
    public class InitializeIntersightWorkflowMoInventoryProperty : PSCmdlet
    {
        public InitializeIntersightWorkflowMoInventoryProperty()
        {
            ClassId = WorkflowMoInventoryProperty.ClassIdEnum.WorkflowMoInventoryProperty;
            ObjectType = WorkflowMoInventoryProperty.ObjectTypeEnum.WorkflowMoInventoryProperty;
            ReferenceType = WorkflowMoInventoryProperty.ReferenceTypeEnum.Moid;

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

        public List<string> Attributes
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowMoInventoryProperty.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowMoInventoryProperty.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"ObjectType for which the attributes need to be collected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ReferenceObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Defines how the reference to the shadow resource is done. Base case is via an Moid, but reference via a selector is also possible.\n* `Moid` - The reference to the original resource is via an Moid.\n* `Selector` - The reference to the original resource is via a selector query. This can potentially lead to tracking data for multiple resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowMoInventoryProperty.ReferenceTypeEnum ReferenceType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowMoInventoryProperty initObject = new Intersight.Model.WorkflowMoInventoryProperty();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Attributes"))
            {
                initObject.Attributes = this.Attributes;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ReferenceObjectType"))
            {
                initObject.ReferenceObjectType = this.ReferenceObjectType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ReferenceType"))
            {
                initObject.ReferenceType = this.ReferenceType;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowMoReferenceArrayItem.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowMoReferenceArrayItem")]
    public class InitializeIntersightWorkflowMoReferenceArrayItem : PSCmdlet
    {
        public InitializeIntersightWorkflowMoReferenceArrayItem()
        {
            ClassId = WorkflowMoReferenceArrayItem.ClassIdEnum.WorkflowMoReferenceArrayItem;
            ObjectType = WorkflowMoReferenceArrayItem.ObjectTypeEnum.WorkflowMoReferenceArrayItem;

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

        public WorkflowMoReferenceArrayItem.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowMoReferenceArrayItem.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.WorkflowMoReferenceProperty> Properties
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowMoReferenceArrayItem initObject = new Intersight.Model.WorkflowMoReferenceArrayItem();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Properties"))
            {
                initObject.Properties = this.Properties;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowMoReferenceAutoArrayItem.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowMoReferenceAutoArrayItem")]
    public class InitializeIntersightWorkflowMoReferenceAutoArrayItem : PSCmdlet
    {
        public InitializeIntersightWorkflowMoReferenceAutoArrayItem()
        {
            ClassId = WorkflowMoReferenceAutoArrayItem.ClassIdEnum.WorkflowMoReferenceAutoArrayItem;
            ObjectType = WorkflowMoReferenceAutoArrayItem.ObjectTypeEnum.WorkflowMoReferenceAutoArrayItem;

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

        public WorkflowMoReferenceAutoArrayItem.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowMoReferenceAutoArrayItem.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.WorkflowMoReferenceAutoProperty> Properties
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowMoReferenceAutoArrayItem initObject = new Intersight.Model.WorkflowMoReferenceAutoArrayItem();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Properties"))
            {
                initObject.Properties = this.Properties;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowMoReferenceAutoDataType.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowMoReferenceAutoDataType")]
    public class InitializeIntersightWorkflowMoReferenceAutoDataType : PSCmdlet
    {
        public InitializeIntersightWorkflowMoReferenceAutoDataType()
        {
            ClassId = WorkflowMoReferenceAutoDataType.ClassIdEnum.WorkflowMoReferenceAutoDataType;
            ObjectType = WorkflowMoReferenceAutoDataType.ObjectTypeEnum.WorkflowMoReferenceAutoDataType;

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

        public WorkflowMoReferenceAutoDataType.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Default value for the data type. If default value was provided and the input was required the default value will be used as the input."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowDefaultValue Default
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Provide a detailed description of the data type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Captures the meta data needed for displaying workflow data types in Intersight User Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowDisplayMeta DisplayMeta
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"JSON formatted mapping from other property of the definition to the current property. Input parameter mapping is supported only for custom data type property in workflow definition and custom data type definition. The format to specify mapping ina workflow definition when source property is of scalar types is '${workflow.input.property}'. The format to specify mapping when the source property is of object reference and mapping needs to be made to the property of the object is '${workflow.input.property.subproperty}'. The format to specify mapping in a custom data type definition is '${datatype.type.property}'. When the current property is of non-scalar type like composite custom data type, then mapping can be provided to the individual property of the custom data type like 'cdt_property:${workflow.input.property}'."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object InputParameters
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Descriptive label for the data type. Label can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), space ( ), forward slash (/) or an underscore (_). The first and last character in label must be an alphanumeric character."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+[\\sa-zA-Z0-9_'.:/-]{1,92}$")]
        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Descriptive name for the data type. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-) or an underscore (_). The first and last character in name must be an alphanumeric character."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+([a-zA-Z0-9-_]*[a-zA-Z0-9])*$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowMoReferenceAutoDataType.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.WorkflowMoReferenceAutoProperty> Properties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specifies whether this parameter is required. The field is applicable for task and workflow."</para>
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
            Intersight.Model.WorkflowMoReferenceAutoDataType initObject = new Intersight.Model.WorkflowMoReferenceAutoDataType();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Default"))
            {
                initObject.Default = this.Default;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DisplayMeta"))
            {
                initObject.DisplayMeta = this.DisplayMeta;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InputParameters"))
            {
                initObject.InputParameters = this.InputParameters;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Properties"))
            {
                initObject.Properties = this.Properties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Required"))
            {
                initObject.Required = this.Required;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowMoReferenceAutoProperty.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowMoReferenceAutoProperty")]
    public class InitializeIntersightWorkflowMoReferenceAutoProperty : PSCmdlet
    {
        public InitializeIntersightWorkflowMoReferenceAutoProperty()
        {
            ClassId = WorkflowMoReferenceAutoProperty.ClassIdEnum.WorkflowMoReferenceAutoProperty;
            ObjectType = WorkflowMoReferenceAutoProperty.ObjectTypeEnum.WorkflowMoReferenceAutoProperty;

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

        public WorkflowMoReferenceAutoProperty.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> DisplayAttributes
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> Filters
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowMoReferenceAutoProperty.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Determines  properties that are used to sort the collection of resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string OrderBy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The rule can be obtained directly from a Resource Selection Criteria or provided as inline resource filter conditions."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowAbstractResourceSelector Rule
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowMoReferenceAutoProperty initObject = new Intersight.Model.WorkflowMoReferenceAutoProperty();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DisplayAttributes"))
            {
                initObject.DisplayAttributes = this.DisplayAttributes;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Filters"))
            {
                initObject.Filters = this.Filters;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OrderBy"))
            {
                initObject.OrderBy = this.OrderBy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Rule"))
            {
                initObject.Rule = this.Rule;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowMoReferenceDataType.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowMoReferenceDataType")]
    public class InitializeIntersightWorkflowMoReferenceDataType : PSCmdlet
    {
        public InitializeIntersightWorkflowMoReferenceDataType()
        {
            ClassId = WorkflowMoReferenceDataType.ClassIdEnum.WorkflowMoReferenceDataType;
            ObjectType = WorkflowMoReferenceDataType.ObjectTypeEnum.WorkflowMoReferenceDataType;

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

        public WorkflowMoReferenceDataType.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Default value for the data type. If default value was provided and the input was required the default value will be used as the input."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowDefaultValue Default
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Provide a detailed description of the data type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Captures the meta data needed for displaying workflow data types in Intersight User Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowDisplayMeta DisplayMeta
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"JSON formatted mapping from other property of the definition to the current property. Input parameter mapping is supported only for custom data type property in workflow definition and custom data type definition. The format to specify mapping ina workflow definition when source property is of scalar types is '${workflow.input.property}'. The format to specify mapping when the source property is of object reference and mapping needs to be made to the property of the object is '${workflow.input.property.subproperty}'. The format to specify mapping in a custom data type definition is '${datatype.type.property}'. When the current property is of non-scalar type like composite custom data type, then mapping can be provided to the individual property of the custom data type like 'cdt_property:${workflow.input.property}'."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object InputParameters
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Descriptive label for the data type. Label can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), space ( ), forward slash (/) or an underscore (_). The first and last character in label must be an alphanumeric character."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+[\\sa-zA-Z0-9_'.:/-]{1,92}$")]
        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Descriptive name for the data type. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-) or an underscore (_). The first and last character in name must be an alphanumeric character."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+([a-zA-Z0-9-_]*[a-zA-Z0-9])*$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowMoReferenceDataType.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.WorkflowMoReferenceProperty> Properties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specifies whether this parameter is required. The field is applicable for task and workflow."</para>
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
            Intersight.Model.WorkflowMoReferenceDataType initObject = new Intersight.Model.WorkflowMoReferenceDataType();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Default"))
            {
                initObject.Default = this.Default;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DisplayMeta"))
            {
                initObject.DisplayMeta = this.DisplayMeta;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InputParameters"))
            {
                initObject.InputParameters = this.InputParameters;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Properties"))
            {
                initObject.Properties = this.Properties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Required"))
            {
                initObject.Required = this.Required;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowMoReferenceProperty.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowMoReferenceProperty")]
    public class InitializeIntersightWorkflowMoReferenceProperty : PSCmdlet
    {
        public InitializeIntersightWorkflowMoReferenceProperty()
        {
            ClassId = WorkflowMoReferenceProperty.ClassIdEnum.WorkflowMoReferenceProperty;
            ObjectType = WorkflowMoReferenceProperty.ObjectTypeEnum.WorkflowMoReferenceProperty;

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

        public WorkflowMoReferenceProperty.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> DisplayAttributes
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowMoReferenceProperty.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Field to hold an Intersight API along with an optional filter to narrow down the search options."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|/api/v1/.*")]
        public string Selector
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Selector properties to define HTTP method and 'body' in case of upsert operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowSelectorProperty SelectorProperty
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A property from the Intersight object, value of which can be used as value for referenced input definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ValueAttribute
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowMoReferenceProperty initObject = new Intersight.Model.WorkflowMoReferenceProperty();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DisplayAttributes"))
            {
                initObject.DisplayAttributes = this.DisplayAttributes;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Selector"))
            {
                initObject.Selector = this.Selector;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SelectorProperty"))
            {
                initObject.SelectorProperty = this.SelectorProperty;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ValueAttribute"))
            {
                initObject.ValueAttribute = this.ValueAttribute;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowOperationTypeDecommission.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowOperationTypeDecommission")]
    public class InitializeIntersightWorkflowOperationTypeDecommission : PSCmdlet
    {
        public InitializeIntersightWorkflowOperationTypeDecommission()
        {
            ClassId = WorkflowOperationTypeDecommission.ClassIdEnum.WorkflowOperationTypeDecommission;
            ObjectType = WorkflowOperationTypeDecommission.ObjectTypeEnum.WorkflowOperationTypeDecommission;
            OperationType = WorkflowOperationTypeDecommission.OperationTypeEnum.PostDeployment;

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

        public WorkflowOperationTypeDecommission.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowOperationTypeDecommission.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of action operation to be performed on the service item.\n* `PostDeployment` - This represents the post-deployment actions for the resources created or defined through the deployment action. There can be more than one post-deployment operations associated with a service item.\n* `Deployment` - This represents the deploy action, for the service item action definition. This operation type is used to create or define resources that is managed by the service item. There can only be one Service Item Action Definition that can be marked with the operation type as Deployment and this is a mandatory operation type. All valid Service Items must have one and only one operation type marked as type Deployment.\n* `Decommission` - This represents the decommission action, used to decommission the created resources. All valid Service Items must have one and only one operation type marked as type Decommission. Once a decommission action is run on a Service Item, no further operations are allowed on that Service Item."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowOperationTypeDecommission.OperationTypeEnum OperationType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specify the service item instance to issue decommission action."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.MoMoRef ServiceItemInstance
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowOperationTypeDecommission initObject = new Intersight.Model.WorkflowOperationTypeDecommission();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OperationType"))
            {
                initObject.OperationType = this.OperationType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ServiceItemInstance"))
            {
                initObject.ServiceItemInstance = this.ServiceItemInstance;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowOperationTypeDeployment.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowOperationTypeDeployment")]
    public class InitializeIntersightWorkflowOperationTypeDeployment : PSCmdlet
    {
        public InitializeIntersightWorkflowOperationTypeDeployment()
        {
            ClassId = WorkflowOperationTypeDeployment.ClassIdEnum.WorkflowOperationTypeDeployment;
            ObjectType = WorkflowOperationTypeDeployment.ObjectTypeEnum.WorkflowOperationTypeDeployment;
            OperationType = WorkflowOperationTypeDeployment.OperationTypeEnum.PostDeployment;

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

        public WorkflowOperationTypeDeployment.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowOperationTypeDeployment.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of action operation to be performed on the service item.\n* `PostDeployment` - This represents the post-deployment actions for the resources created or defined through the deployment action. There can be more than one post-deployment operations associated with a service item.\n* `Deployment` - This represents the deploy action, for the service item action definition. This operation type is used to create or define resources that is managed by the service item. There can only be one Service Item Action Definition that can be marked with the operation type as Deployment and this is a mandatory operation type. All valid Service Items must have one and only one operation type marked as type Deployment.\n* `Decommission` - This represents the decommission action, used to decommission the created resources. All valid Service Items must have one and only one operation type marked as type Decommission. Once a decommission action is run on a Service Item, no further operations are allowed on that Service Item."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowOperationTypeDeployment.OperationTypeEnum OperationType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowOperationTypeDeployment initObject = new Intersight.Model.WorkflowOperationTypeDeployment();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OperationType"))
            {
                initObject.OperationType = this.OperationType;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowOperationTypePostDeployment.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowOperationTypePostDeployment")]
    public class InitializeIntersightWorkflowOperationTypePostDeployment : PSCmdlet
    {
        public InitializeIntersightWorkflowOperationTypePostDeployment()
        {
            ClassId = WorkflowOperationTypePostDeployment.ClassIdEnum.WorkflowOperationTypePostDeployment;
            ObjectType = WorkflowOperationTypePostDeployment.ObjectTypeEnum.WorkflowOperationTypePostDeployment;
            OperationType = WorkflowOperationTypePostDeployment.OperationTypeEnum.PostDeployment;

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

        public WorkflowOperationTypePostDeployment.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowOperationTypePostDeployment.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of action operation to be performed on the service item.\n* `PostDeployment` - This represents the post-deployment actions for the resources created or defined through the deployment action. There can be more than one post-deployment operations associated with a service item.\n* `Deployment` - This represents the deploy action, for the service item action definition. This operation type is used to create or define resources that is managed by the service item. There can only be one Service Item Action Definition that can be marked with the operation type as Deployment and this is a mandatory operation type. All valid Service Items must have one and only one operation type marked as type Deployment.\n* `Decommission` - This represents the decommission action, used to decommission the created resources. All valid Service Items must have one and only one operation type marked as type Decommission. Once a decommission action is run on a Service Item, no further operations are allowed on that Service Item."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowOperationTypePostDeployment.OperationTypeEnum OperationType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specify the service item action definition which needs to be executed on the service item instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.MoMoRef ServiceItemActionDefinition
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specify the service item instance to issue post-deployment action."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.MoMoRef ServiceItemInstance
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowOperationTypePostDeployment initObject = new Intersight.Model.WorkflowOperationTypePostDeployment();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OperationType"))
            {
                initObject.OperationType = this.OperationType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ServiceItemActionDefinition"))
            {
                initObject.ServiceItemActionDefinition = this.ServiceItemActionDefinition;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ServiceItemInstance"))
            {
                initObject.ServiceItemInstance = this.ServiceItemInstance;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowParameterSet.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowParameterSet")]
    public class InitializeIntersightWorkflowParameterSet : PSCmdlet
    {
        public InitializeIntersightWorkflowParameterSet()
        {
            ClassId = WorkflowParameterSet.ClassIdEnum.WorkflowParameterSet;
            Condition = WorkflowParameterSet.ConditionEnum.Eq;
            ObjectType = WorkflowParameterSet.ObjectTypeEnum.WorkflowParameterSet;

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

        public WorkflowParameterSet.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The condition to be evaluated.\n* `eq` - Checks if the values of the two parameters are equal.\n* `ne` - Checks if the values of the two parameters are not equal.\n* `contains` - Checks if the second parameter string value is a substring of the first parameter string value.\n* `matchesPattern` - Checks if a string matches a regular expression."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowParameterSet.ConditionEnum Condition
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the controlling entity, whose value will be used for evaluating the parameter set."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ControlParameter
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> EnableParameters
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name for the parameter set.  Limited to 64 alphanumeric characters (upper and lower case), and special characters '-' and '_'."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowParameterSet.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The controlling parameter will be evaluated against this 'value'."</para>
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
            Intersight.Model.WorkflowParameterSet initObject = new Intersight.Model.WorkflowParameterSet();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Condition"))
            {
                initObject.Condition = this.Condition;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ControlParameter"))
            {
                initObject.ControlParameter = this.ControlParameter;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EnableParameters"))
            {
                initObject.EnableParameters = this.EnableParameters;
            }
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowPowerShellApi.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowPowerShellApi")]
    public class InitializeIntersightWorkflowPowerShellApi : PSCmdlet
    {
        public InitializeIntersightWorkflowPowerShellApi()
        {
            ClassId = WorkflowPowerShellApi.ClassIdEnum.WorkflowPowerShellApi;
            ObjectType = WorkflowPowerShellApi.ObjectTypeEnum.WorkflowPowerShellApi;

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
        /// <para type="description">"The optional request body that is sent as part of this API request.\nThe request body can contain a golang template that can be populated with task input\nparameters and previous API output parameters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Body
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowPowerShellApi.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Intersight Orchestrator, with the support of response parser specification,\ncan extract the values from API responses and map them to task output parameters.\nThe value extraction is supported for response content types XML, JSON and Text.\nThe type of the content that gets passed as payload and response in this\nAPI. The supported values are json, xml, text."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ContentType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The response of a PowerShell script is an object, since PowerShell is an Object based language.\nEach object can contain multiple objects as properties, each of which in turn can contain multiple objects and so on and so forth.\nThe depth field specifies how many levels of contained objects are included in the JSON representation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Depth
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A description that task designer can add to individual API requests that explain \nwhat the API call is about."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Intersight Orchestrator, with the support of response parser specification,\ncan extract the values from API responses and map them to task output parameters.\nThe value extraction is supported for response content types XML, JSON and Text.\nOptional input to specify the content type in case of error API response. This\nshould be used if the content type of error response is different from that of\nthe success response. If not specified, contentType input value is used to parse\nthe error response."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ErrorContentType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user friendly label that task designers have given to the batch API request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference name for this API request within the batch API request.\nThis name shall be used to map the API output parameters to subsequent\nAPI input parameters within a batch API task."</para>
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

        public WorkflowPowerShellApi.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The timeout in seconds for the execution of the script against the given endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string OperationTimeout
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"All the possible outcomes of this API are captured here. Outcomes property\nis a collection property of type workflow.Outcome objects.\nThe outcomes can be mapped to the message to be shown. The outcomes are\nevaluated in the order they are given. At the end of the outcomes list,\nan catchall success/fail outcome can be added with condition as 'true'.\nThis is an optional\nproperty and if not specified the task will be marked as success."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Outcomes
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The grammar specification to parse the response and extract the required values."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object PowerShellResponseSpec
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The optional grammar specification for parsing the response to extract the\nrequired values.\nThe specification should have extraction specification specified for\nall the API output parameters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object ResponseSpec
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The skip expression, if provided, allows the batch API executor to skip the\napi execution when the given expression evaluates to true.\nThe expression is given as such a golang template that has to be\nevaluated to a final content true/false. The expression is an optional and in\ncase not provided, the API will always be executed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SkipOnCondition
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The delay in seconds after which the API needs to be executed.\nBy default, the given API is executed immediately. Specifying a start delay adds to the delay to execution.\nStart Delay is not supported for the first API in the Batch and cumulative delay of all the APIs in the Batch should not exceed the task time out."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long StartDelay
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The duration in seconds by which the API response is expected from the API target.\nIf the end point does not respond for the API request within this timeout\nduration, the task will be marked as failed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Timeout
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowPowerShellApi initObject = new Intersight.Model.WorkflowPowerShellApi();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Body"))
            {
                initObject.Body = this.Body;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ContentType"))
            {
                initObject.ContentType = this.ContentType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Depth"))
            {
                initObject.Depth = this.Depth;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ErrorContentType"))
            {
                initObject.ErrorContentType = this.ErrorContentType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OperationTimeout"))
            {
                initObject.OperationTimeout = this.OperationTimeout;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Outcomes"))
            {
                initObject.Outcomes = this.Outcomes;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PowerShellResponseSpec"))
            {
                initObject.PowerShellResponseSpec = this.PowerShellResponseSpec;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ResponseSpec"))
            {
                initObject.ResponseSpec = this.ResponseSpec;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SkipOnCondition"))
            {
                initObject.SkipOnCondition = this.SkipOnCondition;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StartDelay"))
            {
                initObject.StartDelay = this.StartDelay;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Timeout"))
            {
                initObject.Timeout = this.Timeout;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowPowerShellBatchApiExecutor.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowPowerShellBatchApiExecutor")]
    public class InitializeIntersightWorkflowPowerShellBatchApiExecutor : PSCmdlet
    {
        public InitializeIntersightWorkflowPowerShellBatchApiExecutor()
        {
            ClassId = WorkflowPowerShellBatchApiExecutor.ClassIdEnum.WorkflowPowerShellBatchApiExecutor;
            ObjectType = WorkflowPowerShellBatchApiExecutor.ObjectTypeEnum.WorkflowPowerShellBatchApiExecutor;

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

        public List<Model.WorkflowApi> Batch
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.WorkflowApi> CancelAction
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowPowerShellBatchApiExecutor.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enter the constraints on when this task should match against the task definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowTaskConstraints Constraints
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A detailed description about the batch APIs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a workflowErrorResponseHandler resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowErrorResponseHandlerRelationship ErrorResponseHandler
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
        /// <para type="description">"Name for the batch API task."</para>
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

        public WorkflowPowerShellBatchApiExecutor.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"All the possible outcomes of this task are captured here. Outcomes property\nis a collection property of type workflow.Outcome objects.\nThe outcomes can be mapped to the message to be shown. The outcomes are\nevaluated in the order they are given. At the end of the outcomes list,\nan catchall success/fail outcome can be added with condition as 'true'.\nThis is an optional\nproperty and if not specified the task will be marked as success."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Outcomes
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Intersight Orchestrator allows the extraction of required values from API\nresponses using the API response grammar. These extracted values can be mapped\nto task output parameters defined in task definition.\nThe mapping of API output parameters to the task output parameters is provided\nas JSON in this property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Output
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When an execution of a nth API in the Batch fails,\nRetry from failed API flag indicates if the execution should start from the nth API or the first API during task retry.\nBy default the value is set to false."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool RetryFromFailedApi
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The skip expression, if provided, allows the batch API executor to skip the\ntask execution when the given expression evaluates to true.\nThe expression is given as such a golang template that has to be\nevaluated to a final content true/false. The expression is an optional and in\ncase not provided, the API will always be executed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SkipOnCondition
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
        /// <para type="description">"A reference to a workflowTaskDefinition resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowTaskDefinitionRelationship TaskDefinition
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This will hold the data needed for task to be rendered in the user interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object UiRenderingData
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowPowerShellBatchApiExecutor initObject = new Intersight.Model.WorkflowPowerShellBatchApiExecutor();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Batch"))
            {
                initObject.Batch = this.Batch;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CancelAction"))
            {
                initObject.CancelAction = this.CancelAction;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Constraints"))
            {
                initObject.Constraints = this.Constraints;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ErrorResponseHandler"))
            {
                initObject.ErrorResponseHandler = this.ErrorResponseHandler;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Outcomes"))
            {
                initObject.Outcomes = this.Outcomes;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Output"))
            {
                initObject.Output = this.Output;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RetryFromFailedApi"))
            {
                initObject.RetryFromFailedApi = this.RetryFromFailedApi;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SkipOnCondition"))
            {
                initObject.SkipOnCondition = this.SkipOnCondition;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TaskDefinition"))
            {
                initObject.TaskDefinition = this.TaskDefinition;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UiRenderingData"))
            {
                initObject.UiRenderingData = this.UiRenderingData;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowPrimitiveArrayItem.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowPrimitiveArrayItem")]
    public class InitializeIntersightWorkflowPrimitiveArrayItem : PSCmdlet
    {
        public InitializeIntersightWorkflowPrimitiveArrayItem()
        {
            ClassId = WorkflowPrimitiveArrayItem.ClassIdEnum.WorkflowPrimitiveArrayItem;
            ObjectType = WorkflowPrimitiveArrayItem.ObjectTypeEnum.WorkflowPrimitiveArrayItem;

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

        public WorkflowPrimitiveArrayItem.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowPrimitiveArrayItem.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Captures an array item which is of primitive data type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowPrimitiveDataProperty Properties
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowPrimitiveArrayItem initObject = new Intersight.Model.WorkflowPrimitiveArrayItem();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Properties"))
            {
                initObject.Properties = this.Properties;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowPrimitiveDataProperty.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowPrimitiveDataProperty")]
    public class InitializeIntersightWorkflowPrimitiveDataProperty : PSCmdlet
    {
        public InitializeIntersightWorkflowPrimitiveDataProperty()
        {
            ClassId = WorkflowPrimitiveDataProperty.ClassIdEnum.WorkflowPrimitiveDataProperty;
            ObjectType = WorkflowPrimitiveDataProperty.ObjectTypeEnum.WorkflowPrimitiveDataProperty;
            Type = WorkflowPrimitiveDataProperty.TypeEnum.String;

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

        public WorkflowPrimitiveDataProperty.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Constraints that must be applied to the parameter value supplied for this data type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowConstraints Constraints
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.WorkflowMoReferenceProperty> InventorySelector
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowPrimitiveDataProperty.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Intersight supports secure properties as task input/output. The values of\nthese properties are encrypted and stored in Intersight.\nThis flag marks the property to be secure when it is set to true."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Secure
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specify the enum type for primitive data type.\n* `string` - Enum to specify a string data type.\n* `integer` - Enum to specify an integer32 data type.\n* `float` - Enum to specify a float64 data type.\n* `boolean` - Enum to specify a boolean data type.\n* `json` - Enum to specify a json data type.\n* `enum` - Enum to specify a enum data type which is a list of pre-defined strings."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowPrimitiveDataProperty.TypeEnum Type
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowPrimitiveDataProperty initObject = new Intersight.Model.WorkflowPrimitiveDataProperty();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Constraints"))
            {
                initObject.Constraints = this.Constraints;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InventorySelector"))
            {
                initObject.InventorySelector = this.InventorySelector;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Secure"))
            {
                initObject.Secure = this.Secure;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Type"))
            {
                initObject.Type = this.Type;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowPrimitiveDataType.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowPrimitiveDataType")]
    public class InitializeIntersightWorkflowPrimitiveDataType : PSCmdlet
    {
        public InitializeIntersightWorkflowPrimitiveDataType()
        {
            ClassId = WorkflowPrimitiveDataType.ClassIdEnum.WorkflowPrimitiveDataType;
            ObjectType = WorkflowPrimitiveDataType.ObjectTypeEnum.WorkflowPrimitiveDataType;

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

        public WorkflowPrimitiveDataType.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Default value for the data type. If default value was provided and the input was required the default value will be used as the input."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowDefaultValue Default
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Provide a detailed description of the data type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Captures the meta data needed for displaying workflow data types in Intersight User Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowDisplayMeta DisplayMeta
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"JSON formatted mapping from other property of the definition to the current property. Input parameter mapping is supported only for custom data type property in workflow definition and custom data type definition. The format to specify mapping ina workflow definition when source property is of scalar types is '${workflow.input.property}'. The format to specify mapping when the source property is of object reference and mapping needs to be made to the property of the object is '${workflow.input.property.subproperty}'. The format to specify mapping in a custom data type definition is '${datatype.type.property}'. When the current property is of non-scalar type like composite custom data type, then mapping can be provided to the individual property of the custom data type like 'cdt_property:${workflow.input.property}'."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object InputParameters
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Descriptive label for the data type. Label can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), space ( ), forward slash (/) or an underscore (_). The first and last character in label must be an alphanumeric character."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+[\\sa-zA-Z0-9_'.:/-]{1,92}$")]
        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Descriptive name for the data type. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-) or an underscore (_). The first and last character in name must be an alphanumeric character."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+([a-zA-Z0-9-_]*[a-zA-Z0-9])*$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowPrimitiveDataType.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Primitive data type properties."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowPrimitiveDataProperty Properties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specifies whether this parameter is required. The field is applicable for task and workflow."</para>
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
            Intersight.Model.WorkflowPrimitiveDataType initObject = new Intersight.Model.WorkflowPrimitiveDataType();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Default"))
            {
                initObject.Default = this.Default;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DisplayMeta"))
            {
                initObject.DisplayMeta = this.DisplayMeta;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InputParameters"))
            {
                initObject.InputParameters = this.InputParameters;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Properties"))
            {
                initObject.Properties = this.Properties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Required"))
            {
                initObject.Required = this.Required;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowProperties.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowProperties")]
    public class InitializeIntersightWorkflowProperties : PSCmdlet
    {
        public InitializeIntersightWorkflowProperties()
        {
            ClassId = WorkflowProperties.ClassIdEnum.WorkflowProperties;
            ObjectType = WorkflowProperties.ObjectTypeEnum.WorkflowProperties;
            RetryPolicy = WorkflowProperties.RetryPolicyEnum.Fixed;
            SupportStatus = WorkflowProperties.SupportStatusEnum.Supported;
            TimeoutPolicy = WorkflowProperties.TimeoutPolicyEnum.Timeout;

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

        public WorkflowProperties.ClassIdEnum ClassId
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

        public WorkflowProperties.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.WorkflowBaseDataType> OutputDefinition
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of times a task should be tried before marking as failed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long RetryCount
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The delay in seconds after which the the task is re-tried."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(10, 86400)]
        public long RetryDelay
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The retry policy for the task.\n* `Fixed` - The enum specifies the option as Fixed where the task retry happens after fixed time specified by RetryDelay."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowProperties.RetryPolicyEnum RetryPolicy
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Supported status of the definition.\n* `Supported` - The definition is a supported version and there will be no changes to the mandatory inputs or outputs.\n* `Beta` - The definition is a Beta version and this version can under go changes until the version is marked supported.\n* `Deprecated` - The version of definition is deprecated and typically there will be a higher version of the same definition that has been added."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowProperties.SupportStatusEnum SupportStatus
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The timeout value in seconds after which task will be marked as timed out. Max allowed value is 7 days."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(10, 604800)]
        public long Timeout
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The timeout policy for the task.\n* `Timeout` - The enum specifies the option as Timeout where task will be timed out after the specified time in Timeout property.\n* `Retry` - The enum specifies the option as Retry where task will be re-tried."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowProperties.TimeoutPolicyEnum TimeoutPolicy
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowProperties initObject = new Intersight.Model.WorkflowProperties();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("OutputDefinition"))
            {
                initObject.OutputDefinition = this.OutputDefinition;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RetryCount"))
            {
                initObject.RetryCount = this.RetryCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RetryDelay"))
            {
                initObject.RetryDelay = this.RetryDelay;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RetryPolicy"))
            {
                initObject.RetryPolicy = this.RetryPolicy;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SupportStatus"))
            {
                initObject.SupportStatus = this.SupportStatus;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Timeout"))
            {
                initObject.Timeout = this.Timeout;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TimeoutPolicy"))
            {
                initObject.TimeoutPolicy = this.TimeoutPolicy;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowResourceInlineSelector.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowResourceInlineSelector")]
    public class InitializeIntersightWorkflowResourceInlineSelector : PSCmdlet
    {
        public InitializeIntersightWorkflowResourceInlineSelector()
        {
            ClassId = WorkflowResourceInlineSelector.ClassIdEnum.WorkflowResourceInlineSelector;
            ObjectType = WorkflowResourceInlineSelector.ObjectTypeEnum.WorkflowResourceInlineSelector;

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

        public WorkflowResourceInlineSelector.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowResourceInlineSelector.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The odata based filter URL to select the resources."</para>
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
            Intersight.Model.WorkflowResourceInlineSelector initObject = new Intersight.Model.WorkflowResourceInlineSelector();
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowResourceSelectorCriteria.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowResourceSelectorCriteria")]
    public class InitializeIntersightWorkflowResourceSelectorCriteria : PSCmdlet
    {
        public InitializeIntersightWorkflowResourceSelectorCriteria()
        {
            ClassId = WorkflowResourceSelectorCriteria.ClassIdEnum.WorkflowResourceSelectorCriteria;
            ObjectType = WorkflowResourceSelectorCriteria.ObjectTypeEnum.WorkflowResourceSelectorCriteria;

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

        public WorkflowResourceSelectorCriteria.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowResourceSelectorCriteria.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The runtime properties and the value can be stored in this property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Parameters
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Holds the resource selection criteria reference."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.MoMoRef ResourceSelectionCriteria
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowResourceSelectorCriteria initObject = new Intersight.Model.WorkflowResourceSelectorCriteria();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Parameters"))
            {
                initObject.Parameters = this.Parameters;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ResourceSelectionCriteria"))
            {
                initObject.ResourceSelectionCriteria = this.ResourceSelectionCriteria;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowResultHandler.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowResultHandler")]
    public class InitializeIntersightWorkflowResultHandler : PSCmdlet
    {
        public InitializeIntersightWorkflowResultHandler()
        {
            ClassId = WorkflowResultHandler.ClassIdEnum.WorkflowResultHandler;
            ObjectType = WorkflowResultHandler.ObjectTypeEnum.WorkflowResultHandler;

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

        public WorkflowResultHandler.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowResultHandler.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowResultHandler initObject = new Intersight.Model.WorkflowResultHandler();
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowRollbackTask.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowRollbackTask")]
    public class InitializeIntersightWorkflowRollbackTask : PSCmdlet
    {
        public InitializeIntersightWorkflowRollbackTask()
        {
            ClassId = WorkflowRollbackTask.ClassIdEnum.WorkflowRollbackTask;
            ObjectType = WorkflowRollbackTask.ObjectTypeEnum.WorkflowRollbackTask;

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
        /// <para type="description">"The catalog under which the task definition has been added."</para>
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

        public WorkflowRollbackTask.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of rollback task definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Input parameters mapping for rollback task from the input or output of the main task definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object InputParameters
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the task definition which is capable of doing rollback of this task."</para>
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

        public WorkflowRollbackTask.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The resolved referenced rollback task definition managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string TaskMoid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The version of the task definition."</para>
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
            Intersight.Model.WorkflowRollbackTask initObject = new Intersight.Model.WorkflowRollbackTask();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("TaskMoid"))
            {
                initObject.TaskMoid = this.TaskMoid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject.VarVersion = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowRollbackWorkflow.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowRollbackWorkflow")]
    public class InitializeIntersightWorkflowRollbackWorkflow : PSCmdlet
    {
        public InitializeIntersightWorkflowRollbackWorkflow()
        {
            Action = WorkflowRollbackWorkflow.ActionEnum.None;
            ClassId = WorkflowRollbackWorkflow.ClassIdEnum.WorkflowRollbackWorkflow;
            ObjectType = WorkflowRollbackWorkflow.ObjectTypeEnum.WorkflowRollbackWorkflow;

        }
        // <summary>
        /// <para type="description">"The action of the rollback workflow such as Create and Start.\n* `None` - If no action is set, then the default value is set to none for the action field.\n* `Create` - Create rollback workflow data for the execution of the rollback workflow.\n* `Start` - Start a new execution of the rollback workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowRollbackWorkflow.ActionEnum Action
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

        public WorkflowRollbackWorkflow.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When set to true, if a task in the workflow fails, the rollback workflow continues to the subsequent task. When set to false, the rollback workflow execution halts if a task fails."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool ContinueOnTaskFailure
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

        public WorkflowRollbackWorkflow.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a workflowWorkflowInfo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowWorkflowInfoRelationship PrimaryWorkflow
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.WorkflowRollbackWorkflowTask> SelectedTasks
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
            Intersight.Model.WorkflowRollbackWorkflow initObject = new Intersight.Model.WorkflowRollbackWorkflow();
            if (this.MyInvocation.BoundParameters.ContainsKey("Action"))
            {
                initObject.Action = this.Action;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ContinueOnTaskFailure"))
            {
                initObject.ContinueOnTaskFailure = this.ContinueOnTaskFailure;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PrimaryWorkflow"))
            {
                initObject.PrimaryWorkflow = this.PrimaryWorkflow;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SelectedTasks"))
            {
                initObject.SelectedTasks = this.SelectedTasks;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowRollbackWorkflowTask.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowRollbackWorkflowTask")]
    public class InitializeIntersightWorkflowRollbackWorkflowTask : PSCmdlet
    {
        public InitializeIntersightWorkflowRollbackWorkflowTask()
        {
            ClassId = WorkflowRollbackWorkflowTask.ClassIdEnum.WorkflowRollbackWorkflowTask;
            ObjectType = WorkflowRollbackWorkflowTask.ObjectTypeEnum.WorkflowRollbackWorkflowTask;

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

        public WorkflowRollbackWorkflowTask.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of TaskInfo that needs to be rolled back."</para>
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

        public WorkflowRollbackWorkflowTask.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Reference name of TaskInfo that need to be rolled back."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string RefName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Moid of TaskInfo that supports rollback operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string TaskInfoMoid
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowRollbackWorkflowTask initObject = new Intersight.Model.WorkflowRollbackWorkflowTask();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("RefName"))
            {
                initObject.RefName = this.RefName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TaskInfoMoid"))
            {
                initObject.TaskInfoMoid = this.TaskInfoMoid;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowSelectorProperty.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowSelectorProperty")]
    public class InitializeIntersightWorkflowSelectorProperty : PSCmdlet
    {
        public InitializeIntersightWorkflowSelectorProperty()
        {
            ClassId = WorkflowSelectorProperty.ClassIdEnum.WorkflowSelectorProperty;
            Method = WorkflowSelectorProperty.MethodEnum.GET;
            ObjectType = WorkflowSelectorProperty.ObjectTypeEnum.WorkflowSelectorProperty;

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
        /// <para type="description">"Content of the request body to send for POST request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Body
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowSelectorProperty.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The HTTP method to be used.\n* `GET` - The HTTP GET method requests a representation of the specified resource.\n* `POST` - The HTTP POST method sends data to the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowSelectorProperty.MethodEnum Method
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowSelectorProperty.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowSelectorProperty initObject = new Intersight.Model.WorkflowSelectorProperty();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Body"))
            {
                initObject.Body = this.Body;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Method"))
            {
                initObject.Method = this.Method;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowSequenceParams.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowSequenceParams")]
    public class InitializeIntersightWorkflowSequenceParams : PSCmdlet
    {
        public InitializeIntersightWorkflowSequenceParams()
        {
            ClassId = WorkflowSequenceParams.ClassIdEnum.WorkflowSequenceParams;
            ObjectType = WorkflowSequenceParams.ObjectTypeEnum.WorkflowSequenceParams;

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

        public WorkflowSequenceParams.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowSequenceParams.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowSequenceParams initObject = new Intersight.Model.WorkflowSequenceParams();
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowSerialLoopTask.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowSerialLoopTask")]
    public class InitializeIntersightWorkflowSerialLoopTask : PSCmdlet
    {
        public InitializeIntersightWorkflowSerialLoopTask()
        {
            ClassId = WorkflowSerialLoopTask.ClassIdEnum.WorkflowSerialLoopTask;
            ObjectType = WorkflowSerialLoopTask.ObjectTypeEnum.WorkflowSerialLoopTask;

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

        public WorkflowSerialLoopTask.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Condition expression which will be evaluated and when expression is true the tasks under loop will be executed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Condition
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Count value for the loop, this can be a static value defined as a constant at design time or can be a dynamic value defined as an expression that will evaluate to an integer value at execution time. Dynamic values for count must be specified as a template. For example, if a loop must run for a count which matches the length of a workflow input called StringArray, then the count must be specified using a template '{{ len .global.workflow.input.StringArray }}'. The count must be less than or equal to 100. If count is given as a dynamic value, and during execution time if count evaluates to be a value greater than 100, then the loop task will fail."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Count
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The description of this task instance in the workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user defined label identifier of the workflow task used for UI display."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Start task where the list of tasks will be executed multiple times based on the count or condition value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string LoopStartTask
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the task within the workflow and it must be unique among all WorkflowTasks within a workflow definition. This name serves as the internal unique identifier for the task and is used to pick input and output parameters to feed into other tasks."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowSerialLoopTask.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This specifies the name of the next task to run if all iterations of the loop task do not succeed. The unique name given to the task instance within the workflow must be provided here. In a graph model, denotes an edge to another Task Node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string OnFailure
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This specifies the name of the next task to run if all iterations of the loop task succeeds. The unique name given to the task instance within the workflow must be provided here. In a graph model, denotes an edge to another Task Node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string OnSuccess
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowSerialLoopTask initObject = new Intersight.Model.WorkflowSerialLoopTask();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Condition"))
            {
                initObject.Condition = this.Condition;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Count"))
            {
                initObject.Count = this.Count;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LoopStartTask"))
            {
                initObject.LoopStartTask = this.LoopStartTask;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OnFailure"))
            {
                initObject.OnFailure = this.OnFailure;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("OnSuccess"))
            {
                initObject.OnSuccess = this.OnSuccess;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowServiceItemActionDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowServiceItemActionDefinition")]
    public class InitializeIntersightWorkflowServiceItemActionDefinition : PSCmdlet
    {
        public InitializeIntersightWorkflowServiceItemActionDefinition()
        {
            ActionType = WorkflowServiceItemActionDefinition.ActionTypeEnum.External;
            ClassId = WorkflowServiceItemActionDefinition.ClassIdEnum.WorkflowServiceItemActionDefinition;
            ObjectType = WorkflowServiceItemActionDefinition.ObjectTypeEnum.WorkflowServiceItemActionDefinition;

        }
        // <summary>
        /// <para type="description">"Action properties for the service item."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowServiceItemActionProperties ActionProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of actionDefinition which decides on how to trigger the action.\n* `External` - External actions definition can be triggered by enduser to perform actions on the service item. Once action is completed successfully (eg. create/deploy), user cannot re-trigger that action again.\n* `Internal` - Internal action definition is used to trigger periodic actions on the service item instance.\n* `Repetitive` - Repetitive action definition is an external action that can be triggered by enduser to perform repetitive actions (eg. Edit/Update/Perform health check) on the created service item."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowServiceItemActionDefinition.ActionTypeEnum ActionType
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

        public List<WorkflowServiceItemActionDefinition.AllowedInstanceStatesEnum> AllowedInstanceStates
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to iamRole resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.IamRoleRelationship> AssociatedRoles
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The mappings from workflows in the action definition to the service item attribute definition. Any output from core or post-core workflow can be mapped to service item attribute definition. The attribute can be referred using the name of the workflow definition and the attribute name in the following format '${<ServiceItemActionWorkflowDefinition.Name>.output.<outputName>'."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object AttributeParameters
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowServiceItemActionDefinition.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.WorkflowServiceItemActionWorkflowDefinition> CoreWorkflows
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The description for this action which provides information on what are the pre-requisites to use this action on the service item and what features are supported by this action."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
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
        /// <para type="description">"A user friendly short name to identify the action. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.), colon (:), space ( ) or an underscore (_)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+[\\sa-zA-Z0-9_.:-]{1,92}$")]
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
        /// <para type="description">"The name for this action definition. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.), colon (:) or an underscore (_). Name of the action must be unique within a service item definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowServiceItemActionDefinition.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Value in seconds to specify the periodicity of the workflows. A zero value indicate the workflow will not execute periodically. A non-zero value indicate, the workflow will be executed periodically with this periodicity."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Periodicity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.WorkflowServiceItemActionWorkflowDefinition> PostCoreWorkflows
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.WorkflowServiceItemActionWorkflowDefinition> PreCoreWorkflows
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The flag to indicate that action is restricted on a Private Virtual Appliance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool RestrictOnPrivateAppliance
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a workflowServiceItemDefinition resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowServiceItemDefinitionRelationship ServiceItemDefinition
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.WorkflowServiceItemActionWorkflowDefinition> StopWorkflows
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.WorkflowServiceItemActionWorkflowDefinition> ValidationWorkflows
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowServiceItemActionDefinition initObject = new Intersight.Model.WorkflowServiceItemActionDefinition();
            if (this.MyInvocation.BoundParameters.ContainsKey("ActionProperties"))
            {
                initObject.ActionProperties = this.ActionProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ActionType"))
            {
                initObject.ActionType = this.ActionType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AllowedInstanceStates"))
            {
                initObject.AllowedInstanceStates = this.AllowedInstanceStates;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AssociatedRoles"))
            {
                initObject.AssociatedRoles = this.AssociatedRoles;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AttributeParameters"))
            {
                initObject.AttributeParameters = this.AttributeParameters;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CoreWorkflows"))
            {
                initObject.CoreWorkflows = this.CoreWorkflows;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InputDefinition"))
            {
                initObject.InputDefinition = this.InputDefinition;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Periodicity"))
            {
                initObject.Periodicity = this.Periodicity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PostCoreWorkflows"))
            {
                initObject.PostCoreWorkflows = this.PostCoreWorkflows;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PreCoreWorkflows"))
            {
                initObject.PreCoreWorkflows = this.PreCoreWorkflows;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RestrictOnPrivateAppliance"))
            {
                initObject.RestrictOnPrivateAppliance = this.RestrictOnPrivateAppliance;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ServiceItemDefinition"))
            {
                initObject.ServiceItemDefinition = this.ServiceItemDefinition;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StopWorkflows"))
            {
                initObject.StopWorkflows = this.StopWorkflows;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ValidationWorkflows"))
            {
                initObject.ValidationWorkflows = this.ValidationWorkflows;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowServiceItemActionInstance.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowServiceItemActionInstance")]
    public class InitializeIntersightWorkflowServiceItemActionInstance : PSCmdlet
    {
        public InitializeIntersightWorkflowServiceItemActionInstance()
        {
            Action = WorkflowServiceItemActionInstance.ActionEnum.None;
            ClassId = WorkflowServiceItemActionInstance.ClassIdEnum.WorkflowServiceItemActionInstance;
            ObjectType = WorkflowServiceItemActionInstance.ObjectTypeEnum.WorkflowServiceItemActionInstance;

        }
        // <summary>
        /// <para type="description">"Name of the action that needs to be performed on the service item instance.\n* `None` - No action is set, this is the default value for action field.\n* `Validate` - Validate the action instance inputs and run the validation workflows.\n* `Start` - Start a new execution of the action instance.\n* `Rerun` - Rerun the service item action instance from the beginning.\n* `Retry` - Retry the workflow that has failed from the failure point.\n* `Cancel` - Cancel the core workflow that is in running or waiting state. This action can be used when the workflows are stuck and not progressing.\n* `Stop` - Stop the action instance which is in progress and didn't complete successfully. Use this action to clear the state and then delete the action instance. A completed action cannot be stopped."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowServiceItemActionInstance.ActionEnum Action
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

        public WorkflowServiceItemActionInstance.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamIdp resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamIdpRelationship Idp
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamIdpReference resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamIdpReferenceRelationship IdpReference
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Inputs for a service item action and the format is specified by input definition of the service item action definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Input
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

        public WorkflowServiceItemActionInstance.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a workflowServiceItemActionDefinition resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowServiceItemActionDefinitionRelationship ServiceItemActionDefinition
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a workflowServiceItemInstance resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowServiceItemInstanceRelationship ServiceItemInstance
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
        /// <para type="description">"A reference to a iamUser resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamUserRelationship User
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowServiceItemActionInstance initObject = new Intersight.Model.WorkflowServiceItemActionInstance();
            if (this.MyInvocation.BoundParameters.ContainsKey("Action"))
            {
                initObject.Action = this.Action;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Idp"))
            {
                initObject.Idp = this.Idp;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IdpReference"))
            {
                initObject.IdpReference = this.IdpReference;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Input"))
            {
                initObject.Input = this.Input;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ServiceItemActionDefinition"))
            {
                initObject.ServiceItemActionDefinition = this.ServiceItemActionDefinition;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ServiceItemInstance"))
            {
                initObject.ServiceItemInstance = this.ServiceItemInstance;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("User"))
            {
                initObject.User = this.User;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowServiceItemActionProperties.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowServiceItemActionProperties")]
    public class InitializeIntersightWorkflowServiceItemActionProperties : PSCmdlet
    {
        public InitializeIntersightWorkflowServiceItemActionProperties()
        {
            ClassId = WorkflowServiceItemActionProperties.ClassIdEnum.WorkflowServiceItemActionProperties;
            ObjectType = WorkflowServiceItemActionProperties.ObjectTypeEnum.WorkflowServiceItemActionProperties;
            OperationType = WorkflowServiceItemActionProperties.OperationTypeEnum.PostDeployment;

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

        public WorkflowServiceItemActionProperties.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowServiceItemActionProperties.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of action operation to be executed on the service item.\n* `PostDeployment` - This represents the post-deployment actions for the resources created or defined through the deployment action. There can be more than one post-deployment operations associated with a service item.\n* `Deployment` - This represents the deploy action, for the service item action definition. This operation type is used to create or define resources that is managed by the service item. There can only be one Service Item Action Definition that can be marked with the operation type as Deployment and this is a mandatory operation type. All valid Service Items must have one and only one operation type marked as type Deployment.\n* `Decommission` - This represents the decommission action, used to decommission the created resources. All valid Service Items must have one and only one operation type marked as type Decommission. Once a decommission action is run on a Service Item, no further operations are allowed on that Service Item."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowServiceItemActionProperties.OperationTypeEnum OperationType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When true, the action on the service item will be stopped when it reaches a failure by either calling the configured stop workflow or by calling the rollback workflow. By default value is set to true."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool StopOnFailure
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowServiceItemActionProperties initObject = new Intersight.Model.WorkflowServiceItemActionProperties();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OperationType"))
            {
                initObject.OperationType = this.OperationType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StopOnFailure"))
            {
                initObject.StopOnFailure = this.StopOnFailure;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowServiceItemActionWorkflowDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowServiceItemActionWorkflowDefinition")]
    public class InitializeIntersightWorkflowServiceItemActionWorkflowDefinition : PSCmdlet
    {
        public InitializeIntersightWorkflowServiceItemActionWorkflowDefinition()
        {
            ClassId = WorkflowServiceItemActionWorkflowDefinition.ClassIdEnum.WorkflowServiceItemActionWorkflowDefinition;
            ObjectType = WorkflowServiceItemActionWorkflowDefinition.ObjectTypeEnum.WorkflowServiceItemActionWorkflowDefinition;

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
        /// <para type="description">"Specify the catalog moid that this workflow belongs. When catalog moid is not specified then the catalog of the service item is used first and if no workflow can be found in that catalog, then the shared catalog from Intersight is used."</para>
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

        public WorkflowServiceItemActionWorkflowDefinition.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The description of this workflow instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Capture the mapping of ActionDefinition inputDefinition to workflow definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object InputParameters
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user defined label identifier of the workflow used for UI display."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the workflow, this name must be unique across all the workflow definition used within the action definitions."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowServiceItemActionWorkflowDefinition.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The workflow definition version to use as subworkflow. When no version is specified then the default version of the workflow at the time of creating or updating this workflow is used."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Version
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The qualified name of workflow that should be executed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string WorkflowDefinitionName
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowServiceItemActionWorkflowDefinition initObject = new Intersight.Model.WorkflowServiceItemActionWorkflowDefinition();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject.VarVersion = this.Version;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("WorkflowDefinitionName"))
            {
                initObject.WorkflowDefinitionName = this.WorkflowDefinitionName;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowServiceItemAttribute.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowServiceItemAttribute")]
    public class InitializeIntersightWorkflowServiceItemAttribute : PSCmdlet
    {
        public InitializeIntersightWorkflowServiceItemAttribute()
        {
            ClassId = WorkflowServiceItemAttribute.ClassIdEnum.WorkflowServiceItemAttribute;
            ObjectType = WorkflowServiceItemAttribute.ObjectTypeEnum.WorkflowServiceItemAttribute;

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
        /// <para type="description">"Service item attribute for a service item instance and the format is specified by attribute definition of the service item definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Attribute
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowServiceItemAttribute.ClassIdEnum ClassId
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
        /// <para type="description">"Attribute name which is used in the attribute definition of the service item."</para>
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

        public WorkflowServiceItemAttribute.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a workflowServiceItemDefinition resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowServiceItemDefinitionRelationship ServiceItemDefinition
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a workflowServiceItemInstance resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowServiceItemInstanceRelationship ServiceItemInstance
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
            Intersight.Model.WorkflowServiceItemAttribute initObject = new Intersight.Model.WorkflowServiceItemAttribute();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Attribute"))
            {
                initObject.Attribute = this.Attribute;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ServiceItemDefinition"))
            {
                initObject.ServiceItemDefinition = this.ServiceItemDefinition;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ServiceItemInstance"))
            {
                initObject.ServiceItemInstance = this.ServiceItemInstance;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowServiceItemDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowServiceItemDefinition")]
    public class InitializeIntersightWorkflowServiceItemDefinition : PSCmdlet
    {
        public InitializeIntersightWorkflowServiceItemDefinition()
        {
            ClassId = WorkflowServiceItemDefinition.ClassIdEnum.WorkflowServiceItemDefinition;
            ObjectType = WorkflowServiceItemDefinition.ObjectTypeEnum.WorkflowServiceItemDefinition;
            PublishStatus = WorkflowServiceItemDefinition.PublishStatusEnum.Draft;
            SupportStatus = WorkflowServiceItemDefinition.SupportStatusEnum.Supported;

        }
        // <summary>
        /// <para type="description">"An array of relationships to workflowServiceItemActionDefinition resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.WorkflowServiceItemActionDefinitionRelationship> ActionDefinitions
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
        /// <para type="description">"Service item definition can declare that only one instance can be allowed within the customer account."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool AllowMultipleServiceItemInstances
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.WorkflowBaseDataType> AttributeDefinition
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

        public WorkflowServiceItemDefinition.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Cisco Validated Design (CVD) Identifier that this service item provides."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string CvdId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The flag to indicate that service item instance will be deleted after the completion of decommission action."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool DeleteInstanceOnDecommission
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The description for this service item which provides information on what are the pre-requisites to deploy the service item and what features are supported on the service item."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user friendly short name to identify the service item. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.), colon (:), space ( ) or an underscore (_)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+[\\sa-zA-Z0-9_.:-]{1,92}$")]
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
        /// <para type="description">"The name for this service item definition. You can have multiple versions of the service item with the same name. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.), colon (:) or an underscore (_)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowServiceItemDefinition.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The publish status of service item (Draft, Published, Archived).\n* `Draft` - The enum specifies the option as Draft which means the meta definition is being designed and tested.\n* `Published` - The enum specifies the option as Published which means the meta definition is ready for consumption.\n* `Archived` - The enum specifies the option as Archived which means the meta definition is archived and can no longer be consumed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowServiceItemDefinition.PublishStatusEnum PublishStatus
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The service item can be marked as deprecated, supported or beta, the support status indicates that. When a new service item is introduced, it can be marked beta to indicate this is experimental and later moved to Supported status. When Service item is deprecated, it cannot be instantiated and used for a Catalog Item design.\n* `Supported` - The definition is a supported version and there will be no changes to the mandatory inputs or outputs.\n* `Beta` - The definition is a Beta version and this version can under go changes until the version is marked supported.\n* `Deprecated` - The version of definition is deprecated and typically there will be a higher version of the same definition that has been added."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowServiceItemDefinition.SupportStatusEnum SupportStatus
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
        /// <para type="description">"The version of the service item to support multiple versions."</para>
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
            Intersight.Model.WorkflowServiceItemDefinition initObject = new Intersight.Model.WorkflowServiceItemDefinition();
            if (this.MyInvocation.BoundParameters.ContainsKey("ActionDefinitions"))
            {
                initObject.ActionDefinitions = this.ActionDefinitions;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AllowMultipleServiceItemInstances"))
            {
                initObject.AllowMultipleServiceItemInstances = this.AllowMultipleServiceItemInstances;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AttributeDefinition"))
            {
                initObject.AttributeDefinition = this.AttributeDefinition;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Catalog"))
            {
                initObject.Catalog = this.Catalog;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CvdId"))
            {
                initObject.CvdId = this.CvdId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DeleteInstanceOnDecommission"))
            {
                initObject.DeleteInstanceOnDecommission = this.DeleteInstanceOnDecommission;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("PublishStatus"))
            {
                initObject.PublishStatus = this.PublishStatus;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SupportStatus"))
            {
                initObject.SupportStatus = this.SupportStatus;
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowServiceItemHealthCheckDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowServiceItemHealthCheckDefinition")]
    public class InitializeIntersightWorkflowServiceItemHealthCheckDefinition : PSCmdlet
    {
        public InitializeIntersightWorkflowServiceItemHealthCheckDefinition()
        {
            ClassId = WorkflowServiceItemHealthCheckDefinition.ClassIdEnum.WorkflowServiceItemHealthCheckDefinition;
            ExecutionMode = WorkflowServiceItemHealthCheckDefinition.ExecutionModeEnum.OnDemand;
            ObjectType = WorkflowServiceItemHealthCheckDefinition.ObjectTypeEnum.WorkflowServiceItemHealthCheckDefinition;

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
        /// <para type="description">"Category that the health check belongs to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Category
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowServiceItemHealthCheckDefinition.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Static information detailing the common cause for the health check failure.\nIt also gives possible remediation actions that can be taken to remedy the health check failure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string CommonCauseAndResolution
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the health check definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Execution mode of the health check on service item.\n* `OnDemand` - Execute the health check on-demand.\n* `Periodic` - Execute the health check on a periodic basis."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowServiceItemHealthCheckDefinition.ExecutionModeEnum ExecutionMode
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Workflow that is associated with this health check definition. This workflow will be run on execution of the respective health check definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowServiceItemActionWorkflowDefinition HealthCheckWorkflow
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Label for the health check definition that is displayed on UI."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

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
        /// <para type="description">"Name of the health check definition."</para>
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

        public WorkflowServiceItemHealthCheckDefinition.ObjectTypeEnum ObjectType
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
            Intersight.Model.WorkflowServiceItemHealthCheckDefinition initObject = new Intersight.Model.WorkflowServiceItemHealthCheckDefinition();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Category"))
            {
                initObject.Category = this.Category;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CommonCauseAndResolution"))
            {
                initObject.CommonCauseAndResolution = this.CommonCauseAndResolution;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ExecutionMode"))
            {
                initObject.ExecutionMode = this.ExecutionMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HealthCheckWorkflow"))
            {
                initObject.HealthCheckWorkflow = this.HealthCheckWorkflow;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowServiceItemHealthCheckExecution.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowServiceItemHealthCheckExecution")]
    public class InitializeIntersightWorkflowServiceItemHealthCheckExecution : PSCmdlet
    {
        public InitializeIntersightWorkflowServiceItemHealthCheckExecution()
        {
            ClassId = WorkflowServiceItemHealthCheckExecution.ClassIdEnum.WorkflowServiceItemHealthCheckExecution;
            ObjectType = WorkflowServiceItemHealthCheckExecution.ObjectTypeEnum.WorkflowServiceItemHealthCheckExecution;

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

        public WorkflowServiceItemHealthCheckExecution.ClassIdEnum ClassId
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

        public WorkflowServiceItemHealthCheckExecution.ObjectTypeEnum ObjectType
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
            Intersight.Model.WorkflowServiceItemHealthCheckExecution initObject = new Intersight.Model.WorkflowServiceItemHealthCheckExecution();
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowServiceItemInputDefinitionType.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowServiceItemInputDefinitionType")]
    public class InitializeIntersightWorkflowServiceItemInputDefinitionType : PSCmdlet
    {
        public InitializeIntersightWorkflowServiceItemInputDefinitionType()
        {
            ClassId = WorkflowServiceItemInputDefinitionType.ClassIdEnum.WorkflowServiceItemInputDefinitionType;
            ObjectType = WorkflowServiceItemInputDefinitionType.ObjectTypeEnum.WorkflowServiceItemInputDefinitionType;

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

        public WorkflowServiceItemInputDefinitionType.ClassIdEnum ClassId
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
        /// <para type="description">"Capture the mapping of service item ActionDefinition inputDefinition to catalog service request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object InputParameters
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowServiceItemInputDefinitionType.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specify the service item action for which input definition is associated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.MoMoRef ServiceItemActionDefinition
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowServiceItemInputDefinitionType initObject = new Intersight.Model.WorkflowServiceItemInputDefinitionType();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("InputDefinition"))
            {
                initObject.InputDefinition = this.InputDefinition;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InputParameters"))
            {
                initObject.InputParameters = this.InputParameters;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ServiceItemActionDefinition"))
            {
                initObject.ServiceItemActionDefinition = this.ServiceItemActionDefinition;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowServiceItemInstance.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowServiceItemInstance")]
    public class InitializeIntersightWorkflowServiceItemInstance : PSCmdlet
    {
        public InitializeIntersightWorkflowServiceItemInstance()
        {
            ClassId = WorkflowServiceItemInstance.ClassIdEnum.WorkflowServiceItemInstance;
            ObjectType = WorkflowServiceItemInstance.ObjectTypeEnum.WorkflowServiceItemInstance;

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

        public WorkflowServiceItemInstance.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The description for this service item instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamIdp resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamIdpRelationship Idp
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a iamIdpReference resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamIdpReferenceRelationship IdpReference
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user friendly short name to identify the resource. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.), colon (:), space ( ) or an underscore (_)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\sa-zA-Z0-9_.:-]{1,92}$")]
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
        /// <para type="description">"A name of the service item instance. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.) or an underscore (_)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+[\\sa-zA-Z0-9_.:-]{1,92}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowServiceItemInstance.ObjectTypeEnum ObjectType
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
        /// <para type="description">"A reference to a workflowServiceItemDefinition resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowServiceItemDefinitionRelationship ServiceItemDefinition
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
        /// <para type="description">"A reference to a iamUser resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamUserRelationship User
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowServiceItemInstance initObject = new Intersight.Model.WorkflowServiceItemInstance();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Idp"))
            {
                initObject.Idp = this.Idp;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IdpReference"))
            {
                initObject.IdpReference = this.IdpReference;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Organization"))
            {
                initObject.Organization = this.Organization;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ServiceItemDefinition"))
            {
                initObject.ServiceItemDefinition = this.ServiceItemDefinition;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("User"))
            {
                initObject.User = this.User;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowServiceItemOutput.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowServiceItemOutput")]
    public class InitializeIntersightWorkflowServiceItemOutput : PSCmdlet
    {
        public InitializeIntersightWorkflowServiceItemOutput()
        {
            ClassId = WorkflowServiceItemOutput.ClassIdEnum.WorkflowServiceItemOutput;
            ObjectType = WorkflowServiceItemOutput.ObjectTypeEnum.WorkflowServiceItemOutput;

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

        public WorkflowServiceItemOutput.ClassIdEnum ClassId
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
        /// <para type="description">"Output name which is used in the output definition of the service item."</para>
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

        public WorkflowServiceItemOutput.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Service item output for a service item instance and the format is specified by output definition of the service item definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Output
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a workflowServiceItemInstance resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowServiceItemInstanceRelationship ServiceItemInstance
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
            Intersight.Model.WorkflowServiceItemOutput initObject = new Intersight.Model.WorkflowServiceItemOutput();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Output"))
            {
                initObject.Output = this.Output;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ServiceItemInstance"))
            {
                initObject.ServiceItemInstance = this.ServiceItemInstance;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowServiceItemType.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowServiceItemType")]
    public class InitializeIntersightWorkflowServiceItemType : PSCmdlet
    {
        public InitializeIntersightWorkflowServiceItemType()
        {
            ClassId = WorkflowServiceItemType.ClassIdEnum.WorkflowServiceItemType;
            ObjectType = WorkflowServiceItemType.ObjectTypeEnum.WorkflowServiceItemType;

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

        public WorkflowServiceItemType.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The description of this service item."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the service item as defined by the user."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+[\\sa-zA-Z0-9_.:-]{1,92}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowServiceItemType.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specify the service items that are associated with the catalog item."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.MoMoRef ServiceItemDefinition
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.WorkflowServiceItemInputDefinitionType> ServiceItemInputDefinition
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowServiceItemType initObject = new Intersight.Model.WorkflowServiceItemType();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ServiceItemDefinition"))
            {
                initObject.ServiceItemDefinition = this.ServiceItemDefinition;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ServiceItemInputDefinition"))
            {
                initObject.ServiceItemInputDefinition = this.ServiceItemInputDefinition;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowSshBatchExecutor.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowSshBatchExecutor")]
    public class InitializeIntersightWorkflowSshBatchExecutor : PSCmdlet
    {
        public InitializeIntersightWorkflowSshBatchExecutor()
        {
            ClassId = WorkflowSshBatchExecutor.ClassIdEnum.WorkflowSshBatchExecutor;
            ObjectType = WorkflowSshBatchExecutor.ObjectTypeEnum.WorkflowSshBatchExecutor;

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

        public List<Model.WorkflowApi> Batch
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.WorkflowApi> CancelAction
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowSshBatchExecutor.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enter the constraints on when this task should match against the task definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowTaskConstraints Constraints
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A detailed description about the batch APIs."</para>
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
        /// <para type="description">"Name for the batch API task."</para>
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

        public WorkflowSshBatchExecutor.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"All the possible outcomes of this task are captured here. Outcomes property\nis a collection property of type workflow.Outcome objects.\nThe outcomes can be mapped to the message to be shown. The outcomes are\nevaluated in the order they are given. At the end of the outcomes list,\nan catchall success/fail outcome can be added with condition as 'true'.\nThis is an optional\nproperty and if not specified the task will be marked as success."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Outcomes
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Intersight Orchestrator allows the extraction of required values from API\nresponses using the API response grammar. These extracted values can be mapped\nto task output parameters defined in task definition.\nThe mapping of API output parameters to the task output parameters is provided\nas JSON in this property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Output
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When an execution of a nth API in the Batch fails,\nRetry from failed API flag indicates if the execution should start from the nth API or the first API during task retry.\nBy default the value is set to false."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool RetryFromFailedApi
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The skip expression, if provided, allows the batch API executor to skip the\ntask execution when the given expression evaluates to true.\nThe expression is given as such a golang template that has to be\nevaluated to a final content true/false. The expression is an optional and in\ncase not provided, the API will always be executed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SkipOnCondition
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
        /// <para type="description">"A reference to a workflowTaskDefinition resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowTaskDefinitionRelationship TaskDefinition
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This will hold the data needed for task to be rendered in the user interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object UiRenderingData
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowSshBatchExecutor initObject = new Intersight.Model.WorkflowSshBatchExecutor();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Batch"))
            {
                initObject.Batch = this.Batch;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CancelAction"))
            {
                initObject.CancelAction = this.CancelAction;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Constraints"))
            {
                initObject.Constraints = this.Constraints;
            }
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Outcomes"))
            {
                initObject.Outcomes = this.Outcomes;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Output"))
            {
                initObject.Output = this.Output;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RetryFromFailedApi"))
            {
                initObject.RetryFromFailedApi = this.RetryFromFailedApi;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SkipOnCondition"))
            {
                initObject.SkipOnCondition = this.SkipOnCondition;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TaskDefinition"))
            {
                initObject.TaskDefinition = this.TaskDefinition;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UiRenderingData"))
            {
                initObject.UiRenderingData = this.UiRenderingData;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowSshCmd.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowSshCmd")]
    public class InitializeIntersightWorkflowSshCmd : PSCmdlet
    {
        public InitializeIntersightWorkflowSshCmd()
        {
            ClassId = WorkflowSshCmd.ClassIdEnum.WorkflowSshCmd;
            ObjectType = WorkflowSshCmd.ObjectTypeEnum.WorkflowSshCmd;

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

        public WorkflowSshCmd.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SSH command to execute on the remote server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Command
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SSH command type to execute on the remote server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string CommandType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The secure properties that have large text content as value can be encrypted using AES key. In these cases, the AES key needs to be encrypted using the device connector's public key and passed as the value for this property.\nThe secure properties that are encrypted using the AES key are mapped against the property name with prefix 'AES' in SecureProperties dictionary."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EncryptedAesKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The public key that was used to encrypt the values present in SecureProperties dictionary.\nIf the given public key is not the same as device connector's public key, an error response with appropriate error message is thrown back."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EncryptionKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SSH prompts required as part of command execution. It is a collection of ExpectPrompt complex type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object ExpectPrompts
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowSshCmd.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A dictionary of encrypted secure values mapped against the secure property name. The values that are encrypted using the AES key must be mapped against the secure property name with an 'AES' prefix\nDevice connector expects the message body to be a golang template and the template can use the secure property names as placeholders."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object SecureProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Regex of the remote server's shell prompt."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ShellPrompt
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Expect timeout value in seconds for the shell prompt."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long ShellPromptTimeout
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowSshCmd initObject = new Intersight.Model.WorkflowSshCmd();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Command"))
            {
                initObject.Command = this.Command;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CommandType"))
            {
                initObject.CommandType = this.CommandType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EncryptedAesKey"))
            {
                initObject.EncryptedAesKey = this.EncryptedAesKey;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EncryptionKey"))
            {
                initObject.EncryptionKey = this.EncryptionKey;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ExpectPrompts"))
            {
                initObject.ExpectPrompts = this.ExpectPrompts;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SecureProperties"))
            {
                initObject.SecureProperties = this.SecureProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ShellPrompt"))
            {
                initObject.ShellPrompt = this.ShellPrompt;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ShellPromptTimeout"))
            {
                initObject.ShellPromptTimeout = this.ShellPromptTimeout;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowSshConfig.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowSshConfig")]
    public class InitializeIntersightWorkflowSshConfig : PSCmdlet
    {
        public InitializeIntersightWorkflowSshConfig()
        {
            ClassId = WorkflowSshConfig.ClassIdEnum.WorkflowSshConfig;
            ObjectType = WorkflowSshConfig.ObjectTypeEnum.WorkflowSshConfig;

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

        public WorkflowSshConfig.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The secure properties that have large text content as value can be encrypted using AES key. In these cases, the AES key needs to be encrypted using the device connector's public key and passed as the value for this property.\nThe secure properties that are encrypted using the AES key are mapped against the property name with prefix 'AES' in SecureProperties dictionary."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EncryptedAesKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The public key that was used to encrypt the values present in SecureProperties dictionary.\nIf the given public key is not the same as device connector's public key, an error response with appropriate error message is thrown back."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string EncryptionKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowSshConfig.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Optional passphrase if provided while creating the private key."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Passphrase
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Password to use in the SSH connection credentials (If empty, private key will be used)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Password
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"PEM encoded private key to be used in the SSH connection credentials (Optional if password is given)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PrivateKey
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A dictionary of encrypted secure values mapped against the secure property name. The values that are encrypted using the AES key must be mapped against the secure property name with an 'AES' prefix\nDevice connector expects the message body to be a golang template and the template can use the secure property names as placeholders."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object SecureProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The remote server to connect to. IPv4 address represented in dot decimal notation or hostname can be\nspecified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Target
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Username for the remote SSH connection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string User
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowSshConfig initObject = new Intersight.Model.WorkflowSshConfig();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("EncryptedAesKey"))
            {
                initObject.EncryptedAesKey = this.EncryptedAesKey;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EncryptionKey"))
            {
                initObject.EncryptionKey = this.EncryptionKey;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Passphrase"))
            {
                initObject.Passphrase = this.Passphrase;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Password"))
            {
                initObject.Password = this.Password;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PrivateKey"))
            {
                initObject.PrivateKey = this.PrivateKey;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SecureProperties"))
            {
                initObject.SecureProperties = this.SecureProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Target"))
            {
                initObject.Target = this.Target;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("User"))
            {
                initObject.User = this.User;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowSshSession.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowSshSession")]
    public class InitializeIntersightWorkflowSshSession : PSCmdlet
    {
        public InitializeIntersightWorkflowSshSession()
        {
            ClassId = WorkflowSshSession.ClassIdEnum.WorkflowSshSession;
            MessageType = WorkflowSshSession.MessageTypeEnum.ExecuteCommand;
            ObjectType = WorkflowSshSession.ObjectTypeEnum.WorkflowSshSession;

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
        /// <para type="description">"The optional request body that is sent as part of this API request.\nThe request body can contain a golang template that can be populated with task input\nparameters and previous API output parameters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Body
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Flag to allow capturing entire command response as batch API output."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string CaptureCompleteResponse
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowSshSession.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Intersight Orchestrator, with the support of response parser specification,\ncan extract the values from API responses and map them to task output parameters.\nThe value extraction is supported for response content types XML, JSON and Text.\nThe type of the content that gets passed as payload and response in this\nAPI. The supported values are json, xml, text."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ContentType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A description that task designer can add to individual API requests that explain \nwhat the API call is about."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Intersight Orchestrator, with the support of response parser specification,\ncan extract the values from API responses and map them to task output parameters.\nThe value extraction is supported for response content types XML, JSON and Text.\nOptional input to specify the content type in case of error API response. This\nshould be used if the content type of error response is different from that of\nthe success response. If not specified, contentType input value is used to parse\nthe error response."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ErrorContentType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Optional array of integer values to specify the expected exit codes of a SSH command execution. SSH command\nexecution is marked success upon receiving any of the expected exit code from command execution. If not set, success\nexit code of 0 is expected from command execution."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object ExpectedExitCodes
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Message to transfer a file from Intersight connected device to remote server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowFileTransfer FileTransferToRemote
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user friendly label that task designers have given to the batch API request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of SSH message to be sent to the remote server.\n* `ExecuteCommand` - Execute a SSH command on the remote server.\n* `NewSession` - Open a new SSH connection to the remote server.\n* `FileTransfer` - Transfer a file from Intersight connected device to the remote server.\n* `CloseSession` - Close the SSH connection to the remote server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowSshSession.MessageTypeEnum MessageType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference name for this API request within the batch API request.\nThis name shall be used to map the API output parameters to subsequent\nAPI input parameters within a batch API task."</para>
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

        public WorkflowSshSession.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"All the possible outcomes of this API are captured here. Outcomes property\nis a collection property of type workflow.Outcome objects.\nThe outcomes can be mapped to the message to be shown. The outcomes are\nevaluated in the order they are given. At the end of the outcomes list,\nan catchall success/fail outcome can be added with condition as 'true'.\nThis is an optional\nproperty and if not specified the task will be marked as success."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Outcomes
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The optional grammar specification for parsing the response to extract the\nrequired values.\nThe specification should have extraction specification specified for\nall the API output parameters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object ResponseSpec
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The skip expression, if provided, allows the batch API executor to skip the\napi execution when the given expression evaluates to true.\nThe expression is given as such a golang template that has to be\nevaluated to a final content true/false. The expression is an optional and in\ncase not provided, the API will always be executed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SkipOnCondition
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SSH command to execute on the remote server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object SshCommand
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Carries the SSH session details for opening a new connection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowSshConfig SshConfiguration
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SSH operation timeout value in seconds. The provided string value should be able to convert to\nrespective integer value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SshOpTimeout
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The delay in seconds after which the API needs to be executed.\nBy default, the given API is executed immediately. Specifying a start delay adds to the delay to execution.\nStart Delay is not supported for the first API in the Batch and cumulative delay of all the APIs in the Batch should not exceed the task time out."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long StartDelay
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The duration in seconds by which the API response is expected from the API target.\nIf the end point does not respond for the API request within this timeout\nduration, the task will be marked as failed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Timeout
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowSshSession initObject = new Intersight.Model.WorkflowSshSession();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Body"))
            {
                initObject.Body = this.Body;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CaptureCompleteResponse"))
            {
                initObject.CaptureCompleteResponse = this.CaptureCompleteResponse;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ContentType"))
            {
                initObject.ContentType = this.ContentType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ErrorContentType"))
            {
                initObject.ErrorContentType = this.ErrorContentType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ExpectedExitCodes"))
            {
                initObject.ExpectedExitCodes = this.ExpectedExitCodes;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FileTransferToRemote"))
            {
                initObject.FileTransferToRemote = this.FileTransferToRemote;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MessageType"))
            {
                initObject.MessageType = this.MessageType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Outcomes"))
            {
                initObject.Outcomes = this.Outcomes;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ResponseSpec"))
            {
                initObject.ResponseSpec = this.ResponseSpec;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SkipOnCondition"))
            {
                initObject.SkipOnCondition = this.SkipOnCondition;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SshCommand"))
            {
                initObject.SshCommand = this.SshCommand;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SshConfiguration"))
            {
                initObject.SshConfiguration = this.SshConfiguration;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SshOpTimeout"))
            {
                initObject.SshOpTimeout = this.SshOpTimeout;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StartDelay"))
            {
                initObject.StartDelay = this.StartDelay;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Timeout"))
            {
                initObject.Timeout = this.Timeout;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowStartTask.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowStartTask")]
    public class InitializeIntersightWorkflowStartTask : PSCmdlet
    {
        public InitializeIntersightWorkflowStartTask()
        {
            ClassId = WorkflowStartTask.ClassIdEnum.WorkflowStartTask;
            ObjectType = WorkflowStartTask.ObjectTypeEnum.WorkflowStartTask;

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

        public WorkflowStartTask.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The description of this task instance in the workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user defined label identifier of the workflow task used for UI display."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the task within the workflow and it must be unique among all WorkflowTasks within a workflow definition. This name serves as the internal unique identifier for the task and is used to pick input and output parameters to feed into other tasks."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the next task (Task names unique within workflow) to run.  In a graph model, denotes an edge to another Task Node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string NextTask
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowStartTask.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowStartTask initObject = new Intersight.Model.WorkflowStartTask();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NextTask"))
            {
                initObject.NextTask = this.NextTask;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowSubWorkflowTask.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowSubWorkflowTask")]
    public class InitializeIntersightWorkflowSubWorkflowTask : PSCmdlet
    {
        public InitializeIntersightWorkflowSubWorkflowTask()
        {
            ClassId = WorkflowSubWorkflowTask.ClassIdEnum.WorkflowSubWorkflowTask;
            ObjectType = WorkflowSubWorkflowTask.ObjectTypeEnum.WorkflowSubWorkflowTask;

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
        /// <para type="description">"Specify the catalog moid that this task belongs."</para>
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

        public WorkflowSubWorkflowTask.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The description of this task instance in the workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"JSON formatted key-value pairs that define the inputs given to the task. Mapping for task inputs can be provided as either static values, direct mapping or advanced mapping using templates. The direct mapping can be specified as '${Source.< input | output | variable>.<JSONPath>}'. 'Source' can be either workflow or the name of an earlier task within the workflow. You can map the task input to either a workflow input, a task output or a variable. Golang template syntax is supported for advanced mapping. A simple flattened example is \"InputParameters\":{ \"input1\":\"${workflow.variable.var1}\", \"input2\":\"prefixStr_{{.global.workflow.input.input1}}\" } where task input1 is mapped directly to variable var1 and task input2 is using a template to prefix a string to workflow input1 and then assign that value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object InputParameters
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user defined label identifier of the workflow task used for UI display."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the task within the workflow and it must be unique among all WorkflowTasks within a workflow definition. This name serves as the internal unique identifier for the task and is used to pick input and output parameters to feed into other tasks."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowSubWorkflowTask.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This specifies the name of the next task to run if Task fails.  This is the unique name given to the task instance within the workflow. In a graph model, denotes an edge to another Task Node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string OnFailure
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This specifies the name of the next task to run if Task succeeds.  This is the unique name given to the task instance within the workflow. In a graph model, denotes an edge to another Task Node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string OnSuccess
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The task is disabled/enabled for rollback operation in this workflow if the task has rollback support."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool RollbackDisabled
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"JSON formatted key-value pairs that perform variable update at the end of the task execution. Mapping for variables can be provided as either static values, direct mapping or advanced mapping using templates. The direct mapping can be specified as '${Source.< input | output | variable>.<JSONPath>}'. 'Source' can be either workflow or the name of the current or an earlier task within the workflow. You can map the variable to either a workflow input, a task output or another variable. Golang template syntax is supported for advanced mapping. A simple flattened example is \"VariableParameters\":{ \"var1\":\"${task1.output.output1}\", \"var2\":\"{{ Itoa .global.workflow.variable.varInt}}\" } where variable var1 is mapped directly to output1 of task1 and variable var2 is using a template to convert another variable varInt to string and assign that value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object VariableParameters
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The workflow definition version to use as subworkflow. When no version is specified then the default version of the workflow at the time of creating or updating this workflow is used."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Version
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The qualified name of workflow that should be executed as a task."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string WorkflowDefinitionName
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowSubWorkflowTask initObject = new Intersight.Model.WorkflowSubWorkflowTask();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OnFailure"))
            {
                initObject.OnFailure = this.OnFailure;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("OnSuccess"))
            {
                initObject.OnSuccess = this.OnSuccess;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RollbackDisabled"))
            {
                initObject.RollbackDisabled = this.RollbackDisabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VariableParameters"))
            {
                initObject.VariableParameters = this.VariableParameters;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject.VarVersion = this.Version;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("WorkflowDefinitionName"))
            {
                initObject.WorkflowDefinitionName = this.WorkflowDefinitionName;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowSuccessEndTask.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowSuccessEndTask")]
    public class InitializeIntersightWorkflowSuccessEndTask : PSCmdlet
    {
        public InitializeIntersightWorkflowSuccessEndTask()
        {
            ClassId = WorkflowSuccessEndTask.ClassIdEnum.WorkflowSuccessEndTask;
            ObjectType = WorkflowSuccessEndTask.ObjectTypeEnum.WorkflowSuccessEndTask;

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

        public WorkflowSuccessEndTask.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The description of this task instance in the workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user defined label identifier of the workflow task used for UI display."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the task within the workflow and it must be unique among all WorkflowTasks within a workflow definition. This name serves as the internal unique identifier for the task and is used to pick input and output parameters to feed into other tasks."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowSuccessEndTask.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowSuccessEndTask initObject = new Intersight.Model.WorkflowSuccessEndTask();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowTargetContext.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowTargetContext")]
    public class InitializeIntersightWorkflowTargetContext : PSCmdlet
    {
        public InitializeIntersightWorkflowTargetContext()
        {
            ClassId = WorkflowTargetContext.ClassIdEnum.WorkflowTargetContext;
            ObjectType = WorkflowTargetContext.ObjectTypeEnum.WorkflowTargetContext;

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

        public WorkflowTargetContext.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowTargetContext.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowTargetContext initObject = new Intersight.Model.WorkflowTargetContext();
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowTargetDataType.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowTargetDataType")]
    public class InitializeIntersightWorkflowTargetDataType : PSCmdlet
    {
        public InitializeIntersightWorkflowTargetDataType()
        {
            ClassId = WorkflowTargetDataType.ClassIdEnum.WorkflowTargetDataType;
            ObjectType = WorkflowTargetDataType.ObjectTypeEnum.WorkflowTargetDataType;

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

        public WorkflowTargetDataType.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Reference to custom data type definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowCustomDataProperty CustomDataTypeProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Default value for the data type. If default value was provided and the input was required the default value will be used as the input."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowDefaultValue Default
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Provide a detailed description of the data type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Captures the meta data needed for displaying workflow data types in Intersight User Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowDisplayMeta DisplayMeta
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"JSON formatted mapping from other property of the definition to the current property. Input parameter mapping is supported only for custom data type property in workflow definition and custom data type definition. The format to specify mapping ina workflow definition when source property is of scalar types is '${workflow.input.property}'. The format to specify mapping when the source property is of object reference and mapping needs to be made to the property of the object is '${workflow.input.property.subproperty}'. The format to specify mapping in a custom data type definition is '${datatype.type.property}'. When the current property is of non-scalar type like composite custom data type, then mapping can be provided to the individual property of the custom data type like 'cdt_property:${workflow.input.property}'."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object InputParameters
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When this property is true then an array of targets can be passed as input."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsArray
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Descriptive label for the data type. Label can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), space ( ), forward slash (/) or an underscore (_). The first and last character in label must be an alphanumeric character."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+[\\sa-zA-Z0-9_'.:/-]{1,92}$")]
        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specify the maximum value of the array."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Max
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specify the minimum value of the array."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Min
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Descriptive name for the data type. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-) or an underscore (_). The first and last character in name must be an alphanumeric character."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+([a-zA-Z0-9-_]*[a-zA-Z0-9])*$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowTargetDataType.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.WorkflowTargetProperty> Properties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specifies whether this parameter is required. The field is applicable for task and workflow."</para>
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
            Intersight.Model.WorkflowTargetDataType initObject = new Intersight.Model.WorkflowTargetDataType();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CustomDataTypeProperties"))
            {
                initObject.CustomDataTypeProperties = this.CustomDataTypeProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Default"))
            {
                initObject.Default = this.Default;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DisplayMeta"))
            {
                initObject.DisplayMeta = this.DisplayMeta;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InputParameters"))
            {
                initObject.InputParameters = this.InputParameters;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsArray"))
            {
                initObject.IsArray = this.IsArray;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Max"))
            {
                initObject.Max = this.Max;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Min"))
            {
                initObject.Min = this.Min;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Properties"))
            {
                initObject.Properties = this.Properties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Required"))
            {
                initObject.Required = this.Required;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowTargetProperty.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowTargetProperty")]
    public class InitializeIntersightWorkflowTargetProperty : PSCmdlet
    {
        public InitializeIntersightWorkflowTargetProperty()
        {
            ClassId = WorkflowTargetProperty.ClassIdEnum.WorkflowTargetProperty;
            ObjectType = WorkflowTargetProperty.ObjectTypeEnum.WorkflowTargetProperty;

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

        public WorkflowTargetProperty.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A singleton value which will contain the path to connector object from the selected object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ConnectorAttribute
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> ConstraintAttributes
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> DisplayAttributes
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowTargetProperty.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Field to hold an Intersight API along with an optional filter to narrow down the search options for target device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|/api/v1/.*")]
        public string Selector
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Selector properties to define HTTP method and 'body' in case of upsert operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowSelectorProperty SelectorProperty
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> SupportedObjects
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowTargetProperty initObject = new Intersight.Model.WorkflowTargetProperty();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ConnectorAttribute"))
            {
                initObject.ConnectorAttribute = this.ConnectorAttribute;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ConstraintAttributes"))
            {
                initObject.ConstraintAttributes = this.ConstraintAttributes;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DisplayAttributes"))
            {
                initObject.DisplayAttributes = this.DisplayAttributes;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Selector"))
            {
                initObject.Selector = this.Selector;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SelectorProperty"))
            {
                initObject.SelectorProperty = this.SelectorProperty;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SupportedObjects"))
            {
                initObject.SupportedObjects = this.SupportedObjects;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowTaskConstraints.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowTaskConstraints")]
    public class InitializeIntersightWorkflowTaskConstraints : PSCmdlet
    {
        public InitializeIntersightWorkflowTaskConstraints()
        {
            ClassId = WorkflowTaskConstraints.ClassIdEnum.WorkflowTaskConstraints;
            ObjectType = WorkflowTaskConstraints.ObjectTypeEnum.WorkflowTaskConstraints;

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

        public WorkflowTaskConstraints.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowTaskConstraints.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"List of property constraints that helps to narrow down task implementations based on target device input."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object TargetDataType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowTaskConstraints initObject = new Intersight.Model.WorkflowTaskConstraints();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("TargetDataType"))
            {
                initObject.TargetDataType = this.TargetDataType;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowTaskDebugLog.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowTaskDebugLog")]
    public class InitializeIntersightWorkflowTaskDebugLog : PSCmdlet
    {
        public InitializeIntersightWorkflowTaskDebugLog()
        {
            ClassId = WorkflowTaskDebugLog.ClassIdEnum.WorkflowTaskDebugLog;
            ObjectType = WorkflowTaskDebugLog.ObjectTypeEnum.WorkflowTaskDebugLog;

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

        public WorkflowTaskDebugLog.ClassIdEnum ClassId
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

        public WorkflowTaskDebugLog.ObjectTypeEnum ObjectType
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
        /// <para type="description">"A reference to a workflowTaskInfo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowTaskInfoRelationship TaskInfo
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a workflowWorkflowInfo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowWorkflowInfoRelationship WorkflowInfo
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowTaskDebugLog initObject = new Intersight.Model.WorkflowTaskDebugLog();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("TaskInfo"))
            {
                initObject.TaskInfo = this.TaskInfo;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("WorkflowInfo"))
            {
                initObject.WorkflowInfo = this.WorkflowInfo;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowTaskDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowTaskDefinition")]
    public class InitializeIntersightWorkflowTaskDefinition : PSCmdlet
    {
        public InitializeIntersightWorkflowTaskDefinition()
        {
            ClassId = WorkflowTaskDefinition.ClassIdEnum.WorkflowTaskDefinition;
            ObjectType = WorkflowTaskDefinition.ObjectTypeEnum.WorkflowTaskDefinition;

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

        public WorkflowTaskDefinition.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When true this will be the task version that is used when a specific task definition version is not specified. The very first task definition created with a name will be set as the default version, after that user can explicitly set any version of the task definition as the default version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool DefaultVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user friendly description about task on what operations are done as part of the task execution and any other specific information about task input and output."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to workflowTaskDefinition resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.WorkflowTaskDefinitionRelationship> ImplementedTasks
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a workflowTaskDefinition resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowTaskDefinitionRelationship InterfaceTask
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user friendly short name to identify the task definition. Label can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.), colon (:), space ( ), single quote ('), forward slash (/), or an underscore (_) and must be at least 2 characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]{1}[\\sa-zA-Z0-9_'./:-]{0,91}$")]
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
        /// <para type="description">"The name of the task definition. The name should follow this convention <Verb or Action><Category><Vendor><Product><Noun or object> Verb or Action is a required portion of the name and this must be part of the pre-approved verb list. Category is an optional field and this will refer to the broad category of the task referring to the type of resource or endpoint. If there is no specific category then use \"Generic\" if required. Vendor is an optional field and this will refer to the specific vendor this task applies to. If the task is generic and not tied to a vendor, then do not specify anything. Product is an optional field, this will contain the vendor product and model when desired. Noun or object is a required field and  this will contain the noun or object on which the action is being performed. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.), colon (:), or an underscore (_). Examples SendEmail  - This is a task in Generic category for sending email. NewStorageVolume - This is a vendor agnostic task under Storage device category for creating a new volume."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]{1}[a-zA-Z0-9_.:-]{0,63}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowTaskDefinition.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type to capture all the properties for the task definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowProperties Properties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.WorkflowRollbackTask> RollbackTasks
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
        /// <para type="description">"A reference to a workflowTaskMetadata resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowTaskMetadataRelationship TaskMetadata
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The version of the task definition so we can support multiple versions of a task definition."</para>
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
            Intersight.Model.WorkflowTaskDefinition initObject = new Intersight.Model.WorkflowTaskDefinition();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("ImplementedTasks"))
            {
                initObject.ImplementedTasks = this.ImplementedTasks;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InterfaceTask"))
            {
                initObject.InterfaceTask = this.InterfaceTask;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Properties"))
            {
                initObject.Properties = this.Properties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RollbackTasks"))
            {
                initObject.RollbackTasks = this.RollbackTasks;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TaskMetadata"))
            {
                initObject.TaskMetadata = this.TaskMetadata;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject.VarVersion = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowTaskInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowTaskInfo")]
    public class InitializeIntersightWorkflowTaskInfo : PSCmdlet
    {
        public InitializeIntersightWorkflowTaskInfo()
        {
            ClassId = WorkflowTaskInfo.ClassIdEnum.WorkflowTaskInfo;
            ObjectType = WorkflowTaskInfo.ObjectTypeEnum.WorkflowTaskInfo;

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

        public WorkflowTaskInfo.ClassIdEnum ClassId
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

        public WorkflowTaskInfo.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The status of the task and this will specify if the task is running or has reached a final state."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Status
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
            Intersight.Model.WorkflowTaskInfo initObject = new Intersight.Model.WorkflowTaskInfo();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Status"))
            {
                initObject.Status = this.Status;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowTaskInfoUpdate.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowTaskInfoUpdate")]
    public class InitializeIntersightWorkflowTaskInfoUpdate : PSCmdlet
    {
        public InitializeIntersightWorkflowTaskInfoUpdate()
        {
            ClassId = WorkflowTaskInfoUpdate.ClassIdEnum.WorkflowTaskInfoUpdate;
            ObjectType = WorkflowTaskInfoUpdate.ObjectTypeEnum.WorkflowTaskInfoUpdate;
            Status = WorkflowTaskInfoUpdate.StatusEnum.Scheduled;

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

        public WorkflowTaskInfoUpdate.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Inputs for the specified TaskInfo. Inputs must only be provided for tasks which has included an input definition and the inputs must match the constraints specified in the input definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Input
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the task being updated and this name must match the task instance name included inside the workflow definition. This name is also captured in the RefName property of the TaskInfo object for the task."</para>
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

        public WorkflowTaskInfoUpdate.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"New status of the task being updated, only Failed and Completed statuses are supported, Completed is the default value in case no status is provided.\n* `Scheduled` - The enum represents the status when task is in scheduled state.\n* `InProgress` - The enum represents the status when task is in-progress state.\n* `NoOp` - The enum represents the status when task is a noop.\n* `Timeout` - The enum represents the status when task has timed out.\n* `Completed` - The enum represents the status when task has completed.\n* `Failed` - The enum represents the status when task has failed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowTaskInfoUpdate.StatusEnum Status
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowTaskInfoUpdate initObject = new Intersight.Model.WorkflowTaskInfoUpdate();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Status"))
            {
                initObject.Status = this.Status;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowTaskLoopInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowTaskLoopInfo")]
    public class InitializeIntersightWorkflowTaskLoopInfo : PSCmdlet
    {
        public InitializeIntersightWorkflowTaskLoopInfo()
        {
            ClassId = WorkflowTaskLoopInfo.ClassIdEnum.WorkflowTaskLoopInfo;
            ObjectType = WorkflowTaskLoopInfo.ObjectTypeEnum.WorkflowTaskLoopInfo;

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

        public WorkflowTaskLoopInfo.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowTaskLoopInfo.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowTaskLoopInfo initObject = new Intersight.Model.WorkflowTaskLoopInfo();
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowTaskMetadata.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowTaskMetadata")]
    public class InitializeIntersightWorkflowTaskMetadata : PSCmdlet
    {
        public InitializeIntersightWorkflowTaskMetadata()
        {
            ClassId = WorkflowTaskMetadata.ClassIdEnum.WorkflowTaskMetadata;
            ObjectType = WorkflowTaskMetadata.ObjectTypeEnum.WorkflowTaskMetadata;

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
        /// <para type="description">"An array of relationships to iamRole resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.IamRoleRelationship> AssociatedRoles
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

        public WorkflowTaskMetadata.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The task metadata description to describe what this task will do when executed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user friendly short name to identify the task metadata."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]{1}[\\sa-zA-Z0-9_'.:-]{0,92}$")]
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
        /// <para type="description">"The name of the task metadata. The name should follow this convention <Verb or Action><Category><Vendor><Product><Noun or object> Verb or Action is a required portion of the name and this must be part of the pre-approved verb list. Category is an optional field and this will refer to the broad category of the task referring to the type of resource or endpoint. If there is no specific category then use \"Generic\" if required. Vendor is an optional field and this will refer to the specific vendor this task applies to. If the task is generic and not tied to a vendor, then do not specify anything. Product is an optional field, this will contain the vendor product and model when desired. Noun or object is a required field and  this will contain the noun or object on which the action is being performed. Examples SendEmail  - This is a task in Generic category for sending email. NewStorageVolume - This is a vendor agnostic task under Storage device category for creating a new volume."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]{1}[a-zA-Z0-9_.:-]{0,63}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowTaskMetadata.ObjectTypeEnum ObjectType
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
            Intersight.Model.WorkflowTaskMetadata initObject = new Intersight.Model.WorkflowTaskMetadata();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AssociatedRoles"))
            {
                initObject.AssociatedRoles = this.AssociatedRoles;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Catalog"))
            {
                initObject.Catalog = this.Catalog;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowTaskRetryInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowTaskRetryInfo")]
    public class InitializeIntersightWorkflowTaskRetryInfo : PSCmdlet
    {
        public InitializeIntersightWorkflowTaskRetryInfo()
        {
            ClassId = WorkflowTaskRetryInfo.ClassIdEnum.WorkflowTaskRetryInfo;
            ObjectType = WorkflowTaskRetryInfo.ObjectTypeEnum.WorkflowTaskRetryInfo;

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

        public WorkflowTaskRetryInfo.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowTaskRetryInfo.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowTaskRetryInfo initObject = new Intersight.Model.WorkflowTaskRetryInfo();
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowTemplateEvaluation.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowTemplateEvaluation")]
    public class InitializeIntersightWorkflowTemplateEvaluation : PSCmdlet
    {
        public InitializeIntersightWorkflowTemplateEvaluation()
        {
            ClassId = WorkflowTemplateEvaluation.ClassIdEnum.WorkflowTemplateEvaluation;
            ObjectType = WorkflowTemplateEvaluation.ObjectTypeEnum.WorkflowTemplateEvaluation;

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

        public WorkflowTemplateEvaluation.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Expected output type of the template. Required to type cast the output."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowBaseDataType ExpectedOutputDataType
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

        public WorkflowTemplateEvaluation.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.TemplateTransformationStage> Stages
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
        /// <para type="description">"Values to be fed to the template for execution."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Values
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowTemplateEvaluation initObject = new Intersight.Model.WorkflowTemplateEvaluation();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ExpectedOutputDataType"))
            {
                initObject.ExpectedOutputDataType = this.ExpectedOutputDataType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Stages"))
            {
                initObject.Stages = this.Stages;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Values"))
            {
                initObject.Values = this.Values;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowTemplateFunctionMeta.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowTemplateFunctionMeta")]
    public class InitializeIntersightWorkflowTemplateFunctionMeta : PSCmdlet
    {
        public InitializeIntersightWorkflowTemplateFunctionMeta()
        {
            ClassId = WorkflowTemplateFunctionMeta.ClassIdEnum.WorkflowTemplateFunctionMeta;
            ObjectType = WorkflowTemplateFunctionMeta.ObjectTypeEnum.WorkflowTemplateFunctionMeta;

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

        public WorkflowTemplateFunctionMeta.ClassIdEnum ClassId
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

        public WorkflowTemplateFunctionMeta.ObjectTypeEnum ObjectType
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
            Intersight.Model.WorkflowTemplateFunctionMeta initObject = new Intersight.Model.WorkflowTemplateFunctionMeta();
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowTemplateParser.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowTemplateParser")]
    public class InitializeIntersightWorkflowTemplateParser : PSCmdlet
    {
        public InitializeIntersightWorkflowTemplateParser()
        {
            ClassId = WorkflowTemplateParser.ClassIdEnum.WorkflowTemplateParser;
            ObjectType = WorkflowTemplateParser.ObjectTypeEnum.WorkflowTemplateParser;

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

        public WorkflowTemplateParser.ClassIdEnum ClassId
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

        public WorkflowTemplateParser.ObjectTypeEnum ObjectType
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
        /// <para type="description">"The content of the entire template file. The content\ncan either be a static or dynamic file that can contain placeholders.\nThe placeholders are expected to conform to the golang template syntax i.e. it must be provided inside {{ }}."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string TemplateContent
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowTemplateParser initObject = new Intersight.Model.WorkflowTemplateParser();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("TemplateContent"))
            {
                initObject.TemplateContent = this.TemplateContent;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowUiDisplayMetadata.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowUiDisplayMetadata")]
    public class InitializeIntersightWorkflowUiDisplayMetadata : PSCmdlet
    {
        public InitializeIntersightWorkflowUiDisplayMetadata()
        {
            ClassId = WorkflowUiDisplayMetadata.ClassIdEnum.WorkflowUiDisplayMetadata;
            ObjectType = WorkflowUiDisplayMetadata.ObjectTypeEnum.WorkflowUiDisplayMetadata;

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

        public WorkflowUiDisplayMetadata.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.MoBaseMoRelationship MetaDefinition
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

        public WorkflowUiDisplayMetadata.ObjectTypeEnum ObjectType
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.WorkflowUiFormConfig> UiFormConfigs
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.WorkflowUiViewConfig> UiViewConfigs
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowUiDisplayMetadata initObject = new Intersight.Model.WorkflowUiDisplayMetadata();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("MetaDefinition"))
            {
                initObject.MetaDefinition = this.MetaDefinition;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("UiFormConfigs"))
            {
                initObject.UiFormConfigs = this.UiFormConfigs;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UiViewConfigs"))
            {
                initObject.UiViewConfigs = this.UiViewConfigs;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowUiFormConfig.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowUiFormConfig")]
    public class InitializeIntersightWorkflowUiFormConfig : PSCmdlet
    {
        public InitializeIntersightWorkflowUiFormConfig()
        {
            ClassId = WorkflowUiFormConfig.ClassIdEnum.WorkflowUiFormConfig;
            ObjectType = WorkflowUiFormConfig.ObjectTypeEnum.WorkflowUiFormConfig;

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

        public WorkflowUiFormConfig.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Schema of the UI config for the set of defined datatypes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Config
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the entity inside the meta definition for which a collection of workflow datatype definition is added. Use StartTask as the name for the input definition inside a workflow definition or if workflow definition contains user action task, then it will be the name of the user action task."</para>
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

        public WorkflowUiFormConfig.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowUiFormConfig initObject = new Intersight.Model.WorkflowUiFormConfig();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Config"))
            {
                initObject.Config = this.Config;
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowUiInputFilter.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowUiInputFilter")]
    public class InitializeIntersightWorkflowUiInputFilter : PSCmdlet
    {
        public InitializeIntersightWorkflowUiInputFilter()
        {
            ClassId = WorkflowUiInputFilter.ClassIdEnum.WorkflowUiInputFilter;
            ObjectType = WorkflowUiInputFilter.ObjectTypeEnum.WorkflowUiInputFilter;

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

        public WorkflowUiInputFilter.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> Filters
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name for the input definition to which this filter applies. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-) or an underscore (_). The first and last character in name must be an alphanumeric character. When defining the cascade filter for a sub property, use a period (.) to separate each section of the name like \"StorageConfig.Volume\" where 'StorageConfig' is an input name and 'Volume' is a sub property defined through custom data type definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+([a-zA-Z0-9-_.]*[a-zA-Z0-9])*$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowUiInputFilter.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Help message shown to the user about which prior input needs to be selected to enable the input mapped to this filter."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string UserHelpMessage
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowUiInputFilter initObject = new Intersight.Model.WorkflowUiInputFilter();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Filters"))
            {
                initObject.Filters = this.Filters;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("UserHelpMessage"))
            {
                initObject.UserHelpMessage = this.UserHelpMessage;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowUiViewConfig.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowUiViewConfig")]
    public class InitializeIntersightWorkflowUiViewConfig : PSCmdlet
    {
        public InitializeIntersightWorkflowUiViewConfig()
        {
            ClassId = WorkflowUiViewConfig.ClassIdEnum.WorkflowUiViewConfig;
            ObjectType = WorkflowUiViewConfig.ObjectTypeEnum.WorkflowUiViewConfig;

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

        public WorkflowUiViewConfig.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Schema of the UI config for the set of defined datatypes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Config
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the entity inside the meta definition for which a collection of datatype definition is added. Use StartTask as the name for the input definition inside a workflow definition or if workflow definition contains user action task, then it will be the name of the user action task."</para>
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

        public WorkflowUiViewConfig.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowUiViewConfig initObject = new Intersight.Model.WorkflowUiViewConfig();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Config"))
            {
                initObject.Config = this.Config;
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowValidationError.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowValidationError")]
    public class InitializeIntersightWorkflowValidationError : PSCmdlet
    {
        public InitializeIntersightWorkflowValidationError()
        {
            ClassId = WorkflowValidationError.ClassIdEnum.WorkflowValidationError;
            ObjectType = WorkflowValidationError.ObjectTypeEnum.WorkflowValidationError;

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

        public WorkflowValidationError.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowValidationError.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowValidationError initObject = new Intersight.Model.WorkflowValidationError();
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowValidationInformation.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowValidationInformation")]
    public class InitializeIntersightWorkflowValidationInformation : PSCmdlet
    {
        public InitializeIntersightWorkflowValidationInformation()
        {
            ClassId = WorkflowValidationInformation.ClassIdEnum.WorkflowValidationInformation;
            ObjectType = WorkflowValidationInformation.ObjectTypeEnum.WorkflowValidationInformation;

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

        public WorkflowValidationInformation.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowValidationInformation.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowValidationInformation initObject = new Intersight.Model.WorkflowValidationInformation();
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowVariable.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowVariable")]
    public class InitializeIntersightWorkflowVariable : PSCmdlet
    {
        public InitializeIntersightWorkflowVariable()
        {
            ClassId = WorkflowVariable.ClassIdEnum.WorkflowVariable;
            ObjectType = WorkflowVariable.ObjectTypeEnum.WorkflowVariable;

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

        public WorkflowVariable.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This defines the schema of the variable. It can be set to any Primitive or Custom Data Types supported by workflows."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowBaseDataType Definition
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

        public WorkflowVariable.ObjectTypeEnum ObjectType
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
        /// <para type="description">"This defines the value of the variable and it will be validated against the datatype defined in the definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Value
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowVariable initObject = new Intersight.Model.WorkflowVariable();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Catalog"))
            {
                initObject.Catalog = this.Catalog;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Definition"))
            {
                initObject.Definition = this.Definition;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Value"))
            {
                initObject.Value = this.Value;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowWaitTask.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowWaitTask")]
    public class InitializeIntersightWorkflowWaitTask : PSCmdlet
    {
        public InitializeIntersightWorkflowWaitTask()
        {
            ClassId = WorkflowWaitTask.ClassIdEnum.WorkflowWaitTask;
            ObjectType = WorkflowWaitTask.ObjectTypeEnum.WorkflowWaitTask;

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

        public WorkflowWaitTask.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The description of this task instance in the workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
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
        /// <para type="description">"JSON formatted key-value pairs that define the inputs given to the task. Mapping for task inputs can be provided as either static values, direct mapping or advanced mapping using templates. The direct mapping can be specified as '${Source.< input | output | variable>.<JSONPath>}'. 'Source' can be either workflow or the name of an earlier task within the workflow. You can map the task input to either a workflow input, a task output or a variable. Golang template syntax is supported for advanced mapping. A simple flattened example is \"InputParameters\":{ \"input1\":\"${workflow.variable.var1}\", \"input2\":\"prefixStr_{{.global.workflow.input.input1}}\" } where task input1 is mapped directly to variable var1 and task input2 is using a template to prefix a string to workflow input1 and then assign that value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object InputParameters
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user defined label identifier of the workflow task used for UI display."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the task within the workflow and it must be unique among all WorkflowTasks within a workflow definition. This name serves as the internal unique identifier for the task and is used to pick input and output parameters to feed into other tasks."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowWaitTask.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This specifies the name of the next task to run if Task fails.  This is the unique name given to the task instance within the workflow. In a graph model, denotes an edge to another Task Node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string OnFailure
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This specifies the name of the next task to run if Task succeeds.  This is the unique name given to the task instance within the workflow. In a graph model, denotes an edge to another Task Node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string OnSuccess
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.WorkflowWaitTaskPrompt> Prompts
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The task is disabled/enabled for rollback operation in this workflow if the task has rollback support."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool RollbackDisabled
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"JSON formatted key-value pairs that perform variable update at the end of the task execution. Mapping for variables can be provided as either static values, direct mapping or advanced mapping using templates. The direct mapping can be specified as '${Source.< input | output | variable>.<JSONPath>}'. 'Source' can be either workflow or the name of the current or an earlier task within the workflow. You can map the variable to either a workflow input, a task output or another variable. Golang template syntax is supported for advanced mapping. A simple flattened example is \"VariableParameters\":{ \"var1\":\"${task1.output.output1}\", \"var2\":\"{{ Itoa .global.workflow.variable.varInt}}\" } where variable var1 is mapped directly to output1 of task1 and variable var2 is using a template to convert another variable varInt to string and assign that value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object VariableParameters
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowWaitTask initObject = new Intersight.Model.WorkflowWaitTask();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InputDefinition"))
            {
                initObject.InputDefinition = this.InputDefinition;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InputParameters"))
            {
                initObject.InputParameters = this.InputParameters;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OnFailure"))
            {
                initObject.OnFailure = this.OnFailure;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("OnSuccess"))
            {
                initObject.OnSuccess = this.OnSuccess;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Prompts"))
            {
                initObject.Prompts = this.Prompts;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RollbackDisabled"))
            {
                initObject.RollbackDisabled = this.RollbackDisabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VariableParameters"))
            {
                initObject.VariableParameters = this.VariableParameters;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowWaitTaskPrompt.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowWaitTaskPrompt")]
    public class InitializeIntersightWorkflowWaitTaskPrompt : PSCmdlet
    {
        public InitializeIntersightWorkflowWaitTaskPrompt()
        {
            ClassId = WorkflowWaitTaskPrompt.ClassIdEnum.WorkflowWaitTaskPrompt;
            ObjectType = WorkflowWaitTaskPrompt.ObjectTypeEnum.WorkflowWaitTaskPrompt;
            TaskStatus = WorkflowWaitTaskPrompt.TaskStatusEnum.Scheduled;

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

        public WorkflowWaitTaskPrompt.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description that give more details about what it means to pick this prompt option for the wait task."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User friendly label for the prompt. This label will be shown to the user as one of available options for the wait task."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name for the wait prompt."</para>
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

        public WorkflowWaitTaskPrompt.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Task status for the wait task when this prompt option is selected.\n* `Scheduled` - The enum represents the status when task is in scheduled state.\n* `InProgress` - The enum represents the status when task is in-progress state.\n* `NoOp` - The enum represents the status when task is a noop.\n* `Timeout` - The enum represents the status when task has timed out.\n* `Completed` - The enum represents the status when task has completed.\n* `Failed` - The enum represents the status when task has failed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowWaitTaskPrompt.TaskStatusEnum TaskStatus
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowWaitTaskPrompt initObject = new Intersight.Model.WorkflowWaitTaskPrompt();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("TaskStatus"))
            {
                initObject.TaskStatus = this.TaskStatus;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowWebApi.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowWebApi")]
    public class InitializeIntersightWorkflowWebApi : PSCmdlet
    {
        public InitializeIntersightWorkflowWebApi()
        {
            ClassId = WorkflowWebApi.ClassIdEnum.WorkflowWebApi;
            EndpointRequestType = WorkflowWebApi.EndpointRequestTypeEnum.Internal;
            ObjectType = WorkflowWebApi.ObjectTypeEnum.WorkflowWebApi;

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
        /// <para type="description">"The optional request body that is sent as part of this API request.\nThe request body can contain a golang template that can be populated with task input\nparameters and previous API output parameters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Body
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowWebApi.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Intersight Orchestrator, with the support of response parser specification,\ncan extract the values from API responses and map them to task output parameters.\nThe value extraction is supported for response content types XML, JSON and Text.\nThe type of the content that gets passed as payload and response in this\nAPI. The supported values are json, xml, text."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ContentType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Collection of key value pairs to set in the request header as Cookie list."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Cookies
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A description that task designer can add to individual API requests that explain \nwhat the API call is about."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If the target type is Endpoint, this property determines whether the request is\nto be handled as internal request or external request by the device connector.\n* `Internal` - The endpoint API executed is an internal request handled by the device connector plugin.\n* `External` - The endpoint API request is passed through by the device connector."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowWebApi.EndpointRequestTypeEnum EndpointRequestType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Intersight Orchestrator, with the support of response parser specification,\ncan extract the values from API responses and map them to task output parameters.\nThe value extraction is supported for response content types XML, JSON and Text.\nOptional input to specify the content type in case of error API response. This\nshould be used if the content type of error response is different from that of\nthe success response. If not specified, contentType input value is used to parse\nthe error response."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ErrorContentType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Collection of key value pairs to set in the request header."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Headers
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user friendly label that task designers have given to the batch API request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The HTTP method to be executed in the given URL (GET, POST, PUT, etc).\nIf the value is not specified, GET will be used as default.\nThe supported values are GET, POST, PUT, DELETE, PATCH, HEAD."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Method
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of the intersight object for which API request is to be made.\nThe property is valid in case of Intersight API calls and the base url is automatically prepended based on the value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string MoType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference name for this API request within the batch API request.\nThis name shall be used to map the API output parameters to subsequent\nAPI input parameters within a batch API task."</para>
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

        public WorkflowWebApi.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"All the possible outcomes of this API are captured here. Outcomes property\nis a collection property of type workflow.Outcome objects.\nThe outcomes can be mapped to the message to be shown. The outcomes are\nevaluated in the order they are given. At the end of the outcomes list,\nan catchall success/fail outcome can be added with condition as 'true'.\nThis is an optional\nproperty and if not specified the task will be marked as success."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Outcomes
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The accepted web protocol values are http and https."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Protocol
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The optional grammar specification for parsing the response to extract the\nrequired values.\nThe specification should have extraction specification specified for\nall the API output parameters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object ResponseSpec
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The skip expression, if provided, allows the batch API executor to skip the\napi execution when the given expression evaluates to true.\nThe expression is given as such a golang template that has to be\nevaluated to a final content true/false. The expression is an optional and in\ncase not provided, the API will always be executed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SkipOnCondition
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The delay in seconds after which the API needs to be executed.\nBy default, the given API is executed immediately. Specifying a start delay adds to the delay to execution.\nStart Delay is not supported for the first API in the Batch and cumulative delay of all the APIs in the Batch should not exceed the task time out."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long StartDelay
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If the web API is to be executed in a remote device connected to the\nIntersight through device connector, 'Endpoint' is expected as the value\nwhereas if the API is an Intersight API, 'Local' is expected as the value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string TargetType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The duration in seconds by which the API response is expected from the API target.\nIf the end point does not respond for the API request within this timeout\nduration, the task will be marked as failed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Timeout
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The URL of the resource in the target to which the API request is made."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Url
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowWebApi initObject = new Intersight.Model.WorkflowWebApi();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Body"))
            {
                initObject.Body = this.Body;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ContentType"))
            {
                initObject.ContentType = this.ContentType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Cookies"))
            {
                initObject.Cookies = this.Cookies;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndpointRequestType"))
            {
                initObject.EndpointRequestType = this.EndpointRequestType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ErrorContentType"))
            {
                initObject.ErrorContentType = this.ErrorContentType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Headers"))
            {
                initObject.Headers = this.Headers;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Method"))
            {
                initObject.Method = this.Method;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MoType"))
            {
                initObject.MoType = this.MoType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Outcomes"))
            {
                initObject.Outcomes = this.Outcomes;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Protocol"))
            {
                initObject.Protocol = this.Protocol;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ResponseSpec"))
            {
                initObject.ResponseSpec = this.ResponseSpec;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SkipOnCondition"))
            {
                initObject.SkipOnCondition = this.SkipOnCondition;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StartDelay"))
            {
                initObject.StartDelay = this.StartDelay;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TargetType"))
            {
                initObject.TargetType = this.TargetType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Timeout"))
            {
                initObject.Timeout = this.Timeout;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Url"))
            {
                initObject.Url = this.Url;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowWorkerTask.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowWorkerTask")]
    public class InitializeIntersightWorkflowWorkerTask : PSCmdlet
    {
        public InitializeIntersightWorkflowWorkerTask()
        {
            ClassId = WorkflowWorkerTask.ClassIdEnum.WorkflowWorkerTask;
            ObjectType = WorkflowWorkerTask.ObjectTypeEnum.WorkflowWorkerTask;

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
        /// <para type="description">"Specify the catalog moid that this task belongs."</para>
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

        public WorkflowWorkerTask.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The description of this task instance in the workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"JSON formatted key-value pairs that define the inputs given to the task. Mapping for task inputs can be provided as either static values, direct mapping or advanced mapping using templates. The direct mapping can be specified as '${Source.< input | output | variable>.<JSONPath>}'. 'Source' can be either workflow or the name of an earlier task within the workflow. You can map the task input to either a workflow input, a task output or a variable. Golang template syntax is supported for advanced mapping. A simple flattened example is \"InputParameters\":{ \"input1\":\"${workflow.variable.var1}\", \"input2\":\"prefixStr_{{.global.workflow.input.input1}}\" } where task input1 is mapped directly to variable var1 and task input2 is using a template to prefix a string to workflow input1 and then assign that value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object InputParameters
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user defined label identifier of the workflow task used for UI display."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the task within the workflow and it must be unique among all WorkflowTasks within a workflow definition. This name serves as the internal unique identifier for the task and is used to pick input and output parameters to feed into other tasks."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowWorkerTask.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This specifies the name of the next task to run if Task fails.  This is the unique name given to the task instance within the workflow. In a graph model, denotes an edge to another Task Node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string OnFailure
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This specifies the name of the next task to run if Task succeeds.  This is the unique name given to the task instance within the workflow. In a graph model, denotes an edge to another Task Node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string OnSuccess
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The task is disabled/enabled for rollback operation in this workflow if the task has rollback support."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool RollbackDisabled
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The qualified name of task that should be executed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string TaskDefinitionName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"JSON formatted key-value pairs that perform variable update at the end of the task execution. Mapping for variables can be provided as either static values, direct mapping or advanced mapping using templates. The direct mapping can be specified as '${Source.< input | output | variable>.<JSONPath>}'. 'Source' can be either workflow or the name of the current or an earlier task within the workflow. You can map the variable to either a workflow input, a task output or another variable. Golang template syntax is supported for advanced mapping. A simple flattened example is \"VariableParameters\":{ \"var1\":\"${task1.output.output1}\", \"var2\":\"{{ Itoa .global.workflow.variable.varInt}}\" } where variable var1 is mapped directly to output1 of task1 and variable var2 is using a template to convert another variable varInt to string and assign that value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object VariableParameters
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The task definition version to use in this workflow. When no version is specified then the default version of the task at the time of creating or updating this workflow is used."</para>
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
            Intersight.Model.WorkflowWorkerTask initObject = new Intersight.Model.WorkflowWorkerTask();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OnFailure"))
            {
                initObject.OnFailure = this.OnFailure;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("OnSuccess"))
            {
                initObject.OnSuccess = this.OnSuccess;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RollbackDisabled"))
            {
                initObject.RollbackDisabled = this.RollbackDisabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TaskDefinitionName"))
            {
                initObject.TaskDefinitionName = this.TaskDefinitionName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VariableParameters"))
            {
                initObject.VariableParameters = this.VariableParameters;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject.VarVersion = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowWorkflowCtx.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowWorkflowCtx")]
    public class InitializeIntersightWorkflowWorkflowCtx : PSCmdlet
    {
        public InitializeIntersightWorkflowWorkflowCtx()
        {
            ClassId = WorkflowWorkflowCtx.ClassIdEnum.WorkflowWorkflowCtx;
            ObjectType = WorkflowWorkflowCtx.ObjectTypeEnum.WorkflowWorkflowCtx;

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

        public WorkflowWorkflowCtx.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Details about initiator of the workflow. Any Intersight object resource can be set as the initiator of the workflow. For workflows executed by an Intersight service, an applicable service object will be set as the initiator. For example, during server profile deployment workflow, the server profile object will be set as the initiator by the system. For user created workflows, this field is optional and for workflows executed from Intersight workflow execution page, the workflow definition object will be set as the Initiator."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowInitiatorContext InitiatorCtx
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowWorkflowCtx.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowWorkflowCtx initObject = new Intersight.Model.WorkflowWorkflowCtx();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("InitiatorCtx"))
            {
                initObject.InitiatorCtx = this.InitiatorCtx;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowWorkflowDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowWorkflowDefinition")]
    public class InitializeIntersightWorkflowWorkflowDefinition : PSCmdlet
    {
        public InitializeIntersightWorkflowWorkflowDefinition()
        {
            ClassId = WorkflowWorkflowDefinition.ClassIdEnum.WorkflowWorkflowDefinition;
            ObjectType = WorkflowWorkflowDefinition.ObjectTypeEnum.WorkflowWorkflowDefinition;

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

        public WorkflowWorkflowDefinition.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When true this will be the workflow version that is used when a specific workflow definition version is not specified. The default version is used when user executes a workflow without specifying a version or when workflow is included in another workflow without a specific version. The very first workflow definition created with a name will be set as the default version, after that user can explicitly set any version of the workflow definition as the default version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool DefaultVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The description for this workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
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

        public List<Model.WorkflowParameterSet> InputParameterSet
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user friendly short name to identify the workflow. Label can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.), colon (:), space ( ), forward slash (/), or an underscore (_)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]{1}[\\sa-zA-Z0-9_./:-]{0,91}$")]
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
        /// <para type="description">"The name for this workflow. You can have multiple versions of the workflow with the same name. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.) or an underscore (_)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]{1}[a-zA-Z0-9_.-]{0,63}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowWorkflowDefinition.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.WorkflowBaseDataType> OutputDefinition
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The output mappings for the workflow. The schema for outputs of a workflow is defined using OutputDefinition. The outputs for workflows that we want to export out at the end of the workflow can be mapped from task outputs, workflow inputs, or workflow variables. Any task output, workflow input, or workflow variable can be mapped to a workflow output as long as the types are compatible. The format to specify the mapping is '${ 'workflow | <taskName>'. 'output |input | variable'.<name>[.<JsonPath>]}'. First, either the keyword 'workflow' or the name of the task in the workflow must be given. If a task name is used, then it must be followed by the keyword 'output', if the keyword workflow was used, then it must be followed by the keyword 'input' or 'variable'. Following this '<name>' must be the name of either input, output, or variable that must be mapped as workflow output. The last part of the mapping can be an optional <JsonPath> to extract specific fields on the data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object OutputParameters
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type to capture the properties of a workflow definition. Some of these properties are passed to workflow execution instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowWorkflowProperties Properties
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.WorkflowWorkflowTask> Tasks
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.WorkflowUiInputFilter> UiInputFilters
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This will hold the data needed for workflow to be rendered in the user interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object UiRenderingData
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.WorkflowBaseDataType> VariableDefinition
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The version of the workflow to support multiple versions."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Version
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a workflowWorkflowMetadata resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowWorkflowMetadataRelationship WorkflowMetadata
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowWorkflowDefinition initObject = new Intersight.Model.WorkflowWorkflowDefinition();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("InputDefinition"))
            {
                initObject.InputDefinition = this.InputDefinition;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InputParameterSet"))
            {
                initObject.InputParameterSet = this.InputParameterSet;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("OutputDefinition"))
            {
                initObject.OutputDefinition = this.OutputDefinition;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("OutputParameters"))
            {
                initObject.OutputParameters = this.OutputParameters;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Properties"))
            {
                initObject.Properties = this.Properties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tasks"))
            {
                initObject.Tasks = this.Tasks;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UiInputFilters"))
            {
                initObject.UiInputFilters = this.UiInputFilters;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UiRenderingData"))
            {
                initObject.UiRenderingData = this.UiRenderingData;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VariableDefinition"))
            {
                initObject.VariableDefinition = this.VariableDefinition;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject.VarVersion = this.Version;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("WorkflowMetadata"))
            {
                initObject.WorkflowMetadata = this.WorkflowMetadata;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowWorkflowEngineProperties.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowWorkflowEngineProperties")]
    public class InitializeIntersightWorkflowWorkflowEngineProperties : PSCmdlet
    {
        public InitializeIntersightWorkflowWorkflowEngineProperties()
        {
            ClassId = WorkflowWorkflowEngineProperties.ClassIdEnum.WorkflowWorkflowEngineProperties;
            ObjectType = WorkflowWorkflowEngineProperties.ObjectTypeEnum.WorkflowWorkflowEngineProperties;

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

        public WorkflowWorkflowEngineProperties.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowWorkflowEngineProperties.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowWorkflowEngineProperties initObject = new Intersight.Model.WorkflowWorkflowEngineProperties();
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowWorkflowInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowWorkflowInfo")]
    public class InitializeIntersightWorkflowWorkflowInfo : PSCmdlet
    {
        public InitializeIntersightWorkflowWorkflowInfo()
        {
            Action = WorkflowWorkflowInfo.ActionEnum.None;
            ClassId = WorkflowWorkflowInfo.ClassIdEnum.WorkflowWorkflowInfo;
            ObjectType = WorkflowWorkflowInfo.ObjectTypeEnum.WorkflowWorkflowInfo;

        }
        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamAccountRelationship Account
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The action of the workflow such as start, cancel, retry, pause.\n* `None` - No action is set, this is the default value for action field.\n* `Create` - Create a new instance of the workflow but it does not start the execution of the workflow. Use the Start action to start execution of the workflow.\n* `Start` - Start a new execution of the workflow.\n* `Pause` - Pause the workflow, this can only be issued on workflows that are in running state. A workflow can be paused for a maximum of 180 days, after 180 days the workflow will be terminated by the system.\n* `Resume` - Resume the workflow which was previously paused through pause action on the workflow.\n* `Rerun` - Rerun the workflow that has previously reached a failed state. The workflow is run from the beginning using inputs from previous execution. Completed and currently running workflows cannot be rerun. Workflows do not have to be marked for retry to use this action.\n* `Retry` - This action has been deprecated. Please use RetryFailed, Rerun or RetryFromTask action. Retry the workflow that has previously reached a final state and has the retryable property set to true. A running or waiting workflow cannot be retried. If the property retryFromTaskName is also passed along with this action, the workflow will be started from that specific task, otherwise the workflow will be restarted from the first task.  The task name in retryFromTaskName must be one of the tasks that completed or failed in the previous run. It is not possible to retry a workflow from a task which wasn't run in the previous iteration.\n* `RetryFailed` - Retry the workflow that has failed. A running or waiting workflow or a workflow that completed successfully cannot be retried. Only the tasks that failed in the previous run will be retried and the rest of workflow will be run. This action does not restart the workflow and also does not support retrying from a specific task.\n* `RetryFromTask` - Retry the workflow that has previously reached a failed state and has the retryable property set to true. A running or waiting workflow cannot be retried. RetryFromTaskName must be passed along with this action, and the workflow will be started from that specific task. The task name in RetryFromTaskName must be one of the tasks that was executed in the previous attempt. It is not possible to retry a workflow from a task that wasn't run in the previous execution attempt.\n* `Cancel` - Cancel the workflow that is in running or waiting state."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowWorkflowInfo.ActionEnum Action
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
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.MoBaseMoRelationship AssociatedObject
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowWorkflowInfo.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The duration in hours after which the workflow info for failed, terminated or timed out workflow will be removed from database. The minimum is 1 hour, maximum is 365 days and default is 90 days."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 8760)]
        public long FailedWorkflowCleanupDuration
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"All the given inputs for the workflow. The schema for the inputs is defined in the InputDefinition section of the WorkflowDefinition. The InputDefinition will provide a list of input fields to be accepted, the associated datatype of the inputs and any additional constraints on the inputs. For more information please refer to InputDefinition property in the the the WorkflowDefinition resource. The inputs for a workflow are provided as a collection of key-value pairs, where key is the name of the input and value is any valid JSON data which conforms to the datatype of the input as specified in the InputDefinition. When the input passed into a workflow does not match the datatype or the constraints specified in the workflow definition, it will not be accepted. For example, if the InputDefinition specified that workflow must accept a string name 'key' and the value passed for key must adhere to a regex pattern. If Workflow was started with input where 'key' is not a string matching the regex pattern, an error will be generated and workflow will not start execution. During workflow definition design, the input passed into the workflow will be referred using the format 'workflow.input.<inputName>'. If the input is referred directly in a mapping it will be in the format '${workflow.input.<inputName>}' or inside a template mapping in the format '{{.global.workflow.input.<inputName>}}'."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Input
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
        /// <para type="description">"A name of the workflow execution instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[^:]{1,92}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowWorkflowInfo.ObjectTypeEnum ObjectType
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
        /// <para type="description">"A reference to a iamPermission resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.IamPermissionRelationship Permission
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This field is required when RetryFromTask action is issued for a workflow that is in a 'final' state. The workflow will be retried from the specified task. This field must specify a task name which is the unique name of the task within the workflow. The task name must be one of the tasks that were completed or failed in the previous run. It is not possible to retry a workflow from a task that wasn't run in the previous execution attempt."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string RetryFromTaskName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The duration in hours after which the workflow info for successful workflow will be removed from database. The minimum is 1 hour, maximum is 365 days and default is 90 days."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidateRange(1, 8760)]
        public long SuccessWorkflowCleanupDuration
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
        /// <para type="description">"Used to update a TaskInfo instance in the WorkflowInfo, it is used as a way to update status and provide user inputs for a WaitTask."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowTaskInfoUpdate TaskInfoUpdate
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The workflow context which contains initiator and target information."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowWorkflowCtx WorkflowCtx
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a workflowWorkflowDefinition resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.WorkflowWorkflowDefinitionRelationship WorkflowDefinition
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowWorkflowInfo initObject = new Intersight.Model.WorkflowWorkflowInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("Account"))
            {
                initObject.Account = this.Account;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Action"))
            {
                initObject.Action = this.Action;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AssociatedObject"))
            {
                initObject.AssociatedObject = this.AssociatedObject;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("FailedWorkflowCleanupDuration"))
            {
                initObject.FailedWorkflowCleanupDuration = this.FailedWorkflowCleanupDuration;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Input"))
            {
                initObject.Input = this.Input;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Permission"))
            {
                initObject.Permission = this.Permission;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RetryFromTaskName"))
            {
                initObject.RetryFromTaskName = this.RetryFromTaskName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SuccessWorkflowCleanupDuration"))
            {
                initObject.SuccessWorkflowCleanupDuration = this.SuccessWorkflowCleanupDuration;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TaskInfoUpdate"))
            {
                initObject.TaskInfoUpdate = this.TaskInfoUpdate;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("WorkflowCtx"))
            {
                initObject.WorkflowCtx = this.WorkflowCtx;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("WorkflowDefinition"))
            {
                initObject.WorkflowDefinition = this.WorkflowDefinition;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowWorkflowInfoAutoRestartProperties.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowWorkflowInfoAutoRestartProperties")]
    public class InitializeIntersightWorkflowWorkflowInfoAutoRestartProperties : PSCmdlet
    {
        public InitializeIntersightWorkflowWorkflowInfoAutoRestartProperties()
        {
            ClassId = WorkflowWorkflowInfoAutoRestartProperties.ClassIdEnum.WorkflowWorkflowInfoAutoRestartProperties;
            ObjectType = WorkflowWorkflowInfoAutoRestartProperties.ObjectTypeEnum.WorkflowWorkflowInfoAutoRestartProperties;

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

        public WorkflowWorkflowInfoAutoRestartProperties.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowWorkflowInfoAutoRestartProperties.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowWorkflowInfoAutoRestartProperties initObject = new Intersight.Model.WorkflowWorkflowInfoAutoRestartProperties();
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowWorkflowInfoProperties.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowWorkflowInfoProperties")]
    public class InitializeIntersightWorkflowWorkflowInfoProperties : PSCmdlet
    {
        public InitializeIntersightWorkflowWorkflowInfoProperties()
        {
            ClassId = WorkflowWorkflowInfoProperties.ClassIdEnum.WorkflowWorkflowInfoProperties;
            ObjectType = WorkflowWorkflowInfoProperties.ObjectTypeEnum.WorkflowWorkflowInfoProperties;

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

        public WorkflowWorkflowInfoProperties.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowWorkflowInfoProperties.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowWorkflowInfoProperties initObject = new Intersight.Model.WorkflowWorkflowInfoProperties();
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowWorkflowMetadata.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowWorkflowMetadata")]
    public class InitializeIntersightWorkflowWorkflowMetadata : PSCmdlet
    {
        public InitializeIntersightWorkflowWorkflowMetadata()
        {
            ClassId = WorkflowWorkflowMetadata.ClassIdEnum.WorkflowWorkflowMetadata;
            ObjectType = WorkflowWorkflowMetadata.ObjectTypeEnum.WorkflowWorkflowMetadata;

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
        /// <para type="description">"An array of relationships to iamRole resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.IamRoleRelationship> AssociatedRoles
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

        public WorkflowWorkflowMetadata.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The description for this workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user friendly short name to identify the workflow metadata. Label can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.), colon (:), space ( ) or an underscore (_)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]{1}[\\sa-zA-Z0-9_.:-]{0,91}$")]
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
        /// <para type="description">"The name for this workflow metadata. You can have multiple versions of the workflow with the same name. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.) or an underscore (_)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]{1}[a-zA-Z0-9_.-]{0,63}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowWorkflowMetadata.ObjectTypeEnum ObjectType
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
            Intersight.Model.WorkflowWorkflowMetadata initObject = new Intersight.Model.WorkflowWorkflowMetadata();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AssociatedRoles"))
            {
                initObject.AssociatedRoles = this.AssociatedRoles;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Catalog"))
            {
                initObject.Catalog = this.Catalog;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowWorkflowProperties.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowWorkflowProperties")]
    public class InitializeIntersightWorkflowWorkflowProperties : PSCmdlet
    {
        public InitializeIntersightWorkflowWorkflowProperties()
        {
            ClassId = WorkflowWorkflowProperties.ClassIdEnum.WorkflowWorkflowProperties;
            ObjectType = WorkflowWorkflowProperties.ObjectTypeEnum.WorkflowWorkflowProperties;
            PublishStatus = WorkflowWorkflowProperties.PublishStatusEnum.Draft;
            SupportStatus = WorkflowWorkflowProperties.SupportStatusEnum.Supported;

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

        public WorkflowWorkflowProperties.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enabling this flag will capture request and response details as debug logs for tasks that are using workflow.BatchApi for implementation. For other tasks in the workflow which are not based on workflow.BatchApi logs will not be generated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool EnableDebug
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This flag determines if this workflow publish status is enforced or not."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool EnablePublishStatus
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowWorkflowProperties.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The workflow publish status (Draft, Published, Archived), this property is relevant only when enablePublishStatus is set to true.\n* `Draft` - The enum specifies the option as Draft which means the meta definition is being designed and tested.\n* `Published` - The enum specifies the option as Published which means the meta definition is ready for consumption.\n* `Archived` - The enum specifies the option as Archived which means the meta definition is archived and can no longer be consumed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowWorkflowProperties.PublishStatusEnum PublishStatus
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When set to true, the failed workflow executions from this workflow definition can be retried for up to 2 weeks since the last modification time. After two weeks of inactivity on the workflow execution, the option to retry the failed workflow will be disabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Retryable
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When set to true, the changes are automatically rolled back if the workflow execution is canceled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool RollbackOnCancel
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When set to true, the changes are automatically rolled back if the workflow fails to execute."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool RollbackOnFailure
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Supported status of the definition.\n* `Supported` - The definition is a supported version and there will be no changes to the mandatory inputs or outputs.\n* `Beta` - The definition is a Beta version and this version can under go changes until the version is marked supported.\n* `Deprecated` - The version of definition is deprecated and typically there will be a higher version of the same definition that has been added."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowWorkflowProperties.SupportStatusEnum SupportStatus
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowWorkflowProperties initObject = new Intersight.Model.WorkflowWorkflowProperties();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("EnableDebug"))
            {
                initObject.EnableDebug = this.EnableDebug;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EnablePublishStatus"))
            {
                initObject.EnablePublishStatus = this.EnablePublishStatus;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PublishStatus"))
            {
                initObject.PublishStatus = this.PublishStatus;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Retryable"))
            {
                initObject.Retryable = this.Retryable;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RollbackOnCancel"))
            {
                initObject.RollbackOnCancel = this.RollbackOnCancel;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RollbackOnFailure"))
            {
                initObject.RollbackOnFailure = this.RollbackOnFailure;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SupportStatus"))
            {
                initObject.SupportStatus = this.SupportStatus;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowWorkflowTask.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowWorkflowTask")]
    public class InitializeIntersightWorkflowWorkflowTask : PSCmdlet
    {
        public InitializeIntersightWorkflowWorkflowTask()
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

        public WorkflowWorkflowTask.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The description of this task instance in the workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user defined label identifier of the workflow task used for UI display."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the task within the workflow and it must be unique among all WorkflowTasks within a workflow definition. This name serves as the internal unique identifier for the task and is used to pick input and output parameters to feed into other tasks."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_:-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowWorkflowTask.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowWorkflowTask initObject = new Intersight.Model.WorkflowWorkflowTask();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowXmlApi.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowXmlApi")]
    public class InitializeIntersightWorkflowXmlApi : PSCmdlet
    {
        public InitializeIntersightWorkflowXmlApi()
        {
            ClassId = WorkflowXmlApi.ClassIdEnum.WorkflowXmlApi;
            ObjectType = WorkflowXmlApi.ObjectTypeEnum.WorkflowXmlApi;

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
        /// <para type="description">"The optional request body that is sent as part of this API request.\nThe request body can contain a golang template that can be populated with task input\nparameters and previous API output parameters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Body
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowXmlApi.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Intersight Orchestrator, with the support of response parser specification,\ncan extract the values from API responses and map them to task output parameters.\nThe value extraction is supported for response content types XML, JSON and Text.\nThe type of the content that gets passed as payload and response in this\nAPI. The supported values are json, xml, text."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ContentType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A description that task designer can add to individual API requests that explain \nwhat the API call is about."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Intersight Orchestrator, with the support of response parser specification,\ncan extract the values from API responses and map them to task output parameters.\nThe value extraction is supported for response content types XML, JSON and Text.\nOptional input to specify the content type in case of error API response. This\nshould be used if the content type of error response is different from that of\nthe success response. If not specified, contentType input value is used to parse\nthe error response."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ErrorContentType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user friendly label that task designers have given to the batch API request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Label
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference name for this API request within the batch API request.\nThis name shall be used to map the API output parameters to subsequent\nAPI input parameters within a batch API task."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public WorkflowXmlApi.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"All the possible outcomes of this API are captured here. Outcomes property\nis a collection property of type workflow.Outcome objects.\nThe outcomes can be mapped to the message to be shown. The outcomes are\nevaluated in the order they are given. At the end of the outcomes list,\nan catchall success/fail outcome can be added with condition as 'true'.\nThis is an optional\nproperty and if not specified the task will be marked as success."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object Outcomes
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The optional grammar specification for parsing the response to extract the\nrequired values.\nThe specification should have extraction specification specified for\nall the API output parameters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public object ResponseSpec
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The skip expression, if provided, allows the batch API executor to skip the\napi execution when the given expression evaluates to true.\nThe expression is given as such a golang template that has to be\nevaluated to a final content true/false. The expression is an optional and in\ncase not provided, the API will always be executed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SkipOnCondition
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The delay in seconds after which the API needs to be executed.\nBy default, the given API is executed immediately. Specifying a start delay adds to the delay to execution.\nStart Delay is not supported for the first API in the Batch and cumulative delay of all the APIs in the Batch should not exceed the task time out."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long StartDelay
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The duration in seconds by which the API response is expected from the API target.\nIf the end point does not respond for the API request within this timeout\nduration, the task will be marked as failed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Timeout
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.WorkflowXmlApi initObject = new Intersight.Model.WorkflowXmlApi();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Body"))
            {
                initObject.Body = this.Body;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ContentType"))
            {
                initObject.ContentType = this.ContentType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ErrorContentType"))
            {
                initObject.ErrorContentType = this.ErrorContentType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Label"))
            {
                initObject.Label = this.Label;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Outcomes"))
            {
                initObject.Outcomes = this.Outcomes;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ResponseSpec"))
            {
                initObject.ResponseSpec = this.ResponseSpec;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SkipOnCondition"))
            {
                initObject.SkipOnCondition = this.SkipOnCondition;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StartDelay"))
            {
                initObject.StartDelay = this.StartDelay;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Timeout"))
            {
                initObject.Timeout = this.Timeout;
            }
            WriteObject(initObject);
        }

    }
}