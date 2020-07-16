# IamEndPointUserRoleAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChangePassword** | **Boolean** | Denotes whether password has changed. | [optional] [readonly] 
**Enabled** | **Boolean** | Enables the user account on the endpoint. | [optional] 
**IsPasswordSet** | **Boolean** | Indicates whether the value of the &#39;password&#39; property has been set. | [optional] [readonly] 
**Password** | **String** | Valid login password of the user. | [optional] 
**EndPointRole** | [**IamEndPointRoleRelationship[]**](IamEndPointRoleRelationship.md) | An array of relationships to iamEndPointRole resources. | [optional] 
**EndPointUser** | [**IamEndPointUserRelationship**](IamEndPointUserRelationship.md) |  | [optional] 
**EndPointUserPolicy** | [**IamEndPointUserPolicyRelationship**](IamEndPointUserPolicyRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIamEndPointUserRoleAllOf  -ChangePassword null `
 -Enabled null `
 -IsPasswordSet null `
 -Password null `
 -EndPointRole null `
 -EndPointUser null `
 -EndPointUserPolicy null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

