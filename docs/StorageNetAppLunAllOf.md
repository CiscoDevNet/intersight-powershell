# StorageNetAppLunAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.NetAppLun"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.NetAppLun"]
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
$StorageNetAppLunAllOf = Initialize-IntersightStorageNetAppLunAllOf  -ClassId null `
 -ObjectType null `
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
$StorageNetAppLunAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

