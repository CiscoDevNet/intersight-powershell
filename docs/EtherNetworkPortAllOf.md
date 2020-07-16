# EtherNetworkPortAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
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
Initialize-IntersightEtherNetworkPortAllOf  -ModuleId null `
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
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

