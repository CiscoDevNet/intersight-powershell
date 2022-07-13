$organization1 = Get-IntersightOrganizationOrganization -Name 'default'

$registered_device1 = Get-IntersightAssetDeviceregistrations -Moid '<Replace with Moid>'

$kubernetes_aci_cni_profile1 = New-IntersightKubernetesAciCniProfile -Organization $organization1 -RegisteredDevice $registered_device1 -Description 'kubernetes aci cni profile' -Name 'kubernetes_aci_cni_profile1' -Type Instance -NodeSvcSubnetStart '10.0.0.0/8' -PodSubnetStart '10.0.0.0/8'