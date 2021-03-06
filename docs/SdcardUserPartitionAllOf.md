# SdcardUserPartitionAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "sdcard.UserPartition"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "sdcard.UserPartition"]
**Name** | **String** | Name of virtual drive for user partition. | [optional] [default to "UserPartition"]

## Examples

- Prepare the resource
```powershell
$SdcardUserPartitionAllOf = Initialize-IntersightSdcardUserPartitionAllOf  -ClassId null `
 -ObjectType null `
 -Name null
```

- Convert the resource to JSON
```powershell
$SdcardUserPartitionAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

