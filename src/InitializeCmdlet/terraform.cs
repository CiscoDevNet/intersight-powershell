using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
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
}