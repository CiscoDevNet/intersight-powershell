# StoragePureArrayUtilizationAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.PureArrayUtilization"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.PureArrayUtilization"]
**DataReduction** | **Double** | Ratio of mapped sectors within a volume versus the amount of physical space the data occupies after data compression and deduplication. The data reduction ratio does not include thin provisioning savings. For example, a data reduction ratio of 5.0 means that for every 5 MB the host writes to the array, 1 MB is stored on the array&#39;s flash modules. | [optional] [readonly] 
**Parity** | **Double** | Percentage of data that is fully protected. The percentage value will drop below 100% if the data is not fully protected. | [optional] [readonly] 
**Provisioned** | **Int64** | Total provisioned storage capacity in Pure FlashArray, represented in bytes. | [optional] [readonly] 
**Shared** | **Int64** | Physical space occupied by deduplicated data, represented in bytes. The space is shared with other volumes and snapshots as a result of data deduplication. | [optional] [readonly] 
**Snapshot** | **Int64** | Physical space occupied by the snapshots, represented in bytes. | [optional] [readonly] 
**System** | **Int64** | Physical space occupied by internal array metadata, represented in bytes. | [optional] [readonly] 
**ThinProvisioned** | **Double** | Percentage of volume sectors that do not contain host-written data because the hosts have not written data to them or the sectors have been explicitly trimmed. | [optional] [readonly] 
**TotalReduction** | **Double** | Ratio of provisioned sectors within a volume versus the amount of physical space the data occupies after reduction via data compression and deduplication and with thin provisioning savings. Total reduction is data reduction with thin provisioning savings. For example, a total reduction ratio of 10.0 means that for every 10 MB of provisioned space, 1 MB is stored on the array&#39;s flash modules. | [optional] [readonly] 
**Volume** | **Int64** | Physical space occupied by volume data, excluding shared, array metadata and snapshots. Size is represented in bytes. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$StoragePureArrayUtilizationAllOf = Initialize-IntersightStoragePureArrayUtilizationAllOf  -ClassId null `
 -ObjectType null `
 -DataReduction null `
 -Parity null `
 -Provisioned null `
 -Shared null `
 -Snapshot null `
 -System null `
 -ThinProvisioned null `
 -TotalReduction null `
 -Volume null
```

- Convert the resource to JSON
```powershell
$StoragePureArrayUtilizationAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

