# StoragePureHostUtilization
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**Available** | **Int64** | Total consumable storage capacity represented in bytes. System may reserve some space for internal purposes which is excluded from total capacity. | [optional] [readonly] 
**CapacityUtilization** | **Double** | Percentage of used capacity. | [optional] [readonly] 
**Free** | **Int64** | Unused space available for applications to consume, represented in bytes. | [optional] [readonly] 
**Total** | **Int64** | Total storage capacity, represented in bytes. It is set by the component manufacturer. | [optional] [readonly] 
**Used** | **Int64** | Used or consumed storage capacity, represented in bytes. | [optional] [readonly] 
**DataReduction** | **Double** | Ratio of mapped sectors within a volume versus the amount of physical space the data occupies after data compression and deduplication. The data reduction ratio does not include thin provisioning savings. For example, a data reduction ratio of 5.0 means that for every 5 MB the host writes to the array, 1 MB is stored on the array&#39;s flash modules. | [optional] [readonly] 
**Snapshot** | **Int64** | Physical space occupied by the snapshots, represented in bytes. | [optional] [readonly] 
**ThinProvisioned** | **Double** | Percentage of volume sectors that do not contain host-written data because the hosts have not written data to them or the sectors have been explicitly trimmed. | [optional] [readonly] 
**TotalReduction** | **Double** | Ratio of provisioned sectors within a volume versus the amount of physical space the data occupies after reduction via data compression and deduplication and with thin provisioning savings. Total reduction is data reduction with thin provisioning savings. For example, a total reduction ratio of 10.0 means that for every 10 MB of provisioned space, 1 MB is stored on the array&#39;s flash modules. | [optional] [readonly] 
**Volume** | **Int64** | Physical space occupied by volume data, excluding shared, array metadata and snapshots. Size id represented in bytes. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$StoragePureHostUtilization = Initialize-IntersightStoragePureHostUtilization  -ClassId null `
 -ObjectType null `
 -Available null `
 -CapacityUtilization null `
 -Free null `
 -Total null `
 -Used null `
 -DataReduction null `
 -Snapshot null `
 -ThinProvisioned null `
 -TotalReduction null `
 -Volume null
```

- Convert the resource to JSON
```powershell
$StoragePureHostUtilization | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

