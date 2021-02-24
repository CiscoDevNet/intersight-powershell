# ComputeVmediaAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "compute.Vmedia"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "compute.Vmedia"]
**Enabled** | **Boolean** | State of the Virtual Media service on the server. | [optional] [readonly] [default to $true]
**Encryption** | **Boolean** | If enabled, allows encryption of all Virtual Media communications. | [optional] [readonly] 
**LowPowerUsb** | **Boolean** | If enabled, the virtual drives appear on the boot selection menu after mapping the image and rebooting the host. | [optional] [readonly] [default to $true]
**ComputePhysicalUnit** | [**ComputePhysicalRelationship**](ComputePhysicalRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ComputeVmediaAllOf = Initialize-IntersightComputeVmediaAllOf  -ClassId null `
 -ObjectType null `
 -Enabled null `
 -Encryption null `
 -LowPowerUsb null `
 -ComputePhysicalUnit null
```

- Convert the resource to JSON
```powershell
$ComputeVmediaAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

