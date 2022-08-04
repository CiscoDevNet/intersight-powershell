
#Get the KubernetesVersion to Update
$KubernetesVersion = Get-IntersightKubernetesVersion -Name KubernetesVersionName
$KubernetesVersion | Set-IntersightKubernetesVersion -Description 'Updated description'