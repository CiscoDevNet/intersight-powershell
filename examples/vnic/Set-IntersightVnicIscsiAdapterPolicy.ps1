# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

# Get the VnicIscsiAdapterPolicy to Update
$VnicIscsiAdapterPolicy = Get-IntersightVnicIscsiAdapterPolicy -Name VnicIscsiAdapterPolicyName

# Update the VnicIscsiAdapterPolicy
$v_isci_adapter1 = $VnicIscsiAdapterPolicy | Set-IntersightVnicIscsiAdapterPolicy -Description 'update demo isci adapter'