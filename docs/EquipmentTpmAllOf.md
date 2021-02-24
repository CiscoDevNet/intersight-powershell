# EquipmentTpmAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "equipment.Tpm"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "equipment.Tpm"]
**ActivationStatus** | **String** | Identifies the activation status of the TPM. | [optional] [readonly] 
**AdminState** | **String** | Identifies the admin configured state of the TPM. | [optional] [readonly] 
**FirmwareVersion** | **String** | Firmware Version of the Trusted Platform Module. | [optional] 
**Ownership** | **String** | Identifies the ownership information of the TPM. | [optional] [readonly] 
**Presence** | **String** | Identifies the presence of the trusted platform module. | [optional] [readonly] 
**TpmId** | **Int64** | Enter  the ID of the trusted platform module. | [optional] [readonly] 
**Version** | **String** | Identifies the version of the Trusted Platform Module. | [optional] [readonly] 
**ComputeBoard** | [**ComputeBoardRelationship**](ComputeBoardRelationship.md) |  | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$EquipmentTpmAllOf = Initialize-IntersightEquipmentTpmAllOf  -ClassId null `
 -ObjectType null `
 -ActivationStatus null `
 -AdminState null `
 -FirmwareVersion null `
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
$EquipmentTpmAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

