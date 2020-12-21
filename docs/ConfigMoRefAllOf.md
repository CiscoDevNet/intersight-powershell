# ConfigMoRefAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "config.MoRef"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "config.MoRef"]
**Moid** | **String** | Moid represents the MoId of the object. | [optional] 

## Examples

- Prepare the resource
```powershell
$ConfigMoRefAllOf = Initialize-IntersightConfigMoRefAllOf  -ClassId null `
 -ObjectType null `
 -Moid null
```

- Convert the resource to JSON
```powershell
$ConfigMoRefAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

