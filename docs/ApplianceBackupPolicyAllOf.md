# ApplianceBackupPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BackupTime** | **System.DateTime** | The next backup time set by the backup scheduler. Backup scheduler calculates the next backup time with the user-defined schedule set in the Schedule field. | [optional] [readonly] 
**IsPasswordSet** | **Boolean** | Indicates whether the value of the &#39;password&#39; property has been set. | [optional] [readonly] 
**ManualBackup** | **Boolean** | Backup mode of the appliance. Automatic backups of the appliance are not initiated if this property is set to &#39;true&#39; and the backup schedule field is ignored. | [optional] 
**Password** | **String** | Password to authenticate the file server. | [optional] 
**Schedule** | [**OnpremSchedule**](OnpremSchedule.md) |  | [optional] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightApplianceBackupPolicyAllOf  -BackupTime null `
 -IsPasswordSet null `
 -ManualBackup null `
 -Password null `
 -Schedule null `
 -Account null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

