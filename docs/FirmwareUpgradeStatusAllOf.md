# FirmwareUpgradeStatusAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DownloadError** | **String** | The error message from the endpoint during the download. | [optional] 
**DownloadMessage** | [**AnyType**](.md) | The message from the endpoint during the download.} type: string | [optional] 
**DownloadPercentage** | **Int64** | The percentage of the image downloaded in the endpoint. | [optional] 
**DownloadProgress** | **Int64** | The download progress of the file represented as a percentage between 0% and 100%. If progress reporting is not possible a value of -1 is sent. | [optional] 
**DownloadRetries** | **Int64** | The number of retries the plugin attempted before succeeding or failing the download. | [optional] 
**DownloadStage** | **String** | The image download stages. Example:downloading, flashing. | [optional] 
**EpPowerStatus** | **String** | The server power status after the upgrade request is submitted in the endpoint. | [optional] [default to "none"]
**OverallError** | **String** | The reason for the operation failure. | [optional] 
**OverallPercentage** | **Int64** | The overall percentage of the operation. | [optional] 
**Overallstatus** | **String** | The overall status of the operation. | [optional] [default to "none"]
**PendingType** | **String** | Pending reason for the upgrade waiting. | [optional] [default to "none"]
**Sha256checksum** | [**SystemByte**](SystemByte.md) | The sha256checksum of the downloaded file as calculated by the download plugin after successfully downloading a file. | [optional] 
**Upgrade** | [**FirmwareUpgradeBaseRelationship**](FirmwareUpgradeBaseRelationship.md) |  | [optional] 
**Workflow** | [**WorkflowWorkflowInfoRelationship**](WorkflowWorkflowInfoRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFirmwareUpgradeStatusAllOf  -DownloadError null `
 -DownloadMessage null `
 -DownloadPercentage null `
 -DownloadProgress null `
 -DownloadRetries null `
 -DownloadStage null `
 -EpPowerStatus null `
 -OverallError null `
 -OverallPercentage null `
 -Overallstatus null `
 -PendingType null `
 -Sha256checksum null `
 -Upgrade null `
 -Workflow null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

