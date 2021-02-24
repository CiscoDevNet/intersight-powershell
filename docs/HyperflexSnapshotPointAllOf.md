# HyperflexSnapshotPointAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.SnapshotPoint"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.SnapshotPoint"]
**ClusterEntityReference** | [**HyperflexEntityReference**](HyperflexEntityReference.md) |  | [optional] 
**ReplicationStatus** | [**HyperflexReplicationStatus**](HyperflexReplicationStatus.md) |  | [optional] 
**SnapshotFiles** | [**HyperflexSnapshotFiles**](HyperflexSnapshotFiles.md) |  | [optional] 
**SnapshotPointEntityReference** | [**HyperflexEntityReference**](HyperflexEntityReference.md) |  | [optional] 
**SnapshotStatus** | [**HyperflexSnapshotStatus**](HyperflexSnapshotStatus.md) |  | [optional] 
**VmRuntimeInfo** | [**HyperflexVirtualMachine**](HyperflexVirtualMachine.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexSnapshotPointAllOf = Initialize-IntersightHyperflexSnapshotPointAllOf  -ClassId null `
 -ObjectType null `
 -ClusterEntityReference null `
 -ReplicationStatus null `
 -SnapshotFiles null `
 -SnapshotPointEntityReference null `
 -SnapshotStatus null `
 -VmRuntimeInfo null
```

- Convert the resource to JSON
```powershell
$HyperflexSnapshotPointAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

