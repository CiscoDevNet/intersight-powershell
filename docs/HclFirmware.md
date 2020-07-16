# HclFirmware
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**DriverName** | **String** | Protocol for which the driver is provided. E.g.  enic, fnic, lsi_mr3. | [optional] 
**DriverVersion** | **String** | Version of the Driver supported. | [optional] 
**ErrorCode** | **String** | Error code for the support status. | [optional] [readonly] [default to "Success"]
**FirmwareVersion** | **String** | Firmware version of the product/adapter supported. | [optional] 
**Id** | **String** | Identifier of the firmware. | [optional] 
**LatestDriver** | **Boolean** | True if the driver is latest recommended driver. | [optional] [readonly] 
**LatestFirmware** | **Boolean** | True if the firmware is latest recommended firmware. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHclFirmware  -ClassId null `
 -ObjectType null `
 -DriverName null `
 -DriverVersion null `
 -ErrorCode null `
 -FirmwareVersion null `
 -Id null `
 -LatestDriver null `
 -LatestFirmware null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

