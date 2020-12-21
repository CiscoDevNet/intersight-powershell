# AdapterHostFcInterfaceAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "adapter.HostFcInterface"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "adapter.HostFcInterface"]
**AdminState** | **String** | Admin Configured State of Host Fibre Channel Interface. | [optional] [readonly] 
**EpDn** | **String** | The Endpoint Config Dn of the Host Fibre Channel Interface. | [optional] [readonly] 
**HostFcInterfaceId** | **Int64** | Identifier of Host Fibre Channel Interface. | [optional] [readonly] 
**Name** | **String** | Name of Host Fibre Channel Interface. | [optional] [readonly] 
**OperState** | **String** | Operational State of Host Fibre Channel Interface. | [optional] [readonly] 
**Operability** | **String** | Operability status of Host Fibre Channel Interface. | [optional] [readonly] 
**OriginalWwnn** | **String** | The uniquely distinguishable factory default  World Wide Node Name of the Host. | [optional] [readonly] 
**OriginalWwpn** | **String** | The uniquely distinguishable factory default World Wide Port Name of the Host Fibre Channel Interface. | [optional] [readonly] 
**PeerDn** | **String** | PeerPort Dn of Host Fibre Channel Interface. | [optional] [readonly] 
**Wwnn** | **String** | The uniquely distinguishable user configured World Wide Node Name of the Host. | [optional] [readonly] 
**Wwpn** | **String** | The uniquely distinguishable user configured World Wide Port Name of the Host Fibre Channel Interface. | [optional] [readonly] 
**AdapterUnit** | [**AdapterUnitRelationship**](AdapterUnitRelationship.md) |  | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$AdapterHostFcInterfaceAllOf = Initialize-IntersightAdapterHostFcInterfaceAllOf  -ClassId null `
 -ObjectType null `
 -AdminState null `
 -EpDn null `
 -HostFcInterfaceId null `
 -Name null `
 -OperState null `
 -Operability null `
 -OriginalWwnn null `
 -OriginalWwpn null `
 -PeerDn null `
 -Wwnn null `
 -Wwpn null `
 -AdapterUnit null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$AdapterHostFcInterfaceAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

