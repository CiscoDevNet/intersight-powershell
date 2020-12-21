# SolPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "sol.Policy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "sol.Policy"]
**BaudRate** | **Int32** | Baud Rate used for Serial Over LAN communication. * &#x60;9600&#x60; - Use baud rate 9600 for communication. * &#x60;19200&#x60; - Use baud rate 19200 for communication. * &#x60;38400&#x60; - Use baud rate 38400 for communication. * &#x60;57600&#x60; - Use baud rate 57600 for communication. * &#x60;115200&#x60; - Use baud rate 115200 for communication. | [optional] [default to 9600]
**ComPort** | **String** | Serial port through which the system routes Serial Over LAN communication. This field is available only on some Cisco UCS C-Series servers. If it is unavailable, the server uses COM port 0 by default. * &#x60;com0&#x60; - Use serial port com0 for communication. * &#x60;com1&#x60; - Use serial port com1 for communication. | [optional] [default to "com0"]
**Enabled** | **Boolean** | State of Serial Over LAN service on the endpoint. | [optional] [default to $true]
**SshPort** | **Int64** | SSH port used to access Serial Over LAN directly. Enables bypassing Cisco IMC shell to provide direct access to Serial Over LAN. | [optional] [default to 2400]
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**Profiles** | [**PolicyAbstractConfigProfileRelationship[]**](PolicyAbstractConfigProfileRelationship.md) | An array of relationships to policyAbstractConfigProfile resources. | [optional] 

## Examples

- Prepare the resource
```powershell
$SolPolicyAllOf = Initialize-IntersightSolPolicyAllOf  -ClassId null `
 -ObjectType null `
 -BaudRate null `
 -ComPort null `
 -Enabled null `
 -SshPort null `
 -Organization null `
 -Profiles null
```

- Convert the resource to JSON
```powershell
$SolPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

