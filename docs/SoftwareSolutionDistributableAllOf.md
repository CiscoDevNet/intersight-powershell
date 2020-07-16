# SoftwareSolutionDistributableAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FilePath** | **String** | The path of the file in S3/minio bucket. | [optional] [readonly] 
**SolutionName** | **String** | The name of the solution in which the image belongs. | [optional] 
**SubType** | **String** | The type of the file like OS image, Script etc. | [optional] [default to "osimage"]
**Catalog** | [**SoftwarerepositoryCatalogRelationship**](SoftwarerepositoryCatalogRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightSoftwareSolutionDistributableAllOf  -FilePath null `
 -SolutionName null `
 -SubType null `
 -Catalog null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

