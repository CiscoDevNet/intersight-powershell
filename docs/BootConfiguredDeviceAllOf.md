# BootConfiguredDeviceAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**Name** | **String** | The name of the boot device configured in the boot policy. | [optional] 
**Order** | **Int64** | The order of the boot device configured in the boot policy. | [optional] 
**State** | **String** | The state of the boot device configured in the boot policy. | [optional] 
**Type** | **String** | The type of the boot device configured in the boot policy. | [optional] 

## Examples

- Prepare the resource
```powershell
$BootConfiguredDeviceAllOf = Initialize-IntersightBootConfiguredDeviceAllOf  -ClassId null `
 -ObjectType null `
 -Name null `
 -Order null `
 -State null `
 -Type null
```

- Convert the resource to JSON
```powershell
$BootConfiguredDeviceAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

