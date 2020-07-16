# SolPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BaudRate** | **Int32** | Baud Rate used for Serial Over LAN communication. | [optional] [default to 9600]
**ComPort** | **String** | Serial port through which the system routes Serial Over LAN communication. This field is available only on some Cisco UCS C-Series servers. If it is unavailable, the server uses COM port 0 by default. | [optional] [default to "com0"]
**Enabled** | **Boolean** | State of Serial Over LAN service on the endpoint. | [optional] 
**SshPort** | **Int64** | SSH port used to access Serial Over LAN directly. Enables bypassing Cisco IMC shell to provide direct access to Serial Over LAN. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**Profiles** | [**PolicyAbstractConfigProfileRelationship[]**](PolicyAbstractConfigProfileRelationship.md) | An array of relationships to policyAbstractConfigProfile resources. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightSolPolicyAllOf  -BaudRate null `
 -ComPort null `
 -Enabled null `
 -SshPort null `
 -Organization null `
 -Profiles null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

