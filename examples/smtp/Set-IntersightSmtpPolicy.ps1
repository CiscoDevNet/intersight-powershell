# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Name 'default'

# Get the SmtpPolicy to Update
$SmtpPolicy = Get-IntersightSmtpPolicy -Name SmtpPolicyName

# Update the SmtpPolicy
$smtp1 = $SmtpPolicy | Set-IntersightSmtpPolicy -Description 'update demo smtp policy' -AuthPassword false 