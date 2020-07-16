# FcpoolPoolAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IdBlocks** | [**FcpoolBlock[]**](FcpoolBlock.md) |  | [optional] 
**PoolPurpose** | **String** | Purpose of this WWN pool. | [optional] 
**BlockHeads** | [**FcpoolFcBlockRelationship[]**](FcpoolFcBlockRelationship.md) | An array of relationships to fcpoolFcBlock resources. | [optional] [readonly] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFcpoolPoolAllOf  -IdBlocks null `
 -PoolPurpose null `
 -BlockHeads null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

