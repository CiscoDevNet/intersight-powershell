# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

# Get the VnicIscsiBootPolicy to Update
$VnicIscsiBootPolicy = Get-IntersightVnicIscsiBootPolicy -Name VnicIscsiBootPolicyName

# Update the VnicIscsiBootPolicy
$v_isci_boot1 = $VnicIscsiBootPolicy | Set-IntersightVnicIscsiBootPolicy -Description 'update demo isci boot policy'