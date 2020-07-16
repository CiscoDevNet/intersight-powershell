# MacpoolPoolMemberAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MacAddress** | **String** | MAC Address of this pool member. | [optional] 
**AssignedToEntity** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**BlockHead** | [**MacpoolIdBlockRelationship**](MacpoolIdBlockRelationship.md) |  | [optional] 
**Peer** | [**MacpoolLeaseRelationship**](MacpoolLeaseRelationship.md) |  | [optional] 
**Pool** | [**MacpoolPoolRelationship**](MacpoolPoolRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightMacpoolPoolMemberAllOf  -MacAddress null `
 -AssignedToEntity null `
 -BlockHead null `
 -Peer null `
 -Pool null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

