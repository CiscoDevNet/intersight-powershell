# VmediaPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **Boolean** | State of the Virtual Media service on the endpoint. | [optional] 
**Encryption** | **Boolean** | If enabled, allows encryption of all Virtual Media communications. | [optional] 
**LowPowerUsb** | **Boolean** | If enabled, the virtual drives appear on the boot selection menu after mapping the image and rebooting the host. | [optional] 
**Mappings** | [**VmediaMapping[]**](VmediaMapping.md) |  | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**Profiles** | [**PolicyAbstractConfigProfileRelationship[]**](PolicyAbstractConfigProfileRelationship.md) | An array of relationships to policyAbstractConfigProfile resources. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVmediaPolicyAllOf  -Enabled null `
 -Encryption null `
 -LowPowerUsb null `
 -Mappings null `
 -Organization null `
 -Profiles null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

