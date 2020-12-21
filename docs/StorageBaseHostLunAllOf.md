# StorageBaseHostLunAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**Hlu** | **Int64** | Logical unit number (LUN) by which hosts address specified volume. Hlu is a decimal representation of the LUN from the endpoint. | [optional] [readonly] 
**HostName** | **String** | Name of the host associated with LUN. | [optional] [readonly] 
**VolumeName** | **String** | Name of the storage volume associated with LUN. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$StorageBaseHostLunAllOf = Initialize-IntersightStorageBaseHostLunAllOf  -ClassId null `
 -ObjectType null `
 -Hlu null `
 -HostName null `
 -VolumeName null
```

- Convert the resource to JSON
```powershell
$StorageBaseHostLunAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

