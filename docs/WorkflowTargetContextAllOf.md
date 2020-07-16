# WorkflowTargetContextAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TargetMoid** | **String** | Moid of the target Intersight managed object. | [optional] 
**TargetName** | **String** | Name of the target instance. | [optional] 
**TargetType** | **String** | Object type of the target Intersight managed object. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowTargetContextAllOf  -TargetMoid null `
 -TargetName null `
 -TargetType null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

