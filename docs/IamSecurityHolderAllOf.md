# IamSecurityHolderAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 
**ResourcePermissions** | [**IamResourcePermissionRelationship[]**](IamResourcePermissionRelationship.md) | An array of relationships to iamResourcePermission resources. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIamSecurityHolderAllOf  -Account null `
 -ResourcePermissions null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

