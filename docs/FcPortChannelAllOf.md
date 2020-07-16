# FcPortChannelAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdminSpeed** | **String** | Administrator configured Speed applied on the port channel. | [optional] 
**AdminState** | **String** | Administratively configured state (enabled/disabled) for this portchannel. | [optional] [readonly] 
**Mode** | **String** | Mode information N_proxy, F or E associated to the Fibre Channel portchannel. | [optional] 
**OperSpeed** | **String** | Operational speed of this port-channel. | [optional] 
**OperState** | **String** | Operational state of this port-channel. | [optional] 
**OperStateQual** | **String** | Reason for this port-channel&#39;s Operational state. | [optional] 
**PortChannelId** | **Int64** | Unique identifier for this port-channel on the FI. | [optional] 
**Role** | **String** | This port-channel&#39;s configured role (fcUplink, fcStorage, etc.). | [optional] 
**SwitchId** | **String** | Switch Identifier that is local to a cluster. | [optional] 
**Vsan** | **Int64** | Virtual San that is associated to the port-channel. | [optional] 
**EquipmentSwitchCard** | [**EquipmentSwitchCardRelationship**](EquipmentSwitchCardRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFcPortChannelAllOf  -AdminSpeed null `
 -AdminState null `
 -Mode null `
 -OperSpeed null `
 -OperState null `
 -OperStateQual null `
 -PortChannelId null `
 -Role null `
 -SwitchId null `
 -Vsan null `
 -EquipmentSwitchCard null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

