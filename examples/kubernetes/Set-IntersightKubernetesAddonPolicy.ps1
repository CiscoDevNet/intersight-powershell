
#Get the KubernetesAddonPolicy to Update
$KubernetesAddonPolicy = Get-IntersightKubernetesAddonPolicy -Name KubernetesAddonPolicyName
$KubernetesAddonPolicy | Set-IntersightKubernetesAddonPolicy -Description 'Updated description'