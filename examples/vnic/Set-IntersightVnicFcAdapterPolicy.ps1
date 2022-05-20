# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

# Get the VnicFcAdapterPolicy to Update
$VnicFcAdapterPolicy = Get-IntersightVnicFcAdapterPolicy -Name VnicFcAdapterPolicyName

# Update the VnicFcAdapterPolicy
$v_fc_adapter1 = $VnicFcAdapterPolicy | Set-IntersightVnicFcAdapterPolicy -Description 'Update demo vnic fc adapter policy'