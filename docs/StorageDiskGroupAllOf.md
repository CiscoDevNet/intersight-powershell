# StorageDiskGroupAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **String** | Name to identity this disk group in the controller. | [optional] 
**RaidType** | **String** | Raid level of the virtual drives in this diskgroup. | [optional] 
**DedicatedHotSpares** | [**StoragePhysicalDiskRelationship[]**](StoragePhysicalDiskRelationship.md) | An array of relationships to storagePhysicalDisk resources. | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**Spans** | [**StorageSpanRelationship[]**](StorageSpanRelationship.md) | An array of relationships to storageSpan resources. | [optional] 
**StorageController** | [**StorageControllerRelationship**](StorageControllerRelationship.md) |  | [optional] 
**VirtualDrives** | [**StorageVirtualDriveRelationship[]**](StorageVirtualDriveRelationship.md) | An array of relationships to storageVirtualDrive resources. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightStorageDiskGroupAllOf  -Name null `
 -RaidType null `
 -DedicatedHotSpares null `
 -RegisteredDevice null `
 -Spans null `
 -StorageController null `
 -VirtualDrives null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

