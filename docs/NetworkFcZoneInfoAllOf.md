# NetworkFcZoneInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserZoneCount** | **Int64** | The number of Fibre Channel user zones defined on a Fabric Interconnect. | [optional] [readonly] 
**UserZoneLimit** | **Int64** | The maximum number of Fibre Channel user zones allowed on a Fabric Interconnect. | [optional] [readonly] 
**ZoneCount** | **Int64** | The number of Fibre Channel zones defined on a Fabric Interconnect. | [optional] [readonly] 
**ZoneLimit** | **Int64** | The maximum number of Fibre Channel zones allowed on a Fabric Interconnect. | [optional] [readonly] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**NetworkElement** | [**NetworkElementRelationship**](NetworkElementRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightNetworkFcZoneInfoAllOf  -UserZoneCount null `
 -UserZoneLimit null `
 -ZoneCount null `
 -ZoneLimit null `
 -InventoryDeviceInfo null `
 -NetworkElement null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

