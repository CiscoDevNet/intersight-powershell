# WorkflowAssociatedRolesAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.AssociatedRoles"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.AssociatedRoles"]
**Moid** | **String** | Stores the identifier of the task definition for which the required roles are cached in the workflow definition. In the case of sub workflow tasks, this property stores the identifier of the workflow that is wrapped in the sub workflow task. | [optional] [readonly] 
**Roles** | **String[]** |  | [optional] 
**TaskNames** | **String[]** |  | [optional] 
**WorkflowRoles** | [**WorkflowAssociatedRoles[]**](WorkflowAssociatedRoles.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkflowAssociatedRolesAllOf = Initialize-IntersightWorkflowAssociatedRolesAllOf  -ClassId null `
 -ObjectType null `
 -Moid null `
 -Roles null `
 -TaskNames null `
 -WorkflowRoles null
```

- Convert the resource to JSON
```powershell
$WorkflowAssociatedRolesAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

