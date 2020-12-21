# NetworkFcZoneInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "network.FcZoneInfo"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "network.FcZoneInfo"]
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
$NetworkFcZoneInfoAllOf = Initialize-IntersightNetworkFcZoneInfoAllOf  -ClassId null `
 -ObjectType null `
 -UserZoneCount null `
 -UserZoneLimit null `
 -ZoneCount null `
 -ZoneLimit null `
 -InventoryDeviceInfo null `
 -NetworkElement null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$NetworkFcZoneInfoAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

