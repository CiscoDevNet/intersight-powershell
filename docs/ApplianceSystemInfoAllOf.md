# ApplianceSystemInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CloudConnStatus** | **String** | Connection state of the Intersight Appliance to the Intersight. | [optional] [readonly] [default to ""]
**DeploymentSize** | **String** | Current running deployment size for the Intersight Appliance cluster. Eg. small, medium, large etc. | [optional] [readonly] 
**Hostname** | **String** | Publicly accessible FQDN or IP address of the Intersight Appliance. | [optional] [readonly] 
**InitDone** | **Boolean** | Indicates that the setup initialization process has been completed. | [optional] [readonly] 
**OperationalStatus** | **String** | Operational status of the Intersight Appliance cluster. | [optional] [readonly] [default to "Unknown"]
**SerialId** | **String** | SerialId of the Intersight Appliance. SerialId is generated when the Intersight Appliance is setup. It is a unique UUID string, and serialId will not change for the life time of the Intersight Appliance. | [optional] [readonly] 
**TimeZone** | **String** | Timezone of the Intersight Appliance. | [optional] [default to "Pacific/Niue"]
**Version** | **String** | Current software version of the Intersight Appliance. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightApplianceSystemInfoAllOf  -CloudConnStatus null `
 -DeploymentSize null `
 -Hostname null `
 -InitDone null `
 -OperationalStatus null `
 -SerialId null `
 -TimeZone null `
 -Version null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

