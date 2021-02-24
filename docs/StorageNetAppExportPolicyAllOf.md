# StorageNetAppExportPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.NetAppExportPolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.NetAppExportPolicy"]
**NetAppExportPolicyRule** | [**StorageNetAppExportPolicyRule[]**](StorageNetAppExportPolicyRule.md) |  | [optional] 
**PolicyId** | **Int64** | ID for the Export Policy. | [optional] [readonly] 
**Array** | [**StorageNetAppClusterRelationship**](StorageNetAppClusterRelationship.md) |  | [optional] 
**Tenant** | [**StorageNetAppStorageVmRelationship**](StorageNetAppStorageVmRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$StorageNetAppExportPolicyAllOf = Initialize-IntersightStorageNetAppExportPolicyAllOf  -ClassId null `
 -ObjectType null `
 -NetAppExportPolicyRule null `
 -PolicyId null `
 -Array null `
 -Tenant null
```

- Convert the resource to JSON
```powershell
$StorageNetAppExportPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

