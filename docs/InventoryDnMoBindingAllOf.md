# InventoryDnMoBindingAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Dn** | **String** | The Distinguished Name for this object, used to uniquely identify this object. | [optional] [readonly] 
**TargetMoId** | **String** | The MO ID of the target MO for this particular Distinguished Name (dn). | [optional] [readonly] 
**TargetMoType** | **String** | The type of the target MO for this particular Distinguished Name (dn). | [optional] [readonly] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightInventoryDnMoBindingAllOf  -Dn null `
 -TargetMoId null `
 -TargetMoType null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

