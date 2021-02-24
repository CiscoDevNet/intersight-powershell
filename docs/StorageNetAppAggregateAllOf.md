# StorageNetAppAggregateAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.NetAppAggregate"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.NetAppAggregate"]
**AggregateType** | **String** | Storage disk type for NetApp aggregate. * &#x60;HDD&#x60; - Hard Disk Drive. * &#x60;Hybrid&#x60; - Solid State Hard Disk Drive. * &#x60;Hybrid (Flash Pool)&#x60; - SSHD in a flash pool. * &#x60;SSD&#x60; - Solid State Disk. * &#x60;SSD (FabricPool)&#x60; - SSD in a flash pool. * &#x60;VMDisk (SDS)&#x60; - Storage disk with Hard disk drive. * &#x60;VMDisk (FabricPool)&#x60; - Storage disk with Non-volatile random-access memory drives. * &#x60;LUN (FlexArray)&#x60; - LUN as a disk. * &#x60;Not Mapped&#x60; - Storage disk is not mapped. | [optional] [readonly] [default to "HDD"]
**RaidSize** | **Int64** | Size of the RAID group represented by number of disks in the group. | [optional] [readonly] 
**RaidType** | **String** | The RAID configuration type. * &#x60;Unknown&#x60; - Default unknown RAID type. * &#x60;RAID0&#x60; - RAID0 splits (&quot;&quot;stripes&quot;&quot;) data evenly across two or more disks, without parity information. * &#x60;RAID1&#x60; - RAID1 requires a minimum of two disks to work, and provides data redundancy and failover. * &#x60;RAID4&#x60; - RAID4 stripes block level data and dedicates a disk to parity. * &#x60;RAID5&#x60; - RAID5  distributes striping and parity at a block level. * &#x60;RAID6&#x60; - RAID6 level operates like RAID5 with distributed parity and striping. * &#x60;RAID10&#x60; - RAID10 requires a minimum of four disks in the array. It stripes across disks for higher performance, and mirrors for redundancy. * &#x60;RAIDDP&#x60; - RAIDDP uses up to two spare disks to replace and reconstruct the data from up to two simultaneously failed disks within the RAID group. * &#x60;RAIDTEC&#x60; - With RAIDTEC protection, use up to three spare disks to replace and reconstruct the data from up to three simultaneously failed disks within the RAID group. | [optional] [readonly] [default to "Unknown"]
**State** | **String** | Current state of the NetApp aggregate. * &#x60;Unknown&#x60; - Specifies that the aggregate is discovered, but the aggregate information is not yet retrieved by the Unified Manager server. * &#x60;Online&#x60; - Aggregate is ready and available. * &#x60;Onlining&#x60; - Transitioning online. * &#x60;Offline&#x60; - Aggregate is unavailable. * &#x60;Offlining&#x60; - Transitioning offline. * &#x60;Relocating&#x60; - The aggregate is being relocated. * &#x60;Restricted&#x60; - Limited operations (e.g., parity reconstruction) are allowed, but data access is not allowed. * &#x60;Failed&#x60; - The aggregate cannot be brought online. * &#x60;Inconsistent&#x60; - The aggregate has been marked corrupted; contact technical support. * &#x60;Unmounted&#x60; - The aggregate is not mounted. | [optional] [readonly] [default to "Unknown"]
**Uuid** | **String** | Uuid of  NetApp Aggregate. | [optional] [readonly] 
**ArrayController** | [**StorageNetAppNodeRelationship**](StorageNetAppNodeRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$StorageNetAppAggregateAllOf = Initialize-IntersightStorageNetAppAggregateAllOf  -ClassId null `
 -ObjectType null `
 -AggregateType null `
 -RaidSize null `
 -RaidType null `
 -State null `
 -Uuid null `
 -ArrayController null
```

- Convert the resource to JSON
```powershell
$StorageNetAppAggregateAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

