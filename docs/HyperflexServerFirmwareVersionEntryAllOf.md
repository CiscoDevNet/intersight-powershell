# HyperflexServerFirmwareVersionEntryAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.ServerFirmwareVersionEntry"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.ServerFirmwareVersionEntry"]
**Constraint** | [**HyperflexAppSettingConstraint**](HyperflexAppSettingConstraint.md) |  | [optional] 
**ServerPlatform** | **String** | The server platform type that is applicable for the server firmware bundle version. * &#x60;M5&#x60; - M5 generation of UCS server. * &#x60;M4&#x60; - M4 generation of UCS server. | [optional] [default to "M5"]
**Version** | **String** | The server firmware bundle version. | [optional] 
**ServerFirmwareVersion** | [**HyperflexServerFirmwareVersionRelationship**](HyperflexServerFirmwareVersionRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexServerFirmwareVersionEntryAllOf = Initialize-IntersightHyperflexServerFirmwareVersionEntryAllOf  -ClassId null `
 -ObjectType null `
 -Constraint null `
 -ServerPlatform null `
 -Version null `
 -ServerFirmwareVersion null
```

- Convert the resource to JSON
```powershell
$HyperflexServerFirmwareVersionEntryAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

