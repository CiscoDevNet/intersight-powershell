# FirmwareHttpServer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "firmware.HttpServer"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "firmware.HttpServer"]
**LocationLink** | **String** | HTTP/HTTPS link to the image. Accepted formats HTTP[s]://server-hostname/share/image or HTTP[s]://serverip/share/image. For a successful upgrade, the remote share server must have network connectivity with the CIMC of the selected devices. | [optional] 
**MountOptions** | **String** | Mount option as configured on the HTTP server. Empty if nothing is configured. | [optional] 

## Examples

- Prepare the resource
```powershell
$FirmwareHttpServer = Initialize-IntersightFirmwareHttpServer  -ClassId null `
 -ObjectType null `
 -LocationLink null `
 -MountOptions null
```

- Convert the resource to JSON
```powershell
$FirmwareHttpServer | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

