# RecommendationPhysicalItemAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "recommendation.PhysicalItem"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "recommendation.PhysicalItem"]
**Capacity** | **Int64** | Capacity of the physical entity added. | [optional] [readonly] 
**Count** | **Int64** | Count of number of items/devices to be added.For example, number of disks to add on a node PhysicalItem in case of HyperFlex Cluster recommendation. | [optional] [readonly] 
**IsNew** | **Boolean** | If the PhysicalItem is new, this is set to true, else false. | [optional] [readonly] 
**MaxCount** | **Int64** | Maximum number of items/devices which can be added on this PhysicalItem.For example, maximum number of disks allowed on a node PhysicalItem in case of HyperFlex Cluster recommendation. | [optional] [readonly] 
**Model** | **String** | Model of the recommended physical device which is externally identifiable. | [optional] [readonly] 
**SourceMoid** | **String** | Moid of the managed object which represents the existing physical entity. | [optional] [readonly] 
**Unit** | **String** | Unit of the new capacity. * &#x60;TB&#x60; - The Enum value TB represents that the measurement unit is in terabytes. * &#x60;MB&#x60; - The Enum value MB represents that the measurement unit is in megabytes. | [optional] [readonly] [default to "TB"]
**Uuid** | **String** | Uuid of the recommended physical device. | [optional] [readonly] 
**CapacityRunway** | [**RecommendationCapacityRunwayRelationship**](RecommendationCapacityRunwayRelationship.md) |  | [optional] 
**PhysicalItem** | [**RecommendationPhysicalItemRelationship[]**](RecommendationPhysicalItemRelationship.md) | An array of relationships to recommendationPhysicalItem resources. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$RecommendationPhysicalItemAllOf = Initialize-IntersightRecommendationPhysicalItemAllOf  -ClassId null `
 -ObjectType null `
 -Capacity null `
 -Count null `
 -IsNew null `
 -MaxCount null `
 -Model null `
 -SourceMoid null `
 -Unit null `
 -Uuid null `
 -CapacityRunway null `
 -PhysicalItem null
```

- Convert the resource to JSON
```powershell
$RecommendationPhysicalItemAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

