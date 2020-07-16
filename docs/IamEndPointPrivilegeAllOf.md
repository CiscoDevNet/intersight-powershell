# IamEndPointPrivilegeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **String** | The functionality of this privilege. | [optional] [readonly] 
**Name** | **String** | The name of the end point privilege. | [optional] [readonly] 
**Type** | **String** | The type of the end point like Cisco UCS Fabric Interconnect or Cisco IMC. | [optional] [readonly] [default to ""]
**System** | [**IamSystemRelationship**](IamSystemRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIamEndPointPrivilegeAllOf  -Description null `
 -Name null `
 -Type null `
 -System null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

