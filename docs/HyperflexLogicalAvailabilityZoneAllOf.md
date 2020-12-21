# HyperflexLogicalAvailabilityZoneAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.LogicalAvailabilityZone"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.LogicalAvailabilityZone"]
**AutoConfig** | **Boolean** | Enable or disable Logical Availability Zones (LAZ). If enabled, HyperFlex Data Platform automatically selects and groups nodes into different availability zones. For HyperFlex Data Platform versions prior to 3.0 release, this setting does not apply. For HyperFlex Data Platform versions 3.0 or higher, this setting is only applicable to Fabric Interconnect attached HyperFlex systems with 8 or more converged nodes. | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$HyperflexLogicalAvailabilityZoneAllOf = Initialize-IntersightHyperflexLogicalAvailabilityZoneAllOf  -ClassId null `
 -ObjectType null `
 -AutoConfig null
```

- Convert the resource to JSON
```powershell
$HyperflexLogicalAvailabilityZoneAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

