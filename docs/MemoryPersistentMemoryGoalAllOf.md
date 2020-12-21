# MemoryPersistentMemoryGoalAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "memory.PersistentMemoryGoal"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "memory.PersistentMemoryGoal"]
**MemoryModePercentage** | **Int64** | Volatile memory percentage. | [optional] 
**PersistentMemoryType** | **String** | Type of the Persistent Memory configuration where the Persistent Memory Modules are combined in an interleaved set or not. * &#x60;app-direct&#x60; - The App Direct interleaved Persistent Memory type. * &#x60;app-direct-non-interleaved&#x60; - The App Direct non-interleaved Persistent Memory type. | [optional] [default to "app-direct"]
**SocketId** | **String** | CPU Socket ID to which this goal will be applied. * &#x60;All Sockets&#x60; - All the CPU socket IDs in a server. | [optional] [default to "All Sockets"]

## Examples

- Prepare the resource
```powershell
$MemoryPersistentMemoryGoalAllOf = Initialize-IntersightMemoryPersistentMemoryGoalAllOf  -ClassId null `
 -ObjectType null `
 -MemoryModePercentage null `
 -PersistentMemoryType null `
 -SocketId null
```

- Convert the resource to JSON
```powershell
$MemoryPersistentMemoryGoalAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

