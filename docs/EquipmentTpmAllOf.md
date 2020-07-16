# EquipmentTpmAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActivationStatus** | **String** | Identifies the activation status of the TPM. | [optional] [readonly] 
**AdminState** | **String** | Identifies the admin configured state of the TPM. | [optional] [readonly] 
**Ownership** | **String** | Identifies the ownership information of the TPM. | [optional] [readonly] 
**Presence** | **String** | Identifies the presence of the trusted platform module. | [optional] [readonly] 
**TpmId** | **Int64** | Enter  the ID of the trusted platform module. | [optional] [readonly] 
**Version** | **String** | Identifies the revision of the Trusted Platform Module. | [optional] [readonly] 
**ComputeBoard** | [**ComputeBoardRelationship**](ComputeBoardRelationship.md) |  | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightEquipmentTpmAllOf  -ActivationStatus null `
 -AdminState null `
 -Ownership null `
 -Presence null `
 -TpmId null `
 -Version null `
 -ComputeBoard null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

