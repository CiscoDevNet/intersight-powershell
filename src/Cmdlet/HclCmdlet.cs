using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HclOperatingSystemVendor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHclOperatingSystemVendor", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHclOperatingSystemVendor:GetCmdletBase
	{
		public GetIntersightHclOperatingSystemVendor()
		{
			ApiInstance = new HclApi(Config);
            MethodName = "GetHclOperatingSystemVendorListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HclDriverImage.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHclDriverImage", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHclDriverImage:GetCmdletBase
	{
		public GetIntersightHclDriverImage()
		{
			ApiInstance = new HclApi(Config);
            MethodName = "GetHclDriverImageListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HclHyperflexSoftwareCompatibilityInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHclHyperflexSoftwareCompatibilityInfo", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHclHyperflexSoftwareCompatibilityInfo:GetCmdletBase
	{
		public GetIntersightHclHyperflexSoftwareCompatibilityInfo()
		{
			ApiInstance = new HclApi(Config);
            MethodName = "GetHclHyperflexSoftwareCompatibilityInfoListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HclHyperflexSoftwareCompatibilityInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHclHyperflexSoftwareCompatibilityInfo")]
    public class NewIntersightHclHyperflexSoftwareCompatibilityInfo:NewCmdletBase
	{
		public NewIntersightHclHyperflexSoftwareCompatibilityInfo()
		{
			ApiInstance = new HclApi(Config);
            ModelObject = new HclHyperflexSoftwareCompatibilityInfo();
            MethodName = "CreateHclHyperflexSoftwareCompatibilityInfoWithHttpInfo";
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
        
        public List<HclConstraint> Constraints {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"HXDP component software version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string HxdpVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type fo Hypervisor the HyperFlex components versions are compatible with. For example ESX, Hyperv or KVM.\n* `ESXi` - The hypervisor running on the HyperFlex cluster is a Vmware ESXi hypervisor of any version.\n* `HyperFlexAp` - The hypervisor running on the HyperFlex cluster is Cisco HyperFlex Application Platform.\n* `Hyper-V` - The hypervisor running on the HyperFlex cluster is Microsoft Hyper-V.\n* `Unknown` - The hypervisor running on the HyperFlex cluster is not known."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HclHyperflexSoftwareCompatibilityInfo.HypervisorTypeEnum HypervisorType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Hypervisor component software version."</para>
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
        /// <para type="description">"UCS Server Firmware component software version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ServerFwVersion {
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
    /// <para type="synopsis">This is the cmdlet to New HclSupportedDriverName.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHclSupportedDriverName")]
    public class NewIntersightHclSupportedDriverName:NewCmdletBase
	{
		public NewIntersightHclSupportedDriverName()
		{
			ApiInstance = new HclApi(Config);
            ModelObject = new HclSupportedDriverName();
            MethodName = "CreateHclSupportedDriverNameWithHttpInfo";
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
        /// <para type="description">"Vendor distributing the Operating System."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string OsVendor {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Version of the Operating System."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string OsVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HclProduct> ProductList {
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
    /// <para type="synopsis">This is the cmdlet to Get HclExemptedCatalog.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHclExemptedCatalog", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHclExemptedCatalog:GetCmdletBase
	{
		public GetIntersightHclExemptedCatalog()
		{
			ApiInstance = new HclApi(Config);
            MethodName = "GetHclExemptedCatalogListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get HclOperatingSystem.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightHclOperatingSystem", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightHclOperatingSystem:GetCmdletBase
	{
		public GetIntersightHclOperatingSystem()
		{
			ApiInstance = new HclApi(Config);
            MethodName = "GetHclOperatingSystemListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New HclCompatibilityStatus.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightHclCompatibilityStatus")]
    public class NewIntersightHclCompatibilityStatus:NewCmdletBase
	{
		public NewIntersightHclCompatibilityStatus()
		{
			ApiInstance = new HclApi(Config);
            ModelObject = new HclCompatibilityStatus();
            MethodName = "CreateHclCompatibilityStatusWithHttpInfo";
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
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<HclHardwareCompatibilityProfile> ProfileList {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of the request to be served.\n* `FillSupportedVersions` - Responds with the supported firmware and driver versions. The API doesn't expect firmware and driver versions to be passed in the request and ignores if passed.\n* `CheckCompatibility` - Checks the compatibility for the given firmware and driver versions. This request type expects the firmware and driver versions to filled and the service validates the values and responds back with the error codes.\n* `GetRecommendedDrivers` - Responds with the supported drivers. The API expects firmware version to be filled. The API populates driver ISO url for the given server model. Today the link is same for all servers managed by UCSM whereas it depends on the model for Standalone servers."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HclCompatibilityStatus.RequestTypeEnum RequestType {
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
    /// <para type="synopsis">This is the cmdlet to Set HclHyperflexSoftwareCompatibilityInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightHclHyperflexSoftwareCompatibilityInfo")]
    public class SetIntersightHclHyperflexSoftwareCompatibilityInfo:SetCmdletBase
	{
		public SetIntersightHclHyperflexSoftwareCompatibilityInfo()
		{
			ApiInstance = new HclApi(Config);
            ModelObject = new HclHyperflexSoftwareCompatibilityInfo();
            MethodName = "UpdateHclHyperflexSoftwareCompatibilityInfoWithHttpInfo";
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
        
        public List<HclConstraint> Constraints {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"HXDP component software version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string HxdpVersion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type fo Hypervisor the HyperFlex components versions are compatible with. For example ESX, Hyperv or KVM.\n* `ESXi` - The hypervisor running on the HyperFlex cluster is a Vmware ESXi hypervisor of any version.\n* `HyperFlexAp` - The hypervisor running on the HyperFlex cluster is Cisco HyperFlex Application Platform.\n* `Hyper-V` - The hypervisor running on the HyperFlex cluster is Microsoft Hyper-V.\n* `Unknown` - The hypervisor running on the HyperFlex cluster is not known."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public HclHyperflexSoftwareCompatibilityInfo.HypervisorTypeEnum HypervisorType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Hypervisor component software version."</para>
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
        /// <para type="description">"UCS Server Firmware component software version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ServerFwVersion {
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
    /// <para type="synopsis">This is the cmdlet to Remove HclHyperflexSoftwareCompatibilityInfo.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightHclHyperflexSoftwareCompatibilityInfo")]
    public class RemoveIntersightHclHyperflexSoftwareCompatibilityInfo:RemoveCmdletBase
	{
		public RemoveIntersightHclHyperflexSoftwareCompatibilityInfo()
		{
			ApiInstance = new HclApi(Config);
            MethodName = "DeleteHclHyperflexSoftwareCompatibilityInfoWithHttpInfo";
		}
    }
}