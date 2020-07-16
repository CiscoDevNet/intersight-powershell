# ResourceGroupAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **String** | The name of this resource group. | [optional] 
**PerTypeCombinedSelector** | [**ResourcePerTypeCombinedSelector[]**](ResourcePerTypeCombinedSelector.md) |  | [optional] 
**Qualifier** | **String** | Qualifier shall be used to specify if we want to organize resources using multiple resource group or single For an account, resource groups can be of only one of the above types. (Both the types are mutually exclusive for an account.). | [optional] [default to "Allow-Selectors"]
**Selectors** | [**ResourceSelector[]**](ResourceSelector.md) |  | [optional] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 
**Organizations** | [**OrganizationOrganizationRelationship[]**](OrganizationOrganizationRelationship.md) | An array of relationships to organizationOrganization resources. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightResourceGroupAllOf  -Name null `
 -PerTypeCombinedSelector null `
 -Qualifier null `
 -Selectors null `
 -Account null `
 -Organizations null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

