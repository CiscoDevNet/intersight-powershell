
#Get the KubernetesAddonRepository to Update
$KubernetesAddonRepository = Get-IntersightKubernetesAddonRepository -Name KubernetesAddonRepositoryName
$KubernetesAddonRepository | Set-IntersightKubernetesAddonRepository -Description 'Updated description'