# NiaapiVersionRegexPlatform
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "niaapi.VersionRegexPlatform"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "niaapi.VersionRegexPlatform"]
**Anyllregex** | **String** | All long live version Regex pattern. | [optional] 
**Currentlltrain** | [**NiaapiSoftwareRegex**](NiaapiSoftwareRegex.md) |  | [optional] 
**Latestsltrain** | [**NiaapiSoftwareRegex**](NiaapiSoftwareRegex.md) |  | [optional] 
**Sltrain** | [**NiaapiSoftwareRegex[]**](NiaapiSoftwareRegex.md) |  | [optional] 
**Upcominglltrain** | [**NiaapiSoftwareRegex**](NiaapiSoftwareRegex.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$NiaapiVersionRegexPlatform = Initialize-IntersightNiaapiVersionRegexPlatform  -ClassId null `
 -ObjectType null `
 -Anyllregex null `
 -Currentlltrain null `
 -Latestsltrain null `
 -Sltrain null `
 -Upcominglltrain null
```

- Convert the resource to JSON
```powershell
$NiaapiVersionRegexPlatform | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

