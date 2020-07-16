# IamPrivilegeSetAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **String** | Description of the privilege set. | [optional] [readonly] 
**Name** | **String** | Name of the privilege set. | [optional] 
**PrivilegeNames** | **String[]** |  | [optional] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 
**AssociatedPrivilegeSets** | [**IamPrivilegeSetRelationship[]**](IamPrivilegeSetRelationship.md) | An array of relationships to iamPrivilegeSet resources. | [optional] 
**Privileges** | [**IamPrivilegeRelationship[]**](IamPrivilegeRelationship.md) | An array of relationships to iamPrivilege resources. | [optional] [readonly] 
**System** | [**IamSystemRelationship**](IamSystemRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIamPrivilegeSetAllOf  -Description null `
 -Name null `
 -PrivilegeNames null `
 -Account null `
 -AssociatedPrivilegeSets null `
 -Privileges null `
 -System null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

