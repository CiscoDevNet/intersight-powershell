# MemoryPersistentMemoryPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Goals** | [**MemoryPersistentMemoryGoal[]**](MemoryPersistentMemoryGoal.md) |  | [optional] 
**LocalSecurity** | [**MemoryPersistentMemoryLocalSecurity**](MemoryPersistentMemoryLocalSecurity.md) |  | [optional] 
**LogicalNamespaces** | [**MemoryPersistentMemoryLogicalNamespace[]**](MemoryPersistentMemoryLogicalNamespace.md) |  | [optional] 
**ManagementMode** | **String** | Management Mode of the policy. This can be either Configured from Intersight or Configured from Operating System. | [optional] [default to "configured-from-intersight"]
**RetainNamespaces** | **Boolean** | Persistent Memory Namespaces to be retained or not. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**Profiles** | [**PolicyAbstractConfigProfileRelationship[]**](PolicyAbstractConfigProfileRelationship.md) | An array of relationships to policyAbstractConfigProfile resources. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightMemoryPersistentMemoryPolicyAllOf  -Goals null `
 -LocalSecurity null `
 -LogicalNamespaces null `
 -ManagementMode null `
 -RetainNamespaces null `
 -Organization null `
 -Profiles null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

