# StorageHitachiDiskAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.HitachiDisk"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.HitachiDisk"]
**DriveTypeCode** | **String** | Drive type code. | [optional] [readonly] 
**ParityGroupId** | **String** | Parity group number. When the drive does not belong to any parity group, an empty character string is output. | [optional] [readonly] 
**TypeDetail** | **String** | Drive type. * &#x60;N/A&#x60; - Not available. * &#x60;SAS&#x60; - SAS. * &#x60;SSD(MLC)&#x60; - SSD (MLC). * &#x60;SSD(FMC)&#x60; - SSD (FMC). * &#x60;SSD(FMD)&#x60; - SSD (FMD). * &#x60;SSD(SLC)&#x60; - SSD (SLC). * &#x60;SSD&#x60; - SSD. * &#x60;SSD(RI)&#x60; - SSD (RI). | [optional] [readonly] [default to "N/A"]
**Usage** | **String** | Purpose for which the drive is used. | [optional] [readonly] 
**Array** | [**StorageHitachiArrayRelationship**](StorageHitachiArrayRelationship.md) |  | [optional] 
**ParityGroup** | [**StorageHitachiParityGroupRelationship**](StorageHitachiParityGroupRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$StorageHitachiDiskAllOf = Initialize-IntersightStorageHitachiDiskAllOf  -ClassId null `
 -ObjectType null `
 -DriveTypeCode null `
 -ParityGroupId null `
 -TypeDetail null `
 -Usage null `
 -Array null `
 -ParityGroup null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$StorageHitachiDiskAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

