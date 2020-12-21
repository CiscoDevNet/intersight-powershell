# CmrfCmRf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**Moid** | **String** | The Moid of the referenced REST resource. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$CmrfCmRf = Initialize-IntersightCmrfCmRf  -ClassId null `
 -ObjectType null `
 -Moid null
```

- Convert the resource to JSON
```powershell
$CmrfCmRf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

