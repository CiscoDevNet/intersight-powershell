# ChassisConfigResultEntryAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "chassis.ConfigResultEntry"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "chassis.ConfigResultEntry"]
**ConfigResult** | [**ChassisConfigResultRelationship**](ChassisConfigResultRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChassisConfigResultEntryAllOf = Initialize-IntersightChassisConfigResultEntryAllOf  -ClassId null `
 -ObjectType null `
 -ConfigResult null
```

- Convert the resource to JSON
```powershell
$ChassisConfigResultEntryAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

