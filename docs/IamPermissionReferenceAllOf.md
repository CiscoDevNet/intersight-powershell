# IamPermissionReferenceAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PermissionIdentifier** | **String** | MOID of the permission which user has access to. | [optional] [readonly] 
**PermissionName** | **String** | Name of the permission which user has access to. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIamPermissionReferenceAllOf  -PermissionIdentifier null `
 -PermissionName null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

