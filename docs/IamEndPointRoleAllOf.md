# IamEndPointRoleAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **String** | The name of the end point role. | [optional] [readonly] 
**RoleType** | **String** | User specified tags to roles like as ep-admin or ep-readonly. | [optional] [readonly] 
**Type** | **String** | The type of the end point like Cisco UCS Fabric Interconnect or Cisco IMC. | [optional] [readonly] [default to ""]
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 
**EndPointPrivileges** | [**IamEndPointPrivilegeRelationship[]**](IamEndPointPrivilegeRelationship.md) | An array of relationships to iamEndPointPrivilege resources. | [optional] [readonly] 
**System** | [**IamSystemRelationship**](IamSystemRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIamEndPointRoleAllOf  -Name null `
 -RoleType null `
 -Type null `
 -Account null `
 -EndPointPrivileges null `
 -System null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

