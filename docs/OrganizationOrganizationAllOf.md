# OrganizationOrganizationAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **String** | The informative description about the usage of this organization. | [optional] 
**Name** | **String** | The name of the organization. There can be multiple organizations under an account. | [optional] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 
**ResourceGroups** | [**ResourceGroupRelationship[]**](ResourceGroupRelationship.md) | An array of relationships to resourceGroup resources. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightOrganizationOrganizationAllOf  -Description null `
 -Name null `
 -Account null `
 -ResourceGroups null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

