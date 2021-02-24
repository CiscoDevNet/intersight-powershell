# VnicIscsiBootPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "vnic.IscsiBootPolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "vnic.IscsiBootPolicy"]
**AutoTargetvendorName** | **String** | Auto target interface that is represented via the Initiator name or the DHCP vendor ID. The vendor ID can be up to 32 alphanumeric characters. | [optional] 
**Chap** | [**VnicIscsiAuthProfile**](VnicIscsiAuthProfile.md) |  | [optional] 
**InitiatorIpSource** | **String** | Source Type of Initiator IP Address - Auto/Static/Pool. * &#x60;None&#x60; - Type defines that property is not applicable for an interface. * &#x60;Auto&#x60; - The system selects an interface automatically - DHCP. * &#x60;Static&#x60; - Type represents that static information or properties are associated to an interface. * &#x60;Pool&#x60; - Type defines that property value will be fetched from an associated pool. | [optional] [default to "None"]
**InitiatorStaticIpV4Address** | **String** | Static IP address provided for iSCSI Initiator. | [optional] 
**InitiatorStaticIpV4Config** | [**IppoolIpV4Config**](IppoolIpV4Config.md) |  | [optional] 
**MutualChap** | [**VnicIscsiAuthProfile**](VnicIscsiAuthProfile.md) |  | [optional] 
**TargetSourceType** | **String** | Source Type of Targets - Auto/Static. * &#x60;None&#x60; - Type defines that property is not applicable for an interface. * &#x60;Auto&#x60; - The system selects an interface automatically - DHCP. * &#x60;Static&#x60; - Type represents that static information or properties are associated to an interface. * &#x60;Pool&#x60; - Type defines that property value will be fetched from an associated pool. | [optional] [default to "None"]
**InitiatorIpPool** | [**IppoolPoolRelationship**](IppoolPoolRelationship.md) |  | [optional] 
**IscsiAdapterPolicy** | [**VnicIscsiAdapterPolicyRelationship**](VnicIscsiAdapterPolicyRelationship.md) |  | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**PrimaryTargetPolicy** | [**VnicIscsiStaticTargetPolicyRelationship**](VnicIscsiStaticTargetPolicyRelationship.md) |  | [optional] 
**SecondaryTargetPolicy** | [**VnicIscsiStaticTargetPolicyRelationship**](VnicIscsiStaticTargetPolicyRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$VnicIscsiBootPolicyAllOf = Initialize-IntersightVnicIscsiBootPolicyAllOf  -ClassId null `
 -ObjectType null `
 -AutoTargetvendorName null `
 -Chap null `
 -InitiatorIpSource null `
 -InitiatorStaticIpV4Address null `
 -InitiatorStaticIpV4Config null `
 -MutualChap null `
 -TargetSourceType null `
 -InitiatorIpPool null `
 -IscsiAdapterPolicy null `
 -Organization null `
 -PrimaryTargetPolicy null `
 -SecondaryTargetPolicy null
```

- Convert the resource to JSON
```powershell
$VnicIscsiBootPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

