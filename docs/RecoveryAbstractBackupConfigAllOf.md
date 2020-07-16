# RecoveryAbstractBackupConfigAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FileNamePrefix** | **String** | The file name for the backup image. This name is added as a prefix in the name for the backup image. A unique file name for the backup image is created along with a timestamp. For example: prefix-1572431305418. | [optional] 
**IsPasswordSet** | **Boolean** | Indicates whether the value of the &#39;password&#39; property has been set. | [optional] [readonly] 
**LocationType** | **String** | Specifies whether the backup will be stored locally or remotely. | [optional] [default to "Network Share"]
**Password** | **String** | Password of Backup server. | [optional] 
**Path** | **String** | The file system path where the backup images must be stored. Include the IP address/hostname of the network share location and the complete file system path. For example: 172.29.109.234/var/backups/. | [optional] 
**Protocol** | **String** | Protocol for transferring the backup image to the network share location. | [optional] [default to "SCP"]
**RetentionCount** | **Int64** | Number of backup copies maintained on the local or remote server. When the created backup files exceed this number, the initial backup files are overwritten in a sequential manner. | [optional] 
**UserName** | **String** | Backup server user name. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightRecoveryAbstractBackupConfigAllOf  -FileNamePrefix null `
 -IsPasswordSet null `
 -LocationType null `
 -Password null `
 -Path null `
 -Protocol null `
 -RetentionCount null `
 -UserName null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

