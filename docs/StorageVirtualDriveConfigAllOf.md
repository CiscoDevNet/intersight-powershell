# StorageVirtualDriveConfigAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessPolicy** | **String** | Access policy that host has on this virtual drive. | [optional] [default to "Default"]
**BootDrive** | **Boolean** | The flag enables the use of this virtual drive as a boot drive. | [optional] 
**DiskGroupName** | **String** | Disk group policy that has the disk group in which this virtual drive needs to be created. | [optional] [readonly] 
**DiskGroupPolicy** | **String** | Disk group policy that has the disk group in which this virtual drive needs to be created. | [optional] 
**DriveCache** | **String** | Drive Cache property expect disk cache policy. | [optional] [default to "Default"]
**ExpandToAvailable** | **Boolean** | The flag enables this virtual drive to use all the available space in the disk group. When this flag is configured, the size property is ignored. | [optional] 
**IoPolicy** | **String** | Desired IO mode - direct IO or cached IO. | [optional] [default to "Default"]
**Name** | **String** | The name of the virtual drive. The name can be between 1 and 15 alphanumeric characters. Spaces or any special characters other than - (hyphen), _ (underscore), : (colon), and . (period) are not allowed. | [optional] 
**ReadPolicy** | **String** | Read ahead mode to be used to read data from this virtual drive. | [optional] [default to "Default"]
**Size** | **Int64** | Virtual drive size in MB. Size is mandatory field unless the &#39;Expand to Available&#39; option is enabled. | [optional] 
**WritePolicy** | **String** | Write mode to be used to write data to this virtual drive. | [optional] [default to "Default"]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightStorageVirtualDriveConfigAllOf  -AccessPolicy null `
 -BootDrive null `
 -DiskGroupName null `
 -DiskGroupPolicy null `
 -DriveCache null `
 -ExpandToAvailable null `
 -IoPolicy null `
 -Name null `
 -ReadPolicy null `
 -Size null `
 -WritePolicy null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

