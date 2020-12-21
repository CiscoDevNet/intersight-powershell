# AdapterExtEthInterfaceAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "adapter.ExtEthInterface"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "adapter.ExtEthInterface"]
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
$AdapterExtEthInterfaceAllOf = Initialize-IntersightAdapterExtEthInterfaceAllOf  -ClassId null `
 -ObjectType null `
 -AdminState null `
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
$AdapterExtEthInterfaceAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

