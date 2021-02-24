# EquipmentPsuControlAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "equipment.PsuControl"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "equipment.PsuControl"]
**ClusterState** | **String** | This field identifies the cluster state of the psu redundancy. | [optional] [readonly] 
**InputPowerState** | **String** | This field identifies the input power state of the psus. | [optional] [readonly] 
**Name** | **String** | This field identifies the name of psu control object. | [optional] [readonly] 
**OperQualifier** | **String** | This field identifies the operational qualifier for the psu redundancy. | [optional] [readonly] 
**OperReason** | **String[]** |  | [optional] 
**OperState** | **String** | This field identifies the operational state of the psu redundancy. | [optional] [readonly] 
**OutputPowerState** | **String** | This field identifies the output power state of the psus. | [optional] [readonly] 
**Redundancy** | **String** | This field identifies the redundancy state of the psus. | [optional] [readonly] 
**EquipmentChassis** | [**EquipmentChassisRelationship**](EquipmentChassisRelationship.md) |  | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$EquipmentPsuControlAllOf = Initialize-IntersightEquipmentPsuControlAllOf  -ClassId null `
 -ObjectType null `
 -ClusterState null `
 -InputPowerState null `
 -Name null `
 -OperQualifier null `
 -OperReason null `
 -OperState null `
 -OutputPowerState null `
 -Redundancy null `
 -EquipmentChassis null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$EquipmentPsuControlAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

