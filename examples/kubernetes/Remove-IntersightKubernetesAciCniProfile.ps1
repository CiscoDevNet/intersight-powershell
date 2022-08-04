
#Get the KubernetesAciCniProfile to delete
$KubernetesAciCniProfile = Get-IntersightKubernetesAciCniProfile -Name KubernetesAciCniProfileName
$KubernetesAciCniProfile | Remove-IntersightKubernetesAciCniProfile

#Remove the server profile by Moid.
Remove-IntersightKubernetesAciCniProfile -Moid '<Replace with Moid>'
