# ConfigExporterAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "config.Exporter"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "config.Exporter"]
**DownloadPath** | **String** | Pre-signed URL to download the exported package, if the export operation has completed successfully. Regenerated during a GET request, if the existing pre-signed URL has expired. | [optional] [readonly] 
**Items** | [**ConfigMoRef[]**](ConfigMoRef.md) |  | [optional] 
**Name** | **String** | An identifier for the exporter instance. | [optional] 
**Status** | **String** | Status of the export operation. * &#x60;&#x60; - The operation has not started. * &#x60;InProgress&#x60; - The operation is in progress. * &#x60;Success&#x60; - The operation has succeeded. * &#x60;Failed&#x60; - The operation has failed. * &#x60;RollBackInitiated&#x60; - The rollback has been inititiated for import failure. * &#x60;RollBackFailed&#x60; - The rollback has failed for import failure. * &#x60;RollbackCompleted&#x60; - The rollback has completed for import failure. * &#x60;RollbackAborted&#x60; - The rollback has been aborted for import failure. * &#x60;OperationTimedOut&#x60; - The operation has timed out. | [optional] [readonly] [default to ""]
**StatusMessage** | **String** | Status message associated with failures or progress indication. | [optional] [readonly] 
**ExportedItems** | [**ConfigExportedItemRelationship[]**](ConfigExportedItemRelationship.md) | An array of relationships to configExportedItem resources. | [optional] [readonly] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ConfigExporterAllOf = Initialize-IntersightConfigExporterAllOf  -ClassId null `
 -ObjectType null `
 -DownloadPath null `
 -Items null `
 -Name null `
 -Status null `
 -StatusMessage null `
 -ExportedItems null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$ConfigExporterAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

