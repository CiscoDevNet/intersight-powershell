# AssetTerraformIntegrationTerraformCloudOptions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "asset.TerraformIntegrationTerraformCloudOptions"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "asset.TerraformIntegrationTerraformCloudOptions"]
**DefaultTerraformOrganization** | **String** | Default organization for Terraform Cloud platform type. | [optional] 

## Examples

- Prepare the resource
```powershell
$AssetTerraformIntegrationTerraformCloudOptions = Initialize-IntersightAssetTerraformIntegrationTerraformCloudOptions  -ClassId null `
 -ObjectType null `
 -DefaultTerraformOrganization null
```

- Convert the resource to JSON
```powershell
$AssetTerraformIntegrationTerraformCloudOptions | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

