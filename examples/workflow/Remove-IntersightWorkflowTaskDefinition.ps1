#Get the WorkflowTaskDefinition to delete
$WorkflowTaskDefinition = Get-IntersightWorkflowTaskDefinition -Name WorkflowTaskDefinitionName
$WorkflowTaskDefinition | Remove-IntersightWorkflowTaskDefinition

#Remove the WorkflowTaskDefinition by Moid.
Remove-IntersightWorkflowTaskDefinition -Moid '<Replace with Moid>'
