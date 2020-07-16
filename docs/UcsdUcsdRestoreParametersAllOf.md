# UcsdUcsdRestoreParametersAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsPasswordSet** | **Boolean** | Indicates whether the value of the &#39;password&#39; property has been set. | [optional] [readonly] 
**Location** | **String** | The complete location of the path on the server. The location should be specified in the following format- hostname-or-ipv4address&lt;:port&gt;/absolute-file-path. | [optional] 
**Password** | **String** | The password of the target backup server. Only required if the target server is accessed using SFTP or SCP protocol. | [optional] 
**Protocol** | **String** | The protocol used to backup the UCS Director. | [optional] 
**RestoreConfigurationFiles** | **Boolean** | Decides whether UCS Director property files should also be restored. | [optional] 
**RestoreLicense** | **Boolean** | Decides whether license should also be restored. | [optional] 
**Username** | **String** | The username of the target backup server. Only required if the target server is accessed using SFTP or SCP protocol. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightUcsdUcsdRestoreParametersAllOf  -IsPasswordSet null `
 -Location null `
 -Password null `
 -Protocol null `
 -RestoreConfigurationFiles null `
 -RestoreLicense null `
 -Username null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

