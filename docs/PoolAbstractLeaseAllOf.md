# PoolAbstractLeaseAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**AllocationType** | **String** | Type of the lease allocation either static or dynamic (i.e via pool). * &#x60;dynamic&#x60; - Identifiers to be allocated by system. * &#x60;static&#x60; - Identifiers are assigned by the user. | [optional] [default to "dynamic"]

## Examples

- Prepare the resource
```powershell
$PoolAbstractLeaseAllOf = Initialize-IntersightPoolAbstractLeaseAllOf  -ClassId null `
 -ObjectType null `
 -AllocationType null
```

- Convert the resource to JSON
```powershell
$PoolAbstractLeaseAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

