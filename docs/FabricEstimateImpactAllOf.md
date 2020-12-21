# FabricEstimateImpactAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "fabric.EstimateImpact"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "fabric.EstimateImpact"]
**VarProfile** | [**FabricSwitchProfileRelationship**](FabricSwitchProfileRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$FabricEstimateImpactAllOf = Initialize-IntersightFabricEstimateImpactAllOf  -ClassId null `
 -ObjectType null `
 -VarProfile null
```

- Convert the resource to JSON
```powershell
$FabricEstimateImpactAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

