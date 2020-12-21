# NiatelemetryNiaInventoryAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "niatelemetry.NiaInventory"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "niatelemetry.NiaInventory"]
**BgpPeerCount** | **Int64** | Number of BGP peers on a node. | [optional] 
**Cpu** | **Double** | CPU usage of device being inventoried. This determines the percentage of CPU resources used. | [optional] 
**CrashResetLogs** | **String** | Last crash reset reason of device being inventoried. This determines the last reason for a device&#39;s restart due to crash of the system. | [optional] 
**DeviceName** | **String** | Name of device being inventoried. The name the user assigns to the device is inventoried here. | [optional] 
**DeviceType** | **String** | Type of device being inventoried. This determines whether the device is a controller, leaf or spine. | [optional] 
**Disk** | [**NiatelemetryDiskinfo**](NiatelemetryDiskinfo.md) |  | [optional] 
**Dn** | **String** | Dn for the inventories present. | [optional] 
**FexCount** | **Int64** | Number of fabric extendors utilized. | [optional] 
**InfraWiNodeCount** | **Int64** | Number of appliances as physical device that are wired into the cluster. | [optional] 
**IpAddress** | **String** | The IP address of the device being inventoried. | [optional] 
**LogInTime** | **String** | Last log in time device being inventoried. This determines the last login time on the device. | [optional] 
**LogOutTime** | **String** | Last log out time of device being inventoried. This determines the last logout time on the device. | [optional] 
**MacSecCount** | **Int64** | Number of Macsec configured interfaces on a TOR. | [optional] 
**MacSecFabCount** | **Int64** | Number of Macsec configured interfaces on a Spine. | [optional] 
**MacsecTotalCount** | **Int64** | Number of total Macsec configured interfaces for all nodes. | [optional] 
**Memory** | **Int64** | Memory usage of device being inventoried. This determines the percentage of memory resources used. | [optional] 
**NodeId** | **String** | The ID of the device being inventoried. | [optional] 
**RecordType** | **String** | Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected. | [optional] 
**RecordVersion** | **String** | Version of record being pushed. This determines what was the API version for data available from the device. | [optional] 
**RoutePrefixCount** | **Int64** | Total nuumber of v4 and v6 routes per node. | [optional] 
**RoutePrefixV4Count** | **Int64** | Number of v4 routes per node. | [optional] 
**RoutePrefixV6Count** | **Int64** | Number of v6 routes per node. | [optional] 
**Serial** | **String** | Serial number of device being invetoried. The serial number is unique per device and will be used as the key. | [optional] 
**SoftwareDownload** | **String** | Last software downloaded of device being inventoried. This determines if software download API was used. | [optional] 
**SystemUpTime** | **String** | The amount of time that the device being inventoried been up. | [optional] 
**Version** | **String** | Software version of device being inventoried. The various software version values for each device are available on cisco.com. | [optional] 
**LicenseState** | [**NiatelemetryNiaLicenseStateRelationship**](NiatelemetryNiaLicenseStateRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$NiatelemetryNiaInventoryAllOf = Initialize-IntersightNiatelemetryNiaInventoryAllOf  -ClassId null `
 -ObjectType null `
 -BgpPeerCount null `
 -Cpu null `
 -CrashResetLogs null `
 -DeviceName null `
 -DeviceType null `
 -Disk null `
 -Dn null `
 -FexCount null `
 -InfraWiNodeCount null `
 -IpAddress null `
 -LogInTime null `
 -LogOutTime null `
 -MacSecCount null `
 -MacSecFabCount null `
 -MacsecTotalCount null `
 -Memory null `
 -NodeId null `
 -RecordType null `
 -RecordVersion null `
 -RoutePrefixCount null `
 -RoutePrefixV4Count null `
 -RoutePrefixV6Count null `
 -Serial null `
 -SoftwareDownload null `
 -SystemUpTime null `
 -Version null `
 -LicenseState null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$NiatelemetryNiaInventoryAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

