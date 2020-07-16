# TamSecurityAdvisoryDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**Description** | **String** | Brief description of details specified for an advisory type. | [optional] 
**BaseScore** | **Decimal** | CVSS version 3 base score for the security Advisory. | [optional] 
**CveIds** | **String[]** |  | [optional] 
**EnvironmentalScore** | **Decimal** | CVSS version 3 environmental score for the security Advisory. | [optional] 
**Status** | **String** | Cisco assigned status of the published advisory. Depends on whether the investigation is complete or on-going. | [optional] [default to "interim"]
**TemporalScore** | **Decimal** | CVSS version 3 temporal score for the security Advisory. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightTamSecurityAdvisoryDetails  -ClassId null `
 -ObjectType null `
 -Description null `
 -BaseScore null `
 -CveIds null `
 -EnvironmentalScore null `
 -Status null `
 -TemporalScore null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

