# HclSupportedDriverNameAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hcl.SupportedDriverName"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hcl.SupportedDriverName"]
**OsVendor** | **String** | Vendor distributing the Operating System. | [optional] 
**OsVersion** | **String** | Version of the Operating System. | [optional] 
**ProductList** | [**HclProduct[]**](HclProduct.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HclSupportedDriverNameAllOf = Initialize-IntersightHclSupportedDriverNameAllOf  -ClassId null `
 -ObjectType null `
 -OsVendor null `
 -OsVersion null `
 -ProductList null
```

- Convert the resource to JSON
```powershell
$HclSupportedDriverNameAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

