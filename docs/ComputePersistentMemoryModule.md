# ComputePersistentMemoryModule
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "compute.PersistentMemoryModule"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "compute.PersistentMemoryModule"]
**SocketId** | **String** | Socket ID of the Persistent Memory Module on the server. | [optional] 
**SocketMemoryId** | **String** | Socket Memory ID of the Persistent Memory Module on the server. | [optional] 

## Examples

- Prepare the resource
```powershell
$ComputePersistentMemoryModule = Initialize-IntersightComputePersistentMemoryModule  -ClassId null `
 -ObjectType null `
 -SocketId null `
 -SocketMemoryId null
```

- Convert the resource to JSON
```powershell
$ComputePersistentMemoryModule | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

