# AdapterFcSettingsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "adapter.FcSettings"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "adapter.FcSettings"]
**FipEnabled** | **Boolean** | Status of FIP protocol on the adapter interfaces. | [optional] [default to $true]

## Examples

- Prepare the resource
```powershell
$AdapterFcSettingsAllOf = Initialize-IntersightAdapterFcSettingsAllOf  -ClassId null `
 -ObjectType null `
 -FipEnabled null
```

- Convert the resource to JSON
```powershell
$AdapterFcSettingsAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

