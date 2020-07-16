# SyslogRemoteClientBase
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**Enabled** | **Boolean** | Enables/disables remote logging for the endpoint If enabled, log messages will be sent to the syslog server mentioned in the Hostname/IP Address field. | [optional] 
**Hostname** | **String** | Hostname or IP Address of the syslog server where log should be stored. | [optional] 
**MinSeverity** | **String** | Lowest level of messages to be included in the remote log. | [optional] [default to "warning"]
**Port** | **Int64** | Port number used for logging on syslog server. | [optional] 
**Protocol** | **String** | Transport layer protocol for transmission of log messages to syslog server. | [optional] [default to "udp"]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightSyslogRemoteClientBase  -ClassId null `
 -ObjectType null `
 -Enabled null `
 -Hostname null `
 -MinSeverity null `
 -Port null `
 -Protocol null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

