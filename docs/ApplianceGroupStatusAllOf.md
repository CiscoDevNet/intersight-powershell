# ApplianceGroupStatusAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "appliance.GroupStatus"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "appliance.GroupStatus"]
**Description** | **String** | Description of the group. | [optional] [readonly] 
**GroupName** | **String** | The name of group, which includes Identity Management, Device Connector Service, Core Service, Analytics, Internal and Appliance. | [optional] [readonly] 
**OverallStatus** | **String** | The overall API status from this group&#39;s applications. | [optional] [readonly] 
**Apps** | [**ApplianceAppStatusRelationship[]**](ApplianceAppStatusRelationship.md) | An array of relationships to applianceAppStatus resources. | [optional] [readonly] 
**SystemStatus** | [**ApplianceSystemStatusRelationship**](ApplianceSystemStatusRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ApplianceGroupStatusAllOf = Initialize-IntersightApplianceGroupStatusAllOf  -ClassId null `
 -ObjectType null `
 -Description null `
 -GroupName null `
 -OverallStatus null `
 -Apps null `
 -SystemStatus null
```

- Convert the resource to JSON
```powershell
$ApplianceGroupStatusAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

