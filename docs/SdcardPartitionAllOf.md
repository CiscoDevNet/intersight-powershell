# SdcardPartitionAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "sdcard.Partition"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "sdcard.Partition"]
**Type** | **String** | This specifies the type of the partition. Allowed values are OS, Utility. * &#x60;OS&#x60; - This partition contains virtual drives where user can install operating system. * &#x60;Utility&#x60; - This partition contains virtual drives for utilities such as SCU, HUU, Drivers and Diagnostics. | [optional] [default to "OS"]
**VirtualDrives** | [**SdcardVirtualDrive[]**](SdcardVirtualDrive.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$SdcardPartitionAllOf = Initialize-IntersightSdcardPartitionAllOf  -ClassId null `
 -ObjectType null `
 -Type null `
 -VirtualDrives null
```

- Convert the resource to JSON
```powershell
$SdcardPartitionAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

