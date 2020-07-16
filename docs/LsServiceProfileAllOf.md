# LsServiceProfileAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AssignState** | **String** | Assignment state of the service profile. | [optional] [readonly] 
**AssocState** | **String** | Association state of the service profile. | [optional] [readonly] 
**AssociatedServer** | **String** | Server to which the UCS Manager service profile is associated to. | [optional] [readonly] 
**ConfigState** | **String** | Configuration state of the service profile. | [optional] [readonly] 
**Name** | **String** | Name of the UCS Manager service profile. | [optional] [readonly] 
**OperState** | **String** | Operational state of the service profile. | [optional] [readonly] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightLsServiceProfileAllOf  -AssignState null `
 -AssocState null `
 -AssociatedServer null `
 -ConfigState null `
 -Name null `
 -OperState null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

