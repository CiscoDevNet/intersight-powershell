# IamUserGroupAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iam.UserGroup"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iam.UserGroup"]
**Name** | **String** | The name of the user group which the dynamic user belongs to. | [optional] 
**Idp** | [**IamIdpRelationship**](IamIdpRelationship.md) |  | [optional] 
**Idpreference** | [**IamIdpReferenceRelationship**](IamIdpReferenceRelationship.md) |  | [optional] 
**Permissions** | [**IamPermissionRelationship[]**](IamPermissionRelationship.md) | An array of relationships to iamPermission resources. | [optional] 
**Qualifier** | [**IamQualifierRelationship**](IamQualifierRelationship.md) |  | [optional] 
**Users** | [**IamUserRelationship[]**](IamUserRelationship.md) | An array of relationships to iamUser resources. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$IamUserGroupAllOf = Initialize-IntersightIamUserGroupAllOf  -ClassId null `
 -ObjectType null `
 -Name null `
 -Idp null `
 -Idpreference null `
 -Permissions null `
 -Qualifier null `
 -Users null
```

- Convert the resource to JSON
```powershell
$IamUserGroupAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

