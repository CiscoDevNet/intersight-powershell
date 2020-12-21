# FirmwareNetworkShareAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "firmware.NetworkShare"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "firmware.NetworkShare"]
**CifsServer** | [**FirmwareCifsServer**](FirmwareCifsServer.md) |  | [optional] 
**HttpServer** | [**FirmwareHttpServer**](FirmwareHttpServer.md) |  | [optional] 
**IsPasswordSet** | **Boolean** | Indicates whether the value of the &#39;password&#39; property has been set. | [optional] [readonly] [default to $false]
**MapType** | **String** | File server protocols such as CIFS, NFS, WWW for HTTP (S) that hosts the image. * &#x60;nfs&#x60; - File server protocol used is NFS. * &#x60;cifs&#x60; - File server protocol used is CIFS. * &#x60;www&#x60; - File server protocol used is WWW. | [optional] [default to "nfs"]
**NfsServer** | [**FirmwareNfsServer**](FirmwareNfsServer.md) |  | [optional] 
**Password** | **String** | Password as configured on the file server. | [optional] 
**Upgradeoption** | **String** | Option to control the upgrade operation. Some examples, 1) nw_upgrade_mount_only - mount the image from a file server and run the upgrade on the next server boot and 2) nw_upgrade_full - mount the image and immediately run the upgrade. * &#x60;nw_upgrade_full&#x60; - Network upgrade option for full upgrade. * &#x60;nw_upgrade_mount_only&#x60; - Network upgrade mount only. | [optional] [default to "nw_upgrade_full"]
**Username** | **String** | Username as configured on the file server. | [optional] 

## Examples

- Prepare the resource
```powershell
$FirmwareNetworkShareAllOf = Initialize-IntersightFirmwareNetworkShareAllOf  -ClassId null `
 -ObjectType null `
 -CifsServer null `
 -HttpServer null `
 -IsPasswordSet null `
 -MapType null `
 -NfsServer null `
 -Password null `
 -Upgradeoption null `
 -Username null
```

- Convert the resource to JSON
```powershell
$FirmwareNetworkShareAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

