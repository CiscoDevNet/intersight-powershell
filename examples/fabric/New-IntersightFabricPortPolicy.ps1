$organization1 = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

$fabric_port_policy1 = New-IntersightFabricPortPolicy -Organization $organization1 -Name 'fabric_port_policy1' -Description 'demo fabric port policy' -DeviceModel 'UCS-FI-6454'