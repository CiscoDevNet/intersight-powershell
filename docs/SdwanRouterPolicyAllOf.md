# SdwanRouterPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "sdwan.RouterPolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "sdwan.RouterPolicy"]
**DeploymentSize** | **String** | Scale of the SD-WAN router virtual machine deployment. * &#x60;Typical&#x60; - Typical deployment configuration with 4 vCPUs and 4GB RAM. * &#x60;Minimal&#x60; - Minimal deployment configuration with 2 vCPUs and 4GB RAM. | [optional] [default to "Typical"]
**WanCount** | **Int64** | Number of WAN connections across the SD-WAN site. | [optional] [default to 2]
**WanTerminationType** | **String** | Defines if the WAN networks are singly or dually terminated. Dually terminated WANs are configured on all the SD-WAN routers. Singly terminated WANs are configured only on one of the SD-WAN routers. * &#x60;Single&#x60; - Singly terminated WANs ar evenly distributed across SD-WAN router nodes. A given WAN connection is available only on one of the router nodes. * &#x60;Dual&#x60; - Dually terminated WANs are configured on all the SD-WAN routers. A given WAN connection is available on multiple router nodes. | [optional] [default to "Single"]
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**Profiles** | [**SdwanProfileRelationship[]**](SdwanProfileRelationship.md) | An array of relationships to sdwanProfile resources. | [optional] 
**SolutionImage** | [**SoftwareSolutionDistributableRelationship**](SoftwareSolutionDistributableRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$SdwanRouterPolicyAllOf = Initialize-IntersightSdwanRouterPolicyAllOf  -ClassId null `
 -ObjectType null `
 -DeploymentSize null `
 -WanCount null `
 -WanTerminationType null `
 -Organization null `
 -Profiles null `
 -SolutionImage null
```

- Convert the resource to JSON
```powershell
$SdwanRouterPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

