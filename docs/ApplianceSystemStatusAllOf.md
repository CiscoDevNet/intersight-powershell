# ApplianceSystemStatusAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "appliance.SystemStatus"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "appliance.SystemStatus"]
**OperationalStatus** | **String** | Operational status of the Intersight Appliance. Operational status is based on the result of the status checks. If result of any check is Critical, then its value is Impaired. Otherwise, if result of any check is Warning, then its value is AttentionNeeded. If all checks are OK, then its value is Operational. * &#x60;Unknown&#x60; - Operational status of the Intersight Appliance entity is Unknown. * &#x60;Operational&#x60; - Operational status of the Intersight Appliance entity is Operational. * &#x60;Impaired&#x60; - Operational status of the Intersight Appliance entity is Impaired. * &#x60;AttentionNeeded&#x60; - Operational status of the Intersight Appliance entity is AttentionNeeded. | [optional] [readonly] [default to "Unknown"]
**StatusChecks** | [**ApplianceStatusCheck[]**](ApplianceStatusCheck.md) |  | [optional] 
**AppStatuses** | [**ApplianceAppStatusRelationship[]**](ApplianceAppStatusRelationship.md) | An array of relationships to applianceAppStatus resources. | [optional] [readonly] 
**GroupStatuses** | [**ApplianceGroupStatusRelationship[]**](ApplianceGroupStatusRelationship.md) | An array of relationships to applianceGroupStatus resources. | [optional] [readonly] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**SystemInfo** | [**ApplianceSystemInfoRelationship**](ApplianceSystemInfoRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ApplianceSystemStatusAllOf = Initialize-IntersightApplianceSystemStatusAllOf  -ClassId null `
 -ObjectType null `
 -OperationalStatus null `
 -StatusChecks null `
 -AppStatuses null `
 -GroupStatuses null `
 -RegisteredDevice null `
 -SystemInfo null
```

- Convert the resource to JSON
```powershell
$ApplianceSystemStatusAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

