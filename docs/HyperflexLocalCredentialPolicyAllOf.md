# HyperflexLocalCredentialPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.LocalCredentialPolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.LocalCredentialPolicy"]
**FactoryHypervisorPassword** | **Boolean** | Indicates if Hypervisor password is the factory set default password. For HyperFlex Data Platform versions 3.0 or higher, enable this if the default password was not changed on the Hypervisor. It is required to supply a new custom Hypervisor password that will be applied to the Hypervisor during deployment. For HyperFlex Data Platform versions prior to 3.0 release, this setting has no effect and the default password will be used for initial install. The Hypervisor password should be changed after deployment. | [optional] [default to $false]
**HxdpRootPwd** | **String** | HyperFlex storage controller VM password must contain a minimum of 10 characters, with at least 1 lowercase, 1 uppercase, 1 numeric, and 1 of these -_@#$%^&amp;*! special characters. | [optional] 
**HypervisorAdmin** | **String** | Hypervisor administrator username must contain only alphanumeric characters. | [optional] 
**HypervisorAdminPwd** | **String** | The ESXi root password. For HyperFlex Data Platform 3.0 or later, if the factory default password was not manually changed, you must set a new custom password. If the password was manually changed, you must not enable the factory default password property and provide the current hypervisor password. Note - All HyperFlex nodes require the same hypervisor password for installation. For HyperFlex Data Platform prior to 3.0, use the default password &quot;&quot;Cisco123&quot;&quot; for newly manufactured HyperFlex servers. A custom password should only be entered if hypervisor credentials were manually changed prior to deployment. | [optional] 
**IsHxdpRootPwdSet** | **Boolean** | Indicates whether the value of the &#39;hxdpRootPwd&#39; property has been set. | [optional] [readonly] [default to $false]
**IsHypervisorAdminPwdSet** | **Boolean** | Indicates whether the value of the &#39;hypervisorAdminPwd&#39; property has been set. | [optional] [readonly] [default to $false]
**ClusterProfiles** | [**HyperflexClusterProfileRelationship[]**](HyperflexClusterProfileRelationship.md) | An array of relationships to hyperflexClusterProfile resources. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexLocalCredentialPolicyAllOf = Initialize-IntersightHyperflexLocalCredentialPolicyAllOf  -ClassId null `
 -ObjectType null `
 -FactoryHypervisorPassword null `
 -HxdpRootPwd null `
 -HypervisorAdmin null `
 -HypervisorAdminPwd null `
 -IsHxdpRootPwdSet null `
 -IsHypervisorAdminPwdSet null `
 -ClusterProfiles null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$HyperflexLocalCredentialPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

