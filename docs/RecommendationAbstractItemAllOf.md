# RecommendationAbstractItemAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | [default to "recommendation.PhysicalItem"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | [default to "recommendation.PhysicalItem"]
**Name** | **String** | The name of the physical device recommended. | [optional] [readonly] 
**Type** | **String** | The type of physical device recommended. * &#x60;Disk&#x60; - The Enum value Disk represents that the item type recommended is a Physical Disk. * &#x60;Node&#x60; - The Enum value Node represents that the item type recommended is a Storage Node. * &#x60;Cluster&#x60; - The Enum value Cluster represents that the item type recommended is a HyperFlex Cluster. | [optional] [readonly] [default to "Disk"]

## Examples

- Prepare the resource
```powershell
$RecommendationAbstractItemAllOf = Initialize-IntersightRecommendationAbstractItemAllOf  -ClassId null `
 -ObjectType null `
 -Name null `
 -Type null
```

- Convert the resource to JSON
```powershell
$RecommendationAbstractItemAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

