
#Get the WorkflowCustomDataTypeDefinition to delete
$WorkflowCustomDataTypeDefinition = Remove-IntersightWorkflowCustomDataTypeDefinition -Name WorkflowCustomDataTypeDefinitionName
$WorkflowCustomDataTypeDefinition | Remove-IntersightWorkflowCustomDataTypeDefinition

#Remove the server profile by Moid.
Remove-IntersightWorkflowCustomDataTypeDefinition -Moid 123bc2222287wee
