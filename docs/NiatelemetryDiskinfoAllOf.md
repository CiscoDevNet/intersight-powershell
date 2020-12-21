# NiatelemetryDiskinfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "niatelemetry.Diskinfo"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "niatelemetry.Diskinfo"]
**Free** | **Int64** | The free disk capacity, currently the type of this field is set to integer. This determines how much memory is free in Bytes. | [optional] 
**Name** | **String** | Disk Name used to identified the disk usage record. This determines the name of the disk partition that is inventoried. | [optional] 
**Total** | **Int64** | The total disk capacity, it should be the sum of free and used, currently the type of this field is set to integer. This determines the total memory for this partition. | [optional] 
**Used** | **Int64** | The used disk capacity, currently the type of this field is set to integer. This determines how much memory is used in Bytes. | [optional] 

## Examples

- Prepare the resource
```powershell
$NiatelemetryDiskinfoAllOf = Initialize-IntersightNiatelemetryDiskinfoAllOf  -ClassId null `
 -ObjectType null `
 -Free null `
 -Name null `
 -Total null `
 -Used null
```

- Convert the resource to JSON
```powershell
$NiatelemetryDiskinfoAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

