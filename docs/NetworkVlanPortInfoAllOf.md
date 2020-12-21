# NetworkVlanPortInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "network.VlanPortInfo"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "network.VlanPortInfo"]
**AccessVlanPortCount** | **Int64** | The number of available VLAN access ports on a Fabric Interconnect. | [optional] [readonly] 
**BorderVlanPortCount** | **Int64** | The number of available VLAN border ports on a Fabric Interconnect. | [optional] [readonly] 
**CompressedOptimizationSetsValue** | **Int64** | The number of compressed VLAN Group count on a Fabric Interconnect calculated by VLAN port group library. | [optional] 
**CompressedVlanPortCount** | **String** | The number of compressed VLAN ports on a Fabric Interconnect. | [optional] [readonly] 
**CompressedVlanPortCountValue** | **Int64** | The number of compressed VLAN port count on a Fabric Interconnect calculated by VLAN port group library. | [optional] 
**TotalVlanPortCount** | **Int64** | The total number of VLAN ports on a Fabric Interconnect. | [optional] [readonly] 
**UncompressedVlanPortCount** | **String** | The number of uncompressed VLAN ports on a Fabric Interconnect. | [optional] [readonly] 
**UncompressedVlanPortCountValue** | **Int64** | The number of uncompressed VLAN port count on a Fabric Interconnect calculated by VLAN port group library. | [optional] 
**VlanPortLimit** | **Int64** | The maximum number of VLAN ports allowed on a Fabric Interconnect. | [optional] [readonly] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**NetworkElement** | [**NetworkElementRelationship**](NetworkElementRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$NetworkVlanPortInfoAllOf = Initialize-IntersightNetworkVlanPortInfoAllOf  -ClassId null `
 -ObjectType null `
 -AccessVlanPortCount null `
 -BorderVlanPortCount null `
 -CompressedOptimizationSetsValue null `
 -CompressedVlanPortCount null `
 -CompressedVlanPortCountValue null `
 -TotalVlanPortCount null `
 -UncompressedVlanPortCount null `
 -UncompressedVlanPortCountValue null `
 -VlanPortLimit null `
 -InventoryDeviceInfo null `
 -NetworkElement null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$NetworkVlanPortInfoAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

