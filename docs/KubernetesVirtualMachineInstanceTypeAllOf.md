# KubernetesVirtualMachineInstanceTypeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "kubernetes.VirtualMachineInstanceType"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "kubernetes.VirtualMachineInstanceType"]
**Cpu** | **Int64** | Number of CPUs allocated to virtual machine. | [optional] [default to 4]
**DiskSize** | **Int64** | Ephemeral disk capacity to be provided with units example - 10Gi. | [optional] 
**Memory** | **Int64** | Virtual machine memory defined in mebibytes (MiB). | [optional] [default to 16384]
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**Profiles** | [**KubernetesVirtualMachineInfrastructureProviderRelationship[]**](KubernetesVirtualMachineInfrastructureProviderRelationship.md) | An array of relationships to kubernetesVirtualMachineInfrastructureProvider resources. | [optional] 

## Examples

- Prepare the resource
```powershell
$KubernetesVirtualMachineInstanceTypeAllOf = Initialize-IntersightKubernetesVirtualMachineInstanceTypeAllOf  -ClassId null `
 -ObjectType null `
 -Cpu null `
 -DiskSize null `
 -Memory null `
 -Organization null `
 -Profiles null
```

- Convert the resource to JSON
```powershell
$KubernetesVirtualMachineInstanceTypeAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

