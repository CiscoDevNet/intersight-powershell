# EtherPhysicalPortAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdminSpeed** | **String** | Administratively configured speed for this port. | [optional] [readonly] 
**AdminState** | **String** | Administratively configured state (enabled/disabled) for this port. | [optional] [readonly] 
**AggregatePortId** | **Int64** | Breakout port member in the Fabric Interconnect. | [optional] [readonly] 
**LicenseGrace** | **String** | The number of days this port&#39;s license has been in Grace Period for. | [optional] [readonly] 
**LicenseState** | **String** | The state of the port&#39;s licensing. | [optional] [readonly] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**PortGroup** | [**PortGroupRelationship**](PortGroupRelationship.md) |  | [optional] 
**PortSubGroup** | [**PortSubGroupRelationship**](PortSubGroupRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightEtherPhysicalPortAllOf  -AdminSpeed null `
 -AdminState null `
 -AggregatePortId null `
 -LicenseGrace null `
 -LicenseState null `
 -InventoryDeviceInfo null `
 -PortGroup null `
 -PortSubGroup null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

