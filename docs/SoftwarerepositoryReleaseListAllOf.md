# SoftwarerepositoryReleaseListAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Count** | **Int32** | The total number of &#39;softwarerepository.Release&#39; resources matching the request, accross all pages. The &#39;Count&#39; attribute is included when the HTTP GET request includes the &#39;$inlinecount&#39; parameter. | [optional] 
**Results** | [**SoftwarerepositoryRelease[]**](SoftwarerepositoryRelease.md) | The array of &#39;softwarerepository.Release&#39; resources matching the request. | [optional] 

## Examples

- Prepare the resource
```powershell
$SoftwarerepositoryReleaseListAllOf = Initialize-IntersightSoftwarerepositoryReleaseListAllOf  -Count null `
 -Results null
```

- Convert the resource to JSON
```powershell
$SoftwarerepositoryReleaseListAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

