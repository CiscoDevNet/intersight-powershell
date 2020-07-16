# NetworkVlanPortInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessVlanPortCount** | **Int64** | The number of available VLAN access ports on a Fabric Interconnect. | [optional] [readonly] 
**BorderVlanPortCount** | **Int64** | The number of available VLAN border ports on a Fabric Interconnect. | [optional] [readonly] 
**CompressedVlanPortCount** | **String** | The number of compressed VLAN ports on a Fabric Interconnect. | [optional] [readonly] 
**UncompressedVlanPortCount** | **String** | The number of uncompressed VLAN ports on a Fabric Interconnect. | [optional] [readonly] 
**VlanPortLimit** | **Int64** | The maximum number of VLAN ports allowed on a Fabric Interconnect. | [optional] [readonly] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**NetworkElement** | [**NetworkElementRelationship**](NetworkElementRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightNetworkVlanPortInfoAllOf  -AccessVlanPortCount null `
 -BorderVlanPortCount null `
 -CompressedVlanPortCount null `
 -UncompressedVlanPortCount null `
 -VlanPortLimit null `
 -InventoryDeviceInfo null `
 -NetworkElement null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

