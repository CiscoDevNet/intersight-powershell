# NiatelemetryTenant
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "niatelemetry.Tenant"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "niatelemetry.Tenant"]
**AccountMoid** | **String** | The Account ID for this managed object. | [optional] [readonly] 
**CreateTime** | **System.DateTime** | The time when this managed object was created. | [optional] [readonly] 
**DomainGroupMoid** | **String** | The DomainGroup ID for this managed object. | [optional] [readonly] 
**ModTime** | **System.DateTime** | The time when this managed object was last modified. | [optional] [readonly] 
**Moid** | **String** | The unique identifier of this Managed Object instance. | [optional] 
**Owners** | **String[]** |  | [optional] 
**SharedScope** | **String** | Intersight provides pre-built workflows, tasks and policies to end users through global catalogs. Objects that are made available through global catalogs are said to have a &#39;shared&#39; ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs. | [optional] [readonly] 
**Tags** | [**MoTag[]**](MoTag.md) |  | [optional] 
**VersionContext** | [**MoVersionContext**](MoVersionContext.md) |  | [optional] 
**Var0ClusterReplicationNetworkPolicy** | [**HyperflexClusterReplicationNetworkPolicyRelationship**](HyperflexClusterReplicationNetworkPolicyRelationship.md) |  | [optional] 
**Ancestors** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**Parent** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**PermissionResources** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**DisplayNames** | [**System.Collections.Hashtable**](Array.md) | A set of display names for the MO resource. These names are calculated based on other properties of the MO and potentially properties of Ancestor MOs. Displaynames are intended as a way to provide a normalized user appropriate name for an MO, especially for MOs which do not have a &#39;Name&#39; property, which is the case for much of the inventory discovered from managed targets. There are a limited number of keys, currently &#39;short&#39; and &#39;hierarchical&#39;. The value is an array and clients should use the first element of the array. | [optional] [readonly] 
**BfdIfPolCount** | **Int64** | Number of Bidirectional Forwarding Detection bfdIfPol Model Objects. | [optional] 
**BfdIfpCount** | **Int64** | Number of objects with Bidirectional Forwarding Detection Interface Policy. | [optional] 
**DhcpRsProvCount** | **Int64** | Number of tenants with Dynamic Host Configuration Protocol enabled. | [optional] 
**Dn** | **String** | Dn for the tenants present. | [optional] 
**FhsBdPolCount** | **Int64** | Number of objects with First hop security. Checks for presence of IP source gaurd, dynamic arp inspection. | [optional] 
**FvApCount** | **Int64** | Number of application profiles per tenant. | [optional] 
**FvBdCount** | **Int64** | Number of bridge domains with hardware proxy enabled per tenant. | [optional] 
**FvBdSubnetCount** | **Int64** | Number of bridge domain subnets per tenant. | [optional] 
**FvBdnoArpCount** | **Int64** | Number of bridge domains with ARP flodding disabled per tenant. | [optional] 
**FvCepCount** | **Int64** | Count of number of endpoints per tenant. | [optional] 
**FvRsBdToFhsCount** | **Int64** | Number of objects with First hop security. Checks for presence of IP source gaurd, dynamic arp inspection. | [optional] 
**FvRsBdToOutCount** | **Int64** | Number of bridge domains connected to layer 3 out per tenant. | [optional] 
**FvSiteConnpCount** | **Int64** | Number of Multi-Site objects. | [optional] 
**FvSubnetCount** | **Int64** | Number of subnets per tenant. | [optional] 
**IpStaticRouteCount** | **Int64** | Number of IP static routes per tenant. | [optional] 
**L3MulticastCount** | **Int64** | Number of layer 3 multicasts. | [optional] 
**L3MulticastCtxCount** | **Int64** | Number of layer 3 multicast CtxP. | [optional] 
**L3MulticastIfCount** | **Int64** | Number of layer 3 multicast IfP. | [optional] 
**L3outCount** | **Int64** | Number of L3 out objects for the tenants present. | [optional] 
**QosCustomPolCount** | **Int64** | Number of Quality Of Service Custom Policy. | [optional] 
**RecordType** | **String** | Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected. | [optional] 
**RecordVersion** | **String** | Version of record being pushed. This determines what was the API version for data available from the device. | [optional] 
**SiteName** | **String** | The Site name represents an APIC cluster. Service Engine can onboard multiple APIC clusters / sites. | [optional] 
**Ssm** | **String** | SSM property feature usage. | [optional] 
**SsmCount** | **Int64** | Number of context-level ssm translate policies per tenant. | [optional] 
**TcamOptCount** | **Int64** | Number of TCAM optimization enabled per tenant. | [optional] 
**TraceRouteEpCount** | **Int64** | Number of ITrace route endpoint per tenant. | [optional] 
**TraceRouteEpExtCount** | **Int64** | Number of ITrace endpoint external routes per tenant. | [optional] 
**TraceRouteExtEpCount** | **Int64** | Number of ITrace external endpoint routes per tenant. | [optional] 
**TraceRouteExtExtCount** | **Int64** | Number of ITrace external routes per tenant. | [optional] 
**VnsAbsGraphCount** | **Int64** | Number of objects with L4 to L7 Services graph. | [optional] 
**VnsBackupPolCount** | **Int64** | Number of objects with Policy Based Routing standby Node. Checks the Policy Based Routing backup policy. | [optional] 
**VnsRedirectDestCount** | **Int64** | Number of objects with Policy Based Routing standby Node. Policy based redirect requires a destination to redirect traffic. | [optional] 
**VnsSvcRedirectPolCount** | **Int64** | Number of Policy Based Routing and Policy Based Service Insertion objects. Includes without L4-L7 package. | [optional] 
**VrfCount** | **Int64** | Number of Vrfs per tenant. | [optional] 
**VzBrCpCount** | **Int64** | Number of Zoning Policy per tenant. | [optional] 
**VzRtConsCount** | **Int64** | Number of Client Contract between End Point Groups per tenant. | [optional] 
**VzRtProvCount** | **Int64** | Number of Client Contract between End Point Groups per tenant. | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$NiatelemetryTenant = Initialize-IntersightNiatelemetryTenant  -ClassId null `
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
 -Var0ClusterReplicationNetworkPolicy null `
 -Ancestors null `
 -Parent null `
 -PermissionResources null `
 -DisplayNames null `
 -BfdIfPolCount null `
 -BfdIfpCount null `
 -DhcpRsProvCount null `
 -Dn null `
 -FhsBdPolCount null `
 -FvApCount null `
 -FvBdCount null `
 -FvBdSubnetCount null `
 -FvBdnoArpCount null `
 -FvCepCount null `
 -FvRsBdToFhsCount null `
 -FvRsBdToOutCount null `
 -FvSiteConnpCount null `
 -FvSubnetCount null `
 -IpStaticRouteCount null `
 -L3MulticastCount null `
 -L3MulticastCtxCount null `
 -L3MulticastIfCount null `
 -L3outCount null `
 -QosCustomPolCount null `
 -RecordType null `
 -RecordVersion null `
 -SiteName null `
 -Ssm null `
 -SsmCount null `
 -TcamOptCount null `
 -TraceRouteEpCount null `
 -TraceRouteEpExtCount null `
 -TraceRouteExtEpCount null `
 -TraceRouteExtExtCount null `
 -VnsAbsGraphCount null `
 -VnsBackupPolCount null `
 -VnsRedirectDestCount null `
 -VnsSvcRedirectPolCount null `
 -VrfCount null `
 -VzBrCpCount null `
 -VzRtConsCount null `
 -VzRtProvCount null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$NiatelemetryTenant | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

