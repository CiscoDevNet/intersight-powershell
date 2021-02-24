# TechsupportmanagementApplianceParamAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "techsupportmanagement.ApplianceParam"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "techsupportmanagement.ApplianceParam"]
**IsApplianceRequest** | **Boolean** | Specifies whether the techsupport request is from the cloud or by the appliance. | [optional] 

## Examples

- Prepare the resource
```powershell
$TechsupportmanagementApplianceParamAllOf = Initialize-IntersightTechsupportmanagementApplianceParamAllOf  -ClassId null `
 -ObjectType null `
 -IsApplianceRequest null
```

- Convert the resource to JSON
```powershell
$TechsupportmanagementApplianceParamAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

