# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Name 'default'

# Get the WorkflowBatchApiExecutor to Update
$WorkflowBatchApiExecutor = Get-IntersightWorkflowBatchApiExecutor -Name WorkflowBatchApiExecutorName

# Update the WorkflowBatchApiExecutor
$workflow_batch_api1 = $WorkflowBatchApiExecutor | Set-IntersightWorkflowBatchApiExecutor -Description 'update demo workflow batch api executor'