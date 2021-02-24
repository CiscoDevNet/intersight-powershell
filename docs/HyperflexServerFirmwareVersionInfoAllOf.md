# HyperflexServerFirmwareVersionInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.ServerFirmwareVersionInfo"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.ServerFirmwareVersionInfo"]
**ServerPlatform** | **String** | The platform type for UCS server. * &#x60;M5&#x60; - M5 generation of UCS server. * &#x60;M4&#x60; - M4 generation of UCS server. | [optional] [default to "M5"]
**Version** | **String** | The server firmware bundle version. | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexServerFirmwareVersionInfoAllOf = Initialize-IntersightHyperflexServerFirmwareVersionInfoAllOf  -ClassId null `
 -ObjectType null `
 -ServerPlatform null `
 -Version null
```

- Convert the resource to JSON
```powershell
$HyperflexServerFirmwareVersionInfoAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

