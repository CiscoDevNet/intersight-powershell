
#Get the KubernetesNodeGroupProfile to delete
$KubernetesNodeGroupProfile = Remove-IntersightKubernetesNodeGroupProfile -Name KubernetesNodeGroupProfileName
$KubernetesNodeGroupProfile | Remove-IntersightKubernetesNodeGroupProfile

#Remove the server profile by Moid.
Remove-IntersightKubernetesNodeGroupProfile -Moid 123bc2222287wee
