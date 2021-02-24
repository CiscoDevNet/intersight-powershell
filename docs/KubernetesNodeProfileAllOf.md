# KubernetesNodeProfileAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | [default to "kubernetes.VirtualMachineNodeProfile"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | [default to "kubernetes.VirtualMachineNodeProfile"]
**CloudProvider** | **String** | Cloud provider for this node profile. * &#x60;noProvider&#x60; - Enables the use of no cloud provider. * &#x60;external&#x60; - Out of tree cloud provider, e.g. CPI for vsphere. | [optional] [default to "noProvider"]
**NodeGroup** | [**KubernetesNodeGroupProfileRelationship**](KubernetesNodeGroupProfileRelationship.md) |  | [optional] 
**Target** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**Version** | [**KubernetesVersionRelationship**](KubernetesVersionRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$KubernetesNodeProfileAllOf = Initialize-IntersightKubernetesNodeProfileAllOf  -ClassId null `
 -ObjectType null `
 -CloudProvider null `
 -NodeGroup null `
 -Target null `
 -Version null
```

- Convert the resource to JSON
```powershell
$KubernetesNodeProfileAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

