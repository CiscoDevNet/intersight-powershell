# StorageSasExpanderAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExpanderId** | **Int64** | Unique Identifier of the storage expander. | [optional] [readonly] 
**Name** | **String** | The name  of the installed storage expander. | [optional] 
**OperState** | **String** | The operational state of the storage expander. | [optional] [readonly] 
**Operability** | **String** | The operability status of the storage expander. | [optional] [readonly] 
**Presence** | **String** | The availability of the storage expander. | [optional] [readonly] 
**SasAddress** | **String** | The SAS address of the SAS expander. | [optional] [readonly] 
**ComputeRackUnit** | [**ComputeRackUnitRelationship**](ComputeRackUnitRelationship.md) |  | [optional] 
**Controller** | [**ManagementControllerRelationship**](ManagementControllerRelationship.md) |  | [optional] 
**EquipmentChassis** | [**EquipmentChassisRelationship**](EquipmentChassisRelationship.md) |  | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightStorageSasExpanderAllOf  -ExpanderId null `
 -Name null `
 -OperState null `
 -Operability null `
 -Presence null `
 -SasAddress null `
 -ComputeRackUnit null `
 -Controller null `
 -EquipmentChassis null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

