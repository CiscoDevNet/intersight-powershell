# MetaRelationshipDefinitionAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApiAccess** | **String** | API access definition for this relationship. | [optional] [readonly] [default to "NoAccess"]
**Collection** | **Boolean** | Specifies whether the relationship is a collection. | [optional] [readonly] 
**Export** | **Boolean** | When turned off, the peer MO is not exported when the local MO is exported. | [optional] [readonly] 
**ExportWithPeer** | **Boolean** | When turned on, the local MO is exported when the peer is exported. | [optional] [readonly] 
**Name** | **String** | The name of the relationship. | [optional] [readonly] 
**Type** | **String** | Fully qualified type of the foreign managed object. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightMetaRelationshipDefinitionAllOf  -ApiAccess null `
 -Collection null `
 -Export null `
 -ExportWithPeer null `
 -Name null `
 -Type null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

