# HyperflexMapClusterIdToProtectionInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.MapClusterIdToProtectionInfo"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.MapClusterIdToProtectionInfo"]
**ClusterId** | **String** | The Cluster Id we are using to map to ProtectionInfo. | [optional] [readonly] 
**ProtectionInfo** | [**HyperflexProtectionInfo**](HyperflexProtectionInfo.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexMapClusterIdToProtectionInfo = Initialize-IntersightHyperflexMapClusterIdToProtectionInfo  -ClassId null `
 -ObjectType null `
 -ClusterId null `
 -ProtectionInfo null
```

- Convert the resource to JSON
```powershell
$HyperflexMapClusterIdToProtectionInfo | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

