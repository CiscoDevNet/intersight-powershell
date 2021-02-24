# StorageNetAppExportPolicyRule
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.NetAppExportPolicyRule"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.NetAppExportPolicyRule"]
**ClientMatch** | **String[]** |  | [optional] 
**Index** | **Int64** | Position of export rule in the list of rules. | [optional] 
**RoRule** | **String[]** |  | [optional] 
**RwRule** | **String[]** |  | [optional] 
**SuperUser** | **String[]** |  | [optional] 
**User** | **String** | Export Policy rule that are mapped to this User ID. | [optional] 

## Examples

- Prepare the resource
```powershell
$StorageNetAppExportPolicyRule = Initialize-IntersightStorageNetAppExportPolicyRule  -ClassId null `
 -ObjectType null `
 -ClientMatch null `
 -Index null `
 -RoRule null `
 -RwRule null `
 -SuperUser null `
 -User null
```

- Convert the resource to JSON
```powershell
$StorageNetAppExportPolicyRule | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

