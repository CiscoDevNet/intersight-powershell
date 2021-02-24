# RecommendationBaseAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | [default to "recommendation.CapacityRunway"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | [default to "recommendation.CapacityRunway"]
**LastUpdatedTime** | **System.DateTime** | The time when the recommendation was last updated. | [optional] [readonly] 
**Name** | **String** | The name of the recommendation. | [optional] [readonly] 
**RequirementMet** | **Boolean** | Indicates if the recommendation requirement is met by the existing setup by adding hardware components to it or it needs expansion. For example if the recommendation is to add 16 disks to a HyperFlex cluster but the cluster is already alost full and only 8 disks can be added, then this property is set to false. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$RecommendationBaseAllOf = Initialize-IntersightRecommendationBaseAllOf  -ClassId null `
 -ObjectType null `
 -LastUpdatedTime null `
 -Name null `
 -RequirementMet null
```

- Convert the resource to JSON
```powershell
$RecommendationBaseAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

