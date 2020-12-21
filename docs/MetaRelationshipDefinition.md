# MetaRelationshipDefinition
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "meta.RelationshipDefinition"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "meta.RelationshipDefinition"]
**ApiAccess** | **String** | API access definition for this relationship. * &#x60;NoAccess&#x60; - The property is not accessible from the API. * &#x60;ReadOnly&#x60; - The value of the property is read-only.An HTTP 4xx status code is returned when the user sends a POST/PUT/PATCH request that containsa ReadOnly property. * &#x60;CreateOnly&#x60; - The value of the property can be set when the REST resource is created. It cannot be changed after object creation.An HTTP 4xx status code is returned when the user sends a POST/PUT/PATCH request that containsa CreateOnly property.CreateOnly properties are returned in the response body of HTTP GET requests. * &#x60;ReadWrite&#x60; - The property has read/write access. * &#x60;WriteOnly&#x60; - The value of the property can be set but it is never returned in the response body of supported HTTP methods.This settings is used for sensitive properties such as passwords. * &#x60;ReadOnCreate&#x60; - The value of the property is returned in the HTTP POST response body when the REST resource is created.The property is not writeable and cannot be queried through a GET request after the resource has been created. | [optional] [readonly] [default to "NoAccess"]
**Collection** | **Boolean** | Specifies whether the relationship is a collection. | [optional] [readonly] 
**Export** | **Boolean** | When turned off, the peer MO is not exported when the local MO is exported. | [optional] [readonly] 
**ExportWithPeer** | **Boolean** | When turned on, the local MO is exported when the peer is exported. | [optional] [readonly] 
**Name** | **String** | The name of the relationship. | [optional] [readonly] 
**PeerRelName** | **String** | Name of relationship in peer managed object. | [optional] [readonly] 
**Type** | **String** | Fully qualified type of the peer managed object. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$MetaRelationshipDefinition = Initialize-IntersightMetaRelationshipDefinition  -ClassId null `
 -ObjectType null `
 -ApiAccess null `
 -Collection null `
 -Export null `
 -ExportWithPeer null `
 -Name null `
 -PeerRelName null `
 -Type null
```

- Convert the resource to JSON
```powershell
$MetaRelationshipDefinition | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

