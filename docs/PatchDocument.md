# PatchDocument
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Op** | **String** | The PATCH operation to be performed. &#39;move&#39; and &#39;copy&#39; are defined in RFC 6902 but are not supported in the Intersight API. | 
**Path** | **String** | A JSON-Pointer to a property in a REST resource. | 
**Value** | [**SystemCollectionsHashtable**](.md) | The value to be used within the operations. | [optional] 
**VarFrom** | **String** | A string containing a JSON Pointer value. | [optional] 

## Examples

- Prepare the resource
```powershell
$PatchDocument = Initialize-IntersightPatchDocument  -Op null `
 -Path null `
 -Value null `
 -VarFrom null
```

- Convert the resource to JSON
```powershell
$PatchDocument | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

