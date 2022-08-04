# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Name 'default'

# Get the VnicSanConnectivityPolicy to Update
$VnicSanConnectivityPolicy = Get-IntersightVnicSanConnectivityPolicy -Name VnicSanConnectivityPolicyName

# Update the VnicSanConnectivityPolicy
$v_san1 = $VnicSanConnectivityPolicy | Set-IntersightVnicSanConnectivityPolicy -Description 'update demo san connectivity policy'