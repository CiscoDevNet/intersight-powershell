# WorkflowFileTemplateOpAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.FileTemplateOp"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.FileTemplateOp"]
**TemplateFilePath** | **String** | Path of the template file on the connected device. | [optional] 
**TemplateValues** | [**AnyType**](.md) | Input values to render text output file from template file. | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkflowFileTemplateOpAllOf = Initialize-IntersightWorkflowFileTemplateOpAllOf  -ClassId null `
 -ObjectType null `
 -TemplateFilePath null `
 -TemplateValues null
```

- Convert the resource to JSON
```powershell
$WorkflowFileTemplateOpAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

