
#Get the WorkflowTaskDefinition to delete
$WorkflowTaskDefinition = Remove-IntersightWorkflowTaskDefinition -Name WorkflowTaskDefinitionName
$WorkflowTaskDefinition | Remove-IntersightWorkflowTaskDefinition

#Remove the server profile by Moid.
Remove-IntersightWorkflowTaskDefinition -Moid 123bc2222287wee
