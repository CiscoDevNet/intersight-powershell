#Get the WorkflowCustomDataTypeDefinition to delete
$WorkflowCustomDataTypeDefinition = Get-IntersightWorkflowCustomDataTypeDefinition -Name WorkflowCustomDataTypeDefinitionName
$WorkflowCustomDataTypeDefinition | Remove-IntersightWorkflowCustomDataTypeDefinition

#Remove the WorkflowCustomDataTypeDefinition by Moid.
Remove-IntersightWorkflowCustomDataTypeDefinition -Moid '<Replace with Moid>'
