# SyslogRemoteClientBaseAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **Boolean** | Enables/disables remote logging for the endpoint If enabled, log messages will be sent to the syslog server mentioned in the Hostname/IP Address field. | [optional] 
**Hostname** | **String** | Hostname or IP Address of the syslog server where log should be stored. | [optional] 
**MinSeverity** | **String** | Lowest level of messages to be included in the remote log. | [optional] [default to "warning"]
**Port** | **Int64** | Port number used for logging on syslog server. | [optional] 
**Protocol** | **String** | Transport layer protocol for transmission of log messages to syslog server. | [optional] [default to "udp"]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightSyslogRemoteClientBaseAllOf  -Enabled null `
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

