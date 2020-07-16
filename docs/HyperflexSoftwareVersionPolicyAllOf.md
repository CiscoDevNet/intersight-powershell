# HyperflexSoftwareVersionPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HxdpVersion** | **String** | Desired HyperFlex Data Platform software version to apply on the HyperFlex cluster. | [optional] 
**HypervisorVersion** | **String** | Desired  hypervisor version to apply for all the nodes on the HyperFlex cluster. | [optional] 
**ServerFirmwareVersion** | **String** | Desired server firmware version to apply on the HyperFlex Cluster. | [optional] 
**UpgradeTypes** | **String[]** |  | [optional] 
**ClusterProfiles** | [**HyperflexClusterProfileRelationship[]**](HyperflexClusterProfileRelationship.md) | An array of relationships to hyperflexClusterProfile resources. | [optional] 
**HxdpVersionInfo** | [**SoftwareHyperflexDistributableRelationship**](SoftwareHyperflexDistributableRelationship.md) |  | [optional] 
**HypervisorVersionInfo** | [**SoftwareHyperflexDistributableRelationship**](SoftwareHyperflexDistributableRelationship.md) |  | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**ServerFirmwareVersionInfo** | [**FirmwareDistributableRelationship**](FirmwareDistributableRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHyperflexSoftwareVersionPolicyAllOf  -HxdpVersion null `
 -HypervisorVersion null `
 -ServerFirmwareVersion null `
 -UpgradeTypes null `
 -ClusterProfiles null `
 -HxdpVersionInfo null `
 -HypervisorVersionInfo null `
 -Organization null `
 -ServerFirmwareVersionInfo null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

