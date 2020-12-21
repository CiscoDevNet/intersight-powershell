# WorkflowTargetContext
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.TargetContext"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.TargetContext"]
**TargetMoid** | **String** | Moid of the target Intersight managed object. | [optional] 
**TargetName** | **String** | Name of the target instance. | [optional] 
**TargetType** | **String** | Object type of the target Intersight managed object. | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkflowTargetContext = Initialize-IntersightWorkflowTargetContext  -ClassId null `
 -ObjectType null `
 -TargetMoid null `
 -TargetName null `
 -TargetType null
```

- Convert the resource to JSON
```powershell
$WorkflowTargetContext | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

