# EquipmentTransceiverAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "equipment.Transceiver"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "equipment.Transceiver"]
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
$EquipmentTransceiverAllOf = Initialize-IntersightEquipmentTransceiverAllOf  -ClassId null `
 -ObjectType null `
 -OperSpeed null `
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
$EquipmentTransceiverAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

