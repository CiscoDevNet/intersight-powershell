# ApplianceBackupBaseAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Filename** | **String** | Backup filename to backup or restore. | [optional] 
**Protocol** | **String** | Communication protocol used by the file server (e.g. scp or sftp). | [optional] [default to "scp"]
**RemoteHost** | **String** | Hostname of the remote file server. | [optional] 
**RemotePath** | **String** | File server directory to copy the file. | [optional] 
**RemotePort** | **Int64** | Remote TCP port on the file server (e.g. 22 for scp). | [optional] 
**Username** | **String** | Username to authenticate the fileserver. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightApplianceBackupBaseAllOf  -Filename null `
 -Protocol null `
 -RemoteHost null `
 -RemotePath null `
 -RemotePort null `
 -Username null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

