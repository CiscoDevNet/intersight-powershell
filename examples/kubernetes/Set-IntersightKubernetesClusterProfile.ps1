
#Get the KubernetesClusterProfile to Update
$KubernetesClusterProfile = Get-IntersightKubernetesClusterProfile -Name KubernetesClusterProfileName
$KubernetesClusterProfile | Set-IntersightKubernetesClusterProfile -Description 'Updated description'