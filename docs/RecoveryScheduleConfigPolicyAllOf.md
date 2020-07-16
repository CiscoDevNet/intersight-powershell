# RecoveryScheduleConfigPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schedule** | [**RecoveryBackupSchedule**](RecoveryBackupSchedule.md) |  | [optional] 
**BackupProfiles** | [**RecoveryBackupProfileRelationship[]**](RecoveryBackupProfileRelationship.md) | An array of relationships to recoveryBackupProfile resources. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightRecoveryScheduleConfigPolicyAllOf  -Schedule null `
 -BackupProfiles null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

