# AdapterExtEthInterfaceAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdminState** | **String** | Admin configured state of an External Ethernet Interface. | [optional] [readonly] 
**EpDn** | **String** | Endpoint Config DN of an External Ethernet Interface. | [optional] [readonly] 
**ExtEthInterfaceId** | **String** | Unique Identifier for an External Ethernet Interface within the adapter object. | [optional] [readonly] 
**InterfaceType** | **String** | Type of an External Ethernet Interface. | [optional] [readonly] 
**MacAddress** | **String** | MAC address of an External Ethernet Interface. | [optional] [readonly] 
**PeerAggrPortId** | **Int64** | Peer Aggregate Port Id attached to an External Ethernet Interface. | [optional] [readonly] 
**PeerDn** | **String** | DN of peer end-point attached to an External Ethernet Interface. | [optional] [readonly] 
**PeerPortId** | **Int64** | Peer Port Id attached to an External Ethernet Interface. | [optional] [readonly] 
**PeerSlotId** | **Int64** | Peer Slot Id attached to an External Ethernet Interface. | [optional] [readonly] 
**SwitchId** | **String** | SwitchId attached to an External Ethernet Interface. | [optional] [readonly] 
**AdapterUnit** | [**AdapterUnitRelationship**](AdapterUnitRelationship.md) |  | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightAdapterExtEthInterfaceAllOf  -AdminState null `
 -EpDn null `
 -ExtEthInterfaceId null `
 -InterfaceType null `
 -MacAddress null `
 -PeerAggrPortId null `
 -PeerDn null `
 -PeerPortId null `
 -PeerSlotId null `
 -SwitchId null `
 -AdapterUnit null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

