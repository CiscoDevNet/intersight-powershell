# OsInstallAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **String** | The name of the OS install configuration. | [optional] 
**ConfigurationFile** | [**OsConfigurationFileRelationship**](OsConfigurationFileRelationship.md) |  | [optional] 
**Image** | [**SoftwarerepositoryOperatingSystemFileRelationship**](SoftwarerepositoryOperatingSystemFileRelationship.md) |  | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**OsduImage** | [**FirmwareServerConfigurationUtilityDistributableRelationship**](FirmwareServerConfigurationUtilityDistributableRelationship.md) |  | [optional] 
**Server** | [**ComputePhysicalRelationship**](ComputePhysicalRelationship.md) |  | [optional] 
**WorkflowInfo** | [**WorkflowWorkflowInfoRelationship**](WorkflowWorkflowInfoRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightOsInstallAllOf  -Name null `
 -ConfigurationFile null `
 -Image null `
 -Organization null `
 -OsduImage null `
 -Server null `
 -WorkflowInfo null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

