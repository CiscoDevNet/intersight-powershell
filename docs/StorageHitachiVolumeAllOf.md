# StorageHitachiVolumeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.HitachiVolume"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.HitachiVolume"]
**Attributes** | **String[]** |  | [optional] 
**ClprId** | **Int64** | CLPR (Cache Logical Partition) number of this volume. | [optional] [readonly] 
**DataReductionMode** | **String** | Setting of the capacity saving function (dedupe and compression). * &#x60;N/A&#x60; - Not available. * &#x60;compression&#x60; - The capacity saving function (compression) is enabled. * &#x60;compression_deduplication&#x60; - The capacity saving function (compression and deduplication) is enabled. * &#x60;disabled&#x60; - The capacity saving function (compression and deduplication) is disabled. | [optional] [readonly] [default to "N/A"]
**DataReductionStatus** | **String** | Status of the capacity saving function. * &#x60;N/A&#x60; - Not available. * &#x60;ENABLED&#x60; - The capacity saving function is enabled. * &#x60;DISABLED&#x60; - The capacity saving function is disabled. * &#x60;ENABLING&#x60; - The capacity saving function is being enabled. * &#x60;REHYDRATING&#x60; - The capacity saving function is being disabled. * &#x60;DELETING&#x60; - The volumes for which the capacity saving function is enabled are being deleted. * &#x60;FAILED&#x60; - An attempt to enable the capacity saving function failed. | [optional] [readonly] [default to "N/A"]
**DriveType** | **String** | Code indicating the drive type of the drive belonging to the volume. | [optional] [readonly] 
**EmulationType** | **String** | The volume emulation type or the volume status information. * &#x60;N/A&#x60; - Not available. * &#x60;NOT DEFINED&#x60; - The volume is not implemented. * &#x60;DEFINING&#x60; - The volume is being created. * &#x60;REMOVING&#x60; - The volume is being removed. * &#x60;OPEN-V&#x60; - To be provided by Hitachi. | [optional] [readonly] [default to "N/A"]
**IsFullAllocationEnabled** | **Boolean** | Whether pages are reserved by the FullAllocation functionality. | [optional] [readonly] 
**Label** | **String** | Label of the volume, as configured in the storage array. | [optional] [readonly] 
**NumOfPaths** | **Int64** | Number of paths set for the volume. | [optional] [readonly] 
**ParityGroupIds** | **String[]** |  | [optional] 
**PoolId** | **String** | ID of the pool with which the volume is associated. | [optional] [readonly] 
**RaidLevel** | **String** | RAID level for the volume. * &#x60;N/A&#x60; - Not available. * &#x60;RAID1&#x60; - RAID1. * &#x60;RAID5&#x60; - RAID5. * &#x60;RAID6&#x60; - RAID6. | [optional] [readonly] [default to "N/A"]
**RaidType** | **String** | RAID type drive configuration. | [optional] [readonly] 
**Status** | **String** | Status information of the volume. * &#x60;N/A&#x60; - Not available. * &#x60;NML&#x60; - The volume is in normal status. * &#x60;BLK&#x60; - The volume is blocked. * &#x60;BSY&#x60; - The volume status is being changed. * &#x60;Unknown&#x60; - The volume status is unknown (not supported). | [optional] [readonly] [default to "N/A"]
**Array** | [**StorageHitachiArrayRelationship**](StorageHitachiArrayRelationship.md) |  | [optional] 
**ParityGroups** | [**StorageHitachiParityGroupRelationship[]**](StorageHitachiParityGroupRelationship.md) | An array of relationships to storageHitachiParityGroup resources. | [optional] [readonly] 
**Pool** | [**StorageHitachiPoolRelationship**](StorageHitachiPoolRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$StorageHitachiVolumeAllOf = Initialize-IntersightStorageHitachiVolumeAllOf  -ClassId null `
 -ObjectType null `
 -Attributes null `
 -ClprId null `
 -DataReductionMode null `
 -DataReductionStatus null `
 -DriveType null `
 -EmulationType null `
 -IsFullAllocationEnabled null `
 -Label null `
 -NumOfPaths null `
 -ParityGroupIds null `
 -PoolId null `
 -RaidLevel null `
 -RaidType null `
 -Status null `
 -Array null `
 -ParityGroups null `
 -Pool null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$StorageHitachiVolumeAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

