# IamEndPointUserPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PasswordProperties** | [**IamEndPointPasswordProperties**](IamEndPointPasswordProperties.md) |  | [optional] 
**EndPointUserRoles** | [**IamEndPointUserRoleRelationship[]**](IamEndPointUserRoleRelationship.md) | An array of relationships to iamEndPointUserRole resources. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**Profiles** | [**PolicyAbstractConfigProfileRelationship[]**](PolicyAbstractConfigProfileRelationship.md) | An array of relationships to policyAbstractConfigProfile resources. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIamEndPointUserPolicyAllOf  -PasswordProperties null `
 -EndPointUserRoles null `
 -Organization null `
 -Profiles null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

