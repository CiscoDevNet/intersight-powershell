# FabricSwitchProfileAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "fabric.SwitchProfile"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "fabric.SwitchProfile"]
**ConfigChanges** | [**PolicyConfigChange**](PolicyConfigChange.md) |  | [optional] 
**AssignedSwitch** | [**NetworkElementRelationship**](NetworkElementRelationship.md) |  | [optional] 
**AssociatedSwitch** | [**NetworkElementRelationship**](NetworkElementRelationship.md) |  | [optional] 
**ConfigChangeDetails** | [**FabricConfigChangeDetailRelationship[]**](FabricConfigChangeDetailRelationship.md) | An array of relationships to fabricConfigChangeDetail resources. | [optional] [readonly] 
**ConfigResult** | [**FabricConfigResultRelationship**](FabricConfigResultRelationship.md) |  | [optional] 
**RunningWorkflows** | [**WorkflowWorkflowInfoRelationship[]**](WorkflowWorkflowInfoRelationship.md) | An array of relationships to workflowWorkflowInfo resources. | [optional] [readonly] 
**SwitchClusterProfile** | [**FabricSwitchClusterProfileRelationship**](FabricSwitchClusterProfileRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$FabricSwitchProfileAllOf = Initialize-IntersightFabricSwitchProfileAllOf  -ClassId null `
 -ObjectType null `
 -ConfigChanges null `
 -AssignedSwitch null `
 -AssociatedSwitch null `
 -ConfigChangeDetails null `
 -ConfigResult null `
 -RunningWorkflows null `
 -SwitchClusterProfile null
```

- Convert the resource to JSON
```powershell
$FabricSwitchProfileAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

