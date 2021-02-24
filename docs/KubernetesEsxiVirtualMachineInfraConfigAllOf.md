# KubernetesEsxiVirtualMachineInfraConfigAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "kubernetes.EsxiVirtualMachineInfraConfig"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "kubernetes.EsxiVirtualMachineInfraConfig"]
**Cluster** | **String** | Name of the vSphere cluster on which the virtual machines are created. | [optional] 
**Datastore** | **String** | Name of the datasore on which the virtual machine disks are created. | [optional] 
**IsPassphraseSet** | **Boolean** | Indicates whether the value of the &#39;passphrase&#39; property has been set. | [optional] [readonly] [default to $false]
**Passphrase** | **String** | Passphrase for the vcenter user. | [optional] 
**ResourcePool** | **String** | Name of the vSphere resource pool on which the virtual machines are created. | [optional] 

## Examples

- Prepare the resource
```powershell
$KubernetesEsxiVirtualMachineInfraConfigAllOf = Initialize-IntersightKubernetesEsxiVirtualMachineInfraConfigAllOf  -ClassId null `
 -ObjectType null `
 -Cluster null `
 -Datastore null `
 -IsPassphraseSet null `
 -Passphrase null `
 -ResourcePool null
```

- Convert the resource to JSON
```powershell
$KubernetesEsxiVirtualMachineInfraConfigAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

