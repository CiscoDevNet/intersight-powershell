# VnicEthQosPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cos** | **Int64** | Class of Service to be associated to the traffic on the virtual interface. | [optional] 
**Mtu** | **Int64** | The Maximum Transmission Unit (MTU) or packet size that the virtual interface accepts. | [optional] 
**RateLimit** | **Int64** | The value in Mbps (0-10G/40G/100G depending on Adapter Model) to use for limiting the data rate on the virtual interface. Setting this to zero will turn rate limiting off. | [optional] 
**TrustHostCos** | **Boolean** | Enables usage of the Class of Service provided by the operating system. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVnicEthQosPolicyAllOf  -Cos null `
 -Mtu null `
 -RateLimit null `
 -TrustHostCos null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

