# HyperflexSummaryAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
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
Initialize-IntersightHyperflexSummaryAllOf  -ActiveNodes null `
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

