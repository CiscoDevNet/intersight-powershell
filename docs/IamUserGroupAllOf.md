# IamUserGroupAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **String** | The name of the user group which the dynamic user belongs to. | [optional] 
**Idp** | [**IamIdpRelationship**](IamIdpRelationship.md) |  | [optional] 
**Idpreference** | [**IamIdpReferenceRelationship**](IamIdpReferenceRelationship.md) |  | [optional] 
**Permissions** | [**IamPermissionRelationship[]**](IamPermissionRelationship.md) | An array of relationships to iamPermission resources. | [optional] 
**Qualifier** | [**IamQualifierRelationship**](IamQualifierRelationship.md) |  | [optional] 
**Users** | [**IamUserRelationship[]**](IamUserRelationship.md) | An array of relationships to iamUser resources. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIamUserGroupAllOf  -Name null `
 -Idp null `
 -Idpreference null `
 -Permissions null `
 -Qualifier null `
 -Users null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

