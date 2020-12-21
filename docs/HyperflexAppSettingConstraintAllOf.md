# HyperflexAppSettingConstraintAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.AppSettingConstraint"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.AppSettingConstraint"]
**HxdpVersion** | **String** | The supported HyperFlex Data Platform version in regex format. | [optional] 
**HypervisorType** | **String** | The hypervisor type for the HyperFlex cluster. * &#x60;ESXi&#x60; - The hypervisor running on the HyperFlex cluster is a Vmware ESXi hypervisor of any version. * &#x60;HyperFlexAp&#x60; - The hypervisor running on the HyperFlex cluster is Cisco HyperFlex Application Platform. * &#x60;Hyper-V&#x60; - The hypervisor running on the HyperFlex cluster is Microsoft Hyper-V. * &#x60;Unknown&#x60; - The hypervisor running on the HyperFlex cluster is not known. | [optional] [default to "ESXi"]
**MgmtPlatform** | **String** | The supported management platform for the HyperFlex Cluster. * &#x60;FI&#x60; - The host servers used in the cluster deployment are managed by a UCS Fabric Interconnect. * &#x60;EDGE&#x60; - The host servers used in the cluster deployment are standalone severs. | [optional] [default to "FI"]
**ServerModel** | **String** | The supported server models in regex format. | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexAppSettingConstraintAllOf = Initialize-IntersightHyperflexAppSettingConstraintAllOf  -ClassId null `
 -ObjectType null `
 -HxdpVersion null `
 -HypervisorType null `
 -MgmtPlatform null `
 -ServerModel null
```

- Convert the resource to JSON
```powershell
$HyperflexAppSettingConstraintAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

