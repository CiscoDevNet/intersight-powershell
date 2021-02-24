# VirtualizationVirtualDiskAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "virtualization.VirtualDisk"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "virtualization.VirtualDisk"]
**Capacity** | **String** | Disk capacity to be provided with units example - 10Gi. | [optional] 
**Discovered** | **Boolean** | Flag to indicate whether the configuration is created from inventory object. | [optional] [readonly] 
**Mode** | **String** | File mode of the disk  example - Filesystem, Block. * &#x60;Block&#x60; - It is a Block virtual disk. * &#x60;Filesystem&#x60; - It is a File system virtual disk. | [optional] [default to "Block"]
**Name** | **String** | Name of the storage disk. Name must be unique within a Datastore. | [optional] 
**SourceCerts** | **String** | Base64 encoded CA certificates of the https source to check against. | [optional] 
**SourceDiskToClone** | **String** | Source disk from which the content is copied. | [optional] 
**SourceFilePath** | **String** | Image path used to import on the created disk. | [optional] 
**Cluster** | [**VirtualizationBaseClusterRelationship**](VirtualizationBaseClusterRelationship.md) |  | [optional] 
**Inventory** | [**VirtualizationBaseVirtualDiskRelationship**](VirtualizationBaseVirtualDiskRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**WorkflowInfo** | [**WorkflowWorkflowInfoRelationship**](WorkflowWorkflowInfoRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$VirtualizationVirtualDiskAllOf = Initialize-IntersightVirtualizationVirtualDiskAllOf  -ClassId null `
 -ObjectType null `
 -Capacity null `
 -Discovered null `
 -Mode null `
 -Name null `
 -SourceCerts null `
 -SourceDiskToClone null `
 -SourceFilePath null `
 -Cluster null `
 -Inventory null `
 -RegisteredDevice null `
 -WorkflowInfo null
```

- Convert the resource to JSON
```powershell
$VirtualizationVirtualDiskAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

