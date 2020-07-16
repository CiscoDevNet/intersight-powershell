# RecoveryConfigResultAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Var0OnDemandBackup** | [**RecoveryOnDemandBackupRelationship**](RecoveryOnDemandBackupRelationship.md) |  | [optional] 
**BackupProfile** | [**RecoveryBackupProfileRelationship**](RecoveryBackupProfileRelationship.md) |  | [optional] 
**ResultEntries** | [**RecoveryConfigResultEntryRelationship[]**](RecoveryConfigResultEntryRelationship.md) | An array of relationships to recoveryConfigResultEntry resources. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightRecoveryConfigResultAllOf  -Var0OnDemandBackup null `
 -BackupProfile null `
 -ResultEntries null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

