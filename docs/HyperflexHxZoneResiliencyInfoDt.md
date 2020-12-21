# HyperflexHxZoneResiliencyInfoDt
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.HxZoneResiliencyInfoDt"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.HxZoneResiliencyInfoDt"]
**Name** | **String** | The name of the availability zone. | [optional] [readonly] 
**ResiliencyInfo** | [**HyperflexHxResiliencyInfoDt**](HyperflexHxResiliencyInfoDt.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexHxZoneResiliencyInfoDt = Initialize-IntersightHyperflexHxZoneResiliencyInfoDt  -ClassId null `
 -ObjectType null `
 -Name null `
 -ResiliencyInfo null
```

- Convert the resource to JSON
```powershell
$HyperflexHxZoneResiliencyInfoDt | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

