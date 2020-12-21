# MemoryPersistentMemoryPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "memory.PersistentMemoryPolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "memory.PersistentMemoryPolicy"]
**Goals** | [**MemoryPersistentMemoryGoal[]**](MemoryPersistentMemoryGoal.md) |  | [optional] 
**LocalSecurity** | [**MemoryPersistentMemoryLocalSecurity**](MemoryPersistentMemoryLocalSecurity.md) |  | [optional] 
**LogicalNamespaces** | [**MemoryPersistentMemoryLogicalNamespace[]**](MemoryPersistentMemoryLogicalNamespace.md) |  | [optional] 
**ManagementMode** | **String** | Management Mode of the policy. This can be either Configured from Intersight or Configured from Operating System. * &#x60;configured-from-intersight&#x60; - The Persistent Memory Modules are configured from Intersight thorugh Persistent Memory policy. * &#x60;configured-from-operating-system&#x60; - The Persistent Memory Modules are configured from operating system thorugh OS tools. | [optional] [default to "configured-from-intersight"]
**RetainNamespaces** | **Boolean** | Persistent Memory Namespaces to be retained or not. | [optional] [default to $true]
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**Profiles** | [**PolicyAbstractConfigProfileRelationship[]**](PolicyAbstractConfigProfileRelationship.md) | An array of relationships to policyAbstractConfigProfile resources. | [optional] 

## Examples

- Prepare the resource
```powershell
$MemoryPersistentMemoryPolicyAllOf = Initialize-IntersightMemoryPersistentMemoryPolicyAllOf  -ClassId null `
 -ObjectType null `
 -Goals null `
 -LocalSecurity null `
 -LogicalNamespaces null `
 -ManagementMode null `
 -RetainNamespaces null `
 -Organization null `
 -Profiles null
```

- Convert the resource to JSON
```powershell
$MemoryPersistentMemoryPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

