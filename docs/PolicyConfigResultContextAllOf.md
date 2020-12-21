# PolicyConfigResultContextAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "policy.ConfigResultContext"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "policy.ConfigResultContext"]
**EntityData** | [**AnyType**](.md) | The data of the object present in config result context. | [optional] 
**EntityMoid** | **String** | The Moid of the object present in config result context. | [optional] 
**EntityName** | **String** | The name of the object present in config result context. | [optional] 
**EntityType** | **String** | The type of the object present in config result context. | [optional] 

## Examples

- Prepare the resource
```powershell
$PolicyConfigResultContextAllOf = Initialize-IntersightPolicyConfigResultContextAllOf  -ClassId null `
 -ObjectType null `
 -EntityData null `
 -EntityMoid null `
 -EntityName null `
 -EntityType null
```

- Convert the resource to JSON
```powershell
$PolicyConfigResultContextAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

