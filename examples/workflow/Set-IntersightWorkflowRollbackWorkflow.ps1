# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Name 'default'

# Get the WorkflowRollbackWorkflow to Update
$WorkflowRollbackWorkflow = Get-IntersightWorkflowRollbackWorkflow -Name WorkflowRollbackWorkflowName

# Update the WorkflowRollbackWorkflow
$workflow_rollback1 = $WorkflowRollbackWorkflow | Set-IntersightWorkflowRollbackWorkflow -Description 'update demo workflow rollback' 