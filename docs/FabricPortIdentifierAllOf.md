# FabricPortIdentifierAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "fabric.PortIdentifier"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "fabric.PortIdentifier"]
**AggregatePortId** | **Int64** | Breakout port Identifier of the Switch Interface. When a port is not configured as a breakout port, the aggregatePortId is set to 0, and unused. When a port is configured as a breakout port, the &#39;aggregatePortId&#39; port number as labeled on the equipment, e.g. the id of the port on the switch. | [optional] 
**PortId** | **Int64** | Port Identifier of the Switch/FEX/Chassis Interface. When a port is not configured as a breakout port, the portId is the port number as labeled on the equipment, e.g. the id of the port on the switch, FEX or chassis. When a port is configured as a breakout port, the &#39;portId&#39; represents the port id on the fanout side of the breakout cable. | [optional] 
**SlotId** | **Int64** | Slot Identifier of the Switch/FEX/Chassis Interface. | [optional] 

## Examples

- Prepare the resource
```powershell
$FabricPortIdentifierAllOf = Initialize-IntersightFabricPortIdentifierAllOf  -ClassId null `
 -ObjectType null `
 -AggregatePortId null `
 -PortId null `
 -SlotId null
```

- Convert the resource to JSON
```powershell
$FabricPortIdentifierAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

