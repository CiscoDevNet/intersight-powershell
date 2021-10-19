using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowValidationInformation.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowValidationInformation")]
    public class InitializeIntersightWorkflowValidationInformation:PSCmdlet
	{
		public InitializeIntersightWorkflowValidationInformation()
		{
            ClassId = WorkflowValidationInformation.ClassIdEnum.WorkflowValidationInformation;
            ObjectType = WorkflowValidationInformation.ObjectTypeEnum.WorkflowValidationInformation;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowValidationInformation.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowValidationInformation.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowFileDownloadOp.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowFileDownloadOp")]
    public class InitializeIntersightWorkflowFileDownloadOp:PSCmdlet
	{
		public InitializeIntersightWorkflowFileDownloadOp()
		{
            ClassId = WorkflowFileDownloadOp.ClassIdEnum.WorkflowFileDownloadOp;
            ObjectType = WorkflowFileDownloadOp.ObjectTypeEnum.WorkflowFileDownloadOp;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowFileDownloadOp.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Path on the Intersight connected device to which file needs to be downloaded."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DestinationPath {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowFileDownloadOp.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Source bucket name hosting the file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SourceBucket {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the file to be downloaded from bucket to endpoint devices."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SourceFile {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowCustomDataProperty.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowCustomDataProperty")]
    public class InitializeIntersightWorkflowCustomDataProperty:PSCmdlet
	{
		public InitializeIntersightWorkflowCustomDataProperty()
		{
            ClassId = WorkflowCustomDataProperty.ClassIdEnum.WorkflowCustomDataProperty;
            ObjectType = WorkflowCustomDataProperty.ObjectTypeEnum.WorkflowCustomDataProperty;
            
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
        /// <para type="description">"Specify the catalog moid that this custom data type belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string CatalogMoid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowCustomDataProperty.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the custom data type for this input."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string CustomDataTypeName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowCustomDataProperty.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowMoReferenceProperty.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowMoReferenceProperty")]
    public class InitializeIntersightWorkflowMoReferenceProperty:PSCmdlet
	{
		public InitializeIntersightWorkflowMoReferenceProperty()
		{
            ClassId = WorkflowMoReferenceProperty.ClassIdEnum.WorkflowMoReferenceProperty;
            ObjectType = WorkflowMoReferenceProperty.ObjectTypeEnum.WorkflowMoReferenceProperty;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowMoReferenceProperty.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> DisplayAttributes {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowMoReferenceProperty.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Field to hold an Intersight API along with an optional filter to narrow down the search options."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|/api/v1/.*")]
        public string Selector {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Selector properties to define HTTP method and 'body' in case of upsert operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.WorkflowSelectorProperty SelectorProperty {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A property from the Intersight object, value of which can be used as value for referenced input definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ValueAttribute {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowFileOperations.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowFileOperations")]
    public class InitializeIntersightWorkflowFileOperations:PSCmdlet
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The optional request body that is sent as part of this API request.\nThe request body can contain a golang template that can be populated with task input\nparameters and previous API output parameters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Body {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowFileOperations.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Intersight Orchestrator, with the support of response parser specification,\ncan extract the values from API responses and map them to task output parameters.\nThe value extraction is supported for response content types XML, JSON and Text.\nThe type of the content that gets passed as payload and response in this\nAPI. The supported values are json, xml, text."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ContentType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A description that task designer can add to individual API requests that explain \nwhat the API call is about."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Intersight Orchestrator, with the support of response parser specification,\ncan extract the values from API responses and map them to task output parameters.\nThe value extraction is supported for response content types XML, JSON and Text.\nOptional input to specify the content type in case of error API response. This\nshould be used if the content type of error response is different from that of\nthe success response. If not specified, contentType input value is used to parse\nthe error response."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ErrorContentType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"File operation to download a given file from Intersight storage services such as\nAWS or Minio bucket to a specified path on one or more Intersight connected devices."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.WorkflowFileDownloadOp FileDownload {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Populates data driven template file with input values to generate textual output."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.WorkflowFileTemplateOp FileTemplate {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user friendly label that task designers have given to the batch API request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference name for this API request within the batch API request.\nThis name shall be used to map the API output parameters to subsequent\nAPI input parameters within a batch API task."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowFileOperations.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"File operation type to be executed on the connected endpoint.\n* `FileDownload` - The API is executed in a remote device connected to the Intersightthrough its device connector. This operation is to download the filefrom specified storage bucket to the specific path on the device.\n* `FileTemplatize` - Populates data driven template file with input values to generate textual output.Inputs - the path of the template file on the device and json values to populate.An error will be returned if the file does not exists or if there is an error whileexecuting the template."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowFileOperations.OperationTypeEnum OperationType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"All the possible outcomes of this API are captured here. Outcomes property\nis a collection property of type workflow.Outcome objects.\nThe outcomes can be mapped to the message to be shown. The outcomes are\nevaluated in the order they are given. At the end of the outcomes list,\nan catchall success/fail outcome can be added with condition as 'true'.\nThis is an optional\nproperty and if not specified the task will be marked as success."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object Outcomes {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The optional grammar specification for parsing the response to extract the\nrequired values.\nThe specification should have extraction specification specified for\nall the API output parameters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object ResponseSpec {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The skip expression, if provided, allows the batch API executor to skip the\napi execution when the given expression evaluates to true.\nThe expression is given as such a golang template that has to be\nevaluated to a final content true/false. The expression is an optional and in\ncase not provided, the API will always be executed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SkipOnCondition {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The delay in seconds after which the API needs to be executed.\nBy default, the given API is executed immediately. Specifying a start delay adds to the delay to execution.\nStart Delay is not supported for the first API in the Batch and cumulative delay of all the APIs in the Batch should not exceed the task time out."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long StartDelay {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The duration in seconds by which the API response is expected from the API target.\nIf the end point does not respond for the API request within this timeout\nduration, the task will be marked as failed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Timeout {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowSelectorProperty.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowSelectorProperty")]
    public class InitializeIntersightWorkflowSelectorProperty:PSCmdlet
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Content of the request body to send for POST request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object Body {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowSelectorProperty.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The HTTP method to be used.\n* `GET` - The HTTP GET method requests a representation of the specified resource.\n* `POST` - The HTTP POST method sends data to the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowSelectorProperty.MethodEnum Method {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowSelectorProperty.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowTargetDataType.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowTargetDataType")]
    public class InitializeIntersightWorkflowTargetDataType:PSCmdlet
	{
		public InitializeIntersightWorkflowTargetDataType()
		{
            ClassId = WorkflowTargetDataType.ClassIdEnum.WorkflowTargetDataType;
            ObjectType = WorkflowTargetDataType.ObjectTypeEnum.WorkflowTargetDataType;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowTargetDataType.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Reference to custom data type definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.WorkflowCustomDataProperty CustomDataTypeProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Default value for the data type. If default value was provided and the input was required the default value will be used as the input."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.WorkflowDefaultValue Default {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Provide a detailed description of the data type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Captures the meta data needed for displaying workflow data types in Intersight User Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.WorkflowDisplayMeta DisplayMeta {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"JSON formatted mapping from other property of the definition to the current property. Input parameter mapping is supported only for custom data type property in workflow definition and custom data type definition. The format to specify mapping ina workflow definition when source property is of scalar types is '${workflow.input.property}'. The format to specify mapping when the source property is of object reference and mapping needs to be made to the property of the object is '${workflow.input.property.subproperty}'. The format to specify mapping in a custom data type definition is '${datatype.type.property}'. When the current property is of non-scalar type like composite custom data type, then mapping can be provided to the individual property of the custom data type like 'cdt_property:${workflow.input.property}'."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object InputParameters {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When this property is true then an array of targets can be passed as input."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool IsArray {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Descriptive label for the data type. Label can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), space ( ) or an underscore (_). The first and last character in label must be an alphanumeric character."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+[\\sa-zA-Z0-9_'.:-]{1,92}$")]
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specify the maximum value of the array."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Max {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specify the minimum value of the array."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Min {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Descriptive name for the data type. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-) or an underscore (_). The first and last character in name must be an alphanumeric character."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+([a-zA-Z0-9-_]*[a-zA-Z0-9])*$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowTargetDataType.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.WorkflowTargetProperty> Properties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specifies whether this parameter is required. The field is applicable for task and workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Required {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowWorkflowCtx.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowWorkflowCtx")]
    public class InitializeIntersightWorkflowWorkflowCtx:PSCmdlet
	{
		public InitializeIntersightWorkflowWorkflowCtx()
		{
            ClassId = WorkflowWorkflowCtx.ClassIdEnum.WorkflowWorkflowCtx;
            ObjectType = WorkflowWorkflowCtx.ObjectTypeEnum.WorkflowWorkflowCtx;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowWorkflowCtx.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Details about initiator of the workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.WorkflowInitiatorContext InitiatorCtx {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowWorkflowCtx.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.WorkflowTargetContext> TargetCtxList {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of workflowMeta of the workflow running."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string WorkflowMetaName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The subtype of the workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string WorkflowSubtype {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of the workflow being started. This can be any string for client services to distinguish workflow by type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string WorkflowType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
            if (this.MyInvocation.BoundParameters.ContainsKey("TargetCtxList"))
            {
                initObject.TargetCtxList = this.TargetCtxList;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("WorkflowMetaName"))
            {
                initObject.WorkflowMetaName = this.WorkflowMetaName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("WorkflowSubtype"))
            {
                initObject.WorkflowSubtype = this.WorkflowSubtype;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("WorkflowType"))
            {
                initObject.WorkflowType = this.WorkflowType;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowFileTransfer.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowFileTransfer")]
    public class InitializeIntersightWorkflowFileTransfer:PSCmdlet
	{
		public InitializeIntersightWorkflowFileTransfer()
		{
            ClassId = WorkflowFileTransfer.ClassIdEnum.WorkflowFileTransfer;
            ObjectType = WorkflowFileTransfer.ObjectTypeEnum.WorkflowFileTransfer;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowFileTransfer.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Destination file path on the target server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DestinationFilePath {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The secure properties that have large text content as value can be encrypted using AES key. In these cases, the AES key needs to be encrypted using the device connector public key and passed as the value for this property.\nThe secure properties that are encrypted using the AES key are mapped against the property name with prefix 'AES' in SecureProperties dictionary."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string EncryptedAesKey {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The public key that was used to encrypt the values present in SecureProperties dictionary.\nIf the given public key is not same as device connector's public key, an error reponse with appropriate error message is thrown back."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string EncryptionKey {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"File permission to set on the transferred file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long FileMode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowFileTransfer.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A dictionary of encrypted secure values mapped against the secure property name. The values that are encrypted using AES key must be mapped against the secure property name with a 'AES' prefix\nDevice connector expects the message body to be a golang template and the template can use the secure property names as placeholders."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object SecureProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Source file path on the Intersight connected device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SourceFilePath {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowEnumEntry.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowEnumEntry")]
    public class InitializeIntersightWorkflowEnumEntry:PSCmdlet
	{
		public InitializeIntersightWorkflowEnumEntry()
		{
            ClassId = WorkflowEnumEntry.ClassIdEnum.WorkflowEnumEntry;
            ObjectType = WorkflowEnumEntry.ObjectTypeEnum.WorkflowEnumEntry;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowEnumEntry.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Label for the enum value. A user friendly short string to identify the enum value. Label can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.), colon (:), space ( ), single quote ('), forward slash (/), or an underscore (_) and must be at least 2 characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+[+\\s\\/a-zA-Z0-9_'.:-]{1,92}$")]
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowEnumEntry.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enum value for this enum entry. Value will be passed to the workflow as string type for execution. Value can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.), colon (:), space ( ), forward slash (/), or an underscore (_)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]*[+\\s\\/a-zA-Z0-9_.:-]{1,64}$")]
        public string Value {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowFileTemplateOp.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowFileTemplateOp")]
    public class InitializeIntersightWorkflowFileTemplateOp:PSCmdlet
	{
		public InitializeIntersightWorkflowFileTemplateOp()
		{
            ClassId = WorkflowFileTemplateOp.ClassIdEnum.WorkflowFileTemplateOp;
            ObjectType = WorkflowFileTemplateOp.ObjectTypeEnum.WorkflowFileTemplateOp;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowFileTemplateOp.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowFileTemplateOp.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Path of the template file on the connected device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string TemplateFilePath {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Input values to render text output file from template file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object TemplateValues {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowPrimitiveDataType.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowPrimitiveDataType")]
    public class InitializeIntersightWorkflowPrimitiveDataType:PSCmdlet
	{
		public InitializeIntersightWorkflowPrimitiveDataType()
		{
            ClassId = WorkflowPrimitiveDataType.ClassIdEnum.WorkflowPrimitiveDataType;
            ObjectType = WorkflowPrimitiveDataType.ObjectTypeEnum.WorkflowPrimitiveDataType;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowPrimitiveDataType.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Default value for the data type. If default value was provided and the input was required the default value will be used as the input."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.WorkflowDefaultValue Default {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Provide a detailed description of the data type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Captures the meta data needed for displaying workflow data types in Intersight User Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.WorkflowDisplayMeta DisplayMeta {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"JSON formatted mapping from other property of the definition to the current property. Input parameter mapping is supported only for custom data type property in workflow definition and custom data type definition. The format to specify mapping ina workflow definition when source property is of scalar types is '${workflow.input.property}'. The format to specify mapping when the source property is of object reference and mapping needs to be made to the property of the object is '${workflow.input.property.subproperty}'. The format to specify mapping in a custom data type definition is '${datatype.type.property}'. When the current property is of non-scalar type like composite custom data type, then mapping can be provided to the individual property of the custom data type like 'cdt_property:${workflow.input.property}'."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object InputParameters {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Descriptive label for the data type. Label can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), space ( ) or an underscore (_). The first and last character in label must be an alphanumeric character."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+[\\sa-zA-Z0-9_'.:-]{1,92}$")]
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Descriptive name for the data type. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-) or an underscore (_). The first and last character in name must be an alphanumeric character."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+([a-zA-Z0-9-_]*[a-zA-Z0-9])*$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowPrimitiveDataType.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Primitive data type properties."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.WorkflowPrimitiveDataProperty Properties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specifies whether this parameter is required. The field is applicable for task and workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Required {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowFailureEndTask.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowFailureEndTask")]
    public class InitializeIntersightWorkflowFailureEndTask:PSCmdlet
	{
		public InitializeIntersightWorkflowFailureEndTask()
		{
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowFailureEndTask.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The description of this task instance in the workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user defined label identifier of the workflow task used for UI display."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the task within the workflow and it must be unique among all WorkflowTasks within a workflow definition. This name serves as the internal unique identifier for the task and is used to pick input and output parameters to feed into other tasks."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowFailureEndTask.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowJoinTask.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowJoinTask")]
    public class InitializeIntersightWorkflowJoinTask:PSCmdlet
	{
		public InitializeIntersightWorkflowJoinTask()
		{
            ClassId = WorkflowJoinTask.ClassIdEnum.WorkflowJoinTask;
            ObjectType = WorkflowJoinTask.ObjectTypeEnum.WorkflowJoinTask;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowJoinTask.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The description of this task instance in the workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user defined label identifier of the workflow task used for UI display."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the task within the workflow and it must be unique among all WorkflowTasks within a workflow definition. This name serves as the internal unique identifier for the task and is used to pick input and output parameters to feed into other tasks."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowJoinTask.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the next task to run if all fork path specified in the JoinOnTasks list succeeds which is the unique name given to the task instance within the workflow. In a graph model, denotes an edge to another Task Node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string OnSuccess {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowInternalProperties.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowInternalProperties")]
    public class InitializeIntersightWorkflowInternalProperties:PSCmdlet
	{
		public InitializeIntersightWorkflowInternalProperties()
		{
            ClassId = WorkflowInternalProperties.ClassIdEnum.WorkflowInternalProperties;
            ObjectType = WorkflowInternalProperties.ObjectTypeEnum.WorkflowInternalProperties;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowInternalProperties.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowInternalProperties.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowPrimitiveDataProperty.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowPrimitiveDataProperty")]
    public class InitializeIntersightWorkflowPrimitiveDataProperty:PSCmdlet
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowPrimitiveDataProperty.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Constraints that must be applied to the parameter value supplied for this data type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.WorkflowConstraints Constraints {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.WorkflowMoReferenceProperty> InventorySelector {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowPrimitiveDataProperty.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Intersight supports secure properties as task input/output. The values of\nthese properties are encrypted and stored in Intersight.\nThis flag marks the property to be secure when it is set to true."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Secure {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specify the enum type for primitive data type.\n* `string` - Enum to specify a string data type.\n* `integer` - Enum to specify an integer32 data type.\n* `float` - Enum to specify a float64 data type.\n* `boolean` - Enum to specify a boolean data type.\n* `json` - Enum to specify a json data type.\n* `enum` - Enum to specify a enum data type which is a list of pre-defined strings."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowPrimitiveDataProperty.TypeEnum Type {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowDisplayMeta.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowDisplayMeta")]
    public class InitializeIntersightWorkflowDisplayMeta:PSCmdlet
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowDisplayMeta.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Inventory selector specified for primitive data property should be used in Intersight User Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool InventorySelector {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowDisplayMeta.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specify the widget type for data display.\n* `None` - Display none of the widget types.\n* `Radio` - Display the widget as a radio button.\n* `Dropdown` - Display the widget as a dropdown.\n* `GridSelector` - Display the widget as a selector.\n* `DrawerSelector` - Display the widget as a selector."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowDisplayMeta.WidgetTypeEnum WidgetType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowConstraints.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowConstraints")]
    public class InitializeIntersightWorkflowConstraints:PSCmdlet
	{
		public InitializeIntersightWorkflowConstraints()
		{
            ClassId = WorkflowConstraints.ClassIdEnum.WorkflowConstraints;
            ObjectType = WorkflowConstraints.ObjectTypeEnum.WorkflowConstraints;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowConstraints.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.WorkflowEnumEntry> EnumList {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Allowed maximum value of the parameter if parameter is integer/float or maximum length of the parameter if the parameter is string. When max and min are set to 0, then the limits are not checked. If parameter is integer/float, then maximum number supported is 1.797693134862315708145274237317043567981e+308 or (2**1023 * (2**53 - 1) / 2**52). When a number bigger than this is given as Maximum value, the constraints will not be enforced."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public double Max {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Allowed minimum value of the parameter if parameter is integer/float or minimum length of the parameter if the parameter is string. When max and min are set to 0, then the limits are not checked. If parameter is integer/float, then minimum number supported is 4.940656458412465441765687928682213723651e-324 or (1 / 2 ** (1023 - 1 + 52)). When a number smaller than this is given as minimum value, the constraints will not be enforced."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public double Min {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowConstraints.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When the parameter is a string this regular expression is used to ensure the value is valid."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Regex {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowSshSession.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowSshSession")]
    public class InitializeIntersightWorkflowSshSession:PSCmdlet
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The optional request body that is sent as part of this API request.\nThe request body can contain a golang template that can be populated with task input\nparameters and previous API output parameters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Body {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowSshSession.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Intersight Orchestrator, with the support of response parser specification,\ncan extract the values from API responses and map them to task output parameters.\nThe value extraction is supported for response content types XML, JSON and Text.\nThe type of the content that gets passed as payload and response in this\nAPI. The supported values are json, xml, text."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ContentType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A description that task designer can add to individual API requests that explain \nwhat the API call is about."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Intersight Orchestrator, with the support of response parser specification,\ncan extract the values from API responses and map them to task output parameters.\nThe value extraction is supported for response content types XML, JSON and Text.\nOptional input to specify the content type in case of error API response. This\nshould be used if the content type of error response is different from that of\nthe success response. If not specified, contentType input value is used to parse\nthe error response."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ErrorContentType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Message to transfer a file from Intersight connected device to remote server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.WorkflowFileTransfer FileTransferToRemote {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user friendly label that task designers have given to the batch API request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of SSH message to send to the remote server.\n* `ExecuteCommand` - Execute a SSH command on the remote server.\n* `NewSession` - Open a new SSH connection to the remote server.\n* `FileTransfer` - Transfer a file from Intersight connected device to the remote server.\n* `CloseSession` - Close the SSH connection to the remote server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowSshSession.MessageTypeEnum MessageType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference name for this API request within the batch API request.\nThis name shall be used to map the API output parameters to subsequent\nAPI input parameters within a batch API task."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowSshSession.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"All the possible outcomes of this API are captured here. Outcomes property\nis a collection property of type workflow.Outcome objects.\nThe outcomes can be mapped to the message to be shown. The outcomes are\nevaluated in the order they are given. At the end of the outcomes list,\nan catchall success/fail outcome can be added with condition as 'true'.\nThis is an optional\nproperty and if not specified the task will be marked as success."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object Outcomes {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The optional grammar specification for parsing the response to extract the\nrequired values.\nThe specification should have extraction specification specified for\nall the API output parameters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object ResponseSpec {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The skip expression, if provided, allows the batch API executor to skip the\napi execution when the given expression evaluates to true.\nThe expression is given as such a golang template that has to be\nevaluated to a final content true/false. The expression is an optional and in\ncase not provided, the API will always be executed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SkipOnCondition {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SSH command to execute on the remote server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.WorkflowSshCmd SshCommand {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Carries the SSH session details for opening a new connection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.WorkflowSshConfig SshConfiguration {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The delay in seconds after which the API needs to be executed.\nBy default, the given API is executed immediately. Specifying a start delay adds to the delay to execution.\nStart Delay is not supported for the first API in the Batch and cumulative delay of all the APIs in the Batch should not exceed the task time out."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long StartDelay {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The duration in seconds by which the API response is expected from the API target.\nIf the end point does not respond for the API request within this timeout\nduration, the task will be marked as failed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Timeout {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.WorkflowSshSession initObject = new Intersight.Model.WorkflowSshSession();
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowWaitTaskPrompt.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowWaitTaskPrompt")]
    public class InitializeIntersightWorkflowWaitTaskPrompt:PSCmdlet
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowWaitTaskPrompt.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description that give more details about what it means to pick this prompt option for the wait task."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User friendly label for the prompt. This label will be shown to the user as one of available options for the wait task."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name for the wait prompt."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowWaitTaskPrompt.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Task status for the wait task when this prompt option is selected.\n* `Scheduled` - The enum represents the status when task is in scheduled state.\n* `InProgress` - The enum represents the status when task is in-progress state.\n* `NoOp` - The enum represents the status when task is a noop.\n* `Timeout` - The enum represents the status when task has timed out.\n* `Completed` - The enum represents the status when task has completed.\n* `Failed` - The enum represents the status when task has failed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowWaitTaskPrompt.TaskStatusEnum TaskStatus {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowMoReferenceArrayItem.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowMoReferenceArrayItem")]
    public class InitializeIntersightWorkflowMoReferenceArrayItem:PSCmdlet
	{
		public InitializeIntersightWorkflowMoReferenceArrayItem()
		{
            ClassId = WorkflowMoReferenceArrayItem.ClassIdEnum.WorkflowMoReferenceArrayItem;
            ObjectType = WorkflowMoReferenceArrayItem.ObjectTypeEnum.WorkflowMoReferenceArrayItem;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowMoReferenceArrayItem.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowMoReferenceArrayItem.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.WorkflowMoReferenceProperty> Properties {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowWorkflowProperties.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowWorkflowProperties")]
    public class InitializeIntersightWorkflowWorkflowProperties:PSCmdlet
	{
		public InitializeIntersightWorkflowWorkflowProperties()
		{
            ClassId = WorkflowWorkflowProperties.ClassIdEnum.WorkflowWorkflowProperties;
            ObjectType = WorkflowWorkflowProperties.ObjectTypeEnum.WorkflowWorkflowProperties;
            SupportStatus = WorkflowWorkflowProperties.SupportStatusEnum.Supported;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowWorkflowProperties.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enabling this flag will capture request and response details as debug logs for tasks that are using workflow.BatchApi for implementation. For other tasks in the workflow which are not based on workflow.BatchApi logs will not be generated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool EnableDebug {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When set to false the workflow is owned by the system and used for internal services. Such workflows cannot be directly used by external entities."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool ExternalMeta {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowWorkflowProperties.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When true, this workflow can be retried if has not been modified for more than a period of 2 weeks."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Retryable {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Supported status of the definition.\n* `Supported` - The definition is a supported version and there will be no changes to the mandatory inputs or outputs.\n* `Beta` - The definition is a Beta version and this version can under go changes until the version is marked supported.\n* `Deprecated` - The version of definition is deprecated and typically there will be a higher version of the same definition that has been added."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowWorkflowProperties.SupportStatusEnum SupportStatus {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
            if (this.MyInvocation.BoundParameters.ContainsKey("ExternalMeta"))
            {
                initObject.ExternalMeta = this.ExternalMeta;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Retryable"))
            {
                initObject.Retryable = this.Retryable;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SupportStatus"))
            {
                initObject.SupportStatus = this.SupportStatus;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowUiInputFilter.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowUiInputFilter")]
    public class InitializeIntersightWorkflowUiInputFilter:PSCmdlet
	{
		public InitializeIntersightWorkflowUiInputFilter()
		{
            ClassId = WorkflowUiInputFilter.ClassIdEnum.WorkflowUiInputFilter;
            ObjectType = WorkflowUiInputFilter.ObjectTypeEnum.WorkflowUiInputFilter;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowUiInputFilter.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> Filters {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name for the input definition to which this filter applies. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-) or an underscore (_). The first and last character in name must be an alphanumeric character. When defining the cascade filter for a sub property, use a period (.) to seperate each section of the name like \"StorageConfig.Volume\" where 'StorageConfig' is an input name and 'Volume' is a sub property defined through custom data type definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+([a-zA-Z0-9-_.]*[a-zA-Z0-9])*$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowUiInputFilter.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Help message shown to the user about which prior input needs to be selected to enable the input mapped to this filter."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string UserHelpMessage {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowCustomDataType.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowCustomDataType")]
    public class InitializeIntersightWorkflowCustomDataType:PSCmdlet
	{
		public InitializeIntersightWorkflowCustomDataType()
		{
            ClassId = WorkflowCustomDataType.ClassIdEnum.WorkflowCustomDataType;
            ObjectType = WorkflowCustomDataType.ObjectTypeEnum.WorkflowCustomDataType;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowCustomDataType.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Default value for the data type. If default value was provided and the input was required the default value will be used as the input."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.WorkflowDefaultValue Default {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Provide a detailed description of the data type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Captures the meta data needed for displaying workflow data types in Intersight User Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.WorkflowDisplayMeta DisplayMeta {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"JSON formatted mapping from other property of the definition to the current property. Input parameter mapping is supported only for custom data type property in workflow definition and custom data type definition. The format to specify mapping ina workflow definition when source property is of scalar types is '${workflow.input.property}'. The format to specify mapping when the source property is of object reference and mapping needs to be made to the property of the object is '${workflow.input.property.subproperty}'. The format to specify mapping in a custom data type definition is '${datatype.type.property}'. When the current property is of non-scalar type like composite custom data type, then mapping can be provided to the individual property of the custom data type like 'cdt_property:${workflow.input.property}'."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object InputParameters {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Descriptive label for the data type. Label can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), space ( ) or an underscore (_). The first and last character in label must be an alphanumeric character."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+[\\sa-zA-Z0-9_'.:-]{1,92}$")]
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Descriptive name for the data type. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-) or an underscore (_). The first and last character in name must be an alphanumeric character."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+([a-zA-Z0-9-_]*[a-zA-Z0-9])*$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowCustomDataType.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Captures the custom data type properties."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.WorkflowCustomDataProperty Properties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specifies whether this parameter is required. The field is applicable for task and workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Required {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowComments.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowComments")]
    public class InitializeIntersightWorkflowComments:PSCmdlet
	{
		public InitializeIntersightWorkflowComments()
		{
            ClassId = WorkflowComments.ClassIdEnum.WorkflowComments;
            ObjectType = WorkflowComments.ObjectTypeEnum.WorkflowComments;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowComments.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description field provides comment about the template function."</para>
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
        
        public List<string> Examples {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowComments.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowTargetProperty.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowTargetProperty")]
    public class InitializeIntersightWorkflowTargetProperty:PSCmdlet
	{
		public InitializeIntersightWorkflowTargetProperty()
		{
            ClassId = WorkflowTargetProperty.ClassIdEnum.WorkflowTargetProperty;
            ObjectType = WorkflowTargetProperty.ObjectTypeEnum.WorkflowTargetProperty;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowTargetProperty.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A singleton value which will contain the path to connector object from the selected object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ConnectorAttribute {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> ConstraintAttributes {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> DisplayAttributes {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowTargetProperty.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Field to hold an Intersight API along with an optional filter to narrow down the search options for target device."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|/api/v1/.*")]
        public string Selector {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Selector properties to define HTTP method and 'body' in case of upsert operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.WorkflowSelectorProperty SelectorProperty {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> SupportedObjects {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowSshConfig.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowSshConfig")]
    public class InitializeIntersightWorkflowSshConfig:PSCmdlet
	{
		public InitializeIntersightWorkflowSshConfig()
		{
            ClassId = WorkflowSshConfig.ClassIdEnum.WorkflowSshConfig;
            ObjectType = WorkflowSshConfig.ObjectTypeEnum.WorkflowSshConfig;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowSshConfig.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The secure properties that have large text content as value can be encrypted using AES key. In these cases, the AES key needs to be encrypted using the device connector public key and passed as the value for this property.\nThe secure properties that are encrypted using the AES key are mapped against the property name with prefix 'AES' in SecureProperties dictionary."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string EncryptedAesKey {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The public key that was used to encrypt the values present in SecureProperties dictionary.\nIf the given public key is not same as device connector's public key, an error reponse with appropriate error message is thrown back."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string EncryptionKey {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowSshConfig.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Password to use in the SSH connection credentials (If empty then private key will be used)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Password {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A dictionary of encrypted secure values mapped against the secure property name. The values that are encrypted using AES key must be mapped against the secure property name with a 'AES' prefix\nDevice connector expects the message body to be a golang template and the template can use the secure property names as placeholders."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object SecureProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The remote server to connect to. IPv4 address represented in dot decimal notation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Target {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Username for the remote SSH connection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string User {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Password"))
            {
                initObject.Password = this.Password;
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowDefaultValue.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowDefaultValue")]
    public class InitializeIntersightWorkflowDefaultValue:PSCmdlet
	{
		public InitializeIntersightWorkflowDefaultValue()
		{
            ClassId = WorkflowDefaultValue.ClassIdEnum.WorkflowDefaultValue;
            ObjectType = WorkflowDefaultValue.ObjectTypeEnum.WorkflowDefaultValue;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowDefaultValue.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowDefaultValue.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Override the default value provided for the data type. When true, allow the user to enter value for the data type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Override {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Default value for the data type. If default value was provided and the input was required the default value will be used as the input."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object Value {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowDynamicWorkflowActionTaskList.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowDynamicWorkflowActionTaskList")]
    public class InitializeIntersightWorkflowDynamicWorkflowActionTaskList:PSCmdlet
	{
		public InitializeIntersightWorkflowDynamicWorkflowActionTaskList()
		{
            ClassId = WorkflowDynamicWorkflowActionTaskList.ClassIdEnum.WorkflowDynamicWorkflowActionTaskList;
            ObjectType = WorkflowDynamicWorkflowActionTaskList.ObjectTypeEnum.WorkflowDynamicWorkflowActionTaskList;
            
		}
        // <summary>
        /// <para type="description">"The action of the Dynamic Workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Action {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowDynamicWorkflowActionTaskList.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowDynamicWorkflowActionTaskList.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The task list that has precedence which dictates how the workflow should be constructed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object Tasks {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.WorkflowDynamicWorkflowActionTaskList initObject = new Intersight.Model.WorkflowDynamicWorkflowActionTaskList();
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Tasks"))
            {
                initObject.Tasks = this.Tasks;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowExpectPrompt.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowExpectPrompt")]
    public class InitializeIntersightWorkflowExpectPrompt:PSCmdlet
	{
		public InitializeIntersightWorkflowExpectPrompt()
		{
            ClassId = WorkflowExpectPrompt.ClassIdEnum.WorkflowExpectPrompt;
            ObjectType = WorkflowExpectPrompt.ObjectTypeEnum.WorkflowExpectPrompt;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowExpectPrompt.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The regex of the expect prompt of the interactive command."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Expect {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowExpectPrompt.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The answer string to the expect prompt."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Send {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowAssociatedRoles.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowAssociatedRoles")]
    public class InitializeIntersightWorkflowAssociatedRoles:PSCmdlet
	{
		public InitializeIntersightWorkflowAssociatedRoles()
		{
            ClassId = WorkflowAssociatedRoles.ClassIdEnum.WorkflowAssociatedRoles;
            ObjectType = WorkflowAssociatedRoles.ObjectTypeEnum.WorkflowAssociatedRoles;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowAssociatedRoles.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowAssociatedRoles.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowWorkflowInfoProperties.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowWorkflowInfoProperties")]
    public class InitializeIntersightWorkflowWorkflowInfoProperties:PSCmdlet
	{
		public InitializeIntersightWorkflowWorkflowInfoProperties()
		{
            ClassId = WorkflowWorkflowInfoProperties.ClassIdEnum.WorkflowWorkflowInfoProperties;
            ObjectType = WorkflowWorkflowInfoProperties.ObjectTypeEnum.WorkflowWorkflowInfoProperties;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowWorkflowInfoProperties.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowWorkflowInfoProperties.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When true, this workflow can be retried if has not been modified for more than a period of 2 weeks."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Retryable {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.WorkflowWorkflowInfoProperties initObject = new Intersight.Model.WorkflowWorkflowInfoProperties();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Retryable"))
            {
                initObject.Retryable = this.Retryable;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowWebApi.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowWebApi")]
    public class InitializeIntersightWorkflowWebApi:PSCmdlet
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The optional request body that is sent as part of this API request.\nThe request body can contain a golang template that can be populated with task input\nparameters and previous API output parameters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Body {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowWebApi.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Intersight Orchestrator, with the support of response parser specification,\ncan extract the values from API responses and map them to task output parameters.\nThe value extraction is supported for response content types XML, JSON and Text.\nThe type of the content that gets passed as payload and response in this\nAPI. The supported values are json, xml, text."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ContentType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Collection of key value pairs to set in the request header as Cookie list."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object Cookies {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A description that task designer can add to individual API requests that explain \nwhat the API call is about."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If the target type is Endpoint, this property determines whether the request is\nto be handled as internal request or external request by the device connector.\n* `Internal` - The endpoint API executed is an internal request handled by the device connector plugin.\n* `External` - The endpoint API request is passed through by the device connector."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowWebApi.EndpointRequestTypeEnum EndpointRequestType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Intersight Orchestrator, with the support of response parser specification,\ncan extract the values from API responses and map them to task output parameters.\nThe value extraction is supported for response content types XML, JSON and Text.\nOptional input to specify the content type in case of error API response. This\nshould be used if the content type of error response is different from that of\nthe success response. If not specified, contentType input value is used to parse\nthe error response."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ErrorContentType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Collection of key value pairs to set in the request header."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object Headers {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user friendly label that task designers have given to the batch API request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The HTTP method to be executed in the given URL (GET, POST, PUT, etc).\nIf the value is not specified, GET will be used as default.\nThe supported values are GET, POST, PUT, DELETE, PATCH, HEAD."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Method {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of the intersight object for which API request is to be made.\nThe property is valid in case of Intersight API calls and the base url is automatically prepended based on the value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string MoType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference name for this API request within the batch API request.\nThis name shall be used to map the API output parameters to subsequent\nAPI input parameters within a batch API task."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowWebApi.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"All the possible outcomes of this API are captured here. Outcomes property\nis a collection property of type workflow.Outcome objects.\nThe outcomes can be mapped to the message to be shown. The outcomes are\nevaluated in the order they are given. At the end of the outcomes list,\nan catchall success/fail outcome can be added with condition as 'true'.\nThis is an optional\nproperty and if not specified the task will be marked as success."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object Outcomes {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The accepted web protocol values are http and https."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Protocol {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The optional grammar specification for parsing the response to extract the\nrequired values.\nThe specification should have extraction specification specified for\nall the API output parameters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object ResponseSpec {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The skip expression, if provided, allows the batch API executor to skip the\napi execution when the given expression evaluates to true.\nThe expression is given as such a golang template that has to be\nevaluated to a final content true/false. The expression is an optional and in\ncase not provided, the API will always be executed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SkipOnCondition {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The delay in seconds after which the API needs to be executed.\nBy default, the given API is executed immediately. Specifying a start delay adds to the delay to execution.\nStart Delay is not supported for the first API in the Batch and cumulative delay of all the APIs in the Batch should not exceed the task time out."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long StartDelay {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If the web API is to be executed in a remote device connected to the\nIntersight through device connector, 'Endpoint' is expected as the value\nwhereas if the API is an Intersight API, 'Local' is expected as the value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string TargetType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The duration in seconds by which the API response is expected from the API target.\nIf the end point does not respond for the API request within this timeout\nduration, the task will be marked as failed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Timeout {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The URL of the resource in the target to which the API request is made."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Url {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowDecisionCase.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowDecisionCase")]
    public class InitializeIntersightWorkflowDecisionCase:PSCmdlet
	{
		public InitializeIntersightWorkflowDecisionCase()
		{
            ClassId = WorkflowDecisionCase.ClassIdEnum.WorkflowDecisionCase;
            ObjectType = WorkflowDecisionCase.ObjectTypeEnum.WorkflowDecisionCase;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowDecisionCase.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of this decision case."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the next task (Task names unique within workflow) to run.  In a graph model, denotes an edge to another Task Node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string NextTask {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowDecisionCase.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Value for the decision case."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Value {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowMessage.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowMessage")]
    public class InitializeIntersightWorkflowMessage:PSCmdlet
	{
		public InitializeIntersightWorkflowMessage()
		{
            ClassId = WorkflowMessage.ClassIdEnum.WorkflowMessage;
            ObjectType = WorkflowMessage.ObjectTypeEnum.WorkflowMessage;
            Severity = WorkflowMessage.SeverityEnum.Info;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowMessage.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An i18n message that can be translated in multiple languages to support internationalization."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Message {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowMessage.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The severity of the Task or Workflow message warning/error/info etc.\n* `Info` - The enum represents the log level to be used to convey info message.\n* `Warning` - The enum represents the log level to be used to convey warning message.\n* `Debug` - The enum represents the log level to be used to convey debug message.\n* `Error` - The enum represents the log level to be used to convey error message."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowMessage.SeverityEnum Severity {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.WorkflowMessage initObject = new Intersight.Model.WorkflowMessage();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Message"))
            {
                initObject.Message = this.Message;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Severity"))
            {
                initObject.Severity = this.Severity;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowTaskRetryInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowTaskRetryInfo")]
    public class InitializeIntersightWorkflowTaskRetryInfo:PSCmdlet
	{
		public InitializeIntersightWorkflowTaskRetryInfo()
		{
            ClassId = WorkflowTaskRetryInfo.ClassIdEnum.WorkflowTaskRetryInfo;
            ObjectType = WorkflowTaskRetryInfo.ObjectTypeEnum.WorkflowTaskRetryInfo;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowTaskRetryInfo.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowTaskRetryInfo.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Status of the retried task."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Status {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Retry instance will get a unique instance id."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string TaskInstId {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.WorkflowTaskRetryInfo initObject = new Intersight.Model.WorkflowTaskRetryInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Status"))
            {
                initObject.Status = this.Status;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TaskInstId"))
            {
                initObject.TaskInstId = this.TaskInstId;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowForkTask.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowForkTask")]
    public class InitializeIntersightWorkflowForkTask:PSCmdlet
	{
		public InitializeIntersightWorkflowForkTask()
		{
            ClassId = WorkflowForkTask.ClassIdEnum.WorkflowForkTask;
            ObjectType = WorkflowForkTask.ObjectTypeEnum.WorkflowForkTask;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowForkTask.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The description of this task instance in the workflow."</para>
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
        
        public List<string> ForkedTasks {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Task name for the join control task that must follow a fork control task."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string JoinTask {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user defined label identifier of the workflow task used for UI display."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the task within the workflow and it must be unique among all WorkflowTasks within a workflow definition. This name serves as the internal unique identifier for the task and is used to pick input and output parameters to feed into other tasks."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowForkTask.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowWorkflowEngineProperties.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowWorkflowEngineProperties")]
    public class InitializeIntersightWorkflowWorkflowEngineProperties:PSCmdlet
	{
		public InitializeIntersightWorkflowWorkflowEngineProperties()
		{
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowWorkflowEngineProperties.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowWorkflowEngineProperties.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowSubWorkflowTask.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowSubWorkflowTask")]
    public class InitializeIntersightWorkflowSubWorkflowTask:PSCmdlet
	{
		public InitializeIntersightWorkflowSubWorkflowTask()
		{
            ClassId = WorkflowSubWorkflowTask.ClassIdEnum.WorkflowSubWorkflowTask;
            ObjectType = WorkflowSubWorkflowTask.ObjectTypeEnum.WorkflowSubWorkflowTask;
            
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
        /// <para type="description">"Specify the catalog moid that this task belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string CatalogMoid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowSubWorkflowTask.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The description of this task instance in the workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"JSON formatted map that defines the input given to the task. JSONPath is used for chaining output from previous tasks as inputs into the current task. The format to specify the mapping is '${Source.input/output.JsonPath}'. 'Source' can be either workflow or the name of the task within the workflow. You can map the task input to either a workflow input or a task output. Following this is JSON path expression to extract JSON fragment from source's input/output."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object InputParameters {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user defined label identifier of the workflow task used for UI display."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the task within the workflow and it must be unique among all WorkflowTasks within a workflow definition. This name serves as the internal unique identifier for the task and is used to pick input and output parameters to feed into other tasks."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowSubWorkflowTask.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This specifies the name of the next task to run if Task fails.  This is the unique name given to the task instance within the workflow. In a graph model, denotes an edge to another Task Node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string OnFailure {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This specifies the name of the next task to run if Task succeeds.  This is the unique name given to the task instance within the workflow. In a graph model, denotes an edge to another Task Node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string OnSuccess {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The task is disabled/enabled for rollback operation in this workflow if the task has rollback support."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool RollbackDisabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"UseDefault when set to true, means the default version of the task or workflow will be used at the time of execution. When this property is set then version for task or subworkflow cannot be set. When workflow is created or updated the default version of task or subworkflow will be used for validation, but when the workflow is executed the default version that that time will be used for validation and subsequent execution."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool UseDefault {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The workflow definition version to use as subworkflow. When no version is specified then the default version of the workflow at the time of creating or updating this workflow is used."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Version {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The qualified name of workflow that should be executed as a task."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string WorkflowDefinitionName {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
            if (this.MyInvocation.BoundParameters.ContainsKey("UseDefault"))
            {
                initObject.UseDefault = this.UseDefault;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("WorkflowDefinitionName"))
            {
                initObject.WorkflowDefinitionName = this.WorkflowDefinitionName;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowPrimitiveArrayItem.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowPrimitiveArrayItem")]
    public class InitializeIntersightWorkflowPrimitiveArrayItem:PSCmdlet
	{
		public InitializeIntersightWorkflowPrimitiveArrayItem()
		{
            ClassId = WorkflowPrimitiveArrayItem.ClassIdEnum.WorkflowPrimitiveArrayItem;
            ObjectType = WorkflowPrimitiveArrayItem.ObjectTypeEnum.WorkflowPrimitiveArrayItem;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowPrimitiveArrayItem.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowPrimitiveArrayItem.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Captures an array item which is of primitive data type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.WorkflowPrimitiveDataProperty Properties {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowSuccessEndTask.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowSuccessEndTask")]
    public class InitializeIntersightWorkflowSuccessEndTask:PSCmdlet
	{
		public InitializeIntersightWorkflowSuccessEndTask()
		{
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowSuccessEndTask.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The description of this task instance in the workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user defined label identifier of the workflow task used for UI display."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the task within the workflow and it must be unique among all WorkflowTasks within a workflow definition. This name serves as the internal unique identifier for the task and is used to pick input and output parameters to feed into other tasks."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowSuccessEndTask.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowValidationError.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowValidationError")]
    public class InitializeIntersightWorkflowValidationError:PSCmdlet
	{
		public InitializeIntersightWorkflowValidationError()
		{
            ClassId = WorkflowValidationError.ClassIdEnum.WorkflowValidationError;
            ObjectType = WorkflowValidationError.ObjectTypeEnum.WorkflowValidationError;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowValidationError.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowValidationError.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowCliCommand.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowCliCommand")]
    public class InitializeIntersightWorkflowCliCommand:PSCmdlet
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The optional request body that is sent as part of this API request.\nThe request body can contain a golang template that can be populated with task input\nparameters and previous API output parameters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Body {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowCliCommand.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The command to run on the device connector."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Command {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Intersight Orchestrator, with the support of response parser specification,\ncan extract the values from API responses and map them to task output parameters.\nThe value extraction is supported for response content types XML, JSON and Text.\nThe type of the content that gets passed as payload and response in this\nAPI. The supported values are json, xml, text."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ContentType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A description that task designer can add to individual API requests that explain \nwhat the API call is about."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The regex string that identifies the end of the command response."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string EndPrompt {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Intersight Orchestrator, with the support of response parser specification,\ncan extract the values from API responses and map them to task output parameters.\nThe value extraction is supported for response content types XML, JSON and Text.\nOptional input to specify the content type in case of error API response. This\nshould be used if the content type of error response is different from that of\nthe success response. If not specified, contentType input value is used to parse\nthe error response."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ErrorContentType {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.WorkflowExpectPrompt> ExpectPrompts {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<long> ExpectedExitCodes {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user friendly label that task designers have given to the batch API request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference name for this API request within the batch API request.\nThis name shall be used to map the API output parameters to subsequent\nAPI input parameters within a batch API task."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowCliCommand.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"All the possible outcomes of this API are captured here. Outcomes property\nis a collection property of type workflow.Outcome objects.\nThe outcomes can be mapped to the message to be shown. The outcomes are\nevaluated in the order they are given. At the end of the outcomes list,\nan catchall success/fail outcome can be added with condition as 'true'.\nThis is an optional\nproperty and if not specified the task will be marked as success."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object Outcomes {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The optional grammar specification for parsing the response to extract the\nrequired values.\nThe specification should have extraction specification specified for\nall the API output parameters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object ResponseSpec {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The skip expression, if provided, allows the batch API executor to skip the\napi execution when the given expression evaluates to true.\nThe expression is given as such a golang template that has to be\nevaluated to a final content true/false. The expression is an optional and in\ncase not provided, the API will always be executed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SkipOnCondition {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Skips the execution status check of the terminal command. One use case for this is while exiting the\nterminal session from esxi host."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool SkipStatusCheck {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The delay in seconds after which the API needs to be executed.\nBy default, the given API is executed immediately. Specifying a start delay adds to the delay to execution.\nStart Delay is not supported for the first API in the Batch and cumulative delay of all the APIs in the Batch should not exceed the task time out."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long StartDelay {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If this flag is set, it marks the end of the terminal session where the previous commands were executed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool TerminalEnd {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If this flag is set, the execution of this command initiates a terminal session in which the subsequent\nCLI commands are executed until a command with terminalEnd flag is encountered or the end of the batch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool TerminalStart {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The duration in seconds by which the API response is expected from the API target.\nIf the end point does not respond for the API request within this timeout\nduration, the task will be marked as failed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Timeout {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of the command - can be interactive or non-interactive.\n* `NonInteractive` - The CLI command is not an interactive command.\n* `Interactive` - The CLI command is executed in interactive mode and the command must provide the expects andanswers."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowCliCommand.TypeEnum Type {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowCustomDataTypeProperties.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowCustomDataTypeProperties")]
    public class InitializeIntersightWorkflowCustomDataTypeProperties:PSCmdlet
	{
		public InitializeIntersightWorkflowCustomDataTypeProperties()
		{
            ClassId = WorkflowCustomDataTypeProperties.ClassIdEnum.WorkflowCustomDataTypeProperties;
            ObjectType = WorkflowCustomDataTypeProperties.ObjectTypeEnum.WorkflowCustomDataTypeProperties;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowCustomDataTypeProperties.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowCustomDataTypeProperties.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowLoopTask.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowLoopTask")]
    public class InitializeIntersightWorkflowLoopTask:PSCmdlet
	{
		public InitializeIntersightWorkflowLoopTask()
		{
            ClassId = WorkflowLoopTask.ClassIdEnum.WorkflowLoopTask;
            ObjectType = WorkflowLoopTask.ObjectTypeEnum.WorkflowLoopTask;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowLoopTask.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Count value for the loop, this can be a constant or an expression which will evaluate to an integer value. Example, Use the length of the input A which is an array. Count must be less than or equal to 500."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Count {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The description of this task instance in the workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user defined label identifier of the workflow task used for UI display."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Start task where the list of tasks will be executed multiple times based on the count value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string LoopStartTask {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the task within the workflow and it must be unique among all WorkflowTasks within a workflow definition. This name serves as the internal unique identifier for the task and is used to pick input and output parameters to feed into other tasks."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When tasks are run in parallel and the count is large, the actual number of task run in parallel can be controlled by this property. If count is 100 and numberOfBatches is 5 then 20 tasks are run in parallel 5 times. Parallel batch size must be less than the count. In cases where count is dynamic and depends on input given during workflow execution, if that count is less than batch then empty batches might get created which do not have any tasks under them."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NumberOfBatches {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowLoopTask.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This specifies the name of the next task to run if all iterations of the loop task succeeds. The unique name given to the task instance within the workflow must be provided here. In a graph model, denotes an edge to another Task Node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string OnSuccess {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When set to true the loop will run in parallel else it will run in a serial fashion. Only one task is supported inside the loop task when the loop is run in parallel. Subworkflow can be used inside the single loop task to build complex conditions."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Parallel {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowDecisionTask.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowDecisionTask")]
    public class InitializeIntersightWorkflowDecisionTask:PSCmdlet
	{
		public InitializeIntersightWorkflowDecisionTask()
		{
            ClassId = WorkflowDecisionTask.ClassIdEnum.WorkflowDecisionTask;
            ObjectType = WorkflowDecisionTask.ObjectTypeEnum.WorkflowDecisionTask;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowDecisionTask.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The condition to evaluate for this decision task. The condition can be a workflow or task variable or an JavaScript expression. Example value for condition could be a variable like \"${task1.output.var1} or ${workflow.input.var2}\" which evaluates to a value matching any of the decision case values. Example value for condition if it's an expression - \"if ( ${task1.output.var1} ! = null && ${task1.output.var1} > 0 ) 'true'; else 'false'; \" which evaluates to 'true' or 'false' and will match one of the decision case values. You can also use JavaScript functions like indexOf, toUpperCase in the expression which will be evaluated by the expression evaluator."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Condition {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.WorkflowDecisionCase> DecisionCases {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The default next Task to execute if the decision cannot be evaluated to any of the DecisionCases."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DefaultTask {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The description of this task instance in the workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This field is deprecated. Decision case conditions can be added using the workflow input or task output variables in the Condition field. Refer to Condition field for more details."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object InputParameters {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user defined label identifier of the workflow task used for UI display."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the task within the workflow and it must be unique among all WorkflowTasks within a workflow definition. This name serves as the internal unique identifier for the task and is used to pick input and output parameters to feed into other tasks."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowDecisionTask.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowApi.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowApi")]
    public class InitializeIntersightWorkflowApi:PSCmdlet
	{
		public InitializeIntersightWorkflowApi()
		{
            
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
        /// <para type="description">"The optional request body that is sent as part of this API request.\nThe request body can contain a golang template that can be populated with task input\nparameters and previous API output parameters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Body {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.WorkflowApi.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Intersight Orchestrator, with the support of response parser specification,\ncan extract the values from API responses and map them to task output parameters.\nThe value extraction is supported for response content types XML, JSON and Text.\nThe type of the content that gets passed as payload and response in this\nAPI. The supported values are json, xml, text."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ContentType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A description that task designer can add to individual API requests that explain \nwhat the API call is about."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Intersight Orchestrator, with the support of response parser specification,\ncan extract the values from API responses and map them to task output parameters.\nThe value extraction is supported for response content types XML, JSON and Text.\nOptional input to specify the content type in case of error API response. This\nshould be used if the content type of error response is different from that of\nthe success response. If not specified, contentType input value is used to parse\nthe error response."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ErrorContentType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user friendly label that task designers have given to the batch API request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference name for this API request within the batch API request.\nThis name shall be used to map the API output parameters to subsequent\nAPI input parameters within a batch API task."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.WorkflowApi.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"All the possible outcomes of this API are captured here. Outcomes property\nis a collection property of type workflow.Outcome objects.\nThe outcomes can be mapped to the message to be shown. The outcomes are\nevaluated in the order they are given. At the end of the outcomes list,\nan catchall success/fail outcome can be added with condition as 'true'.\nThis is an optional\nproperty and if not specified the task will be marked as success."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object Outcomes {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The optional grammar specification for parsing the response to extract the\nrequired values.\nThe specification should have extraction specification specified for\nall the API output parameters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object ResponseSpec {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The skip expression, if provided, allows the batch API executor to skip the\napi execution when the given expression evaluates to true.\nThe expression is given as such a golang template that has to be\nevaluated to a final content true/false. The expression is an optional and in\ncase not provided, the API will always be executed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SkipOnCondition {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The delay in seconds after which the API needs to be executed.\nBy default, the given API is executed immediately. Specifying a start delay adds to the delay to execution.\nStart Delay is not supported for the first API in the Batch and cumulative delay of all the APIs in the Batch should not exceed the task time out."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long StartDelay {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The duration in seconds by which the API response is expected from the API target.\nIf the end point does not respond for the API request within this timeout\nduration, the task will be marked as failed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Timeout {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowXmlApi.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowXmlApi")]
    public class InitializeIntersightWorkflowXmlApi:PSCmdlet
	{
		public InitializeIntersightWorkflowXmlApi()
		{
            
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
        /// <para type="description">"The optional request body that is sent as part of this API request.\nThe request body can contain a golang template that can be populated with task input\nparameters and previous API output parameters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Body {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowXmlApi.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Intersight Orchestrator, with the support of response parser specification,\ncan extract the values from API responses and map them to task output parameters.\nThe value extraction is supported for response content types XML, JSON and Text.\nThe type of the content that gets passed as payload and response in this\nAPI. The supported values are json, xml, text."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ContentType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A description that task designer can add to individual API requests that explain \nwhat the API call is about."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Intersight Orchestrator, with the support of response parser specification,\ncan extract the values from API responses and map them to task output parameters.\nThe value extraction is supported for response content types XML, JSON and Text.\nOptional input to specify the content type in case of error API response. This\nshould be used if the content type of error response is different from that of\nthe success response. If not specified, contentType input value is used to parse\nthe error response."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ErrorContentType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user friendly label that task designers have given to the batch API request."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference name for this API request within the batch API request.\nThis name shall be used to map the API output parameters to subsequent\nAPI input parameters within a batch API task."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowXmlApi.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"All the possible outcomes of this API are captured here. Outcomes property\nis a collection property of type workflow.Outcome objects.\nThe outcomes can be mapped to the message to be shown. The outcomes are\nevaluated in the order they are given. At the end of the outcomes list,\nan catchall success/fail outcome can be added with condition as 'true'.\nThis is an optional\nproperty and if not specified the task will be marked as success."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object Outcomes {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The optional grammar specification for parsing the response to extract the\nrequired values.\nThe specification should have extraction specification specified for\nall the API output parameters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object ResponseSpec {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The skip expression, if provided, allows the batch API executor to skip the\napi execution when the given expression evaluates to true.\nThe expression is given as such a golang template that has to be\nevaluated to a final content true/false. The expression is an optional and in\ncase not provided, the API will always be executed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SkipOnCondition {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The delay in seconds after which the API needs to be executed.\nBy default, the given API is executed immediately. Specifying a start delay adds to the delay to execution.\nStart Delay is not supported for the first API in the Batch and cumulative delay of all the APIs in the Batch should not exceed the task time out."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long StartDelay {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The duration in seconds by which the API response is expected from the API target.\nIf the end point does not respond for the API request within this timeout\nduration, the task will be marked as failed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Timeout {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowTaskConstraints.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowTaskConstraints")]
    public class InitializeIntersightWorkflowTaskConstraints:PSCmdlet
	{
		public InitializeIntersightWorkflowTaskConstraints()
		{
            ClassId = WorkflowTaskConstraints.ClassIdEnum.WorkflowTaskConstraints;
            ObjectType = WorkflowTaskConstraints.ObjectTypeEnum.WorkflowTaskConstraints;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowTaskConstraints.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowTaskConstraints.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"List of property constraints that helps to narrow down task implementations based on target device input."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object TargetDataType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowCustomArrayItem.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowCustomArrayItem")]
    public class InitializeIntersightWorkflowCustomArrayItem:PSCmdlet
	{
		public InitializeIntersightWorkflowCustomArrayItem()
		{
            ClassId = WorkflowCustomArrayItem.ClassIdEnum.WorkflowCustomArrayItem;
            ObjectType = WorkflowCustomArrayItem.ObjectTypeEnum.WorkflowCustomArrayItem;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowCustomArrayItem.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowCustomArrayItem.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Captures an array item which is of custom data type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.WorkflowCustomDataProperty Properties {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowArrayItem.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowArrayItem")]
    public class InitializeIntersightWorkflowArrayItem:PSCmdlet
	{
		public InitializeIntersightWorkflowArrayItem()
		{
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowArrayItem.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowArrayItem.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowWorkerTask.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowWorkerTask")]
    public class InitializeIntersightWorkflowWorkerTask:PSCmdlet
	{
		public InitializeIntersightWorkflowWorkerTask()
		{
            ClassId = WorkflowWorkerTask.ClassIdEnum.WorkflowWorkerTask;
            ObjectType = WorkflowWorkerTask.ObjectTypeEnum.WorkflowWorkerTask;
            
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
        /// <para type="description">"Specify the catalog moid that this task belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string CatalogMoid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowWorkerTask.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The description of this task instance in the workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"JSON formatted map that defines the input given to the task. JSONPath is used for chaining output from previous tasks as inputs into the current task. The format to specify the mapping is '${Source.input/output.JsonPath}'. 'Source' can be either workflow or the name of the task within the workflow. You can map the task input to either a workflow input or a task output. Following this is JSON path expression to extract JSON fragment from source's input/output."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object InputParameters {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user defined label identifier of the workflow task used for UI display."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the task within the workflow and it must be unique among all WorkflowTasks within a workflow definition. This name serves as the internal unique identifier for the task and is used to pick input and output parameters to feed into other tasks."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowWorkerTask.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This specifies the name of the next task to run if Task fails.  This is the unique name given to the task instance within the workflow. In a graph model, denotes an edge to another Task Node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string OnFailure {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This specifies the name of the next task to run if Task succeeds.  This is the unique name given to the task instance within the workflow. In a graph model, denotes an edge to another Task Node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string OnSuccess {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The task is disabled/enabled for rollback operation in this workflow if the task has rollback support."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool RollbackDisabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The qualified name of task that should be executed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string TaskDefinitionName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"UseDefault when set to true, means the default version of the task or workflow will be used at the time of execution. When this property is set then version for task or subworkflow cannot be set. When workflow is created or updated the default version of task or subworkflow will be used for validation, but when the workflow is executed the default version that that time will be used for validation and subsequent execution."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool UseDefault {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The task definition version to use in this workflow. When no version is specified then the default version of the task at the time of creating or updating this workflow is used."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Version {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
            if (this.MyInvocation.BoundParameters.ContainsKey("UseDefault"))
            {
                initObject.UseDefault = this.UseDefault;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowParameterSet.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowParameterSet")]
    public class InitializeIntersightWorkflowParameterSet:PSCmdlet
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowParameterSet.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The condition to be evaluated.\n* `eq` - Checks if the values of the two parameters are equal.\n* `ne` - Checks if the values of the two parameters are not equal.\n* `contains` - Checks if the second parameter string value is a substring of the first parameter string value.\n* `matchesPattern` - Checks if a string matches a regular expression."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowParameterSet.ConditionEnum Condition {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the controlling entity, whose value will be used for evaluating the parameter set."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ControlParameter {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> EnableParameters {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name for the parameter set.  Limited to 64 alphanumeric characters (upper and lower case), and special characters '-' and '_'."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowParameterSet.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The controlling parameter will be evaluated against this 'value'."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Value {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowBaseDataType.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowBaseDataType")]
    public class InitializeIntersightWorkflowBaseDataType:PSCmdlet
	{
		public InitializeIntersightWorkflowBaseDataType()
		{
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowBaseDataType.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Default value for the data type. If default value was provided and the input was required the default value will be used as the input."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.WorkflowDefaultValue Default {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Provide a detailed description of the data type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Captures the meta data needed for displaying workflow data types in Intersight User Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.WorkflowDisplayMeta DisplayMeta {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"JSON formatted mapping from other property of the definition to the current property. Input parameter mapping is supported only for custom data type property in workflow definition and custom data type definition. The format to specify mapping ina workflow definition when source property is of scalar types is '${workflow.input.property}'. The format to specify mapping when the source property is of object reference and mapping needs to be made to the property of the object is '${workflow.input.property.subproperty}'. The format to specify mapping in a custom data type definition is '${datatype.type.property}'. When the current property is of non-scalar type like composite custom data type, then mapping can be provided to the individual property of the custom data type like 'cdt_property:${workflow.input.property}'."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object InputParameters {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Descriptive label for the data type. Label can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), space ( ) or an underscore (_). The first and last character in label must be an alphanumeric character."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+[\\sa-zA-Z0-9_'.:-]{1,92}$")]
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Descriptive name for the data type. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-) or an underscore (_). The first and last character in name must be an alphanumeric character."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+([a-zA-Z0-9-_]*[a-zA-Z0-9])*$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowBaseDataType.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specifies whether this parameter is required. The field is applicable for task and workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Required {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowWaitTask.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowWaitTask")]
    public class InitializeIntersightWorkflowWaitTask:PSCmdlet
	{
		public InitializeIntersightWorkflowWaitTask()
		{
            ClassId = WorkflowWaitTask.ClassIdEnum.WorkflowWaitTask;
            ObjectType = WorkflowWaitTask.ObjectTypeEnum.WorkflowWaitTask;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowWaitTask.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The description of this task instance in the workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"JSON formatted map that defines the input given to the task. JSONPath is used for chaining output from previous tasks as inputs into the current task. The format to specify the mapping is '${Source.input/output.JsonPath}'. 'Source' can be either workflow or the name of the task within the workflow. You can map the task input to either a workflow input or a task output. Following this is JSON path expression to extract JSON fragment from source's input/output."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object InputParameters {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user defined label identifier of the workflow task used for UI display."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the task within the workflow and it must be unique among all WorkflowTasks within a workflow definition. This name serves as the internal unique identifier for the task and is used to pick input and output parameters to feed into other tasks."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowWaitTask.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This specifies the name of the next task to run if Task fails.  This is the unique name given to the task instance within the workflow. In a graph model, denotes an edge to another Task Node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string OnFailure {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This specifies the name of the next task to run if Task succeeds.  This is the unique name given to the task instance within the workflow. In a graph model, denotes an edge to another Task Node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string OnSuccess {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.WorkflowWaitTaskPrompt> Prompts {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The task is disabled/enabled for rollback operation in this workflow if the task has rollback support."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool RollbackDisabled {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"UseDefault when set to true, means the default version of the task or workflow will be used at the time of execution. When this property is set then version for task or subworkflow cannot be set. When workflow is created or updated the default version of task or subworkflow will be used for validation, but when the workflow is executed the default version that that time will be used for validation and subsequent execution."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool UseDefault {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
            if (this.MyInvocation.BoundParameters.ContainsKey("UseDefault"))
            {
                initObject.UseDefault = this.UseDefault;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowResultHandler.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowResultHandler")]
    public class InitializeIntersightWorkflowResultHandler:PSCmdlet
	{
		public InitializeIntersightWorkflowResultHandler()
		{
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowResultHandler.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowResultHandler.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowSshCmd.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowSshCmd")]
    public class InitializeIntersightWorkflowSshCmd:PSCmdlet
	{
		public InitializeIntersightWorkflowSshCmd()
		{
            ClassId = WorkflowSshCmd.ClassIdEnum.WorkflowSshCmd;
            CommandType = WorkflowSshCmd.CommandTypeEnum.NonInteractiveCmd;
            ObjectType = WorkflowSshCmd.ObjectTypeEnum.WorkflowSshCmd;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowSshCmd.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SSH command to execute on the remote server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Command {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SSH command type to execute on the remote server.\n* `NonInteractiveCmd` - Execute a non-interactive SSH command on the remote server.\n* `InteractiveCmd` - Execute an interactive SSH command on the remote server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowSshCmd.CommandTypeEnum CommandType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The secure properties that have large text content as value can be encrypted using AES key. In these cases, the AES key needs to be encrypted using the device connector public key and passed as the value for this property.\nThe secure properties that are encrypted using the AES key are mapped against the property name with prefix 'AES' in SecureProperties dictionary."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string EncryptedAesKey {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The public key that was used to encrypt the values present in SecureProperties dictionary.\nIf the given public key is not same as device connector's public key, an error reponse with appropriate error message is thrown back."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string EncryptionKey {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.ConnectorExpectPrompt> ExpectPrompts {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowSshCmd.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A dictionary of encrypted secure values mapped against the secure property name. The values that are encrypted using AES key must be mapped against the secure property name with a 'AES' prefix\nDevice connector expects the message body to be a golang template and the template can use the secure property names as placeholders."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object SecureProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Regex of the remote server's shell prompt."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ShellPrompt {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Expect timeout value in seconds for the shell prompt."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long ShellPromptTimeout {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowInitiatorContext.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowInitiatorContext")]
    public class InitializeIntersightWorkflowInitiatorContext:PSCmdlet
	{
		public InitializeIntersightWorkflowInitiatorContext()
		{
            ClassId = WorkflowInitiatorContext.ClassIdEnum.WorkflowInitiatorContext;
            ObjectType = WorkflowInitiatorContext.ObjectTypeEnum.WorkflowInitiatorContext;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowInitiatorContext.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The moid of the Intersight managed object that initiated the workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string InitiatorMoid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the initiator who started the workflow. The initiator can be Intersight managed object that triggered the workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string InitiatorName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of Intersight managed object that initiated the workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string InitiatorType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowInitiatorContext.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowProperties.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowProperties")]
    public class InitializeIntersightWorkflowProperties:PSCmdlet
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Dictionary<string,object> AdditionalProperties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowProperties.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"When set to false the task definition can only be used by internal system workflows. When set to true then the task can be included in user defined workflows."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool ExternalMeta {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.WorkflowBaseDataType> InputDefinition {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowProperties.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.WorkflowBaseDataType> OutputDefinition {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of times a task should be tried before marking as failed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long RetryCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The delay in seconds after which the the task is re-tried."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(10, 86400)]
        public long RetryDelay {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The retry policy for the task.\n* `Fixed` - The enum specifies the option as Fixed where the task retry happens after fixed time specified by RetryDelay."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowProperties.RetryPolicyEnum RetryPolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Supported status of the definition.\n* `Supported` - The definition is a supported version and there will be no changes to the mandatory inputs or outputs.\n* `Beta` - The definition is a Beta version and this version can under go changes until the version is marked supported.\n* `Deprecated` - The version of definition is deprecated and typically there will be a higher version of the same definition that has been added."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowProperties.SupportStatusEnum SupportStatus {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The timeout value in seconds after which task will be marked as timed out. Max allowed value is 7 days."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(10, 604800)]
        public long Timeout {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The timeout policy for the task.\n* `Timeout` - The enum specifies the option as Timeout where task will be timed out after the specified time in Timeout property.\n* `Retry` - The enum specifies the option as Retry where task will be re-tried."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowProperties.TimeoutPolicyEnum TimeoutPolicy {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.WorkflowProperties initObject = new Intersight.Model.WorkflowProperties();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ExternalMeta"))
            {
                initObject.ExternalMeta = this.ExternalMeta;
            }
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowWorkflowTask.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowWorkflowTask")]
    public class InitializeIntersightWorkflowWorkflowTask:PSCmdlet
	{
		public InitializeIntersightWorkflowWorkflowTask()
		{
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowWorkflowTask.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The description of this task instance in the workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user defined label identifier of the workflow task used for UI display."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the task within the workflow and it must be unique among all WorkflowTasks within a workflow definition. This name serves as the internal unique identifier for the task and is used to pick input and output parameters to feed into other tasks."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowWorkflowTask.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowTargetContext.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowTargetContext")]
    public class InitializeIntersightWorkflowTargetContext:PSCmdlet
	{
		public InitializeIntersightWorkflowTargetContext()
		{
            ClassId = WorkflowTargetContext.ClassIdEnum.WorkflowTargetContext;
            ObjectType = WorkflowTargetContext.ObjectTypeEnum.WorkflowTargetContext;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowTargetContext.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowTargetContext.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Moid of the target Intersight managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string TargetMoid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the target instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string TargetName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Object type of the target Intersight managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string TargetType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.WorkflowTargetContext initObject = new Intersight.Model.WorkflowTargetContext();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("TargetMoid"))
            {
                initObject.TargetMoid = this.TargetMoid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TargetName"))
            {
                initObject.TargetName = this.TargetName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TargetType"))
            {
                initObject.TargetType = this.TargetType;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowMoReferenceDataType.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowMoReferenceDataType")]
    public class InitializeIntersightWorkflowMoReferenceDataType:PSCmdlet
	{
		public InitializeIntersightWorkflowMoReferenceDataType()
		{
            ClassId = WorkflowMoReferenceDataType.ClassIdEnum.WorkflowMoReferenceDataType;
            ObjectType = WorkflowMoReferenceDataType.ObjectTypeEnum.WorkflowMoReferenceDataType;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowMoReferenceDataType.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Default value for the data type. If default value was provided and the input was required the default value will be used as the input."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.WorkflowDefaultValue Default {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Provide a detailed description of the data type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Captures the meta data needed for displaying workflow data types in Intersight User Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.WorkflowDisplayMeta DisplayMeta {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"JSON formatted mapping from other property of the definition to the current property. Input parameter mapping is supported only for custom data type property in workflow definition and custom data type definition. The format to specify mapping ina workflow definition when source property is of scalar types is '${workflow.input.property}'. The format to specify mapping when the source property is of object reference and mapping needs to be made to the property of the object is '${workflow.input.property.subproperty}'. The format to specify mapping in a custom data type definition is '${datatype.type.property}'. When the current property is of non-scalar type like composite custom data type, then mapping can be provided to the individual property of the custom data type like 'cdt_property:${workflow.input.property}'."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object InputParameters {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Descriptive label for the data type. Label can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), space ( ) or an underscore (_). The first and last character in label must be an alphanumeric character."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+[\\sa-zA-Z0-9_'.:-]{1,92}$")]
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Descriptive name for the data type. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-) or an underscore (_). The first and last character in name must be an alphanumeric character."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+([a-zA-Z0-9-_]*[a-zA-Z0-9])*$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowMoReferenceDataType.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.WorkflowMoReferenceProperty> Properties {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specifies whether this parameter is required. The field is applicable for task and workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Required {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowStartTask.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowStartTask")]
    public class InitializeIntersightWorkflowStartTask:PSCmdlet
	{
		public InitializeIntersightWorkflowStartTask()
		{
            ClassId = WorkflowStartTask.ClassIdEnum.WorkflowStartTask;
            ObjectType = WorkflowStartTask.ObjectTypeEnum.WorkflowStartTask;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowStartTask.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The description of this task instance in the workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A user defined label identifier of the workflow task used for UI display."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the task within the workflow and it must be unique among all WorkflowTasks within a workflow definition. This name serves as the internal unique identifier for the task and is used to pick input and output parameters to feed into other tasks."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The name of the next task (Task names unique within workflow) to run.  In a graph model, denotes an edge to another Task Node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string NextTask {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowStartTask.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowArrayDataType.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowArrayDataType")]
    public class InitializeIntersightWorkflowArrayDataType:PSCmdlet
	{
		public InitializeIntersightWorkflowArrayDataType()
		{
            ClassId = WorkflowArrayDataType.ClassIdEnum.WorkflowArrayDataType;
            ObjectType = WorkflowArrayDataType.ObjectTypeEnum.WorkflowArrayDataType;
            
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
        /// <para type="description">"Data item within the array data type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.WorkflowArrayItem ArrayItemType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowArrayDataType.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Default value for the data type. If default value was provided and the input was required the default value will be used as the input."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.WorkflowDefaultValue Default {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Provide a detailed description of the data type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Captures the meta data needed for displaying workflow data types in Intersight User Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.WorkflowDisplayMeta DisplayMeta {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"JSON formatted mapping from other property of the definition to the current property. Input parameter mapping is supported only for custom data type property in workflow definition and custom data type definition. The format to specify mapping ina workflow definition when source property is of scalar types is '${workflow.input.property}'. The format to specify mapping when the source property is of object reference and mapping needs to be made to the property of the object is '${workflow.input.property.subproperty}'. The format to specify mapping in a custom data type definition is '${datatype.type.property}'. When the current property is of non-scalar type like composite custom data type, then mapping can be provided to the individual property of the custom data type like 'cdt_property:${workflow.input.property}'."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object InputParameters {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Descriptive label for the data type. Label can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), space ( ) or an underscore (_). The first and last character in label must be an alphanumeric character."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+[\\sa-zA-Z0-9_'.:-]{1,92}$")]
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specify the maximum value of the array."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Max {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specify the minimum value of the array."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Min {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Descriptive name for the data type. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-) or an underscore (_). The first and last character in name must be an alphanumeric character."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+([a-zA-Z0-9-_]*[a-zA-Z0-9])*$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowArrayDataType.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specifies whether this parameter is required. The field is applicable for task and workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Required {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowRollbackTask.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowRollbackTask")]
    public class InitializeIntersightWorkflowRollbackTask:PSCmdlet
	{
		public InitializeIntersightWorkflowRollbackTask()
		{
            ClassId = WorkflowRollbackTask.ClassIdEnum.WorkflowRollbackTask;
            ObjectType = WorkflowRollbackTask.ObjectTypeEnum.WorkflowRollbackTask;
            
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
        /// <para type="description">"The catalog under which the task definition has been added."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string CatalogMoid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowRollbackTask.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of rollback task definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Input parameters mapping for rollback task from the input or output of the main task definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object InputParameters {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the task definition which is capable of doing rollback of this task."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowRollbackTask.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The resolved referenced rollback task definition managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string TaskMoid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The version of the task definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Version {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
                initObject._Version = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize WorkflowRollbackWorkflowTask.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightWorkflowRollbackWorkflowTask")]
    public class InitializeIntersightWorkflowRollbackWorkflowTask:PSCmdlet
	{
		public InitializeIntersightWorkflowRollbackWorkflowTask()
		{
            ClassId = WorkflowRollbackWorkflowTask.ClassIdEnum.WorkflowRollbackWorkflowTask;
            ObjectType = WorkflowRollbackWorkflowTask.ObjectTypeEnum.WorkflowRollbackWorkflowTask;
            
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowRollbackWorkflowTask.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of TaskInfo that needs to be rolled back."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public WorkflowRollbackWorkflowTask.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Reference name of TaskInfo that need to be rolled back."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RefName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Moid of TaskInfo that supports rollback operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string TaskInfoMoid {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
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
}