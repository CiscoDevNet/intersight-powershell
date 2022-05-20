$ip_v4_config1 = Initialize-IntersightIppoolIpv4Config -Gateway '10.1.1.1' -Netmask '255.0.0.0' -PrimaryDns '8.8.8.8'

$organization1 = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

$ippool_pool1 = New-IntersightIppoolPool -IpV4Config $ip_v4_config1 -Organization $organization1 -Name 'ippool_pool1' -Description 'ippool pool' -AssignmentOrder 'sequential'