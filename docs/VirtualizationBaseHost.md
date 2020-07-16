# VirtualizationBaseHost
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountMoid** | **String** | The Account ID for this managed object. | [optional] [readonly] 
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**CreateTime** | **System.DateTime** | The time when this managed object was created. | [optional] [readonly] 
**DomainGroupMoid** | **String** | The DomainGroup ID for this managed object. | [optional] [readonly] 
**ModTime** | **System.DateTime** | The time when this managed object was last modified. | [optional] [readonly] 
**Moid** | **String** | The unique identifier of this Managed Object instance. | [optional] 
**ObjectType** | **String** | The fully-qualified type of this managed object, i.e. the class name. This property is optional. The ObjectType is implied from the URL path. If specified, the value of objectType must match the class name specified in the URL path. | [readonly] 
**Owners** | **String[]** |  | [optional] 
**SharedScope** | **String** | Intersight provides pre-built workflows, tasks and policies to end users through global catalogs. Objects that are made available through global catalogs are said to have a &#39;shared&#39; ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs. | [optional] [readonly] 
**Tags** | [**MoTag[]**](MoTag.md) |  | [optional] 
**VersionContext** | [**MoVersionContext**](MoVersionContext.md) |  | [optional] 
**Ancestors** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**Parent** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**PermissionResources** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**DisplayNames** | [**System.Collections.Hashtable**](Array.md) | a map of display names for a resource. | [optional] [readonly] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**CpuInfo** | [**VirtualizationCpuInfo**](VirtualizationCpuInfo.md) |  | [optional] 
**HardwareInfo** | [**InfraHardwareInfo**](InfraHardwareInfo.md) |  | [optional] 
**HypervisorType** | **String** | Identifies the broad type of the underlying hypervisor. | [optional] [default to "Unknown"]
**Identity** | **String** | The internally generated identity of this host. This entity is not manipulated by users. It aids in uniquely identifying the datacenter object. For VMware, this is an MOR (managed object reference). | [optional] 
**MaintenanceMode** | **Boolean** | Is this host in maintenance mode. Set to true or false. | [optional] 
**MemoryCapacity** | [**VirtualizationMemoryCapacity**](VirtualizationMemoryCapacity.md) |  | [optional] 
**Model** | **String** | Commercial model information about this hardware. | [optional] 
**Name** | **String** | Name of this host supplied by user. It is not the identity of the host. The name is subject to user manipulations. | [optional] 
**ProcessorCapacity** | [**VirtualizationComputeCapacity**](VirtualizationComputeCapacity.md) |  | [optional] 
**ProductInfo** | [**VirtualizationProductInfo**](VirtualizationProductInfo.md) |  | [optional] 
**Serial** | **String** | Serial number of this host (internally generated). | [optional] 
**Status** | **String** | Host health status, as reported by the hypervisor platform. | [optional] [default to "Unknown"]
**UpTime** | **String** | The uptime of the host, stored as Duration (from w3c). | [optional] 
**Uuid** | **String** | Universally unique identity of this host (example b3d4483b-5560-9342-8309-b486c9236610). Internally generated. | [optional] 
**Vendor** | **String** | Commercial vendor details of this hardware. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVirtualizationBaseHost  -AccountMoid null `
 -ClassId null `
 -CreateTime null `
 -DomainGroupMoid null `
 -ModTime null `
 -Moid null `
 -ObjectType null `
 -Owners null `
 -SharedScope null `
 -Tags null `
 -VersionContext null `
 -Ancestors null `
 -Parent null `
 -PermissionResources null `
 -DisplayNames null `
 -RegisteredDevice null `
 -CpuInfo null `
 -HardwareInfo null `
 -HypervisorType null `
 -Identity null `
 -MaintenanceMode null `
 -MemoryCapacity null `
 -Model null `
 -Name null `
 -ProcessorCapacity null `
 -ProductInfo null `
 -Serial null `
 -Status null `
 -UpTime null `
 -Uuid null `
 -Vendor null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

