# ConnectorAuthMessageAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RemoteUserLocale** | **String** | The platform locale to assign user. A locale defines one or more organizations (domains) the user is allowed access, and access is limited to the organizations specified in the locale. | [optional] 
**RemoteUserName** | **String** | The user name passed to the platform for use in platform audit logs. | [optional] 
**RemoteUserRoles** | **String** | The list of roles to pass to the platform to validate the action against. | [optional] 
**RemoteUserSessionId** | **String** | The session Id passed to the platform for use in platforms auditing. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightConnectorAuthMessageAllOf  -RemoteUserLocale null `
 -RemoteUserName null `
 -RemoteUserRoles null `
 -RemoteUserSessionId null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

