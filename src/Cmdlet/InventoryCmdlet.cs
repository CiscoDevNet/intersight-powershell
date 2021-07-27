using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get InventoryGenericInventory.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightInventoryGenericInventory", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightInventoryGenericInventory:GetCmdletBase
	{
		public GetIntersightInventoryGenericInventory()
		{
			ApiInstance = new InventoryApi(Config);
            MethodName = "GetInventoryGenericInventoryList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New InventoryRequest.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightInventoryRequest")]
    public class NewIntersightInventoryRequest:NewCmdletBase
	{
		public NewIntersightInventoryRequest()
		{
			ApiInstance = new InventoryApi(Config);
            ModelObject = new InventoryRequest();
            MethodName = "CreateInventoryRequest";
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
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceRegistrationRelationship Device {
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<InventoryInventoryMo> Mos {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get InventoryGenericInventoryHolder.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightInventoryGenericInventoryHolder", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightInventoryGenericInventoryHolder:GetCmdletBase
	{
		public GetIntersightInventoryGenericInventoryHolder()
		{
			ApiInstance = new InventoryApi(Config);
            MethodName = "GetInventoryGenericInventoryHolderList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get InventoryDeviceInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightInventoryDeviceInfo", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightInventoryDeviceInfo:GetCmdletBase
	{
		public GetIntersightInventoryDeviceInfo()
		{
			ApiInstance = new InventoryApi(Config);
            MethodName = "GetInventoryDeviceInfoList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set InventoryGenericInventory.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightInventoryGenericInventory")]
    public class SetIntersightInventoryGenericInventory:SetCmdletBase
	{
		public SetIntersightInventoryGenericInventory()
		{
			ApiInstance = new InventoryApi(Config);
            ModelObject = new InventoryGenericInventory();
            MethodName = "PatchInventoryGenericInventory";
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
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set InventoryGenericInventoryHolder.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightInventoryGenericInventoryHolder")]
    public class SetIntersightInventoryGenericInventoryHolder:SetCmdletBase
	{
		public SetIntersightInventoryGenericInventoryHolder()
		{
			ApiInstance = new InventoryApi(Config);
            ModelObject = new InventoryGenericInventoryHolder();
            MethodName = "UpdateInventoryGenericInventoryHolder";
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
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get InventoryDnMoBinding.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightInventoryDnMoBinding", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightInventoryDnMoBinding:GetCmdletBase
	{
		public GetIntersightInventoryDnMoBinding()
		{
			ApiInstance = new InventoryApi(Config);
            MethodName = "GetInventoryDnMoBindingList";
		}
    }
}