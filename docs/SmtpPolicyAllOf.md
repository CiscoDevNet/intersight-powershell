# SmtpPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **Boolean** | If enabled, controls the state of the SMTP client service on the managed device. | [optional] 
**MinSeverity** | **String** | Minimum fault severity level to receive email notifications. Email notifications are sent for all faults whose severity is equal to or greater than the chosen level. | [optional] [default to "critical"]
**SenderEmail** | **String** | The email address entered here will be displayed as the from address (mail received from address) of all the SMTP mail alerts that are received. If not configured, the hostname of the server is used in the from address field. | [optional] 
**SmtpPort** | **Int64** | Port number used by the SMTP server for outgoing SMTP communication. | [optional] 
**SmtpRecipients** | **String[]** |  | [optional] 
**SmtpServer** | **String** | IP address or hostname of the SMTP server. The SMTP server is used by the managed device to send email notifications. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**Profiles** | [**PolicyAbstractConfigProfileRelationship[]**](PolicyAbstractConfigProfileRelationship.md) | An array of relationships to policyAbstractConfigProfile resources. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightSmtpPolicyAllOf  -Enabled null `
 -MinSeverity null `
 -SenderEmail null `
 -SmtpPort null `
 -SmtpRecipients null `
 -SmtpServer null `
 -Organization null `
 -Profiles null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

