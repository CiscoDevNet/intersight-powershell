# NiatelemetryNiaInventory
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "niatelemetry.NiaInventory"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "niatelemetry.NiaInventory"]
**AccountMoid** | **String** | The Account ID for this managed object. | [optional] [readonly] 
**CreateTime** | **System.DateTime** | The time when this managed object was created. | [optional] [readonly] 
**DomainGroupMoid** | **String** | The DomainGroup ID for this managed object. | [optional] [readonly] 
**ModTime** | **System.DateTime** | The time when this managed object was last modified. | [optional] [readonly] 
**Moid** | **String** | The unique identifier of this Managed Object instance. | [optional] 
**Owners** | **String[]** |  | [optional] 
**SharedScope** | **String** | Intersight provides pre-built workflows, tasks and policies to end users through global catalogs. Objects that are made available through global catalogs are said to have a &#39;shared&#39; ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs. | [optional] [readonly] 
**Tags** | [**MoTag[]**](MoTag.md) |  | [optional] 
**VersionContext** | [**MoVersionContext**](MoVersionContext.md) |  | [optional] 
**Var0ClusterReplicationNetworkPolicy** | [**HyperflexClusterReplicationNetworkPolicyRelationship**](HyperflexClusterReplicationNetworkPolicyRelationship.md) |  | [optional] 
**Ancestors** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**Parent** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**PermissionResources** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**DisplayNames** | [**System.Collections.Hashtable**](Array.md) | A set of display names for the MO resource. These names are calculated based on other properties of the MO and potentially properties of Ancestor MOs. Displaynames are intended as a way to provide a normalized user appropriate name for an MO, especially for MOs which do not have a &#39;Name&#39; property, which is the case for much of the inventory discovered from managed targets. There are a limited number of keys, currently &#39;short&#39; and &#39;hierarchical&#39;. The value is an array and clients should use the first element of the array. | [optional] [readonly] 
**Cpu** | **Double** | CPU usage of device being inventoried. This determines the percentage of CPU resources used. | [optional] 
**CrashResetLogs** | **String** | Last crash reset reason of device being inventoried. This determines the last reason for a device&#39;s restart due to crash of the system. | [optional] 
**CustomerDeviceConnector** | **String** | Returns the value of the customerDeviceConnector field. | [optional] 
**DeviceDiscovery** | **String** | Returns the value of the deviceDiscovery field. | [optional] 
**DeviceHealth** | **Int64** | Returns the device health. | [optional] 
**DeviceId** | **String** | Returns the value of the deviceId field. | [optional] 
**DeviceName** | **String** | Name of device being inventoried. The name the user assigns to the device is inventoried here. | [optional] 
**DeviceType** | **String** | Type of device being inventoried. This determines whether the device is a controller, leaf or spine. | [optional] 
**DeviceUpTime** | **Int64** | Returns the device up time. | [optional] 
**Disk** | [**NiatelemetryDiskinfo**](NiatelemetryDiskinfo.md) |  | [optional] 
**Dn** | **String** | Dn for the inventories present. | [optional] 
**FexCount** | **Int64** | Number of fabric extendors utilized. | [optional] 
**InfraWiNodeCount** | **Int64** | Number of appliances as physical device that are wired into the cluster. | [optional] 
**IpAddress** | **String** | The IP address of the device being inventoried. | [optional] 
**IsVirtualNode** | **String** | Flag to specify if the node is virtual. | [optional] 
**LogInTime** | **String** | Last log in time device being inventoried. This determines the last login time on the device. | [optional] 
**LogOutTime** | **String** | Last log out time of device being inventoried. This determines the last logout time on the device. | [optional] 
**MacSecCount** | **Int64** | Number of Macsec configured interfaces on a TOR. | [optional] 
**MacSecFabCount** | **Int64** | Number of Macsec configured interfaces on a Spine. | [optional] 
**MacsecTotalCount** | **Int64** | Number of total Macsec configured interfaces for all nodes. | [optional] 
**Memory** | **Int64** | Memory usage of device being inventoried. This determines the percentage of memory resources used. | [optional] 
**NodeId** | **String** | The ID of the device being inventoried. | [optional] 
**NxosEvpnMacRoutes** | **Int64** | Returns the total number of evpn mac routes. | [optional] 
**NxosInterfaceBrief** | [**NiatelemetryInterface**](NiatelemetryInterface.md) |  | [optional] 
**NxosTelnet** | **String** | Returns the value of the nxosTelnet field. | [optional] 
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
$NiatelemetryNiaInventory = Initialize-IntersightNiatelemetryNiaInventory  -ClassId null `
 -ObjectType null `
 -AccountMoid null `
 -CreateTime null `
 -DomainGroupMoid null `
 -ModTime null `
 -Moid null `
 -Owners null `
 -SharedScope null `
 -Tags null `
 -VersionContext null `
 -Var0ClusterReplicationNetworkPolicy null `
 -Ancestors null `
 -Parent null `
 -PermissionResources null `
 -DisplayNames null `
 -Cpu null `
 -CrashResetLogs null `
 -CustomerDeviceConnector null `
 -DeviceDiscovery null `
 -DeviceHealth null `
 -DeviceId null `
 -DeviceName null `
 -DeviceType null `
 -DeviceUpTime null `
 -Disk null `
 -Dn null `
 -FexCount null `
 -InfraWiNodeCount null `
 -IpAddress null `
 -IsVirtualNode null `
 -LogInTime null `
 -LogOutTime null `
 -MacSecCount null `
 -MacSecFabCount null `
 -MacsecTotalCount null `
 -Memory null `
 -NodeId null `
 -NxosEvpnMacRoutes null `
 -NxosInterfaceBrief null `
 -NxosTelnet null `
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
$NiatelemetryNiaInventory | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

