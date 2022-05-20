# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

# Get the VnicEthAdapterPolicy  to Update
$VnicEthAdapterPolicy = Get-IntersightVnicEthAdapterPolicy -Name VnicEthAdapterPolicyName

# Update the VnicEthAdapterPolicy
$vnic1 = $VnicEthAdapterPolicy | Set-IntersightVnicEthAdapterPolicy -Description 'Update demo vnic eth adapter policy'