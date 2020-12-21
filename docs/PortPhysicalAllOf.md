# PortPhysicalAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**OperState** | **String** | Operational state of this port (enabled/disabled). | [optional] [readonly] 
**OperStateQual** | **String** | Reason for this port&#39;s Operational state. | [optional] [readonly] 
**PortId** | **Int64** | Switch physical port identifier. | [optional] [readonly] 
**Role** | **String** | The role assigned to this port. | [optional] [readonly] 
**SlotId** | **Int64** | Switch expansion slot module identifier. | [optional] [readonly] 
**SwitchId** | **String** | Switch Identifier that is local to a cluster. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$PortPhysicalAllOf = Initialize-IntersightPortPhysicalAllOf  -ClassId null `
 -ObjectType null `
 -OperState null `
 -OperStateQual null `
 -PortId null `
 -Role null `
 -SlotId null `
 -SwitchId null
```

- Convert the resource to JSON
```powershell
$PortPhysicalAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

