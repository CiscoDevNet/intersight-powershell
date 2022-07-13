# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Name 'default'

# Get the TechsupportmanagementCollectionControlPolicy to Update
$TechsupportmanagementCollectionControlPolicy = Get-IntersightTechsupportmanagementCollectionControlPolicy -Moid '<Replace with Moid>'

# Update the TechsupportmanagementCollectionControlPolicy
$tech_policy1 = $TechsupportmanagementCollectionControlPolicy | Set-IntersightTechsupportmanagementCollectionControlPolicy -TechSupportCollection 'Disable'