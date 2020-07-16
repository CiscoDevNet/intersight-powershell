# HyperflexAppCatalogAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Version** | **String** | The catalog version used in HyperFlex cluster configuration service. | [optional] 
**FeatureLimitExternal** | [**HyperflexFeatureLimitExternalRelationship**](HyperflexFeatureLimitExternalRelationship.md) |  | [optional] 
**FeatureLimitInternal** | [**HyperflexFeatureLimitInternalRelationship**](HyperflexFeatureLimitInternalRelationship.md) |  | [optional] 
**HxdpVersions** | [**HyperflexHxdpVersionRelationship[]**](HyperflexHxdpVersionRelationship.md) | An array of relationships to hyperflexHxdpVersion resources. | [optional] 
**HyperflexCapabilityInfos** | [**HyperflexCapabilityInfoRelationship[]**](HyperflexCapabilityInfoRelationship.md) | An array of relationships to hyperflexCapabilityInfo resources. | [optional] 
**HyperflexSoftwareCompatibilityInfos** | [**HclHyperflexSoftwareCompatibilityInfoRelationship[]**](HclHyperflexSoftwareCompatibilityInfoRelationship.md) | An array of relationships to hclHyperflexSoftwareCompatibilityInfo resources. | [optional] 
**ServerFirmwareVersion** | [**HyperflexServerFirmwareVersionRelationship**](HyperflexServerFirmwareVersionRelationship.md) |  | [optional] 
**ServerModel** | [**HyperflexServerModelRelationship**](HyperflexServerModelRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHyperflexAppCatalogAllOf  -Version null `
 -FeatureLimitExternal null `
 -FeatureLimitInternal null `
 -HxdpVersions null `
 -HyperflexCapabilityInfos null `
 -HyperflexSoftwareCompatibilityInfos null `
 -ServerFirmwareVersion null `
 -ServerModel null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

