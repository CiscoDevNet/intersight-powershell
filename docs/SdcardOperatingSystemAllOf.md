# SdcardOperatingSystemAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "sdcard.OperatingSystem"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "sdcard.OperatingSystem"]
**Name** | **String** | Name of virtual drive for operating system partition. | [optional] [default to "Hypervisor"]

## Examples

- Prepare the resource
```powershell
$SdcardOperatingSystemAllOf = Initialize-IntersightSdcardOperatingSystemAllOf  -ClassId null `
 -ObjectType null `
 -Name null
```

- Convert the resource to JSON
```powershell
$SdcardOperatingSystemAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

