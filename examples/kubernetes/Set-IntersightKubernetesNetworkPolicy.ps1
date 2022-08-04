
#Get the KubernetesNetworkPolicy to Update
$KubernetesNetworkPolicy = Get-IntersightKubernetesNetworkPolicy -Name KubernetesNetworkPolicyName
$KubernetesNetworkPolicy | Set-IntersightKubernetesNetworkPolicy -Description 'Updated description'