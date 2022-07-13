# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Name 'default'

# Get the VrfVrf  to Update
$VrfVrf = Get-IntersightVrfVrf -Name VrfVrfName

# Update the VrfVrf
$vrf1 = $VrfVrf | Set-IntersightVrfVrf -Description 'Update demo VrfVrf'