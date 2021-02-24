# VirtualizationVmEsxiDisk
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "virtualization.VmEsxiDisk"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "virtualization.VmEsxiDisk"]
**Capacity** | **String** | Disk capacity to be provided with units example - 10Gi. | [optional] 
**Datastore** | **String** | Datastore of the disk from the space is allocated. | [optional] 
**Diskmode** | **String** | Mode of the disk, like persistent, independent persistent. | [optional] 
**Name** | **String** | Name of the virtual disk. | [optional] 
**StorageAllocation** | **String** | Specify the allocation type as thin or thick. | [optional] 
**StorageController** | **String** | Controller name of the disk, if not specified uses the default one. | [optional] 

## Examples

- Prepare the resource
```powershell
$VirtualizationVmEsxiDisk = Initialize-IntersightVirtualizationVmEsxiDisk  -ClassId null `
 -ObjectType null `
 -Capacity null `
 -Datastore null `
 -Diskmode null `
 -Name null `
 -StorageAllocation null `
 -StorageController null
```

- Convert the resource to JSON
```powershell
$VirtualizationVmEsxiDisk | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

