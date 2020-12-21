# VnicNvgreSettingsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "vnic.NvgreSettings"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "vnic.NvgreSettings"]
**Enabled** | **Boolean** | Status of the Network Virtualization using Generic Routing Encapsulation on the virtual ethernet interface. | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$VnicNvgreSettingsAllOf = Initialize-IntersightVnicNvgreSettingsAllOf  -ClassId null `
 -ObjectType null `
 -Enabled null
```

- Convert the resource to JSON
```powershell
$VnicNvgreSettingsAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

