# InventoryRequestAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Mos** | [**InventoryInventoryMo[]**](InventoryInventoryMo.md) |  | [optional] 
**Device** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightInventoryRequestAllOf  -Mos null `
 -Device null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

