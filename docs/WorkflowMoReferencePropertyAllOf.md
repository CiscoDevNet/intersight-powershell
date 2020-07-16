# WorkflowMoReferencePropertyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayAttributes** | **String[]** |  | [optional] 
**Selector** | **String** | Field to hold an Intersight API along with an optional filter to narrow down the search options. | [optional] 
**ValueAttribute** | **String** | A property from the Intersight object, value of which can be used as value for referenced input definition. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowMoReferencePropertyAllOf  -DisplayAttributes null `
 -Selector null `
 -ValueAttribute null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

