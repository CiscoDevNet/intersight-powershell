
#Get the KubernetesAddonDefinition to delete
$KubernetesAddonDefinition = Remove-IntersightKubernetesAddonDefinition -Name KubernetesAddonDefinitionName
$KubernetesAddonDefinition | Remove-IntersightKubernetesAddonDefinition

#Remove the server profile by Moid.
Remove-IntersightKubernetesAddonDefinition -Moid 123bc2222287wee
