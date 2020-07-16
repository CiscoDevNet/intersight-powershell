# HclHyperflexSoftwareCompatibilityInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Constraints** | [**HclConstraint[]**](HclConstraint.md) |  | [optional] 
**HxdpVersion** | **String** | HXDP component software version. | [optional] 
**HypervisorType** | **String** | Type fo Hypervisor the HyperFlex components versions are compatible with. For example ESX, Hyperv or KVM. | [optional] [default to "ESXi"]
**HypervisorVersion** | **String** | Hypervisor component software version. | [optional] 
**ServerFwVersion** | **String** | UCS Server Firmware component software version. | [optional] 
**AppCatalog** | [**HyperflexAppCatalogRelationship**](HyperflexAppCatalogRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHclHyperflexSoftwareCompatibilityInfoAllOf  -Constraints null `
 -HxdpVersion null `
 -HypervisorType null `
 -HypervisorVersion null `
 -ServerFwVersion null `
 -AppCatalog null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

