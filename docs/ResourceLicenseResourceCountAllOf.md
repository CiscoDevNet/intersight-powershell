# ResourceLicenseResourceCountAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "resource.LicenseResourceCount"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "resource.LicenseResourceCount"]
**LicenseType** | **String** | Type of licensing defined for this resource group. Used for licensing group. * &#x60;Base&#x60; - Base as a License type. It is default license type. * &#x60;Essential&#x60; - Essential as a License type. * &#x60;Standard&#x60; - Standard as a License type. * &#x60;Advantage&#x60; - Advantage as a License type. * &#x60;Premier&#x60; - Premier as a License type. * &#x60;IWO-Essential&#x60; - IWO-Essential as a License type. * &#x60;IWO-Advantage&#x60; - IWO-Advantage as a License type. * &#x60;IWO-Premier&#x60; - IWO-Premier as a License type. | [optional] [readonly] [default to "Base"]
**ResourceCount** | **Int64** | The number of resource belongs to this licensing tier. | [optional] [readonly] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 
**LicenseGroups** | [**ResourceGroupRelationship[]**](ResourceGroupRelationship.md) | An array of relationships to resourceGroup resources. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$ResourceLicenseResourceCountAllOf = Initialize-IntersightResourceLicenseResourceCountAllOf  -ClassId null `
 -ObjectType null `
 -LicenseType null `
 -ResourceCount null `
 -Account null `
 -LicenseGroups null
```

- Convert the resource to JSON
```powershell
$ResourceLicenseResourceCountAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

