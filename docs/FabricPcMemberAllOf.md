# FabricPcMemberAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "fabric.PcMember"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "fabric.PcMember"]
**PcId** | **Int64** | Port Channel Identifier for the collection of ports. | [optional] 
**PortPolicy** | [**FabricPortPolicyRelationship**](FabricPortPolicyRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$FabricPcMemberAllOf = Initialize-IntersightFabricPcMemberAllOf  -ClassId null `
 -ObjectType null `
 -PcId null `
 -PortPolicy null
```

- Convert the resource to JSON
```powershell
$FabricPcMemberAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

