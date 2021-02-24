# NiatelemetryEpg
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "niatelemetry.Epg"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "niatelemetry.Epg"]
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
**AzurePackCount** | **Int64** | Azure Pack NAT with ASA feature usage. | [optional] 
**Dn** | **String** | Dn value for the End Point Groups present. | [optional] 
**EpgDelimiterCount** | **Int64** | Number of  objects with delimiter value present in EPG Delimiter attribute. | [optional] 
**FcNpvCount** | **Int64** | Number of ports with FC path attribute of type FC. | [optional] 
**FcoeCount** | **String** | Number of FCoE per End Point Group. | [optional] 
**FvRsDomAttCount** | **Int64** | Number of FvRsDomAtt objects per End Point Group with VMware configuration. | [optional] 
**IntraEpgDvsBmCount** | **Int64** | Intra End Point Group Contract for Distributed Virtual Switch and BM feature usage. | [optional] 
**IntraEpgHyperv** | **String** | Intra EPG Isolation for Hyper-V, enabled if pcEnfPref attribute is set to enforced. | [optional] 
**IsAttrBased** | **String** | Gets the state of End Point Groups with isAttrBasedEPg value as configured. | [optional] 
**Microsegmentation** | **String** | Gets the state of End Point Groups where microsegmentation is present. | [optional] 
**MicrosoftUsegCount** | **Int64** | Number of FvRsDomAtt objects per End Point Group with Microsoft configuration. | [optional] 
**Name** | **String** | Name value for the End Point Groups present. | [optional] 
**OrchslDevVipCfgCount** | **Int64** | Number of objects with Simplified Service Graph Integration with Windows Azure Pack. | [optional] 
**RecordType** | **String** | Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected. | [optional] 
**RecordVersion** | **String** | Version of record being pushed. This determines what was the API version for data available from the device. | [optional] 
**SiteName** | **String** | The Site name represents an APIC cluster. Service Engine can onboard multiple APIC clusters / sites. | [optional] 
**UsegHypervCount** | **Int64** | Logical Operators for attribute based microsegmentation in a hypervisor. | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$NiatelemetryEpg = Initialize-IntersightNiatelemetryEpg  -ClassId null `
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
 -AzurePackCount null `
 -Dn null `
 -EpgDelimiterCount null `
 -FcNpvCount null `
 -FcoeCount null `
 -FvRsDomAttCount null `
 -IntraEpgDvsBmCount null `
 -IntraEpgHyperv null `
 -IsAttrBased null `
 -Microsegmentation null `
 -MicrosoftUsegCount null `
 -Name null `
 -OrchslDevVipCfgCount null `
 -RecordType null `
 -RecordVersion null `
 -SiteName null `
 -UsegHypervCount null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$NiatelemetryEpg | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

