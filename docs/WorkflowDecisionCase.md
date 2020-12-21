# WorkflowDecisionCase
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.DecisionCase"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.DecisionCase"]
**Description** | **String** | Description of this decision case. | [optional] 
**NextTask** | **String** | The name of the next task (Task names unique within workflow) to run.  In a graph model, denotes an edge to another Task Node. | [optional] 
**Value** | **String** | Value for the decision case. | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkflowDecisionCase = Initialize-IntersightWorkflowDecisionCase  -ClassId null `
 -ObjectType null `
 -Description null `
 -NextTask null `
 -Value null
```

- Convert the resource to JSON
```powershell
$WorkflowDecisionCase | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

