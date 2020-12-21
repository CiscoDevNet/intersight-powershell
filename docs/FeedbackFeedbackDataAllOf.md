# FeedbackFeedbackDataAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "feedback.FeedbackData"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "feedback.FeedbackData"]
**AccountName** | **String** | Account name of the feedback sender. Copied in order to be persisted in case of account removal. | [optional] 
**AlternativeFollowUpEmails** | **String[]** |  | [optional] 
**Comment** | **String** | Text of the feedback as provided by the user, if it is a bug or a comment. | [optional] 
**Email** | **String** | User&#39;s email address details. | [optional] 
**Evaluation** | **String** | Evalation rating as provided by the user to capture user sentiment regarding the issue. * &#x60;Excellent&#x60; - Option that specifies user&#39;s excelent evaluation. * &#x60;Poor&#x60; - Option that specifies user&#39;s poor evaluation. * &#x60;Fair&#x60; - Option that specifies user&#39;s fair evaluation. * &#x60;Good&#x60; - Option that specifies user&#39;s good evaluation. | [optional] [default to "Excellent"]
**FollowUp** | **Boolean** | If a user is open for follow-up or not. | [optional] 
**TraceIds** | [**AnyType**](.md) | Bunch of last traceId for reproducing user last activity. | [optional] 
**Type** | **String** | Type of the feedback from user. * &#x60;Evaluation&#x60; - User&#39;s feedback classified as an evaluation. * &#x60;Bug&#x60; - User&#39;s feedback classified as a bug. | [optional] [default to "Evaluation"]

## Examples

- Prepare the resource
```powershell
$FeedbackFeedbackDataAllOf = Initialize-IntersightFeedbackFeedbackDataAllOf  -ClassId null `
 -ObjectType null `
 -AccountName null `
 -AlternativeFollowUpEmails null `
 -Comment null `
 -Email null `
 -Evaluation null `
 -FollowUp null `
 -TraceIds null `
 -Type null
```

- Convert the resource to JSON
```powershell
$FeedbackFeedbackDataAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

