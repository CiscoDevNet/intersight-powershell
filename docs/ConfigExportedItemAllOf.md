# ConfigExportedItemAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FileName** | **String** | Name of the file corresponding to item MO. | [optional] [readonly] 
**Item** | [**ConfigMoRef**](ConfigMoRef.md) |  | [optional] 
**Name** | **String** | MO item identity (the moref corresponding to item) expressed as a string. | [optional] [readonly] 
**ServiceVersion** | **String** | Version of the service that owns the item MO. | [optional] [readonly] 
**Status** | **String** | Status of the item&#39;s export operation. | [optional] [readonly] [default to ""]
**StatusMessage** | **String** | Progress or error message for the MO&#39;s export operation. | [optional] [readonly] 
**Exporter** | [**ConfigExporterRelationship**](ConfigExporterRelationship.md) |  | [optional] 
**ParentItem** | [**ConfigExportedItemRelationship**](ConfigExportedItemRelationship.md) |  | [optional] 
**RelatedItems** | [**ConfigExportedItemRelationship[]**](ConfigExportedItemRelationship.md) | An array of relationships to configExportedItem resources. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightConfigExportedItemAllOf  -FileName null `
 -Item null `
 -Name null `
 -ServiceVersion null `
 -Status null `
 -StatusMessage null `
 -Exporter null `
 -ParentItem null `
 -RelatedItems null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

