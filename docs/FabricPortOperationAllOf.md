# FabricPortOperationAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdminState** | **String** | Admin configured state to disable the port. | [optional] [default to "Enabled"]
**NetworkElement** | [**NetworkElementRelationship**](NetworkElementRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFabricPortOperationAllOf  -AdminState null `
 -NetworkElement null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

