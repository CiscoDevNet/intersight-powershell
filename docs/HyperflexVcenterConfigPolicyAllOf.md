# HyperflexVcenterConfigPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.VcenterConfigPolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.VcenterConfigPolicy"]
**DataCenter** | **String** | The vCenter datacenter name. | [optional] 
**Hostname** | **String** | The vCenter server FQDN or IP. | [optional] 
**IsPasswordSet** | **Boolean** | Indicates whether the value of the &#39;password&#39; property has been set. | [optional] [readonly] [default to $false]
**Password** | **String** | The password for authenticating with vCenter. Follow the corresponding password policy governed by vCenter. | [optional] 
**SsoUrl** | **String** | Overrides the default vCenter Single Sign-On URL. Do not specify unless instructed by Cisco TAC. | [optional] 
**Username** | **String** | The vCenter username (e.g. administrator@vsphere.local). | [optional] 
**ClusterProfiles** | [**HyperflexClusterProfileRelationship[]**](HyperflexClusterProfileRelationship.md) | An array of relationships to hyperflexClusterProfile resources. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexVcenterConfigPolicyAllOf = Initialize-IntersightHyperflexVcenterConfigPolicyAllOf  -ClassId null `
 -ObjectType null `
 -DataCenter null `
 -Hostname null `
 -IsPasswordSet null `
 -Password null `
 -SsoUrl null `
 -Username null `
 -ClusterProfiles null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$HyperflexVcenterConfigPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

