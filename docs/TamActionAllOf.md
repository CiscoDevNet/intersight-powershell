# TamActionAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "tam.Action"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "tam.Action"]
**AffectedObjectType** | **String** | Type of the managed object that should be marked with an instance of the Alert (when operation type is create) or that should have an alert instance removed (when operation type is remove). | [optional] 
**AlertType** | **String** | Alert type is used to denote the category of an Intersight alert (FieldNotice, equipment Fault etc.). * &#x60;psirt&#x60; - Respresents the psirt alert type (https://tools.cisco.com/security/center/publicationListing.x). * &#x60;fieldNotice&#x60; - Respresents the field notice alert type (https://www.cisco.com/c/en/us/support/web/tsd-products-field-notice-summary.html). | [optional] [default to "psirt"]
**Identifiers** | [**TamIdentifiers[]**](TamIdentifiers.md) |  | [optional] 
**Name** | **String** | Uniquely identifies a given action among the set of actions corresponding to an advisory. Primarily used to store and compare results of subsequent iterations corresponding to the action queries. | [optional] 
**OperationType** | **String** | Operation type for the alert action. An action is used to carry out the process of &quot;&quot;reacting&quot;&quot; to an alert condition. For e.g.in case of a fieldNotice alert, the intention may be to create a new alert (if the condition matches and there is no existing alert) or to remove an existing alert when the alert condition has been remedied. * &#x60;create&#x60; - Create an instance of AdvisoryInstance. * &#x60;remove&#x60; - Remove an instance of AdvisoryInstance. | [optional] [default to "create"]
**Queries** | [**TamQueryEntry[]**](TamQueryEntry.md) |  | [optional] 
**Type** | **String** | Type of Intersight alert. An alert in Intersight could be one of several kinds (FieldNotice, PSIRT etc.). Primarily used for filtering alerts based on the type. * &#x60;restApi&#x60; - Repesents the use of REST API for carrying out alert actions. | [optional] [default to "restApi"]

## Examples

- Prepare the resource
```powershell
$TamActionAllOf = Initialize-IntersightTamActionAllOf  -ClassId null `
 -ObjectType null `
 -AffectedObjectType null `
 -AlertType null `
 -Identifiers null `
 -Name null `
 -OperationType null `
 -Queries null `
 -Type null
```

- Convert the resource to JSON
```powershell
$TamActionAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

