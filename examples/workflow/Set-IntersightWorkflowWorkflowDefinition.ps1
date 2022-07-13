# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Name 'default'

# Get the WorkflowWorkflowDefinition to Update
$WorkflowWorkflowDefinition = Get-IntersightWorkflowWorkflowDefinition -Name WorkflowWorkflowDefinitionName

# Update the WorkflowWorkflowDefinition
$workflow_definition1 = $WorkflowWorkflowDefinition | Set-IntersightWorkflowWorkflowDefinition -Description 'update demo workflow definition' 