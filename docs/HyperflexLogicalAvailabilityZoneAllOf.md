# HyperflexLogicalAvailabilityZoneAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AutoConfig** | **Boolean** | Enable or disable Logical Availability Zones (LAZ). If enabled, HyperFlex Data Platform automatically selects and groups nodes into different availability zones. For HyperFlex Data Platform versions prior to 3.0 release, this setting does not apply. For HyperFlex Data Platform versions 3.0 or higher, this setting is only applicable to Fabric Interconnect attached HyperFlex systems with 8 or more converged nodes. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHyperflexLogicalAvailabilityZoneAllOf  -AutoConfig null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

