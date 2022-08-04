# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Name 'default'

# Get the VmediaPolicy to Update
$VmediaPolicy = Get-IntersightVmediaPolicy -Name VmediaPolicyName

# Update the VmediaPolicy
$vmedia1 = $VmediaPolicy | Set-IntersightVmediaPolicy -Description 'Update demo vmedia policy'