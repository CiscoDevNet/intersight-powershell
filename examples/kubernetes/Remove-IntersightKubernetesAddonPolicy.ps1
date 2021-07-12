
#Get the KubernetesAddonPolicy to delete
$KubernetesAddonPolicy = Remove-IntersightKubernetesAddonPolicy -Name KubernetesAddonPolicyName
$KubernetesAddonPolicy | Remove-IntersightKubernetesAddonPolicy

#Remove the server profile by Moid.
Remove-IntersightKubernetesAddonPolicy -Moid 123bc2222287wee
