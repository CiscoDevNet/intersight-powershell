# StorageBaseDiskPoolAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**Name** | **String** | Human readable name of the pool, limited to 64 characters. | [optional] [readonly] 
**PoolId** | **String** | Object ID for the pool. Platforms that use a number should convert it to string. | [optional] [readonly] 
**Status** | **String** | Human readable status of the pool, indicating the current health. * &#x60;Unknown&#x60; - Entity status is unknown. * &#x60;Degraded&#x60; - State is degraded, and might impact normal operation of the entity. * &#x60;Critical&#x60; - Entity is in a critical state, impacting operations. * &#x60;Ok&#x60; - Entity status is in a stable state, operating normally. | [optional] [readonly] [default to "Unknown"]
**StorageUtilization** | [**StorageBaseCapacity**](StorageBaseCapacity.md) |  | [optional] 
**Type** | **String** | Human readable type of the pool, such as thin, tiered, active-flash, etc. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$StorageBaseDiskPoolAllOf = Initialize-IntersightStorageBaseDiskPoolAllOf  -ClassId null `
 -ObjectType null `
 -Name null `
 -PoolId null `
 -Status null `
 -StorageUtilization null `
 -Type null
```

- Convert the resource to JSON
```powershell
$StorageBaseDiskPoolAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

