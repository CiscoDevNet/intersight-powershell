# VnicArfsSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "vnic.ArfsSettings"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "vnic.ArfsSettings"]
**Enabled** | **Boolean** | Status of Accelerated Receive Flow Steering on the virtual ethernet interface. | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$VnicArfsSettings = Initialize-IntersightVnicArfsSettings  -ClassId null `
 -ObjectType null `
 -Enabled null
```

- Convert the resource to JSON
```powershell
$VnicArfsSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

