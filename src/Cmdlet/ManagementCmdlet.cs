using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set ManagementInterface.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightManagementInterface")]
    public class SetIntersightManagementInterface:SetCmdletBase
	{
		public SetIntersightManagementInterface()
		{
			ApiInstance = new ManagementApi(Config);
            ModelObject = new ManagementInterface();
            MethodName = "UpdateManagementInterface";
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
        /// <para type="description">"Hostname configured for the interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string HostName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IPv6 address of the interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Ipv6Address {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IPv6 default gateway for the interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Ipv6Gateway {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IPv6 prefix for the interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Ipv6Prefix {
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
        /// <para type="description">"Switch Id connected to the interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SwitchId {
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
        // <summary>
        /// <para type="description">"The event channel connection status for the interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string UemConnStatus {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Virtual hostname configured for the interface in case of clustered environment."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string VirtualHostName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VlanId configured for the interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long VlanId {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set ManagementController.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightManagementController")]
    public class SetIntersightManagementController:SetCmdletBase
	{
		public SetIntersightManagementController()
		{
			ApiInstance = new ManagementApi(Config);
            ModelObject = new ManagementController();
            MethodName = "UpdateManagementController";
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
        /// <para type="description">"A reference to a equipmentIoCardBase resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public EquipmentIoCardBaseRelationship EquipmentIoCardBase {
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
    /// <para type="synopsis">This is the cmdlet to Set ManagementEntity.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightManagementEntity")]
    public class SetIntersightManagementEntity:SetCmdletBase
	{
		public SetIntersightManagementEntity()
		{
			ApiInstance = new ManagementApi(Config);
            ModelObject = new ManagementEntity();
            MethodName = "UpdateManagementEntity";
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
    /// <para type="synopsis">This is the cmdlet to Get ManagementEntity.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightManagementEntity", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightManagementEntity:GetCmdletBase
	{
		public GetIntersightManagementEntity()
		{
			ApiInstance = new ManagementApi(Config);
            MethodName = "GetManagementEntityList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ManagementInterface.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightManagementInterface", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightManagementInterface:GetCmdletBase
	{
		public GetIntersightManagementInterface()
		{
			ApiInstance = new ManagementApi(Config);
            MethodName = "GetManagementInterfaceList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get ManagementController.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightManagementController", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightManagementController:GetCmdletBase
	{
		public GetIntersightManagementController()
		{
			ApiInstance = new ManagementApi(Config);
            MethodName = "GetManagementControllerList";
		}
    }
}