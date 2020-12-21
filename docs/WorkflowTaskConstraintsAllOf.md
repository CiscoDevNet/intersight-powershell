# WorkflowTaskConstraintsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.TaskConstraints"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.TaskConstraints"]
**TargetDataType** | [**AnyType**](.md) | List of property constraints that helps to narrow down task implementations based on target device input. | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkflowTaskConstraintsAllOf = Initialize-IntersightWorkflowTaskConstraintsAllOf  -ClassId null `
 -ObjectType null `
 -TargetDataType null
```

- Convert the resource to JSON
```powershell
$WorkflowTaskConstraintsAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

