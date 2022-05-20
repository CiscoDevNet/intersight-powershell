# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

# Get the VnicFcIf to Update
$VnicFcIf = Get-IntersightVnicFcIf -Name VnicFcIfName

# Update the VnicFcIf
$v_fc_if1 = $VnicFcIf | Set-IntersightVnicFcIf -Description 'Update demo vnic fc if'