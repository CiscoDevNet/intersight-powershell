# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Name 'default'

# Get the TamAdvisoryDefinition to Update
$TamAdvisoryDefinition = Get-IntersightTamAdvisoryDefinition -Name TamAdvisoryDefinitionName

# Update the TamAdvisoryDefinition
$tam_definition1 = $TamAdvisoryDefinition | Set-IntersightTamAdvisoryDefinition -State 'evaluating'