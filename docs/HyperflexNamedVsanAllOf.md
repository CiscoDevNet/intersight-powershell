# HyperflexNamedVsanAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.NamedVsan"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.NamedVsan"]
**Name** | **String** | The name of the VSAN. The name can be from 1 to 32 characters long and can contain a combination of alphanumeric characters, underscores, and hyphens. | [optional] 
**VsanId** | **Int64** | The ID of the named VSAN. The ID can be any number between 1 and 4093, inclusive. | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexNamedVsanAllOf = Initialize-IntersightHyperflexNamedVsanAllOf  -ClassId null `
 -ObjectType null `
 -Name null `
 -VsanId null
```

- Convert the resource to JSON
```powershell
$HyperflexNamedVsanAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

