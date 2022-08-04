#Get the WorkflowRollbackWorkflow to delete
$WorkflowRollbackWorkflow = Get-IntersightWorkflowRollbackWorkflow -Name WorkflowRollbackWorkflowName
$WorkflowRollbackWorkflow | Remove-IntersightWorkflowRollbackWorkflow

#Remove the WorkflowRollbackWorkflow by Moid.
Remove-IntersightWorkflowRollbackWorkflow -Moid '<Replace with Moid>'
