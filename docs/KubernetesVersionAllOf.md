# KubernetesVersionAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "kubernetes.Version"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "kubernetes.Version"]
**KubernetesVersion** | **String** | Desired Kubernetes version. | [optional] 
**Name** | **String** | The name of this IKS kubernetes version. | [optional] 
**BootIso** | [**SoftwareSolutionDistributableRelationship**](SoftwareSolutionDistributableRelationship.md) |  | [optional] 
**Catalog** | [**KubernetesCatalogRelationship**](KubernetesCatalogRelationship.md) |  | [optional] 
**OvaImageTemplate** | [**SoftwareSolutionDistributableRelationship**](SoftwareSolutionDistributableRelationship.md) |  | [optional] 
**Qcow2NodeTemplate** | [**SoftwareSolutionDistributableRelationship**](SoftwareSolutionDistributableRelationship.md) |  | [optional] 
**Qcow2VirtualMachineTemplate** | [**SoftwareSolutionDistributableRelationship**](SoftwareSolutionDistributableRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$KubernetesVersionAllOf = Initialize-IntersightKubernetesVersionAllOf  -ClassId null `
 -ObjectType null `
 -KubernetesVersion null `
 -Name null `
 -BootIso null `
 -Catalog null `
 -OvaImageTemplate null `
 -Qcow2NodeTemplate null `
 -Qcow2VirtualMachineTemplate null
```

- Convert the resource to JSON
```powershell
$KubernetesVersionAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

