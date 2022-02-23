using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize TechsupportmanagementNiaParam.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightTechsupportmanagementNiaParam")]
    public class InitializeIntersightTechsupportmanagementNiaParam:PSCmdlet
	{
		public InitializeIntersightTechsupportmanagementNiaParam()
		{
            ClassId = TechsupportmanagementNiaParam.ClassIdEnum.TechsupportmanagementNiaParam;
            CollectionLevel = TechsupportmanagementNiaParam.CollectionLevelEnum.NUMBER_1;
            ObjectType = TechsupportmanagementNiaParam.ObjectTypeEnum.TechsupportmanagementNiaParam;
            
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
        
        public TechsupportmanagementNiaParam.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"CollectionLevel controls the size / depth of the tech support files collected.\n* `1` - Use cached data in the returned collection.\n* `2` - Use current data in the returned collection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public TechsupportmanagementNiaParam.CollectionLevelEnum CollectionLevel {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Filename specifies an individual filename to collect from the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Filename {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"ForceFresh controls whether to return pre-collected files or force the collection of new files."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool ForceFresh {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public TechsupportmanagementNiaParam.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> Pids {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> SerialNumbers {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.TechsupportmanagementNiaParam initObject = new Intersight.Model.TechsupportmanagementNiaParam();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CollectionLevel"))
            {
                initObject.CollectionLevel = this.CollectionLevel;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Filename"))
            {
                initObject.Filename = this.Filename;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ForceFresh"))
            {
                initObject.ForceFresh = this.ForceFresh;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Pids"))
            {
                initObject.Pids = this.Pids;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SerialNumbers"))
            {
                initObject.SerialNumbers = this.SerialNumbers;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize TechsupportmanagementPlatformParam.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightTechsupportmanagementPlatformParam")]
    public class InitializeIntersightTechsupportmanagementPlatformParam:PSCmdlet
	{
		public InitializeIntersightTechsupportmanagementPlatformParam()
		{
            ClassId = TechsupportmanagementPlatformParam.ClassIdEnum.TechsupportmanagementPlatformParam;
            CollectionType = TechsupportmanagementPlatformParam.CollectionTypeEnum.NUMBER_1;
            ObjectType = TechsupportmanagementPlatformParam.ObjectTypeEnum.TechsupportmanagementPlatformParam;
            
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
        
        public TechsupportmanagementPlatformParam.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"CollectionType specifies if basic or detailed techsupport needs to be collected.\n* `1` - Collect basic techsupport.\n* `2` - Collect detailed techsupport."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public TechsupportmanagementPlatformParam.CollectionTypeEnum CollectionType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Controls whether to include core file in the techsupport bundle."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool IncludeCore {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public TechsupportmanagementPlatformParam.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.TechsupportmanagementPlatformParam initObject = new Intersight.Model.TechsupportmanagementPlatformParam();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("CollectionType"))
            {
                initObject.CollectionType = this.CollectionType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IncludeCore"))
            {
                initObject.IncludeCore = this.IncludeCore;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize TechsupportmanagementApplianceParam.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightTechsupportmanagementApplianceParam")]
    public class InitializeIntersightTechsupportmanagementApplianceParam:PSCmdlet
	{
		public InitializeIntersightTechsupportmanagementApplianceParam()
		{
            ClassId = TechsupportmanagementApplianceParam.ClassIdEnum.TechsupportmanagementApplianceParam;
            ObjectType = TechsupportmanagementApplianceParam.ObjectTypeEnum.TechsupportmanagementApplianceParam;
            
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
        
        public TechsupportmanagementApplianceParam.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Specifies whether the techsupport request is from the cloud or by the appliance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool IsApplianceRequest {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public TechsupportmanagementApplianceParam.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.TechsupportmanagementApplianceParam initObject = new Intersight.Model.TechsupportmanagementApplianceParam();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("IsApplianceRequest"))
            {
                initObject.IsApplianceRequest = this.IsApplianceRequest;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
}