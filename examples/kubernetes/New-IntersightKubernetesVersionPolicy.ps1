$organization1 = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

$kubernetes_version_policy1 = New-IntersightKubernetesVersionPolicy -Organization $organization1 -Description 'kubernetes version policy' -Name 'kubernetes_version_policy1'