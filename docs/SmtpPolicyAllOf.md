# SmtpPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "smtp.Policy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "smtp.Policy"]
**Enabled** | **Boolean** | If enabled, controls the state of the SMTP client service on the managed device. | [optional] [default to $true]
**MinSeverity** | **String** | Minimum fault severity level to receive email notifications. Email notifications are sent for all faults whose severity is equal to or greater than the chosen level. * &#x60;critical&#x60; - Minimum severity to report is critical. * &#x60;condition&#x60; - Minimum severity to report is informational. * &#x60;warning&#x60; - Minimum severity to report is warning. * &#x60;minor&#x60; - Minimum severity to report is minor. * &#x60;major&#x60; - Minimum severity to report is major. | [optional] [default to "critical"]
**SenderEmail** | **String** | The email address entered here will be displayed as the from address (mail received from address) of all the SMTP mail alerts that are received. If not configured, the hostname of the server is used in the from address field. | [optional] 
**SmtpPort** | **Int64** | Port number used by the SMTP server for outgoing SMTP communication. | [optional] [default to 25]
**SmtpRecipients** | **String[]** |  | [optional] 
**SmtpServer** | **String** | IP address or hostname of the SMTP server. The SMTP server is used by the managed device to send email notifications. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**Profiles** | [**PolicyAbstractConfigProfileRelationship[]**](PolicyAbstractConfigProfileRelationship.md) | An array of relationships to policyAbstractConfigProfile resources. | [optional] 

## Examples

- Prepare the resource
```powershell
$SmtpPolicyAllOf = Initialize-IntersightSmtpPolicyAllOf  -ClassId null `
 -ObjectType null `
 -Enabled null `
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
$SmtpPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

