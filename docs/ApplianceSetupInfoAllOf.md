# ApplianceSetupInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "appliance.SetupInfo"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "appliance.SetupInfo"]
**BuildType** | **String** | Build type of the Intersight Appliance setup (e.g. release or debug). | [optional] [readonly] 
**Capabilities** | [**ApplianceKeyValuePair[]**](ApplianceKeyValuePair.md) |  | [optional] 
**CloudUrl** | **String** | URL of the Intersight to which this Intersight Appliance is connected to. | [optional] [readonly] 
**DeploymentMode** | **String** | Indicates where Intersight Appliance is installed in air-gapped or connected mode. In connected mode, Intersight Appliance is claimed by Intesight SaaS. In air-gapped mode, Intersight Appliance does not connect to any Cisco services. * &#x60;Connected&#x60; - In connected mode, Intersight Appliance connects to Intersight SaaS and other cisco.com services. * &#x60;Private&#x60; - In private mode, Intersight Appliance does not connect to Intersight SaaS or any cisco.com services. | [optional] [readonly] [default to "Connected"]
**EndTime** | **System.DateTime** | End date of the Intersight Appliance&#39;s initial setup. | [optional] [readonly] 
**SetupStates** | **String[]** |  | [optional] 
**StartTime** | **System.DateTime** | Start date of the Intersight Appliance&#39;s initial setup. | [optional] [readonly] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ApplianceSetupInfoAllOf = Initialize-IntersightApplianceSetupInfoAllOf  -ClassId null `
 -ObjectType null `
 -BuildType null `
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
$ApplianceSetupInfoAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

