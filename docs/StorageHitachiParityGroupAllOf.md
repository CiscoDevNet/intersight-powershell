# StorageHitachiParityGroupAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.HitachiParityGroup"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.HitachiParityGroup"]
**DiskSpeed** | **String** | Speed (rpm) of the disk belonging to the parity group. | [optional] [readonly] 
**DiskType** | **String** | Type of the disk belonging to the parity group. | [optional] [readonly] 
**IsAcceleratedCompressionEnabled** | **Boolean** | Value of the accelerated compression of the parity group. true, Accelerated compression for the parity group is enabled. false, Accelerated compression for the parity group is disabled. | [optional] [readonly] 
**IsCopyBackModeEnabled** | **Boolean** | Value of the copy back mode setting of the parity group. true, Copy back mode is enabled. false, Copy back mode is disabled. | [optional] [readonly] 
**IsEncryptionEnabled** | **Boolean** | Value of the encryption setting of the parity group. true, Encryption is enabled. false, Encryption is disabled. | [optional] [readonly] 
**Array** | [**StorageHitachiArrayRelationship**](StorageHitachiArrayRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$StorageHitachiParityGroupAllOf = Initialize-IntersightStorageHitachiParityGroupAllOf  -ClassId null `
 -ObjectType null `
 -DiskSpeed null `
 -DiskType null `
 -IsAcceleratedCompressionEnabled null `
 -IsCopyBackModeEnabled null `
 -IsEncryptionEnabled null `
 -Array null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$StorageHitachiParityGroupAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

