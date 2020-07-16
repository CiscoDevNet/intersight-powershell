# VirtualizationVmwareDatastore
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
**Capacity** | [**VirtualizationStorageCapacity**](VirtualizationStorageCapacity.md) |  | [optional] 
**HostCount** | **Int64** | Number of hosts attached to or supported-by this datastore. | [optional] 
**Identity** | **String** | The internally generated identity of this datastore. This entity is not manipulated by users. It aids in uniquely identifying the datastore object. For VMware, this is a MOR (managed object reference). | [optional] 
**Name** | **String** | Name of this datastore supplied by user. It is not the identity of the datastore. The name is subject to user manipulations. | [optional] 
**Type** | **String** | A string indicating the type of the datastore (VMFS, NFS, etc). | [optional] [default to "Unknown"]
**VmCount** | **Int64** | Number of virtual machines relying on (using) this datastore. | [optional] 
**Accessible** | **Boolean** | Shows if this datastore is accessible. | [optional] 
**MaintenanceMode** | **Boolean** | Indicates if the datastore is in maintenance mode. Will be set to True, when in maintenance mode. | [optional] 
**MultipleHostAccess** | **Boolean** | Indicates if this datastore is connected to multiple hosts. | [optional] 
**Status** | **String** | Datastore health status, as reported by the hypervisor platform. | [optional] [default to "Unknown"]
**ThinProvisioningSupported** | **Boolean** | Indicates if this datastore supports thin provisioning for files. | [optional] 
**UnCommitted** | **Int64** | Space uncommitted in this datastore in bytes. | [optional] 
**Url** | **String** | The URL to access this datastore (example - &#39;ds:///vmfs/volumes/562a4e8a-0eeb5372-dd61-78baf9cb9afa/&#39;). | [optional] 
**Cluster** | [**VirtualizationVmwareClusterRelationship**](VirtualizationVmwareClusterRelationship.md) |  | [optional] 
**Datacenter** | [**VirtualizationVmwareDatacenterRelationship**](VirtualizationVmwareDatacenterRelationship.md) |  | [optional] 
**Hosts** | [**VirtualizationVmwareHostRelationship[]**](VirtualizationVmwareHostRelationship.md) | An array of relationships to virtualizationVmwareHost resources. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVirtualizationVmwareDatastore  -AccountMoid null `
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
 -Capacity null `
 -HostCount null `
 -Identity null `
 -Name null `
 -Type null `
 -VmCount null `
 -Accessible null `
 -MaintenanceMode null `
 -MultipleHostAccess null `
 -Status null `
 -ThinProvisioningSupported null `
 -UnCommitted null `
 -Url null `
 -Cluster null `
 -Datacenter null `
 -Hosts null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

