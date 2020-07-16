# RecoveryRestoreAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConfigParams** | [**RecoveryConfigParams**](RecoveryConfigParams.md) |  | [optional] 
**BackupInfo** | [**RecoveryAbstractBackupInfoRelationship**](RecoveryAbstractBackupInfoRelationship.md) |  | [optional] 
**Device** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**Workflow** | [**WorkflowWorkflowInfoRelationship**](WorkflowWorkflowInfoRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightRecoveryRestoreAllOf  -ConfigParams null `
 -BackupInfo null `
 -Device null `
 -Organization null `
 -Workflow null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

