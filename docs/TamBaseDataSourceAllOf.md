# TamBaseDataSourceAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**Name** | **String** | Name is used to unique identify and refer a given data source in an alert definition. | [optional] 
**Type** | **String** | Type of data source (for e.g. TextFsmTempalate based, Intersight API based etc.). * &#x60;nxos&#x60; - Collector type for this data collection is NXOS. * &#x60;intersightApi&#x60; - Collector type for this data collection is Intersight APIs. | [optional] [default to "nxos"]

## Examples

- Prepare the resource
```powershell
$TamBaseDataSourceAllOf = Initialize-IntersightTamBaseDataSourceAllOf  -ClassId null `
 -ObjectType null `
 -Name null `
 -Type null
```

- Convert the resource to JSON
```powershell
$TamBaseDataSourceAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

