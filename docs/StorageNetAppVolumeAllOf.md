# StorageNetAppVolumeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.NetAppVolume"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.NetAppVolume"]
**AutosizeMode** | **String** | The autosize mode for NetApp Volume. Modes can be off or grow or grow_shrink. * &#x60;off&#x60; - The volume will not grow or shrink in size in response to the amount of used space. * &#x60;grow&#x60; - The volume will automatically grow when used space in the volume is above the grow threshold. * &#x60;grow_shrink&#x60; - The volume will grow or shrink in size in response to the amount of used space. | [optional] [readonly] [default to "off"]
**ExportPolicyName** | **String** | Name of Export Policy. | [optional] [readonly] 
**SnapshotPolicyName** | **String** | Name of Snapshot Policy. | [optional] [readonly] 
**SnapshotPolicyUuid** | **String** | Name of Snapshot Policy. | [optional] [readonly] 
**SnapshotUtilizedCapacity** | **Int64** | The total space used by Snapshot copies in the volume represented in bytes. | [optional] [readonly] 
**State** | **String** | The current state of a NetApp volume. * &#x60;offline&#x60; - Read and write access to the volume is not allowed. * &#x60;online&#x60; - Read and write access to the volume is allowed. * &#x60;error&#x60; - Storage volume state of error type. * &#x60;mixed&#x60; - The constituents of a FlexGroup volume are not all in the same state. | [optional] [readonly] [default to "offline"]
**Type** | **String** | NetApp volume type. The volume type can be Read-write or Data-protection, Load-sharing, or Data-cache. * &#x60;data-protection&#x60; - Prevents modification of the data on the Volume. * &#x60;read-write&#x60; - Data on the Volume can be modified. * &#x60;load-sharing&#x60; - Load Sharing. | [optional] [readonly] [default to "data-protection"]
**Uuid** | **String** | UUID of NetApp Volume. | [optional] [readonly] 
**Array** | [**StorageNetAppClusterRelationship**](StorageNetAppClusterRelationship.md) |  | [optional] 
**DiskPool** | [**StorageNetAppAggregateRelationship[]**](StorageNetAppAggregateRelationship.md) | An array of relationships to storageNetAppAggregate resources. | [optional] [readonly] 
**Tenant** | [**StorageNetAppStorageVmRelationship**](StorageNetAppStorageVmRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$StorageNetAppVolumeAllOf = Initialize-IntersightStorageNetAppVolumeAllOf  -ClassId null `
 -ObjectType null `
 -AutosizeMode null `
 -ExportPolicyName null `
 -SnapshotPolicyName null `
 -SnapshotPolicyUuid null `
 -SnapshotUtilizedCapacity null `
 -State null `
 -Type null `
 -Uuid null `
 -Array null `
 -DiskPool null `
 -Tenant null
```

- Convert the resource to JSON
```powershell
$StorageNetAppVolumeAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

