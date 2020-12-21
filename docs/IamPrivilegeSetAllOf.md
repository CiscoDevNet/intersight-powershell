# IamPrivilegeSetAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iam.PrivilegeSet"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iam.PrivilegeSet"]
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
$IamPrivilegeSetAllOf = Initialize-IntersightIamPrivilegeSetAllOf  -ClassId null `
 -ObjectType null `
 -Description null `
 -Name null `
 -PrivilegeNames null `
 -Account null `
 -AssociatedPrivilegeSets null `
 -Privileges null `
 -System null
```

- Convert the resource to JSON
```powershell
$IamPrivilegeSetAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

