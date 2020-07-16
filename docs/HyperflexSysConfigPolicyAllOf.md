# HyperflexSysConfigPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DnsDomainName** | **String** | The DNS Search Domain Name. This setting applies to HyperFlex Data Platform 3.0 or later only. | [optional] 
**DnsServers** | **String[]** |  | [optional] 
**NtpServers** | **String[]** |  | [optional] 
**Timezone** | **String** | The timezone of the HyperFlex cluster&#39;s system clock. | [optional] [default to "Pacific/Niue"]
**ClusterProfiles** | [**HyperflexClusterProfileRelationship[]**](HyperflexClusterProfileRelationship.md) | An array of relationships to hyperflexClusterProfile resources. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHyperflexSysConfigPolicyAllOf  -DnsDomainName null `
 -DnsServers null `
 -NtpServers null `
 -Timezone null `
 -ClusterProfiles null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

