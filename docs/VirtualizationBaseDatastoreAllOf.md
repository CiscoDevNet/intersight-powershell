# VirtualizationBaseDatastoreAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | [default to "virtualization.VmwareDatastore"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | [default to "virtualization.VmwareDatastore"]
**Capacity** | [**VirtualizationStorageCapacity**](VirtualizationStorageCapacity.md) |  | [optional] 
**HostCount** | **Int64** | Number of hosts attached to or supported-by this datastore. | [optional] 
**Identity** | **String** | The internally generated identity of this datastore. This entity is not manipulated by users. It aids in uniquely identifying the datastore object. For VMware, this is a MOR (managed object reference). | [optional] 
**Name** | **String** | Name of this datastore supplied by user. It is not the identity of the datastore. The name is subject to user manipulations. | [optional] 
**Type** | **String** | A string indicating the type of the datastore (VMFS, NFS, etc). * &#x60;Unknown&#x60; - The nature of the file system is unknown. * &#x60;VMFS&#x60; - It is a Virtual Machine Filesystem. * &#x60;NFS&#x60; - It is a Network File System. * &#x60;vSAN&#x60; - It is a virtual Storage Area Network file system. * &#x60;VirtualVolume&#x60; - A Virtual Volume datastore represents a storage container in a hypervisor server. | [optional] [default to "Unknown"]
**VmCount** | **Int64** | Number of virtual machines relying on (using) this datastore. | [optional] 

## Examples

- Prepare the resource
```powershell
$VirtualizationBaseDatastoreAllOf = Initialize-IntersightVirtualizationBaseDatastoreAllOf  -ClassId null `
 -ObjectType null `
 -Capacity null `
 -HostCount null `
 -Identity null `
 -Name null `
 -Type null `
 -VmCount null
```

- Convert the resource to JSON
```powershell
$VirtualizationBaseDatastoreAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

