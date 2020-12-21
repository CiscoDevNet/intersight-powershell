# IamEndPointUserPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iam.EndPointUserPolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iam.EndPointUserPolicy"]
**PasswordProperties** | [**IamEndPointPasswordProperties**](IamEndPointPasswordProperties.md) |  | [optional] 
**EndPointUserRoles** | [**IamEndPointUserRoleRelationship[]**](IamEndPointUserRoleRelationship.md) | An array of relationships to iamEndPointUserRole resources. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**Profiles** | [**PolicyAbstractConfigProfileRelationship[]**](PolicyAbstractConfigProfileRelationship.md) | An array of relationships to policyAbstractConfigProfile resources. | [optional] 

## Examples

- Prepare the resource
```powershell
$IamEndPointUserPolicyAllOf = Initialize-IntersightIamEndPointUserPolicyAllOf  -ClassId null `
 -ObjectType null `
 -PasswordProperties null `
 -EndPointUserRoles null `
 -Organization null `
 -Profiles null
```

- Convert the resource to JSON
```powershell
$IamEndPointUserPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

