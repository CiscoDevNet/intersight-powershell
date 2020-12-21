# StorageVirtualDriveConfig
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.VirtualDriveConfig"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.VirtualDriveConfig"]
**AccessPolicy** | **String** | Access policy that host has on this virtual drive. * &#x60;Default&#x60; - Use platform default access mode. * &#x60;ReadWrite&#x60; - Enables host to perform read-write on the VD. * &#x60;ReadOnly&#x60; - Host can only read from the VD. * &#x60;Blocked&#x60; - Host can neither read nor write to the VD. | [optional] [default to "Default"]
**BootDrive** | **Boolean** | The flag enables the use of this virtual drive as a boot drive. | [optional] 
**DiskGroupName** | **String** | Disk group policy that has the disk group in which this virtual drive needs to be created. | [optional] [readonly] 
**DiskGroupPolicy** | **String** | Disk group policy that has the disk group in which this virtual drive needs to be created. | [optional] 
**DriveCache** | **String** | Drive Cache property expect disk cache policy. * &#x60;Default&#x60; - Use platform default drive cache mode. * &#x60;NoChange&#x60; - Drive cache policy is unchanged. * &#x60;Enable&#x60; - Enables IO caching on the drive. * &#x60;Disable&#x60; - Disables IO caching on the drive. | [optional] [default to "Default"]
**ExpandToAvailable** | **Boolean** | The flag enables this virtual drive to use all the available space in the disk group. When this flag is configured, the size property is ignored. | [optional] 
**IoPolicy** | **String** | Desired IO mode - direct IO or cached IO. * &#x60;Default&#x60; - Use platform default IO mode. * &#x60;Direct&#x60; - Use direct IO for writing directly into the disk. * &#x60;Cached&#x60; - Use cached IO for writing into cache and then to disk. | [optional] [default to "Default"]
**Name** | **String** | The name of the virtual drive. The name can be between 1 and 15 alphanumeric characters. Spaces or any special characters other than - (hyphen), _ (underscore), : (colon), and . (period) are not allowed. | [optional] 
**ReadPolicy** | **String** | Read ahead mode to be used to read data from this virtual drive. * &#x60;Default&#x60; - Use platform default read ahead mode. * &#x60;ReadAhead&#x60; - Use read ahead mode for the policy. * &#x60;NoReadAhead&#x60; - Do not use read ahead mode for the policy. | [optional] [default to "Default"]
**Size** | **Int64** | Virtual drive size in MB. Size is mandatory field unless the &#39;Expand to Available&#39; option is enabled. | [optional] 
**StripSize** | **String** | The strip size is the portion of a stripe that resides on a single drive in the drive group. The stripe consists of the data segments that the RAID controller writes across multiple drives, not including parity drives. * &#x60;Default&#x60; - Use platform default strip size for a virtual drive. * &#x60;32k&#x60; - Enables a strip size of 32k for a virtual drive. * &#x60;64k&#x60; - Enables a strip size of 64k for a virtual drive. * &#x60;128k&#x60; - Enables a strip size of 128k for a virtual drive. * &#x60;256k&#x60; - Enables a strip size of 256k for a virtual drive. * &#x60;512k&#x60; - Enables a strip size of 512k for a virtual drive. * &#x60;1024k&#x60; - Enables a strip size of 1024k for a virtual drive. | [optional] [default to "Default"]
**Vdid** | **String** | Unique Id of the Virtual Drive to be used to identify Virtual Drive when name is empty. | [optional] [readonly] 
**WritePolicy** | **String** | Write mode to be used to write data to this virtual drive. * &#x60;Default&#x60; - Use platform default write mode. * &#x60;WriteThrough&#x60; - Data is written through the cache and to the physical drives. Performance is improved, because subsequent reads of that data can be satisfied from the cache. * &#x60;WriteBackGoodBbu&#x60; - Data is stored in the cache, and is only written to the physical drives when space in the cache is needed. Virtual drives requesting this policy fall back to Write Through caching when the battery backup unit (BBU) cannot guarantee the safety of the cache in the event of a power failure. * &#x60;AlwaysWriteBack&#x60; - With this policy, write caching remains Write Back even if the battery backup unit is defective or discharged. | [optional] [default to "Default"]

## Examples

- Prepare the resource
```powershell
$StorageVirtualDriveConfig = Initialize-IntersightStorageVirtualDriveConfig  -ClassId null `
 -ObjectType null `
 -AccessPolicy null `
 -BootDrive null `
 -DiskGroupName null `
 -DiskGroupPolicy null `
 -DriveCache null `
 -ExpandToAvailable null `
 -IoPolicy null `
 -Name null `
 -ReadPolicy null `
 -Size null `
 -StripSize null `
 -Vdid null `
 -WritePolicy null
```

- Convert the resource to JSON
```powershell
$StorageVirtualDriveConfig | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

