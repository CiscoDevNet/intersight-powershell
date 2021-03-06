# NiaapiReleaseRecommendAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**Cll** | **String** | Current long-lived release. | [optional] 
**Crr** | **String** | Customer recommended releases. | [optional] 
**VarPid** | **String** | Hardware model identificator. | [optional] 
**Ull** | **String** | Upcoming long-lived release. | [optional] 

## Examples

- Prepare the resource
```powershell
$NiaapiReleaseRecommendAllOf = Initialize-IntersightNiaapiReleaseRecommendAllOf  -ClassId null `
 -ObjectType null `
 -Cll null `
 -Crr null `
 -VarPid null `
 -Ull null
```

- Convert the resource to JSON
```powershell
$NiaapiReleaseRecommendAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

