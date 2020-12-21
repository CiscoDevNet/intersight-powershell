# OrganizationOrganizationAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "organization.Organization"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "organization.Organization"]
**Description** | **String** | The informative description about the usage of this organization. | [optional] 
**Name** | **String** | The name of the organization. There can be multiple organizations under an account. | [optional] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 
**ResourceGroups** | [**ResourceGroupRelationship[]**](ResourceGroupRelationship.md) | An array of relationships to resourceGroup resources. | [optional] 

## Examples

- Prepare the resource
```powershell
$OrganizationOrganizationAllOf = Initialize-IntersightOrganizationOrganizationAllOf  -ClassId null `
 -ObjectType null `
 -Description null `
 -Name null `
 -Account null `
 -ResourceGroups null
```

- Convert the resource to JSON
```powershell
$OrganizationOrganizationAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

