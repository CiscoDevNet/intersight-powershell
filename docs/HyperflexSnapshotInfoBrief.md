# HyperflexSnapshotInfoBrief
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.SnapshotInfoBrief"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.SnapshotInfoBrief"]
**ReplicationStatus** | [**HyperflexReplicationStatus**](HyperflexReplicationStatus.md) |  | [optional] 
**Site** | **String** | Cluster site for this snapshot. * &#x60;PRIMARY&#x60; - The cluster site for this backup is primary. * &#x60;SECONDARY&#x60; - The cluster site for this backup is secondary. | [optional] [readonly] [default to "PRIMARY"]
**SnapshotStatus** | [**HyperflexSnapshotStatus**](HyperflexSnapshotStatus.md) |  | [optional] 
**VmSnapshotEntityReference** | [**HyperflexEntityReference**](HyperflexEntityReference.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexSnapshotInfoBrief = Initialize-IntersightHyperflexSnapshotInfoBrief  -ClassId null `
 -ObjectType null `
 -ReplicationStatus null `
 -Site null `
 -SnapshotStatus null `
 -VmSnapshotEntityReference null
```

- Convert the resource to JSON
```powershell
$HyperflexSnapshotInfoBrief | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

