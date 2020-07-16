# OsDistributionAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **String** | The name of the OS distribution such as ESXi, CentOS. | [optional] 
**SupportedEditions** | **String[]** |  | [optional] 
**Catalog** | [**OsCatalogRelationship**](OsCatalogRelationship.md) |  | [optional] 
**Version** | [**HclOperatingSystemRelationship**](HclOperatingSystemRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightOsDistributionAllOf  -Name null `
 -SupportedEditions null `
 -Catalog null `
 -Version null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

