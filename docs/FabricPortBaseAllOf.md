# FabricPortBaseAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AggregatePortId** | **Int64** | Breakout port Identifier of the Switch Interface. | [optional] 
**PortId** | **Int64** | Port Identifier of the Switch/FEX/Chassis Interface. | [optional] 
**SlotId** | **Int64** | Slot Identifier of the Switch/FEX/Chassis Interface. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFabricPortBaseAllOf  -AggregatePortId null `
 -PortId null `
 -SlotId null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

