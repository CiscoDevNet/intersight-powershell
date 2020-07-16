# FirmwareCifsServerAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FileLocation** | **String** | The location to the image file. The accepted format is IP-or-hostname/folder1/folder2/.../imageFile. | [optional] 
**MountOptions** | **String** | Mount option (Authentication Protocol) as configured on the CIFS Server. Example:ntlmv2. | [optional] [default to "none"]
**RemoteFile** | **String** | Filename of the image in the remote share location. Example:ucs-c220m5-huu-3.1.2c.iso. | [optional] [readonly] 
**RemoteIp** | **String** | CIFS Server Hostname or IP Address. For example:CIFS-server-hostname or 10.10.8.7. The remote share server should have network connectivity with the CIMC of the selected devices for a successful upgrade. | [optional] [readonly] 
**RemoteShare** | **String** | Directory where the image is stored. Example:share/subfolder. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFirmwareCifsServerAllOf  -FileLocation null `
 -MountOptions null `
 -RemoteFile null `
 -RemoteIp null `
 -RemoteShare null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

