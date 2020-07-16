# FirmwareHttpServerAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LocationLink** | **String** | HTTP/HTTPS link to the image. Accepted formats HTTP[s]://server-hostname/share/image or HTTP[s]://serverip/share/image. For a successful upgrade, the remote share server must have network connectivity with the CIMC of the selected devices. | [optional] 
**MountOptions** | **String** | Mount option as configured on the HTTP server. Empty if nothing is configured. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFirmwareHttpServerAllOf  -LocationLink null `
 -MountOptions null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

