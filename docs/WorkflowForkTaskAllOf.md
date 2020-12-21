# WorkflowForkTaskAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.ForkTask"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.ForkTask"]
**ForkedTasks** | **String[]** |  | [optional] 
**JoinTask** | **String** | Task name for the join control task that must follow a fork control task. | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkflowForkTaskAllOf = Initialize-IntersightWorkflowForkTaskAllOf  -ClassId null `
 -ObjectType null `
 -ForkedTasks null `
 -JoinTask null
```

- Convert the resource to JSON
```powershell
$WorkflowForkTaskAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

