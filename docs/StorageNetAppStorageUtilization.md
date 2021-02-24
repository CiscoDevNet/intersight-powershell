# StorageNetAppStorageUtilization
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.NetAppStorageUtilization"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.NetAppStorageUtilization"]
**Available** | **Int64** | Total consumable storage capacity represented in bytes. System may reserve some space for internal purposes which is excluded from total capacity. | [optional] [readonly] 
**CapacityUtilization** | **Double** | Percentage of used capacity. | [optional] [readonly] 
**Free** | **Int64** | Unused space available for applications to consume, represented in bytes. | [optional] [readonly] 
**Total** | **Int64** | Total storage capacity, represented in bytes. It is set by the component manufacturer. | [optional] [readonly] 
**Used** | **Int64** | Used or consumed storage capacity, represented in bytes. | [optional] [readonly] 
**LogicalUsed** | **Int64** | Total logical used capacity, represented in bytes. | [optional] [readonly] 
**Savings** | **Int64** | Total savings capacity, represented in bytes. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$StorageNetAppStorageUtilization = Initialize-IntersightStorageNetAppStorageUtilization  -ClassId null `
 -ObjectType null `
 -Available null `
 -CapacityUtilization null `
 -Free null `
 -Total null `
 -Used null `
 -LogicalUsed null `
 -Savings null
```

- Convert the resource to JSON
```powershell
$StorageNetAppStorageUtilization | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

