# ServerConfigResultAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarProfile** | [**ServerProfileRelationship**](ServerProfileRelationship.md) |  | [optional] 
**ResultEntries** | [**ServerConfigResultEntryRelationship[]**](ServerConfigResultEntryRelationship.md) | An array of relationships to serverConfigResultEntry resources. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightServerConfigResultAllOf  -VarProfile null `
 -ResultEntries null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

