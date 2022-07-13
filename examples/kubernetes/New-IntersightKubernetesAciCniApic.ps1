$organization1 = Get-IntersightOrganizationOrganization -Name 'default'

$registered_device1 = Get-IntersightAssetDeviceregistrations -Moid '<Replace with Moid>'

$kubernetes_aci_cni_apic1 = New-IntersightKubernetesAciCniApic -Organization $organization1 -RegisteredDevice $registered_device1 -NumAciCniProfiles 3