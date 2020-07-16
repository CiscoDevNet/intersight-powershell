# EtherPortChannelAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessVlan** | **String** | Access VLANs for this port-channel, on this FI. | [optional] 
**AdminState** | **String** | Administratively configured state (enabled/disabled) for this port-channel. | [optional] 
**AllowedVlans** | **String** | Allowed VLANs on this port-channel, on this FI. | [optional] 
**Mode** | **String** | Operating mode of this port-channel. | [optional] 
**NativeVlan** | **String** | Native VLAN for this port-channel, on this FI. | [optional] 
**OperSpeed** | **String** | Operational speed of this port-channel. | [optional] 
**OperState** | **String** | Operational state of this port-channel. | [optional] 
**OperStateQual** | **String** | Reason for this port-channel&#39;s Operational state. | [optional] 
**PortChannelId** | **Int64** | Unique identifier for this port-channel on the FI. | [optional] 
**Role** | **String** | This port-channel&#39;s configured role (uplink, server, etc.). | [optional] 
**SwitchId** | **String** | Switch Identifier that is local to a cluster. | [optional] 
**EquipmentSwitchCard** | [**EquipmentSwitchCardRelationship**](EquipmentSwitchCardRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightEtherPortChannelAllOf  -AccessVlan null `
 -AdminState null `
 -AllowedVlans null `
 -Mode null `
 -NativeVlan null `
 -OperSpeed null `
 -OperState null `
 -OperStateQual null `
 -PortChannelId null `
 -Role null `
 -SwitchId null `
 -EquipmentSwitchCard null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

