# FabricSwitchProfileAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
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
Initialize-IntersightFabricSwitchProfileAllOf  -ConfigChanges null `
 -AssignedSwitch null `
 -AssociatedSwitch null `
 -ConfigChangeDetails null `
 -ConfigResult null `
 -RunningWorkflows null `
 -SwitchClusterProfile null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

