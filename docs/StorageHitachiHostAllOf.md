# StorageHitachiHostAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.HitachiHost"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.HitachiHost"]
**AuthenticationMode** | **String** | Authentication mode for the iSCSI target. * &#x60;N/A&#x60; - Not available. * &#x60;CHAP&#x60; - CHAP-authentication mode. * &#x60;NONE&#x60; - No-authentication mode. * &#x60;BOTH&#x60; - Comply with Host Setting. | [optional] [readonly] [default to "N/A"]
**HostGroupId** | **String** | ID of the host group. | [optional] [readonly] 
**HostGroupNumber** | **Int64** | Host group number for this host. | [optional] 
**HostModeOptions** | **Int64[]** |  | [optional] 
**IsChapMutual** | **Boolean** | Mutual CHAP setting that is Enabled or Disabled. | [optional] [readonly] 
**IscsiName** | **String** | IQN (iSCSI qualified name). Can be up to 255 characters long. | [optional] [readonly] 
**PortId** | **String** | Port ID of the host group. | [optional] [readonly] 
**PortLunSecurity** | **Boolean** | LUN security setting for the port. | [optional] [readonly] 
**Type** | **String** | Host Group type, it can be FC or iSCSI. * &#x60;FC&#x60; - Port supports fibre channel protocol. * &#x60;iSCSI&#x60; - Port supports iSCSI protocol. * &#x60;FCoE&#x60; - Port supports fibre channel over ethernet protocol. | [optional] [readonly] [default to "FC"]
**Wwn** | **String** | World wide port name, 64 bit address represented in hexa decimal notation. | [optional] [readonly] 
**Array** | [**StorageHitachiArrayRelationship**](StorageHitachiArrayRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$StorageHitachiHostAllOf = Initialize-IntersightStorageHitachiHostAllOf  -ClassId null `
 -ObjectType null `
 -AuthenticationMode null `
 -HostGroupId null `
 -HostGroupNumber null `
 -HostModeOptions null `
 -IsChapMutual null `
 -IscsiName null `
 -PortId null `
 -PortLunSecurity null `
 -Type null `
 -Wwn null `
 -Array null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$StorageHitachiHostAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

