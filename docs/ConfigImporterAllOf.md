# ConfigImporterAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "config.Importer"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "config.Importer"]
**ImportPath** | **String** | The path to the archive in Intersight storage that has all the MOs to be imported. | [optional] 
**ImportSource** | **String** | The source of the archive in Intersight storage that has all the MOs to be imported. * &#x60;ImageRepo&#x60; - The &#39;ImageRepo&#39; source if the source of exporter archive is image repository. * &#x60;URL&#x60; - The &#39;URL&#39; source if the source of exported archive is a URL. | [optional] [default to "ImageRepo"]
**Name** | **String** | An identifier for the importer instance. | [optional] 
**SkipIntegrityChecks** | **Boolean** | Specifies whether integrity checks must be skipped. | [optional] [default to $false]
**Status** | **String** | Status of the import operation. * &#x60;&#x60; - The operation has not started. * &#x60;InProgress&#x60; - The operation is in progress. * &#x60;Success&#x60; - The operation has succeeded. * &#x60;Failed&#x60; - The operation has failed. * &#x60;RollBackInitiated&#x60; - The rollback has been inititiated for import failure. * &#x60;RollBackFailed&#x60; - The rollback has failed for import failure. * &#x60;RollbackCompleted&#x60; - The rollback has completed for import failure. * &#x60;RollbackAborted&#x60; - The rollback has been aborted for import failure. * &#x60;OperationTimedOut&#x60; - The operation has timed out. | [optional] [readonly] [default to ""]
**StatusMessage** | **String** | Status message associated with failures or progress indication. | [optional] [readonly] 
**ImportedItems** | [**ConfigImportedItemRelationship[]**](ConfigImportedItemRelationship.md) | An array of relationships to configImportedItem resources. | [optional] [readonly] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ConfigImporterAllOf = Initialize-IntersightConfigImporterAllOf  -ClassId null `
 -ObjectType null `
 -ImportPath null `
 -ImportSource null `
 -Name null `
 -SkipIntegrityChecks null `
 -Status null `
 -StatusMessage null `
 -ImportedItems null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$ConfigImporterAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

