$organization = Get-IntersightOrganizationOrganization -Name 'default'

$profiles1 = Get-IntersightServerProfile -Moid '<Replace with Moid>'

$ssh_policy1 = New-IntersightSshPolicy -Organization $organization -Profiles $profiles1 -Name 'ssh_policy1' -Description 'ssh policy' -Enabled 1 -Port 22 -Timeout 1800