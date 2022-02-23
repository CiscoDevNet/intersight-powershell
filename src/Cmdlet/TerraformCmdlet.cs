using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set TerraformExecutor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightTerraformExecutor")]
    public class SetIntersightTerraformExecutor:SetCmdletBase
	{
		public SetIntersightTerraformExecutor()
		{
			ApiInstance = new TerraformApi(Config);
            ModelObject = new TerraformExecutor();
            MethodName = "UpdateTerraformExecutorWithHttpInfo";
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
        
        public List<TerraformCloudResource> CloudResource {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"Command to be executed during update operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Command {
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
        /// <para type="description">"Enum indicates what operation is being done.\n* `Create` - Creating a Terraform resource.\n* `Update` - Updating a Terraform resource.\n* `Delete` - Deleting a Terraform resource."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public TerraformExecutor.OperationEnum Operation {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"Terraform output of the entire execution."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object Output {
            get;
            set;
        }
        
        
        
        
        // <summary>
        /// <para type="description">"The Platform type used in conjunction with 'sourceFolderPath' and 'sourceFolderName' determines unique path for a Terraform workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PlatformType {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceRegistrationRelationship RegisteredDevice {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<TerraformRunstate> RunState {
            get;
            set;
        }
        
        
        // <summary>
        /// <para type="description">"Folder Name where Terraform workflows are stored."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SourceFolderName {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"Relative folder Path where 'sourceFolderName' is located."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SourceFolderPath {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"Flag indicates whether workflow is internal/external."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SourceLocation {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"Status of the terraform execution."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Status {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"Stderr of the terraform execution will be captured here."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object Stderr {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"Stdout of the terraform execution will be captured here."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object Stdout {
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
        /// <para type="description">"TaskId of a pontem workflow is same as the MO."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string TaskId {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"Variables needed by the terraform configuration as a JSON object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object Variables {
            get;
            set;
        }
        
        
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove TerraformExecutor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightTerraformExecutor")]
    public class RemoveIntersightTerraformExecutor:RemoveCmdletBase
	{
		public RemoveIntersightTerraformExecutor()
		{
			ApiInstance = new TerraformApi(Config);
            MethodName = "DeleteTerraformExecutorWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get TerraformExecutor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightTerraformExecutor", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightTerraformExecutor:GetCmdletBase
	{
		public GetIntersightTerraformExecutor()
		{
			ApiInstance = new TerraformApi(Config);
            MethodName = "GetTerraformExecutorListWithHttpInfo";
		}
        
        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = true, ParameterSetName = "CmdletParam")]
        
        public IamAccountRelationship Account {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        
        public string AccountMoid {
            get;
            set;
        }
        
        
        
        
        // <summary>
        /// <para type="description">"Command to be executed during update operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        
        public string Command {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        
        public DateTime CreateTime {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        
        public string DomainGroupMoid {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        
        public DateTime ModTime {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        
        public string Moid {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"Enum indicates what operation is being done.\n* `Create` - Creating a Terraform resource.\n* `Update` - Updating a Terraform resource.\n* `Delete` - Deleting a Terraform resource."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        
        public TerraformExecutor.OperationEnum Operation {
            get;
            set;
        }
        
        
        
        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false,ValueFromPipeline = true, ParameterSetName = "CmdletParam")]
        
        public MoBaseMoRelationship Parent {
            get;
            set;
        }
        
        
        // <summary>
        /// <para type="description">"The Platform type used in conjunction with 'sourceFolderPath' and 'sourceFolderName' determines unique path for a Terraform workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        
        public string PlatformType {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = true, ParameterSetName = "CmdletParam")]
        
        public AssetDeviceRegistrationRelationship RegisteredDevice {
            get;
            set;
        }
        
        
        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        
        public string SharedScope {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"Folder Name where Terraform workflows are stored."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        
        public string SourceFolderName {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"Relative folder Path where 'sourceFolderName' is located."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        
        public string SourceFolderPath {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"Flag indicates whether workflow is internal/external."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        
        public string SourceLocation {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"Status of the terraform execution."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        
        public string Status {
            get;
            set;
        }
        
        
        
        
        // <summary>
        /// <para type="description">"TaskId of a pontem workflow is same as the MO."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        
        public string TaskId {
            get;
            set;
        }
        
        
        
        // <summary>
        /// <para type="description">"A reference to a workflowWorkflowInfo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = true, ParameterSetName = "CmdletParam")]
        
        public WorkflowWorkflowInfoRelationship WorkflowInfo {
            get;
            set;
        }

        
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New TerraformExecutor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightTerraformExecutor")]
    public class NewIntersightTerraformExecutor:NewCmdletBase
	{
		public NewIntersightTerraformExecutor()
		{
			ApiInstance = new TerraformApi(Config);
            ModelObject = new TerraformExecutor();
            MethodName = "CreateTerraformExecutorWithHttpInfo";
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
        
        public List<TerraformCloudResource> CloudResource {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"Command to be executed during update operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Command {
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
        /// <para type="description">"Enum indicates what operation is being done.\n* `Create` - Creating a Terraform resource.\n* `Update` - Updating a Terraform resource.\n* `Delete` - Deleting a Terraform resource."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public TerraformExecutor.OperationEnum Operation {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"Terraform output of the entire execution."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object Output {
            get;
            set;
        }
        
        
        
        
        // <summary>
        /// <para type="description">"The Platform type used in conjunction with 'sourceFolderPath' and 'sourceFolderName' determines unique path for a Terraform workflow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PlatformType {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceRegistrationRelationship RegisteredDevice {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<TerraformRunstate> RunState {
            get;
            set;
        }
        
        
        // <summary>
        /// <para type="description">"Folder Name where Terraform workflows are stored."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SourceFolderName {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"Relative folder Path where 'sourceFolderName' is located."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SourceFolderPath {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"Flag indicates whether workflow is internal/external."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SourceLocation {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"Status of the terraform execution."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Status {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"Stderr of the terraform execution will be captured here."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object Stderr {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"Stdout of the terraform execution will be captured here."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object Stdout {
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
        /// <para type="description">"TaskId of a pontem workflow is same as the MO."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string TaskId {
            get;
            set;
        }
        
        // <summary>
        /// <para type="description">"Variables needed by the terraform configuration as a JSON object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public object Variables {
            get;
            set;
        }
        
        
    }
}