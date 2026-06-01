using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize SdaaciConnection.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightSdaaciConnection")]
    public class InitializeIntersightSdaaciConnection : PSCmdlet
    {
        public InitializeIntersightSdaaciConnection()
        {
            ClassId = SdaaciConnection.ClassIdEnum.SdaaciConnection;
            ObjectType = SdaaciConnection.ObjectTypeEnum.SdaaciConnection;
            Status = SdaaciConnection.StatusEnum.NotConnected;

        }
        // <summary>
        /// <para type="description">"User input for ACI L3Out name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string AciL3Out
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Match rule name in Cisco APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string AciMatchRuleName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"ACI tenant name for the selected APIC target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string AciTenant
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
        /// <para type="description">"A reference to a assetTarget resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetTargetRelationship ApicTarget
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Campus fabric site Id where the border node is configured."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string CampusFabricSite
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetTarget resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetTargetRelationship CatalystCenterTarget
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public SdaaciConnection.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Application EPG name for this connection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Epg
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"EPG Subnet Ipv4Cidr configured on APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\/([0-9]|[1-2][0-9]|3[0-2])$")]
        public string EpgSubnet
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Device within the selected domain used for firewall configuration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string FirewallDevice
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Domain used for firewall configuration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string FirewallDomain
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetTarget resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.AssetTargetRelationship FmcTarget
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
        /// <para type="description">"L3Out node profile in Cisco APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string NodeProfile
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public SdaaciConnection.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.OrganizationOrganizationRelationship Organization
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Connection status between SDA and ACI.\n* `NotConnected` - Status of the connection:Not connected.\n* `Connected` - Status of the connection:Connected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public SdaaciConnection.StatusEnum Status
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
        // <summary>
        /// <para type="description">"Transit Id for the given border node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Transit
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Virtual Network for this connection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string VirtualNetwork
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VN and EPG information for this connection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string VnEpg
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Tenant VRF in Cisco APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vrf
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.SdaaciConnection initObject = new Intersight.Model.SdaaciConnection();
            if (this.MyInvocation.BoundParameters.ContainsKey("AciL3Out"))
            {
                initObject.AciL3Out = this.AciL3Out;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AciMatchRuleName"))
            {
                initObject.AciMatchRuleName = this.AciMatchRuleName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AciTenant"))
            {
                initObject.AciTenant = this.AciTenant;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ApicTarget"))
            {
                initObject.ApicTarget = this.ApicTarget;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CampusFabricSite"))
            {
                initObject.CampusFabricSite = this.CampusFabricSite;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("CatalystCenterTarget"))
            {
                initObject.CatalystCenterTarget = this.CatalystCenterTarget;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Epg"))
            {
                initObject.Epg = this.Epg;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EpgSubnet"))
            {
                initObject.EpgSubnet = this.EpgSubnet;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FirewallDevice"))
            {
                initObject.FirewallDevice = this.FirewallDevice;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FirewallDomain"))
            {
                initObject.FirewallDomain = this.FirewallDomain;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FmcTarget"))
            {
                initObject.FmcTarget = this.FmcTarget;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NodeProfile"))
            {
                initObject.NodeProfile = this.NodeProfile;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Organization"))
            {
                initObject.Organization = this.Organization;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Status"))
            {
                initObject.Status = this.Status;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Transit"))
            {
                initObject.Transit = this.Transit;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VirtualNetwork"))
            {
                initObject.VirtualNetwork = this.VirtualNetwork;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VnEpg"))
            {
                initObject.VnEpg = this.VnEpg;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vrf"))
            {
                initObject.Vrf = this.Vrf;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize SdaaciConnectionDetail.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightSdaaciConnectionDetail")]
    public class InitializeIntersightSdaaciConnectionDetail : PSCmdlet
    {
        public InitializeIntersightSdaaciConnectionDetail()
        {
            ClassId = SdaaciConnectionDetail.ClassIdEnum.SdaaciConnectionDetail;
            ObjectType = SdaaciConnectionDetail.ObjectTypeEnum.SdaaciConnectionDetail;
            Status = SdaaciConnectionDetail.StatusEnum.NotConnected;

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

        public SdaaciConnectionDetail.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a sdaaciConnection resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.SdaaciConnectionRelationship Connection
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the connection between the two peers."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Ip pool Id configured for this connection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string IpPool
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Layer 3 handoff Id configured between a border node and a border leaf."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Layer3HandoffId
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

        public SdaaciConnectionDetail.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Interface Id configured on Peer A."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PeerAinterface
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IP address of the device used as the local peer."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\/([0-9]|[1-2][0-9]|3[0-2])$")]
        public string PeerAipAddress
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of device used as Peer A in this peer connection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PeerAtype
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Interface Id configured on Peer B."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PeerBinterface
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IP address of the device used as the remote peer."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PeerBipAddress
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of device used as Peer B in this peer connection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PeerBtype
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"First peer in the connection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Peera
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Second peer in the connection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Peerb
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Router Id defined for this peer connection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string RouterId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Connection status between the peers.\n* `NotConnected` - Status of the connection:Not connected.\n* `Connected` - Status of the connection:Connected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public SdaaciConnectionDetail.StatusEnum Status
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
            PSUtils.ProcessRelationshipParam(this.MyInvocation.BoundParameters);
            Intersight.Model.SdaaciConnectionDetail initObject = new Intersight.Model.SdaaciConnectionDetail();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Connection"))
            {
                initObject.Connection = this.Connection;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IpPool"))
            {
                initObject.IpPool = this.IpPool;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Layer3HandoffId"))
            {
                initObject.Layer3HandoffId = this.Layer3HandoffId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PeerAinterface"))
            {
                initObject.PeerAinterface = this.PeerAinterface;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PeerAipAddress"))
            {
                initObject.PeerAipAddress = this.PeerAipAddress;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PeerAtype"))
            {
                initObject.PeerAtype = this.PeerAtype;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PeerBinterface"))
            {
                initObject.PeerBinterface = this.PeerBinterface;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PeerBipAddress"))
            {
                initObject.PeerBipAddress = this.PeerBipAddress;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PeerBtype"))
            {
                initObject.PeerBtype = this.PeerBtype;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Peera"))
            {
                initObject.Peera = this.Peera;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Peerb"))
            {
                initObject.Peerb = this.Peerb;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("RouterId"))
            {
                initObject.RouterId = this.RouterId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Status"))
            {
                initObject.Status = this.Status;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
}