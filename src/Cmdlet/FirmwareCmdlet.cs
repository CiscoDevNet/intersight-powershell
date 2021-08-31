using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FirmwareDistributableMeta.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFirmwareDistributableMeta", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFirmwareDistributableMeta:GetCmdletBase
	{
		public GetIntersightFirmwareDistributableMeta()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "GetFirmwareDistributableMetaListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FirmwareDriveDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFirmwareDriveDescriptor")]
    public class SetIntersightFirmwareDriveDescriptor:SetCmdletBase
	{
		public SetIntersightFirmwareDriveDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            ModelObject = new FirmwareDriveDescriptor();
            MethodName = "UpdateFirmwareDriveDescriptorWithHttpInfo";
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
        /// <para type="description">"The brand string of the endpoint for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string BrandString {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<CapabilityCapabilityRelationship> Capabilities {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The label type for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
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
        /// <para type="description">"The revision for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Revision {
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
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vendor {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FirmwareDriveDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFirmwareDriveDescriptor")]
    public class RemoveIntersightFirmwareDriveDescriptor:RemoveCmdletBase
	{
		public RemoveIntersightFirmwareDriveDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "DeleteFirmwareDriveDescriptorWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FirmwareDimmDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFirmwareDimmDescriptor")]
    public class SetIntersightFirmwareDimmDescriptor:SetCmdletBase
	{
		public SetIntersightFirmwareDimmDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            ModelObject = new FirmwareDimmDescriptor();
            MethodName = "UpdateFirmwareDimmDescriptorWithHttpInfo";
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
        /// <para type="description">"The brand string of the endpoint for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string BrandString {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<CapabilityCapabilityRelationship> Capabilities {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The label type for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
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
        /// <para type="description">"The revision for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Revision {
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
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vendor {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FirmwareDimmDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFirmwareDimmDescriptor")]
    public class RemoveIntersightFirmwareDimmDescriptor:RemoveCmdletBase
	{
		public RemoveIntersightFirmwareDimmDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "DeleteFirmwareDimmDescriptorWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FirmwareHbaDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFirmwareHbaDescriptor", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFirmwareHbaDescriptor:GetCmdletBase
	{
		public GetIntersightFirmwareHbaDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "GetFirmwareHbaDescriptorListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FirmwareHbaDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFirmwareHbaDescriptor")]
    public class NewIntersightFirmwareHbaDescriptor:NewCmdletBase
	{
		public NewIntersightFirmwareHbaDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            ModelObject = new FirmwareHbaDescriptor();
            MethodName = "CreateFirmwareHbaDescriptorWithHttpInfo";
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
        /// <para type="description">"The brand string of the endpoint for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string BrandString {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<CapabilityCapabilityRelationship> Capabilities {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The label type for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Model {
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
        /// <para type="description">"The revision for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Revision {
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
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vendor {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FirmwarePcieDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFirmwarePcieDescriptor", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFirmwarePcieDescriptor:GetCmdletBase
	{
		public GetIntersightFirmwarePcieDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "GetFirmwarePcieDescriptorListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FirmwarePcieDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFirmwarePcieDescriptor")]
    public class NewIntersightFirmwarePcieDescriptor:NewCmdletBase
	{
		public NewIntersightFirmwarePcieDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            ModelObject = new FirmwarePcieDescriptor();
            MethodName = "CreateFirmwarePcieDescriptorWithHttpInfo";
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
        /// <para type="description">"The brand string of the endpoint for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string BrandString {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<CapabilityCapabilityRelationship> Capabilities {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The label type for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Model {
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
        /// <para type="description">"The revision for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Revision {
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
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vendor {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FirmwarePsuDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFirmwarePsuDescriptor", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFirmwarePsuDescriptor:GetCmdletBase
	{
		public GetIntersightFirmwarePsuDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "GetFirmwarePsuDescriptorListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FirmwarePsuDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFirmwarePsuDescriptor")]
    public class NewIntersightFirmwarePsuDescriptor:NewCmdletBase
	{
		public NewIntersightFirmwarePsuDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            ModelObject = new FirmwarePsuDescriptor();
            MethodName = "CreateFirmwarePsuDescriptorWithHttpInfo";
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
        /// <para type="description">"The brand string of the endpoint for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string BrandString {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<CapabilityCapabilityRelationship> Capabilities {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The label type for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Model {
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
        /// <para type="description">"The revision for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Revision {
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
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vendor {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FirmwareServerConfigurationUtilityDistributable.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFirmwareServerConfigurationUtilityDistributable")]
    public class RemoveIntersightFirmwareServerConfigurationUtilityDistributable:RemoveCmdletBase
	{
		public RemoveIntersightFirmwareServerConfigurationUtilityDistributable()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "DeleteFirmwareServerConfigurationUtilityDistributableWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FirmwareServerConfigurationUtilityDistributable.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFirmwareServerConfigurationUtilityDistributable")]
    public class SetIntersightFirmwareServerConfigurationUtilityDistributable:SetCmdletBase
	{
		public SetIntersightFirmwareServerConfigurationUtilityDistributable()
		{
			ApiInstance = new FirmwareApi(Config);
            ModelObject = new FirmwareServerConfigurationUtilityDistributable();
            MethodName = "UpdateFirmwareServerConfigurationUtilityDistributableWithHttpInfo";
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
        /// <para type="description">"A reference to a softwarerepositoryCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SoftwarerepositoryCatalogRelationship Catalog {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<FirmwareComponentMeta> ComponentMeta {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User provided description about the file. Cisco provided description for image inventoried from a Cisco repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to firmwareDistributableMeta resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<FirmwareDistributableMetaRelationship> DistributableMetas {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of image which the distributable falls into according to the component it can upgrade. For e.g.; Standalone server, Intersight managed server, UCS Managed Fabric Interconnect. The field is used in private appliance mode, where image does not have description populated from CCO."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ImageType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The action to be performed on the imported file. If 'PreCache' is set, the image will be cached in Appliance. Applicable in Intersight appliance deployment. If 'Evict' is set, the cached file will be removed. Applicable in Intersight appliance deployment. If 'GeneratePreSignedUploadUrl' is set, generates pre signed URL (s) for the file to be imported into the repository. Applicable for local machine source. The URL (s) will be populated under LocalMachine file server. If 'CompleteImportProcess' is set, the ImportState is marked as 'Imported'. Applicable for local machine source. If 'Cancel' is set, the ImportState is marked as 'Failed'. Applicable for local machine source.\n* `None` - No action should be taken on the imported file.\n* `GeneratePreSignedUploadUrl` - Generate pre signed URL of file for importing into the repository.\n* `GeneratePreSignedDownloadUrl` - Generate pre signed URL of file in the repository to download.\n* `CompleteImportProcess` - Mark that the import process of the file into the repository is complete.\n* `MarkImportFailed` - Mark to indicate that the import process of the file into the repository failed.\n* `PreCache` - Cache the file into the Intersight Appliance.\n* `Cancel` - The cancel import process for the file into the repository.\n* `Extract` - The action to extract the file in the external repository.\n* `Evict` - Evict the cached file from the Intersight Appliance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareServerConfigurationUtilityDistributable.ImportActionEnum ImportAction {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The MD5 ETag for a file that is stored in Intersight repository or in the appliance cache. Warning - MD5 is currently broken and this will be migrated to SHA shortly."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Md5eTag {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The md5sum checksum of the file. This information is available for all Cisco distributed images and files imported to the local repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Md5sum {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The mdfid of the image provided by cisco.com."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Mdfid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The endpoint model for which this firmware image is applicable."</para>
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
        /// <para type="description">"The name of the file. It is populated as part of the image import operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The build which is recommended by Cisco."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecommendedBuild {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a softwarerepositoryRelease resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SoftwarerepositoryReleaseRelationship Release {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The url for the release notes of this image."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ReleaseNotesUrl {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The sha512sum of the file. This information is available for all Cisco distributed images and files imported to the local repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Sha512sum {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The size (in bytes) of the file. This information is available for all Cisco distributed images and files imported to the local repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Size {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The software advisory, if any, provided by the vendor for this file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SoftwareAdvisoryUrl {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Location of the file in an external repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SoftwarerepositoryFileServer Source {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> SupportedModels {
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
        /// <para type="description">"The vendor or publisher of this file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vendor {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Vendor provided version for the file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FirmwareUpgradeImpactStatus.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFirmwareUpgradeImpactStatus", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFirmwareUpgradeImpactStatus:GetCmdletBase
	{
		public GetIntersightFirmwareUpgradeImpactStatus()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "GetFirmwareUpgradeImpactStatusListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FirmwareNxosDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFirmwareNxosDescriptor", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFirmwareNxosDescriptor:GetCmdletBase
	{
		public GetIntersightFirmwareNxosDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "GetFirmwareNxosDescriptorListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FirmwareNxosDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFirmwareNxosDescriptor")]
    public class NewIntersightFirmwareNxosDescriptor:NewCmdletBase
	{
		public NewIntersightFirmwareNxosDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            ModelObject = new FirmwareNxosDescriptor();
            MethodName = "CreateFirmwareNxosDescriptorWithHttpInfo";
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
        /// <para type="description">"The brand string of the endpoint for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string BrandString {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<CapabilityCapabilityRelationship> Capabilities {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The label type for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Model {
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
        /// <para type="description">"The revision for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Revision {
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
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vendor {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FirmwareDriveDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFirmwareDriveDescriptor", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFirmwareDriveDescriptor:GetCmdletBase
	{
		public GetIntersightFirmwareDriveDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "GetFirmwareDriveDescriptorListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FirmwareDriveDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFirmwareDriveDescriptor")]
    public class NewIntersightFirmwareDriveDescriptor:NewCmdletBase
	{
		public NewIntersightFirmwareDriveDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            ModelObject = new FirmwareDriveDescriptor();
            MethodName = "CreateFirmwareDriveDescriptorWithHttpInfo";
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
        /// <para type="description">"The brand string of the endpoint for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string BrandString {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<CapabilityCapabilityRelationship> Capabilities {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The label type for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Model {
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
        /// <para type="description">"The revision for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Revision {
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
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vendor {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FirmwareBiosDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFirmwareBiosDescriptor")]
    public class SetIntersightFirmwareBiosDescriptor:SetCmdletBase
	{
		public SetIntersightFirmwareBiosDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            ModelObject = new FirmwareBiosDescriptor();
            MethodName = "UpdateFirmwareBiosDescriptorWithHttpInfo";
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
        /// <para type="description">"The brand string of the endpoint for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string BrandString {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<CapabilityCapabilityRelationship> Capabilities {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The label type for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
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
        /// <para type="description">"The revision for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Revision {
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
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vendor {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FirmwareBiosDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFirmwareBiosDescriptor")]
    public class RemoveIntersightFirmwareBiosDescriptor:RemoveCmdletBase
	{
		public RemoveIntersightFirmwareBiosDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "DeleteFirmwareBiosDescriptorWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FirmwareDimmDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFirmwareDimmDescriptor", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFirmwareDimmDescriptor:GetCmdletBase
	{
		public GetIntersightFirmwareDimmDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "GetFirmwareDimmDescriptorListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FirmwareDimmDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFirmwareDimmDescriptor")]
    public class NewIntersightFirmwareDimmDescriptor:NewCmdletBase
	{
		public NewIntersightFirmwareDimmDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            ModelObject = new FirmwareDimmDescriptor();
            MethodName = "CreateFirmwareDimmDescriptorWithHttpInfo";
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
        /// <para type="description">"The brand string of the endpoint for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string BrandString {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<CapabilityCapabilityRelationship> Capabilities {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The label type for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Model {
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
        /// <para type="description">"The revision for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Revision {
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
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vendor {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FirmwareIomDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFirmwareIomDescriptor")]
    public class SetIntersightFirmwareIomDescriptor:SetCmdletBase
	{
		public SetIntersightFirmwareIomDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            ModelObject = new FirmwareIomDescriptor();
            MethodName = "UpdateFirmwareIomDescriptorWithHttpInfo";
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
        /// <para type="description">"The brand string of the endpoint for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string BrandString {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<CapabilityCapabilityRelationship> Capabilities {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The label type for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
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
        /// <para type="description">"The revision for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Revision {
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
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vendor {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FirmwareIomDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFirmwareIomDescriptor")]
    public class RemoveIntersightFirmwareIomDescriptor:RemoveCmdletBase
	{
		public RemoveIntersightFirmwareIomDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "DeleteFirmwareIomDescriptorWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FirmwareNxosDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFirmwareNxosDescriptor")]
    public class SetIntersightFirmwareNxosDescriptor:SetCmdletBase
	{
		public SetIntersightFirmwareNxosDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            ModelObject = new FirmwareNxosDescriptor();
            MethodName = "UpdateFirmwareNxosDescriptorWithHttpInfo";
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
        /// <para type="description">"The brand string of the endpoint for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string BrandString {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<CapabilityCapabilityRelationship> Capabilities {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The label type for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
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
        /// <para type="description">"The revision for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Revision {
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
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vendor {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FirmwareNxosDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFirmwareNxosDescriptor")]
    public class RemoveIntersightFirmwareNxosDescriptor:RemoveCmdletBase
	{
		public RemoveIntersightFirmwareNxosDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "DeleteFirmwareNxosDescriptorWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FirmwareDistributable.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFirmwareDistributable")]
    public class SetIntersightFirmwareDistributable:SetCmdletBase
	{
		public SetIntersightFirmwareDistributable()
		{
			ApiInstance = new FirmwareApi(Config);
            ModelObject = new FirmwareDistributable();
            MethodName = "UpdateFirmwareDistributableWithHttpInfo";
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
        /// <para type="description">"A reference to a softwarerepositoryCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SoftwarerepositoryCatalogRelationship Catalog {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<FirmwareComponentMeta> ComponentMeta {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User provided description about the file. Cisco provided description for image inventoried from a Cisco repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to firmwareDistributableMeta resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<FirmwareDistributableMetaRelationship> DistributableMetas {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The file location of the distributable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FileLocation {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The category into which the distributable falls into according to the supported platform series. For e.g.; C-Series/B-Series/Infrastructure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ImageCategory {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of image which the distributable falls into according to the component it can upgrade. For e.g.; Standalone server, Intersight managed server, UCS Managed Fabric Interconnect. The field is used in private appliance mode, where image does not have description populated from CCO."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ImageType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The action to be performed on the imported file. If 'PreCache' is set, the image will be cached in Appliance. Applicable in Intersight appliance deployment. If 'Evict' is set, the cached file will be removed. Applicable in Intersight appliance deployment. If 'GeneratePreSignedUploadUrl' is set, generates pre signed URL (s) for the file to be imported into the repository. Applicable for local machine source. The URL (s) will be populated under LocalMachine file server. If 'CompleteImportProcess' is set, the ImportState is marked as 'Imported'. Applicable for local machine source. If 'Cancel' is set, the ImportState is marked as 'Failed'. Applicable for local machine source.\n* `None` - No action should be taken on the imported file.\n* `GeneratePreSignedUploadUrl` - Generate pre signed URL of file for importing into the repository.\n* `GeneratePreSignedDownloadUrl` - Generate pre signed URL of file in the repository to download.\n* `CompleteImportProcess` - Mark that the import process of the file into the repository is complete.\n* `MarkImportFailed` - Mark to indicate that the import process of the file into the repository failed.\n* `PreCache` - Cache the file into the Intersight Appliance.\n* `Cancel` - The cancel import process for the file into the repository.\n* `Extract` - The action to extract the file in the external repository.\n* `Evict` - Evict the cached file from the Intersight Appliance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareDistributable.ImportActionEnum ImportAction {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The MD5 ETag for a file that is stored in Intersight repository or in the appliance cache. Warning - MD5 is currently broken and this will be migrated to SHA shortly."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Md5eTag {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The md5sum checksum of the file. This information is available for all Cisco distributed images and files imported to the local repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Md5sum {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The mdfid of the image provided by cisco.com."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Mdfid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The endpoint model for which this firmware image is applicable."</para>
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
        /// <para type="description">"The name of the file. It is populated as part of the image import operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The source of the distributable. If it has been created by the user or system.\n* `System` - The distributable has been created by the System.\n* `User` - The distributable has been created by the User."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareDistributable.OriginEnum Origin {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The build which is recommended by Cisco."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecommendedBuild {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a softwarerepositoryRelease resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SoftwarerepositoryReleaseRelationship Release {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The url for the release notes of this image."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ReleaseNotesUrl {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The sha512sum of the file. This information is available for all Cisco distributed images and files imported to the local repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Sha512sum {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The size (in bytes) of the file. This information is available for all Cisco distributed images and files imported to the local repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Size {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The software advisory, if any, provided by the vendor for this file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SoftwareAdvisoryUrl {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Location of the file in an external repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SoftwarerepositoryFileServer Source {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> SupportedModels {
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
        /// <para type="description">"The vendor or publisher of this file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vendor {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Vendor provided version for the file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FirmwareDistributable.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFirmwareDistributable")]
    public class RemoveIntersightFirmwareDistributable:RemoveCmdletBase
	{
		public RemoveIntersightFirmwareDistributable()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "DeleteFirmwareDistributableWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FirmwareUpgradeImpact.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFirmwareUpgradeImpact")]
    public class NewIntersightFirmwareUpgradeImpact:NewCmdletBase
	{
		public NewIntersightFirmwareUpgradeImpact()
		{
			ApiInstance = new FirmwareApi(Config);
            ModelObject = new FirmwareUpgradeImpact();
            MethodName = "CreateFirmwareUpgradeImpactWithHttpInfo";
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
        /// <para type="description">"An array of relationships to equipmentChassis resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<EquipmentChassisRelationship> Chassis {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> Components {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Captures the status of an upgrade impact calculation. Indicates whether the calculation is complete, in progress or the calculation is impossible due to the absence of the target image on the endpoint.\n* `Inprogress` - Upgrade impact calculation is in progress.\n* `Completed` - Upgrade impact calculation is completed.\n* `Unavailable` - Upgrade impact is not available since image is not present in FI."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareUpgradeImpact.ComputationStateEnum ComputationState {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a firmwareDistributable resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareDistributableRelationship Distributable {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> ExcludeComponents {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<FirmwareBaseImpact> Impacts {
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
        /// <para type="description">"An array of relationships to networkElement resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<NetworkElementRelationship> NetworkElements {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a softwarerepositoryRelease resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SoftwarerepositoryReleaseRelationship Release {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to computePhysical resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<ComputePhysicalRelationship> Server {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The summary on the component or components getting impacted by the upgrade.\n* `Basic` - Summary of a single instance involved in the upgrade operation.\n* `Detail` - Summary of the collection of single instances for a complex component involved in the upgrade operation. For example, in case of a server upgrade, a detailed summary indicates impact of all the single instances which are part of the server, such as storage controller, drives, and BIOS."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareUpgradeImpact.SummaryEnum Summary {
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
    /// <para type="synopsis">This is the cmdlet to Remove FirmwareChassisUpgrade.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFirmwareChassisUpgrade")]
    public class RemoveIntersightFirmwareChassisUpgrade:RemoveCmdletBase
	{
		public RemoveIntersightFirmwareChassisUpgrade()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "DeleteFirmwareChassisUpgradeWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FirmwareUnsupportedVersionUpgrade.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFirmwareUnsupportedVersionUpgrade")]
    public class RemoveIntersightFirmwareUnsupportedVersionUpgrade:RemoveCmdletBase
	{
		public RemoveIntersightFirmwareUnsupportedVersionUpgrade()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "DeleteFirmwareUnsupportedVersionUpgradeWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FirmwareUnsupportedVersionUpgrade.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFirmwareUnsupportedVersionUpgrade")]
    public class SetIntersightFirmwareUnsupportedVersionUpgrade:SetCmdletBase
	{
		public SetIntersightFirmwareUnsupportedVersionUpgrade()
		{
			ApiInstance = new FirmwareApi(Config);
            ModelObject = new FirmwareUnsupportedVersionUpgrade();
            MethodName = "UpdateFirmwareUnsupportedVersionUpgradeWithHttpInfo";
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
        /// <para type="description">"The checksum of the downloaded file as calculated by the download plugin after successfully downloading a file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ConnectorFileChecksum Checksum {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a firmwareDistributable resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareDistributableRelationship Distributable {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Any error encountered. Set to empty when download is in progress or completed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DownloadError {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The download progress of the file represented as a percentage between 0% and 100%. If progress reporting is not possible a value of -1 is sent."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long DownloadProgress {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of retries the plugin attempted before succeeding or failing the download."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long DownloadRetries {
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
        /// <para type="description">"A reference to a equipmentPhysicalIdentity resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public EquipmentPhysicalIdentityRelationship PhysicalIdentity {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The sha256checksum of the downloaded file as calculated by the download plugin after successfully downloading a file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public byte Sha256checksum {
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
        /// <para type="description">"Workflow status of firmware upgrade.\n* `None` - Upgrade status is none when upgrade is in progress.\n* `Completed` - Upgrade completed successfully.\n* `Failed` - Upgrade status is failed when upgrade has failed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareUnsupportedVersionUpgrade.UpgradeStatusEnum UpgradeStatus {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FirmwareBoardControllerDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFirmwareBoardControllerDescriptor", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFirmwareBoardControllerDescriptor:GetCmdletBase
	{
		public GetIntersightFirmwareBoardControllerDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "GetFirmwareBoardControllerDescriptorListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FirmwareBoardControllerDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFirmwareBoardControllerDescriptor")]
    public class NewIntersightFirmwareBoardControllerDescriptor:NewCmdletBase
	{
		public NewIntersightFirmwareBoardControllerDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            ModelObject = new FirmwareBoardControllerDescriptor();
            MethodName = "CreateFirmwareBoardControllerDescriptorWithHttpInfo";
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
        /// <para type="description">"The brand string of the endpoint for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string BrandString {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<CapabilityCapabilityRelationship> Capabilities {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The label type for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Model {
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
        /// <para type="description">"The revision for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Revision {
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
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vendor {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FirmwareGpuDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFirmwareGpuDescriptor", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFirmwareGpuDescriptor:GetCmdletBase
	{
		public GetIntersightFirmwareGpuDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "GetFirmwareGpuDescriptorListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FirmwareGpuDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFirmwareGpuDescriptor")]
    public class NewIntersightFirmwareGpuDescriptor:NewCmdletBase
	{
		public NewIntersightFirmwareGpuDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            ModelObject = new FirmwareGpuDescriptor();
            MethodName = "CreateFirmwareGpuDescriptorWithHttpInfo";
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
        /// <para type="description">"The brand string of the endpoint for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string BrandString {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<CapabilityCapabilityRelationship> Capabilities {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The label type for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Model {
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
        /// <para type="description">"The revision for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Revision {
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
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vendor {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FirmwarePsuDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFirmwarePsuDescriptor")]
    public class SetIntersightFirmwarePsuDescriptor:SetCmdletBase
	{
		public SetIntersightFirmwarePsuDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            ModelObject = new FirmwarePsuDescriptor();
            MethodName = "PatchFirmwarePsuDescriptorWithHttpInfo";
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
        /// <para type="description">"The brand string of the endpoint for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string BrandString {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<CapabilityCapabilityRelationship> Capabilities {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The label type for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
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
        /// <para type="description">"The revision for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Revision {
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
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vendor {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FirmwarePsuDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFirmwarePsuDescriptor")]
    public class RemoveIntersightFirmwarePsuDescriptor:RemoveCmdletBase
	{
		public RemoveIntersightFirmwarePsuDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "DeleteFirmwarePsuDescriptorWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FirmwareSwitchUpgrade.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFirmwareSwitchUpgrade")]
    public class RemoveIntersightFirmwareSwitchUpgrade:RemoveCmdletBase
	{
		public RemoveIntersightFirmwareSwitchUpgrade()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "DeleteFirmwareSwitchUpgradeWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FirmwareBiosDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFirmwareBiosDescriptor", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFirmwareBiosDescriptor:GetCmdletBase
	{
		public GetIntersightFirmwareBiosDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "GetFirmwareBiosDescriptorListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FirmwareBiosDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFirmwareBiosDescriptor")]
    public class NewIntersightFirmwareBiosDescriptor:NewCmdletBase
	{
		public NewIntersightFirmwareBiosDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            ModelObject = new FirmwareBiosDescriptor();
            MethodName = "CreateFirmwareBiosDescriptorWithHttpInfo";
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
        /// <para type="description">"The brand string of the endpoint for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string BrandString {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<CapabilityCapabilityRelationship> Capabilities {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The label type for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Model {
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
        /// <para type="description">"The revision for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Revision {
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
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vendor {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FirmwareSwitchUpgrade.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFirmwareSwitchUpgrade", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFirmwareSwitchUpgrade:GetCmdletBase
	{
		public GetIntersightFirmwareSwitchUpgrade()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "GetFirmwareSwitchUpgradeListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FirmwareSwitchUpgrade.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFirmwareSwitchUpgrade")]
    public class NewIntersightFirmwareSwitchUpgrade:NewCmdletBase
	{
		public NewIntersightFirmwareSwitchUpgrade()
		{
			ApiInstance = new FirmwareApi(Config);
            ModelObject = new FirmwareSwitchUpgrade();
            MethodName = "CreateFirmwareSwitchUpgradeWithHttpInfo";
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
        /// <para type="description">"Direct download options in case the upgradeType is direct download based upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareDirectDownload DirectDownload {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a firmwareDistributable resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareDistributableRelationship Distributable {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The flag to enable or disable fabric evacuation during the switch firmware upgrade. In case of IMM, it is mandatory to have the Fabric Interconnects associated with domain profile for fabric evacuation to happen."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool EnableFabricEvacuation {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Location of the image in user software repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SoftwarerepositoryFileServer FileServer {
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
        /// <para type="description">"An array of relationships to networkElement resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<NetworkElementRelationship> NetworkElements {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Deprecated (Use 'fileServer' property). Network share options in case of the upgradeType is network share based upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareNetworkShare NetworkShare {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a softwarerepositoryRelease resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SoftwarerepositoryReleaseRelationship Release {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User has the option to skip the estimate impact calculation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool SkipEstimateImpact {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Status of the upgrade operation.\n* `NONE` - Upgrade status is not populated.\n* `IN_PROGRESS` - The upgrade is in progress.\n* `SUCCESSFUL` - The upgrade successfully completed.\n* `FAILED` - The upgrade shows failed status.\n* `TERMINATED` - The upgrade has been terminated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareSwitchUpgrade.StatusEnum Status {
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
        /// <para type="description">"Desired upgrade mode to choose either direct download based upgrade or network share upgrade.\n* `direct_upgrade` - Upgrade mode is direct download.\n* `network_upgrade` - Upgrade mode is network upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareSwitchUpgrade.UpgradeTypeEnum UpgradeType {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FirmwareHbaDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFirmwareHbaDescriptor")]
    public class RemoveIntersightFirmwareHbaDescriptor:RemoveCmdletBase
	{
		public RemoveIntersightFirmwareHbaDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "DeleteFirmwareHbaDescriptorWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FirmwareHbaDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFirmwareHbaDescriptor")]
    public class SetIntersightFirmwareHbaDescriptor:SetCmdletBase
	{
		public SetIntersightFirmwareHbaDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            ModelObject = new FirmwareHbaDescriptor();
            MethodName = "UpdateFirmwareHbaDescriptorWithHttpInfo";
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
        /// <para type="description">"The brand string of the endpoint for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string BrandString {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<CapabilityCapabilityRelationship> Capabilities {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The label type for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
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
        /// <para type="description">"The revision for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Revision {
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
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vendor {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FirmwareUnsupportedVersionUpgrade.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFirmwareUnsupportedVersionUpgrade", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFirmwareUnsupportedVersionUpgrade:GetCmdletBase
	{
		public GetIntersightFirmwareUnsupportedVersionUpgrade()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "GetFirmwareUnsupportedVersionUpgradeListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FirmwareUnsupportedVersionUpgrade.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFirmwareUnsupportedVersionUpgrade")]
    public class NewIntersightFirmwareUnsupportedVersionUpgrade:NewCmdletBase
	{
		public NewIntersightFirmwareUnsupportedVersionUpgrade()
		{
			ApiInstance = new FirmwareApi(Config);
            ModelObject = new FirmwareUnsupportedVersionUpgrade();
            MethodName = "CreateFirmwareUnsupportedVersionUpgradeWithHttpInfo";
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
        /// <para type="description">"The checksum of the downloaded file as calculated by the download plugin after successfully downloading a file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ConnectorFileChecksum Checksum {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a firmwareDistributable resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareDistributableRelationship Distributable {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Any error encountered. Set to empty when download is in progress or completed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DownloadError {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The download progress of the file represented as a percentage between 0% and 100%. If progress reporting is not possible a value of -1 is sent."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long DownloadProgress {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of retries the plugin attempted before succeeding or failing the download."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long DownloadRetries {
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
        /// <para type="description">"A reference to a equipmentPhysicalIdentity resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public EquipmentPhysicalIdentityRelationship PhysicalIdentity {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The sha256checksum of the downloaded file as calculated by the download plugin after successfully downloading a file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public byte Sha256checksum {
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
        /// <para type="description">"Workflow status of firmware upgrade.\n* `None` - Upgrade status is none when upgrade is in progress.\n* `Completed` - Upgrade completed successfully.\n* `Failed` - Upgrade status is failed when upgrade has failed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareUnsupportedVersionUpgrade.UpgradeStatusEnum UpgradeStatus {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FirmwareUpgrade.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFirmwareUpgrade", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFirmwareUpgrade:GetCmdletBase
	{
		public GetIntersightFirmwareUpgrade()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "GetFirmwareUpgradeListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FirmwareUpgrade.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFirmwareUpgrade")]
    public class NewIntersightFirmwareUpgrade:NewCmdletBase
	{
		public NewIntersightFirmwareUpgrade()
		{
			ApiInstance = new FirmwareApi(Config);
            ModelObject = new FirmwareUpgrade();
            MethodName = "CreateFirmwareUpgradeWithHttpInfo";
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
        /// <para type="description">"Direct download options in case the upgradeType is direct download based upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareDirectDownload DirectDownload {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a firmwareDistributable resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareDistributableRelationship Distributable {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> ExcludeComponentList {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Location of the image in user software repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SoftwarerepositoryFileServer FileServer {
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
        /// <para type="description">"Deprecated (Use 'fileServer' property). Network share options in case of the upgradeType is network share based upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareNetworkShare NetworkShare {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a softwarerepositoryRelease resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SoftwarerepositoryReleaseRelationship Release {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a computePhysical resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public ComputePhysicalRelationship Server {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User has the option to skip the estimate impact calculation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool SkipEstimateImpact {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Status of the upgrade operation.\n* `NONE` - Upgrade status is not populated.\n* `IN_PROGRESS` - The upgrade is in progress.\n* `SUCCESSFUL` - The upgrade successfully completed.\n* `FAILED` - The upgrade shows failed status.\n* `TERMINATED` - The upgrade has been terminated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareUpgrade.StatusEnum Status {
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
        /// <para type="description">"Desired upgrade mode to choose either direct download based upgrade or network share upgrade.\n* `direct_upgrade` - Upgrade mode is direct download.\n* `network_upgrade` - Upgrade mode is network upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareUpgrade.UpgradeTypeEnum UpgradeType {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FirmwareRunningFirmware.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFirmwareRunningFirmware", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFirmwareRunningFirmware:GetCmdletBase
	{
		public GetIntersightFirmwareRunningFirmware()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "GetFirmwareRunningFirmwareListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FirmwareBoardControllerDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFirmwareBoardControllerDescriptor")]
    public class SetIntersightFirmwareBoardControllerDescriptor:SetCmdletBase
	{
		public SetIntersightFirmwareBoardControllerDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            ModelObject = new FirmwareBoardControllerDescriptor();
            MethodName = "UpdateFirmwareBoardControllerDescriptorWithHttpInfo";
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
        /// <para type="description">"The brand string of the endpoint for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string BrandString {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<CapabilityCapabilityRelationship> Capabilities {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The label type for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
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
        /// <para type="description">"The revision for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Revision {
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
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vendor {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FirmwareBoardControllerDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFirmwareBoardControllerDescriptor")]
    public class RemoveIntersightFirmwareBoardControllerDescriptor:RemoveCmdletBase
	{
		public RemoveIntersightFirmwareBoardControllerDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "DeleteFirmwareBoardControllerDescriptorWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FirmwareEula.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFirmwareEula")]
    public class NewIntersightFirmwareEula:NewCmdletBase
	{
		public NewIntersightFirmwareEula()
		{
			ApiInstance = new FirmwareApi(Config);
            ModelObject = new FirmwareEula();
            MethodName = "CreateFirmwareEulaWithHttpInfo";
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
        
        public List<MoTag> Tags {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FirmwareEula.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFirmwareEula", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFirmwareEula:GetCmdletBase
	{
		public GetIntersightFirmwareEula()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "GetFirmwareEulaListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FirmwareCimcDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFirmwareCimcDescriptor", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFirmwareCimcDescriptor:GetCmdletBase
	{
		public GetIntersightFirmwareCimcDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "GetFirmwareCimcDescriptorListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FirmwareCimcDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFirmwareCimcDescriptor")]
    public class NewIntersightFirmwareCimcDescriptor:NewCmdletBase
	{
		public NewIntersightFirmwareCimcDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            ModelObject = new FirmwareCimcDescriptor();
            MethodName = "CreateFirmwareCimcDescriptorWithHttpInfo";
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
        /// <para type="description">"The brand string of the endpoint for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string BrandString {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<CapabilityCapabilityRelationship> Capabilities {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The label type for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Model {
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
        /// <para type="description">"The revision for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Revision {
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
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vendor {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FirmwareDriverDistributable.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFirmwareDriverDistributable")]
    public class RemoveIntersightFirmwareDriverDistributable:RemoveCmdletBase
	{
		public RemoveIntersightFirmwareDriverDistributable()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "DeleteFirmwareDriverDistributableWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FirmwareDriverDistributable.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFirmwareDriverDistributable")]
    public class SetIntersightFirmwareDriverDistributable:SetCmdletBase
	{
		public SetIntersightFirmwareDriverDistributable()
		{
			ApiInstance = new FirmwareApi(Config);
            ModelObject = new FirmwareDriverDistributable();
            MethodName = "UpdateFirmwareDriverDistributableWithHttpInfo";
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
        /// <para type="description">"A reference to a softwarerepositoryCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SoftwarerepositoryCatalogRelationship Catalog {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The device type on which the driver is installable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Category {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<FirmwareComponentMeta> ComponentMeta {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User provided description about the file. Cisco provided description for image inventoried from a Cisco repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates in which directory path this driver will be added."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Directory {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to firmwareDistributableMeta resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<FirmwareDistributableMetaRelationship> DistributableMetas {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of image which the distributable falls into according to the component it can upgrade. For e.g.; Standalone server, Intersight managed server, UCS Managed Fabric Interconnect. The field is used in private appliance mode, where image does not have description populated from CCO."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ImageType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The action to be performed on the imported file. If 'PreCache' is set, the image will be cached in Appliance. Applicable in Intersight appliance deployment. If 'Evict' is set, the cached file will be removed. Applicable in Intersight appliance deployment. If 'GeneratePreSignedUploadUrl' is set, generates pre signed URL (s) for the file to be imported into the repository. Applicable for local machine source. The URL (s) will be populated under LocalMachine file server. If 'CompleteImportProcess' is set, the ImportState is marked as 'Imported'. Applicable for local machine source. If 'Cancel' is set, the ImportState is marked as 'Failed'. Applicable for local machine source.\n* `None` - No action should be taken on the imported file.\n* `GeneratePreSignedUploadUrl` - Generate pre signed URL of file for importing into the repository.\n* `GeneratePreSignedDownloadUrl` - Generate pre signed URL of file in the repository to download.\n* `CompleteImportProcess` - Mark that the import process of the file into the repository is complete.\n* `MarkImportFailed` - Mark to indicate that the import process of the file into the repository failed.\n* `PreCache` - Cache the file into the Intersight Appliance.\n* `Cancel` - The cancel import process for the file into the repository.\n* `Extract` - The action to extract the file in the external repository.\n* `Evict` - Evict the cached file from the Intersight Appliance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareDriverDistributable.ImportActionEnum ImportAction {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The MD5 ETag for a file that is stored in Intersight repository or in the appliance cache. Warning - MD5 is currently broken and this will be migrated to SHA shortly."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Md5eTag {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The md5sum checksum of the file. This information is available for all Cisco distributed images and files imported to the local repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Md5sum {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The mdfid of the image provided by cisco.com."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Mdfid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The endpoint model for which this firmware image is applicable."</para>
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
        /// <para type="description">"The name of the file. It is populated as part of the image import operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The operating system name to which this driver is compatible."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Osname {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"OS Version. It is populated as part of the image import operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Osversion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The build which is recommended by Cisco."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecommendedBuild {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a softwarerepositoryRelease resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SoftwarerepositoryReleaseRelationship Release {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The url for the release notes of this image."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ReleaseNotesUrl {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The sha512sum of the file. This information is available for all Cisco distributed images and files imported to the local repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Sha512sum {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The size (in bytes) of the file. This information is available for all Cisco distributed images and files imported to the local repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Size {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The software advisory, if any, provided by the vendor for this file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SoftwareAdvisoryUrl {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Location of the file in an external repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SoftwarerepositoryFileServer Source {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> SupportedModels {
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
        /// <para type="description">"The vendor or publisher of this file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vendor {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Vendor provided version for the file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FirmwareMswitchDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFirmwareMswitchDescriptor", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFirmwareMswitchDescriptor:GetCmdletBase
	{
		public GetIntersightFirmwareMswitchDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "GetFirmwareMswitchDescriptorListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FirmwareMswitchDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFirmwareMswitchDescriptor")]
    public class NewIntersightFirmwareMswitchDescriptor:NewCmdletBase
	{
		public NewIntersightFirmwareMswitchDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            ModelObject = new FirmwareMswitchDescriptor();
            MethodName = "CreateFirmwareMswitchDescriptorWithHttpInfo";
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
        /// <para type="description">"The brand string of the endpoint for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string BrandString {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<CapabilityCapabilityRelationship> Capabilities {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The label type for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Model {
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
        /// <para type="description">"The revision for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Revision {
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
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vendor {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FirmwareMswitchDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFirmwareMswitchDescriptor")]
    public class SetIntersightFirmwareMswitchDescriptor:SetCmdletBase
	{
		public SetIntersightFirmwareMswitchDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            ModelObject = new FirmwareMswitchDescriptor();
            MethodName = "UpdateFirmwareMswitchDescriptorWithHttpInfo";
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
        /// <para type="description">"The brand string of the endpoint for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string BrandString {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<CapabilityCapabilityRelationship> Capabilities {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The label type for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
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
        /// <para type="description">"The revision for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Revision {
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
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vendor {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FirmwareMswitchDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFirmwareMswitchDescriptor")]
    public class RemoveIntersightFirmwareMswitchDescriptor:RemoveCmdletBase
	{
		public RemoveIntersightFirmwareMswitchDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "DeleteFirmwareMswitchDescriptorWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FirmwareServerConfigurationUtilityDistributable.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFirmwareServerConfigurationUtilityDistributable")]
    public class NewIntersightFirmwareServerConfigurationUtilityDistributable:NewCmdletBase
	{
		public NewIntersightFirmwareServerConfigurationUtilityDistributable()
		{
			ApiInstance = new FirmwareApi(Config);
            ModelObject = new FirmwareServerConfigurationUtilityDistributable();
            MethodName = "CreateFirmwareServerConfigurationUtilityDistributableWithHttpInfo";
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
        /// <para type="description">"A reference to a softwarerepositoryCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SoftwarerepositoryCatalogRelationship Catalog {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<FirmwareComponentMeta> ComponentMeta {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User provided description about the file. Cisco provided description for image inventoried from a Cisco repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to firmwareDistributableMeta resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<FirmwareDistributableMetaRelationship> DistributableMetas {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of image which the distributable falls into according to the component it can upgrade. For e.g.; Standalone server, Intersight managed server, UCS Managed Fabric Interconnect. The field is used in private appliance mode, where image does not have description populated from CCO."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ImageType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The action to be performed on the imported file. If 'PreCache' is set, the image will be cached in Appliance. Applicable in Intersight appliance deployment. If 'Evict' is set, the cached file will be removed. Applicable in Intersight appliance deployment. If 'GeneratePreSignedUploadUrl' is set, generates pre signed URL (s) for the file to be imported into the repository. Applicable for local machine source. The URL (s) will be populated under LocalMachine file server. If 'CompleteImportProcess' is set, the ImportState is marked as 'Imported'. Applicable for local machine source. If 'Cancel' is set, the ImportState is marked as 'Failed'. Applicable for local machine source.\n* `None` - No action should be taken on the imported file.\n* `GeneratePreSignedUploadUrl` - Generate pre signed URL of file for importing into the repository.\n* `GeneratePreSignedDownloadUrl` - Generate pre signed URL of file in the repository to download.\n* `CompleteImportProcess` - Mark that the import process of the file into the repository is complete.\n* `MarkImportFailed` - Mark to indicate that the import process of the file into the repository failed.\n* `PreCache` - Cache the file into the Intersight Appliance.\n* `Cancel` - The cancel import process for the file into the repository.\n* `Extract` - The action to extract the file in the external repository.\n* `Evict` - Evict the cached file from the Intersight Appliance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareServerConfigurationUtilityDistributable.ImportActionEnum ImportAction {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The MD5 ETag for a file that is stored in Intersight repository or in the appliance cache. Warning - MD5 is currently broken and this will be migrated to SHA shortly."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Md5eTag {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The md5sum checksum of the file. This information is available for all Cisco distributed images and files imported to the local repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Md5sum {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The mdfid of the image provided by cisco.com."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Mdfid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The endpoint model for which this firmware image is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Model {
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
        /// <para type="description">"The name of the file. It is populated as part of the image import operation."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The build which is recommended by Cisco."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecommendedBuild {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a softwarerepositoryRelease resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SoftwarerepositoryReleaseRelationship Release {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The url for the release notes of this image."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ReleaseNotesUrl {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The sha512sum of the file. This information is available for all Cisco distributed images and files imported to the local repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Sha512sum {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The size (in bytes) of the file. This information is available for all Cisco distributed images and files imported to the local repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Size {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The software advisory, if any, provided by the vendor for this file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SoftwareAdvisoryUrl {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Location of the file in an external repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SoftwarerepositoryFileServer Source {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> SupportedModels {
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
        /// <para type="description">"The vendor or publisher of this file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vendor {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Vendor provided version for the file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FirmwareServerConfigurationUtilityDistributable.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFirmwareServerConfigurationUtilityDistributable", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFirmwareServerConfigurationUtilityDistributable:GetCmdletBase
	{
		public GetIntersightFirmwareServerConfigurationUtilityDistributable()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "GetFirmwareServerConfigurationUtilityDistributableListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FirmwareRunningFirmware.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFirmwareRunningFirmware")]
    public class SetIntersightFirmwareRunningFirmware:SetCmdletBase
	{
		public SetIntersightFirmwareRunningFirmware()
		{
			ApiInstance = new FirmwareApi(Config);
            ModelObject = new FirmwareRunningFirmware();
            MethodName = "UpdateFirmwareRunningFirmwareWithHttpInfo";
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
        /// <para type="description">"An array of relationships to networkElement resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<NetworkElementRelationship> NetworkElements {
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
    /// <para type="synopsis">This is the cmdlet to Get FirmwareSasExpanderDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFirmwareSasExpanderDescriptor", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFirmwareSasExpanderDescriptor:GetCmdletBase
	{
		public GetIntersightFirmwareSasExpanderDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "GetFirmwareSasExpanderDescriptorListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FirmwareSasExpanderDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFirmwareSasExpanderDescriptor")]
    public class NewIntersightFirmwareSasExpanderDescriptor:NewCmdletBase
	{
		public NewIntersightFirmwareSasExpanderDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            ModelObject = new FirmwareSasExpanderDescriptor();
            MethodName = "CreateFirmwareSasExpanderDescriptorWithHttpInfo";
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
        /// <para type="description">"The brand string of the endpoint for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string BrandString {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<CapabilityCapabilityRelationship> Capabilities {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The label type for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Model {
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
        /// <para type="description">"The revision for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Revision {
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
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vendor {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FirmwareUpgradeStatus.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFirmwareUpgradeStatus", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFirmwareUpgradeStatus:GetCmdletBase
	{
		public GetIntersightFirmwareUpgradeStatus()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "GetFirmwareUpgradeStatusListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FirmwareSasExpanderDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFirmwareSasExpanderDescriptor")]
    public class RemoveIntersightFirmwareSasExpanderDescriptor:RemoveCmdletBase
	{
		public RemoveIntersightFirmwareSasExpanderDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "DeleteFirmwareSasExpanderDescriptorWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FirmwareSasExpanderDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFirmwareSasExpanderDescriptor")]
    public class SetIntersightFirmwareSasExpanderDescriptor:SetCmdletBase
	{
		public SetIntersightFirmwareSasExpanderDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            ModelObject = new FirmwareSasExpanderDescriptor();
            MethodName = "UpdateFirmwareSasExpanderDescriptorWithHttpInfo";
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
        /// <para type="description">"The brand string of the endpoint for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string BrandString {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<CapabilityCapabilityRelationship> Capabilities {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The label type for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
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
        /// <para type="description">"The revision for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Revision {
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
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vendor {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FirmwarePcieDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFirmwarePcieDescriptor")]
    public class SetIntersightFirmwarePcieDescriptor:SetCmdletBase
	{
		public SetIntersightFirmwarePcieDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            ModelObject = new FirmwarePcieDescriptor();
            MethodName = "UpdateFirmwarePcieDescriptorWithHttpInfo";
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
        /// <para type="description">"The brand string of the endpoint for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string BrandString {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<CapabilityCapabilityRelationship> Capabilities {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The label type for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
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
        /// <para type="description">"The revision for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Revision {
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
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vendor {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FirmwarePcieDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFirmwarePcieDescriptor")]
    public class RemoveIntersightFirmwarePcieDescriptor:RemoveCmdletBase
	{
		public RemoveIntersightFirmwarePcieDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "DeleteFirmwarePcieDescriptorWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FirmwareDriverDistributable.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFirmwareDriverDistributable")]
    public class NewIntersightFirmwareDriverDistributable:NewCmdletBase
	{
		public NewIntersightFirmwareDriverDistributable()
		{
			ApiInstance = new FirmwareApi(Config);
            ModelObject = new FirmwareDriverDistributable();
            MethodName = "CreateFirmwareDriverDistributableWithHttpInfo";
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
        /// <para type="description">"A reference to a softwarerepositoryCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SoftwarerepositoryCatalogRelationship Catalog {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The device type on which the driver is installable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Category {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<FirmwareComponentMeta> ComponentMeta {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User provided description about the file. Cisco provided description for image inventoried from a Cisco repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates in which directory path this driver will be added."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Directory {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to firmwareDistributableMeta resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<FirmwareDistributableMetaRelationship> DistributableMetas {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of image which the distributable falls into according to the component it can upgrade. For e.g.; Standalone server, Intersight managed server, UCS Managed Fabric Interconnect. The field is used in private appliance mode, where image does not have description populated from CCO."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ImageType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The action to be performed on the imported file. If 'PreCache' is set, the image will be cached in Appliance. Applicable in Intersight appliance deployment. If 'Evict' is set, the cached file will be removed. Applicable in Intersight appliance deployment. If 'GeneratePreSignedUploadUrl' is set, generates pre signed URL (s) for the file to be imported into the repository. Applicable for local machine source. The URL (s) will be populated under LocalMachine file server. If 'CompleteImportProcess' is set, the ImportState is marked as 'Imported'. Applicable for local machine source. If 'Cancel' is set, the ImportState is marked as 'Failed'. Applicable for local machine source.\n* `None` - No action should be taken on the imported file.\n* `GeneratePreSignedUploadUrl` - Generate pre signed URL of file for importing into the repository.\n* `GeneratePreSignedDownloadUrl` - Generate pre signed URL of file in the repository to download.\n* `CompleteImportProcess` - Mark that the import process of the file into the repository is complete.\n* `MarkImportFailed` - Mark to indicate that the import process of the file into the repository failed.\n* `PreCache` - Cache the file into the Intersight Appliance.\n* `Cancel` - The cancel import process for the file into the repository.\n* `Extract` - The action to extract the file in the external repository.\n* `Evict` - Evict the cached file from the Intersight Appliance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareDriverDistributable.ImportActionEnum ImportAction {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The MD5 ETag for a file that is stored in Intersight repository or in the appliance cache. Warning - MD5 is currently broken and this will be migrated to SHA shortly."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Md5eTag {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The md5sum checksum of the file. This information is available for all Cisco distributed images and files imported to the local repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Md5sum {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The mdfid of the image provided by cisco.com."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Mdfid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The endpoint model for which this firmware image is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Model {
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
        /// <para type="description">"The name of the file. It is populated as part of the image import operation."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The operating system name to which this driver is compatible."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Osname {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"OS Version. It is populated as part of the image import operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Osversion {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The build which is recommended by Cisco."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecommendedBuild {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a softwarerepositoryRelease resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SoftwarerepositoryReleaseRelationship Release {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The url for the release notes of this image."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ReleaseNotesUrl {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The sha512sum of the file. This information is available for all Cisco distributed images and files imported to the local repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Sha512sum {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The size (in bytes) of the file. This information is available for all Cisco distributed images and files imported to the local repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Size {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The software advisory, if any, provided by the vendor for this file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SoftwareAdvisoryUrl {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Location of the file in an external repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SoftwarerepositoryFileServer Source {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> SupportedModels {
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
        /// <para type="description">"The vendor or publisher of this file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vendor {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Vendor provided version for the file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FirmwareDriverDistributable.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFirmwareDriverDistributable", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFirmwareDriverDistributable:GetCmdletBase
	{
		public GetIntersightFirmwareDriverDistributable()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "GetFirmwareDriverDistributableListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FirmwareStorageControllerDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFirmwareStorageControllerDescriptor")]
    public class SetIntersightFirmwareStorageControllerDescriptor:SetCmdletBase
	{
		public SetIntersightFirmwareStorageControllerDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            ModelObject = new FirmwareStorageControllerDescriptor();
            MethodName = "PatchFirmwareStorageControllerDescriptorWithHttpInfo";
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
        /// <para type="description">"The brand string of the endpoint for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string BrandString {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<CapabilityCapabilityRelationship> Capabilities {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The label type for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
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
        /// <para type="description">"The revision for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Revision {
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
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vendor {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FirmwareStorageControllerDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFirmwareStorageControllerDescriptor")]
    public class RemoveIntersightFirmwareStorageControllerDescriptor:RemoveCmdletBase
	{
		public RemoveIntersightFirmwareStorageControllerDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "DeleteFirmwareStorageControllerDescriptorWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FirmwareIomDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFirmwareIomDescriptor", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFirmwareIomDescriptor:GetCmdletBase
	{
		public GetIntersightFirmwareIomDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "GetFirmwareIomDescriptorListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FirmwareIomDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFirmwareIomDescriptor")]
    public class NewIntersightFirmwareIomDescriptor:NewCmdletBase
	{
		public NewIntersightFirmwareIomDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            ModelObject = new FirmwareIomDescriptor();
            MethodName = "CreateFirmwareIomDescriptorWithHttpInfo";
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
        /// <para type="description">"The brand string of the endpoint for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string BrandString {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<CapabilityCapabilityRelationship> Capabilities {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The label type for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Model {
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
        /// <para type="description">"The revision for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Revision {
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
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vendor {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FirmwareFirmwareSummary.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFirmwareFirmwareSummary", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFirmwareFirmwareSummary:GetCmdletBase
	{
		public GetIntersightFirmwareFirmwareSummary()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "GetFirmwareFirmwareSummaryListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FirmwareChassisUpgrade.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFirmwareChassisUpgrade", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFirmwareChassisUpgrade:GetCmdletBase
	{
		public GetIntersightFirmwareChassisUpgrade()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "GetFirmwareChassisUpgradeListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FirmwareChassisUpgrade.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFirmwareChassisUpgrade")]
    public class NewIntersightFirmwareChassisUpgrade:NewCmdletBase
	{
		public NewIntersightFirmwareChassisUpgrade()
		{
			ApiInstance = new FirmwareApi(Config);
            ModelObject = new FirmwareChassisUpgrade();
            MethodName = "CreateFirmwareChassisUpgradeWithHttpInfo";
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
        /// <para type="description">"A reference to a equipmentChassis resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public EquipmentChassisRelationship Chassis {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Direct download options in case the upgradeType is direct download based upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareDirectDownload DirectDownload {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a firmwareDistributable resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareDistributableRelationship Distributable {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> ExcludeComponentList {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Location of the image in user software repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SoftwarerepositoryFileServer FileServer {
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
        /// <para type="description">"Deprecated (Use 'fileServer' property). Network share options in case of the upgradeType is network share based upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareNetworkShare NetworkShare {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a softwarerepositoryRelease resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SoftwarerepositoryReleaseRelationship Release {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User has the option to skip the estimate impact calculation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool SkipEstimateImpact {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Status of the upgrade operation.\n* `NONE` - Upgrade status is not populated.\n* `IN_PROGRESS` - The upgrade is in progress.\n* `SUCCESSFUL` - The upgrade successfully completed.\n* `FAILED` - The upgrade shows failed status.\n* `TERMINATED` - The upgrade has been terminated."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareChassisUpgrade.StatusEnum Status {
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
        /// <para type="description">"Desired upgrade mode to choose either direct download based upgrade or network share upgrade.\n* `direct_upgrade` - Upgrade mode is direct download.\n* `network_upgrade` - Upgrade mode is network upgrade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareChassisUpgrade.UpgradeTypeEnum UpgradeType {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FirmwareStorageControllerDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFirmwareStorageControllerDescriptor", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFirmwareStorageControllerDescriptor:GetCmdletBase
	{
		public GetIntersightFirmwareStorageControllerDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "GetFirmwareStorageControllerDescriptorListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FirmwareStorageControllerDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFirmwareStorageControllerDescriptor")]
    public class NewIntersightFirmwareStorageControllerDescriptor:NewCmdletBase
	{
		public NewIntersightFirmwareStorageControllerDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            ModelObject = new FirmwareStorageControllerDescriptor();
            MethodName = "CreateFirmwareStorageControllerDescriptorWithHttpInfo";
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
        /// <para type="description">"The brand string of the endpoint for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string BrandString {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<CapabilityCapabilityRelationship> Capabilities {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The label type for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Model {
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
        /// <para type="description">"The revision for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Revision {
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
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vendor {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FirmwareCimcDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFirmwareCimcDescriptor")]
    public class SetIntersightFirmwareCimcDescriptor:SetCmdletBase
	{
		public SetIntersightFirmwareCimcDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            ModelObject = new FirmwareCimcDescriptor();
            MethodName = "UpdateFirmwareCimcDescriptorWithHttpInfo";
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
        /// <para type="description">"The brand string of the endpoint for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string BrandString {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<CapabilityCapabilityRelationship> Capabilities {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The label type for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
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
        /// <para type="description">"The revision for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Revision {
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
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vendor {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FirmwareCimcDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFirmwareCimcDescriptor")]
    public class RemoveIntersightFirmwareCimcDescriptor:RemoveCmdletBase
	{
		public RemoveIntersightFirmwareCimcDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "DeleteFirmwareCimcDescriptorWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FirmwareUpgrade.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFirmwareUpgrade")]
    public class RemoveIntersightFirmwareUpgrade:RemoveCmdletBase
	{
		public RemoveIntersightFirmwareUpgrade()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "DeleteFirmwareUpgradeWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get FirmwareDistributable.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightFirmwareDistributable", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightFirmwareDistributable:GetCmdletBase
	{
		public GetIntersightFirmwareDistributable()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "GetFirmwareDistributableListWithHttpInfo";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New FirmwareDistributable.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightFirmwareDistributable")]
    public class NewIntersightFirmwareDistributable:NewCmdletBase
	{
		public NewIntersightFirmwareDistributable()
		{
			ApiInstance = new FirmwareApi(Config);
            ModelObject = new FirmwareDistributable();
            MethodName = "CreateFirmwareDistributableWithHttpInfo";
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
        /// <para type="description">"A reference to a softwarerepositoryCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SoftwarerepositoryCatalogRelationship Catalog {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<FirmwareComponentMeta> ComponentMeta {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"User provided description about the file. Cisco provided description for image inventoried from a Cisco repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to firmwareDistributableMeta resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<FirmwareDistributableMetaRelationship> DistributableMetas {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The file location of the distributable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string FileLocation {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The category into which the distributable falls into according to the supported platform series. For e.g.; C-Series/B-Series/Infrastructure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ImageCategory {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of image which the distributable falls into according to the component it can upgrade. For e.g.; Standalone server, Intersight managed server, UCS Managed Fabric Interconnect. The field is used in private appliance mode, where image does not have description populated from CCO."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ImageType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The action to be performed on the imported file. If 'PreCache' is set, the image will be cached in Appliance. Applicable in Intersight appliance deployment. If 'Evict' is set, the cached file will be removed. Applicable in Intersight appliance deployment. If 'GeneratePreSignedUploadUrl' is set, generates pre signed URL (s) for the file to be imported into the repository. Applicable for local machine source. The URL (s) will be populated under LocalMachine file server. If 'CompleteImportProcess' is set, the ImportState is marked as 'Imported'. Applicable for local machine source. If 'Cancel' is set, the ImportState is marked as 'Failed'. Applicable for local machine source.\n* `None` - No action should be taken on the imported file.\n* `GeneratePreSignedUploadUrl` - Generate pre signed URL of file for importing into the repository.\n* `GeneratePreSignedDownloadUrl` - Generate pre signed URL of file in the repository to download.\n* `CompleteImportProcess` - Mark that the import process of the file into the repository is complete.\n* `MarkImportFailed` - Mark to indicate that the import process of the file into the repository failed.\n* `PreCache` - Cache the file into the Intersight Appliance.\n* `Cancel` - The cancel import process for the file into the repository.\n* `Extract` - The action to extract the file in the external repository.\n* `Evict` - Evict the cached file from the Intersight Appliance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareDistributable.ImportActionEnum ImportAction {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The MD5 ETag for a file that is stored in Intersight repository or in the appliance cache. Warning - MD5 is currently broken and this will be migrated to SHA shortly."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Md5eTag {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The md5sum checksum of the file. This information is available for all Cisco distributed images and files imported to the local repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Md5sum {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The mdfid of the image provided by cisco.com."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Mdfid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The endpoint model for which this firmware image is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Model {
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
        /// <para type="description">"The name of the file. It is populated as part of the image import operation."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The source of the distributable. If it has been created by the user or system.\n* `System` - The distributable has been created by the System.\n* `User` - The distributable has been created by the User."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public FirmwareDistributable.OriginEnum Origin {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The build which is recommended by Cisco."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RecommendedBuild {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a softwarerepositoryRelease resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SoftwarerepositoryReleaseRelationship Release {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The url for the release notes of this image."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ReleaseNotesUrl {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The sha512sum of the file. This information is available for all Cisco distributed images and files imported to the local repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Sha512sum {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The size (in bytes) of the file. This information is available for all Cisco distributed images and files imported to the local repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public long Size {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The software advisory, if any, provided by the vendor for this file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SoftwareAdvisoryUrl {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Location of the file in an external repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SoftwarerepositoryFileServer Source {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> SupportedModels {
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
        /// <para type="description">"The vendor or publisher of this file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vendor {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Vendor provided version for the file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set FirmwareGpuDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightFirmwareGpuDescriptor")]
    public class SetIntersightFirmwareGpuDescriptor:SetCmdletBase
	{
		public SetIntersightFirmwareGpuDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            ModelObject = new FirmwareGpuDescriptor();
            MethodName = "UpdateFirmwareGpuDescriptorWithHttpInfo";
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
        /// <para type="description">"The brand string of the endpoint for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string BrandString {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<CapabilityCapabilityRelationship> Capabilities {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The label type for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Label {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
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
        /// <para type="description">"The revision for the component."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Revision {
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
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Vendor {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove FirmwareGpuDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightFirmwareGpuDescriptor")]
    public class RemoveIntersightFirmwareGpuDescriptor:RemoveCmdletBase
	{
		public RemoveIntersightFirmwareGpuDescriptor()
		{
			ApiInstance = new FirmwareApi(Config);
            MethodName = "DeleteFirmwareGpuDescriptorWithHttpInfo";
		}
    }
}