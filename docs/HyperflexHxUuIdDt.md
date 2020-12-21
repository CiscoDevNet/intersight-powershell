# HyperflexHxUuIdDt
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.HxUuIdDt"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.HxUuIdDt"]
**Links** | [**HyperflexHxLinkDt[]**](HyperflexHxLinkDt.md) |  | [optional] 
**Uuid** | **String** | The unique identifier string of an entity. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$HyperflexHxUuIdDt = Initialize-IntersightHyperflexHxUuIdDt  -ClassId null `
 -ObjectType null `
 -Links null `
 -Uuid null
```

- Convert the resource to JSON
```powershell
$HyperflexHxUuIdDt | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

