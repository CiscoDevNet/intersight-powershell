using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexCapabilityInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexCapabilityInfo")]
    public class NewIntersightHyperflexCapabilityInfo:NewCmdletBase
	{
		public NewIntersightHyperflexCapabilityInfo()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexCapabilityInfo();
            MethodName = "CreateHyperflexCapabilityInfo";
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
        /// <para type="description">"A reference to a hyperflexAppCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexAppCatalogRelationship AppCatalog {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HclConstraint> CapabilityConstraints {
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
        /// <para type="description">"Name of the capability or feature set consisting of a collection of constraint rules and value."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        
        public string Name {
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
    /// <para type="synopsis">This is the cmdlet to Get HyperflexCapabilityInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexCapabilityInfo", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexCapabilityInfo:GetCmdletBase
	{
		public GetIntersightHyperflexCapabilityInfo()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexCapabilityInfoList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexExtFcStoragePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexExtFcStoragePolicy")]
    public class SetIntersightHyperflexExtFcStoragePolicy:SetCmdletBase
	{
		public SetIntersightHyperflexExtFcStoragePolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexExtFcStoragePolicy();
            MethodName = "UpdateHyperflexExtFcStoragePolicy";
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
        /// <para type="description">"Enables or disables external FC storage configuration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool AdminState {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexClusterProfileRelationship> ClusterProfiles {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VSAN for the primary Fabric Interconnect external FC storage traffic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexNamedVsan ExtaTraffic {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VSAN for the secondary Fabric Interconnect external FC storage traffic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexNamedVsan ExtbTraffic {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
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
        /// <para type="description">"The range of WWxN addresses to use for the FC storage configuration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexWwxnPrefixRange WwxnPrefixRange {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexExtFcStoragePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexExtFcStoragePolicy")]
    public class RemoveIntersightHyperflexExtFcStoragePolicy:RemoveCmdletBase
	{
		public RemoveIntersightHyperflexExtFcStoragePolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexExtFcStoragePolicy";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexSoftwareDistributionEntry.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexSoftwareDistributionEntry", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexSoftwareDistributionEntry:GetCmdletBase
	{
		public GetIntersightHyperflexSoftwareDistributionEntry()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexSoftwareDistributionEntryList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexSoftwareDistributionEntry.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexSoftwareDistributionEntry")]
    public class NewIntersightHyperflexSoftwareDistributionEntry:NewCmdletBase
	{
		public NewIntersightHyperflexSoftwareDistributionEntry()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexSoftwareDistributionEntry();
            MethodName = "CreateHyperflexSoftwareDistributionEntry";
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
        /// <para type="description">"A reference to a hyperflexAppCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexAppCatalogRelationship AppCatalog {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The HyperFlex Software Distribution type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DistributionType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hyperflexSoftwareDistributionVersion resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexSoftwareDistributionVersionRelationship> DistributionVersions {
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
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexClusterProfile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexClusterProfile")]
    public class SetIntersightHyperflexClusterProfile:SetCmdletBase
	{
		public SetIntersightHyperflexClusterProfile()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexClusterProfile();
            MethodName = "UpdateHyperflexClusterProfile";
		}
        // <summary>
        /// <para type="description">"User initiated action. Each profile type has its own supported actions. For HyperFlex cluster profile, the supported actions are -- Validate, Deploy, Continue, Retry, Abort, Unassign For server profile, the support actions are -- Deploy, Unassign."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Action {
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
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexClusterRelationship AssociatedCluster {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexAutoSupportPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexAutoSupportPolicyRelationship AutoSupport {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexClusterNetworkPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexClusterNetworkPolicyRelationship ClusterNetwork {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexClusterStoragePolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexClusterStoragePolicyRelationship ClusterStorage {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The configuration state and results of the last configuration operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PolicyConfigContext ConfigContext {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The storage data IP address for the HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string DataIpAddress {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexExtFcStoragePolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexExtFcStoragePolicyRelationship ExtFcStorage {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexExtIscsiStoragePolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexExtIscsiStoragePolicyRelationship ExtIscsiStorage {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The node name prefix that is used to automatically generate the default hostname for each server.\nA dash (-) will be appended to the prefix followed by the node number to form a hostname.\nThis default naming scheme can be manually overridden in the node configuration.\nThe maximum length of a prefix is 60, must only contain alphanumeric characters or dash (-), and must\nstart with an alphanumeric character."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9][a-zA-Z0-9-]{1,59}$")]
        public string HostNamePrefix {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a commHttpProxyPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public CommHttpProxyPolicyRelationship Httpproxypolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The hypervisor control virtual IP address for the HyperFlex compute cluster that is used for node/pod management."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string HypervisorControlIpAddress {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The hypervisor type for the HyperFlex cluster.\n* `ESXi` - The hypervisor running on the HyperFlex cluster is a Vmware ESXi hypervisor of any version.\n* `HyperFlexAp` - The hypervisor running on the HyperFlex cluster is Cisco HyperFlex Application Platform.\n* `Hyper-V` - The hypervisor running on the HyperFlex cluster is Microsoft Hyper-V.\n* `Unknown` - The hypervisor running on the HyperFlex cluster is not known."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexClusterProfile.HypervisorTypeEnum HypervisorType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexLocalCredentialPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexLocalCredentialPolicyRelationship LocalCredential {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The MAC address prefix in the form of 00:25:B5:XX."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^00:25:B5:[0-9a-fA-F]{2}$")]
        public string MacAddressPrefix {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The management IP address for the HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string MgmtIpAddress {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The management platform for the HyperFlex cluster.\n* `FI` - The host servers used in the cluster deployment are managed by a UCS Fabric Interconnect.\n* `EDGE` - The host servers used in the cluster deployment are standalone severs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexClusterProfile.MgmtPlatformEnum MgmtPlatform {
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
        /// <para type="description">"Name of the profile instance or profile template."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexNodeConfigPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexNodeConfigPolicyRelationship NodeConfig {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hyperflexNodeProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexNodeProfileRelationship> NodeProfileConfig {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to policyAbstractPolicy resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<PolicyAbstractPolicyRelationship> PolicyBucket {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexProxySettingPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexProxySettingPolicyRelationship ProxySetting {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of copies of each data block written."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Replication {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexSoftwareVersionPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexSoftwareVersionPolicyRelationship SoftwareVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a policyAbstractProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PolicyAbstractProfileRelationship SrcTemplate {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The auxiliary storage IP address for the HyperFlex cluster. For two node clusters, this is the IP address of the auxiliary ZK controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string StorageClusterAuxiliaryIp {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The VLAN for the HyperFlex storage data traffic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexNamedVlan StorageDataVlan {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The storage type used for the HyperFlex cluster (HyperFlex Storage or 3rd party).\n* `HyperFlexDp` - The type of storage is HyperFlex Data Platform.\n* `ThirdParty` - The type of storage is 3rd Party Storage (PureStorage, etc..)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexClusterProfile.StorageTypeEnum StorageType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexSysConfigPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexSysConfigPolicyRelationship SysConfig {
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
        /// <para type="description">"Defines the type of the profile. Accepted values are instance or template.\n* `instance` - The profile defines the configuration for a specific instance of a target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexClusterProfile.TypeEnum Type {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexUcsmConfigPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexUcsmConfigPolicyRelationship UcsmConfig {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexVcenterConfigPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexVcenterConfigPolicyRelationship VcenterConfig {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The WWxN prefix in the form of 20:00:00:25:B5:XX."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^20:00:00:25:B5:[0-9a-fA-F]{2}$")]
        public string WwxnPrefix {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexClusterProfile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexClusterProfile")]
    public class RemoveIntersightHyperflexClusterProfile:RemoveCmdletBase
	{
		public RemoveIntersightHyperflexClusterProfile()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexClusterProfile";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexLocalCredentialPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexLocalCredentialPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexLocalCredentialPolicy:GetCmdletBase
	{
		public GetIntersightHyperflexLocalCredentialPolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexLocalCredentialPolicyList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexLocalCredentialPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexLocalCredentialPolicy")]
    public class NewIntersightHyperflexLocalCredentialPolicy:NewCmdletBase
	{
		public NewIntersightHyperflexLocalCredentialPolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexLocalCredentialPolicy();
            MethodName = "CreateHyperflexLocalCredentialPolicy";
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
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexClusterProfileRelationship> ClusterProfiles {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates if Hypervisor password is the factory set default password. For HyperFlex Data Platform versions 3.0 or higher, enable this if the default password was not changed on the Hypervisor. It is required to supply a new custom Hypervisor password that will be applied to the Hypervisor during deployment. For HyperFlex Data Platform versions prior to 3.0 release, this setting has no effect and the default password will be used for initial install. The Hypervisor password should be changed after deployment."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool FactoryHypervisorPassword {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"HyperFlex storage controller VM password must contain a minimum of 10 characters, with at least 1 lowercase, 1 uppercase, 1 numeric, and 1 of these -_@#$%^&*! special characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9!@#$%^&*_-]{10,}$")]
        public string HxdpRootPwd {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Hypervisor administrator username must contain only alphanumeric characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]{1,}$")]
        public string HypervisorAdmin {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The ESXi root password. For HyperFlex Data Platform 3.0 or later, if the factory default password was not manually changed, you must set a new custom password. If the password was manually changed, you must not enable the factory default password property and provide the current hypervisor password. Note - All HyperFlex nodes require the same hypervisor password for installation. For HyperFlex Data Platform prior to 3.0, use the default password \"Cisco123\" for newly manufactured HyperFlex servers. A custom password should only be entered if hypervisor credentials were manually changed prior to deployment."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^.{7,40}$")]
        public string HypervisorAdminPwd {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
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
    /// <para type="synopsis">This is the cmdlet to Set HyperflexSoftwareDistributionVersion.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexSoftwareDistributionVersion")]
    public class SetIntersightHyperflexSoftwareDistributionVersion:SetCmdletBase
	{
		public SetIntersightHyperflexSoftwareDistributionVersion()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexSoftwareDistributionVersion();
            MethodName = "UpdateHyperflexSoftwareDistributionVersion";
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
        /// <para type="description">"An array of relationships to hyperflexSoftwareDistributionComponent resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexSoftwareDistributionComponentRelationship> DistributionComponents {
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
        /// <para type="description">"A reference to a hyperflexSoftwareDistributionEntry resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexSoftwareDistributionEntryRelationship SoftwareDistributionEntry {
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
        /// <para type="description">"The HyperFlex Software Distribution version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexSoftwareDistributionVersion.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexSoftwareDistributionVersion")]
    public class RemoveIntersightHyperflexSoftwareDistributionVersion:RemoveCmdletBase
	{
		public RemoveIntersightHyperflexSoftwareDistributionVersion()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexSoftwareDistributionVersion";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexHxapHost.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexHxapHost", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexHxapHost:GetCmdletBase
	{
		public GetIntersightHyperflexHxapHost()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexHxapHostList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexSoftwareDistributionComponent.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexSoftwareDistributionComponent")]
    public class SetIntersightHyperflexSoftwareDistributionComponent:SetCmdletBase
	{
		public SetIntersightHyperflexSoftwareDistributionComponent()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexSoftwareDistributionComponent();
            MethodName = "UpdateHyperflexSoftwareDistributionComponent";
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
        /// <para type="description">"The bucket name where the files are present, if source is external cloud store."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string BucketName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The HyperFlex Software Distribution Component Identifier."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ComponentId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The HyperFlex Software Distribution Component Name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ComponentName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"File location on the cloud storage."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FilePath {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> FilesToDownload {
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
        /// <para type="description">"A reference to a hyperflexSoftwareDistributionVersion resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexSoftwareDistributionVersionRelationship SoftwareDistributionVersion {
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
        /// <para type="description">"The HyperFlex Software Distribution Component Version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexSoftwareDistributionComponent.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexSoftwareDistributionComponent")]
    public class RemoveIntersightHyperflexSoftwareDistributionComponent:RemoveCmdletBase
	{
		public RemoveIntersightHyperflexSoftwareDistributionComponent()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexSoftwareDistributionComponent";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexCiscoHypervisorManager.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexCiscoHypervisorManager")]
    public class SetIntersightHyperflexCiscoHypervisorManager:SetCmdletBase
	{
		public SetIntersightHyperflexCiscoHypervisorManager()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexCiscoHypervisorManager();
            MethodName = "UpdateHyperflexCiscoHypervisorManager";
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
        /// <para type="description">"The user provided name for the hypervisor manager. For example, vCenterIreland. Usually, this name is subject to manipulation by the user. It is not the identity of the hypervisor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+[\\sa-zA-Z0-9_-]{1,32}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceRegistrationRelationship RegisteredDevice {
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
    /// <para type="synopsis">This is the cmdlet to Get HyperflexConfigResult.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexConfigResult", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexConfigResult:GetCmdletBase
	{
		public GetIntersightHyperflexConfigResult()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexConfigResultList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexServerFirmwareVersionEntry.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexServerFirmwareVersionEntry")]
    public class NewIntersightHyperflexServerFirmwareVersionEntry:NewCmdletBase
	{
		public NewIntersightHyperflexServerFirmwareVersionEntry()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexServerFirmwareVersionEntry();
            MethodName = "CreateHyperflexServerFirmwareVersionEntry";
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
        /// <para type="description">"The conditions that must be satisfied before applying the AppSetting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexAppSettingConstraint Constraint {
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
        /// <para type="description">"A reference to a hyperflexServerFirmwareVersion resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexServerFirmwareVersionRelationship ServerFirmwareVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The server platform type that is applicable for the server firmware bundle version.\n* `M5` - M5 generation of UCS server.\n* `M3` - M3 generation of UCS server.\n* `M4` - M4 generation of UCS server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexServerFirmwareVersionEntry.ServerPlatformEnum ServerPlatform {
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
        /// <para type="description">"The server firmware bundle version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("(^3\\.[1-9]\\([1-9][a-z]\\)$|^[4-9]\\.[0-9]\\([1-9][a-z]\\)$)")]
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexServerFirmwareVersionEntry.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexServerFirmwareVersionEntry", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexServerFirmwareVersionEntry:GetCmdletBase
	{
		public GetIntersightHyperflexServerFirmwareVersionEntry()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexServerFirmwareVersionEntryList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexSoftwareDistributionComponent.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexSoftwareDistributionComponent", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexSoftwareDistributionComponent:GetCmdletBase
	{
		public GetIntersightHyperflexSoftwareDistributionComponent()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexSoftwareDistributionComponentList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexSoftwareDistributionComponent.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexSoftwareDistributionComponent")]
    public class NewIntersightHyperflexSoftwareDistributionComponent:NewCmdletBase
	{
		public NewIntersightHyperflexSoftwareDistributionComponent()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexSoftwareDistributionComponent();
            MethodName = "CreateHyperflexSoftwareDistributionComponent";
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
        /// <para type="description">"The bucket name where the files are present, if source is external cloud store."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string BucketName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The HyperFlex Software Distribution Component Identifier."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ComponentId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The HyperFlex Software Distribution Component Name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ComponentName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"File location on the cloud storage."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FilePath {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> FilesToDownload {
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
        /// <para type="description">"A reference to a hyperflexSoftwareDistributionVersion resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexSoftwareDistributionVersionRelationship SoftwareDistributionVersion {
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
        /// <para type="description">"The HyperFlex Software Distribution Component Version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexHealthCheckPackageChecksum.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexHealthCheckPackageChecksum", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexHealthCheckPackageChecksum:GetCmdletBase
	{
		public GetIntersightHyperflexHealthCheckPackageChecksum()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexHealthCheckPackageChecksumList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexHealthCheckPackageChecksum.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexHealthCheckPackageChecksum")]
    public class NewIntersightHyperflexHealthCheckPackageChecksum:NewCmdletBase
	{
		public NewIntersightHyperflexHealthCheckPackageChecksum()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexHealthCheckPackageChecksum();
            MethodName = "CreateHyperflexHealthCheckPackageChecksum";
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
        /// <para type="description">"SHA512 checksum of the health check package."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Checksum {
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
        /// <para type="description">"Name of the health check Debian package."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"HyperFlex health check Debian package file name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PackageName {
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
        /// <para type="description">"Timestamp of last update of HyperFlex health check package checksum."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public DateTime Timestamp {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"HyperFlex health check Debian Package Version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexClusterBackupPolicyDeployment.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexClusterBackupPolicyDeployment", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexClusterBackupPolicyDeployment:GetCmdletBase
	{
		public GetIntersightHyperflexClusterBackupPolicyDeployment()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexClusterBackupPolicyDeploymentList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexClusterBackupPolicyDeployment.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexClusterBackupPolicyDeployment")]
    public class NewIntersightHyperflexClusterBackupPolicyDeployment:NewCmdletBase
	{
		public NewIntersightHyperflexClusterBackupPolicyDeployment()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexClusterBackupPolicyDeployment();
            MethodName = "CreateHyperflexClusterBackupPolicyDeployment";
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
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexClusterRelationship BackupTarget {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"True if record created by discovery on HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Discovered {
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
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexClusterRelationship SourceCluster {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"True if policy was detached from source Hyperflex Cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool SourceDetached {
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
        /// <para type="description">"True if policy was detached from target Hyperflex Cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool TargetDetached {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexProxySettingPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexProxySettingPolicy")]
    public class SetIntersightHyperflexProxySettingPolicy:SetCmdletBase
	{
		public SetIntersightHyperflexProxySettingPolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexProxySettingPolicy();
            MethodName = "UpdateHyperflexProxySettingPolicy";
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
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexClusterProfileRelationship> ClusterProfiles {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"HTTP Proxy server FQDN or IP."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[A-Za-z]([A-Za-z0-9-]*[A-Za-z0-9])?$|^[A-Za-z0-9]([A-Za-z0-9-]*[A-Za-z0-9])?(\\.[A-Za-z0-9]([A-Za-z0-9-]*[A-Za-z0-9])?)*(\\.[A-Za-z]([A-Za-z0-9-]*[A-Za-z0-9])?)$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string Hostname {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The password for the HTTP Proxy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Password {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The HTTP Proxy port number.\nThe port number of the HTTP proxy must be between 1 and 65535, inclusive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 65535)]
        public long Port {
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
        /// <para type="description">"The username for the HTTP Proxy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Username {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexProxySettingPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexProxySettingPolicy")]
    public class RemoveIntersightHyperflexProxySettingPolicy:RemoveCmdletBase
	{
		public RemoveIntersightHyperflexProxySettingPolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexProxySettingPolicy";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexHxapVirtualMachineNetworkInterface.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexHxapVirtualMachineNetworkInterface", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexHxapVirtualMachineNetworkInterface:GetCmdletBase
	{
		public GetIntersightHyperflexHxapVirtualMachineNetworkInterface()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexHxapVirtualMachineNetworkInterfaceList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexSysConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexSysConfigPolicy")]
    public class SetIntersightHyperflexSysConfigPolicy:SetCmdletBase
	{
		public SetIntersightHyperflexSysConfigPolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexSysConfigPolicy();
            MethodName = "UpdateHyperflexSysConfigPolicy";
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
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexClusterProfileRelationship> ClusterProfiles {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The DNS Search Domain Name. This setting applies to HyperFlex Data Platform 3.0 or later only."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^([a-zA-Z0-9]([a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?\\.)*[a-zA-Z]{2,63}$")]
        public string DnsDomainName {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> DnsServers {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> NtpServers {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
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
        /// <para type="description">"The timezone of the HyperFlex cluster's system clock.\n* `Pacific/Niue` - \n* `Pacific/Pago_Pago` - \n* `Pacific/Honolulu` - \n* `Pacific/Rarotonga` - \n* `Pacific/Tahiti` - \n* `Pacific/Marquesas` - \n* `America/Anchorage` - \n* `Pacific/Gambier` - \n* `America/Los_Angeles` - \n* `America/Tijuana` - \n* `America/Vancouver` - \n* `America/Whitehorse` - \n* `Pacific/Pitcairn` - \n* `America/Dawson_Creek` - \n* `America/Denver` - \n* `America/Edmonton` - \n* `America/Hermosillo` - \n* `America/Mazatlan` - \n* `America/Phoenix` - \n* `America/Yellowknife` - \n* `America/Belize` - \n* `America/Chicago` - \n* `America/Costa_Rica` - \n* `America/El_Salvador` - \n* `America/Guatemala` - \n* `America/Managua` - \n* `America/Mexico_City` - \n* `America/Regina` - \n* `America/Tegucigalpa` - \n* `America/Winnipeg` - \n* `Pacific/Galapagos` - \n* `America/Bogota` - \n* `America/Cancun` - \n* `America/Cayman` - \n* `America/Guayaquil` - \n* `America/Havana` - \n* `America/Iqaluit` - \n* `America/Jamaica` - \n* `America/Lima` - \n* `America/Nassau` - \n* `America/New_York` - \n* `America/Panama` - \n* `America/Port-au-Prince` - \n* `America/Rio_Branco` - \n* `America/Toronto` - \n* `Pacific/Easter` - \n* `America/Caracas` - \n* `America/Asuncion` - \n* `America/Barbados` - \n* `America/Boa_Vista` - \n* `America/Campo_Grande` - \n* `America/Cuiaba` - \n* `America/Curacao` - \n* `America/Grand_Turk` - \n* `America/Guyana` - \n* `America/Halifax` - \n* `America/La_Paz` - \n* `America/Manaus` - \n* `America/Martinique` - \n* `America/Port_of_Spain` - \n* `America/Porto_Velho` - \n* `America/Puerto_Rico` - \n* `America/Santo_Domingo` - \n* `America/Thule` - \n* `Atlantic/Bermuda` - \n* `America/St_Johns` - \n* `America/Araguaina` - \n* `America/Argentina/Buenos_Aires` - \n* `America/Bahia` - \n* `America/Belem` - \n* `America/Cayenne` - \n* `America/Fortaleza` - \n* `America/Godthab` - \n* `America/Maceio` - \n* `America/Miquelon` - \n* `America/Montevideo` - \n* `America/Paramaribo` - \n* `America/Recife` - \n* `America/Santiago` - \n* `America/Sao_Paulo` - \n* `Antarctica/Palmer` - \n* `Antarctica/Rothera` - \n* `Atlantic/Stanley` - \n* `America/Noronha` - \n* `Atlantic/South_Georgia` - \n* `America/Scoresbysund` - \n* `Atlantic/Azores` - \n* `Atlantic/Cape_Verde` - \n* `Africa/Abidjan` - \n* `Africa/Accra` - \n* `Africa/Bissau` - \n* `Africa/Casablanca` - \n* `Africa/El_Aaiun` - \n* `Africa/Monrovia` - \n* `America/Danmarkshavn` - \n* `Atlantic/Canary` - \n* `Atlantic/Faroe` - \n* `Atlantic/Reykjavik` - \n* `Etc/GMT` - \n* `Europe/Dublin` - \n* `Europe/Lisbon` - \n* `Europe/London` - \n* `Africa/Algiers` - \n* `Africa/Ceuta` - \n* `Africa/Lagos` - \n* `Africa/Ndjamena` - \n* `Africa/Tunis` - \n* `Africa/Windhoek` - \n* `Europe/Amsterdam` - \n* `Europe/Andorra` - \n* `Europe/Belgrade` - \n* `Europe/Berlin` - \n* `Europe/Brussels` - \n* `Europe/Budapest` - \n* `Europe/Copenhagen` - \n* `Europe/Gibraltar` - \n* `Europe/Luxembourg` - \n* `Europe/Madrid` - \n* `Europe/Malta` - \n* `Europe/Monaco` - \n* `Europe/Oslo` - \n* `Europe/Paris` - \n* `Europe/Prague` - \n* `Europe/Rome` - \n* `Europe/Stockholm` - \n* `Europe/Tirane` - \n* `Europe/Vienna` - \n* `Europe/Warsaw` - \n* `Europe/Zurich` - \n* `Africa/Cairo` - \n* `Africa/Johannesburg` - \n* `Africa/Maputo` - \n* `Africa/Tripoli` - \n* `Asia/Amman` - \n* `Asia/Beirut` - \n* `Asia/Damascus` - \n* `Asia/Gaza` - \n* `Asia/Jerusalem` - \n* `Asia/Nicosia` - \n* `Europe/Athens` - \n* `Europe/Bucharest` - \n* `Europe/Chisinau` - \n* `Europe/Helsinki` - \n* `Europe/Istanbul` - \n* `Europe/Kaliningrad` - \n* `Europe/Kiev` - \n* `Europe/Riga` - \n* `Europe/Sofia` - \n* `Europe/Tallinn` - \n* `Europe/Vilnius` - \n* `Africa/Khartoum` - \n* `Africa/Nairobi` - \n* `Antarctica/Syowa` - \n* `Asia/Baghdad` - \n* `Asia/Qatar` - \n* `Asia/Riyadh` - \n* `Europe/Minsk` - \n* `Europe/Moscow` - \n* `Asia/Tehran` - \n* `Asia/Baku` - \n* `Asia/Dubai` - \n* `Asia/Tbilisi` - \n* `Asia/Yerevan` - \n* `Europe/Samara` - \n* `Indian/Mahe` - \n* `Indian/Mauritius` - \n* `Indian/Reunion` - \n* `Asia/Kabul` - \n* `Antarctica/Mawson` - \n* `Asia/Aqtau` - \n* `Asia/Aqtobe` - \n* `Asia/Ashgabat` - \n* `Asia/Dushanbe` - \n* `Asia/Karachi` - \n* `Asia/Tashkent` - \n* `Asia/Yekaterinburg` - \n* `Indian/Kerguelen` - \n* `Indian/Maldives` - \n* `Asia/Calcutta` - \n* `Asia/Kolkata` - \n* `Asia/Colombo` - \n* `Asia/Katmandu` - \n* `Antarctica/Vostok` - \n* `Asia/Almaty` - \n* `Asia/Bishkek` - \n* `Asia/Dhaka` - \n* `Asia/Omsk` - \n* `Asia/Thimphu` - \n* `Indian/Chagos` - \n* `Asia/Rangoon` - \n* `Indian/Cocos` - \n* `Antarctica/Davis` - \n* `Asia/Bangkok` - \n* `Asia/Hovd` - \n* `Asia/Jakarta` - \n* `Asia/Krasnoyarsk` - \n* `Asia/Saigon` - \n* `Indian/Christmas` - \n* `Antarctica/Casey` - \n* `Asia/Brunei` - \n* `Asia/Choibalsan` - \n* `Asia/Hong_Kong` - \n* `Asia/Irkutsk` - \n* `Asia/Kuala_Lumpur` - \n* `Asia/Macau` - \n* `Asia/Makassar` - \n* `Asia/Manila` - \n* `Asia/Shanghai` - \n* `Asia/Singapore` - \n* `Asia/Taipei` - \n* `Asia/Ulaanbaatar` - \n* `Australia/Perth` - \n* `Asia/Pyongyang` - \n* `Asia/Dili` - \n* `Asia/Jayapura` - \n* `Asia/Seoul` - \n* `Asia/Tokyo` - \n* `Asia/Yakutsk` - \n* `Pacific/Palau` - \n* `Australia/Adelaide` - \n* `Australia/Darwin` - \n* `Antarctica/DumontDUrville` - \n* `Asia/Magadan` - \n* `Asia/Vladivostok` - \n* `Australia/Brisbane` - \n* `Australia/Hobart` - \n* `Australia/Sydney` - \n* `Pacific/Chuuk` - \n* `Pacific/Guam` - \n* `Pacific/Port_Moresby` - \n* `Pacific/Efate` - \n* `Pacific/Guadalcanal` - \n* `Pacific/Kosrae` - \n* `Pacific/Norfolk` - \n* `Pacific/Noumea` - \n* `Pacific/Pohnpei` - \n* `Asia/Kamchatka` - \n* `Pacific/Auckland` - \n* `Pacific/Fiji` - \n* `Pacific/Funafuti` - \n* `Pacific/Kwajalein` - \n* `Pacific/Majuro` - \n* `Pacific/Nauru` - \n* `Pacific/Tarawa` - \n* `Pacific/Wake` - \n* `Pacific/Wallis` - \n* `Pacific/Apia` - \n* `Pacific/Enderbury` - \n* `Pacific/Fakaofo` - \n* `Pacific/Tongatapu` - \n* `Pacific/Kiritimati` -"</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexSysConfigPolicy.TimezoneEnum Timezone {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexSysConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexSysConfigPolicy")]
    public class RemoveIntersightHyperflexSysConfigPolicy:RemoveCmdletBase
	{
		public RemoveIntersightHyperflexSysConfigPolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexSysConfigPolicy";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexVmSnapshotInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexVmSnapshotInfo", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexVmSnapshotInfo:GetCmdletBase
	{
		public GetIntersightHyperflexVmSnapshotInfo()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexVmSnapshotInfoList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexHealthCheckPackageChecksum.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexHealthCheckPackageChecksum")]
    public class SetIntersightHyperflexHealthCheckPackageChecksum:SetCmdletBase
	{
		public SetIntersightHyperflexHealthCheckPackageChecksum()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexHealthCheckPackageChecksum();
            MethodName = "UpdateHyperflexHealthCheckPackageChecksum";
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
        /// <para type="description">"SHA512 checksum of the health check package."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Checksum {
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
        /// <para type="description">"Name of the health check Debian package."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"HyperFlex health check Debian package file name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string PackageName {
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
        /// <para type="description">"Timestamp of last update of HyperFlex health check package checksum."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public DateTime Timestamp {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"HyperFlex health check Debian Package Version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexHealthCheckPackageChecksum.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexHealthCheckPackageChecksum")]
    public class RemoveIntersightHyperflexHealthCheckPackageChecksum:RemoveCmdletBase
	{
		public RemoveIntersightHyperflexHealthCheckPackageChecksum()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexHealthCheckPackageChecksum";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexHxapVirtualMachineNetworkInterface.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexHxapVirtualMachineNetworkInterface")]
    public class RemoveIntersightHyperflexHxapVirtualMachineNetworkInterface:RemoveCmdletBase
	{
		public RemoveIntersightHyperflexHxapVirtualMachineNetworkInterface()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexHxapVirtualMachineNetworkInterface";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexCluster.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexCluster")]
    public class SetIntersightHyperflexCluster:SetCmdletBase
	{
		public SetIntersightHyperflexCluster()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexCluster();
            MethodName = "UpdateHyperflexCluster";
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
        /// <para type="description">"A reference to a policyAbstractProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PolicyAbstractProfileRelationship AssociatedProfile {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hyperflexBaseCluster resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexBaseClusterRelationship> ChildClusters {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This can be a Storage or Compute cluster. A storage cluster contains storage nodes that are used to persist data. A compute cluster contains compute nodes that are used for executing business logic.\n* `Storage` - Cluster of storage nodes used to persist data.\n* `Compute` - Cluster of compute nodes used to execute business logic.\n* `Unknown` - This cluster type is Unknown. Expect Compute or Storage as valid values."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexCluster.ClusterPurposeEnum ClusterPurpose {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Identifies the broad type of the underlying hypervisor.\n* `ESXi` - The hypervisor running on the HyperFlex cluster is a Vmware ESXi hypervisor of any version.\n* `HyperFlexAp` - The hypervisor running on the HyperFlex cluster is Cisco HyperFlex Application Platform.\n* `Hyper-V` - The hypervisor running on the HyperFlex cluster is Microsoft Hyper-V.\n* `Unknown` - The hypervisor running on the HyperFlex cluster is not known."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexCluster.HypervisorTypeEnum HypervisorType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The capacity and usage information for memory on this cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationMemoryCapacity MemoryCapacity {
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
        /// <para type="description">"A reference to a hyperflexBaseCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexBaseClusterRelationship ParentCluster {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The capacity and usage information for CPU power on this cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationComputeCapacity ProcessorCapacity {
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
        /// <para type="description">"Total number of CPU cores in this cluster. It is a cumulative number across all hosts in the cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long TotalCores {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexVolume.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexVolume", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexVolume:GetCmdletBase
	{
		public GetIntersightHyperflexVolume()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexVolumeList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexHxapVirtualMachine.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexHxapVirtualMachine")]
    public class SetIntersightHyperflexHxapVirtualMachine:SetCmdletBase
	{
		public SetIntersightHyperflexHxapVirtualMachine()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexHxapVirtualMachine();
            MethodName = "UpdateHyperflexHxapVirtualMachine";
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<InfraMetaData> AffinitySelectors {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Denotes age or life time of the VM in nano seconds."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Age {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<InfraMetaData> AntiAffinitySelectors {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Time when this VM booted up."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public DateTime BootTime {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Provisioned CPU and memory information for this virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public InfraHardwareInfo Capacity {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexVmDisk> Disks {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Reason of the failure when VM is in failed state."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FailureReason {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Guest operating system details running on this machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationGuestInfo GuestInfo {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of hypervisor where the virtual machine is hosted for example ESXi.\n* `ESXi` - The hypervisor running on the HyperFlex cluster is a Vmware ESXi hypervisor of any version.\n* `HyperFlexAp` - The hypervisor running on the HyperFlex cluster is Cisco HyperFlex Application Platform.\n* `Hyper-V` - The hypervisor running on the HyperFlex cluster is Microsoft Hyper-V.\n* `Unknown` - The hypervisor running on the HyperFlex cluster is not known."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexHxapVirtualMachine.HypervisorTypeEnum HypervisorType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The internally generated identity of this VM. This entity is not manipulated by users. It aids in uniquely identifying the virtual machine object. For VMware, this is MOR (managed object reference)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Identity {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexVmInterface> Interfaces {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> IpAddress {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<InfraMetaData> Labels {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The capacity and usage information for memory on this virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationMemoryCapacity MemoryCapacity {
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
        /// <para type="description">"User-provided name to identify the virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number network interfaces associated with the virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long NetworkCount {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Power state of the virtual machine.\n* `Unknown` - The entity's power state is unknown.\n* `PoweringOn` - The entity is powering on.\n* `PoweredOn` - The entity is powered on.\n* `PoweringOff` - The entity is powering off.\n* `PoweredOff` - The entity is powered down.\n* `StandBy` - The entity is in standby mode.\n* `Paused` - The entity is in pause state.\n* `Rebooting` - The entity reboot is in progress.\n* `` - The entity's power state is not available."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexHxapVirtualMachine.PowerStateEnum PowerState {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The capacity and usage information for CPU power on this virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationComputeCapacity ProcessorCapacity {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Cloud platform, where the virtual machine is launched.\n* `Unknown` - Cloud provider is not known.\n* `VMwarevSphere` - Cloud provider named VMware vSphere.\n* `AmazonWebServices` - Cloud provider named Amazon Web Services.\n* `MicrosoftAzure` - Cloud provider named Microsoft Azure.\n* `GoogleCloudPlatform` - Cloud provider named Google Cloud Platform."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexHxapVirtualMachine.ProviderEnum Provider {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceRegistrationRelationship RegisteredDevice {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Denotes the VM start timestamp."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string StartTime {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The current state of the virtual machine. For example, starting, stopped, etc.\n* `None` - A place holder for the default value.\n* `Creating` - Virtual machine creation is in progress.\n* `Pending` - The virtual machine is preparing to enter the started state.\n* `Starting` - The virtual machine is starting.\n* `Started` - The virtual machine is running and ready for use.\n* `Stopping` - The virtual machine is preparing to be stopped.\n* `Stopped` - The virtual machine is shut down and cannot be used. The virtual machine can be started again at any time.\n* `Pausing` - The virtual machine is preparing to be paused.\n* `Paused` - The virtual machine enters into paused state due to low free disk space.\n* `Suspending` - The virtual machine is preparing to be suspended.\n* `Suspended` - Virtual machine is in sleep mode.When a virtual machine is suspended, the current state of theoperating system, and applications is saved, and the virtual machine put into a suspended mode.\n* `Deleting` - The virtual machine is preparing to be terminated.\n* `Terminated` - The virtual machine has been permanently deleted and cannot be started.\n* `Rebooting` - The virtual machine reboot is in progress.\n* `Error` - The deployment of virtual machine is failed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexHxapVirtualMachine.StateEnum State {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Status of virtual machine.\n* `Unknown` - Virtual machine state is not available.\n* `Running` - Virtual machine is running normally.\n* `Stopped` - Virtual machine has been stopped.\n* `WaitForLaunch` - Virtual machine is wating to be launched.\n* `Paused` - Virtual machine is currently paused.\n* `ImportInProgress` - Virtual machine image is being imported into the platform.\n* `ImportFailed` - Virtual machine image import operation failed.\n* `DiskCloneInProgress` - Disk clone operation for the virtual machine is in progress.\n* `DiskCloneFailed` - Disk clone operation for the virtual machine failed.\n* `Processing` - Virtual machine is being created.\n* `UnSchedulable` - Virtual machine cannot be scheduled to run, either due to insufficient resources or failure to match affinity specifications.\n* `Failed` - Some virtual machine operation has failed. More information is available as part of the results of the operation.\n* `` - Virtual machine status is not available."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexHxapVirtualMachine.StatusEnum Status {
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
        /// <para type="description">"The uuid of this virtual machine. The uuid is internally generated and not user specified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$")]
        public string Uuid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Time when this virtualmachine is created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public DateTime VmCreationTime {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexServerModel.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexServerModel", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexServerModel:GetCmdletBase
	{
		public GetIntersightHyperflexServerModel()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexServerModelList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexServerModel.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexServerModel")]
    public class NewIntersightHyperflexServerModel:NewCmdletBase
	{
		public NewIntersightHyperflexServerModel()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexServerModel();
            MethodName = "CreateHyperflexServerModel";
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
        /// <para type="description">"A reference to a hyperflexAppCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexAppCatalogRelationship AppCatalog {
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
        
        public List<HyperflexServerModelEntry> ServerModelEntries {
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
    /// <para type="synopsis">This is the cmdlet to Set HyperflexHxapVirtualDisk.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexHxapVirtualDisk")]
    public class SetIntersightHyperflexHxapVirtualDisk:SetCmdletBase
	{
		public SetIntersightHyperflexHxapVirtualDisk()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexHxapVirtualDisk();
            MethodName = "UpdateHyperflexHxapVirtualDisk";
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
        /// <para type="description">"A reference to a hyperflexHxapCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexHxapClusterRelationship Cluster {
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
        /// <para type="description">"Name of the storage disk. Name must be unique within a Datastore."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceRegistrationRelationship RegisteredDevice {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Disk size represented in bytes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Size {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Virtual disk used for cloning new disk."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SourceVirtualDisk {
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
    /// <para type="synopsis">This is the cmdlet to Set HyperflexHxdpVersion.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexHxdpVersion")]
    public class SetIntersightHyperflexHxdpVersion:SetCmdletBase
	{
		public SetIntersightHyperflexHxdpVersion()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexHxdpVersion();
            MethodName = "PatchHyperflexHxdpVersion";
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
        /// <para type="description">"A reference to a hyperflexAppCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexAppCatalogRelationship AppCatalog {
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
        // <summary>
        /// <para type="description">"The HyperFlex Data Platform version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexHxdpVersion.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexHxdpVersion")]
    public class RemoveIntersightHyperflexHxdpVersion:RemoveCmdletBase
	{
		public RemoveIntersightHyperflexHxdpVersion()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexHxdpVersion";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexHxapHostVswitch.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexHxapHostVswitch", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexHxapHostVswitch:GetCmdletBase
	{
		public GetIntersightHyperflexHxapHostVswitch()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexHxapHostVswitchList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexCluster.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexCluster", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexCluster:GetCmdletBase
	{
		public GetIntersightHyperflexCluster()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexClusterList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexHxapDatacenter.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexHxapDatacenter")]
    public class SetIntersightHyperflexHxapDatacenter:SetCmdletBase
	{
		public SetIntersightHyperflexHxapDatacenter()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexHxapDatacenter();
            MethodName = "UpdateHyperflexHxapDatacenter";
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
        /// <para type="description">"The internally generated identity of this placement. This entity is not manipulated by users. It aids in uniquely identifying the placement object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Identity {
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
        /// <para type="description">"Name of the virtual machine placement. It is the name of the VPC (Virtual Private Cloud) in case of AWS\nvirtual machine, and datacenter name in case of VMware virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceRegistrationRelationship RegisteredDevice {
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
        /// <para type="description">"The uuid of this placement. The uuid is internally generated and not user specified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$")]
        public string Uuid {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexHxapDatacenter.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexHxapDatacenter")]
    public class RemoveIntersightHyperflexHxapDatacenter:RemoveCmdletBase
	{
		public RemoveIntersightHyperflexHxapDatacenter()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexHxapDatacenter";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexClusterReplicationNetworkPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexClusterReplicationNetworkPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexClusterReplicationNetworkPolicy:GetCmdletBase
	{
		public GetIntersightHyperflexClusterReplicationNetworkPolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexClusterReplicationNetworkPolicyList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexClusterReplicationNetworkPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexClusterReplicationNetworkPolicy")]
    public class NewIntersightHyperflexClusterReplicationNetworkPolicy:NewCmdletBase
	{
		public NewIntersightHyperflexClusterReplicationNetworkPolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexClusterReplicationNetworkPolicy();
            MethodName = "CreateHyperflexClusterReplicationNetworkPolicy";
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
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexClusterProfileRelationship> ClusterProfiles {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Bandwidth for the Replication network in Mbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long ReplicationBandwidthMbps {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexIpAddrRange> ReplicationIpranges {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"MTU for the Replication network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1024, 1500)]
        public long ReplicationMtu {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VLAN for the Replication network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexNamedVlan ReplicationVlan {
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
    /// <para type="synopsis">This is the cmdlet to Get HyperflexHxdpVersion.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexHxdpVersion", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexHxdpVersion:GetCmdletBase
	{
		public GetIntersightHyperflexHxdpVersion()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexHxdpVersionList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexHxdpVersion.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexHxdpVersion")]
    public class NewIntersightHyperflexHxdpVersion:NewCmdletBase
	{
		public NewIntersightHyperflexHxdpVersion()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexHxdpVersion();
            MethodName = "CreateHyperflexHxdpVersion";
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
        /// <para type="description">"A reference to a hyperflexAppCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexAppCatalogRelationship AppCatalog {
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
        
        public List<MoTag> Tags {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The HyperFlex Data Platform version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexFeatureLimitInternal.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexFeatureLimitInternal")]
    public class SetIntersightHyperflexFeatureLimitInternal:SetCmdletBase
	{
		public SetIntersightHyperflexFeatureLimitInternal()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexFeatureLimitInternal();
            MethodName = "PatchHyperflexFeatureLimitInternal";
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
        /// <para type="description">"A reference to a hyperflexAppCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexAppCatalogRelationship AppCatalog {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexFeatureLimitEntry> FeatureLimitEntries {
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
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexFeatureLimitInternal.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexFeatureLimitInternal")]
    public class RemoveIntersightHyperflexFeatureLimitInternal:RemoveCmdletBase
	{
		public RemoveIntersightHyperflexFeatureLimitInternal()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexFeatureLimitInternal";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexDatastoreStatistic.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexDatastoreStatistic", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexDatastoreStatistic:GetCmdletBase
	{
		public GetIntersightHyperflexDatastoreStatistic()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexDatastoreStatisticList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexFeatureLimitExternal.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexFeatureLimitExternal", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexFeatureLimitExternal:GetCmdletBase
	{
		public GetIntersightHyperflexFeatureLimitExternal()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexFeatureLimitExternalList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexFeatureLimitExternal.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexFeatureLimitExternal")]
    public class NewIntersightHyperflexFeatureLimitExternal:NewCmdletBase
	{
		public NewIntersightHyperflexFeatureLimitExternal()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexFeatureLimitExternal();
            MethodName = "CreateHyperflexFeatureLimitExternal";
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
        /// <para type="description">"A reference to a hyperflexAppCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexAppCatalogRelationship AppCatalog {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexFeatureLimitEntry> FeatureLimitEntries {
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
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexHealthCheckDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexHealthCheckDefinition", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexHealthCheckDefinition:GetCmdletBase
	{
		public GetIntersightHyperflexHealthCheckDefinition()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexHealthCheckDefinitionList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexHealthCheckDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexHealthCheckDefinition")]
    public class NewIntersightHyperflexHealthCheckDefinition:NewCmdletBase
	{
		public NewIntersightHyperflexHealthCheckDefinition()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexHealthCheckDefinition();
            MethodName = "CreateHyperflexHealthCheckDefinition";
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
        /// <para type="description">"Category that the health check belongs to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Category {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Static information detailing the common causes for the health check failure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string CommonCauses {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Execution configuration fo the health check script."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Configuration {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the health check definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexHealthCheckScriptInfo> HealthCheckScriptInfos {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Static information detailing the health impact of the health check failure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string HealthImpact {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Internal name of the health check definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string InternalName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Minimum HyperFlex version that the check is supported on. Defaults to version 3.0.1."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string MinimumHyperFlexVersion {
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
        /// <para type="description">"Name of the health check definition."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Static information containing additional reference for the health check."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Reference {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Static information detailing the possible remediation actions that can be taken to remedy the health check failure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Resolution {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Execution mode of the health script on the HyperFlex cluster.\n* `ON_DEMAND` - Execute the health check on-demand.\n* `SCHEDULED` - Execute the health check on a scheduled interval."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexHealthCheckDefinition.ScriptExecutionModeEnum ScriptExecutionMode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates if the script needs to be executed on HyperFlex compute nodes. |\nTypically, scripts are only executed on the storage Nodes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool ScriptExecutionOnComputeNodes {
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
        /// <para type="description">"Indicates whether the health check is executed only on the leader node, or on all nodes in the HyperFlex cluster.\n* `EXECUTE_ON_LEADER_NODE` - Execute the health check script only on the HyperFlex cluster's leader node.\n* `EXECUTE_ON_ALL_NODES` - Execute health check on all nodes and aggregate the results.\n* `EXECUTE_ON_ALL_NODES_AND_AGGREGATE` - Execute the health check on all Nodes and perform custom aggregation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexHealthCheckDefinition.TargetExecutionTypeEnum TargetExecutionType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Health check script execution timeout."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Timeout {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> UnsupportedHyperFlexVersions {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexClusterReplicationNetworkPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexClusterReplicationNetworkPolicy")]
    public class SetIntersightHyperflexClusterReplicationNetworkPolicy:SetCmdletBase
	{
		public SetIntersightHyperflexClusterReplicationNetworkPolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexClusterReplicationNetworkPolicy();
            MethodName = "UpdateHyperflexClusterReplicationNetworkPolicy";
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
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexClusterProfileRelationship> ClusterProfiles {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Bandwidth for the Replication network in Mbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long ReplicationBandwidthMbps {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexIpAddrRange> ReplicationIpranges {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"MTU for the Replication network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1024, 1500)]
        public long ReplicationMtu {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VLAN for the Replication network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexNamedVlan ReplicationVlan {
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
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexClusterReplicationNetworkPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexClusterReplicationNetworkPolicy")]
    public class RemoveIntersightHyperflexClusterReplicationNetworkPolicy:RemoveCmdletBase
	{
		public RemoveIntersightHyperflexClusterReplicationNetworkPolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexClusterReplicationNetworkPolicy";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexAlarm.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexAlarm", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexAlarm:GetCmdletBase
	{
		public GetIntersightHyperflexAlarm()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexAlarmList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexExtIscsiStoragePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexExtIscsiStoragePolicy")]
    public class SetIntersightHyperflexExtIscsiStoragePolicy:SetCmdletBase
	{
		public SetIntersightHyperflexExtIscsiStoragePolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexExtIscsiStoragePolicy();
            MethodName = "UpdateHyperflexExtIscsiStoragePolicy";
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
        /// <para type="description">"Enable or disable external FCoE storage configuration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool AdminState {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexClusterProfileRelationship> ClusterProfiles {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VLAN for the primary Fabric Interconnect external FCoE storage traffic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexNamedVlan ExtaTraffic {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VLAN for the secondary Fabric Interconnect external FCoE storage traffic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexNamedVlan ExtbTraffic {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
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
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexExtIscsiStoragePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexExtIscsiStoragePolicy")]
    public class RemoveIntersightHyperflexExtIscsiStoragePolicy:RemoveCmdletBase
	{
		public RemoveIntersightHyperflexExtIscsiStoragePolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexExtIscsiStoragePolicy";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexHxapCluster.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexHxapCluster")]
    public class SetIntersightHyperflexHxapCluster:SetCmdletBase
	{
		public SetIntersightHyperflexHxapCluster()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexHxapCluster();
            MethodName = "UpdateHyperflexHxapCluster";
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
        /// <para type="description">"A reference to a policyAbstractProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PolicyAbstractProfileRelationship AssociatedProfile {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hyperflexBaseCluster resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexBaseClusterRelationship> ChildClusters {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"This can be a Storage or Compute cluster. A storage cluster contains storage nodes that are used to persist data. A compute cluster contains compute nodes that are used for executing business logic.\n* `Storage` - Cluster of storage nodes used to persist data.\n* `Compute` - Cluster of compute nodes used to execute business logic.\n* `Unknown` - This cluster type is Unknown. Expect Compute or Storage as valid values."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexHxapCluster.ClusterPurposeEnum ClusterPurpose {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"CPU oversubscription factor configured on the cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public double ConfiguredCpuOverSubFactor {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"CPU allocation details of the cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationCpuAllocation CpuAllocation {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Current oversubscription factor of the cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public double CurrentCpuOverSubFactor {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Datacenter to which the cluster belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DatacenterName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Reason for the failure when cluster is in failed state."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FailureReason {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Hypervisor version of HyperFlex compute cluster along with build number."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string HypervisorBuild {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Identifies the broad type of the underlying hypervisor.\n* `ESXi` - The hypervisor running on the HyperFlex cluster is a Vmware ESXi hypervisor of any version.\n* `HyperFlexAp` - The hypervisor running on the HyperFlex cluster is Cisco HyperFlex Application Platform.\n* `Hyper-V` - The hypervisor running on the HyperFlex cluster is Microsoft Hyper-V.\n* `Unknown` - The hypervisor running on the HyperFlex cluster is not known."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexHxapCluster.HypervisorTypeEnum HypervisorType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Management IP Address of the cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ManagementIpAddress {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Memory allocation details of the cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationMemoryAllocation MemoryAllocation {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The capacity and usage information for memory on this cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationMemoryCapacity MemoryCapacity {
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
        /// <para type="description">"A reference to a hyperflexBaseCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexBaseClusterRelationship ParentCluster {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The capacity and usage information for CPU power on this cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationComputeCapacity ProcessorCapacity {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceRegistrationRelationship RegisteredDevice {
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
        /// <para type="description">"Total number of CPU cores in this cluster. It is a cumulative number across all hosts in the cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long TotalCores {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexHxapCluster.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexHxapCluster")]
    public class RemoveIntersightHyperflexHxapCluster:RemoveCmdletBase
	{
		public RemoveIntersightHyperflexHxapCluster()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexHxapCluster";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexVmBackupInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexVmBackupInfo", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexVmBackupInfo:GetCmdletBase
	{
		public GetIntersightHyperflexVmBackupInfo()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexVmBackupInfoList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexBackupCluster.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexBackupCluster", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexBackupCluster:GetCmdletBase
	{
		public GetIntersightHyperflexBackupCluster()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexBackupClusterList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexDataProtectionPeer.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexDataProtectionPeer", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexDataProtectionPeer:GetCmdletBase
	{
		public GetIntersightHyperflexDataProtectionPeer()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexDataProtectionPeerList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexHxapDvswitch.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexHxapDvswitch", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexHxapDvswitch:GetCmdletBase
	{
		public GetIntersightHyperflexHxapDvswitch()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexHxapDvswitchList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexExtIscsiStoragePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexExtIscsiStoragePolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexExtIscsiStoragePolicy:GetCmdletBase
	{
		public GetIntersightHyperflexExtIscsiStoragePolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexExtIscsiStoragePolicyList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexExtIscsiStoragePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexExtIscsiStoragePolicy")]
    public class NewIntersightHyperflexExtIscsiStoragePolicy:NewCmdletBase
	{
		public NewIntersightHyperflexExtIscsiStoragePolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexExtIscsiStoragePolicy();
            MethodName = "CreateHyperflexExtIscsiStoragePolicy";
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
        /// <para type="description">"Enable or disable external FCoE storage configuration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool AdminState {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexClusterProfileRelationship> ClusterProfiles {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VLAN for the primary Fabric Interconnect external FCoE storage traffic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexNamedVlan ExtaTraffic {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VLAN for the secondary Fabric Interconnect external FCoE storage traffic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexNamedVlan ExtbTraffic {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
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
    /// <para type="synopsis">This is the cmdlet to Get HyperflexLicense.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexLicense", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexLicense:GetCmdletBase
	{
		public GetIntersightHyperflexLicense()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexLicenseList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexSoftwareVersionPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexSoftwareVersionPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexSoftwareVersionPolicy:GetCmdletBase
	{
		public GetIntersightHyperflexSoftwareVersionPolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexSoftwareVersionPolicyList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexSoftwareVersionPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexSoftwareVersionPolicy")]
    public class NewIntersightHyperflexSoftwareVersionPolicy:NewCmdletBase
	{
		public NewIntersightHyperflexSoftwareVersionPolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexSoftwareVersionPolicy();
            MethodName = "CreateHyperflexSoftwareVersionPolicy";
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
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexClusterProfileRelationship> ClusterProfiles {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Desired HyperFlex Data Platform software version to apply on the HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string HxdpVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Desired  hypervisor version to apply for all the nodes on the HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string HypervisorVersion {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Desired server firmware version to apply on the HyperFlex Cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|(^3\\.[0-9]\\([1-9][a-z]\\)$|^[4-9]\\.[1-9]\\([1-9][a-z]\\)$|^4\\.0\\([1-3][a-z]\\)$|^4\\.0\\(4[d-z]\\)$|4\\.0\\([5-9][a-z]\\)$)")]
        public string ServerFirmwareVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexServerFirmwareVersionInfo> ServerFirmwareVersions {
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> UpgradeTypes {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexNode.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexNode", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexNode:GetCmdletBase
	{
		public GetIntersightHyperflexNode()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexNodeList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexClusterBackupPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexClusterBackupPolicy")]
    public class SetIntersightHyperflexClusterBackupPolicy:SetCmdletBase
	{
		public SetIntersightHyperflexClusterBackupPolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexClusterBackupPolicy();
            MethodName = "UpdateHyperflexClusterBackupPolicy";
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
        /// <para type="description">"Backup datastore name prefix used during the auto creation of the datastore. All VMs created in this datastore will be automatically backed up."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string BackupDataStoreName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Replication data store size in backupDataStoreSizeUnit."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long BackupDataStoreSize {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Replication data store size."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string BackupDataStoreSizeUnit {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexClusterRelationship BackupTarget {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexClusterProfileRelationship> ClusterProfiles {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Replication cluster pairing name prefix."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ReplicationPairNamePrefix {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Backup policy replication schedule."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexReplicationSchedule ReplicationSchedule {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of snapshots that will be retained as part of the Multi Point in Time support."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 30)]
        public long SnapshotRetentionCount {
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
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexClusterBackupPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexClusterBackupPolicy")]
    public class RemoveIntersightHyperflexClusterBackupPolicy:RemoveCmdletBase
	{
		public RemoveIntersightHyperflexClusterBackupPolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexClusterBackupPolicy";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexVmImportOperation.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexVmImportOperation", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexVmImportOperation:GetCmdletBase
	{
		public GetIntersightHyperflexVmImportOperation()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexVmImportOperationList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexVmImportOperation.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexVmImportOperation")]
    public class NewIntersightHyperflexVmImportOperation:NewCmdletBase
	{
		public NewIntersightHyperflexVmImportOperation()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexVmImportOperation();
            MethodName = "CreateHyperflexVmImportOperation";
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
        
        public AssetDeviceRegistrationRelationship DeviceMoid {
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
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
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
    /// <para type="synopsis">This is the cmdlet to Set HyperflexNodeProfile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexNodeProfile")]
    public class SetIntersightHyperflexNodeProfile:SetCmdletBase
	{
		public SetIntersightHyperflexNodeProfile()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexNodeProfile();
            MethodName = "UpdateHyperflexNodeProfile";
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
        /// <para type="description">"A reference to a computePhysical resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputePhysicalRelationship AssignedServer {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexClusterProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexClusterProfileRelationship ClusterProfile {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IP address for storage data network (Controller VM interface)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string HxdpDataIp {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IP address for HyperFlex management network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string HxdpMgmtIp {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IP address for hypervisor control such as VM migration or pod management."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string HypervisorControlIp {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IP address for storage data network (Hypervisor interface)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string HypervisorDataIp {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IP address for Hypervisor management network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string HypervisorMgmtIp {
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
        /// <para type="description">"Name of the profile instance or profile template."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a policyAbstractProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PolicyAbstractProfileRelationship SrcTemplate {
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
        /// <para type="description">"Defines the type of the profile. Accepted values are instance or template.\n* `instance` - The profile defines the configuration for a specific instance of a target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexNodeProfile.TypeEnum Type {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexNodeProfile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexNodeProfile")]
    public class RemoveIntersightHyperflexNodeProfile:RemoveCmdletBase
	{
		public RemoveIntersightHyperflexNodeProfile()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexNodeProfile";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexWitnessConfiguration.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexWitnessConfiguration", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexWitnessConfiguration:GetCmdletBase
	{
		public GetIntersightHyperflexWitnessConfiguration()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexWitnessConfigurationList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexClusterStoragePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexClusterStoragePolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexClusterStoragePolicy:GetCmdletBase
	{
		public GetIntersightHyperflexClusterStoragePolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexClusterStoragePolicyList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexClusterStoragePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexClusterStoragePolicy")]
    public class NewIntersightHyperflexClusterStoragePolicy:NewCmdletBase
	{
		public NewIntersightHyperflexClusterStoragePolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexClusterStoragePolicy();
            MethodName = "CreateHyperflexClusterStoragePolicy";
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
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexClusterProfileRelationship> ClusterProfiles {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If enabled, formats existing disk partitions (destroys all user data)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool DiskPartitionCleanup {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enable or disable Logical Availability Zones (LAZ). If enabled, HyperFlex Data Platform automatically selects and groups nodes into different availability zones. For HyperFlex Data Platform versions prior to 3.0 release, this setting does not apply. For HyperFlex Data Platform versions 3.0 or higher, this setting is only applicable to Fabric Interconnect attached HyperFlex systems with 8 or more converged nodes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexLogicalAvailabilityZone LogicalAvalabilityZoneConfig {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
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
        /// <para type="description">"Enable or disable VDI optimization (hybrid HyperFlex systems only)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool VdiOptimization {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexHxapNetwork.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexHxapNetwork", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexHxapNetwork:GetCmdletBase
	{
		public GetIntersightHyperflexHxapNetwork()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexHxapNetworkList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexServerFirmwareVersion.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexServerFirmwareVersion", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexServerFirmwareVersion:GetCmdletBase
	{
		public GetIntersightHyperflexServerFirmwareVersion()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexServerFirmwareVersionList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexServerFirmwareVersion.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexServerFirmwareVersion")]
    public class NewIntersightHyperflexServerFirmwareVersion:NewCmdletBase
	{
		public NewIntersightHyperflexServerFirmwareVersion()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexServerFirmwareVersion();
            MethodName = "CreateHyperflexServerFirmwareVersion";
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
        /// <para type="description">"A reference to a hyperflexAppCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexAppCatalogRelationship AppCatalog {
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
        /// <para type="description">"An array of relationships to hyperflexServerFirmwareVersionEntry resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexServerFirmwareVersionEntryRelationship> ServerFirmwareVersionEntries {
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
    /// <para type="synopsis">This is the cmdlet to Set HyperflexClusterReplicationNetworkPolicyDeployment.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexClusterReplicationNetworkPolicyDeployment")]
    public class SetIntersightHyperflexClusterReplicationNetworkPolicyDeployment:SetCmdletBase
	{
		public SetIntersightHyperflexClusterReplicationNetworkPolicyDeployment()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexClusterReplicationNetworkPolicyDeployment();
            MethodName = "UpdateHyperflexClusterReplicationNetworkPolicyDeployment";
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
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexClusterRelationship Cluster {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"True if record created by discovery on HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Discovered {
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
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexIpAddrRange> ReplicationIpranges {
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
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexClusterReplicationNetworkPolicyDeployment.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexClusterReplicationNetworkPolicyDeployment")]
    public class RemoveIntersightHyperflexClusterReplicationNetworkPolicyDeployment:RemoveCmdletBase
	{
		public RemoveIntersightHyperflexClusterReplicationNetworkPolicyDeployment()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexClusterReplicationNetworkPolicyDeployment";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexClusterReplicationNetworkPolicyDeployment.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexClusterReplicationNetworkPolicyDeployment", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexClusterReplicationNetworkPolicyDeployment:GetCmdletBase
	{
		public GetIntersightHyperflexClusterReplicationNetworkPolicyDeployment()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexClusterReplicationNetworkPolicyDeploymentList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexClusterReplicationNetworkPolicyDeployment.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexClusterReplicationNetworkPolicyDeployment")]
    public class NewIntersightHyperflexClusterReplicationNetworkPolicyDeployment:NewCmdletBase
	{
		public NewIntersightHyperflexClusterReplicationNetworkPolicyDeployment()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexClusterReplicationNetworkPolicyDeployment();
            MethodName = "CreateHyperflexClusterReplicationNetworkPolicyDeployment";
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
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexClusterRelationship Cluster {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"True if record created by discovery on HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Discovered {
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
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexIpAddrRange> ReplicationIpranges {
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
    /// <para type="synopsis">This is the cmdlet to Set HyperflexHealthCheckDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexHealthCheckDefinition")]
    public class SetIntersightHyperflexHealthCheckDefinition:SetCmdletBase
	{
		public SetIntersightHyperflexHealthCheckDefinition()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexHealthCheckDefinition();
            MethodName = "UpdateHyperflexHealthCheckDefinition";
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
        /// <para type="description">"Category that the health check belongs to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Category {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Static information detailing the common causes for the health check failure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string CommonCauses {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Execution configuration fo the health check script."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Configuration {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the health check definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexHealthCheckScriptInfo> HealthCheckScriptInfos {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Static information detailing the health impact of the health check failure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string HealthImpact {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Internal name of the health check definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string InternalName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Minimum HyperFlex version that the check is supported on. Defaults to version 3.0.1."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string MinimumHyperFlexVersion {
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
        /// <para type="description">"Name of the health check definition."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Static information containing additional reference for the health check."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Reference {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Static information detailing the possible remediation actions that can be taken to remedy the health check failure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Resolution {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Execution mode of the health script on the HyperFlex cluster.\n* `ON_DEMAND` - Execute the health check on-demand.\n* `SCHEDULED` - Execute the health check on a scheduled interval."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexHealthCheckDefinition.ScriptExecutionModeEnum ScriptExecutionMode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates if the script needs to be executed on HyperFlex compute nodes. |\nTypically, scripts are only executed on the storage Nodes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool ScriptExecutionOnComputeNodes {
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
        /// <para type="description">"Indicates whether the health check is executed only on the leader node, or on all nodes in the HyperFlex cluster.\n* `EXECUTE_ON_LEADER_NODE` - Execute the health check script only on the HyperFlex cluster's leader node.\n* `EXECUTE_ON_ALL_NODES` - Execute health check on all nodes and aggregate the results.\n* `EXECUTE_ON_ALL_NODES_AND_AGGREGATE` - Execute the health check on all Nodes and perform custom aggregation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexHealthCheckDefinition.TargetExecutionTypeEnum TargetExecutionType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Health check script execution timeout."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Timeout {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> UnsupportedHyperFlexVersions {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexHealthCheckDefinition.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexHealthCheckDefinition")]
    public class RemoveIntersightHyperflexHealthCheckDefinition:RemoveCmdletBase
	{
		public RemoveIntersightHyperflexHealthCheckDefinition()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexHealthCheckDefinition";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexClusterProfile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexClusterProfile", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexClusterProfile:GetCmdletBase
	{
		public GetIntersightHyperflexClusterProfile()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexClusterProfileList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexClusterProfile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexClusterProfile")]
    public class NewIntersightHyperflexClusterProfile:NewCmdletBase
	{
		public NewIntersightHyperflexClusterProfile()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexClusterProfile();
            MethodName = "CreateHyperflexClusterProfile";
		}
        // <summary>
        /// <para type="description">"User initiated action. Each profile type has its own supported actions. For HyperFlex cluster profile, the supported actions are -- Validate, Deploy, Continue, Retry, Abort, Unassign For server profile, the support actions are -- Deploy, Unassign."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Action {
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
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexClusterRelationship AssociatedCluster {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexAutoSupportPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexAutoSupportPolicyRelationship AutoSupport {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexClusterNetworkPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexClusterNetworkPolicyRelationship ClusterNetwork {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexClusterStoragePolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexClusterStoragePolicyRelationship ClusterStorage {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The configuration state and results of the last configuration operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PolicyConfigContext ConfigContext {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The storage data IP address for the HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string DataIpAddress {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexExtFcStoragePolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexExtFcStoragePolicyRelationship ExtFcStorage {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexExtIscsiStoragePolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexExtIscsiStoragePolicyRelationship ExtIscsiStorage {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The node name prefix that is used to automatically generate the default hostname for each server.\nA dash (-) will be appended to the prefix followed by the node number to form a hostname.\nThis default naming scheme can be manually overridden in the node configuration.\nThe maximum length of a prefix is 60, must only contain alphanumeric characters or dash (-), and must\nstart with an alphanumeric character."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9][a-zA-Z0-9-]{1,59}$")]
        public string HostNamePrefix {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a commHttpProxyPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public CommHttpProxyPolicyRelationship Httpproxypolicy {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The hypervisor control virtual IP address for the HyperFlex compute cluster that is used for node/pod management."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string HypervisorControlIpAddress {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The hypervisor type for the HyperFlex cluster.\n* `ESXi` - The hypervisor running on the HyperFlex cluster is a Vmware ESXi hypervisor of any version.\n* `HyperFlexAp` - The hypervisor running on the HyperFlex cluster is Cisco HyperFlex Application Platform.\n* `Hyper-V` - The hypervisor running on the HyperFlex cluster is Microsoft Hyper-V.\n* `Unknown` - The hypervisor running on the HyperFlex cluster is not known."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexClusterProfile.HypervisorTypeEnum HypervisorType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexLocalCredentialPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexLocalCredentialPolicyRelationship LocalCredential {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The MAC address prefix in the form of 00:25:B5:XX."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^00:25:B5:[0-9a-fA-F]{2}$")]
        public string MacAddressPrefix {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The management IP address for the HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string MgmtIpAddress {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The management platform for the HyperFlex cluster.\n* `FI` - The host servers used in the cluster deployment are managed by a UCS Fabric Interconnect.\n* `EDGE` - The host servers used in the cluster deployment are standalone severs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexClusterProfile.MgmtPlatformEnum MgmtPlatform {
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
        /// <para type="description">"Name of the profile instance or profile template."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexNodeConfigPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexNodeConfigPolicyRelationship NodeConfig {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hyperflexNodeProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexNodeProfileRelationship> NodeProfileConfig {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to policyAbstractPolicy resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<PolicyAbstractPolicyRelationship> PolicyBucket {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexProxySettingPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexProxySettingPolicyRelationship ProxySetting {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of copies of each data block written."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Replication {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexSoftwareVersionPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexSoftwareVersionPolicyRelationship SoftwareVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a policyAbstractProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PolicyAbstractProfileRelationship SrcTemplate {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The auxiliary storage IP address for the HyperFlex cluster. For two node clusters, this is the IP address of the auxiliary ZK controller."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string StorageClusterAuxiliaryIp {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The VLAN for the HyperFlex storage data traffic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexNamedVlan StorageDataVlan {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The storage type used for the HyperFlex cluster (HyperFlex Storage or 3rd party).\n* `HyperFlexDp` - The type of storage is HyperFlex Data Platform.\n* `ThirdParty` - The type of storage is 3rd Party Storage (PureStorage, etc..)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexClusterProfile.StorageTypeEnum StorageType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexSysConfigPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexSysConfigPolicyRelationship SysConfig {
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
        /// <para type="description">"Defines the type of the profile. Accepted values are instance or template.\n* `instance` - The profile defines the configuration for a specific instance of a target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexClusterProfile.TypeEnum Type {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexUcsmConfigPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexUcsmConfigPolicyRelationship UcsmConfig {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexVcenterConfigPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexVcenterConfigPolicyRelationship VcenterConfig {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The WWxN prefix in the form of 20:00:00:25:B5:XX."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^20:00:00:25:B5:[0-9a-fA-F]{2}$")]
        public string WwxnPrefix {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexClusterBackupPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexClusterBackupPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexClusterBackupPolicy:GetCmdletBase
	{
		public GetIntersightHyperflexClusterBackupPolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexClusterBackupPolicyList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexClusterBackupPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexClusterBackupPolicy")]
    public class NewIntersightHyperflexClusterBackupPolicy:NewCmdletBase
	{
		public NewIntersightHyperflexClusterBackupPolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexClusterBackupPolicy();
            MethodName = "CreateHyperflexClusterBackupPolicy";
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
        /// <para type="description">"Backup datastore name prefix used during the auto creation of the datastore. All VMs created in this datastore will be automatically backed up."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string BackupDataStoreName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Replication data store size in backupDataStoreSizeUnit."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long BackupDataStoreSize {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Replication data store size."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string BackupDataStoreSizeUnit {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexClusterRelationship BackupTarget {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexClusterProfileRelationship> ClusterProfiles {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Replication cluster pairing name prefix."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ReplicationPairNamePrefix {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Backup policy replication schedule."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexReplicationSchedule ReplicationSchedule {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of snapshots that will be retained as part of the Multi Point in Time support."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 30)]
        public long SnapshotRetentionCount {
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
    /// <para type="synopsis">This is the cmdlet to Set HyperflexAppCatalog.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexAppCatalog")]
    public class SetIntersightHyperflexAppCatalog:SetCmdletBase
	{
		public SetIntersightHyperflexAppCatalog()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexAppCatalog();
            MethodName = "PatchHyperflexAppCatalog";
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
        /// <para type="description">"A reference to a hyperflexFeatureLimitExternal resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexFeatureLimitExternalRelationship FeatureLimitExternal {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexFeatureLimitInternal resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexFeatureLimitInternalRelationship FeatureLimitInternal {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hyperflexHxdpVersion resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexHxdpVersionRelationship> HxdpVersions {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hyperflexCapabilityInfo resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexCapabilityInfoRelationship> HyperflexCapabilityInfos {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hclHyperflexSoftwareCompatibilityInfo resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HclHyperflexSoftwareCompatibilityInfoRelationship> HyperflexSoftwareCompatibilityInfos {
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
        /// <para type="description">"A reference to a hyperflexServerFirmwareVersion resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexServerFirmwareVersionRelationship ServerFirmwareVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexServerModel resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexServerModelRelationship ServerModel {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hyperflexSoftwareDistributionEntry resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexSoftwareDistributionEntryRelationship> SoftwareDistributions {
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
        /// <para type="description">"The catalog version used in HyperFlex cluster configuration service."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexAppCatalog.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexAppCatalog")]
    public class RemoveIntersightHyperflexAppCatalog:RemoveCmdletBase
	{
		public RemoveIntersightHyperflexAppCatalog()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexAppCatalog";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexCiscoHypervisorManager.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexCiscoHypervisorManager", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexCiscoHypervisorManager:GetCmdletBase
	{
		public GetIntersightHyperflexCiscoHypervisorManager()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexCiscoHypervisorManagerList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexCiscoHypervisorManager.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexCiscoHypervisorManager")]
    public class NewIntersightHyperflexCiscoHypervisorManager:NewCmdletBase
	{
		public NewIntersightHyperflexCiscoHypervisorManager()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexCiscoHypervisorManager();
            MethodName = "CreateHyperflexCiscoHypervisorManager";
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The user provided name for the hypervisor manager. For example, vCenterIreland. Usually, this name is subject to manipulation by the user. It is not the identity of the hypervisor."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]+[\\sa-zA-Z0-9_-]{1,32}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceRegistrationRelationship RegisteredDevice {
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
    /// <para type="synopsis">This is the cmdlet to Get HyperflexHxapDvUplink.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexHxapDvUplink", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexHxapDvUplink:GetCmdletBase
	{
		public GetIntersightHyperflexHxapDvUplink()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexHxapDvUplinkList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexHxapCluster.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexHxapCluster", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexHxapCluster:GetCmdletBase
	{
		public GetIntersightHyperflexHxapCluster()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexHxapClusterList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexFeatureLimitInternal.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexFeatureLimitInternal", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexFeatureLimitInternal:GetCmdletBase
	{
		public GetIntersightHyperflexFeatureLimitInternal()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexFeatureLimitInternalList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexFeatureLimitInternal.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexFeatureLimitInternal")]
    public class NewIntersightHyperflexFeatureLimitInternal:NewCmdletBase
	{
		public NewIntersightHyperflexFeatureLimitInternal()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexFeatureLimitInternal();
            MethodName = "CreateHyperflexFeatureLimitInternal";
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
        /// <para type="description">"A reference to a hyperflexAppCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexAppCatalogRelationship AppCatalog {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexFeatureLimitEntry> FeatureLimitEntries {
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
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexAppCatalog.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexAppCatalog", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexAppCatalog:GetCmdletBase
	{
		public GetIntersightHyperflexAppCatalog()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexAppCatalogList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexAppCatalog.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexAppCatalog")]
    public class NewIntersightHyperflexAppCatalog:NewCmdletBase
	{
		public NewIntersightHyperflexAppCatalog()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexAppCatalog();
            MethodName = "CreateHyperflexAppCatalog";
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
        /// <para type="description">"A reference to a hyperflexFeatureLimitExternal resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexFeatureLimitExternalRelationship FeatureLimitExternal {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexFeatureLimitInternal resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexFeatureLimitInternalRelationship FeatureLimitInternal {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hyperflexHxdpVersion resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexHxdpVersionRelationship> HxdpVersions {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hyperflexCapabilityInfo resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexCapabilityInfoRelationship> HyperflexCapabilityInfos {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hclHyperflexSoftwareCompatibilityInfo resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HclHyperflexSoftwareCompatibilityInfoRelationship> HyperflexSoftwareCompatibilityInfos {
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
        /// <para type="description">"A reference to a hyperflexServerFirmwareVersion resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexServerFirmwareVersionRelationship ServerFirmwareVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexServerModel resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexServerModelRelationship ServerModel {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hyperflexSoftwareDistributionEntry resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexSoftwareDistributionEntryRelationship> SoftwareDistributions {
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
        /// <para type="description">"The catalog version used in HyperFlex cluster configuration service."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexClusterStoragePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexClusterStoragePolicy")]
    public class SetIntersightHyperflexClusterStoragePolicy:SetCmdletBase
	{
		public SetIntersightHyperflexClusterStoragePolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexClusterStoragePolicy();
            MethodName = "PatchHyperflexClusterStoragePolicy";
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
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexClusterProfileRelationship> ClusterProfiles {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"If enabled, formats existing disk partitions (destroys all user data)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool DiskPartitionCleanup {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enable or disable Logical Availability Zones (LAZ). If enabled, HyperFlex Data Platform automatically selects and groups nodes into different availability zones. For HyperFlex Data Platform versions prior to 3.0 release, this setting does not apply. For HyperFlex Data Platform versions 3.0 or higher, this setting is only applicable to Fabric Interconnect attached HyperFlex systems with 8 or more converged nodes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexLogicalAvailabilityZone LogicalAvalabilityZoneConfig {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
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
        /// <para type="description">"Enable or disable VDI optimization (hybrid HyperFlex systems only)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool VdiOptimization {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexClusterStoragePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexClusterStoragePolicy")]
    public class RemoveIntersightHyperflexClusterStoragePolicy:RemoveCmdletBase
	{
		public RemoveIntersightHyperflexClusterStoragePolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexClusterStoragePolicy";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexAutoSupportPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexAutoSupportPolicy")]
    public class SetIntersightHyperflexAutoSupportPolicy:SetCmdletBase
	{
		public SetIntersightHyperflexAutoSupportPolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexAutoSupportPolicy();
            MethodName = "UpdateHyperflexAutoSupportPolicy";
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
        /// <para type="description">"Enable or disable Auto-Support."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool AdminState {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexClusterProfileRelationship> ClusterProfiles {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The recipient email address for support tickets."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$")]
        public string ServiceTicketReceipient {
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
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexAutoSupportPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexAutoSupportPolicy")]
    public class RemoveIntersightHyperflexAutoSupportPolicy:RemoveCmdletBase
	{
		public RemoveIntersightHyperflexAutoSupportPolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexAutoSupportPolicy";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexAutoSupportPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexAutoSupportPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexAutoSupportPolicy:GetCmdletBase
	{
		public GetIntersightHyperflexAutoSupportPolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexAutoSupportPolicyList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexAutoSupportPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexAutoSupportPolicy")]
    public class NewIntersightHyperflexAutoSupportPolicy:NewCmdletBase
	{
		public NewIntersightHyperflexAutoSupportPolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexAutoSupportPolicy();
            MethodName = "CreateHyperflexAutoSupportPolicy";
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
        /// <para type="description">"Enable or disable Auto-Support."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool AdminState {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexClusterProfileRelationship> ClusterProfiles {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The recipient email address for support tickets."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$")]
        public string ServiceTicketReceipient {
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
    /// <para type="synopsis">This is the cmdlet to Set HyperflexServerFirmwareVersionEntry.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexServerFirmwareVersionEntry")]
    public class SetIntersightHyperflexServerFirmwareVersionEntry:SetCmdletBase
	{
		public SetIntersightHyperflexServerFirmwareVersionEntry()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexServerFirmwareVersionEntry();
            MethodName = "UpdateHyperflexServerFirmwareVersionEntry";
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
        /// <para type="description">"The conditions that must be satisfied before applying the AppSetting."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexAppSettingConstraint Constraint {
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
        /// <para type="description">"A reference to a hyperflexServerFirmwareVersion resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexServerFirmwareVersionRelationship ServerFirmwareVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The server platform type that is applicable for the server firmware bundle version.\n* `M5` - M5 generation of UCS server.\n* `M3` - M3 generation of UCS server.\n* `M4` - M4 generation of UCS server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexServerFirmwareVersionEntry.ServerPlatformEnum ServerPlatform {
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
        /// <para type="description">"The server firmware bundle version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("(^3\\.[1-9]\\([1-9][a-z]\\)$|^[4-9]\\.[0-9]\\([1-9][a-z]\\)$)")]
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexServerFirmwareVersionEntry.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexServerFirmwareVersionEntry")]
    public class RemoveIntersightHyperflexServerFirmwareVersionEntry:RemoveCmdletBase
	{
		public RemoveIntersightHyperflexServerFirmwareVersionEntry()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexServerFirmwareVersionEntry";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexProxySettingPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexProxySettingPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexProxySettingPolicy:GetCmdletBase
	{
		public GetIntersightHyperflexProxySettingPolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexProxySettingPolicyList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexProxySettingPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexProxySettingPolicy")]
    public class NewIntersightHyperflexProxySettingPolicy:NewCmdletBase
	{
		public NewIntersightHyperflexProxySettingPolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexProxySettingPolicy();
            MethodName = "CreateHyperflexProxySettingPolicy";
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
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexClusterProfileRelationship> ClusterProfiles {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"HTTP Proxy server FQDN or IP."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[A-Za-z]([A-Za-z0-9-]*[A-Za-z0-9])?$|^[A-Za-z0-9]([A-Za-z0-9-]*[A-Za-z0-9])?(\\.[A-Za-z0-9]([A-Za-z0-9-]*[A-Za-z0-9])?)*(\\.[A-Za-z]([A-Za-z0-9-]*[A-Za-z0-9])?)$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string Hostname {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The password for the HTTP Proxy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Password {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The HTTP Proxy port number.\nThe port number of the HTTP proxy must be between 1 and 65535, inclusive."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidateRange(1, 65535)]
        public long Port {
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
        /// <para type="description">"The username for the HTTP Proxy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Username {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexStorageContainer.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexStorageContainer", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexStorageContainer:GetCmdletBase
	{
		public GetIntersightHyperflexStorageContainer()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexStorageContainerList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexSoftwareDistributionEntry.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexSoftwareDistributionEntry")]
    public class SetIntersightHyperflexSoftwareDistributionEntry:SetCmdletBase
	{
		public SetIntersightHyperflexSoftwareDistributionEntry()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexSoftwareDistributionEntry();
            MethodName = "PatchHyperflexSoftwareDistributionEntry";
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
        /// <para type="description">"A reference to a hyperflexAppCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexAppCatalogRelationship AppCatalog {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The HyperFlex Software Distribution type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DistributionType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hyperflexSoftwareDistributionVersion resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexSoftwareDistributionVersionRelationship> DistributionVersions {
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
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexSoftwareDistributionEntry.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexSoftwareDistributionEntry")]
    public class RemoveIntersightHyperflexSoftwareDistributionEntry:RemoveCmdletBase
	{
		public RemoveIntersightHyperflexSoftwareDistributionEntry()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexSoftwareDistributionEntry";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexUcsmConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexUcsmConfigPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexUcsmConfigPolicy:GetCmdletBase
	{
		public GetIntersightHyperflexUcsmConfigPolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexUcsmConfigPolicyList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexUcsmConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexUcsmConfigPolicy")]
    public class NewIntersightHyperflexUcsmConfigPolicy:NewCmdletBase
	{
		public NewIntersightHyperflexUcsmConfigPolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexUcsmConfigPolicy();
            MethodName = "CreateHyperflexUcsmConfigPolicy";
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
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexClusterProfileRelationship> ClusterProfiles {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Out-of-band KVM IP range.\nConfigures the service profiles to use IP addresses within this range for setting the KVM IP of a server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexIpAddrRange KvmIpRange {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The MAC address prefix range for configuring vNICs.\nConfigures the service profiles to use MAC address prefixes within this range for setting the MAC address of server vNICs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexMacAddrPrefixRange MacPrefixRange {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The server firmware bundle version used for server components such as CIMC, adapters, BIOS, etc."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("(^3\\.[1-9]\\([1-9][a-z]\\)$|^[4-9]\\.[0-9]\\([1-9][a-z]\\)$)")]
        public string ServerFirmwareVersion {
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
    /// <para type="synopsis">This is the cmdlet to Set HyperflexClusterNetworkPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexClusterNetworkPolicy")]
    public class SetIntersightHyperflexClusterNetworkPolicy:SetCmdletBase
	{
		public SetIntersightHyperflexClusterNetworkPolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexClusterNetworkPolicy();
            MethodName = "UpdateHyperflexClusterNetworkPolicy";
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
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexClusterProfileRelationship> ClusterProfiles {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enable or disable jumbo frames."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool JumboFrame {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Out-of-band KVM IP range.\nConfigures the service profiles to use IP addresses within this range for setting the KVM IP of a server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexIpAddrRange KvmIpRange {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The MAC address prefix range for configuring vNICs.\nConfigures the service profiles to use MAC address prefixes within this range for setting the MAC address of server vNICs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexMacAddrPrefixRange MacPrefixRange {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The VLAN for the management network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexNamedVlan MgmtVlan {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
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
        /// <para type="description">"Link speed of the server adapter port to the upstream switch. When the policy is attached to a cluster profile with EDGE management platform, the uplink speed can be '1G' or '10G+'. Use '10G+' for link speeds of 10G or above. When the policy is attached to a cluster profile with Fabric Interconnect management platform, the uplink speed can be 'default' only.\n* `default` - Current default value set on the hardware platform.\n* `1G` - A link speed of 1 gigabit per second.\n* `10G` - A link speed of 10 gigabits per second or above."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexClusterNetworkPolicy.UplinkSpeedEnum UplinkSpeed {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The VM migration VLAN.\nThis VLAN is used for transfering VMs from one host to another during operations such a cluster upgrade.\nFor HyperFlex Application Platform clusters, this VLAN is also used for hypervisor control traffic such as\nnode to node communication, pod-to-pod communication, etc."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexNamedVlan VmMigrationVlan {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexNamedVlan> VmNetworkVlans {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexClusterNetworkPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexClusterNetworkPolicy")]
    public class RemoveIntersightHyperflexClusterNetworkPolicy:RemoveCmdletBase
	{
		public RemoveIntersightHyperflexClusterNetworkPolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexClusterNetworkPolicy";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexFeatureLimitExternal.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexFeatureLimitExternal")]
    public class SetIntersightHyperflexFeatureLimitExternal:SetCmdletBase
	{
		public SetIntersightHyperflexFeatureLimitExternal()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexFeatureLimitExternal();
            MethodName = "UpdateHyperflexFeatureLimitExternal";
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
        /// <para type="description">"A reference to a hyperflexAppCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexAppCatalogRelationship AppCatalog {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexFeatureLimitEntry> FeatureLimitEntries {
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
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexFeatureLimitExternal.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexFeatureLimitExternal")]
    public class RemoveIntersightHyperflexFeatureLimitExternal:RemoveCmdletBase
	{
		public RemoveIntersightHyperflexFeatureLimitExternal()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexFeatureLimitExternal";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexNodeConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexNodeConfigPolicy")]
    public class SetIntersightHyperflexNodeConfigPolicy:SetCmdletBase
	{
		public SetIntersightHyperflexNodeConfigPolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexNodeConfigPolicy();
            MethodName = "UpdateHyperflexNodeConfigPolicy";
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
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexClusterProfileRelationship> ClusterProfiles {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The range of storage data IPs to be assigned to the nodes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexIpAddrRange DataIpRange {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The range of storage management IPs to be assigned to the nodes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexIpAddrRange HxdpIpRange {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The range of IPs to be assigned to each hypervisor node for VM migration and hypervior control."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexIpAddrRange HypervisorControlIpRange {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The range of management IPs to be assigned to the nodes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexIpAddrRange MgmtIpRange {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The node name prefix that is used to automatically generate the default hostname for each server.\nA dash (-) will be appended to the prefix followed by the node number to form a hostname.\nThis default naming scheme can be manually overridden in the node configuration.\nThe maximum length of a prefix is 60, must only contain alphanumeric characters or dash (-), and must\nstart with an alphanumeric character."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9][a-zA-Z0-9-]{1,59}$")]
        public string NodeNamePrefix {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
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
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexNodeConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexNodeConfigPolicy")]
    public class RemoveIntersightHyperflexNodeConfigPolicy:RemoveCmdletBase
	{
		public RemoveIntersightHyperflexNodeConfigPolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexNodeConfigPolicy";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexHxapVirtualDisk.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexHxapVirtualDisk", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexHxapVirtualDisk:GetCmdletBase
	{
		public GetIntersightHyperflexHxapVirtualDisk()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexHxapVirtualDiskList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexVcenterConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexVcenterConfigPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexVcenterConfigPolicy:GetCmdletBase
	{
		public GetIntersightHyperflexVcenterConfigPolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexVcenterConfigPolicyList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexVcenterConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexVcenterConfigPolicy")]
    public class NewIntersightHyperflexVcenterConfigPolicy:NewCmdletBase
	{
		public NewIntersightHyperflexVcenterConfigPolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexVcenterConfigPolicy();
            MethodName = "CreateHyperflexVcenterConfigPolicy";
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
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexClusterProfileRelationship> ClusterProfiles {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The vCenter datacenter name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9~!@#$%&*()-_][a-zA-Z0-9~!@#$%&* ()-_]{0,79}$")]
        public string DataCenter {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The vCenter server FQDN or IP."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[A-Za-z]([A-Za-z0-9-]*[A-Za-z0-9])?$|^[A-Za-z0-9]([A-Za-z0-9-]*[A-Za-z0-9])?(\\.[A-Za-z0-9]([A-Za-z0-9-]*[A-Za-z0-9])?)*(\\.[A-Za-z]([A-Za-z0-9-]*[A-Za-z0-9])?)$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string Hostname {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The password for authenticating with vCenter. Follow the corresponding password policy governed by vCenter."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Password {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Overrides the default vCenter Single Sign-On URL. Do not specify unless instructed by Cisco TAC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SsoUrl {
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
        /// <para type="description">"The vCenter username (e.g. administrator@vsphere.local)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^([a-zA-Z0-9._-]+)@([a-zA-Z0-9._-]+)$")]
        public string Username {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexClusterNetworkPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexClusterNetworkPolicy")]
    public class NewIntersightHyperflexClusterNetworkPolicy:NewCmdletBase
	{
		public NewIntersightHyperflexClusterNetworkPolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexClusterNetworkPolicy();
            MethodName = "CreateHyperflexClusterNetworkPolicy";
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
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexClusterProfileRelationship> ClusterProfiles {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Enable or disable jumbo frames."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool JumboFrame {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Out-of-band KVM IP range.\nConfigures the service profiles to use IP addresses within this range for setting the KVM IP of a server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexIpAddrRange KvmIpRange {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The MAC address prefix range for configuring vNICs.\nConfigures the service profiles to use MAC address prefixes within this range for setting the MAC address of server vNICs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexMacAddrPrefixRange MacPrefixRange {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The VLAN for the management network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexNamedVlan MgmtVlan {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
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
        /// <para type="description">"Link speed of the server adapter port to the upstream switch. When the policy is attached to a cluster profile with EDGE management platform, the uplink speed can be '1G' or '10G+'. Use '10G+' for link speeds of 10G or above. When the policy is attached to a cluster profile with Fabric Interconnect management platform, the uplink speed can be 'default' only.\n* `default` - Current default value set on the hardware platform.\n* `1G` - A link speed of 1 gigabit per second.\n* `10G` - A link speed of 10 gigabits per second or above."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexClusterNetworkPolicy.UplinkSpeedEnum UplinkSpeed {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The VM migration VLAN.\nThis VLAN is used for transfering VMs from one host to another during operations such a cluster upgrade.\nFor HyperFlex Application Platform clusters, this VLAN is also used for hypervisor control traffic such as\nnode to node communication, pod-to-pod communication, etc."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexNamedVlan VmMigrationVlan {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexNamedVlan> VmNetworkVlans {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexClusterNetworkPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexClusterNetworkPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexClusterNetworkPolicy:GetCmdletBase
	{
		public GetIntersightHyperflexClusterNetworkPolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexClusterNetworkPolicyList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexLocalCredentialPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexLocalCredentialPolicy")]
    public class SetIntersightHyperflexLocalCredentialPolicy:SetCmdletBase
	{
		public SetIntersightHyperflexLocalCredentialPolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexLocalCredentialPolicy();
            MethodName = "UpdateHyperflexLocalCredentialPolicy";
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
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexClusterProfileRelationship> ClusterProfiles {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates if Hypervisor password is the factory set default password. For HyperFlex Data Platform versions 3.0 or higher, enable this if the default password was not changed on the Hypervisor. It is required to supply a new custom Hypervisor password that will be applied to the Hypervisor during deployment. For HyperFlex Data Platform versions prior to 3.0 release, this setting has no effect and the default password will be used for initial install. The Hypervisor password should be changed after deployment."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool FactoryHypervisorPassword {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"HyperFlex storage controller VM password must contain a minimum of 10 characters, with at least 1 lowercase, 1 uppercase, 1 numeric, and 1 of these -_@#$%^&*! special characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9!@#$%^&*_-]{10,}$")]
        public string HxdpRootPwd {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Hypervisor administrator username must contain only alphanumeric characters."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9]{1,}$")]
        public string HypervisorAdmin {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The ESXi root password. For HyperFlex Data Platform 3.0 or later, if the factory default password was not manually changed, you must set a new custom password. If the password was manually changed, you must not enable the factory default password property and provide the current hypervisor password. Note - All HyperFlex nodes require the same hypervisor password for installation. For HyperFlex Data Platform prior to 3.0, use the default password \"Cisco123\" for newly manufactured HyperFlex servers. A custom password should only be entered if hypervisor credentials were manually changed prior to deployment."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^.{7,40}$")]
        public string HypervisorAdminPwd {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
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
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexLocalCredentialPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexLocalCredentialPolicy")]
    public class RemoveIntersightHyperflexLocalCredentialPolicy:RemoveCmdletBase
	{
		public RemoveIntersightHyperflexLocalCredentialPolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexLocalCredentialPolicy";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexVcenterConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexVcenterConfigPolicy")]
    public class SetIntersightHyperflexVcenterConfigPolicy:SetCmdletBase
	{
		public SetIntersightHyperflexVcenterConfigPolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexVcenterConfigPolicy();
            MethodName = "UpdateHyperflexVcenterConfigPolicy";
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
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexClusterProfileRelationship> ClusterProfiles {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The vCenter datacenter name."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9~!@#$%&*()-_][a-zA-Z0-9~!@#$%&* ()-_]{0,79}$")]
        public string DataCenter {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The vCenter server FQDN or IP."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[A-Za-z]([A-Za-z0-9-]*[A-Za-z0-9])?$|^[A-Za-z0-9]([A-Za-z0-9-]*[A-Za-z0-9])?(\\.[A-Za-z0-9]([A-Za-z0-9-]*[A-Za-z0-9])?)*(\\.[A-Za-z]([A-Za-z0-9-]*[A-Za-z0-9])?)$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string Hostname {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The password for authenticating with vCenter. Follow the corresponding password policy governed by vCenter."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Password {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Overrides the default vCenter Single Sign-On URL. Do not specify unless instructed by Cisco TAC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SsoUrl {
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
        /// <para type="description">"The vCenter username (e.g. administrator@vsphere.local)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^([a-zA-Z0-9._-]+)@([a-zA-Z0-9._-]+)$")]
        public string Username {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexVcenterConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexVcenterConfigPolicy")]
    public class RemoveIntersightHyperflexVcenterConfigPolicy:RemoveCmdletBase
	{
		public RemoveIntersightHyperflexVcenterConfigPolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexVcenterConfigPolicy";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexHxapVirtualMachine.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexHxapVirtualMachine", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexHxapVirtualMachine:GetCmdletBase
	{
		public GetIntersightHyperflexHxapVirtualMachine()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexHxapVirtualMachineList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexHealthCheckExecution.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexHealthCheckExecution", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexHealthCheckExecution:GetCmdletBase
	{
		public GetIntersightHyperflexHealthCheckExecution()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexHealthCheckExecutionList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexClusterHealthCheckExecutionSnapshot.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexClusterHealthCheckExecutionSnapshot", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexClusterHealthCheckExecutionSnapshot:GetCmdletBase
	{
		public GetIntersightHyperflexClusterHealthCheckExecutionSnapshot()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexClusterHealthCheckExecutionSnapshotList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexSoftwareVersionPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexSoftwareVersionPolicy")]
    public class SetIntersightHyperflexSoftwareVersionPolicy:SetCmdletBase
	{
		public SetIntersightHyperflexSoftwareVersionPolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexSoftwareVersionPolicy();
            MethodName = "UpdateHyperflexSoftwareVersionPolicy";
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
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexClusterProfileRelationship> ClusterProfiles {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Desired HyperFlex Data Platform software version to apply on the HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string HxdpVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Desired  hypervisor version to apply for all the nodes on the HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string HypervisorVersion {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Desired server firmware version to apply on the HyperFlex Cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|(^3\\.[0-9]\\([1-9][a-z]\\)$|^[4-9]\\.[1-9]\\([1-9][a-z]\\)$|^4\\.0\\([1-3][a-z]\\)$|^4\\.0\\(4[d-z]\\)$|4\\.0\\([5-9][a-z]\\)$)")]
        public string ServerFirmwareVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexServerFirmwareVersionInfo> ServerFirmwareVersions {
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> UpgradeTypes {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexSoftwareVersionPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexSoftwareVersionPolicy")]
    public class RemoveIntersightHyperflexSoftwareVersionPolicy:RemoveCmdletBase
	{
		public RemoveIntersightHyperflexSoftwareVersionPolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexSoftwareVersionPolicy";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexHealthCheckExecutionSnapshot.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexHealthCheckExecutionSnapshot", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexHealthCheckExecutionSnapshot:GetCmdletBase
	{
		public GetIntersightHyperflexHealthCheckExecutionSnapshot()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexHealthCheckExecutionSnapshotList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexCapabilityInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexCapabilityInfo")]
    public class SetIntersightHyperflexCapabilityInfo:SetCmdletBase
	{
		public SetIntersightHyperflexCapabilityInfo()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexCapabilityInfo();
            MethodName = "PatchHyperflexCapabilityInfo";
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
        /// <para type="description">"A reference to a hyperflexAppCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexAppCatalogRelationship AppCatalog {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HclConstraint> CapabilityConstraints {
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
        /// <para type="description">"Name of the capability or feature set consisting of a collection of constraint rules and value."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
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
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexCapabilityInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexCapabilityInfo")]
    public class RemoveIntersightHyperflexCapabilityInfo:RemoveCmdletBase
	{
		public RemoveIntersightHyperflexCapabilityInfo()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexCapabilityInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexVmImportOperation.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexVmImportOperation")]
    public class RemoveIntersightHyperflexVmImportOperation:RemoveCmdletBase
	{
		public RemoveIntersightHyperflexVmImportOperation()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexVmImportOperation";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexConfigResultEntry.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexConfigResultEntry", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexConfigResultEntry:GetCmdletBase
	{
		public GetIntersightHyperflexConfigResultEntry()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexConfigResultEntryList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexHxapDatacenter.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexHxapDatacenter", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexHxapDatacenter:GetCmdletBase
	{
		public GetIntersightHyperflexHxapDatacenter()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexHxapDatacenterList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexHxapDatacenter.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexHxapDatacenter")]
    public class NewIntersightHyperflexHxapDatacenter:NewCmdletBase
	{
		public NewIntersightHyperflexHxapDatacenter()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexHxapDatacenter();
            MethodName = "CreateHyperflexHxapDatacenter";
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
        /// <para type="description">"The internally generated identity of this placement. This entity is not manipulated by users. It aids in uniquely identifying the placement object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Identity {
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
        /// <para type="description">"Name of the virtual machine placement. It is the name of the VPC (Virtual Private Cloud) in case of AWS\nvirtual machine, and datacenter name in case of VMware virtual machine."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceRegistrationRelationship RegisteredDevice {
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
        /// <para type="description">"The uuid of this placement. The uuid is internally generated and not user specified."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$")]
        public string Uuid {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexNodeConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexNodeConfigPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexNodeConfigPolicy:GetCmdletBase
	{
		public GetIntersightHyperflexNodeConfigPolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexNodeConfigPolicyList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexNodeConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexNodeConfigPolicy")]
    public class NewIntersightHyperflexNodeConfigPolicy:NewCmdletBase
	{
		public NewIntersightHyperflexNodeConfigPolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexNodeConfigPolicy();
            MethodName = "CreateHyperflexNodeConfigPolicy";
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
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexClusterProfileRelationship> ClusterProfiles {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The range of storage data IPs to be assigned to the nodes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexIpAddrRange DataIpRange {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The range of storage management IPs to be assigned to the nodes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexIpAddrRange HxdpIpRange {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The range of IPs to be assigned to each hypervisor node for VM migration and hypervior control."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexIpAddrRange HypervisorControlIpRange {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The range of management IPs to be assigned to the nodes."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexIpAddrRange MgmtIpRange {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The node name prefix that is used to automatically generate the default hostname for each server.\nA dash (-) will be appended to the prefix followed by the node number to form a hostname.\nThis default naming scheme can be manually overridden in the node configuration.\nThe maximum length of a prefix is 60, must only contain alphanumeric characters or dash (-), and must\nstart with an alphanumeric character."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9][a-zA-Z0-9-]{1,59}$")]
        public string NodeNamePrefix {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
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
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexVmRestoreOperation.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexVmRestoreOperation")]
    public class RemoveIntersightHyperflexVmRestoreOperation:RemoveCmdletBase
	{
		public RemoveIntersightHyperflexVmRestoreOperation()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexVmRestoreOperation";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexHealth.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexHealth", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexHealth:GetCmdletBase
	{
		public GetIntersightHyperflexHealth()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexHealthList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexNodeProfile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexNodeProfile")]
    public class NewIntersightHyperflexNodeProfile:NewCmdletBase
	{
		public NewIntersightHyperflexNodeProfile()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexNodeProfile();
            MethodName = "CreateHyperflexNodeProfile";
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
        /// <para type="description">"A reference to a computePhysical resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputePhysicalRelationship AssignedServer {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexClusterProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexClusterProfileRelationship ClusterProfile {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the profile."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IP address for storage data network (Controller VM interface)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string HxdpDataIp {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IP address for HyperFlex management network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string HxdpMgmtIp {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IP address for hypervisor control such as VM migration or pod management."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string HypervisorControlIp {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IP address for storage data network (Hypervisor interface)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string HypervisorDataIp {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"IP address for Hypervisor management network."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])$")]
        public string HypervisorMgmtIp {
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
        /// <para type="description">"Name of the profile instance or profile template."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a policyAbstractProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public PolicyAbstractProfileRelationship SrcTemplate {
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
        /// <para type="description">"Defines the type of the profile. Accepted values are instance or template.\n* `instance` - The profile defines the configuration for a specific instance of a target."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexNodeProfile.TypeEnum Type {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexNodeProfile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexNodeProfile", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexNodeProfile:GetCmdletBase
	{
		public GetIntersightHyperflexNodeProfile()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexNodeProfileList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexSysConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexSysConfigPolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexSysConfigPolicy:GetCmdletBase
	{
		public GetIntersightHyperflexSysConfigPolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexSysConfigPolicyList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexSysConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexSysConfigPolicy")]
    public class NewIntersightHyperflexSysConfigPolicy:NewCmdletBase
	{
		public NewIntersightHyperflexSysConfigPolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexSysConfigPolicy();
            MethodName = "CreateHyperflexSysConfigPolicy";
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
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexClusterProfileRelationship> ClusterProfiles {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The DNS Search Domain Name. This setting applies to HyperFlex Data Platform 3.0 or later only."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^([a-zA-Z0-9]([a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?\\.)*[a-zA-Z]{2,63}$")]
        public string DnsDomainName {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> DnsServers {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> NtpServers {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
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
        /// <para type="description">"The timezone of the HyperFlex cluster's system clock.\n* `Pacific/Niue` - \n* `Pacific/Pago_Pago` - \n* `Pacific/Honolulu` - \n* `Pacific/Rarotonga` - \n* `Pacific/Tahiti` - \n* `Pacific/Marquesas` - \n* `America/Anchorage` - \n* `Pacific/Gambier` - \n* `America/Los_Angeles` - \n* `America/Tijuana` - \n* `America/Vancouver` - \n* `America/Whitehorse` - \n* `Pacific/Pitcairn` - \n* `America/Dawson_Creek` - \n* `America/Denver` - \n* `America/Edmonton` - \n* `America/Hermosillo` - \n* `America/Mazatlan` - \n* `America/Phoenix` - \n* `America/Yellowknife` - \n* `America/Belize` - \n* `America/Chicago` - \n* `America/Costa_Rica` - \n* `America/El_Salvador` - \n* `America/Guatemala` - \n* `America/Managua` - \n* `America/Mexico_City` - \n* `America/Regina` - \n* `America/Tegucigalpa` - \n* `America/Winnipeg` - \n* `Pacific/Galapagos` - \n* `America/Bogota` - \n* `America/Cancun` - \n* `America/Cayman` - \n* `America/Guayaquil` - \n* `America/Havana` - \n* `America/Iqaluit` - \n* `America/Jamaica` - \n* `America/Lima` - \n* `America/Nassau` - \n* `America/New_York` - \n* `America/Panama` - \n* `America/Port-au-Prince` - \n* `America/Rio_Branco` - \n* `America/Toronto` - \n* `Pacific/Easter` - \n* `America/Caracas` - \n* `America/Asuncion` - \n* `America/Barbados` - \n* `America/Boa_Vista` - \n* `America/Campo_Grande` - \n* `America/Cuiaba` - \n* `America/Curacao` - \n* `America/Grand_Turk` - \n* `America/Guyana` - \n* `America/Halifax` - \n* `America/La_Paz` - \n* `America/Manaus` - \n* `America/Martinique` - \n* `America/Port_of_Spain` - \n* `America/Porto_Velho` - \n* `America/Puerto_Rico` - \n* `America/Santo_Domingo` - \n* `America/Thule` - \n* `Atlantic/Bermuda` - \n* `America/St_Johns` - \n* `America/Araguaina` - \n* `America/Argentina/Buenos_Aires` - \n* `America/Bahia` - \n* `America/Belem` - \n* `America/Cayenne` - \n* `America/Fortaleza` - \n* `America/Godthab` - \n* `America/Maceio` - \n* `America/Miquelon` - \n* `America/Montevideo` - \n* `America/Paramaribo` - \n* `America/Recife` - \n* `America/Santiago` - \n* `America/Sao_Paulo` - \n* `Antarctica/Palmer` - \n* `Antarctica/Rothera` - \n* `Atlantic/Stanley` - \n* `America/Noronha` - \n* `Atlantic/South_Georgia` - \n* `America/Scoresbysund` - \n* `Atlantic/Azores` - \n* `Atlantic/Cape_Verde` - \n* `Africa/Abidjan` - \n* `Africa/Accra` - \n* `Africa/Bissau` - \n* `Africa/Casablanca` - \n* `Africa/El_Aaiun` - \n* `Africa/Monrovia` - \n* `America/Danmarkshavn` - \n* `Atlantic/Canary` - \n* `Atlantic/Faroe` - \n* `Atlantic/Reykjavik` - \n* `Etc/GMT` - \n* `Europe/Dublin` - \n* `Europe/Lisbon` - \n* `Europe/London` - \n* `Africa/Algiers` - \n* `Africa/Ceuta` - \n* `Africa/Lagos` - \n* `Africa/Ndjamena` - \n* `Africa/Tunis` - \n* `Africa/Windhoek` - \n* `Europe/Amsterdam` - \n* `Europe/Andorra` - \n* `Europe/Belgrade` - \n* `Europe/Berlin` - \n* `Europe/Brussels` - \n* `Europe/Budapest` - \n* `Europe/Copenhagen` - \n* `Europe/Gibraltar` - \n* `Europe/Luxembourg` - \n* `Europe/Madrid` - \n* `Europe/Malta` - \n* `Europe/Monaco` - \n* `Europe/Oslo` - \n* `Europe/Paris` - \n* `Europe/Prague` - \n* `Europe/Rome` - \n* `Europe/Stockholm` - \n* `Europe/Tirane` - \n* `Europe/Vienna` - \n* `Europe/Warsaw` - \n* `Europe/Zurich` - \n* `Africa/Cairo` - \n* `Africa/Johannesburg` - \n* `Africa/Maputo` - \n* `Africa/Tripoli` - \n* `Asia/Amman` - \n* `Asia/Beirut` - \n* `Asia/Damascus` - \n* `Asia/Gaza` - \n* `Asia/Jerusalem` - \n* `Asia/Nicosia` - \n* `Europe/Athens` - \n* `Europe/Bucharest` - \n* `Europe/Chisinau` - \n* `Europe/Helsinki` - \n* `Europe/Istanbul` - \n* `Europe/Kaliningrad` - \n* `Europe/Kiev` - \n* `Europe/Riga` - \n* `Europe/Sofia` - \n* `Europe/Tallinn` - \n* `Europe/Vilnius` - \n* `Africa/Khartoum` - \n* `Africa/Nairobi` - \n* `Antarctica/Syowa` - \n* `Asia/Baghdad` - \n* `Asia/Qatar` - \n* `Asia/Riyadh` - \n* `Europe/Minsk` - \n* `Europe/Moscow` - \n* `Asia/Tehran` - \n* `Asia/Baku` - \n* `Asia/Dubai` - \n* `Asia/Tbilisi` - \n* `Asia/Yerevan` - \n* `Europe/Samara` - \n* `Indian/Mahe` - \n* `Indian/Mauritius` - \n* `Indian/Reunion` - \n* `Asia/Kabul` - \n* `Antarctica/Mawson` - \n* `Asia/Aqtau` - \n* `Asia/Aqtobe` - \n* `Asia/Ashgabat` - \n* `Asia/Dushanbe` - \n* `Asia/Karachi` - \n* `Asia/Tashkent` - \n* `Asia/Yekaterinburg` - \n* `Indian/Kerguelen` - \n* `Indian/Maldives` - \n* `Asia/Calcutta` - \n* `Asia/Kolkata` - \n* `Asia/Colombo` - \n* `Asia/Katmandu` - \n* `Antarctica/Vostok` - \n* `Asia/Almaty` - \n* `Asia/Bishkek` - \n* `Asia/Dhaka` - \n* `Asia/Omsk` - \n* `Asia/Thimphu` - \n* `Indian/Chagos` - \n* `Asia/Rangoon` - \n* `Indian/Cocos` - \n* `Antarctica/Davis` - \n* `Asia/Bangkok` - \n* `Asia/Hovd` - \n* `Asia/Jakarta` - \n* `Asia/Krasnoyarsk` - \n* `Asia/Saigon` - \n* `Indian/Christmas` - \n* `Antarctica/Casey` - \n* `Asia/Brunei` - \n* `Asia/Choibalsan` - \n* `Asia/Hong_Kong` - \n* `Asia/Irkutsk` - \n* `Asia/Kuala_Lumpur` - \n* `Asia/Macau` - \n* `Asia/Makassar` - \n* `Asia/Manila` - \n* `Asia/Shanghai` - \n* `Asia/Singapore` - \n* `Asia/Taipei` - \n* `Asia/Ulaanbaatar` - \n* `Australia/Perth` - \n* `Asia/Pyongyang` - \n* `Asia/Dili` - \n* `Asia/Jayapura` - \n* `Asia/Seoul` - \n* `Asia/Tokyo` - \n* `Asia/Yakutsk` - \n* `Pacific/Palau` - \n* `Australia/Adelaide` - \n* `Australia/Darwin` - \n* `Antarctica/DumontDUrville` - \n* `Asia/Magadan` - \n* `Asia/Vladivostok` - \n* `Australia/Brisbane` - \n* `Australia/Hobart` - \n* `Australia/Sydney` - \n* `Pacific/Chuuk` - \n* `Pacific/Guam` - \n* `Pacific/Port_Moresby` - \n* `Pacific/Efate` - \n* `Pacific/Guadalcanal` - \n* `Pacific/Kosrae` - \n* `Pacific/Norfolk` - \n* `Pacific/Noumea` - \n* `Pacific/Pohnpei` - \n* `Asia/Kamchatka` - \n* `Pacific/Auckland` - \n* `Pacific/Fiji` - \n* `Pacific/Funafuti` - \n* `Pacific/Kwajalein` - \n* `Pacific/Majuro` - \n* `Pacific/Nauru` - \n* `Pacific/Tarawa` - \n* `Pacific/Wake` - \n* `Pacific/Wallis` - \n* `Pacific/Apia` - \n* `Pacific/Enderbury` - \n* `Pacific/Fakaofo` - \n* `Pacific/Tongatapu` - \n* `Pacific/Kiritimati` -"</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexSysConfigPolicy.TimezoneEnum Timezone {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexHxapHost.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexHxapHost")]
    public class SetIntersightHyperflexHxapHost:SetCmdletBase
	{
		public SetIntersightHyperflexHxapHost()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexHxapHost();
            MethodName = "UpdateHyperflexHxapHost";
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
        /// <para type="description">"Denotes age or life time of the Host in nano seconds."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Age {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Chassis version of the Host."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ChassisVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The UUID of the cluster to which this Host belongs to."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ClusterUuid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"CPU allocation details of the host."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationCpuAllocation CpuAllocation {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Details about the CPUs installed on this host are represented here."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationCpuInfo CpuInfo {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Reason of the failure when host is in failed state."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FailureReason {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The hardware details of this host. It includes capacity, manufacturer, and model information."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public InfraHardwareInfo HardwareInfo {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Is the host Powered-up or Powered-down.\n* `Unknown` - The entity's power state is unknown.\n* `PoweringOn` - The entity is powering on.\n* `PoweredOn` - The entity is powered on.\n* `PoweringOff` - The entity is powering off.\n* `PoweredOff` - The entity is powered down.\n* `StandBy` - The entity is in standby mode.\n* `Paused` - The entity is in pause state.\n* `Rebooting` - The entity reboot is in progress.\n* `` - The entity's power state is not available."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexHxapHost.HwPowerStateEnum HwPowerState {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Identifies the broad type of the underlying hypervisor.\n* `ESXi` - The hypervisor running on the HyperFlex cluster is a Vmware ESXi hypervisor of any version.\n* `HyperFlexAp` - The hypervisor running on the HyperFlex cluster is Cisco HyperFlex Application Platform.\n* `Hyper-V` - The hypervisor running on the HyperFlex cluster is Microsoft Hyper-V.\n* `Unknown` - The hypervisor running on the HyperFlex cluster is not known."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexHxapHost.HypervisorTypeEnum HypervisorType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The internally generated identity of this host. This entity is not manipulated by users. It aids in uniquely identifying the datacenter object. For VMware, this is an MOR (managed object reference)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Identity {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Internal IP Address of the Host."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string InternalIpAddress {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Is this host in maintenance mode. Set to true or false."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool MaintenanceMode {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Management IP Address of the Host."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ManagementIpAddress {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Is the role of this host is master in the cluster? true or false."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool MasterRole {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Memory allocation details of the host."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationMemoryAllocation MemoryAllocation {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The memory capacity and usage information on this host."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationMemoryCapacity MemoryCapacity {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Commercial model information about this hardware."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Model {
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
        /// <para type="description">"Name of this host supplied by user. It is not the identity of the host. The name is subject to user manipulations."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The capacity and usage information for CPU power on this host."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationComputeCapacity ProcessorCapacity {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Details of this product, such as vendor, model, etc. are represented here."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public VirtualizationProductInfo ProductInfo {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public AssetDeviceRegistrationRelationship RegisteredDevice {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Serial number of this host (internally generated)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Serial {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Host health status, as reported by the hypervisor platform.\n* `Unknown` - Entity status is unknown.\n* `Degraded` - State is degraded, and might impact normal operation of the entity.\n* `Critical` - Entity is in a critical state, impacting operations.\n* `Ok` - Entity status is in a stable state, operating normally."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexHxapHost.StatusEnum Status {
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
        /// <para type="description">"The uptime of the host, stored as Duration (from w3c)."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string UpTime {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Universally unique identity of this host (example b3d4483b-5560-9342-8309-b486c9236610). Internally generated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$")]
        public string Uuid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Commercial vendor details of this hardware."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vendor {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Product version of the Host."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexExtFcStoragePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexExtFcStoragePolicy")]
    public class NewIntersightHyperflexExtFcStoragePolicy:NewCmdletBase
	{
		public NewIntersightHyperflexExtFcStoragePolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexExtFcStoragePolicy();
            MethodName = "CreateHyperflexExtFcStoragePolicy";
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
        /// <para type="description">"Enables or disables external FC storage configuration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool AdminState {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexClusterProfileRelationship> ClusterProfiles {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VSAN for the primary Fabric Interconnect external FC storage traffic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexNamedVsan ExtaTraffic {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VSAN for the secondary Fabric Interconnect external FC storage traffic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexNamedVsan ExtbTraffic {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
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
        /// <para type="description">"The range of WWxN addresses to use for the FC storage configuration."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexWwxnPrefixRange WwxnPrefixRange {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexExtFcStoragePolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexExtFcStoragePolicy", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexExtFcStoragePolicy:GetCmdletBase
	{
		public GetIntersightHyperflexExtFcStoragePolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexExtFcStoragePolicyList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexHxapHostInterface.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexHxapHostInterface", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexHxapHostInterface:GetCmdletBase
	{
		public GetIntersightHyperflexHxapHostInterface()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexHxapHostInterfaceList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexDevicePackageDownloadState.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexDevicePackageDownloadState", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexDevicePackageDownloadState:GetCmdletBase
	{
		public GetIntersightHyperflexDevicePackageDownloadState()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexDevicePackageDownloadStateList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HyperflexSoftwareDistributionVersion.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexSoftwareDistributionVersion", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexSoftwareDistributionVersion:GetCmdletBase
	{
		public GetIntersightHyperflexSoftwareDistributionVersion()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexSoftwareDistributionVersionList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexSoftwareDistributionVersion.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexSoftwareDistributionVersion")]
    public class NewIntersightHyperflexSoftwareDistributionVersion:NewCmdletBase
	{
		public NewIntersightHyperflexSoftwareDistributionVersion()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexSoftwareDistributionVersion();
            MethodName = "CreateHyperflexSoftwareDistributionVersion";
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
        /// <para type="description">"An array of relationships to hyperflexSoftwareDistributionComponent resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexSoftwareDistributionComponentRelationship> DistributionComponents {
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
        /// <para type="description">"A reference to a hyperflexSoftwareDistributionEntry resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexSoftwareDistributionEntryRelationship SoftwareDistributionEntry {
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
        /// <para type="description">"The HyperFlex Software Distribution version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexUcsmConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexUcsmConfigPolicy")]
    public class SetIntersightHyperflexUcsmConfigPolicy:SetCmdletBase
	{
		public SetIntersightHyperflexUcsmConfigPolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexUcsmConfigPolicy();
            MethodName = "UpdateHyperflexUcsmConfigPolicy";
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
        /// <para type="description">"An array of relationships to hyperflexClusterProfile resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexClusterProfileRelationship> ClusterProfiles {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description of the policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^$|^[a-zA-Z0-9]+[\\x00-\\xFF]*$")]
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Out-of-band KVM IP range.\nConfigures the service profiles to use IP addresses within this range for setting the KVM IP of a server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexIpAddrRange KvmIpRange {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The MAC address prefix range for configuring vNICs.\nConfigures the service profiles to use MAC address prefixes within this range for setting the MAC address of server vNICs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexMacAddrPrefixRange MacPrefixRange {
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
        /// <para type="description">"Name of the concrete policy."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.:-]{1,64}$")]
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The server firmware bundle version used for server components such as CIMC, adapters, BIOS, etc."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        [ValidatePattern("(^3\\.[1-9]\\([1-9][a-z]\\)$|^[4-9]\\.[0-9]\\([1-9][a-z]\\)$)")]
        public string ServerFirmwareVersion {
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
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexUcsmConfigPolicy.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexUcsmConfigPolicy")]
    public class RemoveIntersightHyperflexUcsmConfigPolicy:RemoveCmdletBase
	{
		public RemoveIntersightHyperflexUcsmConfigPolicy()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexUcsmConfigPolicy";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexServerModel.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexServerModel")]
    public class SetIntersightHyperflexServerModel:SetCmdletBase
	{
		public SetIntersightHyperflexServerModel()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexServerModel();
            MethodName = "UpdateHyperflexServerModel";
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
        /// <para type="description">"A reference to a hyperflexAppCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexAppCatalogRelationship AppCatalog {
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
        
        public List<HyperflexServerModelEntry> ServerModelEntries {
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
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexServerModel.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexServerModel")]
    public class RemoveIntersightHyperflexServerModel:RemoveCmdletBase
	{
		public RemoveIntersightHyperflexServerModel()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexServerModel";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexClusterBackupPolicyDeployment.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexClusterBackupPolicyDeployment")]
    public class SetIntersightHyperflexClusterBackupPolicyDeployment:SetCmdletBase
	{
		public SetIntersightHyperflexClusterBackupPolicyDeployment()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexClusterBackupPolicyDeployment();
            MethodName = "UpdateHyperflexClusterBackupPolicyDeployment";
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
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexClusterRelationship BackupTarget {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"True if record created by discovery on HyperFlex cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool Discovered {
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
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexClusterRelationship SourceCluster {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"True if policy was detached from source Hyperflex Cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool SourceDetached {
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
        /// <para type="description">"True if policy was detached from target Hyperflex Cluster."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool TargetDetached {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexClusterBackupPolicyDeployment.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexClusterBackupPolicyDeployment")]
    public class RemoveIntersightHyperflexClusterBackupPolicyDeployment:RemoveCmdletBase
	{
		public RemoveIntersightHyperflexClusterBackupPolicyDeployment()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexClusterBackupPolicyDeployment";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove HyperflexServerFirmwareVersion.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHyperflexServerFirmwareVersion")]
    public class RemoveIntersightHyperflexServerFirmwareVersion:RemoveCmdletBase
	{
		public RemoveIntersightHyperflexServerFirmwareVersion()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "DeleteHyperflexServerFirmwareVersion";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set HyperflexServerFirmwareVersion.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHyperflexServerFirmwareVersion")]
    public class SetIntersightHyperflexServerFirmwareVersion:SetCmdletBase
	{
		public SetIntersightHyperflexServerFirmwareVersion()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexServerFirmwareVersion();
            MethodName = "UpdateHyperflexServerFirmwareVersion";
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
        /// <para type="description">"A reference to a hyperflexAppCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexAppCatalogRelationship AppCatalog {
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
        /// <para type="description">"An array of relationships to hyperflexServerFirmwareVersionEntry resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HyperflexServerFirmwareVersionEntryRelationship> ServerFirmwareVersionEntries {
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
    /// <para type="synopsis">This is the cmdlet to Get HyperflexVmRestoreOperation.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHyperflexVmRestoreOperation", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHyperflexVmRestoreOperation:GetCmdletBase
	{
		public GetIntersightHyperflexVmRestoreOperation()
		{
			ApiInstance = new HyperflexApi(Config);
            MethodName = "GetHyperflexVmRestoreOperationList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HyperflexVmRestoreOperation.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHyperflexVmRestoreOperation")]
    public class NewIntersightHyperflexVmRestoreOperation:NewCmdletBase
	{
		public NewIntersightHyperflexVmRestoreOperation()
		{
			ApiInstance = new HyperflexApi(Config);
            ModelObject = new HyperflexVmRestoreOperation();
            MethodName = "CreateHyperflexVmRestoreOperation";
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
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"New name for the Virtual Machine after recovery."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string NewName {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public OrganizationOrganizationRelationship Organization {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Power on the Virtual Machine after recovery."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool PowerOn {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexCluster resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexClusterRelationship RestoreEdgeClusterMoid {
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
        /// <para type="description">"A reference to a hyperflexVmBackupInfo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexVmBackupInfoRelationship VmBackupInfoMoid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a hyperflexVmSnapshotInfo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HyperflexVmSnapshotInfoRelationship VmSnapshotInfoMoid {
            get;
            set;
        }
    }
}