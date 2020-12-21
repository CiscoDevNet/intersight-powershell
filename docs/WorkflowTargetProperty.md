# WorkflowTargetProperty
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.TargetProperty"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.TargetProperty"]
**ConnectorAttribute** | **String** | A singleton value which will contain the path to connector object from the selected object. | [optional] 
**ConstraintAttributes** | **String[]** |  | [optional] 
**DisplayAttributes** | **String[]** |  | [optional] 
**Selector** | **String** | Field to hold an Intersight API along with an optional filter to narrow down the search options for target device. | [optional] 
**SupportedObjects** | **String[]** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkflowTargetProperty = Initialize-IntersightWorkflowTargetProperty  -ClassId null `
 -ObjectType null `
 -ConnectorAttribute null `
 -ConstraintAttributes null `
 -DisplayAttributes null `
 -Selector null `
 -SupportedObjects null
```

- Convert the resource to JSON
```powershell
$WorkflowTargetProperty | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

