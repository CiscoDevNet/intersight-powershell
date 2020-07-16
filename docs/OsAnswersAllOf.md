# OsAnswersAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AnswerFile** | **String** | If the source of the answers is a static file, the content of the file is stored as value in this property. The value is mandatory only when the &#39;Source&#39; property has been set to &#39;File&#39;. | [optional] 
**Hostname** | **String** | Hostname to be configured for the server in the OS. | [optional] 
**IpConfigType** | **String** | IP configuration type. Values are Static or Dynamic configuration of IP. In case of static IP configuration, IP address, gateway and other details need to be populated. In case of dynamic the IP configuration is obtained dynamically from DHCP. | [optional] [default to "static"]
**IpConfiguration** | [**OsIpConfiguration**](OsIpConfiguration.md) |  | [optional] 
**IsAnswerFileSet** | **Boolean** | Indicates whether the value of the &#39;answerFile&#39; property has been set. | [optional] [readonly] 
**IsRootPasswordCrypted** | **Boolean** | Enable to indicate Root Password provided is encrypted. | [optional] 
**IsRootPasswordSet** | **Boolean** | Indicates whether the value of the &#39;rootPassword&#39; property has been set. | [optional] [readonly] 
**Nameserver** | **String** | IP address of the name server to be configured in the OS. | [optional] 
**ProductKey** | **String** | The product key to be used for a specific version of Windows installation. | [optional] 
**RootPassword** | **String** | Password configured for the root / administrator user in the OS. You can enter a plain text or an encrypted password. Intersight encrypts the plaintext password. Enable the Encrypted Password option to provide an encrypted password. For more details on encrypting passwords, see Help Center. | [optional] 
**Source** | **String** | Answer values can be provided from three sources - Embedded in OS image, static file, or as placeholder values for an answer file template. Source of the answers is given as value, Embedded/File/Template. &#39;Embedded&#39; option indicates that the answer file is embedded within the OS Image. &#39;File&#39; option indicates that the answers are provided as a file. &#39;Template&#39; indicates that the placeholders in the selected os.ConfigurationFile MO are replaced with values provided as os.Answers MO. | [optional] [default to "None"]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightOsAnswersAllOf  -AnswerFile null `
 -Hostname null `
 -IpConfigType null `
 -IpConfiguration null `
 -IsAnswerFileSet null `
 -IsRootPasswordCrypted null `
 -IsRootPasswordSet null `
 -Nameserver null `
 -ProductKey null `
 -RootPassword null `
 -Source null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

