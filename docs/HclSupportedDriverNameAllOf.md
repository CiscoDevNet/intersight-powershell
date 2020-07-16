# HclSupportedDriverNameAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OsVendor** | **String** | Vendor distributing the Operating System. | [optional] 
**OsVersion** | **String** | Version of the Operating System. | [optional] 
**ProductList** | [**HclProduct[]**](HclProduct.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHclSupportedDriverNameAllOf  -OsVendor null `
 -OsVersion null `
 -ProductList null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

