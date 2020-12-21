# ApplianceBackupPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "appliance.BackupPolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "appliance.BackupPolicy"]
**BackupTime** | **System.DateTime** | The next backup time set by the backup scheduler. Backup scheduler calculates the next backup time with the user-defined schedule set in the Schedule field. | [optional] [readonly] 
**IsPasswordSet** | **Boolean** | Indicates whether the value of the &#39;password&#39; property has been set. | [optional] [readonly] [default to $false]
**ManualBackup** | **Boolean** | Backup mode of the appliance. Automatic backups of the appliance are not initiated if this property is set to &#39;true&#39; and the backup schedule field is ignored. | [optional] 
**Password** | **String** | Password to authenticate the file server. | [optional] 
**Schedule** | [**OnpremSchedule**](OnpremSchedule.md) |  | [optional] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ApplianceBackupPolicyAllOf = Initialize-IntersightApplianceBackupPolicyAllOf  -ClassId null `
 -ObjectType null `
 -BackupTime null `
 -IsPasswordSet null `
 -ManualBackup null `
 -Password null `
 -Schedule null `
 -Account null
```

- Convert the resource to JSON
```powershell
$ApplianceBackupPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

