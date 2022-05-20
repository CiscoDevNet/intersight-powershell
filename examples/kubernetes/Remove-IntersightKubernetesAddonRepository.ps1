
#Get the KubernetesAddonRepository to delete
$KubernetesAddonRepository = Get-IntersightKubernetesAddonRepository -Name KubernetesAddonRepositoryName
$KubernetesAddonRepository | Remove-IntersightKubernetesAddonRepository

#Remove the server profile by Moid.
Remove-IntersightKubernetesAddonRepository -Moid '<Replace with Moid>'
