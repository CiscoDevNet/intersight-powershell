using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize MetaAccessPrivilege.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightMetaAccessPrivilege")]
    public class InitializeIntersightMetaAccessPrivilege:PSCmdlet
	{
		public InitializeIntersightMetaAccessPrivilege()
		{
            ClassId = MetaAccessPrivilege.ClassIdEnum.MetaAccessPrivilege;
            ObjectType = MetaAccessPrivilege.ObjectTypeEnum.MetaAccessPrivilege;
            
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
        
        public MetaAccessPrivilege.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public MetaAccessPrivilege.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.MetaAccessPrivilege initObject = new Intersight.Model.MetaAccessPrivilege();
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
    /// <para type="synopsis">This is the cmdlet to Initialize MetaRelationshipDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightMetaRelationshipDefinition")]
    public class InitializeIntersightMetaRelationshipDefinition:PSCmdlet
	{
		public InitializeIntersightMetaRelationshipDefinition()
		{
            ClassId = MetaRelationshipDefinition.ClassIdEnum.MetaRelationshipDefinition;
            ObjectType = MetaRelationshipDefinition.ObjectTypeEnum.MetaRelationshipDefinition;
            
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
        
        public MetaRelationshipDefinition.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public MetaRelationshipDefinition.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.MetaRelationshipDefinition initObject = new Intersight.Model.MetaRelationshipDefinition();
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
    /// <para type="synopsis">This is the cmdlet to Initialize MetaDisplayNameDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightMetaDisplayNameDefinition")]
    public class InitializeIntersightMetaDisplayNameDefinition:PSCmdlet
	{
		public InitializeIntersightMetaDisplayNameDefinition()
		{
            ClassId = MetaDisplayNameDefinition.ClassIdEnum.MetaDisplayNameDefinition;
            ObjectType = MetaDisplayNameDefinition.ObjectTypeEnum.MetaDisplayNameDefinition;
            
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
        
        public MetaDisplayNameDefinition.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public MetaDisplayNameDefinition.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.MetaDisplayNameDefinition initObject = new Intersight.Model.MetaDisplayNameDefinition();
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
    /// <para type="synopsis">This is the cmdlet to Initialize MetaPropDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightMetaPropDefinition")]
    public class InitializeIntersightMetaPropDefinition:PSCmdlet
	{
		public InitializeIntersightMetaPropDefinition()
		{
            ClassId = MetaPropDefinition.ClassIdEnum.MetaPropDefinition;
            ObjectType = MetaPropDefinition.ObjectTypeEnum.MetaPropDefinition;
            
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
        
        public MetaPropDefinition.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public MetaPropDefinition.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.MetaPropDefinition initObject = new Intersight.Model.MetaPropDefinition();
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