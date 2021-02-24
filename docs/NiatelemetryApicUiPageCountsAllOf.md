# NiatelemetryApicUiPageCountsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "niatelemetry.ApicUiPageCounts"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "niatelemetry.ApicUiPageCounts"]
**PageCount** | **Int64** | Number of times that the user has opened this page. | [optional] 
**PageName** | **String** | Name of the page for which page count is recorded. | [optional] 
**RecordType** | **String** | Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected. | [optional] 
**RecordVersion** | **String** | Version of record being pushed. This determines what was the API version for data available from the device. | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$NiatelemetryApicUiPageCountsAllOf = Initialize-IntersightNiatelemetryApicUiPageCountsAllOf  -ClassId null `
 -ObjectType null `
 -PageCount null `
 -PageName null `
 -RecordType null `
 -RecordVersion null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$NiatelemetryApicUiPageCountsAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

