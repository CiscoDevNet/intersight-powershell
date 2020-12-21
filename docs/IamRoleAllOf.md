# IamRoleAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iam.Role"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iam.Role"]
**Description** | **String** | Informative description about each role. | [optional] [readonly] 
**Name** | **String** | The name of the role which has to be granted to user. | [optional] 
**PrivilegeNames** | **String[]** |  | [optional] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 
**PrivilegeSets** | [**IamPrivilegeSetRelationship[]**](IamPrivilegeSetRelationship.md) | An array of relationships to iamPrivilegeSet resources. | [optional] [readonly] 
**System** | [**IamSystemRelationship**](IamSystemRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$IamRoleAllOf = Initialize-IntersightIamRoleAllOf  -ClassId null `
 -ObjectType null `
 -Description null `
 -Name null `
 -PrivilegeNames null `
 -Account null `
 -PrivilegeSets null `
 -System null
```

- Convert the resource to JSON
```powershell
$IamRoleAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

