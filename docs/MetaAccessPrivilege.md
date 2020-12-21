# MetaAccessPrivilege
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "meta.AccessPrivilege"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "meta.AccessPrivilege"]
**Method** | **String** | The type of CRUD operation (create, read, update, delete) for which an access privilege is required. * &#x60;Update&#x60; - The &#39;update&#39; operation/state. * &#x60;Create&#x60; - The &#39;create&#39; operation/state. * &#x60;Read&#x60; - The &#39;read&#39; operation/state. * &#x60;Delete&#x60; - The &#39;delete&#39; operation/state. | [optional] [readonly] [default to "Update"]
**Privilege** | **String** | The name of the privilege which is required to invoke the specified CRUD method. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$MetaAccessPrivilege = Initialize-IntersightMetaAccessPrivilege  -ClassId null `
 -ObjectType null `
 -Method null `
 -Privilege null
```

- Convert the resource to JSON
```powershell
$MetaAccessPrivilege | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

