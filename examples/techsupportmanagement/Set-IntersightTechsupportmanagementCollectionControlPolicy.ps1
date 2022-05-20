# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

# Get the TechsupportmanagementCollectionControlPolicy to Update
$TechsupportmanagementCollectionControlPolicy = Get-IntersightTechsupportmanagementCollectionControlPolicy -Moid '<Replace with Moid>'

# Update the TechsupportmanagementCollectionControlPolicy
$tech_policy1 = $TechsupportmanagementCollectionControlPolicy | Set-IntersightTechsupportmanagementCollectionControlPolicy -TechSupportCollection 'Disable'