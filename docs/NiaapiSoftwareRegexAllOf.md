# NiaapiSoftwareRegexAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "niaapi.SoftwareRegex"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "niaapi.SoftwareRegex"]
**Regex** | **String** | Regular Expression pattern used to reconginze the version string. | [optional] 
**SoftwareVersion** | **String** | Software release. A set of Software releases seperated by comma which can be recongized by according Regex pattern. | [optional] 

## Examples

- Prepare the resource
```powershell
$NiaapiSoftwareRegexAllOf = Initialize-IntersightNiaapiSoftwareRegexAllOf  -ClassId null `
 -ObjectType null `
 -Regex null `
 -SoftwareVersion null
```

- Convert the resource to JSON
```powershell
$NiaapiSoftwareRegexAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

