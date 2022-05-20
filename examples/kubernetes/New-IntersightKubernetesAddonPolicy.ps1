$addon_configuration1 = Initialize-IntersightKubernetesAddonconfiguration -InstallStrategy 'Always' -ReleaseName 'helm-release-3' -UpgradeStrategy 'UpgradeOnly'

$addon_definition1 = Get-IntersightKubernetesAddondefinition -Moid '<Replace with Moid>'

$organization1 = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

$kubernetes_addon_policy1 = New-IntersightKubernetesAddonPolicy -AddonConfiguration $addon_configuration1 -AddonDefinition $addon_definition1 -Organization $organization1 -Description 'kubernetes addon policy' -Name 'kubernetes_addon_policy1'