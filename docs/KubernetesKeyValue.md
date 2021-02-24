# KubernetesKeyValue
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "kubernetes.KeyValue"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "kubernetes.KeyValue"]
**Key** | **String** | Key or property name in a key/value pair. | [optional] 
**Value** | **String** | Property value in a key/value pair. | [optional] 

## Examples

- Prepare the resource
```powershell
$KubernetesKeyValue = Initialize-IntersightKubernetesKeyValue  -ClassId null `
 -ObjectType null `
 -Key null `
 -Value null
```

- Convert the resource to JSON
```powershell
$KubernetesKeyValue | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

