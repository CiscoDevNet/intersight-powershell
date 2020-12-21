# MacpoolIdBlockAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "macpool.IdBlock"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "macpool.IdBlock"]
**MacBlock** | [**MacpoolBlock**](MacpoolBlock.md) |  | [optional] 
**Pool** | [**MacpoolPoolRelationship**](MacpoolPoolRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$MacpoolIdBlockAllOf = Initialize-IntersightMacpoolIdBlockAllOf  -ClassId null `
 -ObjectType null `
 -MacBlock null `
 -Pool null
```

- Convert the resource to JSON
```powershell
$MacpoolIdBlockAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

