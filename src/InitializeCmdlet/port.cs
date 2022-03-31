using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize PortGroup.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightPortGroup")]
    public class InitializeIntersightPortGroup:PSCmdlet
	{
		public InitializeIntersightPortGroup()
		{
            ClassId = PortGroup.ClassIdEnum.PortGroup;
            ObjectType = PortGroup.ObjectTypeEnum.PortGroup;
            
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
        
        public PortGroup.ClassIdEnum ClassId {
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
        
        public PortGroup.ObjectTypeEnum ObjectType {
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

        protected override void ProcessRecord()
        {
             Intersight.Model.PortGroup initObject = new Intersight.Model.PortGroup();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize PortMacBinding.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightPortMacBinding")]
    public class InitializeIntersightPortMacBinding:PSCmdlet
	{
		public InitializeIntersightPortMacBinding()
		{
            ClassId = PortMacBinding.ClassIdEnum.PortMacBinding;
            ObjectType = PortMacBinding.ObjectTypeEnum.PortMacBinding;
            
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
        /// <para type="description">"Aggregate Port ID of the local Switch Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long AggregatePortId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Chassis/FEX device idetifier that is local to a cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long ChassisId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Chassis/Rack Model that is associated with the Switch/FEX interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ChassisModel {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Chassis/Rack Serial that is associated with the Switch/FEX interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ChassisSerial {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Chassis/Rack Vendor that is associated with the Switch/FEX interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ChassisVendor {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PortMacBinding.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Device ID value that is advertised and available as a part of LLDP TLV."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DeviceMac {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IOM/SIOC/Adapter Mode that is associated with the Switch/FEX interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long ModuleMode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IOM/SIOC/Adapter Model that is associated with the Switch/FEX interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ModuleModel {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Uplink port identifier of the VIC that is associated with the Switch/FEX interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long ModulePortId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IOM/SIOC/Adapter Serial that is associated with the Switch/FEX interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ModuleSerial {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IOM/SIOC/Adapter Side that is associated with the Switch/FEX interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long ModuleSide {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IOM/SIOC/Adapter Slot that is associated with the Switch/FEX interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long ModuleSlot {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IOM/SIOC/Adapter Vendor that is associated with the Switch/FEX interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ModuleVendor {
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
        /// <para type="description">"A reference to a networkElement resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public Model.NetworkElementRelationship NetworkElement {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PortMacBinding.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Port ID of the local Switch Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long PortId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Port ID value that is advertised and available as a part of LLDP TLV."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PortMac {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Slot ID of the local Switch slot Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long SlotId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Switch Identifier that is local to a cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long SwitchId {
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

        protected override void ProcessRecord()
        {
             Intersight.Model.PortMacBinding initObject = new Intersight.Model.PortMacBinding();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AggregatePortId"))
            {
                initObject.AggregatePortId = this.AggregatePortId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ChassisId"))
            {
                initObject.ChassisId = this.ChassisId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ChassisModel"))
            {
                initObject.ChassisModel = this.ChassisModel;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ChassisSerial"))
            {
                initObject.ChassisSerial = this.ChassisSerial;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ChassisVendor"))
            {
                initObject.ChassisVendor = this.ChassisVendor;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DeviceMac"))
            {
                initObject.DeviceMac = this.DeviceMac;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ModuleMode"))
            {
                initObject.ModuleMode = this.ModuleMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ModuleModel"))
            {
                initObject.ModuleModel = this.ModuleModel;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ModulePortId"))
            {
                initObject.ModulePortId = this.ModulePortId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ModuleSerial"))
            {
                initObject.ModuleSerial = this.ModuleSerial;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ModuleSide"))
            {
                initObject.ModuleSide = this.ModuleSide;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ModuleSlot"))
            {
                initObject.ModuleSlot = this.ModuleSlot;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ModuleVendor"))
            {
                initObject.ModuleVendor = this.ModuleVendor;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NetworkElement"))
            {
                initObject.NetworkElement = this.NetworkElement;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PortId"))
            {
                initObject.PortId = this.PortId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PortMac"))
            {
                initObject.PortMac = this.PortMac;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotId"))
            {
                initObject.SlotId = this.SlotId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SwitchId"))
            {
                initObject.SwitchId = this.SwitchId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize PortSubGroup.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightPortSubGroup")]
    public class InitializeIntersightPortSubGroup:PSCmdlet
	{
		public InitializeIntersightPortSubGroup()
		{
            ClassId = PortSubGroup.ClassIdEnum.PortSubGroup;
            ObjectType = PortSubGroup.ObjectTypeEnum.PortSubGroup;
            
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
        
        public PortSubGroup.ClassIdEnum ClassId {
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
        
        public PortSubGroup.ObjectTypeEnum ObjectType {
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

        protected override void ProcessRecord()
        {
             Intersight.Model.PortSubGroup initObject = new Intersight.Model.PortSubGroup();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
}