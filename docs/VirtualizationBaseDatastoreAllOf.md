# VirtualizationBaseDatastoreAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Capacity** | [**VirtualizationStorageCapacity**](VirtualizationStorageCapacity.md) |  | [optional] 
**HostCount** | **Int64** | Number of hosts attached to or supported-by this datastore. | [optional] 
**Identity** | **String** | The internally generated identity of this datastore. This entity is not manipulated by users. It aids in uniquely identifying the datastore object. For VMware, this is a MOR (managed object reference). | [optional] 
**Name** | **String** | Name of this datastore supplied by user. It is not the identity of the datastore. The name is subject to user manipulations. | [optional] 
**Type** | **String** | A string indicating the type of the datastore (VMFS, NFS, etc). | [optional] [default to "Unknown"]
**VmCount** | **Int64** | Number of virtual machines relying on (using) this datastore. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVirtualizationBaseDatastoreAllOf  -Capacity null `
 -HostCount null `
 -Identity null `
 -Name null `
 -Type null `
 -VmCount null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

