using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set EtherNetworkPort.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightEtherNetworkPort")]
    public class SetIntersightEtherNetworkPort:SetCmdletBase
	{
		public SetIntersightEtherNetworkPort()
		{
			ApiInstance = new EtherApi(Config);
            ModelObject = new EtherNetworkPort();
            MethodName = "UpdateEtherNetworkPort";
		}
        // <summary>
        /// <para type="description">"A reference to a etherPhysicalPortBase resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public EtherPhysicalPortBaseRelationship AcknowledgedPeerInterface {
            get;
            set;
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
        /// <para type="description">"Febric extender identifier for this port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long ModuleId {
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
        /// <para type="description">"Operational state of an Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string OperState {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Peer DN for network host port of fabric extender."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PeerDn {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a etherPhysicalPortBase resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public EtherPhysicalPortBaseRelationship PeerInterface {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Switch physical port identifier."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long PortId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Switch expansion slot module identifier."</para>
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
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get EtherHostPort.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightEtherHostPort", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightEtherHostPort:GetCmdletBase
	{
		public GetIntersightEtherHostPort()
		{
			ApiInstance = new EtherApi(Config);
            MethodName = "GetEtherHostPortList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set EtherPhysicalPort.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightEtherPhysicalPort")]
    public class SetIntersightEtherPhysicalPort:SetCmdletBase
	{
		public SetIntersightEtherPhysicalPort()
		{
			ApiInstance = new EtherApi(Config);
            ModelObject = new EtherPhysicalPort();
            MethodName = "UpdateEtherPhysicalPort";
		}
        // <summary>
        /// <para type="description">"A reference to a portInterfaceBase resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PortInterfaceBaseRelationship AcknowledgedPeerInterface {
            get;
            set;
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
        /// <para type="description">"A reference to a portInterfaceBase resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PortInterfaceBaseRelationship PeerInterface {
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
    /// <para type="synopsis">This is the cmdlet to Get EtherPhysicalPort.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightEtherPhysicalPort", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightEtherPhysicalPort:GetCmdletBase
	{
		public GetIntersightEtherPhysicalPort()
		{
			ApiInstance = new EtherApi(Config);
            MethodName = "GetEtherPhysicalPortList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get EtherNetworkPort.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightEtherNetworkPort", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightEtherNetworkPort:GetCmdletBase
	{
		public GetIntersightEtherNetworkPort()
		{
			ApiInstance = new EtherApi(Config);
            MethodName = "GetEtherNetworkPortList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set EtherHostPort.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightEtherHostPort")]
    public class SetIntersightEtherHostPort:SetCmdletBase
	{
		public SetIntersightEtherHostPort()
		{
			ApiInstance = new EtherApi(Config);
            ModelObject = new EtherHostPort();
            MethodName = "PatchEtherHostPort";
		}
        // <summary>
        /// <para type="description">"A reference to a portInterfaceBase resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PortInterfaceBaseRelationship AcknowledgedPeerInterface {
            get;
            set;
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
        /// <para type="description">"Fabric extender identifier for this port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long ModuleId {
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
        /// <para type="description">"A reference to a portInterfaceBase resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PortInterfaceBaseRelationship PeerInterface {
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
    /// <para type="synopsis">This is the cmdlet to Get EtherPortChannel.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightEtherPortChannel", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightEtherPortChannel:GetCmdletBase
	{
		public GetIntersightEtherPortChannel()
		{
			ApiInstance = new EtherApi(Config);
            MethodName = "GetEtherPortChannelList";
		}
    }
}