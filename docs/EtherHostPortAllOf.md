# EtherHostPortAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ModuleId** | **Int64** | Fabric extender identifier for this port. | [optional] 
**Speed** | **String** | Host Port Speed of IO card or fabric extender. | [optional] [readonly] 
**EquipmentIoCardBase** | [**EquipmentIoCardBaseRelationship**](EquipmentIoCardBaseRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightEtherHostPortAllOf  -ModuleId null `
 -Speed null `
 -EquipmentIoCardBase null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

