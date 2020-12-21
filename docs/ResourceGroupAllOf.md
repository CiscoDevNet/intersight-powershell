# ResourceGroupAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "resource.Group"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "resource.Group"]
**Name** | **String** | The name of this resource group. | [optional] 
**PerTypeCombinedSelector** | [**ResourcePerTypeCombinedSelector[]**](ResourcePerTypeCombinedSelector.md) |  | [optional] 
**Qualifier** | **String** | Qualifier shall be used to specify if we want to organize resources using multiple resource group or single For an account, resource groups can be of only one of the above types. (Both the types are mutually exclusive for an account.). * &#x60;Allow-Selectors&#x60; - Resources will be added to resource groups based on ODATA filter. Multiple resource group can be created to organize resources. * &#x60;Allow-All&#x60; - All resources will become part of the Resource Group. Only one resource group can be created to organize resources. | [optional] [default to "Allow-Selectors"]
**Selectors** | [**ResourceSelector[]**](ResourceSelector.md) |  | [optional] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 
**Organizations** | [**OrganizationOrganizationRelationship[]**](OrganizationOrganizationRelationship.md) | An array of relationships to organizationOrganization resources. | [optional] 

## Examples

- Prepare the resource
```powershell
$ResourceGroupAllOf = Initialize-IntersightResourceGroupAllOf  -ClassId null `
 -ObjectType null `
 -Name null `
 -PerTypeCombinedSelector null `
 -Qualifier null `
 -Selectors null `
 -Account null `
 -Organizations null
```

- Convert the resource to JSON
```powershell
$ResourceGroupAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

