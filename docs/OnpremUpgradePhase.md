# OnpremUpgradePhase
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**ElapsedTime** | **Int64** | Elapsed time in seconds to complete the current upgrade phase. | [optional] [readonly] 
**EndTime** | **System.DateTime** | End date of the software upgrade phase. | [optional] [readonly] 
**Failed** | **Boolean** | Indicates if the upgrade phase has failed or not. | [optional] [readonly] 
**Message** | **String** | Status message set during the upgrade phase. | [optional] [readonly] 
**Name** | **String** | Name of the upgrade phase. | [optional] [readonly] [default to "init"]
**StartTime** | **System.DateTime** | Start date of the software upgrade phase. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightOnpremUpgradePhase  -ClassId null `
 -ObjectType null `
 -ElapsedTime null `
 -EndTime null `
 -Failed null `
 -Message null `
 -Name null `
 -StartTime null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

