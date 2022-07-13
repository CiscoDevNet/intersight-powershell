# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Name 'default'

# Get the SoftwareHclMeta to Update
$SoftwareHclMeta = Get-IntersightSoftwareHclMeta -Name SoftwareHclMetaName

# Update the SoftwareHclMeta
$hcl_meta1 = $SoftwareHclMeta | Set-IntersightSoftwareHclMeta -Description 'update demo software hcl meta'