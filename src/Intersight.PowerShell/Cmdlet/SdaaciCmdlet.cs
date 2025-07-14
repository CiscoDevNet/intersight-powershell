using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get SdaaciConnection.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightSdaaciConnection", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightSdaaciConnection : GetCmdletBase
    {
        public GetIntersightSdaaciConnection()
        {
            ApiInstance = new SdaaciApi(Config);
            MethodName = "GetSdaaciConnectionListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AccountMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"User input for ACI L3Out name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AciL3Out
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Match rule name in Cisco APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AciMatchRuleName
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"ACI tenant name for the selected APIC target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AciTenant
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"A reference to a assetTarget resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public AssetTargetRelationship ApicTarget
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Campus fabric site Id where the border node is configured."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string CampusFabricSite
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a assetTarget resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public AssetTargetRelationship CatalystCenterTarget
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DomainGroupMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Application EPG name for this connection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Epg
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"EPG Subnet Ipv4Cidr configured on APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\/([0-9]|[1-2][0-9]|3[0-2])$")]
        public string EpgSubnet
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Device within the selected domain used for firewall configuration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string FirewallDevice
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Domain used for firewall configuration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string FirewallDomain
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a assetTarget resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public AssetTargetRelationship FmcTarget
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ModTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Moid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"L3Out node profile in Cisco APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string NodeProfile
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public OrganizationOrganizationRelationship Organization
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Connection status between SDA and ACI.\n* `NotConnected` - Status of the connection:Not connected.\n* `Connected` - Status of the connection:Connected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public SdaaciConnection.StatusEnum Status
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Transit Id for the given border node."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Transit
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Virtual Network for this connection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string VirtualNetwork
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"VN and EPG information for this connection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string VnEpg
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Tenant VRF in Cisco APIC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Vrf
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get SdaaciConnectionDetail.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightSdaaciConnectionDetail", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightSdaaciConnectionDetail : GetCmdletBase
    {
        public GetIntersightSdaaciConnectionDetail()
        {
            ApiInstance = new SdaaciApi(Config);
            MethodName = "GetSdaaciConnectionDetailListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"The Account ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AccountMoid
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"A reference to a sdaaciConnection resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public SdaaciConnectionRelationship Connection
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CreateTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Description of the connection between the two peers."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Description
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The DomainGroup ID for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DomainGroupMoid
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Ip pool Id configured for this connection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string IpPool
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Layer 3 handoff Id configured between a border node and a border leaf."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Layer3HandoffId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when this managed object was last modified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ModTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Moid
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public MoBaseMoRelationship Parent
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Interface Id configured on Peer A."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string PeerAinterface
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"IP address of the device used as the local peer."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]).([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\/([0-9]|[1-2][0-9]|3[0-2])$")]
        public string PeerAipAddress
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Type of device used as Peer A in this peer connection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string PeerAtype
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Interface Id configured on Peer B."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string PeerBinterface
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"IP address of the device used as the remote peer."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string PeerBipAddress
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Type of device used as Peer B in this peer connection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string PeerBtype
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"First peer in the connection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Peera
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Second peer in the connection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Peerb
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"Router Id defined for this peer connection."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string RouterId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Connection status between the peers.\n* `NotConnected` - Status of the connection:Not connected.\n* `Connected` - Status of the connection:Connected."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public SdaaciConnectionDetail.StatusEnum Status
        {
            get;
            set;
        }




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New SdaaciConnection.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightSdaaciConnection")]
    public class NewIntersightSdaaciConnection : NewCmdletBase
    {
        public NewIntersightSdaaciConnection()
        {
            ApiInstance = new SdaaciApi(Config);
            ModelObject = new SdaaciConnection();
            MethodName = "CreateSdaaciConnectionWithHttpInfo";
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

        public AssetTargetRelationship ApicTarget
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

        public AssetTargetRelationship CatalystCenterTarget
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

        public AssetTargetRelationship FmcTarget
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
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public OrganizationOrganizationRelationship Organization
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

        public List<MoTag> Tags
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
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New SdaaciConnectionDetail.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightSdaaciConnectionDetail")]
    public class NewIntersightSdaaciConnectionDetail : NewCmdletBase
    {
        public NewIntersightSdaaciConnectionDetail()
        {
            ApiInstance = new SdaaciApi(Config);
            ModelObject = new SdaaciConnectionDetail();
            MethodName = "CreateSdaaciConnectionDetailWithHttpInfo";
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
        /// <para type="description">"A reference to a sdaaciConnection resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public SdaaciConnectionRelationship Connection
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

        public List<MoTag> Tags
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove SdaaciConnection.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightSdaaciConnection")]
    public class RemoveIntersightSdaaciConnection : RemoveCmdletBase
    {
        public RemoveIntersightSdaaciConnection()
        {
            ApiInstance = new SdaaciApi(Config);
            MethodName = "DeleteSdaaciConnectionWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove SdaaciConnectionDetail.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightSdaaciConnectionDetail")]
    public class RemoveIntersightSdaaciConnectionDetail : RemoveCmdletBase
    {
        public RemoveIntersightSdaaciConnectionDetail()
        {
            ApiInstance = new SdaaciApi(Config);
            MethodName = "DeleteSdaaciConnectionDetailWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set SdaaciConnection.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightSdaaciConnection")]
    public class SetIntersightSdaaciConnection : SetCmdletBase
    {
        public SetIntersightSdaaciConnection()
        {
            ApiInstance = new SdaaciApi(Config);
            ModelObject = new SdaaciConnection();
            MethodName = "UpdateSdaaciConnectionWithHttpInfo";
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

        public AssetTargetRelationship ApicTarget
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

        public AssetTargetRelationship CatalystCenterTarget
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

        public AssetTargetRelationship FmcTarget
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

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
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public OrganizationOrganizationRelationship Organization
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

        public List<MoTag> Tags
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
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set SdaaciConnectionDetail.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightSdaaciConnectionDetail")]
    public class SetIntersightSdaaciConnectionDetail : SetCmdletBase
    {
        public SetIntersightSdaaciConnectionDetail()
        {
            ApiInstance = new SdaaciApi(Config);
            ModelObject = new SdaaciConnectionDetail();
            MethodName = "UpdateSdaaciConnectionDetailWithHttpInfo";
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
        /// <para type="description">"A reference to a sdaaciConnection resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public SdaaciConnectionRelationship Connection
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
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
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

        public List<MoTag> Tags
        {
            get;
            set;
        }

    }
}