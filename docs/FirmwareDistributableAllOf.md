# FirmwareDistributableAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FileLocation** | **String** | The file location of the distributable. | [optional] 
**ImageCategory** | **String** | The category into which the distributable falls into according to the supported platform series. For e.g.; C-Series/B-Series/Infrastructure. | [optional] 
**Origin** | **String** | The source of the distributable. If it has been created by the user or system. | [optional] [default to "System"]
**Catalog** | [**SoftwarerepositoryCatalogRelationship**](SoftwarerepositoryCatalogRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFirmwareDistributableAllOf  -FileLocation null `
 -ImageCategory null `
 -Origin null `
 -Catalog null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

