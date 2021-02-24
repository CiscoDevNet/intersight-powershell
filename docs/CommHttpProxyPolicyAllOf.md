# CommHttpProxyPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "comm.HttpProxyPolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "comm.HttpProxyPolicy"]
**ClusterProfiles** | [**HyperflexClusterProfileRelationship[]**](HyperflexClusterProfileRelationship.md) | An array of relationships to hyperflexClusterProfile resources. | [optional] 

## Examples

- Prepare the resource
```powershell
$CommHttpProxyPolicyAllOf = Initialize-IntersightCommHttpProxyPolicyAllOf  -ClassId null `
 -ObjectType null `
 -ClusterProfiles null
```

- Convert the resource to JSON
```powershell
$CommHttpProxyPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

