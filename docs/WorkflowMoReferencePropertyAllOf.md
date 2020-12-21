# WorkflowMoReferencePropertyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.MoReferenceProperty"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.MoReferenceProperty"]
**DisplayAttributes** | **String[]** |  | [optional] 
**Selector** | **String** | Field to hold an Intersight API along with an optional filter to narrow down the search options. | [optional] 
**ValueAttribute** | **String** | A property from the Intersight object, value of which can be used as value for referenced input definition. | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkflowMoReferencePropertyAllOf = Initialize-IntersightWorkflowMoReferencePropertyAllOf  -ClassId null `
 -ObjectType null `
 -DisplayAttributes null `
 -Selector null `
 -ValueAttribute null
```

- Convert the resource to JSON
```powershell
$WorkflowMoReferencePropertyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

