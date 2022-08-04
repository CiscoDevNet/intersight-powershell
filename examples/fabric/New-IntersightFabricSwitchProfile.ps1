$switch_cluster_profile1 = Get-IntersightFabricSwitchclusterprofile -Moid '<Replace with Moid>'

$fabric_switch_profile1 = New-IntersightFabricSwitchProfile -SwitchClusterProfile $switch_cluster_profile1 -Name 'fabric_switch_profile1' -Description 'demo fabric switch profile' -Type 'instance' -Action 'No-op'