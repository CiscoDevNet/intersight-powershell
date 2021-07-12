
#Get the KubernetesVersion to delete
$KubernetesVersion = Remove-IntersightKubernetesVersion -Name KubernetesVersionName
$KubernetesVersion | Remove-IntersightKubernetesVersion

#Remove the server profile by Moid.
Remove-IntersightKubernetesVersion -Moid 123bc2222287wee
