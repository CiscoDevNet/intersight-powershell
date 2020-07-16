# SoftwarerepositoryReleaseAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReleaseDate** | **System.DateTime** | The date when the file was released or distributed by its vendor. | [optional] 
**ReleaseNotesUrl** | **String** | The URL for the release notes of this image. | [optional] 
**SupportedModels** | **String[]** |  | [optional] 
**Type** | **String** | The platform release type for which the images are released. This can be a fabric switch or compute server hardware. | [optional] [default to "FabricSwitch"]
**Version** | **String** | Cisco provided release version. | [optional] 
**Catalog** | [**SoftwarerepositoryCatalogRelationship**](SoftwarerepositoryCatalogRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightSoftwarerepositoryReleaseAllOf  -ReleaseDate null `
 -ReleaseNotesUrl null `
 -SupportedModels null `
 -Type null `
 -Version null `
 -Catalog null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

