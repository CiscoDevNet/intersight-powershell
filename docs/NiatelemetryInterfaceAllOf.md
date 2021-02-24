# NiatelemetryInterfaceAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "niatelemetry.Interface"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "niatelemetry.Interface"]
**InterfaceDownCount** | **Int64** | Return value of number of interafces down. | [optional] 
**InterfaceUpCount** | **Int64** | Return value of number of interafces up. | [optional] 

## Examples

- Prepare the resource
```powershell
$NiatelemetryInterfaceAllOf = Initialize-IntersightNiatelemetryInterfaceAllOf  -ClassId null `
 -ObjectType null `
 -InterfaceDownCount null `
 -InterfaceUpCount null
```

- Convert the resource to JSON
```powershell
$NiatelemetryInterfaceAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

