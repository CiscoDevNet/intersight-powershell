# MetaPropDefinitionAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApiAccess** | **String** | API access control for the property. Examples are NoAccess, ReadOnly, CreateOnly etc. | [optional] [readonly] [default to "NoAccess"]
**Name** | **String** | The name of the property. | [optional] [readonly] 
**OpSecurity** | **String** | The data-at-rest security protection applied to this property when a Managed Object is persisted. For example, Encrypted or Cleartext. | [optional] [readonly] [default to "ClearText"]
**SearchWeight** | **Double** | Enables the property to be searchable from global search. A value of 0 means this property is not globally searchable. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightMetaPropDefinitionAllOf  -ApiAccess null `
 -Name null `
 -OpSecurity null `
 -SearchWeight null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

