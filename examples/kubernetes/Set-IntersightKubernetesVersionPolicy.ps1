
#Get the KubernetesVersionPolicy to Update
$KubernetesVersionPolicy = Get-IntersightKubernetesVersionPolicy -Name KubernetesVersionPolicyName
$KubernetesVersionPolicy | Set-IntersightKubernetesVersionPolicy -Description 'Updated description'