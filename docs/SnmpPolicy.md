# SnmpPolicy
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "snmp.Policy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "snmp.Policy"]
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
**Description** | **String** | Description of the policy. | [optional] 
**Name** | **String** | Name of the concrete policy. | [optional] 
**AccessCommunityString** | **String** | The default SNMPv1, SNMPv2c community name or SNMPv3 username to include on any trap messages sent to the SNMP host. The name can be 18 characters long. | [optional] 
**CommunityAccess** | **String** | Controls access to the information in the inventory tables. Applicable only for SNMPv1 and SNMPv2c users. * &#x60;Disabled&#x60; - Blocks access to the information in the inventory tables. * &#x60;Limited&#x60; - Partial access to read the information in the inventory tables. * &#x60;Full&#x60; - Full access to read the information in the inventory tables. | [optional] [default to "Disabled"]
**Enabled** | **Boolean** | State of the SNMP Policy on the endpoint. If enabled, the endpoint sends SNMP traps to the designated host. | [optional] [default to $true]
**EngineId** | **String** | User-defined unique identification of the static engine. | [optional] 
**SnmpPort** | **Int64** | Port on which Cisco IMC SNMP agent runs. Enter a value between 1-65535. Reserved ports not allowed (22, 23, 80, 123, 389, 443, 623, 636, 2068, 3268, 3269). | [optional] [default to 161]
**SnmpTraps** | [**SnmpTrap[]**](SnmpTrap.md) |  | [optional] 
**SnmpUsers** | [**SnmpUser[]**](SnmpUser.md) |  | [optional] 
**SysContact** | **String** | Contact person responsible for the SNMP implementation. Enter a string up to 64 characters, such as an email address or a name and telephone number. | [optional] 
**SysLocation** | **String** | Location of host on which the SNMP agent (server) runs. | [optional] 
**TrapCommunity** | **String** | SNMP community group used for sending SNMP trap to other devices. Valid only for SNMPv2c users. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**Profiles** | [**PolicyAbstractConfigProfileRelationship[]**](PolicyAbstractConfigProfileRelationship.md) | An array of relationships to policyAbstractConfigProfile resources. | [optional] 

## Examples

- Prepare the resource
```powershell
$SnmpPolicy = Initialize-IntersightSnmpPolicy  -ClassId null `
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
 -Description null `
 -Name null `
 -AccessCommunityString null `
 -CommunityAccess null `
 -Enabled null `
 -EngineId null `
 -SnmpPort null `
 -SnmpTraps null `
 -SnmpUsers null `
 -SysContact null `
 -SysLocation null `
 -TrapCommunity null `
 -Organization null `
 -Profiles null
```

- Convert the resource to JSON
```powershell
$SnmpPolicy | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

