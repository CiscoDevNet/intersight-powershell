using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize TerraformCloudResource.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightTerraformCloudResource")]
    public class InitializeIntersightTerraformCloudResource:PSCmdlet
	{
		public InitializeIntersightTerraformCloudResource()
		{
            ClassId = TerraformCloudResource.ClassIdEnum.TerraformCloudResource;
            ObjectType = TerraformCloudResource.ObjectTypeEnum.TerraformCloudResource;
            
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
        
        public TerraformCloudResource.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Currentstatus of the resource if applicable on the cloud."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string CurrentStatus {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Desiredstatus of the resource if applicable on the cloud."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DesiredStatus {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public TerraformCloudResource.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Unique id of the resource from the cloud provider."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ResourceId {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.TerraformCloudResource initObject = new Intersight.Model.TerraformCloudResource();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CurrentStatus"))
            {
                initObject.CurrentStatus = this.CurrentStatus;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DesiredStatus"))
            {
                initObject.DesiredStatus = this.DesiredStatus;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ResourceId"))
            {
                initObject.ResourceId = this.ResourceId;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize TerraformExecutor.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightTerraformExecutor")]
    public class InitializeIntersightTerraformExecutor:PSCmdlet
	{
		public InitializeIntersightTerraformExecutor()
		{
            ClassId = TerraformExecutor.ClassIdEnum.TerraformExecutor;
            ObjectType = TerraformExecutor.ObjectTypeEnum.TerraformExecutor;
            Operation = TerraformExecutor.OperationEnum.Create;
            
		}
        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.IamAccountRelationship Account {
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
        
        public TerraformExecutor.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.TerraformCloudResource> CloudResource {
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public TerraformExecutor.ObjectTypeEnum ObjectType {
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
        
        public Model.AssetDeviceRegistrationRelationship RegisteredDevice {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.TerraformRunstate> RunState {
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
        
        public List<Model.MoTag> Tags {
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

        protected override void ProcessRecord()
        {
             Intersight.Model.TerraformExecutor initObject = new Intersight.Model.TerraformExecutor();
            if (this.MyInvocation.BoundParameters.ContainsKey("Account"))
            {
                initObject.Account = this.Account;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CloudResource"))
            {
                initObject.CloudResource = this.CloudResource;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Command"))
            {
                initObject.Command = this.Command;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Operation"))
            {
                initObject.Operation = this.Operation;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Output"))
            {
                initObject.Output = this.Output;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PlatformType"))
            {
                initObject.PlatformType = this.PlatformType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RegisteredDevice"))
            {
                initObject.RegisteredDevice = this.RegisteredDevice;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RunState"))
            {
                initObject.RunState = this.RunState;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SourceFolderName"))
            {
                initObject.SourceFolderName = this.SourceFolderName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SourceFolderPath"))
            {
                initObject.SourceFolderPath = this.SourceFolderPath;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SourceLocation"))
            {
                initObject.SourceLocation = this.SourceLocation;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Status"))
            {
                initObject.Status = this.Status;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Stderr"))
            {
                initObject.Stderr = this.Stderr;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Stdout"))
            {
                initObject.Stdout = this.Stdout;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TaskId"))
            {
                initObject.TaskId = this.TaskId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Variables"))
            {
                initObject.Variables = this.Variables;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize TerraformRunstate.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightTerraformRunstate")]
    public class InitializeIntersightTerraformRunstate:PSCmdlet
	{
		public InitializeIntersightTerraformRunstate()
		{
            ClassId = TerraformRunstate.ClassIdEnum.TerraformRunstate;
            ObjectType = TerraformRunstate.ObjectTypeEnum.TerraformRunstate;
            
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
        
        public TerraformRunstate.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public TerraformRunstate.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Run identifier for every terraform execution."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RunId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"StateFile identifier of terraform execution."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string StateFile {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.TerraformRunstate initObject = new Intersight.Model.TerraformRunstate();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RunId"))
            {
                initObject.RunId = this.RunId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StateFile"))
            {
                initObject.StateFile = this.StateFile;
            }
            WriteObject(initObject);
        }

    }
}