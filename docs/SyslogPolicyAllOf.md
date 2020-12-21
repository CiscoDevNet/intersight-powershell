# SyslogPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "syslog.Policy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "syslog.Policy"]
**LocalClients** | [**SyslogLocalClientBase[]**](SyslogLocalClientBase.md) |  | [optional] 
**RemoteClients** | [**SyslogRemoteClientBase[]**](SyslogRemoteClientBase.md) |  | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**Profiles** | [**PolicyAbstractConfigProfileRelationship[]**](PolicyAbstractConfigProfileRelationship.md) | An array of relationships to policyAbstractConfigProfile resources. | [optional] 

## Examples

- Prepare the resource
```powershell
$SyslogPolicyAllOf = Initialize-IntersightSyslogPolicyAllOf  -ClassId null `
 -ObjectType null `
 -LocalClients null `
 -RemoteClients null `
 -Organization null `
 -Profiles null
```

- Convert the resource to JSON
```powershell
$SyslogPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

