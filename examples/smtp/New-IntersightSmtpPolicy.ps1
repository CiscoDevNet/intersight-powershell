$organization = Get-IntersightOrganizationOrganization -Name 'default'

$profiles1 = Get-IntersightServerProfile -Moid '<Replace with Moid>'

$smtp1 = New-IntersightSmtpPolicy -Organization $organization -Profiles $profiles1 -Enabled 0 -Name 'smtp1' -Description 'testing smtp policy' -SmtpPort 32 -MinSeverity 'critical' -SmtpServer '10.10.10.1' -SenderEmail 'IMCSQAAutomation@cisco.com' -SmtpRecipients @('aw@cisco.com', 'cy@cisco.com', 'dz@cisco.com')