# RecoveryBackupProfileAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **Boolean** | Enables/Disables the schedule on the endpoint. | [optional] 
**BackupConfig** | [**RecoveryBackupConfigPolicyRelationship**](RecoveryBackupConfigPolicyRelationship.md) |  | [optional] 
**ConfigResult** | [**RecoveryConfigResultRelationship**](RecoveryConfigResultRelationship.md) |  | [optional] 
**DeviceId** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**ScheduleConfig** | [**RecoveryScheduleConfigPolicyRelationship**](RecoveryScheduleConfigPolicyRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightRecoveryBackupProfileAllOf  -Enabled null `
 -BackupConfig null `
 -ConfigResult null `
 -DeviceId null `
 -Organization null `
 -ScheduleConfig null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

