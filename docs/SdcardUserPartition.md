# SdcardUserPartition
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "sdcard.UserPartition"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "sdcard.UserPartition"]
**Enable** | **Boolean** | Enable the respective virtual drive to be available to the host. | [optional] 
**Name** | **String** | Name of virtual drive for user partition. | [optional] [default to "UserPartition"]

## Examples

- Prepare the resource
```powershell
$SdcardUserPartition = Initialize-IntersightSdcardUserPartition  -ClassId null `
 -ObjectType null `
 -Enable null `
 -Name null
```

- Convert the resource to JSON
```powershell
$SdcardUserPartition | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

