# FirmwareEulaAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "firmware.Eula"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "firmware.Eula"]
**Accepted** | **Boolean** | EULA acceptance status for the account. | [optional] [readonly] 
**Content** | **String** | EULA acceptance form content provided by cisco.com. | [optional] [readonly] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$FirmwareEulaAllOf = Initialize-IntersightFirmwareEulaAllOf  -ClassId null `
 -ObjectType null `
 -Accepted null `
 -Content null `
 -Account null
```

- Convert the resource to JSON
```powershell
$FirmwareEulaAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

