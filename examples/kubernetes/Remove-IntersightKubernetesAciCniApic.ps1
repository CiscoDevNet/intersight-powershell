
#Get the KubernetesAciCniApic to delete
$KubernetesAciCniApic = Remove-IntersightKubernetesAciCniApic -Name KubernetesAciCniApicName
$KubernetesAciCniApic | Remove-IntersightKubernetesAciCniApic

#Remove the server profile by Moid.
Remove-IntersightKubernetesAciCniApic -Moid 123bc2222287wee
