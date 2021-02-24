# AssetTerraformIntegrationTerraformAgentOptionsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "asset.TerraformIntegrationTerraformAgentOptions"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "asset.TerraformIntegrationTerraformAgentOptions"]
**ManagedHosts** | **String[]** |  | [optional] 
**TerraformAgentPoolName** | **String** | Agent pool name for Terraform Agent platform type. | [optional] [default to "default"]
**TerraformOrganization** | **String** | Organization for Terraform Agent platform type. | [optional] 

## Examples

- Prepare the resource
```powershell
$AssetTerraformIntegrationTerraformAgentOptionsAllOf = Initialize-IntersightAssetTerraformIntegrationTerraformAgentOptionsAllOf  -ClassId null `
 -ObjectType null `
 -ManagedHosts null `
 -TerraformAgentPoolName null `
 -TerraformOrganization null
```

- Convert the resource to JSON
```powershell
$AssetTerraformIntegrationTerraformAgentOptionsAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

