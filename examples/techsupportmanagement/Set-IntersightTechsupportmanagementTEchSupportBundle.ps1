# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Name 'default'

# Get the TechsupportmanagementTechSupportBundle to Update
$TechsupportmanagementTechSupportBundle = Get-IntersightTechsupportmanagementTechSupportBundle -Moid '<Replace with Moid>'

# Update the TechsupportmanagementTechSupportBundle
$tech_policy1 = $TechsupportmanagementTechSupportBundle | Set-IntersightTechsupportmanagementTechSupportBundle -TechSupportCollection 'Disable'