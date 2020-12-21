# SoftwarerepositoryOperatingSystemFile
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "softwarerepository.OperatingSystemFile"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "softwarerepository.OperatingSystemFile"]
**AccountMoid** | **String** | The Account ID for this managed object. | [optional] [readonly] 
**CreateTime** | **System.DateTime** | The time when this managed object was created. | [optional] [readonly] 
**DomainGroupMoid** | **String** | The DomainGroup ID for this managed object. | [optional] [readonly] 
**ModTime** | **System.DateTime** | The time when this managed object was last modified. | [optional] [readonly] 
**Moid** | **String** | The unique identifier of this Managed Object instance. | [optional] 
**Owners** | **String[]** |  | [optional] 
**SharedScope** | **String** | Intersight provides pre-built workflows, tasks and policies to end users through global catalogs. Objects that are made available through global catalogs are said to have a &#39;shared&#39; ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs. | [optional] [readonly] 
**Tags** | [**MoTag[]**](MoTag.md) |  | [optional] 
**VersionContext** | [**MoVersionContext**](MoVersionContext.md) |  | [optional] 
**Ancestors** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**Parent** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**PermissionResources** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**DisplayNames** | [**System.Collections.Hashtable**](Array.md) | A set of display names for the MO resource. These names are calculated based on other properties of the MO and potentially properties of Ancestor MOs. Displaynames are intended as a way to provide a normalized user appropriate name for an MO, especially for MOs which do not have a &#39;Name&#39; property, which is the case for much of the inventory discovered from managed targets. There are a limited number of keys, currently &#39;short&#39; and &#39;hierarchical&#39;. The value is an array and clients should use the first element of the array. | [optional] [readonly] 
**Description** | **String** | User provided description about the file. Cisco provided description for image inventoried from a Cisco repository. | [optional] 
**DownloadCount** | **Int64** | The number of times this file has been downloaded from the local repository. It is used by the repository monitoring process to determine the files that are to be evicted from the cache. | [optional] [readonly] 
**ImportAction** | **String** | The action to be performed on the imported file. If &#39;PreCache&#39; is set, the image will be cached in Appliance. Applicable in Intersight appliance deployment. If &#39;Evict&#39; is set, the cached file will be removed. Applicable in Intersight appliance deployment. If &#39;GeneratePreSignedUploadUrl&#39; is set, generates pre signed URL (s) for the file to be imported into the repository. Applicable for local machine source. The URL (s) will be populated under LocalMachine file server. If &#39;CompleteImportProcess&#39; is set, the ImportState is marked as &#39;Imported&#39;. Applicable for local machine source. If &#39;Cancel&#39; is set, the ImportState is marked as &#39;Failed&#39;. Applicable for local machine source. * &#x60;None&#x60; - No action should be taken on the imported file. * &#x60;GeneratePreSignedUploadUrl&#x60; - Generate pre signed URL of file for importing into the repository. * &#x60;GeneratePreSignedDownloadUrl&#x60; - Generate pre signed URL of file in the repository to download. * &#x60;CompleteImportProcess&#x60; - Mark that the import process of the file into the repository is complete. * &#x60;MarkImportFailed&#x60; - Mark to indicate that the import process of the file into the repository failed. * &#x60;PreCache&#x60; - Cache the file into the Intersight Appliance. * &#x60;Cancel&#x60; - The cancel import process for the file into the repository. * &#x60;Extract&#x60; - The action to extract the file in the external repository. * &#x60;Evict&#x60; - Evict the cached file from the Intersight Appliance. | [optional] [default to "None"]
**ImportState** | **String** | The state  of this file in the repository or Appliance. The importState is updated during the import operation and as part of the repository monitoring process. * &#x60;ReadyForImport&#x60; - The image is ready to be imported into the repository. * &#x60;Importing&#x60; - The image is being imported into the repository. * &#x60;Imported&#x60; - The image has been extracted and imported into the repository. * &#x60;PendingExtraction&#x60; - Indicates that the image has been imported but not extracted in the repository. * &#x60;Extracting&#x60; - Indicates that the image is being extracted into the repository. * &#x60;Extracted&#x60; - Indicates that the image has been extracted into the repository. * &#x60;Failed&#x60; - The image import from an external source to the repository has failed. * &#x60;MetaOnly&#x60; - The image is present in an external repository. * &#x60;ReadyForCache&#x60; - The image is ready to be cached into the Intersight Appliance. * &#x60;Caching&#x60; - Indicates that the image is being cached into the Intersight Appliance or endpoint cache. * &#x60;Cached&#x60; - Indicates that the image has been cached into the Intersight Appliance or endpoint cache. * &#x60;CachingFailed&#x60; - Indicates that the image caching into the Intersight Appliance failed or endpoint cache. * &#x60;Corrupted&#x60; - Indicates that the image in the local repository (or endpoint cache) has been corrupted after it was cached. * &#x60;Evicted&#x60; - Indicates that the image has been evicted from the Intersight Appliance (or endpoint cache) to reclaim storage space. | [optional] [readonly] [default to "ReadyForImport"]
**ImportedTime** | **System.DateTime** | The time at which this image or file was imported/cached into the repositry. if the &#39;ImportState&#39; is &#39;Imported&#39;, the time at which this image or file was imported. if the &#39;ImportState&#39; is &#39;Cached&#39;, the time at which this image or file was cached. | [optional] [readonly] 
**LastAccessTime** | **System.DateTime** | The time at which this file was last downloaded from the local repository. It is used by the repository monitoring process to determine the files that are to be evicted from the cache. | [optional] [readonly] 
**Md5eTag** | **String** | The MD5 ETag for a file that is stored in Intersight repository or in the appliance cache. Warning - MD5 is currently broken and this will be migrated to SHA shortly. | [optional] 
**Md5sum** | **String** | The md5sum checksum of the file. This information is available for all Cisco distributed images and files imported to the local repository. | [optional] 
**Name** | **String** | The name of the file. It is populated as part of the image import operation. | [optional] 
**ReleaseDate** | **System.DateTime** | The date on which the file was released or distributed by its vendor. | [optional] 
**Sha512sum** | **String** | The sha512sum of the file. This information is available for all Cisco distributed images and files imported to the local repository. | [optional] 
**Size** | **Int64** | The size (in bytes) of the file. This information is available for all Cisco distributed images and files imported to the local repository. | [optional] 
**SoftwareAdvisoryUrl** | **String** | The software advisory, if any, provided by the vendor for this file. | [optional] 
**Source** | [**SoftwarerepositoryFileServer**](SoftwarerepositoryFileServer.md) |  | [optional] 
**Version** | **String** | Vendor provided version for the file. | [optional] 
**Vendor** | **String** | The vendor or publisher of this file. | [optional] 
**Catalog** | [**SoftwarerepositoryCatalogRelationship**](SoftwarerepositoryCatalogRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$SoftwarerepositoryOperatingSystemFile = Initialize-IntersightSoftwarerepositoryOperatingSystemFile  -ClassId null `
 -ObjectType null `
 -AccountMoid null `
 -CreateTime null `
 -DomainGroupMoid null `
 -ModTime null `
 -Moid null `
 -Owners null `
 -SharedScope null `
 -Tags null `
 -VersionContext null `
 -Ancestors null `
 -Parent null `
 -PermissionResources null `
 -DisplayNames null `
 -Description null `
 -DownloadCount null `
 -ImportAction null `
 -ImportState null `
 -ImportedTime null `
 -LastAccessTime null `
 -Md5eTag null `
 -Md5sum null `
 -Name null `
 -ReleaseDate null `
 -Sha512sum null `
 -Size null `
 -SoftwareAdvisoryUrl null `
 -Source null `
 -Version null `
 -Vendor null `
 -Catalog null
```

- Convert the resource to JSON
```powershell
$SoftwarerepositoryOperatingSystemFile | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

