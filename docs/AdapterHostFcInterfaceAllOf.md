# AdapterHostFcInterfaceAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
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
Initialize-IntersightAdapterHostFcInterfaceAllOf  -AdminState null `
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
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

