# StorageHitachiArrayUtilizationAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.HitachiArrayUtilization"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.HitachiArrayUtilization"]
**DataReduction** | **Double** | Ratio of mapped sectors within a volume versus the amount of physical space the data occupies after data compression and deduplication. The data reduction ratio does not include thin provisioning savings. For example, a data reduction ratio of 5.0 means that for every 5 MB the host writes to the array, 1 MB is stored on the array&#39;s flash modules. | [optional] [readonly] 
**Provisioned** | **Int64** | Total provisioned storage capacity in Hitachi Virtual Storage, represented in bytes. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$StorageHitachiArrayUtilizationAllOf = Initialize-IntersightStorageHitachiArrayUtilizationAllOf  -ClassId null `
 -ObjectType null `
 -DataReduction null `
 -Provisioned null
```

- Convert the resource to JSON
```powershell
$StorageHitachiArrayUtilizationAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

