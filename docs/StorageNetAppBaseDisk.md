# StorageNetAppBaseDisk
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.NetAppBaseDisk"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.NetAppBaseDisk"]
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
**DeviceMoId** | **String** | The database identifier of the registered device of an object. | [optional] [readonly] 
**Dn** | **String** | The Distinguished Name unambiguously identifies an object in the system. | [optional] [readonly] 
**Rn** | **String** | The Relative Name uniquely identifies an object within a given context. | [optional] [readonly] 
**Model** | **String** | This field identifies the model of the given component. | [optional] [readonly] 
**Revision** | **String** | This field identifies the revision of the given component. | [optional] [readonly] 
**Serial** | **String** | This field identifies the serial of the given component. | [optional] [readonly] 
**Vendor** | **String** | This field identifies the vendor of the given component. | [optional] [readonly] 
**Name** | **String** | Disk name available in storage array. | [optional] [readonly] 
**PartNumber** | **String** | Storage disk part number. | [optional] [readonly] 
**Protocol** | **String** | Storage protocol used in disk for communication. Possible values are SAS, SATA and NVMe. * &#x60;Unknown&#x60; - Disk protocol is unknown. * &#x60;SAS&#x60; - Serial Attached SCSI protocol (SAS) used in disk. * &#x60;NVMe&#x60; - Non-volatile memory express (NVMe) protocol used in disk. * &#x60;SATA&#x60; - Serial Advanced Technology Attachment (SATA) used in disk. | [optional] [readonly] [default to "Unknown"]
**Speed** | **Int64** | Disk speed for read or write operation measured in rpm. | [optional] [readonly] 
**Status** | **String** | Storage disk health status. * &#x60;Unknown&#x60; - Component status is not available. * &#x60;Ok&#x60; - Component is healthy and no issues found. * &#x60;Degraded&#x60; - Functioning, but not at full capability due to a non-fatal failure. * &#x60;Critical&#x60; - Not functioning or requiring immediate attention. * &#x60;Offline&#x60; - Component is installed, but powered off. * &#x60;Identifying&#x60; - Component is in initialization process. * &#x60;NotAvailable&#x60; - Component is not installed or not available. * &#x60;Updating&#x60; - Software update is in progress. * &#x60;Unrecognized&#x60; - Component is not recognized. It may be because the component is not installed properly or it is not supported. | [optional] [readonly] [default to "Unknown"]
**StorageUtilization** | [**StorageBaseCapacity**](StorageBaseCapacity.md) |  | [optional] 
**Type** | **String** | Storage disk type - it can be SSD, HDD, NVRAM. * &#x60;Unknown&#x60; - Default unknown disk type. * &#x60;SSD&#x60; - Storage disk with Solid state disk. * &#x60;HDD&#x60; - Storage disk with Hard disk drive. * &#x60;NVRAM&#x60; - Storage disk with Non-volatile random-access memory type. * &#x60;SATA&#x60; - Disk drive implementation with Serial Advanced Technology Attachment (SATA). * &#x60;BSAS&#x60; - Bridged SAS-SATA disks with added hardware to enable them to be plugged into a SAS-connected storage shelf. * &#x60;FC&#x60; - Storage disk with Fiber Channel. * &#x60;FSAS&#x60; - Near Line SAS. NL-SAS drives are enterprise SATA drives with a SAS interface, head, media, androtational speed of traditional enterprise-class SATA drives with the fully capable SAS interfacetypical for classic SAS drives. * &#x60;LUN&#x60; - Logical Unit Number refers to a logical disk. * &#x60;MSATA&#x60; - SATA disk in multi-disk carrier storage shelf. * &#x60;SAS&#x60; - Storage disk with serial attached SCSI. * &#x60;VMDISK&#x60; - Virtual machine Data Disk. | [optional] [readonly] [default to "Unknown"]
**Version** | **String** | Storage disk version number. | [optional] [readonly] 
**BaseDiskModel** | **String** | NetApp base disk model. | [optional] [readonly] 
**ContainerType** | **String** | Supported container type for NetApp disk. * &#x60;Unknown&#x60; - Container is currently unknown. This is the default setting. * &#x60;Aggregate&#x60; - Disk is used as a physical disk in an aggregate. * &#x60;Broken&#x60; - Disk is in broken pool. * &#x60;Label Maintenance&#x60; - Disk is in online label maintenance list. * &#x60;Foreign&#x60; - Array LUN has been marked foreign. * &#x60;Maintenance&#x60; - Disk is in maintenance center. * &#x60;Mediator&#x60; - A mediator disk is a disk used on non-shared HA systems hosted by an external node which is used to communicate the viability of the storage failover between non-shared HA nodes. * &#x60;Shared&#x60; - Disk is partitioned or in a storage pool. * &#x60;Remote&#x60; - Disk belongs to a remote cluster. * &#x60;Spare&#x60; - Disk is a spare disk. * &#x60;Unassigned&#x60; - Disk ownership has not been assigned. * &#x60;Unsupported&#x60; - Disk is not supported. | [optional] [readonly] [default to "Unknown"]
**DiskType** | **String** | Type of the NetApp disk. * &#x60;Unknown&#x60; - Default unknown disk type. * &#x60;SSDNVM&#x60; - Solid state disk with Non-Volatile Memory Express protocol enabled. * &#x60;ATA&#x60; - Advanced Technology Attachment is a type of disk drive that integrates the drive controller directly on the drive itself. * &#x60;FCAL&#x60; - For the FC-AL disk connection type, disk shelves are connected to the controller in a loop * &#x60;BSAS&#x60; - Bridged SAS-SATA disks with added hardware to enable them to be plugged into a SAS-connected storage shelf. * &#x60;FSAS&#x60; - Near Line SAS. NL-SAS drives are enterprise SATA drives with a SAS interface, head, media, and rotational speed of traditional enterprise-class SATA drives with the fully capable SAS interface typical for classic SAS drives. * &#x60;LUN&#x60; - Logical Unit Number refers to a logical disk. * &#x60;SAS&#x60; - Storage disk with serial attached SCSI. * &#x60;MSATA&#x60; - SATA disk in multi-disk carrier storage shelf. * &#x60;SSD&#x60; - Storage disk with Solid state disk. * &#x60;VMDISK&#x60; - Virtual machine Data Disk. | [optional] [readonly] [default to "Unknown"]
**State** | **String** | Current state of the NetApp disk. * &#x60;Present&#x60; - Storage disk state type is present. * &#x60;Copy&#x60; - Storage disk state type is copy. * &#x60;Broken&#x60; - Storage disk state type is broken. * &#x60;Maintenance&#x60; - Storage disk state type is maintenance. * &#x60;Partner&#x60; - Storage disk state type is partner. * &#x60;Pending&#x60; - Storage disk state type is pending. * &#x60;Reconstructing&#x60; - Storage disk state type is reconstructing. * &#x60;Removed&#x60; - Storage disk state type is removed. * &#x60;Spare&#x60; - Storage disk state type is spare. * &#x60;Unfail&#x60; - Storage disk state type is unfail. * &#x60;Zeroing&#x60; - Storage disk state type is zeroing. | [optional] [readonly] [default to "Present"]
**Uuid** | **String** | Uuid of  NetApp Disk. | [optional] [readonly] 
**Array** | [**StorageNetAppClusterRelationship**](StorageNetAppClusterRelationship.md) |  | [optional] 
**ArrayController** | [**StorageNetAppNodeRelationship**](StorageNetAppNodeRelationship.md) |  | [optional] 
**DiskPool** | [**StorageNetAppAggregateRelationship[]**](StorageNetAppAggregateRelationship.md) | An array of relationships to storageNetAppAggregate resources. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$StorageNetAppBaseDisk = Initialize-IntersightStorageNetAppBaseDisk  -ClassId null `
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
 -DeviceMoId null `
 -Dn null `
 -Rn null `
 -Model null `
 -Revision null `
 -Serial null `
 -Vendor null `
 -Name null `
 -PartNumber null `
 -Protocol null `
 -Speed null `
 -Status null `
 -StorageUtilization null `
 -Type null `
 -Version null `
 -BaseDiskModel null `
 -ContainerType null `
 -DiskType null `
 -State null `
 -Uuid null `
 -Array null `
 -ArrayController null `
 -DiskPool null
```

- Convert the resource to JSON
```powershell
$StorageNetAppBaseDisk | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

