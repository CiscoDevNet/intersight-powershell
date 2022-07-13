# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Name 'default'

# Get the SolPolicy to Update
$SolPolicy = Get-IntersightSolPolicy -Name SolPolicyName

# Update the SolPolicy
$sol1 = $SolPolicy | Set-IntersightSolPolicy -Description 'update demo sol policy' 