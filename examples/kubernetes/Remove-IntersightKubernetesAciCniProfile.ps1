
#Get the KubernetesAciCniProfile to delete
$KubernetesAciCniProfile = Remove-IntersightKubernetesAciCniProfile -Name KubernetesAciCniProfileName
$KubernetesAciCniProfile | Remove-IntersightKubernetesAciCniProfile

#Remove the server profile by Moid.
Remove-IntersightKubernetesAciCniProfile -Moid 123bc2222287wee
