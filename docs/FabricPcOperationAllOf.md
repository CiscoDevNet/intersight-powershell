# FabricPcOperationAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdminState** | **String** | Admin configured state to disable the port channel. | [optional] [default to "Enabled"]
**PcId** | **Int64** | Port Channel Identifier for the collection of ports. | [optional] 
**NetworkElement** | [**NetworkElementRelationship**](NetworkElementRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFabricPcOperationAllOf  -AdminState null `
 -PcId null `
 -NetworkElement null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

