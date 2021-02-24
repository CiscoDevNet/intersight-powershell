# StorageNetAppNodeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.NetAppNode"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.NetAppNode"]
**Health** | **Boolean** | Health of NetApp Node. | [optional] [readonly] 
**Systemid** | **String** | System id of NetApp Node. | [optional] [readonly] 
**Uuid** | **String** | UUID of NetApp Node. | [optional] [readonly] 
**Array** | [**StorageNetAppClusterRelationship**](StorageNetAppClusterRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$StorageNetAppNodeAllOf = Initialize-IntersightStorageNetAppNodeAllOf  -ClassId null `
 -ObjectType null `
 -Health null `
 -Systemid null `
 -Uuid null `
 -Array null
```

- Convert the resource to JSON
```powershell
$StorageNetAppNodeAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

