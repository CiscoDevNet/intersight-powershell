# ConfigExporterAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DownloadPath** | **String** | Pre-signed URL to download the exported package, if the export operation has completed successfully. Regenerated during a GET request, if the existing pre-signed URL has expired. | [optional] [readonly] 
**Items** | [**ConfigMoRef[]**](ConfigMoRef.md) |  | [optional] 
**Name** | **String** | An identifier for the exporter instance. | [optional] 
**Status** | **String** | Status of the export operation. | [optional] [readonly] [default to ""]
**StatusMessage** | **String** | Status message associated with failures or progress indication. | [optional] [readonly] 
**ExportedItems** | [**ConfigExportedItemRelationship[]**](ConfigExportedItemRelationship.md) | An array of relationships to configExportedItem resources. | [optional] [readonly] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightConfigExporterAllOf  -DownloadPath null `
 -Items null `
 -Name null `
 -Status null `
 -StatusMessage null `
 -ExportedItems null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

