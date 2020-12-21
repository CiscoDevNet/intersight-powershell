# SnmpTrapAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "snmp.Trap"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "snmp.Trap"]
**Destination** | **String** | Address to which the SNMP trap information is sent. | [optional] 
**Enabled** | **Boolean** | Enables/disables the trap on the server If enabled, trap is active on the server. | [optional] [default to $true]
**Port** | **Int64** | Port used by the server to communicate with trap destination. Enter a value between 1-65535. Reserved ports not allowed (22, 23, 80, 123, 389, 443, 623, 636, 2068, 3268, 3269). | [optional] [default to 162]
**Type** | **String** | Type of trap which decides whether to receive a notification when a trap is received at the destination. * &#x60;Trap&#x60; - Do not receive notifications when trap is sent to the destination. * &#x60;Inform&#x60; - Receive notifications when trap is sent to the destination. This option is valid only for V2 users. | [optional] [default to "Trap"]
**User** | **String** | SNMP user for the trap. Applicable only to SNMPv3. | [optional] 
**Version** | **String** | SNMP version used for the trap. * &#x60;V3&#x60; - SNMP v3 trap version notifications. * &#x60;V2&#x60; - SNMP v2 trap version notifications. | [optional] [default to "V3"]

## Examples

- Prepare the resource
```powershell
$SnmpTrapAllOf = Initialize-IntersightSnmpTrapAllOf  -ClassId null `
 -ObjectType null `
 -Destination null `
 -Enabled null `
 -Port null `
 -Type null `
 -User null `
 -Version null
```

- Convert the resource to JSON
```powershell
$SnmpTrapAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

