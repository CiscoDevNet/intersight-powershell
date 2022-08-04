#Get the WorkflowBatchApiExecutor to delete
$WorkflowBatchApiExecutor = Get-IntersightWorkflowBatchApiExecutor -Name WorkflowBatchApiExecutorName
$WorkflowBatchApiExecutor | Remove-IntersightWorkflowBatchApiExecutor

#Remove the WorkflowBatchApiExecutor by Moid.
Remove-IntersightWorkflowBatchApiExecutor -Moid '<Replace with Moid>'
