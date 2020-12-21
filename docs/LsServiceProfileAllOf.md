# LsServiceProfileAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "ls.ServiceProfile"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "ls.ServiceProfile"]
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
$LsServiceProfileAllOf = Initialize-IntersightLsServiceProfileAllOf  -ClassId null `
 -ObjectType null `
 -AssignState null `
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
$LsServiceProfileAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

