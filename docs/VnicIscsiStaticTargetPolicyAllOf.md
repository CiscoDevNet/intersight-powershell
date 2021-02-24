# VnicIscsiStaticTargetPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "vnic.IscsiStaticTargetPolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "vnic.IscsiStaticTargetPolicy"]
**IpAddress** | **String** | The IPv4 address assigned to the iSCSI target. | [optional] 
**Lun** | [**VnicLun**](VnicLun.md) |  | [optional] 
**Port** | **Int64** | The port associated with the iSCSI target. | [optional] 
**TargetName** | **String** | Qualified Name (IQN) or Extended Unique Identifier (EUI) name of the iSCSI target. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$VnicIscsiStaticTargetPolicyAllOf = Initialize-IntersightVnicIscsiStaticTargetPolicyAllOf  -ClassId null `
 -ObjectType null `
 -IpAddress null `
 -Lun null `
 -Port null `
 -TargetName null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$VnicIscsiStaticTargetPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

