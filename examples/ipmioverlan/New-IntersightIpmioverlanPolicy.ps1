$organization1 = Get-IntersightOrganizationOrganization -Name 'default'

$ipmi1 = New-IntersightIpmioverlanPolicy -Organization $organization1 -Name 'ipmi1' -Description 'demo ipmi policy' -Enabled 1 -Privilege 'admin' -EncryptionKey 'abcABC007'