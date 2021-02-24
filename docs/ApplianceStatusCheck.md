# ApplianceStatusCheck
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "appliance.StatusCheck"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "appliance.StatusCheck"]
**Code** | **String** | Unique identifier of the status check. | [optional] 
**Result** | **String** | Result of this status check. * &#x60;OK&#x60; - Result of the check is OK. * &#x60;Warning&#x60; - Result of the check is Warning. * &#x60;Critical&#x60; - Result of the check is Critical. * &#x60;Info&#x60; - Result of the check is low. | [optional] [default to "OK"]

## Examples

- Prepare the resource
```powershell
$ApplianceStatusCheck = Initialize-IntersightApplianceStatusCheck  -ClassId null `
 -ObjectType null `
 -Code null `
 -Result null
```

- Convert the resource to JSON
```powershell
$ApplianceStatusCheck | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

