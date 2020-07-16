# NiatelemetryNiaInventoryAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cpu** | **Double** | CPU usage of device being inventoried. This determines the percentage of CPU resources used. | [optional] 
**CrashResetLogs** | **String** | Last crash reset reason of device being inventoried. This determines the last reason for a device&#39;s restart due to crash of the system. | [optional] 
**DeviceName** | **String** | Name of device being inventoried. The name the user assigns to the device is inventoried here. | [optional] 
**DeviceType** | **String** | Type of device being inventoried. This determines whether the device is a controller, leaf or spine. | [optional] 
**Disk** | [**NiatelemetryDiskinfo**](NiatelemetryDiskinfo.md) |  | [optional] 
**LogInTime** | **String** | Last log in time device being inventoried. This determines the last login time on the device. | [optional] 
**LogOutTime** | **String** | Last log out time of device being inventoried. This determines the last logout time on the device. | [optional] 
**Memory** | **Int64** | Memory usage of device being inventoried. This determines the percentage of memory resources used. | [optional] 
**RecordType** | **String** | Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected. | [optional] 
**RecordVersion** | **String** | Version of record being pushed. This determines what was the API version for data available from the device. | [optional] 
**Serial** | **String** | Serial number of device being invetoried. The serial number is unique per device and will be used as the key. | [optional] 
**SoftwareDownload** | **String** | Last software downloaded of device being inventoried. This determines if software download API was used. | [optional] 
**Version** | **String** | Software version of device being inventoried. The various software version values for each device are available on cisco.com. | [optional] 
**LicenseState** | [**NiatelemetryNiaLicenseStateRelationship**](NiatelemetryNiaLicenseStateRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightNiatelemetryNiaInventoryAllOf  -Cpu null `
 -CrashResetLogs null `
 -DeviceName null `
 -DeviceType null `
 -Disk null `
 -LogInTime null `
 -LogOutTime null `
 -Memory null `
 -RecordType null `
 -RecordVersion null `
 -Serial null `
 -SoftwareDownload null `
 -Version null `
 -LicenseState null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

