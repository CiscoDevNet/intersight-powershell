# IqnpoolLeaseAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iqnpool.Lease"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iqnpool.Lease"]
**IqnAddress** | **String** | IQN address allocated for pool-based allocation &quot;&quot;prefix+suffix+number&quot;&quot;. | [optional] 
**AssignedToEntity** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**Pool** | [**IqnpoolPoolRelationship**](IqnpoolPoolRelationship.md) |  | [optional] 
**PoolMember** | [**IqnpoolPoolMemberRelationship**](IqnpoolPoolMemberRelationship.md) |  | [optional] 
**Universe** | [**IqnpoolUniverseRelationship**](IqnpoolUniverseRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$IqnpoolLeaseAllOf = Initialize-IntersightIqnpoolLeaseAllOf  -ClassId null `
 -ObjectType null `
 -IqnAddress null `
 -AssignedToEntity null `
 -Pool null `
 -PoolMember null `
 -Universe null
```

- Convert the resource to JSON
```powershell
$IqnpoolLeaseAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

