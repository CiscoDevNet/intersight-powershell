# WorkflowDefaultValueAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.DefaultValue"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.DefaultValue"]
**Override** | **Boolean** | Override the default value provided for the data type. When true, allow the user to enter value for the data type. | [optional] 
**Value** | [**AnyType**](.md) | Default value for the data type. If default value was provided and the input was required the default value will be used as the input. | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkflowDefaultValueAllOf = Initialize-IntersightWorkflowDefaultValueAllOf  -ClassId null `
 -ObjectType null `
 -Override null `
 -Value null
```

- Convert the resource to JSON
```powershell
$WorkflowDefaultValueAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

