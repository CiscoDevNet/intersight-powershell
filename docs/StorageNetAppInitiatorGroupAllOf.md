# StorageNetAppInitiatorGroupAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.NetAppInitiatorGroup"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.NetAppInitiatorGroup"]
**Protocol** | **String** | Initiator group protocol. * &#x60;FCP&#x60; - Fibre channel initiator type which contains WWN of an HBA on the host. * &#x60;iSCSI&#x60; - An iSCSI initiator type used by the host. * &#x60;mixed&#x60; - For systems using both FC and iSCSI connections to the same LUN, create two igroups, one for FC and one for iSCSI. Then map the LUN to both igroups. | [optional] [readonly] [default to "FCP"]
**Uuid** | **String** | UUID of the LUN. | [optional] [readonly] 
**Tenant** | [**StorageNetAppStorageVmRelationship**](StorageNetAppStorageVmRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$StorageNetAppInitiatorGroupAllOf = Initialize-IntersightStorageNetAppInitiatorGroupAllOf  -ClassId null `
 -ObjectType null `
 -Protocol null `
 -Uuid null `
 -Tenant null
```

- Convert the resource to JSON
```powershell
$StorageNetAppInitiatorGroupAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

