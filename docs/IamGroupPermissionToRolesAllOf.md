# IamGroupPermissionToRolesAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iam.GroupPermissionToRoles"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iam.GroupPermissionToRoles"]
**Group** | [**CmrfCmRf**](CmrfCmRf.md) |  | [optional] 
**Orgs** | [**CmrfCmRf[]**](CmrfCmRf.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$IamGroupPermissionToRolesAllOf = Initialize-IntersightIamGroupPermissionToRolesAllOf  -ClassId null `
 -ObjectType null `
 -Group null `
 -Orgs null
```

- Convert the resource to JSON
```powershell
$IamGroupPermissionToRolesAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

