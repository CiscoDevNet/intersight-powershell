# StorageHitachiInitiator
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.HitachiInitiator"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.HitachiInitiator"]
**Iqn** | **String** | IQN (iSCSI qualified name). Can be up to 255 characters long and has the format iqn.yyyy-mm.naming-authority:unique name. | [optional] [readonly] 
**Name** | **String** | Name of the initiator represented in the storage array. | [optional] [readonly] 
**Type** | **String** | Initiator type, it can be FC or iSCSI. * &#x60;FC&#x60; - Fibre channel initiator type which contains WWN of an HBA on the host. * &#x60;iSCSI&#x60; - An iSCSI initiator type which contains the IQN (iSCSI Qualified Name) used by the host. * &#x60;Mixed&#x60; - Initiator type for systems using both FC and iSCSI connections. | [optional] [readonly] [default to "FC"]
**Wwn** | **String** | World wide name, 128 bit address represented in hexadecimal notation. For example, 51:4f:0c:50:14:1f:af:01:51:4f:0c:51:14:1f:af:01. | [optional] [readonly] 
**Wwpn** | **String** | World wide port name, 64 bit address represented in hexa decimal notation. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$StorageHitachiInitiator = Initialize-IntersightStorageHitachiInitiator  -ClassId null `
 -ObjectType null `
 -Iqn null `
 -Name null `
 -Type null `
 -Wwn null `
 -Wwpn null
```

- Convert the resource to JSON
```powershell
$StorageHitachiInitiator | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

