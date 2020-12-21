# IamAccountPermissions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iam.AccountPermissions"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iam.AccountPermissions"]
**AccountIdentifier** | **String** | MOID of the account which a user can select after authentication. | [optional] [readonly] 
**AccountName** | **String** | Name of the account which a user can select after authentication. | [optional] [readonly] 
**AccountStatus** | **String** | Status of the account. Account remains inactive until a device is claimed to the account. | [optional] [readonly] 
**Permissions** | [**IamPermissionReference[]**](IamPermissionReference.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$IamAccountPermissions = Initialize-IntersightIamAccountPermissions  -ClassId null `
 -ObjectType null `
 -AccountIdentifier null `
 -AccountName null `
 -AccountStatus null `
 -Permissions null
```

- Convert the resource to JSON
```powershell
$IamAccountPermissions | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

