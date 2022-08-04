$organization1 = Get-IntersightOrganizationOrganization -Name 'default'

$iks1 = New-IntersightKubernetesClusterAddonProfile -Organization $organization1 -Name 'cluster_addon_profile1'