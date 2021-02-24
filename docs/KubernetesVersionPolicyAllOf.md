# KubernetesVersionPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "kubernetes.VersionPolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "kubernetes.VersionPolicy"]
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**Profiles** | [**KubernetesNodeGroupProfileRelationship[]**](KubernetesNodeGroupProfileRelationship.md) | An array of relationships to kubernetesNodeGroupProfile resources. | [optional] 
**Version** | [**KubernetesVersionRelationship**](KubernetesVersionRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$KubernetesVersionPolicyAllOf = Initialize-IntersightKubernetesVersionPolicyAllOf  -ClassId null `
 -ObjectType null `
 -Organization null `
 -Profiles null `
 -Version null
```

- Convert the resource to JSON
```powershell
$KubernetesVersionPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

