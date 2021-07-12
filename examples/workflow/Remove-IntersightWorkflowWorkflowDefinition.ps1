
#Get the WorkflowWorkflowDefinition to delete
$WorkflowWorkflowDefinition = Remove-IntersightWorkflowWorkflowDefinition -Name WorkflowWorkflowDefinitionName
$WorkflowWorkflowDefinition | Remove-IntersightWorkflowWorkflowDefinition

#Remove the server profile by Moid.
Remove-IntersightWorkflowWorkflowDefinition -Moid 123bc2222287wee
