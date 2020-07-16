# WorkflowDecisionCaseAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **String** | Description of this decision case. | [optional] 
**NextTask** | **String** | The name of the next task (Task names unique within workflow) to run.  In a graph model, denotes an edge to another Task Node. | [optional] 
**Value** | **String** | Value for the decision case. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowDecisionCaseAllOf  -Description null `
 -NextTask null `
 -Value null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

