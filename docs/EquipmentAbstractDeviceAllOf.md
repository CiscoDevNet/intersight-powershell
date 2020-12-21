# EquipmentAbstractDeviceAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**Name** | **String** | Administrator defined name for the device. | [optional] [readonly] 
**Uuid** | **String** | Unique identity of the device. | [optional] [readonly] 
**Version** | **String** | Current running software version of the device. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$EquipmentAbstractDeviceAllOf = Initialize-IntersightEquipmentAbstractDeviceAllOf  -ClassId null `
 -ObjectType null `
 -Name null `
 -Uuid null `
 -Version null
```

- Convert the resource to JSON
```powershell
$EquipmentAbstractDeviceAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

