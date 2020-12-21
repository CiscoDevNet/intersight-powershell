# StorageBaseArrayDiskAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**Name** | **String** | Disk name available in storage array. | [optional] [readonly] 
**PartNumber** | **String** | Storage disk part number. | [optional] [readonly] 
**Protocol** | **String** | Storage protocol used in disk for communication. Possible values are SAS, SATA and NVMe. * &#x60;Unknown&#x60; - Disk protocol is unknown. * &#x60;SAS&#x60; - Serial Attached SCSI protocol (SAS) used in disk. * &#x60;NVMe&#x60; - Non-volatile memory express (NVMe) protocol used in disk. * &#x60;SATA&#x60; - Serial Advanced Technology Attachment (SATA) used in disk. | [optional] [readonly] [default to "Unknown"]
**Speed** | **Int64** | Disk speed for read or write operation measured in rpm. | [optional] [readonly] 
**Status** | **String** | Storage disk health status. * &#x60;Unknown&#x60; - Component status is not available. * &#x60;Ok&#x60; - Component is healthy and no issues found. * &#x60;Degraded&#x60; - Functioning, but not at full capability due to a non-fatal failure. * &#x60;Critical&#x60; - Not functioning or requiring immediate attention. * &#x60;Offline&#x60; - Component is installed, but powered off. * &#x60;Identifying&#x60; - Component is in initialization process. * &#x60;NotAvailable&#x60; - Component is not installed or not available. * &#x60;Updating&#x60; - Software update is in progress. * &#x60;Unrecognized&#x60; - Component is not recognized. It may be because the component is not installed properly or it is not supported. | [optional] [readonly] [default to "Unknown"]
**StorageUtilization** | [**StorageBaseCapacity**](StorageBaseCapacity.md) |  | [optional] 
**Type** | **String** | Storage disk type - it can be SSD, HDD, NVRAM. * &#x60;Unknown&#x60; - Default unknown disk type. * &#x60;SSD&#x60; - Storage disk with Solid state disk. * &#x60;HDD&#x60; - Storage disk with Hard disk drive. * &#x60;NVRAM&#x60; - Storage disk with Non-volatile random-access memory type. * &#x60;SATA&#x60; - Disk drive implementation with Serial Advanced Technology Attachment (SATA). * &#x60;BSAS&#x60; - Bridged SAS-SATA disks with added hardware to enable them to be plugged into a SAS-connected storage shelf. * &#x60;FC&#x60; - Storage disk with Fiber Channel. * &#x60;FSAS&#x60; - Near Line SAS. NL-SAS drives are enterprise SATA drives with a SAS interface, head, media, androtational speed of traditional enterprise-class SATA drives with the fully capable SAS interfacetypical for classic SAS drives. * &#x60;LUN&#x60; - Logical Unit Number refers to a logical disk. * &#x60;MSATA&#x60; - SATA disk in multi-disk carrier storage shelf. * &#x60;SAS&#x60; - Storage disk with serial attached SCSI. * &#x60;VMDISK&#x60; - Virtual machine Data Disk. | [optional] [readonly] [default to "Unknown"]
**Version** | **String** | Storage disk version number. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$StorageBaseArrayDiskAllOf = Initialize-IntersightStorageBaseArrayDiskAllOf  -ClassId null `
 -ObjectType null `
 -Name null `
 -PartNumber null `
 -Protocol null `
 -Speed null `
 -Status null `
 -StorageUtilization null `
 -Type null `
 -Version null
```

- Convert the resource to JSON
```powershell
$StorageBaseArrayDiskAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

