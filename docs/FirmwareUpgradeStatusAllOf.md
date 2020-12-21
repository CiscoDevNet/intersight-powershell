# FirmwareUpgradeStatusAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "firmware.UpgradeStatus"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "firmware.UpgradeStatus"]
**DownloadError** | **String** | The error message from the endpoint during the download. | [optional] 
**DownloadMessage** | **String** | The message from the endpoint during the download. | [optional] 
**DownloadPercentage** | **Int64** | The percentage of the image downloaded in the endpoint. | [optional] 
**DownloadProgress** | **Int64** | The download progress of the file represented as a percentage between 0% and 100%. If progress reporting is not possible a value of -1 is sent. | [optional] 
**DownloadRetries** | **Int64** | The number of retries the plugin attempted before succeeding or failing the download. | [optional] 
**DownloadStage** | **String** | The image download stages. Example:downloading, flashing. | [optional] 
**EpPowerStatus** | **String** | The server power status after the upgrade request is submitted in the endpoint. * &#x60;none&#x60; - Server power status is none. * &#x60;powered on&#x60; - Server power status is powered on. * &#x60;powered off&#x60; - Server power status is powered off. | [optional] [default to "none"]
**OverallError** | **String** | The reason for the operation failure. | [optional] 
**OverallPercentage** | **Int64** | The overall percentage of the operation. | [optional] 
**Overallstatus** | **String** | The overall status of the operation. * &#x60;none&#x60; - Upgrade stage is no upgrade stage. * &#x60;started&#x60; - Upgrade stage is started. * &#x60;prepare initiating&#x60; - Upgrade configuration is being prepared. * &#x60;prepare initiated&#x60; - Upgrade configuration is initiated. * &#x60;prepared&#x60; - Upgrade configuration is prepared. * &#x60;download initiating&#x60; - Upgrade stage is download initiating. * &#x60;download initiated&#x60; - Upgrade stage is download initiated. * &#x60;downloading&#x60; - Upgrade stage is downloading. * &#x60;downloaded&#x60; - Upgrade stage is downloaded. * &#x60;upgrade initiating on fabric A&#x60; - Upgrade stage is in upgrade initiating when upgrade is being started in endopint. * &#x60;upgrade initiated on fabric A&#x60; - Upgrade stage is in upgrade initiated when the upgrade has started in endpoint. * &#x60;upgrading fabric A&#x60; - Upgrade stage is in upgrading when the upgrade requires reboot to complete. * &#x60;rebooting fabric A&#x60; - Upgrade is in rebooting when the endpoint is being rebooted. * &#x60;upgraded fabric A&#x60; - Upgrade stage is in upgraded when the corresponding endpoint has completed. * &#x60;upgrade initiating on fabric B&#x60; - Upgrade stage is in upgrade initiating when upgrade is being started in endopint. * &#x60;upgrade initiated on fabric B&#x60; - Upgrade stage is in upgrade initiated when upgrade has started in endpoint. * &#x60;upgrading fabric B&#x60; - Upgrade stage is in upgrading when the upgrade requires reboot to complete. * &#x60;rebooting fabric B&#x60; - Upgrade is in rebooting when the endpoint is being rebooted. * &#x60;upgraded fabric B&#x60; - Upgrade stage is in upgraded when the corresponding endpoint has completed. * &#x60;upgrade initiating&#x60; - Upgrade stage is upgrade initiating. * &#x60;upgrade initiated&#x60; - Upgrade stage is upgrade initiated. * &#x60;upgrading&#x60; - Upgrade stage is upgrading. * &#x60;oob images staging&#x60; - Out-of-band component images staging. * &#x60;oob images staged&#x60; - Out-of-band component images staged. * &#x60;rebooting&#x60; - Upgrade is rebooting the endpoint. * &#x60;upgraded&#x60; - Upgrade stage is upgraded. * &#x60;success&#x60; - Upgrade stage is success. * &#x60;failed&#x60; - Upgrade stage is upgrade failed. * &#x60;terminated&#x60; - Upgrade stage is terminated. * &#x60;pending&#x60; - Upgrade stage is pending. * &#x60;ReadyForCache&#x60; - The image is ready to be cached into the Intersight Appliance. * &#x60;Caching&#x60; - The image will be cached into Intersight Appliance or an endpoint cache. * &#x60;Cached&#x60; - The image has been cached into the Intersight Appliance or endpoint cache. * &#x60;CachingFailed&#x60; - The image caching into the Intersight Appliance failed or endpoint cache. | [optional] [default to "none"]
**PendingType** | **String** | Pending reason for the upgrade waiting. * &#x60;none&#x60; - Upgrade pending reason is none. * &#x60;pending for next reboot&#x60; - Upgrade pending reason is pending for next reboot. | [optional] [default to "none"]
**Sha256checksum** | [**SystemByte**](SystemByte.md) | The sha256checksum of the downloaded file as calculated by the download plugin after successfully downloading a file. | [optional] 
**Upgrade** | [**FirmwareUpgradeBaseRelationship**](FirmwareUpgradeBaseRelationship.md) |  | [optional] 
**Workflow** | [**WorkflowWorkflowInfoRelationship**](WorkflowWorkflowInfoRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$FirmwareUpgradeStatusAllOf = Initialize-IntersightFirmwareUpgradeStatusAllOf  -ClassId null `
 -ObjectType null `
 -DownloadError null `
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
$FirmwareUpgradeStatusAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

