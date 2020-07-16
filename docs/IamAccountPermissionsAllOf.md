# IamAccountPermissionsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountIdentifier** | **String** | MOID of the account which a user can select after authentication. | [optional] [readonly] 
**AccountName** | **String** | Name of the account which a user can select after authentication. | [optional] [readonly] 
**AccountStatus** | **String** | Status of the account. Account remains inactive until a device is claimed to the account. | [optional] [readonly] 
**Permissions** | [**IamPermissionReference[]**](IamPermissionReference.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIamAccountPermissionsAllOf  -AccountIdentifier null `
 -AccountName null `
 -AccountStatus null `
 -Permissions null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

