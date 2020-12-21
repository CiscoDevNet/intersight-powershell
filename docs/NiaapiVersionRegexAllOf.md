# NiaapiVersionRegexAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "niaapi.VersionRegex"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "niaapi.VersionRegex"]
**Apic** | [**NiaapiVersionRegexPlatform**](NiaapiVersionRegexPlatform.md) |  | [optional] 
**Dcnm** | [**NiaapiVersionRegexPlatform**](NiaapiVersionRegexPlatform.md) |  | [optional] 
**Version** | **String** | Version number for the Version Regex data, also used as identity. | [optional] 

## Examples

- Prepare the resource
```powershell
$NiaapiVersionRegexAllOf = Initialize-IntersightNiaapiVersionRegexAllOf  -ClassId null `
 -ObjectType null `
 -Apic null `
 -Dcnm null `
 -Version null
```

- Convert the resource to JSON
```powershell
$NiaapiVersionRegexAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

