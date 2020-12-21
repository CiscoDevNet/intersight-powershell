# HyperflexSoftwareVersionPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.SoftwareVersionPolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.SoftwareVersionPolicy"]
**HxdpVersion** | **String** | Desired HyperFlex Data Platform software version to apply on the HyperFlex cluster. | [optional] 
**HypervisorVersion** | **String** | Desired  hypervisor version to apply for all the nodes on the HyperFlex cluster. | [optional] 
**ServerFirmwareVersion** | **String** | Desired server firmware version to apply on the HyperFlex Cluster. | [optional] 
**ServerFirmwareVersions** | [**HyperflexServerFirmwareVersionInfo[]**](HyperflexServerFirmwareVersionInfo.md) |  | [optional] 
**UpgradeTypes** | **String[]** |  | [optional] 
**ClusterProfiles** | [**HyperflexClusterProfileRelationship[]**](HyperflexClusterProfileRelationship.md) | An array of relationships to hyperflexClusterProfile resources. | [optional] 
**HxdpVersionInfo** | [**SoftwareHyperflexDistributableRelationship**](SoftwareHyperflexDistributableRelationship.md) |  | [optional] 
**HypervisorVersionInfo** | [**SoftwareHyperflexDistributableRelationship**](SoftwareHyperflexDistributableRelationship.md) |  | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**ServerFirmwareVersionInfo** | [**FirmwareDistributableRelationship**](FirmwareDistributableRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexSoftwareVersionPolicyAllOf = Initialize-IntersightHyperflexSoftwareVersionPolicyAllOf  -ClassId null `
 -ObjectType null `
 -HxdpVersion null `
 -HypervisorVersion null `
 -ServerFirmwareVersion null `
 -ServerFirmwareVersions null `
 -UpgradeTypes null `
 -ClusterProfiles null `
 -HxdpVersionInfo null `
 -HypervisorVersionInfo null `
 -Organization null `
 -ServerFirmwareVersionInfo null
```

- Convert the resource to JSON
```powershell
$HyperflexSoftwareVersionPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

