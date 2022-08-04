$organization1 = Get-IntersightOrganizationOrganization -Name 'default'

$kubernetes_network_policy1 = New-IntersightKubernetesNetworkPolicy -Organization $organization1 -Description 'kubernetes network policy' -Name 'kubernetes_network_policy1' -CniType 'Calico'