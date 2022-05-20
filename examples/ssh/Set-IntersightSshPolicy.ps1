# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

# Get the SshPolicy to Update
$SshPolicy = Get-IntersightSshPolicy -Name SshPolicyName

# Update the SshPolicy
$ssh1 = $SshPolicy | Set-IntersightSshPolicy -Description 'update demo ssh policy' 