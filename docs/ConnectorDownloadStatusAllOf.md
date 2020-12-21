# ConnectorDownloadStatusAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | [default to "softwarerepository.CachedImage"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | [default to "softwarerepository.CachedImage"]
**Checksum** | [**ConnectorFileChecksum**](ConnectorFileChecksum.md) |  | [optional] 
**DownloadError** | **String** | Any error encountered. Set to empty when download is in progress or completed. | [optional] 
**DownloadProgress** | **Int64** | The download progress of the file represented as a percentage between 0% and 100%. If progress reporting is not possible a value of -1 is sent. | [optional] 
**DownloadRetries** | **Int64** | The number of retries the plugin attempted before succeeding or failing the download. | [optional] 
**Sha256checksum** | [**SystemByte**](SystemByte.md) | The sha256checksum of the downloaded file as calculated by the download plugin after successfully downloading a file. | [optional] 

## Examples

- Prepare the resource
```powershell
$ConnectorDownloadStatusAllOf = Initialize-IntersightConnectorDownloadStatusAllOf  -ClassId null `
 -ObjectType null `
 -Checksum null `
 -DownloadError null `
 -DownloadProgress null `
 -DownloadRetries null `
 -Sha256checksum null
```

- Convert the resource to JSON
```powershell
$ConnectorDownloadStatusAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

