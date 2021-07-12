
#Get the KubernetesClusterProfile to delete
$KubernetesClusterProfile = Remove-IntersightKubernetesClusterProfile -Name KubernetesClusterProfileName
$KubernetesClusterProfile | Remove-IntersightKubernetesClusterProfile

#Remove the server profile by Moid.
Remove-IntersightKubernetesClusterProfile -Moid 123bc2222287wee
