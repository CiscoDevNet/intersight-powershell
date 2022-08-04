
#Get the KubernetesAddonPolicy to delete
$KubernetesAddonPolicy = Get-IntersightKubernetesAddonPolicy -Name KubernetesAddonPolicyName
$KubernetesAddonPolicy | Remove-IntersightKubernetesAddonPolicy

#Remove the server profile by Moid.
Remove-IntersightKubernetesAddonPolicy -Moid '<Replace with Moid>'
