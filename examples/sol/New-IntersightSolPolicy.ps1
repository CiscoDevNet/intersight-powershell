$organization = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

$sol1 = New-IntersightSolPolicy -Organization $organization -Name 'sol2' -Description 'demo serial over lan policy' -Enabled 0 -BaudRate 9600 -ComPort 'com1' -SshPort 1096