# ConnectorDownloadStatusAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Checksum** | [**ConnectorFileChecksum**](ConnectorFileChecksum.md) |  | [optional] 
**DownloadError** | [**AnyType**](.md) | Any error encountered. Set to empty when download is in progress or completed.} type: string | [optional] 
**DownloadProgress** | **Int64** | The download progress of the file represented as a percentage between 0% and 100%. If progress reporting is not possible a value of -1 is sent. | [optional] 
**DownloadRetries** | **Int64** | The number of retries the plugin attempted before succeeding or failing the download. | [optional] 
**Sha256checksum** | [**SystemByte**](SystemByte.md) | The sha256checksum of the downloaded file as calculated by the download plugin after successfully downloading a file. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightConnectorDownloadStatusAllOf  -Checksum null `
 -DownloadError null `
 -DownloadProgress null `
 -DownloadRetries null `
 -Sha256checksum null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

