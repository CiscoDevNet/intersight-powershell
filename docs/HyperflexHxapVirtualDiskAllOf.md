# HyperflexHxapVirtualDiskAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.HxapVirtualDisk"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.HxapVirtualDisk"]
**AccessMode** | **String** | Access mode of the virtual disk. * &#x60;ReadWriteOnce&#x60; - Read write permisisons to a Virtual disk by a single virtual machine. * &#x60;ReadWriteMany&#x60; - Read write permisisons to a Virtual disk by multiple virtual machines. * &#x60;ReadOnlyMany&#x60; - Read only permisisons to a Virtual disk by multiple virtual machines. | [optional] [readonly] [default to "ReadWriteOnce"]
**Mode** | **String** | File mode of the disk  example - Filesystem, Block. * &#x60;Block&#x60; - It is a Block virtual disk. * &#x60;Filesystem&#x60; - It is a File system virtual disk. | [optional] [readonly] [default to "Block"]
**SourceFilePath** | **String** | Source file path associated with virtual machine disk. | [optional] [readonly] 
**SourceVirtualDisk** | **String** | Source disk name from where the clone is done. | [optional] [readonly] 
**Status** | [**HyperflexDiskStatus**](HyperflexDiskStatus.md) |  | [optional] 
**Uuid** | **String** | UUID of the virtual disk. | [optional] [readonly] 
**Cluster** | [**HyperflexHxapClusterRelationship**](HyperflexHxapClusterRelationship.md) |  | [optional] 
**VirtualMachine** | [**HyperflexHxapVirtualMachineRelationship**](HyperflexHxapVirtualMachineRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexHxapVirtualDiskAllOf = Initialize-IntersightHyperflexHxapVirtualDiskAllOf  -ClassId null `
 -ObjectType null `
 -AccessMode null `
 -Mode null `
 -SourceFilePath null `
 -SourceVirtualDisk null `
 -Status null `
 -Uuid null `
 -Cluster null `
 -VirtualMachine null
```

- Convert the resource to JSON
```powershell
$HyperflexHxapVirtualDiskAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

