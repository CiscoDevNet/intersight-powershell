# VirtualizationEsxiVmStorageConfiguration
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "virtualization.EsxiVmStorageConfiguration"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "virtualization.EsxiVmStorageConfiguration"]
**Datastore** | **String** | Datastore where virtual machine is deployed. | [optional] 
**Disks** | [**VirtualizationVmEsxiDisk[]**](VirtualizationVmEsxiDisk.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$VirtualizationEsxiVmStorageConfiguration = Initialize-IntersightVirtualizationEsxiVmStorageConfiguration  -ClassId null `
 -ObjectType null `
 -Datastore null `
 -Disks null
```

- Convert the resource to JSON
```powershell
$VirtualizationEsxiVmStorageConfiguration | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

