# MoBaseResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectType** | **String** | A discriminator value to disambiguate the schema of a HTTP GET response body. | 

## Examples

- Prepare the resource
```powershell
$MoBaseResponse = Initialize-IntersightMoBaseResponse  -ObjectType null
```

- Convert the resource to JSON
```powershell
$MoBaseResponse | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

