$organization1 = Get-IntersightOrganizationOrganization -Name 'default'

$fabric_switch_cluster_profile1 = New-IntersightFabricSwitchClusterProfile -Organization $organization1 -Name 'fabric_switch_cluster_profile' -Description 'demo fabric switch cluster profile' -Type 'instance'