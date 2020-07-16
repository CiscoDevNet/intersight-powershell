# ApplianceSetupInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BuildType** | **String** | Build type of the Intersight Appliance setup (e.g. release or debug). | [optional] [readonly] 
**Capabilities** | [**ApplianceKeyValuePair[]**](ApplianceKeyValuePair.md) |  | [optional] 
**CloudUrl** | **String** | URL of the Intersight to which this Intersight Appliance is connected to. | [optional] [readonly] 
**DeploymentMode** | **String** | Indicates where Intersight Appliance is installed in air-gapped or connected mode. In connected mode, Intersight Appliance is claimed by Intesight SaaS. In air-gapped mode, Intersight Appliance does not connect to any Cisco services. | [optional] [readonly] [default to "Connected"]
**EndTime** | **System.DateTime** | End date of the Intersight Appliance&#39;s initial setup. | [optional] [readonly] 
**SetupStates** | **String[]** |  | [optional] 
**StartTime** | **System.DateTime** | Start date of the Intersight Appliance&#39;s initial setup. | [optional] [readonly] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightApplianceSetupInfoAllOf  -BuildType null `
 -Capabilities null `
 -CloudUrl null `
 -DeploymentMode null `
 -EndTime null `
 -SetupStates null `
 -StartTime null `
 -Account null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

