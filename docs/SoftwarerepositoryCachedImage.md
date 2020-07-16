# SoftwarerepositoryCachedImage
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
**Checksum** | [**ConnectorFileChecksum**](ConnectorFileChecksum.md) |  | [optional] 
**DownloadError** | [**AnyType**](.md) | Any error encountered. Set to empty when download is in progress or completed.} type: string | [optional] 
**DownloadProgress** | **Int64** | The download progress of the file represented as a percentage between 0% and 100%. If progress reporting is not possible a value of -1 is sent. | [optional] 
**DownloadRetries** | **Int64** | The number of retries the plugin attempted before succeeding or failing the download. | [optional] 
**Sha256checksum** | [**SystemByte**](SystemByte.md) | The sha256checksum of the downloaded file as calculated by the download plugin after successfully downloading a file. | [optional] 
**Action** | **String** | The action to be performed on the imported file. If &#39;PreCache&#39; is set, the image will be cached in endpoint. If &#39;Evict&#39; is set, the cached file will be removed. Applicable in Intersight appliance deployment. If &#39;Cancel&#39; is set, the ImportState is marked as &#39;Failed&#39;. Applicable for local machine source. | [optional] [default to "None"]
**CacheState** | **String** | The state  of this file in the endpoint The importState is updated during the cache operation and as part of the cache monitoring process. | [optional] [readonly] [default to "ReadyForImport"]
**CachedTime** | **System.DateTime** | The time when the image or file was cached into the FI storage. | [optional] [readonly] 
**LastAccessTime** | **System.DateTime** | Used by the cache monitoring process to determine the files that are to be evicted from the cache. | [optional] [readonly] 
**Md5sum** | **String** | The MD5 sum of the firmware image that will be used by the endpoint to validate the integrity of the image. | [optional] [readonly] 
**OriginalSha512sum** | **String** | The actual sha512sum of the cached image. | [optional] [readonly] 
**Path** | **String** | The absolute path of the imported file in the endpoint. | [optional] [readonly] 
**RegisteredWorkflows** | **String[]** |  | [optional] 
**UsedCount** | **Int64** | The number of times this file has been used to copy or upgrade or install actions. Used by the cache monitoring process to determine the files to be evicted from the cache. | [optional] [readonly] 
**File** | [**SoftwarerepositoryFileRelationship**](SoftwarerepositoryFileRelationship.md) |  | [optional] 
**NetworkElement** | [**NetworkElementRelationship**](NetworkElementRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightSoftwarerepositoryCachedImage  -AccountMoid null `
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
 -Checksum null `
 -DownloadError null `
 -DownloadProgress null `
 -DownloadRetries null `
 -Sha256checksum null `
 -Action null `
 -CacheState null `
 -CachedTime null `
 -LastAccessTime null `
 -Md5sum null `
 -OriginalSha512sum null `
 -Path null `
 -RegisteredWorkflows null `
 -UsedCount null `
 -File null `
 -NetworkElement null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

