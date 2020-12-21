# HyperflexNodeConfigPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.NodeConfigPolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.NodeConfigPolicy"]
**DataIpRange** | [**HyperflexIpAddrRange**](HyperflexIpAddrRange.md) |  | [optional] 
**HxdpIpRange** | [**HyperflexIpAddrRange**](HyperflexIpAddrRange.md) |  | [optional] 
**HypervisorControlIpRange** | [**HyperflexIpAddrRange**](HyperflexIpAddrRange.md) |  | [optional] 
**MgmtIpRange** | [**HyperflexIpAddrRange**](HyperflexIpAddrRange.md) |  | [optional] 
**NodeNamePrefix** | **String** | The node name prefix that is used to automatically generate the default hostname for each server. A dash (-) will be appended to the prefix followed by the node number to form a hostname. This default naming scheme can be manually overridden in the node configuration. The maximum length of a prefix is 60, must only contain alphanumeric characters or dash (-), and must start with an alphanumeric character. | [optional] 
**ClusterProfiles** | [**HyperflexClusterProfileRelationship[]**](HyperflexClusterProfileRelationship.md) | An array of relationships to hyperflexClusterProfile resources. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexNodeConfigPolicyAllOf = Initialize-IntersightHyperflexNodeConfigPolicyAllOf  -ClassId null `
 -ObjectType null `
 -DataIpRange null `
 -HxdpIpRange null `
 -HypervisorControlIpRange null `
 -MgmtIpRange null `
 -NodeNamePrefix null `
 -ClusterProfiles null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$HyperflexNodeConfigPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

