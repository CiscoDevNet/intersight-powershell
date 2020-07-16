# HyperflexServerFirmwareVersionAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ServerFirmwareVersionEntries** | [**HyperflexServerFirmwareVersionEntry[]**](HyperflexServerFirmwareVersionEntry.md) |  | [optional] 
**AppCatalog** | [**HyperflexAppCatalogRelationship**](HyperflexAppCatalogRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHyperflexServerFirmwareVersionAllOf  -ServerFirmwareVersionEntries null `
 -AppCatalog null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

