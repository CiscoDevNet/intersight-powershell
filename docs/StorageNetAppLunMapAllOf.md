# StorageNetAppLunMapAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.NetAppLunMap"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.NetAppLunMap"]
**Uuid** | **String** | UUID of the LUN. | [optional] [readonly] 
**VarHost** | [**StorageNetAppInitiatorGroupRelationship[]**](StorageNetAppInitiatorGroupRelationship.md) | An array of relationships to storageNetAppInitiatorGroup resources. | [optional] [readonly] 
**Tenant** | [**StorageNetAppStorageVmRelationship**](StorageNetAppStorageVmRelationship.md) |  | [optional] 
**Volume** | [**StorageNetAppLunRelationship**](StorageNetAppLunRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$StorageNetAppLunMapAllOf = Initialize-IntersightStorageNetAppLunMapAllOf  -ClassId null `
 -ObjectType null `
 -Uuid null `
 -VarHost null `
 -Tenant null `
 -Volume null
```

- Convert the resource to JSON
```powershell
$StorageNetAppLunMapAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

