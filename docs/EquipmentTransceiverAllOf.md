# EquipmentTransceiverAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OperSpeed** | **String** | Operational speed of the transceiver. | [optional] [readonly] 
**OperState** | **String** | Operational state of the transceiver. | [optional] [readonly] 
**OperStateQual** | **String** | Reason for this transceiver&#39;s operational state. | [optional] [readonly] 
**PortId** | **Int64** | Switch physical port identifier. | [optional] [readonly] 
**SlotId** | **Int64** | Switch expansion slot module identifier. | [optional] [readonly] 
**SwitchId** | **String** | Switch Identifier that is local to a cluster. | [optional] [readonly] 
**Type** | **String** | The type of the transceiver. | [optional] [readonly] 
**EtherPhysicalPort** | [**EtherPhysicalPortRelationship**](EtherPhysicalPortRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightEquipmentTransceiverAllOf  -OperSpeed null `
 -OperState null `
 -OperStateQual null `
 -PortId null `
 -SlotId null `
 -SwitchId null `
 -Type null `
 -EtherPhysicalPort null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

