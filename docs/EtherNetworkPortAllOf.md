# EtherNetworkPortAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "ether.NetworkPort"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "ether.NetworkPort"]
**ModuleId** | **Int64** | Febric extender identifier for this port. | [optional] 
**PeerDn** | **String** | Peer DN for network host port of fabric extender. | [optional] 
**PortId** | **Int64** | Switch physical port identifier. | [optional] 
**SlotId** | **Int64** | Switch expansion slot module identifier. | [optional] 
**Speed** | **String** | Network Port Speed of IO card or fabric extender. | [optional] [readonly] 
**SwitchId** | **String** | Switch Identifier that is local to a cluster. | [optional] 
**EquipmentIoCardBase** | [**EquipmentIoCardBaseRelationship**](EquipmentIoCardBaseRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$EtherNetworkPortAllOf = Initialize-IntersightEtherNetworkPortAllOf  -ClassId null `
 -ObjectType null `
 -ModuleId null `
 -PeerDn null `
 -PortId null `
 -SlotId null `
 -Speed null `
 -SwitchId null `
 -EquipmentIoCardBase null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$EtherNetworkPortAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

