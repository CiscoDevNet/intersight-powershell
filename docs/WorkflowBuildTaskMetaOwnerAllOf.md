# WorkflowBuildTaskMetaOwnerAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.BuildTaskMetaOwner"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.BuildTaskMetaOwner"]
**Service** | **String** | The microservice owner responsible for the tasks. | [optional] [readonly] 
**WorkflowTypes** | **String[]** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkflowBuildTaskMetaOwnerAllOf = Initialize-IntersightWorkflowBuildTaskMetaOwnerAllOf  -ClassId null `
 -ObjectType null `
 -Service null `
 -WorkflowTypes null
```

- Convert the resource to JSON
```powershell
$WorkflowBuildTaskMetaOwnerAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

