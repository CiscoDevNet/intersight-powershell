# TechsupportmanagementNiaParamAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CollectionLevel** | **Int32** | CollectionLevel controls the size / depth of the tech support files collected. | [optional] [default to 1]
**Filename** | **String** | Filename specifies an individual filename to collect from the endpoint. | [optional] 
**ForceFresh** | **Boolean** | ForceFresh controls whether to return pre-collected files or force the collection of new files. | [optional] 
**Pids** | **String[]** |  | [optional] 
**SerialNumbers** | **String[]** |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightTechsupportmanagementNiaParamAllOf  -CollectionLevel null `
 -Filename null `
 -ForceFresh null `
 -Pids null `
 -SerialNumbers null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

