# VirtualizationEsxiVmConfiguration
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "virtualization.EsxiVmConfiguration"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "virtualization.EsxiVmConfiguration"]
**Annotation** | **String** | Specify annotation (optional) for the virtual machine. | [optional] 
**Compute** | [**VirtualizationEsxiVmComputeConfiguration**](VirtualizationEsxiVmComputeConfiguration.md) |  | [optional] 
**Customspec** | [**VirtualizationBaseCustomSpec**](VirtualizationBaseCustomSpec.md) |  | [optional] 
**Datacenter** | **String** | Datacenter where virtual machine is deployed. | [optional] 
**Folder** | **String** | Folder where virtual machine is deployed. | [optional] 
**Image** | **String** | Image path of OVA (The image can be from any location). | [optional] 
**Network** | [**VirtualizationEsxiVmNetworkConfiguration**](VirtualizationEsxiVmNetworkConfiguration.md) |  | [optional] 
**Storage** | [**VirtualizationEsxiVmStorageConfiguration**](VirtualizationEsxiVmStorageConfiguration.md) |  | [optional] 
**Template** | **String** | Template to be used for clone. | [optional] 

## Examples

- Prepare the resource
```powershell
$VirtualizationEsxiVmConfiguration = Initialize-IntersightVirtualizationEsxiVmConfiguration  -ClassId null `
 -ObjectType null `
 -Annotation null `
 -Compute null `
 -Customspec null `
 -Datacenter null `
 -Folder null `
 -Image null `
 -Network null `
 -Storage null `
 -Template null
```

- Convert the resource to JSON
```powershell
$VirtualizationEsxiVmConfiguration | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

