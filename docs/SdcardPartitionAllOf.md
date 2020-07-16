# SdcardPartitionAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **String** | This specifies the type of the partition. Allowed values are OS, Utility. | [optional] [default to "OS"]
**VirtualDrives** | [**SdcardVirtualDrive[]**](SdcardVirtualDrive.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightSdcardPartitionAllOf  -Type null `
 -VirtualDrives null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

