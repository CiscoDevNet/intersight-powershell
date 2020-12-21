# VnicPlogiSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "vnic.PlogiSettings"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "vnic.PlogiSettings"]
**Retries** | **Int64** | The number of times that the system tries to log in to a port after the first failure. | [optional] [default to 8]
**Timeout** | **Int64** | The number of milliseconds that the system waits before it tries to log in again. | [optional] [default to 20000]

## Examples

- Prepare the resource
```powershell
$VnicPlogiSettings = Initialize-IntersightVnicPlogiSettings  -ClassId null `
 -ObjectType null `
 -Retries null `
 -Timeout null
```

- Convert the resource to JSON
```powershell
$VnicPlogiSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

