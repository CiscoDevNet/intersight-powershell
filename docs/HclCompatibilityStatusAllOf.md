# HclCompatibilityStatusAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hcl.CompatibilityStatus"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hcl.CompatibilityStatus"]
**ProfileList** | [**HclHardwareCompatibilityProfile[]**](HclHardwareCompatibilityProfile.md) |  | [optional] 
**RequestType** | **String** | Type of the request to be served. * &#x60;FillSupportedVersions&#x60; - Responds with the supported firmware and driver versions. The API doesn&#39;t expect firmware and driver versions to be passed in the request and ignores if passed. * &#x60;CheckCompatibility&#x60; - Checks the compatibility for the given firmware and driver versions. This request type expects the firmware and driver versions to filled and the service validates the values and responds back with the error codes. * &#x60;GetRecommendedDrivers&#x60; - Responds with the supported drivers. The API expects firmware version to be filled. The API populates driver ISO url for the given server model. Today the link is same for all servers managed by UCSM whereas it depends on the model for Standalone servers. | [optional] [default to "FillSupportedVersions"]

## Examples

- Prepare the resource
```powershell
$HclCompatibilityStatusAllOf = Initialize-IntersightHclCompatibilityStatusAllOf  -ClassId null `
 -ObjectType null `
 -ProfileList null `
 -RequestType null
```

- Convert the resource to JSON
```powershell
$HclCompatibilityStatusAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

