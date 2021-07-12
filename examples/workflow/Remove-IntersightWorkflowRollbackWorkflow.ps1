
#Get the WorkflowRollbackWorkflow to delete
$WorkflowRollbackWorkflow = Remove-IntersightWorkflowRollbackWorkflow -Name WorkflowRollbackWorkflowName
$WorkflowRollbackWorkflow | Remove-IntersightWorkflowRollbackWorkflow

#Remove the server profile by Moid.
Remove-IntersightWorkflowRollbackWorkflow -Moid 123bc2222287wee
