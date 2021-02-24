# WorkflowDecisionTaskAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.DecisionTask"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.DecisionTask"]
**Condition** | **String** | The condition to evaluate for this decision task. The condition can be a workflow or task variable or an JavaScript expression. Example value for condition could be a variable like &quot;&quot;${task1.output.var1} or ${workflow.input.var2}&quot;&quot; which evaluates to a value matching any of the decision case values. Example value for condition if it&#39;s an expression - &quot;&quot;if ( ${task1.output.var1} ! &#x3D; null &amp;&amp; ${task1.output.var1} &gt; 0 ) &#39;true&#39;; else &#39;false&#39;; &quot;&quot; which evaluates to &#39;true&#39; or &#39;false&#39; and will match one of the decision case values. You can also use JavaScript functions like indexOf, toUpperCase in the expression which will be evaluated by the expression evaluator. | [optional] 
**DecisionCases** | [**WorkflowDecisionCase[]**](WorkflowDecisionCase.md) |  | [optional] 
**DefaultTask** | **String** | The default next Task to execute if the decision cannot be evaluated to any of the DecisionCases. | [optional] 
**InputParameters** | [**AnyType**](.md) | This field is deprecated. Decision case conditions can be added using the workflow input or task output variables in the Condition field. Refer to Condition field for more details. | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkflowDecisionTaskAllOf = Initialize-IntersightWorkflowDecisionTaskAllOf  -ClassId null `
 -ObjectType null `
 -Condition null `
 -DecisionCases null `
 -DefaultTask null `
 -InputParameters null
```

- Convert the resource to JSON
```powershell
$WorkflowDecisionTaskAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

