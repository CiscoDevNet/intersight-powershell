# RecoveryBackupProfileAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "recovery.BackupProfile"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "recovery.BackupProfile"]
**Enabled** | **Boolean** | Enables/Disables the schedule on the endpoint. | [optional] [default to $true]
**BackupConfig** | [**RecoveryBackupConfigPolicyRelationship**](RecoveryBackupConfigPolicyRelationship.md) |  | [optional] 
**ConfigResult** | [**RecoveryConfigResultRelationship**](RecoveryConfigResultRelationship.md) |  | [optional] 
**DeviceId** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**ScheduleConfig** | [**RecoveryScheduleConfigPolicyRelationship**](RecoveryScheduleConfigPolicyRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$RecoveryBackupProfileAllOf = Initialize-IntersightRecoveryBackupProfileAllOf  -ClassId null `
 -ObjectType null `
 -Enabled null `
 -BackupConfig null `
 -ConfigResult null `
 -DeviceId null `
 -Organization null `
 -ScheduleConfig null
```

- Convert the resource to JSON
```powershell
$RecoveryBackupProfileAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

