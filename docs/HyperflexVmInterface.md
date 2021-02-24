# HyperflexVmInterface
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.VmInterface"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.VmInterface"]
**Bridge** | **String** | Virtual machine brige name of interface. | [optional] [readonly] 
**IpAddress** | **String[]** |  | [optional] 
**MacAddress** | **String** | Virtual machine interface mac address. | [optional] [readonly] 
**Model** | **String** | Virtual machine interface model. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$HyperflexVmInterface = Initialize-IntersightHyperflexVmInterface  -ClassId null `
 -ObjectType null `
 -Bridge null `
 -IpAddress null `
 -MacAddress null `
 -Model null
```

- Convert the resource to JSON
```powershell
$HyperflexVmInterface | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

