# SnmpUser
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**AuthPassword** | **String** | Authorization password for the user. | [optional] 
**AuthType** | **String** | Authorization protocol for authenticating the user. | [optional] [default to "NA"]
**IsAuthPasswordSet** | **Boolean** | Indicates whether the value of the &#39;authPassword&#39; property has been set. | [optional] [readonly] 
**IsPrivacyPasswordSet** | **Boolean** | Indicates whether the value of the &#39;privacyPassword&#39; property has been set. | [optional] [readonly] 
**Name** | **String** | SNMP username. Must have a minimum of 1 and and a maximum of 31 characters. | [optional] 
**PrivacyPassword** | **String** | Privacy password for the user. | [optional] 
**PrivacyType** | **String** | Privacy protocol for the user. | [optional] [default to "NA"]
**SecurityLevel** | **String** | Security mechanism used for communication between agent and manager. | [optional] [default to "AuthPriv"]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightSnmpUser  -ClassId null `
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
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

