# CapabilityPortRangeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EndPortId** | **Int64** | Ending Port ID in this range of ports. | [optional] 
**EndSlotId** | **Int64** | Ending Slot ID in this range of ports. | [optional] 
**StartPortId** | **Int64** | Starting Port ID in this range of ports. | [optional] 
**StartSlotId** | **Int64** | Starting Slot ID in this range of ports. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightCapabilityPortRangeAllOf  -EndPortId null `
 -EndSlotId null `
 -StartPortId null `
 -StartSlotId null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

