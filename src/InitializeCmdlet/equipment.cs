using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize EquipmentIoCardIdentity.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightEquipmentIoCardIdentity")]
    public class InitializeIntersightEquipmentIoCardIdentity:PSCmdlet
	{
		public InitializeIntersightEquipmentIoCardIdentity()
		{
            ClassId = EquipmentIoCardIdentity.ClassIdEnum.EquipmentIoCardIdentity;
            ObjectType = EquipmentIoCardIdentity.ObjectTypeEnum.EquipmentIoCardIdentity;
            
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
        
        public EquipmentIoCardIdentity.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"MO Reference to equipmentIoCard MO in inventory service."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string IoCardMoid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IOM/MUX Module ID connected to the FI."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long ModuleId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"MO Reference to networkElement MO in inventory service."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string NetworkElementMoid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public EquipmentIoCardIdentity.ObjectTypeEnum ObjectType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Switch ID to which IOM is connected, ID can be either 1 or 2, equalent to A or B."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long SwitchId {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.EquipmentIoCardIdentity initObject = new Intersight.Model.EquipmentIoCardIdentity();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("IoCardMoid"))
            {
                initObject.IoCardMoid = this.IoCardMoid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ModuleId"))
            {
                initObject.ModuleId = this.ModuleId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NetworkElementMoid"))
            {
                initObject.NetworkElementMoid = this.NetworkElementMoid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SwitchId"))
            {
                initObject.SwitchId = this.SwitchId;
            }
            WriteObject(initObject);
        }

    }
}