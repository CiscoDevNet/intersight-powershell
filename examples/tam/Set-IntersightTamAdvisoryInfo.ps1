# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Name 'default'

# Get the TamAdvisoryInfo to Update
$TamAdvisoryInfo = Get-IntersightTamAdvisoryInfo -Name TamAdvisoryInfoName

# Update the TamAdvisoryInfo
$tam_info1 = $TamAdvisoryInfo | Set-IntersightTamAdvisoryInfo -State 'active'