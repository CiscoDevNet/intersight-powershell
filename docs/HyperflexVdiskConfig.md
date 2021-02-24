# HyperflexVdiskConfig
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.VdiskConfig"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.VdiskConfig"]
**AccessMode** | **String** | Access mode of the virtual disk. * &#x60;ReadWriteOnce&#x60; - Read write permisisons to a Virtual disk by a single virtual machine. * &#x60;ReadWriteMany&#x60; - Read write permisisons to a Virtual disk by multiple virtual machines. * &#x60;ReadOnlyMany&#x60; - Read only permisisons to a Virtual disk by multiple virtual machines. | [optional] [readonly] [default to "ReadWriteOnce"]
**Capacity** | **Int64** | Total disk capacity represented in Gibibytes (GiB). | [optional] [readonly] 
**Mode** | **String** | File mode of the disk, example - Filesystem, Block. * &#x60;Block&#x60; - It is a Block virtual disk. * &#x60;Filesystem&#x60; - It is a File system virtual disk. | [optional] [readonly] [default to "Block"]
**Name** | **String** | Name of the virtual disk. | [optional] [readonly] 
**SourceFilePath** | **String** | Source file path associated with virtual machine disk. | [optional] [readonly] 
**SourceVirtualDisk** | **String** | Source disk name from where the clone is done. | [optional] [readonly] 
**Status** | [**HyperflexDiskStatus**](HyperflexDiskStatus.md) |  | [optional] 
**Uuid** | **String** | UUID of the virtual disk. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$HyperflexVdiskConfig = Initialize-IntersightHyperflexVdiskConfig  -ClassId null `
 -ObjectType null `
 -AccessMode null `
 -Capacity null `
 -Mode null `
 -Name null `
 -SourceFilePath null `
 -SourceVirtualDisk null `
 -Status null `
 -Uuid null
```

- Convert the resource to JSON
```powershell
$HyperflexVdiskConfig | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

