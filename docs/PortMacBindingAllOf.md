# PortMacBindingAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AggregatePortId** | **Int64** | Aggregate Port ID of the local Switch Interface. | [optional] 
**ChassisId** | **Int64** | Chassis/FEX device idetifier that is local to a cluster. | [optional] 
**DeviceMac** | **String** | Device ID value that is advertised and available as a part of LLDP TLV. | [optional] 
**PortId** | **Int64** | Port ID of the local Switch Interface. | [optional] 
**PortMac** | **String** | Port ID value that is advertised and available as a part of LLDP TLV. | [optional] 
**SlotId** | **Int64** | Slot ID of the local Switch slot Interface. | [optional] 
**SwitchId** | **Int64** | Switch Identifier that is local to a cluster. | [optional] 
**NetworkElement** | [**NetworkElementRelationship**](NetworkElementRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightPortMacBindingAllOf  -AggregatePortId null `
 -ChassisId null `
 -DeviceMac null `
 -PortId null `
 -PortMac null `
 -SlotId null `
 -SwitchId null `
 -NetworkElement null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

