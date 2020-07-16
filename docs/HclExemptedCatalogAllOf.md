# HclExemptedCatalogAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Comments** | **String** | Reason for the exemption. | [optional] 
**Name** | **String** | A unique descriptive name of the exemption. | [optional] 
**OsVendor** | **String** | Vendor of the Operating System. | [optional] 
**OsVersion** | **String** | Version of the Operating system. | [optional] 
**ProcessorName** | **String** | Name of the processor supported for the server. | [optional] 
**ProductModels** | **String[]** |  | [optional] 
**ProductType** | **String** | Type of the product/adapter say PT for Pass Through controllers. | [optional] 
**ServerPid** | **String** | Three part ID representing the server model as returned by UCSM/CIMC XML APIs. | [optional] 
**UcsVersion** | **String** | Version of the UCS software. | [optional] 
**VersionType** | **String** | Type of the UCS version indicating whether it is a UCSM release vesion or a IMC release. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHclExemptedCatalogAllOf  -Comments null `
 -Name null `
 -OsVendor null `
 -OsVersion null `
 -ProcessorName null `
 -ProductModels null `
 -ProductType null `
 -ServerPid null `
 -UcsVersion null `
 -VersionType null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

