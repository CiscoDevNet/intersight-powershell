# KubernetesAddonPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "kubernetes.AddonPolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "kubernetes.AddonPolicy"]
**SystemManaged** | **Boolean** | To determine if Addon Policy is automatically managed by the system. | [optional] 
**Addons** | [**KubernetesAddonRelationship[]**](KubernetesAddonRelationship.md) | An array of relationships to kubernetesAddon resources. | [optional] 
**ClusterProfiles** | [**KubernetesClusterProfileRelationship[]**](KubernetesClusterProfileRelationship.md) | An array of relationships to kubernetesClusterProfile resources. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$KubernetesAddonPolicyAllOf = Initialize-IntersightKubernetesAddonPolicyAllOf  -ClassId null `
 -ObjectType null `
 -SystemManaged null `
 -Addons null `
 -ClusterProfiles null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$KubernetesAddonPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

