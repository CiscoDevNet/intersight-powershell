# StorageRemoteKeySettingAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsPasswordSet** | **Boolean** | Indicates whether the value of the &#39;password&#39; property has been set. | [optional] [readonly] 
**Password** | **String** | The password for the KMIP server login. | [optional] 
**Port** | **Int64** | The port to which the KMIP client should connect. | [optional] 
**PrimaryServer** | **String** | The IP address of the primary KMIP server. It could be an IPv4 address, an IPv6 address, or a hostname. Hostnames are valid only when Inband is configured for the CIMC address. | [optional] 
**SecondaryServer** | **String** | The IP address of the secondary KMIP server. It could be an IPv4 address, an IPv6 address, or a hostname. Hostnames are valid only when Inband is configured for the CIMC address. | [optional] 
**ServerCertificate** | **String** | The certificate/ public key of the KMIP server. It is required for initiating secure communication with the server. | [optional] 
**Username** | **String** | The user name for the KMIP server login. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightStorageRemoteKeySettingAllOf  -IsPasswordSet null `
 -Password null `
 -Port null `
 -PrimaryServer null `
 -SecondaryServer null `
 -ServerCertificate null `
 -Username null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

