
#Get the KubernetesAciCniApic to Update
$KubernetesAciCniApic = Get-IntersightKubernetesAciCniApic -Name KubernetesAciCniApicName
$KubernetesAciCniApic | Set-IntersightKubernetesAciCniApic -Description 'Updated description'