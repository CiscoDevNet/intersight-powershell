$organization1 = Get-IntersightOrganizationOrganization -Name 'default'

$dcp1 = New-IntersightDeviceconnectorPolicy -Organization $organization1 -Name 'device_con1' -Description 'demo device connector policy' -LockoutEnabled 1