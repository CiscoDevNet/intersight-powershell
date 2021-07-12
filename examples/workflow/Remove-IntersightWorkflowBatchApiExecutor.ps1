
#Get the WorkflowBatchApiExecutor to delete
$WorkflowBatchApiExecutor = Remove-IntersightWorkflowBatchApiExecutor -Name WorkflowBatchApiExecutorName
$WorkflowBatchApiExecutor | Remove-IntersightWorkflowBatchApiExecutor

#Remove the server profile by Moid.
Remove-IntersightWorkflowBatchApiExecutor -Moid 123bc2222287wee
