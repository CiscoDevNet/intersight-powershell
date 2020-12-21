# HclHyperflexSoftwareCompatibilityInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hcl.HyperflexSoftwareCompatibilityInfo"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hcl.HyperflexSoftwareCompatibilityInfo"]
**Constraints** | [**HclConstraint[]**](HclConstraint.md) |  | [optional] 
**HxdpVersion** | **String** | HXDP component software version. | [optional] 
**HypervisorType** | **String** | Type fo Hypervisor the HyperFlex components versions are compatible with. For example ESX, Hyperv or KVM. * &#x60;ESXi&#x60; - The hypervisor running on the HyperFlex cluster is a Vmware ESXi hypervisor of any version. * &#x60;HyperFlexAp&#x60; - The hypervisor running on the HyperFlex cluster is Cisco HyperFlex Application Platform. * &#x60;Hyper-V&#x60; - The hypervisor running on the HyperFlex cluster is Microsoft Hyper-V. * &#x60;Unknown&#x60; - The hypervisor running on the HyperFlex cluster is not known. | [optional] [default to "ESXi"]
**HypervisorVersion** | **String** | Hypervisor component software version. | [optional] 
**ServerFwVersion** | **String** | UCS Server Firmware component software version. | [optional] 
**AppCatalog** | [**HyperflexAppCatalogRelationship**](HyperflexAppCatalogRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HclHyperflexSoftwareCompatibilityInfoAllOf = Initialize-IntersightHclHyperflexSoftwareCompatibilityInfoAllOf  -ClassId null `
 -ObjectType null `
 -Constraints null `
 -HxdpVersion null `
 -HypervisorType null `
 -HypervisorVersion null `
 -ServerFwVersion null `
 -AppCatalog null
```

- Convert the resource to JSON
```powershell
$HclHyperflexSoftwareCompatibilityInfoAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

