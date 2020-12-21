# UuidpoolBlockAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "uuidpool.Block"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "uuidpool.Block"]
**UuidSuffixBlock** | [**UuidpoolUuidBlock**](UuidpoolUuidBlock.md) |  | [optional] 
**Pool** | [**UuidpoolPoolRelationship**](UuidpoolPoolRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$UuidpoolBlockAllOf = Initialize-IntersightUuidpoolBlockAllOf  -ClassId null `
 -ObjectType null `
 -UuidSuffixBlock null `
 -Pool null
```

- Convert the resource to JSON
```powershell
$UuidpoolBlockAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

