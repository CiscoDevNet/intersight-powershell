# StorageHitachiInitiatorAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.HitachiInitiator"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.HitachiInitiator"]
**Wwpn** | **String** | World wide port name, 64 bit address represented in hexa decimal notation. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$StorageHitachiInitiatorAllOf = Initialize-IntersightStorageHitachiInitiatorAllOf  -ClassId null `
 -ObjectType null `
 -Wwpn null
```

- Convert the resource to JSON
```powershell
$StorageHitachiInitiatorAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

