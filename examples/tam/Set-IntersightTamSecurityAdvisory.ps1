# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Name 'default'

# Get the TamSecurityAdvisory to Update
$TamSecurityAdvisory = Get-IntersightTamSecurityAdvisory -Name TamSecurityAdvisoryName

# Update the TamSecurityAdvisory
$tam_advisory1 = $TamSecurityAdvisory | Set-IntersightTamSecurityAdvisory -State 'ready'