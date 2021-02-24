# StorageNetAppLunRelationship
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.NetAppLun"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.NetAppLun"]
**Moid** | **String** | The unique identifier of this Managed Object instance. | [optional] 
**Selector** | **String** | An OData $filter expression which describes the REST resource to be referenced. This field may be set instead of &#39;moid&#39; by clients. 1. If &#39;moid&#39; is set this field is ignored. 1. If &#39;selector&#39; is set and &#39;moid&#39; is empty/absent from the request, Intersight determines the Moid of the resource matching the filter expression and populates it in the MoRef that is part of the object instance being inserted/updated to fulfill the REST request. An error is returned if the filter matches zero or more than one REST resource. An example filter string is: Serial eq &#39;3AA8B7T11&#39;. | [optional] [readonly] 
**Link** | **String** | A URL to an instance of the &#39;mo.MoRef&#39; class. | [optional] 
**AccountMoid** | **String** | The Account ID for this managed object. | [optional] [readonly] 
**CreateTime** | **System.DateTime** | The time when this managed object was created. | [optional] [readonly] 
**DomainGroupMoid** | **String** | The DomainGroup ID for this managed object. | [optional] [readonly] 
**ModTime** | **System.DateTime** | The time when this managed object was last modified. | [optional] [readonly] 
**Owners** | **String[]** |  | [optional] 
**SharedScope** | **String** | Intersight provides pre-built workflows, tasks and policies to end users through global catalogs. Objects that are made available through global catalogs are said to have a &#39;shared&#39; ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs. | [optional] [readonly] 
**Tags** | [**MoTag[]**](MoTag.md) |  | [optional] 
**VersionContext** | [**MoVersionContext**](MoVersionContext.md) |  | [optional] 
**Var0ClusterReplicationNetworkPolicy** | [**HyperflexClusterReplicationNetworkPolicyRelationship**](HyperflexClusterReplicationNetworkPolicyRelationship.md) |  | [optional] 
**Ancestors** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**Parent** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**PermissionResources** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**DisplayNames** | [**System.Collections.Hashtable**](Array.md) | A set of display names for the MO resource. These names are calculated based on other properties of the MO and potentially properties of Ancestor MOs. Displaynames are intended as a way to provide a normalized user appropriate name for an MO, especially for MOs which do not have a &#39;Name&#39; property, which is the case for much of the inventory discovered from managed targets. There are a limited number of keys, currently &#39;short&#39; and &#39;hierarchical&#39;. The value is an array and clients should use the first element of the array. | [optional] [readonly] 
**Description** | **String** | Short description about the volume. | [optional] [readonly] 
**NaaId** | **String** | NAA id of volume. It is a significant number to identify corresponding lun path in hypervisor. | [optional] [readonly] 
**Name** | **String** | Named entity of the volume. | [optional] [readonly] 
**Size** | **Int64** | User provisioned volume size. It is the size exposed to host. | [optional] [readonly] 
**StorageUtilization** | [**StorageBaseCapacity**](StorageBaseCapacity.md) |  | [optional] 
**OsType** | **String** | The operating system (OS) type for this LUN. * &#x60;Linux&#x60; - Family of open source Unix-like operating systems based on the Linux kernel. * &#x60;AIX&#x60; - Advanced Interactive Executive (AIX). * &#x60;HP-UX&#x60; - HP-UX is implementation of the Unix operating system, based on Unix System V. * &#x60;Hyper-V&#x60; - Windows Server 2008 or Windows Server 2012 Hyper-V. * &#x60;OpenVMS&#x60; - OpenVMS is multi-user, multiprocessing virtual memory-based operating system. * &#x60;Solaris&#x60; - Solaris is a Unix operating system. * &#x60;NetWare&#x60; - NetWare is a computer network operating system. * &#x60;VMware&#x60; - An enterprise-class, type-1 hypervisor developed by VMware for deploying and serving virtual computers. * &#x60;Windows&#x60; - Single-partition Windows disk using the Master Boot Record (MBR) partitioning style. * &#x60;Xen&#x60; - Xen is a type-1 hypervisor, providing services that allow multiple computer operating systems to execute on the same computer hardware concurrently. | [optional] [readonly] [default to "Linux"]
**Serial** | **String** | Serial number for the provisioned LUN. | [optional] [readonly] 
**State** | **String** | The administrative state of a LUN. * &#x60;offline&#x60; - The LUN is administratively offline, or a more detailed offline reason is not available. * &#x60;online&#x60; - The LUN is online. | [optional] [readonly] [default to "offline"]
**Uuid** | **String** | UUID of the LUN. | [optional] [readonly] 
**Array** | [**StorageNetAppClusterRelationship**](StorageNetAppClusterRelationship.md) |  | [optional] 
**VarHost** | [**StorageNetAppInitiatorGroupRelationship[]**](StorageNetAppInitiatorGroupRelationship.md) | An array of relationships to storageNetAppInitiatorGroup resources. | [optional] [readonly] 
**StorageContainer** | [**StorageNetAppVolumeRelationship**](StorageNetAppVolumeRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$StorageNetAppLunRelationship = Initialize-IntersightStorageNetAppLunRelationship  -ClassId null `
 -ObjectType null `
 -Moid null `
 -Selector null `
 -Link null `
 -AccountMoid null `
 -CreateTime null `
 -DomainGroupMoid null `
 -ModTime null `
 -Owners null `
 -SharedScope null `
 -Tags null `
 -VersionContext null `
 -Var0ClusterReplicationNetworkPolicy null `
 -Ancestors null `
 -Parent null `
 -PermissionResources null `
 -DisplayNames null `
 -Description null `
 -NaaId null `
 -Name null `
 -Size null `
 -StorageUtilization null `
 -OsType null `
 -Serial null `
 -State null `
 -Uuid null `
 -Array null `
 -VarHost null `
 -StorageContainer null
```

- Convert the resource to JSON
```powershell
$StorageNetAppLunRelationship | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

