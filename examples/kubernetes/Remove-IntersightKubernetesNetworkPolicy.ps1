
#Get the KubernetesNetworkPolicy to delete
$KubernetesNetworkPolicy = Remove-IntersightKubernetesNetworkPolicy -Name KubernetesNetworkPolicyName
$KubernetesNetworkPolicy | Remove-IntersightKubernetesNetworkPolicy

#Remove the server profile by Moid.
Remove-IntersightKubernetesNetworkPolicy -Moid 123bc2222287wee
