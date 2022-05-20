# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

# Get the WorkflowTaskDefinition to Update
$WorkflowTaskDefinition = Get-IntersightWorkflowTaskDefinition -Name WorkflowTaskDefinitionName

# Update the WorkflowTaskDefinition
$task_definition1 = $WorkflowTaskDefinition | Set-IntersightWorkflowTaskDefinition -Description 'update demo workflow task definition'