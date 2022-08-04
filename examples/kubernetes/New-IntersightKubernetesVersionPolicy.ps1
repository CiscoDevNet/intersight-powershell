$organization1 = Get-IntersightOrganizationOrganization -Name 'default'

$kubernetes_version_policy1 = New-IntersightKubernetesVersionPolicy -Organization $organization1 -Description 'kubernetes version policy' -Name 'kubernetes_version_policy1'