# VnicSanConnectivityPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PlacementMode** | **String** | The mode used for placement of vnics on network adapters. It can either be Auto or Custom. | [optional] [default to "custom"]
**TargetPlatform** | **String** | The platform for which the server profile is applicable. It can either be a server that is operating in standalone mode or which is attached to a Fabric Interconnect managed by Intersight. | [optional] [default to "Standalone"]
**FcIfs** | [**VnicFcIfRelationship[]**](VnicFcIfRelationship.md) | An array of relationships to vnicFcIf resources. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**Profiles** | [**PolicyAbstractConfigProfileRelationship[]**](PolicyAbstractConfigProfileRelationship.md) | An array of relationships to policyAbstractConfigProfile resources. | [optional] 
**WwnnPool** | [**FcpoolPoolRelationship**](FcpoolPoolRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVnicSanConnectivityPolicyAllOf  -PlacementMode null `
 -TargetPlatform null `
 -FcIfs null `
 -Organization null `
 -Profiles null `
 -WwnnPool null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

