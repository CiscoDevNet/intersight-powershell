# ApplianceBackupBaseAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**Filename** | **String** | Backup filename to backup or restore. | [optional] 
**Protocol** | **String** | Communication protocol used by the file server (e.g. scp or sftp). * &#x60;scp&#x60; - Secure Copy Protocol (SCP) to access the file server. * &#x60;sftp&#x60; - SSH File Transfer Protocol (SFTP) to access file server. | [optional] [default to "scp"]
**RemoteHost** | **String** | Hostname of the remote file server. | [optional] 
**RemotePath** | **String** | File server directory to copy the file. | [optional] 
**RemotePort** | **Int64** | Remote TCP port on the file server (e.g. 22 for scp). | [optional] 
**Username** | **String** | Username to authenticate the fileserver. | [optional] 

## Examples

- Prepare the resource
```powershell
$ApplianceBackupBaseAllOf = Initialize-IntersightApplianceBackupBaseAllOf  -ClassId null `
 -ObjectType null `
 -Filename null `
 -Protocol null `
 -RemoteHost null `
 -RemotePath null `
 -RemotePort null `
 -Username null
```

- Convert the resource to JSON
```powershell
$ApplianceBackupBaseAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

