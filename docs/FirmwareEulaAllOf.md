# FirmwareEulaAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Accepted** | **Boolean** | EULA acceptance status for the account. | [optional] [readonly] 
**Content** | **String** | EULA acceptance form content provided by cisco.com. | [optional] [readonly] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFirmwareEulaAllOf  -Accepted null `
 -Content null `
 -Account null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

