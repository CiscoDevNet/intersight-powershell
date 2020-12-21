# InventoryDnMoBindingAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "inventory.DnMoBinding"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "inventory.DnMoBinding"]
**Dn** | **String** | The Distinguished Name for this object, used to uniquely identify this object. | [optional] [readonly] 
**TargetMoId** | **String** | The MO ID of the target MO for this particular Distinguished Name (dn). | [optional] [readonly] 
**TargetMoType** | **String** | The type of the target MO for this particular Distinguished Name (dn). | [optional] [readonly] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$InventoryDnMoBindingAllOf = Initialize-IntersightInventoryDnMoBindingAllOf  -ClassId null `
 -ObjectType null `
 -Dn null `
 -TargetMoId null `
 -TargetMoType null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$InventoryDnMoBindingAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

