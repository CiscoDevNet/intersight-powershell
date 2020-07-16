# FirmwareDirectDownloadAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HttpServer** | [**FirmwareHttpServer**](FirmwareHttpServer.md) |  | [optional] 
**ImageSource** | **String** | Source type referring the image to be downloaded from CCO or from a local HTTPS server. | [optional] [default to "cisco"]
**IsPasswordSet** | **Boolean** | Indicates whether the value of the &#39;password&#39; property has been set. | [optional] [readonly] 
**Password** | **String** | Password as configured on the local https server. | [optional] 
**Upgradeoption** | **String** | Option to control the upgrade, e.g., sd_upgrade_mount_only - download the image into sd and upgrade wait for the server on-next boot. | [optional] [default to "sd_upgrade_mount_only"]
**Username** | **String** | Username as configured on the local https server. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFirmwareDirectDownloadAllOf  -HttpServer null `
 -ImageSource null `
 -IsPasswordSet null `
 -Password null `
 -Upgradeoption null `
 -Username null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

