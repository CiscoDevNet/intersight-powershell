# EquipmentSystemIoControllerAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "equipment.SystemIoController"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "equipment.SystemIoController"]
**ChassisId** | **String** | The assigned identifier for a chassis. | [optional] [readonly] 
**ConnectionPath** | **String** | Connection Path identifies the data path available between IOModule and FI. | [optional] [readonly] 
**ConnectionStatus** | **String** | Connection status identifies the status of data path. | [optional] [readonly] 
**Description** | **String** | This field gives a brief information on systemIOController. | [optional] [readonly] 
**ManagingInstance** | **String** | This field identifies the CIMC that manages the controller. | [optional] [readonly] 
**OperState** | **String** | This field identifies the SIOC operational state. | [optional] [readonly] 
**PartNumber** | **String** | Part Number identifier for the IO module. | [optional] [readonly] 
**VarPid** | **String** | This field identifies the Product ID for systemIOController. | [optional] [readonly] 
**SystemIoControllerId** | **Int64** | This represents system I/O Controller identifier. | [optional] [readonly] 
**Cmc** | [**ManagementControllerRelationship**](ManagementControllerRelationship.md) |  | [optional] 
**EquipmentChassis** | [**EquipmentChassisRelationship**](EquipmentChassisRelationship.md) |  | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**SharedIoModule** | [**EquipmentSharedIoModuleRelationship**](EquipmentSharedIoModuleRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$EquipmentSystemIoControllerAllOf = Initialize-IntersightEquipmentSystemIoControllerAllOf  -ClassId null `
 -ObjectType null `
 -ChassisId null `
 -ConnectionPath null `
 -ConnectionStatus null `
 -Description null `
 -ManagingInstance null `
 -OperState null `
 -PartNumber null `
 -VarPid null `
 -SystemIoControllerId null `
 -Cmc null `
 -EquipmentChassis null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null `
 -SharedIoModule null
```

- Convert the resource to JSON
```powershell
$EquipmentSystemIoControllerAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

