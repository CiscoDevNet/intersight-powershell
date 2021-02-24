# IamBannerMessageAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iam.BannerMessage"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iam.BannerMessage"]
**BannerContents** | **String** | Contents of the banner message. | [optional] 
**BannerDisplay** | **Boolean** | Whether or not to display the banner message. | [optional] 
**BannerTitle** | **String** | Title of the banner message. | [optional] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$IamBannerMessageAllOf = Initialize-IntersightIamBannerMessageAllOf  -ClassId null `
 -ObjectType null `
 -BannerContents null `
 -BannerDisplay null `
 -BannerTitle null `
 -Account null
```

- Convert the resource to JSON
```powershell
$IamBannerMessageAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

