# ContentComplexType
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "content.ComplexType"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "content.ComplexType"]
**Name** | **String** | The unique name of this complex type within the grammar specification. | [optional] 
**Parameters** | [**ContentBaseParameter[]**](ContentBaseParameter.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ContentComplexType = Initialize-IntersightContentComplexType  -ClassId null `
 -ObjectType null `
 -Name null `
 -Parameters null
```

- Convert the resource to JSON
```powershell
$ContentComplexType | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

