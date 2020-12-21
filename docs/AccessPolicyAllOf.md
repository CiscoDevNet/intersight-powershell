# AccessPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "access.Policy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "access.Policy"]
**AddressType** | [**AccessAddressType**](AccessAddressType.md) |  | [optional] 
**InbandVlan** | **Int64** | VLAN to be used for server access over Inband network. | [optional] 
**InbandIpPool** | [**IppoolPoolRelationship**](IppoolPoolRelationship.md) |  | [optional] 
**InbandVrf** | [**VrfVrfRelationship**](VrfVrfRelationship.md) |  | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**Profiles** | [**PolicyAbstractConfigProfileRelationship[]**](PolicyAbstractConfigProfileRelationship.md) | An array of relationships to policyAbstractConfigProfile resources. | [optional] 

## Examples

- Prepare the resource
```powershell
$AccessPolicyAllOf = Initialize-IntersightAccessPolicyAllOf  -ClassId null `
 -ObjectType null `
 -AddressType null `
 -InbandVlan null `
 -InbandIpPool null `
 -InbandVrf null `
 -Organization null `
 -Profiles null
```

- Convert the resource to JSON
```powershell
$AccessPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

