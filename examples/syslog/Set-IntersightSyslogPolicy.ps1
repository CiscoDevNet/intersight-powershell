# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Name 'default'

# Get the SyslogPolicy to Update
$SyslogPolicy = Get-IntersightSyslogPolicy -Name SyslogPolicyName

# Update the SyslogPolicy
$syslog1 = $SyslogPolicy | Set-IntersightSyslogPolicy -Description 'update demo syslog policy' 