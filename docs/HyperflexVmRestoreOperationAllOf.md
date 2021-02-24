# HyperflexVmRestoreOperationAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.VmRestoreOperation"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.VmRestoreOperation"]
**NewName** | **String** | New name for the Virtual Machine after recovery. | [optional] 
**PowerOn** | **Boolean** | Power on the Virtual Machine after recovery. | [optional] [default to $true]
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**RestoreEdgeClusterMoid** | [**HyperflexClusterRelationship**](HyperflexClusterRelationship.md) |  | [optional] 
**VmBackupInfoMoid** | [**HyperflexVmBackupInfoRelationship**](HyperflexVmBackupInfoRelationship.md) |  | [optional] 
**VmSnapshotInfoMoid** | [**HyperflexVmSnapshotInfoRelationship**](HyperflexVmSnapshotInfoRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexVmRestoreOperationAllOf = Initialize-IntersightHyperflexVmRestoreOperationAllOf  -ClassId null `
 -ObjectType null `
 -NewName null `
 -PowerOn null `
 -Organization null `
 -RestoreEdgeClusterMoid null `
 -VmBackupInfoMoid null `
 -VmSnapshotInfoMoid null
```

- Convert the resource to JSON
```powershell
$HyperflexVmRestoreOperationAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

