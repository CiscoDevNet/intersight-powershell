
#Get the KubernetesAciCniApic to delete
$KubernetesAciCniApic = Get-IntersightKubernetesAciCniApic -Name KubernetesAciCniApicName
$KubernetesAciCniApic | Remove-IntersightKubernetesAciCniApic

#Remove the server profile by Moid.
Remove-IntersightKubernetesAciCniApic -Moid '<Replace with Moid>'
