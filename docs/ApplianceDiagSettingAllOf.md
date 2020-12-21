# ApplianceDiagSettingAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "appliance.DiagSetting"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "appliance.DiagSetting"]
**IsPasswordSet** | **Boolean** | Indicates whether the value of the &#39;password&#39; property has been set. | [optional] [readonly] [default to $false]
**Message** | **String** | Status message of the password change operation. | [optional] 
**Password** | **String** | Password of the Intersight Appliance&#39;s OS diagnostic user account. | [optional] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ApplianceDiagSettingAllOf = Initialize-IntersightApplianceDiagSettingAllOf  -ClassId null `
 -ObjectType null `
 -IsPasswordSet null `
 -Message null `
 -Password null `
 -Account null
```

- Convert the resource to JSON
```powershell
$ApplianceDiagSettingAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

