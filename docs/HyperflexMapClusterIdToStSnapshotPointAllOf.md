# HyperflexMapClusterIdToStSnapshotPointAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.MapClusterIdToStSnapshotPoint"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.MapClusterIdToStSnapshotPoint"]
**ClusterId** | **String** | ClusterId of the snapshot point. | [optional] [readonly] 
**SnapshotPoint** | [**HyperflexSnapshotPoint**](HyperflexSnapshotPoint.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexMapClusterIdToStSnapshotPointAllOf = Initialize-IntersightHyperflexMapClusterIdToStSnapshotPointAllOf  -ClassId null `
 -ObjectType null `
 -ClusterId null `
 -SnapshotPoint null
```

- Convert the resource to JSON
```powershell
$HyperflexMapClusterIdToStSnapshotPointAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

