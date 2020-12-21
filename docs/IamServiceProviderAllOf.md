# IamServiceProviderAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iam.ServiceProvider"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iam.ServiceProvider"]
**EntityId** | **String** | Entity ID of the Intersight Service Provider. In SAML, the entity ID uniquely identifies the IdP/Service Provider. | [optional] [readonly] 
**Metadata** | **String** | Metadata of the Intersight Service Provider. User downloads the Intersight Service Provider metadata and integrates it with their IdP for authentication. | [optional] [readonly] 
**Name** | **String** | Name of the Intersight Service Provider. | [optional] [readonly] 
**System** | [**IamSystemRelationship**](IamSystemRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$IamServiceProviderAllOf = Initialize-IntersightIamServiceProviderAllOf  -ClassId null `
 -ObjectType null `
 -EntityId null `
 -Metadata null `
 -Name null `
 -System null
```

- Convert the resource to JSON
```powershell
$IamServiceProviderAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

