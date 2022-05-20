# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

# Get the WorkflowCustomDataTypeDefinition to Update
$WorkflowCustomDataTypeDefinition = Get-IntersightWorkflowCustomDataTypeDefinition -Name WorkflowCustomDataTypeDefinitionName

# Update the WorkflowCustomDataTypeDefinition
$workflow_custom1 = $WorkflowCustomDataTypeDefinition | Set-IntersightWorkflowCustomDataTypeDefinition -Description 'update demo custom data type definition'