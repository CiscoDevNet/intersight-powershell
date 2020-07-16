# NiatelemetryNiaFeatureUsage
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
**ApicCount** | **Int64** | Number of APIC controllers. This determines the value of controllers for the fabric. | [optional] 
**AppCenterCount** | **Int64** | ACI APPs feature usage. This determines the total number of apps installed on the fabric. | [optional] 
**Ave** | **String** | AVE feature usage. This determines if ACI virtual edge feature is enabled or disabled. | [optional] 
**BdCount** | **Int64** | Number of BDs. This determines the total number of Broadcast Domains across the fabric. | [optional] 
**ConsistencyCheckerApp** | **String** | Consistency checker application usage. This determines if the fabric has Consistency checker application installed. | [optional] 
**ContractCount** | **Int64** | Number of contracts. This determines the total number of Contracts configured across the fabric. | [optional] 
**DnsCount** | **Int64** | DNS feature usage. This determines the total number of DNS configurations across the fabric. | [optional] 
**EigrpCount** | **Int64** | Eigrp feature usage. This determines the total number of EIGRP sessions across the fabric. | [optional] 
**EpgCount** | **Int64** | Number of EPGs. This determines the total number of End Point Groups across the fabric. | [optional] 
**HsrpCount** | **Int64** | Hsrp feature usage. This determines the total number of HSRP sessions across the fabric. | [optional] 
**IbgpCount** | **Int64** | Ibgp feature usage. This determines the total number of BGP sessions across the fabric. | [optional] 
**IgmpAccessListCount** | **Int64** | IGMP Access List feature usage. This determines the total number of IGMP access lists configured across the fabric. | [optional] 
**IgmpSnoop** | **String** | IGMP Snooping feature usage. This determines if this feature is enabled or disabled. | [optional] 
**IpEpgCount** | **Int64** | Number of IP based EPGs. This determines the total number of IP End Point Groups across the fabric. | [optional] 
**IsisCount** | **Int64** | Isis feature usage. TThis determines the total number of ISIS sessions across the fabric. | [optional] 
**L2Multicast** | **String** | L2Multicast feature usage. This determines if this Layer 2 Multicast feature is being enabled / disabled on the fabric. | [optional] 
**LeafCount** | **Int64** | Number of Leafs. This determines the total number of Leaf switches in the fabric. | [optional] 
**MaintenanceModeCount** | **Int64** | Maintenance Mode feature usage. This determines the number of switches that are currently in maintenance mode. | [optional] 
**ManagementOverV6Count** | **Int64** | Management over IPv6 feature usage. This determines the total number of IPv6 configurtaions in the fabric. | [optional] 
**Nir** | **String** | NIR application usage. This determines if the fabric has NIR application installed. | [optional] 
**OpflexKubernetesCount** | **Int64** | Opflex for Kubernetes feature usage. This determines the total number of VMM sessions of type kubernetes. | [optional] 
**OspfCount** | **Int64** | Ospf feature usage. This determines the total number of OSPF sessions across the fabric. | [optional] 
**PoeCount** | **Int64** | POE feature usage. This determines the total number of POE configurations across the fabric. | [optional] 
**QinVniTunnelCount** | **Int64** | QinVniTunnel feature usage. This determines if the qinVniTunnel feature is being used on the fabric and the scale of it. | [optional] 
**RemoteLeafCount** | **Int64** | Number of remote Leafs. This determines the total number of remote leaf switches in the fabric. | [optional] 
**ScvmmCount** | **Int64** | SCVMM feature usage. This determines the total number of SCVMM configurations in the fabric. | [optional] 
**SharedL3OutCount** | **Int64** | SharedL3Out feature usage. This determines the total number of Shared L3 out configured across the fabric. | [optional] 
**SiteName** | **String** | The Site name represents an APIC cluster. Service Engine can onboard multiple APIC clusters / sites. There will be a feature usage object per site in Multi site scenario. In multi-site scenario the site name is available in all the requests being made. | [optional] 
**SmartCallHome** | **String** | Smart callhome feature usage. This determines if this feature is being enabled or disabled. | [optional] 
**Snmp** | **String** | SNMP feature usage. This determines if this feature is enabled or disabled. | [optional] 
**SpineCount** | **Int64** | Number of Spines. This determines the total number of spine switches in the fabric. | [optional] 
**SshOverV6Count** | **Int64** | Ssh over IPv6 feature usage. This determines the total number of IPv6 configurtaions in the fabric. | [optional] 
**SyslogOverV6Count** | **Int64** | Syslog over IPv6 feature usage. This determines the total number of IPv6 configurtaions in the fabric. | [optional] 
**TenantCount** | **Int64** | Number of tenants. This determines the total number of tenants configured across the fabric. | [optional] 
**TierTwoLeafCount** | **Int64** | Number of tier 2 Leafs. This determines the total number of tier 2 Leaf switches in the fabric. | [optional] 
**Twamp** | **String** | TWAMP feature usage. This determines if this feature is enabled or disabled. | [optional] 
**Useg** | **String** | VMM uSegmentation feature usage. This determines if microsegmentation feature is enabled or disabled. | [optional] 
**VpodCount** | **Int64** | Virtual pod feature usage. This determines the total number of virtual POD configurations in the fabrics. | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightNiatelemetryNiaFeatureUsage  -AccountMoid null `
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
 -ApicCount null `
 -AppCenterCount null `
 -Ave null `
 -BdCount null `
 -ConsistencyCheckerApp null `
 -ContractCount null `
 -DnsCount null `
 -EigrpCount null `
 -EpgCount null `
 -HsrpCount null `
 -IbgpCount null `
 -IgmpAccessListCount null `
 -IgmpSnoop null `
 -IpEpgCount null `
 -IsisCount null `
 -L2Multicast null `
 -LeafCount null `
 -MaintenanceModeCount null `
 -ManagementOverV6Count null `
 -Nir null `
 -OpflexKubernetesCount null `
 -OspfCount null `
 -PoeCount null `
 -QinVniTunnelCount null `
 -RemoteLeafCount null `
 -ScvmmCount null `
 -SharedL3OutCount null `
 -SiteName null `
 -SmartCallHome null `
 -Snmp null `
 -SpineCount null `
 -SshOverV6Count null `
 -SyslogOverV6Count null `
 -TenantCount null `
 -TierTwoLeafCount null `
 -Twamp null `
 -Useg null `
 -VpodCount null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

