# WorkflowStartTaskAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.StartTask"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.StartTask"]
**NextTask** | **String** | The name of the next task (Task names unique within workflow) to run.  In a graph model, denotes an edge to another Task Node. | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkflowStartTaskAllOf = Initialize-IntersightWorkflowStartTaskAllOf  -ClassId null `
 -ObjectType null `
 -NextTask null
```

- Convert the resource to JSON
```powershell
$WorkflowStartTaskAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

