# RecoveryRestoreAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "recovery.Restore"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "recovery.Restore"]
**ConfigParams** | [**RecoveryConfigParams**](RecoveryConfigParams.md) |  | [optional] 
**BackupInfo** | [**RecoveryAbstractBackupInfoRelationship**](RecoveryAbstractBackupInfoRelationship.md) |  | [optional] 
**Device** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**Workflow** | [**WorkflowWorkflowInfoRelationship**](WorkflowWorkflowInfoRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$RecoveryRestoreAllOf = Initialize-IntersightRecoveryRestoreAllOf  -ClassId null `
 -ObjectType null `
 -ConfigParams null `
 -BackupInfo null `
 -Device null `
 -Organization null `
 -Workflow null
```

- Convert the resource to JSON
```powershell
$RecoveryRestoreAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

