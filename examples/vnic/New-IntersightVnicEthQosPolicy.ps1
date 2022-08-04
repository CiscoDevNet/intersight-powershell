$organization = Get-IntersightOrganizationOrganization -Name 'default'

$v_eth_qos1 = New-IntersightVnicEthQosPolicy -Organization $organization -Name 'v_eth_qos1' -Description 'demo vnic eth qos policy' -Mtu 1500 -RateLimit 0 -Cos 0 -Burst 1024 -Priority 'BestEffort' -TrustHostCos 0