# HyperflexVmDiskAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.VmDisk"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.VmDisk"]
**BootOrder** | **Int64** | Boot order for this disk. | [optional] [readonly] 
**Bus** | **String** | Virtual machine brige name of interface. * &#x60;virtio&#x60; - Disk uses the same paths as a bare-metal system. This simplifies physical-to-virtual and virtual-to-virtual migration. * &#x60;sata&#x60; - Serial ATA (SATA, abbreviated from Serial AT Attachment) is a computer bus interface that connects host bus adapters to mass storage devices such as hard disk drives, optical drives, and solid-state drives. * &#x60;scsi&#x60; - SCSI (Small Computer System Interface) bus used.. | [optional] [readonly] [default to "virtio"]
**Name** | **String** | Disk name associated with virtual machine. | [optional] [readonly] 
**Type** | **String** | Type of the Disk (hdd, cdrom). * &#x60;hdd&#x60; - Allows the virtual machine to mount disk from hard disk drive (hdd) image. * &#x60;cdrom&#x60; - Allows the virtual machine to mount disk from compact disk (cd) image. | [optional] [readonly] [default to "hdd"]
**VirtualDisk** | [**HyperflexVdiskConfig**](HyperflexVdiskConfig.md) |  | [optional] 
**VirtualDiskReference** | **String** | Virtual disk reference name. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$HyperflexVmDiskAllOf = Initialize-IntersightHyperflexVmDiskAllOf  -ClassId null `
 -ObjectType null `
 -BootOrder null `
 -Bus null `
 -Name null `
 -Type null `
 -VirtualDisk null `
 -VirtualDiskReference null
```

- Convert the resource to JSON
```powershell
$HyperflexVmDiskAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

