# RecommendationCapacityRunwayAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "recommendation.CapacityRunway"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "recommendation.CapacityRunway"]
**AdditionalCapacity** | **Int64** | Additional capacity is the capacity which is needed more after exhausing all hardware on current cluster. | [optional] [readonly] 
**Period** | **Int64** | Number of months in future for which recommendation is provided for. | [optional] [readonly] 
**Runway** | **Int64** | This represents the new runway, that is the number of days remaining before the cluster&#39;s storage utilization reaches the recommended capacity limit after the recommended hardware is added. | [optional] [readonly] 
**TotalCapacity** | **Int64** | Total capacity of the cluster after the recommended hardware is added. | [optional] [readonly] 
**Unit** | **String** | Unit for the new capacity. * &#x60;TB&#x60; - The Enum value TB represents that the measurement unit is in terabytes. * &#x60;MB&#x60; - The Enum value MB represents that the measurement unit is in megabytes. | [optional] [readonly] [default to "TB"]
**ForecastInstance** | [**ForecastInstanceRelationship**](ForecastInstanceRelationship.md) |  | [optional] 
**PhysicalItem** | [**RecommendationPhysicalItemRelationship[]**](RecommendationPhysicalItemRelationship.md) | An array of relationships to recommendationPhysicalItem resources. | [optional] [readonly] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$RecommendationCapacityRunwayAllOf = Initialize-IntersightRecommendationCapacityRunwayAllOf  -ClassId null `
 -ObjectType null `
 -AdditionalCapacity null `
 -Period null `
 -Runway null `
 -TotalCapacity null `
 -Unit null `
 -ForecastInstance null `
 -PhysicalItem null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$RecommendationCapacityRunwayAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

