# WorkflowTargetPropertyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConnectorAttribute** | **String** | A singleton value which will contain the path to connector object from the selected object. | [optional] 
**ConstraintAttributes** | **String[]** |  | [optional] 
**DisplayAttributes** | **String[]** |  | [optional] 
**Selector** | **String** | Field to hold an Intersight API along with an optional filter to narrow down the search options for target device. | [optional] 
**SupportedObjects** | **String[]** |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowTargetPropertyAllOf  -ConnectorAttribute null `
 -ConstraintAttributes null `
 -DisplayAttributes null `
 -Selector null `
 -SupportedObjects null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

