# NetworkconfigPolicy
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountMoid** | **String** | The Account ID for this managed object. | [optional] [readonly] 
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**CreateTime** | **System.DateTime** | The time when this managed object was created. | [optional] [readonly] 
**DomainGroupMoid** | **String** | The DomainGroup ID for this managed object. | [optional] [readonly] 
**ModTime** | **System.DateTime** | The time when this managed object was last modified. | [optional] [readonly] 
**Moid** | **String** | The unique identifier of this Managed Object instance. | [optional] 
**ObjectType** | **String** | The fully-qualified type of this managed object, i.e. the class name. This property is optional. The ObjectType is implied from the URL path. If specified, the value of objectType must match the class name specified in the URL path. | [readonly] 
**Owners** | **String[]** |  | [optional] 
**SharedScope** | **String** | Intersight provides pre-built workflows, tasks and policies to end users through global catalogs. Objects that are made available through global catalogs are said to have a &#39;shared&#39; ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs. | [optional] [readonly] 
**Tags** | [**MoTag[]**](MoTag.md) |  | [optional] 
**VersionContext** | [**MoVersionContext**](MoVersionContext.md) |  | [optional] 
**Ancestors** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**Parent** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**PermissionResources** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**DisplayNames** | [**System.Collections.Hashtable**](Array.md) | a map of display names for a resource. | [optional] [readonly] 
**Description** | **String** | Description of the policy. | [optional] 
**Name** | **String** | Name of the concrete policy. | [optional] 
**AlternateIpv4dnsServer** | **String** | IP address of the secondary DNS server. | [optional] 
**AlternateIpv6dnsServer** | **String** | IP address of the secondary DNS server. | [optional] 
**DynamicDnsDomain** | **String** | The domain name appended to a hostname for a Dynamic DNS (DDNS) update. If left blank, only a hostname is sent to the DDNS update request. | [optional] 
**EnableDynamicDns** | **Boolean** | If enabled, updates the resource records to the DNS from Cisco IMC. | [optional] 
**EnableIpv4dnsFromDhcp** | **Boolean** | If enabled, Cisco IMC retrieves the DNS server addresses from DHCP. Use DHCP field must be enabled for IPv4 in Cisco IMC to enable it. | [optional] 
**EnableIpv6** | **Boolean** | If enabled, allows to configure IPv6 properties. | [optional] 
**EnableIpv6dnsFromDhcp** | **Boolean** | If enabled, Cisco IMC retrieves the DNS server addresses from DHCP. Use DHCP field must be enabled for IPv6 in Cisco IMC to enable it. | [optional] 
**PreferredIpv4dnsServer** | **String** | IP address of the primary DNS server. | [optional] 
**PreferredIpv6dnsServer** | **String** | IP address of the primary DNS server. | [optional] 
**ApplianceAccount** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**Profiles** | [**PolicyAbstractConfigProfileRelationship[]**](PolicyAbstractConfigProfileRelationship.md) | An array of relationships to policyAbstractConfigProfile resources. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightNetworkconfigPolicy  -AccountMoid null `
 -ClassId null `
 -CreateTime null `
 -DomainGroupMoid null `
 -ModTime null `
 -Moid null `
 -ObjectType null `
 -Owners null `
 -SharedScope null `
 -Tags null `
 -VersionContext null `
 -Ancestors null `
 -Parent null `
 -PermissionResources null `
 -DisplayNames null `
 -Description null `
 -Name null `
 -AlternateIpv4dnsServer null `
 -AlternateIpv6dnsServer null `
 -DynamicDnsDomain null `
 -EnableDynamicDns null `
 -EnableIpv4dnsFromDhcp null `
 -EnableIpv6 null `
 -EnableIpv6dnsFromDhcp null `
 -PreferredIpv4dnsServer null `
 -PreferredIpv6dnsServer null `
 -ApplianceAccount null `
 -Organization null `
 -Profiles null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

