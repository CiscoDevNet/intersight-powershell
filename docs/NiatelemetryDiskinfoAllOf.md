# NiatelemetryDiskinfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Free** | **Int64** | The free disk capacity, currently the type of this field is set to integer. This determines how much memory is free in Bytes. | [optional] 
**Name** | **String** | Disk Name used to identified the disk usage record. This determines the name of the disk partition that is inventoried. | [optional] 
**Total** | **Int64** | The total disk capacity, it should be the sum of free and used, currently the type of this field is set to integer. This determines the total memory for this partition. | [optional] 
**Used** | **Int64** | The used disk capacity, currently the type of this field is set to integer. This determines how much memory is used in Bytes. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightNiatelemetryDiskinfoAllOf  -Free null `
 -Name null `
 -Total null `
 -Used null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

