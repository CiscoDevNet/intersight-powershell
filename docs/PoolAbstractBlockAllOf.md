# PoolAbstractBlockAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FreeBlockCount** | **Int64** | Free IDs that can be allocated in this block. | [optional] [readonly] 
**NextIdAllocator** | **Int64** | Moving counter to allocate the next identifier. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightPoolAbstractBlockAllOf  -FreeBlockCount null `
 -NextIdAllocator null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

