# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Name 'default'

# Get the VnicEthIf  to Update
$VnicEthIf = Get-IntersightVnicEthIf -Name VnicEthIfName

# Update the VnicEthIf
$v_ef_if1 = $VnicEthIf | Set-IntersightVnicEthIf -Description 'Update demo vnic eth if'