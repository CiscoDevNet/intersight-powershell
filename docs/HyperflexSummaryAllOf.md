# HyperflexSummaryAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.Summary"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.Summary"]
**ActiveNodes** | **String** | The number of nodes currently participating in the storage cluster. | [optional] [readonly] 
**Address** | **String** | The data IP address of the HyperFlex cluster. | [optional] [readonly] 
**Boottime** | **Int64** | The time taken during last cluster startup in seconds. | [optional] [readonly] 
**ClusterAccessPolicy** | **String** | The cluster access policy for the HyperFlex cluster. An access policy of &#39;STRICT&#39; means that the cluster becomes readonly once any fragment of data is reduced to one copy. &#39;LENIENT&#39; means that the cluster stays in read-write mode even if any fragment of data is reduced to one copy. | [optional] [readonly] 
**CompressionSavings** | **Double** | The percentage of storage space saved using data compression. | [optional] [readonly] 
**DataReplicationCompliance** | **String** | The compliance with the data replication factor set for the HyperFlex cluster. | [optional] [readonly] 
**DataReplicationFactor** | **String** | The number of data copies retained by the HyperFlex cluster. | [optional] [readonly] 
**DeduplicationSavings** | **Double** | The percentage of storage space saved using data deduplication. | [optional] [readonly] 
**Downtime** | **String** | The amount of time the HyperFlex cluster has been offline. | [optional] [readonly] 
**FreeCapacity** | **Int64** | The amount of storage capacity currently not in use, represented in bytes. | [optional] [readonly] 
**HealingInfo** | [**HyperflexStPlatformClusterHealingInfo**](HyperflexStPlatformClusterHealingInfo.md) |  | [optional] 
**Name** | **String** | The name of the HyperFlex cluster. | [optional] [readonly] 
**ResiliencyDetails** | [**SystemCollectionsHashtable**](.md) | The details about the resiliency health of the cluster. Includes information about the cluster healing status and the storage cluster health. | [optional] [readonly] 
**ResiliencyDetailsSize** | **Int64** | The number of elements in the resiliency details property. | [optional] [readonly] 
**ResiliencyInfo** | [**HyperflexStPlatformClusterResiliencyInfo**](HyperflexStPlatformClusterResiliencyInfo.md) |  | [optional] 
**SpaceStatus** | **String** | The space utilization status of the HyperFlex cluster. | [optional] [readonly] 
**State** | **String** | The operational state of the HyperFlex cluster. | [optional] [readonly] 
**TotalCapacity** | **Int64** | The total amount of storage capacity available for the HyperFlex cluster, represented in bytes. | [optional] [readonly] 
**TotalSavings** | **Double** | The percentage of storage space saved in total. | [optional] [readonly] 
**Uptime** | **String** | The amount of time the HyperFlex cluster has been running since last startup. | [optional] [readonly] 
**UsedCapacity** | **Int64** | The amount of storage capacity in use, represented in bytes. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$HyperflexSummaryAllOf = Initialize-IntersightHyperflexSummaryAllOf  -ClassId null `
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
$HyperflexSummaryAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

