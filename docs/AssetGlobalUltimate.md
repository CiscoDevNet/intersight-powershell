# AssetGlobalUltimate
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "asset.GlobalUltimate"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "asset.GlobalUltimate"]
**Id** | **String** | ID of the user in BillToGlobal. | [optional] [readonly] 
**Name** | **String** | Name of the user in BillToGlobal. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$AssetGlobalUltimate = Initialize-IntersightAssetGlobalUltimate  -ClassId null `
 -ObjectType null `
 -Id null `
 -Name null
```

- Convert the resource to JSON
```powershell
$AssetGlobalUltimate | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

