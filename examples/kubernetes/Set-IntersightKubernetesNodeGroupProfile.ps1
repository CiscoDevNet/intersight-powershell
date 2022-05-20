
#Get the KubernetesNodeGroupProfile to Update
$KubernetesNodeGroupProfile = Get-IntersightKubernetesNodeGroupProfile -Name KubernetesNodeGroupProfileName
$KubernetesNodeGroupProfile | Set-IntersightKubernetesNodeGroupProfile -Description 'Updated description'