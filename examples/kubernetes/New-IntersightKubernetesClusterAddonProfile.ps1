$organization1 = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

$iks1 = New-IntersightKubernetesClusterAddonProfile -Organization $organization1 -Name 'cluster_addon_profile1'