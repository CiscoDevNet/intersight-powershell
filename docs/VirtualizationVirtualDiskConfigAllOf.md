# VirtualizationVirtualDiskConfigAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "virtualization.VirtualDiskConfig"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "virtualization.VirtualDiskConfig"]
**Capacity** | **String** | Disk capacity to be provided with units example - 10Gi. | [optional] 
**Mode** | **String** | File mode of the disk, example - Filesystem, Block. * &#x60;Block&#x60; - It is a Block virtual disk. * &#x60;Filesystem&#x60; - It is a File system virtual disk. | [optional] [default to "Block"]
**Name** | **String** | Name of the virtual disk. | [optional] 
**SourceCerts** | **String** | Base64 encoded CA certificates of the https source to check against. | [optional] 
**SourceDiskToClone** | **String** | Source disk name from where the clone is done. | [optional] 
**SourceFilePath** | **String** | Disk image source for the virtual machine. | [optional] 

## Examples

- Prepare the resource
```powershell
$VirtualizationVirtualDiskConfigAllOf = Initialize-IntersightVirtualizationVirtualDiskConfigAllOf  -ClassId null `
 -ObjectType null `
 -Capacity null `
 -Mode null `
 -Name null `
 -SourceCerts null `
 -SourceDiskToClone null `
 -SourceFilePath null
```

- Convert the resource to JSON
```powershell
$VirtualizationVirtualDiskConfigAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

