$organization1 = Get-IntersightOrganizationOrganization -Name 'default'

$kvm1 = New-IntersightKvmPolicy -Organization $organization1 -Name 'kvm1' -Description 'demo kvm policy' -Enabled 1 -MaximumSessions 3 -RemotePort 2069 -EnableVideoEncryption 1 -EnableLocalServerVideo 1