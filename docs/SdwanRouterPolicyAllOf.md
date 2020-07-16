# SdwanRouterPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeploymentSize** | **String** | Scale of the SD-WAN router virtual machine deployment. | [optional] [default to "Typical"]
**WanCount** | **Int64** | Number of WAN connections across the SD-WAN site. | [optional] 
**WanTerminationType** | **String** | Defines if the WAN networks are singly or dually terminated. Dually terminated WANs are configured on all the SD-WAN routers. Singly terminated WANs are configured only on one of the SD-WAN routers. | [optional] [default to "Single"]
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**Profiles** | [**SdwanProfileRelationship[]**](SdwanProfileRelationship.md) | An array of relationships to sdwanProfile resources. | [optional] 
**SolutionImage** | [**SoftwareSolutionDistributableRelationship**](SoftwareSolutionDistributableRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightSdwanRouterPolicyAllOf  -DeploymentSize null `
 -WanCount null `
 -WanTerminationType null `
 -Organization null `
 -Profiles null `
 -SolutionImage null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

