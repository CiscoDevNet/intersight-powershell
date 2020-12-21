# HclExemptedCatalogAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hcl.ExemptedCatalog"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hcl.ExemptedCatalog"]
**Comments** | **String** | Reason for the exemption. | [optional] 
**Name** | **String** | A unique descriptive name of the exemption. | [optional] 
**OsVendor** | **String** | Vendor of the Operating System. | [optional] 
**OsVersion** | **String** | Version of the Operating system. | [optional] 
**ProcessorName** | **String** | Name of the processor supported for the server. | [optional] 
**ProductModels** | **String[]** |  | [optional] 
**ProductType** | **String** | Type of the product/adapter say GPU for graphic cards. * &#x60;&#x60; - Default type of the Product. * &#x60;Adapter&#x60; - Represents network adapter cards. * &#x60;StorageController&#x60; - Represents storage controllers. * &#x60;GPU&#x60; - Represents graphics cards. | [optional] [default to ""]
**ServerPid** | **String** | Three part ID representing the server model as returned by UCSM/CIMC XML APIs. | [optional] 
**UcsVersion** | **String** | Version of the UCS software. | [optional] 
**VersionType** | **String** | Type of the UCS version indicating whether it is a UCSM release vesion or a IMC release. | [optional] 

## Examples

- Prepare the resource
```powershell
$HclExemptedCatalogAllOf = Initialize-IntersightHclExemptedCatalogAllOf  -ClassId null `
 -ObjectType null `
 -Comments null `
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
$HclExemptedCatalogAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

