# TopSystemAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Ipv4Address** | **String** | The IPv4 address of system. | [optional] [readonly] 
**Ipv6Address** | **String** | The IPv6 address of system. | [optional] [readonly] 
**Mode** | **String** | The current mode of the system. | [optional] [readonly] 
**Name** | **String** | The admin configured name of the system. | [optional] [readonly] 
**TimeZone** | **String** | The operational timezone of the system, empty indicates no timezone has been set specifically. | [optional] 
**ComputeBlades** | [**ComputeBladeRelationship[]**](ComputeBladeRelationship.md) | An array of relationships to computeBlade resources. | [optional] 
**ComputeRackUnits** | [**ComputeRackUnitRelationship[]**](ComputeRackUnitRelationship.md) | An array of relationships to computeRackUnit resources. | [optional] [readonly] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**ManagementController** | [**ManagementControllerRelationship**](ManagementControllerRelationship.md) |  | [optional] 
**NetworkElements** | [**NetworkElementRelationship[]**](NetworkElementRelationship.md) | An array of relationships to networkElement resources. | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightTopSystemAllOf  -Ipv4Address null `
 -Ipv6Address null `
 -Mode null `
 -Name null `
 -TimeZone null `
 -ComputeBlades null `
 -ComputeRackUnits null `
 -InventoryDeviceInfo null `
 -ManagementController null `
 -NetworkElements null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

