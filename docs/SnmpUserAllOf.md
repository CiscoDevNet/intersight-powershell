# SnmpUserAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "snmp.User"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "snmp.User"]
**AuthPassword** | **String** | Authorization password for the user. | [optional] 
**AuthType** | **String** | Authorization protocol for authenticating the user. * &#x60;NA&#x60; - Authentication protocol is not applicable. * &#x60;MD5&#x60; - MD5 protocol is used to authenticate SNMP user. * &#x60;SHA&#x60; - SHA protocol is used to authenticate SNMP user. | [optional] [default to "NA"]
**IsAuthPasswordSet** | **Boolean** | Indicates whether the value of the &#39;authPassword&#39; property has been set. | [optional] [readonly] [default to $false]
**IsPrivacyPasswordSet** | **Boolean** | Indicates whether the value of the &#39;privacyPassword&#39; property has been set. | [optional] [readonly] [default to $false]
**Name** | **String** | SNMP username. Must have a minimum of 1 and and a maximum of 31 characters. | [optional] 
**PrivacyPassword** | **String** | Privacy password for the user. | [optional] 
**PrivacyType** | **String** | Privacy protocol for the user. * &#x60;NA&#x60; - Privacy protocol is not applicable. * &#x60;DES&#x60; - DES privacy protocol is used for SNMP user. * &#x60;AES&#x60; - AES privacy protocol is used for SNMP user. | [optional] [default to "NA"]
**SecurityLevel** | **String** | Security mechanism used for communication between agent and manager. * &#x60;AuthPriv&#x60; - The user requires both an authorization password and a privacy password. * &#x60;NoAuthNoPriv&#x60; - The user does not require an authorization or privacy password. * &#x60;AuthNoPriv&#x60; - The user requires an authorization password but not a privacy password. | [optional] [default to "AuthPriv"]

## Examples

- Prepare the resource
```powershell
$SnmpUserAllOf = Initialize-IntersightSnmpUserAllOf  -ClassId null `
 -ObjectType null `
 -AuthPassword null `
 -AuthType null `
 -IsAuthPasswordSet null `
 -IsPrivacyPasswordSet null `
 -Name null `
 -PrivacyPassword null `
 -PrivacyType null `
 -SecurityLevel null
```

- Convert the resource to JSON
```powershell
$SnmpUserAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

