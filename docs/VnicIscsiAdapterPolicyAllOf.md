# VnicIscsiAdapterPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "vnic.IscsiAdapterPolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "vnic.IscsiAdapterPolicy"]
**ConnectionTimeOut** | **Int64** | The number of seconds to wait until Cisco UCS assumes that the initial login has failed and the iSCSI adapter is unavailable. | [optional] 
**DhcpTimeout** | **Int64** | The number of seconds to wait before the initiator assumes that the DHCP server is unavailable. | [optional] 
**LunBusyRetryCount** | **Int64** | The number of times to retry the connection in case of a failure during iSCSI LUN discovery. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$VnicIscsiAdapterPolicyAllOf = Initialize-IntersightVnicIscsiAdapterPolicyAllOf  -ClassId null `
 -ObjectType null `
 -ConnectionTimeOut null `
 -DhcpTimeout null `
 -LunBusyRetryCount null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$VnicIscsiAdapterPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

