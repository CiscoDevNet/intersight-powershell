# KubernetesVirtualMachineNodeProfileAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "kubernetes.VirtualMachineNodeProfile"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "kubernetes.VirtualMachineNodeProfile"]
**IpAddresses** | [**IppoolIpLeaseRelationship[]**](IppoolIpLeaseRelationship.md) | An array of relationships to ippoolIpLease resources. | [optional] 
**NodeIp** | [**IppoolIpLeaseRelationship**](IppoolIpLeaseRelationship.md) |  | [optional] 
**VirtualMachine** | [**VirtualizationVirtualMachineRelationship**](VirtualizationVirtualMachineRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$KubernetesVirtualMachineNodeProfileAllOf = Initialize-IntersightKubernetesVirtualMachineNodeProfileAllOf  -ClassId null `
 -ObjectType null `
 -IpAddresses null `
 -NodeIp null `
 -VirtualMachine null
```

- Convert the resource to JSON
```powershell
$KubernetesVirtualMachineNodeProfileAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

