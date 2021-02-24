# StorageBaseStorageContainerAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**CreatedTime** | **System.DateTime** | Storage container&#39;s creation time. | [optional] [readonly] 
**Name** | **String** | Name of the storage container. | [optional] [readonly] 
**StorageUtilization** | [**StorageBaseCapacity**](StorageBaseCapacity.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$StorageBaseStorageContainerAllOf = Initialize-IntersightStorageBaseStorageContainerAllOf  -ClassId null `
 -ObjectType null `
 -CreatedTime null `
 -Name null `
 -StorageUtilization null
```

- Convert the resource to JSON
```powershell
$StorageBaseStorageContainerAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

