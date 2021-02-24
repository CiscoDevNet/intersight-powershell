# ConnectorScopedInventoryAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**NamingProperty** | **String** | A property that uniquely identifies the object to be inventoried as a part of the scoped inventory. | [optional] 
**Queries** | [**AnyType**](.md) | Set of queries to identify objects to be inventoried as part of this scoped inventory action. | [optional] 
**Type** | **String** | Type of the object for which scoped inventory needs to be run. | [optional] 
**Values** | **String[]** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ConnectorScopedInventoryAllOf = Initialize-IntersightConnectorScopedInventoryAllOf  -ClassId null `
 -ObjectType null `
 -NamingProperty null `
 -Queries null `
 -Type null `
 -Values null
```

- Convert the resource to JSON
```powershell
$ConnectorScopedInventoryAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

