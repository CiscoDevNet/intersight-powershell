
#Get the KubernetesAddonDefinition to Update
$KubernetesAddonDefinition = Get-IntersightKubernetesAddonDefinition -Name KubernetesAddonDefinitionName
$KubernetesAddonDefinition | Set-IntersightKubernetesAddonDefinition -Description 'Updated description'