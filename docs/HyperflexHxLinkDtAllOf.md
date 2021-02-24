# HyperflexHxLinkDtAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.HxLinkDt"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.HxLinkDt"]
**Comments** | **String** | Comment for this HyperFlex resource. | [optional] [readonly] 
**Href** | **String** | URI of resource. Target URL for making REST call. | [optional] [readonly] 
**Method** | **String** | HTTP verb that this HyperFlex link DT is referring to. * &#x60;POST&#x60; - HTTP verb POST for this task definition. * &#x60;GET&#x60; - HTTP verb GET for this task definition. * &#x60;PUT&#x60; - HTTP verb PUT for this task definition. * &#x60;DELETE&#x60; - HTTP verb DELETE for this task definition. | [optional] [readonly] [default to "POST"]
**Rel** | **String** | Relationship of link to this resource. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$HyperflexHxLinkDtAllOf = Initialize-IntersightHyperflexHxLinkDtAllOf  -ClassId null `
 -ObjectType null `
 -Comments null `
 -Href null `
 -Method null `
 -Rel null
```

- Convert the resource to JSON
```powershell
$HyperflexHxLinkDtAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

