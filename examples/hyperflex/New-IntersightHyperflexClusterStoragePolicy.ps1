$logical_avalability_zone_config1 = Initialize-IntersightHyperflexLogicalavailabilityzone -AutoConfig 0

$organization1 = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

$hyperflex_cluster_storage_policy1 = New-IntersightHyperflexClusterStoragePolicy -LogicalAvalabilityZoneConfig $logical_avalability_zone_config1 -Organization $organization1 -DiskPartitionCleanup 1 -VdiOptimization 1 -Name 'hyperflex_cluster_storage_policy1'