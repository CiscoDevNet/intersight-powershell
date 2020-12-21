# ApplianceReleaseNoteListAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Count** | **Int32** | The total number of &#39;appliance.ReleaseNote&#39; resources matching the request, accross all pages. The &#39;Count&#39; attribute is included when the HTTP GET request includes the &#39;$inlinecount&#39; parameter. | [optional] 
**Results** | [**ApplianceReleaseNote[]**](ApplianceReleaseNote.md) | The array of &#39;appliance.ReleaseNote&#39; resources matching the request. | [optional] 

## Examples

- Prepare the resource
```powershell
$ApplianceReleaseNoteListAllOf = Initialize-IntersightApplianceReleaseNoteListAllOf  -Count null `
 -Results null
```

- Convert the resource to JSON
```powershell
$ApplianceReleaseNoteListAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

