# TerminalAuditLogListAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Count** | **Int32** | The total number of &#39;terminal.AuditLog&#39; resources matching the request, accross all pages. The &#39;Count&#39; attribute is included when the HTTP GET request includes the &#39;$inlinecount&#39; parameter. | [optional] 
**Results** | [**TerminalAuditLog[]**](TerminalAuditLog.md) | The array of &#39;terminal.AuditLog&#39; resources matching the request. | [optional] 

## Examples

- Prepare the resource
```powershell
$TerminalAuditLogListAllOf = Initialize-IntersightTerminalAuditLogListAllOf  -Count null `
 -Results null
```

- Convert the resource to JSON
```powershell
$TerminalAuditLogListAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

