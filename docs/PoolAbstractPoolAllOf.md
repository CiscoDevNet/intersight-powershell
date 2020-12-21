# PoolAbstractPoolAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**Assigned** | **Int64** | Number of IDs that are currently assigned. | [optional] [readonly] 
**AssignmentOrder** | **String** | Assignment order decides the order in which the next identifier is allocated. * &#x60;sequential&#x60; - Identifiers are assigned in a sequential order. * &#x60;default&#x60; - Assignment order is decided by the system. | [optional] [default to "sequential"]
**Size** | **Int64** | Total number of identifiers in this pool. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$PoolAbstractPoolAllOf = Initialize-IntersightPoolAbstractPoolAllOf  -ClassId null `
 -ObjectType null `
 -Assigned null `
 -AssignmentOrder null `
 -Size null
```

- Convert the resource to JSON
```powershell
$PoolAbstractPoolAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

