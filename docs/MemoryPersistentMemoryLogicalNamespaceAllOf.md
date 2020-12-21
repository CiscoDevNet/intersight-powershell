# MemoryPersistentMemoryLogicalNamespaceAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "memory.PersistentMemoryLogicalNamespace"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "memory.PersistentMemoryLogicalNamespace"]
**Capacity** | **Int64** | Capacity of this Namespace that is created or modified. | [optional] 
**Mode** | **String** | Mode of this Namespace that is created or modified. * &#x60;raw&#x60; - The raw mode of Persistent Memory Namespace. * &#x60;block&#x60; - The block mode of Persistent Memory Namespace. | [optional] [default to "raw"]
**Name** | **String** | Name of this Namespace to be created on the server. | [optional] 
**SocketId** | **Int32** | Socket ID of the region on which this Namespace has to be created or modified. * &#x60;1&#x60; - The first CPU socket in a server. * &#x60;2&#x60; - The second CPU socket in a server. * &#x60;3&#x60; - The third CPU socket in a server. * &#x60;4&#x60; - The fourth CPU socket in a server. | [optional] [default to 1]
**SocketMemoryId** | **String** | Socket Memory ID of the region on which this Namespace has to be created or modified. * &#x60;Not Applicable&#x60; - The socket memory ID is not applicable if app-direct persistent memory type is selected in the goal. * &#x60;2&#x60; - The second socket memory ID within a socket in a server. * &#x60;4&#x60; - The fourth socket memory ID within a socket in a server. * &#x60;6&#x60; - The sixth socket memory ID within a socket in a server. * &#x60;8&#x60; - The eighth socket memory ID within a socket in a server. * &#x60;10&#x60; - The tenth socket memory ID within a socket in a server. * &#x60;12&#x60; - The twelfth socket memory ID within a socket in a server. | [optional] [default to "Not Applicable"]

## Examples

- Prepare the resource
```powershell
$MemoryPersistentMemoryLogicalNamespaceAllOf = Initialize-IntersightMemoryPersistentMemoryLogicalNamespaceAllOf  -ClassId null `
 -ObjectType null `
 -Capacity null `
 -Mode null `
 -Name null `
 -SocketId null `
 -SocketMemoryId null
```

- Convert the resource to JSON
```powershell
$MemoryPersistentMemoryLogicalNamespaceAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

