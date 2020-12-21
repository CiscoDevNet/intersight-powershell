# FabricPortModeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "fabric.PortMode"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "fabric.PortMode"]
**CustomMode** | **String** | Custom Port Mode specified for the port range. * &#x60;FibreChannel&#x60; - Fibre Channel Port Types. * &#x60;BreakoutEthernet10G&#x60; - Breakout Ethernet 10G Port Type. * &#x60;BreakoutEthernet25G&#x60; - Breakout Ethernet 25G Port Type. | [optional] [default to "FibreChannel"]
**PortIdEnd** | **Int64** | Ending range of the Port Identifier. | [optional] 
**PortIdStart** | **Int64** | Starting range of the Port Identifier. | [optional] 
**SlotId** | **Int64** | Slot Identifier of the switch. | [optional] 
**PortPolicy** | [**FabricPortPolicyRelationship**](FabricPortPolicyRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$FabricPortModeAllOf = Initialize-IntersightFabricPortModeAllOf  -ClassId null `
 -ObjectType null `
 -CustomMode null `
 -PortIdEnd null `
 -PortIdStart null `
 -SlotId null `
 -PortPolicy null
```

- Convert the resource to JSON
```powershell
$FabricPortModeAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

