# ConfigImportedItemAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "config.ImportedItem"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "config.ImportedItem"]
**IsShared** | **Boolean** | Specifies whether this item MO was in shared scope or user scope when exported. | [optional] [readonly] 
**IsUpdated** | **Boolean** | Specifies whether this item MO was updated or created while importing in desired service. | [optional] [readonly] 
**Item** | [**ConfigMoRef**](ConfigMoRef.md) |  | [optional] 
**Name** | **String** | MO item identity (the moref corresponding to item) expressed as a string. | [optional] [readonly] 
**NewMoid** | **String** | Moid of the MO created/updated during import for the item. | [optional] [readonly] 
**ServiceVersion** | **String** | Version of the service that owned the item MO when the item was exported. | [optional] [readonly] 
**Status** | **String** | Status of the item&#39;s import operation. * &#x60;&#x60; - The operation has not started. * &#x60;InProgress&#x60; - The operation is in progress. * &#x60;Success&#x60; - The operation has succeeded. * &#x60;Failed&#x60; - The operation has failed. * &#x60;RollBackInitiated&#x60; - The rollback has been inititiated for import failure. * &#x60;RollBackFailed&#x60; - The rollback has failed for import failure. * &#x60;RollbackCompleted&#x60; - The rollback has completed for import failure. * &#x60;RollbackAborted&#x60; - The rollback has been aborted for import failure. * &#x60;OperationTimedOut&#x60; - The operation has timed out. | [optional] [readonly] [default to ""]
**StatusMessage** | **String** | Progress or error message for the MO&#39;s import operation. | [optional] [readonly] 
**Importer** | [**ConfigImporterRelationship**](ConfigImporterRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ConfigImportedItemAllOf = Initialize-IntersightConfigImportedItemAllOf  -ClassId null `
 -ObjectType null `
 -IsShared null `
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
$ConfigImportedItemAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

