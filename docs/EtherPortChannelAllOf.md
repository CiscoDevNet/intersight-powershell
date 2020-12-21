# EtherPortChannelAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "ether.PortChannel"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "ether.PortChannel"]
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
$EtherPortChannelAllOf = Initialize-IntersightEtherPortChannelAllOf  -ClassId null `
 -ObjectType null `
 -AccessVlan null `
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
$EtherPortChannelAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

