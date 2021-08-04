using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ResourcePerTypeCombinedSelector.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightResourcePerTypeCombinedSelector")]
    public class InitializeIntersightResourcePerTypeCombinedSelector:PSCmdlet
	{
		public InitializeIntersightResourcePerTypeCombinedSelector()
		{
            ClassId = ResourcePerTypeCombinedSelector.ClassIdEnum.ResourcePerTypeCombinedSelector;
            ObjectType = ResourcePerTypeCombinedSelector.ObjectTypeEnum.ResourcePerTypeCombinedSelector;
            
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
        
        public ResourcePerTypeCombinedSelector.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ResourcePerTypeCombinedSelector.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.ResourcePerTypeCombinedSelector initObject = new Intersight.Model.ResourcePerTypeCombinedSelector();
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
    /// <para type="synopsis">This is the cmdlet to Initialize ResourceSourceToPermissionResourcesHolder.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightResourceSourceToPermissionResourcesHolder")]
    public class InitializeIntersightResourceSourceToPermissionResourcesHolder:PSCmdlet
	{
		public InitializeIntersightResourceSourceToPermissionResourcesHolder()
		{
            ClassId = ResourceSourceToPermissionResourcesHolder.ClassIdEnum.ResourceSourceToPermissionResourcesHolder;
            ObjectType = ResourceSourceToPermissionResourcesHolder.ObjectTypeEnum.ResourceSourceToPermissionResourcesHolder;
            
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
        
        public ResourceSourceToPermissionResourcesHolder.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ResourceSourceToPermissionResourcesHolder.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<Model.ResourceSourceToPermissionResources> SourceToPermissionResources {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.ResourceSourceToPermissionResourcesHolder initObject = new Intersight.Model.ResourceSourceToPermissionResourcesHolder();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SourceToPermissionResources"))
            {
                initObject.SourceToPermissionResources = this.SourceToPermissionResources;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize ResourceSourceToPermissionResources.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightResourceSourceToPermissionResources")]
    public class InitializeIntersightResourceSourceToPermissionResources:PSCmdlet
	{
		public InitializeIntersightResourceSourceToPermissionResources()
		{
            ClassId = ResourceSourceToPermissionResources.ClassIdEnum.ResourceSourceToPermissionResources;
            ObjectType = ResourceSourceToPermissionResources.ObjectTypeEnum.ResourceSourceToPermissionResources;
            
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
        
        public ResourceSourceToPermissionResources.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ResourceSourceToPermissionResources.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.ResourceSourceToPermissionResources initObject = new Intersight.Model.ResourceSourceToPermissionResources();
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
    /// <para type="synopsis">This is the cmdlet to Initialize ResourceSelector.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightResourceSelector")]
    public class InitializeIntersightResourceSelector:PSCmdlet
	{
		public InitializeIntersightResourceSelector()
		{
            ClassId = ResourceSelector.ClassIdEnum.ResourceSelector;
            ObjectType = ResourceSelector.ObjectTypeEnum.ResourceSelector;
            
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
        
        public ResourceSelector.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ResourceSelector.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"ODATA filter to select resources. The group selector may include URLs of individual resource, or OData query with filters that match multiple queries. The URLs must be relative (i.e. do not include the host)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|/api/v1/.*")]
        public string Selector {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.ResourceSelector initObject = new Intersight.Model.ResourceSelector();
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
}