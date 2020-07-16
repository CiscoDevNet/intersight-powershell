# ResourceLicenseResourceCountAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LicenseType** | **String** | Type of licensing defined for this resource group. Used for licensing group. | [optional] [readonly] [default to "Base"]
**ResourceCount** | **Int64** | The number of resource belongs to this licensing tier. | [optional] [readonly] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 
**LicenseGroups** | [**ResourceGroupRelationship[]**](ResourceGroupRelationship.md) | An array of relationships to resourceGroup resources. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightResourceLicenseResourceCountAllOf  -LicenseType null `
 -ResourceCount null `
 -Account null `
 -LicenseGroups null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

