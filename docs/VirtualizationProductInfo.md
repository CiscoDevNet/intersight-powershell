# VirtualizationProductInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "virtualization.ProductInfo"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "virtualization.ProductInfo"]
**ProductName** | **String** | Commercial product name. For example, VMware ESXi. | [optional] 
**ProductType** | **String** | Product name provided by the vendor. For example, embeddedEsx. | [optional] 
**ProductVendor** | **String** | Commercial vendor name. For example, VMware Inc. | [optional] 
**Version** | **String** | Hypervisor version running on the system. | [optional] 

## Examples

- Prepare the resource
```powershell
$VirtualizationProductInfo = Initialize-IntersightVirtualizationProductInfo  -ClassId null `
 -ObjectType null `
 -ProductName null `
 -ProductType null `
 -ProductVendor null `
 -Version null
```

- Convert the resource to JSON
```powershell
$VirtualizationProductInfo | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

