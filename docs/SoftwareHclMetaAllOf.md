# SoftwareHclMetaAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContentType** | **String** | The type of content that the Json file holds (Incremental or full dump). | [optional] [default to "Full"]
**Catalog** | [**SoftwarerepositoryCatalogRelationship**](SoftwarerepositoryCatalogRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightSoftwareHclMetaAllOf  -ContentType null `
 -Catalog null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

