# PoolAbstractPoolMemberAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**Assigned** | **Boolean** | Boolean to represent whether the ID is assigned or not. | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$PoolAbstractPoolMemberAllOf = Initialize-IntersightPoolAbstractPoolMemberAllOf  -ClassId null `
 -ObjectType null `
 -Assigned null
```

- Convert the resource to JSON
```powershell
$PoolAbstractPoolMemberAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

