
#Get the KubernetesAddonDefinition to delete
$KubernetesAddonDefinition = Get-IntersightKubernetesAddonDefinition -Name KubernetesAddonDefinitionName
$KubernetesAddonDefinition | Remove-IntersightKubernetesAddonDefinition

#Remove the server profile by Moid.
Remove-IntersightKubernetesAddonDefinition -Moid '<Replace with Moid>'
