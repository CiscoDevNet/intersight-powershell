# VnicCdn
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "vnic.Cdn"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "vnic.Cdn"]
**Source** | **String** | Source of the CDN. It can either be user specified or be the same as the vNIC name. * &#x60;vnic&#x60; - Source of the CDN is the same as the vNIC name. * &#x60;user&#x60; - Source of the CDN is specified by the user. | [optional] [default to "vnic"]
**Value** | **String** | The CDN value entered in case of user defined mode. | [optional] 

## Examples

- Prepare the resource
```powershell
$VnicCdn = Initialize-IntersightVnicCdn  -ClassId null `
 -ObjectType null `
 -Source null `
 -Value null
```

- Convert the resource to JSON
```powershell
$VnicCdn | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

