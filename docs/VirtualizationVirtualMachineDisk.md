# VirtualizationVirtualMachineDisk
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "virtualization.VirtualMachineDisk"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "virtualization.VirtualMachineDisk"]
**Bus** | **String** | Disk bus name given for a virtual machine. * &#x60;virtio&#x60; - Disk uses the same paths as a bare-metal system. This simplifies physical-to-virtual and virtual-to-virtual migration. * &#x60;sata&#x60; - Serial ATA (SATA, abbreviated from Serial AT Attachment) is a computer bus interface that connects host bus adapters to mass storage devices such as hard disk drives, optical drives, and solid-state drives. * &#x60;scsi&#x60; - SCSI (Small Computer System Interface) bus used.. | [optional] [default to "virtio"]
**Name** | **String** | Virtual machine network bridge name. | [optional] 
**Order** | **Int64** | Priority order of the disk. | [optional] 
**Type** | **String** | Disk type hdd or cdrom for a virtual machine. * &#x60;hdd&#x60; - Allows the virtual machine to mount disk from hard disk drive (hdd) image. * &#x60;cdrom&#x60; - Allows the virtual machine to mount disk from compact disk (cd) image. | [optional] [default to "hdd"]
**VirtualDisk** | [**VirtualizationVirtualDiskConfig**](VirtualizationVirtualDiskConfig.md) |  | [optional] 
**VirtualDiskReference** | **String** | Name of the existing virtual disk to be attached to the Virtual Machine. | [optional] 

## Examples

- Prepare the resource
```powershell
$VirtualizationVirtualMachineDisk = Initialize-IntersightVirtualizationVirtualMachineDisk  -ClassId null `
 -ObjectType null `
 -Bus null `
 -Name null `
 -Order null `
 -Type null `
 -VirtualDisk null `
 -VirtualDiskReference null
```

- Convert the resource to JSON
```powershell
$VirtualizationVirtualMachineDisk | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

