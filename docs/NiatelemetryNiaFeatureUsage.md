# NiatelemetryNiaFeatureUsage
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "niatelemetry.NiaFeatureUsage"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "niatelemetry.NiaFeatureUsage"]
**AccountMoid** | **String** | The Account ID for this managed object. | [optional] [readonly] 
**CreateTime** | **System.DateTime** | The time when this managed object was created. | [optional] [readonly] 
**DomainGroupMoid** | **String** | The DomainGroup ID for this managed object. | [optional] [readonly] 
**ModTime** | **System.DateTime** | The time when this managed object was last modified. | [optional] [readonly] 
**Moid** | **String** | The unique identifier of this Managed Object instance. | [optional] 
**Owners** | **String[]** |  | [optional] 
**SharedScope** | **String** | Intersight provides pre-built workflows, tasks and policies to end users through global catalogs. Objects that are made available through global catalogs are said to have a &#39;shared&#39; ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs. | [optional] [readonly] 
**Tags** | [**MoTag[]**](MoTag.md) |  | [optional] 
**VersionContext** | [**MoVersionContext**](MoVersionContext.md) |  | [optional] 
**Ancestors** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**Parent** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**PermissionResources** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**DisplayNames** | [**System.Collections.Hashtable**](Array.md) | A set of display names for the MO resource. These names are calculated based on other properties of the MO and potentially properties of Ancestor MOs. Displaynames are intended as a way to provide a normalized user appropriate name for an MO, especially for MOs which do not have a &#39;Name&#39; property, which is the case for much of the inventory discovered from managed targets. There are a limited number of keys, currently &#39;short&#39; and &#39;hierarchical&#39;. The value is an array and clients should use the first element of the array. | [optional] [readonly] 
**ApicCount** | **Int64** | Number of APIC controllers. This determines the value of controllers for the fabric. | [optional] 
**AppCenterCount** | **Int64** | ACI APPs feature usage scale. | [optional] 
**Ave** | **String** | AVE feature usage. This determines if ACI virtual edge feature is enabled or disabled. | [optional] 
**BdCount** | **Int64** | Number of BDs. This determines the total number of Broadcast Domains across the fabric. | [optional] 
**CallhomeSmartGroupCount** | **Int64** | Number of call home smart monitoring policies on the fabric. | [optional] 
**CloudSecPeerCount** | **Int64** | Number of Cloudsec SA peers. | [optional] 
**CompHvCount** | **Int64** | Number of compute hypervisors on the fabric. | [optional] 
**ConfigExportpCount** | **Int64** | Number of system backup configure export policies on the fabric. | [optional] 
**ConfigJobCount** | **Int64** | Number of system backup configure jobs on the fanric. | [optional] 
**ConsistencyCheckerApp** | **String** | Consistency checker application usage. This determines if the fabric has Consistency checker application installed. | [optional] 
**ContractCount** | **Int64** | Number of contracts. This determines the total number of Contracts configured across the fabric. | [optional] 
**DnsCount** | **Int64** | DNS feature usage. This determines the total number of DNS configurations across the fabric. | [optional] 
**EigrpCount** | **Int64** | Eigrp feature usage. This determines the total number of EIGRP sessions across the fabric. | [optional] 
**EpgCount** | **Int64** | Number of End Point Groups. This determines the total number of End Point Groups across the fabric. | [optional] 
**FabricSetuppCount** | **Int64** | Number of Multi-Pods per fabric. | [optional] 
**FcoeNportCount** | **Int64** | Total number of FCoE N-Port for DOM, VSAn, and VLAN. | [optional] 
**FcoeNportDomCount** | **Int64** | Number of FCoE N-Port DOM. | [optional] 
**FcoeNportVlanCount** | **Int64** | Number of FCoE N-Port VLAN. | [optional] 
**FcoeNportVsanCount** | **Int64** | Number of FCoE N-Port VSAN. | [optional] 
**FvSlaDefCount** | **Int64** | Number of Internet Protocol Service Level Agreements Monitoring policy objects for object tracking. | [optional] 
**HsrpCount** | **Int64** | Hsrp feature usage. This determines the total number of HSRP sessions across the fabric. | [optional] 
**IbgpCount** | **Int64** | Ibgp feature usage. This determines the total number of BGP sessions across the fabric. | [optional] 
**IgmpAccessListCount** | **Int64** | IGMP Access List feature usage. This determines the total number of IGMP access lists configured across the fabric. | [optional] 
**IgmpSnoop** | **String** | IGMP Snooping feature usage. This determines if this feature is enabled or disabled. | [optional] 
**IpEpgCount** | **Int64** | Number of IP based End Point Groups. This determines the total number of IP End Point Groups across the fabric. | [optional] 
**IsisCount** | **Int64** | Isis feature usage. This determines the total number of ISIS sessions across the fabric. | [optional] 
**L2Multicast** | **String** | L2Multicast feature usage. This determines if this Layer 2 Multicast feature is being enabled / disabled on the fabric. | [optional] 
**LeafCount** | **Int64** | Number of Leafs. This determines the total number of Leaf switches in the fabric. | [optional] 
**MaintenanceModeCount** | **Int64** | Maintenance Mode feature usage. This determines the number of switches that are currently in maintenance mode. | [optional] 
**ManagementOverV6Count** | **Int64** | Management over IPv6 feature usage. This determines the total number of IPv6 configurtaions in the fabric. | [optional] 
**MicrosoftUsegVmmEpPdCount** | **Int64** | Number of Microsoft microsegmentation VmmEpPD objects. Ensures that Microsoft was configured. | [optional] 
**NetFlowCount** | **Int64** | Number of Netflow monitor policies. | [optional] 
**Nir** | **String** | NIR application usage. This determines if the fabric has NIR application installed. | [optional] 
**OpenStack** | **String** | Open stack feature usage. | [optional] 
**OpflexKubernetesCount** | **Int64** | Opflex for Kubernetes feature usage. This determines the total number of VMM sessions of type kubernetes. | [optional] 
**OspfCount** | **Int64** | Ospf feature usage. This determines the total number of OSPF sessions across the fabric. | [optional] 
**PoeCount** | **Int64** | POE feature usage. This determines the total number of POE configurations across the fabric. | [optional] 
**PortSecurityCount** | **Int64** | Number of objects with Port Security enabled. Non-Zero value indicates the object as enabled. | [optional] 
**QinVniTunnelCount** | **Int64** | QinVniTunnel feature usage. This determines if the qinVniTunnel feature is being used on the fabric and the scale of it. | [optional] 
**QosCongCount** | **Int64** | Number of Quality Of Service congestion class. | [optional] 
**QosPfcPolCount** | **Int64** | Number of Quality Of Service class. | [optional] 
**RecordType** | **String** | Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected. | [optional] 
**RecordVersion** | **String** | Version of record being pushed. This determines what was the API version for data available from the device. | [optional] 
**RemoteLeafCount** | **Int64** | Number of remote Leafs. This determines the total number of remote leaf switches in the fabric. | [optional] 
**ScvmmCount** | **Int64** | SCVMM feature usage. This determines the total number of SCVMM configurations in the fabric. | [optional] 
**SharedL3OutCount** | **Int64** | SharedL3Out feature usage. This determines the total number of Shared L3 out configured across the fabric. | [optional] 
**SiteName** | **String** | The Site name represents an APIC cluster. Service Engine can onboard multiple APIC clusters / sites. There will be a feature usage object per site in Multi site scenario. In multi-site scenario the site name is available in all the requests being made. | [optional] 
**SmartCallHome** | **String** | Smart callhome feature usage. This determines if this feature is being enabled or disabled. | [optional] 
**Snmp** | **String** | SNMP feature usage. This determines if this feature is enabled or disabled. | [optional] 
**SnmpGroupCount** | **Int64** | Number of SNMP monitoring policies on the fabric. | [optional] 
**SpanCount** | **Int64** | Number of Span Sources and Destinations. | [optional] 
**SpanDstCount** | **Int64** | Number of Span Destinations with valid state. | [optional] 
**SpanSrcCount** | **Int64** | Number of Span Sources with valid state. | [optional] 
**SpineCount** | **Int64** | Number of Spines. This determines the total number of spine switches in the fabric. | [optional] 
**SshOverV6Count** | **Int64** | Ssh over IPv6 feature usage. This determines the total number of IPv6 configurtaions in the fabric. | [optional] 
**SyslogGroupCount** | **Int64** | Number of syslog monitoring policies on the fabric. | [optional] 
**SyslogOverV6Count** | **Int64** | Syslog over IPv6 feature usage. This determines the total number of IPv6 configurtaions in the fabric. | [optional] 
**TacacsGroupCount** | **Int64** | Number of tacacs monitoring policies on the fabric. | [optional] 
**TenantCount** | **Int64** | Number of tenants. This determines the total number of tenants configured across the fabric. | [optional] 
**TierTwoLeafCount** | **Int64** | Number of tier 2 Leafs. This determines the total number of tier 2 Leaf switches in the fabric. | [optional] 
**Twamp** | **String** | TWAMP feature usage. This determines if this feature is enabled or disabled. | [optional] 
**Useg** | **String** | VMM uSegmentation feature usage. This determines if microsegmentation feature is enabled or disabled. | [optional] 
**VmWareVdsCount** | **Int64** | Number of objects with VmWare vCenter 6.5 support. Checks the controller revision value. | [optional] 
**VmmCtrlrpCount** | **Int64** | Number of Virtual Machine Monitor controller policy objects for VMware vCenter. | [optional] 
**VmmDompCount** | **Int64** | Number of Virtual Machine Monitor domain policy model objects for VMware vCenter. | [optional] 
**VmmEpPdCount** | **Int64** | Microsegmentation Distributed Virtual Switch feature usage. Gets the number of objects associated to VMware vCenter. | [optional] 
**VnsmDevCount** | **Int64** | Number of objects with L4-L7 Device Package Import enabled. Checks for the vendor and the model. | [optional] 
**VpodCount** | **Int64** | Virtual pod feature usage. This determines the total number of virtual POD configurations in the fabrics. | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$NiatelemetryNiaFeatureUsage = Initialize-IntersightNiatelemetryNiaFeatureUsage  -ClassId null `
 -ObjectType null `
 -AccountMoid null `
 -CreateTime null `
 -DomainGroupMoid null `
 -ModTime null `
 -Moid null `
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
 -CallhomeSmartGroupCount null `
 -CloudSecPeerCount null `
 -CompHvCount null `
 -ConfigExportpCount null `
 -ConfigJobCount null `
 -ConsistencyCheckerApp null `
 -ContractCount null `
 -DnsCount null `
 -EigrpCount null `
 -EpgCount null `
 -FabricSetuppCount null `
 -FcoeNportCount null `
 -FcoeNportDomCount null `
 -FcoeNportVlanCount null `
 -FcoeNportVsanCount null `
 -FvSlaDefCount null `
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
 -MicrosoftUsegVmmEpPdCount null `
 -NetFlowCount null `
 -Nir null `
 -OpenStack null `
 -OpflexKubernetesCount null `
 -OspfCount null `
 -PoeCount null `
 -PortSecurityCount null `
 -QinVniTunnelCount null `
 -QosCongCount null `
 -QosPfcPolCount null `
 -RecordType null `
 -RecordVersion null `
 -RemoteLeafCount null `
 -ScvmmCount null `
 -SharedL3OutCount null `
 -SiteName null `
 -SmartCallHome null `
 -Snmp null `
 -SnmpGroupCount null `
 -SpanCount null `
 -SpanDstCount null `
 -SpanSrcCount null `
 -SpineCount null `
 -SshOverV6Count null `
 -SyslogGroupCount null `
 -SyslogOverV6Count null `
 -TacacsGroupCount null `
 -TenantCount null `
 -TierTwoLeafCount null `
 -Twamp null `
 -Useg null `
 -VmWareVdsCount null `
 -VmmCtrlrpCount null `
 -VmmDompCount null `
 -VmmEpPdCount null `
 -VnsmDevCount null `
 -VpodCount null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$NiatelemetryNiaFeatureUsage | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

