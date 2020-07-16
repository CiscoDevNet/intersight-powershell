# FirmwareBaseDistributable
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountMoid** | **String** | The Account ID for this managed object. | [optional] [readonly] 
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**CreateTime** | **System.DateTime** | The time when this managed object was created. | [optional] [readonly] 
**DomainGroupMoid** | **String** | The DomainGroup ID for this managed object. | [optional] [readonly] 
**ModTime** | **System.DateTime** | The time when this managed object was last modified. | [optional] [readonly] 
**Moid** | **String** | The unique identifier of this Managed Object instance. | [optional] 
**ObjectType** | **String** | The fully-qualified type of this managed object, i.e. the class name. This property is optional. The ObjectType is implied from the URL path. If specified, the value of objectType must match the class name specified in the URL path. | [readonly] 
**Owners** | **String[]** |  | [optional] 
**SharedScope** | **String** | Intersight provides pre-built workflows, tasks and policies to end users through global catalogs. Objects that are made available through global catalogs are said to have a &#39;shared&#39; ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs. | [optional] [readonly] 
**Tags** | [**MoTag[]**](MoTag.md) |  | [optional] 
**VersionContext** | [**MoVersionContext**](MoVersionContext.md) |  | [optional] 
**Ancestors** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**Parent** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**PermissionResources** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**DisplayNames** | [**System.Collections.Hashtable**](Array.md) | a map of display names for a resource. | [optional] [readonly] 
**Description** | **String** | User provided description about the file. Cisco provided description for image inventoried from a Cisco repository. | [optional] 
**DownloadCount** | **Int64** | The number of times this file has been downloaded from the local repository. It is used by the repository monitoring process to determine the files that are to be evicted from the cache. | [optional] [readonly] 
**ImportAction** | **String** | The action to be performed on the imported file. If &#39;PreCache&#39; is set, the image will be cached in Appliance. Applicable in Intersight appliance deployment. If &#39;Evict&#39; is set, the cached file will be removed. Applicable in Intersight appliance deployment. If &#39;GeneratePreSignedUploadUrl&#39; is set, generates pre signed URL (s) for the file to be imported into the repository. Applicable for local machine source. The URL (s) will be populated under LocalMachine file server. If &#39;CompleteImportProcess&#39; is set, the ImportState is marked as &#39;Imported&#39;. Applicable for local machine source. If &#39;Cancel&#39; is set, the ImportState is marked as &#39;Failed&#39;. Applicable for local machine source. | [optional] [default to "None"]
**ImportState** | **String** | The state  of this file in the repository or Appliance. The importState is updated during the import operation and as part of the repository monitoring process. | [optional] [readonly] [default to "ReadyForImport"]
**ImportedTime** | **System.DateTime** | The time at which this image or file was imported/cached into the repositry. if the &#39;ImportState&#39; is &#39;Imported&#39;, the time at which this image or file was imported. if the &#39;ImportState&#39; is &#39;Cached&#39;, the time at which this image or file was cached. | [optional] [readonly] 
**LastAccessTime** | **System.DateTime** | The time at which this file was last downloaded from the local repository. It is used by the repository monitoring process to determine the files that are to be evicted from the cache. | [optional] [readonly] 
**Md5sum** | **String** | The md5sum checksum of the file. This information is available for all Cisco distributed images and files imported to the local repository. | [optional] 
**Name** | **String** | The name of the file. It is populated as part of the image import operation. | [optional] 
**ReleaseDate** | **System.DateTime** | The date on which the file was released or distributed by its vendor. | [optional] 
**Sha512sum** | **String** | The sha512sum of the file. This information is available for all Cisco distributed images and files imported to the local repository. | [optional] 
**Size** | **Int64** | The size (in bytes) of the file. This information is available for all Cisco distributed images and files imported to the local repository. | [optional] 
**SoftwareAdvisoryUrl** | **String** | The software advisory, if any, provided by the vendor for this file. | [optional] 
**Source** | [**SoftwarerepositoryFileServer**](SoftwarerepositoryFileServer.md) |  | [optional] 
**Version** | **String** | Vendor provided version for the file. | [optional] 
**BundleType** | **String** | The bundle type of the image, as published on cisco.com. | [optional] [readonly] 
**ComponentMeta** | [**FirmwareComponentMeta[]**](FirmwareComponentMeta.md) |  | [optional] 
**Guid** | **String** | The unique identifier for an image in a Cisco repository. | [optional] [readonly] 
**Mdfid** | **String** | The mdfid of the image provided by cisco.com. | [optional] 
**Model** | **String** | The endpoint model for which this firmware image is applicable. | [optional] 
**PlatformType** | **String** | The platform type of the image. | [optional] [readonly] 
**RecommendedBuild** | **String** | The build which is recommended by Cisco. | [optional] 
**ReleaseNotesUrl** | **String** | The url for the release notes of this image. | [optional] 
**SoftwareTypeId** | **String** | The software type id provided by cisco.com. | [optional] [readonly] 
**SupportedModels** | **String[]** |  | [optional] 
**Vendor** | **String** | The vendor or publisher of this file. | [optional] 
**DistributableMetas** | [**FirmwareDistributableMetaRelationship[]**](FirmwareDistributableMetaRelationship.md) | An array of relationships to firmwareDistributableMeta resources. | [optional] 
**Release** | [**SoftwarerepositoryReleaseRelationship**](SoftwarerepositoryReleaseRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFirmwareBaseDistributable  -AccountMoid null `
 -ClassId null `
 -CreateTime null `
 -DomainGroupMoid null `
 -ModTime null `
 -Moid null `
 -ObjectType null `
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
 -Md5sum null `
 -Name null `
 -ReleaseDate null `
 -Sha512sum null `
 -Size null `
 -SoftwareAdvisoryUrl null `
 -Source null `
 -Version null `
 -BundleType null `
 -ComponentMeta null `
 -Guid null `
 -Mdfid null `
 -Model null `
 -PlatformType null `
 -RecommendedBuild null `
 -ReleaseNotesUrl null `
 -SoftwareTypeId null `
 -SupportedModels null `
 -Vendor null `
 -DistributableMetas null `
 -Release null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

