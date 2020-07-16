# EquipmentSharedIoModuleAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConfigState** | **String** | This field identifies the configuration state for this SIOM Unit. | [optional] [readonly] 
**Discovery** | **String** | This field identifies the discovery state of SIOM. | [optional] [readonly] 
**MacOfSharedIomAside** | **String** | This field identifies the MAC of IOM-A side. | [optional] [readonly] 
**MacOfSharedIomBside** | **String** | This field identifies the MAC of IOM-B side. | [optional] [readonly] 
**OperState** | **String** | This field identifies the SIOM operational state. | [optional] [readonly] 
**PartNumber** | **String** | This field identifies the Part Number for this SIOM Unit. | [optional] [readonly] 
**Reachability** | **String** | This field identifies the reachability to FI-A and B side. | [optional] [readonly] 
**UsrLbl** | **String** | User label configured for the SIOM. | [optional] [readonly] 
**Vid** | **String** | This field identifies the vendor id for this SIOM Unit. | [optional] [readonly] 
**Controller** | [**ManagementControllerRelationship**](ManagementControllerRelationship.md) |  | [optional] 
**EquipmentSystemIoController** | [**EquipmentSystemIoControllerRelationship**](EquipmentSystemIoControllerRelationship.md) |  | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**PortGroups** | [**PortGroupRelationship[]**](PortGroupRelationship.md) | An array of relationships to portGroup resources. | [optional] [readonly] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightEquipmentSharedIoModuleAllOf  -ConfigState null `
 -Discovery null `
 -MacOfSharedIomAside null `
 -MacOfSharedIomBside null `
 -OperState null `
 -PartNumber null `
 -Reachability null `
 -UsrLbl null `
 -Vid null `
 -Controller null `
 -EquipmentSystemIoController null `
 -InventoryDeviceInfo null `
 -PortGroups null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

