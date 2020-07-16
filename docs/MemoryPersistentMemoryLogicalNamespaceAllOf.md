# MemoryPersistentMemoryLogicalNamespaceAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Capacity** | **Int32** | Capacity of this Namespace that is created or modified. | [optional] 
**Mode** | **String** | Mode of this Namespace that is created or modified. | [optional] [default to "raw"]
**Name** | **String** | Name of this Namespace to be created on the server. | [optional] 
**SocketId** | **Int32** | Socket ID of the region on which this Namespace has to be created or modified. | [optional] [default to 1]
**SocketMemoryId** | **String** | Socket Memory ID of the region on which this Namespace has to be created or modified. | [optional] [default to "Not Applicable"]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightMemoryPersistentMemoryLogicalNamespaceAllOf  -Capacity null `
 -Mode null `
 -Name null `
 -SocketId null `
 -SocketMemoryId null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

