# ConfigExportedItemAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "config.ExportedItem"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "config.ExportedItem"]
**FileName** | **String** | Name of the file corresponding to item MO. | [optional] [readonly] 
**Item** | [**ConfigMoRef**](ConfigMoRef.md) |  | [optional] 
**Name** | **String** | MO item identity (the moref corresponding to item) expressed as a string. | [optional] [readonly] 
**ServiceVersion** | **String** | Version of the service that owns the item MO. | [optional] [readonly] 
**Status** | **String** | Status of the item&#39;s export operation. * &#x60;&#x60; - The operation has not started. * &#x60;InProgress&#x60; - The operation is in progress. * &#x60;Success&#x60; - The operation has succeeded. * &#x60;Failed&#x60; - The operation has failed. * &#x60;RollBackInitiated&#x60; - The rollback has been inititiated for import failure. * &#x60;RollBackFailed&#x60; - The rollback has failed for import failure. * &#x60;RollbackCompleted&#x60; - The rollback has completed for import failure. * &#x60;RollbackAborted&#x60; - The rollback has been aborted for import failure. * &#x60;OperationTimedOut&#x60; - The operation has timed out. | [optional] [readonly] [default to ""]
**StatusMessage** | **String** | Progress or error message for the MO&#39;s export operation. | [optional] [readonly] 
**Exporter** | [**ConfigExporterRelationship**](ConfigExporterRelationship.md) |  | [optional] 
**ParentItem** | [**ConfigExportedItemRelationship**](ConfigExportedItemRelationship.md) |  | [optional] 
**RelatedItems** | [**ConfigExportedItemRelationship[]**](ConfigExportedItemRelationship.md) | An array of relationships to configExportedItem resources. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$ConfigExportedItemAllOf = Initialize-IntersightConfigExportedItemAllOf  -ClassId null `
 -ObjectType null `
 -FileName null `
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
$ConfigExportedItemAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

