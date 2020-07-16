# AccessPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InbandVlan** | **Int64** | VLAN to be used for server access over Inband network. | [optional] 
**InbandIpPool** | [**IppoolPoolRelationship**](IppoolPoolRelationship.md) |  | [optional] 
**InbandVrf** | [**VrfVrfRelationship**](VrfVrfRelationship.md) |  | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**Profiles** | [**PolicyAbstractConfigProfileRelationship[]**](PolicyAbstractConfigProfileRelationship.md) | An array of relationships to policyAbstractConfigProfile resources. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightAccessPolicyAllOf  -InbandVlan null `
 -InbandIpPool null `
 -InbandVrf null `
 -Organization null `
 -Profiles null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

