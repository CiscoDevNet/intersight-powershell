using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get SoftwarerepositoryAuthorization.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightSoftwarerepositoryAuthorization", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightSoftwarerepositoryAuthorization : GetCmdletBase
    {
        public GetIntersightSoftwarerepositoryAuthorization()
        {
            ApiInstance = new SoftwarerepositoryApi(Config);
            MethodName = "GetSoftwarerepositoryAuthorizationListWithHttpInfo";
        }

        // <summary>
        /// <para type="description">"A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public IamAccountRelationship Account
        {
            get;
            set;
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
        /// <para type="description">"The state of the alarm dismissal for the 'IsAsdDialogDismissed' alarm."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool IsAsdv4AlarmDismissed
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Indicates whether the value of the 'password' property has been set."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool IsPasswordSet
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
        /// <para type="description">"The password that will be used by Intersight to create OAuth2 tokens for interacting with the external repository, on the user account's behalf."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Password
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The external repository for which this authorization has been provided. The only supported repository today is cisco.com.\n* `Cisco` - External repository hosted on cisco.com.\n* `IntersightCloud` - Repository hosted by the Intersight Cloud.\n* `LocalMachine` - The file is available on the local client machine. Used as an upload source type.\n* `NetworkShare` - External repository in the customer datacenter. This will typically be a file server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public SoftwarerepositoryAuthorization.RepositoryTypeEnum RepositoryType
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
        /// <para type="description">"The username that will be used by Intersight to create OAuth2 tokens for interacting with the external repository, on the user account's behalf."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string UserId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The Automated Software Distribution version of the authorization MO.\n* `V3` - The client is running Automated Software Distribution V3.\n* `V4` - The client is running Automated Software Distribution V4."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public SoftwarerepositoryAuthorization.VarVersionEnum Version
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get SoftwarerepositoryCachedImage.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightSoftwarerepositoryCachedImage", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightSoftwarerepositoryCachedImage : GetCmdletBase
    {
        public GetIntersightSoftwarerepositoryCachedImage()
        {
            ApiInstance = new SoftwarerepositoryApi(Config);
            MethodName = "GetSoftwarerepositoryCachedImageListWithHttpInfo";
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
        /// <para type="description">"The action to be performed on the imported file. If 'PreCache' is set, the image will be cached in endpoint. If 'Evict' is set, the cached file will be removed. Applicable in Intersight appliance deployment. If 'Cancel' is set, the ImportState is marked as 'Failed'. Applicable for local machine source.\n* `None` - No action should be taken on the imported file.\n* `GeneratePreSignedUploadUrl` - Generate pre signed URL of file for importing into the repository.\n* `GeneratePreSignedDownloadUrl` - Generate pre signed URL of file in the repository to download.\n* `CompleteImportProcess` - Mark that the import process of the file into the repository is complete.\n* `MarkImportFailed` - Mark to indicate that the import process of the file into the repository failed.\n* `PreCache` - Cache the file into the Intersight Appliance.\n* `Cancel` - The cancel import process for the file into the repository.\n* `Extract` - The action to extract the file in the external repository.\n* `Evict` - Evict the cached file from the Intersight Appliance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public SoftwarerepositoryCachedImage.ActionEnum Action
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The state  of this file in the endpoint The importState is updated during the cache operation and as part of the cache monitoring process.\n* `ReadyForImport` - The image is ready to be imported into the repository.\n* `Importing` - The image is being imported into the repository.\n* `Imported` - The image has been extracted and imported into the repository.\n* `PendingExtraction` - Indicates that the image has been imported but not extracted in the repository.\n* `Extracting` - Indicates that the image is being extracted into the repository.\n* `Extracted` - Indicates that the image has been extracted into the repository.\n* `Failed` - The image import from an external source to the repository has failed.\n* `MetaOnly` - The image is present in an external repository.\n* `ReadyForCache` - The image is ready to be cached into the Intersight Appliance.\n* `Caching` - Indicates that the image is being cached into the Intersight Appliance or endpoint cache.\n* `Cached` - Indicates that the image has been cached into the Intersight Appliance or endpoint cache.\n* `CachingFailed` - Indicates that the image caching into the Intersight Appliance failed or endpoint cache.\n* `Corrupted` - Indicates that the image in the local repository (or endpoint cache) has been corrupted after it was cached.\n* `Evicted` - Indicates that the image has been evicted from the Intersight Appliance (or endpoint cache) to reclaim storage space.\n* `Invalid` - Indicates that the corresponding distributable MO has been removed from the backend. This can be due to unpublishing of an image."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public SoftwarerepositoryCachedImage.CacheStateEnum CacheState
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time when the image or file was cached into the FI storage."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime CachedTime
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
        /// <para type="description">"Any error encountered. Set to empty when download is in progress or completed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DownloadError
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The download progress of the file represented as a percentage between 0% and 100%. If progress reporting is not possible, a value of -1 is sent."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long DownloadProgress
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The number of retries the plugin attempted before succeeding or failing the download."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long DownloadRetries
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"A reference to a softwarerepositoryFile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public SoftwarerepositoryFileRelationship File
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Used by the cache monitoring process to determine the files that are to be evicted from the cache."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime LastAccessTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The MD5 sum of the firmware image that will be used by the endpoint to validate the integrity of the image."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Md5sum
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
        /// <para type="description">"A reference to a networkElement resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public NetworkElementRelationship NetworkElement
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The actual sha512sum of the cached image."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string OriginalSha512sum
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
        /// <para type="description">"The absolute path of the imported file in the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Path
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The sha256checksum of the downloaded file as calculated by the download plugin after successfully downloading a file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public byte Sha256checksum
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
        /// <para type="description">"The number of times this file has been used to copy or upgrade or install actions. Used by the cache monitoring process to determine the files to be evicted from the cache."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long UsedCount
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get SoftwarerepositoryCatalog.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightSoftwarerepositoryCatalog", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightSoftwarerepositoryCatalog : GetCmdletBase
    {
        public GetIntersightSoftwarerepositoryCatalog()
        {
            ApiInstance = new SoftwarerepositoryApi(Config);
            MethodName = "GetSoftwarerepositoryCatalogListWithHttpInfo";
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
        /// <para type="description">"The status of the image catalog synchronization operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool IsImagePullFailure
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
        /// <para type="description">"The name of the catalog. The names are populated and predefined during MO creation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Name
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
        /// <para type="description">"A reference to a iamSystem resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public IamSystemRelationship System
        {
            get;
            set;
        }




    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get SoftwarerepositoryCategoryMapper.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightSoftwarerepositoryCategoryMapper", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightSoftwarerepositoryCategoryMapper : GetCmdletBase
    {
        public GetIntersightSoftwarerepositoryCategoryMapper()
        {
            ApiInstance = new SoftwarerepositoryApi(Config);
            MethodName = "GetSoftwarerepositoryCategoryMapperListWithHttpInfo";
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
        /// <para type="description">"The category of the model series."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Category
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
        /// <para type="description">"The type of distributable image, example huu, scu, driver, os.\n* `Distributable` - Stores firmware host utility images and fabric images.\n* `DriverDistributable` - Stores driver distributable images.\n* `ServerConfigurationUtilityDistributable` - Stores server configuration utility images.\n* `OperatingSystemFile` - Stores operating system iso images.\n* `HyperflexDistributable` - It stores HyperFlex images."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public SoftwarerepositoryCategoryMapper.FileTypeEnum FileType
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The type of image based on the endpoint it can upgrade. For example, ucs-c420m5-huu-3.2.1a.iso can upgrade standalone servers, so the image type is Standalone Server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ImageType
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Defines whether NFS firmware upgrade is supported with this image type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool IsNfsUpgradeSupported
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Cisco software repository image category identifier."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string MdfId
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
        /// <para type="description">"An unique identifer for a capability descriptor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Name
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
        /// <para type="description">"The regex that all images of this category follow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string RegexPattern
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
        /// <para type="description">"The image can be downloaded from cisco.com or external cloud store.\n* `Cisco` - External repository hosted on cisco.com.\n* `IntersightCloud` - Repository hosted by the Intersight Cloud.\n* `LocalMachine` - The file is available on the local client machine. Used as an upload source type.\n* `NetworkShare` - External repository in the customer datacenter. This will typically be a file server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public SoftwarerepositoryCategoryMapper.SourceEnum Source
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The software type id provided by cisco.com."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SwId
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The version from which user can download images from amazon store, if source is external cloud store."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Version
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get SoftwarerepositoryCategoryMapperModel.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightSoftwarerepositoryCategoryMapperModel", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightSoftwarerepositoryCategoryMapperModel : GetCmdletBase
    {
        public GetIntersightSoftwarerepositoryCategoryMapperModel()
        {
            ApiInstance = new SoftwarerepositoryApi(Config);
            MethodName = "GetSoftwarerepositoryCategoryMapperModelListWithHttpInfo";
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
        /// <para type="description">"The category of the model series."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Category
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
        /// <para type="description">"The distributable tag value of the model series."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string DistTag
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
        /// <para type="description">"The type of image based on the endpoint it can upgrade. For example, ucs-bundle-6400-infra.4.1.2a.bin can upgrade ucs managed fabric interconnects, so the image type is UCS Managed Fabric Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ImageType
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Defines whether NFS firmware upgrade is supported with this image type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool IsNfsUpgradeSupported
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
        /// <para type="description">"An unique identifer for a capability descriptor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Name
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
        /// <para type="description">"The regex that all images of this model follow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string RegexPattern
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Cisco hardware model series."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SeriesId
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





    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get SoftwarerepositoryCategorySupportConstraint.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightSoftwarerepositoryCategorySupportConstraint", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightSoftwarerepositoryCategorySupportConstraint : GetCmdletBase
    {
        public GetIntersightSoftwarerepositoryCategorySupportConstraint()
        {
            ApiInstance = new SoftwarerepositoryApi(Config);
            MethodName = "GetSoftwarerepositoryCategorySupportConstraintListWithHttpInfo";
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
        /// <para type="description">"Identifier for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ConstraintId
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
        /// <para type="description">"Cisco software repository image category identifier."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string MdfId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Minimum image version from where the models can be supported."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string MinVersion
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
        /// <para type="description">"An unique identifer for a capability descriptor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Name
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
        /// <para type="description">"Fields which tells if the constraint is based on image name parsing."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public bool ParseFromImageName
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





    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get SoftwarerepositoryDownloadSpec.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightSoftwarerepositoryDownloadSpec", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightSoftwarerepositoryDownloadSpec : GetCmdletBase
    {
        public GetIntersightSoftwarerepositoryDownloadSpec()
        {
            ApiInstance = new SoftwarerepositoryApi(Config);
            MethodName = "GetSoftwarerepositoryDownloadSpecListWithHttpInfo";
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
        /// <para type="description">"The OAuth2 token that will be used during image download by the endpoint to authenticate with file server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string AuthToken
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The certificate of file server that will be used by the endpoint to validate the server before starting the file download."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Certificate
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
        /// <para type="description">"A reference to a softwarerepositoryFile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public SoftwarerepositoryFileRelationship File
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The name of the firmware image."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Filename
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"MD5 sum of the firmware image that will be used by the endpoint to validate the integrity of the image, post download."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Md5sum
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
        /// <para type="description">"Intersight provides pre-built workflows, tasks and policies to end users through global catalogs.\nObjects that are made available through global catalogs are said to have a 'shared' ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SharedScope
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The size (in bytes) of the firmware image."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long Size
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The URL of this file in file server. The endpoint uses this URL to download the file from the file server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Url
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get SoftwarerepositoryOperatingSystemFile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightSoftwarerepositoryOperatingSystemFile", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightSoftwarerepositoryOperatingSystemFile : GetCmdletBase
    {
        public GetIntersightSoftwarerepositoryOperatingSystemFile()
        {
            ApiInstance = new SoftwarerepositoryApi(Config);
            MethodName = "GetSoftwarerepositoryOperatingSystemFileListWithHttpInfo";
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
        /// <para type="description">"A reference to a softwarerepositoryCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public SoftwarerepositoryCatalogRelationship Catalog
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
        /// <para type="description">"User provided description about the file. Cisco provided description for image inventoried from a Cisco repository."</para>
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
        /// <para type="description">"The number of times this file has been downloaded from the local repository. It is used by the repository monitoring process to determine the files that are to be evicted from the cache."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long DownloadCount
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The name of the feature to which the uploaded file belongs.\n* `System` - This indicates system initiated file uploads.\n* `OpenAPIImport` - This indicates an OpenAPI file upload.\n* `PartnerIntegrationImport` - This indicates a Partner-Integration Appliance user file uploads."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public SoftwarerepositoryOperatingSystemFile.FeatureSourceEnum FeatureSource
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The action to be performed on the imported file. If 'PreCache' is set, the image will be cached in Appliance. Applicable in Intersight appliance deployment. If 'Evict' is set, the cached file will be removed. Applicable in Intersight appliance deployment. If 'GeneratePreSignedUploadUrl' is set, generates pre signed URL (s) for the file to be imported into the repository. Applicable for local machine source. The URL (s) will be populated under LocalMachine file server. If 'CompleteImportProcess' is set, the ImportState is marked as 'Imported'. Applicable for local machine source. If 'Cancel' is set, the ImportState is marked as 'Failed'. Applicable for local machine source.\n* `None` - No action should be taken on the imported file.\n* `GeneratePreSignedUploadUrl` - Generate pre signed URL of file for importing into the repository.\n* `GeneratePreSignedDownloadUrl` - Generate pre signed URL of file in the repository to download.\n* `CompleteImportProcess` - Mark that the import process of the file into the repository is complete.\n* `MarkImportFailed` - Mark to indicate that the import process of the file into the repository failed.\n* `PreCache` - Cache the file into the Intersight Appliance.\n* `Cancel` - The cancel import process for the file into the repository.\n* `Extract` - The action to extract the file in the external repository.\n* `Evict` - Evict the cached file from the Intersight Appliance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public SoftwarerepositoryOperatingSystemFile.ImportActionEnum ImportAction
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The state  of this file in the repository or Appliance. The importState is updated during the import operation and as part of the repository monitoring process.\n* `ReadyForImport` - The image is ready to be imported into the repository.\n* `Importing` - The image is being imported into the repository.\n* `Imported` - The image has been extracted and imported into the repository.\n* `PendingExtraction` - Indicates that the image has been imported but not extracted in the repository.\n* `Extracting` - Indicates that the image is being extracted into the repository.\n* `Extracted` - Indicates that the image has been extracted into the repository.\n* `Failed` - The image import from an external source to the repository has failed.\n* `MetaOnly` - The image is present in an external repository.\n* `ReadyForCache` - The image is ready to be cached into the Intersight Appliance.\n* `Caching` - Indicates that the image is being cached into the Intersight Appliance or endpoint cache.\n* `Cached` - Indicates that the image has been cached into the Intersight Appliance or endpoint cache.\n* `CachingFailed` - Indicates that the image caching into the Intersight Appliance failed or endpoint cache.\n* `Corrupted` - Indicates that the image in the local repository (or endpoint cache) has been corrupted after it was cached.\n* `Evicted` - Indicates that the image has been evicted from the Intersight Appliance (or endpoint cache) to reclaim storage space.\n* `Invalid` - Indicates that the corresponding distributable MO has been removed from the backend. This can be due to unpublishing of an image."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public SoftwarerepositoryOperatingSystemFile.ImportStateEnum ImportState
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time at which this image or file was imported/cached into the repositry. if the 'ImportState' is 'Imported', the time at which this image or file was imported. if the 'ImportState' is 'Cached', the time at which this image or file was cached."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ImportedTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The time at which this file was last downloaded from the local repository. It is used by the repository monitoring process to determine the files that are to be evicted from the cache."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime LastAccessTime
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The MD5 ETag for a file that is stored in Intersight repository or in the appliance cache. Warning - MD5 is currently broken and this will be migrated to SHA shortly."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Md5eTag
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The md5sum checksum of the file. This information is available for all Cisco distributed images and files imported to the local repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Md5sum
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
        /// <para type="description">"The name of the file. It is populated as part of the image import operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Name
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
        /// <para type="description">"The date on which the file was released or distributed by its vendor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ReleaseDate
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The sha512sum of the file. This information is available for all Cisco distributed images and files imported to the local repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Sha512sum
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
        /// <para type="description">"The size (in bytes) of the file. This information is available for all Cisco distributed images and files imported to the local repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public long Size
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The software advisory, if any, provided by the vendor for this file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string SoftwareAdvisoryUrl
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The vendor or publisher of this file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Vendor
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Vendor provided version for the file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Version
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Get SoftwarerepositoryRelease.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "IntersightSoftwarerepositoryRelease", DefaultParameterSetName = "CmdletParam")]
    public class GetIntersightSoftwarerepositoryRelease : GetCmdletBase
    {
        public GetIntersightSoftwarerepositoryRelease()
        {
            ApiInstance = new SoftwarerepositoryApi(Config);
            MethodName = "GetSoftwarerepositoryReleaseListWithHttpInfo";
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
        /// <para type="description">"A reference to a softwarerepositoryCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, ParameterSetName = "CmdletParam")]

        public SoftwarerepositoryCatalogRelationship Catalog
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
        /// <para type="description">"The date when the file was released or distributed by its vendor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public DateTime ReleaseDate
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The URL for the release notes of this image."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string ReleaseNotesUrl
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
        /// <para type="description">"The platform type for which the images are released. This can be a Fabric Interconnect or compute server hardware.\n* `FabricSwitch` - The images in a release that correspond to Fabric Interconnect switches.\n* `ComputeSystem` - The images in a release that correspond to servers."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public SoftwarerepositoryRelease.TypeEnum Type
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Cisco provided release version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false, ParameterSetName = "CmdletParam")]

        public string Version
        {
            get;
            set;
        }



    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New SoftwarerepositoryAuthorization.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightSoftwarerepositoryAuthorization")]
    public class NewIntersightSoftwarerepositoryAuthorization : NewCmdletBase
    {
        public NewIntersightSoftwarerepositoryAuthorization()
        {
            ApiInstance = new SoftwarerepositoryApi(Config);
            ModelObject = new SoftwarerepositoryAuthorization();
            MethodName = "CreateSoftwarerepositoryAuthorizationWithHttpInfo";
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
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The password that will be used by Intersight to create OAuth2 tokens for interacting with the external repository, on the user account's behalf."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Password
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The external repository for which this authorization has been provided. The only supported repository today is cisco.com.\n* `Cisco` - External repository hosted on cisco.com.\n* `IntersightCloud` - Repository hosted by the Intersight Cloud.\n* `LocalMachine` - The file is available on the local client machine. Used as an upload source type.\n* `NetworkShare` - External repository in the customer datacenter. This will typically be a file server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public SoftwarerepositoryAuthorization.RepositoryTypeEnum RepositoryType
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
        /// <para type="description">"The username that will be used by Intersight to create OAuth2 tokens for interacting with the external repository, on the user account's behalf."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string UserId
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New SoftwarerepositoryCategoryMapper.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightSoftwarerepositoryCategoryMapper")]
    public class NewIntersightSoftwarerepositoryCategoryMapper : NewCmdletBase
    {
        public NewIntersightSoftwarerepositoryCategoryMapper()
        {
            ApiInstance = new SoftwarerepositoryApi(Config);
            ModelObject = new SoftwarerepositoryCategoryMapper();
            MethodName = "CreateSoftwarerepositoryCategoryMapperWithHttpInfo";
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
        /// <para type="description">"The category of the model series."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Category
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The type of distributable image, example huu, scu, driver, os.\n* `Distributable` - Stores firmware host utility images and fabric images.\n* `DriverDistributable` - Stores driver distributable images.\n* `ServerConfigurationUtilityDistributable` - Stores server configuration utility images.\n* `OperatingSystemFile` - Stores operating system iso images.\n* `HyperflexDistributable` - It stores HyperFlex images."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public SoftwarerepositoryCategoryMapper.FileTypeEnum FileType
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The type of image based on the endpoint it can upgrade. For example, ucs-c420m5-huu-3.2.1a.iso can upgrade standalone servers, so the image type is Standalone Server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ImageType
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Defines whether NFS firmware upgrade is supported with this image type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsNfsUpgradeSupported
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Cisco software repository image category identifier."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string MdfId
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
        /// <para type="description">"An unique identifer for a capability descriptor."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"The regex that all images of this category follow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string RegexPattern
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The image can be downloaded from cisco.com or external cloud store.\n* `Cisco` - External repository hosted on cisco.com.\n* `IntersightCloud` - Repository hosted by the Intersight Cloud.\n* `LocalMachine` - The file is available on the local client machine. Used as an upload source type.\n* `NetworkShare` - External repository in the customer datacenter. This will typically be a file server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public SoftwarerepositoryCategoryMapper.SourceEnum Source
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> SupportedModels
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The software type id provided by cisco.com."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SwId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> TagTypes
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
        /// <para type="description">"The version from which user can download images from amazon store, if source is external cloud store."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New SoftwarerepositoryCategoryMapperModel.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightSoftwarerepositoryCategoryMapperModel")]
    public class NewIntersightSoftwarerepositoryCategoryMapperModel : NewCmdletBase
    {
        public NewIntersightSoftwarerepositoryCategoryMapperModel()
        {
            ApiInstance = new SoftwarerepositoryApi(Config);
            ModelObject = new SoftwarerepositoryCategoryMapperModel();
            MethodName = "CreateSoftwarerepositoryCategoryMapperModelWithHttpInfo";
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
        /// <para type="description">"The category of the model series."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Category
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The distributable tag value of the model series."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string DistTag
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The type of image based on the endpoint it can upgrade. For example, ucs-bundle-6400-infra.4.1.2a.bin can upgrade ucs managed fabric interconnects, so the image type is UCS Managed Fabric Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ImageType
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Defines whether NFS firmware upgrade is supported with this image type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsNfsUpgradeSupported
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
        /// <para type="description">"An unique identifer for a capability descriptor."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"The regex that all images of this model follow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string RegexPattern
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Cisco hardware model series."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SeriesId
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> SupportedModels
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
    /// <para type="synopsis">This is the cmdlet to New SoftwarerepositoryCategorySupportConstraint.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightSoftwarerepositoryCategorySupportConstraint")]
    public class NewIntersightSoftwarerepositoryCategorySupportConstraint : NewCmdletBase
    {
        public NewIntersightSoftwarerepositoryCategorySupportConstraint()
        {
            ApiInstance = new SoftwarerepositoryApi(Config);
            ModelObject = new SoftwarerepositoryCategorySupportConstraint();
            MethodName = "CreateSoftwarerepositoryCategorySupportConstraintWithHttpInfo";
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
        /// <para type="description">"Identifier for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ConstraintId
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<SoftwarerepositoryConstraintModels> FilteredModels
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Cisco software repository image category identifier."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string MdfId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Minimum image version from where the models can be supported."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string MinVersion
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
        /// <para type="description">"An unique identifer for a capability descriptor."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"Fields which tells if the constraint is based on image name parsing."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool ParseFromImageName
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> SupportedModels
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
    /// <para type="synopsis">This is the cmdlet to New SoftwarerepositoryOperatingSystemFile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightSoftwarerepositoryOperatingSystemFile")]
    public class NewIntersightSoftwarerepositoryOperatingSystemFile : NewCmdletBase
    {
        public NewIntersightSoftwarerepositoryOperatingSystemFile()
        {
            ApiInstance = new SoftwarerepositoryApi(Config);
            ModelObject = new SoftwarerepositoryOperatingSystemFile();
            MethodName = "CreateSoftwarerepositoryOperatingSystemFileWithHttpInfo";
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
        /// <para type="description">"A reference to a softwarerepositoryCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public SoftwarerepositoryCatalogRelationship Catalog
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"User provided description about the file. Cisco provided description for image inventoried from a Cisco repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"The action to be performed on the imported file. If 'PreCache' is set, the image will be cached in Appliance. Applicable in Intersight appliance deployment. If 'Evict' is set, the cached file will be removed. Applicable in Intersight appliance deployment. If 'GeneratePreSignedUploadUrl' is set, generates pre signed URL (s) for the file to be imported into the repository. Applicable for local machine source. The URL (s) will be populated under LocalMachine file server. If 'CompleteImportProcess' is set, the ImportState is marked as 'Imported'. Applicable for local machine source. If 'Cancel' is set, the ImportState is marked as 'Failed'. Applicable for local machine source.\n* `None` - No action should be taken on the imported file.\n* `GeneratePreSignedUploadUrl` - Generate pre signed URL of file for importing into the repository.\n* `GeneratePreSignedDownloadUrl` - Generate pre signed URL of file in the repository to download.\n* `CompleteImportProcess` - Mark that the import process of the file into the repository is complete.\n* `MarkImportFailed` - Mark to indicate that the import process of the file into the repository failed.\n* `PreCache` - Cache the file into the Intersight Appliance.\n* `Cancel` - The cancel import process for the file into the repository.\n* `Extract` - The action to extract the file in the external repository.\n* `Evict` - Evict the cached file from the Intersight Appliance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public SoftwarerepositoryOperatingSystemFile.ImportActionEnum ImportAction
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"The MD5 ETag for a file that is stored in Intersight repository or in the appliance cache. Warning - MD5 is currently broken and this will be migrated to SHA shortly."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Md5eTag
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The md5sum checksum of the file. This information is available for all Cisco distributed images and files imported to the local repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Md5sum
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
        /// <para type="description">"The name of the file. It is populated as part of the image import operation."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"The date on which the file was released or distributed by its vendor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime ReleaseDate
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The sha512sum of the file. This information is available for all Cisco distributed images and files imported to the local repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Sha512sum
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The size (in bytes) of the file. This information is available for all Cisco distributed images and files imported to the local repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Size
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The software advisory, if any, provided by the vendor for this file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SoftwareAdvisoryUrl
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Location of the file in an external repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public SoftwarerepositoryFileServer Source
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
        /// <para type="description">"The vendor or publisher of this file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vendor
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Vendor provided version for the file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to New SoftwarerepositoryRelease.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.New, "IntersightSoftwarerepositoryRelease")]
    public class NewIntersightSoftwarerepositoryRelease : NewCmdletBase
    {
        public NewIntersightSoftwarerepositoryRelease()
        {
            ApiInstance = new SoftwarerepositoryApi(Config);
            ModelObject = new SoftwarerepositoryRelease();
            MethodName = "CreateSoftwarerepositoryReleaseWithHttpInfo";
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
        /// <para type="description">"A reference to a softwarerepositoryCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public SoftwarerepositoryCatalogRelationship Catalog
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
        /// <para type="description">"The date when the file was released or distributed by its vendor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime ReleaseDate
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The URL for the release notes of this image."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ReleaseNotesUrl
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> SupportedModels
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
        /// <para type="description">"The platform type for which the images are released. This can be a Fabric Interconnect or compute server hardware.\n* `FabricSwitch` - The images in a release that correspond to Fabric Interconnect switches.\n* `ComputeSystem` - The images in a release that correspond to servers."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public SoftwarerepositoryRelease.TypeEnum Type
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Cisco provided release version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove SoftwarerepositoryCategoryMapper.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightSoftwarerepositoryCategoryMapper")]
    public class RemoveIntersightSoftwarerepositoryCategoryMapper : RemoveCmdletBase
    {
        public RemoveIntersightSoftwarerepositoryCategoryMapper()
        {
            ApiInstance = new SoftwarerepositoryApi(Config);
            MethodName = "DeleteSoftwarerepositoryCategoryMapperWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove SoftwarerepositoryCategoryMapperModel.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightSoftwarerepositoryCategoryMapperModel")]
    public class RemoveIntersightSoftwarerepositoryCategoryMapperModel : RemoveCmdletBase
    {
        public RemoveIntersightSoftwarerepositoryCategoryMapperModel()
        {
            ApiInstance = new SoftwarerepositoryApi(Config);
            MethodName = "DeleteSoftwarerepositoryCategoryMapperModelWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove SoftwarerepositoryCategorySupportConstraint.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightSoftwarerepositoryCategorySupportConstraint")]
    public class RemoveIntersightSoftwarerepositoryCategorySupportConstraint : RemoveCmdletBase
    {
        public RemoveIntersightSoftwarerepositoryCategorySupportConstraint()
        {
            ApiInstance = new SoftwarerepositoryApi(Config);
            MethodName = "DeleteSoftwarerepositoryCategorySupportConstraintWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove SoftwarerepositoryOperatingSystemFile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightSoftwarerepositoryOperatingSystemFile")]
    public class RemoveIntersightSoftwarerepositoryOperatingSystemFile : RemoveCmdletBase
    {
        public RemoveIntersightSoftwarerepositoryOperatingSystemFile()
        {
            ApiInstance = new SoftwarerepositoryApi(Config);
            MethodName = "DeleteSoftwarerepositoryOperatingSystemFileWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Remove SoftwarerepositoryRelease.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "IntersightSoftwarerepositoryRelease")]
    public class RemoveIntersightSoftwarerepositoryRelease : RemoveCmdletBase
    {
        public RemoveIntersightSoftwarerepositoryRelease()
        {
            ApiInstance = new SoftwarerepositoryApi(Config);
            MethodName = "DeleteSoftwarerepositoryReleaseWithHttpInfo";
        }
    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set SoftwarerepositoryAuthorization.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightSoftwarerepositoryAuthorization")]
    public class SetIntersightSoftwarerepositoryAuthorization : SetCmdletBase
    {
        public SetIntersightSoftwarerepositoryAuthorization()
        {
            ApiInstance = new SoftwarerepositoryApi(Config);
            ModelObject = new SoftwarerepositoryAuthorization();
            MethodName = "UpdateSoftwarerepositoryAuthorizationWithHttpInfo";
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
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The password that will be used by Intersight to create OAuth2 tokens for interacting with the external repository, on the user account's behalf."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Password
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The external repository for which this authorization has been provided. The only supported repository today is cisco.com.\n* `Cisco` - External repository hosted on cisco.com.\n* `IntersightCloud` - Repository hosted by the Intersight Cloud.\n* `LocalMachine` - The file is available on the local client machine. Used as an upload source type.\n* `NetworkShare` - External repository in the customer datacenter. This will typically be a file server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public SoftwarerepositoryAuthorization.RepositoryTypeEnum RepositoryType
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
        /// <para type="description">"The username that will be used by Intersight to create OAuth2 tokens for interacting with the external repository, on the user account's behalf."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string UserId
        {
            get;
            set;
        }


    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set SoftwarerepositoryCategoryMapper.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightSoftwarerepositoryCategoryMapper")]
    public class SetIntersightSoftwarerepositoryCategoryMapper : SetCmdletBase
    {
        public SetIntersightSoftwarerepositoryCategoryMapper()
        {
            ApiInstance = new SoftwarerepositoryApi(Config);
            ModelObject = new SoftwarerepositoryCategoryMapper();
            MethodName = "UpdateSoftwarerepositoryCategoryMapperWithHttpInfo";
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
        /// <para type="description">"The category of the model series."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Category
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"The type of distributable image, example huu, scu, driver, os.\n* `Distributable` - Stores firmware host utility images and fabric images.\n* `DriverDistributable` - Stores driver distributable images.\n* `ServerConfigurationUtilityDistributable` - Stores server configuration utility images.\n* `OperatingSystemFile` - Stores operating system iso images.\n* `HyperflexDistributable` - It stores HyperFlex images."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public SoftwarerepositoryCategoryMapper.FileTypeEnum FileType
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The type of image based on the endpoint it can upgrade. For example, ucs-c420m5-huu-3.2.1a.iso can upgrade standalone servers, so the image type is Standalone Server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ImageType
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Defines whether NFS firmware upgrade is supported with this image type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsNfsUpgradeSupported
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Cisco software repository image category identifier."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string MdfId
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
        /// <para type="description">"An unique identifer for a capability descriptor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"The regex that all images of this category follow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string RegexPattern
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The image can be downloaded from cisco.com or external cloud store.\n* `Cisco` - External repository hosted on cisco.com.\n* `IntersightCloud` - Repository hosted by the Intersight Cloud.\n* `LocalMachine` - The file is available on the local client machine. Used as an upload source type.\n* `NetworkShare` - External repository in the customer datacenter. This will typically be a file server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public SoftwarerepositoryCategoryMapper.SourceEnum Source
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> SupportedModels
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The software type id provided by cisco.com."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SwId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> TagTypes
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
        /// <para type="description">"The version from which user can download images from amazon store, if source is external cloud store."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set SoftwarerepositoryCategoryMapperModel.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightSoftwarerepositoryCategoryMapperModel")]
    public class SetIntersightSoftwarerepositoryCategoryMapperModel : SetCmdletBase
    {
        public SetIntersightSoftwarerepositoryCategoryMapperModel()
        {
            ApiInstance = new SoftwarerepositoryApi(Config);
            ModelObject = new SoftwarerepositoryCategoryMapperModel();
            MethodName = "UpdateSoftwarerepositoryCategoryMapperModelWithHttpInfo";
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
        /// <para type="description">"The category of the model series."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Category
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The distributable tag value of the model series."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string DistTag
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The type of image based on the endpoint it can upgrade. For example, ucs-bundle-6400-infra.4.1.2a.bin can upgrade ucs managed fabric interconnects, so the image type is UCS Managed Fabric Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ImageType
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Defines whether NFS firmware upgrade is supported with this image type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsNfsUpgradeSupported
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
        /// <para type="description">"An unique identifer for a capability descriptor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"The regex that all images of this model follow."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string RegexPattern
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Cisco hardware model series."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SeriesId
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> SupportedModels
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
    /// <para type="synopsis">This is the cmdlet to Set SoftwarerepositoryCategorySupportConstraint.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightSoftwarerepositoryCategorySupportConstraint")]
    public class SetIntersightSoftwarerepositoryCategorySupportConstraint : SetCmdletBase
    {
        public SetIntersightSoftwarerepositoryCategorySupportConstraint()
        {
            ApiInstance = new SoftwarerepositoryApi(Config);
            ModelObject = new SoftwarerepositoryCategorySupportConstraint();
            MethodName = "UpdateSoftwarerepositoryCategorySupportConstraintWithHttpInfo";
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
        /// <para type="description">"Identifier for this managed object."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ConstraintId
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<SoftwarerepositoryConstraintModels> FilteredModels
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Cisco software repository image category identifier."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string MdfId
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Minimum image version from where the models can be supported."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string MinVersion
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
        /// <para type="description">"An unique identifer for a capability descriptor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description">"Fields which tells if the constraint is based on image name parsing."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool ParseFromImageName
        {
            get;
            set;
        }



        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> SupportedModels
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
    /// <para type="synopsis">This is the cmdlet to Set SoftwarerepositoryOperatingSystemFile.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightSoftwarerepositoryOperatingSystemFile")]
    public class SetIntersightSoftwarerepositoryOperatingSystemFile : SetCmdletBase
    {
        public SetIntersightSoftwarerepositoryOperatingSystemFile()
        {
            ApiInstance = new SoftwarerepositoryApi(Config);
            ModelObject = new SoftwarerepositoryOperatingSystemFile();
            MethodName = "UpdateSoftwarerepositoryOperatingSystemFileWithHttpInfo";
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
        /// <para type="description">"A reference to a softwarerepositoryCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public SoftwarerepositoryCatalogRelationship Catalog
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"User provided description about the file. Cisco provided description for image inventoried from a Cisco repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"The action to be performed on the imported file. If 'PreCache' is set, the image will be cached in Appliance. Applicable in Intersight appliance deployment. If 'Evict' is set, the cached file will be removed. Applicable in Intersight appliance deployment. If 'GeneratePreSignedUploadUrl' is set, generates pre signed URL (s) for the file to be imported into the repository. Applicable for local machine source. The URL (s) will be populated under LocalMachine file server. If 'CompleteImportProcess' is set, the ImportState is marked as 'Imported'. Applicable for local machine source. If 'Cancel' is set, the ImportState is marked as 'Failed'. Applicable for local machine source.\n* `None` - No action should be taken on the imported file.\n* `GeneratePreSignedUploadUrl` - Generate pre signed URL of file for importing into the repository.\n* `GeneratePreSignedDownloadUrl` - Generate pre signed URL of file in the repository to download.\n* `CompleteImportProcess` - Mark that the import process of the file into the repository is complete.\n* `MarkImportFailed` - Mark to indicate that the import process of the file into the repository failed.\n* `PreCache` - Cache the file into the Intersight Appliance.\n* `Cancel` - The cancel import process for the file into the repository.\n* `Extract` - The action to extract the file in the external repository.\n* `Evict` - Evict the cached file from the Intersight Appliance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public SoftwarerepositoryOperatingSystemFile.ImportActionEnum ImportAction
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"The MD5 ETag for a file that is stored in Intersight repository or in the appliance cache. Warning - MD5 is currently broken and this will be migrated to SHA shortly."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Md5eTag
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The md5sum checksum of the file. This information is available for all Cisco distributed images and files imported to the local repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Md5sum
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
        /// <para type="description">"The name of the file. It is populated as part of the image import operation."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }




        // <summary>
        /// <para type="description">"The date on which the file was released or distributed by its vendor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime ReleaseDate
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The sha512sum of the file. This information is available for all Cisco distributed images and files imported to the local repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Sha512sum
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description">"The size (in bytes) of the file. This information is available for all Cisco distributed images and files imported to the local repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long Size
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The software advisory, if any, provided by the vendor for this file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string SoftwareAdvisoryUrl
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Location of the file in an external repository."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public SoftwarerepositoryFileServer Source
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
        /// <para type="description">"The vendor or publisher of this file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vendor
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Vendor provided version for the file."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Set SoftwarerepositoryRelease.</para>
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "IntersightSoftwarerepositoryRelease")]
    public class SetIntersightSoftwarerepositoryRelease : SetCmdletBase
    {
        public SetIntersightSoftwarerepositoryRelease()
        {
            ApiInstance = new SoftwarerepositoryApi(Config);
            ModelObject = new SoftwarerepositoryRelease();
            MethodName = "UpdateSoftwarerepositoryReleaseWithHttpInfo";
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
        /// <para type="description">"A reference to a softwarerepositoryCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public SoftwarerepositoryCatalogRelationship Catalog
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
        /// <para type="description">"The date when the file was released or distributed by its vendor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public DateTime ReleaseDate
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"The URL for the release notes of this image."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ReleaseNotesUrl
        {
            get;
            set;
        }


        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> SupportedModels
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
        /// <para type="description">"The platform type for which the images are released. This can be a Fabric Interconnect or compute server hardware.\n* `FabricSwitch` - The images in a release that correspond to Fabric Interconnect switches.\n* `ComputeSystem` - The images in a release that correspond to servers."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public SoftwarerepositoryRelease.TypeEnum Type
        {
            get;
            set;
        }

        // <summary>
        /// <para type="description">"Cisco provided release version."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

    }
}