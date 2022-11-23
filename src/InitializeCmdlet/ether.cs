using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize EtherHostPort.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightEtherHostPort")]
    public class InitializeIntersightEtherHostPort : PSCmdlet
    {
        public InitializeIntersightEtherHostPort()
        {
            ClassId = EtherHostPort.ClassIdEnum.EtherHostPort;
            ObjectType = EtherHostPort.ObjectTypeEnum.EtherHostPort;

        }
        // <summary>
        /// <para type="description">"A reference to a portInterfaceBase resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.PortInterfaceBaseRelationship AcknowledgedPeerInterface
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public EtherHostPort.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a equipmentIoCardBase resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.EquipmentIoCardBaseRelationship EquipmentIoCardBase
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Fabric extender identifier for this port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long ModuleId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public EtherHostPort.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a portInterfaceBase resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.PortInterfaceBaseRelationship PeerInterface
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.EtherHostPort initObject = new Intersight.Model.EtherHostPort();
            if (this.MyInvocation.BoundParameters.ContainsKey("AcknowledgedPeerInterface"))
            {
                initObject.AcknowledgedPeerInterface = this.AcknowledgedPeerInterface;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("EquipmentIoCardBase"))
            {
                initObject.EquipmentIoCardBase = this.EquipmentIoCardBase;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ModuleId"))
            {
                initObject.ModuleId = this.ModuleId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PeerInterface"))
            {
                initObject.PeerInterface = this.PeerInterface;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize EtherNetworkPort.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightEtherNetworkPort")]
    public class InitializeIntersightEtherNetworkPort : PSCmdlet
    {
        public InitializeIntersightEtherNetworkPort()
        {
            ClassId = EtherNetworkPort.ClassIdEnum.EtherNetworkPort;
            ObjectType = EtherNetworkPort.ObjectTypeEnum.EtherNetworkPort;

        }
        // <summary>
        /// <para type="description">"A reference to a etherPhysicalPortBase resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.EtherPhysicalPortBaseRelationship AcknowledgedPeerInterface
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public EtherNetworkPort.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a equipmentIoCardBase resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.EquipmentIoCardBaseRelationship EquipmentIoCardBase
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Febric extender identifier for this port."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long ModuleId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public EtherNetworkPort.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Operational state of an Interface."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string OperState
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Peer DN for network host port of fabric extender."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PeerDn
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a etherPhysicalPortBase resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.EtherPhysicalPortBaseRelationship PeerInterface
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Switch physical port identifier."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long PortId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Switch expansion slot module identifier."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long SlotId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Switch Identifier that is local to a cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SwitchId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.EtherNetworkPort initObject = new Intersight.Model.EtherNetworkPort();
            if (this.MyInvocation.BoundParameters.ContainsKey("AcknowledgedPeerInterface"))
            {
                initObject.AcknowledgedPeerInterface = this.AcknowledgedPeerInterface;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("EquipmentIoCardBase"))
            {
                initObject.EquipmentIoCardBase = this.EquipmentIoCardBase;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ModuleId"))
            {
                initObject.ModuleId = this.ModuleId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OperState"))
            {
                initObject.OperState = this.OperState;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PeerDn"))
            {
                initObject.PeerDn = this.PeerDn;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PeerInterface"))
            {
                initObject.PeerInterface = this.PeerInterface;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PortId"))
            {
                initObject.PortId = this.PortId;
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
    /// <para type="synopsis">This is the cmdlet to Initialize EtherPhysicalPort.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightEtherPhysicalPort")]
    public class InitializeIntersightEtherPhysicalPort : PSCmdlet
    {
        public InitializeIntersightEtherPhysicalPort()
        {
            ClassId = EtherPhysicalPort.ClassIdEnum.EtherPhysicalPort;
            ObjectType = EtherPhysicalPort.ObjectTypeEnum.EtherPhysicalPort;

        }
        // <summary>
        /// <para type="description">"A reference to a portInterfaceBase resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.PortInterfaceBaseRelationship AcknowledgedPeerInterface
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public EtherPhysicalPort.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public EtherPhysicalPort.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a portInterfaceBase resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.PortInterfaceBaseRelationship PeerInterface
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.EtherPhysicalPort initObject = new Intersight.Model.EtherPhysicalPort();
            if (this.MyInvocation.BoundParameters.ContainsKey("AcknowledgedPeerInterface"))
            {
                initObject.AcknowledgedPeerInterface = this.AcknowledgedPeerInterface;
            }
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
            if (this.MyInvocation.BoundParameters.ContainsKey("PeerInterface"))
            {
                initObject.PeerInterface = this.PeerInterface;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize EtherPortChannel.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightEtherPortChannel")]
    public class InitializeIntersightEtherPortChannel : PSCmdlet
    {
        public InitializeIntersightEtherPortChannel()
        {
            ClassId = EtherPortChannel.ClassIdEnum.EtherPortChannel;
            ObjectType = EtherPortChannel.ObjectTypeEnum.EtherPortChannel;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public EtherPortChannel.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a equipmentSwitchCard resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.EquipmentSwitchCardRelationship EquipmentSwitchCard
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public EtherPortChannel.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.EtherPortChannel initObject = new Intersight.Model.EtherPortChannel();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("EquipmentSwitchCard"))
            {
                initObject.EquipmentSwitchCard = this.EquipmentSwitchCard;
            }
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