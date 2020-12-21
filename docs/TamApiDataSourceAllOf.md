# TamApiDataSourceAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "tam.ApiDataSource"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "tam.ApiDataSource"]
**MoType** | **String** | Type of Intersight managed object used as data source. | [optional] 
**Queries** | [**TamQueryEntry[]**](TamQueryEntry.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$TamApiDataSourceAllOf = Initialize-IntersightTamApiDataSourceAllOf  -ClassId null `
 -ObjectType null `
 -MoType null `
 -Queries null
```

- Convert the resource to JSON
```powershell
$TamApiDataSourceAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

