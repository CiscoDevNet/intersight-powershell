# RecoveryScheduleConfigPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "recovery.ScheduleConfigPolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "recovery.ScheduleConfigPolicy"]
**Schedule** | [**RecoveryBackupSchedule**](RecoveryBackupSchedule.md) |  | [optional] 
**BackupProfiles** | [**RecoveryBackupProfileRelationship[]**](RecoveryBackupProfileRelationship.md) | An array of relationships to recoveryBackupProfile resources. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$RecoveryScheduleConfigPolicyAllOf = Initialize-IntersightRecoveryScheduleConfigPolicyAllOf  -ClassId null `
 -ObjectType null `
 -Schedule null `
 -BackupProfiles null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$RecoveryScheduleConfigPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

