# VmediaPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "vmedia.Policy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "vmedia.Policy"]
**Enabled** | **Boolean** | State of the Virtual Media service on the endpoint. | [optional] [default to $true]
**Encryption** | **Boolean** | If enabled, allows encryption of all Virtual Media communications. | [optional] 
**LowPowerUsb** | **Boolean** | If enabled, the virtual drives appear on the boot selection menu after mapping the image and rebooting the host. | [optional] [default to $true]
**Mappings** | [**VmediaMapping[]**](VmediaMapping.md) |  | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**Profiles** | [**PolicyAbstractConfigProfileRelationship[]**](PolicyAbstractConfigProfileRelationship.md) | An array of relationships to policyAbstractConfigProfile resources. | [optional] 

## Examples

- Prepare the resource
```powershell
$VmediaPolicyAllOf = Initialize-IntersightVmediaPolicyAllOf  -ClassId null `
 -ObjectType null `
 -Enabled null `
 -Encryption null `
 -LowPowerUsb null `
 -Mappings null `
 -Organization null `
 -Profiles null
```

- Convert the resource to JSON
```powershell
$VmediaPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

