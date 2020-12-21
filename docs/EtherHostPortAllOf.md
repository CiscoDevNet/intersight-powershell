# EtherHostPortAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "ether.HostPort"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "ether.HostPort"]
**ModuleId** | **Int64** | Fabric extender identifier for this port. | [optional] 
**Speed** | **String** | Host Port Speed of IO card or fabric extender. | [optional] [readonly] 
**EquipmentIoCardBase** | [**EquipmentIoCardBaseRelationship**](EquipmentIoCardBaseRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$EtherHostPortAllOf = Initialize-IntersightEtherHostPortAllOf  -ClassId null `
 -ObjectType null `
 -ModuleId null `
 -Speed null `
 -EquipmentIoCardBase null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$EtherHostPortAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

