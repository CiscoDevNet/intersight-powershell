# StorageBaseTenantAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | [default to "storage.NetAppStorageVm"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | [default to "storage.NetAppStorageVm"]
**Name** | **String** | Name of the tenant in storage array. | [optional] [readonly] 
**State** | **String** | The state of this tenant. * &#x60;Unknown&#x60; - Component state is not available. * &#x60;Starting&#x60; - Component is being started. * &#x60;Running&#x60; - Component is currently running. * &#x60;Stopping&#x60; - Component is being stopped. * &#x60;Stopped&#x60; - Component has been stopped. * &#x60;Deleting&#x60; - Component deletion is in progress. | [optional] [readonly] [default to "Unknown"]
**Uuid** | **String** | The uuid of this tenant in storage array. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$StorageBaseTenantAllOf = Initialize-IntersightStorageBaseTenantAllOf  -ClassId null `
 -ObjectType null `
 -Name null `
 -State null `
 -Uuid null
```

- Convert the resource to JSON
```powershell
$StorageBaseTenantAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

