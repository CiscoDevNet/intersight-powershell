# FabricPortModeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomMode** | **String** | Custom Port Mode specified for the port range. | [optional] [default to "FibreChannel"]
**PortIdEnd** | **Int64** | Ending range of the Port Identifier. | [optional] 
**PortIdStart** | **Int64** | Starting range of the Port Identifier. | [optional] 
**SlotId** | **Int64** | Slot Identifier of the switch. | [optional] 
**PortPolicy** | [**FabricPortPolicyRelationship**](FabricPortPolicyRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFabricPortModeAllOf  -CustomMode null `
 -PortIdEnd null `
 -PortIdStart null `
 -SlotId null `
 -PortPolicy null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

