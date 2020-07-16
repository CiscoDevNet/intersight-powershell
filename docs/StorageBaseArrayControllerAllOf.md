# StorageBaseArrayControllerAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **String** | Storage array controller name. | [optional] [readonly] 
**OperationalMode** | **String** | Controller running mode, Primary or Secondary. | [optional] [readonly] [default to "Unknown"]
**Status** | **String** | Status of the storage controller. | [optional] [readonly] [default to "Unknown"]
**Version** | **String** | Software version running on a storage controller. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightStorageBaseArrayControllerAllOf  -Name null `
 -OperationalMode null `
 -Status null `
 -Version null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

