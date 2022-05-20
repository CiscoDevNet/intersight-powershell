# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

# Get the VnicLanConnectivityPolicy to Update
$VnicLanConnectivityPolicy = Get-IntersightVnicLanConnectivityPolicy -Name VnicLanConnectivityPolicyName

# Update the VnicLanConnectivityPolicy
$v_lan1 = $VnicLanConnectivityPolicy | Set-IntersightVnicLanConnectivityPolicy -Description 'update demo lan connectivity policy'