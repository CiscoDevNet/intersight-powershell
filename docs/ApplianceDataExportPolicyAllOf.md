# ApplianceDataExportPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "appliance.DataExportPolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "appliance.DataExportPolicy"]
**Enable** | **Boolean** | Status of the data collection mode. If the value is &#39;true&#39;, then data collection is enabled. | [optional] 
**Name** | **String** | Name of the Data Export Policy. | [optional] [readonly] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 
**ParentConfig** | [**ApplianceDataExportPolicyRelationship**](ApplianceDataExportPolicyRelationship.md) |  | [optional] 
**SubConfigs** | [**ApplianceDataExportPolicyRelationship[]**](ApplianceDataExportPolicyRelationship.md) | An array of relationships to applianceDataExportPolicy resources. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$ApplianceDataExportPolicyAllOf = Initialize-IntersightApplianceDataExportPolicyAllOf  -ClassId null `
 -ObjectType null `
 -Enable null `
 -Name null `
 -Account null `
 -ParentConfig null `
 -SubConfigs null
```

- Convert the resource to JSON
```powershell
$ApplianceDataExportPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

