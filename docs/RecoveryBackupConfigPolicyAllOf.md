# RecoveryBackupConfigPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "recovery.BackupConfigPolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "recovery.BackupConfigPolicy"]
**BackupProfiles** | [**RecoveryBackupProfileRelationship[]**](RecoveryBackupProfileRelationship.md) | An array of relationships to recoveryBackupProfile resources. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$RecoveryBackupConfigPolicyAllOf = Initialize-IntersightRecoveryBackupConfigPolicyAllOf  -ClassId null `
 -ObjectType null `
 -BackupProfiles null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$RecoveryBackupConfigPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

