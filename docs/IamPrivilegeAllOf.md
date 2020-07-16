# IamPrivilegeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HostnamePrefix** | **String** | The hostname prefix of the resource corresponding to this privilege. For example \\&#39;sentry\\&#39; in https://sentry.intersight.com . | [optional] [readonly] 
**Method** | **String** | The API method on the rest resource corresponding to privilege. For example READ, CREATE, UPDATE etc. | [optional] [readonly] 
**Name** | **String** | The name of the privilege reported by microservice. | [optional] [readonly] 
**RestPath** | **String** | The REST API path of the resource corresponding to this privilege. For example /v1/iam/Accounts, /v1/iam/Sessions. | [optional] [readonly] 
**UrlPrefix** | **String** | The URL path prefix of the resource corresponding to this privilege. For example /devops/kibana, /devops/grafana etc. | [optional] [readonly] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 
**System** | [**IamSystemRelationship**](IamSystemRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIamPrivilegeAllOf  -HostnamePrefix null `
 -Method null `
 -Name null `
 -RestPath null `
 -UrlPrefix null `
 -Account null `
 -System null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

