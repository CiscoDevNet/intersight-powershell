using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize BulkRestResult.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightBulkRestResult")]
    public class InitializeIntersightBulkRestResult:PSCmdlet
	{
		public InitializeIntersightBulkRestResult()
		{
            ClassId = BulkRestResult.ClassIdEnum.BulkRestResult;
            ObjectType = BulkRestResult.ObjectTypeEnum.BulkRestResult;
            
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
        
        public BulkRestResult.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public BulkRestResult.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.BulkRestResult initObject = new Intersight.Model.BulkRestResult();
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
    /// <para type="synopsis">This is the cmdlet to Initialize BulkApiResult.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightBulkApiResult")]
    public class InitializeIntersightBulkApiResult:PSCmdlet
	{
		public InitializeIntersightBulkApiResult()
		{
            ClassId = BulkApiResult.ClassIdEnum.BulkRestResult;
            ObjectType = BulkApiResult.ObjectTypeEnum.BulkRestResult;
            
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
        
        public BulkApiResult.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public BulkApiResult.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.BulkApiResult initObject = new Intersight.Model.BulkApiResult();
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
    /// <para type="synopsis">This is the cmdlet to Initialize BulkSubRequest.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightBulkSubRequest")]
    public class InitializeIntersightBulkSubRequest:PSCmdlet
	{
		public InitializeIntersightBulkSubRequest()
		{
            ClassId = BulkSubRequest.ClassIdEnum.BulkRestSubRequest;
            ObjectType = BulkSubRequest.ObjectTypeEnum.BulkRestSubRequest;
            Verb = BulkSubRequest.VerbEnum.POST;
            
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
        
        public BulkSubRequest.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public BulkSubRequest.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The URI on which this action is to be performed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Uri {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of operation to be performed.\nOne of - Post (Create), Patch (Update) or Delete (Remove).\nThe value is used to override the top level verb.\n* `POST` - Used to create a REST resource.\n* `PATCH` - Used to update a REST resource.\n* `DELETE` - Used to delete a REST resource."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public BulkSubRequest.VerbEnum Verb {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.BulkSubRequest initObject = new Intersight.Model.BulkSubRequest();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Uri"))
            {
                initObject.Uri = this.Uri;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Verb"))
            {
                initObject.Verb = this.Verb;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize BulkRestSubRequest.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightBulkRestSubRequest")]
    public class InitializeIntersightBulkRestSubRequest:PSCmdlet
	{
		public InitializeIntersightBulkRestSubRequest()
		{
            ClassId = BulkRestSubRequest.ClassIdEnum.BulkRestSubRequest;
            ObjectType = BulkRestSubRequest.ObjectTypeEnum.BulkRestSubRequest;
            Verb = BulkRestSubRequest.VerbEnum.POST;
            
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
        /// <para type="description">"The content to be used for creating or updating a MO.\nThis field would need to conform to the schema published for the object type that is being operated upon."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.MoBaseMo Body {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public BulkRestSubRequest.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public BulkRestSubRequest.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Used with PATCH & DELETE actions. The moid of an existing object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string TargetMoid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The URI on which this action is to be performed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Uri {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of operation to be performed.\nOne of - Post (Create), Patch (Update) or Delete (Remove).\nThe value is used to override the top level verb.\n* `POST` - Used to create a REST resource.\n* `PATCH` - Used to update a REST resource.\n* `DELETE` - Used to delete a REST resource."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public BulkRestSubRequest.VerbEnum Verb {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.BulkRestSubRequest initObject = new Intersight.Model.BulkRestSubRequest();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Body"))
            {
                initObject.Body = this.Body;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("TargetMoid"))
            {
                initObject.TargetMoid = this.TargetMoid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Uri"))
            {
                initObject.Uri = this.Uri;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Verb"))
            {
                initObject.Verb = this.Verb;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize BulkHttpHeader.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightBulkHttpHeader")]
    public class InitializeIntersightBulkHttpHeader:PSCmdlet
	{
		public InitializeIntersightBulkHttpHeader()
		{
            ClassId = BulkHttpHeader.ClassIdEnum.BulkHttpHeader;
            ObjectType = BulkHttpHeader.ObjectTypeEnum.BulkHttpHeader;
            
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
        
        public BulkHttpHeader.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public BulkHttpHeader.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.BulkHttpHeader initObject = new Intersight.Model.BulkHttpHeader();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
}