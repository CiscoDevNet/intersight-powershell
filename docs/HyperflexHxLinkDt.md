# HyperflexHxLinkDt
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.HxLinkDt"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.HxLinkDt"]
**Comments** | **String** | A description that provides additional context for usage of the resource. | [optional] [readonly] 
**Href** | **String** | The URI of resource. Target URL for making REST call. | [optional] [readonly] 
**Method** | **String** | The HTTP method to use when making the REST call to this resource. * &#x60;POST&#x60; - The http verb for creating POST requests to a rest endpoint. * &#x60;GET&#x60; - The http verb for creating GET requests to a rest endpoint. * &#x60;PUT&#x60; - The http verb for creating PUT requests to a rest endpoint. * &#x60;DELETE&#x60; - The http verb for creating DELETE requests to a rest endpoint. | [optional] [readonly] [default to "POST"]
**Rel** | **String** | The relationship of the link to this resource. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$HyperflexHxLinkDt = Initialize-IntersightHyperflexHxLinkDt  -ClassId null `
 -ObjectType null `
 -Comments null `
 -Href null `
 -Method null `
 -Rel null
```

- Convert the resource to JSON
```powershell
$HyperflexHxLinkDt | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

