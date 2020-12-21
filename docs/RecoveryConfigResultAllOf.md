# RecoveryConfigResultAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "recovery.ConfigResult"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "recovery.ConfigResult"]
**Var0OnDemandBackup** | [**RecoveryOnDemandBackupRelationship**](RecoveryOnDemandBackupRelationship.md) |  | [optional] 
**BackupProfile** | [**RecoveryBackupProfileRelationship**](RecoveryBackupProfileRelationship.md) |  | [optional] 
**ResultEntries** | [**RecoveryConfigResultEntryRelationship[]**](RecoveryConfigResultEntryRelationship.md) | An array of relationships to recoveryConfigResultEntry resources. | [optional] 

## Examples

- Prepare the resource
```powershell
$RecoveryConfigResultAllOf = Initialize-IntersightRecoveryConfigResultAllOf  -ClassId null `
 -ObjectType null `
 -Var0OnDemandBackup null `
 -BackupProfile null `
 -ResultEntries null
```

- Convert the resource to JSON
```powershell
$RecoveryConfigResultAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

