using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize InventoryInventoryMo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightInventoryInventoryMo")]
    public class InitializeIntersightInventoryInventoryMo:PSCmdlet
	{
		public InitializeIntersightInventoryInventoryMo()
		{
            ClassId = InventoryInventoryMo.ClassIdEnum.InventoryInventoryMo;
            ObjectType = InventoryInventoryMo.ObjectTypeEnum.InventoryInventoryMo;
            
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
        
        public InventoryInventoryMo.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The UCS DN of the MO for which the latest inventory to be fetched. If this property is empty and moId property has the Moid of the MO to be updated, the Moid will be used. If this property is empty and moId is also empty, all the MOs of the given moType will be updated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string MoDn {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The MO id of an MO for which the latest inventory to be fetched. If this property is empty and moDn property has the UCS DN of the MO to be updated, the DN will be used. If this property is empty and moDn is also empty, all the MOs of the given moType will be updated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string MoId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of the MO for which the latest inventory to be fetched."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string MoType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public InventoryInventoryMo.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.InventoryInventoryMo initObject = new Intersight.Model.InventoryInventoryMo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("MoDn"))
            {
                initObject.MoDn = this.MoDn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MoId"))
            {
                initObject.MoId = this.MoId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MoType"))
            {
                initObject.MoType = this.MoType;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize InventoryUemInfo.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightInventoryUemInfo")]
    public class InitializeIntersightInventoryUemInfo:PSCmdlet
	{
		public InitializeIntersightInventoryUemInfo()
		{
            ClassId = InventoryUemInfo.ClassIdEnum.InventoryUemInfo;
            ObjectType = InventoryUemInfo.ObjectTypeEnum.InventoryUemInfo;
            
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
        
        public InventoryUemInfo.ClassIdEnum ClassId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Last Sequence ID in the UEM event frame received from the endpoint identified by endpointInfo."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long LastSequenceId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public InventoryUemInfo.ObjectTypeEnum ObjectType {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
             Intersight.Model.InventoryUemInfo initObject = new Intersight.Model.InventoryUemInfo();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("LastSequenceId"))
            {
                initObject.LastSequenceId = this.LastSequenceId;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
}