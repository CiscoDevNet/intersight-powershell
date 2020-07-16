# WorkflowDecisionTaskAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Condition** | **String** | The condition to evaluate for this decision task. The condition can be a workflow or task variable or an expression based on the input parameters. Example value for condition if its Workflow/task variable is -  &quot;&quot;${task1.output.var1} or ${workflow.input.var2}&quot;&quot; which evaluates to a value matching any of the decision case values. Example value for condition if its an expression is - &quot;&quot;if ( $.element ! &#x3D; null &amp;&amp; $.element &gt; 0 ) &#39;true&#39;; else &#39;false&#39;; &quot;&quot; which evaluates to &#39;true&#39; or &#39;false&#39; and will match one of the decision case values. Here &quot;&quot;element&quot;&quot; is a variable in decisiontask&#39;s inputParameters JSON formatted map. You can also use javascript like functions indexOf, toUpperCase in the expression which will be evaluated by the expression evaluator. | [optional] 
**DecisionCases** | [**WorkflowDecisionCase[]**](WorkflowDecisionCase.md) |  | [optional] 
**DefaultTask** | **String** | The default next Task to execute if the decision cannot be evaluated to any of the DecisionCases. | [optional] 
**InputParameters** | [**AnyType**](.md) | JSON formatted map that defines the input given to the decision task. The inputs are used as variables in the condition property of decision task. The input variables can be static values like &quot;&quot;hello&quot;&quot; , &quot;&quot;24&quot;&quot;, &quot;&quot;true&quot;&quot; OR previous task outputs/workflow inputs like &quot;&quot;${task2.output.var1}}&quot;&quot;. The input variables are referrenced as $.inputVariableName in the condition property. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowDecisionTaskAllOf  -Condition null `
 -DecisionCases null `
 -DefaultTask null `
 -InputParameters null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

