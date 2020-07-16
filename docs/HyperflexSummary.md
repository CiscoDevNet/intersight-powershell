# HyperflexSummary
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**ActiveNodes** | **String** |  | [optional] [readonly] 
**Address** | **String** |  | [optional] [readonly] 
**Boottime** | **Int64** |  | [optional] [readonly] 
**ClusterAccessPolicy** | **String** |  | [optional] [readonly] 
**CompressionSavings** | **Double** |  | [optional] [readonly] 
**DataReplicationCompliance** | **String** |  | [optional] [readonly] 
**DataReplicationFactor** | **String** |  | [optional] [readonly] 
**DeduplicationSavings** | **Double** |  | [optional] [readonly] 
**Downtime** | **String** |  | [optional] [readonly] 
**FreeCapacity** | **Int64** |  | [optional] [readonly] 
**HealingInfo** | [**HyperflexStPlatformClusterHealingInfo**](HyperflexStPlatformClusterHealingInfo.md) |  | [optional] 
**Name** | **String** |  | [optional] [readonly] 
**ResiliencyDetails** | [**SystemCollectionsHashtable**](.md) |  | [optional] [readonly] 
**ResiliencyDetailsSize** | **Int64** |  | [optional] [readonly] 
**ResiliencyInfo** | [**HyperflexStPlatformClusterResiliencyInfo**](HyperflexStPlatformClusterResiliencyInfo.md) |  | [optional] 
**SpaceStatus** | **String** |  | [optional] [readonly] 
**State** | **String** |  | [optional] [readonly] 
**TotalCapacity** | **Int64** |  | [optional] [readonly] 
**TotalSavings** | **Double** |  | [optional] [readonly] 
**Uptime** | **String** |  | [optional] [readonly] 
**UsedCapacity** | **Int64** |  | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHyperflexSummary  -ClassId null `
 -ObjectType null `
 -ActiveNodes null `
 -Address null `
 -Boottime null `
 -ClusterAccessPolicy null `
 -CompressionSavings null `
 -DataReplicationCompliance null `
 -DataReplicationFactor null `
 -DeduplicationSavings null `
 -Downtime null `
 -FreeCapacity null `
 -HealingInfo null `
 -Name null `
 -ResiliencyDetails null `
 -ResiliencyDetailsSize null `
 -ResiliencyInfo null `
 -SpaceStatus null `
 -State null `
 -TotalCapacity null `
 -TotalSavings null `
 -Uptime null `
 -UsedCapacity null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

