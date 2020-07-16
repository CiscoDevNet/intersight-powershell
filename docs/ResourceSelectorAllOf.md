# ResourceSelectorAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Selector** | **String** | ODATA filter to select resources. The group selector may include URLs of individual resource, or OData query with filters that match multiple queries. The URLs must be relative (i.e. do not include the host). | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightResourceSelectorAllOf  -Selector null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

