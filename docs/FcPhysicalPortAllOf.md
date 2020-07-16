# FcPhysicalPortAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdminSpeed** | **String** | Administrator configured Speed applied on the port. | [optional] [readonly] 
**AdminState** | **String** | Administratively configured state (enabled/disabled) for this port. | [optional] [readonly] 
**B2bCredit** | **Int64** | Buffer to Buffer credits of FC port. | [optional] [readonly] 
**MaxSpeed** | **String** | Maximum Speed with which the port operates. | [optional] [readonly] 
**Mode** | **String** | Mode information N_proxy, F or E associated to the Fibre Channel port. | [optional] [readonly] 
**OperSpeed** | **String** | Operational Speed with which the port operates. | [optional] [readonly] 
**PeerDn** | **String** | PeerDn for fibre channel physical port. | [optional] [readonly] 
**PortChannelId** | **Int64** | Port channel id of FC port channel created on FI switch. | [optional] [readonly] 
**TransceiverType** | **String** | Transceiver type of a Fibre Channel port. | [optional] [readonly] 
**Vsan** | **Int64** | Virtual San that is associated to the port. | [optional] [readonly] 
**Wwn** | **String** | World Wide Name of a Fibre Channel port. | [optional] [readonly] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**PortGroup** | [**PortGroupRelationship**](PortGroupRelationship.md) |  | [optional] 
**PortSubGroup** | [**PortSubGroupRelationship**](PortSubGroupRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFcPhysicalPortAllOf  -AdminSpeed null `
 -AdminState null `
 -B2bCredit null `
 -MaxSpeed null `
 -Mode null `
 -OperSpeed null `
 -PeerDn null `
 -PortChannelId null `
 -TransceiverType null `
 -Vsan null `
 -Wwn null `
 -InventoryDeviceInfo null `
 -PortGroup null `
 -PortSubGroup null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

