# ConfigImportedItemAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsShared** | **Boolean** | Specifies whether this item MO was in shared scope or user scope when exported. | [optional] [readonly] 
**IsUpdated** | **Boolean** | Specifies whether this item MO was updated or created while importing in desired service. | [optional] [readonly] 
**Item** | [**ConfigMoRef**](ConfigMoRef.md) |  | [optional] 
**Name** | **String** | MO item identity (the moref corresponding to item) expressed as a string. | [optional] [readonly] 
**NewMoid** | **String** | Moid of the MO created/updated during import for the item. | [optional] [readonly] 
**ServiceVersion** | **String** | Version of the service that owned the item MO when the item was exported. | [optional] [readonly] 
**Status** | **String** | Status of the item&#39;s import operation. | [optional] [readonly] [default to ""]
**StatusMessage** | **String** | Progress or error message for the MO&#39;s import operation. | [optional] [readonly] 
**Importer** | [**ConfigImporterRelationship**](ConfigImporterRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightConfigImportedItemAllOf  -IsShared null `
 -IsUpdated null `
 -Item null `
 -Name null `
 -NewMoid null `
 -ServiceVersion null `
 -Status null `
 -StatusMessage null `
 -Importer null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

