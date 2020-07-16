# HclOperatingSystemAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Version** | **String** | Version of the Operating System. | [optional] 
**Vendor** | [**HclOperatingSystemVendorRelationship**](HclOperatingSystemVendorRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHclOperatingSystemAllOf  -Version null `
 -Vendor null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

