# FabricConfigResultAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarProfile** | [**FabricSwitchProfileRelationship**](FabricSwitchProfileRelationship.md) |  | [optional] 
**ResultEntries** | [**FabricConfigResultEntryRelationship[]**](FabricConfigResultEntryRelationship.md) | An array of relationships to fabricConfigResultEntry resources. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFabricConfigResultAllOf  -VarProfile null `
 -ResultEntries null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

