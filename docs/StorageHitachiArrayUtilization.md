# StorageHitachiArrayUtilization
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.HitachiArrayUtilization"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.HitachiArrayUtilization"]
**Available** | **Int64** | Total consumable storage capacity represented in bytes. System may reserve some space for internal purposes which is excluded from total capacity. | [optional] [readonly] 
**CapacityUtilization** | **Double** | Percentage of used capacity. | [optional] [readonly] 
**Free** | **Int64** | Unused space available for applications to consume, represented in bytes. | [optional] [readonly] 
**Total** | **Int64** | Total storage capacity, represented in bytes. It is set by the component manufacturer. | [optional] [readonly] 
**Used** | **Int64** | Used or consumed storage capacity, represented in bytes. | [optional] [readonly] 
**DataReduction** | **Double** | Ratio of mapped sectors within a volume versus the amount of physical space the data occupies after data compression and deduplication. The data reduction ratio does not include thin provisioning savings. For example, a data reduction ratio of 5.0 means that for every 5 MB the host writes to the array, 1 MB is stored on the array&#39;s flash modules. | [optional] [readonly] 
**Provisioned** | **Int64** | Total provisioned storage capacity in Hitachi Virtual Storage, represented in bytes. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$StorageHitachiArrayUtilization = Initialize-IntersightStorageHitachiArrayUtilization  -ClassId null `
 -ObjectType null `
 -Available null `
 -CapacityUtilization null `
 -Free null `
 -Total null `
 -Used null `
 -DataReduction null `
 -Provisioned null
```

- Convert the resource to JSON
```powershell
$StorageHitachiArrayUtilization | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

