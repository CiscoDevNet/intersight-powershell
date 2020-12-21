# IamEndPointUserRoleAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iam.EndPointUserRole"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iam.EndPointUserRole"]
**ChangePassword** | **Boolean** | Denotes whether password has changed. | [optional] [readonly] 
**Enabled** | **Boolean** | Enables the user account on the endpoint. | [optional] 
**IsPasswordSet** | **Boolean** | Indicates whether the value of the &#39;password&#39; property has been set. | [optional] [readonly] [default to $false]
**Password** | **String** | Valid login password of the user. | [optional] 
**EndPointRole** | [**IamEndPointRoleRelationship[]**](IamEndPointRoleRelationship.md) | An array of relationships to iamEndPointRole resources. | [optional] 
**EndPointUser** | [**IamEndPointUserRelationship**](IamEndPointUserRelationship.md) |  | [optional] 
**EndPointUserPolicy** | [**IamEndPointUserPolicyRelationship**](IamEndPointUserPolicyRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$IamEndPointUserRoleAllOf = Initialize-IntersightIamEndPointUserRoleAllOf  -ClassId null `
 -ObjectType null `
 -ChangePassword null `
 -Enabled null `
 -IsPasswordSet null `
 -Password null `
 -EndPointRole null `
 -EndPointUser null `
 -EndPointUserPolicy null
```

- Convert the resource to JSON
```powershell
$IamEndPointUserRoleAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

