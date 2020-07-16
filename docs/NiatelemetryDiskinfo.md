# NiatelemetryDiskinfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**Free** | **Int64** | The free disk capacity, currently the type of this field is set to integer. This determines how much memory is free in Bytes. | [optional] 
**Name** | **String** | Disk Name used to identified the disk usage record. This determines the name of the disk partition that is inventoried. | [optional] 
**Total** | **Int64** | The total disk capacity, it should be the sum of free and used, currently the type of this field is set to integer. This determines the total memory for this partition. | [optional] 
**Used** | **Int64** | The used disk capacity, currently the type of this field is set to integer. This determines how much memory is used in Bytes. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightNiatelemetryDiskinfo  -ClassId null `
 -ObjectType null `
 -Free null `
 -Name null `
 -Total null `
 -Used null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

