# StorageHitachiParityGroup
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.HitachiParityGroup"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.HitachiParityGroup"]
**AccountMoid** | **String** | The Account ID for this managed object. | [optional] [readonly] 
**CreateTime** | **System.DateTime** | The time when this managed object was created. | [optional] [readonly] 
**DomainGroupMoid** | **String** | The DomainGroup ID for this managed object. | [optional] [readonly] 
**ModTime** | **System.DateTime** | The time when this managed object was last modified. | [optional] [readonly] 
**Moid** | **String** | The unique identifier of this Managed Object instance. | [optional] 
**Owners** | **String[]** |  | [optional] 
**SharedScope** | **String** | Intersight provides pre-built workflows, tasks and policies to end users through global catalogs. Objects that are made available through global catalogs are said to have a &#39;shared&#39; ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs. | [optional] [readonly] 
**Tags** | [**MoTag[]**](MoTag.md) |  | [optional] 
**VersionContext** | [**MoVersionContext**](MoVersionContext.md) |  | [optional] 
**Var0ClusterReplicationNetworkPolicy** | [**HyperflexClusterReplicationNetworkPolicyRelationship**](HyperflexClusterReplicationNetworkPolicyRelationship.md) |  | [optional] 
**Ancestors** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**Parent** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**PermissionResources** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**DisplayNames** | [**System.Collections.Hashtable**](Array.md) | A set of display names for the MO resource. These names are calculated based on other properties of the MO and potentially properties of Ancestor MOs. Displaynames are intended as a way to provide a normalized user appropriate name for an MO, especially for MOs which do not have a &#39;Name&#39; property, which is the case for much of the inventory discovered from managed targets. There are a limited number of keys, currently &#39;short&#39; and &#39;hierarchical&#39;. The value is an array and clients should use the first element of the array. | [optional] [readonly] 
**Level** | **String** | The RAID level associated with the group of disks. * &#x60;Unknown&#x60; - Default unknown RAID type. * &#x60;RAID0&#x60; - RAID0 splits (&quot;&quot;stripes&quot;&quot;) data evenly across two or more disks, without parity information. * &#x60;RAID1&#x60; - RAID1 requires a minimum of two disks to work, and provides data redundancy and failover. * &#x60;RAID4&#x60; - RAID4 stripes block level data and dedicates a disk to parity. * &#x60;RAID5&#x60; - RAID5  distributes striping and parity at a block level. * &#x60;RAID6&#x60; - RAID6 level operates like RAID5 with distributed parity and striping. * &#x60;RAID10&#x60; - RAID10 requires a minimum of four disks in the array. It stripes across disks for higher performance, and mirrors for redundancy. * &#x60;RAIDDP&#x60; - RAIDDP uses up to two spare disks to replace and reconstruct the data from up to two simultaneously failed disks within the RAID group. * &#x60;RAIDTEC&#x60; - With RAIDTEC protection, use up to three spare disks to replace and reconstruct the data from up to three simultaneously failed disks within the RAID group. | [optional] [readonly] [default to "Unknown"]
**Name** | **String** | Human readable name of the RAID group. | [optional] [readonly] 
**StorageUtilization** | [**StorageBaseCapacity**](StorageBaseCapacity.md) |  | [optional] 
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
$StorageHitachiParityGroup = Initialize-IntersightStorageHitachiParityGroup  -ClassId null `
 -ObjectType null `
 -AccountMoid null `
 -CreateTime null `
 -DomainGroupMoid null `
 -ModTime null `
 -Moid null `
 -Owners null `
 -SharedScope null `
 -Tags null `
 -VersionContext null `
 -Var0ClusterReplicationNetworkPolicy null `
 -Ancestors null `
 -Parent null `
 -PermissionResources null `
 -DisplayNames null `
 -Level null `
 -Name null `
 -StorageUtilization null `
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
$StorageHitachiParityGroup | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

