# StorageBaseHostAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**Description** | **String** | Short description about the host. | [optional] [readonly] 
**Initiators** | [**StorageBaseInitiator[]**](StorageBaseInitiator.md) |  | [optional] 
**Name** | **String** | Name of the host in storage array. | [optional] [readonly] 
**OsType** | **String** | Operating system running on the host. | [optional] [readonly] 
**StorageUtilization** | [**StorageBaseCapacity**](StorageBaseCapacity.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$StorageBaseHostAllOf = Initialize-IntersightStorageBaseHostAllOf  -ClassId null `
 -ObjectType null `
 -Description null `
 -Initiators null `
 -Name null `
 -OsType null `
 -StorageUtilization null
```

- Convert the resource to JSON
```powershell
$StorageBaseHostAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

