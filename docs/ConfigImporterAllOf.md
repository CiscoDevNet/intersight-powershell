# ConfigImporterAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ImportPath** | **String** | The path to the archive in Intersight storage that has all the MOs to be imported. | [optional] 
**ImportSource** | **String** | The source of the archive in Intersight storage that has all the MOs to be imported. | [optional] [default to "ImageRepo"]
**Name** | **String** | An identifier for the importer instance. | [optional] 
**SkipIntegrityChecks** | **Boolean** | Specifies whether integrity checks must be skipped. | [optional] 
**Status** | **String** | Status of the import operation. | [optional] [readonly] [default to ""]
**StatusMessage** | **String** | Status message associated with failures or progress indication. | [optional] [readonly] 
**ImportedItems** | [**ConfigImportedItemRelationship[]**](ConfigImportedItemRelationship.md) | An array of relationships to configImportedItem resources. | [optional] [readonly] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightConfigImporterAllOf  -ImportPath null `
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
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

