# UuidpoolUniverseAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "uuidpool.Universe"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "uuidpool.Universe"]
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$UuidpoolUniverseAllOf = Initialize-IntersightUuidpoolUniverseAllOf  -ClassId null `
 -ObjectType null `
 -Account null
```

- Convert the resource to JSON
```powershell
$UuidpoolUniverseAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

