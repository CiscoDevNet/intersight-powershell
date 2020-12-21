# WorkflowBuildTaskMetaAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.BuildTaskMeta"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.BuildTaskMeta"]
**Name** | **String** | Name for the BuildTaskMeta instance used to created a dynamic workflow. | [optional] [readonly] 
**Src** | **String** | Microservice owner for the task in this workflow. | [optional] [readonly] 
**TaskList** | [**AnyType**](.md) | Task list used to build the dynamic workflow. | [optional] [readonly] 
**TaskType** | **String** | The type of the task within this workflow. | [optional] [readonly] 
**WorkflowType** | **String** | The type for the dynamic workflow. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$WorkflowBuildTaskMetaAllOf = Initialize-IntersightWorkflowBuildTaskMetaAllOf  -ClassId null `
 -ObjectType null `
 -Name null `
 -Src null `
 -TaskList null `
 -TaskType null `
 -WorkflowType null
```

- Convert the resource to JSON
```powershell
$WorkflowBuildTaskMetaAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

