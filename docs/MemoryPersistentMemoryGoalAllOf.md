# MemoryPersistentMemoryGoalAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MemoryModePercentage** | **Int32** | Volatile memory percentage. | [optional] 
**PersistentMemoryType** | **String** | Type of the Persistent Memory configuration where the Persistent Memory Modules are combined in an interleaved set or not. | [optional] [default to "app-direct"]
**SocketId** | **String** | CPU Socket ID to which this goal will be applied. | [optional] [default to "All Sockets"]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightMemoryPersistentMemoryGoalAllOf  -MemoryModePercentage null `
 -PersistentMemoryType null `
 -SocketId null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

