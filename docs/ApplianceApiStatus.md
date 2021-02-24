# ApplianceApiStatus
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "appliance.ApiStatus"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "appliance.ApiStatus"]
**ElapsedTime** | **Double** | The elapsed time for query in seconds. | [optional] [readonly] 
**ObjectName** | **String** | Name to identify the API. | [optional] [readonly] 
**Reason** | **String** | Reason to address why the API call failed, if API call was successed, reason would be null. | [optional] [readonly] 
**Response** | **Int64** | Response code of the API call. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$ApplianceApiStatus = Initialize-IntersightApplianceApiStatus  -ClassId null `
 -ObjectType null `
 -ElapsedTime null `
 -ObjectName null `
 -Reason null `
 -Response null
```

- Convert the resource to JSON
```powershell
$ApplianceApiStatus | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

