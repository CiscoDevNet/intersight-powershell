
#Get the KubernetesNetworkPolicy to delete
$KubernetesNetworkPolicy = Get-IntersightKubernetesNetworkPolicy -Name KubernetesNetworkPolicyName
$KubernetesNetworkPolicy | Remove-IntersightKubernetesNetworkPolicy

#Remove the server profile by Moid.
Remove-IntersightKubernetesNetworkPolicy -Moid '<Replace with Moid>'
