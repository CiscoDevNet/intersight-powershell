# FirmwareDirectDownloadAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "firmware.DirectDownload"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "firmware.DirectDownload"]
**HttpServer** | [**FirmwareHttpServer**](FirmwareHttpServer.md) |  | [optional] 
**ImageSource** | **String** | Source type referring the image to be downloaded from CCO or from a local HTTPS server. * &#x60;cisco&#x60; - Image to be downloaded from Cisco software repository. * &#x60;localHttp&#x60; - Image to be downloaded from a https server. | [optional] [default to "cisco"]
**IsPasswordSet** | **Boolean** | Indicates whether the value of the &#39;password&#39; property has been set. | [optional] [readonly] [default to $false]
**Password** | **String** | Password as configured on the local https server. | [optional] 
**Upgradeoption** | **String** | Option to control the upgrade, e.g., sd_upgrade_mount_only - download the image into sd and upgrade wait for the server on-next boot. * &#x60;sd_upgrade_mount_only&#x60; - Direct upgrade SD upgrade mount only. * &#x60;sd_download_only&#x60; - Direct upgrade SD download only. * &#x60;sd_upgrade_only&#x60; - Direct upgrade SD upgrade only. * &#x60;sd_upgrade_full&#x60; - Direct upgrade SD upgrade full. * &#x60;upgrade_full&#x60; - The upgrade downloads or mounts the image, and reboots immediately for an upgrade. * &#x60;upgrade_mount_only&#x60; - The upgrade downloads or mounts the image. The upgrade happens in next reboot. * &#x60;chassis_upgrade_full&#x60; - Direct upgrade chassis upgrade full. | [optional] [default to "sd_upgrade_mount_only"]
**Username** | **String** | Username as configured on the local https server. | [optional] 

## Examples

- Prepare the resource
```powershell
$FirmwareDirectDownloadAllOf = Initialize-IntersightFirmwareDirectDownloadAllOf  -ClassId null `
 -ObjectType null `
 -HttpServer null `
 -ImageSource null `
 -IsPasswordSet null `
 -Password null `
 -Upgradeoption null `
 -Username null
```

- Convert the resource to JSON
```powershell
$FirmwareDirectDownloadAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

