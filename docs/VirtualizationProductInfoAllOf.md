# VirtualizationProductInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProductName** | **String** | Commercial product name. For example, VMware ESXi. | [optional] 
**ProductType** | **String** | Product name provided by the vendor. For example, embeddedEsx. | [optional] 
**ProductVendor** | **String** | Commercial vendor name. For example, VMware Inc. | [optional] 
**Version** | **String** | Hypervisor version running on the system. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVirtualizationProductInfoAllOf  -ProductName null `
 -ProductType null `
 -ProductVendor null `
 -Version null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

