# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Name 'default'

# Get the WorkflowCustomDataTypeDefinition to Update
$WorkflowCustomDataTypeDefinition = Get-IntersightWorkflowCustomDataTypeDefinition -Name WorkflowCustomDataTypeDefinitionName

# Update the WorkflowCustomDataTypeDefinition
$workflow_custom1 = $WorkflowCustomDataTypeDefinition | Set-IntersightWorkflowCustomDataTypeDefinition -Description 'update demo custom data type definition'