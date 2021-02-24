# VnicLunAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "vnic.Lun"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "vnic.Lun"]
**Bootable** | **Boolean** | Specifies LUN is bootable. | [optional] 
**LunId** | **Int64** | The Identifier of the LUN. | [optional] 

## Examples

- Prepare the resource
```powershell
$VnicLunAllOf = Initialize-IntersightVnicLunAllOf  -ClassId null `
 -ObjectType null `
 -Bootable null `
 -LunId null
```

- Convert the resource to JSON
```powershell
$VnicLunAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

