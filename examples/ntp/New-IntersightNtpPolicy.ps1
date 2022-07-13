$organization1 = Get-IntersightOrganizationOrganization -Name 'default'

$ntp1 = New-IntersightNtpPolicy -Organization $organization1 -Name 'ntp1' -Description 'test policy' -Enabled 1 -NtpServers @('ntp.esl.cisco.com', 'time-a-g.nist.gov', 'time-b-g.nist.gov')