# SnmpTrap
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**Destination** | **String** | Address to which the SNMP trap information is sent. | [optional] 
**Enabled** | **Boolean** | Enables/disables the trap on the server If enabled, trap is active on the server. | [optional] 
**Port** | **Int64** | Port used by the server to communicate with trap destination. Enter a value between 1-65535. | [optional] 
**Type** | **String** | Type of trap which decides whether to receive a notification when a trap is received at the destination. | [optional] [default to "Trap"]
**User** | **String** | SNMP user for the trap. Applicable only to SNMPv3. | [optional] 
**Version** | **String** | SNMP version used for the trap. | [optional] [default to "V3"]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightSnmpTrap  -ClassId null `
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
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

