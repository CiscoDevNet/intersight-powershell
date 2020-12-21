# SnmpPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "snmp.Policy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "snmp.Policy"]
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
$SnmpPolicyAllOf = Initialize-IntersightSnmpPolicyAllOf  -ClassId null `
 -ObjectType null `
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
$SnmpPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

