# HclHardwareCompatibilityProfile
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**DriverIsoUrl** | **String** | Url for the ISO with the drivers supported for the server. | [optional] 
**ErrorCode** | **String** | Error code indicating the compatibility status. | [optional] [readonly] [default to "Success"]
**Id** | **String** | Identifier of the hardware compatibility profile. | [optional] 
**OsVendor** | **String** | Vendor of the Operating System running on the server. | [optional] 
**OsVersion** | **String** | Version of the Operating System running on the server. | [optional] 
**ProcessorModel** | **String** | Model of the processor present in the server. | [optional] 
**Products** | [**HclProduct[]**](HclProduct.md) |  | [optional] 
**ServerModel** | **String** | Model of the server as returned by UCSM/CIMC XML API. | [optional] 
**ServerRevision** | **String** | Revision of the server model. | [optional] 
**UcsVersion** | **String** | Version of the UCS software. | [optional] 
**VersionType** | **String** | Type of the UCS version indicating whether it is a UCSM release vesion or a IMC release. | [optional] [default to "UCSM"]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHclHardwareCompatibilityProfile  -ClassId null `
 -ObjectType null `
 -DriverIsoUrl null `
 -ErrorCode null `
 -Id null `
 -OsVendor null `
 -OsVersion null `
 -ProcessorModel null `
 -Products null `
 -ServerModel null `
 -ServerRevision null `
 -UcsVersion null `
 -VersionType null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

