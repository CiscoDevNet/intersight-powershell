# EtherPhysicalPortAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "ether.PhysicalPort"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "ether.PhysicalPort"]
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
$EtherPhysicalPortAllOf = Initialize-IntersightEtherPhysicalPortAllOf  -ClassId null `
 -ObjectType null `
 -AdminSpeed null `
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
$EtherPhysicalPortAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

