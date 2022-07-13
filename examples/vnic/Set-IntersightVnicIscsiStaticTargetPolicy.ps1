# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Name 'default'

# Get the VnicIscsiStaticTargetPolicy to Update
$VnicIscsiStaticTargetPolicy = Get-IntersightVnicIscsiStaticTargetPolicy -Name VnicIscsiStaticTargetPolicyName

# Update the VnicIscsiStaticTargetPolicy
$target_policy1 = $VnicIscsiStaticTargetPolicy | Set-IntersightVnicIscsiStaticTargetPolicy -Description 'update demo vnic iscsi static target policy'