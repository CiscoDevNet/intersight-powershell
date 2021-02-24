# ApplianceExternalSyslogSettingAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "appliance.ExternalSyslogSetting"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "appliance.ExternalSyslogSetting"]
**Enabled** | **Boolean** | Enable or disable External Syslog Server. | [optional] [default to $false]
**ExportNginx** | **Boolean** | Enable or disable exporting of Web Server access logs. | [optional] [default to $false]
**Port** | **Int64** | External Syslog Server Port for connection establishment. | [optional] [default to 10514]
**Server** | **String** | External Syslog Server Address, can be IP address or hostname. | [optional] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ApplianceExternalSyslogSettingAllOf = Initialize-IntersightApplianceExternalSyslogSettingAllOf  -ClassId null `
 -ObjectType null `
 -Enabled null `
 -ExportNginx null `
 -Port null `
 -Server null `
 -Account null
```

- Convert the resource to JSON
```powershell
$ApplianceExternalSyslogSettingAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

