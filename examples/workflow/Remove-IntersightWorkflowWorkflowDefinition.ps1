#Get the WorkflowWorkflowDefinition to delete
$WorkflowWorkflowDefinition = Get-IntersightWorkflowWorkflowDefinition -Name WorkflowWorkflowDefinitionName
$WorkflowWorkflowDefinition | Remove-IntersightWorkflowWorkflowDefinition

#Remove the WorkflowWorkflowDefinition by Moid.
Remove-IntersightWorkflowWorkflowDefinition -Moid '<Replace with Moid>'
