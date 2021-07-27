using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CloudCustomAttributes.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCloudCustomAttributes")]
    public class InitializeIntersightCloudCustomAttributes:PSCmdlet
	{
		public InitializeIntersightCloudCustomAttributes()
		{
            ClassId = CloudCustomAttributes.ClassIdEnum.CloudCustomAttributes;
            ObjectType = CloudCustomAttributes.ObjectTypeEnum.CloudCustomAttributes;
            
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
        /// <para type="description">"The name of an attribute. If used as a key-value pair then this field represents the key."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string AttributeName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The data type for attributeValue. For e.g. string, int, float."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string AttributeType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The attribute value. If used as a key-value pair then this field represents the value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string AttributeValue {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public CloudCustomAttributes.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public CloudCustomAttributes.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.CloudCustomAttributes initObject = new Intersight.Model.CloudCustomAttributes();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AttributeName"))
            {
                initObject.AttributeName = this.AttributeName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AttributeType"))
            {
                initObject.AttributeType = this.AttributeType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AttributeValue"))
            {
                initObject.AttributeValue = this.AttributeValue;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
}