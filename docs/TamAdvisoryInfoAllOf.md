# TamAdvisoryInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "tam.AdvisoryInfo"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "tam.AdvisoryInfo"]
**State** | **String** | Current state of the advisory for the owner. Indicates if the user is interested in getting updates for the advisory. * &#x60;active&#x60; - Advisory is currently active and the user wants to receive updates for this advisory. * &#x60;acknowledged&#x60; - Advisory is seen and acknowledged by the user and she no longer wants to recieve updates. | [optional] [default to "active"]
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 
**Advisory** | [**TamBaseAdvisoryRelationship**](TamBaseAdvisoryRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$TamAdvisoryInfoAllOf = Initialize-IntersightTamAdvisoryInfoAllOf  -ClassId null `
 -ObjectType null `
 -State null `
 -Account null `
 -Advisory null
```

- Convert the resource to JSON
```powershell
$TamAdvisoryInfoAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

