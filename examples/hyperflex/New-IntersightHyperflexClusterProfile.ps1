$storage_data_vlan1 = Initialize-IntersightHyperflexNamedvlan -Name 'hx-storage-data' -VlanId 27

$tags1 = Initialize-IntersightMoTag -Key "key" -Value "value"

$organization1 = Get-IntersightOrganizationOrganization -Name 'default'

$hyperflex_cluster_profile1 = New-IntersightHyperflexClusterProfile -StorageDataVlan $storage_data_vlan1 -Tags $tags1 -Organization $organization1 -MgmtIpAddress '10.225.68.237' -MacAddressPrefix '00:25:B5:D5' -MgmtPlatform 'EDGE' -Replication 3 -Description 'This is hyperflex cluster profile' -Name 'hyperflex_cluster_profile1'