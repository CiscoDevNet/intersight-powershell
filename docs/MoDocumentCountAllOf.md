# MoDocumentCountAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Count** | **Int32** | The total number of resources matching the query filter, accross all pages. | [optional] 

## Examples

- Prepare the resource
```powershell
$MoDocumentCountAllOf = Initialize-IntersightMoDocumentCountAllOf  -Count null
```

- Convert the resource to JSON
```powershell
$MoDocumentCountAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

