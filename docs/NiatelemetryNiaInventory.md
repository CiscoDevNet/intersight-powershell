# NiatelemetryNiaInventory
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
Initialize-IntersightNiatelemetryNiaInventory  -AccountMoid null `
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
 -Cpu null `
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

