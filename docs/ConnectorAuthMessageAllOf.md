# ConnectorAuthMessageAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**RemoteUserLocale** | **String** | The platform locale to assign user. A locale defines one or more organizations (domains) the user is allowed access, and access is limited to the organizations specified in the locale. | [optional] 
**RemoteUserName** | **String** | The user name passed to the platform for use in platform audit logs. | [optional] 
**RemoteUserRoles** | **String** | The list of roles to pass to the platform to validate the action against. | [optional] 
**RemoteUserSessionId** | **String** | The session Id passed to the platform for use in platforms auditing. | [optional] 

## Examples

- Prepare the resource
```powershell
$ConnectorAuthMessageAllOf = Initialize-IntersightConnectorAuthMessageAllOf  -ClassId null `
 -ObjectType null `
 -RemoteUserLocale null `
 -RemoteUserName null `
 -RemoteUserRoles null `
 -RemoteUserSessionId null
```

- Convert the resource to JSON
```powershell
$ConnectorAuthMessageAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

