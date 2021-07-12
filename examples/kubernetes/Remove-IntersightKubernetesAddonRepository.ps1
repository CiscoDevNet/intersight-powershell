
#Get the KubernetesAddonRepository to delete
$KubernetesAddonRepository = Remove-IntersightKubernetesAddonRepository -Name KubernetesAddonRepositoryName
$KubernetesAddonRepository | Remove-IntersightKubernetesAddonRepository

#Remove the server profile by Moid.
Remove-IntersightKubernetesAddonRepository -Moid 123bc2222287wee
