# KubernetesVirtualMachineInfrastructureProviderAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "kubernetes.VirtualMachineInfrastructureProvider"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "kubernetes.VirtualMachineInfrastructureProvider"]
**InfraConfig** | [**KubernetesBaseVirtualMachineInfraConfig**](KubernetesBaseVirtualMachineInfraConfig.md) |  | [optional] 
**InstanceType** | [**KubernetesVirtualMachineInstanceTypeRelationship**](KubernetesVirtualMachineInstanceTypeRelationship.md) |  | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**Target** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$KubernetesVirtualMachineInfrastructureProviderAllOf = Initialize-IntersightKubernetesVirtualMachineInfrastructureProviderAllOf  -ClassId null `
 -ObjectType null `
 -InfraConfig null `
 -InstanceType null `
 -Organization null `
 -Target null
```

- Convert the resource to JSON
```powershell
$KubernetesVirtualMachineInfrastructureProviderAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

