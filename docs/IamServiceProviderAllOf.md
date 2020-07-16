# IamServiceProviderAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntityId** | **String** | Entity ID of the Intersight Service Provider. In SAML, the entity ID uniquely identifies the IdP/Service Provider. | [optional] [readonly] 
**Metadata** | **String** | Metadata of the Intersight Service Provider. User downloads the Intersight Service Provider metadata and integrates it with their IdP for authentication. | [optional] [readonly] 
**Name** | **String** | Name of the Intersight Service Provider. | [optional] [readonly] 
**System** | [**IamSystemRelationship**](IamSystemRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIamServiceProviderAllOf  -EntityId null `
 -Metadata null `
 -Name null `
 -System null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

