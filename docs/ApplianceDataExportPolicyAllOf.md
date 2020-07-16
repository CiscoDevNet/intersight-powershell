# ApplianceDataExportPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enable** | **Boolean** | Status of the data collection mode. If the value is &#39;true&#39;, then data collection is enabled. | [optional] 
**Name** | **String** | Name of the Data Export Policy. | [optional] [readonly] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 
**ParentConfig** | [**ApplianceDataExportPolicyRelationship**](ApplianceDataExportPolicyRelationship.md) |  | [optional] 
**SubConfigs** | [**ApplianceDataExportPolicyRelationship[]**](ApplianceDataExportPolicyRelationship.md) | An array of relationships to applianceDataExportPolicy resources. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightApplianceDataExportPolicyAllOf  -Enable null `
 -Name null `
 -Account null `
 -ParentConfig null `
 -SubConfigs null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

