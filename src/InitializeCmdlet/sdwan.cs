using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize SdwanTemplateInputsType.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightSdwanTemplateInputsType")]
    public class InitializeIntersightSdwanTemplateInputsType:PSCmdlet
	{
		public InitializeIntersightSdwanTemplateInputsType()
		{
            ClassId = SdwanTemplateInputsType.ClassIdEnum.SdwanTemplateInputsType;
            ObjectType = SdwanTemplateInputsType.ObjectTypeEnum.SdwanTemplateInputsType;
            
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
        
        public SdwanTemplateInputsType.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Defines if the input is editable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Editable {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the dynamic input key specified in the vManage template."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Key {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SdwanTemplateInputsType.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Defines if the input is optional or required."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Required {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Label for the property being saved in the current instance of template Input."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Title {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Defines the object type for the input."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Type {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Value of the dynamic input key specfied in the vManage template."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Value {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.SdwanTemplateInputsType initObject = new Intersight.Model.SdwanTemplateInputsType();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Editable"))
            {
                initObject.Editable = this.Editable;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Key"))
            {
                initObject.Key = this.Key;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Required"))
            {
                initObject.Required = this.Required;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Title"))
            {
                initObject.Title = this.Title;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Type"))
            {
                initObject.Type = this.Type;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Value"))
            {
                initObject.Value = this.Value;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize SdwanNetworkConfigurationType.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightSdwanNetworkConfigurationType")]
    public class InitializeIntersightSdwanNetworkConfigurationType:PSCmdlet
	{
		public InitializeIntersightSdwanNetworkConfigurationType()
		{
            ClassId = SdwanNetworkConfigurationType.ClassIdEnum.SdwanNetworkConfigurationType;
            NetworkType = SdwanNetworkConfigurationType.NetworkTypeEnum.WAN;
            ObjectType = SdwanNetworkConfigurationType.ObjectTypeEnum.SdwanNetworkConfigurationType;
            
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
        
        public SdwanNetworkConfigurationType.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of the Port group being added.\n* `WAN` - Port-group being added is used for WAN traffic.\n* `LAN` - Port-group being added is used for LAN traffic.\n* `Management` - Port-group being added is used for Management traffic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SdwanNetworkConfigurationType.NetworkTypeEnum NetworkType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SdwanNetworkConfigurationType.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the Port Group to create."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PortGroup {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VLAN to be added to the Port Group."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Vlan {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.SdwanNetworkConfigurationType initObject = new Intersight.Model.SdwanNetworkConfigurationType();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("NetworkType"))
            {
                initObject.NetworkType = this.NetworkType;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PortGroup"))
            {
                initObject.PortGroup = this.PortGroup;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vlan"))
            {
                initObject.Vlan = this.Vlan;
            }
            WriteObject(initObject);
        }

    }
}