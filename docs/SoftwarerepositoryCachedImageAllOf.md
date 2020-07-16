# SoftwarerepositoryCachedImageAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
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
Initialize-IntersightSoftwarerepositoryCachedImageAllOf  -Action null `
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

