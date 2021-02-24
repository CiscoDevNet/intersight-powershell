# StorageNetAppStorageUtilizationAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.NetAppStorageUtilization"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.NetAppStorageUtilization"]
**LogicalUsed** | **Int64** | Total logical used capacity, represented in bytes. | [optional] [readonly] 
**Savings** | **Int64** | Total savings capacity, represented in bytes. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$StorageNetAppStorageUtilizationAllOf = Initialize-IntersightStorageNetAppStorageUtilizationAllOf  -ClassId null `
 -ObjectType null `
 -LogicalUsed null `
 -Savings null
```

- Convert the resource to JSON
```powershell
$StorageNetAppStorageUtilizationAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

