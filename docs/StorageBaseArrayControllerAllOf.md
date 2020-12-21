# StorageBaseArrayControllerAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**Name** | **String** | Storage array controller name. | [optional] [readonly] 
**OperationalMode** | **String** | Controller running mode, Primary or Secondary. * &#x60;Unknown&#x60; - Component operational state is unknown. * &#x60;Primary&#x60; - Component operates in primary mode and accepts workloads. * &#x60;Secondary&#x60; - Component is running as a secondary or standby mode. * &#x60;Maintenance&#x60; - Component is in maintenance mode for upgrade. During maintenance mode, component does not perform any workload. | [optional] [readonly] [default to "Unknown"]
**Status** | **String** | Status of the storage controller. * &#x60;Unknown&#x60; - Component status is not available. * &#x60;Ok&#x60; - Component is healthy and no issues found. * &#x60;Degraded&#x60; - Functioning, but not at full capability due to a non-fatal failure. * &#x60;Critical&#x60; - Not functioning or requiring immediate attention. * &#x60;Offline&#x60; - Component is installed, but powered off. * &#x60;Identifying&#x60; - Component is in initialization process. * &#x60;NotAvailable&#x60; - Component is not installed or not available. * &#x60;Updating&#x60; - Software update is in progress. * &#x60;Unrecognized&#x60; - Component is not recognized. It may be because the component is not installed properly or it is not supported. | [optional] [readonly] [default to "Unknown"]
**Version** | **String** | Software version running on a storage controller. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$StorageBaseArrayControllerAllOf = Initialize-IntersightStorageBaseArrayControllerAllOf  -ClassId null `
 -ObjectType null `
 -Name null `
 -OperationalMode null `
 -Status null `
 -Version null
```

- Convert the resource to JSON
```powershell
$StorageBaseArrayControllerAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

