# FeedbackFeedbackDataAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountName** | **String** | Account name of the feedback sender. Copied in order to be persisted in case of account removal. | [optional] 
**AlternativeFollowUpEmails** | **String[]** |  | [optional] 
**Comment** | **String** | Text of the feedback as provided by the user, if it is a bug or a comment. | [optional] 
**Email** | **String** | User&#39;s email address details. | [optional] 
**Evaluation** | **String** | Evalation rating as provided by the user to capture user sentiment regarding the issue. | [optional] [default to "Excellent"]
**FollowUp** | **Boolean** | If a user is open for follow-up or not. | [optional] 
**TraceIds** | [**AnyType**](.md) | Bunch of last traceId for reproducing user last activity. | [optional] 
**Type** | **String** | Type of the feedback from user. | [optional] [default to "Evaluation"]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFeedbackFeedbackDataAllOf  -AccountName null `
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
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

