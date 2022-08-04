$organization1 = Get-IntersightOrganizationOrganization -Name 'default'

$fabric_multicast_policy1 = New-IntersightFabricMulticastPolicy -Organization $organization1 -Name 'fabric_multicast_policy1' -Description 'demo fabric multicast policy' -QuerierIpAddress '192.168.0.1' -QuerierState 'Enabled' -SnoopingState 'Enabled'