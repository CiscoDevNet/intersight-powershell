# SoftwarerepositoryFileAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
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

## Examples

- Prepare the resource
```powershell
Initialize-IntersightSoftwarerepositoryFileAllOf  -Description null `
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
 -Version null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

