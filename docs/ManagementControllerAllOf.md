# ManagementControllerAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "management.Controller"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "management.Controller"]
**Model** | **String** | Model of the endpoint that houses the management controller. | [optional] [readonly] 
**AdapterUnit** | [**AdapterUnitRelationship**](AdapterUnitRelationship.md) |  | [optional] 
**ComputeBlade** | [**ComputeBladeRelationship**](ComputeBladeRelationship.md) |  | [optional] 
**ComputeRackUnit** | [**ComputeRackUnitRelationship**](ComputeRackUnitRelationship.md) |  | [optional] 
**EquipmentIoCardBase** | [**EquipmentIoCardBaseRelationship**](EquipmentIoCardBaseRelationship.md) |  | [optional] 
**EquipmentSharedIoModule** | [**EquipmentSharedIoModuleRelationship**](EquipmentSharedIoModuleRelationship.md) |  | [optional] 
**EquipmentSystemIoController** | [**EquipmentSystemIoControllerRelationship**](EquipmentSystemIoControllerRelationship.md) |  | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**ManagementInterfaces** | [**ManagementInterfaceRelationship[]**](ManagementInterfaceRelationship.md) | An array of relationships to managementInterface resources. | [optional] [readonly] 
**NetworkElement** | [**NetworkElementRelationship**](NetworkElementRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**RunningFirmware** | [**FirmwareRunningFirmwareRelationship[]**](FirmwareRunningFirmwareRelationship.md) | An array of relationships to firmwareRunningFirmware resources. | [optional] [readonly] 
**StorageSasExpander** | [**StorageSasExpanderRelationship**](StorageSasExpanderRelationship.md) |  | [optional] 
**TopSystem** | [**TopSystemRelationship**](TopSystemRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ManagementControllerAllOf = Initialize-IntersightManagementControllerAllOf  -ClassId null `
 -ObjectType null `
 -Model null `
 -AdapterUnit null `
 -ComputeBlade null `
 -ComputeRackUnit null `
 -EquipmentIoCardBase null `
 -EquipmentSharedIoModule null `
 -EquipmentSystemIoController null `
 -InventoryDeviceInfo null `
 -ManagementInterfaces null `
 -NetworkElement null `
 -RegisteredDevice null `
 -RunningFirmware null `
 -StorageSasExpander null `
 -TopSystem null
```

- Convert the resource to JSON
```powershell
$ManagementControllerAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

