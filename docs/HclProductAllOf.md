# HclProductAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DriverNames** | **String[]** |  | [optional] 
**ErrorCode** | **String** | Error code indicating the support status. | [optional] [readonly] [default to "Success"]
**Firmwares** | [**HclFirmware[]**](HclFirmware.md) |  | [optional] 
**Id** | **String** | Identifier of the product. | [optional] 
**Model** | **String** | Model/PID of the product/adapter. | [optional] 
**Revision** | **String** | Revision of the adapter model. | [optional] 
**Type** | **String** | Type of the product/adapter say OCP, PT, GPU. | [optional] 
**Vendor** | **String** | Vendor of the product or adapter. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHclProductAllOf  -DriverNames null `
 -ErrorCode null `
 -Firmwares null `
 -Id null `
 -Model null `
 -Revision null `
 -Type null `
 -Vendor null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

