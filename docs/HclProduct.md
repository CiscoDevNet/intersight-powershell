# HclProduct
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
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
Initialize-IntersightHclProduct  -ClassId null `
 -ObjectType null `
 -DriverNames null `
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

