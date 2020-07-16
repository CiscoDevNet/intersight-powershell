# MetaAccessPrivilegeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Method** | **String** | The type of CRUD operation (create, read, update, delete) for which an access privilege is required. | [optional] [readonly] [default to "Update"]
**Privilege** | **String** | The name of the privilege which is required to invoke the specified CRUD method. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightMetaAccessPrivilegeAllOf  -Method null `
 -Privilege null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

