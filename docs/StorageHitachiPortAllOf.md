# StorageHitachiPortAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.HitachiPort"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.HitachiPort"]
**FabricMode** | **Boolean** | Fabric mode of the port. true, Set. false, Not set. | [optional] [readonly] 
**Ipv4Address** | **String** | IPv4 address. | [optional] [readonly] 
**Ipv6GlobalAddress** | **String** | IPv6 global address value. | [optional] [readonly] 
**Ipv6LinkLocalAddress** | **String** | IPv6 link local address value. | [optional] [readonly] 
**IsIpv6Enable** | **Boolean** | IPv6 mode. | [optional] [readonly] 
**LoopId** | **String** | The value set for the port loop ID (AL_PA). | [optional] [readonly] 
**PortConnection** | **String** | Topology setting for the port. | [optional] [readonly] 
**PortLunSecurity** | **Boolean** | LUN security setting for the port. | [optional] [readonly] 
**ShortportId** | **String** | Port ID (short) of the port. | [optional] [readonly] 
**TcpMtu** | **Int64** | Value of MTU for iSCSI communication. | [optional] [readonly] 
**Array** | [**StorageHitachiArrayRelationship**](StorageHitachiArrayRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$StorageHitachiPortAllOf = Initialize-IntersightStorageHitachiPortAllOf  -ClassId null `
 -ObjectType null `
 -FabricMode null `
 -Ipv4Address null `
 -Ipv6GlobalAddress null `
 -Ipv6LinkLocalAddress null `
 -IsIpv6Enable null `
 -LoopId null `
 -PortConnection null `
 -PortLunSecurity null `
 -ShortportId null `
 -TcpMtu null `
 -Array null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$StorageHitachiPortAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

