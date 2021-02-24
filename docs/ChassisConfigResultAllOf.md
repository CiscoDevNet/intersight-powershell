# ChassisConfigResultAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "chassis.ConfigResult"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "chassis.ConfigResult"]
**VarProfile** | [**ChassisProfileRelationship**](ChassisProfileRelationship.md) |  | [optional] 
**ResultEntries** | [**ChassisConfigResultEntryRelationship[]**](ChassisConfigResultEntryRelationship.md) | An array of relationships to chassisConfigResultEntry resources. | [optional] 

## Examples

- Prepare the resource
```powershell
$ChassisConfigResultAllOf = Initialize-IntersightChassisConfigResultAllOf  -ClassId null `
 -ObjectType null `
 -VarProfile null `
 -ResultEntries null
```

- Convert the resource to JSON
```powershell
$ChassisConfigResultAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

