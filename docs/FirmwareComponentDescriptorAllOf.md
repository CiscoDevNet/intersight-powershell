# FirmwareComponentDescriptorAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BrandString** | **String** | The brand string of the endpoint for which this capability information is applicable. | [optional] 
**Label** | **String** | The label type for the component. | [optional] 
**Revision** | **String** | The revision for the component. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFirmwareComponentDescriptorAllOf  -BrandString null `
 -Label null `
 -Revision null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

