# VirtualizationBaseVirtualDiskAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | [default to "hyperflex.HxapVirtualDisk"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | [default to "hyperflex.HxapVirtualDisk"]
**Capacity** | **Int64** | Disk capacity represented in bytes. | [optional] 
**Name** | **String** | Name of the storage disk. Name must be unique within a Datastore. | [optional] 

## Examples

- Prepare the resource
```powershell
$VirtualizationBaseVirtualDiskAllOf = Initialize-IntersightVirtualizationBaseVirtualDiskAllOf  -ClassId null `
 -ObjectType null `
 -Capacity null `
 -Name null
```

- Convert the resource to JSON
```powershell
$VirtualizationBaseVirtualDiskAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

