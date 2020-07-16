# CondHclStatusJobAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ManagedObject** | [**InventoryBaseRelationship**](InventoryBaseRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightCondHclStatusJobAllOf  -ManagedObject null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

