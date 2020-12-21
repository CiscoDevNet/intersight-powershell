# ComputeRackUnitIdentityAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "compute.RackUnitIdentity"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "compute.RackUnitIdentity"]
**AdapterSerial** | **String** | Serial Identifier of an adapter participating in SWM. | [optional] 

## Examples

- Prepare the resource
```powershell
$ComputeRackUnitIdentityAllOf = Initialize-IntersightComputeRackUnitIdentityAllOf  -ClassId null `
 -ObjectType null `
 -AdapterSerial null
```

- Convert the resource to JSON
```powershell
$ComputeRackUnitIdentityAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

