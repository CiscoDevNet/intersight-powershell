using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set SoftwarerepositoryAuthorization.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightSoftwarerepositoryAuthorization")]
    public class SetIntersightSoftwarerepositoryAuthorization:SetCmdletBase
	{
		public SetIntersightSoftwarerepositoryAuthorization()
		{
			ApiInstance = new SoftwarerepositoryApi(Config);
            ModelObject = new SoftwarerepositoryAuthorization();
            MethodName = "UpdateSoftwarerepositoryAuthorization";
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
        /// <para type="description">"The password that will be used by Intersight to create OAuth2 tokens for interacting with the external repository, on the user account's behalf."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Password {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The external repository for which this authorization has been provided. The only supported repository today is cisco.com.\n* `Cisco` - External repository hosted on cisco.com.\n* `IntersightCloud` - Repository hosted by the Intersight Cloud.\n* `LocalMachine` - The file is available on the local client machine. Used as an upload source type.\n* `NetworkShare` - External repository in the customer datacenter. This will typically be a file server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SoftwarerepositoryAuthorization.RepositoryTypeEnum RepositoryType {
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
        /// <para type="description">"The username that will be used by Intersight to create OAuth2 tokens for interacting with the external repository, on the user account's behalf."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string UserId {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New SoftwarerepositoryCategorySupportConstraint.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightSoftwarerepositoryCategorySupportConstraint")]
    public class NewIntersightSoftwarerepositoryCategorySupportConstraint:NewCmdletBase
	{
		public NewIntersightSoftwarerepositoryCategorySupportConstraint()
		{
			ApiInstance = new SoftwarerepositoryApi(Config);
            ModelObject = new SoftwarerepositoryCategorySupportConstraint();
            MethodName = "CreateSoftwarerepositoryCategorySupportConstraint";
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
        /// <para type="description">"Identifier for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ConstraintId {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<SoftwarerepositoryConstraintModels> FilteredModels {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Cisco software repository image category identifier."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string MdfId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Minimum image version from where the models can be supported."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string MinVersion {
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
        /// <para type="description">"An unique identifer for a capability descriptor."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Fields which tells if the constraint is based on image name parsing."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool ParseFromImageName {
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
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get SoftwarerepositoryCategorySupportConstraint.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightSoftwarerepositoryCategorySupportConstraint", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightSoftwarerepositoryCategorySupportConstraint:GetCmdletBase
	{
		public GetIntersightSoftwarerepositoryCategorySupportConstraint()
		{
			ApiInstance = new SoftwarerepositoryApi(Config);
            MethodName = "GetSoftwarerepositoryCategorySupportConstraintList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New SoftwarerepositoryOperatingSystemFile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightSoftwarerepositoryOperatingSystemFile")]
    public class NewIntersightSoftwarerepositoryOperatingSystemFile:NewCmdletBase
	{
		public NewIntersightSoftwarerepositoryOperatingSystemFile()
		{
			ApiInstance = new SoftwarerepositoryApi(Config);
            ModelObject = new SoftwarerepositoryOperatingSystemFile();
            MethodName = "CreateSoftwarerepositoryOperatingSystemFile";
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
        /// <para type="description">"User provided description about the file. Cisco provided description for image inventoried from a Cisco repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The action to be performed on the imported file. If 'PreCache' is set, the image will be cached in Appliance. Applicable in Intersight appliance deployment. If 'Evict' is set, the cached file will be removed. Applicable in Intersight appliance deployment. If 'GeneratePreSignedUploadUrl' is set, generates pre signed URL (s) for the file to be imported into the repository. Applicable for local machine source. The URL (s) will be populated under LocalMachine file server. If 'CompleteImportProcess' is set, the ImportState is marked as 'Imported'. Applicable for local machine source. If 'Cancel' is set, the ImportState is marked as 'Failed'. Applicable for local machine source.\n* `None` - No action should be taken on the imported file.\n* `GeneratePreSignedUploadUrl` - Generate pre signed URL of file for importing into the repository.\n* `GeneratePreSignedDownloadUrl` - Generate pre signed URL of file in the repository to download.\n* `CompleteImportProcess` - Mark that the import process of the file into the repository is complete.\n* `MarkImportFailed` - Mark to indicate that the import process of the file into the repository failed.\n* `PreCache` - Cache the file into the Intersight Appliance.\n* `Cancel` - The cancel import process for the file into the repository.\n* `Extract` - The action to extract the file in the external repository.\n* `Evict` - Evict the cached file from the Intersight Appliance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SoftwarerepositoryOperatingSystemFile.ImportActionEnum ImportAction {
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
    /// <para type="synopsis">This is the cmdlet to Get SoftwarerepositoryOperatingSystemFile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightSoftwarerepositoryOperatingSystemFile", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightSoftwarerepositoryOperatingSystemFile:GetCmdletBase
	{
		public GetIntersightSoftwarerepositoryOperatingSystemFile()
		{
			ApiInstance = new SoftwarerepositoryApi(Config);
            MethodName = "GetSoftwarerepositoryOperatingSystemFileList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove SoftwarerepositoryOperatingSystemFile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightSoftwarerepositoryOperatingSystemFile")]
    public class RemoveIntersightSoftwarerepositoryOperatingSystemFile:RemoveCmdletBase
	{
		public RemoveIntersightSoftwarerepositoryOperatingSystemFile()
		{
			ApiInstance = new SoftwarerepositoryApi(Config);
            MethodName = "DeleteSoftwarerepositoryOperatingSystemFile";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set SoftwarerepositoryOperatingSystemFile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightSoftwarerepositoryOperatingSystemFile")]
    public class SetIntersightSoftwarerepositoryOperatingSystemFile:SetCmdletBase
	{
		public SetIntersightSoftwarerepositoryOperatingSystemFile()
		{
			ApiInstance = new SoftwarerepositoryApi(Config);
            ModelObject = new SoftwarerepositoryOperatingSystemFile();
            MethodName = "UpdateSoftwarerepositoryOperatingSystemFile";
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
        /// <para type="description">"User provided description about the file. Cisco provided description for image inventoried from a Cisco repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Description {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The action to be performed on the imported file. If 'PreCache' is set, the image will be cached in Appliance. Applicable in Intersight appliance deployment. If 'Evict' is set, the cached file will be removed. Applicable in Intersight appliance deployment. If 'GeneratePreSignedUploadUrl' is set, generates pre signed URL (s) for the file to be imported into the repository. Applicable for local machine source. The URL (s) will be populated under LocalMachine file server. If 'CompleteImportProcess' is set, the ImportState is marked as 'Imported'. Applicable for local machine source. If 'Cancel' is set, the ImportState is marked as 'Failed'. Applicable for local machine source.\n* `None` - No action should be taken on the imported file.\n* `GeneratePreSignedUploadUrl` - Generate pre signed URL of file for importing into the repository.\n* `GeneratePreSignedDownloadUrl` - Generate pre signed URL of file in the repository to download.\n* `CompleteImportProcess` - Mark that the import process of the file into the repository is complete.\n* `MarkImportFailed` - Mark to indicate that the import process of the file into the repository failed.\n* `PreCache` - Cache the file into the Intersight Appliance.\n* `Cancel` - The cancel import process for the file into the repository.\n* `Extract` - The action to extract the file in the external repository.\n* `Evict` - Evict the cached file from the Intersight Appliance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SoftwarerepositoryOperatingSystemFile.ImportActionEnum ImportAction {
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
    /// <para type="synopsis">This is the cmdlet to Get SoftwarerepositoryCategoryMapper.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightSoftwarerepositoryCategoryMapper", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightSoftwarerepositoryCategoryMapper:GetCmdletBase
	{
		public GetIntersightSoftwarerepositoryCategoryMapper()
		{
			ApiInstance = new SoftwarerepositoryApi(Config);
            MethodName = "GetSoftwarerepositoryCategoryMapperList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New SoftwarerepositoryCategoryMapper.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightSoftwarerepositoryCategoryMapper")]
    public class NewIntersightSoftwarerepositoryCategoryMapper:NewCmdletBase
	{
		public NewIntersightSoftwarerepositoryCategoryMapper()
		{
			ApiInstance = new SoftwarerepositoryApi(Config);
            ModelObject = new SoftwarerepositoryCategoryMapper();
            MethodName = "CreateSoftwarerepositoryCategoryMapper";
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
        /// <para type="description">"The category of the model series."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Category {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of distributable image, example huu, scu, driver, os.\n* `Distributable` - Stores firmware host utility images and fabric images.\n* `DriverDistributable` - Stores driver distributable images.\n* `ServerConfigurationUtilityDistributable` - Stores server configuration utility images.\n* `OperatingSystemFile` - Stores operating system iso images.\n* `HyperflexDistributable` - It stores HyperFlex images."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SoftwarerepositoryCategoryMapper.FileTypeEnum FileType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of image based on the endpoint it can upgrade. For example, ucs-c420m5-huu-3.2.1a.iso can upgrade standalone servers, so the image type is Standalone Server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ImageType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Cisco software repository image category identifier."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string MdfId {
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
        /// <para type="description">"An unique identifer for a capability descriptor."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The regex that all images of this category follow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RegexPattern {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The image can be downloaded from cisco.com or external cloud store.\n* `Cisco` - External repository hosted on cisco.com.\n* `IntersightCloud` - Repository hosted by the Intersight Cloud.\n* `LocalMachine` - The file is available on the local client machine. Used as an upload source type.\n* `NetworkShare` - External repository in the customer datacenter. This will typically be a file server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SoftwarerepositoryCategoryMapper.SourceEnum Source {
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
        /// <para type="description">"The software type id provided by cisco.com."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SwId {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> TagTypes {
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
        /// <para type="description">"The version from which user can download images from amazon store, if source is external cloud store."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get SoftwarerepositoryCategoryMapperModel.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightSoftwarerepositoryCategoryMapperModel", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightSoftwarerepositoryCategoryMapperModel:GetCmdletBase
	{
		public GetIntersightSoftwarerepositoryCategoryMapperModel()
		{
			ApiInstance = new SoftwarerepositoryApi(Config);
            MethodName = "GetSoftwarerepositoryCategoryMapperModelList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New SoftwarerepositoryCategoryMapperModel.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightSoftwarerepositoryCategoryMapperModel")]
    public class NewIntersightSoftwarerepositoryCategoryMapperModel:NewCmdletBase
	{
		public NewIntersightSoftwarerepositoryCategoryMapperModel()
		{
			ApiInstance = new SoftwarerepositoryApi(Config);
            ModelObject = new SoftwarerepositoryCategoryMapperModel();
            MethodName = "CreateSoftwarerepositoryCategoryMapperModel";
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
        /// <para type="description">"The category of the model series."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Category {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The distributable tag value of the model series."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DistTag {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of image based on the endpoint it can upgrade. For example, ucs-bundle-6400-infra.4.1.2a.bin can upgrade ucs managed fabric interconnects, so the image type is UCS Managed Fabric Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ImageType {
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
        /// <para type="description">"An unique identifer for a capability descriptor."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The regex that all images of this model follow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RegexPattern {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Cisco hardware model series."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SeriesId {
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
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set SoftwarerepositoryCategoryMapperModel.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightSoftwarerepositoryCategoryMapperModel")]
    public class SetIntersightSoftwarerepositoryCategoryMapperModel:SetCmdletBase
	{
		public SetIntersightSoftwarerepositoryCategoryMapperModel()
		{
			ApiInstance = new SoftwarerepositoryApi(Config);
            ModelObject = new SoftwarerepositoryCategoryMapperModel();
            MethodName = "PatchSoftwarerepositoryCategoryMapperModel";
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
        /// <para type="description">"The category of the model series."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Category {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The distributable tag value of the model series."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string DistTag {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of image based on the endpoint it can upgrade. For example, ucs-bundle-6400-infra.4.1.2a.bin can upgrade ucs managed fabric interconnects, so the image type is UCS Managed Fabric Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ImageType {
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
        /// <para type="description">"An unique identifer for a capability descriptor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The regex that all images of this model follow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RegexPattern {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Cisco hardware model series."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SeriesId {
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
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove SoftwarerepositoryCategoryMapperModel.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightSoftwarerepositoryCategoryMapperModel")]
    public class RemoveIntersightSoftwarerepositoryCategoryMapperModel:RemoveCmdletBase
	{
		public RemoveIntersightSoftwarerepositoryCategoryMapperModel()
		{
			ApiInstance = new SoftwarerepositoryApi(Config);
            MethodName = "DeleteSoftwarerepositoryCategoryMapperModel";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set SoftwarerepositoryRelease.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightSoftwarerepositoryRelease")]
    public class SetIntersightSoftwarerepositoryRelease:SetCmdletBase
	{
		public SetIntersightSoftwarerepositoryRelease()
		{
			ApiInstance = new SoftwarerepositoryApi(Config);
            ModelObject = new SoftwarerepositoryRelease();
            MethodName = "UpdateSoftwarerepositoryRelease";
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
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The URL for the release notes of this image."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ReleaseNotesUrl {
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
        /// <para type="description">"The platform type for which the images are released. This can be a Fabric Interconnect or compute server hardware.\n* `FabricSwitch` - The images in a release that correspond to Fabric Interconnect switches.\n* `ComputeSystem` - The images in a release that correspond to servers."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SoftwarerepositoryRelease.TypeEnum Type {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Cisco provided release version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove SoftwarerepositoryRelease.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightSoftwarerepositoryRelease")]
    public class RemoveIntersightSoftwarerepositoryRelease:RemoveCmdletBase
	{
		public RemoveIntersightSoftwarerepositoryRelease()
		{
			ApiInstance = new SoftwarerepositoryApi(Config);
            MethodName = "DeleteSoftwarerepositoryRelease";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set SoftwarerepositoryCategoryMapper.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightSoftwarerepositoryCategoryMapper")]
    public class SetIntersightSoftwarerepositoryCategoryMapper:SetCmdletBase
	{
		public SetIntersightSoftwarerepositoryCategoryMapper()
		{
			ApiInstance = new SoftwarerepositoryApi(Config);
            ModelObject = new SoftwarerepositoryCategoryMapper();
            MethodName = "UpdateSoftwarerepositoryCategoryMapper";
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
        /// <para type="description">"The category of the model series."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Category {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of distributable image, example huu, scu, driver, os.\n* `Distributable` - Stores firmware host utility images and fabric images.\n* `DriverDistributable` - Stores driver distributable images.\n* `ServerConfigurationUtilityDistributable` - Stores server configuration utility images.\n* `OperatingSystemFile` - Stores operating system iso images.\n* `HyperflexDistributable` - It stores HyperFlex images."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SoftwarerepositoryCategoryMapper.FileTypeEnum FileType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of image based on the endpoint it can upgrade. For example, ucs-c420m5-huu-3.2.1a.iso can upgrade standalone servers, so the image type is Standalone Server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ImageType {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Cisco software repository image category identifier."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string MdfId {
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
        /// <para type="description">"An unique identifer for a capability descriptor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The regex that all images of this category follow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string RegexPattern {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The image can be downloaded from cisco.com or external cloud store.\n* `Cisco` - External repository hosted on cisco.com.\n* `IntersightCloud` - Repository hosted by the Intersight Cloud.\n* `LocalMachine` - The file is available on the local client machine. Used as an upload source type.\n* `NetworkShare` - External repository in the customer datacenter. This will typically be a file server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SoftwarerepositoryCategoryMapper.SourceEnum Source {
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
        /// <para type="description">"The software type id provided by cisco.com."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string SwId {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<string> TagTypes {
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
        /// <para type="description">"The version from which user can download images from amazon store, if source is external cloud store."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove SoftwarerepositoryCategoryMapper.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightSoftwarerepositoryCategoryMapper")]
    public class RemoveIntersightSoftwarerepositoryCategoryMapper:RemoveCmdletBase
	{
		public RemoveIntersightSoftwarerepositoryCategoryMapper()
		{
			ApiInstance = new SoftwarerepositoryApi(Config);
            MethodName = "DeleteSoftwarerepositoryCategoryMapper";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get SoftwarerepositoryDownloadSpec.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightSoftwarerepositoryDownloadSpec", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightSoftwarerepositoryDownloadSpec:GetCmdletBase
	{
		public GetIntersightSoftwarerepositoryDownloadSpec()
		{
			ApiInstance = new SoftwarerepositoryApi(Config);
            MethodName = "GetSoftwarerepositoryDownloadSpecList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New SoftwarerepositoryRelease.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightSoftwarerepositoryRelease")]
    public class NewIntersightSoftwarerepositoryRelease:NewCmdletBase
	{
		public NewIntersightSoftwarerepositoryRelease()
		{
			ApiInstance = new SoftwarerepositoryApi(Config);
            ModelObject = new SoftwarerepositoryRelease();
            MethodName = "CreateSoftwarerepositoryRelease";
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
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Moid {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The URL for the release notes of this image."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ReleaseNotesUrl {
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
        /// <para type="description">"The platform type for which the images are released. This can be a Fabric Interconnect or compute server hardware.\n* `FabricSwitch` - The images in a release that correspond to Fabric Interconnect switches.\n* `ComputeSystem` - The images in a release that correspond to servers."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SoftwarerepositoryRelease.TypeEnum Type {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Cisco provided release version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Version {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get SoftwarerepositoryRelease.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightSoftwarerepositoryRelease", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightSoftwarerepositoryRelease:GetCmdletBase
	{
		public GetIntersightSoftwarerepositoryRelease()
		{
			ApiInstance = new SoftwarerepositoryApi(Config);
            MethodName = "GetSoftwarerepositoryReleaseList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get SoftwarerepositoryCachedImage.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightSoftwarerepositoryCachedImage", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightSoftwarerepositoryCachedImage:GetCmdletBase
	{
		public GetIntersightSoftwarerepositoryCachedImage()
		{
			ApiInstance = new SoftwarerepositoryApi(Config);
            MethodName = "GetSoftwarerepositoryCachedImageList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set SoftwarerepositoryCategorySupportConstraint.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightSoftwarerepositoryCategorySupportConstraint")]
    public class SetIntersightSoftwarerepositoryCategorySupportConstraint:SetCmdletBase
	{
		public SetIntersightSoftwarerepositoryCategorySupportConstraint()
		{
			ApiInstance = new SoftwarerepositoryApi(Config);
            ModelObject = new SoftwarerepositoryCategorySupportConstraint();
            MethodName = "UpdateSoftwarerepositoryCategorySupportConstraint";
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
        /// <para type="description">"Identifier for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string ConstraintId {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public List<SoftwarerepositoryConstraintModels> FilteredModels {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Cisco software repository image category identifier."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string MdfId {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Minimum image version from where the models can be supported."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string MinVersion {
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
        /// <para type="description">"An unique identifer for a capability descriptor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Name {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Fields which tells if the constraint is based on image name parsing."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public bool ParseFromImageName {
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
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove SoftwarerepositoryCategorySupportConstraint.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightSoftwarerepositoryCategorySupportConstraint")]
    public class RemoveIntersightSoftwarerepositoryCategorySupportConstraint:RemoveCmdletBase
	{
		public RemoveIntersightSoftwarerepositoryCategorySupportConstraint()
		{
			ApiInstance = new SoftwarerepositoryApi(Config);
            MethodName = "DeleteSoftwarerepositoryCategorySupportConstraint";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get SoftwarerepositoryCatalog.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightSoftwarerepositoryCatalog", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightSoftwarerepositoryCatalog:GetCmdletBase
	{
		public GetIntersightSoftwarerepositoryCatalog()
		{
			ApiInstance = new SoftwarerepositoryApi(Config);
            MethodName = "GetSoftwarerepositoryCatalogList";
		}
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New SoftwarerepositoryAuthorization.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightSoftwarerepositoryAuthorization")]
    public class NewIntersightSoftwarerepositoryAuthorization:NewCmdletBase
	{
		public NewIntersightSoftwarerepositoryAuthorization()
		{
			ApiInstance = new SoftwarerepositoryApi(Config);
            ModelObject = new SoftwarerepositoryAuthorization();
            MethodName = "CreateSoftwarerepositoryAuthorization";
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
        /// <para type="description">"The password that will be used by Intersight to create OAuth2 tokens for interacting with the external repository, on the user account's behalf."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string Password {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The external repository for which this authorization has been provided. The only supported repository today is cisco.com.\n* `Cisco` - External repository hosted on cisco.com.\n* `IntersightCloud` - Repository hosted by the Intersight Cloud.\n* `LocalMachine` - The file is available on the local client machine. Used as an upload source type.\n* `NetworkShare` - External repository in the customer datacenter. This will typically be a file server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public SoftwarerepositoryAuthorization.RepositoryTypeEnum RepositoryType {
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
        /// <para type="description">"The username that will be used by Intersight to create OAuth2 tokens for interacting with the external repository, on the user account's behalf."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true,ValueFromPipeline = false)]
        
        public string UserId {
            get;
            set;
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get SoftwarerepositoryAuthorization.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightSoftwarerepositoryAuthorization", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightSoftwarerepositoryAuthorization:GetCmdletBase
	{
		public GetIntersightSoftwarerepositoryAuthorization()
		{
			ApiInstance = new SoftwarerepositoryApi(Config);
            MethodName = "GetSoftwarerepositoryAuthorizationList";
		}
    }
}