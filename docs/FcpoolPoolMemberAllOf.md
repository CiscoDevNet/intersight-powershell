# FcpoolPoolMemberAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WwnId** | **String** | WWN ID of this pool member. | [optional] 
**AssignedToEntity** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**BlockHead** | [**FcpoolFcBlockRelationship**](FcpoolFcBlockRelationship.md) |  | [optional] 
**Peer** | [**FcpoolLeaseRelationship**](FcpoolLeaseRelationship.md) |  | [optional] 
**Pool** | [**FcpoolPoolRelationship**](FcpoolPoolRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFcpoolPoolMemberAllOf  -WwnId null `
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

