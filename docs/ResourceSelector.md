# ResourceSelector
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "resource.Selector"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "resource.Selector"]
**Selector** | **String** | ODATA filter to select resources. The group selector may include URLs of individual resource, or OData query with filters that match multiple queries. The URLs must be relative (i.e. do not include the host). | [optional] 

## Examples

- Prepare the resource
```powershell
$ResourceSelector = Initialize-IntersightResourceSelector  -ClassId null `
 -ObjectType null `
 -Selector null
```

- Convert the resource to JSON
```powershell
$ResourceSelector | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

