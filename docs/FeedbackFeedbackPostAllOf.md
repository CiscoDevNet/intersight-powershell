# FeedbackFeedbackPostAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "feedback.FeedbackPost"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "feedback.FeedbackPost"]
**FeedbackData** | [**FeedbackFeedbackData**](FeedbackFeedbackData.md) |  | [optional] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$FeedbackFeedbackPostAllOf = Initialize-IntersightFeedbackFeedbackPostAllOf  -ClassId null `
 -ObjectType null `
 -FeedbackData null `
 -Account null
```

- Convert the resource to JSON
```powershell
$FeedbackFeedbackPostAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

