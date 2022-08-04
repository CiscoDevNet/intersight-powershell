# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Name 'default'

# Get the SshPolicy to Update
$SshPolicy = Get-IntersightSshPolicy -Name SshPolicyName

# Update the SshPolicy
$ssh1 = $SshPolicy | Set-IntersightSshPolicy -Description 'update demo ssh policy' 