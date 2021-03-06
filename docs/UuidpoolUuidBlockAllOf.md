# UuidpoolUuidBlockAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "uuidpool.UuidBlock"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "uuidpool.UuidBlock"]
**VarFrom** | **String** | Starting UUID suffix of the block must be in hexadecimal format xxxx-xxxxxxxxxxxx. | [optional] 
**To** | **String** | Starting UUID suffix of the block must be in hexadecimal format xxxx-xxxxxxxxxxxx. | [optional] 

## Examples

- Prepare the resource
```powershell
$UuidpoolUuidBlockAllOf = Initialize-IntersightUuidpoolUuidBlockAllOf  -ClassId null `
 -ObjectType null `
 -VarFrom null `
 -To null
```

- Convert the resource to JSON
```powershell
$UuidpoolUuidBlockAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

