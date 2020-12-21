# AdapterHostEthInterfaceAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "adapter.HostEthInterface"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "adapter.HostEthInterface"]
**AdminState** | **String** | Admin state of the Host Ethernet Interface. | [optional] [readonly] 
**EpDn** | **String** | The Endpoint Config Dn of the Host Ethernet Interface. | [optional] [readonly] 
**HostEthInterfaceId** | **Int64** | Unique Identifier for an Host Ethernet Interface within the adapter object. | [optional] [readonly] 
**InterfaceType** | **String** | Type of External Ethernet Interface. | [optional] [readonly] 
**MacAddress** | **String** | Mac address of the Host Ethernet Interface. | [optional] [readonly] 
**Name** | **String** | Name of Host Ethernet Interface. | [optional] [readonly] 
**Operability** | **String** | Operability status of Host Ethernet Channel Interface. | [optional] [readonly] 
**OriginalMacAddress** | **String** | The factory default Mac address of the Host Ethernet Interface. | [optional] [readonly] 
**PciAddr** | **String** | The PCI address of the Host Ethernet Interface. | [optional] [readonly] 
**PeerDn** | **String** | The distinguished name of the peer endpoint connected to the Host Ethernet interface. | [optional] [readonly] 
**VirtualizationPreference** | **String** | Virtualization Preference of the Host Ethernet Interface indicating if virtualization is enabled or not. | [optional] [readonly] 
**VnicDn** | **String** | The Virtual Ethernet Interface DN connected to the Host Ethernet Interface. | [optional] [readonly] 
**AdapterUnit** | [**AdapterUnitRelationship**](AdapterUnitRelationship.md) |  | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$AdapterHostEthInterfaceAllOf = Initialize-IntersightAdapterHostEthInterfaceAllOf  -ClassId null `
 -ObjectType null `
 -AdminState null `
 -EpDn null `
 -HostEthInterfaceId null `
 -InterfaceType null `
 -MacAddress null `
 -Name null `
 -Operability null `
 -OriginalMacAddress null `
 -PciAddr null `
 -PeerDn null `
 -VirtualizationPreference null `
 -VnicDn null `
 -AdapterUnit null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$AdapterHostEthInterfaceAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

